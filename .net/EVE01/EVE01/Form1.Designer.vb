<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Highlight, Nothing)
        Me.Nombres = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lista = New System.Windows.Forms.ListView()
        Me.botonlista1 = New System.Windows.Forms.Button()
        Me.Nombres.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nombres
        '
        Me.Nombres.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Nombres.Controls.Add(Me.botonlista1)
        Me.Nombres.Controls.Add(Me.lista)
        Me.Nombres.Controls.Add(Me.Button2)
        Me.Nombres.Controls.Add(Me.Label8)
        Me.Nombres.Controls.Add(Me.TextBox6)
        Me.Nombres.Controls.Add(Me.TextBox5)
        Me.Nombres.Controls.Add(Me.TextBox4)
        Me.Nombres.Controls.Add(Me.TextBox3)
        Me.Nombres.Controls.Add(Me.TextBox2)
        Me.Nombres.Controls.Add(Me.TextBox1)
        Me.Nombres.Controls.Add(Me.Button3)
        Me.Nombres.Controls.Add(Me.Button1)
        Me.Nombres.Controls.Add(Me.Label6)
        Me.Nombres.Controls.Add(Me.Label5)
        Me.Nombres.Controls.Add(Me.Label4)
        Me.Nombres.Controls.Add(Me.Label3)
        Me.Nombres.Controls.Add(Me.Label2)
        Me.Nombres.Controls.Add(Me.Label1)
        Me.Nombres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Nombres.Location = New System.Drawing.Point(0, 0)
        Me.Nombres.Name = "Nombres"
        Me.Nombres.Size = New System.Drawing.Size(1368, 682)
        Me.Nombres.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1365, 39)
        Me.Label8.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(814, 565)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(394, 49)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "BORRAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(475, 565)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(333, 49)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "MODIFICAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(25, 565)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(394, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RUT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo(s):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(321, 433)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Teléfono:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(443, 268)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 22)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(443, 315)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 22)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(443, 225)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(240, 22)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(443, 359)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(240, 22)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(443, 402)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(240, 22)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(443, 439)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(240, 22)
        Me.TextBox6.TabIndex = 15
        '
        'lista
        '
        Me.lista.HideSelection = False
        Me.lista.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lista.Location = New System.Drawing.Point(735, 108)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(379, 80)
        Me.lista.TabIndex = 20
        Me.lista.UseCompatibleStateImageBehavior = False
        '
        'botonlista1
        '
        Me.botonlista1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.botonlista1.Location = New System.Drawing.Point(701, 357)
        Me.botonlista1.Name = "botonlista1"
        Me.botonlista1.Size = New System.Drawing.Size(196, 24)
        Me.botonlista1.TabIndex = 21
        Me.botonlista1.Text = "AGREGAR"
        Me.botonlista1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 682)
        Me.Controls.Add(Me.Nombres)
        Me.Name = "Form1"
        Me.Text = "Formulario de ingreso"
        Me.Nombres.ResumeLayout(False)
        Me.Nombres.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Nombres As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lista As ListView
    Friend WithEvents botonlista1 As Button
End Class
