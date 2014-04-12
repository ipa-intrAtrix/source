Imports ipa_intrAtrix.Models.Contracts
Imports ipa_intrAtrix.Models

Public Class UserController
    Inherits System.Web.Mvc.Controller

    ' ReSharper disable once FieldCanBeMadeReadOnly.Local
    Private _userData As New UserHelper
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
    Function Create(users As Users) As ActionResult
        Try
            _userData.CreateUser(users)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' POST: /UserData/Edit/5

    <HttpPost()> _
    Function Edit(ByVal id As Integer, users As Users) As ActionResult
        Try
            _userData.UpdateUser(users)
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
            Dim userData = _userData.GetUserById(id)
            _userData.DeleteUser(userData)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class