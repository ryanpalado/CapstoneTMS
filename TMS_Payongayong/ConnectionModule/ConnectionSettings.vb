Imports MySql.Data.MySqlClient

Public Class ConnectionSettings

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim con As New MySqlConnection("server=" & txtse.Text & ";uid=" & txtu.Text & ";pwd=" & txtp.Text & ";port=" & txtpo.Text & ";database=" & txtdbase.Text & ";")
        Try
            con.Close()
            con.Open()
            MsgBox("Connected")
            btnSave.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            btnSave.Enabled = False
        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With sets
            .serverko = txtse.Text
            .userko = txtu.Text
            .portko = txtpo.Text
            .passko = txtp.Text
            .databaseko = txtdbase.Text
            .Save()

        End With
        MsgBox("Saved")
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        sets.Reset()
    End Sub

    Private Sub txtse_TextChanged(sender As Object, e As EventArgs) Handles txtse.TextChanged
        btnSave.Enabled = False
    End Sub

    Private Sub txtu_TextChanged(sender As Object, e As EventArgs) Handles txtu.TextChanged
        btnSave.Enabled = False
    End Sub

    Private Sub txtp_TextChanged(sender As Object, e As EventArgs) Handles txtp.TextChanged
        btnSave.Enabled = False
    End Sub

    Private Sub txtpo_TextChanged(sender As Object, e As EventArgs) Handles txtpo.TextChanged
        btnSave.Enabled = False
    End Sub

    Private Sub txtdbase_TextChanged(sender As Object, e As EventArgs) Handles txtdbase.TextChanged
        btnSave.Enabled = False
    End Sub
End Class
