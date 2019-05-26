Public Class Conocimiento5
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Show()
    End Sub

    Private Sub Btnregreso_Click(sender As Object, e As EventArgs) Handles Btnregreso.Click
        Me.Hide()
        Conocimiento4.Show()

    End Sub

    Private Sub Btnsiguiente_Click(sender As Object, e As EventArgs) Handles Btnmenu.Click
        Menuscratch.Show()
        Me.Hide()
    End Sub
End Class