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
    //lightbox script
    var src;
    $('.img-responsive').on('click', function () {
        //Get clicked link src
        src = $(this).attr("src");

        /* 	
		If the lightbox window HTML already exists in document, 
		change the img src to to match the href of whatever link was clicked
		
		If the lightbox window HTML doesn't exist, create it and insert it.
		(This will only happen the first time around)
		*/

        if ($('#lightbox').length > 0) { // #lightbox exists

            //place href as img src value
            $('#content img').attr('src', src);
            console.log(src);

            //show lightbox window - you could use .show('fast') for a transition
            $('#lightbox').show();
        }

        else { //#lightbox does not exist - create and insert (runs 1st time only)

            //create HTML markup for lightbox window
            var lightbox =
			'<div id="lightbox">' +
				'<p>Click to close</p>' +
				'<div id="content">' + //insert clicked link's href into img src
					'<img src="' + src + '" />' +
				'</div>' +
			'</div>';

            //insert lightbox HTML into page
            $('body').append(lightbox);
        }

        $('#lightbox').on('click', function () { //must use live, as the lightbox element is inserted into the DOM
            $('#lightbox').hide();
        });

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