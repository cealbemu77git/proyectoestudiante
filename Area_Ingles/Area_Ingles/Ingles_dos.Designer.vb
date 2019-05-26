<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingles_dos
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Saludos y presentaciones ", "Buenos días--buenas noches", "Good morning--good evening", "", "Hola--adiós", "Hello--good bye", "", "Nos vemos luego", "I will see you later", "", "Yo me llamo", "My name is", "", "¿Cómo se llama?", "What is your name?", "", "¿Me permite presentarle ", "(al señor, a la señora, a la señorita)?", "May I introduce (Mr., Mrs., Miss)?", "", "Mi esposa--mi esposo", "My wife--my husband", "", "Mi hija--mi hijo", "My daughter--my son", "", "Mi amigo", "My friend", "", "Mi hermana--mi hermano", "My sister--my brother", "", "¿Cómo está usted?", "How are you?", "", "Bien--¿y usted?", "Fine--and you?", "", "¿Cómo está su familia?", "How is your family?", "", "(No) muy bien", "(Not) very well", "", "Por favor siéntate", "Please sit down", "", "Me he divertido mucho", "I have had so much fun", "", "Espero verte (otra vez, pronto)", "I hope to see you (again, soon)", "", "Venga a verme", "Come to see me", "", "Deme su dirección (y su número de teléfono)", "Give me your address (and telephone number)", "", "Dé mis saludos a...", "Give my regards to...", "", "Nosotros viajamos a...", "We are traveling to…", "", "Restaurante y alimentos ", "¿Dónde hay un buen restaurante?", "Where is a good restaurant?", "", "El desayuno, la comida, la cena", "Breakfast, lunch, dinner", "", "Un sándwich", "A sandwich", "", "¿A qué hora se sirve la comida?", "At what time is dinner served?", "", "¿Podemos comer (cenar) ahora?", "Can we have lunch (dinner) now?", "", "La mesera, el mesero", "The waitress, the waiter", "", "Deme una mesa cerca de la ventana", "Give me a table near the window", "", "¿Está reservada esta mesa?", "Is this table reserved?", "", "Aquella mesa estará desocupada dentro de poco", "That table will be free soon", "", "Haga el favor de servirnos rápido", "Please serve us quickly", "", "Tráigame el menú (la carta de vinos)", "Bring me the menu (the wine list)", "", "Una servilleta, un vaso", "A napkin, a glass", "", "Un tenedor, una cuchara", "A fork, a spoon", "", "Azúcar, sal, pimienta", "Sugar, salt, pepper", "", "Salsa, aceite, vinagre", "Sauce, oil, vinegar", "", "Esto no está limpio", "This is not clean", "", "Está sucio", "It is dirty", "", "Ya es suficiente, gracias", "I have had enough, thanks", "", "Esto está frío", "This is cold", "", "Lléveselo", "Take it away", "", "No he pedido esto", "I did not order this", "", "¿Se puede cambiar esto por?", "May I change this for?", "", "La cuenta, por favor", "The check, please", "", "¿Está incluida la propina?", "Is the tip included?", "", "¿Hay que pagar por el servicio?", "Is there a service charge?", "", "El cambio es para usted", "Keep the change", "", "Hay un error en la cuenta", "There is a mistake in the bill", "", "¿Qué son estos cargos?", "What are these charges for?", "", "Un coctel", "A cocktail", "", "Un refresco", "A soft drink", "", "Una bebida de frutas", "A fruit drink", "", "Un vaso de", "A glass of", "", "Cerveza", "Beer", "", "Vino tinto, vino blanco", "Red wine, white wine", "", "Tomemos otro más", "Let’s have another", "", "Caldo (de pollo, con verduras)", "(Chicken) Soup (with vegetables)", "", "Huevos (revueltos, fritos)", "(scrambled, fried) Eggs", "", "Carne asada", "Roast beef", "", "Langosta", "Lobster", "", "Camarones", "Shrimp", "", "Rebanada de...", "Slice of..."})
        Me.ListBox1.Location = New System.Drawing.Point(16, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(254, 116)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Saludos y presentaciones "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Area_Ingles.My.Resources.Resources.Captura9
        Me.PictureBox1.Location = New System.Drawing.Point(276, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(168, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(52, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "EVALUAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Ingles_dos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 258)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Ingles_dos"
        Me.Text = "Ingles_dos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
