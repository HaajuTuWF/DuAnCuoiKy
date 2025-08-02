function searchProduct() {
    const keyword = document.getElementById("searchInput").value.trim();

    if (!keyword) {
        alert("Vui lòng nhập tên sản phẩm.");
        return;
    }

    fetch(`/SanPham/Search?term=${encodeURIComponent(keyword)}`)
        .then(res => res.json())
        .then(data => {
            if (data.success) {
                window.location.href = data.redirectUrl;
            } else {
                alert("Không tìm thấy sản phẩm.");
            }
        })
        .catch(err => {
            console.error("Lỗi khi tìm kiếm:", err);
        });
}