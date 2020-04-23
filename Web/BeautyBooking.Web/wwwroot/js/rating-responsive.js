$(document).ready(function () {
    $("span.fa-star-o").on('click', function () {
        let $this = $(this),
            rating = $this.data('rating');
        $("span.fa").each(function () {
            let $star = $(this);
            if ($star.data('rating') <= rating) {
                $star.removeClass('fa-star-o').addClass('fa-star')
            }
            else {
                $star.removeClass('fa-star').addClass('fa-star-o');
            }
        });

        $("#selectedRating").prop('value', rating);
        $("#RateValue").val(rating);
    });
});