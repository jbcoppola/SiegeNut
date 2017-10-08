$(document).ready(function () {
    $('.btn').click(function () {
        if ($(this).attr('value') == "Login") {
            if (!$(this).hasClass("selected")) {
                $(this).addClass("selected");
                $(".btn[value='Register']").removeClass("selected");
            }
            $('#register').hide();
            $('#login').show();
        }
        else if ($(this).attr('value') == "Register") {
            if (!$(this).hasClass("selected")) {
                $(this).addClass("selected");
                $(".btn[value='Login']").removeClass("selected");
            }
            $('#register').show();
            $('#login').hide();
        }
    });

    $('.default').click(); //whichever button is default shows that form
});