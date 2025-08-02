using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectFinal.Models;

namespace ProjectFinal.Controllers
{
    public class LapTopController : Controller
    {
        private readonly DuAnWebContext _context;
        public LapTopController(DuAnWebContext context)
        {
            _context = context;
        }
        public IActionResult Acer()
        {
            var danhSachSanPham = _context.LapTop.ToList();
            return View(danhSachSanPham);
        }
        public IActionResult Asus()
        {
            return View();
        }
        public IActionResult MSi()
        {
            return View();
        }
        public IActionResult Macbook()
        {
            return View();
        }
        public IActionResult Lenovo()
        {
            return View();
        }
        public IActionResult Dell()
        {
            return View();
        }
    }
}
