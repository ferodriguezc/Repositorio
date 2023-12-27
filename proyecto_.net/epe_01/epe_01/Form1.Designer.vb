Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1



    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.barraMenu = New System.Windows.Forms.MenuStrip()
        Me.Menu_Superior = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cambio_De_Color_Sub_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox_Operacion = New System.Windows.Forms.GroupBox()
        Me.Button_Calcular = New System.Windows.Forms.Button()
        Me.Label_Multi = New System.Windows.Forms.Label()
        Me.Label_Resultado_Multi = New System.Windows.Forms.Label()
        Me.Label_Div = New System.Windows.Forms.Label()
        Me.Label_Resultado_Div = New System.Windows.Forms.Label()
        Me.Label_Resultado_Resta = New System.Windows.Forms.Label()
        Me.Label_Resta = New System.Windows.Forms.Label()
        Me.Label_Resultado_Suma = New System.Windows.Forms.Label()
        Me.Label_suma = New System.Windows.Forms.Label()
        Me.Label_Segun_Num = New System.Windows.Forms.Label()
        Me.Label_Primer_Num = New System.Windows.Forms.Label()
        Me.ingr_Num_2 = New System.Windows.Forms.TextBox()
        Me.ingr_Num_1 = New System.Windows.Forms.TextBox()
        Me.Group_Box_Calculadora = New System.Windows.Forms.GroupBox()
        Me.boton_igual = New System.Windows.Forms.Button()
        Me.resultado_cal = New System.Windows.Forms.Label()
        Me.boton0 = New System.Windows.Forms.Button()
        Me.boton9 = New System.Windows.Forms.Button()
        Me.boton8 = New System.Windows.Forms.Button()
        Me.boton7 = New System.Windows.Forms.Button()
        Me.boton6 = New System.Windows.Forms.Button()
        Me.boton5 = New System.Windows.Forms.Button()
        Me.boton4 = New System.Windows.Forms.Button()
        Me.boton3 = New System.Windows.Forms.Button()
        Me.boton2 = New System.Windows.Forms.Button()
        Me.boton_divi = New System.Windows.Forms.Button()
        Me.boton_multi = New System.Windows.Forms.Button()
        Me.boton_menos = New System.Windows.Forms.Button()
        Me.boton_suma = New System.Windows.Forms.Button()
        Me.boton1 = New System.Windows.Forms.Button()
        Me.pantalla = New System.Windows.Forms.Label()
        Me.Group_Box_Calendario = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar_1 = New System.Windows.Forms.MonthCalendar()
        Me.Boton_Calendario = New System.Windows.Forms.Button()
        Me.label_calendario = New System.Windows.Forms.Label()
        Me.GroupBox_lista = New System.Windows.Forms.GroupBox()
        Me.ListBox_2 = New System.Windows.Forms.ListBox()
        Me.Button_seleccionar = New System.Windows.Forms.Button()
        Me.ListBox_1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtResultados = New System.Windows.Forms.TextBox()
        Me.barraMenu.SuspendLayout()
        Me.GroupBox_Operacion.SuspendLayout()
        Me.Group_Box_Calculadora.SuspendLayout()
        Me.Group_Box_Calendario.SuspendLayout()
        Me.GroupBox_lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'barraMenu
        '
        Me.barraMenu.GripMargin = New System.Windows.Forms.Padding(2)
        Me.barraMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.barraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Superior})
        Me.barraMenu.Location = New System.Drawing.Point(0, 0)
        Me.barraMenu.Margin = New System.Windows.Forms.Padding(10)
        Me.barraMenu.Name = "barraMenu"
        Me.barraMenu.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.barraMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.barraMenu.Size = New System.Drawing.Size(1324, 28)
        Me.barraMenu.TabIndex = 2
        Me.barraMenu.Text = "menu"
        '
        'Menu_Superior
        '
        Me.Menu_Superior.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cambio_De_Color_Sub_Menu})
        Me.Menu_Superior.Name = "Menu_Superior"
        Me.Menu_Superior.Size = New System.Drawing.Size(85, 24)
        Me.Menu_Superior.Text = "Opciones"
        '
        'Cambio_De_Color_Sub_Menu
        '
        Me.Cambio_De_Color_Sub_Menu.Name = "Cambio_De_Color_Sub_Menu"
        Me.Cambio_De_Color_Sub_Menu.Size = New System.Drawing.Size(323, 26)
        Me.Cambio_De_Color_Sub_Menu.Text = "Cambio de color  de letras y fondo"
        '
        'GroupBox_Operacion
        '
        Me.GroupBox_Operacion.Controls.Add(Me.Button_Calcular)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Multi)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Resultado_Multi)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Div)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Resultado_Div)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Resultado_Resta)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Resta)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Resultado_Suma)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_suma)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Segun_Num)
        Me.GroupBox_Operacion.Controls.Add(Me.Label_Primer_Num)
        Me.GroupBox_Operacion.Controls.Add(Me.ingr_Num_2)
        Me.GroupBox_Operacion.Controls.Add(Me.ingr_Num_1)
        Me.GroupBox_Operacion.Font = New System.Drawing.Font("JetBrains Mono", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Operacion.Location = New System.Drawing.Point(16, 58)
        Me.GroupBox_Operacion.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox_Operacion.Name = "GroupBox_Operacion"
        Me.GroupBox_Operacion.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox_Operacion.Size = New System.Drawing.Size(413, 415)
        Me.GroupBox_Operacion.TabIndex = 3
        Me.GroupBox_Operacion.TabStop = False
        Me.GroupBox_Operacion.Text = "Operaciones con dos números"
        '
        'Button_Calcular
        '
        Me.Button_Calcular.Location = New System.Drawing.Point(32, 262)
        Me.Button_Calcular.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Calcular.Name = "Button_Calcular"
        Me.Button_Calcular.Size = New System.Drawing.Size(138, 58)
        Me.Button_Calcular.TabIndex = 12
        Me.Button_Calcular.Text = "Calcular"
        Me.Button_Calcular.UseVisualStyleBackColor = True
        '
        'Label_Multi
        '
        Me.Label_Multi.AutoSize = True
        Me.Label_Multi.Location = New System.Drawing.Point(248, 233)
        Me.Label_Multi.Name = "Label_Multi"
        Me.Label_Multi.Size = New System.Drawing.Size(150, 22)
        Me.Label_Multi.TabIndex = 11
        Me.Label_Multi.Text = "Multiplicación"
        '
        'Label_Resultado_Multi
        '
        Me.Label_Resultado_Multi.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label_Resultado_Multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resultado_Multi.Location = New System.Drawing.Point(253, 263)
        Me.Label_Resultado_Multi.Name = "Label_Resultado_Multi"
        Me.Label_Resultado_Multi.Size = New System.Drawing.Size(113, 42)
        Me.Label_Resultado_Multi.TabIndex = 10
        Me.Label_Resultado_Multi.Text = " "
        '
        'Label_Div
        '
        Me.Label_Div.AutoSize = True
        Me.Label_Div.Location = New System.Drawing.Point(249, 332)
        Me.Label_Div.Name = "Label_Div"
        Me.Label_Div.Size = New System.Drawing.Size(90, 22)
        Me.Label_Div.TabIndex = 9
        Me.Label_Div.Text = "División"
        '
        'Label_Resultado_Div
        '
        Me.Label_Resultado_Div.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label_Resultado_Div.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resultado_Div.Location = New System.Drawing.Point(253, 357)
        Me.Label_Resultado_Div.Name = "Label_Resultado_Div"
        Me.Label_Resultado_Div.Size = New System.Drawing.Size(109, 41)
        Me.Label_Resultado_Div.TabIndex = 8
        Me.Label_Resultado_Div.Text = " "
        '
        'Label_Resultado_Resta
        '
        Me.Label_Resultado_Resta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label_Resultado_Resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resultado_Resta.Location = New System.Drawing.Point(253, 169)
        Me.Label_Resultado_Resta.Name = "Label_Resultado_Resta"
        Me.Label_Resultado_Resta.Size = New System.Drawing.Size(111, 42)
        Me.Label_Resultado_Resta.TabIndex = 7
        Me.Label_Resultado_Resta.Text = " "
        '
        'Label_Resta
        '
        Me.Label_Resta.AutoSize = True
        Me.Label_Resta.Location = New System.Drawing.Point(249, 144)
        Me.Label_Resta.Name = "Label_Resta"
        Me.Label_Resta.Size = New System.Drawing.Size(60, 22)
        Me.Label_Resta.TabIndex = 6
        Me.Label_Resta.Text = "Resta"
        '
        'Label_Resultado_Suma
        '
        Me.Label_Resultado_Suma.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label_Resultado_Suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resultado_Suma.Location = New System.Drawing.Point(253, 76)
        Me.Label_Resultado_Suma.Name = "Label_Resultado_Suma"
        Me.Label_Resultado_Suma.Size = New System.Drawing.Size(109, 42)
        Me.Label_Resultado_Suma.TabIndex = 5
        Me.Label_Resultado_Suma.Text = " "
        '
        'Label_suma
        '
        Me.Label_suma.AutoSize = True
        Me.Label_suma.Location = New System.Drawing.Point(246, 49)
        Me.Label_suma.Name = "Label_suma"
        Me.Label_suma.Size = New System.Drawing.Size(50, 22)
        Me.Label_suma.TabIndex = 4
        Me.Label_suma.Text = "Suma"
        '
        'Label_Segun_Num
        '
        Me.Label_Segun_Num.AutoSize = True
        Me.Label_Segun_Num.Location = New System.Drawing.Point(27, 165)
        Me.Label_Segun_Num.Name = "Label_Segun_Num"
        Me.Label_Segun_Num.Size = New System.Drawing.Size(150, 22)
        Me.Label_Segun_Num.TabIndex = 3
        Me.Label_Segun_Num.Text = "Segundo número"
        '
        'Label_Primer_Num
        '
        Me.Label_Primer_Num.AutoSize = True
        Me.Label_Primer_Num.Location = New System.Drawing.Point(27, 93)
        Me.Label_Primer_Num.Name = "Label_Primer_Num"
        Me.Label_Primer_Num.Size = New System.Drawing.Size(140, 22)
        Me.Label_Primer_Num.TabIndex = 2
        Me.Label_Primer_Num.Text = "Primer número"
        '
        'ingr_Num_2
        '
        Me.ingr_Num_2.Location = New System.Drawing.Point(28, 194)
        Me.ingr_Num_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ingr_Num_2.Name = "ingr_Num_2"
        Me.ingr_Num_2.Size = New System.Drawing.Size(181, 30)
        Me.ingr_Num_2.TabIndex = 1
        '
        'ingr_Num_1
        '
        Me.ingr_Num_1.Location = New System.Drawing.Point(28, 122)
        Me.ingr_Num_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ingr_Num_1.Name = "ingr_Num_1"
        Me.ingr_Num_1.Size = New System.Drawing.Size(181, 30)
        Me.ingr_Num_1.TabIndex = 0
        '
        'Group_Box_Calculadora
        '
        Me.Group_Box_Calculadora.Controls.Add(Me.boton_igual)
        Me.Group_Box_Calculadora.Controls.Add(Me.resultado_cal)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton0)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton9)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton8)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton7)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton6)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton5)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton4)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton3)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton2)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton_divi)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton_multi)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton_menos)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton_suma)
        Me.Group_Box_Calculadora.Controls.Add(Me.boton1)
        Me.Group_Box_Calculadora.Controls.Add(Me.pantalla)
        Me.Group_Box_Calculadora.Font = New System.Drawing.Font("JetBrains Mono", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Box_Calculadora.Location = New System.Drawing.Point(930, 58)
        Me.Group_Box_Calculadora.Name = "Group_Box_Calculadora"
        Me.Group_Box_Calculadora.Size = New System.Drawing.Size(371, 497)
        Me.Group_Box_Calculadora.TabIndex = 5
        Me.Group_Box_Calculadora.TabStop = False
        Me.Group_Box_Calculadora.Text = "Calculadora"
        '
        'boton_igual
        '
        Me.boton_igual.Location = New System.Drawing.Point(73, 423)
        Me.boton_igual.Name = "boton_igual"
        Me.boton_igual.Size = New System.Drawing.Size(153, 64)
        Me.boton_igual.TabIndex = 16
        Me.boton_igual.Text = "="
        Me.boton_igual.UseVisualStyleBackColor = True
        '
        'resultado_cal
        '
        Me.resultado_cal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.resultado_cal.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado_cal.Location = New System.Drawing.Point(32, 101)
        Me.resultado_cal.Name = "resultado_cal"
        Me.resultado_cal.Size = New System.Drawing.Size(311, 59)
        Me.resultado_cal.TabIndex = 15
        Me.resultado_cal.Text = "  "
        Me.resultado_cal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'boton0
        '
        Me.boton0.Location = New System.Drawing.Point(113, 168)
        Me.boton0.Name = "boton0"
        Me.boton0.Size = New System.Drawing.Size(75, 56)
        Me.boton0.TabIndex = 14
        Me.boton0.Text = "0"
        Me.boton0.UseVisualStyleBackColor = True
        '
        'boton9
        '
        Me.boton9.Location = New System.Drawing.Point(194, 361)
        Me.boton9.Name = "boton9"
        Me.boton9.Size = New System.Drawing.Size(75, 56)
        Me.boton9.TabIndex = 13
        Me.boton9.Text = "9"
        Me.boton9.UseVisualStyleBackColor = True
        '
        'boton8
        '
        Me.boton8.Location = New System.Drawing.Point(113, 361)
        Me.boton8.Name = "boton8"
        Me.boton8.Size = New System.Drawing.Size(75, 56)
        Me.boton8.TabIndex = 12
        Me.boton8.Text = "8"
        Me.boton8.UseVisualStyleBackColor = True
        '
        'boton7
        '
        Me.boton7.Location = New System.Drawing.Point(32, 361)
        Me.boton7.Name = "boton7"
        Me.boton7.Size = New System.Drawing.Size(75, 56)
        Me.boton7.TabIndex = 11
        Me.boton7.Text = "7"
        Me.boton7.UseVisualStyleBackColor = True
        '
        'boton6
        '
        Me.boton6.Location = New System.Drawing.Point(194, 299)
        Me.boton6.Name = "boton6"
        Me.boton6.Size = New System.Drawing.Size(75, 56)
        Me.boton6.TabIndex = 10
        Me.boton6.Text = "6"
        Me.boton6.UseVisualStyleBackColor = True
        '
        'boton5
        '
        Me.boton5.Location = New System.Drawing.Point(113, 299)
        Me.boton5.Name = "boton5"
        Me.boton5.Size = New System.Drawing.Size(75, 56)
        Me.boton5.TabIndex = 9
        Me.boton5.Text = "5"
        Me.boton5.UseVisualStyleBackColor = True
        '
        'boton4
        '
        Me.boton4.Location = New System.Drawing.Point(32, 299)
        Me.boton4.Name = "boton4"
        Me.boton4.Size = New System.Drawing.Size(75, 56)
        Me.boton4.TabIndex = 8
        Me.boton4.Text = "4"
        Me.boton4.UseVisualStyleBackColor = True
        '
        'boton3
        '
        Me.boton3.Location = New System.Drawing.Point(194, 230)
        Me.boton3.Name = "boton3"
        Me.boton3.Size = New System.Drawing.Size(75, 56)
        Me.boton3.TabIndex = 7
        Me.boton3.Text = "3"
        Me.boton3.UseVisualStyleBackColor = True
        '
        'boton2
        '
        Me.boton2.Location = New System.Drawing.Point(113, 230)
        Me.boton2.Name = "boton2"
        Me.boton2.Size = New System.Drawing.Size(75, 56)
        Me.boton2.TabIndex = 6
        Me.boton2.Text = "2"
        Me.boton2.UseVisualStyleBackColor = True
        '
        'boton_divi
        '
        Me.boton_divi.Location = New System.Drawing.Point(277, 359)
        Me.boton_divi.Name = "boton_divi"
        Me.boton_divi.Size = New System.Drawing.Size(75, 56)
        Me.boton_divi.TabIndex = 5
        Me.boton_divi.Text = "/"
        Me.boton_divi.UseVisualStyleBackColor = True
        '
        'boton_multi
        '
        Me.boton_multi.Location = New System.Drawing.Point(277, 297)
        Me.boton_multi.Name = "boton_multi"
        Me.boton_multi.Size = New System.Drawing.Size(75, 56)
        Me.boton_multi.TabIndex = 4
        Me.boton_multi.Text = "*"
        Me.boton_multi.UseVisualStyleBackColor = True
        '
        'boton_menos
        '
        Me.boton_menos.Location = New System.Drawing.Point(277, 235)
        Me.boton_menos.Name = "boton_menos"
        Me.boton_menos.Size = New System.Drawing.Size(75, 56)
        Me.boton_menos.TabIndex = 3
        Me.boton_menos.Text = "-"
        Me.boton_menos.UseVisualStyleBackColor = True
        '
        'boton_suma
        '
        Me.boton_suma.Location = New System.Drawing.Point(277, 168)
        Me.boton_suma.Name = "boton_suma"
        Me.boton_suma.Size = New System.Drawing.Size(75, 56)
        Me.boton_suma.TabIndex = 2
        Me.boton_suma.Text = "+"
        Me.boton_suma.UseVisualStyleBackColor = True
        '
        'boton1
        '
        Me.boton1.Location = New System.Drawing.Point(32, 230)
        Me.boton1.Name = "boton1"
        Me.boton1.Size = New System.Drawing.Size(75, 56)
        Me.boton1.TabIndex = 1
        Me.boton1.Text = "1"
        Me.boton1.UseVisualStyleBackColor = True
        '
        'pantalla
        '
        Me.pantalla.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pantalla.Location = New System.Drawing.Point(32, 42)
        Me.pantalla.Name = "pantalla"
        Me.pantalla.Size = New System.Drawing.Size(311, 59)
        Me.pantalla.TabIndex = 0
        Me.pantalla.Text = "  "
        Me.pantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Group_Box_Calendario
        '
        Me.Group_Box_Calendario.Controls.Add(Me.MonthCalendar_1)
        Me.Group_Box_Calendario.Controls.Add(Me.Boton_Calendario)
        Me.Group_Box_Calendario.Controls.Add(Me.label_calendario)
        Me.Group_Box_Calendario.Font = New System.Drawing.Font("JetBrains Mono", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Box_Calendario.Location = New System.Drawing.Point(455, 58)
        Me.Group_Box_Calendario.Name = "Group_Box_Calendario"
        Me.Group_Box_Calendario.Padding = New System.Windows.Forms.Padding(0)
        Me.Group_Box_Calendario.Size = New System.Drawing.Size(457, 255)
        Me.Group_Box_Calendario.TabIndex = 18
        Me.Group_Box_Calendario.TabStop = False
        Me.Group_Box_Calendario.Text = "Selector de fecha"
        '
        'MonthCalendar_1
        '
        Me.MonthCalendar_1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.MonthCalendar_1.Location = New System.Drawing.Point(3, 26)
        Me.MonthCalendar_1.Margin = New System.Windows.Forms.Padding(0)
        Me.MonthCalendar_1.Name = "MonthCalendar_1"
        Me.MonthCalendar_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MonthCalendar_1.TabIndex = 20
        '
        'Boton_Calendario
        '
        Me.Boton_Calendario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Boton_Calendario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Boton_Calendario.Location = New System.Drawing.Point(298, 62)
        Me.Boton_Calendario.Name = "Boton_Calendario"
        Me.Boton_Calendario.Size = New System.Drawing.Size(147, 90)
        Me.Boton_Calendario.TabIndex = 19
        Me.Boton_Calendario.Text = "Registrar fecha en el sistema"
        Me.Boton_Calendario.UseVisualStyleBackColor = True
        '
        'label_calendario
        '
        Me.label_calendario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_calendario.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label_calendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_calendario.Location = New System.Drawing.Point(301, 165)
        Me.label_calendario.Name = "label_calendario"
        Me.label_calendario.Size = New System.Drawing.Size(144, 35)
        Me.label_calendario.TabIndex = 18
        '
        'GroupBox_lista
        '
        Me.GroupBox_lista.Controls.Add(Me.ListBox_2)
        Me.GroupBox_lista.Controls.Add(Me.Button_seleccionar)
        Me.GroupBox_lista.Controls.Add(Me.ListBox_1)
        Me.GroupBox_lista.Font = New System.Drawing.Font("JetBrains Mono", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_lista.Location = New System.Drawing.Point(16, 507)
        Me.GroupBox_lista.Name = "GroupBox_lista"
        Me.GroupBox_lista.Size = New System.Drawing.Size(863, 169)
        Me.GroupBox_lista.TabIndex = 19
        Me.GroupBox_lista.TabStop = False
        Me.GroupBox_lista.Text = "Selector de elementos para pasar elementos de una lista a otra "
        '
        'ListBox_2
        '
        Me.ListBox_2.FormattingEnabled = True
        Me.ListBox_2.ItemHeight = 22
        Me.ListBox_2.Location = New System.Drawing.Point(531, 59)
        Me.ListBox_2.Name = "ListBox_2"
        Me.ListBox_2.Size = New System.Drawing.Size(320, 92)
        Me.ListBox_2.TabIndex = 2
        '
        'Button_seleccionar
        '
        Me.Button_seleccionar.Location = New System.Drawing.Point(361, 88)
        Me.Button_seleccionar.Name = "Button_seleccionar"
        Me.Button_seleccionar.Size = New System.Drawing.Size(152, 47)
        Me.Button_seleccionar.TabIndex = 1
        Me.Button_seleccionar.Text = "seleccionar"
        Me.Button_seleccionar.UseVisualStyleBackColor = True
        '
        'ListBox_1
        '
        Me.ListBox_1.FormattingEnabled = True
        Me.ListBox_1.ItemHeight = 22
        Me.ListBox_1.Items.AddRange(New Object() {"Pan", "Tomate", "Queso", "Cilantro", "Martillo", "Tv", "Libro", "Computador", "Teclado", "Puerta", "Auto"})
        Me.ListBox_1.Location = New System.Drawing.Point(16, 59)
        Me.ListBox_1.Name = "ListBox_1"
        Me.ListBox_1.Size = New System.Drawing.Size(320, 92)
        Me.ListBox_1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(477, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResultados
        '
        Me.txtResultados.Location = New System.Drawing.Point(477, 385)
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.Size = New System.Drawing.Size(100, 26)
        Me.txtResultados.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 690)
        Me.Controls.Add(Me.txtResultados)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox_lista)
        Me.Controls.Add(Me.Group_Box_Calendario)
        Me.Controls.Add(Me.Group_Box_Calculadora)
        Me.Controls.Add(Me.GroupBox_Operacion)
        Me.Controls.Add(Me.barraMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Programa con múltiples utilidades"
        Me.barraMenu.ResumeLayout(False)
        Me.barraMenu.PerformLayout()
        Me.GroupBox_Operacion.ResumeLayout(False)
        Me.GroupBox_Operacion.PerformLayout()
        Me.Group_Box_Calculadora.ResumeLayout(False)
        Me.Group_Box_Calendario.ResumeLayout(False)
        Me.GroupBox_lista.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu_Superior As ToolStripMenuItem
    Friend WithEvents GroupBox_Operacion As GroupBox
    Friend WithEvents Label_Resultado_Resta As Label
    Friend WithEvents Label_Resta As Label
    Friend WithEvents Label_Resultado_Suma As Label
    Friend WithEvents Label_suma As Label
    Friend WithEvents Label_Segun_Num As Label
    Friend WithEvents Label_Primer_Num As Label
    Friend WithEvents ingr_Num_2 As TextBox
    Friend WithEvents ingr_Num_1 As TextBox
    Friend WithEvents Label_Multi As Label
    Friend WithEvents Label_Resultado_Multi As Label
    Friend WithEvents Label_Div As Label
    Friend WithEvents Label_Resultado_Div As Label
    Friend WithEvents Button_Calcular As Button
    Friend WithEvents Group_Box_Calculadora As GroupBox
    Friend WithEvents boton1 As Button
    Friend WithEvents pantalla As Label
    Friend WithEvents boton_divi As Button
    Friend WithEvents boton_multi As Button
    Friend WithEvents boton_menos As Button
    Friend WithEvents boton_suma As Button
    Friend WithEvents boton0 As Button
    Friend WithEvents boton9 As Button
    Friend WithEvents boton8 As Button
    Friend WithEvents boton7 As Button
    Friend WithEvents boton6 As Button
    Friend WithEvents boton5 As Button
    Friend WithEvents boton4 As Button
    Friend WithEvents boton3 As Button
    Friend WithEvents boton2 As Button
    Friend WithEvents resultado_cal As Label
    Friend WithEvents boton_igual As Button
    Friend WithEvents Group_Box_Calendario As GroupBox
    Friend WithEvents label_calendario As Label
    Friend WithEvents Boton_Calendario As Button
    Friend WithEvents Cambio_De_Color_Sub_Menu As ToolStripMenuItem
    Public WithEvents barraMenu As MenuStrip
    Friend WithEvents GroupBox_lista As GroupBox
    Friend WithEvents ListBox_1 As ListBox
    Friend WithEvents Button_seleccionar As Button
    Friend WithEvents ListBox_2 As ListBox
    Friend WithEvents MonthCalendar_1 As MonthCalendar
    Friend WithEvents Button1 As Button
    Friend WithEvents txtResultados As TextBox
End Class
