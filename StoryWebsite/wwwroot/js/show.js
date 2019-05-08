const slides = document.querySelectorAll('.slide');
const totalNum = slides.length; 
const next = document.querySelector('#next');
const prev = document.querySelector('#prev');
const play = document.querySelector('#play');
const slideNum = document.querySelector(".menubar p");
let auto = false; // Auto scroll
const intervalTime = 4000;
let slideInterval;

//Initialize slide
slides[0].classList.add('current');
let curSlideNum = 1; 

const updateSlideNum = () => {
    slideNum.innerText = curSlideNum + " / " + totalNum;
};

const nextSlide = () => {
    const current = document.querySelector('.current');
    current.classList.remove('current');
    // Check for next slide
    if (current.nextElementSibling) {
        current.nextElementSibling.classList.add('current');
        curSlideNum++;
    } else {
        slides[0].classList.add('current');
        curSlideNum = 1;
    }
    updateSlideNum();
    if (auto) {
        clearInterval(slideInterval);
        slideInterval = setInterval(nextSlide, intervalTime);
    }
};

const prevSlide = () => {
    const current = document.querySelector('.current');
    current.classList.remove('current');
    // Check for prev slide
    if (current.previousElementSibling) {
        current.previousElementSibling.classList.add('current');
        curSlideNum--;
    } else {
        slides[slides.length - 1].classList.add('current');
        curSlideNum = totalNum;
    }
    updateSlideNum();
    if (auto) {
        clearInterval(slideInterval);
        slideInterval = setInterval(nextSlide, intervalTime);
    }
};

// Button events
next.addEventListener('click', e => {
    nextSlide();
});

prev.addEventListener('click', e => {
    prevSlide();
});

play.addEventListener('click', e => {
    auto = !auto;
    if (auto) {
        play.innerHTML = "<i class='fas fa-pause'></i>";
        // Run next slide at interval time
        slideInterval = setInterval(nextSlide, intervalTime);
    } else {
        play.innerHTML = "<i class='fas fa-play'></i>";
        clearInterval(slideInterval);
    }
});

updateSlideNum();

document.addEventListener('keydown', function (event) {
    switch (event.key) {
        case "ArrowLeft":
            // Left pressed
            prevSlide();
            break;
        case "ArrowRight":
            // Right pressed
            nextSlide();
            break;
    }
});

