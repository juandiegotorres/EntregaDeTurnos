Imports MySql.Data.MySqlClient
Public Class cdDatosPrueba
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim consulta As New MySqlCommand

    Private Sub AbrirConexion()
        Try
            If Not conexion Is Nothing Then
                If conexion.State = ConnectionState.Closed Then
                    If conexion.ConnectionString = Nothing Then
                        conexion.ConnectionString = "server=localhost;user Id=root;password=basededatos1;database=db_salon"
                    End If
                    conexion.Open()
                End If
            Else
                conexion = New MySqlConnection
                conexion.ConnectionString = "server=localhost;user Id=root;password=basededatos1;database=db_salon"
                conexion.Open()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        End Try
    End Sub
    Public Sub cargarDatos(ByRef consultaSQL As String)
        Try
            consulta.CommandText = consultaSQL
            consulta.Connection = conexion
            AbrirConexion()
            consulta.ExecuteNonQuery()
            CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, "Clase cdDatosPrueba")
        End Try
    End Sub
    Public Sub llenarDatos(ByRef tabla As DataTable, ByRef consultaSQL As String)
        Try
            consulta.CommandText = consultaSQL
            consulta.Connection = conexion
            adaptador.SelectCommand = consulta
            AbrirConexion()
            adaptador.Fill(tabla)
            CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, "Clase cdDatosPrueba")
        End Try
    End Sub
    Private Sub CerrarConexion()
        Try
            If Not conexion Is Nothing Then
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
            End If
        Catch _error As MySqlException
            MsgBox(_error.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        End Try
    End Sub
End Class
