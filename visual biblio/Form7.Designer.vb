<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresoDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarUnLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUnRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuarioComunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUnLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeDatosToolStripMenuItem, Me.GestionDeUsuarioToolStripMenuItem, Me.GestionDeLibrosToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1407, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresoDeDatosToolStripMenuItem
        '
        Me.IngresoDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolicitarUnLibroToolStripMenuItem, Me.EliminarUnRegistroToolStripMenuItem})
        Me.IngresoDeDatosToolStripMenuItem.Name = "IngresoDeDatosToolStripMenuItem"
        Me.IngresoDeDatosToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.IngresoDeDatosToolStripMenuItem.Text = "Ingreso de Datos"
        '
        'SolicitarUnLibroToolStripMenuItem
        '
        Me.SolicitarUnLibroToolStripMenuItem.Name = "SolicitarUnLibroToolStripMenuItem"
        Me.SolicitarUnLibroToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.SolicitarUnLibroToolStripMenuItem.Text = "Solicitar un libro"
        '
        'EliminarUnRegistroToolStripMenuItem
        '
        Me.EliminarUnRegistroToolStripMenuItem.Name = "EliminarUnRegistroToolStripMenuItem"
        Me.EliminarUnRegistroToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.EliminarUnRegistroToolStripMenuItem.Text = "Eliminar un registro"
        '
        'GestionDeUsuarioToolStripMenuItem
        '
        Me.GestionDeUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioComunToolStripMenuItem})
        Me.GestionDeUsuarioToolStripMenuItem.Name = "GestionDeUsuarioToolStripMenuItem"
        Me.GestionDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.GestionDeUsuarioToolStripMenuItem.Text = "Gestion de usuario"
        '
        'CrearUsuarioComunToolStripMenuItem
        '
        Me.CrearUsuarioComunToolStripMenuItem.Name = "CrearUsuarioComunToolStripMenuItem"
        Me.CrearUsuarioComunToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.CrearUsuarioComunToolStripMenuItem.Text = "Crear usuario Comun"
        '
        'GestionDeLibrosToolStripMenuItem
        '
        Me.GestionDeLibrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarUnLibroToolStripMenuItem, Me.AgregarUnLibroToolStripMenuItem})
        Me.GestionDeLibrosToolStripMenuItem.Name = "GestionDeLibrosToolStripMenuItem"
        Me.GestionDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.GestionDeLibrosToolStripMenuItem.Text = "Gestion de libros"
        '
        'EliminarUnLibroToolStripMenuItem
        '
        Me.EliminarUnLibroToolStripMenuItem.Name = "EliminarUnLibroToolStripMenuItem"
        Me.EliminarUnLibroToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EliminarUnLibroToolStripMenuItem.Text = "Eliminar un libro"
        '
        'AgregarUnLibroToolStripMenuItem
        '
        Me.AgregarUnLibroToolStripMenuItem.Name = "AgregarUnLibroToolStripMenuItem"
        Me.AgregarUnLibroToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AgregarUnLibroToolStripMenuItem.Text = "Agregar un libro"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem1.Text = "salir"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.visual_biblio.My.Resources.Resources._81d
        Me.ClientSize = New System.Drawing.Size(1407, 556)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents IngresoDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarUnLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUnRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuarioComunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUnLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUnLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
End Class
