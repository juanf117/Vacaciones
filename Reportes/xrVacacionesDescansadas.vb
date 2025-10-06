Imports Datos

Public Class xrVacacionesDescansadas
    Public Sub parametro(idEmpleado As Integer)
        Me.DataSource = DatosVacacionesDescansadas.ObtenerVacacionesDescansadas(idEmpleado)
        Me.CreateDocument()
    End Sub
End Class