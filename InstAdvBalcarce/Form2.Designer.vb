<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtIdLegajo = New System.Windows.Forms.TextBox()
        Me.TablaIABBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstAdvBalcarceDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstAdvBalcarceDataSet = New InstAdvBalcarce.InstAdvBalcarceDataSet()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCalcProm = New System.Windows.Forms.Button()
        Me.LabelLegajo = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelGrado = New System.Windows.Forms.Label()
        Me.Label1T = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label2T = New System.Windows.Forms.Label()
        Me.Label3T = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnPromCursos = New System.Windows.Forms.Button()
        Me.Txt1Trimestre = New System.Windows.Forms.TextBox()
        Me.Txt2Trimestre = New System.Windows.Forms.TextBox()
        Me.Txt3Trimestre = New System.Windows.Forms.TextBox()
        Me.LabelProm = New System.Windows.Forms.Label()
        Me.TxtPromedio = New System.Windows.Forms.TextBox()
        Me.BtnIraLectura = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtProm4 = New System.Windows.Forms.TextBox()
        Me.TxtProm3 = New System.Windows.Forms.TextBox()
        Me.TxtProm2 = New System.Windows.Forms.TextBox()
        Me.TxtProm1 = New System.Windows.Forms.TextBox()
        Me.TxtProm5 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdLegajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrimestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrimestreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrimestreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prom1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prom2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prom3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prom4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prom5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablaIABBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtGrado = New System.Windows.Forms.TextBox()
        Me.TablaIABTableAdapter = New InstAdvBalcarce.InstAdvBalcarceDataSetTableAdapters.TablaIABTableAdapter()
        Me.TxtSituacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LblMPG = New System.Windows.Forms.Label()
        Me.TxtMejorPromedioGrado = New System.Windows.Forms.TextBox()
        Me.Bntcalcularmejorpromedio = New System.Windows.Forms.Button()
        CType(Me.TablaIABBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstAdvBalcarceDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstAdvBalcarceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaIABBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtIdLegajo
        '
        Me.TxtIdLegajo.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TxtIdLegajo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablaIABBindingSource1, "IdLegajo", True))
        Me.TxtIdLegajo.Location = New System.Drawing.Point(102, 173)
        Me.TxtIdLegajo.Name = "TxtIdLegajo"
        Me.TxtIdLegajo.Size = New System.Drawing.Size(110, 20)
        Me.TxtIdLegajo.TabIndex = 0
        '
        'TablaIABBindingSource1
        '
        Me.TablaIABBindingSource1.DataMember = "TablaIAB"
        Me.TablaIABBindingSource1.DataSource = Me.InstAdvBalcarceDataSetBindingSource
        '
        'InstAdvBalcarceDataSetBindingSource
        '
        Me.InstAdvBalcarceDataSetBindingSource.DataSource = Me.InstAdvBalcarceDataSet
        Me.InstAdvBalcarceDataSetBindingSource.Position = 0
        '
        'InstAdvBalcarceDataSet
        '
        Me.InstAdvBalcarceDataSet.DataSetName = "InstAdvBalcarceDataSet"
        Me.InstAdvBalcarceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(102, 214)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(110, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(102, 254)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(110, 20)
        Me.TxtApellido.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnGuardar.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(829, 387)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(91, 45)
        Me.BtnGuardar.TabIndex = 17
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCalcProm
        '
        Me.BtnCalcProm.Font = New System.Drawing.Font("Caviar Dreams", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcProm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCalcProm.Location = New System.Drawing.Point(476, 316)
        Me.BtnCalcProm.Name = "BtnCalcProm"
        Me.BtnCalcProm.Size = New System.Drawing.Size(84, 42)
        Me.BtnCalcProm.TabIndex = 11
        Me.BtnCalcProm.Text = "Calcular Promedio"
        Me.BtnCalcProm.UseVisualStyleBackColor = True
        '
        'LabelLegajo
        '
        Me.LabelLegajo.AutoSize = True
        Me.LabelLegajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelLegajo.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLegajo.ForeColor = System.Drawing.Color.White
        Me.LabelLegajo.Location = New System.Drawing.Point(14, 172)
        Me.LabelLegajo.Name = "LabelLegajo"
        Me.LabelLegajo.Size = New System.Drawing.Size(59, 19)
        Me.LabelLegajo.TabIndex = 13
        Me.LabelLegajo.Text = "Legajo"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelNombre.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.Color.White
        Me.LabelNombre.Location = New System.Drawing.Point(14, 213)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(63, 19)
        Me.LabelNombre.TabIndex = 22
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelApellido.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido.ForeColor = System.Drawing.Color.White
        Me.LabelApellido.Location = New System.Drawing.Point(14, 253)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(70, 19)
        Me.LabelApellido.TabIndex = 23
        Me.LabelApellido.Text = "Apellido"
        '
        'LabelGrado
        '
        Me.LabelGrado.AutoSize = True
        Me.LabelGrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelGrado.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGrado.ForeColor = System.Drawing.Color.White
        Me.LabelGrado.Location = New System.Drawing.Point(14, 293)
        Me.LabelGrado.Name = "LabelGrado"
        Me.LabelGrado.Size = New System.Drawing.Size(56, 19)
        Me.LabelGrado.TabIndex = 24
        Me.LabelGrado.Text = "Grado"
        '
        'Label1T
        '
        Me.Label1T.AutoSize = True
        Me.Label1T.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1T.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1T.ForeColor = System.Drawing.Color.White
        Me.Label1T.Location = New System.Drawing.Point(366, 170)
        Me.Label1T.Name = "Label1T"
        Me.Label1T.Size = New System.Drawing.Size(108, 21)
        Me.Label1T.TabIndex = 20
        Me.Label1T.Text = "1er Trimestre"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSalir.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(936, 515)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(91, 45)
        Me.BtnSalir.TabIndex = 20
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label2T
        '
        Me.Label2T.AutoSize = True
        Me.Label2T.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2T.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2T.ForeColor = System.Drawing.Color.White
        Me.Label2T.Location = New System.Drawing.Point(366, 195)
        Me.Label2T.Name = "Label2T"
        Me.Label2T.Size = New System.Drawing.Size(113, 21)
        Me.Label2T.TabIndex = 26
        Me.Label2T.Text = "2do Trimestre"
        '
        'Label3T
        '
        Me.Label3T.AutoSize = True
        Me.Label3T.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3T.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3T.ForeColor = System.Drawing.Color.White
        Me.Label3T.Location = New System.Drawing.Point(367, 221)
        Me.Label3T.Name = "Label3T"
        Me.Label3T.Size = New System.Drawing.Size(107, 21)
        Me.Label3T.TabIndex = 27
        Me.Label3T.Text = "3er Trimestre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Caviar Dreams", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(365, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 27)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Ingreso de notas"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBorrar.Location = New System.Drawing.Point(371, 316)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(84, 42)
        Me.BtnBorrar.TabIndex = 10
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnPromCursos
        '
        Me.BtnPromCursos.Font = New System.Drawing.Font("Caviar Dreams", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPromCursos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPromCursos.Location = New System.Drawing.Point(730, 316)
        Me.BtnPromCursos.Name = "BtnPromCursos"
        Me.BtnPromCursos.Size = New System.Drawing.Size(84, 42)
        Me.BtnPromCursos.TabIndex = 21
        Me.BtnPromCursos.Text = "Calcular"
        Me.BtnPromCursos.UseVisualStyleBackColor = True
        '
        'Txt1Trimestre
        '
        Me.Txt1Trimestre.Location = New System.Drawing.Point(480, 170)
        Me.Txt1Trimestre.Name = "Txt1Trimestre"
        Me.Txt1Trimestre.Size = New System.Drawing.Size(80, 20)
        Me.Txt1Trimestre.TabIndex = 5
        '
        'Txt2Trimestre
        '
        Me.Txt2Trimestre.Location = New System.Drawing.Point(480, 196)
        Me.Txt2Trimestre.Name = "Txt2Trimestre"
        Me.Txt2Trimestre.Size = New System.Drawing.Size(80, 20)
        Me.Txt2Trimestre.TabIndex = 6
        '
        'Txt3Trimestre
        '
        Me.Txt3Trimestre.Location = New System.Drawing.Point(480, 222)
        Me.Txt3Trimestre.Name = "Txt3Trimestre"
        Me.Txt3Trimestre.Size = New System.Drawing.Size(80, 20)
        Me.Txt3Trimestre.TabIndex = 7
        '
        'LabelProm
        '
        Me.LabelProm.AutoSize = True
        Me.LabelProm.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelProm.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProm.ForeColor = System.Drawing.Color.White
        Me.LabelProm.Location = New System.Drawing.Point(367, 247)
        Me.LabelProm.Name = "LabelProm"
        Me.LabelProm.Size = New System.Drawing.Size(80, 21)
        Me.LabelProm.TabIndex = 35
        Me.LabelProm.Text = "Promedio"
        '
        'TxtPromedio
        '
        Me.TxtPromedio.Location = New System.Drawing.Point(480, 248)
        Me.TxtPromedio.Name = "TxtPromedio"
        Me.TxtPromedio.Size = New System.Drawing.Size(80, 20)
        Me.TxtPromedio.TabIndex = 8
        '
        'BtnIraLectura
        '
        Me.BtnIraLectura.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnIraLectura.Font = New System.Drawing.Font("Caviar Dreams", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIraLectura.ForeColor = System.Drawing.Color.White
        Me.BtnIraLectura.Location = New System.Drawing.Point(936, 452)
        Me.BtnIraLectura.Name = "BtnIraLectura"
        Me.BtnIraLectura.Size = New System.Drawing.Size(91, 45)
        Me.BtnIraLectura.TabIndex = 19
        Me.BtnIraLectura.Text = "Ir a Lectura"
        Me.BtnIraLectura.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNuevo.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Location = New System.Drawing.Point(936, 387)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(91, 45)
        Me.BtnNuevo.TabIndex = 18
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Caviar Dreams", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(625, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 27)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Promedios Grado"
        '
        'TxtProm4
        '
        Me.TxtProm4.Location = New System.Drawing.Point(756, 247)
        Me.TxtProm4.Name = "TxtProm4"
        Me.TxtProm4.Size = New System.Drawing.Size(58, 20)
        Me.TxtProm4.TabIndex = 15
        '
        'TxtProm3
        '
        Me.TxtProm3.Location = New System.Drawing.Point(756, 221)
        Me.TxtProm3.Name = "TxtProm3"
        Me.TxtProm3.Size = New System.Drawing.Size(58, 20)
        Me.TxtProm3.TabIndex = 14
        '
        'TxtProm2
        '
        Me.TxtProm2.Location = New System.Drawing.Point(756, 195)
        Me.TxtProm2.Name = "TxtProm2"
        Me.TxtProm2.Size = New System.Drawing.Size(58, 20)
        Me.TxtProm2.TabIndex = 13
        '
        'TxtProm1
        '
        Me.TxtProm1.Location = New System.Drawing.Point(756, 168)
        Me.TxtProm1.Name = "TxtProm1"
        Me.TxtProm1.Size = New System.Drawing.Size(58, 20)
        Me.TxtProm1.TabIndex = 12
        '
        'TxtProm5
        '
        Me.TxtProm5.Location = New System.Drawing.Point(756, 273)
        Me.TxtProm5.Name = "TxtProm5"
        Me.TxtProm5.Size = New System.Drawing.Size(58, 20)
        Me.TxtProm5.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(627, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 19)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Primero"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(627, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 19)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Segundo "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(626, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 19)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Tercero"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(627, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 19)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Cuarto"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(627, 275)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 19)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Quinto "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Caviar Dreams", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(12, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(209, 27)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Ingreso de Alumnos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLegajoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.GradoDataGridViewTextBoxColumn, Me.TrimestreDataGridViewTextBoxColumn, Me.TrimestreDataGridViewTextBoxColumn1, Me.TrimestreDataGridViewTextBoxColumn2, Me.PromedioDataGridViewTextBoxColumn, Me.Prom1DataGridViewTextBoxColumn, Me.Prom2DataGridViewTextBoxColumn, Me.Prom3DataGridViewTextBoxColumn, Me.Prom4DataGridViewTextBoxColumn, Me.Prom5DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TablaIABBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 387)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("DengXian", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(800, 173)
        Me.DataGridView1.TabIndex = 51
        '
        'IdLegajoDataGridViewTextBoxColumn
        '
        Me.IdLegajoDataGridViewTextBoxColumn.DataPropertyName = "IdLegajo"
        Me.IdLegajoDataGridViewTextBoxColumn.HeaderText = "IdLegajo"
        Me.IdLegajoDataGridViewTextBoxColumn.Name = "IdLegajoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'GradoDataGridViewTextBoxColumn
        '
        Me.GradoDataGridViewTextBoxColumn.DataPropertyName = "Grado"
        Me.GradoDataGridViewTextBoxColumn.HeaderText = "Grado"
        Me.GradoDataGridViewTextBoxColumn.Name = "GradoDataGridViewTextBoxColumn"
        '
        'TrimestreDataGridViewTextBoxColumn
        '
        Me.TrimestreDataGridViewTextBoxColumn.DataPropertyName = "1Trimestre"
        Me.TrimestreDataGridViewTextBoxColumn.HeaderText = "1Trimestre"
        Me.TrimestreDataGridViewTextBoxColumn.Name = "TrimestreDataGridViewTextBoxColumn"
        '
        'TrimestreDataGridViewTextBoxColumn1
        '
        Me.TrimestreDataGridViewTextBoxColumn1.DataPropertyName = "2Trimestre"
        Me.TrimestreDataGridViewTextBoxColumn1.HeaderText = "2Trimestre"
        Me.TrimestreDataGridViewTextBoxColumn1.Name = "TrimestreDataGridViewTextBoxColumn1"
        '
        'TrimestreDataGridViewTextBoxColumn2
        '
        Me.TrimestreDataGridViewTextBoxColumn2.DataPropertyName = "3Trimestre"
        Me.TrimestreDataGridViewTextBoxColumn2.HeaderText = "3Trimestre"
        Me.TrimestreDataGridViewTextBoxColumn2.Name = "TrimestreDataGridViewTextBoxColumn2"
        '
        'PromedioDataGridViewTextBoxColumn
        '
        Me.PromedioDataGridViewTextBoxColumn.DataPropertyName = "Promedio"
        Me.PromedioDataGridViewTextBoxColumn.HeaderText = "Promedio"
        Me.PromedioDataGridViewTextBoxColumn.Name = "PromedioDataGridViewTextBoxColumn"
        '
        'Prom1DataGridViewTextBoxColumn
        '
        Me.Prom1DataGridViewTextBoxColumn.DataPropertyName = "Prom1"
        Me.Prom1DataGridViewTextBoxColumn.HeaderText = "Prom1"
        Me.Prom1DataGridViewTextBoxColumn.Name = "Prom1DataGridViewTextBoxColumn"
        '
        'Prom2DataGridViewTextBoxColumn
        '
        Me.Prom2DataGridViewTextBoxColumn.DataPropertyName = "Prom2"
        Me.Prom2DataGridViewTextBoxColumn.HeaderText = "Prom2"
        Me.Prom2DataGridViewTextBoxColumn.Name = "Prom2DataGridViewTextBoxColumn"
        '
        'Prom3DataGridViewTextBoxColumn
        '
        Me.Prom3DataGridViewTextBoxColumn.DataPropertyName = "Prom3"
        Me.Prom3DataGridViewTextBoxColumn.HeaderText = "Prom3"
        Me.Prom3DataGridViewTextBoxColumn.Name = "Prom3DataGridViewTextBoxColumn"
        '
        'Prom4DataGridViewTextBoxColumn
        '
        Me.Prom4DataGridViewTextBoxColumn.DataPropertyName = "Prom4"
        Me.Prom4DataGridViewTextBoxColumn.HeaderText = "Prom4"
        Me.Prom4DataGridViewTextBoxColumn.Name = "Prom4DataGridViewTextBoxColumn"
        '
        'Prom5DataGridViewTextBoxColumn
        '
        Me.Prom5DataGridViewTextBoxColumn.DataPropertyName = "Prom5"
        Me.Prom5DataGridViewTextBoxColumn.HeaderText = "Prom5"
        Me.Prom5DataGridViewTextBoxColumn.Name = "Prom5DataGridViewTextBoxColumn"
        '
        'TablaIABBindingSource
        '
        Me.TablaIABBindingSource.DataMember = "TablaIAB"
        Me.TablaIABBindingSource.DataSource = Me.InstAdvBalcarceDataSetBindingSource
        '
        'TxtGrado
        '
        Me.TxtGrado.Location = New System.Drawing.Point(102, 292)
        Me.TxtGrado.Name = "TxtGrado"
        Me.TxtGrado.Size = New System.Drawing.Size(110, 20)
        Me.TxtGrado.TabIndex = 3
        '
        'TablaIABTableAdapter
        '
        Me.TablaIABTableAdapter.ClearBeforeFill = True
        '
        'TxtSituacion
        '
        Me.TxtSituacion.Location = New System.Drawing.Point(480, 274)
        Me.TxtSituacion.Name = "TxtSituacion"
        Me.TxtSituacion.Size = New System.Drawing.Size(80, 20)
        Me.TxtSituacion.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(367, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Situación"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = Global.InstAdvBalcarce.My.Resources.Resources.form2_2x
        Me.PictureBox1.Location = New System.Drawing.Point(-16, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1069, 583)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Caviar Dreams", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBuscar.Location = New System.Drawing.Point(228, 172)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(84, 21)
        Me.BtnBuscar.TabIndex = 57
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnModificar.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Location = New System.Drawing.Point(829, 452)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(91, 45)
        Me.BtnModificar.TabIndex = 58
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEliminar.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(829, 515)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(91, 45)
        Me.BtnEliminar.TabIndex = 59
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'LblMPG
        '
        Me.LblMPG.AutoSize = True
        Me.LblMPG.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblMPG.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMPG.ForeColor = System.Drawing.Color.White
        Me.LblMPG.Location = New System.Drawing.Point(874, 129)
        Me.LblMPG.Name = "LblMPG"
        Me.LblMPG.Size = New System.Drawing.Size(133, 42)
        Me.LblMPG.TabIndex = 60
        Me.LblMPG.Text = "Grado con" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mejor Promedio:"
        '
        'TxtMejorPromedioGrado
        '
        Me.TxtMejorPromedioGrado.Font = New System.Drawing.Font("Caviar Dreams", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMejorPromedioGrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtMejorPromedioGrado.Location = New System.Drawing.Point(878, 192)
        Me.TxtMejorPromedioGrado.Name = "TxtMejorPromedioGrado"
        Me.TxtMejorPromedioGrado.Size = New System.Drawing.Size(129, 24)
        Me.TxtMejorPromedioGrado.TabIndex = 62
        '
        'Bntcalcularmejorpromedio
        '
        Me.Bntcalcularmejorpromedio.Font = New System.Drawing.Font("Caviar Dreams", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bntcalcularmejorpromedio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bntcalcularmejorpromedio.Location = New System.Drawing.Point(923, 237)
        Me.Bntcalcularmejorpromedio.Name = "Bntcalcularmejorpromedio"
        Me.Bntcalcularmejorpromedio.Size = New System.Drawing.Size(84, 21)
        Me.Bntcalcularmejorpromedio.TabIndex = 63
        Me.Bntcalcularmejorpromedio.Text = "Calcular"
        Me.Bntcalcularmejorpromedio.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1048, 572)
        Me.Controls.Add(Me.Bntcalcularmejorpromedio)
        Me.Controls.Add(Me.TxtMejorPromedioGrado)
        Me.Controls.Add(Me.LblMPG)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtSituacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtGrado)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtProm5)
        Me.Controls.Add(Me.TxtProm4)
        Me.Controls.Add(Me.TxtProm3)
        Me.Controls.Add(Me.TxtProm2)
        Me.Controls.Add(Me.TxtProm1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnIraLectura)
        Me.Controls.Add(Me.TxtPromedio)
        Me.Controls.Add(Me.LabelProm)
        Me.Controls.Add(Me.Txt3Trimestre)
        Me.Controls.Add(Me.Txt2Trimestre)
        Me.Controls.Add(Me.Txt1Trimestre)
        Me.Controls.Add(Me.BtnPromCursos)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3T)
        Me.Controls.Add(Me.Label2T)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1T)
        Me.Controls.Add(Me.LabelGrado)
        Me.Controls.Add(Me.LabelApellido)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelLegajo)
        Me.Controls.Add(Me.BtnCalcProm)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtIdLegajo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form2"
        Me.Text = "Ingreso Alumnos IAB"
        CType(Me.TablaIABBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstAdvBalcarceDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstAdvBalcarceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaIABBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtIdLegajo As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCalcProm As Button
    Friend WithEvents LabelLegajo As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelGrado As Label
    Friend WithEvents Label1T As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label2T As Label
    Friend WithEvents Label3T As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnPromCursos As Button
    Friend WithEvents Txt1Trimestre As TextBox
    Friend WithEvents Txt2Trimestre As TextBox
    Friend WithEvents Txt3Trimestre As TextBox
    Friend WithEvents LabelProm As Label
    Friend WithEvents TxtPromedio As TextBox
    Friend WithEvents BtnIraLectura As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtProm4 As TextBox
    Friend WithEvents TxtProm3 As TextBox
    Friend WithEvents TxtProm2 As TextBox
    Friend WithEvents TxtProm1 As TextBox
    Friend WithEvents TxtProm5 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InstAdvBalcarceDataSetBindingSource As BindingSource
    Friend WithEvents InstAdvBalcarceDataSet As InstAdvBalcarceDataSet
    Friend WithEvents TablaIABBindingSource As BindingSource
    Friend WithEvents TablaIABTableAdapter As InstAdvBalcarceDataSetTableAdapters.TablaIABTableAdapter
    Friend WithEvents IdLegajoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrimestreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrimestreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TrimestreDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Prom1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Prom2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Prom3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Prom4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Prom5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TxtGrado As TextBox
    Friend WithEvents TablaIABBindingSource1 As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtSituacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblMPG As Label
    Friend WithEvents TxtMejorPromedioGrado As TextBox
    Friend WithEvents Bntcalcularmejorpromedio As Button
End Class
