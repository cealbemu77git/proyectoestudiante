Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class Inicio
    Dim conexion As New MySqlConnection
    Dim adaptador As MySqlDataAdapter
    Dim dataset As New DataSet
    Dim comando As New MySqlCommand
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
    End Sub
    'Se programa el botón Ingresar con el nombre de usuario y clave
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btningreso.Click
        Dim usuario As String
        Dim contrace As String
        Dim sql As String
        Dim sw As Boolean = False
        usuario = txtusuario.Text
        contrace = txtclave.Text

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=12345678;database=solucionalosas"
            conexion.Open()

            sql = "SELECT * FROM estudiante where user = '" & usuario & "' and passw =  '" & contrace & "'"
            adaptador = New MySqlDataAdapter(sql, conexion)
            dataset.Clear()
            adaptador.Fill(dataset, "estudiante")

            If (dataset.Tables("estudiante").Rows.Count() <> 0) Then
                MessageBox.Show("bienvenido al sistema")
                Me.Hide()
                Menu1.Show()

            Else
                MessageBox.Show("usuario o pasware son incorrectos")
            End If


        Catch ex As Exception

        End Try
        conexion.Close()


    End Sub
    'Se programa el botón salir
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        End

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=12345678;database=solucionalosas"
            conexion.Open()
            Label_conexion.Text = ("conectado")
            conexion.Close()
        Catch ex As Exception
            Label_conexion.Text = ("desconectado")
        End Try
    End Sub

    Private Sub Button1registrar_Click(sender As Object, e As EventArgs) Handles Button1registrar.Click
        Me.Hide()
        Basededatos.Show()
    End Sub
End Class
