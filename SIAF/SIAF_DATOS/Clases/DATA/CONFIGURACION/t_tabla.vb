Public Class t_tabla
    Public Function FMapeaTablas(i_ta_tabla As Nullable(Of Integer), i_ta_nom_tabla As String, i_ta_des_tabla As String,
                                 i_ta_estado_tabla As String, i_ca_codigo As String, i_ca_valor As String, i_ca_estado As String,
                                 i_opcion As String, i_pantalla As String, i_usuario As String,
                                 i_siguiente As Nullable(Of Short), i_catalogo As Nullable(Of Short), i_modo As Nullable(Of Byte)) As List(Of ClaseCompuesta.ta_tablas)

        Try
            Using SIAF As New SISTEMAEntities
                Dim query = (From r In SIAF.pa_tabla_catalogo_mantenimiento(i_ta_tabla, i_ta_nom_tabla, i_ta_des_tabla,
                                 i_ta_estado_tabla, i_ca_codigo, i_ca_valor, i_ca_estado, i_opcion, i_pantalla, i_usuario, i_siguiente, i_catalogo, i_modo)
                             Select New ClaseCompuesta.ta_tablas With
                            {
                                      .ta_tabla = r.ta_tabla,
                                      .ta_nom_tabla = r.ta_nom_tabla,
                                      .ta_descripcion = r.ta_descripcion,
                                      .ta_estado = r.ta_estado,
                                      .ca_tabla = r.ca_tabla,
                                       .ca_catalogo = r.ca_catalogo,
                                      .ca_codigo = r.ca_codigo,
                                      .ca_valor = r.ca_valor,
                                      .ca_estado = r.ca_estado,
                                      .men_proceso = r.men_proceso,
                                      .men_numero = r.men_numero,
                                      .men_mensaje = r.men_mensaje,
                                      .men_fecha_adicion = r.men_fecha_adicion,
                                      .men_usuario_crea = r.men_usuario_crea,
                                      .men_fecha_modifica = r.men_fecha_modifica,
                                      .men_usuario_modifica = r.men_usuario_modifica,
                                      .men_estado = r.men_estado,
                                      .er_numero = r.er_numero,
                                      .er_descripcion = r.er_descripcion,
                                      .er_gravedad = r.er_gravedad,
                                      .er_solucion = r.er_solucion,
                                      .er_fecha_adicion = r.er_fecha_adicion,
                                      .er_usuario_crea = r.er_usuario_crea,
                                      .er_fecha_modifica = r.er_fecha_modifica,
                                      .er_usuario_modifica = r.er_usuario_modifica,
                                      .er_estado = r.er_estado
                             }).ToList()



                Return query
            End Using

        Catch ex As Exception
            ValidaConexion.MensajesDeErrores(ex)
        End Try
    End Function
    'Public Function FRELACIONCATALOGOS()

    'End Function
End Class
