document.querySelector('.qa-btn-fixed').addEventListener('click', function () {
    const input = document.querySelector('.qa-input-fixed');
 // Tạo phần tử thông báo
    const notification = document.createElement('div');
    notification.className = 'custom-notification';
    // Base CSS cho thông báo
    const baseStyles = `
        position: fixed;
        bottom: 20px;
        right: 20px;
        padding: 15px 20px;
        border-radius: 5px;
        box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        transform: translateY(100%);
        transition: transform 0.3s ease-in-out, opacity 0.3s ease-in-out;
        opacity: 0;
        z-index: 1000;
    `;
    // Kiểm tra input không có ký tự
    if (input.value.trim() === '') {
        // Thông báo thất bại
        notification.style.cssText = `
            ${baseStyles}
            background-color: #f44336;
            color: white;
        `;
        notification.textContent = 'Vui lòng nhập nội dung';
    } else {
        // Thông báo thành công
        notification.style.cssText = `
            ${baseStyles}
            background-color: #4CAF50;
            color: white;
        `;
        notification.textContent = 'Gửi thành công';
        input.value = ''; // Xóa dữ liệu trong input chỉ khi gửi thành công
    }
    // Thêm thông báo vào body
    document.body.appendChild(notification);
    // Kích hoạt animation hiển thị
    setTimeout(() => {
        notification.style.transform = 'translateY(0)';
        notification.style.opacity = '1';
    }, 10);
    // Xóa thông báo sau 2 giây
    setTimeout(() => {
        notification.style.transform = 'translateY(100%)';
        notification.style.opacity = '0';
        setTimeout(() => {
            if (notification.parentNode) {
                document.body.removeChild(notification);
            }
        }, 300);
    }, 2000);
});