
Public Class frmAgregarCliente
    Public e_Persona As New Entidades.ePersona
    Public e_Localidad As New Entidades.eLocalidad
    Private _agregarEditar As Boolean
    Public Property agregarEditar As Boolean
        Set(value As Boolean)
            _agregarEditar = value
        End Set
        Get
            Return _agregarEditar
        End Get
    End Property
    Dim dtCliente As New DataTable
    Dim vistaCliente As New frmVistaClientes
    Private Sub frmAgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim e_Provincia As New Entidades.eProvincia
        Dim dtProvincias As New DataTable
        'Hago la consulta a la base de datos para poder llenar el textbox
        e_Provincia.RecuperarProvincias(dtProvincias)
        If _agregarEditar Then
            'Cargo las propiedades del cliente con la consulta de base de datos
            e_Persona.traerDatosDB(dtCliente)
            'Le asigno las propiedades cargadas a los controles
            txtNombre.Text = e_Persona.Nombre
            txtApellido.Text = e_Persona.Apellido
            txtDocumento.Text = e_Persona.Documento
            txtDireccion.Text = e_Persona.Direccion
            txtTelefono.Text = e_Persona.Telefono
            Dim localidadCliente As New DataTable
            'Carga los txtbox de localidad y cod postal con una consulta
            e_Localidad.RecuperarDatosCliente(localidadCliente)
            txtLocalidad.Text = e_Localidad.localidad
            txtCodPost.Text = e_Localidad.codPostal
            'Cargo el combobox y asigno la provincia correcta del cliente
            With cbProvincia
                .DataSource = dtProvincias
                .DisplayMember = "provincia"
                .ValueMember = "idprovincia"
                .SelectedIndex = e_Localidad.idProvincia - 1
            End With
        Else
            'Cargo el combobox
            With cbProvincia
                .DataSource = dtProvincias
                .DisplayMember = "provincia"
                .ValueMember = "idprovincia"
                .SelectedIndex = 11
            End With
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If _agregarEditar = False Then
            'Verifico que no haya ningun control vacio
            If comprobarDatos() = True Then
                'Guardo los datos modificados del cliente en sus respectivas propiedades
                e_Persona.Nombre = txtNombre.Text
                e_Persona.Apellido = txtApellido.Text
                e_Persona.Documento = txtDocumento.Text
                e_Persona.idLocalidad = txtLocalidad.Tag
                e_Persona.Direccion = txtDireccion.Text
                e_Persona.Telefono = txtTelefono.Text
                'Ejecuto el comando para guardar
                e_Persona.GuardarCliente(dtCliente)
                MsgBox("¡Cliente guardado con éxito!", MsgBoxStyle.Information, "Agregar Cliente")
                Me.DialogResult = DialogResult.OK
            End If
        ElseIf comprobarDatos() = True Then
            'Guardo los datos nuevos del cliente en sus propiedades
            e_Persona.Nombre = txtNombre.Text
            e_Persona.Apellido = txtApellido.Text
            e_Persona.Documento = txtDocumento.Text
            e_Persona.Direccion = txtDireccion.Text
            e_Persona.Telefono = txtTelefono.Text
            'Ejecuto el comando para insertar los datos por primera vez
            e_Persona.modificarCliente(dtCliente)
            MsgBox("¡Cliente modificado con éxito!", MsgBoxStyle.Information, "Agregar Cliente")
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    Public Function comprobarDatos()
        Dim _control As Control
        For Each _control In Me.Controls
            If TypeOf _control Is TextBox Then
                If _control.Text = "" Then
                    MsgBox("Faltan completar datos", MsgBoxStyle.Exclamation, "Agregar cliente")
                    Return False

                End If
            End If
            If txtDireccion.Text = "" Then
                MsgBox("Faltan completar datos", MsgBoxStyle.Exclamation, "Agregar cliente")
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub btnLocalidades_Click(sender As Object, e As EventArgs) Handles btnLocalidades.Click
        Dim localidades As New frmVistaLocalidades
        With localidades
            'Asigno el id provincia del formulario 'localidades' para poder cargar las 
            'localidades de la respectiva provincia seleccionada en el combobox
            .idProv = cbProvincia.SelectedIndex + 1
            .titulo = cbProvincia.Text
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Cuando cierro el formulario pongo el nombre de la localidad y el numero de 
                'codigo postal en los textbox
                txtLocalidad.Text = localidades.e_localidad.localidad
                txtLocalidad.Tag = localidades.e_localidad.idLocalidad
                txtCodPost.Text = localidades.e_localidad.codPostal
            End If
        End With
        txtDocumento.Focus()
    End Sub
    Public Sub limpiarTextBox()
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
            If TypeOf txt Is RichTextBox Then
                txt.Text = ""
            End If
        Next
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Está seguro de que desea salir del formulario?", MsgBoxStyle.YesNo, "Clientes") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub cbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectionChangeCommitted
        'Si cambio de provincia me vacía los textbox de localidad y codigo postal
        txtLocalidad.Text = ""
        txtCodPost.Text = ""
    End Sub
#Region "KEYPRESS"
    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
End Class