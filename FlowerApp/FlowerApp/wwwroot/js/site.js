// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {

    var carNumber = $("#cardNumber");
    carNumber.hide();

    $("#payMethod").on("change", function () {
        if (this.value === "Cash") {
            carNumber.hide();
        } else {
            carNumber.show();
        }
    });
});

$(document).ready(function () {

    var homeShipping = $(".homeShipping");
    homeShipping.show();

    $("#shippingMethod").on("change", function () {
        if (this.value === "Showroom") {
            homeShipping.hide();
        } else {
            homeShipping.show();
        }
    });
});
