Imports Telerik.WinControls

Public Class AddShortBoundary

    Private Sub AddShortBoundary_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
    End Sub

    Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRecord.Click
        If txtShortBoundaryAmount.Text = "" And txtShortBoundaryReason.Text = "" Then
            lblNoAmount.Visible = True
            lblNoReason.Visible = True
            Return
        Else

        End If

        If txtShortBoundaryAmount.Text = "" Then
            lblNoAmount.Visible = True
            Return
        Else

        End If

        If txtShortBoundaryReason.Text = "" Then
            lblNoReason.Visible = True
            Return
        Else

        End If




        Dim date_today As String = Today
        Dim day_today As Date = date_today

        selectQuery("select * from tbl_drivers_remaining_shortboundary where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            modifyQuery("Update tbl_drivers_remaining_shortboundary set remaining_shortboundary = remaining_shortboundary + '" & txtShortBoundaryAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")

            modifyQuery("insert into tbl_drivers_shortboundary (full_date,driver_id,amount,reason,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & txtShortBoundaryAmount.Text & "' ,'" & txtShortBoundaryReason.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ); ")

            ' modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtCashAdvAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            getShortBoundaryFromDB()

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Short Boundary successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

            remaining_ShortBoundary()

            Me.Close()


        ElseIf ViewDriver.lblRemainShortBoundary.Text = "0.00" Then
            'updateFunds()
            modifyQuery("insert into tbl_drivers_remaining_shortboundary(remaining_shortboundary,driver_id) values('" & txtShortBoundaryAmount.Text & "','" & ViewDriver.lblDriverID.Text & "');")
            modifyQuery("insert into tbl_drivers_shortboundary (full_date,driver_id,amount,reason,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & txtShortBoundaryAmount.Text & "' ,'" & txtShortBoundaryReason.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' );")
            getShortBoundaryFromDB()

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Short Boundary successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

            remaining_ShortBoundary()

            Me.Close()
            ' modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtCashAdvAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
        ElseIf ViewDriver.lblRemainShortBoundary.Text <> "0.00" Then
            modifyQuery("Update tbl_drivers_remaining_shortboundary set remaining_shortboundary = remaining_shortboundary + '" & txtShortBoundaryAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")

            modifyQuery("insert into tbl_drivers_shortboundary (full_date,driver_id,amount,reason,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & txtShortBoundaryAmount.Text & "' ,'" & txtShortBoundaryReason.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ); ")

            ' modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtCashAdvAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            getShortBoundaryFromDB()

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Short Boundary successfully added (not =0) .", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

            remaining_ShortBoundary()

            Me.Close()
        End If

    End Sub

    Private Sub AddShortBoundary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadButton2_Click(sender As System.Object, e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub

    Private Sub txtShortBoundaryAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtShortBoundaryAmount.TextChanged

        If txtShortBoundaryAmount.Text = "" Then
            lblNoAmount.Visible = True
        Else
            lblNoAmount.Visible = False
        End If
        Return
    End Sub

    Private Sub txtShortBoundaryReason_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtShortBoundaryReason.TextChanged

        If txtShortBoundaryReason.Text = "" Then
            lblNoReason.Visible = True
        Else
            lblNoReason.Visible = False
        End If
        Return
    End Sub

    Private Sub txtShortBoundaryAmount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtShortBoundaryAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
