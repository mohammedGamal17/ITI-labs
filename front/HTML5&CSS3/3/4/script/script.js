let firstNumSum = document.getElementById("firstNumSum");
let secondNumSum = document.getElementById("secondNumSum");

let firstNumMulti = document.getElementById("firstNumMulti");
let secondNumMulti = document.getElementById("secondNumMulti");

function getSum() {
  let firstNum = 0;
  let secondNum = 0;

  let output = document.getElementById("sumOutput");
  firstNumSum.addEventListener("change", function () {
    firstNum = parseInt(firstNumSum.value);
    output.innerText = firstNum + secondNum;
  });

  secondNumSum.addEventListener("change", function () {
    secondNum = parseInt(secondNumSum.value);
    output.innerText = firstNum + secondNum;
  });
}

getSum();

function getMulti() {
  let firstNum = 1;
  let secondNum = 1;

  let output = document.getElementById("multiOutput");
  firstNumMulti.addEventListener("change", function () {
    firstNum = parseInt(firstNumMulti.value);
    output.innerText = firstNum * secondNum;
  });

  secondNumMulti.addEventListener("change", function () {
    secondNum = parseInt(secondNumMulti.value);
    output.innerText = firstNum * secondNum;
  });
}
getMulti();
