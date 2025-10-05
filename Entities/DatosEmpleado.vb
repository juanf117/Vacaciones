Imports System.Collections.Generic
Imports System.Linq
Imports DB
Public Class DatosEmpleado
    ' Función para obtener la lista de empleados activos
    Public Shared Function ObtenerEmpleados() As List(Of subEmpleado)
        Dim DB = New DB.VacacionesEntities()
        Return DB.Empleado.Where(Function(e) e.Activo = True).Select(Function(e) New subEmpleado With {.idEmpleado = e.idEmpleado, .NombreCompleto = e.NombreCompleto,
                                                                         .DescTipoIdentificacion = e.TipoIdentificacion.DescTipoIdentificacion, .idTipoIdentificacion = e.idTipoIdentificacion,
                                                                         .NumIdentificacion = e.NumIdentificacion, .FechaIngreso = e.FechaIngreso, .SalarioBase = e.SalarioBase,
                                                                         .Direccion = e.Direccion, .Activo = e.Activo}).ToList()
    End Function

    ' Función para insertar un nuevo empleado
    Public Shared Sub InsertarEmpleado(nombreCompleto As String, idTipoIdentificacion As Integer, numIdentificacion As String,
                                           fechaIngreso As Date, salarioBase As Decimal, direccion As String)
        Dim DB = New DB.VacacionesEntities()
        DB.sp_insert_empleado(nombreCompleto, idTipoIdentificacion, numIdentificacion, fechaIngreso, salarioBase, direccion)
    End Sub

    ' Función para actualizar un  empleado
    Public Shared Sub EditarEmpleado(idEmpleado As Integer, nombreCompleto As String, idTipoIdentificacion As Integer, numIdentificacion As String,
                                           fechaIngreso As Date, salarioBase As Decimal, direccion As String)
        Dim DB = New DB.VacacionesEntities()
        DB.sp_update_empleado(idEmpleado, nombreCompleto, idTipoIdentificacion, numIdentificacion, fechaIngreso, salarioBase, direccion)
    End Sub

End Class
