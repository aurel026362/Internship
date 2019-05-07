function avg() {

    var total = 0,
        nr_marks = 0,
        average = 0;

    $('.tmakrs').each(function (i, item) {
        total = total + parseInt(item.innerHTML);
        nr_marks = nr_marks + 1;
    });

    average = total / nr_marks;
    $("#avgTMarks").remove();
    $('<tr id="avgTMarks">').append(
        $('<td colspan="2">').html('<b>AVG Marks: </b>'),
        $('<td>').html('<span class="text-muted"> <b>' + average + '</b></span >')
    ).appendTo("#tableBody");
}