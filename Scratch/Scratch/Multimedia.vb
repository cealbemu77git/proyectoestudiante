Public Class Multimedia
    'Se ocultan todas las imagenes y se activa el video al momento de dar clic en el botón play
    Private Sub Btnplay_Click(sender As Object, e As EventArgs) Handles Btnplay.Click
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        AxWindowsMediaPlayer1.Visible = True
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    'Al dar clic en el botón pause, simplemente se pausa el video 
    Private Sub Btnpause_Click(sender As Object, e As EventArgs) Handles Btnpause.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    'Se detiene el video y se activa la imagen del picturebox2 que es un fondo azul claro
    Private Sub Btnstop_Click(sender As Object, e As EventArgs) Handles Btnstop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.Visible = False
        PictureBox2.Visible = True
    End Sub

    'En el momento de pasar el mouse por el botón menú se desactiva el picturebos2 que es el fondo y se muestra el picturebox3 que
    'es una imagen del menú principal
    Private Sub Btnmenú_MouseMove(sender As Object, e As MouseEventArgs) Handles Btnmenú.MouseMove
        PictureBox2.Visible = False
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    'Se Activa la imagen del picturebox2 que es el fondo azul claro en el momento que el mouse se mueve fuera de cualquier botón
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox2.Visible = True
    End Sub

    'Al presionar el botón salir se sale de la aplicación
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Show()
    End Sub

    'Al pasar el mouse por el botón salir nos muestra una imagen que dice vuelva pronto muchas gracias
    Private Sub Btnsalir_MouseMove(sender As Object, e As MouseEventArgs) Handles Btnsalir.MouseMove
        PictureBox4.Visible = True
    End Sub

    'Al presionar el botón menu nos cierra el presente formulario y posteriormente nos muestra el formulario del menú principal
    Private Sub Btnmenú_Click(sender As Object, e As EventArgs) Handles Btnmenú.Click
        Me.Hide()
        Menuscratch.Show()
    End Sub

    'Al presionar el botón créditos nos muestra la bibliografía de esta actividad
    Private Sub Btncreditos_Click(sender As Object, e As EventArgs) Handles Btncreditos.Click
        PictureBox5.Visible = True
    End Sub

    'Al pasar el mouse por el botón créditos nos muestra la bibliografía de esta actividad
    Private Sub Btncreditos_MouseHover(sender As Object, e As EventArgs) Handles Btncreditos.MouseHover
        PictureBox5.Visible = True
    End Sub
End Class