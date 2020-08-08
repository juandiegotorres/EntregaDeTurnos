Imports System.Drawing.Text
Public Class frmPrincipal
#Region "Declaracion de Propiedades"
    Public e_turno As New Entidades.eTurnos
    Public e_Persona As New Entidades.ePersona
    Dim e_extra As New Entidades.eExtras
    Public _Mensaje As String
    Dim bsTurnos As New BindingSource
    Dim bsClientes As New BindingSource
    Dim bsExtras As New BindingSource
    Dim filtroBS As String
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtiFechaBusqueda.Text = Today
        'Cargo todos los data grid view 
        actualizarClientes()
        actualizarTurnos()
        actualizarExtras()
        'Selecciono los radiobutton manualmente

    End Sub
#Region "CLIENTE"

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim agregarCliente As New frmAgregarCliente
        'Me muestra el formulario para agregar clientes
        agregarCliente.ShowDialog()
        If DialogResult.OK Then
            actualizarClientes()
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        'Si no hay ninguna fila seleccionada muestro un mensaje
        If dgvClientes.CurrentRow.Selected = False Then
            MsgBox("No hay ningun cliente seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Clientes")
        Else
            Dim cliente As New frmAgregarCliente
            With cliente
                'Pongo en verdadero la propiedad agregarEditar ya que abro el formulario para
                'modificar el cliente
                .agregarEditar = True
                'Asigno el ID del Cliente y de la Localidad a la clase ePersona para poder 
                'realizar la consulta
                .e_Persona.idCliente = dgvClientes.CurrentRow.Cells("idCliente").Value
                .e_Localidad.idLocalidad = dgvClientes.CurrentRow.Cells("localidad").Value
                .ShowDialog()
                If DialogResult.OK Then
                    actualizarClientes()
                End If
            End With
        End If
    End Sub
    Public Sub actualizarClientes()
        'Procedimiento para llenar el datagridview con datos de la base de datos
        Dim dtClientes As New DataTable
        e_Persona.RecuperarDatos(dtClientes)
        bsClientes.DataSource = dtClientes
        dgvClientes.DataSource = bsClientes
        dgvClientes.ClearSelection()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        If dgvClientes.CurrentRow.Selected = False Then
            MsgBox("No hay ningun cliente seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Cliente")
        Else
            If MsgBox("¿Desea dar de baja este cliente?", MsgBoxStyle.YesNo, "Clientes") = MsgBoxResult.Yes Then
                Try
                    'Selecciono el id del cliente
                    e_Persona.idCliente = dgvClientes.CurrentRow.Cells("idCliente").Value
                    Dim baja As New DataTable
                    'LLamo al metodo dar de baja para poner el campo 'activo' de la base de 
                    'datos en 0
                    e_Persona.darDeBaja(baja)
                    actualizarClientes()
                    MsgBox("Cliente dado de baja con éxito", MsgBoxStyle.Information, "Clientes")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarCliente.KeyPress
        'Evento para que no deje introducir letras en el text box buscar si el radio button
        'buscar por documento está activado
        If rbDocumentoCliente.Checked = True Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        'Pregunto cual es el radio button que esta chequeado y en cuanto a eso filtro
        'el datagridview
        If rbNombreCliente.Checked = True Then
            filtroBS = "nombre like '%" & txtBuscarCliente.Text & "%'"
            bsClientes.Filter = filtroBS
            dgvClientes.ClearSelection()
        End If
        If rbApellidoCliente.Checked = True Then
            filtroBS = "apellido like '%" & txtBuscarCliente.Text & "%'"
            bsClientes.Filter = filtroBS
            dgvClientes.ClearSelection()
        End If
        If rbDocumentoCliente.Checked = True Then
            filtroBS = "documento like '%" & txtBuscarCliente.Text & "%'"
            bsClientes.Filter = filtroBS
            dgvClientes.ClearSelection()
        End If
    End Sub
    Private Sub SuperTabItem1_Click(sender As Object, e As EventArgs) Handles SuperTabItem1.Click
        'Cada vez que yo clickee la pestaña 'Clientes' el datagridview se va a deseleccionar
        dgvClientes.ClearSelection()
    End Sub
