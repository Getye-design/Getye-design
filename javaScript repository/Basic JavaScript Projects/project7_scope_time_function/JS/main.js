
//Assigning local and global variables

var X = 15; // global variable
function Add_numbers_1() {
    document.write("Adding X and 20 = ");
    document.write(20 + X + "<br>");
}
function Add_numbers_2() {
    document.write("Adding X and 20 = ");
    document.write(X + 100); //
}

Add_numbers_1();
Add_numbers_2();

//A function that includes  an if statement
function get_date() {

    if (new Date().getHours() <18){

        document.getElementById("Greeting").innerHTML = "It is currently before 6PM.";
    }
    else {
        document.getElementById("Greeting").innerHTML = "It is currently After 6PM.";
    }
}

function get_reply(){
    var user_input = document.getElementById("userInput").value;
 
    if (user_input %2 ===0) {

        reply = "You have entered an even number!";
        document.getElementById("feedback").innerHTML = reply;
    }
    else {
        reply = "You enetered an odd number!";
        document.getElementById("feedback").innerHTML = reply;
        console.log("User entred an Odd number!");
    }
}

//Utilizing the time_function() from previous slides 
function Time_function() {
    var Time = new Date().getHours();
    var reply;
    if (Time < 12 == Time >0){
        reply = "It is morning time!";
    } else if (Time >= 12 == Time < 18) {
        Reply = "It is afternoon!"
    }
    else {
        Reply = "It is evening time!"
    }
    document.getElementById("Time_of_day").innerHTML = Reply;

}


