Public Class Form9
    Dim obj As New libro

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Select * from biblioteca.informacion"
        ':::Mediante el objeto que creamos globalmente y nombramos "Obj"
        ':::Accedemos a nuestro procedimiento "consulta" y le pasamos los
        ':::dos (2) parametros (DGTabla, Sql)
        obj.consulta(tablita, Sql)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Sql As String = "Delete From informacion Where nombre= '" & TextBox1.Text & "'"
        obj.operaciones(tablita, Sql)
    End Sub

    Private Sub tablita_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablita.CellDoubleClick
        'aca hice que al hacer doble click en la tabla se pueda eliminar los datos repetidos o simplemente uno solo'
        tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox1.Text = tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = tablita.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = tablita.CurrentRow.Cells(2).Value.ToString()
        ComboBox1.Text = tablita.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = False

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        ComboBox1.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form7.Show()

    End Sub

    Private Sub tablita_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablita.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class