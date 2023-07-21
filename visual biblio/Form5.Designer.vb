<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarUnRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarRegistroToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1346, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarRegistroToolStripMenuItem
        '
        Me.AgregarRegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosDeLibrosToolStripMenuItem, Me.BorrarUnRegistroToolStripMenuItem})
        Me.AgregarRegistroToolStripMenuItem.Name = "AgregarRegistroToolStripMenuItem"
        Me.AgregarRegistroToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.AgregarRegistroToolStripMenuItem.Text = "Agregar Registro"
        '
        'PedidosDeLibrosToolStripMenuItem
        '
        Me.PedidosDeLibrosToolStripMenuItem.Name = "PedidosDeLibrosToolStripMenuItem"
        Me.PedidosDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PedidosDeLibrosToolStripMenuItem.Text = "pedidos de libros "
        '
        'BorrarUnRegistroToolStripMenuItem
        '
        Me.BorrarUnRegistroToolStripMenuItem.Name = "BorrarUnRegistroToolStripMenuItem"
        Me.BorrarUnRegistroToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.BorrarUnRegistroToolStripMenuItem.Text = "borrar un registro"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.visual_biblio.My.Resources.Resources._81d
        Me.ClientSize = New System.Drawing.Size(1346, 728)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosDeLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarUnRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
