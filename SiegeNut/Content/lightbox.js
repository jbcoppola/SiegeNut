$(document).ready(function () {
    var src;
    $('.lightbox-trigger').on('click', function () {
        //Get clicked link src
        src = $(this).attr("src");

        /* 	
        If the lightbox window HTML already exists in document, 
        change the img src to to match the src of whatever image was clicked
        
        If the lightbox window HTML doesn't exist, create and insert it.
        (This will only happen the first time)
        */

        if ($('#lightbox').length > 0) { // #lightbox exists

            //place src as img src value
            $('#content img').attr('src', src);

            //show lightbox window
            $('#lightbox').show();
        }

        else { //#lightbox does not exist - create and insert (runs 1st time only)

            //create HTML markup for lightbox window
            var lightbox =
            '<div id="lightbox">' +
                '<p>Click to close</p>' +
                '<div id="content">' + //insert clicked image src into lightbox
                    '<img src="' + src + '" />' +
                '</div>' +
            '</div>';

            //insert lightbox HTML into page
            $('body').append(lightbox);
        }

        $('#lightbox').on('click', function () { //click anywhere to hide the lightbox
            $('#lightbox').hide();
        });

    });
});