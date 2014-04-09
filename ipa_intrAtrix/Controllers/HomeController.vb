Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Dies ist die Startseite des Intranets von Atrix - IntrAtrix"

        Return View()
    End Function

End Class
