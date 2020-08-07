Public Class ePersona
    '<summary>
    'Declaracion de Propiedades
    ' </summary>
    'Public Enum TipoDocumento As Byte
    '    DNI = 0
    '    Cedula_Identidad = 1
    '    Cedula_Extangeria = 2
    '    Pasaporte = 3
    '    Libreta_Enrolamiento = 4
    '    Libreta_Civica = 5
    'End Enum
#Region "Zona de declaración de propiedades"
    Dim cdDatos As New CapaDeDatos.cdDatosPrueba
    Private _idCliente As UInteger
    Public Property idCliente As UInteger
        Get
            Return _idCliente
        End Get
        Set(value As UInteger)
            _idCliente = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre As String
        Set(value As String)
            _Nombre = value
        End Set
        Get
            Return _Nombre
        End Get
    End Property

    Private _Apellido As String
    Public Property Apellido As String
        Set(value As String)
            _Apellido = value
        End Set
        Get
            Return _Apellido
        End Get
    End Property
    Private _idLocalidad As UInteger
    Public Property idLocalidad() As UInteger
        Get
            Return _idLocalidad
        End Get
        Set(ByVal value As UInteger)
            _idLocalidad = value
        End Set
    End Property

    Private _CodPost As String
    Public Property CodPost() As String
        Get
            Return _CodPost
        End Get
        Set(ByVal value As String)
            _CodPost = value
        End Set
    End Property

    'Private _TipoDoc As TipoDocumento
    'Public Property TipoDoc() As TipoDocumento
    '    Get
    '        Return _TipoDoc
    '    End Get
    '    Set(ByVal value As TipoDocumento)
    '        _TipoDoc = value
    '    End Set
    'End Property

    Private _Documento As String
    Public Property Documento As String
        Set(value As String)
            _Documento = value
        End Set
        Get
            Return _Documento
        End Get
    End Property

    Private _FechaNacimiento As Date
    Public Property FechaNacimiento As Date
        Set(value As Date)
            _FechaNacimiento = value
        End Set
        Get
            Return _FechaNacimiento
        End Get
    End Property
    Private _Direccion As String
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property
    Private _Telefono As String
    Public Property Telefono As String
        Set(value As String)
            _Telefono = value
        End Set
        Get
            Return _Telefono
        End Get
    End Property
    Dim capaDatos As New CapaDeDatos.cdDatos
    Public Sub GuardarCliente(ByRef tabla As DataTable)
        Dim comandoSQL As String = "INSERT INTO db_salon.cliente (nombre,apellido,documento,localidad,direccion,telefono,activo) VALUES ('" & _Nombre & "','" & _Apellido & "','" & _Documento & "','" & _idLocalidad & "','" & _Direccion & "','" & _Telefono & "','1')"
        capaDatos.CargarDatos(tabla, comandoSQL)
    End Sub
    Public Sub traerDatosDB(ByRef tabla As DataTable)
        Dim comandoSQL As String = "SELECT * FROM db_salon.cliente WHERE idCliente = '" & _idCliente & "'"
        capaDatos.CargarDatos(tabla, comandoSQL)
        If tabla.Rows.Count = 1 Then
            Nombre = tabla.Rows(0).Item("nombre").ToString
            Apellido = tabla.Rows(0).Item("apellido").ToString
            Documento = tabla.Rows(0).Item("documento").ToString
            idLocalidad = tabla.Rows(0).Item("localidad")
            Direccion = tabla.Rows(0).Item("direccion").ToString
            Telefono = tabla.Rows(0).Item("telefono").ToString
        End If
    End Sub
    Public Sub RecuperarDatos(ByRef tabla As DataTable)
        Dim capaDatos As New CapaDeDatos.cdDatos
        Dim comandoSQL As String = "SELECT * FROM db_salon.vista_clientes WHERE activo = 1"
        'db_salon.cliente INNER JOIN localidades ON idlocalidad = localidad WHERE activo = 1"
        capaDatos.CargarDatos(tabla, comandoSQL)
    End Sub
    Public Sub darDeBaja(ByRef tabla As DataTable)
        Dim capaDatos As New CapaDeDatos.cdDatos
        Dim comandoSQL As String = "UPDATE db_salon.cliente SET activo = '0' WHERE idCliente = '" & _idCliente & "'"
        capaDatos.CargarDatos(tabla, comandoSQL)
    End Sub
    Public Sub modificarCliente(ByRef tabla As DataTable)
        Try
            Dim comandoSQL As String = "UPDATE db_salon.cliente SET nombre = '" & _Nombre & "', apellido = '" & _Apellido & "', documento = '" & _Documento & "', localidad = '" & _idLocalidad & "', direccion = '" & _Direccion & "', telefono = '" & _Telefono & "' WHERE idCliente = '" & _idCliente & "'"
            capaDatos.CargarDatos(tabla, comandoSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Public Sub buscarCliente(ByRef tabla As DataTable)
    '    Try
    '        Dim comandoSQL As String = "Select * From db_salon.vista_clientes where documento = '" & _Documento & "'"
    '        capaDatos.CargarDatos(tabla, comandoSQL)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Sub traerClientesBaja(ByRef tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM vista_baja_clientes"
        cdDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub restaurarCliente()
        Dim consultaSQL As String = "UPDATE cliente SET activo = '1' WHERE idCliente = '" & _idCliente & "'"
        cdDatos.cargarDatos(consultaSQL)
    End Sub
    Public Sub eliminarCliente()
        Try
            Dim consultaSQL As String = "DELETE FROM turnos WHERE cliente = '" & _idCliente & "'"
            cdDatos.cargarDatos(consultaSQL)
            consultaSQL = "DELETE FROM cliente WHERE idCliente = " & _idCliente
            cdDatos.cargarDatos(consultaSQL)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
    Public Function NombreCompleto() As String
        Dim NombCompleto As String = Nothing
        If Not _Apellido = "" And Not _Nombre = "" Then
            NombCompleto = _Apellido & ", " & _Nombre
        Else
            MsgBox("Error no esxite el nombre o el apllido", MsgBoxStyle.Critical, "Error Clase Persona")
        End If
        Return NombCompleto
    End Function

End Class