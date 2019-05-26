Public Class Conocimiento4
    Private Sub Btnregreso_Click(sender As Object, e As EventArgs) Handles Btnregreso.Click
        Me.Hide()
        Conocimiento3.Show()

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Show()
    End Sub

    Private Sub Btnsiguiente_Click(sender As Object, e As EventArgs) Handles Btnsiguiente.Click
        Me.Hide()
        Conocimiento5.Show()

    End Sub
End Class