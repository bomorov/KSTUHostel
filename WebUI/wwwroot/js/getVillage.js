$(function () {
    $('#countryside-select').change(function () { //регион
        console.log("change");
        // получаем выбранный id
        const id = $(this).val();
        $.ajax({
            type: 'GET',
            url: `@Url.Action("getCoate", "student")?id=${id}`,
            dataType: 'json',
            success: function (data) {
                var items = '<option value="">Выберите поселок</option>';
                $.each(data,
                    function (i, village) {
                        items += `<option value='${village.value}'>${village.text}</option>`;
                    });
                $('#village-select').html(items);
            }
        });
    });
})