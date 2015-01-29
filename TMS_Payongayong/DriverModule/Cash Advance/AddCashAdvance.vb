Imports Telerik.WinControls
Public Class AddCashAdvance

    Private Sub AddCashAdvance_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
    End Sub

    Private Sub AddCashAdvance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' Label1.Text = Format(dr("date"), "dd")

    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Try
            If txtCashAdvAmount.Text = "" And lblReason.Text = "" Then
                lblNoAmount.Visible = True
                lblNoReason.Visible = True
                Return
            Else

            End If

            If txtCashAdvAmount.Text = "" Then
                lblNoAmount.Visible = True
                Return
            Else

            End If

            If lblReason.Text = "" Then
                lblNoReason.Visible = True
                Return
            Else

            End If


            Dim date_today As String = Today
            Dim day_today As Date = date_today


            selectQuery("select * from tbl_drivers_remainingbalance where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
            If dr.HasRows Then
                modifyQuery("Update tbl_drivers_remainingbalance set remaining_balance = remaining_balance + '" & txtCashAdvAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")

                modifyQuery("insert into tbl_drivers_cashadvance (full_date,driver_id,amount,reason,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & txtCashAdvAmount.Text & "' ,'" & lblReason.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ); ")

                ' modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtCashAdvAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
                getCashAdvanceFromDB()

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Cash Advance successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                remainingbalance()

                Me.Close()

            ElseIf ViewDriver.lblTotalBalance.Text = "0.00" Then
                'updateFunds()
                modifyQuery("insert into tbl_drivers_remainingbalance(driver_id,remaining_balance) values('" & ViewDriver.lblDriverID.Text & "','" & txtCashAdvAmount.Text & "');")
                modifyQuery("insert into tbl_drivers_cashadvance (full_date,driver_id,amount,reason,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtCashAdvAmount.Text).ToString("F2") & "' ,'" & lblReason.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Cash Advance successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
                remainingbalance()

                Me.Close()

            Else

                modifyQuery("insert into tbl_drivers_cashadvance (full_date,driver_id,amount,reason,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtCashAdvAmount.Text).ToString("F2") & "' ,'" & lblReason.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
                modifyQuery("Update tbl_drivers_remainingbalance set remaining_balance = remaining_balance + '" & txtCashAdvAmount.Text & "' where rembal_id='" & lblbalID.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "';")

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Cash Advance successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                remainingbalance()

                Me.Close()
            End If


            Return
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub lbl_BalID()
        selectQuery("select * from tbl_drivers_remainingbalance where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            lblbalID.Text = dr.Item("bal_no")
        End If
    End Sub


    Private Sub txtCashAdvAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCashAdvAmount.TextChanged
        If txtCashAdvAmount.Text = "" Then
            lblNoAmount.Visible = True
            Return
        Else
            lblNoAmount.Visible = False
        End If
    End Sub

    Private Sub lblReason_TextChanged(sender As System.Object, e As System.EventArgs) Handles lblReason.TextChanged
        If lblReason.Text = "" Then
            lblNoReason.Visible = True
        Else
            lblNoReason.Visible = False
        End If
        Return

    End Sub

    Private Sub txtCashAdvAmount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashAdvAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
