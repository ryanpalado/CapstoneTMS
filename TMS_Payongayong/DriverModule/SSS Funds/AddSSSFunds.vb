Imports Telerik.WinControls

Public Class AddSSSFunds

   

    Public Sub PaymentCash()
      
            Dim date_today As String = Today
            Dim day_today As Date = date_today

        If ViewDriver.lblRemainSSS.Text = "0.00" Then

            modifyQuery("insert into tbl_drivers_sssfunds (full_date,driver_id,amount,payment_mode,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtSSSAmount.Text).ToString("F2") & "','" & drpdwnPaymentMode.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
            modifyQuery("insert into tbl_drivers_remaining_sssfunds (remaining_sssfunds, driver_id) values ( '" & Decimal.Parse(txtSSSAmount.Text).ToString("F2") & "','" & ViewDriver.lblDriverID.Text & "') ")


            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Taxi Damages successfully paid.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

            remaining_sssfunds()

            Me.Close()

        ElseIf ViewDriver.lblRemainSSS.Text <> "0.00" Then
            modifyQuery("insert into tbl_drivers_sssfunds (full_date,driver_id,amount,payment_mode,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtSSSAmount.Text).ToString("F2") & "','" & drpdwnPaymentMode.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remaining_sssfunds set remaining_sssfunds = remaining_sssfunds + '" & txtSSSAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")


            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Taxi Damages successfully paid.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

            remaining_sssfunds()

            Me.Close()

        End If

    End Sub

    Public Sub PaymentFrmFunds()
        If txtSSSAmount.Text = "" And drpdwnPaymentMode.Text = "" Then
            lblNoAmount.Visible = True
            lblNopayment.Visible = True
            Return
        Else

        End If

        If txtSSSAmount.Text = "" Then
            lblNoAmount.Visible = True
            Return
        Else

        End If

        If drpdwnPaymentMode.Text = "" Then
            lblNopayment.Visible = True
            Return
        Else

        End If
        Dim date_today As String = Today
        Dim day_today As Date = date_today

        If ViewDriver.lblRemainSSS.Text = "0.00" Then
            modifyQuery("insert into tbl_drivers_sssfunds (full_date,driver_id,amount,payment_mode,encoded_by,month,date,year) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtSSSAmount.Text).ToString("F2") & "','" & drpdwnPaymentMode.Text & "' ,'" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblDate.Text & "','" & Dashboard.lblYear.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtSSSAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            modifyQuery("insert into tbl_drivers_remaining_sssfunds (remaining_sssfunds, driver_id) values ( '" & Decimal.Parse(txtSSSAmount.Text).ToString("F2") & "','" & ViewDriver.lblDriverID.Text & "') ")

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "SSS Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
            getsssfundsFromDB()
            remaining_funds()
            remaining_sssfunds()
            Me.Close()

        ElseIf ViewDriver.lblRemainSSS.Text <> "0.00" Then
            modifyQuery("insert into tbl_drivers_sssfunds (full_date,driver_id,amount,payment_mode,encoded_by,month,date,year) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtSSSAmount.Text).ToString("F2") & "','" & drpdwnPaymentMode.Text & "' ,'" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblDate.Text & "','" & Dashboard.lblYear.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtSSSAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            modifyQuery("Update tbl_drivers_remaining_sssfunds set remaining_sssfunds = remaining_sssfunds + '" & txtSSSAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "SSS Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
            getsssfundsFromDB()
            remaining_funds()
            remaining_sssfunds()
            Me.Close()

        End If


    End Sub




    Private Sub AddSSSFunds_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
    End Sub

    Private Sub btnAddSSS_Click(sender As System.Object, e As System.EventArgs) Handles btnAddSSS.Click
        If txtSSSAmount.Text = "" And drpdwnPaymentMode.Text = "" Then
            lblNoAmount.Visible = True
            lblNopayment.Visible = True
            Return
        Else

        End If

        If txtSSSAmount.Text = "" Then
            lblNoAmount.Visible = True
            Return
        Else

        End If

        If drpdwnPaymentMode.Text = "" Then
            lblNopayment.Visible = True
            Return
        Else

        End If


        If drpdwnPaymentMode.Text = "Cash" Then
            PaymentCash()
        ElseIf drpdwnPaymentMode.Text = "Cash from Funds" Then
            PaymentFrmFunds()
        Else
        End If

    End Sub

    Private Sub AddSSSFunds_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSSSAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSSSAmount.TextChanged
        If txtSSSAmount.Text = "" Then
            lblNoAmount.Visible = True

        Else
            lblNoAmount.Visible = False
        End If
        Return
    End Sub

    Private Sub drpdwnPaymentMode_SelectedIndexChanged(sender As System.Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnPaymentMode.SelectedIndexChanged
        If drpdwnPaymentMode.Text = "" Then
            lblNopayment.Visible = True

        Else
            lblNopayment.Visible = False
        End If
        Return
    End Sub

    Private Sub txtSSSAmount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSSAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
