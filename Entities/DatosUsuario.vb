Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports DB
Public Class DatosUsuario
    Public Shared Function ValidarIngreso(usuario As String, contraseña As String) As Boolean

        Dim DB = New DB.VacacionesEntities()
        Dim contraseñaHash As String = SHA1Hash(contraseña)
        'validar que los datos ingresados son correctos
        Return DB.Usuario.Where(Function(u) u.Usuario1 = usuario And u.Contraseña = contraseñaHash And u.Activo = True).Any()
    End Function

    ' Función para generar el hash SHA-1 de la contraseña para que en la base de datos no se guarde en texto plano
    Public Shared Function SHA1Hash(contraseña As String) As String
        'Crear una instancia de SHA1
        Using sha1 As SHA1 = SHA1.Create()
            'variable para almacenar los bytes del texto y el hash
            Dim bytesTexto As Byte() = Encoding.UTF8.GetBytes(contraseña)
            Dim hashBytes As Byte() = sha1.ComputeHash(bytesTexto)
            'convertir el hash a hexadecimal
            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function
End Class
