Imports MySql.Data.MySqlClient
Module Modulo
    Public con As New MySqlConnection("Data source= localhost;userid = root;password=;database=biblioteca")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
    Public wr As MySqlDataAdapter
    Public ds As New DataSet


End Module


