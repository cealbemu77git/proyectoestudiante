<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conocimiento2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conocimiento2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Btnregreso = New System.Windows.Forms.Button()
        Me.Btnsiguiente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(776, 426)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Btnsalir
        '
        Me.Btnsalir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.ForeColor = System.Drawing.Color.ForestGreen
        Me.Btnsalir.Location = New System.Drawing.Point(495, 329)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(98, 31)
        Me.Btnsalir.TabIndex = 9
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = False
        '
        'Btnregreso
        '
        Me.Btnregreso.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnregreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregreso.ForeColor = System.Drawing.Color.ForestGreen
        Me.Btnregreso.Location = New System.Drawing.Point(258, 329)
        Me.Btnregreso.Name = "Btnregreso"
        Me.Btnregreso.Size = New System.Drawing.Size(103, 31)
        Me.Btnregreso.TabIndex = 8
        Me.Btnregreso.Text = "Regresar"
        Me.Btnregreso.UseVisualStyleBackColor = False
        '
        'Btnsiguiente
        '
        Me.Btnsiguiente.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnsiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsiguiente.ForeColor = System.Drawing.Color.ForestGreen
        Me.Btnsiguiente.Location = New System.Drawing.Point(381, 329)
        Me.Btnsiguiente.Name = "Btnsiguiente"
        Me.Btnsiguiente.Size = New System.Drawing.Size(98, 31)
        Me.Btnsiguiente.TabIndex = 7
        Me.Btnsiguiente.Text = "Siguiente"
        Me.Btnsiguiente.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.ForestGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(136, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(489, 48)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.ForestGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(136, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(479, 80)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Conocimiento"
        '
        'Conocimiento2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btnregreso)
        Me.Controls.Add(Me.Btnsiguiente)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Conocimiento2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conocimiento2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btnsalir As Button
    Friend WithEvents Btnregreso As Button
    Friend WithEvents Btnsiguiente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
