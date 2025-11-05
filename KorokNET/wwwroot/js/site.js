// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    let currentSlide = 0;
    let slides = $('.slides img');
    let totalSlides = slides.length;

    $(slides[currentSlide]).fadeIn();

    function showSlide(currentSlideIndex) {
        if (currentSlideIndex >= totalSlides || currentSlideIndex < 0) {
            return false;
        }
        slides.fadeOut(); // скрываем все изображения
        $(slides[currentSlideIndex]).fadeIn(); // показываем нужное изображение
        currentSlide = currentSlideIndex;
    }

    // Задаём интервал для переключения слайдов в каждые 3 секунды
    let slideInterval = setInterval(nextSlideAuto, 3000);

    // Обработчики кликов на кнопки
    $('.previous').click(() => {
        showSlide((currentSlide + totalSlides - 1) % totalSlides);
    })

    $('.next').click(() => {
        showSlide((currentSlide + 1) % totalSlides);
    })

    function nextSlideAuto() {
        showSlide((currentSlide + 1) % totalSlides);
    }
});