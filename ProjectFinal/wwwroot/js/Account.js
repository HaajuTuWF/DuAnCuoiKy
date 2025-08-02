// register.js

document.addEventListener("DOMContentLoaded", function () {
    const form = document.querySelector(".register-form");
    const password = document.getElementById("Password");
    const confirmPassword = document.getElementById("ConfirmPassword");

    // Helper: show inline error
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

    // Show success notification
    function showSuccessAndRedirect() {
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
            <div style="font-size:1.25rem; color:#2d3436; margin-bottom:8px;">Đăng ký thành công!</div>
            <div style="font-size:1rem; color:#636e72;">Bạn sẽ được chuyển về trang chủ trong giây lát...</div>
        `;
        document.body.appendChild(box);

        setTimeout(() => {
            window.location.href = "/";
        }, 1800);
    }

    // Form submit event
    form.addEventListener("submit", function (e) {
        let valid = true;

        // Username validation
        const username = document.getElementById("Username");
        clearError(username);
        if (!username.value.trim()) {
            showError(username, "Tên đăng nhập không được để trống.");
            valid = false;
        } else if (username.value.length < 4) {
            showError(username, "Tên đăng nhập phải có ít nhất 4 ký tự.");
            valid = false;
        }

        // Email validation
        const email = document.getElementById("Email");
        clearError(email);
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (!email.value.trim()) {
            showError(email, "Email không được để trống.");
            valid = false;
        } else if (!emailRegex.test(email.value)) {
            showError(email, "Email không hợp lệ.");
            valid = false;
        }

        // Password validation
        clearError(password);
        if (!password.value) {
            showError(password, "Mật khẩu không được để trống.");
            valid = false;
        } else if (password.value.length < 6) {
            showError(password, "Mật khẩu phải có ít nhất 6 ký tự.");
            valid = false;
        }

        // Confirm password validation
        clearError(confirmPassword);
        if (!confirmPassword.value) {
            showError(confirmPassword, "Vui lòng xác nhận mật khẩu.");
            valid = false;
        } else if (confirmPassword.value !== password.value) {
            showError(confirmPassword, "Mật khẩu xác nhận không khớp.");
            valid = false;
        }

        if (!valid) {
            e.preventDefault();
        } else {
            // Prevent default form submission to show success notification
            e.preventDefault();

            showSuccessAndRedirect();
        }
    });

    // Realtime password match check
    confirmPassword.addEventListener("input", function () {
        clearError(confirmPassword);
        if (confirmPassword.value && confirmPassword.value !== password.value) {
            showError(confirmPassword, "Mật khẩu xác nhận không khớp.");
        }
    });

    // Clear error on input
    ["Username", "Email", "Password"].forEach(function (id) {
        document.getElementById(id).addEventListener("input", function (e) {
            clearError(e.target);
        });
    });
});