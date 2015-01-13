function RegisterComboBoxValidation(form) {
    var comboBoxs = form.find(".t-combobox");

    $.each(comboBoxs, function (index, item) {
        var comboBox = $($(item).find("input:hidden")[0]);
        if (comboBox.val() == "" || comboBox.val() == "-1") {
            var comboBoxId = comboBox.attr("id");

            $("#" + comboBoxId).bind('valueChange', function (e) {
                if (e.value > 0) {
                    var errorElement = $(form).find("[data-valmsg-for='" + comboBoxId + "']");
                    errorElement.removeClass("field-validation-error");
                    errorElement.addClass("field-validation-valid");
                    errorElement.html("");
                }
                else {
                    var errorMessage = $("#" + comboBoxId).attr("data-val-required");
                    var errorElement = $(form).find("[data-valmsg-for='" + comboBoxId + "']");
                    errorElement.removeClass("field-validation-valid");
                    errorElement.addClass("field-validation-error");
                    errorElement.html(errorMessage);
                }
            });
        }
    });
}

function validateComboBox(form) {
    var comboBoxs = form.find(".t-combobox");
    var falseCounter = 0;
    $.each(comboBoxs, function (index, item) {
        var comboBox = $($(item).find("input:hidden")[0]).data("tComboBox");
        var selectedItem = GetComboboxSelectedItem(comboBox);
        if (selectedItem.Value == "" || selectedItem.Value == "-1") {
            var comboBoxId = comboBox.element.id;
            var errorMessage = $("#" + comboBoxId).attr("data-val-required");
            var errorElement = $(form).find("[data-valmsg-for='" + comboBoxId + "']");

            if (!$("#" + comboBoxId).parent().hasClass("mutiSelectCombo")) {
                if (errorElement.length > 0) {
                    errorElement.removeClass("field-validation-valid");
                    errorElement.addClass("field-validation-error");
                    errorElement.html(errorMessage);
                    falseCounter++;
                }
            }
            else {
                if (errorElement.length > 0) {
                    var comboIds = trim($("#" + comboBoxId + "Ids").val());
                    if (comboIds == "") {
                        errorElement.removeClass("field-validation-valid");
                        errorElement.addClass("field-validation-error");
                        errorElement.html(errorMessage);
                        falseCounter++;
                    }
                }
            }
        }
    });

    if (falseCounter > 0)
        return false;
    else
        return true;
}

function trim(str) {
    if (!str || typeof str != 'string')
        return '';
    return str.replace(/^[\s]+/, '').replace(/[\s]+$/, '').replace(/[\s]{2,}/, ' ');
}

/* Converts JSON Object to string */
function ConvertJsonObjectToString(o) {

    var parse = function (_o) {
        var a = [], t;
        for (var p in _o) {
            if (_o.hasOwnProperty(p)) {
                var property = "\"" + p.toString().replace("\\", "\\\\") + "\""
                t = _o[p];
                if (t == null)
                    t = "";
                if (t && typeof t == "object") {

                    a[a.length] = "{ " + arguments.callee(t).join(", ") + "}";
                }
                else {
                    if (typeof t == "string") {
                        if (t.toString().indexOf("<") < 0 || t.toString().indexOf(">") < 0) {
                            a[a.length] = [property + ": \"" + t.toString().replace("\\", "\\\\") + "\""];
                        }
                        else {
                            a[a.length] = [property + ": \"" + "" + "\""];
                        }
                    }
                    else {
                        a[a.length] = [property + ": " + t.toString().replace("\\", "\\\\")];
                    }
                }
            }
        }
        return a;
    }

    return "[" + parse(o).join(", ") + "]";
}


/* Converts JSON Object to string */


function ShowLoading() {
    $("#load-mask-div").height($(document).height());



    $("#load-mask-div").addClass('load-mask-div');
    $("#load-mask-div").show();
}
function HideLoading() {
    $("#load-mask-div").removeClass('load-mask-div');
    $("#load-mask-div").hide();
}

function CollapseGroups(e) {
    ShowLoading();
    $('.t-grid-content').hide();
    setTimeout(function () {
        /* collapse all row if any*/
        var table = $('.t-grid-content')[0];

        var hasGrouping = $('.t-grid-content').find('.t-grouping-row')
        if (hasGrouping.length == 0) {
            $('.t-grid-content').show();
            return;
        }
        var trs = table.getElementsByTagName('tr');
        $.each(trs, function (i, item) {
            if (item.className == "t-grouping-row") {
                var anchors = item.getElementsByTagName('a');
                anchors[0].className = "t-icon t-icon t-expand";
                if (item.childNodes[0].className == 't-group-cell')
                    item.style.display = "none";
            }
            else {
                item.style.display = "none";
            }
        });
        $('.t-grid-content').show();
    }, 200);
    HideLoading();
}


