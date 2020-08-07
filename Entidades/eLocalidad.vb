
Public Class eLocalidad
    Private _idLocalidad As UInteger
    Public Property idLocalidad As UInteger
        Set(value As UInteger)
            _idLocalidad = value
        End Set
        Get
            Return _idLocalidad
        End Get
    End Property
    Private _idProvincia As Byte
    Public Overridable Property idProvincia As Byte
        Set(value As Byte)
            _idProvincia = value
        End Set
        Get
            Return _idProvincia
        End Get
    End Property
    Private Property _localidad As String
    Public Property localidad As String
        Set(value As String)
            _localidad = value
        End Set
        Get
            Return _localidad
        End Get
    End Property
    Private _codPostal As String
    Public Property codPostal As String
        Set(value As String)
            _codPostal = value
        End Set
        Get
            Return _codPostal
        End Get
    End Property
    Public Sub RecuperarDatos(ByRef tabla As DataTable)
        Dim cdLocalidades As New CapaDeDatos.cdDatos
        Dim comandoSQL As String = "SELECT idLocalidad,nombreLocalidad,codPostal FROM db_salon.localidades WHERE idProvincia =" & _idProvincia & " ORDER BY nombreLocalidad ASC"
        cdLocalidades.CargarDatos(tabla, comandoSQL)
    End Sub
    Public Sub NuevaLocalidad(ByRef tablaNueva As DataTable)
        Try
            Dim nuevaLocalidad As New CapaDeDatos.cdDatos
            Dim comandoInsertSQL As String
            '= "INSERT INTO db_consultorio.localidades " & "(localidad," & "codPostal) VALUES " & "(" & _localidad & "," & _codPostal & ")"
            comandoInsertSQL = "INSERT INTO db_salon.localidades (idProvincia,nombreLocalidad,codPostal) VALUES ('" & _idProvincia & "'" & "," & "'" & _localidad & "'" & "," & "'" & _codPostal & "'" & ")"
            nuevaLocalidad.CargarDatos(tablaNueva, comandoInsertSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Editar(ByRef tabla As DataTable)
        Try
            Dim editarLocalidad As New CapaDeDatos.cdDatos
            Dim comandoEditSQL As String = "UPDATE db_salon.localidades SET nombreLocalidad=" & "'" & _localidad & "'" & ", codPostal=" & "'" & _codPostal & "'  WHERE idlocalidad='" & _idLocalidad & "'"
            editarLocalidad.CargarDatos(tabla, comandoEditSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RecuperarDatosCliente(ByRef tabla As DataTable)
        Dim cdLocalidades As New CapaDeDatos.cdDatos
        Dim comandoSQL As String = "SELECT * FROM db_salon.localidades WHERE idLocalidad = '" & _idLocalidad & "'"
        cdLocalidades.CargarDatos(tabla, comandoSQL)
        _idProvincia = tabla.Rows(0).Item("idProvincia")
        _codPostal = tabla.Rows(0).Item("codPostal")
        _localidad = tabla.Rows(0).Item("nombreLocalidad").ToString
        _idLocalidad = tabla.Rows(0).Item("idLocalidad")
    End Sub
End Class
