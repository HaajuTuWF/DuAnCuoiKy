using Microsoft.AspNetCore.Mvc;
using ProjectFinal.Models;

public class CartController : Controller
{
    private readonly DuAnWebContext _context;

    public CartController(DuAnWebContext context)
    {
        _context = context;
    }

    [HttpPost]
    public JsonResult AddToCart([FromBody] int id)
    {
        var product = _context.SanPham.FirstOrDefault(x => x.ID == id);
        if (product == null)
            return Json(new { success = false });

        var cartItem = new Cart
        {
            TenSp = product.TenSp,
            GiaSp = product.GiaSp,
            LinkAnh = product.LinkAnh
        };

        _context.Cart.Add(cartItem);
        _context.SaveChanges();

        // Trả về thêm giá để hiển thị subtotal
        return Json(new { success = true, price = product.GiaSp });
    }


    // Xem giỏ hàng (từ SQL)
    public IActionResult Cart()
    {
        var carts = _context.Cart.ToList();
        return View(carts);
    }

    // Xóa sản phẩm khỏi giỏ
    public IActionResult RemoveFromCart(int id)
    {
        var item = _context.Cart.FirstOrDefault(c => c.ID == id);
        if (item != null)
        {
            _context.Cart.Remove(item);
            _context.SaveChanges();
        }

        return RedirectToAction("Cart");
    }
}
