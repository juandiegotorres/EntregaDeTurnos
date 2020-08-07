Public Class frmBajas
    Dim eTurnos As New Entidades.eTurnos
    Dim eCliente As New Entidades.ePersona
    Dim eExtra As New Entidades.eExtras
    Private Sub frmBajas_Load(sender As Object, e As EventArgs) Handles Me.Load
        actualizarTurnosBaja()
        actualizarBajaClientes()
        actualizarExtrasBaja()
        rbApellidoTurno.Checked = True
        rbApellidoCliente.Checked = True

    End Sub
    Dim filtroBs As String


#Region "TURNOS"
    Private Sub SuperTabControlPanel1_Click(sender As Object, e As EventArgs) Handles pnlTurnos.Click
    End Sub
    Dim bsTurnos As New BindingSource
    Public Sub actualizarTurnosBaja()
        Dim tabla As New DataTable
        eTurnos.traerTurnosBaja(tabla)
        bsTurnos.DataSource = tabla
        dgvTurnos.DataSource = bsTurnos
        dgvTurnos.ClearSelection()
    End Sub

    Private Sub txtBuscarTurno_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarTurno.TextChanged
        If rbNombreTurno.Checked = True Then
            filtroBs = "nombre like '%" & txtBuscarTurno.Text & "%'"
            bsTurnos.Filter = filtroBs
            dgvTurnos.ClearSelection()
        End If
        If rbApellidoTurno.Checked = True Then
            filtroBs = "apellido like '%" & txtBuscarTurno.Text & "%'"
            bsTurnos.Filter = filtroBs
            dgvTurnos.ClearSelection()
        End If
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurarTurno.Click
        If MsgBox("¿Desea restaurar este turno?", MsgBoxStyle.YesNo, "Bajas") = MsgBoxResult.Yes Then
            If dgvTurnos.CurrentRow.Selected = False Or eTurnos.idTurno = 0 Then
                MsgBox("No hay ningun turno seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Bajas")
            Else
                eTurnos.restaurarTurno()
                actualizarTurnosBaja()
            End If
        End If

    End Sub

    Private Sub dgvTurnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTurnos.CellClick
        If dgvTurnos.SelectedRows.Count > 0 Then
            Try
                eTurnos.idTurno = dgvTurnos.CurrentRow.Cells("idTurno").Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnEliminarTurno_Click(sender As Object, e As EventArgs) Handles btnEliminarTurno.Click
        If MsgBox("¿Está seguro que desea eliminar el turno? Esta acción es irreversible", MsgBoxStyle.YesNo, "Bajas") = MsgBoxResult.Yes Then

            If dgvTurnos.CurrentRow.Selected = False Or eTurnos.idTurno = 0 Then
                MsgBox("No hay ningun turno seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Bajas")
            Else
                eTurnos.eliminarTurno()
                actualizarTurnosBaja()
            End If
        End If

    End Sub

    Private Sub frmBajas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancelarTurno_Click(sender As Object, e As EventArgs) Handles btnCancelarTurno.Click
        Me.DialogResult = DialogResult.OK
    End Sub
#End Region

#Region "CLIENTES"
    Dim bsClientes As New BindingSource
    Public Sub actualizarBajaClientes()
        Dim tabla As New DataTable
        eCliente.traerClientesBaja(tabla)
        bsClientes.DataSource = tabla
        dgvClientes.DataSource = bsClientes
        dgvClientes.ClearSelection()

    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        If dgvClientes.SelectedRows.Count > 0 Then
            Try
                eCliente.idCliente = dgvClientes.CurrentRow.Cells("idCliente").Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        If MsgBox("¿Está seguro que desea eliminar el cliente? Esta acción es irreversible", MsgBoxStyle.YesNo, "Bajas") = MsgBoxResult.Yes Then

            If dgvClientes.CurrentRow.Selected = False Or eCliente.idCliente = 0 Then
                MsgBox("No hay ningun cliente seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Bajas")
            Else
                eCliente.eliminarCliente()
                actualizarBajaClientes()
            End If
        End If
    End Sub

    Private Sub BtnRestaurarCliente_Click(sender As Object, e As EventArgs) Handles btnRestaurarCliente.Click
        If MsgBox("¿Desea restaurar este cliente?", MsgBoxStyle.YesNo, "Bajas") = MsgBoxResult.Yes Then
            If dgvClientes.CurrentRow.Selected = False Or eCliente.idCliente = 0 Then
                MsgBox("No hay ningun cliente seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Bajas")
            Else

                eCliente.restaurarCliente()
                actualizarBajaClientes()
            End If
        End If
    End Sub

    Private Sub BtnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        If rbNombreCliente.Checked = True Then
            filtroBs = "nombre like '%" & txtBuscarCliente.Text & "%'"
            bsClientes.Filter = filtroBs
            dgvClientes.ClearSelection()
        End If
        If rbApellidoCliente.Checked = True Then
            filtroBs = "apellido like '%" & txtBuscarCliente.Text & "%'"
            bsClientes.Filter = filtroBs
            dgvClientes.ClearSelection()
        End If
    End Sub


#End Region

#Region "EXTRAS"

    Private Sub BtnEliminarExtra_Click(sender As Object, e As EventArgs) Handles btnEliminarExtra.Click
        If MsgBox("¿Está seguro que desea eliminar este extra? Esta acción es irreversible", MsgBoxStyle.YesNo, "Bajas") = MsgBoxResult.Yes Then

            If dgvExtras.CurrentRow.Selected = False Or eExtra.idExtra = 0 Then
                MsgBox("No hay ningun extra seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Bajas")
            Else
                eExtra.eliminarExtra()
                actualizarExtrasBaja()
            End If
        End If
    End Sub

    Private Sub BtnRestaurarExtra_Click(sender As Object, e As EventArgs) Handles btnRestaurarExtra.Click
        If MsgBox("¿Desea restaurar este extra?", MsgBoxStyle.YesNo, "Bajas") = MsgBoxResult.Yes Then
            If dgvExtras.CurrentRow.Selected = False Or eExtra.idExtra = 0 Then
                MsgBox("No hay ningun extra seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Bajas")
            Else
                eExtra.restaurarExtra()
                actualizarExtrasBaja()
            End If
        End If
    End Sub

    Private Sub BtnCancelarExtra_Click(sender As Object, e As EventArgs) Handles btnCancelarExtra.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Dim bsExtra As New BindingSource
    Public Sub actualizarExtrasBaja()
        Dim tabla As New DataTable
        eExtra.traerExtrasBaja(tabla)
        bsExtra.DataSource = tabla
        dgvExtras.DataSource = bsExtra
        dgvExtras.ClearSelection()
    End Sub

    Private Sub txtBuscarExtra_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarExtra.TextChanged
        filtroBs = "nombre like '%" & txtBuscarExtra.Text & "%'"
        bsExtra.Filter = filtroBs
        dgvExtras.ClearSelection()
    End Sub

    Private Sub dgvExtras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExtras.CellClick
        eExtra.idExtra = dgvExtras.CurrentRow.Cells("idExtra").Value
    End Sub

    Private Sub dgvClientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvClientes.DataBindingComplete
        Dim gridView As DataGridView
        gridView = CType(sender, DataGridView)
        gridView.ClearSelection()
    End Sub

    Private Sub dgvExtras_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvExtras.DataBindingComplete
        Dim gridView As DataGridView
        gridView = CType(sender, DataGridView)
        gridView.ClearSelection()
    End Sub





#End Region

End Class