function GetAllEmployeeList() {
    var callUrl = $("#urlprefix").val() + "/Employee/_PartialEmployeeList";
    var dataToSend = null;
    $.ajax({
        cache: false,
        data: dataToSend,
        type: "POST",
        url: callUrl,
        success: function (result) {
            $("#divEmployeeListContent").html(result);
        },
        error: function (msg) {
            alert('Error' + msg.toString());
        }
    });
}
//function DeleteConfirm() {
//    confirm(OrderManagementResource.msgConfirmDeleteCategory);
//    return false;
//}


