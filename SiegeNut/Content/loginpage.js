$(document).ready(function () {
    $('#register').hide();
    $('.btn').click(function () {
        if ($(this).attr('value') == "Login") {
            $('#register').hide();
            $('#login').show();
        }
        else if ($(this).attr('value') == "Register") {
            $('#register').show();
            $('#login').hide();
        }
    });
});