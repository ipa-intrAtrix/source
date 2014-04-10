Imports ipa_intrAtrix.Models.Contracts.AuthorisierteBenutzer

Namespace Models.Contracts.Lieferantenangaben
    Public Class Provider
        Private _providerId As Integer
        Private _company As String
        Private _lockbox As String
        Private _customerRef As String
        Private _providerContact As IList(Of ProviderContact)
        Private _authorized As Users
        Private _place As Place
        Private _logindata As LoginData

        Public Overridable Property ProviderId() As Integer
            Get
                Return _providerId
            End Get
            Set(value As Integer)
                _providerId = value
            End Set
        End Property

        Public Overridable Property Company() As String
            Get
                Return _company
            End Get
            Set(value As String)
                _company = value
            End Set
        End Property

        Public Overridable Property LockBox() As String
            Get
                Return _lockbox
            End Get
            Set(value As String)
                _lockbox = value
            End Set
        End Property

        Public Overridable Property CustomerRef() As String
            Get
                Return _customerRef
            End Get
            Set(value As String)
                _customerRef = value
            End Set
        End Property

        Protected Overridable Property ProviderContact() As IList(Of ProviderContact)
            Get
                Return _providerContact
            End Get
            Set(value As IList(Of ProviderContact))
                _providerContact = value
            End Set
        End Property

        Public Overridable Property Authorized() As Users
            Get
                Return _authorized
            End Get
            Set(value As Users)
                _authorized = value
            End Set
        End Property

        Public Overridable Property Place() As Place
            Get
                Return _place
            End Get
            Set(value As Place)
                _place = value
            End Set
        End Property

        Public Overridable Property LoginData() As LoginData
            Get
                Return _logindata
            End Get
            Set(value As LoginData)
                _logindata = value
            End Set
        End Property




    End Class
End Namespace