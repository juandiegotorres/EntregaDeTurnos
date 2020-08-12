<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteAlquilerInicio
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.graficoAlquiler = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.graficoAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'graficoAlquiler
        '
        Me.graficoAlquiler.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.graficoAlquiler.BorderlineColor = System.Drawing.Color.Transparent
        Me.graficoAlquiler.BorderlineWidth = 0
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.DimGray
        Me.graficoAlquiler.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Name = "Legend1"
        Me.graficoAlquiler.Legends.Add(Legend1)
        Me.graficoAlquiler.Location = New System.Drawing.Point(12, 70)
        Me.graficoAlquiler.Name = "graficoAlquiler"
        Series1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series1.BackSecondaryColor = System.Drawing.Color.Transparent
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.HotPink
        Series1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "Alquiler"
        Series1.XValueMember = "nombreMes"
        Series1.YValueMembers = "Cantidad"
        Me.graficoAlquiler.Series.Add(Series1)
        Me.graficoAlquiler.Size = New System.Drawing.Size(811, 341)
        Me.graficoAlquiler.TabIndex = 0
        Me.graficoAlquiler.Text = "Chart1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(525, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Reporte de alquiler de los últimos 12 meses"
        '
        'frmReporteAlquilerInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.graficoAlquiler)
        Me.Name = "frmReporteAlquilerInicio"
        Me.Text = "frmReporteAlquilerInicio"
        CType(Me.graficoAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents graficoAlquiler As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
End Class
