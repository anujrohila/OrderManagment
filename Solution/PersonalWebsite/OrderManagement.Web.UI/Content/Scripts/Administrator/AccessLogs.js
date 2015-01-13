function OnSearchClick() {
    if ($('#UserId-input').val().trim() == "") {
        alert(ICLComResource.validationSelectUser);
        return false;
    }
    else {

        var fromDate = $('#FromDate').val().trim();
        var toDate = $('#ToDate').val().trim();

        if (fromDate == "" && toDate != "") {
            alert(ICLComResource.validationSelectFromDate);
            return false;
        }
        if (fromDate != "" && toDate == "") {
            alert(ICLComResource.validationSelectToDate);
            return false;
        }
        if (fromDate != "" && toDate != "") {

            var objFromDate = fromDate.split("/");
            var objToDate = toDate.split("/");

            var obj1day = objFromDate[0];
            var obj1month = objFromDate[1];
            var obj1year = objFromDate[2];

            var obj2day = objToDate[0];
            var obj2month = objToDate[1];
            var obj2year = objToDate[2];

            var objComareFromDate = new Date(obj1year, obj1month, obj1day);
            var objComareToDate = new Date(obj2year, obj2month, obj2day);

            if (objComareFromDate > objComareToDate) {
                alert(ICLComResource.validationToDateGreaterThanFromDate);
                return false;
            }
        }
    }
    return true;
}