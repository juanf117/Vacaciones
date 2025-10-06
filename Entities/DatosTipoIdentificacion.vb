Imports System.Collections.Generic
Imports System.Linq
Imports DB
Public Class DatosTipoIdentificacion
    Public Shared Function ObtenerTiposIdentificacion() As List(Of subTipoIdentificacion)
        Using db As New VacacionesEntities()
            Return db.TipoIdentificacion.Where(Function(t) t.Activo = True).Select(Function(t) New subTipoIdentificacion With {.idTipoIdentificacion = t.idTipoIdentificacion,
                                                                                       .DescTipoIdentificacion = t.DescTipoIdentificacion}).ToList()
        End Using
    End Function
End Class
