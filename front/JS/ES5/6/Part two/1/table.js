var arr;
var grades = [
  [1, 2, 3],
  [4, 5, 6],
];

var sum = [];
for (let i = 0; i < grades.length; i++) {
  sum[i] = grades[i].reduce(function (p, c) {
    p = p + c;
    return p;
  });
}
var average = [];

for (let i = 0; i < grades[0].length; i++) {
  for (let k = 0; k < grades[1].length; k++) {
    if (i == k) {
      average.push((grades[0][i] + grades[1][k]) / 2);
    }
  }
}

document.write(
  "<table><tr><th>std1</th><th>std2</th><th>std3</th><th></th></tr>"
);

getSum();
getAvg();
document.write("<tr>");

document.write("</tr>");
document.write("</table>");

function getSum() {
  for (var i = 0; i < grades[0].length - 1; i++) {
    document.write("<tr>");
    for (var k = 0; k < grades[1].length; k++) {
      document.write("<td>" + grades[i][k] + "</td>");
    }
    document.write("<td>" + sum[i] + "</td>");

    document.write("</tr>");
  }
}
function getAvg(params) {
  for (var l = 0; l < average.length; l++) {
    document.write("<td>" + average[l] + "</td>");
  }
}
