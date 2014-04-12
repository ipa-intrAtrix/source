Namespace Models.Contracts
    Public Class LoginData
        Private _loginDataId As Integer
        Private _username As String
        Private _password As String


        Public Overridable Property LoginDataId() As Integer
            Get
                Return _loginDataId
            End Get
            Set(value As Integer)
                _loginDataId = value
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

        Public Overridable Property Password() As String
            Get
                Return _password
            End Get
            Set(value As String)
                _password = value
            End Set
        End Property


    End Class
End Namespace