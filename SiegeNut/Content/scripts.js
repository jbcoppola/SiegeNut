$(document).ready(function () {

    /* 1. Visualizing things on Hover - See next part for action on click */
    var currentRating = $('.ratings').children('input').val();
    $('.ratings img').on('mouseover', function () {
        var onStar = $(this).attr('value'); // The star currently mouse on
        console.log(onStar);
        // Now highlight all the stars that's not after the current hovered star
        $(this).parent().children().each(function (e) {
            if ($(this).attr('value') <= onStar) {
                $(this).addClass('border');
            }
            else {
                $(this).removeClass('border');
            }
        });

    }).on('mouseout', function () {
        $(this).parent().children().each(function (e) {
            if ($(this).attr('value') <= currentRating) {
                $(this).addClass('border');
            }
            else {
                $(this).removeClass('border');
            }
        });
    });


    /* 2. Action to perform on click */
    $('.ratings img').on('click', function () {
        currentRating = $(this).attr('value'); // The star currently selected
        var stars = $(this).parent().children('li.star');

        for (i = 0; i < stars.length; i++) {
            $(stars[i]).removeClass('border');
        }

        for (i = 0; i < currentRating; i++) {
            $(stars[i]).addClass('border');
        }

        //// JUST RESPONSE (Not needed)
        //var ratingValue = parseInt($('#stars li.selected').last().data('value'), 10);
        //var msg = "";
        //if (ratingValue > 1) {
        //    msg = "Thanks! You rated this " + ratingValue + " stars.";
        //}
        //else {
        //    msg = "We will improve ourselves. You rated this " + ratingValue + " stars.";
        //}
        //responseMessage(msg);

    });


});


//function responseMessage(msg) {
//    $('.success-box').fadeIn(200);
//    $('.success-box div.text-message').html("<span>" + msg + "</span>");
//}