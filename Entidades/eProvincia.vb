'Imports CapaDeDatos
Public Class eProvincia
    Private _nroProvincia As Byte
    Public Overridable Property nroProvincia As Byte
        Set(value As Byte)
            _nroProvincia = value
        End Set
        Get
            Return _nroProvincia
        End Get
    End Property
    Private _provincia As String
    Public Property provincia As String
        Set(value As String)
            _provincia = value
        End Set
        Get
            Return _provincia
        End Get
    End Property
    Public Sub RecuperarProvincias(ByRef tabla As DataTable)
        Dim cdProvincia As New CapaDeDatos.cdDatos
        Dim comandoSQL As String = "SELECT idprovincia, provincia FROM provincias ORDER BY provincia ASC"
        cdProvincia.CargarDatos(tabla, comandoSQL)
    End Sub
End Class
