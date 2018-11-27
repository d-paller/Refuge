$(".classDeleteBtn").click(function () {
    var classId = $(this).data("class-id");

    $("#classCardBody-" + classId).hide();
    $("#confirmDeleteClass-" + classId).show();

    $(".cancelDeleteClass").click(function () {
        $("#classCardBody-" + classId).show();
        $("#confirmDeleteClass-" + classId).hide();
    });
});