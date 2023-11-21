Imports System.Data.SqlClient

Public Class AlumnoCrud

    Public Function EditarAlumno(alumno As Alumno, conexion As DbConection) As Boolean
        Try
            ''editar un elemento
            conexion.AbrirConexion()

            Dim query As String = "UPDATE Alumnos SET Nombre = @nombre, Numero_telefonico = @numero, Correo_electronico = @correo, Direccion= @direccion where id = @id"

            Using comando As New SqlCommand(query, conexion.Conexion)
                comando.Parameters.AddWithValue("@nombre", alumno.Nombre)
                comando.Parameters.AddWithValue("@numero", alumno.NumeroTelefonico)
                comando.Parameters.AddWithValue("@correo", alumno.CorreoElectronico)
                comando.Parameters.AddWithValue("@direccion", alumno.Direccion)
                comando.Parameters.AddWithValue("@id", alumno.Id)

                ''Ejecutar consulta
                comando.ExecuteNonQuery()
            End Using
            conexion.CerrarConexion()
            Return True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function crearNuevoAlumno(alumno As Alumno, conexion As DbConection) As Boolean
        Try
            conexion.AbrirConexion()

            Dim query As String = "INSERT INTO Alumnos (Id ,Nombre, Numero_telefonico, Correo_electronico, Direccion) values (@id, @nombre, @numero, @correo, @Direccion)"

            Using comando As New SqlCommand(query, conexion.Conexion)
                comando.Parameters.AddWithValue("@id", alumno.Id)
                comando.Parameters.AddWithValue("@nombre", alumno.Nombre)
                comando.Parameters.AddWithValue("@numero", alumno.NumeroTelefonico)
                comando.Parameters.AddWithValue("@correo", alumno.CorreoElectronico)
                comando.Parameters.AddWithValue("@Direccion", alumno.Direccion)

                ''Persistir a la base de datos
                comando.ExecuteNonQuery()
            End Using
            conexion.CerrarConexion()
            Return True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function eliminarRegistro(id As Integer, conexion As DbConection) As Boolean
        Try
            conexion.AbrirConexion()

            Dim query As String = "Delete from Alumnos where Id = @id"

            ''lo que falta


            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


End Class
