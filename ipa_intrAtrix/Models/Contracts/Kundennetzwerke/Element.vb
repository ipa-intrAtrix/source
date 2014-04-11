
Namespace Models.Contracts.Kundennetzwerke

    Public Class Element


        Private _elementId As Integer
        Private _element As String
        Private _elementDescr As String
        Private _customerNetwork As CustomerNetwork

        Public Overridable Property ElementId() As Integer
            Get
                Return _elementId
            End Get
            Set(value As Integer)
                _elementId = value
            End Set
        End Property

        Public Overridable Property ElementName() As String
            Get
                Return _element
            End Get
            Set(value As String)
                _element = value
            End Set
        End Property

        Public Overridable Property ElementDescr() As String
            Get
                Return _elementDescr
            End Get
            Set(value As String)
                _elementDescr = value
            End Set
        End Property

        Public Overridable Property CustomerNetwork() As CustomerNetwork
            Get
                Return _customerNetwork
            End Get
            Set(value As CustomerNetwork)
                _customerNetwork = value
            End Set
        End Property

    End Class
End Namespace