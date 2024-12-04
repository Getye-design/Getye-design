// Function to calculate the total cost and generate the receipt
function getReceipt() {
    // Initialize the receipt text and total variables
    var text1 = "<h3>You Ordered:</h3>";
    var runningTotal = 0;
    var sizeTotal = 0;

    // Get all size options
    var sizeArray = document.getElementsByClassName("size");

    // Loop through size options to find the selected one
    for (var i = 0; i < sizeArray.length; i++) {
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value; // Store the selected size
            text1 = text1 + selectedSize + "<br>"; // Add size to receipt text
        }
    }

    // Determine the price based on the selected size
    if (selectedSize === "Small Pizza") {
        sizeTotal = 8;
    } else if (selectedSize === "Medium Pizza") {
        sizeTotal = 10;
    } else if (selectedSize === "Large Pizza") {
        sizeTotal = 14;
    } else if (selectedSize === "Extra Large Pizza") {
        sizeTotal = 16;
    } else if (selectedSize === "Party Pizza") {
        sizeTotal = 18; // Price for "Party Pizza"
    }

    // Update the running total with the size total
    runningTotal = sizeTotal;

    // Log the size selection and subtotal for debugging
    console.log(selectedSize + " = $" + sizeTotal + ".00");
    console.log("size text1: " + text1);
    console.log("subtotal: $" + runningTotal + ".00");

    // Call getTopping function to calculate toppings and update the receipt
    getTopping(runningTotal, text1);
}

// Function to calculate the total cost of toppings and update the receipt
function getTopping(runningTotal, text1) {
    var toppingTotal = 0; // Total cost of toppings
    var selectedTopping = []; // Array to store selected toppings

    // Get all topping options
    var toppingArray = document.getElementsByClassName("toppings");

    // Loop through topping options to find selected ones
    for (var j = 0; j < toppingArray.length; j++) {
        if (toppingArray[j].checked) {
            selectedTopping.push(toppingArray[j].value); // Add selected topping to the array
            console.log("selected topping item: (" + toppingArray[j].value + ")"); // Debug log
            text1 = text1 + toppingArray[j].value + "<br>"; // Add topping to receipt text
        }
    }

    // Calculate topping cost: 1 topping is free, others cost $1 each
    var toppingCount = selectedTopping.length;
    if (toppingCount > 1) {
        toppingTotal = (toppingCount - 1); // Subtract 1 for the free topping
    } else {
        toppingTotal = 0; // No extra cost for 1 topping
    }

    // Update the running total with topping cost
    runningTotal = (runningTotal + toppingTotal);

    // Log topping selection and final total for debugging
    console.log("total selected topping items: " + toppingCount);
    console.log(toppingCount + " topping - 1 free topping = $" + toppingTotal + ".00");
    console.log("topping text1: " + text1);
    console.log("Purchase Total: $" + runningTotal + ".00");

    // Update the receipt text and total price on the webpage
    document.getElementById("showText").innerHTML = text1;
    document.getElementById("totalPrice").innerHTML = "</h3>Total: <strong>$" + runningTotal + ".00</strong></h3>";
};
