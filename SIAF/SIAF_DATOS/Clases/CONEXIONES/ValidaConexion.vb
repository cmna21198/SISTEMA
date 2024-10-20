Imports System.Data.Entity.Core.EntityClient
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Validation
Imports System.Data.SqlClient
Public Class ValidaConexion
    Private Shared conn As EntityConnectionStringBuilder

    ''' <summary>
    ''' metodo que permite hacer la coneccion dependiendo el nombre de la empresa
    ''' </summary>
    Public Shared Function GetConnection() As EntityConnectionStringBuilder
        If conn Is Nothing Then
            conn = Conection.GetConexion
        End If
        Return conn
    End Function
    ''' <summary>
    ''' metodo para validar la conexion
    ''' </summary>
    Public Shared Sub ChangeConnection()
        If conn Is Nothing Then
            conn = Conection.GetConexion
        Else
            conn = Nothing
            conn = Conection.GetConexion
        End If
    End Sub
    Public Shared Function ComprobarConexionServidor()
        If GetConnection() IsNot Nothing Then
            Dim connetionString As String = Nothing
            Dim cnn As SqlConnection

            cnn = New SqlConnection(GetConnection.ProviderConnectionString.ToString + ";Connection Timeout=15")
            Try

                cnn.Open()
                cnn.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try

        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Esta función es para definir los mensajes de errores controlados cuando hay falta de comunicación con el servidor.
    ''' </summary>
    ''' <param name="exe"></param>
    ''' <returns>integer or msgbox</returns>
    Public Shared Function MensajesDeErrores(ByVal exe As Exception) As Integer
        If ComprobarConexionServidor() Then
            Try
                Dim db As New SISTEMAEntities
                Dim MostrarErrorCliente As Boolean = True
                If MostrarErrorCliente Then
                    Dim message = String.Format("Message ---" + vbNewLine + "{0} " + vbNewLine + "InnerException ---" + vbNewLine + " {1} " + vbNewLine + "Message ---" + vbNewLine + " {2} " + vbNewLine + "HelpLink ---" + vbNewLine + "{3} " + vbNewLine + "StackTrace ---" + vbNewLine + "{4} " + vbNewLine + "TargetSite ---" + vbNewLine + "{5}", exe.Message, exe.InnerException, exe.HelpLink, exe.Source, exe.StackTrace, exe.TargetSite)
                    MsgBox(message, MsgBoxStyle.Information, "Detalles de exepción")
                Else
                    Throw exe
                End If
            Catch ex As NullReferenceException
                MsgBox("Ha ocurrido un error al realizar la operación, objeto no contiene valor", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Return -1
            Catch ex As DbEntityValidationException
                MsgBox("Ha ocurrido un error al realizar la operación, contexto no válido", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Return -1
            Catch ex As SqlClient.SqlException
                MsgBox("Ha ocurrido un error al realizar la Operación, mensaje generado desde el servidor", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Return -1
            Catch ex As DbUpdateException
                MsgBox("Ha ocurrido un error al realizar la Operación, no se actualizó la información requerida", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Return -1
            Catch ex As System.Data.Entity.Core.EntityCommandExecutionException
                MsgBox("Ha ocurrido un error al realizar la Operación, contexto no válido", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Return -1
            Catch e As System.Data.Entity.Core.EntitySqlException
                MsgBox("Ha ocurrido un error al realizar la Operación, se ha ingresado sintáctica o semántica incorrecta", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Return -1
            Catch ex As System.Data.Entity.Core.EntityException
                MsgBox("Ha ocurrido un error al realizar la Operación, sentencia no válida", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Return -1
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al realizar la operación, contacte con soporte", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Return -1
            End Try
        Else
            MsgBox("TIMEOUT: Se ha perdido la conexión con el servidor, revise su conexión a internet e intente nuevamente.", MsgBoxStyle.Critical, "MENSAJE DE INFORMACIÓN")
        End If
        Return -1
    End Function

End Class
