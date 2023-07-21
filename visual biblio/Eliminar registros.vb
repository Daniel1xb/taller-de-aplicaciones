Public Class Form1
    Dim obj As New libro
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sql As String = "Select * from biblioteca.informacion"
        obj.consulta(tablita, Sql)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim Sql As String = "Delete From informacion Where nombre= '" & TextBox1.Text & "'"
        obj.operaciones(tablita, Sql)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub tablita_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablita.CellDoubleClick
        tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox1.Text = tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = tablita.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = tablita.CurrentRow.Cells(2).Value.ToString()
        ComboBox1.Text = tablita.CurrentRow.Cells(3).Value.ToString()
        DateTimePicker1.Text = tablita.CurrentRow.Cells(4).Value.ToString()
        DateTimePicker2.Text = tablita.CurrentRow.Cells(5).Value.ToString()
    End Sub
End Class