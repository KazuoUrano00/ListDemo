@Code
    ViewData("Title") = "SendResult"
End Code

<script>
        $(function () {
        var data = [
            {color: "Green", name: "有安杏果" },
            {color: "Pink", name: "佐々木彩夏" },
            {color: "Red", name: "百田夏菜子" },
            {color: "Yellow", name: "玉井詩織" },
            {color: "purple", name: "高城れに" }
        ];

            $("#momoclo").jqGrid({
                data: data,
            datatype: "local",
            colNames: ['色', '名前'],
            colModel: [
                    {name: 'color' },
                    {name: 'name' }
        ],
        caption: 'ももクロ'
    });
    table, td, th { border: 2px #808080 solid; }
</script>

<h2>SendResult</h2>

<table>
    <thead>
        <tr>
            <th>Check</th>
            <th>ID</th>
            <th>Name</th>
        </tr>
    </thead>
    <tbody>
        @For Each employee In Model.Employees
            @<tr>
                <td>@employee.IsChecked</td>
                <td>@employee.EmployeeId</td>
                <td>@employee.EmployeeName</td>
            </tr>
        Next
    </tbody>
</table>
