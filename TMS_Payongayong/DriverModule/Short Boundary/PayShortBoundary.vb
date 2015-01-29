Imports Telerik.WinControls

Public Class PayShortBoundary

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        submit()
    End Sub

    Public Sub submit()

        If txtPayShortBoundary.Text = "" And drpdwnPaymentMode.Text = "" Then
            lblNoAmount.Visible = True
            lblNopayment.Visible = True
            Return
        Else

        End If

        If txtPayShortBoundary.Text = "" Then
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
            If ViewDriver.lblRemainShortBoundary.Text = 0 Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("You do not have balance to pay.")
                Return
            Else
                PaymentCash()
            End If
        ElseIf drpdwnPaymentMode.Text = "From funds" Then



            If ViewDriver.lblRemainShortBoundary.Text = 0 Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("You do not have balance to pay.")
                Return
            End If

            If ViewDriver.lblRemainFunds.Text = 0 Then
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("Sorry you have zero balance.")
                Return
            End If


            If Val(txtPayShortBoundary.Text) > Val(ViewDriver.lblRemainShortBoundary.Text) Then
                txtPayShortBoundary.Clear()
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "You only have " & ViewDriver.lblRemainShortBoundary.Text & " Balance. Do you want to fully paid it? ", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dialog = MsgBoxResult.Yes Then
                    txtPayShortBoundary.Text = ViewDriver.lblRemainShortBoundary.Text
                End If
                Return
            End If

            If Val(txtPayShortBoundary.Text) > Val(ViewDriver.lblRemainFunds.Text) Then

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "You only have " & ViewDriver.lblRemainFunds.Text & ". Do you want to use your remaining balance? ", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dialog = MsgBoxResult.Yes Then
                    txtPayShortBoundary.Text = ViewDriver.lblRemainFunds.Text
                    PaymentFrmFunds()
                    Me.Close()
                Else : dialog = MsgBoxResult.No

                End If

            End If

            If Val(txtPayShortBoundary.Text) < Val(ViewDriver.lblRemainFunds.Text) Then
                PaymentFrmFunds()
            End If

            If Val(txtPayShortBoundary.Text) < Val(ViewDriver.lblRemainShortBoundary.Text) Then
                PaymentFrmFunds()
            End If

        Else

        End If
        remaining_ShortBoundary()
    End Sub


    Public Sub PaymentCash()
        Try
            Dim date_today As String = Today
            Dim day_today As Date = date_today
            modifyQuery("insert into tbl_drivers_payshortboundary (full_date,driver_id,amount,payment_mode,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & Decimal.Parse(txtPayShortBoundary.Text).ToString("F2") & "','" & drpdwnPaymentMode.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remaining_shortboundary set remaining_shortboundary = remaining_shortboundary - '" & txtPayShortBoundary.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            remaining_ShortBoundary()
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Taxi Damages successfully paid.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
            Me.Close()

        Catch ex As Exception
            Return
        End Try


    End Sub

    Public Sub PaymentFrmFunds()

        Try
            Dim date_today As String = Today
            Dim day_today As Date = date_today

            modifyQuery("insert into tbl_drivers_payshortboundary (full_date,driver_id,amount,payment_mode,encoded_by,month,date,year) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & txtPayShortBoundary.Text & "','" & drpdwnPaymentMode.Text & "' ,'" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblDate.Text & "','" & Dashboard.lblYear.Text & "' ) ")
            modifyQuery("Update tbl_drivers_remaining_shortboundary set remaining_shortboundary = remaining_shortboundary - '" & txtPayShortBoundary.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds - '" & txtPayShortBoundary.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
            remaining_funds()
            remaining_ShortBoundary()
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Fund successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
            Me.Close()

        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub drpdwnPaymentMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnPaymentMode.SelectedIndexChanged

        If drpdwnPaymentMode.Text = "" Then
            lblNopayment.Visible = True
        Else
            lblNopayment.Visible = False
        End If
        Return
    End Sub

    Private Sub PayShortBoundary_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
    End Sub

    Private Sub PayShortBoundary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPayShortBoundary_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPayShortBoundary.TextChanged

        If txtPayShortBoundary.Text = "" Then
            lblNoAmount.Visible = True
        Else
            lblNoAmount.Visible = False
        End If
        Return
    End Sub

    Private Sub txtPayShortBoundary_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayShortBoundary.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub


End Class
