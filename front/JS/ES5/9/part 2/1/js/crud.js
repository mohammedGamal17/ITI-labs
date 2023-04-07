//defenition
var TaskNameInput = document.getElementById("taskName");
var checkBox = document.getElementById("myCheck");

var itemContainer = [];

//functions used to add task:
function addItem() {
  var product = {
    name: taskName.value,
  };
  itemContainer.push(product);
  displayItem();
}

function displayItem() {
  var cartona = "";
  for (var i = 0; i < itemContainer.length; i++) {
    cartona += ` <tr>
       <td><input type="button" id="myCheck"></td>
       <td>${itemContainer[i].name}</td>
       <td><button onclick="deleteItem(${i})" class="btn btn-outline-danger btn-sm">Delete</button></td>
   </tr>`;
  }
  document.getElementById("tableBody").innerHTML = cartona;
}
/////////////////////////////////////////////////////////////////////////////////////////////////////

//function used to delete task:
function deleteItem(productIndex) {
  itemContainer.splice(productIndex, 1);
  displayItem(itemContainer);
}

function doneTask(parameters) {}
