const sliders = {
    1: { currentIndex: 0, slides: document.querySelectorAll('#slider1 .slide') },
    2: { currentIndex: 0, slides: document.querySelectorAll('#slider2 .slide') }
};

function showSlide(sliderId, index) {
    const slider = sliders[sliderId];
    const totalSlides = slider.slides.length;

    if (index >= totalSlides) slider.currentIndex = 0;
    else if (index < 0) slider.currentIndex = totalSlides - 1;
    else slider.currentIndex = index;

    slider.slides.forEach((slide, i) => {
        slide.classList.toggle('active', i === slider.currentIndex);
    });
}

function changeSlide(sliderId, direction) {
    showSlide(sliderId, sliders[sliderId].currentIndex + direction);
}

showSlide(1, 0);
showSlide(2, 0);

setInterval(() => changeSlide(1, 1), 3000);
setInterval(() => changeSlide(2, 1), 4000);