using Microsoft.AspNetCore.Mvc;
using ProjectFinal.Models;
using System;

public class RegisterController : Controller
{
    private readonly DuAnWebContext _context;

    public RegisterController(DuAnWebContext context)
    {
        _context = context;
    }

    [HttpPost]
    public JsonResult Register([FromBody] RegisterModel model)
    {
        if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
        {
            return Json(new { success = false, message = "Dữ liệu không hợp lệ" });
        }

        using (var db = new DuAnWebContext())
        {
            var existingUser = db.Users.FirstOrDefault(u => u.Username == model.Username);
            if (existingUser != null)
            {
                return Json(new { success = false, message = "Tên đăng nhập đã tồn tại" });
            }

            db.Users.Add(new User
            {
                Username = model.Username,
                Password = model.Password // Nên mã hóa mật khẩu trong thực tế
            });
            db.SaveChanges();

            return Json(new { success = true });
        }
    }

}
