Public Class Form4
    Dim obj As New libro
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Sql As String = "Insert Into biblioteca.informacion (nombre, apellido, rut, libro, fecha_de_entrega, fecha_de_devolucion) Select  '" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "' , '" & DateTimePicker2.Text & "'"
        obj.operaciones(tablita, Sql)
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL




        'aqui esta el ingreso de datos'
        '---------------------------------------------------------------------------------------------------------------------------------------------------------'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Select * from biblioteca.informacion"
        ':::Mediante el objeto que creamos globalmente y nombramos "Obj"
        ':::Accedemos a nuestro procedimiento "consulta" y le pasamos los
        ':::dos (2) parametros (DGTabla, Sql)
        obj.consulta(tablita, Sql)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Sql As String = "Delete From informacion Where nombre= '" & TextBox1.Text & "'"
        obj.operaciones(tablita, Sql)
    End Sub

    Private Sub Tablita_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablita.CellContentClick
        'aca hice que al hacer doble click en la tabla pase algo *sale mal*'
        tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox1.Text = tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = tablita.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = tablita.CurrentRow.Cells(2).Value.ToString()
        ComboBox1.Text = tablita.CurrentRow.Cells(3).Value.ToString()
        DateTimePicker1.Text = tablita.CurrentRow.Cells(4).Value.ToString()
        DateTimePicker2.Text = tablita.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class