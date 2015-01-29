Imports Telerik.WinControls

Public Class AddFunds

    Private Sub AddFunds_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
    End Sub

    Private Sub AddFunds_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddFunds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFunds.Click


        If txtFundAmount.Text = "" Then
            lblNoAmount.Visible = True
            Return
        Else
        End If

        Try

            Dim date_today As String = Today
            Dim day_today As Date = date_today
            selectQuery("select * from tbl_drivers_remaining_funds where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
            If dr.HasRows Then
                modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds + '" & txtFundAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")

                modifyQuery("insert into tbl_drivers_funds (full_date,day,driver_id,amount,encoded_by,month,year,date) values ('" & date_today & "','" & day_today.ToString("dddd") & "' ,'" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtFundAmount.Text).ToString("F2") & "' ,'" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")

                ' modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtCashAdvAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
                getAllDriversFundFromDB()

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)


                remaining_funds()
                getAllDriversFundFromDB()

                Me.Close()

            ElseIf ViewDriver.lblRemainFunds.Text = "0.00" Then
                'updateFunds()
                addFundsRemain()
                modifyQuery("insert into tbl_drivers_funds (full_date,day,driver_id,amount,encoded_by,month,year,date) values ('" & date_today & "','" & day_today.ToString("dddd") & "' ,'" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtFundAmount.Text).ToString("F2") & "' ,'" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ); ")
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                remaining_funds()
                getAllDriversFundFromDB()

                Me.Close()

            Else
                updateFunds()
                modifyQuery("insert into tbl_drivers_funds (full_date,day,driver_id,amount,encoded_by,month,year,date) values ('" & date_today & "','" & day_today.ToString("dddd") & "' ,'" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtFundAmount.Text).ToString("F2") & "' ,'" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)


                remaining_funds()
                getAllDriversFundFromDB()

                Me.Close()
            End If
            Return
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub txtFundAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFundAmount.TextChanged

        If txtFundAmount.Text = "" Then
            lblNoAmount.Visible = True
        Else
            lblNoAmount.Visible = False
        End If
        Return
    End Sub

    Private Sub txtFundAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFundAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
