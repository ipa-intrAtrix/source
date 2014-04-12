Namespace Models.Contracts
    Public Class Users

        Private _userId As Integer
        Private _name As String
        Private _lastname As String
        Private _pc As String
        Private _ip As String
        Private _domainName As String
        Private _username As String
        Private _pass As String
        Private _provider As IList(Of Provider) = New List(Of Provider)

        Public Overridable Property UserId() As Integer
            Get
                Return _userId
            End Get
            Set(value As Integer)
                _userId = value
            End Set
        End Property

        Public Overridable Property Name() As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Public Overridable Property Lastname() As String
            Get
                Return _lastname
            End Get
            Set(value As String)
                _lastname = value
            End Set
        End Property

        Public Overridable Property Pc() As String
            Get
                Return _pc
            End Get
            Set(value As String)
                _pc = value
            End Set
        End Property

        Public Overridable Property Ip() As String
            Get
                Return _ip
            End Get
            Set(value As String)
                _ip = value
            End Set
        End Property

        Public Overridable Property DomainName() As String
            Get
                Return _domainName
            End Get
            Set(value As String)
                _domainName = value
            End Set
        End Property

        Public Overridable Property Username() As String
            Get
                Return _username
            End Get
            Set(value As String)
                _username = value
            End Set
        End Property

        Public Overridable Property Pass() As String
            Get
                Return _pass
            End Get
            Set(value As String)
                _pass = value
            End Set
        End Property


        Public Overridable Property Provider() As IList(Of Provider)
            Get
                Return _provider
            End Get
            Set(value As IList(Of Provider))
                _provider = value
            End Set
        End Property

    End Class
End Namespace