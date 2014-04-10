Namespace Models.Contracts.Lieferantenangaben
    Public Class ProviderContact
        Private _provContId As Integer
        Private _contact As Contact
        Private _provider As Provider

        Public Overridable Property ProvContId() As Integer
            Get
                Return _provContId
            End Get
            Set(value As Integer)
                _provContId = value
            End Set
        End Property
        Public Overridable Property Contact() As Contact
            Get
                Return _contact
            End Get
            Set(value As Contact)
                _contact = value
            End Set
        End Property
        Public Overridable Property Provider() As Provider
            Get
                Return _provider
            End Get
            Set(value As Provider)
                _provider = value
            End Set
        End Property

    End Class
End Namespace