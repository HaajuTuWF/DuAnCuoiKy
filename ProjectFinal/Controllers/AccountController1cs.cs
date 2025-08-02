using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectFinal.Models;

public class AccountController : Controller
{
    private readonly DuAnWebContext _context;

    public AccountController(DuAnWebContext context)
    {
        _context = context;
    }

    [HttpPost]
    public JsonResult Register([FromBody] RegisterModel model)
    {
        if (_context.Users.Any(u => u.Username == model.Username))
        {
            return Json(new { success = false, message = "Tên đăng nhập đã tồn tại" });
        }

        var user = new User
        {
            Username = model.Username,
            Password = model.Password // ❗Bạn nên mã hóa mật khẩu thực tế
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return Json(new { success = true });
    }
}
