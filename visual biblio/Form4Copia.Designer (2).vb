
Public Class Form2
    Dim obj As New libro


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    'Sub consulta(ByVal Tablita As DataGridView, ByVal Sql As String)

    ':::Creamos la variable Sql que guardar la instruccion de tipo SQL

    ':::Cambiamos el nombre del procedimiento "operaciones"
    'obj.operaciones(Tablita, Sql)
    'End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Sql As String = "Insert Into biblioteca.informacion (nombre, apellido, rut, libro, fecha_de_entrega, fecha_de_devolucion) Select  '" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "' , '" & DateTimePicker2.Text & "'"
        obj.operaciones(tablita, Sql)
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL



        ':::Mediante el objeto que creamos globalmente y nombramos "Obj"
        ':::Accedemos a nuestro procedimiento "consulta" y le pasamos los
        ':::dos (2) parametros (DGTabla, Sql)
        'obj.consulta(tablita, Sql)

        'aqui esta el ingreso de datos'
        '---------------------------------------------------------------------------------------------------------------------------------------------------------'
    End Sub












    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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
        tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox1.Text = tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = tablita.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = tablita.CurrentRow.Cells(2).Value.ToString()
        ComboBox1.Text = tablita.CurrentRow.Cells(3).Value.ToString()
        DateTimePicker1.Text = tablita.CurrentRow.Cells(4).Value.ToString()
        DateTimePicker2.Text = tablita.CurrentRow.Cells(5).Value.ToString()
    End Sub


End Class