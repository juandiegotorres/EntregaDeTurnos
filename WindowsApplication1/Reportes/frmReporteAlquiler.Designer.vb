<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteAlquiler
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.Line4 = New DevComponents.DotNetBar.Controls.Line()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.dgvTurnos = New System.Windows.Forms.DataGridView()
        Me.idTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activoturno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.extras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cbDia = New System.Windows.Forms.CheckBox()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cantidad de alquileres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hasta:"
        '
        'dtpDesde
        '
        Me.dtpDesde.CalendarFont = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDesde.Location = New System.Drawing.Point(123, 61)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(144, 27)
        Me.dtpDesde.TabIndex = 16
        '
        'dtpHasta
        '
        Me.dtpHasta.CalendarFont = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(359, 61)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(144, 27)
        Me.dtpHasta.TabIndex = 18
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.Transparent
        Me.Line2.Location = New System.Drawing.Point(855, 47)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(10, 56)
        Me.Line2.TabIndex = 22
        Me.Line2.Text = "Line2"
        Me.Line2.VerticalLine = True
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Transparent
        Me.Line4.Location = New System.Drawing.Point(23, 39)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(837, 16)
        Me.Line4.TabIndex = 24
        Me.Line4.Text = "Line4"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Transparent
        Me.Line1.Location = New System.Drawing.Point(17, 47)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(10, 56)
        Me.Line1.TabIndex = 25
        Me.Line1.Text = "Line1"
        Me.Line1.VerticalLine = True
        '
        'dgvTurnos
        '
        Me.dgvTurnos.AllowUserToAddRows = False
        Me.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTurno, Me.cliente, Me.nombreCliente, Me.apellidoCliente, Me.fecha, Me.hora, Me.descripcion, Me.activoturno, Me.extras})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(212, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTurnos.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTurnos.Location = New System.Drawing.Point(21, 128)
        Me.dgvTurnos.Name = "dgvTurnos"
        Me.dgvTurnos.ReadOnly = True
        Me.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTurnos.Size = New System.Drawing.Size(837, 287)
        Me.dgvTurnos.TabIndex = 27
        '
        'idTurno
        '
        Me.idTurno.DataPropertyName = "idTurno"
        Me.idTurno.HeaderText = "IDTurno"
        Me.idTurno.Name = "idTurno"
        Me.idTurno.ReadOnly = True
        Me.idTurno.Visible = False
        '
        'cliente
        '
        Me.cliente.DataPropertyName = "cliente"
        Me.cliente.HeaderText = "IDCliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Visible = False
        '
        'nombreCliente
        '
        Me.nombreCliente.DataPropertyName = "nombre"
        Me.nombreCliente.HeaderText = "Nombre"
        Me.nombreCliente.Name = "nombreCliente"
        Me.nombreCliente.ReadOnly = True
        '
        'apellidoCliente
        '
        Me.apellidoCliente.DataPropertyName = "apellido"
        Me.apellidoCliente.HeaderText = "Apellido"
        Me.apellidoCliente.Name = "apellidoCliente"
        Me.apellidoCliente.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'hora
        '
        Me.hora.DataPropertyName = "hora"
        Me.hora.HeaderText = "Hora"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'activoturno
        '
        Me.activoturno.DataPropertyName = "activo"
        Me.activoturno.HeaderText = "Activo"
        Me.activoturno.Name = "activoturno"
        Me.activoturno.ReadOnly = True
        Me.activoturno.Visible = False
        '
        'extras
        '
        Me.extras.DataPropertyName = "extra"
        Me.extras.HeaderText = "Extras"
        Me.extras.Name = "extras"
        Me.extras.ReadOnly = True
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Transparent
        Me.Line3.Location = New System.Drawing.Point(23, 94)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(837, 16)
        Me.Line3.TabIndex = 28
        Me.Line3.Text = "Line3"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(678, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(171, 27)
        Me.btnBuscar.TabIndex = 29
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(18, 437)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(177, 29)
        Me.lblCantidad.TabIndex = 30
        Me.lblCantidad.Text = "Soy un label"
        '
        'cbDia
        '
        Me.cbDia.AutoSize = True
        Me.cbDia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDia.Location = New System.Drawing.Point(25, 107)
        Me.cbDia.Name = "cbDia"
        Me.cbDia.Size = New System.Drawing.Size(164, 17)
        Me.cbDia.TabIndex = 32
        Me.cbDia.Text = "Buscar un día específico"
        Me.cbDia.UseVisualStyleBackColor = True
        '
        'frmReporteAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(894, 496)
        Me.Controls.Add(Me.cbDia)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.dgvTurnos)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Line1)
        Me.Name = "frmReporteAlquiler"
        Me.Text = "frmReporteAlquiler"
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Line4 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents dgvTurnos As DataGridView
    Friend WithEvents idTurno As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents nombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents apellidoCliente As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents hora As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents activoturno As DataGridViewTextBoxColumn
    Friend WithEvents extras As DataGridViewTextBoxColumn
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents cbDia As CheckBox
End Class
