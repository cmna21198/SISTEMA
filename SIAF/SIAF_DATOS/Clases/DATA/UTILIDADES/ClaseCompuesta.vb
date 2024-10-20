Public Class ClaseCompuesta
    Public Class ta_tablas
        Public Property ta_tabla As Nullable(Of Integer)
        Public Property ta_nom_tabla As String
        Public Property ta_descripcion As String
        Public Property ta_estado As String
        Public Property ca_tabla As Nullable(Of Integer)
        Public Property ca_catalogo As Short
        Public Property ca_codigo As String
        Public Property ca_valor As String
        Public Property ca_estado As String
        Public Property men_proceso As Nullable(Of Integer)
        Public Property men_numero As Nullable(Of Short)
        Public Property men_mensaje As String
        Public Property men_fecha_adicion As Nullable(Of Date)
        Public Property men_usuario_crea As String
        Public Property men_fecha_modifica As Nullable(Of Date)
        Public Property men_usuario_modifica As String
        Public Property men_estado As String
        Public Property er_numero As Nullable(Of Long)
        Public Property er_descripcion As String
        Public Property er_gravedad As Nullable(Of Byte)
        Public Property er_solucion As String
        Public Property er_fecha_adicion As Nullable(Of Date)
        Public Property er_usuario_crea As String
        Public Property er_fecha_modifica As Nullable(Of Date)
        Public Property er_usuario_modifica As String
        Public Property er_estado As String
    End Class
    Public Class me_menu
        Public Property me_idmenu As Short
        Public Property me_idsubmenu As Short
        Public Property me_producto As Nullable(Of Integer)
        Public Property me_transaccion As Nullable(Of Integer)
        Public Property me_padre As Nullable(Of Short)
        Public Property me_tipo_obj As Nullable(Of Byte)
        Public Property me_nom_objeto As String
        Public Property me_caption As String
        Public Property me_rute_web As String
        Public Property me_nom_icono As String
        Public Property me_ruta_icono_desa As String
        Public Property me_ruta_icono_prod As String
        Public Property me_estado As String

    End Class
    Public Class Ensamblados
        Public Tipo As String
        Public Nombre As String
    End Class
End Class
