Public Class Evaluar_ingles_dos
    Private Property puntaje As String
    Public buenas, malas, pregunta, m, s As Integer



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        s = s - 1
        If s < 10 Then
            Label_tiempo.Visible = True
            Label_tiempo.Text = m & ":" & s
        Else

            'Labe_time2.Text = m & ":" & s
        End If
    End Sub

    Private Sub btn_Empezar_Click(sender As Object, e As EventArgs) Handles btn_Empezar.Click
        GroupBox_1.Visible = True
        GroupBox_2.Visible = True
        GroupBox_3.Visible = True
        GroupBox_4.Visible = True
        GroupBox_5.Visible = True
        GroupBox_6.Visible = True
        GroupBox_7.Visible = True
        GroupBox_8.Visible = True
        GroupBox_9.Visible = True
        GroupBox_10.Visible = True

        Timer1.Start()
        malas = 0
        buenas = 0
        pregunta = 1
        m = 2
        s = 59
    End Sub

    Private Sub btn_calificar_ingles_dos_Click(sender As Object, e As EventArgs) Handles btn_calificar_ingles_dos.Click
        puntaje = 0
        If RadioButton_1.Checked = False Xor RadioButton_2.Checked = False Xor RadioButton_3.Checked = False Xor RadioButton_4.Checked = False Xor RadioButton_5.Checked = False Xor RadioButton_6.Checked = False Xor RadioButton_7.Checked = False Xor RadioButton_8.Checked = False Xor RadioButton_9.Checked = False Xor RadioButton_10.Checked = False Xor RadioButton_11.Checked = False Xor RadioButton_12.Checked = False Xor RadioButton_13.Checked = False Xor RadioButton_14.Checked = False Xor RadioButton_15.Checked = False Xor RadioButton_16.Checked = False Xor RadioButton_17.Checked = False Xor RadioButton_18.Checked = False Xor RadioButton_19.Checked = False Xor RadioButton_20.Checked = False Xor RadioButton_21.Checked = False Xor RadioButton_22.Checked = False Xor RadioButton_23.Checked = False Xor RadioButton_24.Checked = False Xor RadioButton_25.Checked = False Xor RadioButton_26.Checked = False Xor RadioButton_27.Checked = False Xor RadioButton_28.Checked = False Xor RadioButton_29.Checked = False Xor RadioButton_30.Checked = False Then
            MsgBox("es necesario que responda todas las preguntas")

        Else

            If RadioButton_1.Checked = True Then puntaje = puntaje + 1
            If RadioButton_5.Checked = True Then puntaje = puntaje + 1
            If RadioButton_9.Checked = True Then puntaje = puntaje + 1
            If RadioButton_10.Checked = True Then puntaje = puntaje + 1
            If RadioButton_14.Checked = True Then puntaje = puntaje + 1
            If RadioButton_18.Checked = True Then puntaje = puntaje + 1
            If RadioButton_19.Checked = True Then puntaje = puntaje + 1
            If RadioButton_23.Checked = True Then puntaje = puntaje + 1
            If RadioButton_27.Checked = True Then puntaje = puntaje + 1
            If RadioButton_28.Checked = True Then puntaje = puntaje + 1
            Label_time2.Visible = True
            Label_time2.Text = puntaje

        End If
        If puntaje > 6 Then
            MsgBox("usted a pasado el curso")
            Me.Close()
        End If
    End Sub
End Class