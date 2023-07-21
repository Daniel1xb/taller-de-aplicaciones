Public Class Form5
    Private Sub PedidosDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosDeLibrosToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub BorrarUnRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarUnRegistroToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class