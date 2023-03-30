// var username = document.getElementById("username").value;

gender = document.forms["form"]["gender"].value;
color = document.forms["form"]["selectionMenu"].value;

function validate() {
  var isValid = false;
  if (validateInInputs()) {
    setValuesInCookie();
    isValid = true;
  } else {
    isValid = false;
  }
  console.log(isValid);
  return isValid;
}

function validateInInputs() {
  var isValid = true;
  username = document.forms["form"]["username"].value;
  if (!isString(username)) {
    alert("Name must be filled out");
    return false;
  }
  age = document.forms["form"]["age"].value;
  if (!isNum(age)) {
    alert("Please Write Valid Age");
    return false;
  }
  return true;
}

function setValuesInCookie() {
  document.cookie = "username=" + username;
  document.cookie = "age=" + age;
  document.cookie = "gender=" + gender;
  document.cookie = "color=" + color;
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
