using Microsoft.AspNetCore.Mvc;
using ProjectFinal.Models;

namespace ProjectFinal.Controllers
{
    public class PhoneController : Controller
    {
        private readonly DuAnWebContext _context;

        public PhoneController(DuAnWebContext context)
        {
            _context = context;
        }
        public IActionResult SIphone()
        {
            var sp = _context.SanPham.FirstOrDefault(x => x.TenSp.ToLower().Contains("iphone 15 pro max"));
            if (sp == null) return NotFound();

            return View("Iphone", sp);
        }
        public IActionResult Iphone()
        {
            var anhIp = _context.AnhIp.FirstOrDefault();
            var moTaIp = _context.MoTaIp.FirstOrDefault();
            var phone = _context.Phone.FirstOrDefault();

            var viewModel = new ipViewModel
            {
                Anh = anhIp,
                MoTa = moTaIp,
                Phone = phone
            };

            return View(viewModel);
        }
    }
}
