using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectFinal.Models; // chứa ApplicationDbContext & MoTaAcer

namespace ProjectFinal.Controllers
{
    public class AcerController : Controller
    {
        private readonly DuAnWebContext _context;

        public AcerController(DuAnWebContext context)
        {
            _context = context;
        }
        // Chi tiết mô tả sản phẩm Acer Aspire 7 GM (ID = 1 chẳng hạn)
        public IActionResult AcerAspire7GM()
        {
            var sanPham = _context.SanPham.FirstOrDefault();
            var moTa = _context.MoTaAcer.FirstOrDefault();
            var anh = _context.AnhAcerAP7.FirstOrDefault();

            var viewModel = new AcerViewModel
            {
                SanPham = sanPham,
                MoTa = moTa,
                Anh = anh
            };

            return View(viewModel);
        }
        public IActionResult SAcerAspire7GM()
        {
            var sp = _context.SanPham.FirstOrDefault(x => x.TenSp.ToLower().Contains("acer aspire 7"));
            if (sp == null) return NotFound();

            return View("AcerAspire7GM", sp);
        }
        public IActionResult AcerNitro5()
        {
            return View();
        }
        public IActionResult Acer()
        {
            var danhSachSanPham = _context.SanPham.ToList(); // Lấy tất cả sản phẩm
            return View(danhSachSanPham);
        }
    }
}
