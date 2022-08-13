Imports System.Diagnostics
Imports System.Data
Imports System.Data.OleDb


Public Class Form2
    Dim ConecF2 As New OleDbConnection
    Dim instruccion As OleDbCommand


    Dim Tri1 As Integer
    Dim Tri2 As Integer
    Dim Tri3 As Integer
    Dim PromNotas As Double
    Dim Situacion As String
    Dim MGrado As String


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me muestra en el datagrid con decimales
        DataGridView1.Columns(4).DefaultCellStyle.Format = "0.0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "0.0"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "0.0"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "0.0"

        ConecF2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pc\Documents\InstAdvBalcarce.accdb"
        ConecF2.Open()



        ConecF2.Close()


    End Sub


    Private Sub BtnIraLectura_Click(sender As Object, e As EventArgs) Handles BtnIraLectura.Click
        Form1.Show()
        Me.Hide()

        Dim conec2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pc\Documents\InstAdvBalcarce.accdb")
        conec2.Open()




    End Sub

    'Esta funcion busca si el numero de legajo que le indico ya existe en la base de datos
    Private Function BuscarLegajo(legajo As String) As Integer
        Dim resultadoQuery As String

        Try
            ConecF2.Open()

            instruccion = New OleDbCommand("SELECT IdLegajo FROM TablaIAB WHERE IdLegajo=@IdLegajo", ConecF2)
            instruccion.Parameters.AddWithValue("@IdLegajo", legajo)

            resultadoQuery = instruccion.ExecuteScalar()

            If resultadoQuery <> Nothing Then
                Return Int(resultadoQuery)
            Else
                Return 0

            End If

        Catch ex As Exception

            MsgBox("Fallo la busqueda del Legajo" & vbNewLine & vbNewLine & ex.Message, vbCritical, "Fallo la busqueda")
            Return 0

        Finally
            If ConecF2.State = ConnectionState.Open Then
                ConecF2.Close()
            End If

        End Try
    End Function

    'Esta funcion Guarda todo lo ingresado en BD
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Promedio As Double
        Dim Tri1 As Double
        Dim Tri2 As Double
        Dim Tri3 As Double

        Dim BuscLe As Integer
        Dim resultadoQuery As Integer

        Double.TryParse(TxtPromedio.Text, Promedio)
        Double.TryParse(Txt1Trimestre.Text, Tri1)
        Double.TryParse(Txt2Trimestre.Text, Tri2)
        Double.TryParse(Txt3Trimestre.Text, Tri3)

        Try
            BuscLe = BuscarLegajo(TxtIdLegajo.Text)

            If BuscLe = 0 Then

                ConecF2.Open()

                instruccion = New OleDbCommand("INSERT INTO TablaIAB(IdLegajo, Nombre, Apellido, Grado,1Trimestre, 2Trimestre, 3Trimestre, Promedio)VALUES(@IdLegajo, @Nombre, @Apellido, @Grado, @1Trimestre, @2Trimestre, @3Trimestre, @Promedio)", ConecF2)
                instruccion.Parameters.AddWithValue("@IdLegajo", TxtIdLegajo.Text)
                instruccion.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                instruccion.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                instruccion.Parameters.AddWithValue("@Grado", TxtGrado.Text)

                instruccion.Parameters.Add("@1Trimestre", OleDbType.Double).Value = Tri1
                instruccion.Parameters.Add("@2Trimestre", OleDbType.Double).Value = Tri2
                instruccion.Parameters.Add("@3Trimestre", OleDbType.Double).Value = Tri3
                instruccion.Parameters.Add("@Promedio", OleDbType.Double).Value = Math.Round(Promedio, 2)

                resultadoQuery = instruccion.ExecuteNonQuery()

                If resultadoQuery <> Nothing Then

                    MsgBox("Guardado Correctamente", vbInformation, "Registro Guardado")

                    'TODO: esta línea de código carga datos en la tabla 'InstAdvBalcarceDataSet.TablaIAB' Puede moverla o quitarla según sea necesario.
                    Me.TablaIABTableAdapter.Fill(Me.InstAdvBalcarceDataSet.TablaIAB)

                End If

            Else

                MsgBox("Legajo Existente", vbInformation, "Registro Existente")

            End If

        Catch ex As Exception
            MsgBox("Error al guardar" & vbNewLine & vbNewLine & ex.Message, vbCritical, "Registro No Guardado")
        Finally

            If ConecF2.State = ConnectionState.Open Then
                ConecF2.Close()
            End If
        End Try


    End Sub
    'Esta funcion Calcula el promedio por alumno
    Private Sub BtnCalcProm_Click(sender As Object, e As EventArgs) Handles BtnCalcProm.Click

        Tri1 = Double.Parse(Txt1Trimestre.Text)
        Tri2 = Double.Parse(Txt2Trimestre.Text)
        Tri3 = Double.Parse(Txt3Trimestre.Text)

        PromNotas = Math.Round((Tri1 + Tri2 + Tri3) / 3, 2)
        TxtPromedio.Text = PromNotas

        'situacion del alumno
        If (PromNotas <= 3) Then
            Situacion = "Aplazado"

        ElseIf (PromNotas >= 6) Then
            Situacion = "Aprobado"

        Else
            Situacion = "Desaprobado"

        End If

        TxtSituacion.Text = Situacion

    End Sub

    'Esta funcion limpia todo lo ingresado para poder cargar alumno nuevo
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtIdLegajo.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtGrado.Clear()


        Txt1Trimestre.Clear()
        Txt2Trimestre.Clear()
        Txt3Trimestre.Clear()
        TxtPromedio.Clear()
        TxtSituacion.Clear()

        TxtProm1.Clear()
        TxtProm2.Clear()
        TxtProm3.Clear()
        TxtProm4.Clear()
        TxtProm5.Clear()

        TxtMejorPromedioGrado.Clear()

        TxtIdLegajo.Focus() 'Me vuelve al textbox legajo

    End Sub

    'Esta funcion para salir y cerrar conexion
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        ConecF2.Close()
        Me.Close()

    End Sub


    'Esta funcion limpia lo ingresado en trimestres 
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Txt1Trimestre.Clear()
        Txt2Trimestre.Clear()
        Txt3Trimestre.Clear()
        TxtPromedio.Clear()
        TxtSituacion.Clear()

        Txt1Trimestre.Focus()

    End Sub


    'Esta funcion Calcula los promedios por curso
    Private Sub BtnPromCursos_Click(sender As Object, e As EventArgs) Handles BtnPromCursos.Click

        Dim ConecF2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pc\Documents\InstAdvBalcarce.accdb")

        ConecF2.Open()


        Dim leo = "SELECT Grado,Promedio FROM TablaIAB"
        Dim cmd As New OleDbCommand(leo, ConecF2)
        Dim Adaptador = New OleDbDataAdapter(leo, ConecF2)
        Dim registro = New DataSet
        Dim reader As OleDbDataReader

        Adaptador.Fill(registro, "TablaIAB")
        Dim lista = registro.Tables("TablaIAB").Rows.Count

        Dim Contador1 As Integer = 0
        Dim Contador2 As Integer = 0
        Dim Contador3 As Integer = 0
        Dim Contador4 As Integer = 0
        Dim Contador5 As Integer = 0

        Dim PromPrimg As Double
        Dim PromSegung As Double
        Dim PromTercerg As Double
        Dim PromCuartog As Double
        Dim PromQUintog As Double


        MsgBox(lista)

        'Reader me guarda el resultado del cmando(Command.ExecuteReader)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        While reader.Read()

            'MsgBox(reader(1))
            Select Case reader("Grado")
                Case 1
                    Contador1 = Contador1 + 1
                    PromPrimg = PromPrimg + reader("Promedio")

                Case 2
                    Contador2 = Contador2 + 1
                    PromSegung = PromSegung + reader("Promedio")

                Case 3
                    Contador3 = Contador3 + 1
                    PromTercerg = PromTercerg + reader("Promedio")

                Case 4
                    Contador4 = Contador4 + 1
                    PromCuartog = PromCuartog + reader("Promedio")

                Case 5
                    Contador5 = Contador5 + 1
                    PromQUintog = PromQUintog + reader("Promedio")
            End Select

        End While

        TxtProm1.Text = Math.Round(PromPrimg / Contador1, 2)
        TxtProm2.Text = Math.Round(PromSegung / Contador2, 2)
        TxtProm3.Text = Math.Round(PromTercerg / Contador3, 2)
        TxtProm4.Text = Math.Round(PromCuartog / Contador4, 2)
        TxtProm5.Text = Math.Round(PromQUintog / Contador5, 2)




        ConecF2.Close()

    End Sub


    'Realiza la busqueda por numero de legajo de ser existente trae los datos a cada txtbox
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim ConecF2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pc\Documents\InstAdvBalcarce.accdb")

        ConecF2.Open()

        Dim comando As New OleDbCommand
        Dim adaptador As New OleDbDataAdapter
        Dim registro As New DataSet
        Dim consulta As String
        Dim lista As New Byte

        If TxtIdLegajo.Text <> "" Then

            consulta = "SELECT    *FROM TablaIAB WHERE IdLegajo = " & TxtIdLegajo.Text & ""
            adaptador = New OleDbDataAdapter(consulta, ConecF2)
            registro = New DataSet
            adaptador.Fill(registro, "TablaIAB")
            lista = registro.Tables("TablaIAB").Rows.Count '

            If lista <> 0 Then

                TxtNombre.Text = registro.Tables("TablaIAB").Rows(0).Item("Nombre")
                TxtApellido.Text = registro.Tables("TablaIAB").Rows(0).Item("Apellido")
                TxtGrado.Text = registro.Tables("TablaIAB").Rows(0).Item("Grado")

                Txt1Trimestre.Text = registro.Tables("TablaIAB").Rows(0).Item("1Trimestre")
                Txt2Trimestre.Text = registro.Tables("TablaIAB").Rows(0).Item("2Trimestre")
                Txt3Trimestre.Text = registro.Tables("TablaIAB").Rows(0).Item("3Trimestre")
                TxtPromedio.Text = registro.Tables("TablaIAB").Rows(0).Item("Promedio")

            Else

                MsgBox("resgistro inexistente")
                TxtIdLegajo.Focus()

            End If
        End If

        ConecF2.Close()

    End Sub

    'Esta funcion nos permite modificar datos ingresado del alumno
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        Dim ConecF2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pc\Documents\InstAdvBalcarce.accdb")
        ConecF2.Open()

        Dim consul1 As String
        Dim lista1 As New Byte
        Dim adaptador1 As New OleDbDataAdapter
        Dim registro1 As New DataSet
        Dim Cancel As Integer

        consul1 = "SELECT * FROM TablaIAB WHERE IdLegajo = " & TxtIdLegajo.Text & ""
        adaptador1 = New OleDbDataAdapter(consul1, ConecF2)
        registro1 = New DataSet
        adaptador1.Fill(registro1, "TablaIAB")
        lista1 = registro1.Tables("TablaIAB").Rows.Count


        If (MsgBox("¿Esta seguro que desea mofidicar el registro?", vbCritical + vbYesNo) = vbYes) Then


            consul1 = "UPDATE TablaIAB SET Nombre = '" & TxtNombre.Text & "', Apellido = '" & TxtApellido.Text & "', Grado =
        '" & TxtGrado.Text & "', 1Trimestre ='" & Txt1Trimestre.Text & "',2Trimestre= '" &
        Txt2Trimestre.Text & "', 3Trimestre= '" & Txt3Trimestre.Text & "', Promedio = '" & TxtPromedio.Text & "' WHERE IdLegajo = " &
        TxtIdLegajo.Text & ""

            Dim Comand1 As New OleDbCommand(consul1, ConecF2)
            Dim reader As OleDbDataReader = Comand1.ExecuteReader

            MsgBox("Se modificaron los datos correctamente")

            TxtIdLegajo.Clear()
            TxtNombre.Clear()
            TxtApellido.Clear()
            TxtGrado.Clear()

            Txt1Trimestre.Clear()
            Txt2Trimestre.Clear()
            Txt3Trimestre.Clear()
            TxtPromedio.Clear()
            TxtSituacion.Clear()

            TxtProm1.Clear()
            TxtProm2.Clear()
            TxtProm3.Clear()
            TxtProm4.Clear()
            TxtProm5.Clear()

            TxtMejorPromedioGrado.Clear()

            TxtIdLegajo.Focus()

        Else
            Cancel = False

        End If



        ConecF2.Close()

    End Sub

    'Esta funcion elimina un registro existente
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Cancel As Integer
        Dim ConecF2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pc\Documents\InstAdvBalcarce.accdb")
        ConecF2.Open()


        If (MsgBox("¿Esta seguro que desea eliminar el registro?", vbCritical + vbYesNo) = vbYes) Then

            Dim Elimina As String = "DELETE * From TablaIAB WHERE IdLegajo = " & TxtIdLegajo.Text & ""
            Dim Comand2 As New OleDbCommand(Elimina, ConecF2)
            Dim reader2 As OleDbDataReader = Comand2.ExecuteReader


            MsgBox("Registro Eliminado")

            TxtIdLegajo.Clear()
            TxtNombre.Clear()
            TxtApellido.Clear()
            TxtGrado.Clear()

            Txt1Trimestre.Clear()
            Txt2Trimestre.Clear()
            Txt3Trimestre.Clear()
            TxtPromedio.Clear()
            TxtSituacion.Clear()

            TxtProm1.Clear()
            TxtProm2.Clear()
            TxtProm3.Clear()
            TxtProm4.Clear()
            TxtProm5.Clear()

            TxtMejorPromedioGrado.Clear()

            TxtIdLegajo.Focus()

        Else
            Cancel = False
        End If

        ConecF2.Close()

    End Sub


    'Esta me permite comparar los promedios de los grados para saber cual de ellos tiene el mejor promedio
    Private Sub Bntcalcularmejorpromedio_Click(sender As Object, e As EventArgs) Handles Bntcalcularmejorpromedio.Click

        Dim Primero As Double = TxtProm1.Text
        Dim Segundo As Double = TxtProm2.Text
        Dim Tercero As Double = TxtProm3.Text
        Dim Cuarto As Double = TxtProm4.Text
        Dim Quinto As Double = TxtProm5.Text


        If (Primero > Segundo And Primero > Tercero And Primero > Cuarto And Primero > Quinto) Then
            MGrado = "Primer Grado"

        ElseIf (Segundo > Primero And Segundo > Tercero And Segundo > Cuarto And Segundo > Quinto) Then
            MGrado = "Segundo Grado"

        ElseIf (Tercero > Primero And Tercero > Segundo And Tercero > Cuarto And Tercero > Quinto) Then
            MGrado = "Tercero Grado"

        ElseIf (Cuarto > Primero And Cuarto > Segundo And Cuarto > Tercero And Cuarto > Quinto) Then
            MGrado = "Cuarto Grado"

        ElseIf (Quinto > Primero And Quinto > Segundo And Quinto > Tercero And Quinto > Cuarto) Then
            MGrado = "Quinto Grado"

        End If

        TxtMejorPromedioGrado.Text = MGrado

    End Sub

End Class