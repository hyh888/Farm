$(document).ready(function () {
    $('#accordion').accordion({
        onSelect: function (title, index) {
            console.log('选择了第' + (index + 1) + '个面板');
        }
    });
}
)