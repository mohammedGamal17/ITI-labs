function isColor(strColor) {
  var s = new Option().style;
  s.color = strColor;
  return s.color == strColor;
}

do {
  var colorText = prompt("enter color for text");
} while (!isColor(colorText));

do {
  var colorBorder = prompt("enter color for border");
} while (!isColor(colorBorder));

do {
  var url = prompt("name of image");
} while (url.trim().length == 0 || url == null);

document.write("<p style='color:" + colorText + "'>this is ur image</p> <br/>");
document.write(
  "<img src='" +
    url +
    ".png' style=' border: 2px solid " +
    colorBorder +
    " ' />"
);
