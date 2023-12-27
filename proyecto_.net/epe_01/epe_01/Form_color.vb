Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form_color
    ' Este código crea una segunda pantalla que se abrirá desde la barra de menú.
    ' La pantalla permite cambiar aleatoriamente el color mediante botones,
    ' modificando el texto y fondos. También incluye un botón que realiza ambos cambios a la vez.


    ' EL evento se ejecuta cuando se hace clic en Button1
    Private Sub Button_texto_Click_1(sender As Object, e As EventArgs) Handles Button_texto.Click

        ' Se crea un objeto Random para generar colores aleatorios
        Dim random As New Random()

        ' Se cambia el color del texto en Form1 a un color aleatorio
        Form1.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))
    End Sub

    ' Este evento se ejecuta cuando se hace clic en Button2
    Private Sub Button_fondo_Click_1(sender As Object, e As EventArgs) Handles Button_fondo.Click
        ' Se crea un objeto Random para generar colores aleatorios
        Dim random As New Random()

        ' Se cambia el color de fondo en Form1 a un color aleatorio
        Form1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))
    End Sub

    ' Este evento se ejecuta cuando se hace clic en Button3
    Private Sub Button_text_fond_Click_1(sender As Object, e As EventArgs) Handles Button_text_fond.Click
        ' Se crea un objeto Random para generar colores aleatorios
        Dim random As New Random()

        ' Se cambia el color de fondo y el color del texto en Form1 a colores aleatorios
        Form1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))
        Form1.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))
    End Sub


End Class