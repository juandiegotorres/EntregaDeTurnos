<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaLocalidad
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblLocalidadProvincia = New System.Windows.Forms.Label()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreLocalidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(334, 135)
        Me.btnCancelar.MaximumSize = New System.Drawing.Size(87, 23)
        Me.btnCancelar.MinimumSize = New System.Drawing.Size(87, 23)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 23)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(241, 135)
        Me.btnGuardar.MaximumSize = New System.Drawing.Size(87, 23)
        Me.btnGuardar.MinimumSize = New System.Drawing.Size(87, 23)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblLocalidadProvincia
        '
        Me.lblLocalidadProvincia.AutoSize = True
        Me.lblLocalidadProvincia.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidadProvincia.Location = New System.Drawing.Point(12, 19)
        Me.lblLocalidadProvincia.Name = "lblLocalidadProvincia"
        Me.lblLocalidadProvincia.Size = New System.Drawing.Size(183, 18)
        Me.lblLocalidadProvincia.TabIndex = 11
        Me.lblLocalidadProvincia.Text = "Nueva localidad de: "
        '
        'txtCodPostal
        '
        Me.txtCodPostal.Location = New System.Drawing.Point(121, 97)
        Me.txtCodPostal.MaxLength = 4
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(82, 21)
        Me.txtCodPostal.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Código Postal:"
        '
        'txtNombreLocalidad
        '
        Me.txtNombreLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreLocalidad.Location = New System.Drawing.Point(94, 60)
        Me.txtNombreLocalidad.Name = "txtNombreLocalidad"
        Me.txtNombreLocalidad.Size = New System.Drawing.Size(293, 21)
        Me.txtNombreLocalidad.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre:"
        '
        'frmNuevaLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 170)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblLocalidadProvincia)
        Me.Controls.Add(Me.txtCodPostal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreLocalidad)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximumSize = New System.Drawing.Size(450, 209)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 209)
        Me.Name = "frmNuevaLocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:Nueva Localidad:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblLocalidadProvincia As Label
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreLocalidad As TextBox
    Friend WithEvents Label1 As Label
End Class
