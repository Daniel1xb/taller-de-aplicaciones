﻿Imports MySql.Data.MySqlClient
Public Class libro
    ':::Creamos nuestra conexión a la base de Datos
    Dim con As New MySqlConnection("server=localhost; user=root; database=biblioteca")


    ':::Creamos el procedimiento conexion
    Sub conexion()
        ':::Instruccion Try para capturar errores
        Try
            ':::Abrimos nuestro conexion con la propiedad Open
            con.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "Gente")
            ':::Y cerramos la conexion
            con.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "Gente")
        End Try
    End Sub

    ':::Creamos el procedimiento para la consulta y le indicamos que debe pedir 2 parametros para 
    ':::ejecutarse correctamente (Tabla, Sql)
    Sub consulta(ByVal Tabla As DataGridView, ByVal Sql As String)
        ':::Instruccion Try para capturar errores
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            Dim DA As New MySqlDataAdapter(Sql, con)
            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable
            ':::Pasamos la informacion del DataAdapter al DataTable mediante la propiedad Fill
            DA.Fill(DT)
            ':::Ahora mostramos los datos en el DataGridView
            Tabla.DataSource = DT
        Catch ex As Exception
            MsgBox("No se logro realizar la consulta por: " & ex.Message, MsgBoxStyle.Critical, "Gente")
        End Try
    End Sub

    ':::Creamos el procedimiento para Agregar, Actualizar y Eliminar ademas le indicamos que debe pedir
    ':::2 parametros para ejecutarse correctamente (Tabla, Sql)
    Sub operaciones(ByVal Tabla As DataGridView, ByVal Sql As String)
        ':::Abrimos la conexion
        con.Open()
        ':::Instruccion Try para capturar errores
        Try
            ':::Creamos nuestro objeto de tipo Command que almacenara nuestras instrucciones
            ':::Necesita 2 parametros (Instruccion, conexion)
            Dim cmd As New MySqlCommand(Sql, con)
            ':::Ejecutamos la instruccion mediante la propiedad ExecuteNonQuery del command
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se logro realizar la operación por: " & ex.Message, MsgBoxStyle.Critical, "Gente")
        End Try
        ':::Cerramos la conexion
        con.Close()
    End Sub

End Class
