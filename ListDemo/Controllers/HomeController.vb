Imports System.Web.Mvc
Imports ListDemo.Models

Namespace Controllers
    Public Class HomeController
        Inherits System.Web.Mvc.Controller


        Function Index() As ActionResult
            Dim model = New EmployeeListModel()
            model.Employees = New List(Of EmployeeModel) From
            {
                New EmployeeModel() With {.IsChecked = False, .EmployeeId = "X001", .EmployeeName = "Mike"},
                New EmployeeModel() With {.IsChecked = True, .EmployeeId = "X002", .EmployeeName = "Tom"},
                New EmployeeModel() With {.IsChecked = True, .EmployeeId = "Y001", .EmployeeName = "Smith"},
                New EmployeeModel() With {.IsChecked = False, .EmployeeId = "Z001", .EmployeeName = "Kevin"}
            }
            Return View(model)
            'Return View()
        End Function

        Function About() As ActionResult
            ViewData("Message") = "Your application description page."

            Return View()
        End Function

        Function Contact() As ActionResult
            ViewData("Message") = "Your contact page."

            Return View()
        End Function
        Function SendResult(ByVal model As EmployeeListModel) As ActionResult
            Return View(model)
        End Function
        Function JpGrid() As ActionResult
            ViewData("Message") = "jpGrid."

            Return View()
        End Function
    End Class
End Namespace
