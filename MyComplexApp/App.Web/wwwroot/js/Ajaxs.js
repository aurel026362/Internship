$('#myTab li:first-child a');
$('#myTab li:first-child a');
$('#myTab li:last-child a');
$('#myTab li:nth-child(3) a');

$(document).ready(function () {
    $('#allcomments').empty();

    $("#PersonalData").bind("click", function () {
        var obj = ({
            FirstName: $("#FName").val(),
            LastName: $("#LName").val(),
            PhoneNumber: $("#PhoneNumber").val(),
            DateOfBirth: $("#DateBirth").val()
        });
        $.ajax({
            url: "/User/EditData",
            type: "POST",
            data: obj,
            datatype: "json",
            success: function () {
            }
        });
    });


});
