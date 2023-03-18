// 1.1
var header = prompt("Enter your header");
document.write("<h3> Header </h3> <br/> <hr/> ");

for (var i = 1; i < 7; i++) {
  document.write("<h" + i + ">" + header + i + "<h" + i + "/>");
}

//1.2
var sum = 0;
do {
  var num = prompt("enter your number : ");
  if (isNaN(num)) {
    confirm("please enter you number??????????");
  } else {
    sum += parseInt(num);
    if (sum <= 100) {
      alert(sum);
    } else {
      break;
    }
  }
} while (sum < 100 || num === 0);
confirm(sum);
