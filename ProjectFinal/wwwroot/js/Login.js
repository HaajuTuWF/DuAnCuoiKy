document.addEventListener("DOMContentLoaded", function () {
    const form = document.querySelector(".login-form");
    const username = document.getElementById("Username");
    const password = document.getElementById("Password");

    function showError(input, message) {
        let error = input.nextElementSibling;
        if (!error || !error.classList.contains("input-error-message")) {
            error = document.createElement("div");
            error.className = "input-error-message";
            error.style.color = "#d63031";
            error.style.fontSize = "0.95rem";
            error.style.marginTop = "-12px";
            error.style.marginBottom = "14px";
            input.insertAdjacentElement("afterend", error);
        }
        error.textContent = message;
    }

    function clearError(input) {
        let error = input.nextElementSibling;
        if (error && error.classList.contains("input-error-message")) {
            error.remove();
        }
    }

    function showSuccessAndRedirect(usernameValue) {
        // Lưu username vào localStorage
        localStorage.setItem('username', usernameValue);

        // Create overlay
        const overlay = document.createElement("div");
        overlay.style.position = "fixed";
        overlay.style.top = "0";
        overlay.style.left = "0";
        overlay.style.width = "100vw";
        overlay.style.height = "100vh";
        overlay.style.background = "rgba(0,0,0,0.13)";
        overlay.style.zIndex = "9998";
        document.body.appendChild(overlay);

        // Create notification box
        const box = document.createElement("div");
        box.style.position = "fixed";
        box.style.top = "50%";
        box.style.left = "50%";
        box.style.transform = "translate(-50%, -50%)";
        box.style.background = "#fff";
        box.style.boxShadow = "0 2px 14px rgba(0,0,0,0.17)";
        box.style.borderRadius = "8px";
        box.style.padding = "36px 42px";
        box.style.zIndex = "9999";
        box.style.textAlign = "center";

        box.innerHTML = `
            <div style="font-size:2.1rem; color:#00b894; margin-bottom:18px;">&#10003;</div>
            <div style="font-size:1.25rem; color:#2d3436; margin-bottom:8px;">Đăng nhập thành công!</div>
            <div style="font-size:1rem; color:#636e72;">Bạn sẽ được chuyển về trang chủ trong giây lát...</div>
        `;
        document.body.appendChild(box);

        setTimeout(() => {
            window.location.href = "/";
        }, 1500);
    }

    form.addEventListener("submit", function (e) {
        e.preventDefault();
        let valid = true;

        clearError(username);
        if (!username.value.trim()) {
            showError(username, "Tên đăng nhập không được để trống.");
            valid = false;
        }

        clearError(password);
        if (!password.value) {
            showError(password, "Mật khẩu không được để trống.");
            valid = false;
        } else if (password.value.length < 6) {
            showError(password, "Mật khẩu phải có ít nhất 6 ký tự.");
            valid = false;
        }

        if (!valid) {
            return;
        }

        // Gửi dữ liệu bằng fetch tới API
        fetch('/api/account/login', {
            method: 'POST',
            headers: {
                'Accept': 'application/json'
            },
            body: new URLSearchParams({
                Username: username.value,
                Password: password.value
            })
        })
            .then(response => response.json())
            .then(data => {
                if (data.success) {
                    showSuccessAndRedirect(data.username);
                } else {
                    showError(password, data.message || "Đăng nhập thất bại!");
                }
            })
            .catch(err => {
                showError(password, "Đã xảy ra lỗi kết nối server!");
            });
    });

    [username, password].forEach(function (input) {
        input.addEventListener("input", function () {
            clearError(input);
        });
    });
});