Public Class Form8
    Dim obj As New libro

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form7.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Sql As String = "Insert Into biblioteca.informacion (nombre, apellido, rut, libro, fecha_de_entrega, fecha_de_devolucion) Select  '" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "' , '" & DateTimePicker2.Text & "'"
        obj.operaciones(tablita, Sql)
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL




        'aqui esta el ingreso de datos'
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Select * from biblioteca.informacion"
        ':::Mediante el objeto que creamos globalmente y nombramos "Obj"
        ':::Accedemos a nuestro procedimiento "consulta" y le pasamos los
        ':::dos (2) parametros (DGTabla, Sql)
        obj.consulta(tablita, Sql)
    End Sub

    Private Sub tablita_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablita.CellDoubleClick
        'aca hice que al hacer doble click en la tabla se pueda eliminar los datos repetidos o simplemente uno solo'
        tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox1.Text = tablita.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = tablita.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = tablita.CurrentRow.Cells(2).Value.ToString()
        ComboBox1.Text = tablita.CurrentRow.Cells(3).Value.ToString()
        DateTimePicker1.Text = tablita.CurrentRow.Cells(4).Value.ToString()
        DateTimePicker2.Text = tablita.CurrentRow.Cells(5).Value.ToString()
    End Sub
End Class