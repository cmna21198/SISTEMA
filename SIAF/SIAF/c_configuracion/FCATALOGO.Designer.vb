<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FCATALOGO
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCATALOGO))
        Me.grid_view = New DevExpress.XtraGrid.GridControl()
        Me.grd_gridview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colca_tabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colca_catalogo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.calca_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colca_valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colca_estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRecargar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.TsEstado = New DevExpress.XtraEditors.ToggleSwitch()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTabla = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscarTabla = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.grid_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_gridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTabla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_view
        '
        Me.grid_view.Location = New System.Drawing.Point(15, 147)
        Me.grid_view.LookAndFeel.SkinName = "Office 2013"
        Me.grid_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_view.MainView = Me.grd_gridview
        Me.grid_view.Name = "grid_view"
        Me.grid_view.Size = New System.Drawing.Size(440, 206)
        Me.grid_view.TabIndex = 0
        Me.grid_view.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd_gridview})
        '
        'grd_gridview
        '
        Me.grd_gridview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colca_tabla, Me.colca_catalogo, Me.calca_codigo, Me.colca_valor, Me.colca_estado})
        GridFormatRule1.Column = Me.colca_estado
        GridFormatRule1.ColumnApplyTo = Me.colca_estado
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression1.Expression = "[ca_estado] = 'I'"
        FormatConditionRuleExpression1.PredefinedName = "Bold Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.Column = Me.colca_estado
        GridFormatRule2.ColumnApplyTo = Me.colca_estado
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression2.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression2.Expression = "[ca_estado] = 'A'"
        FormatConditionRuleExpression2.PredefinedName = "Bold Text"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.grd_gridview.FormatRules.Add(GridFormatRule1)
        Me.grd_gridview.FormatRules.Add(GridFormatRule2)
        Me.grd_gridview.GridControl = Me.grid_view
        Me.grd_gridview.Name = "grd_gridview"
        Me.grd_gridview.OptionsFind.AlwaysVisible = True
        Me.grd_gridview.OptionsView.ShowGroupPanel = False
        '
        'colca_tabla
        '
        Me.colca_tabla.Caption = "tabla"
        Me.colca_tabla.FieldName = "ca_tabla"
        Me.colca_tabla.Name = "colca_tabla"
        Me.colca_tabla.OptionsColumn.AllowEdit = False
        Me.colca_tabla.OptionsColumn.ReadOnly = True
        '
        'colca_catalogo
        '
        Me.colca_catalogo.AppearanceCell.Options.UseTextOptions = True
        Me.colca_catalogo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colca_catalogo.Caption = "N°"
        Me.colca_catalogo.FieldName = "ca_catalogo"
        Me.colca_catalogo.Name = "colca_catalogo"
        Me.colca_catalogo.OptionsColumn.AllowEdit = False
        Me.colca_catalogo.Visible = True
        Me.colca_catalogo.VisibleIndex = 0
        '
        'calca_codigo
        '
        Me.calca_codigo.AppearanceCell.Options.UseTextOptions = True
        Me.calca_codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.calca_codigo.Caption = "Código"
        Me.calca_codigo.FieldName = "ca_codigo"
        Me.calca_codigo.Name = "calca_codigo"
        Me.calca_codigo.OptionsColumn.AllowEdit = False
        Me.calca_codigo.OptionsColumn.ReadOnly = True
        Me.calca_codigo.Visible = True
        Me.calca_codigo.VisibleIndex = 1
        '
        'colca_valor
        '
        Me.colca_valor.Caption = "Valor"
        Me.colca_valor.FieldName = "ca_valor"
        Me.colca_valor.Name = "colca_valor"
        Me.colca_valor.OptionsColumn.AllowEdit = False
        Me.colca_valor.OptionsColumn.ReadOnly = True
        Me.colca_valor.Visible = True
        Me.colca_valor.VisibleIndex = 2
        '
        'colca_estado
        '
        Me.colca_estado.AppearanceCell.Options.UseTextOptions = True
        Me.colca_estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colca_estado.Caption = "Estado"
        Me.colca_estado.FieldName = "ca_estado"
        Me.colca_estado.Name = "colca_estado"
        Me.colca_estado.OptionsColumn.AllowEdit = False
        Me.colca_estado.OptionsColumn.ReadOnly = True
        Me.colca_estado.Visible = True
        Me.colca_estado.VisibleIndex = 3
        '
        'btnEditar
        '
        Me.btnEditar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnEditar.Appearance.Options.UseFont = True
        Me.btnEditar.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditar.AppearanceHovered.Options.UseBackColor = True
        Me.btnEditar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnEditar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEditar.ImageOptions.Image = CType(resources.GetObject("btnEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnEditar.Location = New System.Drawing.Point(461, 147)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(154, 36)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "&Editar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNuevo.AppearanceHovered.Options.UseBackColor = True
        Me.btnNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnNuevo.ImageOptions.Image = CType(resources.GetObject("btnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnNuevo.Location = New System.Drawing.Point(464, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(105, 36)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "&NUEVO"
        '
        'btnRecargar
        '
        Me.btnRecargar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargar.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnRecargar.Appearance.Options.UseFont = True
        Me.btnRecargar.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRecargar.AppearanceHovered.Options.UseBackColor = True
        Me.btnRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnRecargar.ImageOptions.Image = CType(resources.GetObject("btnRecargar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRecargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRecargar.Location = New System.Drawing.Point(461, 189)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(154, 36)
        Me.btnRecargar.TabIndex = 7
        Me.btnRecargar.Text = "&RECARGAR"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.AppearanceHovered.Options.UseBackColor = True
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnGuardar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnGuardar.Location = New System.Drawing.Point(464, 52)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 36)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&GUARDAR"
        '
        'TsEstado
        '
        Me.TsEstado.Location = New System.Drawing.Point(89, 96)
        Me.TsEstado.Name = "TsEstado"
        Me.TsEstado.Properties.LookAndFeel.SkinName = "The Bezier"
        Me.TsEstado.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TsEstado.Properties.OffText = "Inactivo"
        Me.TsEstado.Properties.OnText = "Activo"
        Me.TsEstado.Size = New System.Drawing.Size(108, 20)
        Me.TsEstado.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(89, 43)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Properties.MaxLength = 25
        Me.txtCodigo.Size = New System.Drawing.Size(226, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Tabla:"
        '
        'txtTabla
        '
        Me.txtTabla.Location = New System.Drawing.Point(89, 19)
        Me.txtTabla.Name = "txtTabla"
        Me.txtTabla.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabla.Properties.MaxLength = 25
        Me.txtTabla.Size = New System.Drawing.Size(226, 20)
        Me.txtTabla.TabIndex = 1
        '
        'btnBuscarTabla
        '
        Me.btnBuscarTabla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnBuscarTabla.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnBuscarTabla.ImageOptions.SvgImage = CType(resources.GetObject("btnBuscarTabla.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnBuscarTabla.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btnBuscarTabla.Location = New System.Drawing.Point(330, 20)
        Me.btnBuscarTabla.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnBuscarTabla.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscarTabla.Name = "btnBuscarTabla"
        Me.btnBuscarTabla.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarTabla.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Valor:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(89, 68)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Properties.MaxLength = 25
        Me.txtValor.Size = New System.Drawing.Size(226, 20)
        Me.txtValor.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTabla)
        Me.GroupBox1.Controls.Add(Me.btnBuscarTabla)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TsEstado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(15, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 139)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'FCATALOGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(627, 364)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.grid_view)
        Me.Name = "FCATALOGO"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CATÁLOGOS DE TABLAS"
        CType(Me.grid_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_gridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTabla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_view As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd_gridview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRecargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TsEstado As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTabla As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscarTabla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colca_tabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents calca_codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colca_valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colca_estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents colca_catalogo As DevExpress.XtraGrid.Columns.GridColumn
End Class
