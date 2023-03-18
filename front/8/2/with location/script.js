// var username = document.getElementById("username").value;

function validateForm() {
  var name = document.forms["form"]["username"].value;
  if (!isString(name)) {
    alert("Name must be filled out");
    return false;
  }
  var age = document.forms["form"]["age"].value;
  if (!isNum(age)) {
    alert("Please Write Valid Age");
    return false;
  }
}

function validate() {
  return isString() && isNum();
}

function isString(str) {
  var isString = false;
  if (isNaN(str)) {
    isString = true;
  }
  return isString;
}
function isNum(num) {
  var isNumber = false;
  if (Number(num) && num > 0) {
    isNumber = true;
  }
  return isNumber;
}
