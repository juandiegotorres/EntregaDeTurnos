<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarTurno
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
        Me.dtiFechaTurno = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtiHoraTurno = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnExistente = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.dtiFechaTurno.Location = New System.Drawing.Point(127, 89)
        '
        '
        '
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
        '
        '
        '
        Me.dtiFechaTurno.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFechaTurno.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaTurno.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFechaTurno.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaTurno.MonthCalendar.TodayButtonVisible = True
        Me.dtiFechaTurno.Name = "dtiFechaTurno"
        Me.dtiFechaTurno.Size = New System.Drawing.Size(131, 22)
        Me.dtiFechaTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFechaTurno.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 24)
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora Turno"
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
        Me.dtiHoraTurno.Location = New System.Drawing.Point(127, 129)
        '
        '
        '
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
        '
        '
        '
        Me.dtiHoraTurno.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiHoraTurno.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiHoraTurno.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiHoraTurno.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHoraTurno.MonthCalendar.TodayButtonVisible = True
        Me.dtiHoraTurno.MonthCalendar.Visible = False
        Me.dtiHoraTurno.Name = "dtiHoraTurno"
        Me.dtiHoraTurno.Size = New System.Drawing.Size(131, 22)
        Me.dtiHoraTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiHoraTurno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cliente"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(330, 49)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(59, 24)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnExistente
        '
        Me.btnExistente.Location = New System.Drawing.Point(395, 49)
        Me.btnExistente.Name = "btnExistente"
        Me.btnExistente.Size = New System.Drawing.Size(59, 24)
        Me.btnExistente.TabIndex = 8
        Me.btnExistente.Text = "Existente"
        Me.btnExistente.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Extras"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Vajilla", "Inflables", "Musica"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(127, 168)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(258, 64)
        Me.CheckedListBox1.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.FlatAppearance.BorderSize = 2
        Me.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGuardar.Location = New System.Drawing.Point(223, 321)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 25)
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
        Me.btnCancelar.Location = New System.Drawing.Point(344, 321)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 25)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Descripción"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(127, 241)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(309, 53)
        Me.RichTextBox1.TabIndex = 15
        Me.RichTextBox1.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 20)
        Me.TextBox1.TabIndex = 16
        '
        'frmAgregarTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(463, 357)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExistente)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtiHoraTurno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtiFechaTurno)
        Me.MaximizeBox = False
        Me.Name = "frmAgregarTurno"
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
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnExistente As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
End Class
