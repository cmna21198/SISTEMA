Imports SIAF_NEGOCIO
#Region "Estructs"
Structure DataEdit
    Public ta_tabla_princ As String
    Public ta_cat_principal As String
    Public ta_tabla_padre As String
    Public ta_cat_padre As String
End Structure
#End Region
Public Class FRELACION_CATALOGO
    Dim n_tablas As New n_tabla
    Dim _VLTabla() As String '01/07/2024 CMNA
    Dim VLId As Integer
    Dim VLTIPO_OPERACION As Char
    Dim VTDATA() As DataEdit

#Region "Eventos de formulario"
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click

    End Sub

    Private Sub btnBuscarTabla_0_Click(sender As Object, e As EventArgs) Handles btnBuscarTabla_0.Click, btnBuscarTabla_1.Click, btnBuscarTabla_2.Click, btnBuscarTabla_3.Click
        Dim gridview As New FGRIDVIEW
        VLTIPO_OPERACION = IIf(sender.Name = "btnBuscarTabla_0" Or sender.Name = "btnBuscarTabla_2", "T", "C")
        gridview.VLOPERACION = VLTIPO_OPERACION
        gridview.VLOPCION = "Q"

        If VLTIPO_OPERACION = "T" Then
            If VTDATA Is Nothing Then
                gridview.VLVALOR = ""
                gridview.VLCATALOGO = ""
                gridview.VLMODO = 1
            Else
                If sender.Name = "btnBuscarTabla_2" Then
                    gridview.VLMODO = 2
                End If
                gridview.VLVALOR = IIf((VTDATA(0).ta_tabla_princ <> "" Or Not VTDATA(0).ta_tabla_princ Is Nothing), VTDATA(0).ta_tabla_princ, VTDATA(0).ta_tabla_padre)
            End If
        End If

        If VLTIPO_OPERACION = "C" Then
            If VTDATA Is Nothing Or VTDATA.Length = 0 Then
                gridview.VLVALOR = ""
                gridview.VLCATALOGO = ""
            Else
                gridview.VLMODO = 1
                gridview.VLCATALOGO = ""
                If sender.Name = "btnBuscarTabla_1" Then
                    gridview.VLVALOR = IIf((VTDATA(0).ta_tabla_princ <> "" Or Not VTDATA(0).ta_tabla_princ Is Nothing), VTDATA(0).ta_tabla_princ, "0")

                Else
                    gridview.VLVALOR = IIf((VTDATA(0).ta_tabla_padre <> "" Or Not VTDATA(0).ta_tabla_padre Is Nothing), VTDATA(0).ta_tabla_padre, "0")
                End If
            End If
        End If
        gridview.ShowDialog()
        _VLTabla = IIf(gridview.VLVALOR <> "", Split(gridview.VLVALOR, "|"), Nothing)
        gridview.Dispose()

        If Not _VLTabla Is Nothing Then
            If VTDATA Is Nothing Then
                ReDim VTDATA(0)
            End If

            If VLTIPO_OPERACION = "T" Then
                If sender.Name = "btnBuscarTabla_0" Then
                    If (_VLTabla.Length - 1 > 0) Then
                        VTDATA(0).ta_tabla_princ = _VLTabla(0).Trim()
                        txttblprincipal.Text = _VLTabla(1).Trim()
                    End If

                Else
                    If (_VLTabla.Length - 1 > 0) Then
                        VTDATA(0).ta_tabla_padre = _VLTabla(0)
                        txtblpadre.Text = _VLTabla(1).Trim()
                    End If

                End If

            ElseIf VLTIPO_OPERACION = "C" Then
                If sender.Name = "btnBuscarTabla_1" Then
                    If (_VLTabla.Length - 1 > 0) Then
                        VTDATA(0).ta_cat_principal = _VLTabla(1).Trim()
                        txtcatalogoprinc.Text = _VLTabla(3).Trim()
                    End If

                Else
                    If (_VLTabla.Length - 1 > 0) Then
                        VTDATA(0).ta_cat_padre = _VLTabla(1).Trim()
                        txtcatalogopadre.Text = _VLTabla(3).Trim()
                    End If
                End If
            End If



        End If

    End Sub

    Private Sub tsEsPadre_Toggled(sender As Object, e As EventArgs) Handles tsEsPadre.Toggled
        If sender.IsOn Then
            txtblpadre.Enabled = False
            txtcatalogopadre.Enabled = False
            btnBuscarTabla_2.Enabled = False
            btnBuscarTabla_3.Enabled = False
        Else
            txtblpadre.Enabled = True
            txtcatalogopadre.Enabled = True
            btnBuscarTabla_2.Enabled = True
            btnBuscarTabla_3.Enabled = True
        End If
    End Sub
#End Region
#Region "Métodos lógicos"
    Private Sub PL_RECARGAR_GRID()
        grdcTablas.DataSource = Nothing
    End Sub
#End Region
End Class