Imports System.Data.SqlClient

Public Class CitiesController

    Public Function listarStados(conexion As DbConection) As List(Of String)

        conexion.AbrirConexion()

        Dim query As String = "Select * from States"

        Dim Resultado As New DataTable()

        Try
            Using adaptador As New SqlDataAdapter(query, conexion.Conexion)
                adaptador.Fill(Resultado)
            End Using

            Dim nombresFormateados As New List(Of String)

            For i As Integer = 0 To Resultado.Rows.Count - 1
                Dim nombre As String = Resultado.Rows(i).Field(Of String)("Name")
                nombresFormateados.Add($"{i + 1}. {nombre}")
            Next

            conexion.CerrarConexion()
            Return nombresFormateados
        Catch ex As Exception
            Return New List(Of String)
        End Try
    End Function

    Public Function LLenadoDeTablaCiudades(conexion As DbConection) As DataTable
        Try
            conexion.AbrirConexion()

            Dim query As String = "SELECT Cities.id, Cities.Name as 'Ciudad', States.Name as 'Estado' FROM Cities INNER JOIN States on States.Id = State_Id"

            Dim ResultSet As New DataTable()

            Using result As New SqlDataAdapter(query, conexion.Conexion)
                result.Fill(ResultSet)
            End Using

            conexion.CerrarConexion()
            Return ResultSet
        Catch ex As Exception
            ''print el error
            Return New DataTable()
        End Try
    End Function

    Public Sub AgregarRegistro(citi As CIty, conexion As DbConection)
        conexion.AbrirConexion()

        Dim query As String = "INSERT INTO Cities (Name, State_id) values (@name, @state_id)"

        Try
            Using command As New SqlCommand(query, conexion.Conexion)
                command.Parameters.AddWithValue("@name", citi.Name)
                command.Parameters.AddWithValue("@state_id", citi.State_id)

                command.ExecuteNonQuery()
            End Using
            conexion.CerrarConexion()
            MsgBox("ingresado con exito")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

End Class
