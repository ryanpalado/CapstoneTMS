Public Class Passcode

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        'If txtpasscode.Text = "" Then
        '    MsgBox("Enter a passcode")

        'End If
        If txtpasscode.Text = Val(12345) Then
            Me.Hide()
            ModifyBoundary.Show()
        Else
            txtpasscode.Clear()
            Label2.Visible = True
        End If
        Return
    End Sub
End Class
