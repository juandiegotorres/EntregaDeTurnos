Public Class frmAgregarExtra
    Dim e_Extra As New Entidades.eExtras
    Dim _idExtra As UInt16
    Private _editar As Boolean
    Public Property editar As Boolean
        Set(value As Boolean)
            _editar = value
        End Set
        Get
            Return _editar
        End Get
    End Property
    'Public Sub New(ByRef idExtra)

    '    ' Esta llamada es exigida por el diseñador.
    '    InitializeComponent()
    '    _idExtra = idExtra
    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    'End Sub
    Public Sub New(ByRef cantidadExtras)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _idExtra = cantidadExtras
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmAgregarExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _editar Then
            'Le asigno a la propiedad de la clase el valor del extra que pasé por parametro
            e_Extra.idExtra = _idExtra
            'Hago la consulta para que cargue las propiedades con todos los datos de la base de datos
            e_Extra.cargarModificar()
            'Si el formulario esta para modificar cargo todas las propiedades en los controles
            txtNombre.Text = e_Extra.nombre
            txtCantidad.Text = e_Extra.cantidad
            txtPrecio.Text = e_Extra.precio
            txtDescripcion.Text = e_Extra.descripcion
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Comprobar datos veerifica que no haya ningun control vacio
        If comprobarDatos() = True Then
            e_Extra.idExtra = _idExtra
            e_Extra.nombre = txtNombre.Text
            e_Extra.descripcion = txtDescripcion.Text
            e_Extra.cantidad = txtCantidad.Text
            e_Extra.precio = txtPrecio.Text
            If editar Then
                e_Extra.modificarExtra()
                MsgBox("¡Extra modificado con éxito!", MsgBoxStyle.Information, "Editar Extra")
            Else
                e_Extra.nuevoExtra()
                MsgBox("¡Extra guardado con éxito!", MsgBoxStyle.Information, "Agregar Extra")
            End If
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
        Next
        Return True
    End Function
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Está seguro de que desea salir del formulario?", MsgBoxStyle.YesNo, "Extras") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub txtPrecio_GotFocus(sender As Object, e As EventArgs) Handles txtPrecio.GotFocus
        'Mensaje de ayuda a la hora de introducir el precio cada vez que el textbox obtiene el foco
        ttAyuda.SetToolTip(txtPrecio, "Introduzca los centavos con una coma. Ej: '22,50'")
        ttAyuda.ToolTipTitle = "Precio"
        ttAyuda.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        'Mensaje de ayuda a la hora de introducir el precio cada vez que paso el mouse sobre el txtbox
        ttAyuda.SetToolTip(txtPrecio, "Introduzca los centavos con una coma. Ej: '22,50'")
        ttAyuda.ToolTipTitle = "Precio"
        ttAyuda.ToolTipIcon = ToolTipIcon.Info
    End Sub
#Region "KEYPRESS"
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.ToString = "," And InStr(Me.Text, ",") = 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
End Class