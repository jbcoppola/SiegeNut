$(document).ready(function () {
    $(function () {
        $('select.btn[name="sortBy"]').change(function () {
            console.log("changed");
            var url = $(this).val();
            if (url != null && url != '') {
                window.location.href = url;
            }
        });
    });
});