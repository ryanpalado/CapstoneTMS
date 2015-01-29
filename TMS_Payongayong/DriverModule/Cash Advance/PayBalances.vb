Imports Telerik.WinControls

Public Class PayBalances

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click

        If txtPayBalAmount.Text = "" And drpdwnPaymentMode.Text = "" Then
            lblNoAmount.Visible = True
            lblNopayment.Visible = True
            Return
        Else

        End If

        If txtPayBalAmount.Text = "" Then
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

            If ViewDriver.lblTotalBalance.Text = 0 Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("You do not have balance to pay.")
                Return
            End If

            If ViewDriver.lblRemainFunds.Text = 0 Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("Sorry you have zero balance.")
                Return
            End If

            If Val(ViewDriver.lblTotalBalance.Text) < Val(txtPayBalAmount.Text) Then
                txtPayBalAmount.Clear()
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "You only have " & ViewDriver.lblTotalBalance.Text & " Balance. Do you want to fully paid it? ", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dialog = MsgBoxResult.Yes Then
                    txtPayBalAmount.Text = ViewDriver.lblTotalBalance.Text
                End If
                Return
            End If

            If Val(txtPayBalAmount.Text) > Val(ViewDriver.lblRemainFunds.Text) Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "You only have " & ViewDriver.lblRemainFunds.Text & ". Do you want to use your remaining balance? ", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dialog = MsgBoxResult.Yes Then
                    txtPayBalAmount.Text = ViewDriver.lblRemainFunds.Text
                    PaymentFrmFunds()
                    Me.Close()
                End If
                Return
            End If


            If Val(ViewDriver.lblTotalBalance.Text) > Val(txtPayBalAmount.Text) Then
                PaymentFrmFunds()
            End If

            If Val(txtPayBalAmount.Text) < Val(ViewDriver.lblRemainFunds.Text) Then
                PaymentFrmFunds()
            End If
        Else

        End If
        remainingbalance()

    End Sub

    Public Sub PaymentCash()
        Try
            Dim date_today As String = Today
            Dim day_today As Date = date_today

            modifyQuery("insert into tbl_drivers_paybalances (full_date,driver_id,amount,details,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtPayBalAmount.Text).ToString("F2") & "','" & drpdwnPaymentMode.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remainingbalance set remaining_balance = remaining_balance - '" & txtPayBalAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")


            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

            remaining_funds()

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub PaymentFrmFunds()
        Try
            Dim date_today As String = Today
            Dim day_today As Date = date_today

            modifyQuery("insert into tbl_drivers_paybalances (full_date,driver_id,amount,details,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & txtPayBalAmount.Text & "','" & drpdwnPaymentMode.Text & "' ,'" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remainingbalance set remaining_balance = remaining_balance - '" & txtPayBalAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtPayBalAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
            remainingbalance()
            remaining_funds()

            Me.Close()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub lblPayBalAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayBalAmount.TextChanged

        If txtPayBalAmount.Text = "" Then
            lblNoAmount.Visible = True

        Else
            lblNoAmount.Visible = False
        End If
        Return
    End Sub

    Private Sub drpdwnPaymentMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnPaymentMode.SelectedIndexChanged

        If drpdwnPaymentMode.Text = "" Then
            lblNopayment.Visible = True

        Else
            lblNopayment.Visible = False
        End If
        Return
    End Sub

    Private Sub PayBalances_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
    End Sub

    Private Sub PayBalances_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Dim max = ViewDriver.lblTotalBalance.Text.ToString

        txtPayBalAmount.MaxLength = 10
    End Sub

    Private Sub txtPayBalAmount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayBalAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
