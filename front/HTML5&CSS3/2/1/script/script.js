window.addEventListener("load", function () {
  startBtn = document.getElementById("start");
  startBtn.addEventListener("click", startMoving);

  pauseBtn = document.getElementById("pause");
  pauseBtn.addEventListener("click", pauseMoving);

  stopBtn = document.getElementById("stop");
  stopBtn.addEventListener("click", stop);
});

let animation = document.getElementById("animation");
animation.addEventListener("mouseenter", mouseHover);

animation.addEventListener("mouseleave", startMoving);

function startMoving() {
  let myStyles = `
  animation-play-state: running;
`;

  animation.style.cssText = myStyles;
}

function pauseMoving() {
  let myStyles = `
  animation-play-state: paused;
`;

  animation.style.cssText = myStyles;
}

function stopMoving() {
  let myStyles = `
  animation-play-state: inherit;
`;

  animation.style.cssText = myStyles;
}

function mouseHover() {
  let myStyles = `
  animation-play-state: paused;
  transform: rotate(0deg) scale(1.1);
`;

  animation.style.cssText = myStyles;
}
