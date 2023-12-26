<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_color
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
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Button_texto = New System.Windows.Forms.Button()
        Me.Button_text_fond = New System.Windows.Forms.Button()
        Me.Button_fondo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(23, 55)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(420, 29)
        Me.Titulo.TabIndex = 11
        Me.Titulo.Text = "Cambio de color de fondos y letras"
        '
        'Button_texto
        '
        Me.Button_texto.Font = New System.Drawing.Font("JetBrains Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_texto.Location = New System.Drawing.Point(14, 139)
        Me.Button_texto.Name = "Button_texto"
        Me.Button_texto.Size = New System.Drawing.Size(584, 34)
        Me.Button_texto.TabIndex = 8
        Me.Button_texto.Text = "Cambiar aleatoriamente color de letras"
        Me.Button_texto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_texto.UseVisualStyleBackColor = True
        '
        'Button_text_fond
        '
        Me.Button_text_fond.Font = New System.Drawing.Font("JetBrains Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_text_fond.Location = New System.Drawing.Point(14, 266)
        Me.Button_text_fond.Name = "Button_text_fond"
        Me.Button_text_fond.Size = New System.Drawing.Size(584, 38)
        Me.Button_text_fond.TabIndex = 10
        Me.Button_text_fond.Text = "Cambiar  aleatoriamente color de letras y fondo"
        Me.Button_text_fond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_text_fond.UseVisualStyleBackColor = True
        '
        'Button_fondo
        '
        Me.Button_fondo.Font = New System.Drawing.Font("JetBrains Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fondo.Location = New System.Drawing.Point(14, 204)
        Me.Button_fondo.Name = "Button_fondo"
        Me.Button_fondo.Size = New System.Drawing.Size(584, 36)
        Me.Button_fondo.TabIndex = 9
        Me.Button_fondo.Text = "Cambiar aleatoriamente de color de fondo"
        Me.Button_fondo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_fondo.UseVisualStyleBackColor = True
        '
        'Form_color
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 359)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.Button_texto)
        Me.Controls.Add(Me.Button_text_fond)
        Me.Controls.Add(Me.Button_fondo)
        Me.Name = "Form_color"
        Me.Text = "Cambio de colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents Button_texto As Button
    Friend WithEvents Button_text_fond As Button
    Friend WithEvents Button_fondo As Button
End Class
