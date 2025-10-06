Imports System.Data.Entity.Core.Metadata.Edm
Imports Datos

Public Class addVacacionesDescansadas
    Public idVacacionesDescansadas As Integer
    Public idEmpleado As Integer
    Public edita As Boolean = False
    Private Sub addVacacionesDescansadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        epError.Clear()

        Dim valido As Boolean = True

        'validar que los campos obligatorios no estén vacíos
        If dtFecha.Text = "" Then
            epError.SetError(dtFecha, "Campo requerido")
            dtFecha.Focus()
            valido = False
        End If
        If txtCantidad.Text = "" Or txtCantidad.Value = 0 Then
            epError.SetError(txtCantidad, "Campo requerido")
            txtCantidad.Focus()
            valido = False
        End If
        If txtConcepto.Text = "" Then
            epError.SetError(txtConcepto, "Campo requerido")
            txtConcepto.Focus()
            valido = False
        End If

        If Not valido Then
            Return
        End If

        'si edita es true, se actualiza el registro, si no, se inserta uno nuevo
        If edita Then
            Datos.DatosVacacionesDescansadas.EditarVacacionesDescansadas(idVacacionesDescansadas, dtFecha.Value, Convert.ToDouble(txtCantidad.Text),
                                                                txtConcepto.Text)
            MessageBox.Show("Registro actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else 'si edita es false, se inserta un nuevo registro

            If DatosVacacionesDescansadas.ValidarFechaExistente(idEmpleado, dtFecha.Value) Then
                epError.SetError(dtFecha, "Ya existe un registro para esta fecha")
                dtFecha.Focus()
                Return
            End If

            Datos.DatosVacacionesDescansadas.InsertarVacacionesDescansadas(idEmpleado, dtFecha.Value, Convert.ToDouble(txtCantidad.Text),
                                                                txtConcepto.Text)
            MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Preguntar al usuario si está seguro de eliminar el registro
        If MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Datos.DatosVacacionesDescansadas.EliminarVacacionesDescansadas(idVacacionesDescansadas)
            MessageBox.Show("Registro eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class