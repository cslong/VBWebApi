Public Class HomeController
    Inherits Microsoft.AspNetCore.Mvc.Controller

    Function Index() As Microsoft.AspNetCore.Mvc.ActionResult
        ViewData("Title") = "Home Page"

        Return View()
    End Function
End Class
