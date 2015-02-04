Public Class UpdateUSerstatus

    Private Sub UpdateUSerstatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getnow("Select user_id as 'User Id', full_name as 'Full Name', username as 'Username', `status` as 'Status' FROM `tbl_users`")
        RadGridView1.DataSource = dt

    End Sub

    Private Sub RadGridView1_DoubleClick(sender As Object, e As EventArgs) Handles RadGridView1.DoubleClick
        If RadGridView1.Rows.Count - 1 > 0 Then
            txtid.Text = RadGridView1.CurrentRow.Cells(0).Value
            txtfull.Text = RadGridView1.CurrentRow.Cells(1).Value
            txtuname.Text = RadGridView1.CurrentRow.Cells(2).Value
            txtstatus.Text = RadGridView1.CurrentRow.Cells(3).Value

        Else
            MsgBox("No data", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList1.SelectedIndexChanged

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        getnow("UPDATE tbl_users set status='" & RadDropDownList1.Text & "' where username='" & txtuname.Text & "'")
        MsgBox("Update success!")
        UpdateUSerstatus_Load(sender, e)

    End Sub
End Class
