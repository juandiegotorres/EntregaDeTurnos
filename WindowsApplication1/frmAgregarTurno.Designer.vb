<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarTurno
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
        Me.dtiFechaTurno = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtiHoraTurno = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExistente = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clbExtras = New System.Windows.Forms.CheckedListBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.cbSinExtras = New System.Windows.Forms.CheckBox()
        CType(Me.dtiFechaTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiHoraTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtiFechaTurno
        '
        '
        '
        '
        Me.dtiFechaTurno.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFechaTurno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaTurno.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiFechaTurno.ButtonDropDown.Visible = True
        Me.dtiFechaTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiFechaTurno.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.dtiFechaTurno.IsPopupCalendarOpen = False
        Me.dtiFechaTurno.Location = New System.Drawing.Point(106, 89)
        Me.dtiFechaTurno.MinDate = New Date(2018, 11, 8, 14, 56, 23, 0)
        '
        '
        '
        Me.dtiFechaTurno.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiFechaTurno.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaTurno.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiFechaTurno.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiFechaTurno.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFechaTurno.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaTurno.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFechaTurno.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFechaTurno.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFechaTurno.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFechaTurno.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaTurno.MonthCalendar.DisplayMonth = New Date(2018, 10, 1, 0, 0, 0, 0)
        Me.dtiFechaTurno.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiFechaTurno.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiFechaTurno.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFechaTurno.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaTurno.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFechaTurno.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaTurno.MonthCalendar.TodayButtonVisible = True
        Me.dtiFechaTurno.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiFechaTurno.Name = "dtiFechaTurno"
        Me.dtiFechaTurno.Size = New System.Drawing.Size(131, 22)
        Me.dtiFechaTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFechaTurno.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ENTREGA DE TURNOS"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(-1, 29)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(440, 12)
        Me.Line1.TabIndex = 3
        Me.Line1.Text = "Line1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora"
        '
        'dtiHoraTurno
        '
        '
        '
        '
        Me.dtiHoraTurno.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiHoraTurno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHoraTurno.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiHoraTurno.ButtonDropDown.Visible = True
        Me.dtiHoraTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiHoraTurno.Format = DevComponents.Editors.eDateTimePickerFormat.ShortTime
        Me.dtiHoraTurno.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.dtiHoraTurno.IsPopupCalendarOpen = False
        Me.dtiHoraTurno.Location = New System.Drawing.Point(106, 129)
        '
        '
        '
        Me.dtiHoraTurno.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiHoraTurno.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHoraTurno.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiHoraTurno.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiHoraTurno.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiHoraTurno.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiHoraTurno.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiHoraTurno.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiHoraTurno.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiHoraTurno.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiHoraTurno.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHoraTurno.MonthCalendar.DisplayMonth = New Date(2018, 10, 1, 0, 0, 0, 0)
        Me.dtiHoraTurno.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiHoraTurno.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiHoraTurno.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiHoraTurno.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiHoraTurno.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiHoraTurno.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHoraTurno.MonthCalendar.TodayButtonVisible = True
        Me.dtiHoraTurno.MonthCalendar.Visible = False
        Me.dtiHoraTurno.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiHoraTurno.Name = "dtiHoraTurno"
        Me.dtiHoraTurno.Size = New System.Drawing.Size(131, 22)
        Me.dtiHoraTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiHoraTurno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cliente"
        '
        'btnExistente
        '
        Me.btnExistente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExistente.Location = New System.Drawing.Point(309, 49)
        Me.btnExistente.Name = "btnExistente"
        Me.btnExistente.Size = New System.Drawing.Size(33, 24)
        Me.btnExistente.TabIndex = 8
        Me.btnExistente.Text = "..."
        Me.btnExistente.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Extras"
        '
        'clbExtras
        '
        Me.clbExtras.CheckOnClick = True
        Me.clbExtras.Enabled = False
        Me.clbExtras.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbExtras.FormattingEnabled = True
        Me.clbExtras.Location = New System.Drawing.Point(106, 168)
        Me.clbExtras.Name = "clbExtras"
        Me.clbExtras.Size = New System.Drawing.Size(197, 148)
        Me.clbExtras.TabIndex = 11
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
        Me.btnGuardar.Location = New System.Drawing.Point(235, 406)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 26)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        Me.btnCancelar.Location = New System.Drawing.Point(333, 406)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 26)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(106, 334)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(319, 53)
        Me.txtDescripcion.TabIndex = 15
        Me.txtDescripcion.Text = ""
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(106, 51)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(197, 20)
        Me.txtCliente.TabIndex = 16
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCliente.Location = New System.Drawing.Point(350, 49)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(75, 24)
        Me.btnNuevoCliente.TabIndex = 17
        Me.btnNuevoCliente.Text = "Nuevo"
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'cbSinExtras
        '
        Me.cbSinExtras.AutoSize = True
        Me.cbSinExtras.Checked = True
        Me.cbSinExtras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSinExtras.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSinExtras.Location = New System.Drawing.Point(332, 168)
        Me.cbSinExtras.Name = "cbSinExtras"
        Me.cbSinExtras.Size = New System.Drawing.Size(93, 20)
        Me.cbSinExtras.TabIndex = 18
        Me.cbSinExtras.Text = "Sin extras"
        Me.cbSinExtras.UseVisualStyleBackColor = True
        '
        'frmAgregarTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 461)
        Me.Controls.Add(Me.cbSinExtras)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.clbExtras)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExistente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtiHoraTurno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtiFechaTurno)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(465, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(465, 500)
        Me.Name = "frmAgregarTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarTurno"
        CType(Me.dtiFechaTurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiHoraTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtiFechaTurno As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label3 As Label
    Friend WithEvents dtiHoraTurno As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExistente As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents clbExtras As CheckedListBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents cbSinExtras As CheckBox
End Class
