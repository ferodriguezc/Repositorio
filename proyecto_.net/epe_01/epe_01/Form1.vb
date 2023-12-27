Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql
Imports MySql.Data.MySqlClient

Public Class Form1







    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label_Resultado_Resta.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label_Resta.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click

        ' Se intenta realizar el siguiente bloque de código
        Try
            ' Se convierten los valores ingresados en las cajas de texto a enteros
            Dim valornum1 As Integer = Integer.Parse(ingr_Num_1.Text)
            Dim valornum2 As Integer = Integer.Parse(ingr_Num_2.Text)

            ' Se realiza la suma y se muestra en el correspondiente Label
            Label_Resultado_Suma.Text = valornum1 + valornum2

            ' Se realiza la resta y se muestra en el correspondiente Label
            Label_Resultado_Resta.Text = valornum1 - valornum2

            ' Se realiza la multiplicación y se muestra en el correspondiente Label
            Label_Resultado_Multi.Text = valornum1 * valornum2

            ' Se realiza la división y se redondea a 3 decimales, luego se muestra en el correspondiente Label
            Label_Resultado_Div.Text = Math.Round(valornum1 / valornum2, 3)

            ' Si ocurre algún error durante la ejecución del bloque anterior, se captura y se muestra un mensaje de error
        Catch ex As Exception
            MessageBox.Show("Error: no ingresaste un valor correcto")
        End Try

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs)
        System.Media.SystemSounds.Beep.Play()
    End Sub






    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles boton1.Click, boton2.Click, boton3.Click,
        boton4.Click, boton5.Click, boton6.Click, boton7.Click, boton8.Click, boton9.Click, boton0.Click, boton_suma.Click,
        boton_menos.Click, boton_multi.Click, boton_divi.Click


        ' El procedimiento de clic para todos los botones de números
        Dim botonPresionado As Button = DirectCast(sender, Button)

        ' Concatena el texto del botón al texto actual del Label
        pantalla.Text &= botonPresionado.Text

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles boton7.Click

    End Sub

    Private Sub resultado_cal_Click(sender As Object, e As EventArgs) Handles resultado_cal.Click



    End Sub

    Private Sub boton_igual_Click(sender As Object, e As EventArgs) Handles boton_igual.Click


        Dim expresion As String = pantalla.Text


        ' Utiliza un DataTable para evaluar la expresión
        Dim dt As New DataTable()
        Dim resultado As Object = dt.Compute(expresion, "")
        resultado_cal.Text = resultado.ToString()
        pantalla.Text = ""


    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles Group_Box_Calendario.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles label_calendario.Click




    End Sub



    Private Sub boton_calendario_Click(sender As Object, e As EventArgs) Handles Boton_Calendario.Click

        label_calendario.Text = MonthCalendar_1.SelectionStart

    End Sub





    Private Sub Cambio_De_Color_Sub_Menu_Click(sender As Object, e As EventArgs) Handles Cambio_De_Color_Sub_Menu.Click
        Dim ventanaNueva As New Form_color()

        ' Mostrar la nueva ventana
        ventanaNueva.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox_Operacion.Enter

    End Sub

    Private Sub Button_seleccionar_Click(sender As Object, e As EventArgs) Handles Button_seleccionar.Click


        ' Construir un mensaje con los elementos seleccionados

        For Each item As Object In ListBox_1.SelectedItems
            Dim mensaje As String = item.ToString() & " Agregado correctamente a segunda lista"
            ListBox_2.Items.Add(item.ToString())
            MessageBox.Show(mensaje)


        Next

    End Sub

    Private Sub ListBox_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_1.SelectedIndexChanged

    End Sub




    Dim connectionString As String = "Server=localhost;Database=bd_net;User ID=root;Password=101010;"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Crea una conexión
        Using conexion As New MySqlConnection(connectionString)
            Try
                ' Abre la conexión
                conexion.Open()

                ' Ejecuta una consulta SELECT
                Dim consulta As String = "SELECT * FROM usuarios"
                Using comando As New MySqlCommand(consulta, conexion)
                    Using lector As MySqlDataReader = comando.ExecuteReader()
                        ' Procesa los resultados y muestra en el cuadro de texto
                        While lector.Read()
                            txtResultados.Text += $"RUT: {lector("RUT")}, Nombres: {lector("Nombres")}, apellidos: {lector("apellidos")}{Environment.NewLine}"
                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Manejo de errores
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

End Class

