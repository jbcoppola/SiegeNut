$(document).ready(function () {

    /* 1. Visualizing things on Hover - See next part for action on click */
    var currentRating = $('.ratings').children('input').val();
    var v;
    $('.ratings img').on('mouseover', function () {
        var onStar = $(this).attr('value'); // The star currently mouse on

        // Now highlight all the stars that's not after the current hovered star
        StarUpdate(this, onStar);

    }).on('mouseout', function () {
        StarUpdate(this, currentRating);
    });


    /* 2. Action to perform on click */
    $('.ratings img').on('click', function () {
        currentRating = $(this).attr('value'); // The star currently selected
        
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

function StarUpdate(f, rating) {
    $(f).parent().children().each(function (e) {
        v = $(this).attr('value');
        if (v <= rating) {
            if (v % 1 != 0) { $(this).attr('src', '/Images/half star left.png') }
            else { $(this).attr('src', '/Images/half star right.png') }
        }
        else {
            if (v % 1 != 0) { $(this).attr('src', '/Images/half empty star left.png') }
            else { $(this).attr('src', '/Images/half empty star right.png') }
        }
    });
};