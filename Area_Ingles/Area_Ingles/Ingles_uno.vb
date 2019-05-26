Public Class Ingles_uno
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btn_evaluar_ingles_uno_Click(sender As Object, e As EventArgs) Handles btn_evaluar_ingles_uno.Click
        Evaluacion1_uno.Show()

    End Sub

    Private Sub btn_evaluar_ingles_uno_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_evaluar_ingles_uno.MouseMove
        PictureBox1.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseMove
        PictureBox1.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseMove
        PictureBox1.Visible = False
        PictureBox2.Visible = True
    End Sub
End Class