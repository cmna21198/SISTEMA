<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRELACION_CATALOGO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRELACION_CATALOGO))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.tsEsPadre = New DevExpress.XtraEditors.ToggleSwitch()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tsestado = New DevExpress.XtraEditors.ToggleSwitch()
        Me.btnBuscarTabla_3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarTabla_2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarTabla_1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarTabla_0 = New DevExpress.XtraEditors.SimpleButton()
        Me.txttblprincipal = New System.Windows.Forms.TextBox()
        Me.txtcatalogoprinc = New System.Windows.Forms.TextBox()
        Me.txtblpadre = New System.Windows.Forms.TextBox()
        Me.txtcatalogopadre = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRecargar = New DevExpress.XtraEditors.SimpleButton()
        Me.grdcTablas = New DevExpress.XtraGrid.GridControl()
        Me.grdvTablas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrel_TablaPadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_ca_tabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_catalogo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_catalogorelac = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_tabla_princ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_padre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_ta_nom_tabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_ca_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_ca_valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrel_Nivel = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tsEsPadre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsestado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImageOptions.SvgImage = CType(resources.GetObject("GroupControl1.CaptionImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.GroupControl1.CaptionImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.GroupControl1.Controls.Add(Me.tsEsPadre)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.tsestado)
        Me.GroupControl1.Controls.Add(Me.btnBuscarTabla_3)
        Me.GroupControl1.Controls.Add(Me.btnBuscarTabla_2)
        Me.GroupControl1.Controls.Add(Me.btnBuscarTabla_1)
        Me.GroupControl1.Controls.Add(Me.btnBuscarTabla_0)
        Me.GroupControl1.Controls.Add(Me.txttblprincipal)
        Me.GroupControl1.Controls.Add(Me.txtcatalogoprinc)
        Me.GroupControl1.Controls.Add(Me.txtblpadre)
        Me.GroupControl1.Controls.Add(Me.txtcatalogopadre)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2013"
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(474, 185)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = " Ingreso de datos"
        '
        'tsEsPadre
        '
        Me.tsEsPadre.Location = New System.Drawing.Point(149, 78)
        Me.tsEsPadre.Name = "tsEsPadre"
        Me.tsEsPadre.Properties.LookAndFeel.SkinName = "The Bezier"
        Me.tsEsPadre.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.tsEsPadre.Properties.OffText = "No"
        Me.tsEsPadre.Properties.OnText = "Si"
        Me.tsEsPadre.Size = New System.Drawing.Size(115, 20)
        Me.tsEsPadre.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Es padre?"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsestado
        '
        Me.tsestado.Location = New System.Drawing.Point(149, 156)
        Me.tsestado.Name = "tsestado"
        Me.tsestado.Properties.LookAndFeel.SkinName = "The Bezier"
        Me.tsestado.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.tsestado.Properties.OffText = "Inactivo"
        Me.tsestado.Properties.OnText = "Activo"
        Me.tsestado.Size = New System.Drawing.Size(115, 20)
        Me.tsestado.TabIndex = 22
        '
        'btnBuscarTabla_3
        '
        Me.btnBuscarTabla_3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnBuscarTabla_3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnBuscarTabla_3.ImageOptions.SvgImage = CType(resources.GetObject("btnBuscarTabla_3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnBuscarTabla_3.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btnBuscarTabla_3.Location = New System.Drawing.Point(304, 131)
        Me.btnBuscarTabla_3.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnBuscarTabla_3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscarTabla_3.Name = "btnBuscarTabla_3"
        Me.btnBuscarTabla_3.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarTabla_3.TabIndex = 21
        '
        'btnBuscarTabla_2
        '
        Me.btnBuscarTabla_2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnBuscarTabla_2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnBuscarTabla_2.ImageOptions.SvgImage = CType(resources.GetObject("btnBuscarTabla_2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnBuscarTabla_2.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btnBuscarTabla_2.Location = New System.Drawing.Point(304, 105)
        Me.btnBuscarTabla_2.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnBuscarTabla_2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscarTabla_2.Name = "btnBuscarTabla_2"
        Me.btnBuscarTabla_2.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarTabla_2.TabIndex = 20
        '
        'btnBuscarTabla_1
        '
        Me.btnBuscarTabla_1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnBuscarTabla_1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnBuscarTabla_1.ImageOptions.SvgImage = CType(resources.GetObject("btnBuscarTabla_1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnBuscarTabla_1.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btnBuscarTabla_1.Location = New System.Drawing.Point(304, 56)
        Me.btnBuscarTabla_1.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnBuscarTabla_1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscarTabla_1.Name = "btnBuscarTabla_1"
        Me.btnBuscarTabla_1.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarTabla_1.TabIndex = 19
        '
        'btnBuscarTabla_0
        '
        Me.btnBuscarTabla_0.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnBuscarTabla_0.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnBuscarTabla_0.ImageOptions.SvgImage = CType(resources.GetObject("btnBuscarTabla_0.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnBuscarTabla_0.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btnBuscarTabla_0.Location = New System.Drawing.Point(304, 30)
        Me.btnBuscarTabla_0.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnBuscarTabla_0.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscarTabla_0.Name = "btnBuscarTabla_0"
        Me.btnBuscarTabla_0.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarTabla_0.TabIndex = 18
        '
        'txttblprincipal
        '
        Me.txttblprincipal.Location = New System.Drawing.Point(149, 29)
        Me.txttblprincipal.Name = "txttblprincipal"
        Me.txttblprincipal.Size = New System.Drawing.Size(149, 21)
        Me.txttblprincipal.TabIndex = 17
        Me.txttblprincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcatalogoprinc
        '
        Me.txtcatalogoprinc.Location = New System.Drawing.Point(149, 55)
        Me.txtcatalogoprinc.Name = "txtcatalogoprinc"
        Me.txtcatalogoprinc.Size = New System.Drawing.Size(149, 21)
        Me.txtcatalogoprinc.TabIndex = 16
        Me.txtcatalogoprinc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtblpadre
        '
        Me.txtblpadre.Location = New System.Drawing.Point(149, 104)
        Me.txtblpadre.Name = "txtblpadre"
        Me.txtblpadre.Size = New System.Drawing.Size(149, 21)
        Me.txtblpadre.TabIndex = 15
        Me.txtblpadre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcatalogopadre
        '
        Me.txtcatalogopadre.Location = New System.Drawing.Point(149, 130)
        Me.txtcatalogopadre.Name = "txtcatalogopadre"
        Me.txtcatalogopadre.Size = New System.Drawing.Size(149, 21)
        Me.txtcatalogopadre.TabIndex = 14
        Me.txtcatalogopadre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnNuevo.Location = New System.Drawing.Point(364, 30)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(105, 36)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "&NUEVO"
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
        Me.btnGuardar.Location = New System.Drawing.Point(364, 72)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 36)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "&GUARDAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ESTADO:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CATÁLOGO PADRE:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TABLA PADRE:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CATÁLOGO PRINCIPAL:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TABLA PRINCIPAL:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnEditar.Location = New System.Drawing.Point(376, 203)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(110, 36)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "&Editar"
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
        Me.btnRecargar.Location = New System.Drawing.Point(376, 245)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(110, 36)
        Me.btnRecargar.TabIndex = 12
        Me.btnRecargar.Text = "&RECARGAR"
        '
        'grdcTablas
        '
        Me.grdcTablas.Location = New System.Drawing.Point(14, 203)
        Me.grdcTablas.MainView = Me.grdvTablas
        Me.grdcTablas.Name = "grdcTablas"
        Me.grdcTablas.Size = New System.Drawing.Size(346, 206)
        Me.grdcTablas.TabIndex = 13
        Me.grdcTablas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvTablas})
        '
        'grdvTablas
        '
        Me.grdvTablas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrel_TablaPadre, Me.colrel_ca_tabla, Me.colrel_catalogo, Me.colrel_catalogorelac, Me.colrel_tabla_princ, Me.colrel_padre, Me.colrel_ta_nom_tabla, Me.colrel_ca_codigo, Me.colrel_ca_valor, Me.colrel_Nivel})
        GridFormatRule1.Name = "Estado"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Appearance.Options.UseTextOptions = True
        FormatConditionRuleExpression1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        FormatConditionRuleExpression1.Expression = "[ta_estado] = 'I'"
        FormatConditionRuleExpression1.PredefinedName = "Bold Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression2.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression2.Expression = "[ta_estado] = 'A'"
        FormatConditionRuleExpression2.PredefinedName = "Bold Text"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.grdvTablas.FormatRules.Add(GridFormatRule1)
        Me.grdvTablas.FormatRules.Add(GridFormatRule2)
        Me.grdvTablas.GridControl = Me.grdcTablas
        Me.grdvTablas.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grdvTablas.Name = "grdvTablas"
        Me.grdvTablas.OptionsBehavior.Editable = False
        Me.grdvTablas.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdvTablas.OptionsFind.AlwaysVisible = True
        Me.grdvTablas.OptionsView.ShowGroupPanel = False
        '
        'colrel_TablaPadre
        '
        Me.colrel_TablaPadre.Caption = "Tabla Vinculada"
        Me.colrel_TablaPadre.FieldName = "rel_TablaPadre"
        Me.colrel_TablaPadre.Name = "colrel_TablaPadre"
        Me.colrel_TablaPadre.Visible = True
        Me.colrel_TablaPadre.VisibleIndex = 0
        '
        'colrel_ca_tabla
        '
        Me.colrel_ca_tabla.Caption = "rel_ca_tabla"
        Me.colrel_ca_tabla.FieldName = "rel_ca_tabla"
        Me.colrel_ca_tabla.Name = "colrel_ca_tabla"
        '
        'colrel_catalogo
        '
        Me.colrel_catalogo.Caption = "rel_catalogo"
        Me.colrel_catalogo.FieldName = "rel_catalogo"
        Me.colrel_catalogo.Name = "colrel_catalogo"
        '
        'colrel_catalogorelac
        '
        Me.colrel_catalogorelac.Caption = "rel_catalogorelac"
        Me.colrel_catalogorelac.FieldName = "rel_catalogorelac"
        Me.colrel_catalogorelac.Name = "colrel_catalogorelac"
        '
        'colrel_tabla_princ
        '
        Me.colrel_tabla_princ.Caption = "rel_tabla_princ"
        Me.colrel_tabla_princ.FieldName = "rel_tabla_princ"
        Me.colrel_tabla_princ.Name = "colrel_tabla_princ"
        '
        'colrel_padre
        '
        Me.colrel_padre.Caption = "rel_padre"
        Me.colrel_padre.FieldName = "rel_padre"
        Me.colrel_padre.Name = "colrel_padre"
        '
        'colrel_ta_nom_tabla
        '
        Me.colrel_ta_nom_tabla.Caption = "rel_ta_nom_tabla"
        Me.colrel_ta_nom_tabla.FieldName = "rel_ta_nom_tabla"
        Me.colrel_ta_nom_tabla.Name = "colrel_ta_nom_tabla"
        Me.colrel_ta_nom_tabla.Visible = True
        Me.colrel_ta_nom_tabla.VisibleIndex = 1
        '
        'colrel_ca_codigo
        '
        Me.colrel_ca_codigo.Caption = "rel_ca_codigo"
        Me.colrel_ca_codigo.FieldName = "rel_ca_codigo"
        Me.colrel_ca_codigo.Name = "colrel_ca_codigo"
        Me.colrel_ca_codigo.Visible = True
        Me.colrel_ca_codigo.VisibleIndex = 2
        '
        'colrel_ca_valor
        '
        Me.colrel_ca_valor.Caption = "rel_ca_valor"
        Me.colrel_ca_valor.FieldName = "rel_ca_valor"
        Me.colrel_ca_valor.Name = "colrel_ca_valor"
        Me.colrel_ca_valor.Visible = True
        Me.colrel_ca_valor.VisibleIndex = 3
        '
        'colrel_Nivel
        '
        Me.colrel_Nivel.Caption = "rel_Nivel"
        Me.colrel_Nivel.FieldName = "rel_Nivel"
        Me.colrel_Nivel.Name = "colrel_Nivel"
        Me.colrel_Nivel.Visible = True
        Me.colrel_Nivel.VisibleIndex = 4
        '
        'FRELACION_CATALOGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(502, 421)
        Me.Controls.Add(Me.grdcTablas)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnRecargar)
        Me.Name = "FRELACION_CATALOGO"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RELACIONES DE CATÁLOGOS"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tsEsPadre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsestado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdcTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRecargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txttblprincipal As TextBox
    Friend WithEvents txtcatalogoprinc As TextBox
    Friend WithEvents txtblpadre As TextBox
    Friend WithEvents txtcatalogopadre As TextBox
    Friend WithEvents tsestado As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents btnBuscarTabla_3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarTabla_2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarTabla_1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarTabla_0 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdcTablas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvTablas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tsEsPadre As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents Label6 As Label
    Friend WithEvents colrel_TablaPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_ca_tabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_catalogo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_catalogorelac As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_tabla_princ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_padre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_ta_nom_tabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_ca_codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_ca_valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrel_Nivel As DevExpress.XtraGrid.Columns.GridColumn
End Class
