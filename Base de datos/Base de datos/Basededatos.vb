Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class Basededatos
    Dim conexion As New MySqlConnection
    Dim adaptador As MySqlDataAdapter
    Dim dataset As New DataSet
    Dim comando As New MySqlCommand


    Private Sub Basededatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            conexion.ConnectionString = "server=localhost;user=root;password=12345678;database=solucionalosas"
            conexion.Open()
            label_conexion.Text = ("conectado")
            conexion.Close()
        Catch ex As Exception
            label_conexion.Text = ("desconectado")
        End Try

    End Sub
    'Se programa el botón salir
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        conexion.Close()
        Me.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2registrar_Click(sender As Object, e As EventArgs) Handles Button2registrar.Click
        Dim cedula As String
        Dim nombre As String
        Dim apellido As String
        Dim usuario As String
        Dim clave As String
        Dim sql As String

        cedula = txt_cedula.Text
        nombre = txt_nombre.Text
        apellido = txt_apellido.Text
        usuario = txt_usuario.Text
        clave = txt_contracena.Text

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=12345678;database=solucionalosas"

            If (txt_cedula.Text <> "" And txt_nombre.Text <> "" And txt_apellido.Text <> "" And txt_usuario.Text <> "" And txt_contracena.Text <> "") Then
                'sql = "INSERT INTO estudiante  VALUES ('" + txt_cedula.Text + "','" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_usuario.Text + "','" + txt_contracena.Text + "')"
                sql = "INSERT INTO `estudiante` (`idEstudiante`, `cedula`, `nombre`, `apellido`, `user`, `passw`) VALUES (NULL, '" + txt_cedula.Text + "','" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_usuario.Text + "','" + txt_contracena.Text + "')"
                conexion.Open()
                comando = New MySqlCommand(sql, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Registros almacenados", vbInformation, "Confirmar")
                limpiar()
                Me.Hide()
                Inicio.Show()
            Else
                MsgBox("todos los campo son obligatorios", vbCritical, "Atencion")
            End If

        Catch ex As Exception
            MsgBox("Registros no almacenados", vbCritical, "Atencion")
        End Try

        conexion.Close()
    End Sub
    Public Sub limpiar()
        txt_cedula.Text = ""
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        txt_usuario.Text = ""
        txt_contracena.Text = ""
    End Sub
    Public Sub validarCampos(e)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se admiten letras", "Validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
End Class