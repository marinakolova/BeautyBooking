$(document).ready(function () {
    $(".editable").on('click', function () {
        disableEditingField();

        let $this = $(this),
            value = $this.prop('innerHTML');

        $this.prop('innerHTML', '');
        $this.append(`<input type="text" width="100%" value="${value}" />`);
        $this.children('input').focus();
        $this.data('editing', true);
    });

    let disableEditingField = function disableEditingField() {
        $('.editable').each(function () {
            let $td = $(this);
            if ($td.find('input').length > 0) {
                $td.prop('innerHTML', $td.find('input')[0].value);
                $($td.find('input')[0]).remove();
            }
        });
    }

    $(document).on('keypress', 'td.editable > input', function (event) {
        if (event.which === 13) {
            let $this = $(this);
            $this.parent().prop('innerHTML', $this.val());
            $this.remove();
            // TODO: Send to server
        }
    });
});