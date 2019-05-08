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

    //$("#theme").bind("change", function () {
    //    $.ajax({
    //        url: "/Intern/GetComments",
    //        type: "Get",
    //        data: ({ themeId: $('#theme').val() }),
    //        datatype: "json",
    //        success: function (data) {
    //            pageNr = 0;
    //            $("#allcomments").empty();
    //            $("#MoreComments").show();
    //            try {
    //                $("#endMarks").remove();
    //            }
    //            catch (Exception) {

    //            }

    //            $.each(data.comments, function (i, item) {
    //                //$('#allcomments').append("<b>" + item.eMail + "</b> : " + item.content + " <small class='text-muted'> (" + item.dateComment + ")</span><br/>");
    //                var classcomment = "";
    //                if (item.eMail=='@Model.PersonalData.EMail') classcomment = "my-comment";
    //                else classcomment = "other-comment";
    //                $('#allcomments').append("<div class='" + classcomment + "'><b>" + item.eMail + "</b> : "
    //                    + item.content + " <small class='text-muted'> (" + item.dateComment + ")</span></div>");
    //            });
    //        },
    //        error: function (data) {
    //            alert("error");
    //        }
    //    });
    //});

    //$("#MoreComments").hide();

    //$("#submitComment").click(function () {
    //    $.ajax({
    //        url: "/Intern/SubmitComment",
    //        type: "POST",
    //        data: ({ comment: $("#myComment").val(), themeId: $("#theme").val() }),
    //        datatype: "html",
    //        success: function () {
    //            $("#allcomments").prepend("<div class='my-comment'>" +
    //                "<img src='~/imgs/about.jpg' style='width:30px;height:30px;border-radius:200px;'/> " +
    //                "<b>@Model.PersonalData.EMail</b><span class='text-body'> : " + $("#myComment").val() +
    //                " </span><small class='text-muted'>(@DateTime.Now.ToString())</span></div>");
    //            $("#myComment").val("");
    //        },
    //        error: function () {
    //            alert("Error! Choose a theme!");
    //        }
    //    });
    //});
    
    //$("#MoreComments").click(function () {
    //    pageNr++;
    //    $.ajax({
    //        url: "/Intern/GetMoreComments",
    //        type: "GET",
    //        data: ({ themeId: $("#theme").val(), pageNr: pageNr }),
    //        datatype: "application/json",
    //        success: function (data) {
    //            if (data.length < 10) {
    //                $("#bottom-div").prepend("<span class='text-danger' id='endMarks'>Don't exist more comments!</span>");
    //                $("#MoreComments").hide();
    //            }
    //            $.each(data, function (i, item) {
    //                $('#allcomments').append("<div class='other-comment'><b>" + item.eMail + "</b> : "
    //                    + item.content + " <small class='text-muted'> (" + item.dateComment + ")</span></div>");
    //                @*var class=@(Model.PersonalData.EMail.Equals("qwe") ? "'my-comment'" : "'other-comment'");
    //                $("#allcomments").append("<div class=" + class+ ">" +
    //                    +"<img src='~/imgs/about.jpg' style='width:30px; height:30px; border-radius:200px;'/> <b>" + item.EMail + "</b> <span class='text-body'> : " + item.content + " </span> <small class='text-muted text-right'>(" + item.dateComment + ")</small>" +
    //                    +"</div>");*@
    //                });
    //        }
    //    });
    //});
});
