document.addEventListener("DOMContentLoaded", function () {
    let box = document.getElementById("animated-box");
    let position = 0;
    let direction = 1;

    function animate() {
        position += direction * 2;
        box.style.transform = `translateX(${position}px)`;

        if (position > 200 || position < 0) {
            direction *= -1;
        }

        requestAnimationFrame(animate);
    }

    animate();
});
