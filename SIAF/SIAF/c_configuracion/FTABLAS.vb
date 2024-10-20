Imports SIAF_NEGOCIO
'***************************************************************************
' Archivo: FTABLAS.vb
' Elaborado por: Ing.Carlos Manuel Núñez Amador						 
' Organización: NASISTEMAS S.A										
' Fecha: 19/06/2024													 
'**************************************************************************
'								DESCRIPCIÓN								  
' Este programa fue elaborado por empresa de desarrollo NASISTEMAS S.A,   
' cualquier reproducción de este programa queda totalmente prohibido.	  
'**************************************************************************
'							    PROPÓSITO    							   
'Esta pantalla es para realizar las operaciones básicas, para el mant.	   
'de tablas catálogos.													   
'**************************************************************************
'								CONTROL DE CAMBIOS						   
'	Fecha			Tarea		Autor		Descripcion					   
'19/06/2024		  -			CMNA		Versión inicial				   
'**************************************************************************

Public Class FTABLAS
    Dim n_tabla As New n_tabla 'CMNA 21/06/2024 | Funcionalidad de catálogos
    Dim VGTabla As Integer = 0 'CMNA 21/06/2024 | Funcionalidad de catálogos
    Dim VGTipoOperacion As String 'CMNA 21/06/2024 | Funcionalidad de catálogos
#Region "Eventos de pantalla"
    Private Sub txtDesc_tabla_TextChanged(sender As Object, e As EventArgs) Handles txtDesc_tabla.TextChanged
        If Not txtDesc_tabla.Text Is Nothing And txtDesc_tabla.Text <> "" Then
            lblContString.Text = (txtDesc_tabla.Text.Length.ToString) + "/150"
            If txtDesc_tabla.Text.Length > 150 Then
                MsgBox("Este campo no acepta más de 150 caracteres", MsgBoxStyle.Critical, "Error:")
                txtDesc_tabla.Text = Mid(txtDesc_tabla.Text, 1, 150)
            End If
        Else
            lblContString.Text = "0/150"
        End If
    End Sub

    Private Sub grdvTablas_DoubleClick(sender As Object, e As EventArgs) Handles grdvTablas.DoubleClick

        VGTabla = CInt(grdvTablas.GetFocusedRowCellValue(colTa_tabla).ToString())
        txtTabla.Text = grdvTablas.GetFocusedRowCellValue(colta_nom_tabla).ToString()
        txtDesc_tabla.Text = grdvTablas.GetFocusedRowCellValue(colta_descripcion).ToString()
        TsEstado.IsOn = IIf(grdvTablas.GetFocusedRowCellValue(colta_estado).ToString() = "A", True, False)
    End Sub

    Private Sub FTABLAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdcTablas.DataSource = Nothing
        grdcTablas.DataSource = n_tabla.FMapeaTablas(0, "", "", "", "", "", "", "Q", "T", "", 0, 0, 0)
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        Dim VLCantRowsGrid As Integer = 0
        VLCantRowsGrid = grdvTablas.DataRowCount - 1
        grdcTablas.DataSource = n_tabla.FMapeaTablas(0, "", "", "", "", "", "", "Q", "T", "", CInt(grdvTablas.GetRowCellValue(VLCantRowsGrid, colTa_tabla).ToString()), 0, 0)
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        PL_RECARGAR_GRID()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtTabla.Text = ""
        txtDesc_tabla.Text = ""
        TsEstado.IsOn = False
        VGTabla = 0
        VGTipoOperacion = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim VLObjeto() As Object : Dim VLMensajeReturn As String
        If FL_VALIDA_DATOS_ENTRADA() Then
            VGTipoOperacion = FL_VALIDA_TIPO_OPERACION()
            VLObjeto = (n_tabla.FMapeaTablas(VGTabla, txtTabla.Text, txtDesc_tabla.Text, IIf(TsEstado.IsOn, "A", "I"), "", "", "", VGTipoOperacion, "T", "", 0, 0, 0)).ToArray
            For Each obj As Object In VLObjeto
                VLMensajeReturn = obj.men_numero.ToString + "|" + obj.men_mensaje
            Next
            If VLMensajeReturn <> "" Then
                MsgBox(VLMensajeReturn, MsgBoxStyle.Information, "Aviso:")
            End If
        End If
        PL_RECARGAR_GRID()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtTabla.Text = grdvTablas.GetFocusedRowCellValue(colta_nom_tabla).ToString()
        txtDesc_tabla.Text = grdvTablas.GetFocusedRowCellValue(colta_descripcion).ToString()
        TsEstado.IsOn = IIf(grdvTablas.GetFocusedRowCellValue(colta_estado).ToString() = "A", True, False)
    End Sub

    Private Sub FTABLAS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

#End Region

#Region "Métodos lógicos"
    Private Function FL_VALIDA_DATOS_ENTRADA() As Boolean
        If txtTabla.Text = "" Then
            MsgBox("EL CAMPO DEL NOMBRE DE LA TABLA DEBE SER COMPLETADO", MsgBoxStyle.Critical, "ERROR: ")
            Return False
        ElseIf txtDesc_tabla.Text = "" Then
            MsgBox("EL CAMPO DE LA DESCRIPCIÓN DE LA TABLA DEBE SER COMPLETADO", MsgBoxStyle.Critical, "ERROR: ")
            Return False
        Else
            Return True
        End If

    End Function
    Private Function FL_VALIDA_TIPO_OPERACION() As String
        If VGTabla <> 0 And TsEstado.IsOn Then
            Return "U"
        ElseIf VGTabla <> 0 And Not TsEstado.IsOn Then
            Return "D"
        Else
            Return "I"
        End If
    End Function

    Private Sub PL_RECARGAR_GRID()
        grdcTablas.DataSource = Nothing
        grdcTablas.DataSource = n_tabla.FMapeaTablas(0, "", "", "", "", "", "", "Q", "T", "", 0, 0, 0)
        grdvTablas.BestFitColumns()
    End Sub


#End Region
End Class