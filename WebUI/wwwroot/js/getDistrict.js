$(function () {
    $('#district-select').empty();
    $('#district-select').append('<option value>Выберите район</option>');
    $('#countryside-select').empty();
    $('#countryside-select').append('<option value>Выберите айыльный аймак</option>');
    $('#village-select').empty();
    $('#village-select').append('<option value>Выберите поселок</option>');
    $('#region-select').change(function () { //регион
        console.log("change");
        // получаем выбранный id
        const id = $(this).val();
        $.ajax({
            type: 'GET',
            url: `@Url.Action("getCoate", "student")?id=${id}`,
            dataType: 'json',
            success: function (data) {
                var items = '<option value="">Выберите район</option>';
                $.each(data,
                    function (i, district) {
                        items += `<option value='${district.value}'>${district.text}</option>`;
                    });
                $('#district-select').html(items);
                $('#countryside-select').empty();

                $('#countryside-select').append('<option value="">Выберите айыльный аймак</option>');

                $('#village-select').empty();

                $('#village-select').append('<option value="">Выберите поселок</option>');
            }
        });
    });
})