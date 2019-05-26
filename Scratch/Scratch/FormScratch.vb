Public Class Menuscratch
    Private Sub Lblentornos_Click(sender As Object, e As EventArgs) Handles Lblentornos.Click

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Lblconocimiento_Click(sender As Object, e As EventArgs) Handles Lblconocimiento.Click
        Me.Hide()
        Conocimiento.Show()

    End Sub

    Private Sub Lblevaluacion_Click(sender As Object, e As EventArgs) Handles Lblevaluacion.Click
        Me.Hide()
        Evaluacion.Show()
    End Sub

    Private Sub Menuscratch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Multimedia.Show()
    End Sub
End Class
