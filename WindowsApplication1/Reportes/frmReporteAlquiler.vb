Public Class frmReporteAlquiler
    Dim e_turno As new Entidades.eTurnos
    Dim tablaResultado As New DataTable
    Private Sub frmReporteAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCantidad.Text = ""
    End Sub


    Private Sub cbDia_CheckedChanged(sender As Object, e As EventArgs) Handles cbDia.CheckedChanged
        If cbDia.Checked = True Then
            Label2.Visible = False
            dtpHasta.Visible = False
            Label1.Text = "Día:"
            dtpDesde.Location = New Point(95, 61)
            dtpDesde.Value = Today
            If dgvTurnos.Rows.Count >= 1 Then
                tablaResultado.Clear()
                dgvTurnos.DataSource = tablaResultado
            End If
        Else
            Label2.Visible = True
            dtpHasta.Visible = True
            Label1.Text = "Desde:"
            dtpDesde.Location = New Point(123, 61)
            dtpDesde.Value = Today
            If dgvTurnos.Rows.Count >= 1 Then
                tablaResultado.Clear()
                dgvTurnos.DataSource = tablaResultado
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cbDia.Checked = False Then
            If (DateTime.Compare(dtpDesde.Value, dtpHasta.Value) > 0) Then
                MsgBox("La fecha de incio no puede ser mayor que la del final", MsgBoxStyle.Critical, "Reporte Alquiler")
                dtpDesde.Value = Today
            ElseIf dtpDesde.Value.Date.ToString = dtpHasta.Value.Date.ToString Then
                MsgBox("La fechas no pueden ser iguales", MsgBoxStyle.Critical, "Reporte Alquiler")
            Else
                e_turno.reporteAlquilerPersonalizado(tablaResultado, dtpDesde.Value, dtpHasta.Value)
                dgvTurnos.DataSource = tablaResultado
                dgvTurnos.ClearSelection()
                If tablaResultado.Rows.Count = 0 Then
                    MsgBox("No hay registro de esta fecha", MsgBoxStyle.Information, "Reporte Alquiler")
                End If
                lblCantidad.Text = "El salón se alquiló un total de: " & tablaResultado.Rows.Count & " veces"
            End If
        Else
            e_turno.reporteAlquilerDia(tablaResultado, dtpDesde.Value.Date.ToString)
            dgvTurnos.DataSource = tablaResultado
            dgvTurnos.ClearSelection()
            If tablaResultado.Rows.Count = 0 Then
                MsgBox("No hay registro de esta fecha", MsgBoxStyle.Information, "Reporte Alquiler")
            End If
        End If

    End Sub

    Private Sub dtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtpDesde.ValueChanged
        If dgvTurnos.Rows.Count >= 1 Then
            tablaResultado.Clear()
            dgvTurnos.DataSource = tablaResultado
        End If
    End Sub

    Private Sub dtpHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpHasta.ValueChanged
        If dgvTurnos.Rows.Count >= 1 Then
            tablaResultado.Clear()
            dgvTurnos.DataSource = tablaResultado
        End If
    End Sub
End Class