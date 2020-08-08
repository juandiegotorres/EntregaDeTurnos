<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteExtras
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
        Me.graficoExtras = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMasUtilizado = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.lblCantidadUsos1 = New System.Windows.Forms.Label()
        Me.lblCantidadUsos2 = New System.Windows.Forms.Label()
        Me.lblMenosUtilizado = New System.Windows.Forms.Label()
        CType(Me.graficoExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'graficoExtras
        '
        Me.graficoExtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.graficoExtras.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.graficoExtras.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.graficoExtras.Legends.Add(Legend1)
        Me.graficoExtras.Location = New System.Drawing.Point(323, 50)
        Me.graficoExtras.Name = "graficoExtras"
        Me.graficoExtras.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Series1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.IsXValueIndexed = True
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelBorderColor = System.Drawing.Color.Transparent
        Series1.LabelBorderWidth = 0
        Series1.Legend = "Legend1"
        Series1.Name = "Extras"
        Series1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Series1.XValueMember = "nombre"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series1.YValueMembers = "cantidad"
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.graficoExtras.Series.Add(Series1)
        Me.graficoExtras.Size = New System.Drawing.Size(512, 383)
        Me.graficoExtras.TabIndex = 0
        Me.graficoExtras.Text = "Uso de extras"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Extras"
        '
        'lblMasUtilizado
        '
        Me.lblMasUtilizado.AutoSize = True
        Me.lblMasUtilizado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasUtilizado.Location = New System.Drawing.Point(14, 52)
        Me.lblMasUtilizado.Name = "lblMasUtilizado"
        Me.lblMasUtilizado.Size = New System.Drawing.Size(179, 16)
        Me.lblMasUtilizado.TabIndex = 16
        Me.lblMasUtilizado.Text = "El extra mas utilizado es: "
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Transparent
        Me.Line1.Location = New System.Drawing.Point(291, 39)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(14, 423)
        Me.Line1.TabIndex = 17
        Me.Line1.Text = "Line1"
        Me.Line1.VerticalLine = True
        '
        'lblCantidadUsos1
        '
        Me.lblCantidadUsos1.AutoSize = True
        Me.lblCantidadUsos1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadUsos1.Location = New System.Drawing.Point(14, 78)
        Me.lblCantidadUsos1.Name = "lblCantidadUsos1"
        Me.lblCantidadUsos1.Size = New System.Drawing.Size(38, 16)
        Me.lblCantidadUsos1.TabIndex = 19
        Me.lblCantidadUsos1.Text = "Con "
        '
        'lblCantidadUsos2
        '
        Me.lblCantidadUsos2.AutoSize = True
        Me.lblCantidadUsos2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadUsos2.Location = New System.Drawing.Point(14, 156)
        Me.lblCantidadUsos2.Name = "lblCantidadUsos2"
        Me.lblCantidadUsos2.Size = New System.Drawing.Size(38, 16)
        Me.lblCantidadUsos2.TabIndex = 21
        Me.lblCantidadUsos2.Text = "Con "
        '
        'lblMenosUtilizado
        '
        Me.lblMenosUtilizado.AutoSize = True
        Me.lblMenosUtilizado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenosUtilizado.Location = New System.Drawing.Point(14, 130)
        Me.lblMenosUtilizado.Name = "lblMenosUtilizado"
        Me.lblMenosUtilizado.Size = New System.Drawing.Size(179, 16)
        Me.lblMenosUtilizado.TabIndex = 20
        Me.lblMenosUtilizado.Text = "El extra mas utilizado es: "
        '
        'frmReporteExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 468)
        Me.Controls.Add(Me.lblCantidadUsos2)
        Me.Controls.Add(Me.lblMenosUtilizado)
        Me.Controls.Add(Me.lblCantidadUsos1)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.lblMasUtilizado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.graficoExtras)
        Me.Name = "frmReporteExtras"
        Me.Text = "frmReporteExtras"
        CType(Me.graficoExtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents graficoExtras As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMasUtilizado As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents lblCantidadUsos1 As Label
    Friend WithEvents lblCantidadUsos2 As Label
    Friend WithEvents lblMenosUtilizado As Label
End Class
