Public Class UserController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /UserData

    Function Index() As ActionResult
        Return View()
    End Function

    '
    ' GET: /UserData/Details/5

    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    '
    ' POST: /UserData/Create

    <HttpPost()> _
    Function Create(ByVal collection As FormCollection) As ActionResult
        Try
            'TODO: Logik
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' POST: /UserData/Edit/5

    <HttpPost()> _
    Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            'TODO: Logik

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' POST: /UserData/Delete/5

    <HttpPost()> _
    Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            'TODO: Logik

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class