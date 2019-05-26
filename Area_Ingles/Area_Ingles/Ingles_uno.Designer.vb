<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingles_uno
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_evaluar_ingles_uno = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Verbo 'to be' en presente/Contracción     ", "I am(ai em)/I'm(aim)--Yo soy/estoy        ", "You are(iu ar)/You're(iur)--Tú eres/estás", "He is(ji is)/He's(jis)--Él es/está ", "She is(shi is)/She's(shis)--Ella es/está", "We are(güi ar)/We're(güir)--Nosotros somos/estamos", "You are(iu ar)/You're(iur)--Ustedes son/están", "They are(dei ar)/They're(deir)--Ellos son/están", "It is (it is)/It's (its) Eso es/está", "", "Verbo 'to be'en pasado", "I was(ai guas)--Yo fui/estuve", "You were(iu güer)--Tú fuiste/estuviste", "He was(ji guas) --Él fue/estuvo", "She was(shi guas)--Ella fue/estuvo", "We were(güi güer)--Nosotros fuimos/estuvimos", "You were(iu güer)--Ustedes fueron/estuvieron", "They were(dei güer)--Ellos fueron/estuvieron", "It was(it guas)--Eso fue/estuvo"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 31)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(521, 116)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Verbo ""ser"" o ""estar"" → Verb ""to be""(verb tu bi)"
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Items.AddRange(New Object() {"Negación del verbo ""to be"" ", "Verbo 'to be'en negativo presente/Contracción", "I am not(ai em not)/I ain't(ai éint)--Yo no soy/estoy", "You are not(iu ar not)/You aren't(iu árent)--Tú no eres/estás", "He is not(ji is not)/He isn't(ji isnt)--Él no es/está", "She is not(shi is not)/She isn't(shi isnt)--Ella no es/ está", "We are not(güi ar not)/We aren't(güi árent)--Nosotros no somos/estamos", "You are not(iu ar not)/You aren't(iu árent)--Ustedes no son/están", "They are not(dei ar not)/They aren't(dei árent)--Ellos no son/están", "It is not(it is not)/It isn't(it isnt)--Eso no es/está ", "", "Verbo 'to be' en negativo pasado/Contracción", "I was not(ai guas not)/I wasn't(ai guasnt)--Yo no fui/estuve", "You were not(iu güer not)/You weren't(iu güérent)--Tú no fuiste/estuviste", "He was not(ji guas not)/He wasn't(ji guasnt)--Él no fue/estuvo", "She was not(shi guas not)/She wasn't(shi guasnt)--Ella no fue/estuvo", "We were not(güi güer not)/We weren't(güi güérent)--Nosotros no fuimos/estuvimos", "You were not(iu güer not)/You weren't(iu güérent)--Ustedes no fueron/estuvieron", "They were not(dei güer not)/They weren't(dei güérent)--Ellos no fueron/estuvieron" &
                "", "It was not(it guas not)/It wasn't(it guasnt)--Eso no fue/estuvo"})
        Me.ListBox2.Location = New System.Drawing.Point(16, 187)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(517, 132)
        Me.ListBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Negación del verbo ""to be"" "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Area_Ingles.My.Resources.Resources.Captura7
        Me.PictureBox1.Location = New System.Drawing.Point(539, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Area_Ingles.My.Resources.Resources.Captura8
        Me.PictureBox2.Location = New System.Drawing.Point(539, 243)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(283, 240)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(255, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_evaluar_ingles_uno
        '
        Me.btn_evaluar_ingles_uno.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_evaluar_ingles_uno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_evaluar_ingles_uno.Location = New System.Drawing.Point(78, 355)
        Me.btn_evaluar_ingles_uno.Name = "btn_evaluar_ingles_uno"
        Me.btn_evaluar_ingles_uno.Size = New System.Drawing.Size(111, 32)
        Me.btn_evaluar_ingles_uno.TabIndex = 7
        Me.btn_evaluar_ingles_uno.Text = "EVALUAR"
        Me.btn_evaluar_ingles_uno.UseVisualStyleBackColor = False
        '
        'Ingles_uno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 507)
        Me.Controls.Add(Me.btn_evaluar_ingles_uno)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Ingles_uno"
        Me.Text = "Ingles_uno"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_evaluar_ingles_uno As Button
End Class
