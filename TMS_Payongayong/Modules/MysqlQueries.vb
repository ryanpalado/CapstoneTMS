Imports System.Data.Odbc

Module MysqlQueries
    Public connnString As String = "DSN=tms_payongayong"
    Public dr As OdbcDataReader
    Public com As OdbcCommand
    Public conn As OdbcConnection = New OdbcConnection(connnString)
    Public dt As DataTable
    Public da As OdbcDataAdapter
    Public cmb As OdbcCommandBuilder
    Public ds As New DataSet
    Public cmd As New OdbcCommand

    'SELECT COMMAND
    Public Function selectQuery(ByVal q As String) As String
        Try
            conn.Close()
            conn.Open()
            Dim query = New OdbcCommand(String.Format(q), conn)
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
            Dim query = New OdbcCommand(String.Format(q), conn)
            query.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
