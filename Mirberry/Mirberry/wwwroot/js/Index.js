var homeBanner = document.getElementById("banner-home");
var beginBanner = document.getElementById("banner-begin");


beginBanner.hidden = true;

var beginButton = document.getElementById("begin-button");
beginButton.addEventListener("click", function () {
    beginBanner.hidden = false;
    homeBanner.hidden = true;
})
