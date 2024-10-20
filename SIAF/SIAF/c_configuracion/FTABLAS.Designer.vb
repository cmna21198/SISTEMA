<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTABLAS
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FTABLAS))
        Me.colta_estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdcTablas = New DevExpress.XtraGrid.GridControl()
        Me.grdvTablas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTa_tabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colta_nom_tabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colta_descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRecargar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTabla = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesc_tabla = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblContString = New System.Windows.Forms.Label()
        Me.TsEstado = New DevExpress.XtraEditors.ToggleSwitch()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsiguiente = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.grdcTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTabla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'colta_estado
        '
        Me.colta_estado.AppearanceCell.Options.UseTextOptions = True
        Me.colta_estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colta_estado.Caption = "Estado"
        Me.colta_estado.FieldName = "ta_estado"
        Me.colta_estado.Name = "colta_estado"
        Me.colta_estado.Visible = True
        Me.colta_estado.VisibleIndex = 2
        '
        'grdcTablas
        '
        Me.grdcTablas.Location = New System.Drawing.Point(15, 159)
        Me.grdcTablas.MainView = Me.grdvTablas
        Me.grdcTablas.Name = "grdcTablas"
        Me.grdcTablas.Size = New System.Drawing.Size(440, 336)
        Me.grdcTablas.TabIndex = 0
        Me.grdcTablas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvTablas})
        '
        'grdvTablas
        '
        Me.grdvTablas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTa_tabla, Me.colta_nom_tabla, Me.colta_descripcion, Me.colta_estado})
        GridFormatRule1.Column = Me.colta_estado
        GridFormatRule1.ColumnApplyTo = Me.colta_estado
        GridFormatRule1.Name = "Estado"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Appearance.Options.UseTextOptions = True
        FormatConditionRuleExpression1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        FormatConditionRuleExpression1.Expression = "[ta_estado] = 'I'"
        FormatConditionRuleExpression1.PredefinedName = "Bold Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.Column = Me.colta_estado
        GridFormatRule2.ColumnApplyTo = Me.colta_estado
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
        Me.grdvTablas.Name = "grdvTablas"
        Me.grdvTablas.OptionsBehavior.Editable = False
        Me.grdvTablas.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdvTablas.OptionsFind.AlwaysVisible = True
        Me.grdvTablas.OptionsView.ShowGroupPanel = False
        '
        'colTa_tabla
        '
        Me.colTa_tabla.Caption = "IdTabla"
        Me.colTa_tabla.FieldName = "ta_tabla"
        Me.colTa_tabla.Name = "colTa_tabla"
        Me.colTa_tabla.OptionsColumn.ReadOnly = True
        '
        'colta_nom_tabla
        '
        Me.colta_nom_tabla.Caption = "Nombre tabla"
        Me.colta_nom_tabla.FieldName = "ta_nom_tabla"
        Me.colta_nom_tabla.Name = "colta_nom_tabla"
        Me.colta_nom_tabla.Visible = True
        Me.colta_nom_tabla.VisibleIndex = 0
        '
        'colta_descripcion
        '
        Me.colta_descripcion.Caption = "Descripción"
        Me.colta_descripcion.FieldName = "ta_descripcion"
        Me.colta_descripcion.Name = "colta_descripcion"
        Me.colta_descripcion.Visible = True
        Me.colta_descripcion.VisibleIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.AppearanceHovered.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnGuardar.AppearanceHovered.Options.UseBackColor = True
        Me.btnGuardar.AppearanceHovered.Options.UseFont = True
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnGuardar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnGuardar.Location = New System.Drawing.Point(482, 52)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 29)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "&GUARDAR"
        '
        'btnRecargar
        '
        Me.btnRecargar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargar.Appearance.Options.UseFont = True
        Me.btnRecargar.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRecargar.AppearanceHovered.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargar.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnRecargar.AppearanceHovered.Options.UseBackColor = True
        Me.btnRecargar.AppearanceHovered.Options.UseFont = True
        Me.btnRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnRecargar.ImageOptions.Image = CType(resources.GetObject("btnRecargar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRecargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnRecargar.Location = New System.Drawing.Point(460, 212)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(148, 47)
        Me.btnRecargar.TabIndex = 4
        Me.btnRecargar.Text = "&RECARGAR REGISTROS"
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNuevo.AppearanceHovered.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnNuevo.AppearanceHovered.Options.UseBackColor = True
        Me.btnNuevo.AppearanceHovered.Options.UseFont = True
        Me.btnNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnNuevo.ImageOptions.Image = CType(resources.GetObject("btnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnNuevo.Location = New System.Drawing.Point(482, 16)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(108, 29)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "&Nuevo"
        '
        'txtTabla
        '
        Me.txtTabla.Location = New System.Drawing.Point(187, 20)
        Me.txtTabla.Name = "txtTabla"
        Me.txtTabla.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabla.Properties.MaxLength = 25
        Me.txtTabla.Size = New System.Drawing.Size(274, 20)
        Me.txtTabla.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre de tabla:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción de la tabla:"
        '
        'txtDesc_tabla
        '
        Me.txtDesc_tabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc_tabla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc_tabla.Location = New System.Drawing.Point(187, 51)
        Me.txtDesc_tabla.MaxLength = 150
        Me.txtDesc_tabla.Multiline = True
        Me.txtDesc_tabla.Name = "txtDesc_tabla"
        Me.txtDesc_tabla.Size = New System.Drawing.Size(274, 47)
        Me.txtDesc_tabla.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Estado:"
        '
        'lblContString
        '
        Me.lblContString.AutoSize = True
        Me.lblContString.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContString.ForeColor = System.Drawing.Color.DarkRed
        Me.lblContString.Location = New System.Drawing.Point(411, 101)
        Me.lblContString.Name = "lblContString"
        Me.lblContString.Size = New System.Drawing.Size(22, 14)
        Me.lblContString.TabIndex = 10
        Me.lblContString.Text = "0/0"
        '
        'TsEstado
        '
        Me.TsEstado.Location = New System.Drawing.Point(92, 118)
        Me.TsEstado.Name = "TsEstado"
        Me.TsEstado.Properties.LookAndFeel.SkinName = "The Bezier"
        Me.TsEstado.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TsEstado.Properties.OffText = "Inactivo"
        Me.TsEstado.Properties.OnText = "Activo"
        Me.TsEstado.Size = New System.Drawing.Size(108, 20)
        Me.TsEstado.TabIndex = 2
        '
        'btnEditar
        '
        Me.btnEditar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Appearance.Options.UseFont = True
        Me.btnEditar.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditar.AppearanceHovered.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnEditar.AppearanceHovered.Options.UseBackColor = True
        Me.btnEditar.AppearanceHovered.Options.UseFont = True
        Me.btnEditar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnEditar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEditar.ImageOptions.Image = CType(resources.GetObject("btnEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(460, 159)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(148, 47)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "&Editar"
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsiguiente.Appearance.Options.UseFont = True
        Me.btnsiguiente.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnsiguiente.AppearanceHovered.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsiguiente.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.btnsiguiente.AppearanceHovered.Options.UseBackColor = True
        Me.btnsiguiente.AppearanceHovered.Options.UseFont = True
        Me.btnsiguiente.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnsiguiente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnsiguiente.ImageOptions.Image = CType(resources.GetObject("btnsiguiente.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsiguiente.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnsiguiente.Location = New System.Drawing.Point(466, 428)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(142, 47)
        Me.btnsiguiente.TabIndex = 12
        Me.btnsiguiente.Text = "&Siguentes"
        Me.btnsiguiente.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTabla)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.TsEstado)
        Me.GroupBox1.Controls.Add(Me.txtDesc_tabla)
        Me.GroupBox1.Controls.Add(Me.lblContString)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 150)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'FTABLAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(620, 507)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.grdcTablas)
        Me.Name = "FTABLAS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TABLAS"
        CType(Me.grdcTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTabla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdcTablas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvTablas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRecargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTabla As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesc_tabla As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblContString As Label
    Friend WithEvents TsEstado As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsiguiente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTa_tabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colta_nom_tabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colta_descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colta_estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
