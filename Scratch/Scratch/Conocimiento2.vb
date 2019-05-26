Public Class Conocimiento2
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Show()
    End Sub

    Private Sub Btnregreso_Click(sender As Object, e As EventArgs) Handles Btnregreso.Click
        Conocimiento.Show()
        Me.Hide()
    End Sub

    Private Sub Btnsiguiente_Click(sender As Object, e As EventArgs) Handles Btnsiguiente.Click
        Me.Hide()
        Conocimiento3.Show()
    End Sub

    Private Sub Conocimiento2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class