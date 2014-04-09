Public Class CustomerController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Customer

    Function Index() As ActionResult
        Return View()
    End Function

    '
    ' GET: /Customer/Details/5

    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    '
    ' POST: /Customer/Create

    <HttpPost()> _
    Function Create(ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Logik
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function


    '
    ' POST: /Customer/Edit/5

    <HttpPost()> _
    Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Logik

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' POST: /Customer/Delete/5

    <HttpPost()> _
    Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Logik

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class