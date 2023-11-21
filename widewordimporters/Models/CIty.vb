Public Class CIty
    Private _id As Integer
    Private _Name As String
    Private _State_id As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property State_id As Integer
        Get
            Return _State_id
        End Get
        Set(value As Integer)
            _State_id = value
        End Set
    End Property
End Class
