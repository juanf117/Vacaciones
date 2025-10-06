Imports System.Collections.Generic
Imports System.Linq

Public Class DatosVacacionesDescansadas
    ' Función para obtener la lista de vacaciones descansadas
    Public Shared Function ObtenerVacacionesDescansadas(idEmpleado As Integer) As List(Of subVacacionesDescansadas)
        Dim db = New DB.VacacionesEntities()
        Return db.VacacionesDescansadas.Where(Function(v) v.Activo = True And v.idEmpleado = idEmpleado).Select(Function(v) New subVacacionesDescansadas With {.idVacacionesDescansadas = v.idVacacionesDescansadas,
                                                                                                                    .idEmpleado = v.idEmpleado, .Fecha = v.Fecha, .Cantidad = v.Cantidad, .Descripcion = v.Descripcion}).ToList()
    End Function
    ' Función para insertar vacaciones descansadas
    Public Shared Sub InsertarVacacionesDescansadas(idEmpleado As Integer, fecha As Date, cantiada As Double,
                                           descripcion As String)
        Dim db = New DB.VacacionesEntities()
        db.sp_insert_vacaciones_descansadas(idEmpleado, fecha, cantiada, descripcion)
    End Sub

    ' Función para actualizar un  vacaciones descansadas
    Public Shared Sub EditarVacacionesDescansadas(idVacacionesDescansadas As Integer, fecha As Date, cantiada As Double,
                                           descripcion As String)
        Dim db = New DB.VacacionesEntities()
        db.sp_update_vacaciones_descansadas(idVacacionesDescansadas, fecha, cantiada, descripcion)
    End Sub

    ' Función para eliminar un  vacaciones descansadas
    Public Shared Sub EliminarVacacionesDescansadas(idVacacionesDescansadas As Integer)
        Dim db = New DB.VacacionesEntities()
        db.sp_delete_vacaciones_descansadas(idVacacionesDescansadas)
    End Sub

    'Funcion para validar si una fecha ya existe para un empleado
    Public Shared Function ValidarFechaExistente(idEmpleado As Integer, fecha As Date) As Boolean
        Dim db = New DB.VacacionesEntities()
        Return db.VacacionesDescansadas.Any(Function(v) v.idEmpleado = idEmpleado And v.Fecha = fecha.Date And v.Activo = True)
    End Function
End Class
