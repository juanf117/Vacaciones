Imports System.Data.Entity.Core.Metadata.Edm
Imports Datos

Public Class CalcularVacaciones
    Public idEmpleado As Integer
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        epError.Clear()

        Dim valido As Boolean = True

        'validar que los campos obligatorios no estén vacíos
        If dtFechaInicio.Text = "" Then
            epError.SetError(dtFechaInicio, "Campo requerido")
            dtFechaInicio.Focus()
            valido = False
        End If
        If dtFechaFin.Text = "" Then
            epError.SetError(dtFechaFin, "Campo requerido")
            dtFechaFin.Focus()
            valido = False
        End If

        If Not valido Then
            Return
        End If

        If dtFechaFin.Value < dtFechaInicio.Value Then
            epError.SetError(dtFechaFin, "La fecha fin no puede ser menor a la fecha de inicio")
            dtFechaFin.Focus()
            Return
        End If

        DatosControlVacaciones.CalcularVacaciones(idEmpleado, dtFechaInicio.Value, dtFechaFin.Value)

        Me.Close()
    End Sub
End Class