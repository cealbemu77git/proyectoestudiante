Public Class Conocimiento
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Show()
    End Sub

    Private Sub Btnregreso_Click(sender As Object, e As EventArgs) Handles Btnregreso.Click
        Me.Hide()
        Menuscratch.Show()
    End Sub

    Private Sub Btnsiguiente_Click(sender As Object, e As EventArgs) Handles Btnsiguiente.Click
        Me.Hide()
        Conocimiento2.Show()
    End Sub
End Class