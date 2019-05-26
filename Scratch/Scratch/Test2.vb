Public Class Test2
    Dim min As Integer
    Dim sec As Integer
    Private Property puntaje As Integer
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Está seguro que desea terminar el examen?", vbQuestion + vbYesNo) = vbYes Then
            puntaje = 0
            If RadioButton3.Checked = True Then puntaje = puntaje + 1
            If RadioButton6.Checked = True Then puntaje = puntaje + 1
            If RadioButton12.Checked = True Then puntaje = puntaje + 1
            If RadioButton14.Checked = True Then puntaje = puntaje + 1
            If RadioButton18.Checked = True Then puntaje = puntaje + 1
            If RadioButton21.Checked = True Then puntaje = puntaje + 1
            If RadioButton24.Checked = True Then puntaje = puntaje + 1
            If RadioButton31.Checked = True Then puntaje = puntaje + 1
            If RadioButton35.Checked = True Then puntaje = puntaje + 1
            If RadioButton38.Checked = True Then puntaje = puntaje + 1
            MsgBox("Su puntaje es " + Str(puntaje) + "/10")
            If puntaje < 5 Then
                If MsgBox("¿Desea intentarlo de nuevo?", vbQuestion + vbYesNo) = vbYes Then
                    Me.Show()
                Else
                    Me.Hide()
                    Me.Show()
                End If
            Else
                If puntaje > 7 Then
                    MsgBox("Felicitaciones sacaste una nota muy alta")
                    Me.Hide()
                    Me.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Test2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sec = 0
        min = 0
        Lbl3.Text = sec
        Lbl2.Text = min
        Timertest2.Enabled = True
        Timertest2.Interval = 1000
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timertest2.Tick
        sec = sec + 1
        Lbl3.Text = sec
        Lbl2.Text = min
        If sec = 59 Then
            sec = 0
            min = min + 1
            If min = 3 Then
                MsgBox("El tiempo termino, hasta luego")
                Me.Hide()
                Me.Show()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Estás seguro que deseas salir del examen?", vbQuestion + vbYesNo) = vbYes Then
            Me.Hide()
            Me.Show()
        Else
            Me.Show()
        End If
    End Sub
End Class