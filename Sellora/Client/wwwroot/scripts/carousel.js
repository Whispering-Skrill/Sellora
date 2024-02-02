// Initial position of the slide in the carousel
let slidePosition = 0;

// Collection of slides retrieved by class name 'ad'
const slides = document.getElementsByClassName('ad');

// Total number of slides in the carousel (Change accordingly)
const totalSlides = 3;

// Function to update the visibility of slides based on the current active slide
function updateSlidePosition() {

    // This loops through all slides and hides the required slides
    for (let slide of slides) {
        slide.classList.remove('ad--visible')
        slide.classList.add('ad--hidden');
    }

    // This displays the slides in the current active position
    slides[slidePosition].classList.add('ad--visible');
}

// Function to shift the current active slide to the next
function moveToNextSlide() {

    // This checks if the current slide is the last in the Collection
    // If current active slide is last slide, next slide = first slide
    if (slidePosition === totalSlides - 1) {
        slidePosition = 0;
    } else {
        // Updates SlidePosition
        slidePosition++;
    }
    updateSlidePosition();
}

// Function to shift the current active slide to the previous
function moveToPrevSlide() {

    // This checks if the current slide is the first in the Collection
    // If current active slide is first slide, next slide = last slide
    if (slidePosition === 0) {
        slidePosition = totalSlides - 1;
    } else {
        // Updates SlidePosition
        slidePosition--;
    }
    updateSlidePosition();
}