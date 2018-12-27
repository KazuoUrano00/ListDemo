@Code
    ViewData("Title") = "jpGrid"
End Code

<!DOCTYPE html>
<script>
    $(function () {
        var data = [
            { color: "Green", name: "有安杏果" },
            { color: "Pink", name: "佐々木彩夏" },
            { color: "Red", name: "百田夏菜子" },
            { color: "Yellow", name: "玉井詩織" },
            { color: "purple", name: "高城れに" }
        ];

        $("#momoclo").jqGrid({
            data: data,
            datatype: "local",
            colNames: ['色', '名前'],
            colModel: [
                { name: 'color' },
                { name: 'name' }
            ],
            caption: 'ももクロ'
        });
    });
</script>
<html>
<head runat="server">
    <link rel="stylesheet" href="/CSS/smoothness/jquery-ui-1.10.3.custom.min.css" />
    <link rel="stylesheet" href="/CSS/ui.jqgrid.css" />
    <script src="/Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="/Scripts/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <script src="/Scripts/jquery.jqGrid.min.js" type="text/javascript"></script>
    <script src="/Scripts/i18n/grid.locale-ja.js" type="text/javascript"></script>
</head>
<body>
    <div>
        <table id="momoclo"></table>
    </div>
</body>
</html>
