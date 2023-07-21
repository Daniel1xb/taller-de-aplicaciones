Public Class Form1
    Private Sub GestionDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub SolicitarUnLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarUnLibroToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub EliminarUnRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUnRegistroToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()

    End Sub

    Private Sub CrearUsuarioComunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuarioComunToolStripMenuItem.Click
        Me.Hide()
        Form10.Show()

    End Sub

    Private Sub CrearUsuarioAdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BorraUnLibroToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form11.Show()
        Me.Close()

    End Sub

    Private Sub GestionDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuarioToolStripMenuItem.Click

    End Sub

    Private Sub EliminarUnLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUnLibroToolStripMenuItem.Click
        Form11.Show()
        Me.Close()

    End Sub

    Private Sub AñadirUnLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirUnLibroToolStripMenuItem.Click
        Form12.Show()
        Me.Close()
    End Sub
End Class