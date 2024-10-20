Imports System.Data.Entity.Core.EntityClient
Imports System.Runtime.Serialization.Diagnostics

Public NotInheritable Class Conection
    Public Shared Function GetConexion() As EntityConnectionStringBuilder
        Dim conn = New EntityConnectionStringBuilder
        conn.Provider = "System.Data.SqlClient"
        Try
            If My.Computer.Network.Ping("192.168.1.214") Then 'Local/Desarrollo
                conn.ProviderConnectionString = "Data Source=.;Initial Catalog=SISTEMA; User ID=user_sist; Password=1234;multipleactiveresultsets=True;application name=EntityFramework"
            Else
                If My.Computer.Network.Ping("192.168.1.30") Then 'Producción
                    conn.ProviderConnectionString = "Data Source=localhost;Initial Catalog=DB_SIAF; User ID=sa; Password=1234;multipleactiveresultsets=True;application name=EntityFramework"
                End If
            End If
            conn.Metadata = "res://*/EF_SISTEMA.csdl|res://*/EF_SISTEMA.ssdl|res://*/EF_SISTEMA.msl"
            Return conn
        Catch ex As Exception
            MsgBox("LA SOLICITUD DE CONEXIÓN AL SERVIDOR NO SE PUDO COMPLETAR, PORQUE SE ENCUENTRA FUERA DE LÍNEA.", MsgBoxStyle.Critical, "ERROR")
        End Try

    End Function
End Class
