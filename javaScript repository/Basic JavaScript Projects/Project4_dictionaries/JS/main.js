
function my_Dictionary() {

    //keypair value dictionary 
let myDictionary = {
    color: "blue",
    shape: "circle",
    size: "large",
    texture: "smooth"
};

delete myDictionary.size; //Deletes the "size" key pair in the dictionary before it is displayed

document.getElementById("Dictionary").innerHTML = "Color: " + myDictionary.color;

};