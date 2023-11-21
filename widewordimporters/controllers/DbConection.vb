
Imports System.Data.SqlClient
''' <summary>
''' This database will help to connect to database
''' With the connection String and the query method
''' </summary>
Public Class DbConection
    Private CadenaConexion As String = "Data Source=DESKTOP-L9ULFQC;Initial Catalog=sampleDB;User ID=sa;Password=12345678"

    Public Property Conexion As SqlConnection


    Public Sub New()
        Conexion = New SqlConnection(CadenaConexion)
    End Sub

    ''Sub proceso para abrir una conexion
    Public Sub AbrirConexion()
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                '' MsgBox("Conexion exitosa")

            End If
        Catch ex As Exception
            MsgBox("Error al abrir una conexion a la base de datos: " & ex.Message)
        End Try
    End Sub

    Public Sub CerrarConexion()
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
                '' MsgBox("Conexion cerrada")
            End If
        Catch ex As Exception
            MsgBox("Error al cerrar la conexion" & ex.Message)
        End Try
    End Sub

End Class
