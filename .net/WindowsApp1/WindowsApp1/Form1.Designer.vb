Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Public Class Persona
        Public Property Nombre As String
        Public Property ApellidoPaterno As String
        Public Property ApellidoMaterno As String
        Public Property Direccion As String
        Public Property Telefono As String
        Public Property Correo As String
        Public Property Rut As String
        Public Property CorreoLaboral As String
        Public Property CorreoPersonal As String
    End Class

    Private personas As New List(Of Persona)
    Private WithEvents DataGridView1 As New DataGridView()
    Private textBoxNombre As Object
    Private textBoxApellidoPaterno As Object
    Private textBoxApellidoMaterno As Object
    Private textBoxRut As Object
    Private textBoxTelefono As Object
    Private textBoxCorreo As Object
    Private textBoxDireccion As Object
    Private buttonAccion As Object

    Public Sub New()
        InitializeComponent()

        Dim menuStrip As New MenuStrip()
        Me.Controls.Add(menuStrip)

        Dim archivoMenu As New ToolStripMenuItem("Archivo")
        menuStrip.Items.Add(archivoMenu)

        Dim agregarPersonaItem As New ToolStripMenuItem("Agregar Persona")
        archivoMenu.DropDownItems.Add(agregarPersonaItem)
        AddHandler agregarPersonaItem.Click, AddressOf AgregarPersonaToolStripMenuItem_Click

        Dim editarPersonaItem As New ToolStripMenuItem("Editar Persona")
        archivoMenu.DropDownItems.Add(editarPersonaItem)
        AddHandler editarPersonaItem.Click, AddressOf EditarPersonaToolStripMenuItem_Click

        Dim ayudaMenu As New ToolStripMenuItem("Ayuda")
        menuStrip.Items.Add(ayudaMenu)

        Dim acercaDeItem As New ToolStripMenuItem("Acerca de")
        ayudaMenu.DropDownItems.Add(acercaDeItem)
        AddHandler acercaDeItem.Click, AddressOf AcercaDeToolStripMenuItem_Click

        Me.Controls.Add(DataGridView1)
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = personas
    End Sub

    Private Sub AgregarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim formAgregarEditar As New FormAgregarEditar()
        If formAgregarEditar.ShowDialog() = DialogResult.OK Then
            AgregarPersona(formAgregarEditar.PersonaActual)
            ActualizarTabla()
        End If
    End Sub

    Private Sub EditarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim personaSeleccionada = CType(DataGridView1.SelectedRows(0).DataBoundItem, Persona)
            Dim formAgregarEditar As New FormAgregarEditar(personaSeleccionada)
            If formAgregarEditar.ShowDialog() = DialogResult.OK Then
                ActualizarPersona(personaSeleccionada, formAgregarEditar.PersonaActual)
                ActualizarTabla()
            End If
        Else
            MessageBox.Show("Seleccione una persona para editar.", "Editar Persona", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Versión de la aplicación: 1.0" & vbCrLf & "Creador: Daniel Mc Intyre", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AgregarPersona(persona As Persona)
        personas.Add(persona)
    End Sub

    Private Sub ActualizarPersona(personaOriginal As Persona, personaActualizada As Persona)
        personaOriginal.Nombre = personaActualizada.Nombre
        personaOriginal.ApellidoPaterno = personaActualizada.ApellidoPaterno
        personaOriginal.ApellidoMaterno = personaActualizada.ApellidoMaterno
        personaOriginal.CorreoLaboral = personaActualizada.CorreoLaboral
        personaOriginal.CorreoPersonal = personaActualizada.CorreoPersonal
    End Sub

    Private Sub ActualizarTabla()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = personas
    End Sub

    Private Sub InitializeComponent()

        Dim labelNombre As New Label()
        labelNombre.Text = "Nombre:"
        labelNombre.Location = New Point(10, 10)
        Me.Controls.Add(labelNombre)

        textBoxNombre.Location = New Point(150, 10)
        Me.Controls.Add(textBoxNombre)

        Dim labelApellidoPaterno As New Label()
        labelApellidoPaterno.Text = "Apellido Paterno:"
        labelApellidoPaterno.Location = New Point(10, 40)
        Me.Controls.Add(labelApellidoPaterno)

        textBoxApellidoPaterno.Location = New Point(150, 40)
        Me.Controls.Add(textBoxApellidoPaterno)

        Dim labelApellidoMaterno As New Label()
        labelApellidoMaterno.Text = "Apellido Materno:"
        labelApellidoMaterno.Location = New Point(10, 70)
        Me.Controls.Add(labelApellidoMaterno)

        textBoxApellidoMaterno.Location = New Point(150, 70)
        Me.Controls.Add(textBoxApellidoMaterno)

        Dim labelRut As New Label()
        labelRut.Text = "RUT:"
        labelRut.Location = New Point(10, 100)
        Me.Controls.Add(labelRut)

        textBoxRut.Location = New Point(150, 100)
        Me.Controls.Add(textBoxRut)

        Dim labelTelefono As New Label()
        labelTelefono.Text = "Teléfono:"
        labelTelefono.Location = New Point(10, 130)
        Me.Controls.Add(labelTelefono)

        textBoxTelefono.Location = New Point(150, 130)
        Me.Controls.Add(textBoxTelefono)

        Dim labelCorreo As New Label()
        labelCorreo.Text = "Correo:"
        labelCorreo.Location = New Point(10, 160)
        Me.Controls.Add(labelCorreo)

        textBoxCorreo.Location = New Point(150, 160)
        Me.Controls.Add(textBoxCorreo)

        Dim labelDireccion As New Label()
        labelDireccion.Text = "Dirección:"
        labelDireccion.Location = New Point(10, 190)
        Me.Controls.Add(labelDireccion)

        textBoxDireccion.Location = New Point(150, 190)
        Me.Controls.Add(textBoxDireccion)

        buttonAccion.Text = "Agregar Persona"
        buttonAccion.Location = New Point(10, 220)
        Me.Controls.Add(buttonAccion)
    End Sub

    Private Function ButtonAccion_Click() As Object
        Throw New NotImplementedException()
    End Function
End Class


Public Class FormAgregarEditar
    Inherits Form

    Public Property PersonaActual As New Form1.Persona()

    Private textBoxNombre As New TextBox()
    Private textBoxApellidoPaterno As New TextBox()
    Private textBoxApellidoMaterno As New TextBox()
    Private textBoxRut As New TextBox()
    Private textBoxTelefono As New TextBox()
    Private textBoxCorreo As New TextBox()
    Private textBoxDireccion As New TextBox()

    Private buttonAccion As New Button()

    Public Sub New()



    End Sub

    Public Sub New(personaSeleccionada As Form1.Persona)


        PersonaActual = personaSeleccionada
        textBoxNombre.Text = personaSeleccionada.Nombre
        textBoxApellidoPaterno.Text = personaSeleccionada.ApellidoPaterno
        textBoxApellidoMaterno.Text = personaSeleccionada.ApellidoMaterno
        textBoxRut.Text = personaSeleccionada.Rut
        textBoxTelefono.Text = personaSeleccionada.Telefono
        textBoxCorreo.Text = personaSeleccionada.Correo
        textBoxDireccion.Text = personaSeleccionada.Direccion

        buttonAccion.Text = "Editar Persona"
        buttonAccion.Location = New Point(10, 220)
        AddHandler buttonAccion.Click, AddressOf ButtonAccion_Click
        Me.Controls.Add(buttonAccion)
    End Sub

    Private Sub ButtonAccion_Click(sender As Object, e As EventArgs)
        PersonaActual.Nombre = textBoxNombre.Text
        PersonaActual.ApellidoPaterno = textBoxApellidoPaterno.Text
        PersonaActual.ApellidoMaterno = textBoxApellidoMaterno.Text
        PersonaActual.Rut = textBoxRut.Text
        PersonaActual.Telefono = textBoxTelefono.Text
        PersonaActual.Correo = textBoxCorreo.Text
        PersonaActual.Direccion = textBoxDireccion.Text

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
