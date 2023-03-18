window.addEventListener("load", function () {
  username = document.getElementById("username");
  country = document.getElementById("country");
  zip = document.getElementById("zip");
  email = document.getElementById("email");
  //   hobbies = document.forms["form"]["hobbies"];

  username.addEventListener("blur", usernameFun); //end of username
  country.addEventListener("blur", countryFun); // end of country
  zip.addEventListener("blur", zipFun); // end of zip
  email.addEventListener("blur", emailFun); //end of email
  //   hobbies.addEventListener("blur", hobbiesFun); // end of hobbies

  //   document.forms[0].addEventListener("submit", function (e) {
  //     if (!isUsernameValid()) {
  //       username.focus();
  //       e.preventDefault();
  //     }
  //   }); //end of submit

  /**
   *  Username event listener
   ** if valid move on
   ** else focus and be error
   */
  function usernameFun() {
    if (!isUsernameValid()) {
      username.focus();
      username.select();
      username.className = "error";
    } else {
      username.className = "success";
    }
  }

  function isUsernameValid() {
    var regex = /^[a-zA-Z]{4,8}$/;

    return regex.test(username.value);
  }

  /**
   *  Country event listener
   ** if valid move on
   ** else focus and be error
   */
  function countryFun() {
    if (!isCountrySelected()) {
      country.focus();
      country.select();
      country.className = "error";
    } else {
      country.className = "success";
      zip.focus();
    }
  }
  function isCountrySelected() {
    if (country.value == "") return false;

    return true;
  }
  /**
   *  Zip event listener
   ** if valid move on
   ** else focus and be error
   */
  function zipFun() {
    if (!isZipValid()) {
      zip.focus();
      zip.select();
      zip.className = "error";
    } else {
      zip.className = "success";
      email.focus();
    }
  }

  function isZipValid() {
    var regex = /^[0-9]{4,6}$/;

    return regex.test(zip.value);
  }

  /**
   *  Email event listener
   ** if valid move on
   ** else focus and be error
   */
  function emailFun() {
    if (!isEmailValid()) {
      email.focus();
      email.select();
      email.className = "error";
    } else {
      email.className = "success";
      hobbies.focus();
    }
  }

  function isEmailValid() {
    var regex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;

    return regex.test(email.value);
  }

  /**
   *  Hobbies event listener
   ** if valid move on
   ** else focus and be error
   */
  function hobbiesFun() {
    if (!isChecked()) {
      hobbies.className = "success";
    } else {
      hobbies.focus();
      hobbies.select();
      hobbies.className = "error";
    }
  }
  function isChecked() {
    if (
      hobbies[0].checked == false &&
      hobbies[1].checked == false &&
      hobbies[2].checked == false &&
      hobbies[3].checked == false
    ) {
      return false;
    } else {
      return true;
    }
  }
}); //end of load
