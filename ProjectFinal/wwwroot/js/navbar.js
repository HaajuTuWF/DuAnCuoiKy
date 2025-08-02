window.addEventListener('scroll', function () {
    const navbar = document.querySelector('.navbar');
    if (window.scrollY > 50) {
        navbar.classList.add('shrink');
    } else {
        navbar.classList.remove('shrink');
    }
});
//JS HTKH//
document.addEventListener("DOMContentLoaded", function () {
    var username = localStorage.getItem('username');
    if (username) {
        var navbarAccount = document.getElementById('navbarAccount');
        if (navbarAccount) {
            navbarAccount.innerHTML = `<i class="fa fa-user"></i> ${username}`;
        }
    }
});