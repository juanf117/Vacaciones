Imports System.Runtime.InteropServices
Public Class Login

    'variables publicas
    Public ingreso As Boolean = False

    ' Declaraciones para mover el formulario
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    ' Constantes necesarias para mover el formulario
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MessageBox.Show("Seguro que desea salir?", "Vacaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ingreso = False
            Me.Close()
        End If
    End Sub

    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        epError.Clear()

        If txtUsuario.Text = "" Then
            epError.SetError(txtUsuario, "Ingrese un usuario")
            txtUsuario.Focus()
            Return
        End If
        If txtContraseña.Text = "" Then
            epError.SetError(txtContraseña, "Ingrese una contraseña")
            txtContraseña.Focus()
            Return
        End If
        Dim usuario As String = txtUsuario.Text
        Dim contraseña As String = txtContraseña.Text

        ingreso = True
        Me.Close()

    End Sub
End Class