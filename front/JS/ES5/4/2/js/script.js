var salary = [];

do {
  var firstnum = prompt("1num");
} while (isNaN(firstnum) || firstnum.trim().length == 0 || firstnum == null);

do {
  var secondnum = prompt("2num");
} while (isNaN(secondnum) || secondnum.trim().length == 0 || secondnum == null);

do {
  var thirdnum = prompt("3num");
} while (isNaN(thirdnum) || thirdnum.trim().length == 0 || thirdnum == null);

salary.push(firstnum);
salary.push(secondnum);
salary.push(thirdnum);

var sum = parseInt(firstnum) + parseInt(secondnum) + parseInt(thirdnum);
var multi = parseInt(firstnum) * parseInt(secondnum) * parseInt(thirdnum);
if (thirdnum == 0) {
  var division = parseInt(firstnum) / parseInt(secondnum);
} else {
  var division = parseInt(firstnum) / parseInt(secondnum) / parseInt(thirdnum);
}

document.write(
  "<span style='color: red; '> sum of 3 num</span> " +
    firstnum +
    " + " +
    secondnum +
    " + " +
    thirdnum +
    " = " +
    sum +
    "<br/>"
);
document.write(
  "<span style='color: red; '> multi of 3 num</span> " +
    firstnum +
    " * " +
    secondnum +
    " * " +
    thirdnum +
    " = " +
    multi +
    "<br/>"
);

document.write(
  "<span style='color: red; '> division of 3 num</span> " +
    firstnum +
    "/" +
    secondnum +
    "/" +
    thirdnum +
    "=" +
    division +
    "<br/>"
);
