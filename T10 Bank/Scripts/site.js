new WOW().init();

$('.right').addClass('wow');
$('.right').addClass('fadeInRight');
$('.left').addClass('wow');
$('.left').addClass('fadeInLeft');
$('.up').addClass('wow');
$('.up').addClass('fadeInUp');

var width = screen.width;

if (width < 1024) {
    $('.right').addClass('wow');
    $('.right').addClass('fadeInUp');
    $('.left').addClass('wow');
    $('.left').addClass('fadeInUp');
}

$('#telefone').mask('(00) 0000-0000');

$(window).on('beforeunload', function () {
    $(window).scrollTop(0);
});