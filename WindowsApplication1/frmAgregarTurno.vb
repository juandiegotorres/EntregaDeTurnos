Public Class frmAgregarTurno
    Dim e_turno As New Entidades.eTurnos
    Dim e_extra As New Entidades.eExtras
    Dim _idTurno As UInt16
    Dim _idCliente As UInt16
    Dim frmIdExtras As New List(Of UInt16)
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub New(ByRef idTurno, ByRef idCliente)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent()
        _idTurno = idTurno
        _idCliente = idCliente
    End Sub
    Private _editar As Boolean
    Public Property editar As Boolean
        Get
            Return _editar
        End Get
        Set(value As Boolean)
            _editar = value
        End Set
    End Property

    Private Sub frmAgregarTurno_Load(sender As Object, e As EventArgs) Handles Me.Load

        'El "editar" lo pongo el verdadero cuando abro el formulario para modificar 
        'los datos del turno

        If editar Then

            'Le asigno a la propiedad idTurno y idCliente de la clase eTurno el id que le pasé
            'al formulario al abrirlo
            e_turno.idTurno = _idTurno
                e_turno.idCliente = _idCliente
                'LLamo a "cargarModificar" que me trae los datos del turno de la base de datos
                'y me los guarda en la clase eTurno, luego resta llenar los text box y datetimepicker
                e_turno.cargarModificar()
                txtCliente.Text = e_turno.NombreCompleto
                dtiFechaTurno.Text = e_turno.fecha
                dtiHoraTurno.Text = e_turno.hora
                txtDescripcion.Text = e_turno.descripcion
                Dim tablaExtras As New DataTable
                'Proceso para llenar el checked list box con los extras de la base de datos
                e_extra.cargarCLB(tablaExtras)
                With clbExtras
                    .DataSource = tablaExtras
                    .ValueMember = "idextra"
                    .DisplayMember = "nombre"
                End With
                'Este metodo llena un listbox con los id de los extras seleccionados junto con  
                'el id del turno elegido
                e_turno.cargarExtras()
                cbSinExtras.Checked = False
            'Recorro los items del checked list box y voy seleccionando los extras de 
            'la lista que llene anteriormente
            'Dim extraSeleccionado As UInteger
            'For i = 0 To e_turno.idExtras.Count - 1
            '        extraSeleccionado = e_turno.idExtras(i)
            '        clbExtras.SetItemChecked(extraSeleccionado - 1, True)
            '    Next
            'frmIdExtras.Clear()
            remarcarExtras()
            'Dim a As String = clbExtras.Items(i).ToString
            'Dim s As String = a
            'clbExtras.FindString("Pelotero")

        Else
            'Si abro el formulario para agregar pongo los datetimepicker en la fecha y hora de hoy
            dtiFechaTurno.Text = Today
            dtiHoraTurno.Text = Now
            Dim tablaExtras As New DataTable
            e_extra.cargarCLB(tablaExtras)
            'cargo el checked list box
            With clbExtras
                .DataSource = tablaExtras
                .ValueMember = "idextra"
                .DisplayMember = "nombre"
            End With
            frmIdExtras.Clear()

        End If
    End Sub
    Private Function remarcarExtras()
        Try
            Dim tablaModificarExtras As New DataTable
            e_turno.modificarExtraCliente(tablaModificarExtras)
            If tablaModificarExtras.Rows.Count > 0 Then
                If tablaModificarExtras.Rows(0).ItemArray(0) = 0 Then
                    cbSinExtras.Checked = True
                Else
                    For i = 0 To clbExtras.Items.Count - 1
                        For a = 0 To tablaModificarExtras.Rows.Count - 1
                            Dim index As Integer = clbExtras.FindString(tablaModificarExtras.Rows(a).Item("nombre").ToString)
                            clbExtras.SetItemChecked(index, True)
                        Next
                    Next
                    Return True
                End If
            End If
        Catch ex As Exception
            If MsgBox("Hubo un problema al recuperar los extras, por favor verifique que ningun extra haya sido dado de baja", MsgBoxStyle.OkOnly, "Turnos") = MsgBoxResult.Ok Then
                Me.Close()
            End If
            Return False
        End Try
    End Function
    Private Sub btnExistente_Click(sender As Object, e As EventArgs) Handles btnExistente.Click
        Dim vistaCliente As New frmVistaClientes
        With vistaCliente
            .ShowDialog()
            If DialogResult.OK Then
                'Si elijo un cliente existente me va a llenar el textbox con el nombre correspondiente
                txtCliente.Text = vistaCliente.e_Persona.Nombre + " " + vistaCliente.e_Persona.Apellido
                'Y me va a guardar el ID del cliente
                e_turno.idCliente = vistaCliente.e_Persona.idCliente
                _idCliente = vistaCliente.e_Persona.idCliente
            End If
        End With
    End Sub
    'Private Sub clbExtras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbExtras.SelectedIndexChanged
    '    'Proceso para seleccionar los extras que estan seleccionados en el checked list box
    '    Dim item As Object = clbExtras.SelectedValue
    '    If (TypeOf item Is Integer) Then
    '        Try
    '            'Añade el extra a la lista
    '            frmIdExtras.Add(item)
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub
    Public Function comprobardatos()
        Dim _control As Control
        For Each _control In Me.Controls
            If TypeOf _control Is TextBox Then
                If _control.Text = "" Then
                    MsgBox("faltan completar datos", MsgBoxStyle.Exclamation, "agregar cliente")
                    Return False

                End If
            End If
            If txtCliente.Text = "" Then
                MsgBox("faltan completar datos", MsgBoxStyle.Exclamation, "agregar cliente")
                Return False
            End If
        Next
        Return True
    End Function
    Private Function btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Verifico si ha elegido algun cliente
        If txtCliente.Text = "" Or txtCliente.Text = " " Then
            MsgBox("Debe agregar un cliente", MsgBoxStyle.Exclamation, "Agregar cliente")
            Return False
        Else

            'Antes de asignar todas las variable consulto si el dia esta ocupado
            e_turno.fechaConsulta = dtiFechaTurno.Text
            If e_turno.ConsultarDia() = False And editar = False Then
                MsgBox("Día ocupado, por favor escoja otro", MsgBoxStyle.Exclamation, "Turnos")
                Return False
            End If
            If clbExtras.CheckedItems.Count = 0 Then
                MsgBox("Seleccione la opción sin extras", MsgBoxStyle.Exclamation, "Turnos")
                Return False
            End If
            'Si el dia no esta ocupado y si el cliente esta seleccionado
            'guardo los datos correspondientes en las propiedades de la clase eTurno
            e_turno.idCliente = _idCliente
            e_turno.fecha = dtiFechaTurno.Text
            e_turno.fechaConsulta = dtiFechaTurno.Text
            e_turno.hora = dtiHoraTurno.Text
            e_turno.descripcion = txtDescripcion.Text
            frmIdExtras.Clear()
            If cbSinExtras.Checked = True Then
                frmIdExtras.Add(0)
                e_turno.idExtras = frmIdExtras
            Else
                For i = 0 To clbExtras.CheckedIndices.Count - 1
                    If i < clbExtras.CheckedIndices.Count Then
                        Dim a As Integer = clbExtras.CheckedIndices(i)
                        frmIdExtras.Add(a + 1)
                    End If
                Next
                e_turno.idExtras = frmIdExtras
            End If
            Try
                If _editar Then
                    'Le asigno el id del Turno para poder hacer el UPDATE con la condicion WHERE
                    e_turno.idTurno = _idTurno
                    'Llamo al metodo para modificar el turno
                    If e_turno.modificarTurno Then
                        MsgBox("¡Turno modificado con éxito!", MsgBoxStyle.Information, "Turnos")
                    End If
                    Me.DialogResult = DialogResult.OK
                Else
                    'LLamo al metodo para agregar un turno nuevo
                    If e_turno.nuevoTurno() Then
                        MsgBox("¡Turno agregado con éxito!", MsgBoxStyle.Information, "Turnos")
                    End If
                    Me.DialogResult = DialogResult.OK
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return True
        End If

    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim nuevoCLiente As New frmAgregarCliente
        With nuevoCLiente
            .ShowDialog()
            If DialogResult.OK Then
                'Si agrego un nuevo cliente, cuando cierra el formulario, me carga el nombre del 
                'nuevo cliente en el textbox
                txtCliente.Text = nuevoCLiente.e_Persona.NombreCompleto
                e_turno.traerUltimoCliente()
                'Y luego asigo el id del cliente para poder introducirlo junto con los datos del turno
                _idCliente = e_turno.idCliente
            End If
        End With
    End Sub

    Private Sub cbSinExtras_CheckedChanged(sender As Object, e As EventArgs) Handles cbSinExtras.CheckedChanged
        If cbSinExtras.Checked = True Then
            clbExtras.Enabled = False
            For i = 0 To clbExtras.Items.Count - 1
                clbExtras.SetItemChecked(i, False)
            Next
        Else
            clbExtras.Enabled = True
        End If
    End Sub
End Class