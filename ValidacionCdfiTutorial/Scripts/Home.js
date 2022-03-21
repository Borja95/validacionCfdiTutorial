
$(document).ready(function () {
    validarFactura();
});

function validarFactura() {
    $.ajax({
        type: "POST",
        url: "/Home/ValidarFacturas",
        success: function (response) {
            console.log(response);

        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR);
        }
    });
}