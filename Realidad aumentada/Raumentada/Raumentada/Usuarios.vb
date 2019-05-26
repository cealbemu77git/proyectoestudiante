Public Class USUARIOS
    Private Sub USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()

    End Sub
    Sub limpiarCamposRegistros()
        Identificacion_Estudiante.Clear()
        Nombre_Estudiante.Clear()
        Apellidos_Estudiante.Clear()
        Edad_Estudiante.Clear()
        Telefono_Estudiante.Clear()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub REGISTRAR_Click(sender As Object, e As EventArgs) Handles REGISTRAR.Click
        If personaRegistrada(Identificacion_Estudiante.Text) = False Then
            MsgBox(agregarPersona(Identificacion_Estudiante.Text, Nombre_Estudiante.Text, Apellidos_Estudiante.Text, Edad_Estudiante.Text, Telefono_Estudiante.Text))
            limpiarCamposRegistros()
            Identificacion_Estudiante.Focus()

        Else
            MsgBox("La persona ya esta registrada")
        End If
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If personaRegistrada(Identificacion_Estudiante.Text) = True Then
            MsgBox(eliminarPersona(Identificacion_Estudiante.Text))
            Identificacion_Estudiante.Clear()

        Else
            MsgBox("La persona que desea eliminar no existe")
        End If
    End Sub

    Private Sub MODIFICAR_Click(sender As Object, e As EventArgs) Handles MODIFICAR.Click
        If personaRegistrada(Identificacion_Estudiante.Text) = True Then
            MsgBox(actualizarPersona(CInt(Identificacion_Estudiante.Text), Nombre_Estudiante.Text, Apellidos_Estudiante.Text, CInt(Edad_Estudiante.Text), CInt(Telefono_Estudiante.Text)))
        Else
            MsgBox("La persona que desea modificar no existe")
        End If
    End Sub
End Class