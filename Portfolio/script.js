  /* 
  - Duplicate script files
  - Recylced the same function so this doesn't meet the requirement of 3+ functions. 6 method/function calls, but not 3+ functions.
  - 
*/ 

const openButton = document.getElementById("popup");
const popupWindow = document.getElementById("elements");

const closeButton = document.getElementById("close");

openButton.addEventListener("click", function() {
  popupWindow.style.display = "block";
});

closeButton.addEventListener("click", function() {
  popupWindow.style.display = "none";
});

const openButton1 = document.getElementById("popup1");
const popupWindow1 = document.getElementById("attributes");
const closeButton1 = document.getElementById("close1");

openButton1.addEventListener("click", function() {
  popupWindow1.style.display = "block";
});

closeButton1.addEventListener("click", function() {
  popupWindow1.style.display = "none";
});

const openButton2 = document.getElementById("popup2");
const popupWindow2 = document.getElementById("forms");
const closeButton2 = document.getElementById("close2");

openButton2.addEventListener("click", function() {
  popupWindow2.style.display = "block";
});

closeButton2.addEventListener("click", function() {
  popupWindow2.style.display = "none";
});
