' ' Description: Submodelo para representar información básica de un empleado.
Public Class subEmpleado
    Public Property idEmpleado As Integer
    Public Property NombreCompleto As String
    Public Property idTipoIdentificacion As Short
    Public Property DescTipoIdentificacion As String
    Public Property NumIdentificacion As String
    Public Property FechaIngreso As Nullable(Of Date)
    Public Property SalarioBase As Nullable(Of Decimal)
    Public Property Direccion As String
    Public Property Activo As Nullable(Of Boolean)
End Class
