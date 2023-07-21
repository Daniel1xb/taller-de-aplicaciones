Public Class Form12
    Dim obj As New libro
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Sql As String = "Insert Into biblioteca.libros (nombre_Libro,autor) Select  '" & TextBox2.Text & "', '" & TextBox3.Text & "'"
        obj.operaciones(tablita, Sql)
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL




        'aqui esta el ingreso de datos'
        '----------------------------------------------------------------------------
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Select * from libros"
        ':::Mediante el objeto que creamos globalmente y nombramos "Obj"
        ':::Accedemos a nuestro procedimiento "consulta" y le pasamos los
        ':::dos (2) parametros (DGTabla, Sql)
        obj.consulta(tablita, Sql)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class