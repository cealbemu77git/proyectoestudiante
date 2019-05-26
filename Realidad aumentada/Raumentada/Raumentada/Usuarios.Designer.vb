<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USUARIOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USUARIOS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Identificacion_Estudiante = New System.Windows.Forms.TextBox()
        Me.Nombre_Estudiante = New System.Windows.Forms.TextBox()
        Me.Apellidos_Estudiante = New System.Windows.Forms.TextBox()
        Me.Edad_Estudiante = New System.Windows.Forms.TextBox()
        Me.Telefono_Estudiante = New System.Windows.Forms.TextBox()
        Me.REGISTRAR = New System.Windows.Forms.Button()
        Me.MODIFICAR = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IDENTIFICACION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "EDAD"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 230)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TELEFONO"
        '
        'Identificacion_Estudiante
        '
        Me.Identificacion_Estudiante.Location = New System.Drawing.Point(475, 57)
        Me.Identificacion_Estudiante.Name = "Identificacion_Estudiante"
        Me.Identificacion_Estudiante.Size = New System.Drawing.Size(156, 20)
        Me.Identificacion_Estudiante.TabIndex = 7
        '
        'Nombre_Estudiante
        '
        Me.Nombre_Estudiante.Location = New System.Drawing.Point(475, 86)
        Me.Nombre_Estudiante.Name = "Nombre_Estudiante"
        Me.Nombre_Estudiante.Size = New System.Drawing.Size(156, 20)
        Me.Nombre_Estudiante.TabIndex = 8
        '
        'Apellidos_Estudiante
        '
        Me.Apellidos_Estudiante.Location = New System.Drawing.Point(475, 118)
        Me.Apellidos_Estudiante.Name = "Apellidos_Estudiante"
        Me.Apellidos_Estudiante.Size = New System.Drawing.Size(156, 20)
        Me.Apellidos_Estudiante.TabIndex = 9
        '
        'Edad_Estudiante
        '
        Me.Edad_Estudiante.Location = New System.Drawing.Point(475, 145)
        Me.Edad_Estudiante.Name = "Edad_Estudiante"
        Me.Edad_Estudiante.Size = New System.Drawing.Size(100, 20)
        Me.Edad_Estudiante.TabIndex = 10
        '
        'Telefono_Estudiante
        '
        Me.Telefono_Estudiante.Location = New System.Drawing.Point(475, 172)
        Me.Telefono_Estudiante.Name = "Telefono_Estudiante"
        Me.Telefono_Estudiante.Size = New System.Drawing.Size(156, 20)
        Me.Telefono_Estudiante.TabIndex = 11
        '
        'REGISTRAR
        '
        Me.REGISTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTRAR.Location = New System.Drawing.Point(343, 217)
        Me.REGISTRAR.Name = "REGISTRAR"
        Me.REGISTRAR.Size = New System.Drawing.Size(111, 42)
        Me.REGISTRAR.TabIndex = 12
        Me.REGISTRAR.Text = "REGISTRAR"
        Me.REGISTRAR.UseVisualStyleBackColor = True
        '
        'MODIFICAR
        '
        Me.MODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFICAR.Location = New System.Drawing.Point(464, 217)
        Me.MODIFICAR.Name = "MODIFICAR"
        Me.MODIFICAR.Size = New System.Drawing.Size(111, 42)
        Me.MODIFICAR.TabIndex = 13
        Me.MODIFICAR.Text = "MODIFICAR"
        Me.MODIFICAR.UseVisualStyleBackColor = True
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELIMINAR.Location = New System.Drawing.Point(581, 217)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(111, 42)
        Me.ELIMINAR.TabIndex = 14
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = True
        '
        'USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 290)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.MODIFICAR)
        Me.Controls.Add(Me.REGISTRAR)
        Me.Controls.Add(Me.Telefono_Estudiante)
        Me.Controls.Add(Me.Edad_Estudiante)
        Me.Controls.Add(Me.Apellidos_Estudiante)
        Me.Controls.Add(Me.Nombre_Estudiante)
        Me.Controls.Add(Me.Identificacion_Estudiante)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "USUARIOS"
        Me.Text = "Usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Identificacion_Estudiante As TextBox
    Friend WithEvents Nombre_Estudiante As TextBox
    Friend WithEvents Apellidos_Estudiante As TextBox
    Friend WithEvents Edad_Estudiante As TextBox
    Friend WithEvents Telefono_Estudiante As TextBox
    Friend WithEvents REGISTRAR As Button
    Friend WithEvents MODIFICAR As Button
    Friend WithEvents ELIMINAR As Button
End Class
