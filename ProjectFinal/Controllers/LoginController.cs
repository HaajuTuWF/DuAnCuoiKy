using Microsoft.AspNetCore.Mvc;
using ProjectFinal.Models;
using System;

public class LoginController : Controller
{
    private readonly DuAnWebContext _context;

    public LoginController(DuAnWebContext context)
    {
        _context = context;
    }

    [HttpPost]
    public JsonResult CheckLogin([FromBody] LoginViewModel model)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
        if (user != null)
        {
            return Json(new { success = true });
        }
        return Json(new { success = false, message = "Sai tên đăng nhập hoặc mật khẩu." });
    }
}
