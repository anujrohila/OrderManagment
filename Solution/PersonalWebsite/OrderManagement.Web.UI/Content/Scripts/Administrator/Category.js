$(document).ready(function () {
    GetAllCategory();
});

function GetAllCategory() {
    var callUrl = $("#urlprefix").val() + "/AdminCategory/_CategoryList";
    var dataToSend = null;
    $.ajax({
        cache: false,
        data: dataToSend,
        type: "POST",
        url: callUrl,
        success: function (result) {
            //$("#divCategoryList").html(result);
        },
        error: function (msg) {
            alert('Error' + msg.toString());
        }
    });
}
function DeleteConfirm() {
    confirm(OrderManagementResource.msgConfirmDeleteCategory);
    return false;
}


