<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Basededatos
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
        Me.components = New System.ComponentModel.Container()
        Dim CódigoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim Usuario As System.Windows.Forms.Label
        Dim Teléfono_o_celularLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Basededatos))
        Me.Estudiantes6bdDataSet = New Base_de_datos.Estudiantes6bdDataSet()
        Me.InformacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InformacionTableAdapter = New Base_de_datos.Estudiantes6bdDataSetTableAdapters.InformacionTableAdapter()
        Me.TableAdapterManager = New Base_de_datos.Estudiantes6bdDataSetTableAdapters.TableAdapterManager()
        Me.InformacionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InformacionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contracena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label_conexion = New System.Windows.Forms.Label()
        Me.Button2registrar = New System.Windows.Forms.Button()
        CódigoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Usuario = New System.Windows.Forms.Label()
        Teléfono_o_celularLabel = New System.Windows.Forms.Label()
        CType(Me.Estudiantes6bdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformacionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InformacionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CódigoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CódigoLabel.Location = New System.Drawing.Point(35, 91)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(57, 16)
        CódigoLabel.TabIndex = 1
        CódigoLabel.Text = "Cedula"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NombreLabel.Location = New System.Drawing.Point(325, 89)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(67, 16)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ApellidoLabel.Location = New System.Drawing.Point(44, 159)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(70, 16)
        ApellidoLabel.TabIndex = 5
        ApellidoLabel.Text = "Apellido:"
        '
        'Usuario
        '
        Usuario.AutoSize = True
        Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Usuario.Location = New System.Drawing.Point(45, 207)
        Usuario.Name = "Usuario"
        Usuario.Size = New System.Drawing.Size(62, 16)
        Usuario.TabIndex = 7
        Usuario.Text = "Usuario"
        '
        'Teléfono_o_celularLabel
        '
        Teléfono_o_celularLabel.AutoSize = True
        Teléfono_o_celularLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Teléfono_o_celularLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Teléfono_o_celularLabel.Location = New System.Drawing.Point(313, 207)
        Teléfono_o_celularLabel.Name = "Teléfono_o_celularLabel"
        Teléfono_o_celularLabel.Size = New System.Drawing.Size(87, 16)
        Teléfono_o_celularLabel.TabIndex = 9
        Teléfono_o_celularLabel.Text = "Contraceña"
        '
        'Estudiantes6bdDataSet
        '
        Me.Estudiantes6bdDataSet.DataSetName = "Estudiantes6bdDataSet"
        Me.Estudiantes6bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InformacionBindingSource
        '
        Me.InformacionBindingSource.DataMember = "Informacion"
        Me.InformacionBindingSource.DataSource = Me.Estudiantes6bdDataSet
        '
        'InformacionTableAdapter
        '
        Me.InformacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InformacionTableAdapter = Me.InformacionTableAdapter
        Me.TableAdapterManager.UpdateOrder = Base_de_datos.Estudiantes6bdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InformacionBindingNavigator
        '
        Me.InformacionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InformacionBindingNavigator.BindingSource = Me.InformacionBindingSource
        Me.InformacionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InformacionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InformacionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InformacionBindingNavigatorSaveItem})
        Me.InformacionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InformacionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InformacionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InformacionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InformacionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InformacionBindingNavigator.Name = "InformacionBindingNavigator"
        Me.InformacionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InformacionBindingNavigator.Size = New System.Drawing.Size(681, 25)
        Me.InformacionBindingNavigator.TabIndex = 0
        Me.InformacionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InformacionBindingNavigatorSaveItem
        '
        Me.InformacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InformacionBindingNavigatorSaveItem.Image = CType(resources.GetObject("InformacionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InformacionBindingNavigatorSaveItem.Name = "InformacionBindingNavigatorSaveItem"
        Me.InformacionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InformacionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txt_cedula
        '
        Me.txt_cedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformacionBindingSource, "Código", True))
        Me.txt_cedula.Location = New System.Drawing.Point(137, 88)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(160, 20)
        Me.txt_cedula.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformacionBindingSource, "Nombre", True))
        Me.txt_nombre.Location = New System.Drawing.Point(406, 86)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(160, 20)
        Me.txt_nombre.TabIndex = 4
        '
        'txt_apellido
        '
        Me.txt_apellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformacionBindingSource, "Apellido", True))
        Me.txt_apellido.Location = New System.Drawing.Point(137, 156)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(160, 20)
        Me.txt_apellido.TabIndex = 6
        '
        'txt_usuario
        '
        Me.txt_usuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformacionBindingSource, "Correo electronico", True))
        Me.txt_usuario.Location = New System.Drawing.Point(137, 207)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(160, 20)
        Me.txt_usuario.TabIndex = 8
        '
        'txt_contracena
        '
        Me.txt_contracena.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformacionBindingSource, "Teléfono o celular", True))
        Me.txt_contracena.Location = New System.Drawing.Point(406, 207)
        Me.txt_contracena.Name = "txt_contracena"
        Me.txt_contracena.Size = New System.Drawing.Size(160, 20)
        Me.txt_contracena.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "REGISTRO"
        '
        'Btnsalir
        '
        Me.Btnsalir.BackgroundImage = CType(resources.GetObject("Btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.Btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnsalir.Location = New System.Drawing.Point(355, 274)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(55, 52)
        Me.Btnsalir.TabIndex = 17
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(370, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(216, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 42)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Menú"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'label_conexion
        '
        Me.label_conexion.AutoSize = True
        Me.label_conexion.Location = New System.Drawing.Point(12, 332)
        Me.label_conexion.Name = "label_conexion"
        Me.label_conexion.Size = New System.Drawing.Size(13, 13)
        Me.label_conexion.TabIndex = 20
        Me.label_conexion.Text = "c"
        '
        'Button2registrar
        '
        Me.Button2registrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2registrar.Location = New System.Drawing.Point(60, 274)
        Me.Button2registrar.Name = "Button2registrar"
        Me.Button2registrar.Size = New System.Drawing.Size(106, 42)
        Me.Button2registrar.TabIndex = 21
        Me.Button2registrar.Text = "Registrar"
        Me.Button2registrar.UseVisualStyleBackColor = False
        '
        'Basededatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(681, 368)
        Me.Controls.Add(Me.Button2registrar)
        Me.Controls.Add(Me.label_conexion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CódigoLabel)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Usuario)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Teléfono_o_celularLabel)
        Me.Controls.Add(Me.txt_contracena)
        Me.Controls.Add(Me.InformacionBindingNavigator)
        Me.Name = "Basededatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basededatos"
        CType(Me.Estudiantes6bdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformacionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InformacionBindingNavigator.ResumeLayout(False)
        Me.InformacionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Estudiantes6bdDataSet As Estudiantes6bdDataSet
    Friend WithEvents InformacionBindingSource As BindingSource
    Friend WithEvents InformacionTableAdapter As Estudiantes6bdDataSetTableAdapters.InformacionTableAdapter
    Friend WithEvents TableAdapterManager As Estudiantes6bdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InformacionBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents InformacionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_contracena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnsalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents label_conexion As Label
    Friend WithEvents Button2registrar As Button
End Class
