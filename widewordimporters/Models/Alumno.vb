Public Class Alumno
    Private _Id As Integer
    Private _nombre As String
    Private _NumeroTelefonico As String
    Private _correoElectronico As String
    Private _direccion As String

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property NumeroTelefonico As String
        Get
            Return _NumeroTelefonico
        End Get
        Set(value As String)
            _NumeroTelefonico = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property CorreoElectronico As String
        Get
            Return _correoElectronico
        End Get
        Set(value As String)
            _correoElectronico = value
        End Set
    End Property
End Class
