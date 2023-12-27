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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Center)
        Me.Correo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.correoBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.telefonoBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.botonCorreo = New System.Windows.Forms.Button()
        Me.listaCorreo = New System.Windows.Forms.ListView()
        Me.listatelefono = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.botonTeléfono = New System.Windows.Forms.Button()
        Me.listaDirección = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.botonDirección = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.direcciónBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Correo
        '
        Me.Correo.Text = ""
        Me.Correo.Width = 258
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(162, 272)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 31)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RUT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombres:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(162, 355)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(273, 31)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellidos:"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(163, 437)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(273, 31)
        Me.TextBox3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(556, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Correo(s):"
        '
        'correoBox
        '
        Me.correoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.correoBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correoBox.Location = New System.Drawing.Point(692, 273)
        Me.correoBox.Name = "correoBox"
        Me.correoBox.Size = New System.Drawing.Size(273, 31)
        Me.correoBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(531, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Teléfono(s):"
        '
        'telefonoBox
        '
        Me.telefonoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telefonoBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoBox.Location = New System.Drawing.Point(692, 356)
        Me.telefonoBox.Name = "telefonoBox"
        Me.telefonoBox.Size = New System.Drawing.Size(273, 31)
        Me.telefonoBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(186, 622)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 52)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(472, 622)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 52)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(786, 622)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 52)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'botonCorreo
        '
        Me.botonCorreo.AutoSize = True
        Me.botonCorreo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonCorreo.Location = New System.Drawing.Point(971, 274)
        Me.botonCorreo.Name = "botonCorreo"
        Me.botonCorreo.Size = New System.Drawing.Size(170, 30)
        Me.botonCorreo.TabIndex = 15
        Me.botonCorreo.Text = "Agregar otro correo"
        Me.botonCorreo.UseVisualStyleBackColor = True
        '
        'listaCorreo
        '
        Me.listaCorreo.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.listaCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listaCorreo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Correo})
        Me.listaCorreo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup1.Name = "ListViewGroup1"
        Me.listaCorreo.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.listaCorreo.HideSelection = False
        Me.listaCorreo.Location = New System.Drawing.Point(692, 301)
        Me.listaCorreo.Name = "listaCorreo"
        Me.listaCorreo.ShowGroups = False
        Me.listaCorreo.Size = New System.Drawing.Size(273, 33)
        Me.listaCorreo.TabIndex = 16
        Me.listaCorreo.UseCompatibleStateImageBehavior = False
        Me.listaCorreo.View = System.Windows.Forms.View.Tile
        '
        'listatelefono
        '
        Me.listatelefono.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.listatelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listatelefono.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.listatelefono.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup2.Name = "ListViewGroup1"
        Me.listatelefono.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup2})
        Me.listatelefono.HideSelection = False
        Me.listatelefono.Location = New System.Drawing.Point(692, 384)
        Me.listatelefono.Name = "listatelefono"
        Me.listatelefono.ShowGroups = False
        Me.listatelefono.Size = New System.Drawing.Size(273, 33)
        Me.listatelefono.TabIndex = 18
        Me.listatelefono.UseCompatibleStateImageBehavior = False
        Me.listatelefono.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 258
        '
        'botonTeléfono
        '
        Me.botonTeléfono.AutoSize = True
        Me.botonTeléfono.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonTeléfono.Location = New System.Drawing.Point(971, 355)
        Me.botonTeléfono.Name = "botonTeléfono"
        Me.botonTeléfono.Size = New System.Drawing.Size(186, 32)
        Me.botonTeléfono.TabIndex = 17
        Me.botonTeléfono.Text = "Agregar otro teléfono"
        Me.botonTeléfono.UseVisualStyleBackColor = True
        '
        'listaDirección
        '
        Me.listaDirección.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.listaDirección.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listaDirección.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.listaDirección.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup3.Header = "ListViewGroup"
        ListViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup3.Name = "ListViewGroup1"
        Me.listaDirección.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup3})
        Me.listaDirección.HideSelection = False
        Me.listaDirección.Location = New System.Drawing.Point(692, 467)
        Me.listaDirección.Name = "listaDirección"
        Me.listaDirección.ShowGroups = False
        Me.listaDirección.Size = New System.Drawing.Size(273, 33)
        Me.listaDirección.TabIndex = 22
        Me.listaDirección.UseCompatibleStateImageBehavior = False
        Me.listaDirección.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = ""
        Me.ColumnHeader2.Width = 258
        '
        'botonDirección
        '
        Me.botonDirección.AutoSize = True
        Me.botonDirección.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonDirección.Location = New System.Drawing.Point(971, 440)
        Me.botonDirección.Name = "botonDirección"
        Me.botonDirección.Size = New System.Drawing.Size(194, 28)
        Me.botonDirección.TabIndex = 21
        Me.botonDirección.Text = "Agregar otra dirección"
        Me.botonDirección.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(510, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Dirección(es):"
        '
        'direcciónBox
        '
        Me.direcciónBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.direcciónBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direcciónBox.Location = New System.Drawing.Point(692, 439)
        Me.direcciónBox.Name = "direcciónBox"
        Me.direcciónBox.Size = New System.Drawing.Size(273, 31)
        Me.direcciónBox.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.listaDirección)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.botonDirección)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.direcciónBox)
        Me.Panel1.Controls.Add(Me.correoBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.listatelefono)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.botonTeléfono)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.botonCorreo)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.listaCorreo)
        Me.Panel1.Controls.Add(Me.telefonoBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1249, 718)
        Me.Panel1.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Consolas", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(683, 133)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Registro de información para clientes de la empresa"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1246, 198)
        Me.Label8.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Programa de registro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents correoBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents telefonoBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents botonCorreo As Button
    Friend WithEvents listaCorreo As ListView
    Friend WithEvents Correo As ColumnHeader
    Friend WithEvents listatelefono As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents botonTeléfono As Button
    Friend WithEvents listaDirección As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents botonDirección As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents direcciónBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