#End Region
#Region "TURNOS"
    Private Sub actualizarTurnos()
        'Proceso para llenar el datagridview con los datos de la base de datos
        Dim dtTurnos As New DataTable
        e_turno.traerTurnos(dtTurnos)
        bsTurnos.DataSource = dtTurnos
        dgvTurnos.DataSource = bsTurnos
        dgvTurnos.ClearSelection()
    End Sub
    Private Sub btnBuscarFecha_Click(sender As Object, e As EventArgs) Handles btnBuscarFecha.Click
        'Le asigno la fecha del datetimepicker a la propiedad fecha
        e_turno.fechaConsulta = dtiFechaBusqueda.Text
        'Pregunto si las fechas son iguales, para corroborar
        If e_turno.fechaConsulta = dtiFechaBusqueda.Text Then
            Dim dtResultadoBusqueda As New DataTable
            'Consulto el dia contra la base de datos
            If e_turno.ConsultarDia() Then
                picDisponible.Visible = True
                lblDisponibilidad.Text = "Disponible"
            Else
                picOcupado.Visible = True
                lblDisponibilidad.Text = "Ocupado"
            End If
        End If
    End Sub

    Private Sub btnNuevoTurno_Click(sender As Object, e As EventArgs) Handles btnNuevoTurno.Click
        Dim nuevoTurno As New frmAgregarTurno
        'Muestro el formulario para agregar turno
        With nuevoTurno
            .ShowDialog()
            If DialogResult.OK Then
                actualizarTurnos()
            End If
        End With
    End Sub

    Private Sub dgvTurnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTurnos.CellClick
        If dgvTurnos.SelectedRows.Count > 0 Then
            Try
                'Cuando hago click en la fila, guardo el ID del turno
                e_turno.idTurno = dgvTurnos.CurrentRow.Cells("idTurno").Value
                e_turno.idCliente = dgvTurnos.CurrentRow.Cells("cliente").Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnModificarTurno_Click(sender As Object, e As EventArgs) Handles btnModificarTurno.Click
        'Verifico que haya una fila seleccionada o el ID del turno sea mayor que 0
        If dgvTurnos.CurrentRow.Selected = False Or e_turno.idTurno = 0 Then
            MsgBox("No hay ningun turno seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Turnos")
        Else
            'Paso el ID del turno y el ID del Cliente por parametros
            Dim editarTurno As New frmAgregarTurno(e_turno.idTurno, e_turno.idCliente)
            With editarTurno
                .editar = True
                .ShowDialog()
                If DialogResult.OK Then
                    actualizarTurnos()
                End If
            End With
        End If
    End Sub

    Private Sub btnEliminarTurno_Click(sender As Object, e As EventArgs) Handles btnEliminarTurno.Click
        'Proceso para dar de baja
        If dgvTurnos.CurrentRow.Selected = False Or e_turno.idTurno = 0 Then
            MsgBox("No hay ningun turno seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Turnos")
        Else
            If MsgBox("¿Desea dar de baja este turno?", MsgBoxStyle.YesNo, "Turnos") = MsgBoxResult.Yes Then
                Try
                    e_turno.darDeBajaTurno()
                    actualizarTurnos()
                    MsgBox("Turno dado de baja con éxito", MsgBoxStyle.Information, "Pedidos")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub txtBuscarTurno_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarTurno.TextChanged
        filtroBS = "apellido like '%" & txtBuscarTurno.Text & "%'"
        bsTurnos.Filter = filtroBS
        dgvTurnos.ClearSelection()
    End Sub

    Private Sub btnBuscarFecha_LostFocus(sender As Object, e As EventArgs) Handles btnBuscarFecha.LostFocus
        picOcupado.Visible = False
        picDisponible.Visible = False
        lblDisponibilidad.Text = ""
    End Sub
