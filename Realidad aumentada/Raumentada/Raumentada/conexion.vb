Imports Microsoft.Office.Interop.Access
Imports System.Data
Imports System.Data.OleDb

Module Conexion

    Public conexion As OleDbConnection = New OleDbConnection
    Public cadenaConexion As String
    Public rs As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim adaptador As OleDbDataAdapter

    Sub reconectar()
        conexion.Close()
        conexion.Open()
    End Sub

    'Carga la Conexion con la BD ACCESS '
    Sub abrir()
        Try
            cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\Users\vasquezs\Desktop\Realidad aumentada\RAUMENTADA_BD.mdb"
            conexion.ConnectionString = cadenaConexion
            conexion.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function agregarPersona(ByVal Identificacion_Estudiante As String, ByVal Nombre_Estudiante As String, ByVal Apellidos_Estudiante As String, ByVal Edad_Estudiante As String, ByVal Telefono_Estudiante As String) As String
        reconectar()
        Dim salida As String = "SE REGISTRO CORRECTAMENTE"
        Try
            cmd = New OleDbCommand("Insert into Estudiantes(Identificacion_Estudiante,Nombre_Estudiante,Apellidos_Estudiante,Edad_Estudiante,Telefono_Estudiante) values('" & Identificacion_Estudiante & "','" & Nombre_Estudiante & "'," & Apellidos_Estudiante & "','" & Edad_Estudiante & "'," & Telefono_Estudiante & ")", conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            salida = "NO SE REALIZO EL REGISTRO CORRECTAMENTE"
            MsgBox(ex.ToString)
        End Try
        Return salida
    End Function

    'Consulta si la persona esta registrada'
    Function personaRegistrada(ByVal Identificacion_Estudiante As String) As Boolean
        reconectar()
        Dim salida As Boolean = False
        Try
            cmd = New OleDbCommand("Select * from Estudiantes where Identificacion_Estudiante='" & Identificacion_Estudiante & "'", conexion)
            rs = cmd.ExecuteReader
            While rs.Read
                salida = True
            End While
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return salida
    End Function

    'Modifica los datos de una Persona por identificacion'
    Function actualizarPersona(ByVal Identificacion_Estudiante As Integer, ByVal Nombre_Estudiante As String, ByVal Apellidos_Estudiante As String, ByVal Edad_Estudiante As Integer, ByVal Telefono_Estudiante As Integer) As String
        reconectar()
        Dim salida As String = "Se actualizaron los datos correctamente"
        Try
            cmd = New OleDbCommand("Update Estudiantes set Nombre_Estudiante='" & Nombre_Estudiante & "' where Nombre='" & Identificacion_Estudiante & "'", conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            salida = "No se actualizaron los datos"
            MsgBox(ex.ToString)
        End Try
        Return salida
    End Function
    'Elimina los datos de una Persona por identificacion'
    Function eliminarPersona(ByVal Identificacion_Estudiante As String) As String
        reconectar()
        Dim salida As String = "Se elimino el registro"
        Try
            cmd = New OleDbCommand("Delete Estudiantes from Estudiantes where Identificacion_Estudiante='" & Identificacion_Estudiante & "'", conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Return salida
    End Function
End Module
