﻿$(document).ready(function () {
    if ($('select[name="searchField"] :selected').attr('value') == "Rating") {
        $('select.rating-search').show().attr("disabled", false);
        $('input.text-search').hide().attr("disabled", true);
    }
    else {
        $('select.rating-search').hide().attr("disabled", true);
    }
    $('select.btn[name="searchField"]').change(function () {
        if ($(this).children(":selected").attr('value') == "Rating") {
            $('input.text-search').hide().attr("disabled", true);
            $('select.rating-search').show().attr("disabled", false);
        }
        else {
            $('input.text-search').show().attr("disabled", false);
            $('select.rating-search').hide().attr("disabled", true);

        }
    });
    $(function () {
        $('.sort-btns select.btn').change(function () {
            console.log("changed");
            var url = $(this).val();
            if (url != null && url != '') {
                window.location.href = url;
            }
        });
    });
});