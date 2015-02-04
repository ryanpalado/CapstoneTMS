Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Module MysqlQueries
    'Declaring Database Connection
    Public sets As New My.MySettings
    Public conn As New MySqlConnection("server=" & sets.serverko & ";uid=" & sets.userko & ";pwd=" & sets.passko & ";port=" & sets.portko & ";database=" & sets.databaseko & ";")
    Public dr As MySqlDataReader
    Public dt As DataTable
    Public da As MySqlDataAdapter
    Public cmb As MySqlCommandBuilder
    Public cmd As New MySqlCommand
    Public ds As New DataSet

    '------ODBC-----'
    'Public connnString As String = "DSN=tms_payongayong"
    'Public com As OdbcCommand
    'Public dr As OdbcDataReader
    'Public com As OdbcCommand
    'Public conn As OdbcConnection = New OdbcConnection(connnString)
    'Public da As OdbcDataAdapter
    'Public cmb As OdbcCommandBuilder
    'Public cmd As OdbcCommand


    Public Function getnow(ByVal q As String) As String
        Try
            conn.Close()
            conn.Open()
            Dim ad As New MySqlDataAdapter(q, conn)
            dt = New DataTable
            ad.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    'SELECT COMMAND
    Public Function selectQuery(ByVal q As String) As String
        Try
            conn.Close()
            conn.Open()
            Dim query = New MySqlCommand(String.Format(q), conn)
            dr = query.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function

    'INSERT INTO, UPDATE, DELETE COMMAND
    Public Sub modifyQuery(ByVal q As String)
        Try
            conn.Close()
            conn.Open()
            Dim query = New MySqlCommand(String.Format(q), conn)
            query.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
