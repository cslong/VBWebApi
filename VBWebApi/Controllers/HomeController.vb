Imports Microsoft.AspNetCore.Mvc

Public Class HomeController
    Inherits Microsoft.AspNetCore.Mvc.Controller

    Function Index() As Microsoft.AspNetCore.Mvc.ActionResult(Of String)
        Return "This is my default action..."
    End Function

    Function Welcome() As ActionResult(Of String)
        Return "This is the welcome action method..."
    End Function

End Class
