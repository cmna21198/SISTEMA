Imports SIAF_DATOS
Public Class n_tabla
    Dim ta_tablas As New t_tabla
    Public Function FMapeaTablas(i_ta_tabla As Nullable(Of Integer), i_ta_nom_tabla As String, i_ta_des_tabla As String,
                                 i_ta_estado_tabla As String, i_ca_codigo As String, i_ca_valor As String, i_ca_estado As String,
                                 i_opcion As String, i_pantalla As String, i_usuario As String, i_siguiente As Nullable(Of Short), i_catalogo As Nullable(Of Short), i_modo As Nullable(Of Byte)) As List(Of ClaseCompuesta.ta_tablas)
        Return ta_tablas.FMapeaTablas(i_ta_tabla, i_ta_nom_tabla, i_ta_des_tabla,
                                 i_ta_estado_tabla, i_ca_codigo, i_ca_valor, i_ca_estado, i_opcion, i_pantalla, i_usuario, i_siguiente, i_catalogo, i_modo).ToList

    End Function
End Class
