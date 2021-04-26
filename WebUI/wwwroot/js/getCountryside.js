$(function () {
    $('#district-select').change(function () { //регион
        console.log("change");
        // получаем выбранный id
        const id = $(this).val();
        $.ajax({
            type: 'GET',
            url: `@Url.Action("getCoate", "student")?id=${id}`,
            dataType: 'json',
            success: function (data) {
                var items = '<option value="">Выберите айыльный аймак</option>';
                $.each(data,
                    function (i, countryside) {
                        items += `<option value='${countryside.value}'>${countryside.text}</option>`;
                    });
                $('#countryside-select').html(items);
                $('#village-select').empty();

                $('#village-select').append('<option value="">Выберите поселок</option>');
            }
        });
    });
})