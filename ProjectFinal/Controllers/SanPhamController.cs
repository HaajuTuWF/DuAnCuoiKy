using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ProjectFinal.Models;
using System.Collections.Generic;
using System.Linq;

public class SanPhamController : Controller
{
    private readonly DuAnWebContext _context;

    public SanPhamController(DuAnWebContext context)
    {
        _context = context;
    }

    public JsonResult Search(string term)
    {
        if (string.IsNullOrWhiteSpace(term))
            return Json(new { success = false });

        // Dictionary so sánh không phân biệt hoa thường
        var productMap = new Dictionary<string, (string action, string controller)>(StringComparer.OrdinalIgnoreCase)
    {
        { "acer aspire 7", ("AcerAspire7GM", "Acer") },
        { "acer aspire 7 gaming", ("AcerAspire7GM", "Acer") },
        { "iphone", ("Iphone", "Phone") },
        { "iphone 15", ("Iphone", "Phone") },
        { "iphone 15 pro max", ("Iphone", "Phone") },
        { "iphone 15 pro max 256gb", ("Iphone", "Phone") },
    };

        var input = term.Trim();

        // So khớp chính xác (đã bỏ fuzzy search)
        if (productMap.TryGetValue(input, out var route))
        {
            var redirectUrl = Url.Action(route.action, route.controller);
            return Json(new { success = true, redirectUrl });
        }

        return Json(new { success = false });
    }
}
