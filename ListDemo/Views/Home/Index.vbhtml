@ModelType ListDemo.Models.EmployeeListModel

@Code
    ViewData("Title") = "Home Page"
    Dim index As Integer = 0
End Code
<head runat="server">
    <link rel="stylesheet" href="/CSS/smoothness/jquery-ui-1.10.3.custom.min.css" />
    <link rel="stylesheet" href="/CSS/ui.jqgrid.css" />
    <script src="/Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="/Scripts/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <script src="/Scripts/jquery.jqGrid.min.js" type="text/javascript"></script>
    <script src="/Scripts/i18n/grid.locale-ja.js" type="text/javascript"></script>
</head>
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

    table, td, th { border: 2px #808080 solid; }

</script>

@Using (Html.BeginForm("SendResult", "Home", FormMethod.Post))
    @<table>
        <thead>
            <tr>
                <!--<th>Checked?</th>-->
                <th>ID</th>
                <th>Name</th>
            </tr>
        </thead>
        <tbody>
            @For Each employee In Model.Employees
                @<tr>
                    <!--<td>Html.CheckBox(String.Format("Employees[{0}].IsChecked", index), employee.IsChecked)</td>-->
                    <td>@Html.TextBox(String.Format("Employees[{0}].EmployeeId", index), employee.EmployeeId)</td>
                    <td>@Html.TextBox(String.Format("Employees[{0}].EmployeeName", index), employee.EmployeeName)</td>
                </tr>
                index = index + 1
            Next
        </tbody>
    </table>
    @*@<input type="submit" value="Send" />*@
End Using
     <div>
         <table id="momoclo"></table>
     </div>


