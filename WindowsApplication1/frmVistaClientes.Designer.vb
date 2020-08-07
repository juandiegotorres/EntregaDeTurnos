<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.rbDocumentoCliente = New System.Windows.Forms.RadioButton()
        Me.rbApellidoCliente = New System.Windows.Forms.RadioButton()
        Me.rbNombreCliente = New System.Windows.Forms.RadioButton()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.activo, Me.nombre, Me.apellido, Me.documento, Me.Provincia, Me.nombreLocalidad, Me.localidad, Me.CodPostal, Me.direccion, Me.telefono})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.Location = New System.Drawing.Point(13, 85)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(753, 157)
        Me.dgvClientes.TabIndex = 0
        '
        'idCliente
        '
        Me.idCliente.DataPropertyName = "idCliente"
        Me.idCliente.HeaderText = "Cliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Visible = False
        '
        'activo
        '
        Me.activo.DataPropertyName = "activo"
        Me.activo.HeaderText = "Activo"
        Me.activo.Name = "activo"
        Me.activo.ReadOnly = True
        Me.activo.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'documento
        '
        Me.documento.DataPropertyName = "documento"
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        '
        'Provincia
        '
        Me.Provincia.DataPropertyName = "idProvincia"
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        Me.Provincia.Visible = False
        '
        'nombreLocalidad
        '
        Me.nombreLocalidad.DataPropertyName = "nombreLocalidad"
        Me.nombreLocalidad.HeaderText = "Localidad"
        Me.nombreLocalidad.Name = "nombreLocalidad"
        Me.nombreLocalidad.ReadOnly = True
        '
        'localidad
        '
        Me.localidad.DataPropertyName = "localidad"
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Visible = False
        '
        'CodPostal
        '
        Me.CodPostal.DataPropertyName = "codPostal"
        Me.CodPostal.HeaderText = "Cod Postal"
        Me.CodPostal.Name = "CodPostal"
        Me.CodPostal.ReadOnly = True
        Me.CodPostal.Visible = False
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "CLIENTES"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(-2, 33)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(595, 10)
        Me.Line1.TabIndex = 9
        Me.Line1.Text = "Line1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(671, 254)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 29)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtBusqueda.Location = New System.Drawing.Point(13, 52)
        Me.txtBusqueda.MaxLength = 8
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(186, 21)
        Me.txtBusqueda.TabIndex = 14
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(570, 254)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 29)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'rbDocumentoCliente
        '
        Me.rbDocumentoCliente.AutoSize = True
        Me.rbDocumentoCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbDocumentoCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDocumentoCliente.Location = New System.Drawing.Point(368, 53)
        Me.rbDocumentoCliente.Name = "rbDocumentoCliente"
        Me.rbDocumentoCliente.Size = New System.Drawing.Size(100, 20)
        Me.rbDocumentoCliente.TabIndex = 26
        Me.rbDocumentoCliente.TabStop = True
        Me.rbDocumentoCliente.Text = "Documento"
        Me.rbDocumentoCliente.UseVisualStyleBackColor = False
        '
        'rbApellidoCliente
        '
        Me.rbApellidoCliente.AutoSize = True
        Me.rbApellidoCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbApellidoCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbApellidoCliente.Location = New System.Drawing.Point(286, 53)
        Me.rbApellidoCliente.Name = "rbApellidoCliente"
        Me.rbApellidoCliente.Size = New System.Drawing.Size(76, 20)
        Me.rbApellidoCliente.TabIndex = 25
        Me.rbApellidoCliente.TabStop = True
        Me.rbApellidoCliente.Text = "Apellido"
        Me.rbApellidoCliente.UseVisualStyleBackColor = False
        '
        'rbNombreCliente
        '
        Me.rbNombreCliente.AutoSize = True
        Me.rbNombreCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbNombreCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreCliente.Location = New System.Drawing.Point(205, 53)
        Me.rbNombreCliente.Name = "rbNombreCliente"
        Me.rbNombreCliente.Size = New System.Drawing.Size(75, 20)
        Me.rbNombreCliente.TabIndex = 24
        Me.rbNombreCliente.TabStop = True
        Me.rbNombreCliente.Text = "Nombre"
        Me.rbNombreCliente.UseVisualStyleBackColor = False
        '
        'frmVistaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(787, 295)
        Me.Controls.Add(Me.rbDocumentoCliente)
        Me.Controls.Add(Me.rbApellidoCliente)
        Me.Controls.Add(Me.rbNombreCliente)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvClientes)
        Me.MaximumSize = New System.Drawing.Size(803, 334)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(803, 334)
        Me.Name = "frmVistaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:Clientes:."
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents idCliente As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents documento As DataGridViewTextBoxColumn
    Friend WithEvents Provincia As DataGridViewTextBoxColumn
    Friend WithEvents nombreLocalidad As DataGridViewTextBoxColumn
    Friend WithEvents localidad As DataGridViewTextBoxColumn
    Friend WithEvents CodPostal As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As Button
    Friend WithEvents rbDocumentoCliente As RadioButton
    Friend WithEvents rbApellidoCliente As RadioButton
    Friend WithEvents rbNombreCliente As RadioButton
End Class
