Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim csv As StringBuilder = New StringBuilder()
        csv.Append(String.Format("{0},{1},{2}", "Company", "Name", "EmailAddress") & Environment.NewLine)

        Dim list As List(Of Customer) = Customer.CreateList()

        For Each c As Customer In list
            csv.Append(String.Format("{0},{1},{2}", c.Company, c.Name, c.EmailAddress) & Environment.NewLine)
        Next

        ViewBag.CsvReport = csv

        Return View()

    End Function

End Class
