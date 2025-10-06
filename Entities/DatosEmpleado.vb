Imports System.Collections.Generic
Imports System.Linq
Public Class DatosEmpleado
    ' Función para obtener la lista de empleados activos
    Public Shared Function ObtenerEmpleados() As List(Of subEmpleado)
        Dim db = New DB.VacacionesEntities()
        Return db.Empleado.Where(Function(e) e.Activo = True).Select(Function(e) New subEmpleado With {.idEmpleado = e.idEmpleado, .NombreCompleto = e.NombreCompleto,
                                                                         .DescTipoIdentificacion = e.TipoIdentificacion.DescTipoIdentificacion, .idTipoIdentificacion = e.idTipoIdentificacion,
                                                                         .NumIdentificacion = e.NumIdentificacion, .FechaIngreso = e.FechaIngreso, .SalarioBase = e.SalarioBase,
                                                                         .Direccion = e.Direccion, .Activo = e.Activo}).OrderBy(Function(e) e.NombreCompleto).ToList()
    End Function

    ' Función para insertar un nuevo empleado
    Public Shared Sub InsertarEmpleado(nombreCompleto As String, idTipoIdentificacion As Integer, numIdentificacion As String,
                                           fechaIngreso As Date, salarioBase As Decimal, direccion As String)
        Dim db = New DB.VacacionesEntities()
        db.sp_insert_empleado(nombreCompleto, idTipoIdentificacion, numIdentificacion, fechaIngreso, salarioBase, direccion)
    End Sub

    ' Función para actualizar un  empleado
    Public Shared Sub EditarEmpleado(idEmpleado As Integer, nombreCompleto As String, idTipoIdentificacion As Integer, numIdentificacion As String,
                                           fechaIngreso As Date, salarioBase As Decimal, direccion As String)
        Dim db = New DB.VacacionesEntities()
        db.sp_update_empleado(idEmpleado, nombreCompleto, idTipoIdentificacion, numIdentificacion, fechaIngreso, salarioBase, direccion)
    End Sub

    ' Función para validar que no exista el mismo numero de identificacion
    Public Shared Function ValidarIdentificacion(idTipoIdentificacion As Integer, numIdentificacion As String) As Boolean
        Dim db = New DB.VacacionesEntities()
        Return db.Empleado.Any(Function(e) e.idTipoIdentificacion = idTipoIdentificacion And e.NumIdentificacion = numIdentificacion And e.Activo = True)
    End Function

    ' Función para obtener la fecha de ingreso del empleado
    Public Shared Function ObtenerFechaIngreso(idEmpleado As Integer) As Date
        Dim db = New DB.VacacionesEntities()
        Return db.Empleado.Where(Function(e) e.idEmpleado = idEmpleado).Select(Function(e) e.FechaIngreso).FirstOrDefault()
    End Function

End Class
