
Imports System.Globalization
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim obj As New libro

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    '::Creamos la variable Sql que guardar la instruccion de tipo SQL

    ':::Cambiamos el nombre del procedimiento "operaciones"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Sql As String = "Insert Into biblioteca.informacion (nombre, apellido, rut, libro, fecha_de_entrega, fecha_de_devolucion) Select  '" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "' , '" & DateTimePicker2.Text & "'"
        obj.operaciones(tablita, Sql)
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL




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

    Private Sub Button4_Click(sender As Object, e As EventArgs)
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


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub tablita_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablita.CellContentClick

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Public Sub cargardatos()
        Try
            con.Open()
            Dim Sql As String = "select * from libros "
            wr = New MySqlDataAdapter(Sql, con)
            wr.Fill(ds, "libros")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargardatos()
        Try
            ComboBox1.DataSource = ds.Tables("libros")
            ComboBox1.ValueMember = "nombre_Libro"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class