var loginUsername;
function Login() {
    $.getJSON("Handler/Login.ashx?action=formUser", { username: $("#username").val(), psw: $("#password").val() }, function (json) {
        // alert(json);
        loginUsername = $("#username").val()
        $("#mainframe").load("Main.html")

        
       
       // $.parser.parse($('#mainDiv').parent());
    });
}

$(document).ready(function () {
    $("#mainframe").load("Login.html")
   // $("#mainDiv").hide();
    
});
function loadMenu() {
    $.parser.parse();
    //   treeIntro
    $("#wcmName").html("您好" + loginUsername + ",欢迎登录！")
    $("#mainMenu").tree({
        url: '/Handler/Login.ashx?action=treeMenu',
        parentField: "ParentCode",
       iconCls: "IconClass",//iconCls
        textField: "MenuName",
        idField: "MenuCode",
        onClick: function (node) {
            if ($('#tt').tree('isLeaf', node.target)) {
                url = "Handler" + node.URL
                addTab(node.text, url)
            }
         }
    });
    $("#treeIntro").tree({
        url: '/Handler/Login.ashx?action=treeOrg',
        parentField: "ParentCode",
        onLoadSuccess: function () {
            $('#treeIntro').tree('collapseAll');
            var rooNode = $("#treeIntro").tree('getRoot');
            //调用expand方法
            $("#treeIntro").tree('expand', rooNode.target);
        },
        textField: "OrganizeName",
        idField: "OrganizeCode",
    });
}
var hyhCurTab = "";

function addTab(title, url) {
    if ($('#centerTab').tabs('exists', hyhCurTab)) {
        $('#centerTab').tabs('close', hyhCurTab);
    };
    hyhCurTab = title;
    if ($('#centerTab').tabs('exists', title)) {
        $('#centerTab').tabs('select', title);
    } else {
        url  +=".html"
        $('#centerTab').tabs('add', {
            title: title,
            href: url,
          //  content: content,
            closable: true
        });
    }
}
