Imports ipa_intrAtrix.Models.Contracts
Imports ipa_intrAtrix.Models

Public Class CustomerController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Customer
    Function Index() As ActionResult
        Dim customerHelper As New CustomerHelper
        Return View(customerHelper.GetCustomerNetworks())
    End Function

    '
    ' GET: /Customer/Details/5
    Function Details(ByVal id As Integer) As ActionResult
        Dim customerHelper As New CustomerHelper
        Return View(customerHelper.GetCustomerNetworkById(id))
    End Function


    '
    ' GET: /Customer/Create
    Function Create() As ActionResult
        Dim customerNetwork As New CustomerNetwork
        Return View(customerNetwork)
    End Function

    '
    ' POST: /Customer/Create
    <HttpPost()> _
    Function Create(customerNetwork As CustomerNetwork) As ActionResult
        Try
            Dim customerHelper As New CustomerHelper
            customerHelper.CreateCustomerNetwork(customerNetwork)

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function



    '
    ' GET: /Customer/Edit/5
    Function Edit(ByVal id As Integer) As ActionResult
        Dim customerHelper As New CustomerHelper
        Dim customerNetwork = customerHelper.GetCustomerNetworkById(id)

        If IsNothing(customerNetwork) Then
            Return HttpNotFound()
        End If

        Return View(customerNetwork)
    End Function

    '
    ' POST: /Customer/Edit/5
    <HttpPost()> _
    Function Edit(ByVal id As Integer, customerNetwork As CustomerNetwork) As ActionResult
        Try
            Dim customerHelper As New CustomerHelper
            Dim customerDb = customerHelper.GetCustomerNetworkById(id)

            customerDb.SpiderId = customerNetwork.SpiderId
            customerDb.InternalDescr = customerNetwork.InternalDescr
            customerDb.Schema = customerNetwork.Schema
            customerDb.Starting = customerNetwork.Starting
            customerDb.Shutdown = customerNetwork.Shutdown
            customerDb.WarantyExp = customerNetwork.WarantyExp
            customerDb.Waranty = customerNetwork.Waranty

            customerHelper.UpdateCustomerNetwork(customerDb)

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' GET: /Customer/Delete/5
    Function Delete(ByVal id As Integer) As ActionResult
        Dim customerHelper As New CustomerHelper

        Return View(customerHelper.GetCustomerNetworkById(id))
    End Function

    '
    ' POST: /Customer/Delete/5
    <HttpPost()> _
    Function Delete(ByVal id As Integer, customerNetwork As CustomerNetwork) As ActionResult
        Try
            Dim customerHelper As New CustomerHelper
            customerHelper.DeleteCustomerNetwork(customerNetwork)

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class