/* Hide Common Message Region */
setInterval('HideCommonMessageRegion()', 1000);
var valTimer = -1;
function HideCommonMessageRegion() {
    if (trim($("#commonErrorRegion").html()) != "") {
        if (valTimer < 0)
            valTimer = 5000;
    }
    HideMessageRegion();
}

function HideMessageRegion() {
    if (valTimer == 0) {
        $("#commonErrorRegion").html("");
        $("#commonErrorRegion").hide();
        valTimer = -1;
    }
    else {
        valTimer = valTimer - 1000;
    }
}
/* Hide Common Message Region */

function DisableFormControls(container) {
    var texts = $(container).find("input[type=text]");
    $.each(texts, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
    var textareas = $(container).find("textarea");
    $.each(textareas, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
    var teleriks = $(container).find("div");
    $.each(teleriks, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
    var passwords = $(container).filter("input[type=password]");
    $.each(passwords, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
    var checkboxes = $(container).find("input[type=checkbox]");
    $.each(checkboxes, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
}


function onEnterClickButton(e, buttonid) {
    var evt = e ? e : window.event;
    var bt = document.getElementById(buttonid);
    if (bt) {
        if (evt.keyCode == 13) {
            if (bt.tagName == 'A')
                $(bt).click();
            else
                bt.click();
            return false;
        }
    }
}

function OpenDocument(documentPath) {
    if (documentPath == ICLComResource.msgFileNotFound) {
        alert(documentPath)
    }
    else {
        window.open(documentPath);
    }
}

/* Set Validation Sucess Message */

function SetValidationSuccessMessage(message) {

    $("#commonErrorRegion").show();

    var messageHtml = "<div style=\"background: none repeat scroll 0 0 lightyellow; border: 1px solid #DADADA; display: block; margin: 10px; padding: 5px 5px 0;\">"
                  + "<ul style=\"list-style: disc; margin-left: 25px; color: green;\">"
                           + "<li>" + message + "</li>"
                  + "</ul>";
    + "</div>";

    $("#commonErrorRegion").html(messageHtml);
}

function SetValidationErrorMessage(message) {

    $("#commonErrorRegion").show();

    var messageHtml = "<div style=\"background: none repeat scroll 0 0 lightyellow; border: 1px solid #DADADA; display: block; margin: 10px; padding: 5px 5px 0;\">"
                     + "<ul style=\"list-style: disc; margin-left: 25px; color: red;\">"
                              + "<li>" + message + "</li>"
                     + "</ul>";
    + "</div>";

    $("#commonErrorRegion").html(messageHtml);
}

function SetMultipleValidationErrorMessage(messages) {

    $("#commonErrorRegion").show();

    var messageHtml = "<div style=\"background: none repeat scroll 0 0 lightyellow; border: 1px solid #DADADA; display: block; margin: 10px; padding: 5px 5px 0;\">";
    messageHtml = messageHtml + "<ul style=\"list-style: disc; margin-left: 25px; color: red;\">";

    $.each(messages, function (index, message) {
        messageHtml = messageHtml + "<li>" + message + "</li>";
    });

    messageHtml = messageHtml + "</ul>";
    messageHtml = messageHtml + "</div>";

    $("#commonErrorRegion").html(messageHtml);
}


/* Set Validation Sucess Message */

/* Combobox Methods : Get Selected Item */

function GetComboboxSelectedItem(comboBox) {

    var nullObject = { Value: -1, Text: "" };

    if (comboBox == null || comboBox == undefined || comboBox.data == null || comboBox.data == undefined)
        return nullObject;

    if ($("#" + comboBox.element.id).parent().hasClass("mutiSelectCombo"))
        return nullObject;

    var value = comboBox.value();
    var text = comboBox.text();

    var object = searchSelectedObject(comboBox.data, value);

    if (object == undefined || object == null)
        return nullObject;

    var selectedItemText = escapeExpression(object.Text);

    if (selectedItemText == text && object.Value == value) {
        return object;
    }

    return nullObject;
}

function searchSelectedObject(obj, val) {
    for (var index = 0; index < obj.length; index++) {
        if (obj[index].Value == val) {
            return obj[index];
        }
    }
    return { Value: -1, Text: "" };
}

/* Combobox Methods : Get Selected Item */

/* Checked Combobox Methods */

function GetComboboxCheckedItemValues(comboBox) {

    var checkedValues = "";

    if (comboBox == null || comboBox == undefined || comboBox.data == null || comboBox.data == undefined)
        return checkedValues;

    var comboBoxData = comboBox.data;

    $.each(comboBoxData, function (index, item) {
        var checkBoxItem = $(item.Text);
        var checkBoxId = checkBoxItem.attr("id");
        if ($("#" + checkBoxId).is(":checked") == true) {
            if (checkedValues == "")
                checkedValues = item.Value;
            else
                checkedValues = checkedValues + "," + item.Value;
        }
    });

    return checkedValues;
}

function GetComboboxCheckedItemText(comboBox) {

    var checkedText = "";

    if (comboBox == null || comboBox == undefined || comboBox.data == null || comboBox.data == undefined)
        return checkedText;

    var comboBoxData = comboBox.data;

    $.each(comboBoxData, function (index, item) {
        var checkBoxItem = $(item.Text);
        var checkBoxId = checkBoxItem.attr("id");
        if ($("#" + checkBoxId).is(":checked") == true) {
            if (item.Value != "0") {
                if (checkedText == "") {
                    checkedText = GetTextFromHtml(item.Text);
                }
                else {
                    checkedText = checkedText + ", " + GetTextFromHtml(item.Text);
                }
            }
        }
    });

    return checkedText;
}

function GetComboboxSelectedItemText(comboBox) {

    var checkedText = "";

    if (comboBox == null || comboBox == undefined || comboBox.data == null || comboBox.data == undefined)
        return checkedText;

    var comboBoxData = comboBox.data;

    $.each(comboBoxData, function (index, item) {
        var checkBoxItem = $(item.Text);
        var checkBoxId = checkBoxItem.attr("id");
        if ($("#" + checkBoxId).is(":checked") == true) {
            if (item.Value != "-1") {
                if (checkedText == "") {
                    checkedText = GetTextFromHtml(item.Text);
                }
                else {
                    checkedText = checkedText + ", " + GetTextFromHtml(item.Text);
                }
            }
        }
    });

    return checkedText;
}

function GetAllCheckBoxText(comboBox) {
    var checkedText = "";

    if (comboBox == null || comboBox == undefined || comboBox.data == null || comboBox.data == undefined)
        return checkedText;

    var comboBoxData = comboBox.data;

    $.each(comboBoxData, function (index, item) {
        if (item.Value != "0") {
            if (checkedText == "") {
                checkedText = GetTextFromHtml(item.Text);
            }
            else {
                checkedText = checkedText + ", " + GetTextFromHtml(item.Text);
            }
        }
    });

    return checkedText;
}

function GetAllSelectedCheckBoxText(comboBox) {
    var checkedText = "";

    if (comboBox == null || comboBox == undefined || comboBox.data == null || comboBox.data == undefined)
        return checkedText;

    var comboBoxData = comboBox.data;

    $.each(comboBoxData, function (index, item) {
        if (item.Value != "-1") {
            if (checkedText == "") {
                checkedText = GetTextFromHtml(item.Text);
            }
            else {
                checkedText = checkedText + ", " + GetTextFromHtml(item.Text);
            }
        }
    });

    return checkedText;
}

function GetTextFromHtml(html) {
    return escapeExpression(html);
}

function RemoveComboTextBoxHtml() {
    var comboBoxTextBoxes = $(".t-combobox").find("input[class=t-input]");
    $.each(comboBoxTextBoxes, function (index, item) {
        var textBoxValueHtml = $(item).val();
        var textBoxValueText = GetTextFromHtml(textBoxValueHtml);
        $(item).val(textBoxValueText)
    });

    var dropDownTextBoxes = $(".t-dropDownList").find("input[class=t-input]");
    $.each(dropDownTextBoxes, function (index, item) {
        var textBoxValueHtml = $(item).val();
        var textBoxValueText = GetTextFromHtml(textBoxValueHtml);
        $(item).val(textBoxValueText)
    });
}

/* Checked Combobox Methods */

function htmlEncode(value) {
    return $('<div/>').text(value).html();
}

function htmlDecode(value) {
    return $('<div/>').html(value).text();
}
function escapeExpression(value) {

    var originalValue = value;

    value = value.replace(/([#;&,\+\*\~':"\!\^$\[\]=>\|])/g, "\\$1");

    try {
        var text = $(value).text();
        if (trim(text) == "")
            value = originalValue;
        else
            value = text;
    }
    catch (e) {
        value = originalValue;
    }

    return value;
}