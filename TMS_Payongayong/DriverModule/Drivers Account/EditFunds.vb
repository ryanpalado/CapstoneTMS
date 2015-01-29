Imports Telerik.WinControls

Public Class EditFunds

    Private Sub EditFunds_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
        ViewDriver.btn_editFunds.Enabled = False
    End Sub

    Private Sub EditFunds_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewfunds()
        viewremainID()
    End Sub

    Private Sub btnEditFunds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditFunds.Click

        Try
            If radioBtnAdd.IsChecked = True Then
                modifyQuery("Update tbl_drivers_funds set amount = amount + '" & txtFundAmount.Text & "' where fund_no='" & lblIDFundEdit.Text & "';")
                modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds + '" & txtFundAmount.Text & "' where remain_id='" & lblremainID.Text & "';")

            ElseIf radioBtnDeduct.IsChecked = True Then
                modifyQuery("Update tbl_drivers_funds set amount = amount - '" & txtFundAmount.Text & "' where fund_no='" & lblIDFundEdit.Text & "';")
                modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtFundAmount.Text & "' where remain_id='" & lblremainID.Text & "';")

            End If
            remaining_funds()
            getAllDriversFundFromDB()
            '   modifyQuery("update tbl_drivers_funds set amount = '" & txtFundAmount.Text & "' where fund_no = '" & lblIDFundEdit.Text & "' ")
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Record Successfully Updated", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    ' ------------------>>> extract fund id for updating
    Public Sub viewfunds()


        selectQuery("select * from tbl_drivers_funds where fund_no='" & lblIDFundEdit.Text & "' ")
        If dr.HasRows Then
            lblPrevAmount.Text = Decimal.Parse(dr.Item("amount")).ToString("F2")

        End If
    End Sub


    ' ------------------>>> extract remain_id for updating(hindi po kasi makapag-update gamit ang foreign key.. :/ )
    Public Sub viewremainID()


        selectQuery("select * from tbl_drivers_remaining_funds where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            lblremainID.Text = dr.Item("remain_id")
        End If
    End Sub
  
End Class
