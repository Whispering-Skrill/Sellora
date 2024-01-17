let slidePosition = 0;
const slides = document.getElementsByClassName('ad');
const totalSlides = 3;

function updateSlidePosition() {
    for (let slide of slides) {
        slide.classList.remove('ad--visible')
        slide.classList.add('ad--hidden');
    }

    slides[slidePosition].classList.add('ad--visible');
}

function moveToNextSlide() {
    if (slidePosition === totalSlides - 1) {
        slidePosition = 0;
    } else {
        slidePosition++;
    }
    console.log(slidePosition);
    console.log(totalSlides);
    updateSlidePosition();
}

function moveToPrevSlide() {
    if (slidePosition === 0) {
        slidePosition = totalSlides - 1;
    } else {
        slidePosition--;
    }

    updateSlidePosition();
}