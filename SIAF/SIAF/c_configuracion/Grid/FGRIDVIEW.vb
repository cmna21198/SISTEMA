Imports SIAF_NEGOCIO
'***************************************************************************
' Archivo: FGRIDVIEW.vb
' Elaborado por: Ing.Carlos Manuel Núñez Amador						 
' Organización: NASISTEMAS S.A										
' Fecha: 19/06/2024													 
'**************************************************************************
'								DESCRIPCIÓN								  
' Este programa fue elaborado por empresa de desarrollo NASISTEMAS S.A,   
' cualquier reproducción de este programa queda totalmente prohibido.	  
'**************************************************************************
'							    PROPÓSITO    							   
'Esta pantalla es para llamar cualquier origen de datos y representarla en
'forma de lista.
'**************************************************************************
'								CONTROL DE CAMBIOS						   
'	Fecha			Tarea		Autor		Descripcion					   
'19/06/2024		  -			CMNA		Versión inicial				   
'**************************************************************************
Public Class FGRIDVIEW
    Public VLOPERACION As String 'CMNA 21/06/2024 | Funcionalidad de catálogos
    Public VLOPCION As String 'CMNA 21/06/2024 | Funcionalidad de catálogos
    Public VLVALOR As String 'CMNA 21/06/2024 | Funcionalidad de catálogos
    Public VLCATALOGO As String 'CMNA 21/06/2024 | Funcionalidad de catálogos
    Public VLMODO As Short
    Dim n_tabla As New n_tabla 'CMNA 21/06/2024 | Funcionalidad de catálogos
#Region "Eventos"
    Private Sub FGRIDVIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PL_CARGA_GRID(False)
        If VLOPERACION = "T" Then
            grdv_grids.Columns("ta_nom_tabla").Visible = True
            grdv_grids.Columns("ta_descripcion").Visible = True
            grdv_grids.Columns("ta_estado").Visible = True

        Else
            grdv_grids.Columns("ca_catalogo").Visible = True
            grdv_grids.Columns("ca_codigo").Visible = True
            grdv_grids.Columns("ca_valor").Visible = True
            grdv_grids.Columns("ca_estado").Visible = True
        End If
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        PL_CARGA_GRID(False)
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        PL_CARGA_GRID(True)
    End Sub
    Private Sub grdc_grids_DoubleClick(sender As Object, e As EventArgs) Handles grdc_grids.DoubleClick
        'CInt(grdvTablas.GetFocusedRowCellValue(colTa_tabla).ToString())
        If VLOPERACION = "T" Then
            VLVALOR = CStr(grdv_grids.GetFocusedRowCellValue(colta_tabla).ToString()) +
                "|" + CStr(grdv_grids.GetFocusedRowCellValue(colta_nom_tabla).ToString()) +
                "|" + CStr(grdv_grids.GetFocusedRowCellValue(colta_estado).ToString())
        Else
            VLVALOR = CStr(grdv_grids.GetFocusedRowCellValue(colca_tabla).ToString()) +
                  "|" + CStr(grdv_grids.GetFocusedRowCellValue(colca_catalogo).ToString()) +
                  "|" + CStr(grdv_grids.GetFocusedRowCellValue(colca_codigo).ToString()) +
                  "|" + CStr(grdv_grids.GetFocusedRowCellValue(colca_valor).ToString()) +
                  "|" + CStr(grdv_grids.GetFocusedRowCellValue(colca_estado).ToString())
        End If
        Me.Close()
    End Sub
#End Region
#Region "Métodos"
    Private Sub PL_CARGA_GRID(ByVal pActSig As Boolean)
        Dim VLCantRowsGrid As Integer = 0
        VLCantRowsGrid = grdv_grids.DataRowCount - 1
        If VLOPERACION = "T" Then 'Esto ocurre cuando el grid a consultar, sea para tablas
            If pActSig Then
                grdc_grids.DataSource = n_tabla.FMapeaTablas(0, "", "", "", "", "", "", VLOPCION, VLOPERACION, "", CInt(grdv_grids.GetRowCellValue(VLCantRowsGrid, colta_tabla).ToString()), 0, CByte(VLMODO))
            Else
                grdc_grids.DataSource = Nothing
                grdc_grids.DataSource = n_tabla.FMapeaTablas(CInt(IIf(VLVALOR <> "" And Not VLVALOR Is Nothing, VLVALOR.Trim(), 0)), "", "", "", "", "", "", VLOPCION, VLOPERACION, "", 0, 0, CByte(VLMODO))
            End If
        Else 'Cuando el grid a consultar, sea para catálogos
            If pActSig Then
                grdc_grids.DataSource = n_tabla.FMapeaTablas(CInt(IIf(VLVALOR <> "" And Not VLVALOR Is Nothing, VLVALOR.Trim(), 0)), "", "", "", "", "", "", VLOPCION, VLOPERACION, "", CInt(grdv_grids.GetRowCellValue(VLCantRowsGrid, colca_tabla).ToString()), 0, CByte(VLMODO))
            Else
                grdc_grids.DataSource = Nothing
                grdc_grids.DataSource = n_tabla.FMapeaTablas(CInt(IIf(VLVALOR <> "" And Not VLVALOR Is Nothing, VLVALOR.Trim(), 0)), "", "", "", "", "", "", VLOPCION, VLOPERACION, "", 0, CInt(IIf(VLCATALOGO <> "" And Not VLCATALOGO Is Nothing, VLCATALOGO.Trim(), 0)), CByte(VLMODO))
            End If
        End If

    End Sub

#End Region



End Class