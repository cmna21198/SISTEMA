<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FGRIDVIEW
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FGRIDVIEW))
        Me.grdc_grids = New DevExpress.XtraGrid.GridControl()
        Me.grdv_grids = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colta_tabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colta_nom_tabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colta_descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colta_estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colca_tabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colca_catalogo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colca_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colca_valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colca_estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnsiguiente = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRecargar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grdc_grids, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdv_grids, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdc_grids
        '
        Me.grdc_grids.Location = New System.Drawing.Point(0, 12)
        Me.grdc_grids.MainView = Me.grdv_grids
        Me.grdc_grids.Name = "grdc_grids"
        Me.grdc_grids.Size = New System.Drawing.Size(433, 329)
        Me.grdc_grids.TabIndex = 0
        Me.grdc_grids.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdv_grids})
        '
        'grdv_grids
        '
        Me.grdv_grids.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colta_tabla, Me.colta_nom_tabla, Me.colta_descripcion, Me.colta_estado, Me.colca_tabla, Me.colca_catalogo, Me.colca_codigo, Me.colca_valor, Me.colca_estado})
        Me.grdv_grids.GridControl = Me.grdc_grids
        Me.grdv_grids.Name = "grdv_grids"
        Me.grdv_grids.OptionsFind.AlwaysVisible = True
        Me.grdv_grids.OptionsView.ShowGroupPanel = False
        '
        'colta_tabla
        '
        Me.colta_tabla.Caption = "IdTabla"
        Me.colta_tabla.FieldName = "ta_tabla"
        Me.colta_tabla.Name = "colta_tabla"
        Me.colta_tabla.OptionsColumn.AllowEdit = False
        Me.colta_tabla.Width = 76
        '
        'colta_nom_tabla
        '
        Me.colta_nom_tabla.Caption = "Nombre de Tabla"
        Me.colta_nom_tabla.FieldName = "ta_nom_tabla"
        Me.colta_nom_tabla.Name = "colta_nom_tabla"
        Me.colta_nom_tabla.OptionsColumn.AllowEdit = False
        Me.colta_nom_tabla.OptionsColumn.ReadOnly = True
        Me.colta_nom_tabla.Width = 94
        '
        'colta_descripcion
        '
        Me.colta_descripcion.Caption = "Descripción de tabla"
        Me.colta_descripcion.FieldName = "ta_descripcion"
        Me.colta_descripcion.Name = "colta_descripcion"
        Me.colta_descripcion.OptionsColumn.AllowEdit = False
        Me.colta_descripcion.OptionsColumn.ReadOnly = True
        Me.colta_descripcion.Width = 73
        '
        'colta_estado
        '
        Me.colta_estado.Caption = "Estado Tabla"
        Me.colta_estado.FieldName = "ta_estado"
        Me.colta_estado.Name = "colta_estado"
        Me.colta_estado.OptionsColumn.AllowEdit = False
        Me.colta_estado.OptionsColumn.ReadOnly = True
        Me.colta_estado.Width = 73
        '
        'colca_tabla
        '
        Me.colca_tabla.Caption = "ca_tabla"
        Me.colca_tabla.FieldName = "ca_tabla"
        Me.colca_tabla.Name = "colca_tabla"
        Me.colca_tabla.OptionsColumn.AllowEdit = False
        Me.colca_tabla.OptionsColumn.ReadOnly = True
        Me.colca_tabla.Width = 73
        '
        'colca_catalogo
        '
        Me.colca_catalogo.Caption = "N° Catalogo"
        Me.colca_catalogo.FieldName = "ca_catalogo"
        Me.colca_catalogo.Name = "colca_catalogo"
        Me.colca_catalogo.OptionsColumn.AllowEdit = False
        Me.colca_catalogo.Width = 73
        '
        'colca_codigo
        '
        Me.colca_codigo.Caption = "Codigo"
        Me.colca_codigo.FieldName = "ca_codigo"
        Me.colca_codigo.Name = "colca_codigo"
        Me.colca_codigo.OptionsColumn.AllowEdit = False
        Me.colca_codigo.OptionsColumn.ReadOnly = True
        Me.colca_codigo.Width = 73
        '
        'colca_valor
        '
        Me.colca_valor.Caption = "Valor"
        Me.colca_valor.FieldName = "ca_valor"
        Me.colca_valor.Name = "colca_valor"
        Me.colca_valor.OptionsColumn.AllowEdit = False
        Me.colca_valor.OptionsColumn.ReadOnly = True
        Me.colca_valor.Width = 73
        '
        'colca_estado
        '
        Me.colca_estado.Caption = "Estado Catálogo"
        Me.colca_estado.FieldName = "ca_estado"
        Me.colca_estado.Name = "colca_estado"
        Me.colca_estado.OptionsColumn.AllowEdit = False
        Me.colca_estado.OptionsColumn.ReadOnly = True
        Me.colca_estado.Width = 84
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Appearance.Image = CType(resources.GetObject("btnsiguiente.Appearance.Image"), System.Drawing.Image)
        Me.btnsiguiente.Appearance.Options.UseImage = True
        Me.btnsiguiente.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnsiguiente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnsiguiente.ImageOptions.Image = CType(resources.GetObject("btnsiguiente.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsiguiente.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnsiguiente.Location = New System.Drawing.Point(439, 12)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(124, 47)
        Me.btnsiguiente.TabIndex = 14
        Me.btnsiguiente.Text = "&Siguentes"
        '
        'btnRecargar
        '
        Me.btnRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRecargar.ImageOptions.Image = CType(resources.GetObject("btnRecargar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRecargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnRecargar.Location = New System.Drawing.Point(439, 79)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(124, 47)
        Me.btnRecargar.TabIndex = 13
        Me.btnRecargar.Text = "&RECARGAR REGISTROS"
        '
        'FGRIDVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(570, 353)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.grdc_grids)
        Me.Name = "FGRIDVIEW"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LISTADOS"
        CType(Me.grdc_grids, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdv_grids, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdc_grids As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdv_grids As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnsiguiente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRecargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colta_tabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colta_nom_tabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colta_descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colta_estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colca_tabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colca_codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colca_valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colca_estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colca_catalogo As DevExpress.XtraGrid.Columns.GridColumn
End Class
