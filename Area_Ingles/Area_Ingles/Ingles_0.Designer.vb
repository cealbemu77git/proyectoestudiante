<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingles_0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingles_0))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_evaluar_Ingles_cero = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"1 Uno-- One (guan)", "2 Dos --Two (tu)", "3 Tres --Three (thri)", "4 Cuatro --Four (for)", "5 Cinco --Five (faif)", "6 Seis --Six (siks)", "7 Siete --Seven (seven)", "8 Ocho --Eight (eit)", "9 Nueve --Nine (nain)", "10 Diez-- Ten (ten)", "11 Once --Eleven (ileven)", "12 Doce --Twelve (tuelf)", "13 Trece --Thirteen (thertin)", "14 Catorce ---Fourteen (fortin)", "15 Quince-- Fifteen (fiftin)", "16 Dieciséis --Sixteen (sikstin)", "17 Diecisiete --Seventeen (seventin)", "18 Dieciocho --Eighteen (eitin)", "19 Diecinueve-- Nineteen (naintin)", "20 Veinte --Twenty (tuenti)", "21 Veintiuno --Twenty one (tuenti guan)", "30 Treinta --Thirty (therti)", "40 Cuarenta-- Forty (forti)", "50 Cincuenta-- Fifty (fifti)", "60 Sesenta-- Sixty (siksti)", "70 Setenta --Seventy (seventi)", "80 Ochenta --Eighty (eiti)", "90 Noventa-- Ninety (nainti)", "100 Cien --One hundred (guan jandred)", "500 Quinientos --Five hundred (faif jandred)", "1,000 Mil --One thousand (guan thausend)", "2,700 Dos mil setecientos --Two thousand seven hundred (tu thausend seven jandred" &
                ")", "1,000,000 Un millón --One million (guan miliend)", "1,000,000,000 Un billón --One billion (guan biliend)"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(497, 84)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Items.AddRange(New Object() {"Nombres de la familia", "mother: madre ", "father: padre", "daughter: hija", "son: hijo ", "baby: bebé ", "grandmother: abuela", "grandfather: abuelo", "granddaughter: nieta", "grandson: nieto", "aunt: tía", "uncle: tío", "cousin: primo", "", "Parentesco en inglés", "parents: padres", "children: niños", "sister: hermana", "brother: hermano", "siblings: hermanos", "grandparents: abuelos"})
        Me.ListBox2.Location = New System.Drawing.Point(515, 36)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(312, 84)
        Me.ListBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pronombres personales "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(516, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombres de la familia"
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Items.AddRange(New Object() {"Partes del cuerpo", "Hair /hɛər/: pelo", "She has long dark hair / Ella tiene pelo largo y oscuro", "", "Head /hɛd/: cabeza", "I hit my head last night / Me golpeé mi cabeza anoche", "", "Eyes /aɪz/: ojos", "I like blue eyes / Me gustan los ojos azules", "", "Nose /nəʊz/: nariz  ", "He broke my nose on purpose / Él rompió mi nariz a propósito", "", "Ear /ɪər/: oreja", "Cats and elephants have long ears / Los gatos y los elefantes tienen orejas larga" &
                "s", "", "Mouth /maʊθ/: boca", "I don’t like my mouth because it is too big / No me gusta mi boca porque es muy g" &
                "rande", "", "Shoulder /ˈʃəʊldər/: hombre", "Arm /ɑːrm/: brazo", "", "I broke my arm last year / Me rompí mi brazo el año pasado", "", "Hand /hænd/: mano", "She shook my hand hard / Ella estrechó mi mano con fuerza", "", "Leg /lɛɡ/: pierna", "My leg hurts a lot / Me duele la pierna mucho", "", "Knee /niː/: rodilla", "The football player hurt his knee badly / El jugador de fútbol se lastimó la rodi" &
                "lla gravemente", "", "Foot /fʊt/: pie", "Hit the ball with your right foot / Patea la pelota con tu pie derecho", "", "Feet /fiːt/: pies", "I think my feet are too small / Pienso que mis pies son demasiado pequeños"})
        Me.ListBox3.Location = New System.Drawing.Point(456, 150)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(370, 84)
        Me.ListBox3.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Partes del cuerpo"
        '
        'btn_evaluar_Ingles_cero
        '
        Me.btn_evaluar_Ingles_cero.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_evaluar_Ingles_cero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_evaluar_Ingles_cero.Location = New System.Drawing.Point(475, 495)
        Me.btn_evaluar_Ingles_cero.Name = "btn_evaluar_Ingles_cero"
        Me.btn_evaluar_Ingles_cero.Size = New System.Drawing.Size(115, 29)
        Me.btn_evaluar_Ingles_cero.TabIndex = 8
        Me.btn_evaluar_Ingles_cero.Text = "EVALUAR"
        Me.btn_evaluar_Ingles_cero.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(634, 494)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Area_Ingles.My.Resources.Resources.Captura5
        Me.PictureBox2.Location = New System.Drawing.Point(456, 240)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(382, 223)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Area_Ingles.My.Resources.Resources.Captura4
        Me.PictureBox1.Location = New System.Drawing.Point(12, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(17, 240)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(433, 284)
        Me.AxWindowsMediaPlayer1.TabIndex = 10
        '
        'Ingles_0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 566)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_evaluar_Ingles_cero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Ingles_0"
        Me.Text = "Ingles_0"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_evaluar_Ingles_cero As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
