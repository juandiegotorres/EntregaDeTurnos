<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.RichTextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.btnLocalidades = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCodPost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Teléfono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "CLIENTE"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(2, 28)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(440, 12)
        Me.Line1.TabIndex = 8
        Me.Line1.Text = "Line1"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(133, 56)
        Me.txtNombre.MaxLength = 45
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(210, 21)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(133, 94)
        Me.txtApellido.MaxLength = 45
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(231, 21)
        Me.txtApellido.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Provincia"
        '
        'cbProvincia
        '
        Me.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvincia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(133, 170)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(210, 21)
        Me.cbProvincia.TabIndex = 4
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(24, 210)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(69, 16)
        Me.Label.TabIndex = 16
        Me.Label.Text = "Localidad"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(133, 285)
        Me.txtDireccion.MaxLength = 60
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(245, 47)
        Me.txtDireccion.TabIndex = 5
        Me.txtDireccion.Text = ""
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.Location = New System.Drawing.Point(133, 209)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.ReadOnly = True
        Me.txtLocalidad.Size = New System.Drawing.Size(161, 21)
        Me.txtLocalidad.TabIndex = 18
        '
        'btnLocalidades
        '
        Me.btnLocalidades.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalidades.Location = New System.Drawing.Point(300, 207)
        Me.btnLocalidades.Name = "btnLocalidades"
        Me.btnLocalidades.Size = New System.Drawing.Size(88, 23)
        Me.btnLocalidades.TabIndex = 19
        Me.btnLocalidades.Text = "Localidades"
        Me.btnLocalidades.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(263, 397)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 25)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.FlatAppearance.BorderSize = 2
        Me.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(31, 397)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 25)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Código Postal"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLimpiar.FlatAppearance.BorderSize = 2
        Me.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(147, 397)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(92, 25)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtDocumento
        '
        Me.txtDocumento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(133, 132)
        Me.txtDocumento.MaxLength = 8
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(161, 21)
        Me.txtDocumento.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(133, 350)
        Me.txtTelefono.MaxLength = 16
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(161, 21)
        Me.txtTelefono.TabIndex = 6
        '
        'txtCodPost
        '
        Me.txtCodPost.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPost.Location = New System.Drawing.Point(133, 247)
        Me.txtCodPost.Name = "txtCodPost"
        Me.txtCodPost.ReadOnly = True
        Me.txtCodPost.Size = New System.Drawing.Size(100, 21)
        Me.txtCodPost.TabIndex = 29
        '
        'frmAgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 433)
        Me.Controls.Add(Me.txtCodPost)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLocalidades)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.cbProvincia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(405, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(405, 472)
        Me.Name = "frmAgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:Agregar Cliente:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents Label As Label
    Friend WithEvents txtDireccion As RichTextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents btnLocalidades As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCodPost As TextBox
End Class
