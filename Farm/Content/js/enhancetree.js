/**
 * Created by Administrator on 2016/12/6.
 */
$.fn.tree.defaults.loadFilter = function (data, parent) {
    var opt = $(this).data().tree.options;
    var idField,textField,parentField;
    if (opt.parentField) {
        idField = opt.idField || 'id';
        textField = opt.textField || 'text';
        parentField = opt.parentField || 'pid';
        var i,l,treeData = [],tmpMap = [];
        for (i = 0, l = data.length; i < l; i++) {
            tmpMap[data[i][idField]] = data[i];
        }
        for (i = 0, l = data.length; i < l; i++) {
            if (tmpMap[data[i][parentField]] && data[i][idField] != data[i][parentField]) {
                if (!tmpMap[data[i][parentField]]['children'])
                    tmpMap[data[i][parentField]]['children'] = [];
                data[i]['text'] = data[i][textField];
                tmpMap[data[i][parentField]]['children'].push(data[i]);
            } else {
                data[i]['text'] = data[i][textField];
                treeData.push(data[i]);
            }
        }
        return treeData;
    }
    return data;
};



