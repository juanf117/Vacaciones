Imports System.Data.Entity.Core.Metadata.Edm
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Datos

Public Class VacacionesDescansadas

    Sub cargarEmpleados()
        cbxEmpleado.DataSource = DatosEmpleado.ObtenerEmpleados()
        cbxEmpleado.DisplayMember = "NombreCompleto"
        cbxEmpleado.ValueMember = "idEmpleado"
        cbxEmpleado.SelectedIndex = -1
        AddHandler cbxEmpleado.SelectedValueChanged, AddressOf cbxEmpleado_SelectedValueChanged
    End Sub
    Sub cargarVacacionesDescansadas()
        gvVacaciones.DataSource = DatosVacacionesDescansadas.ObtenerVacacionesDescansadas(cbxEmpleado.SelectedValue).OrderBy(Function(v) v.Fecha).ToList()
        FormatearColumnas()
    End Sub
    'función para formatear las columnas del datagridview
    Private Sub FormatearColumnas()
        With gvVacaciones
            'columna id empleado
            .Columns("idVacacionesDescansadas").Visible = False
            .Columns("idEmpleado").Visible = False

            'columna fecha 
            .Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("Fecha").HeaderText = "Fecha"
            .Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Fecha").ReadOnly = True

            'columna cantidad
            .Columns("Cantidad").DefaultCellStyle.Format = "N2"
            .Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Cantidad").HeaderText = "Cantidad"
            .Columns("Cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Cantidad").ReadOnly = True

            'columna nombre completo
            .Columns("Descripcion").HeaderText = "Concepto"
            .Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Descripcion").ReadOnly = True

        End With
    End Sub
    Private Sub VacacionesDescansadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEmpleados()
    End Sub

    Private Sub cbxEmpleado_SelectedValueChanged(sender As Object, e As EventArgs)
        If Not cbxEmpleado.SelectedIndex = -1 Then
            cargarVacacionesDescansadas()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        epError.Clear()

        'validar que los campos obligatorios no estén vacíos
        If cbxEmpleado.Text = "" Then
            epError.SetError(cbxEmpleado, "Campo requerido")
            cbxEmpleado.Focus()
            Return
        End If

        Dim add As New addVacacionesDescansadas()
        add.idEmpleado = cbxEmpleado.SelectedValue
        add.ShowDialog()
        cargarVacacionesDescansadas()
    End Sub

    Private Sub gvVacaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvVacaciones.CellDoubleClick
        If e.RowIndex >= 0 Then
            'obtener la fila actual
            Dim fila As DataGridViewRow = gvVacaciones.Rows(e.RowIndex)

            'cargar datos en el formulario de edición
            Dim add As New addVacacionesDescansadas()
            add.edita = True
            'extraer datos de fila y asignarlos al formulario de edición
            add.idVacacionesDescansadas = fila.Cells("idVacacionesDescansadas").Value.ToString()
            add.idEmpleado = fila.Cells("idEmpleado").Value.ToString()
            add.dtFecha.Value = fila.Cells("Fecha").Value
            add.txtCantidad.Value = fila.Cells("Cantidad").Value
            add.txtConcepto.Text = fila.Cells("Descripcion").Value.ToString()
            add.btnEliminar.Visible = True
            add.ShowDialog()
            cargarVacacionesDescansadas()
        End If
    End Sub
End Class