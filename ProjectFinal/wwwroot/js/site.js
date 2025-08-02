// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    function addToCart(productId) {
        fetch('/Cart/AddToCart', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'RequestVerificationToken': document.querySelector('input[name="__RequestVerificationToken"]').value
            },
            body: JSON.stringify({ productId })
        })
            .then(res => {
                if (res.ok) alert("✅ Đã thêm vào giỏ hàng!");
                else alert("❌ Lỗi thêm sản phẩm!");
            });
    }
