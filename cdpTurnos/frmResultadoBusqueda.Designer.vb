<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultadoBusqueda
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
        Me.btnAgregarTurno = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnDiasDisponibles = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Día Disponible/Ocupado"
        '
        'btnAgregarTurno
        '
        Me.btnAgregarTurno.Location = New System.Drawing.Point(27, 155)
        Me.btnAgregarTurno.Name = "btnAgregarTurno"
        Me.btnAgregarTurno.Size = New System.Drawing.Size(85, 23)
        Me.btnAgregarTurno.TabIndex = 1
        Me.btnAgregarTurno.Text = "Agregar Turno"
        Me.btnAgregarTurno.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(262, 155)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnDiasDisponibles
        '
        Me.btnDiasDisponibles.Location = New System.Drawing.Point(138, 155)
        Me.btnDiasDisponibles.Name = "btnDiasDisponibles"
        Me.btnDiasDisponibles.Size = New System.Drawing.Size(98, 23)
        Me.btnDiasDisponibles.TabIndex = 3
        Me.btnDiasDisponibles.Text = "Dias Disponibles"
        Me.btnDiasDisponibles.UseVisualStyleBackColor = True
        '
        'frmResultadoBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 190)
        Me.Controls.Add(Me.btnDiasDisponibles)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregarTurno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmResultadoBusqueda"
        Me.Text = "frmResultadoBusqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarTurno As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnDiasDisponibles As Button
End Class
