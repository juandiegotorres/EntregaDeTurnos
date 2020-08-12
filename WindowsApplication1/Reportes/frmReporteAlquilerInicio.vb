Imports System.Windows.Forms.DataVisualization.Charting

Imports System.Globalization

Public Class frmReporteAlquilerInicio
    Dim e_turno As New Entidades.eTurnos
    Private Sub frmReporteAlquilerInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tablaAlquiler As New DataTable
        e_turno.reportarAlquiler(tablaAlquiler)

        If tablaAlquiler.Rows.Count = 0 Then
            MsgBox("No se encuentran registros de ningun turno, pruebe agregando uno", MsgBoxStyle.Information, "Reporte turnos")
        Else
            graficoAlquiler.DataSource = tablaAlquiler
            graficoAlquiler.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
            graficoAlquiler.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
        End If
        'Chart1_Customize()
        'Dim cantidad As Integer = tablaExtras.Rows.Count() - 1
        'lblMasUtilizado.Text = "El extra mas utilizado es: " & tablaExtras.Rows(0).Item("nombre").ToString()
        'lblCantidadUsos1.Text = "Con " & tablaExtras.Rows(0).Item("cantidad").ToString() & " usos"
        'lblMenosUtilizado.Text = "El extra menos utilizado es: " & tablaExtras.Rows(cantidad).Item("nombre").ToString()
        'lblCantidadUsos2.Text = "Con " & tablaExtras.Rows(cantidad).Item("cantidad").ToString() & " usos"
        'graficoExtras.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        'graficoExtras.ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = False
    End Sub
    'Protected void Chart1_Customize(Object sender, EventArgs e)
    '    {
    '        foreach (var lbl in Chart1.ChartAreas[0].AxisX.CustomLabels)
    '        {
    '            int monthNumber = Int.Parse(lbl.Text);
    '            If (monthNumber >= 1 && monthNumber <= 12)
    '                lbl.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);
    '            Else
    '                lbl.Text = "";
    '        }
    '    }

    'Private Sub Chart1_Customize()
    '    For Each label In graficoAlquiler.ChartAreas(0).AxisX
    '        Dim numeroMes As Integer
    '        numeroMes = Int16.Parse(label.Text)
    '        If numeroMes >= 1 And numeroMes <= 12 Then
    '            label.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numeroMes)
    '        Else
    '            label.Text = ""
    '        End If
    '    Next
    'End Sub
End Class