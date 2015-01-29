Imports Telerik.WinControls

Public Class AddRecord

    Private Sub AddRecord_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ViewDriver.Enabled = True
    End Sub

    Private Sub AddRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click

        Try

            If drpdwnCalcuAmount.Value = "" And txtDescrip.Text = "" Then
                lblNoAmount.Visible = True
                lblNoReason.Visible = True
                Return
            Else

            End If

            If drpdwnCalcuAmount.Text = "" Then
                lblNoAmount.Visible = True
                Return
            Else

            End If

            If txtDescrip.Text = "" Then
                lblNoReason.Visible = True
                Return
            Else

            End If

            Dim date_today As String = Today
            Dim day_today As Date = date_today

            selectQuery("select * from tbl_drivers_remaining_taxidamages where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
            If dr.HasRows Then
                modifyQuery("Update tbl_drivers_remaining_taxidamages set remaining_taxidamage = remaining_taxidamage + '" & drpdwnCalcuAmount.Value & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
                modifyQuery("insert into tbl_drivers_taxidamages (full_date,driver_id,amount,descript,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & drpdwnCalcuAmount.Value & "' ,'" & txtDescrip.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ); ")
                gettaxidamageFromDB()

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "taxidamages successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
                remaining_taxiDamages()
                remaining_funds()

                Me.Close()
            ElseIf ViewDriver.lblRemTaxiDamage.Text = "0.00" Then

                modifyQuery("insert into tbl_drivers_remaining_taxidamages(remaining_taxidamage,driver_id) values('" & drpdwnCalcuAmount.Value & "','" & ViewDriver.lblDriverID.Text & "')")

                modifyQuery("insert into tbl_drivers_taxidamages(full_date,driver_id,amount,descript,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & drpdwnCalcuAmount.Value & "' ,'" & txtDescrip.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")

                remaining_taxiDamages()
                gettaxidamageFromDB()
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Taxi Damages successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                Me.Close()

            ElseIf ViewDriver.lblRemTaxiDamage.Text <> "0.00" Then
                modifyQuery("insert into tbl_drivers_taxidamages (full_date,driver_id,amount,descript,encoded_by,month,year,date) values ('" & date_today & "','" & ViewDriver.lblDriverID.Text & "', '" & drpdwnCalcuAmount.Value & "' ,'" & txtDescrip.Text & "','" & Dashboard.userName.Text & "','" & Dashboard.lblMonth.Text & "','" & Dashboard.lblYear.Text & "','" & Dashboard.lblDate.Text & "' ) ")
                modifyQuery("Update tbl_drivers_remaining_taxidamages set remaining_taxidamage = remaining_taxidamage + '" & drpdwnCalcuAmount.Value & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")

                remaining_taxiDamages()
                remaining_funds()
                gettaxidamageFromDB()
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Taxi Damages successfully added.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)


                Me.Close()

            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub drpdwnCalcuAmount_CalculatorValueChanged(sender As System.Object, e As System.EventArgs) Handles drpdwnCalcuAmount.CalculatorValueChanged
        If drpdwnCalcuAmount.Text = "" Then
            lblNoAmount.Visible = True

        Else
            lblNoAmount.Visible = False
        End If
        Return
    End Sub

    Private Sub txtDescrip_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescrip.TextChanged
        If txtDescrip.Text = "" Then
            lblNoReason.Visible = True

        Else
            lblNoReason.Visible = False
        End If
        Return
    End Sub

    Private Sub drpdwnCalcuAmount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles drpdwnCalcuAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
