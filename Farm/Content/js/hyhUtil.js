var editIndex = undefined;
var myPageId = 0;
function ReturnYN(value, row, index) {
    if (value == 1) {
        return "是";
    } else {
        return "否";
    }
}
$(".datagrid-editable-input.datagrid-filter").on("change", function () {//筛选框中内容变化后datagrid中的内容要重新加载
    var filter = {};
    var textboxAry = $(".datagrid-editable-input.datagrid-filter");
    for (var i = 0; i < textboxAry.length; i++) {
        filter[textboxAry[i].name] = textboxAry[i].value;
    }
    filter["type"] = filter["type"];
    myDG.datagrid('reload'); //
});



function endEditing() {
    if (editIndex == undefined) { return true }
    if (myDG.datagrid('validateRow', editIndex)) {
        myDG.datagrid('endEdit', editIndex);
        editIndex = undefined;
        return true;
    } else {
        return false;
    }
}
function onClickCell(index, field) {
   
    if (editIndex != index) {
        if (endEditing()) {
            myDG.datagrid('selectRow', index)
                    .datagrid('beginEdit', index);
            var ed = myDG.datagrid('getEditor', { index: index, field: field });

            if (ed) {
                ($(ed.target).data('textbox') ? $(ed.target).textbox('textbox') : $(ed.target)).focus();
            }
            var cellEdit = myDG.datagrid('getEditor', { index: index, field: 'CreatePerson' });
            var $input = cellEdit.target; // 得到文本框对象
            $input.prop('readonly', true); // 设值只读
            editIndex = index;
        } else {
            setTimeout(function () {
                myDG.datagrid('selectRow', editIndex);
            }, 0);
        }
    }
}
function onEndEdit(index, row) {
    var ed = $(this).datagrid('getEditor', {
        index: index,
        field: 'MenuCode'
    });
    row.productname = $(ed.target).combobox('getText');
}
function append() {
    if (endEditing()) {
        myDG.datagrid('appendRow', { status: 'P' });
        editIndex = myDG.datagrid('getRows').length - 1;
        myDG.datagrid('selectRow', editIndex)
                .datagrid('beginEdit', editIndex);
    }
}
function remove() {
    var row = myDG.datagrid('getSelected');
    if (row) {
        var rowIndex = myDG.datagrid('getRowIndex', row);
        myDG.datagrid('deleteRow', rowIndex);
    }
}
function removeit() {
    myDG.datagrid('cancelEdit', editIndex)
        .datagrid('deleteRow', editIndex);
        editIndex = undefined;
        alert("数据已经删除")
    }
function accept() {
    if (endEditing()) {
        myDG.datagrid('acceptChanges');
    }
}
function mySearch() {
    myDG.datagrid('enableFilter');
}
function save() {
    endEditing()

    //endEdit();
    if (myDG.datagrid('getChanges').length) {
        var inserted = myDG.datagrid('getChanges', "inserted");
        var deleted = myDG.datagrid('getChanges', "deleted");
        var updated = myDG.datagrid('getChanges', "updated");

        var effectRow = new Object();
        if (inserted.length) {
            effectRow["inserted"] = JSON.stringify(inserted);
        }
        if (deleted.length) {
            effectRow["deleted"] = JSON.stringify(deleted);
        }
        if (updated.length) {
            effectRow["updated"] = JSON.stringify(updated);
        }

        $.post(saveUrl, effectRow, function (rsp) {
            if (rsp) {
                   if (rsp == "OK") { myDG.datagrid('reload'); }

            }
        }, "JSON").error(function () {
            alert("wrong")
            // msg.error("提交出错了！");
        });
    } else {
        msg.ok("数据未改变！");
    }

    return false;
}
function reject() {
    myDG.datagrid('rejectChanges');
    editIndex = undefined;
}
function getChanges() {
    var rows = myDG.datagrid('getChanges');
    alert(rows.length + ' rows are changed!');
}
function exportExcel() {
    var rows = myDG.datagrid('getChanges');
    alert(rows.length + ' rows are changed!');
}