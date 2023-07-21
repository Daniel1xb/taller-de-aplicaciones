Imports MySql.Data.MySqlClient
Public Class Form2
    Dim obj As New modulo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Sub consulta(ByVal Tablita As DataGridView, ByVal Sql As String)

        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL

        ':::Cambiamos el nombre del procedimiento "operaciones"
        obj.operaciones(Tablita, Sql)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Select * from dato"


        ':::Mediante el objeto que creamos globalmente y nombramos "Obj"
        ':::Accedemos a nuestro procedimiento "consulta" y le pasamos los
        ':::dos (2) parametros (DGTabla, Sql)
        obj.consulta(tablita, Sql)
        Try
            '--------------------------------------------------------------------------------------------------------------------------------------------------'
            con.Open()
            cmd = New MySqlCommand("insert into biblioteca.informacion(nombre,apellido,rut,libro,fecha_de_entrega,fecha_de_devolucion)" & Chr(13) &
                                    "values(@nombre,@apellido,@rut,@libro,@fecha_de_entrega,@fecha_de_devolucion)", con)


            cmd.Parameters.AddWithValue("@nombre", TextBox1.Text)
            cmd.Parameters.AddWithValue("@apellido", TextBox2.Text)
            cmd.Parameters.AddWithValue("@rut", TextBox3.Text)
            cmd.Parameters.AddWithValue("@libro", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@fecha_de_entrega", DateTimePicker1.Text)
            cmd.Parameters.AddWithValue("@fecha_de_devolucion", DateTimePicker2.Text)
            cmd.ExecuteNonQuery()
            MsgBox("datos guardados")



            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        'aqui esta el ingreso de datos'
        '---------------------------------------------------------------------------------------------------------------------------------------------------------'
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles agregar.Click
        Dim Sql As String = "Select * from dato" = "Insert Into dato (id, nombre, apellido) Select  " ' & TextBox1.Text & '", "' & TextBox2.Text & '","' & TextBox3.Text & '","' & combobox1.Text & '"
        obj.operaciones(tablita, Sql)
    End Sub
End Class