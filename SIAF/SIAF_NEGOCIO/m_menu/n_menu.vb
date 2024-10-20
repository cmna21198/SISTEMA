Imports SIAF_DATOS
Public Class n_menu
    Dim me_menu As New m_menu
    Public Function FL_MENU_LISTA() As List(Of ClaseCompuesta.me_menu)
        Return me_menu.FL_MENU().ToList()
    End Function
End Class
