
function addition() {
    var add = 5 + 3; // Example addition operation
    document.getElementById("Add").innerHTML = "5 + 3 = " + add;
}

function subtraction(){ 
    var sub = 10 - 4; // Example subtraction operation
    document.getElementById("Sub").innerHTML = "10 - 4 = " + sub;
}


function multiplication() {
     mult = 6 * 7; 
    document.getElementById("Mlt").innerHTML = "6 * 7 = " + mult;
}

function division() {
    var divide = 42 / 6; 
    document.getElementById("Div").innerHTML = "42 / 6 = " + divide;
}


function random() {
    var random = 42 / 6; 
    document.getElementById("Ran").innerHTML = Math.random() * 10;
}


function modulus_oprator() {
    var modulus =25 % 6;
    document.getElementById('Mod').innerHTML  = 
    "when you divide 25 by 6 you have a remainder of:"+ modulus;
}   


function Increment() {
    var value = document.getElementById("IncrementText").innerHTML;
    value++;
    document.getElementById("IncrementText").innerHTML  = 
    value;
}   


function Decrement() {
    var value = document.getElementById("DecrementText").innerText
    value--;
    document.getElementById("DecrementText").innerHTML  = 
    value;
}   