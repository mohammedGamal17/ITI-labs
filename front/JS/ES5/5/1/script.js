do {
  var number = prompt("enter your number ?");

  if (parseInt(number) % 3 == 0 || parseInt(number) % 5 == 0) {
    if (parseInt(number) % 3 == 0 && parseInt(number) % 5 == 0) {
      document.write("<p> Puzz  </p>");
    } else if (parseInt(number) % 3 == 0) {
      document.write("<p> 3 </p>");
    } else {
      document.write("<p> 5 </p>");
    }
  } else {
    document.write(" The number you Entered can't be divide by 3 or 5 ");
  }
} while (
  isNaN(number) ||
  number.trim().length == 0 ||
  number == null ||
  number == false ||
  number == true
);
