window.addEventListener("load", function () {
  myMap = document.getElementById("mymap");
  let showLocation = document.getElementById("getMap");
  showLocation.addEventListener("click", getLocation);
}); //end of load
function getLocation() {
  if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(getPosition, errorHandler);
  } else {
    myMap.innerText = "Sorry , Update Your Browser And Try Again !";
  }
}

getLocation();
function getPosition(position) {
  var lat = position.coords.latitude;
  var lon = position.coords.longitude;
  var acc = position.coords.accuracy;
  var time = position.timestamp;
  var date = new Date(time);
  getDetails.addEventListener("click", function () {
    let myMap = document.getElementById("mymap");

    myMap.innerHTML = `
    <div class="details">
      <div class="detail">
        <div>Latitude</div>
        <div class="section" id="latitude"></div>
      </div>
      <hr />
      <div class="detail">
        <div>Longitude</div>
        <div class="section" id="longitude" ></div>
      </div>
      <hr />
      <div class="detail">
        <div>Accuracy</div>
        <div class="section" id="accuracy" ></div>
      </div>
      <hr />
      <div class="detail">
        <div>Time Stamp</div>
        <div class="section" id="timeStamp"></div>
      </div>
    </div>
    `;
    latitude = document.getElementById("latitude");
    longitude = document.getElementById("longitude");
    accuracy = document.getElementById("accuracy");
    timeStamp = document.getElementById("timeStamp");
    latitude.innerText = lat;
    longitude.innerText = lon;
    accuracy.innerText = Math.trunc(acc % 1000) + "m";
    timeStamp.innerText = date;
  });
  var location = new google.maps.LatLng(lat, lon);
  var specs = { zoom: 16, center: location };
  new google.maps.Map(myMap, specs);
}

let getDetails = document.getElementById("getDetails");

function errorHandler() {
  alert("error");
}
