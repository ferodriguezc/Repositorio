Public Class Form1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles botonCorreo.Click

        Dim nuevocorreo As String = correoBox.Text
        listaCorreo.Items.Add(nuevocorreo)

        correoBox.Clear()

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles botonTeléfono.Click
        Dim nuevoTelefono As String = telefonoBox.Text
        listatelefono.Items.Add(nuevoTelefono)

        telefonoBox.Clear()
    End Sub



    Private Sub botonDirección_Click(sender As Object, e As EventArgs) Handles botonDirección.Click
        Dim nuevaDirección As String = direcciónBox.Text
        listaDirección.Items.Add(nuevaDirección)

        direcciónBox.Clear()
    End Sub

End Class
