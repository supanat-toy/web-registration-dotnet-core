// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function(){
    Call_box_alert_message()
})

// function Call_box_alert_message_success(message) {
//     console.log("Call_box_alert_message_success")
//     $("span", "#alert_message_succeed").text(message)
//     $("#alert_message_succeed").slideDown(200);
//     setTimeout(function () {
//         $("#alert_message_succeed").slideUp(100);
//     }, 30000);
// }

function Call_box_alert_message_failed(message) {
    console.log("Call_box_alert_message_failed")
    $("span", "#alert_message_failed").text(message)
    $("#alert_message_failed").slideDown(200);

    setTimeout(function () {
        $("#alert_message_failed").slideUp(50);
    }, 3000);
}

