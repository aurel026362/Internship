$('#myTab li:first-child a');
$('#myTab li:first-child a');
$('#myTab li:last-child a');
$('#myTab li:nth-child(3) a');

$(document).ready(function () {
    $("#PersonalData").bind("click", function () {
        var obj = ({
            FirstName: $("#FName").val(),
            LastName: $("#LName").val(),
            PhoneNumber: $("#PhoneNumber").val(),
            DateOfBirth: $("#DateBirth").val()
        });
        $.ajax({
            url: "/Intern/EditData",
            type: "POST",
            data: obj,
            datatype: "json",
            success: function () {
            }
        });
    });

    $("#theme").bind("change", function () {
        alert($('#theme').val());
        $.ajax({
            url: "/Intern/GetComments",
            type: "Get",
            data: ({ themeId: $('#theme').val() }),
            datatype: "json",
            success: function (data) {
                //alert("success");
                $("#comment-div").html(data);
            },
            error: function (data) {
                alert("error");
            }
        });
    });
    //    $.get("/Intern/GetComments", { themeId: $('#theme').val() })
    //        .done(function (data) {
    //            $("#comment-div").html(data);
    //        })
    //        .fail(function (data) {
    //        })
    //        .always(function () {
    //        });
    //});
});
