<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBajas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.pnlTurnos = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.rbApellidoTurno = New System.Windows.Forms.RadioButton()
        Me.rbNombreTurno = New System.Windows.Forms.RadioButton()
        Me.txtBuscarTurno = New System.Windows.Forms.TextBox()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Line5 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnCancelarTurno = New System.Windows.Forms.Button()
        Me.btnRestaurarTurno = New System.Windows.Forms.Button()
        Me.btnEliminarTurno = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.rbApellidoCliente = New System.Windows.Forms.RadioButton()
        Me.rbNombreCliente = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
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
        Me.btnRestaurarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlClientes = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Line4 = New DevComponents.DotNetBar.Controls.Line()
        Me.txtBuscarExtra = New System.Windows.Forms.TextBox()
        Me.btnCancelarExtra = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRestaurarExtra = New System.Windows.Forms.Button()
        Me.Line6 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnEliminarExtra = New System.Windows.Forms.Button()
        Me.dgvExtras = New System.Windows.Forms.DataGridView()
        Me.idExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activoExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlExtras = New DevComponents.DotNetBar.SuperTabItem()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.pnlTurnos.SuspendLayout()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.dgvExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.pnlTurnos)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Location = New System.Drawing.Point(1, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(787, 543)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.pnlClientes, Me.pnlExtras})
        Me.SuperTabControl1.Text = "Turnos"
        '
        'pnlTurnos
        '
        Me.pnlTurnos.Controls.Add(Me.rbApellidoTurno)
        Me.pnlTurnos.Controls.Add(Me.rbNombreTurno)
        Me.pnlTurnos.Controls.Add(Me.txtBuscarTurno)
        Me.pnlTurnos.Controls.Add(Me.Line3)
        Me.pnlTurnos.Controls.Add(Me.Label5)
        Me.pnlTurnos.Controls.Add(Me.Line5)
        Me.pnlTurnos.Controls.Add(Me.btnCancelarTurno)
        Me.pnlTurnos.Controls.Add(Me.btnRestaurarTurno)
        Me.pnlTurnos.Controls.Add(Me.btnEliminarTurno)
        Me.pnlTurnos.Controls.Add(Me.dgvTurnos)
        Me.pnlTurnos.Controls.Add(Me.Label1)
        Me.pnlTurnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTurnos.Location = New System.Drawing.Point(0, 25)
        Me.pnlTurnos.Name = "pnlTurnos"
        Me.pnlTurnos.Size = New System.Drawing.Size(787, 518)
        Me.pnlTurnos.TabIndex = 1
        Me.pnlTurnos.TabItem = Me.SuperTabItem1
        '
        'rbApellidoTurno
        '
        Me.rbApellidoTurno.AutoSize = True
        Me.rbApellidoTurno.BackColor = System.Drawing.Color.Transparent
        Me.rbApellidoTurno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbApellidoTurno.Location = New System.Drawing.Point(317, 87)
        Me.rbApellidoTurno.Name = "rbApellidoTurno"
        Me.rbApellidoTurno.Size = New System.Drawing.Size(76, 20)
        Me.rbApellidoTurno.TabIndex = 29
        Me.rbApellidoTurno.TabStop = True
        Me.rbApellidoTurno.Text = "Apellido"
        Me.rbApellidoTurno.UseVisualStyleBackColor = False
        '
        'rbNombreTurno
        '
        Me.rbNombreTurno.AutoSize = True
        Me.rbNombreTurno.BackColor = System.Drawing.Color.Transparent
        Me.rbNombreTurno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreTurno.Location = New System.Drawing.Point(236, 87)
        Me.rbNombreTurno.Name = "rbNombreTurno"
        Me.rbNombreTurno.Size = New System.Drawing.Size(75, 20)
        Me.rbNombreTurno.TabIndex = 28
        Me.rbNombreTurno.TabStop = True
        Me.rbNombreTurno.Text = "Nombre"
        Me.rbNombreTurno.UseVisualStyleBackColor = False
        '
        'txtBuscarTurno
        '
        Me.txtBuscarTurno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarTurno.Location = New System.Drawing.Point(24, 87)
        Me.txtBuscarTurno.Name = "txtBuscarTurno"
        Me.txtBuscarTurno.Size = New System.Drawing.Size(206, 21)
        Me.txtBuscarTurno.TabIndex = 27
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Transparent
        Me.Line3.Location = New System.Drawing.Point(24, 35)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(700, 10)
        Me.Line3.TabIndex = 26
        Me.Line3.Text = "Line3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Buscar"
        '
        'Line5
        '
        Me.Line5.BackColor = System.Drawing.Color.Transparent
        Me.Line5.Location = New System.Drawing.Point(24, 70)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(708, 10)
        Me.Line5.TabIndex = 25
        Me.Line5.Text = "Line5"
        '
        'btnCancelarTurno
        '
        Me.btnCancelarTurno.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarTurno.Location = New System.Drawing.Point(664, 464)
        Me.btnCancelarTurno.Name = "btnCancelarTurno"
        Me.btnCancelarTurno.Size = New System.Drawing.Size(99, 42)
        Me.btnCancelarTurno.TabIndex = 23
        Me.btnCancelarTurno.Text = "Cancelar"
        Me.btnCancelarTurno.UseVisualStyleBackColor = True
        '
        'btnRestaurarTurno
        '
        Me.btnRestaurarTurno.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurarTurno.Location = New System.Drawing.Point(548, 464)
        Me.btnRestaurarTurno.Name = "btnRestaurarTurno"
        Me.btnRestaurarTurno.Size = New System.Drawing.Size(99, 42)
        Me.btnRestaurarTurno.TabIndex = 22
        Me.btnRestaurarTurno.Text = "Restaurar"
        Me.btnRestaurarTurno.UseVisualStyleBackColor = True
        '
        'btnEliminarTurno
        '
        Me.btnEliminarTurno.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTurno.Location = New System.Drawing.Point(432, 464)
        Me.btnEliminarTurno.Name = "btnEliminarTurno"
        Me.btnEliminarTurno.Size = New System.Drawing.Size(99, 42)
        Me.btnEliminarTurno.TabIndex = 21
        Me.btnEliminarTurno.Text = "Eliminar"
        Me.btnEliminarTurno.UseVisualStyleBackColor = True
        '
        'dgvTurnos
        '
        Me.dgvTurnos.AllowUserToAddRows = False
        Me.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTurno, Me.cliente, Me.nombreCliente, Me.apellidoCliente, Me.fecha, Me.hora, Me.descripcion, Me.activoturno, Me.extras})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(212, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTurnos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTurnos.Location = New System.Drawing.Point(24, 123)
        Me.dgvTurnos.Name = "dgvTurnos"
        Me.dgvTurnos.ReadOnly = True
        Me.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTurnos.Size = New System.Drawing.Size(738, 320)
        Me.dgvTurnos.TabIndex = 20
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Turnos dados de baja"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.pnlTurnos
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Turnos"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.Line2)
        Me.SuperTabControlPanel2.Controls.Add(Me.rbApellidoCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.rbNombreCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtBuscarCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label4)
        Me.SuperTabControlPanel2.Controls.Add(Me.Line1)
        Me.SuperTabControlPanel2.Controls.Add(Me.btnCancelarCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.dgvClientes)
        Me.SuperTabControlPanel2.Controls.Add(Me.btnRestaurarCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.btnEliminarCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label2)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(787, 518)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.pnlClientes
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.Transparent
        Me.Line2.Location = New System.Drawing.Point(24, 35)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(700, 10)
        Me.Line2.TabIndex = 35
        Me.Line2.Text = "Line2"
        '
        'rbApellidoCliente
        '
        Me.rbApellidoCliente.AutoSize = True
        Me.rbApellidoCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbApellidoCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbApellidoCliente.Location = New System.Drawing.Point(317, 88)
        Me.rbApellidoCliente.Name = "rbApellidoCliente"
        Me.rbApellidoCliente.Size = New System.Drawing.Size(76, 20)
        Me.rbApellidoCliente.TabIndex = 34
        Me.rbApellidoCliente.TabStop = True
        Me.rbApellidoCliente.Text = "Apellido"
        Me.rbApellidoCliente.UseVisualStyleBackColor = False
        '
        'rbNombreCliente
        '
        Me.rbNombreCliente.AutoSize = True
        Me.rbNombreCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbNombreCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreCliente.Location = New System.Drawing.Point(236, 88)
        Me.rbNombreCliente.Name = "rbNombreCliente"
        Me.rbNombreCliente.Size = New System.Drawing.Size(75, 20)
        Me.rbNombreCliente.TabIndex = 33
        Me.rbNombreCliente.TabStop = True
        Me.rbNombreCliente.Text = "Nombre"
        Me.rbNombreCliente.UseVisualStyleBackColor = False
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCliente.Location = New System.Drawing.Point(24, 88)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(206, 21)
        Me.txtBuscarCliente.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Buscar"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Transparent
        Me.Line1.Location = New System.Drawing.Point(24, 70)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(708, 10)
        Me.Line1.TabIndex = 31
        Me.Line1.Text = "Line1"
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCliente.Location = New System.Drawing.Point(664, 464)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(99, 42)
        Me.btnCancelarCliente.TabIndex = 26
        Me.btnCancelarCliente.Text = "Cancelar"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.activo, Me.nombre, Me.apellido, Me.documento, Me.Provincia, Me.nombreLocalidad, Me.localidad, Me.CodPostal, Me.direccion, Me.telefono})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClientes.Location = New System.Drawing.Point(24, 123)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(738, 320)
        Me.dgvClientes.TabIndex = 21
        Me.dgvClientes.TabStop = False
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
        'btnRestaurarCliente
        '
        Me.btnRestaurarCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurarCliente.Location = New System.Drawing.Point(548, 464)
        Me.btnRestaurarCliente.Name = "btnRestaurarCliente"
        Me.btnRestaurarCliente.Size = New System.Drawing.Size(99, 42)
        Me.btnRestaurarCliente.TabIndex = 25
        Me.btnRestaurarCliente.Text = "Restaurar"
        Me.btnRestaurarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.Location = New System.Drawing.Point(432, 464)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(99, 42)
        Me.btnEliminarCliente.TabIndex = 24
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clientes dados de baja"
        '
        'pnlClientes
        '
        Me.pnlClientes.AttachedControl = Me.SuperTabControlPanel2
        Me.pnlClientes.GlobalItem = False
        Me.pnlClientes.Name = "pnlClientes"
        Me.pnlClientes.Text = "Clientes"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.Line4)
        Me.SuperTabControlPanel3.Controls.Add(Me.txtBuscarExtra)
        Me.SuperTabControlPanel3.Controls.Add(Me.btnCancelarExtra)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label6)
        Me.SuperTabControlPanel3.Controls.Add(Me.btnRestaurarExtra)
        Me.SuperTabControlPanel3.Controls.Add(Me.Line6)
        Me.SuperTabControlPanel3.Controls.Add(Me.btnEliminarExtra)
        Me.SuperTabControlPanel3.Controls.Add(Me.dgvExtras)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label3)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(787, 543)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.pnlExtras
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Transparent
        Me.Line4.Location = New System.Drawing.Point(24, 35)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(700, 10)
        Me.Line4.TabIndex = 39
        Me.Line4.Text = "Line4"
        '
        'txtBuscarExtra
        '
        Me.txtBuscarExtra.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarExtra.Location = New System.Drawing.Point(24, 88)
        Me.txtBuscarExtra.Name = "txtBuscarExtra"
        Me.txtBuscarExtra.Size = New System.Drawing.Size(206, 21)
        Me.txtBuscarExtra.TabIndex = 38
        '
        'btnCancelarExtra
        '
        Me.btnCancelarExtra.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarExtra.Location = New System.Drawing.Point(664, 464)
        Me.btnCancelarExtra.Name = "btnCancelarExtra"
        Me.btnCancelarExtra.Size = New System.Drawing.Size(99, 42)
        Me.btnCancelarExtra.TabIndex = 29
        Me.btnCancelarExtra.Text = "Cancelar"
        Me.btnCancelarExtra.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 25)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Buscar"
        '
        'btnRestaurarExtra
        '
        Me.btnRestaurarExtra.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurarExtra.Location = New System.Drawing.Point(548, 464)
        Me.btnRestaurarExtra.Name = "btnRestaurarExtra"
        Me.btnRestaurarExtra.Size = New System.Drawing.Size(99, 42)
        Me.btnRestaurarExtra.TabIndex = 28
        Me.btnRestaurarExtra.Text = "Restaurar"
        Me.btnRestaurarExtra.UseVisualStyleBackColor = True
        '
        'Line6
        '
        Me.Line6.BackColor = System.Drawing.Color.Transparent
        Me.Line6.Location = New System.Drawing.Point(24, 70)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(708, 10)
        Me.Line6.TabIndex = 37
        Me.Line6.Text = "Line6"
        '
        'btnEliminarExtra
        '
        Me.btnEliminarExtra.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarExtra.Location = New System.Drawing.Point(432, 464)
        Me.btnEliminarExtra.Name = "btnEliminarExtra"
        Me.btnEliminarExtra.Size = New System.Drawing.Size(99, 42)
        Me.btnEliminarExtra.TabIndex = 27
        Me.btnEliminarExtra.Text = "Eliminar"
        Me.btnEliminarExtra.UseVisualStyleBackColor = True
        Me.btnEliminarExtra.Visible = False
        '
        'dgvExtras
        '
        Me.dgvExtras.AllowUserToAddRows = False
        Me.dgvExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExtras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExtras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idExtra, Me.nombreExtra, Me.descripcionExtra, Me.precio, Me.cantidad, Me.activoExtra})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExtras.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvExtras.Location = New System.Drawing.Point(25, 124)
        Me.dgvExtras.Name = "dgvExtras"
        Me.dgvExtras.ReadOnly = True
        Me.dgvExtras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExtras.Size = New System.Drawing.Size(738, 320)
        Me.dgvExtras.TabIndex = 18
        '
        'idExtra
        '
        Me.idExtra.DataPropertyName = "idExtra"
        Me.idExtra.HeaderText = "ID Extra"
        Me.idExtra.Name = "idExtra"
        Me.idExtra.ReadOnly = True
        Me.idExtra.Visible = False
        '
        'nombreExtra
        '
        Me.nombreExtra.DataPropertyName = "nombre"
        Me.nombreExtra.HeaderText = "Nombre"
        Me.nombreExtra.Name = "nombreExtra"
        Me.nombreExtra.ReadOnly = True
        '
        'descripcionExtra
        '
        Me.descripcionExtra.DataPropertyName = "descripcion"
        Me.descripcionExtra.HeaderText = "Descripcion"
        Me.descripcionExtra.Name = "descripcionExtra"
        Me.descripcionExtra.ReadOnly = True
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'activoExtra
        '
        Me.activoExtra.DataPropertyName = "activo"
        Me.activoExtra.HeaderText = "Activo"
        Me.activoExtra.Name = "activoExtra"
        Me.activoExtra.ReadOnly = True
        Me.activoExtra.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Extras dados de baja"
        '
        'pnlExtras
        '
        Me.pnlExtras.AttachedControl = Me.SuperTabControlPanel3
        Me.pnlExtras.GlobalItem = False
        Me.pnlExtras.Name = "pnlExtras"
        Me.pnlExtras.Text = "Extras"
        '
        'frmBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 543)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.MaximumSize = New System.Drawing.Size(805, 582)
        Me.MinimumSize = New System.Drawing.Size(805, 582)
        Me.Name = "frmBajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:Bajas:."
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.pnlTurnos.ResumeLayout(False)
        Me.pnlTurnos.PerformLayout()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel2.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.SuperTabControlPanel3.PerformLayout()
        CType(Me.dgvExtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents pnlTurnos As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Label1 As Label
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents pnlExtras As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents pnlClientes As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelarTurno As Button
    Friend WithEvents btnRestaurarTurno As Button
    Friend WithEvents btnEliminarTurno As Button
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
    Friend WithEvents dgvClientes As DataGridView
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
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelarCliente As Button
    Friend WithEvents btnRestaurarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnCancelarExtra As Button
    Friend WithEvents btnRestaurarExtra As Button
    Friend WithEvents btnEliminarExtra As Button
    Friend WithEvents dgvExtras As DataGridView
    Friend WithEvents idExtra As DataGridViewTextBoxColumn
    Friend WithEvents nombreExtra As DataGridViewTextBoxColumn
    Friend WithEvents descripcionExtra As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents activoExtra As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Line5 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents txtBuscarTurno As TextBox
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents rbApellidoTurno As RadioButton
    Friend WithEvents rbNombreTurno As RadioButton
    Friend WithEvents rbApellidoCliente As RadioButton
    Friend WithEvents rbNombreCliente As RadioButton
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Line4 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents txtBuscarExtra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Line6 As DevComponents.DotNetBar.Controls.Line
End Class
