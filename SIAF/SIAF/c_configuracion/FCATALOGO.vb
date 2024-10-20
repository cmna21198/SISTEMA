Imports SIAF_NEGOCIO
Imports SIAF_DATOS
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Public Class FCATALOGO
    Dim n_tabla As New n_tabla : Dim VGOTABLAS As New List(Of ClaseCompuesta.ta_tablas)  'CMNA 21/06/2024 | Funcionalidad de catálogos
    Dim _VLTabla() As String  'CMNA 21/06/2024 | Funcionalidad de catálogos
    Dim _VLCatalogo() As String  'CMNA 27/06/2024 | Arreglando bugs
    Dim VGTipoOperacion As String 'CMNA 21/06/2024 | Funcionalidad de catálogos

#Region "Eventos"
    Private Sub btnBuscarTabla_Click(sender As Object, e As EventArgs) Handles btnBuscarTabla.Click
        Dim gridview As New FGRIDVIEW
        gridview.VLOPERACION = "T"
        gridview.VLOPCION = "Q"
        gridview.ShowDialog()
        _VLTabla = IIf(gridview.VLVALOR <> "", Split(gridview.VLVALOR, "|"), Nothing)
        gridview.Dispose()

        If Not _VLTabla Is Nothing Then
            txtTabla.Enabled = False
            txtTabla.Text = _VLTabla(1)
            PL_CARGAR_DATOS_CATALOGO_TABLA()
            btnRecargar.Enabled = True
            btnEditar.Enabled = True
        End If
        ReDim _VLCatalogo(-1)
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        PL_CARGAR_DATOS_CATALOGO_TABLA()
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarControles()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ReDim _VLCatalogo(-1)
        Dim VLCATALOGODATOS As String
        VLCATALOGODATOS = CStr(grd_gridview.GetFocusedRowCellValue(calca_codigo).ToString()) +
                    "|" + CStr(grd_gridview.GetFocusedRowCellValue(colca_catalogo).ToString()) +
                    "|" + CStr(grd_gridview.GetFocusedRowCellValue(colca_valor).ToString()) +
                    "|" + IIf(CStr(grd_gridview.GetFocusedRowCellValue(colca_estado).ToString()) = "A", True, False).ToString

        _VLCatalogo = Split(VLCATALOGODATOS, "|").ToArray()

        txtCodigo.Text = CStr(grd_gridview.GetFocusedRowCellValue(calca_codigo).ToString())
        txtValor.Text = CStr(grd_gridview.GetFocusedRowCellValue(colca_valor).ToString())
        TsEstado.IsOn = IIf(CStr(grd_gridview.GetFocusedRowCellValue(colca_estado).ToString()) = "A", True, False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim VLObjeto() As Object : Dim VLMensajeReturn As String : Dim idcatalogo As Short
        If _VLCatalogo.Length > 0 Then
            idcatalogo = CShort(_VLCatalogo(1))
        End If

        If FL_VALIDA_DATOS_ENTRADA() Then
            VGTipoOperacion = FL_VALIDA_TIPO_OPERACION()
            VLObjeto = (n_tabla.FMapeaTablas(_VLTabla(0), "", "", "", txtCodigo.Text, txtValor.Text, IIf(TsEstado.IsOn, "A", "I"), VGTipoOperacion, "C", "", 0, CShort(IIf(_VLCatalogo.Length > 0, idcatalogo, 0)), 0)).ToArray
            For Each obj As Object In VLObjeto
                VLMensajeReturn = obj.men_numero.ToString + "|" + obj.men_mensaje
            Next
            If VLMensajeReturn <> "" Then
                MsgBox(VLMensajeReturn, MsgBoxStyle.Information, "Aviso:")
            End If
        End If
        PL_CARGAR_DATOS_CATALOGO_TABLA()
        'LimpiarControles()
    End Sub


    Private Sub FCATALOGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivaDesactivaCtrl()
    End Sub

    Private Sub grid_view_DoubleClick(sender As Object, e As EventArgs) Handles grid_view.DoubleClick
        ReDim _VLCatalogo(-1)
        Dim VLCATALOGODATOS As String
        VLCATALOGODATOS = CStr(grd_gridview.GetFocusedRowCellValue(calca_codigo).ToString()) +
                    "|" + CStr(grd_gridview.GetFocusedRowCellValue(colca_catalogo).ToString()) +
                    "|" + CStr(grd_gridview.GetFocusedRowCellValue(colca_valor).ToString()) +
                    "|" + IIf(CStr(grd_gridview.GetFocusedRowCellValue(colca_estado).ToString()) = "A", True, False).ToString

        _VLCatalogo = Split(VLCATALOGODATOS, "|").ToArray()

        txtCodigo.Text = CStr(grd_gridview.GetFocusedRowCellValue(calca_codigo).ToString())
        txtValor.Text = CStr(grd_gridview.GetFocusedRowCellValue(colca_valor).ToString())
        TsEstado.IsOn = IIf(CStr(grd_gridview.GetFocusedRowCellValue(colca_estado).ToString()) = "A", True, False)
    End Sub
    Private Sub FCATALOGO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
#End Region
#Region "METÓDOS LOCALES"
    Private Sub PL_CARGAR_DATOS_CATALOGO_TABLA()
        If Not _VLTabla Is Nothing Then
            If _VLTabla.Length > 0 Then
                VGOTABLAS = n_tabla.FMapeaTablas(_VLTabla(0), "", "", "", "", "", "", "Q", "C", "", 0, 0, 0).ToList()
                If VGOTABLAS.Count <> 0 Then
                    grid_view.DataSource = Nothing
                    grid_view.DataSource = VGOTABLAS
                    grd_gridview.BestFitColumns()
                Else
                    MsgBox("0|No se encontraron registros", MsgBoxStyle.Information, "AVISO:")
                End If
            Else
                MsgBox("0|No se pueden cargar los registros sin antes haber seleccionado la tabla a relacionar.".ToUpper(), MsgBoxStyle.Critical, "ERROR:")
            End If
        Else
            MsgBox("0|No se pueden cargar los registros sin antes haber seleccionado la tabla a relacionar.".ToUpper(), MsgBoxStyle.Critical, "ERROR:")
        End If

    End Sub

    Private Sub ActivaDesactivaCtrl()
        If grd_gridview.DataRowCount <> 0 Then
            btnEditar.Enabled = True
            btnRecargar.Enabled = True
        Else
            btnEditar.Enabled = False
            btnRecargar.Enabled = False
        End If
    End Sub

    Private Function FL_VALIDA_DATOS_ENTRADA() As Boolean
        If txtTabla.Text = "" Then
            MsgBox("NO SE HA SELECCIONADO LA TABLA, PARA RELACIONAR EL CATÁLOGO.", MsgBoxStyle.Critical, "ERROR: ")
            Return False
        ElseIf txtCodigo.Text = "" Then
            MsgBox("EL CÓDIGO DEL CATÁLOGO NO PUEDE ESTAR VACÍO.", MsgBoxStyle.Critical, "ERROR: ")
            Return False
        Else
            Return True
        End If

    End Function
    Private Function FL_VALIDA_TIPO_OPERACION() As String
        If _VLCatalogo.Length > 0 Then
            If (_VLTabla(0) <> 0 And Not VGOTABLAS.Find(Function(x) x.ca_catalogo = _VLCatalogo(1)) Is Nothing) And TsEstado.IsOn Then
                Return "U"
            ElseIf (_VLTabla(0) <> 0 And Not VGOTABLAS.Find(Function(x) x.ca_catalogo = _VLCatalogo(1)) Is Nothing) And Not TsEstado.IsOn Then
                Return "D"
            End If
        Else
            Return "I"
        End If
    End Function

    Private Sub LimpiarControles()
        'ReDim _VLTabla(-1)
        'txtTabla.Text = ""
        txtCodigo.Text = ""
        txtValor.Text = ""
        TsEstado.IsOn = False
        'grid_view.DataSource = Nothing
        'VGOTABLAS.Clear()
        'VGTipoOperacion = ""
        'ActivaDesactivaCtrl()
    End Sub


#End Region

End Class