Imports Datos
Public Class Empleados

    Sub cargarEmpleados()
        gvEmpleados.DataSource = DatosEmpleado.ObtenerEmpleados()
        FormatearColumnas()
    End Sub
    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEmpleados()
    End Sub
    'función para formatear las columnas del datagridview
    Private Sub FormatearColumnas()
        With gvEmpleados
            'columna id empleado
            .Columns("idEmpleado").HeaderText = "ID"
            .Columns("idEmpleado").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("idEmpleado").ReadOnly = True

            'columna nombre completo
            .Columns("NombreCompleto").HeaderText = "Nombre Completo"
            .Columns("NombreCompleto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("NombreCompleto").ReadOnly = True

            'columna número de tipo identificación
            .Columns("DescTipoIdentificacion").HeaderText = "Tipo de Identificación"
            .Columns("DescTipoIdentificacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("DescTipoIdentificacion").ReadOnly = True

            'columna número de tipo NumIdentificacion
            .Columns("NumIdentificacion").HeaderText = "Identificación"
            .Columns("NumIdentificacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("NumIdentificacion").ReadOnly = True

            'columna fecha de ingreso
            .Columns("FechaIngreso").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("FechaIngreso").HeaderText = "Fecha de Ingreso"
            .Columns("FechaIngreso").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("FechaIngreso").ReadOnly = True

            'columna salario base
            .Columns("SalarioBase").DefaultCellStyle.Format = "N2"
            .Columns("SalarioBase").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("SalarioBase").HeaderText = "Salario Base($)"
            .Columns("SalarioBase").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("SalarioBase").ReadOnly = True

            'columna dirección
            .Columns("Direccion").HeaderText = "Dirección"
            .Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Direccion").ReadOnly = True

            .Columns("Activo").Visible = False

            .Columns("idTipoIdentificacion").Visible = False
        End With
    End Sub
    'evento para capturar el doble click en una fila y editar el registro
    Private Sub gvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvEmpleados.CellDoubleClick
        If e.RowIndex >= 0 Then
            'obtener la fila actual
            Dim fila As DataGridViewRow = gvEmpleados.Rows(e.RowIndex)

            'cargar datos en el formulario de edición
            Dim emp As New InsertarEmpleado()
            emp.edita = True
            'extraer datos de fila y asignarlos al formulario de edición
            emp.txtId.Text = fila.Cells("idEmpleado").Value.ToString()
            emp.txtNombre.Text = fila.Cells("NombreCompleto").Value.ToString()
            emp.idTipoIdentificacion = fila.Cells("idTipoIdentificacion").Value
            emp.txtIdentificacion.Text = fila.Cells("NumIdentificacion").Value.ToString()
            emp.dtFechaIngreso.Value = fila.Cells("FechaIngreso").Value
            emp.txtSalarioBase.Value = fila.Cells("SalarioBase").Value
            emp.txtDireccion.Text = fila.Cells("Direccion").Value.ToString()
            emp.ShowDialog()
            cargarEmpleados()
        End If
    End Sub
End Class