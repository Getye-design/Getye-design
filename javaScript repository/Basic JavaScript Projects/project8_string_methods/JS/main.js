// Utilizing the .concat() method
function full_sentence() {
    var part_1 = "Guess what day ";
    var part_2 = "it is... ";
    var part_3 = "Christmas!";
    var whole_sentence = part_1.concat(part_2, part_3);
    document.getElementById("Concat_String").innerHTML = whole_sentence;
  }
  
  // Utilizing the .slice() method
  function slice_Method() {
    var sentence = "Slice and Dice This Sentence";
    var section = sentence.slice(10, 14);
    document.getElementById("Slice").innerHTML = section;
  }
  
  // Utilizing the .toString() method
  function string_Method() {
    var myNumber = 777;
    document.getElementById("ToString").innerHTML = myNumber.toString();
  }
  
  // Utilizing the .toPrecision() method
  function precision_method() {
    var myNumber = 144.789684536;
    document.getElementById("RoundedNumber").innerHTML = myNumber.toPrecision(4);
  }  