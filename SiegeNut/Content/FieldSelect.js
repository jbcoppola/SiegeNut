$(document).ready(function () {
    if ($('select :selected').attr('value') == "Rating") {
        $('select.rating-search').show();
        $('input.text-search').hide();
    }
    else {
        $('select.rating-search').hide();
    }
    $('select.btn[name="searchField"]').change(function () {
        if ($(this).children(":selected").attr('value') == "Rating") {
            $('input.text-search').hide();
            $('select.rating-search').show();
        }
        else {
            $('input.text-search').show();
            $('select.rating-search').hide();
        }
    });
});