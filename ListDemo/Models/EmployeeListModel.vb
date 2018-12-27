Imports System.Collections.Generic

Namespace Models
    Public Class EmployeeListModel
        Public Property Employees As List(Of EmployeeModel)
        Public Sub New()
            Me.Employees = New List(Of EmployeeModel)
        End Sub
    End Class
End Namespace