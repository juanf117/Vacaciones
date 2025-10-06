Imports System.Collections.Generic
Imports System.Linq

Public Class DatosControlVacaciones
    ' Función para obtener la lista de vacaciones descansadas
    Public Shared Function ObtenerVacaciones(idEmpleado As Integer) As List(Of subControlVacaciones)
        Dim db = New DB.VacacionesEntities()
        Return db.ControlVacaciones.Where(Function(v) v.Activo = True And v.idEmpleado = idEmpleado).Select(Function(v) New subControlVacaciones With {.idControlVacaciones = v.idControlVacaciones,
                                                                                                                    .idEmpleado = v.idEmpleado, .Mes = v.Mes, .Anno = v.Anno, .FechaInicio = v.FechaInicio,
                                                                                                                    .FechaFin = v.FechaFin, .DiasGanados = v.DiasGanados, .DiasDescansados = v.DiasDescansados,
                                                                                                                    .Disponibles = v.Disponibles}).ToList()
    End Function

    'Funcion para caulcular las vacaciones
    Public Shared Sub CalcularVacaciones(idEmpleado As Integer, fechaInicio As Date, fechaFin As Date)
        Dim db = New DB.VacacionesEntities()

        db.sp_calcular_vacaciones_empleado(idEmpleado, fechaInicio, fechaFin)
    End Sub

    'Funcion para obtener total de vacaciones
    Public Shared Function OtenerTotalVacaciones(idEmpleado As Integer) As subResumenVacaciones
        Dim db = New DB.VacacionesEntities()

        If db.ControlVacaciones.Where(Function(v) v.Activo = True And v.idEmpleado = idEmpleado).Any() Then
            Return db.ControlVacaciones.Where(Function(v) v.Activo = True And v.idEmpleado = idEmpleado).GroupBy(Function(f) 1).Select(Function(g) New subResumenVacaciones With {
                                                                                                                    .DiasGanados = g.Sum(Function(f) If(f.DiasGanados, 0D)),
                                                                                                                    .DiasDescansados = g.Sum(Function(f) If(f.DiasDescansados, 0D)),
                                                                                                                    .Disponibles = g.Sum(Function(f) If(f.Disponibles, 0D))
                                                                                                                }).FirstOrDefault()
        Else
            Return New subResumenVacaciones With {.DiasGanados = 0D, .DiasDescansados = 0D, .Disponibles = 0D}
        End If


    End Function

    'funcion para reporte de vacaciones
    Public Shared Function ReporteVacaciones(idEmpleado As Integer) As List(Of subReporteVacaciones)
        Dim db = New DB.VacacionesEntities()
        Return db.sp_select_reporte_vacaciones(idEmpleado).OrderBy(Function(r) r.Anno).ThenBy(Function(r) r.MesNumero).Select(Function(r) New subReporteVacaciones With {
                                                                                                                    .idControlVacaciones = r.idControlVacaciones,
                                                                                                                    .idEmpleado = r.idEmpleado,
                                                                                                                    .Mes = r.Mes,
                                                                                                                    .Anno = r.Anno,
                                                                                                                    .FechaInicio = r.FechaInicio,
                                                                                                                    .FechaFin = r.FechaFin,
                                                                                                                    .DiasGanados = r.DiasGanados,
                                                                                                                    .DiasDescansados = r.DiasDescansados,
                                                                                                                    .Disponibles = r.Disponibles,
                                                                                                                    .NombreCompleto = r.NombreCompleto,
                                                                                                                    .NumIdentificacion = r.NumIdentificacion,
                                                                                                                    .FechaIngreso = r.FechaIngreso,
                                                                                                                    .DescTipoIdentificacion = r.DescTipoIdentificacion}).ToList()
    End Function
End Class
