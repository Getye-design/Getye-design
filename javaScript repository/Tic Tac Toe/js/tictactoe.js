// Variable to keep track of whose turn it is
let activePlayer = 'x';

// Array to store moves - use this to determine win conditions
let selectedSquares = [];

// Function to place x or o in a square
function placeXorO(squareNumber) {
    // Checks if the square has been selected already
    if (!selectedSquares.some(element => element.includes(squareNumber))) {
        // Variable to hold the HTML element that was clicked
        let select = document.getElementById(squareNumber);
        // Determines the active player and places the icon
        if (activePlayer === 'x') {
            select.style.backgroundImage = 'url("./images/circle.png")';
        } else {
            select.style.backgroundImage = 'url("./images/square.png")';
        }
        // Adds the square number and player to the array
        selectedSquares.push(squareNumber + activePlayer);
        // Calls the function to check for a win
        checkWinConditions();
        // Changes the active player
        if (activePlayer === 'x') {
            activePlayer = 'o';
        } else {
            activePlayer = 'x';
        }
        // Function to play the placement sound
        audio('./media/wood.mp3');
        // Checks if it is the computer's turn
        if (activePlayer === 'o') {
            disableClick();
            setTimeout(function () {
                computersTurn();
            }, 1000);
        }
    // Returning true is needed for the computersTurn() function
    return true;
}

// Picks a random square for the computer's turn
function computersTurn() {
    let success = false;
    let pickASquare;
    while (!success) {
        pickASquare = String(Math.floor(Math.random() * 9));
        if (placeXorO(pickASquare)) {
            placeXorO(pickASquare);
            success = true;
        };
    }
}
}

//This function parses the selectedSquarees array to search for win conditions.
    //drawLine() function is called to draw a line on the screen if the condition is met.
    function checkWinConditions() {
        if (arrayIncludes("0x", "1x", "2x")) { drawWinLine(50, 100, 558, 100); }
        else if (arrayIncludes("3x", "4x", "5x")) { drawWinLine(50, 304, 558, 304); }
        else if (arrayIncludes("6x", "7x", "8x")) { drawWinLine(50, 508, 558, 508); }
        else if (arrayIncludes("0x", "3x", "6x")) { drawWinLine(100, 50, 100, 558); }
        else if (arrayIncludes("1x", "4x", "7x")) { drawWinLine(304, 50, 304, 558); }
        else if (arrayIncludes("2x", "5x", "8x")) { drawWinLine(508, 50, 508, 558); }
        else if (arrayIncludes("6x", "4x", "2x")) { drawWinLine(100, 508, 510, 90); }
        else if (arrayIncludes("0x", "4x", "8X")) { drawWinLine(100, 100, 520, 520); }
        else if (arrayIncludes("0o", "1o", "2o")) { drawWinLine(50, 100, 558, 100); }
        else if (arrayIncludes("3o", "4o", "5o")) { drawWinLine(50, 304, 558, 304); }
        else if (arrayIncludes("6o", "7o", "8o")) { drawWinLine(50, 508, 558, 508); }
        else if (arrayIncludes("0o", "3o", "6o")) { drawWinLine(100, 50, 100, 558); }
        else if (arrayIncludes("1o", "4o", "7o")) { drawWinLine(304, 50, 304, 558); }
        else if (arrayIncludes("2o", "5o", "8o")) { drawWinLine(508, 50, 508, 558); }
        else if (arrayIncludes("6o", "4o", "2o")) { drawWinLine(100, 508, 510, 90); }
        else if (arrayIncludes("0o", "4o", "8o")) { drawWinLine(100, 100, 520, 520); }
        // Checks for a tie - if no win conditions are met and 9 squares have been selected
        else if (selectedSquares.length >= 9) {
            // Plays the tie sound
            audio('./media/paper.mp3');
            // Resets the game after a tie
            setTimeout(function () { resetGame(); }, 500);
        }
    

         //This function checks if an array includes 3 strings.It is used to check for 
         //each win condition.
// This function checks for each win condition
function arrayIncludes(squareA, squareB, squareC) {
    const a = selectedSquares.includes(squareA);
    const b = selectedSquares.includes(squareB);
    const c = selectedSquares.includes(squareC);
    if (a === true && b === true && c === true) { 
        return true; 
    }
}
    }

// Clears the board and the array to restart the game
function resetGame() {
    for (let i = 0; i < 9; i++) {
        let square = document.getElementById(String(i));
        square.style.backgroundImage = '';
    }
    selectedSquares = [];
}

// Plays the audio files
function audio(audioURL) {
    let audio = new Audio(audioURL);
    audio.play();
}

// Function to draw the line across winning coordinates
function drawWinLine(coordX1, coordY1, coordX2, coordY2) {
    const canvas = document.getElementById('win-lines');
    const c = canvas.getContext('2d');
    let x1 = coordX1,
        y1 = coordY1,
        x2 = coordX2,
        y2 = coordY2,
        x = x1,
        y = y1;

    // Additional implementation for drawing lines might be here...


function animateLineDrawing() {
    const animationLoop = requestAnimationFrame(animateLineDrawing);
    c.clearRect(0, 0, 608, 608);
    c.beginPath();
    c.moveTo(x1, y1);
    c.lineTo(x, y);
    c.lineWidth = 10;
    c.strokeStyle = 'rgba(70, 255, 33, .8)';
    c.stroke();
    
    if (x1 <= x2 && y1 <= y2) {
        if (x < x2) { x += 10; }
        if (y < y2) { y += 10; }
        if (x >= x2 && y >= y2) { 
            cancelAnimationFrame(animationLoop); 
        }
    }
    if (x1 <= x2 && y1 >= y2) {
        if (x < x2) { x += 10; }
        if (y > y2) { y -= 10; }
        if (x >= x2 && y <= y2) { 
            cancelAnimationFrame(animationLoop); 
        }
    }
}

// Clears the board after the animation
function clear() {
    const animationLoop = requestAnimationFrame(clear);
    c.clearRect(0, 0, 608, 608);
    cancelAnimationFrame(animationLoop);
}
    
    disableClick();
    audio('./media/swish.mp3');
    animateLineDrawing();
    setTimeout(function () { clear();resetGame(); }, 1000);
}

// Disables click during the computer's turn
function disableClick() {
    body.style.pointerEvents = 'none';
    setTimeout(function () { 
        body.style.pointerEvents = 'auto'; 
    }, 1000);
}
