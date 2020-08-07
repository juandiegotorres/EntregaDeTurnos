Public Class frmNuevaLocalidad
    Public e_localidad As New Entidades.eLocalidad
    Private _idLoc As Byte
    Public Property idLoc As Byte
        Set(value As Byte)
            _idLoc = value
        End Set
        Get
            Return _idLoc
        End Get
    End Property
    Private _idProv As Byte
    Public Property idProv As Byte
        Set(value As Byte)
            _idProv = value
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
    'Creo esta propiedad porque utilizo el mismo formulario para distintas cosas, si esta en TRUE ejecuta acciones para EDITAR LOCALIDAD y si esta en False para CREAR LOCALIDAD    
    Private _agregarEditarLocalidad As Boolean
    Public Property agregarEditarLocalidad As Boolean
        Set(value As Boolean)
            _agregarEditarLocalidad = value
        End Set
        Get
            Return _agregarEditarLocalidad
        End Get
    End Property
    Private Sub frmNuevaLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim e_localidad As New Entidades.eLocalidad
        If agregarEditarLocalidad = True Then
            lblLocalidadProvincia.Text = "Editar localidad de: " + _titulo
        Else
            lblLocalidadProvincia.Text += " " + _titulo
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If agregarEditarLocalidad = True Then
                Dim editarLocalidad As New DataTable
                'En este caso hace acciones para EDITAR la localidad
                'Cree _idLoc para poder almacenar temporalmente el idLocalidad y luego enviarlo a eLocalidad
                e_localidad.idLocalidad = _idLoc
                e_localidad.localidad = txtNombreLocalidad.Text
                e_localidad.codPostal = txtCodPostal.Text
                e_localidad.Editar(editarLocalidad)
                MsgBox("Localidad editada exitosamente", MsgBoxStyle.Information, "Nueva Localidad")
                Me.DialogResult = DialogResult.OK
            Else
                Dim nuevaLocalidad As New DataTable
                If txtCodPostal.Text = "" And txtNombreLocalidad.Text = "" Then
                    MsgBox("Debe introducir datos", MsgBoxStyle.Information, "Nueva Localidad")
                Else
                    e_localidad.idProvincia = _idProv
                    e_localidad.localidad = txtNombreLocalidad.Text
                    e_localidad.codPostal = txtCodPostal.Text
                    e_localidad.NuevaLocalidad(nuevaLocalidad)
                    MsgBox("Localidad Guardada", MsgBoxStyle.Information, "Nueva Localidad")
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtCodPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodPostal.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub


End Class