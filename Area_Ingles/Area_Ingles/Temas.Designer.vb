<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temas
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TemasDelAreaDeInglesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ingles0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ingles1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ingles2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemasDelAreaDeInglesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(499, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TemasDelAreaDeInglesToolStripMenuItem
        '
        Me.TemasDelAreaDeInglesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TemasDelAreaDeInglesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ingles0ToolStripMenuItem, Me.Ingles1ToolStripMenuItem, Me.Ingles2ToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.TemasDelAreaDeInglesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemasDelAreaDeInglesToolStripMenuItem.Name = "TemasDelAreaDeInglesToolStripMenuItem"
        Me.TemasDelAreaDeInglesToolStripMenuItem.Size = New System.Drawing.Size(192, 25)
        Me.TemasDelAreaDeInglesToolStripMenuItem.Text = "Temas del Area de Ingles"
        '
        'Ingles0ToolStripMenuItem
        '
        Me.Ingles0ToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.Ingles0ToolStripMenuItem.Name = "Ingles0ToolStripMenuItem"
        Me.Ingles0ToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.Ingles0ToolStripMenuItem.Text = "Ingles 0"
        '
        'Ingles1ToolStripMenuItem
        '
        Me.Ingles1ToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.Ingles1ToolStripMenuItem.Name = "Ingles1ToolStripMenuItem"
        Me.Ingles1ToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.Ingles1ToolStripMenuItem.Text = "Ingles 1"
        '
        'Ingles2ToolStripMenuItem
        '
        Me.Ingles2ToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia
        Me.Ingles2ToolStripMenuItem.Name = "Ingles2ToolStripMenuItem"
        Me.Ingles2ToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.Ingles2ToolStripMenuItem.Text = "Ingles 2"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Temas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Area_Ingles.My.Resources.Resources.Captura3
        Me.ClientSize = New System.Drawing.Size(499, 232)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Temas"
        Me.Text = "Temas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TemasDelAreaDeInglesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ingles0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ingles1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ingles2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
