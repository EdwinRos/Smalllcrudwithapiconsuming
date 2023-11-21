<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Direction_input = New System.Windows.Forms.TextBox()
        Me.Mail_input = New System.Windows.Forms.TextBox()
        Me.Contacto_input = New System.Windows.Forms.TextBox()
        Me.Nombre_input = New System.Windows.Forms.TextBox()
        Me.Id_textBox_disable = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NewId_input = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NewAddress_input = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NewContact_input = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NewMail_contact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NewName_input = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Ataques_label = New System.Windows.Forms.Label()
        Me.Tipos_label = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PokeName_label = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PicturePokemon1 = New System.Windows.Forms.PictureBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WideWorldImportersDataSet = New widewordimporters.WideWorldImportersDataSet()
        Me.CustomersTableAdapter = New widewordimporters.WideWorldImportersDataSetTableAdapters.CustomersTableAdapter()
        Me.NombreCiudad_input = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.States_comboBox = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PicturePokemon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WideWorldImportersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1741, 847)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1733, 810)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de elementos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(44, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 25)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Buscar: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(222, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(895, 29)
        Me.TextBox1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(49, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(1171, 641)
        Me.DataGridView1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "This is a mini example from a crud with VB.net"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Small crud to one table"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Direction_input)
        Me.TabPage2.Controls.Add(Me.Mail_input)
        Me.TabPage2.Controls.Add(Me.Contacto_input)
        Me.TabPage2.Controls.Add(Me.Nombre_input)
        Me.TabPage2.Controls.Add(Me.Id_textBox_disable)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1733, 810)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Direction_input
        '
        Me.Direction_input.Location = New System.Drawing.Point(682, 348)
        Me.Direction_input.Name = "Direction_input"
        Me.Direction_input.Size = New System.Drawing.Size(321, 29)
        Me.Direction_input.TabIndex = 13
        '
        'Mail_input
        '
        Me.Mail_input.Location = New System.Drawing.Point(60, 506)
        Me.Mail_input.Name = "Mail_input"
        Me.Mail_input.Size = New System.Drawing.Size(321, 29)
        Me.Mail_input.TabIndex = 12
        '
        'Contacto_input
        '
        Me.Contacto_input.Location = New System.Drawing.Point(60, 348)
        Me.Contacto_input.Name = "Contacto_input"
        Me.Contacto_input.Size = New System.Drawing.Size(321, 29)
        Me.Contacto_input.TabIndex = 10
        '
        'Nombre_input
        '
        Me.Nombre_input.Location = New System.Drawing.Point(682, 186)
        Me.Nombre_input.Name = "Nombre_input"
        Me.Nombre_input.Size = New System.Drawing.Size(321, 29)
        Me.Nombre_input.TabIndex = 9
        '
        'Id_textBox_disable
        '
        Me.Id_textBox_disable.Enabled = False
        Me.Id_textBox_disable.Location = New System.Drawing.Point(60, 186)
        Me.Id_textBox_disable.Name = "Id_textBox_disable"
        Me.Id_textBox_disable.Size = New System.Drawing.Size(321, 29)
        Me.Id_textBox_disable.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(55, 429)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 25)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Correo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(677, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 25)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Direccion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(677, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(55, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Numero de contacto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(501, 673)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(321, 57)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Eliminar registro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 673)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(321, 57)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Editar Registro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(527, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Detalles del registro seleccionado"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1733, 810)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Agregar Nuevo Registro"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewId_input)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.NewAddress_input)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.NewContact_input)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.NewMail_contact)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NewName_input)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1606, 483)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formulario"
        '
        'NewId_input
        '
        Me.NewId_input.Location = New System.Drawing.Point(30, 393)
        Me.NewId_input.Name = "NewId_input"
        Me.NewId_input.Size = New System.Drawing.Size(67, 29)
        Me.NewId_input.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(393, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 60)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Agregar nuevo registro"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(553, 233)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 25)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Direccion"
        '
        'NewAddress_input
        '
        Me.NewAddress_input.Location = New System.Drawing.Point(558, 274)
        Me.NewAddress_input.Name = "NewAddress_input"
        Me.NewAddress_input.Size = New System.Drawing.Size(412, 29)
        Me.NewAddress_input.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(553, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(187, 25)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Numero de contacto"
        '
        'NewContact_input
        '
        Me.NewContact_input.Location = New System.Drawing.Point(558, 144)
        Me.NewContact_input.Name = "NewContact_input"
        Me.NewContact_input.Size = New System.Drawing.Size(412, 29)
        Me.NewContact_input.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 25)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Correo"
        '
        'NewMail_contact
        '
        Me.NewMail_contact.Location = New System.Drawing.Point(30, 274)
        Me.NewMail_contact.Name = "NewMail_contact"
        Me.NewMail_contact.Size = New System.Drawing.Size(412, 29)
        Me.NewMail_contact.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(573, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Dentro de este formulario se pueden agregar nuevos coustomers"
        '
        'NewName_input
        '
        Me.NewName_input.Location = New System.Drawing.Point(30, 144)
        Me.NewName_input.Name = "NewName_input"
        Me.NewName_input.Size = New System.Drawing.Size(412, 29)
        Me.NewName_input.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(637, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Para agregar un nuevo registro es necesario que llene todos los campos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(726, 39)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Agregar un nuevo Elemento a la base de datos"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1733, 810)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "WebAPI"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Tipos_label)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.PokeName_label)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.PicturePokemon1)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 747)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pokemon1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Ataques_label)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 143)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ataques"
        '
        'Ataques_label
        '
        Me.Ataques_label.AutoSize = True
        Me.Ataques_label.Location = New System.Drawing.Point(20, 44)
        Me.Ataques_label.Name = "Ataques_label"
        Me.Ataques_label.Size = New System.Drawing.Size(0, 25)
        Me.Ataques_label.TabIndex = 0
        '
        'Tipos_label
        '
        Me.Tipos_label.AutoSize = True
        Me.Tipos_label.Location = New System.Drawing.Point(321, 154)
        Me.Tipos_label.Name = "Tipos_label"
        Me.Tipos_label.Size = New System.Drawing.Size(0, 25)
        Me.Tipos_label.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(232, 154)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 25)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Tipos:"
        '
        'PokeName_label
        '
        Me.PokeName_label.AutoSize = True
        Me.PokeName_label.Location = New System.Drawing.Point(331, 65)
        Me.PokeName_label.Name = "PokeName_label"
        Me.PokeName_label.Size = New System.Drawing.Size(100, 25)
        Me.PokeName_label.TabIndex = 2
        Me.PokeName_label.Text = "________"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(227, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 25)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Name: "
        '
        'PicturePokemon1
        '
        Me.PicturePokemon1.Location = New System.Drawing.Point(25, 52)
        Me.PicturePokemon1.Name = "PicturePokemon1"
        Me.PicturePokemon1.Size = New System.Drawing.Size(161, 188)
        Me.PicturePokemon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicturePokemon1.TabIndex = 0
        Me.PicturePokemon1.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.States_comboBox)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Controls.Add(Me.NombreCiudad_input)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.DataGridView2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 33)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1733, 810)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(797, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(171, 25)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Nombre de ciudad"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(802, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 61)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(31, 60)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 72
        Me.DataGridView2.RowTemplate.Height = 31
        Me.DataGridView2.Size = New System.Drawing.Size(726, 707)
        Me.DataGridView2.TabIndex = 0
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.WideWorldImportersDataSet
        '
        'WideWorldImportersDataSet
        '
        Me.WideWorldImportersDataSet.DataSetName = "WideWorldImportersDataSet"
        Me.WideWorldImportersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'NombreCiudad_input
        '
        Me.NombreCiudad_input.Location = New System.Drawing.Point(802, 103)
        Me.NombreCiudad_input.Name = "NombreCiudad_input"
        Me.NombreCiudad_input.Size = New System.Drawing.Size(239, 29)
        Me.NombreCiudad_input.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(812, 170)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 25)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Estado"
        '
        'States_comboBox
        '
        Me.States_comboBox.FormattingEnabled = True
        Me.States_comboBox.Location = New System.Drawing.Point(802, 223)
        Me.States_comboBox.Name = "States_comboBox"
        Me.States_comboBox.Size = New System.Drawing.Size(215, 32)
        Me.States_comboBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1787, 909)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Crud Basico"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PicturePokemon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WideWorldImportersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NewName_input As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents WideWorldImportersDataSet As WideWorldImportersDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As WideWorldImportersDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Id_textBox_disable As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Mail_input As TextBox
    Friend WithEvents Contacto_input As TextBox
    Friend WithEvents Nombre_input As TextBox
    Friend WithEvents Direction_input As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents NewAddress_input As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents NewContact_input As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents NewMail_contact As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents NewId_input As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PokeName_label As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PicturePokemon1 As PictureBox
    Friend WithEvents Tipos_label As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Ataques_label As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents States_comboBox As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents NombreCiudad_input As TextBox
End Class
