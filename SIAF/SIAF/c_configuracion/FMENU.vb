﻿Imports SIAF_DATOS
Imports SIAF_NEGOCIO


Public Class FMENU
    Dim oMenuStrip As New MenuStrip()
    Dim VGLMENU As New List(Of ClaseCompuesta.me_menu) : Dim _menu As New n_menu
    Dim VGLENSAM As New List(Of ClaseCompuesta.Ensamblados)

#Region "Eventos de Menu"
    Private Sub FMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aquí se programó para obtener todos los formularios de la app
        Dim ass = System.Reflection.Assembly.GetExecutingAssembly()
        For Each t As Type In ass.GetTypes().Where(Function(x) x.BaseType.Name = "Form")
            If t.BaseType.Name = "Form" Then
                Dim ensamblado As New ClaseCompuesta.Ensamblados
                With ensamblado
                    .Tipo = t.BaseType.Name
                    .Nombre = t.Name
                End With
                VGLENSAM.Add(ensamblado)
            End If
        Next

        Dim oListaMenu As New List(Of Menu)
        VGLMENU = _menu.FL_MENU_LISTA().ToList()

        For Each _Item In VGLMENU.Where(Function(x) x.me_idmenu >= 1 And x.me_tipo_obj = 1 And x.me_padre = 0 And x.me_estado = "A")

            Dim oMenuItem As New ToolStripMenuItem(_Item.me_caption, Nothing, New EventHandler(AddressOf EventoMenu), _Item.me_nom_objeto)

            For Each Menu2 In VGLMENU.Where(Function(x) x.me_idmenu >= 1 And x.me_tipo_obj = 1 And x.me_padre = _Item.me_idmenu And x.me_estado = "A")
                Dim oSubMenuItem As New ToolStripMenuItem(Menu2.me_caption, Nothing, New EventHandler(AddressOf EventoMenu), Menu2.me_nom_objeto)
                oMenuItem.DropDownItems.Add(oSubMenuItem)
            Next
            oMenuStrip.Items.Add(oMenuItem)
        Next
        Me.MainMenuStrip = oMenuStrip
        Me.Controls.Add(oMenuStrip)
    End Sub

    Private Sub EventoMenu(sender As Object, e As EventArgs)
        If sender.Name.ToString <> "" Then
            If Not VGLENSAM.Find(Function(x) x.Nombre = sender.Name.ToString) Is Nothing Then
                mostrarForm(sender.Name)
            End If
        Else
            MsgBox("ERROR EN GENERACIÓN DE MENÚ", MsgBoxStyle.Critical, "ERROR:")
        End If
    End Sub

#End Region

#Region "MÉTODOS DINÁMICOS"
    Public Sub llamarform(ByVal formulario As Form, ByVal mdi As Form)
        Dim frmllamado As Form
        Dim escargado As Boolean = False
        Try
            'chequemos si el formulario ha sido cargado
            For Each frmllamado In mdi.MdiChildren
                'Compara si es igual y retorna verdadero si lo es.
                If frmllamado.Text = formulario.Text Then
                    'Marca la bandera
                    escargado = True
                    'Sale del loop si es verdadero
                    Exit For
                End If
            Next

            If Not escargado Then
                'Carga el formulario si no esta llamado
                formulario.MdiParent = mdi
                formulario.Show()
            ElseIf escargado Then
                'Enfoca el objeto
                frmllamado.Focus()
            End If

            'Nada que hacer, toca colocar la exception
        Catch ex As Exception
            'Mostrar mensaje
            MsgBox(ex.Message & vbCrLf & ex.Source & vbCrLf &
                   ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
        'Limpiar todo
        formulario = Nothing
        frmllamado = Nothing
    End Sub
    Private Sub mostrarForm(ByVal nombreform As String)
        'Creamos una variable tipo Form
        Dim frmdinamico As Form
        'Extraemos toda la información necesaria para poder pasar
        'con el solo nombre del formulario a la variable "frmdinamico", el objeto
        frmdinamico = AppDomain.CurrentDomain.CreateInstanceAndUnwrap(
                      Me.GetType.Assembly.GetName.Name,
        System.String.Concat(Me.GetType.Assembly.GetName.Name, ".", nombreform))
        'Llamamos la rutina que no permitira abrir 2 veces el formulario
        llamarform(frmdinamico, Me)
    End Sub
#End Region


End Class

