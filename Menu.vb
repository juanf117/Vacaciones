Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginForm As New Login()
        loginForm.ShowDialog()

        If loginForm.ingreso = False Then
            Application.Exit()
        End If

        Me.Opacity = 100
    End Sub
End Class