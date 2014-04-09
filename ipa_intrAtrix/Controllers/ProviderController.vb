Public Class ProviderController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /ProviderData

    Function Index() As ActionResult
        Return View()
    End Function

    '
    ' GET: /ProviderData/Details/5

    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    '
    ' POST: /ProviderData/Create

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
    ' POST: /ProviderData/Edit/5

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
    ' POST: /ProviderData/Delete/5

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