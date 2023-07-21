Public Class Form7
    Private Sub IngresoDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeDatosToolStripMenuItem.Click

    End Sub

    Private Sub SolicitarUnLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarUnLibroToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeLibrosToolStripMenuItem.Click
        End
    End Sub

    Private Sub EliminarUnRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUnRegistroToolStripMenuItem.Click
        Me.Hide()
        Form9.Show()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GestionDeUsuarioToolStripMenuItem.Enabled = False
        GestionDelibrosToolStripMenuItem.Enabled = False



    End Sub

    Private Sub CrearUsuarioComunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuarioComunToolStripMenuItem.Click

    End Sub

    Private Sub GestionDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuarioToolStripMenuItem.Click

    End Sub
End Class