Imports MySql.Data.MySqlClient

Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
            MsgBox("Error, campos vacíos", vbExclamation, "Campos Vacíos")
        Else
            If CheckBox2.Checked Then

                If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
                    MsgBox("Error, campos vacíos", vbExclamation, "Campos Vacíos")
                Else
                    con.Open()
                    Dim sql = "SELECT * FROM login1 WHERE usuario = '" & TextBox1.Text & "' AND password= '" & TextBox2.Text & "'"
                    Dim cmd = New MySqlCommand(sql, con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader
                    Try
                        If dr.Read = False Then
                            MsgBox("NO REGISTRADO", vbCritical, "Login Inválido")
                        Else
                            MsgBox("LOGEO CORRECTO", vbInformation, "Login Satisfactorio")
                            Form1.Show()
                            Me.Hide()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    con.Close()
                End If

            Else

                con.Open()
                Dim sql = "SELECT * FROM login WHERE usuario = '" & TextBox1.Text & "' AND password= '" & TextBox2.Text & "'"
                Dim cmd = New MySqlCommand(sql, con)
                Dim dr As MySqlDataReader = cmd.ExecuteReader
                Try
                    If dr.Read = False Then
                        MsgBox("NO REGISTRADO", vbCritical, "Login Inválido")
                    Else
                        MsgBox("LOGEO CORRECTO", vbInformation, "Login Satisfactorio")
                        Form7.Show()
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                con.Close()

            End If 'es el if del checked'


        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
