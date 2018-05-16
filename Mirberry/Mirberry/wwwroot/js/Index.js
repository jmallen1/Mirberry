$(document).ready(function () {

var $homeBanner = $("#banner-home");
var $beginBanner = $("#banner-begin");
var $beginQuestion = $("#begin-question");
var $beginIcons = $("#banner-icons");

    $beginQuestion.hide();
    $beginIcons.hide();

var $beginButton = $("#begin-button");


$beginButton.on("click", function () {
    $homeBanner.hide();
    $beginQuestion.fadeIn(500);
    $beginIcons.fadeIn(1500)
    
})

var $icons = $("#banner-icons a");
    $icons.on("click", function () {
        console.log($(this).text())
    });
})