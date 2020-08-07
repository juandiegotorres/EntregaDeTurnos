<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaTurnos
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
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscarApellido = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnBuscarFecha = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(0, 40)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(595, 10)
        Me.Line1.TabIndex = 16
        Me.Line1.Text = "Line1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Book", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 30)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "TURNOS"
        '
        'btnBuscarApellido
        '
        Me.btnBuscarApellido.Location = New System.Drawing.Point(162, 55)
        Me.btnBuscarApellido.Name = "btnBuscarApellido"
        Me.btnBuscarApellido.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarApellido.TabIndex = 23
        Me.btnBuscarApellido.Text = "Buscar"
        Me.btnBuscarApellido.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 22
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(61, 257)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(95, 29)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(430, 257)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 29)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(307, 257)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 29)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(184, 257)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 29)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(570, 157)
        Me.DataGridView1.TabIndex = 17
        '
        'DateTimeInput1
        '
        '
        '
        '
        Me.DateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput1.ButtonDropDown.Visible = True
        Me.DateTimeInput1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.DateTimeInput1.IsPopupCalendarOpen = False
        Me.DateTimeInput1.Location = New System.Drawing.Point(347, 56)
        '
        '
        '
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.DisplayMonth = New Date(2018, 10, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput1.Name = "DateTimeInput1"
        Me.DateTimeInput1.Size = New System.Drawing.Size(154, 20)
        Me.DateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput1.TabIndex = 24
        '
        'btnBuscarFecha
        '
        Me.btnBuscarFecha.Location = New System.Drawing.Point(507, 55)
        Me.btnBuscarFecha.Name = "btnBuscarFecha"
        Me.btnBuscarFecha.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarFecha.TabIndex = 25
        Me.btnBuscarFecha.Text = "Buscar"
        Me.btnBuscarFecha.UseVisualStyleBackColor = True
        '
        'frmVistaTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(594, 292)
        Me.Controls.Add(Me.btnBuscarFecha)
        Me.Controls.Add(Me.DateTimeInput1)
        Me.Controls.Add(Me.btnBuscarApellido)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmVistaTurnos"
        Me.Text = "frmVistaTurnos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBuscarApellido As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnBuscarFecha As Button
End Class
