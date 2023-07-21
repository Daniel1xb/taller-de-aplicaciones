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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresoDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarUnLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUnRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuarioComunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUnLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirUnLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeDatosToolStripMenuItem, Me.GestionDeUsuarioToolStripMenuItem, Me.GestionDeLibrosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1392, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresoDeDatosToolStripMenuItem
        '
        Me.IngresoDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolicitarUnLibroToolStripMenuItem, Me.EliminarUnRegistroToolStripMenuItem})
        Me.IngresoDeDatosToolStripMenuItem.Name = "IngresoDeDatosToolStripMenuItem"
        Me.IngresoDeDatosToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.IngresoDeDatosToolStripMenuItem.Text = "Ingreso De Datos"
        '
        'SolicitarUnLibroToolStripMenuItem
        '
        Me.SolicitarUnLibroToolStripMenuItem.Name = "SolicitarUnLibroToolStripMenuItem"
        Me.SolicitarUnLibroToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.SolicitarUnLibroToolStripMenuItem.Text = "solicitar un libro"
        '
        'EliminarUnRegistroToolStripMenuItem
        '
        Me.EliminarUnRegistroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EliminarUnRegistroToolStripMenuItem.Name = "EliminarUnRegistroToolStripMenuItem"
        Me.EliminarUnRegistroToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.EliminarUnRegistroToolStripMenuItem.Text = "eliminar un registro"
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
        Me.CrearUsuarioComunToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.CrearUsuarioComunToolStripMenuItem.Text = "Crear usuario comun"
        '
        'GestionDeLibrosToolStripMenuItem
        '
        Me.GestionDeLibrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarUnLibroToolStripMenuItem, Me.AñadirUnLibroToolStripMenuItem})
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
        'AñadirUnLibroToolStripMenuItem
        '
        Me.AñadirUnLibroToolStripMenuItem.Name = "AñadirUnLibroToolStripMenuItem"
        Me.AñadirUnLibroToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AñadirUnLibroToolStripMenuItem.Text = "Añadir un libro"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.visual_biblio.My.Resources.Resources._81d
        Me.ClientSize = New System.Drawing.Size(1392, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IngresoDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarUnLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUnRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuarioComunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUnLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirUnLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
