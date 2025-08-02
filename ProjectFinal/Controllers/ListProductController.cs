using System.Diagnostics;
using ProjectFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProjectFinal.Controllers
{
    public class ListProductController : Controller
    {
        private readonly DuAnWebContext _context;
        public ListProductController(DuAnWebContext context)
        {
            _context = context;
        }
        public ActionResult Phone()
        {
            var danhSachPhone = _context.Phone.ToList(); // Lấy tất cả sản phẩm
            return View(danhSachPhone);
        }
        public ActionResult Laptop()
        {
            var danhSachLTA = _context.LapTopAll.ToList(); // Lấy tất cả sản phẩm
            return View(danhSachLTA);
        }
        public ActionResult Accessory()
        {
            var danhSachSanPham = _context.PhuKien.ToList(); // Lấy tất cả sản phẩm
            return View(danhSachSanPham);
        }
        public ActionResult PC()
        {
            var danhSachPC = _context.PC.ToList(); // Lấy tất cả sản phẩm
            return View(danhSachPC);
        }
        public ActionResult OldDevice()
        {
            return View();
        }
        public ActionResult SimCard()
        {
            return View();
        }
    }
}
