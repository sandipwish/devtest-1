@Html.Raw(ViewBag.CsvReport)
@Code
    Layout = Nothing
    Response.ContentType = "text/plain"
End Code
