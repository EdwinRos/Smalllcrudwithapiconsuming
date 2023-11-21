Imports System.Data.Entity.Core.Common
Imports System.Data.Entity.Infrastructure
Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1

    ''define a local object
    Dim Alumno As New Alumno

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CustomerName_input_TextChanged(sender As Object, e As EventArgs) Handles NewName_input.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Refactor de todo esto con una base de dato mas simple
        AgregarColumnas()
        ' Cargar los datos en la tabla
        CargarTabla()

        ''llenado de espacio de API
        FillApiTap()

    End Sub

    Private Sub FillApiTap()
        ''
        Dim url As String = "https://pokeapi.co/api/v2/pokemon/1/"
        Dim cliente As New HttpClient()
        Dim respues As String = cliente.GetStringAsync(url).Result

        Dim Datos As Object = JsonConvert.DeserializeObject(respues)

        Dim Habilidades As JArray = DirectCast(Datos("abilities"), JArray)
        Dim Nombre As Object = DirectCast(Datos("forms"), JArray)



        PokeName_label.Text = Nombre(0)("name")

        cargarImagen()

        For Each ability As Object In Habilidades
            Ataques_label.Text += ability("ability")("name") & "   "
        Next

        ''cargando tipos
        Dim urlTipos As String = "https://pokeapi.co/api/v2/pokemon-form/1/"
        Dim clienteTipos As New HttpClient()
        Dim respuestaTipos As String = clienteTipos.GetStringAsync(urlTipos).Result

        Dim DatosRespuesta As Object = JsonConvert.DeserializeObject(respuestaTipos)

        Dim RealAbilities As JArray = DirectCast(DatosRespuesta("types"), JArray)

        For Each data As Object In RealAbilities
            Tipos_label.Text += data("type")("name") & "   "
        Next


    End Sub

    ''Metodo para cargar imagenes que vienen de una url
    Private Sub cargarImagen()
        Dim urlImagen As String = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png"

        ' Crear un WebClient para descargar la imagen
        Using clienteWeb As New WebClient()
            Try
                ' Descargar la imagen desde la URL
                Dim imagenBytes As Byte() = clienteWeb.DownloadData(urlImagen)

                ' Convertir los bytes de la imagen a un objeto Image
                Using streamImagen As New IO.MemoryStream(imagenBytes)
                    Dim imagen As Image = Image.FromStream(streamImagen)
                    ' Asignar la imagen al PictureBox
                    PicturePokemon1.Image = imagen
                End Using
            Catch ex As Exception
                ' Manejar cualquier error que pueda ocurrir al descargar la imagen
                MessageBox.Show("Error al cargar la imagen: " & ex.Message)
            End Try
        End Using
    End Sub
    ''Click eveent

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomersTableAdapter.FillBy1(Me.WideWorldImportersDataSet.Customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomersTableAdapter.FillBy2(Me.WideWorldImportersDataSet.Customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy2ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then

            Dim Id = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            Dim Nombre = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Dim Phone = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            Dim Corre_electronico = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            Dim Direccion = DataGridView1.Rows(e.RowIndex).Cells(5).Value

            ''meterlos dentro del editable
            Nombre_input.Text = Nombre
            Id_textBox_disable.Text = Id
            Contacto_input.Text = Phone
            Mail_input.Text = Corre_electronico
            Direction_input.Text = Direccion

            MsgBox("Item seleccionado")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' Toda la logica para editar un registro
        Alumno.Id = Id_textBox_disable.Text
        Alumno.Nombre = Nombre_input.Text
        Alumno.NumeroTelefonico = Contacto_input.Text
        Alumno.CorreoElectronico = Mail_input.Text
        Alumno.Direccion = Direction_input.Text

        Dim _controlador As New AlumnoCrud()

        If _controlador.EditarAlumno(alumno:=Alumno, conexion:=New DbConection) Then
            MsgBox("Registro actualizado exitosamente")
            CargarTabla()
        Else
            MsgBox("Ocurrio un error")
        End If
        ''recargar tabla

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ''Hace falta validar cada uno de los campos
        Alumno.Id = NewId_input.Text
        Alumno.Nombre = NewName_input.Text
        Alumno.NumeroTelefonico = NewContact_input.Text
        Alumno.CorreoElectronico = NewMail_contact.Text
        Alumno.Direccion = NewAddress_input.Text


        Dim _controlador As New AlumnoCrud()

        If _controlador.crearNuevoAlumno(alumno:=Alumno, conexion:=New DbConection) Then
            MsgBox("Alumno ingresado exitosamente")
            CargarTabla()
        Else
            MsgBox("Ocurrio un problema en la transaccion")
        End If

    End Sub

    Private Sub CargarTabla()

        Dim conexion As New DbConection()

        ' Abrir la conexión a la base de datos
        conexion.AbrirConexion()

        ' Ejecutar la consulta
        Dim query As String = "SELECT * FROM alumnos"
        Dim resultado As New DataTable()

        Try
            ' Crear un adaptador de datos y llenar el DataTable con los resultados de la consulta
            Using adaptador As New SqlDataAdapter(query, conexion.Conexion)
                adaptador.Fill(resultado)
            End Using
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        End Try

        ' Cerrar la conexión
        conexion.CerrarConexion()

        ' Actualizar el origen de datos del DataGridView
        DataGridView1.DataSource = resultado

        ''llenando un comboBox

        Dim indiceId As Integer = DataGridView1.Columns("Id").Index
        Dim indiceNombres As Integer = DataGridView1.Columns("Nombre").Index

        ' Recorrer las filas del DataGridView y agregar los valores al ComboBox
#If False Then
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(indiceId).Value IsNot Nothing AndAlso fila.Cells(indiceNombres).Value IsNot Nothing Then
                Dim id As Integer = Convert.ToInt32(fila.Cells(indiceId).Value)
                Dim nombre As String = fila.Cells(indiceNombres).Value.ToString()

                ' Agregar el valor al ComboBox
                ComboBox1.Items.Add(nombre)
            End If
        Next
#End If
    End Sub

    Private Sub AgregarColumnas()
        ' Limpiar el DataGridView y las columnas existentes
        DataGridView1.Columns.Clear()

        ' Agregar las columnas necesarias
        ' ... (otras columnas
        ' 

        ' Agregar la columna de botones
        Dim ColumnaDeBotones As New DataGridViewButtonColumn()
        ColumnaDeBotones.HeaderText = "Acciones"
        ColumnaDeBotones.Text = "Seleccionar"
        ColumnaDeBotones.UseColumnTextForButtonValue = True
        ' Agregar la columna de botones al DataGridView
        DataGridView1.Columns.Add(ColumnaDeBotones)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ''Obtener el termino de busqueda

        Dim terminoDeBusqueda As String = DirectCast(sender, TextBox).Text

        If String.IsNullOrWhiteSpace(terminoDeBusqueda) Then
            CargarTabla()
        Else
            FiltrarTabla(terminoDeBusqueda)
        End If
    End Sub

    ''Funcion para filtrar tabla''
    Private Sub FiltrarTabla(terminoDeBusqueda As String)
        Dim vista As New DataView(DirectCast(DataGridView1.DataSource, DataTable))

        ''Aplicar el filtro al DataView
        vista.RowFilter = String.Format("Nombre LIKE '%{0}%'", terminoDeBusqueda)

        ''Actualizar el DataGridView con los resultados filtrados

        DataGridView1.DataSource = vista.ToTable()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub
End Class
