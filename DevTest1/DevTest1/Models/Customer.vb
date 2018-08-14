Imports TestDataGenerator

Public Class Customer

    Property Name As String
    Property EmailAddress As String
    Property Company As String

    Public Shared Function CreateList() As List(Of Customer)

        Dim catalog As New Catalog()
        Dim list As New List(Of Customer)()

        For i As Integer = 1 To 10000
            Dim cust As Customer = catalog.CreateInstance(Of Customer)()
            list.Add(cust)
        Next i

        Return list

    End Function

End Class
