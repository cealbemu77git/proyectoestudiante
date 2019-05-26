Public Class Evaluacion
    Dim min As Integer
    Dim sec As Integer
    Private Property puntaje As Integer
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged, RadioButton18.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged, RadioButton23.CheckedChanged

    End Sub

    Private Sub RadioButton35_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton35.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Para acceder al Test 2 debes primero terminar este exámen y sacar más de 5")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Estás seguro que deseas salir del examen?", vbQuestion + vbYesNo) = vbYes Then
            Me.Hide()
            Me.Show()
        Else
            Me.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Está seguro que desea terminar el examen?", vbQuestion + vbYesNo) = vbYes Then
            puntaje = 0
            If RadioButton1.Checked = True Then puntaje = puntaje + 1
            If RadioButton5.Checked = True Then puntaje = puntaje + 1
            If RadioButton9.Checked = True Then puntaje = puntaje + 1
            If RadioButton14.Checked = True Then puntaje = puntaje + 1
            If RadioButton20.Checked = True Then puntaje = puntaje + 1
            If RadioButton23.Checked = True Then puntaje = puntaje + 1
            If RadioButton26.Checked = True Then puntaje = puntaje + 1
            If RadioButton30.Checked = True Then puntaje = puntaje + 1
            If RadioButton34.Checked = True Then puntaje = puntaje + 1
            If RadioButton40.Checked = True Then puntaje = puntaje + 1
            MsgBox("Su puntaje es " + Str(puntaje) + "/10")
            If puntaje < 5 Then
                If MsgBox("¿Desea intentarlo de nuevo?", vbQuestion + vbYesNo) = vbYes Then
                    Me.Show()
                Else
                    Me.Hide()
                    Me.Show()
                End If
            Else
                If MsgBox("Deseas ejecutar el Test 2", vbQuestion + vbYesNo) = vbYes Then
                    min = 0
                    sec = 0
                    Timer1.Enabled = False
                    Me.Hide()
                    Test2.Show()
                Else
                    Me.Hide()
                    Me.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Evaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sec = 0
        min = 0
        Label3.Text = sec
        Label2.Text = min
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec = sec + 1
        Label3.Text = sec
        Label2.Text = min
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class