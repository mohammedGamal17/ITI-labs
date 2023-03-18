var isFly = prompt("Is Fly? for yes y for no n");
switch (isFly) {
  case "Y":
  case "y":
    var isWild = prompt("Is Wild  for yes y for no n");
    switch (isWild) {
      case "Y":
      case "y":
        alert(" eagle");
        break;

      case "N":
      case "n":
        alert("parrot");
        break;

      default:
        alert("Wrong selection");
        break;
    }
    break;
  case "N":
  case "n":
    var isFish = prompt("Is under sea? for yes y for no n");
    switch (isFish) {
      case "Y":
      case "y":
        var isWild = prompt("Is Wild  for yes y for no n");
        switch (isWild) {
          case "Y":
          case "y":
            alert("Shark");
            break;

          case "N":
          case "n":
            alert("Dolphin");
            break;

          default:
            alert("Wrong selection");
            break;
        }
        break;
      case "N":
      case "n":
        var isWild = prompt("Is Wild  for yes y for no n");
        switch (isWild) {
          case "Y":
          case "y":
            alert("Lion");
            break;

          case "N":
          case "n":
            alert("Cat");
            break;

          default:
            alert("Wrong selection");
            break;
        }
      default:
        alert("Wrong selection");
        break;
    }
    break;

  default:
    alert("Wrong selection");
    break;
}

function check(value) {
  value.toLowerCase();
  switch (value) {
    case y:
      break;
    case n:
      break;
    default:
      break;
  }
  return a;
}
