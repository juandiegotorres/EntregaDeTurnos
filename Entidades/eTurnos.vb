Imports MySql.Data.MySqlClient

Public Class eTurnos
    Dim cdDatos As New CapaDeDatos.cdDatosPrueba
    Private _idTurno As UInteger
    Public Property idTurno As Integer
        Get
            Return _idTurno
        End Get
        Set(value As Integer)
            _idTurno = value
        End Set
    End Property
    Private _idCliente As UInt16
    Public Property idCliente As UInt16
        Get
            Return _idCliente
        End Get
        Set(value As UInt16)
            _idCliente = value
        End Set
    End Property
    Private _nombreCliente As String
    Public Property nombreCliente As String
        Set(value As String)
            _nombreCliente = value
        End Set
        Get
            Return _nombreCliente
        End Get
    End Property
    Private _apellidoCliente As String
    Public Property apellidoCliente As String
        Set(value As String)
            _apellidoCliente = value
        End Set
        Get
            Return _apellidoCliente
        End Get
    End Property
    Private _idExtras As List(Of UInt16)
    Public Property idExtras As List(Of UInt16)
        Get
            Return _idExtras
        End Get
        Set(value As List(Of UInt16))
            _idExtras = value
        End Set
    End Property
    Private _fechaConsulta As Date
    Public Property fechaConsulta As Date
        Get
            Return _fechaConsulta
        End Get
        Set(value As Date)
            If value < Today Then
                MsgBox("No se puede consultar una fecha anterior" & Chr(13) & "a la actual", MsgBoxStyle.Critical, "Búsqueda de turnos")
            Else
                _fechaConsulta = value
            End If
        End Set
    End Property
    Private _fecha As Date
    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Private _hora As DateTime
    Public Property hora As DateTime
        Get
            Return _hora
        End Get
        Set(value As DateTime)
            _hora = value
        End Set
    End Property
    Private _descripcion As String
    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
    Dim cdTurnos As New CapaDeDatos.cdDatos
    Public Sub traerTurnos(ByRef tabla As DataTable)
        Dim comandoSQL As String = "Select * from vista_turnos"
        cdTurnos.CargarDatos(tabla, comandoSQL)
    End Sub
    Public Function nuevoTurno() As Boolean
        Dim EjecutaComando As New CapaDeDatos.cdDatos
        Dim comando(Me.idExtras.Count + 1) As MySqlCommand
        Dim strComando As String
        Dim Comandos As New List(Of MySqlCommand)
        Try
            strComando = "INSERT INTO `db_salon`.`turnos`(`cliente`, `fecha`, `hora`, `descripcion`, `activo` ) VALUES (@IdCliente, @FechaTurno, @HoraTurno, @Descripcion, '1');"

            comando(0) = New MySqlCommand
            comando(0).CommandText = strComando
            comando(0).Parameters.Add("@IdCliente", MySqlDbType.Int16).Value = Me.idCliente
            comando(0).Parameters.Add("@FechaTurno", MySqlDbType.Date).Value = Me.fecha
            comando(0).Parameters.Add("@HoraTurno", MySqlDbType.DateTime).Value = Me.hora
            comando(0).Parameters.Add("@Descripcion", MySqlDbType.VarChar).Value = Me.descripcion
            Comandos.Add(comando(0))
            For i = 1 To Me.idExtras.Count
                comando(i) = New MySqlCommand
                comando(i).Parameters.Add("@IdAdicional", MySqlDbType.Int16)
                strComando = "INSERT INTO `db_salon`.`extraxturnos`" &
                        "(`numTurno`, `numExtra`) VALUES ((select max(idturno) from `db_salon`.`turnos`), @IdAdicional);"
                comando(i).CommandText = strComando
                comando(i).Parameters("@IdAdicional").Value = Me.idExtras.Item(i - 1)
                Comandos.Add(comando(i))
            Next
            cdTurnos.Guardar(Comandos)
            Return True
        Catch e As MySqlException
            MsgBox("ERROR:" & Chr(13) & e.Message)
            Return False
        End Try
    End Function
    Public Sub cargarModificar()
        Dim tabla As New DataTable
        Dim comandoSQL As String = "SELECT * FROM vista_turnos where idTurno = '" & _idTurno & "'"
        cdTurnos.CargarDatos(tabla, comandoSQL)
        If tabla.Rows.Count = 1 Then
            _nombreCliente = tabla.Rows(0).Item("nombre").ToString
            _apellidoCliente = tabla.Rows(0).Item("apellido").ToString
            _fecha = tabla.Rows(0).Item("fecha").ToString
            _hora = tabla.Rows(0).Item("hora").ToString
            _descripcion = tabla.Rows(0).Item("descripcion").ToString
        End If
    End Sub
    Public Sub traerUltimoCliente()
        Dim tabla As New DataTable
        Dim comandoSQL As String = "select max(cliente.idCliente) as 'idCliente' from db_salon.cliente"
        cdTurnos.CargarDatos(tabla, comandoSQL)
        _idCliente = tabla.Rows(0).Item("idCliente").ToString
    End Sub
    Public Function ConsultarDia()
        Dim comandoSQL As MySqlCommand = New MySqlCommand("select * from db_salon.turnos where fecha = @fecha")
        comandoSQL.Parameters.Add("@fecha", MySqlDbType.Date).Value = Me.fechaConsulta
        '& "'" & _fechaConsulta.ToString("yyyy-MM-dd") & "'"
        Dim tabla As New DataTable
        cdTurnos.CargarDatos(tabla, comandoSQL)
        If tabla.Rows.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub cargarExtras()
        Dim tabla As New DataTable
        Dim numExtra As New List(Of UInt16)
        Dim comandoSQL As String = "select extraxturnos.numTurno, extraxturnos.numExtra from db_salon.turnos, db_salon.extras, db_salon.extraxturnos where turnos.idturno = extraxturnos.numTurno and extras.idExtra = extraxturnos.numExtra and turnos.idturno = '" & _idTurno & "'"
        cdTurnos.CargarDatos(tabla, comandoSQL)
        For i = 0 To tabla.Rows.Count - 1
            numExtra.Add(tabla.Rows(i).Item("numExtra").ToString)
        Next
        _idExtras = numExtra
    End Sub
    Public Sub modificarExtraCliente(tabla As DataTable)
        Dim consultaSQL As String = "SELECT numExtra, nombre FROM extraxturnos, extras where extraxturnos.numExtra = extras.idextra and numTurno = " & _idTurno
        cdDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Function modificarTurno() As Boolean
        Try
            'No tengo nada para comentar en esta parte porque ni yo se como hice
            'para que funcionara
            Dim comando(Me.idExtras.Count + 1) As MySqlCommand
            Dim tabla As New DataTable
            Dim Comandos As New List(Of MySqlCommand)
            Dim comandoSQL As String = "Update `db_salon`.`turnos` set `cliente`=@cliente, `fecha`=@fecha, `hora`=@hora, `descripcion`=@descripcion where `turnos`.`idTurno` = @idTurno"
            Dim SqlComando As MySqlCommand = New MySqlCommand(comandoSQL)
            SqlComando = New MySqlCommand
            SqlComando.CommandText = comandoSQL
            SqlComando.Parameters.Add("@cliente", MySqlDbType.Int16).Value = Me.idCliente
            SqlComando.Parameters.Add("@fecha", MySqlDbType.Date).Value = Me.fecha
            SqlComando.Parameters.Add("@hora", MySqlDbType.DateTime).Value = Me.hora
            SqlComando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = Me.descripcion
            SqlComando.Parameters.Add("@idTurno", MySqlDbType.Int16).Value = Me.idTurno
            cdTurnos.CargarDatos(tabla, SqlComando)
            comandoSQL = "SELECT * FROM db_salon.extraxturnos WHERE numTurno = '" & _idTurno & "'"
            cdTurnos.CargarDatos(tabla, comandoSQL)
            'Hago esto ya que si uso el comando update en el FOR y tengo un solo extra
            'guardado, pero yo quiero agregar mas de uno me va a dar un error. Entonces antes
            'de introducir los nuevos extras borro todo y introduzco cuantos quiera
            'Lo que hago es hacer una consulta primeramente para ver si hay algun extra
            'relacionado con el id del turno que quiero modificar, si existe lo borra y agrega los nuevos
            If tabla.Rows.Count > 0 Then
                comandoSQL = "DELETE FROM db_salon.extraxturnos WHERE numTurno = '" & _idTurno & "'"
                cdTurnos.CargarDatos(tabla, comandoSQL)
            End If
            For i = 1 To Me.idExtras.Count
                comando(i) = New MySqlCommand
                comando(i).Parameters.Add("@IdAdicional", MySqlDbType.Int16)
                comando(i).Parameters.Add("@idTurno", MySqlDbType.Int16).Value = Me.idTurno
                comandoSQL = "INSERT INTO `db_salon`.`extraxturnos`" &
                        "(`numTurno`, `numExtra`) VALUES (@idTurno, @IdAdicional);"
                comando(i).CommandText = comandoSQL
                comando(i).Parameters("@IdAdicional").Value = Me.idExtras.Item(i - 1)
                Comandos.Add(comando(i))
            Next
            cdTurnos.Guardar(Comandos)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Sub darDeBajaTurno()
        Dim tabla As New DataTable
        Dim comandoSQL As String = "UPDATE db_salon.turnos SET activo = '0' WHERE idTurno = '" & _idTurno & "'"
        cdTurnos.CargarDatos(tabla, comandoSQL)
    End Sub
    Public Function NombreCompleto() As String
        Dim NombCompleto As String = Nothing
        If Not _apellidoCliente = "" And Not _nombreCliente = "" Then
            NombCompleto = _nombreCliente & " " & _apellidoCliente
        Else
            MsgBox("Error no esxite el nombre o el apllido", MsgBoxStyle.Critical, "Error Clase Persona")
        End If
        Return NombCompleto
    End Function
    Public Sub traerTurnosBaja(ByRef tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM vista_baja_turnos"
        cdDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub restaurarTurno()
        Dim consultaSQL As String = "UPDATE turnos SET activo = '1' WHERE idTurno = '" & _idTurno & "'"
        cdDatos.cargarDatos(consultaSQL)
    End Sub
    Public Sub eliminarTurno()
        Try
            Dim consultaSQL As String = "DELETE FROM extraxturnos WHERE numTurno = '" & _idTurno & "'"
            cdDatos.cargarDatos(consultaSQL)
            consultaSQL = "DELETE FROM turnos WHERE idTurno = " & _idTurno
            cdDatos.cargarDatos(consultaSQL)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub reporteAlquilerDia(ByRef tabla As DataTable, ByRef fecha1 As Date)
        Try

            Dim comandoSQL As MySqlCommand = New MySqlCommand("SELECT `turnos`.`idTurno` AS `idTurno`, `turnos`.`fecha` AS `fecha`,`turnos`.`hora` AS `hora`, `turnos`.`descripcion` AS `descripcion`, `turnos`.`activo` AS `activo`, `cliente`.`nombre` AS `nombre`, `cliente`.`apellido` AS `apellido`, GROUP_CONCAT(`extras`.`nombre` SEPARATOR ', ') AS `extra` FROM (((`turnos` JOIN `cliente`) JOIN `extras`) JOIN `extraxturnos`) WHERE ((`turnos`.`activo` = 1) AND (`turnos`.`cliente` = `cliente`.`idCliente`) AND (`turnos`.`idTurno` = `extraxturnos`.`numTurno`) AND (`extras`.`idextra` = `extraxturnos`.`numExtra`) AND (`turnos`.`fecha` = @fecha)) GROUP BY `turnos`.`idTurno` ORDER BY `turnos`.`fecha` , `turnos`.`hora`")
            comandoSQL.Parameters.Add("@fecha", MySqlDbType.Date).Value = fecha1
            cdTurnos.CargarDatos(tabla, comandoSQL)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Public Sub reporteAlquilerPersonalizado(ByRef tabla As DataTable, ByRef fechaDesde As Date, ByRef fechaHasta As Date)
        Try
            Dim comandoSQL As MySqlCommand = New MySqlCommand("SELECT `turnos`.`idTurno` AS `idTurno`, `turnos`.`fecha` AS `fecha`,`turnos`.`hora` AS `hora`, `turnos`.`descripcion` AS `descripcion`, `turnos`.`activo` AS `activo`, `cliente`.`nombre` AS `nombre`, `cliente`.`apellido` AS `apellido`, GROUP_CONCAT(`extras`.`nombre` SEPARATOR ', ') AS `extra` FROM (((`turnos` JOIN `cliente`) JOIN `extras`) JOIN `extraxturnos`) WHERE ((`turnos`.`activo` = 1) AND (`turnos`.`cliente` = `cliente`.`idCliente`) AND (`turnos`.`idTurno` = `extraxturnos`.`numTurno`) AND (`extras`.`idextra` = `extraxturnos`.`numExtra`) AND (`turnos`.`fecha` between @fechaDesde and @fechaHasta)) GROUP BY `turnos`.`idTurno` ORDER BY `turnos`.`fecha` , `turnos`.`hora`")
            comandoSQL.Parameters.Add("@fechaDesde", MySqlDbType.Date).Value = fechaDesde
            comandoSQL.Parameters.Add("@fechaHasta", MySqlDbType.Date).Value = fechaHasta
            cdTurnos.CargarDatos(tabla, comandoSQL)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
