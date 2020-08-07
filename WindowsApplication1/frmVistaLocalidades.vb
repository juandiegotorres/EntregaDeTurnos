Imports Entidades.eLocalidad
Public Class frmVistaLocalidades
    Public e_localidad As New Entidades.eLocalidad
    Dim bsLocalidades As New BindingSource
    Private _idProv As Byte
    Public Property idProv As Byte
        Set(Value As Byte)
            _idProv = Value
        End Set
        Get
            Return _idProv
        End Get
    End Property
    Private _titulo As String
    Public Property titulo As String
        Set(value As String)
            _titulo = value
        End Set
        Get
            Return _titulo
        End Get
    End Property
    Public Sub ActualizarDatos()
        Dim dtLocalidades As New DataTable
        e_localidad.idProvincia = _idProv
        e_localidad.RecuperarDatos(dtLocalidades)
        bsLocalidades.DataSource = dtLocalidades
        dgvLocalidades.DataSource = bsLocalidades
    End Sub
    Dim cliente As New frmAgregarCliente
    Private Sub seleccionarPrimero()
        cliente.txtLocalidad.Tag = dgvLocalidades.CurrentRow.Cells(0).Value
        e_localidad.idLocalidad = dgvLocalidades.CurrentRow.Cells(0).Value
        e_localidad.localidad = dgvLocalidades.CurrentRow.Cells(1).Value.ToString
        e_localidad.codPostal = dgvLocalidades.CurrentRow.Cells(2).Value.ToString
    End Sub
    Private Sub frmVistaLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += " " + _titulo
        ActualizarDatos()
        If dgvLocalidades.Rows.Count > 0 Then
            seleccionarPrimero()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Not e_localidad.idLocalidad = 0 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("No hay nada seleccionado", MsgBoxStyle.Information, "frmLocalidades")
        End If
    End Sub

    Private Sub dgvLocalidades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocalidades.CellClick
        If dgvLocalidades.SelectedRows.Count > 0 Then
            Try
                cliente.txtLocalidad.Tag = dgvLocalidades.CurrentRow.Cells(0).Value
                e_localidad.idLocalidad = dgvLocalidades.CurrentRow.Cells(0).Value
                e_localidad.localidad = dgvLocalidades.CurrentRow.Cells(1).Value.ToString
                e_localidad.codPostal = dgvLocalidades.CurrentRow.Cells(2).Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        If txtBusqueda.Text = "" Then
            MsgBox("El cuadro de búsqueda está vacio", MsgBoxStyle.Exclamation, "Localidades")
            txtBusqueda.Focus()
        Else
            For Each Row As DataGridViewRow In dgvLocalidades.Rows
                ':::Nos permite recorrer las celdas del DGTabla
                For Each Cell As DataGridViewCell In Row.Cells
                    ':::Validamos el registro del DGTabla contra el criterio de busqueda
                    If Cell.Value.ToString = txtBusqueda.Text Then
                        ':::Nos ubicamos en la celda que contiene el registro encontrado
                        dgvLocalidades.CurrentCell = Cell
                        Exit Sub
                    End If
                Next
            Next
            MsgBox("No se encontraron resultados", MsgBoxStyle.Critical, "Localidades")
        End If
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim editarLocalidad As New frmNuevaLocalidad
        If e_localidad.idLocalidad = 0 Then
            MsgBox("Debe hacer click sobre una localidad", MsgBoxStyle.Exclamation, "Editar localidad")
        Else
            With editarLocalidad
                .agregarEditarLocalidad = True
                .idLoc = dgvLocalidades.CurrentRow.Cells(0).Value
                .txtNombreLocalidad.Text = dgvLocalidades.CurrentRow.Cells(1).Value.ToString
                .txtCodPostal.Text = e_localidad.codPostal
                .ShowDialog()
                If DialogResult.OK Then
                    ActualizarDatos()
                End If
            End With
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevaLocalidad As New frmNuevaLocalidad
        With nuevaLocalidad
            .idProv = _idProv
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                ActualizarDatos()
                If dgvLocalidades.Rows.Count > 0 Then
                    seleccionarPrimero()
                End If
            End If
        End With
    End Sub

    Private Sub frmVistaLocalidades_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        ActualizarDatos()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        bsLocalidades.Filter = "nombreLocalidad like '%" & txtBusqueda.Text & "%'"
    End Sub
End Class
