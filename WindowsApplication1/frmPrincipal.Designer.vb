<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim btnAgregarExtra As System.Windows.Forms.Button
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.lblDisponibilidad = New System.Windows.Forms.Label()
        Me.picOcupado = New System.Windows.Forms.PictureBox()
        Me.picDisponible = New System.Windows.Forms.PictureBox()
        Me.btnBajas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarTurno = New System.Windows.Forms.TextBox()
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
        Me.btnBuscarFecha = New System.Windows.Forms.Button()
        Me.dtiFechaBusqueda = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminarTurno = New System.Windows.Forms.Button()
        Me.btnModificarTurno = New System.Windows.Forms.Button()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevoTurno = New System.Windows.Forms.Button()
        Me.Turnos = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btnBajaExtras = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvExtras = New System.Windows.Forms.DataGridView()
        Me.idExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activoExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscarExtra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Line6 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnEliminarExtra = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnModificarExtra = New System.Windows.Forms.Button()
        Me.Line7 = New DevComponents.DotNetBar.Controls.Line()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btnBajas1 = New System.Windows.Forms.Button()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.rbDocumentoCliente = New System.Windows.Forms.RadioButton()
        Me.rbApellidoCliente = New System.Windows.Forms.RadioButton()
        Me.rbNombreCliente = New System.Windows.Forms.RadioButton()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Line5 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.Line4 = New DevComponents.DotNetBar.Controls.Line()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btnReportes = New System.Windows.Forms.Button()
        btnAgregarExtra = New System.Windows.Forms.Button()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.picOcupado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiFechaBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.dgvExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarExtra
        '
        btnAgregarExtra.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnAgregarExtra.Location = New System.Drawing.Point(871, 136)
        btnAgregarExtra.Name = "btnAgregarExtra"
        btnAgregarExtra.Size = New System.Drawing.Size(119, 43)
        btnAgregarExtra.TabIndex = 19
        btnAgregarExtra.Text = "Agregar "
        btnAgregarExtra.UseVisualStyleBackColor = True
        AddHandler btnAgregarExtra.Click, AddressOf Me.btnAgregarExtra_Click
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuperTabControl1.BackColor = System.Drawing.Color.White
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(1, 1)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(1005, 593)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabHorizontalSpacing = 8
        Me.SuperTabControl1.TabIndex = 1
        Me.SuperTabControl1.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.MultiLineFit
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Turnos, Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007
        Me.SuperTabControl1.Text = "       Extras       "
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.btnReportes)
        Me.SuperTabControlPanel1.Controls.Add(Me.lblDisponibilidad)
        Me.SuperTabControlPanel1.Controls.Add(Me.picOcupado)
        Me.SuperTabControlPanel1.Controls.Add(Me.picDisponible)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnBajas)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label1)
        Me.SuperTabControlPanel1.Controls.Add(Me.txtBuscarTurno)
        Me.SuperTabControlPanel1.Controls.Add(Me.dgvTurnos)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnBuscarFecha)
        Me.SuperTabControlPanel1.Controls.Add(Me.dtiFechaBusqueda)
        Me.SuperTabControlPanel1.Controls.Add(Me.Line3)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label3)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnEliminarTurno)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnModificarTurno)
        Me.SuperTabControlPanel1.Controls.Add(Me.Line2)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label2)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnNuevoTurno)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.MaximumSize = New System.Drawing.Size(1005, 568)
        Me.SuperTabControlPanel1.MinimumSize = New System.Drawing.Size(1005, 568)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.ShowFocusRectangle = True
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1005, 568)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.Turnos
        '
        'lblDisponibilidad
        '
        Me.lblDisponibilidad.AutoSize = True
        Me.lblDisponibilidad.BackColor = System.Drawing.Color.Transparent
        Me.lblDisponibilidad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponibilidad.Location = New System.Drawing.Point(369, 52)
        Me.lblDisponibilidad.Name = "lblDisponibilidad"
        Me.lblDisponibilidad.Size = New System.Drawing.Size(0, 18)
        Me.lblDisponibilidad.TabIndex = 27
        '
        'picOcupado
        '
        Me.picOcupado.BackColor = System.Drawing.Color.Transparent
        Me.picOcupado.Image = Global.WindowsApplication1.My.Resources.Resources._error
        Me.picOcupado.Location = New System.Drawing.Point(334, 46)
        Me.picOcupado.Name = "picOcupado"
        Me.picOcupado.Size = New System.Drawing.Size(29, 29)
        Me.picOcupado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOcupado.TabIndex = 26
        Me.picOcupado.TabStop = False
        Me.picOcupado.Visible = False
        '
        'picDisponible
        '
        Me.picDisponible.BackColor = System.Drawing.Color.Transparent
        Me.picDisponible.Image = Global.WindowsApplication1.My.Resources.Resources.comprobado
        Me.picDisponible.Location = New System.Drawing.Point(334, 46)
        Me.picDisponible.Name = "picDisponible"
        Me.picDisponible.Size = New System.Drawing.Size(29, 29)
        Me.picDisponible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDisponible.TabIndex = 25
        Me.picDisponible.TabStop = False
        Me.picDisponible.Visible = False
        '
        'btnBajas
        '
        Me.btnBajas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajas.Location = New System.Drawing.Point(871, 456)
        Me.btnBajas.Name = "btnBajas"
        Me.btnBajas.Size = New System.Drawing.Size(119, 23)
        Me.btnBajas.TabIndex = 24
        Me.btnBajas.Text = "Bajas"
        Me.btnBajas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Buscar apellido:"
        '
        'txtBuscarTurno
        '
        Me.txtBuscarTurno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarTurno.Location = New System.Drawing.Point(683, 52)
        Me.txtBuscarTurno.Name = "txtBuscarTurno"
        Me.txtBuscarTurno.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarTurno.TabIndex = 20
        '
        'dgvTurnos
        '
        Me.dgvTurnos.AllowUserToAddRows = False
        Me.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTurno, Me.cliente, Me.nombreCliente, Me.apellidoCliente, Me.fecha, Me.hora, Me.descripcion, Me.activoturno, Me.extras})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(212, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTurnos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTurnos.Location = New System.Drawing.Point(16, 136)
        Me.dgvTurnos.Name = "dgvTurnos"
        Me.dgvTurnos.ReadOnly = True
        Me.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTurnos.Size = New System.Drawing.Size(837, 343)
        Me.dgvTurnos.TabIndex = 19
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
        'btnBuscarFecha
        '
        Me.btnBuscarFecha.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarFecha.Location = New System.Drawing.Point(199, 48)
        Me.btnBuscarFecha.Name = "btnBuscarFecha"
        Me.btnBuscarFecha.Size = New System.Drawing.Size(129, 27)
        Me.btnBuscarFecha.TabIndex = 17
        Me.btnBuscarFecha.Text = "Buscar Fecha"
        Me.btnBuscarFecha.UseVisualStyleBackColor = True
        '
        'dtiFechaBusqueda
        '
        '
        '
        '
        Me.dtiFechaBusqueda.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFechaBusqueda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaBusqueda.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiFechaBusqueda.ButtonDropDown.Visible = True
        Me.dtiFechaBusqueda.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiFechaBusqueda.ForeColor = System.Drawing.Color.Black
        Me.dtiFechaBusqueda.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.dtiFechaBusqueda.IsPopupCalendarOpen = False
        Me.dtiFechaBusqueda.Location = New System.Drawing.Point(16, 48)
        Me.dtiFechaBusqueda.MinDate = New Date(2018, 10, 25, 0, 0, 0, 0)
        '
        '
        '
        Me.dtiFechaBusqueda.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiFechaBusqueda.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaBusqueda.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiFechaBusqueda.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiFechaBusqueda.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFechaBusqueda.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaBusqueda.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFechaBusqueda.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFechaBusqueda.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFechaBusqueda.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFechaBusqueda.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaBusqueda.MonthCalendar.DisplayMonth = New Date(2018, 10, 1, 0, 0, 0, 0)
        Me.dtiFechaBusqueda.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiFechaBusqueda.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiFechaBusqueda.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFechaBusqueda.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaBusqueda.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFechaBusqueda.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaBusqueda.MonthCalendar.TodayButtonVisible = True
        Me.dtiFechaBusqueda.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiFechaBusqueda.Name = "dtiFechaBusqueda"
        Me.dtiFechaBusqueda.Size = New System.Drawing.Size(177, 27)
        Me.dtiFechaBusqueda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFechaBusqueda.TabIndex = 16
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Transparent
        Me.Line3.Location = New System.Drawing.Point(16, 32)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(700, 12)
        Me.Line3.TabIndex = 11
        Me.Line3.Text = "Line3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Consulta disponibilidad de turnos"
        '
        'btnEliminarTurno
        '
        Me.btnEliminarTurno.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTurno.Location = New System.Drawing.Point(871, 260)
        Me.btnEliminarTurno.Name = "btnEliminarTurno"
        Me.btnEliminarTurno.Size = New System.Drawing.Size(119, 43)
        Me.btnEliminarTurno.TabIndex = 9
        Me.btnEliminarTurno.Text = "Dar de Baja "
        Me.btnEliminarTurno.UseVisualStyleBackColor = True
        '
        'btnModificarTurno
        '
        Me.btnModificarTurno.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarTurno.Location = New System.Drawing.Point(871, 198)
        Me.btnModificarTurno.Name = "btnModificarTurno"
        Me.btnModificarTurno.Size = New System.Drawing.Size(119, 43)
        Me.btnModificarTurno.TabIndex = 8
        Me.btnModificarTurno.Text = "Modificar"
        Me.btnModificarTurno.UseVisualStyleBackColor = True
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.Transparent
        Me.Line2.Location = New System.Drawing.Point(16, 120)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(700, 12)
        Me.Line2.TabIndex = 7
        Me.Line2.Text = "Line2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alta, baja y modificación de turnos"
        '
        'btnNuevoTurno
        '
        Me.btnNuevoTurno.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoTurno.Location = New System.Drawing.Point(871, 136)
        Me.btnNuevoTurno.Name = "btnNuevoTurno"
        Me.btnNuevoTurno.Size = New System.Drawing.Size(119, 43)
        Me.btnNuevoTurno.TabIndex = 4
        Me.btnNuevoTurno.Text = "Agregar"
        Me.btnNuevoTurno.UseVisualStyleBackColor = True
        '
        'Turnos
        '
        Me.Turnos.AttachedControl = Me.SuperTabControlPanel1
        Me.Turnos.GlobalItem = False
        Me.Turnos.Name = "Turnos"
        Me.Turnos.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Silver
        Me.Turnos.Text = "      Turnos       "
        Me.Turnos.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTabControlPanel3.Controls.Add(Me.btnBajaExtras)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label8)
        Me.SuperTabControlPanel3.Controls.Add(Me.dgvExtras)
        Me.SuperTabControlPanel3.Controls.Add(Me.txtBuscarExtra)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label6)
        Me.SuperTabControlPanel3.Controls.Add(Me.Line6)
        Me.SuperTabControlPanel3.Controls.Add(Me.btnEliminarExtra)
        Me.SuperTabControlPanel3.Controls.Add(Me.Label7)
        Me.SuperTabControlPanel3.Controls.Add(Me.btnModificarExtra)
        Me.SuperTabControlPanel3.Controls.Add(btnAgregarExtra)
        Me.SuperTabControlPanel3.Controls.Add(Me.Line7)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(1005, 593)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem2
        Me.SuperTabControlPanel3.Visible = False
        '
        'btnBajaExtras
        '
        Me.btnBajaExtras.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaExtras.Location = New System.Drawing.Point(871, 455)
        Me.btnBajaExtras.Name = "btnBajaExtras"
        Me.btnBajaExtras.Size = New System.Drawing.Size(119, 23)
        Me.btnBajaExtras.TabIndex = 28
        Me.btnBajaExtras.Text = "Bajas"
        Me.btnBajaExtras.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Nombre:"
        '
        'dgvExtras
        '
        Me.dgvExtras.AllowUserToAddRows = False
        Me.dgvExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExtras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExtras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idExtra, Me.nombreExtra, Me.descripcionExtra, Me.precio, Me.cantidad, Me.activoExtra})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExtras.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvExtras.Location = New System.Drawing.Point(16, 135)
        Me.dgvExtras.Name = "dgvExtras"
        Me.dgvExtras.ReadOnly = True
        Me.dgvExtras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExtras.Size = New System.Drawing.Size(837, 343)
        Me.dgvExtras.TabIndex = 17
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
        'txtBuscarExtra
        '
        Me.txtBuscarExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarExtra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBuscarExtra.Location = New System.Drawing.Point(104, 59)
        Me.txtBuscarExtra.Name = "txtBuscarExtra"
        Me.txtBuscarExtra.Size = New System.Drawing.Size(218, 23)
        Me.txtBuscarExtra.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Buscar Extra"
        '
        'Line6
        '
        Me.Line6.BackColor = System.Drawing.Color.Transparent
        Me.Line6.Location = New System.Drawing.Point(16, 31)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(708, 10)
        Me.Line6.TabIndex = 25
        Me.Line6.Text = "Line6"
        '
        'btnEliminarExtra
        '
        Me.btnEliminarExtra.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarExtra.Location = New System.Drawing.Point(871, 260)
        Me.btnEliminarExtra.Name = "btnEliminarExtra"
        Me.btnEliminarExtra.Size = New System.Drawing.Size(119, 43)
        Me.btnEliminarExtra.TabIndex = 23
        Me.btnEliminarExtra.Text = "Dar de baja"
        Me.btnEliminarExtra.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(418, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Alta, baja y modificación de extras"
        '
        'btnModificarExtra
        '
        Me.btnModificarExtra.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarExtra.Location = New System.Drawing.Point(871, 198)
        Me.btnModificarExtra.Name = "btnModificarExtra"
        Me.btnModificarExtra.Size = New System.Drawing.Size(119, 43)
        Me.btnModificarExtra.TabIndex = 22
        Me.btnModificarExtra.Text = "Modificar"
        Me.btnModificarExtra.UseVisualStyleBackColor = True
        '
        'Line7
        '
        Me.Line7.BackColor = System.Drawing.Color.Transparent
        Me.Line7.Location = New System.Drawing.Point(16, 121)
        Me.Line7.Name = "Line7"
        Me.Line7.Size = New System.Drawing.Size(708, 10)
        Me.Line7.TabIndex = 21
        Me.Line7.Text = "Line7"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Cyan
        Me.SuperTabItem2.Text = "Extras"
        Me.SuperTabItem2.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.btnBajas1)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtBuscarCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.rbDocumentoCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.rbApellidoCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.rbNombreCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.dgvClientes)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label5)
        Me.SuperTabControlPanel2.Controls.Add(Me.Line5)
        Me.SuperTabControlPanel2.Controls.Add(Me.btnEliminarCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.Label4)
        Me.SuperTabControlPanel2.Controls.Add(Me.btnModificarCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.btnAgregarCliente)
        Me.SuperTabControlPanel2.Controls.Add(Me.Line4)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1005, 593)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem1
        Me.SuperTabControlPanel2.Visible = False
        '
        'btnBajas1
        '
        Me.btnBajas1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajas1.Location = New System.Drawing.Point(871, 455)
        Me.btnBajas1.Name = "btnBajas1"
        Me.btnBajas1.Size = New System.Drawing.Size(119, 23)
        Me.btnBajas1.TabIndex = 25
        Me.btnBajas1.Text = "Bajas"
        Me.btnBajas1.UseVisualStyleBackColor = True
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCliente.Location = New System.Drawing.Point(19, 54)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(207, 23)
        Me.txtBuscarCliente.TabIndex = 24
        '
        'rbDocumentoCliente
        '
        Me.rbDocumentoCliente.AutoSize = True
        Me.rbDocumentoCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbDocumentoCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDocumentoCliente.Location = New System.Drawing.Point(405, 56)
        Me.rbDocumentoCliente.Name = "rbDocumentoCliente"
        Me.rbDocumentoCliente.Size = New System.Drawing.Size(100, 20)
        Me.rbDocumentoCliente.TabIndex = 23
        Me.rbDocumentoCliente.TabStop = True
        Me.rbDocumentoCliente.Text = "Documento"
        Me.rbDocumentoCliente.UseVisualStyleBackColor = False
        '
        'rbApellidoCliente
        '
        Me.rbApellidoCliente.AutoSize = True
        Me.rbApellidoCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbApellidoCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbApellidoCliente.Location = New System.Drawing.Point(323, 56)
        Me.rbApellidoCliente.Name = "rbApellidoCliente"
        Me.rbApellidoCliente.Size = New System.Drawing.Size(76, 20)
        Me.rbApellidoCliente.TabIndex = 22
        Me.rbApellidoCliente.TabStop = True
        Me.rbApellidoCliente.Text = "Apellido"
        Me.rbApellidoCliente.UseVisualStyleBackColor = False
        '
        'rbNombreCliente
        '
        Me.rbNombreCliente.AutoSize = True
        Me.rbNombreCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbNombreCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreCliente.Location = New System.Drawing.Point(242, 56)
        Me.rbNombreCliente.Name = "rbNombreCliente"
        Me.rbNombreCliente.Size = New System.Drawing.Size(75, 20)
        Me.rbNombreCliente.TabIndex = 21
        Me.rbNombreCliente.TabStop = True
        Me.rbNombreCliente.Text = "Nombre"
        Me.rbNombreCliente.UseVisualStyleBackColor = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.activo, Me.nombre, Me.apellido, Me.documento, Me.Provincia, Me.nombreLocalidad, Me.localidad, Me.CodPostal, Me.direccion, Me.telefono})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvClientes.Location = New System.Drawing.Point(16, 135)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(837, 343)
        Me.dgvClientes.TabIndex = 20
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Buscar Cliente"
        '
        'Line5
        '
        Me.Line5.BackColor = System.Drawing.Color.Transparent
        Me.Line5.Location = New System.Drawing.Point(16, 31)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(708, 10)
        Me.Line5.TabIndex = 16
        Me.Line5.Text = "Line5"
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.Location = New System.Drawing.Point(871, 260)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(119, 43)
        Me.btnEliminarCliente.TabIndex = 14
        Me.btnEliminarCliente.Text = "Dar de Baja"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(435, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Alta, baja y modificación de clientes"
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.Location = New System.Drawing.Point(871, 198)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(119, 43)
        Me.btnModificarCliente.TabIndex = 13
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(871, 136)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(119, 43)
        Me.btnAgregarCliente.TabIndex = 10
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Transparent
        Me.Line4.Location = New System.Drawing.Point(16, 122)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(708, 10)
        Me.Line4.TabIndex = 12
        Me.Line4.Text = "Line4"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "      Clientes      "
        Me.SuperTabItem1.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(1005, 568)
        Me.SuperTabControlPanel4.TabIndex = 2
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem3
        '
        'btnReportes
        '
        Me.btnReportes.Location = New System.Drawing.Point(666, 508)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(136, 23)
        Me.btnReportes.TabIndex = 29
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 587)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(941, 534)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " .: Entrega de turnos salón Don Carlos :."
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.PerformLayout()
        CType(Me.picOcupado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiFechaBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.SuperTabControlPanel3.PerformLayout()
        CType(Me.dgvExtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel2.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminarTurno As Button
    Friend WithEvents btnModificarTurno As Button
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNuevoTurno As Button
    Friend WithEvents btnBuscarFecha As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents Line4 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label5 As Label
    Friend WithEvents Line5 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents txtBuscarExtra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Line6 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents btnEliminarExtra As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnModificarExtra As Button
    Friend WithEvents Line7 As DevComponents.DotNetBar.Controls.Line
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
    Friend WithEvents dgvExtras As DataGridView
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
    Friend WithEvents idExtra As DataGridViewTextBoxColumn
    Friend WithEvents nombreExtra As DataGridViewTextBoxColumn
    Friend WithEvents descripcionExtra As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents activoExtra As DataGridViewTextBoxColumn
    Friend WithEvents txtBuscarTurno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbDocumentoCliente As RadioButton
    Friend WithEvents rbApellidoCliente As RadioButton
    Friend WithEvents rbNombreCliente As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBuscarCliente As TextBox
    Private WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Private WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents Turnos As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents dtiFechaBusqueda As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnBajas As Button
    Friend WithEvents btnBajas1 As Button
    Friend WithEvents btnBajaExtras As Button
    Friend WithEvents picOcupado As PictureBox
    Friend WithEvents picDisponible As PictureBox
    Friend WithEvents lblDisponibilidad As Label
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents btnReportes As Button
End Class
