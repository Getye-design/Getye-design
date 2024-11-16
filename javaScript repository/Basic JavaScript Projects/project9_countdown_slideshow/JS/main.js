// Countdown timer function
function countdown() {
    // Gets the input from the user
    var seconds = document.getElementById("seconds").value;

    // Function to perform the countdown
    function tick() {
        seconds = seconds - 1; // Decrease the seconds by 1
        timer.innerHTML = seconds; // Display the updated seconds

        // If seconds remain, keep counting down
        if (seconds > 0) {
            setTimeout(tick, 1000); // Call tick() after 1 second
        } else {
            alert("Time's up!"); // Display an alert when countdown ends
        }
    }

    tick(); // Start the countdown
}
// Image slideshow functions
let slideIndex = 1; // Initialize slide index
showSlides(slideIndex); // Display the first slide

// Next/previous controls
function plusSlides(n) {
    showSlides(slideIndex += n); // Increment or decrement slideIndex
}

// Thumbnail image controls
function currentSlide(n) {
    showSlides(slideIndex = n); // Set slideIndex to the selected slide
}

function showSlides(n) {
    let i;
    let slides = document.getElementsByClassName("mySlides"); // Get all slides
    let dots = document.getElementsByClassName("dot"); // Get all dots

    // If the current slide index exceeds the total slides, go to the first slide
    if (n > slides.length) {
        slideIndex = 1;
    }

    // If the current slide index is less than 1, go to the last slide
    if (n < 1) {
        slideIndex = slides.length;
    }

    // Hide all slides
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }

    // Remove "active" class from all dots
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }

    // Show the current slide and set the corresponding dot as active
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}