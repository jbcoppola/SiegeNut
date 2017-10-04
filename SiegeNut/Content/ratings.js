$(document).ready(function () {
    //ratings scripts
    var currentRating = $('.ratings').children('input').val();
    var v;
    $('.ratings img').on('mouseover', function () {
        var onStar = $(this).attr('value'); // The star with cursor over it
        StarUpdate(this, onStar); //shows rating hovered over
    }).on('mouseout', function () {
        StarUpdate(this, currentRating); //reverts to default rating or selected rating
    });

    $('.ratings img').on('click', function () {
        $(this).parent().children().animate({ backgroundColor: 'white' }, 0).animate({ backgroundColor: 'transparent' }, "fast"); //highlight on click
        currentRating = $(this).attr('value'); // store value of currently selected star
        $("#Rating").val(currentRating); //changes value of hidden field
    });
    

function StarUpdate(f, rating) {
    $(f).parent().children().each(function (e) {
        v = $(this).attr('value');
        if (v <= rating) { //filled or empty star check
            if (v % 1 != 0) { $(this).attr('src', '/Images/half star left.png') } //...and left or right
            else { $(this).attr('src', '/Images/half star right.png') }
        }
        else {
            if (v % 1 != 0) { $(this).attr('src', '/Images/half empty star left.png') }
            else { $(this).attr('src', '/Images/half empty star right.png') }
        }
    });
}
});