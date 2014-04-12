Imports ipa_intrAtrix.Models.Contracts
Imports ipa_intrAtrix.Models

Public Class CustomerController
    Inherits System.Web.Mvc.Controller

    ' ReSharper disable once UnusedMember.Local
    Private _customerData As New CustomerHelper


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
    Function Create(customerNetwork As CustomerNetwork) As ActionResult
        Try
            _customerData.CreateCustomerNetwork(customerNetwork)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function


    '
    ' POST: /Customer/Edit/5

    <HttpPost()> _
    Function Edit(ByVal id As Integer, customerNetwork As CustomerNetwork) As ActionResult
        Try
            _customerData.UpdateCustomerNetwork(customerNetwork)
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
            Dim customerData = _customerData.GetCustomerNetworkById(id)
            _customerData.DeleteCustomerNetwork(customerData)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class