do {
  var num = prompt("enter your number");
  var string = "";
  for (var i = 1; i <= num; i++) {
    // printing spaces
    for (var j = 0; j < num - i; j++) {
      string += " ";
    }
    for (var k = 0; k < i; k++) {
      string += "*";
    }
    string += "\n";
  }
  console.log(string);
} while (isNaN(num) || num <= 0 || num == null || num.trim().length == 0);
