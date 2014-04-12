Imports System.Linq.Expressions
Imports ipa_intrAtrix.Models.Contracts
Imports ipa_intrAtrix.Models

Public Class ProviderController
    Inherits System.Web.Mvc.Controller

    ' ReSharper disable once FieldCanBeMadeReadOnly.Local
    Private _providerData As ProviderHelper = New ProviderHelper
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
    Function Create(provider As Provider) As ActionResult
        Try
            _providerData.CreateProvider(provider)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' POST: /ProviderData/Edit/5

    <HttpPost()> _
    Function Edit(ByVal id As Integer, provider As Provider) As ActionResult
        Try
            _providerData.UpdateProvider(provider)
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
            Dim provider = _providerData.GetProviderById(id)
            _providerData.DeleteProvider(provider)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class