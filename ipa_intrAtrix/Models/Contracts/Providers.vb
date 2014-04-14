
Namespace Models.Contracts
    Public Class Providers
        Private _providerId As Integer
        Private _company As String
        Private _lockbox As String
        Private _customerRef As String
        Private _phone As String
        Private _email As String
        Private _weblink As String

        Private _contact As IList(Of Contact) = New List(Of Contact)
        Private _authorized As IList(Of Users) = New List(Of Users)
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

        Public Overridable Property Phone() As String
            Get
                Return _phone
            End Get
            Set(value As String)
                _phone = value
            End Set
        End Property

        Public Overridable Property Email() As String
            Get
                Return _email
            End Get
            Set(value As String)
                _email = value
            End Set
        End Property

        Public Overridable Property Weblink() As String
            Get
                Return _weblink
            End Get
            Set(value As String)
                _weblink = value
            End Set
        End Property

        Public Overridable Property Contact() As IList(Of Contact)
            Get
                Return _contact
            End Get
            Set(value As IList(Of Contact))
                _contact = value
            End Set
        End Property

        Public Overridable Property Authorized() As IList(Of Users)
            Get
                Return _authorized
            End Get
            Set(value As IList(Of Users))
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