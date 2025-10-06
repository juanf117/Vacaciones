Imports Datos
Public Class InsertarEmpleado
    Public edita As Boolean = False
    Public idTipoIdentificacion As Integer
    Sub cargarTiposIdentificacion()
        cbxTipoIdentificacion.DataSource = DatosTipoIdentificacion.ObtenerTiposIdentificacion()
        cbxTipoIdentificacion.DisplayMember = "DescTipoIdentificacion"
        cbxTipoIdentificacion.ValueMember = "idTipoIdentificacion"
        If edita Then
            cbxTipoIdentificacion.SelectedIndex = idTipoIdentificacion - 1
        Else
            cbxTipoIdentificacion.SelectedIndex = -1
        End If

    End Sub
    Private Sub InsertarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTiposIdentificacion()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        epError.Clear()

        Dim valido As Boolean = True

        'validar que los campos obligatorios no estén vacíos
        If txtNombre.Text = "" Then
            epError.SetError(txtNombre, "Campo requerido")
            txtNombre.Focus()
            valido = False
        End If
        If cbxTipoIdentificacion.Text = "" Then
            epError.SetError(cbxTipoIdentificacion, "Campo requerido")
            cbxTipoIdentificacion.Focus()
            valido = False
        End If
        If txtIdentificacion.Text = "" Then
            epError.SetError(txtIdentificacion, "Campo requerido")
            txtIdentificacion.Focus()
            valido = False
        End If
        If dtFechaIngreso.Text = "" Then
            epError.SetError(dtFechaIngreso, "Campo requerido")
            dtFechaIngreso.Focus()
            valido = False
        End If
        If txtSalarioBase.Text = "" Then
            epError.SetError(txtSalarioBase, "Campo requerido")
            txtSalarioBase.Focus()
            valido = False
        End If
        If txtDireccion.Text = "" Then
            epError.SetError(txtDireccion, "Campo requerido")
            txtDireccion.Focus()
            valido = False
        End If

        If Not valido Then
            Return
        End If

        If edita Then
            DatosEmpleado.EditarEmpleado(txtId.Text, txtNombre.Text, cbxTipoIdentificacion.SelectedValue, txtIdentificacion.Text,
                                           dtFechaIngreso.Value, txtSalarioBase.Value, txtDireccion.Text)
            MessageBox.Show("Empleado editado correctamente", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'validar que no exista el mismo numero de identificacion
            If DatosEmpleado.ValidarIdentificacion(cbxTipoIdentificacion.SelectedValue, txtIdentificacion.Text) Then
                epError.SetError(txtIdentificacion, "Ya existe un empleado con este número de identificación")
                txtIdentificacion.Focus()
                Return
            End If
            DatosEmpleado.InsertarEmpleado(txtNombre.Text, cbxTipoIdentificacion.SelectedValue, txtIdentificacion.Text,
                                           dtFechaIngreso.Value, txtSalarioBase.Value, txtDireccion.Text)
            MessageBox.Show("Empleado guardado correctamente", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub
End Class