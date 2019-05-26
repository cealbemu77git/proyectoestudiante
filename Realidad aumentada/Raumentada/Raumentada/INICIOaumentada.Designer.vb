<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INICIOaumentada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INICIOaumentada))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREARESTUDIANTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSQUEDADEESTUDIANTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREARCONTRASEÑASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFORMACIONDELCURSOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paso1HISTORIADELAREALIDADAUMENTADADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paso2HERRAMIENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIDEOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AUDIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTORNODEEVALUACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXAMEN1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXAMEN2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(625, 384)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "CLOSE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(469, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 238)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USUARIOSToolStripMenuItem, Me.INFORMACIONDELCURSOToolStripMenuItem, Me.ENTORNODEEVALUACIONToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USUARIOSToolStripMenuItem
        '
        Me.USUARIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CREARESTUDIANTESToolStripMenuItem, Me.BUSQUEDADEESTUDIANTESToolStripMenuItem, Me.CREARCONTRASEÑASToolStripMenuItem})
        Me.USUARIOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USUARIOSToolStripMenuItem.Name = "USUARIOSToolStripMenuItem"
        Me.USUARIOSToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.USUARIOSToolStripMenuItem.Text = "USUARIOS"
        '
        'CREARESTUDIANTESToolStripMenuItem
        '
        Me.CREARESTUDIANTESToolStripMenuItem.Name = "CREARESTUDIANTESToolStripMenuItem"
        Me.CREARESTUDIANTESToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.CREARESTUDIANTESToolStripMenuItem.Text = "CREAR ESTUDIANTES"
        '
        'BUSQUEDADEESTUDIANTESToolStripMenuItem
        '
        Me.BUSQUEDADEESTUDIANTESToolStripMenuItem.Name = "BUSQUEDADEESTUDIANTESToolStripMenuItem"
        Me.BUSQUEDADEESTUDIANTESToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.BUSQUEDADEESTUDIANTESToolStripMenuItem.Text = "BUSQUEDA DE ESTUDIANTES"
        '
        'CREARCONTRASEÑASToolStripMenuItem
        '
        Me.CREARCONTRASEÑASToolStripMenuItem.Name = "CREARCONTRASEÑASToolStripMenuItem"
        Me.CREARCONTRASEÑASToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.CREARCONTRASEÑASToolStripMenuItem.Text = "CREAR CONTRASEÑAS"
        '
        'INFORMACIONDELCURSOToolStripMenuItem
        '
        Me.INFORMACIONDELCURSOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Paso1HISTORIADELAREALIDADAUMENTADADToolStripMenuItem, Me.Paso2HERRAMIENTASToolStripMenuItem})
        Me.INFORMACIONDELCURSOToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INFORMACIONDELCURSOToolStripMenuItem.Name = "INFORMACIONDELCURSOToolStripMenuItem"
        Me.INFORMACIONDELCURSOToolStripMenuItem.Size = New System.Drawing.Size(170, 20)
        Me.INFORMACIONDELCURSOToolStripMenuItem.Text = "INFORMACION DEL CURSO"
        '
        'Paso1HISTORIADELAREALIDADAUMENTADADToolStripMenuItem
        '
        Me.Paso1HISTORIADELAREALIDADAUMENTADADToolStripMenuItem.Name = "Paso1HISTORIADELAREALIDADAUMENTADADToolStripMenuItem"
        Me.Paso1HISTORIADELAREALIDADAUMENTADADToolStripMenuItem.Size = New System.Drawing.Size(352, 22)
        Me.Paso1HISTORIADELAREALIDADAUMENTADADToolStripMenuItem.Text = "Paso1- HISTORIA DE LA REALIDAD AUMENTADAD"
        '
        'Paso2HERRAMIENTASToolStripMenuItem
        '
        Me.Paso2HERRAMIENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIDEOToolStripMenuItem, Me.AUDIOToolStripMenuItem})
        Me.Paso2HERRAMIENTASToolStripMenuItem.Name = "Paso2HERRAMIENTASToolStripMenuItem"
        Me.Paso2HERRAMIENTASToolStripMenuItem.Size = New System.Drawing.Size(352, 22)
        Me.Paso2HERRAMIENTASToolStripMenuItem.Text = "Paso2 - HERRAMIENTAS "
        '
        'VIDEOToolStripMenuItem
        '
        Me.VIDEOToolStripMenuItem.Name = "VIDEOToolStripMenuItem"
        Me.VIDEOToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.VIDEOToolStripMenuItem.Text = "VIDEO"
        '
        'AUDIOToolStripMenuItem
        '
        Me.AUDIOToolStripMenuItem.Name = "AUDIOToolStripMenuItem"
        Me.AUDIOToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AUDIOToolStripMenuItem.Text = "AUDIO"
        '
        'ENTORNODEEVALUACIONToolStripMenuItem
        '
        Me.ENTORNODEEVALUACIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXAMEN1ToolStripMenuItem, Me.EXAMEN2ToolStripMenuItem})
        Me.ENTORNODEEVALUACIONToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENTORNODEEVALUACIONToolStripMenuItem.Name = "ENTORNODEEVALUACIONToolStripMenuItem"
        Me.ENTORNODEEVALUACIONToolStripMenuItem.Size = New System.Drawing.Size(170, 20)
        Me.ENTORNODEEVALUACIONToolStripMenuItem.Text = "ENTORNO DE EVALUACION"
        '
        'EXAMEN1ToolStripMenuItem
        '
        Me.EXAMEN1ToolStripMenuItem.Name = "EXAMEN1ToolStripMenuItem"
        Me.EXAMEN1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EXAMEN1ToolStripMenuItem.Text = "EXAMEN 1"
        '
        'EXAMEN2ToolStripMenuItem
        '
        Me.EXAMEN2ToolStripMenuItem.Name = "EXAMEN2ToolStripMenuItem"
        Me.EXAMEN2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EXAMEN2ToolStripMenuItem.Text = "EXAMEN 2"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'INICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "INICIO"
        Me.Text = "MENU"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents USUARIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INFORMACIONDELCURSOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENTORNODEEVALUACIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CREARESTUDIANTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUSQUEDADEESTUDIANTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Paso1HISTORIADELAREALIDADAUMENTADADToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Paso2HERRAMIENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXAMEN1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXAMEN2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CREARCONTRASEÑASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIDEOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AUDIOToolStripMenuItem As ToolStripMenuItem
End Class
