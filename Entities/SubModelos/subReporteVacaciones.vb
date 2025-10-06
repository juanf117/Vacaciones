Public Class subReporteVacaciones
    Public Property idControlVacaciones As Integer
    Public Property idEmpleado As Integer
    Public Property Mes As String
    Public Property MesNumero As Integer
    Public Property Anno As Integer
    Public Property FechaInicio As Nullable(Of Date)
    Public Property FechaFin As Nullable(Of Date)
    Public Property DiasGanados As Nullable(Of Double)
    Public Property DiasDescansados As Nullable(Of Double)
    Public Property Disponibles As Nullable(Of Double)
    Public Property Activo As Nullable(Of Boolean)
    Public Property NombreCompleto As String
    Public Property NumIdentificacion As String
    Public Property FechaIngreso As Nullable(Of Date)
    Public Property DescTipoIdentificacion As String
End Class
