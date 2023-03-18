var newsArr = [];
var category = document.getElementsByName("newsType");
function setValueInTable() {
  for (var i = 0; i < category.length; i++) {
    if (category[i].checked) {
      getNews(i);
    }
  }

  console.log(newsArr);
}

function getNews(i) {
  var table = document.getElementById("table");
  var news = document.getElementById("newsInput");
  var news = document.getElementById("newsInput");
  var createdTr = document.createElement("tr");
  var createdTdOfNews = document.createElement("td");
  if (news.length != 0 && isNaN(news)) {
    createdTdOfNews.innerText = news.value;
    var createdTdOfCategory = document.createElement("td");
    createdTdOfCategory.innerText = category[i].value;
    createdTr.appendChild(createdTdOfNews);
    createdTr.appendChild(createdTdOfCategory);
    table.appendChild(createdTr);
    newsArr.push(createdTdOfNews.innerText);
  } else {
    alert("please write your news");
  }
}

function getValues() {
  var searchInput = document.getElementById("searchValue");
  var table = document.getElementById("searchTable");

  var createdTr = document.createElement("tr");
  var createdTd = document.createElement("td");

  if (searchInput.value != null) {
    var search = newsArr.filter((element) => element == searchInput.value);
    console.log(search);
    createdTd.innerText = search[0];
    createdTr.appendChild(createdTd);
    table.appendChild(createdTr);
  }
}
