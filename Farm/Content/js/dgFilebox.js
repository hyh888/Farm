$.extend($.fn.datagrid.defaults.editors, {
    filebox: {
        init: function (container, options) {
            var input = $("<input />").appendTo(container);
            input.filebox(options);
            return input;
        },

        getValue: function (target) {
            return $(target).filebox("getValue");

        },
        setValue: function (target, value) {
            $(target).filebox("setValue", value);
        },
        resize: function (target, width) {
            var input = $(target);
            if ($.boxModel == true) {
                input.resize('resize', width - (input.outerWidth() - input.width()));
            } else {
                input.resize('resize', width);
            }
        }

    }
});