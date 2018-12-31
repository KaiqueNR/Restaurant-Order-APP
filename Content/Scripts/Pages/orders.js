$(document).ready(function () {
    $('#btn-send-order').click(function () {
        var inputOrder = $('#txt-input').val();
        var parameters = {
            inputOrder: inputOrder
        }

        $.post("Orders/AddOrder", {
            inputOrder: inputOrder
        }, function(data) {
            if (data.success) {
                $('.no-orders').hide();
                $('#tbody-orders-history').append(
                    '<tr>' +
                    '<td>' + inputOrder + '</td>' +
                    '<td>' + data.result + '</td>' +
                    '</tr>'
                );

                $('#txt-output').val(data.result);
                ShowAlertMessage('Order successfully requested', 'success');
            }
        }).fail(function (xhr, error, textStatus) {
                var responseText = xhr.responseText != '' ? xhr.responseText : "Bad Request";

            ShowAlertMessage(responseText, 'danger');

            if (responseText == 'Invalid order!') {
                $('#div-available-orders').show();
            }
        });

        //$.ajax({
        //    type: "POST",
        //    url: "Orders/AddOrder",            
        //    contentType: "application/json",
        //    dataType: "json",
        //    data: JSON.stringify(parameters),
        //    async: true,
        //    success: function (data) {
        //        if (data.success) {
        //            $('.no-orders').hide();
        //            $('#tbody-orders-history').append(
        //                '<tr>' +
        //                '<td>' + inputOrder + '</td>' +
        //                '<td>' + data.result + '</td>' +
        //                '</tr>'
        //            );

        //            $('#txt-output').val(data.result);
        //            ShowAlertMessage('Order successfully requested', 'success');
        //        }
        //    },
        //    error: function (xhr, ajaxOptions, thrownError) {
        //        if (xhr.responseText == '')
        //            thrownError = 'Bad Request!';
        //        ShowAlertMessage(thrownError, 'danger');
        //    }
        //});
    })
});

function ShowAlertMessage(message, type) {
    $('#alert').attr('class', 'alert alert-' + type);
    $('#alert').html(message);
    $('#alert').show();

    window.setTimeout(function () {
        $('#alert').hide();
    }, 3000)
}