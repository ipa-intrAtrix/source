Namespace Models.Contracts
    Public Class Place
        Private _placeId As Integer
        Private _name As String
        Private _postal As Integer
        Private _land As String
        Private _state As String

        Public Overridable Property PlaceId() As Integer
            Get
                Return _placeId
            End Get
            Set(value As Integer)
                _placeId = value
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

        Public Overridable Property Postal() As Integer
            Get
                Return _postal
            End Get
            Set(value As Integer)
                _postal = value
            End Set
        End Property

        Public Overridable Property Land() As String
            Get
                Return _land
            End Get
            Set(value As String)
                _land = value
            End Set
        End Property

        Public Overridable Property State() As String
            Get
                Return _state
            End Get
            Set(value As String)
                _state = value
            End Set
        End Property


    End Class
End Namespace