function name() {
  var resu = "";
  var sum = 0;
  for (var i = 0; i < arguments.length; i++) {
    if (!isNaN(arguments[i]) || arguments[i] == false || arguments[i] == true) {
      sum += arguments[i];
    } else {
      resu += arguments[i];
    }
  }
  console.log(sum + resu);
  alert(resu);
}

name("nasr", 1, 2, 3, 4, "nnew", 5, Date());
