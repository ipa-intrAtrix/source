Namespace Models.Contracts.Kundennetzwerke

    Public Class CustomerNetwork

        Private _custId As Integer
        Private _spiderId As String
        Private _internalDescr As String
        Private _schema As String
        Private _starting As Date
        Private _shutdown As Date
        Private _warantyExp As Date
        Private _waranty As Waranty



        Public Overridable Property CustId() As Integer
            Get
                Return _custId
            End Get
            Set(value As Integer)
                _custId = value
            End Set
        End Property


        Public Overridable Property SpiderId() As String
            Get
                Return _spiderId
            End Get
            Set(value As String)
                _spiderId = value
            End Set
        End Property

        Public Overridable Property InternalDescr() As String
            Get
                Return _internalDescr
            End Get
            Set(value As String)
                _internalDescr = value
            End Set
        End Property

        Public Overridable Property Schema() As String
            Get
                Return _schema
            End Get
            Set(value As String)
                _schema = value
            End Set
        End Property

        Public Overridable Property Starting() As Date
            Get
                Return _starting
            End Get
            Set(value As Date)
                _starting = value
            End Set
        End Property

        Public Overridable Property Shutdown() As Date
            Get
                Return _shutdown
            End Get
            Set(value As Date)
                _shutdown = value
            End Set
        End Property

        Public Overridable Property WarantyExp() As Date
            Get
                Return _warantyExp
            End Get
            Set(value As Date)
                _warantyExp = value
            End Set
        End Property

        Public Overridable Property Waranty() As Waranty
            Get
                Return _waranty
            End Get
            Set(value As Waranty)
                _waranty = value
            End Set
        End Property

    End Class
End Namespace