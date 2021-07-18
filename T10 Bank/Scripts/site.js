new WOW().init();

$('.right').addClass('wow');
$('.right').addClass('fadeInRight');
$('.left').addClass('wow');
$('.left').addClass('fadeInLeft');
$('.up').addClass('wow');
$('.up').addClass('fadeInUp');
$('.down').addClass('wow');
$('.down').addClass('fadeIn');

var width = screen.width;

if (width < 1024) {
    $('.right').addClass('wow');
    $('.right').addClass('fadeInUp');
    $('.left').addClass('wow');
    $('.left').addClass('fadeInUp');
}