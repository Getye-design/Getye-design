
//A function with HTML and JS using a ternary opration with input from browser
function Ride_Function() {
    var Height, Can_ride;
    Height = document.getElementById("Height").value
    Can_ride = (Height < 52) ? "You are too short":"You are tall enough";
    document.getElementById("Ride").innerHTML = Can_ride + " " + "to ride";
}

// A Constructor function for creating a Car object
function Car(make, model, year) {
    this.make = make;       // The make of the car (e.g., Toyota)
    this.model = model;     // The model of the car (e.g., Corolla)
    this.year = year;       // The manufacturing year of the car
}

// Creating an instance of Car using the new keyword
var myCar1 = new Car("Toyota", "Corolla", 2021);
var myCar2 = new Car("BMW", "M5", 2023);
var myCar3 = new Car("Cadillac", "LYRIQ", 2025   

);

// Displaying the properties of the myCar object
function myFunction(){

    document.getElementById("Keywords_and_Constructors").innerHTML = 
    "Car 1 Make: " + myCar1.make + "<br>" +
    "Car 1 Model:" + myCar1.model + "<br>" +
    "Car 1 Year: " + myCar1.year + "<br>" +
    "Car 2 Make: " + myCar2.make + "<br>" +
    "Car 2 Model:" + myCar2.model + "<br>" +
    "Car 2 Year: " + myCar2.year + "<br>" +
    "Car 3 Make: " + myCar3.make + "<br>" +
    "Car 3 Model:" + myCar3.model + "<br>" +
    "Car 3 Year: " + myCar3.year ;

}
//a nested function that'll concatinate strings
function add_Strings() {

var start_string = "Hello";

function Adding(str){
start_string= start_string + " " +str;

}
Adding("There!");
document.getElementById("Nested_Function").innerHTML = start_string;

}