#End Region
#Region "EXTRAS"
    Public Sub actualizarExtras()
        'Proceso para traer los extras de la base de datos y llenar el datagridview
        Dim dtExtras As New DataTable
        e_extra.recuperarExtras(dtExtras)
        bsExtras.DataSource = dtExtras
        dgvExtras.DataSource = bsExtras
        dgvExtras.ClearSelection()
    End Sub
    Private Sub btnAgregarExtra_Click(sender As Object, e As EventArgs)
        'Muestro el formulario para agregar un nuevo extra
        e_extra.contarExtras()
        dgvExtras.Tag = e_extra.cantidad
        Dim agregarExtra As New frmAgregarExtra(dgvExtras.Tag)
        agregarExtra.ShowDialog()
        If DialogResult.OK Then
            actualizarExtras()
        End If
    End Sub
    Private Sub dgvExtras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExtras.CellClick
        e_extra.idExtra = dgvExtras.CurrentRow.Cells("idExtra").Value
    End Sub
    Private Sub btnModificarExtra_Click(sender As Object, e As EventArgs) Handles btnModificarExtra.Click
        'consulto si hay alguna fila seleccionada y si hay alguna abro el formulario
        'para modificar
        If dgvExtras.CurrentRow.Selected = False Then
            MsgBox("No hay ningun extra seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Extras")
        Else
            Dim modificarExtra As New frmAgregarExtra(e_extra.idExtra)
            With modificarExtra
                .editar = True
                .ShowDialog()
                If DialogResult.OK Then
                    actualizarExtras()
                End If
            End With
        End If
    End Sub

    Private Sub btnEliminarExtra_Click(sender As Object, e As EventArgs) Handles btnEliminarExtra.Click
        'consulto si hay alguna fila seleccionada y si hay alguna doy de baja al extra
        If dgvExtras.CurrentRow.Selected = False Then
            MsgBox("No hay ningun extra seleccionado, haga click en uno", MsgBoxStyle.Exclamation, "Extras")
        Else
            If MsgBox("¿Desea dar de baja este extra?", MsgBoxStyle.YesNo, "Extras") = MsgBoxResult.Yes Then
                Try
                    e_extra.darDeBajaExtra()
                    actualizarExtras()
                    MsgBox("Extra dado de baja con éxito", MsgBoxStyle.Information, "Extras")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

        Private Sub txtBuscarExtra_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarExtra.TextChanged
        'Aplico el filtro al binding source segun el nombre
        filtroBS = "nombre like '%" & txtBuscarExtra.Text & "%'"
        bsExtras.Filter = filtroBS
        dgvExtras.ClearSelection()
    End Sub
    Private Sub SuperTabItem2_Click(sender As Object, e As EventArgs) Handles SuperTabItem2.Click
        'Cada vez que hago click en la pestaña extras vacia la seleccion del data grid view
        dgvExtras.ClearSelection()
    End Sub

    Private Sub BtnBajas_Click(sender As Object, e As EventArgs) Handles btnBajas.Click
        Me.Hide()
        frmBajas.ShowDialog()
        If DialogResult.OK Then
            actualizarTurnos()
            actualizarClientes()
            actualizarExtras()
            Me.Show()
        End If
    End Sub

    Private Sub btnBajas1_Click(sender As Object, e As EventArgs) Handles btnBajas1.Click
        Me.Hide()
        frmBajas.ShowDialog()
        If DialogResult.OK Then
            actualizarClientes()
            Me.Show()
        End If
    End Sub

    Private Sub BtnBajaExtras_Click(sender As Object, e As EventArgs) Handles btnBajaExtras.Click
        Me.Hide()
        frmBajas.ShowDialog()
        If DialogResult.OK Then
            actualizarExtras()
            Me.Show()
        End If
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        frmReportes.Show()
    End Sub




#End Region
End Class

