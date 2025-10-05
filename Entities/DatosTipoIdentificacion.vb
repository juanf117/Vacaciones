Imports System.Collections.Generic
Imports System.Linq
Imports DB
Public Class DatosTipoIdentificacion
    Public Shared Function ObtenerTiposIdentificacion() As List(Of TipoIdentificacion)
        Using db As New VacacionesEntities()
            Return db.TipoIdentificacion.Where(Function(t) t.Activo = True).ToList()
        End Using
    End Function
End Class
