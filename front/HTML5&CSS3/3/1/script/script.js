//////////////////////////////////////////
/// Play or Pause
var video = document.getElementById("myVideo");
var toggle = document.getElementById("playOrPause");
var isPlaying = false;

function switchPlayPause() {
  toggle.addEventListener("click", togglePlay);
}

function togglePlay() {
  isPlaying ? video.pause() : video.play();
}
switchPlayPause();
video.onplaying = function () {
  isPlaying = true;
  toggle.innerText = "pause";
  console.log("pause");
};
video.onpause = function () {
  isPlaying = false;
  toggle.innerText = "play_arrow";
};
//////////////////////////////////////////
//
//
//////////////////////////////////////////
/// Sound on Or Off
var volumeToggle = document.getElementById("volumeToggle");
var volumeBar = document.getElementById("volumeBar");
volumeToggle.addEventListener("click", switchOnOffSound);
volumeBar.addEventListener("change", volumeBarControl);
function switchOnOffSound() {
  video.muted ? disableMute() : enableMute();
}

function volumeBarControl() {
  video.volume = volumeBar.value;
  if (video.volume == 0) return enableMute();

  disableMute();
}

function enableMute() {
  video.muted = true;
  volumeToggle.innerText = "volume_off";

  return true;
}

function disableMute() {
  video.muted = false;
  volumeToggle.innerText = "volume_up";
  console.log("asd");
  return false;
}
//////////////////////////////////////////
//
//
//////////////////////////////////////////
/// Current Time
// video.ontimeupdate = function () {
//   myFunction();
// };

// function myFunction() {
//   document.getElementById("current").innerHTML = `
//     <p>Current Time: ${Math.trunc(video.currentTime)}</p>
//   `;
// }
//////////////////////////////////////////
//
//
//////////////////////////////////////////
/// Fullscreen

const fullScreen = document.getElementById("fullScreen");

video.addEventListener("dblclick", function () {
  video.requestFullscreen();
  console.log("full");
});

fullScreen.addEventListener("click", function () {
  video.requestFullscreen();
});

//////////////////////////////////////////
//
//
//////////////////////////////////////////
