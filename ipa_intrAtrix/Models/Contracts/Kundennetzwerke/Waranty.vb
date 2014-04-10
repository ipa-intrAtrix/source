Namespace Models.Contracts.Kundennetzwerke
    Public Class Waranty


        Private _warantyId As Integer
        Private _warantyDescr As String

        Public Overridable Property WarantyId() As Integer
            Get
                Return _warantyId
            End Get
            Set(value As Integer)
                _warantyId = value
            End Set
        End Property

        Public Overridable Property WarantyDescr() As Integer
            Get
                Return _warantyDescr
            End Get
            Set(value As Integer)
                _warantyDescr = value
            End Set
        End Property


    End Class
End Namespace