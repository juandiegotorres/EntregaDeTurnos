Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmReporteExtras
    Dim e_extras As New Entidades.eExtras
    Private Sub frmReporteExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tablaExtras As New DataTable
        e_extras.reportarExtras(tablaExtras)
        graficoExtras.DataSource = tablaExtras
        Dim cantidad As Integer = tablaExtras.Rows.Count() - 1
        lblMasUtilizado.Text = "El extra mas utilizado es: " & tablaExtras.Rows(0).Item("nombre").ToString()
        lblCantidadUsos1.Text = "Con " & tablaExtras.Rows(0).Item("cantidad").ToString() & " usos"
        lblMenosUtilizado.Text = "El extra menos utilizado es: " & tablaExtras.Rows(cantidad).Item("nombre").ToString()
        lblCantidadUsos2.Text = "Con " & tablaExtras.Rows(cantidad).Item("cantidad").ToString() & " usos"
        graficoExtras.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        graficoExtras.ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = False
    End Sub

End Class