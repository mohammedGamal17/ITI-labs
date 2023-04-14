const images = [
  "../UP/1.jpg",
  "../UP/2.jpg",
  "../UP/3.jpg",
  "../UP/4.jpg",
  "../UP/5.jpg",
  "../UP/6.jpg",
  "../UP/7.jpg",
  "../UP/8.jpg",
  "../UP/10.jpg",
];

const container = document.getElementById("image-container");
for (let i = 0; i < images.length; i++) {
  const img = document.createElement("img");
  img.src = images[i];
  container.appendChild(img);
}
