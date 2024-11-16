//A function using a while loop
function count_to_ten() {
    var Digit ="";
    var x = 1;
    while (x < 11) {
        Digit += "<br>" + x;
        x++;
    }
    document.getElementById("count_to_ten").innerHTML = Digit;

}

//A function using a for loop

var Instruments = ["Guitar", "Drums", "piano", "bass"];
var Content = "";
var Y;
function for_Loop() {
    for (Y = 0; Y < Instruments.length; Y++) {
        Content += Instruments[Y] + "<br>";
    }
    document.getElementById("List_of_Instruments").innerHTML = Content;
}
//A function with an array
function color_array() {
    var Colors = [];
    Colors[1] ="Green";
    Colors[2] ="Red";
    Colors[3] ="Blue";
    Colors[4] ="Yellow";
    Colors[5] ="Orange";
    Colors[6] ="Purple";
    document.getElementById("Array").innerHTML =
        "My favorite color is " + Colors[3] + " .";

}

//Creating an object with the let Keyword
function car() {
    let car = {
        make: "Toyota",
        year: "2023",
        color: "Blue",
    };
    document.getElementById("car").innerHTML =
        "I have a " + car.year + " " + car.color + " " + car.make + "."
}