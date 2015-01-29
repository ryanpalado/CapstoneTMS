Imports Telerik.WinControls

Public Class PayDamages

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If txtPayDamageAmount.Text = "" And drpdwnPaymentMode.Text = "" Then
            lblNoAmount.Visible = True
            lblNopayment.Visible = True
            Return
        Else

        End If

        If txtPayDamageAmount.Text = "" Then
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
            If ViewDriver.lblTotalBalance.Text = 0 Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("You do not have balance to pay.")
                Return
            Else
                PaymentCash()
            End If
        ElseIf drpdwnPaymentMode.Text = "From funds" Then
            Dim total_bal As String
            total_bal = ViewDriver.lblRemTaxiDamage.Text
            If Double.Parse(txtPayDamageAmount.Text) > total_bal Then
                txtPayDamageAmount.Clear()
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "You only have " & ViewDriver.lblRemTaxiDamage.Text & " Balance. Do you want to fully paid it? ", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dialog = MsgBoxResult.Yes Then
                    txtPayDamageAmount.Text = (ViewDriver.lblRemTaxiDamage.Text).ToString
                    Return
                Else : dialog = MsgBoxResult.No
                    Return
                End If
                Return
            End If


            If ViewDriver.lblRemTaxiDamage.Text = 0 Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("You do not have balance to pay.")
                Return
            End If

            If ViewDriver.lblRemainFunds.Text = 0 Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("Sorry you have zero balance.")
                Return
            End If

            If Val(ViewDriver.lblRemainFunds.Text) < Val(txtPayDamageAmount.Text) Then

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "You only have " & ViewDriver.lblRemainFunds.Text & ". Do you want to use your remaining balance? ", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dialog = MsgBoxResult.Yes Then
                    txtPayDamageAmount.Text = ViewDriver.lblRemainFunds.Text
                    PaymentFrmFunds()
                    Me.Close()
                Else : dialog = MsgBoxResult.No
                    Return
                End If
            End If

            If Val(ViewDriver.lblRemTaxiDamage.Text) < Val(txtPayDamageAmount.Text) Then
                txtPayDamageAmount.Clear()
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "You only have " & ViewDriver.lblRemTaxiDamage.Text & " Balance. Do you want to fully paid it? ", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dialog = MsgBoxResult.Yes Then
                    txtPayDamageAmount.Text = ViewDriver.lblRemTaxiDamage.Text
                End If
                Return
            End If

            If Val(ViewDriver.lblRemainFunds.Text) > Val(txtPayDamageAmount.Text) Then

                PaymentFrmFunds()
                Return
            End If


            If Val(ViewDriver.lblRemTaxiDamage.Text) > Val(txtPayDamageAmount.Text) Then
                PaymentFrmFunds()
            End If


        End If
        remaining_taxiDamages()


    End Sub

    Public Sub PaymentCash()
        Try
            Dim date_today As String = Today
            Dim day_today As Date = date_today

            modifyQuery("insert into tbl_drivers_paydamages (full_date,driver_id,amount,payment_mode,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtPayDamageAmount.Text).ToString("F2") & "','" & drpdwnPaymentMode.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remaining_taxidamages set remaining_taxidamage = remaining_taxidamage - '" & txtPayDamageAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")


            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Taxi Damages successfully paid.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

            remaining_taxiDamages()

            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub PaymentFrmFunds()
        Try
            Dim date_today As String = Today
            Dim day_today As Date = date_today

            modifyQuery("insert into tbl_drivers_paydamages (full_date,driver_id,amount,payment_mode,encoded_by,month,date,year) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtPayDamageAmount.Text).ToString("F2") & "','" & drpdwnPaymentMode.Text & "' ,'" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblDate.Text & "','" & Dashboard.lblYear.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remaining_taxidamages set remaining_taxidamage = remaining_taxidamage - '" & txtPayDamageAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtPayDamageAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

            remaining_funds()
            remaining_taxiDamages()
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PayDamages_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
    End Sub

    Private Sub PayDamages_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPayDamageAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPayDamageAmount.TextChanged
        If txtPayDamageAmount.Text = "" Then
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

    Private Sub txtPayDamageAmount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayDamageAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
