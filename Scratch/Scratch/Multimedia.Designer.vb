<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multimedia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Multimedia))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Btnplay = New System.Windows.Forms.Button()
        Me.Btnpause = New System.Windows.Forms.Button()
        Me.Btnstop = New System.Windows.Forms.Button()
        Me.Btnmenú = New System.Windows.Forms.Button()
        Me.Btncreditos = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(183, 87)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(573, 362)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Btnplay
        '
        Me.Btnplay.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btnplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnplay.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btnplay.FlatAppearance.BorderSize = 5
        Me.Btnplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btnplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnplay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btnplay.Location = New System.Drawing.Point(47, 87)
        Me.Btnplay.Name = "Btnplay"
        Me.Btnplay.Size = New System.Drawing.Size(101, 34)
        Me.Btnplay.TabIndex = 2
        Me.Btnplay.Text = "PLAY"
        Me.Btnplay.UseVisualStyleBackColor = False
        '
        'Btnpause
        '
        Me.Btnpause.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btnpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnpause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnpause.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btnpause.FlatAppearance.BorderSize = 5
        Me.Btnpause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btnpause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Btnpause.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnpause.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnpause.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btnpause.Location = New System.Drawing.Point(47, 181)
        Me.Btnpause.Name = "Btnpause"
        Me.Btnpause.Size = New System.Drawing.Size(101, 34)
        Me.Btnpause.TabIndex = 3
        Me.Btnpause.Text = "PAUSE"
        Me.Btnpause.UseVisualStyleBackColor = False
        '
        'Btnstop
        '
        Me.Btnstop.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btnstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnstop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnstop.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btnstop.FlatAppearance.BorderSize = 5
        Me.Btnstop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btnstop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnstop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btnstop.Location = New System.Drawing.Point(47, 272)
        Me.Btnstop.Name = "Btnstop"
        Me.Btnstop.Size = New System.Drawing.Size(101, 34)
        Me.Btnstop.TabIndex = 4
        Me.Btnstop.Text = "STOP"
        Me.Btnstop.UseVisualStyleBackColor = False
        '
        'Btnmenú
        '
        Me.Btnmenú.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btnmenú.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnmenú.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnmenú.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btnmenú.FlatAppearance.BorderSize = 5
        Me.Btnmenú.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btnmenú.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Btnmenú.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnmenú.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmenú.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btnmenú.Location = New System.Drawing.Point(782, 87)
        Me.Btnmenú.Name = "Btnmenú"
        Me.Btnmenú.Size = New System.Drawing.Size(101, 34)
        Me.Btnmenú.TabIndex = 5
        Me.Btnmenú.Text = "MENÚ"
        Me.Btnmenú.UseVisualStyleBackColor = False
        '
        'Btncreditos
        '
        Me.Btncreditos.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btncreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btncreditos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncreditos.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btncreditos.FlatAppearance.BorderSize = 5
        Me.Btncreditos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btncreditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Btncreditos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btncreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncreditos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btncreditos.Location = New System.Drawing.Point(782, 181)
        Me.Btncreditos.Name = "Btncreditos"
        Me.Btncreditos.Size = New System.Drawing.Size(101, 34)
        Me.Btncreditos.TabIndex = 6
        Me.Btncreditos.Text = "CRÉDITOS"
        Me.Btncreditos.UseVisualStyleBackColor = False
        '
        'Btnsalir
        '
        Me.Btnsalir.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btnsalir.FlatAppearance.BorderSize = 5
        Me.Btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btnsalir.Location = New System.Drawing.Point(782, 272)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(101, 34)
        Me.Btnsalir.TabIndex = 7
        Me.Btnsalir.Text = "SALIR"
        Me.Btnsalir.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Scratch.My.Resources.Resources.Creditos
        Me.PictureBox5.Location = New System.Drawing.Point(183, 87)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(573, 362)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Scratch.My.Resources.Resources.SALIR
        Me.PictureBox4.Location = New System.Drawing.Point(183, 87)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(573, 362)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox3.Image = Global.Scratch.My.Resources.Resources.Menu
        Me.PictureBox3.Location = New System.Drawing.Point(183, 87)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(573, 362)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox2.Location = New System.Drawing.Point(183, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(573, 362)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(895, 501)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Multimedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 506)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btncreditos)
        Me.Controls.Add(Me.Btnmenú)
        Me.Controls.Add(Me.Btnstop)
        Me.Controls.Add(Me.Btnpause)
        Me.Controls.Add(Me.Btnplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Multimedia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multimedia"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Btnplay As Button
    Friend WithEvents Btnpause As Button
    Friend WithEvents Btnstop As Button
    Friend WithEvents Btnmenú As Button
    Friend WithEvents Btncreditos As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
