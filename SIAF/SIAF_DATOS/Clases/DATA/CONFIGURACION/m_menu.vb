Public Class m_menu
    Public Function FL_MENU() As List(Of ClaseCompuesta.me_menu)
        Using Db As New SISTEMAEntities
            Dim query = (From menu In Db.cl_menu
                         Select New ClaseCompuesta.me_menu With {
                            .me_idmenu = menu.me_idmenu,
                            .me_idsubmenu = menu.me_idsubmenu,
                            .me_producto = menu.me_producto,
                            .me_padre = menu.me_padre,
                            .me_tipo_obj = menu.me_tipo_obj,
                            .me_nom_objeto = menu.me_nom_objeto,
                            .me_caption = menu.me_caption,
                            .me_rute_web = menu.me_rute_web,
                            .me_nom_icono = menu.me_nom_icono,
                            .me_ruta_icono_desa = menu.me_ruta_icono_desa,
                            .me_ruta_icono_prod = menu.me_ruta_icono_prod,
                            .me_estado = menu.me_estado
            }).ToList()
            Return query
        End Using
    End Function
End Class

