Imports MySql.Data.MySqlClient
Public Class eExtras
    Dim cdDatos As New CapaDeDatos.cdDatosPrueba
    Private _idExtra As UInt16
    Public Property idExtra As UInt16
        Get
            Return _idExtra
        End Get
        Set(value As UInt16)
            _idExtra = value
        End Set
    End Property
    Private _nombre As String
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
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
    Private _precio As Decimal
    Public Property precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property
    Private _cantidad As UInt16
    Public Property cantidad As UInt16
        Get
            Return _cantidad
        End Get
        Set(value As UInt16)
            _cantidad = value
        End Set
    End Property
    Dim capaDatos As New CapaDeDatos.cdDatos
    Public Sub nuevoExtra()
        Try
            Dim tabla As New DataTable
            Dim comandoSQL As String = "INSERT INTO db_salon.extras (idExtra,nombre,descripcion,precio,cantidad,activo) VALUES  (@id,@nombre,@descripcion,@precio,@cantidad,'1')"
            Dim SqlComando As MySqlCommand = New MySqlCommand(comandoSQL)
            SqlComando.Parameters.Add("@id", MySqlDbType.Int16).Value = Me.idExtra
            SqlComando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = Me.nombre
            SqlComando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = Me.descripcion
            SqlComando.Parameters.Add("@precio", MySqlDbType.Decimal).Value = Me.precio
            SqlComando.Parameters.Add("@cantidad", MySqlDbType.Int16).Value = Me.cantidad

            capaDatos.CargarDatos(tabla, SqlComando)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cargarModificar()
        Dim tabla As New DataTable
        Dim comandoSQL As String = "SELECT * FROM db_salon.extras where idExtra = '" & _idExtra & "'"
        capaDatos.CargarDatos(tabla, comandoSQL)
        If tabla.Rows.Count = 1 Then
            _nombre = tabla.Rows(0).Item("nombre").ToString
            _descripcion = tabla.Rows(0).Item("descripcion").ToString
            _precio = tabla.Rows(0).Item("precio").ToString
            _cantidad = tabla.Rows(0).Item("cantidad").ToString
        End If
    End Sub
    Public Sub modificarExtra()
        Try
            Dim tabla As New DataTable
            Dim comandoSQL As String = "UPDATE db_salon.extras SET nombre = @nombre, cantidad = @cantidad, precio = @precio, descripcion = @descripcion WHERE idExtra = @idExtra"
            Dim SqlComando As MySqlCommand = New MySqlCommand(comandoSQL)
            SqlComando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = Me.nombre
            SqlComando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = Me.descripcion
            SqlComando.Parameters.Add("@precio", MySqlDbType.Decimal).Value = Me.precio
            SqlComando.Parameters.Add("@cantidad", MySqlDbType.Int16).Value = Me.cantidad
            SqlComando.Parameters.Add("@idExtra", MySqlDbType.Int16).Value = Me.idExtra
            capaDatos.CargarDatos(tabla, SqlComando)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub recuperarExtras(ByRef tabla As DataTable)
        Try
            Dim comandoSQL As String = "SELECT * FROM db_salon.extras WHERE activo= 1"
            capaDatos.CargarDatos(tabla, comandoSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub contarExtras()
        Try
            Dim tabla As New DataTable
            Dim comandoSQL As String = "SELECT count(idExtra) as 'cantidad' FROM extras"
            capaDatos.CargarDatos(tabla, comandoSQL)
            _cantidad = tabla.Rows(0).Item("cantidad").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cargarCLB(ByRef tabla As DataTable)
        Try
            Dim comandoSQL As String = "Select idextra, nombre from db_salon.extras where activo = 1"
            capaDatos.CargarDatos(tabla, comandoSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub darDeBajaExtra()
        Dim tabla As New DataTable
        Dim comandoSQL As String = "UPDATE db_salon.extras SET activo = '0' WHERE idExtra = '" & _idExtra & "'"
        capaDatos.CargarDatos(tabla, comandoSQL)
    End Sub
    Public Sub traerExtrasBaja(ByRef tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM db_salon.extras WHERE activo= 0"
        cdDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub restaurarExtra()
        Dim consultaSQL As String = "UPDATE extras SET activo = '1' WHERE idextra = '" & _idExtra & "'"
        cdDatos.cargarDatos(consultaSQL)
    End Sub
    Public Sub eliminarExtra()
        Try
            Dim consultaSQL As String = "DELETE FROM extraxturnos WHERE numExtra = '" & _idExtra & "'"
            cdDatos.cargarDatos(consultaSQL)
            consultaSQL = "DELETE FROM extras WHERE idextra = " & _idExtra
            cdDatos.cargarDatos(consultaSQL)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#Region "Reportes"
    Public Sub reportarExtras(ByRef tabla As DataTable)
        Try
            Dim comandoSQL As String = "SELECT nombre , count(numExtra) as 'cantidad' FROM extraxturnos, extras where extraxturnos.numExtra = extras.idextra and extras.activo=1 group by numExtra order by cantidad desc;"
            capaDatos.CargarDatos(tabla, comandoSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
