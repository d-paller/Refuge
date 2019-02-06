$(".classDeleteBtn").click(function () {
    var classId = $(this).data("class-id");

    $("#classCardBody-" + classId).hide();
    $("#confirmDeleteClass-" + classId).show();

    $(".cancelDelete").click(function () {
        $("#classCardBody-" + classId).show();
        $("#confirmDeleteClass-" + classId).hide();
    });
});

$(".studentDeleteBtn").click(function () {
    var sId = $(this).data("student-id");

    $("#studentCardBody-" + sId).hide();
    $("#confirmDeleteStudent-" + sId).show();

    $(".cancelDelete").click(function () {
        $("#studentCardBody-" + sId).show();
        $("#confirmDeleteStudent-" + sId).hide();
    });
});

$(".logStudentOut").click(function () {
    var id = $(this).data("id");
    var date = $("#date-" + id).val();
    var time = $("#time-" + id).val();

    var datetime = date + " " + time;
    $.ajax({
        url: "/Admin/LogStudentOut",
        data: {
            id: id,
            datetime: datetime
        },
        type: 'POST',
        success: function () {
            $('#logout-' + id).modal('hide');
        }
    });
});