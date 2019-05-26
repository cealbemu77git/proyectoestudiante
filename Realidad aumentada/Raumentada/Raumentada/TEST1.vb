Public Class TEST1
    Private Property Puntaje As Single

    Private Sub ENVIAR_Click(sender As Object, e As EventArgs) Handles ENVIAR.Click
        Puntaje = 0
        If radioButton1.Checked = False Xor
            radioButton2.Checked = False Xor
            radioButton3.Checked = False Xor
            RadioButton20.Checked = False Xor
            RadioButton19.Checked = False Xor
            RadioButton17.Checked = False Xor
            RadioButton6.Checked = False Xor
            RadioButton8.Checked = False Xor
            RadioButton7.Checked = False Xor
            RadioButton23.Checked = False Xor
            RadioButton22.Checked = False Xor
            RadioButton21.Checked = False Xor
            RadioButton12.Checked = False Xor
            RadioButton11.Checked = False Xor
            RadioButton10.Checked = False Xor
            RadioButton28.Checked = False Xor
            RadioButton27.Checked = False Xor
            RadioButton25.Checked = False Xor
            RadioButton14.Checked = False Xor
            RadioButton15.Checked = False Xor
            RadioButton16.Checked = False Xor
            RadioButton29.Checked = False Xor
            RadioButton30.Checked = False Xor
            RadioButton32.Checked = False Xor
            RadioButton34.Checked = False Xor
            RadioButton35.Checked = False Xor
            RadioButton36.Checked = False Xor
            RadioButton37.Checked = False Xor
            RadioButton38.Checked = False Xor
            RadioButton40.Checked = False Then
            MsgBox("debe responder todas las preguntas")
        Else
            If radioButton4.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton18.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton5.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton24.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton9.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton26.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton13.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton31.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton33.Checked = True Then Puntaje = Puntaje + 1
            If RadioButton39.Checked = True Then Puntaje = Puntaje + 1
            Label1.Visible = True
            Label1.Text = Puntaje
        End If
        If Puntaje >= 5 Then
            TEST2.Show()
        End If
    End Sub

    Private Sub EMPEZAR_Click(sender As Object, e As EventArgs) Handles EMPEZAR.Click
        groupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        GroupBox4.Visible = True
        GroupBox5.Visible = True
        GroupBox6.Visible = True
        GroupBox7.Visible = True
        GroupBox8.Visible = True
        GroupBox9.Visible = True
        GroupBox10.Visible = True
    End Sub

    Private Sub TEST1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class