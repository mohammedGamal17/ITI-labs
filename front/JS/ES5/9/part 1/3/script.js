window.addEventListener("load", function () {
  getFontFamily();
  getTextAlign();
  getLineHeight();
  getLetterSpace();
  getTextIndent();
  getTextTransformation();
  getTextDecoration();
  getBoarderStyle();
  getBoarderColor();
}); //end of load

function getFontFamily() {
  var fontFamily = document.getElementsByName("family");
  for (var i = 0; i < fontFamily.length; i++) {
    fontFamily[i].onclick = function (e) {
      document.getElementById("text").style.fontFamily = e.target.value;
    };
  }
}

function getTextAlign() {
  var textAlign = document.getElementsByName("textAlign");
  for (var i = 0; i < textAlign.length; i++) {
    textAlign[i].onclick = function (e) {
      document.getElementById("text").style.textAlign = e.target.value;
    };
  }
}

function getLineHeight() {
  var lineHeight = document.getElementsByName("lineHeight");
  for (var i = 0; i < lineHeight.length; i++) {
    lineHeight[i].onclick = function (e) {
      document.getElementById("text").style.lineHeight = e.target.value;
    };
  }
}

function getLetterSpace() {
  var letterSpace = document.getElementsByName("letterSpace");
  for (var i = 0; i < letterSpace.length; i++) {
    letterSpace[i].onclick = function (e) {
      document.getElementById("text").style.letterSpacing = e.target.value;
    };
  }
}

function getTextIndent() {
  var textIndent = document.getElementsByName("textIndent");
  for (var i = 0; i < textIndent.length; i++) {
    textIndent[i].onclick = function (e) {
      document.getElementById("text").style.letterSpacing = e.target.value;
    };
  }
}

function getTextTransformation() {
  var textTransformation = document.getElementsByName("textTransformation");
  for (var i = 0; i < textTransformation.length; i++) {
    textTransformation[i].onclick = function (e) {
      document.getElementById("text").style.textTransform = e.target.value;
    };
  }
}

function getTextDecoration() {
  var textDecoration = document.getElementsByName("textDecoration");
  for (var i = 0; i < textDecoration.length; i++) {
    textDecoration[i].onclick = function (e) {
      document.getElementById("text").style.textDecoration = e.target.value;
    };
  }
}

function getBoarderStyle() {
  var boarder = document.getElementsByName("boarder");
  for (var i = 0; i < boarder.length; i++) {
    boarder[i].onclick = function (e) {
      document.getElementById("text").style.borderStyle = e.target.value;
    };
  }
}

function getBoarderColor() {
  var boarderColor = document.getElementsByName("boarderColor");
  for (var i = 0; i < boarderColor.length; i++) {
    boarderColor[i].onclick = function (e) {
      document.getElementById("text").style.borderColor = e.target.value;
    };
  }
}
