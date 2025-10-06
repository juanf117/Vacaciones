Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginForm As New Login()
        loginForm.ShowDialog()

        If loginForm.ingreso = False Then
            Application.Exit()
        End If

        Me.Opacity = 100
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        Dim EmpleadosForm As New Empleados()
        EmpleadosForm.MdiParent = Me
        EmpleadosForm.Show()
    End Sub

    Private Sub DescansadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescansadasToolStripMenuItem.Click
        Dim vacaciones As New VacacionesDescansadas()
        vacaciones.MdiParent = Me
        vacaciones.Show()
    End Sub

    Private Sub ControlDeVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeVacacionesToolStripMenuItem.Click
        Dim vacaciones As New ControlVacaciones()
        vacaciones.MdiParent = Me
        vacaciones.Show()
    End Sub
End Class