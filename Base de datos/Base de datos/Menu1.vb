Public Class Menu1


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub

    Dim scratch As New Scratch.Menuscratch
    Private Sub Button2scratch_Click(sender As Object, e As EventArgs) Handles Button2scratch.Click
        scratch.Show()
    End Sub

    Dim ingles As New Area_Ingles.Temas
    Private Sub Btningles_Click(sender As Object, e As EventArgs) Handles Btningles.Click
        ingles.Show()
    End Sub

    Dim interfazgrafica As New Interface_grafica___Evelyn_Patiño___IA.Inicio
    Private Sub Button3interfasgrafica_Click(sender As Object, e As EventArgs) Handles Button3interfasgrafica.Click
        interfazgrafica.Show()
    End Sub
End Class
