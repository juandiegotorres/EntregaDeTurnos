<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExtras = New System.Windows.Forms.Button()
        Me.btnAlquiler = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Location = New System.Drawing.Point(185, 70)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(873, 507)
        Me.pnlContenedor.TabIndex = 0
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Transparent
        Me.Line3.Location = New System.Drawing.Point(12, 33)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(1078, 10)
        Me.Line3.TabIndex = 13
        Me.Line3.Text = "Line3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Reportes"
        '
        'btnExtras
        '
        Me.btnExtras.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtras.Location = New System.Drawing.Point(17, 155)
        Me.btnExtras.Name = "btnExtras"
        Me.btnExtras.Size = New System.Drawing.Size(152, 63)
        Me.btnExtras.TabIndex = 14
        Me.btnExtras.Text = "Extras que mas se usan"
        Me.btnExtras.UseVisualStyleBackColor = True
        '
        'btnAlquiler
        '
        Me.btnAlquiler.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlquiler.Location = New System.Drawing.Point(17, 240)
        Me.btnAlquiler.Name = "btnAlquiler"
        Me.btnAlquiler.Size = New System.Drawing.Size(152, 63)
        Me.btnAlquiler.TabIndex = 15
        Me.btnAlquiler.Text = "Reporte de alquiler"
        Me.btnAlquiler.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Location = New System.Drawing.Point(17, 70)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(152, 63)
        Me.btnClientes.TabIndex = 16
        Me.btnClientes.Text = "Clientes mas usuales"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 629)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnAlquiler)
        Me.Controls.Add(Me.btnExtras)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmReportes"
        Me.Text = "frmReportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExtras As Button
    Friend WithEvents btnAlquiler As Button
    Friend WithEvents btnClientes As Button
End Class
