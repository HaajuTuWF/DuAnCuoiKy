using Microsoft.AspNetCore.Mvc;
using ProjectFinal.Models;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DuAnWebContext _context;

        // Constructor thêm context
        public HomeController(ILogger<HomeController> logger, DuAnWebContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Trang chủ: Lấy sản phẩm từ DB
        public IActionResult Index()
        {
            var danhSachSp = _context.SanPham.ToList();
            var danhSachLaptop = _context.LapTop.ToList();
            var danhSachPhukien = _context.PhuKien.ToList();
            var danhSachPhone = _context.Phone.ToList();
            var danhSachLTA = _context.LapTopAll.ToList();
            var danhSachPc = _context.PC.ToList();

            var viewModel = new IndexView
            {
                SanPham = danhSachSp,
                LapTop = danhSachLaptop,
                PhuKien = danhSachPhukien,
                Phone = danhSachPhone,
                LapTopAll = danhSachLTA,
                PC = danhSachPc
            };

            return View(viewModel);
        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DK()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
