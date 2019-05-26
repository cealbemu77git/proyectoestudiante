Public Class Conocimiento3
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Show()
    End Sub

    Private Sub Btnregreso_Click(sender As Object, e As EventArgs) Handles Btnregreso.Click
        Me.Hide()
        Conocimiento2.Show()
    End Sub

    Private Sub Btnsiguiente_Click(sender As Object, e As EventArgs) Handles Btnsiguiente.Click
        Me.Hide()
        Conocimiento4.Show()
    End Sub

    Private Sub Conocimiento3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class