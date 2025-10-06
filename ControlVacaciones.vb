Imports Datos
Public Class ControlVacaciones
    Sub cargarEmpleados()
        cbxEmpleado.DataSource = DatosEmpleado.ObtenerEmpleados()
        cbxEmpleado.DisplayMember = "NombreCompleto"
        cbxEmpleado.ValueMember = "idEmpleado"
        cbxEmpleado.SelectedIndex = -1
        AddHandler cbxEmpleado.SelectedValueChanged, AddressOf cbxEmpleado_SelectedValueChanged
    End Sub
    Sub cargarVacaciones()
        gvVacaciones.DataSource = DatosControlVacaciones.ObtenerVacaciones(cbxEmpleado.SelectedValue)
        obtenerTotales()
        FormatearColumnas()
    End Sub
    Sub obtenerTotales()
        Dim totales As subResumenVacaciones = DatosControlVacaciones.OtenerTotalVacaciones(cbxEmpleado.SelectedValue)
        txtGanadas.Text = totales.DiasGanados
        txtDescansadas.Text = totales.DiasDescansados
        txtDisponibles.Text = totales.Disponibles
    End Sub
    Private Sub FormatearColumnas()
        With gvVacaciones
            'columna idControlVacaciones
            .Columns("idControlVacaciones").Visible = False

            'columna id empleado
            .Columns("idEmpleado").Visible = False

            'columna mes
            .Columns("Mes").HeaderText = "Mes"
            .Columns("Mes").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Mes").ReadOnly = True

            'columna año
            .Columns("Anno").HeaderText = "Año"
            .Columns("Anno").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Anno").ReadOnly = True

            'columna fecha de inicio
            .Columns("FechaInicio").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("FechaInicio").HeaderText = "Fecha de Inicio"
            .Columns("FechaInicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("FechaInicio").ReadOnly = True

            'columna fecha de fin
            .Columns("FechaFin").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("FechaFin").HeaderText = "Fecha de Fin"
            .Columns("FechaFin").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("FechaFin").ReadOnly = True

            'columna Dias Ganados
            .Columns("DiasGanados").DefaultCellStyle.Format = "N2"
            .Columns("DiasGanados").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("DiasGanados").HeaderText = "Dias Ganados"
            .Columns("DiasGanados").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("DiasGanados").ReadOnly = True

            'columna Dias Ganados
            .Columns("DiasDescansados").DefaultCellStyle.Format = "N2"
            .Columns("DiasDescansados").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("DiasDescansados").HeaderText = "Dias Ganados"
            .Columns("DiasDescansados").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("DiasDescansados").ReadOnly = True

        End With
    End Sub
    Private Sub ControlVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEmpleados()
    End Sub

    Private Sub cbxEmpleado_SelectedValueChanged(sender As Object, e As EventArgs)
        If Not cbxEmpleado.SelectedIndex = -1 Then
            dtFecha.Value = DatosEmpleado.ObtenerFechaIngreso(cbxEmpleado.SelectedValue)
            cargarVacaciones()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim calcular As New CalcularVacaciones()
        calcular.idEmpleado = cbxEmpleado.SelectedValue
        calcular.dtFechaInicio.Value = dtFecha.Value
        calcular.ShowDialog()
        cargarVacaciones()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

    End Sub
End Class