$(document).ready(function () {

var $homeBanner = $("#banner-home");
var $beginBanner = $("#banner-begin");
var $beginQuestion = $("#begin-question");
var $beginIcons = $("#banner-icons");

    
    $beginQuestion.hide();
    $beginIcons.hide();
    $beginBanner.toggle();
var $beginButton = $("#begin-button");


$beginButton.on("click", function () {
    $homeBanner.hide();
    $beginQuestion.fadeIn(1000, function () {
        // this runs once faded out so is effectivly a 'wait until done'
    });
    $beginIcons.fadeIn(1500)
    
})

var $icons = $("#banner-icons a");
    $icons.on("click", function () {
        console.log($(this).text())
    });
})