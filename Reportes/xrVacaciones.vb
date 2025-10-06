Imports Datos

Public Class xrVacaciones
    Public Sub parametro(idEmpleado As Integer)
        Me.DataSource = DatosControlVacaciones.ReporteVacaciones(idEmpleado)

        Dim subreport As New xrVacacionesDescansadas()
        subreport.parametro(idEmpleado)

        subVacacionesDescansadas.ReportSource = subreport

        Me.CreateDocument()


    End Sub

End Class