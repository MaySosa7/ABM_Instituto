Imports System.Diagnostics
Imports System.Data
Imports System.Data.OleDb


Public Class Form1
    Dim contar As Integer
    Dim PromedioBD As Double

    Dim CuentApro As Integer
    Dim CuentDesa As Integer
    Dim CuentApla As Integer

    'Esta funcion Conecta con el form2para ABM alumnos
    Private Sub BtnIngresoAlumnos_Click(sender As Object, e As EventArgs) Handles BtnIngresoAlumnos.Click
        Form2.Show()
        Me.Hide()

        Dim conec1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pc\Documents\InstAdvBalcarce.accdb")
        conec1.Open()

        Try
            MsgBox("Conexión Correcta", vbInformation, "Aviso")


        Catch ex As Exception
            MsgBox("Conexión INCORRECTA", vbCritical, "Aviso")

        End Try
        conec1.Close()
    End Sub

    'Esta funcio realiza la lectura de BD para calcular cuantos alumnos aprobados,desaprobados y aplazados hay
    Private Sub BtnLecuradeBase_Click(sender As Object, e As EventArgs) Handles BtnLecuradeBase.Click

        Dim Conec1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pc\Documents\InstAdvBalcarce.accdb")
        Conec1.Open()



        Dim leo = "SELECT *FROM TablaIAB WHERE Promedio"
        Dim Adaptador = New OleDbDataAdapter(leo, Conec1)
        Dim registro = New DataSet
        Adaptador.Fill(registro, "TablaIAB")
        Dim lista = registro.Tables("TablaIAB").Rows.Count

        contar = 0

        MsgBox(lista)


        Do While contar < lista

            PromedioBD = registro.Tables("TablaIAB").Rows(contar).Item("Promedio")


            'MsgBox(lectura)

            If (PromedioBD >= 6.0) Then
                CuentApro = CuentApro + 1


            ElseIf (PromedioBD <= 3.9) Then
                CuentApla = CuentApla + 1

            ElseIf (PromedioBD >= 4.0 < 6.0) Then

                CuentDesa = CuentDesa + 1
            End If

            contar = contar + 1
        Loop


        Label4.Text = CuentApro
        Label5.Text = CuentDesa
        Label6.Text = CuentApla

        MsgBox("Terminado")

        Conec1.Close()
    End Sub

    Private Sub BtnSalirF1_Click(sender As Object, e As EventArgs) Handles BtnSalirF1.Click
        Dim Cancel As Integer

        If (MsgBox("¿Esta seguro que desea salir?", vbCritical + vbYesNo) = vbYes) Then

            Me.Close()
        Else
            Cancel = True
        End If
    End Sub
End Class
