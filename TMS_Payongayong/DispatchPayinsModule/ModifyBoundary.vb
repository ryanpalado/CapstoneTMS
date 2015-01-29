Public Class ModifyBoundary

    Private Sub ModifyBoundary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Val(ADDDispatch.txtboundary.Text)
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtnewboundary.Text = txtconfirm.Text Then
            Me.Hide()
            Dashboard.Show()
            selectQuery("update tbl_boundary set boundary ='" & txtnewboundary.Text & "' ;")
            boundaryset()
        Else
            MsgBox("Please Confirm Boundary")
            txtconfirm.Text = ""
            txtnewboundary.Text = ""

        End If
    End Sub

End Class
