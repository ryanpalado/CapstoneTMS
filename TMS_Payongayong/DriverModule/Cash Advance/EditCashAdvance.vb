Imports Telerik.WinControls

Public Class EditCashAdvance

    Private Sub EditCashAdvance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EditCashAdvance_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ViewDriver.Enabled = True
        ViewDriver.btnEdit_Bal.Enabled = False
    End Sub

    Private Sub btnEditCashAdv_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCashAdv.Click
        Try
            If radioBtnAdd.IsChecked = True Then
                modifyQuery("update tbl_drivers_cashadvance set amount = amount + '" & txtCashAdvAmount.Text & "', reason = '" & txtCashAdvReason.Text & "' where balance_no = '" & lblIDCashAdvEdit.Text & "' ")
                modifyQuery("Update tbl_drivers_remainingbalance set remaining_balance = remaining_balance + '" & txtCashAdvAmount.Text & "' where rembal_id='" & lblIDCashAdvEdit.Text & "';")

            ElseIf radioBtnDeduct.IsChecked = True Then
                modifyQuery("update tbl_drivers_cashadvance set amount = amount - '" & txtCashAdvAmount.Text & "', reason = '" & txtCashAdvReason.Text & "' where balance_no = '" & lblIDCashAdvEdit.Text & "' ")
                modifyQuery("Update tbl_drivers_remainingbalance set remaining_balance = remaining_balance - '" & txtCashAdvAmount.Text & " where rembal_id='" & lblIDCashAdvEdit.Text & "';")

            End If
            remainingbalance()
            getCashAdvanceFromDB()
            '   modifyQuery("update tbl_drivers_funds set amount = '" & txtFundAmount.Text & "' where fund_no = '" & lblIDFundEdit.Text & "' ")
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Cash Advance Successfully Updated", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
