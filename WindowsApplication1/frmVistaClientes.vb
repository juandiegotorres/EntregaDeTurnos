Public Class frmVistaClientes
    Public e_Persona As New Entidades.ePersona
    Dim bsClientes As New BindingSource
    Dim filtroBS As String
    Public Sub actualizarClientes()
        Dim dtClientes As New DataTable
        e_Persona.RecuperarDatos(dtClientes)
        bsClientes.DataSource = dtClientes
        dgvClientes.DataSource = bsClientes
        dgvClientes.ClearSelection()
    End Sub
    Private Sub frmVistaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarClientes()
        rbNombreCliente.Checked = True
    End Sub
    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        If dgvClientes.SelectedRows.Count > 0 Then
            Try
                e_Persona.idCliente = dgvClientes.CurrentRow.Cells("idCliente").Value
                e_Persona.Nombre = dgvClientes.CurrentRow.Cells("nombre").Value.ToString
                e_Persona.Apellido = dgvClientes.CurrentRow.Cells("apellido").Value.ToString
                'e_Persona.Documento = dgvClientes.CurrentRow.Cells("documento").Value.ToString
                'e_Persona.Direccion = dgvClientes.CurrentRow.Cells("direccion").Value.ToString
                'e_Persona.Telefono = dgvClientes.CurrentRow.Cells("telefono").Value.ToString
                'modificarCliente.e_Localidad.idLocalidad = dgvClientes.CurrentRow.Cells("idLocalidad").Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If rbDocumentoCliente.Checked = True Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If rbNombreCliente.Checked = True Then
            filtroBS = "nombre like '%" & txtBusqueda.Text & "%'"
            bsClientes.Filter = filtroBS
            dgvClientes.ClearSelection()
        End If
        If rbApellidoCliente.Checked = True Then
            filtroBS = "apellido like '%" & txtBusqueda.Text & "%'"
            bsClientes.Filter = filtroBS
            dgvClientes.ClearSelection()
        End If
        If rbDocumentoCliente.Checked = True Then
            filtroBS = "documento like '%" & txtBusqueda.Text & "%'"
            bsClientes.Filter = filtroBS
            dgvClientes.ClearSelection()
        End If
    End Sub

    Private Sub frmVistaClientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class