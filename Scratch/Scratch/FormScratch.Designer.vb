<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menuscratch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuscratch))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Lblentornos = New System.Windows.Forms.Label()
        Me.Lblconocimiento = New System.Windows.Forms.Label()
        Me.Lblevaluacion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(776, 355)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Btnsalir
        '
        Me.Btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.Location = New System.Drawing.Point(689, 335)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.Btnsalir.TabIndex = 1
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Lblentornos
        '
        Me.Lblentornos.AutoSize = True
        Me.Lblentornos.BackColor = System.Drawing.Color.Orange
        Me.Lblentornos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblentornos.ForeColor = System.Drawing.Color.Transparent
        Me.Lblentornos.Location = New System.Drawing.Point(340, 96)
        Me.Lblentornos.Name = "Lblentornos"
        Me.Lblentornos.Size = New System.Drawing.Size(148, 33)
        Me.Lblentornos.TabIndex = 2
        Me.Lblentornos.Text = "Entornos:"
        '
        'Lblconocimiento
        '
        Me.Lblconocimiento.AutoSize = True
        Me.Lblconocimiento.BackColor = System.Drawing.Color.RoyalBlue
        Me.Lblconocimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblconocimiento.ForeColor = System.Drawing.Color.Transparent
        Me.Lblconocimiento.Location = New System.Drawing.Point(386, 145)
        Me.Lblconocimiento.Name = "Lblconocimiento"
        Me.Lblconocimiento.Size = New System.Drawing.Size(206, 33)
        Me.Lblconocimiento.TabIndex = 3
        Me.Lblconocimiento.Text = "Conocimiento"
        '
        'Lblevaluacion
        '
        Me.Lblevaluacion.AutoSize = True
        Me.Lblevaluacion.BackColor = System.Drawing.Color.MediumOrchid
        Me.Lblevaluacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblevaluacion.ForeColor = System.Drawing.Color.Transparent
        Me.Lblevaluacion.Location = New System.Drawing.Point(386, 194)
        Me.Lblevaluacion.Name = "Lblevaluacion"
        Me.Lblevaluacion.Size = New System.Drawing.Size(168, 33)
        Me.Lblevaluacion.TabIndex = 4
        Me.Lblevaluacion.Text = "Evaluación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OliveDrab
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(386, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Multimedia"
        '
        'Menuscratch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(801, 388)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lblevaluacion)
        Me.Controls.Add(Me.Lblconocimiento)
        Me.Controls.Add(Me.Lblentornos)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Menuscratch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Scratch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btnsalir As Button
    Friend WithEvents Lblentornos As Label
    Friend WithEvents Lblconocimiento As Label
    Friend WithEvents Lblevaluacion As Label
    Friend WithEvents Label1 As Label
End Class
