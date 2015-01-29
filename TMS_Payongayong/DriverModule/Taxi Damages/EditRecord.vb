Imports Telerik.WinControls

Public Class EditRecord

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Try
            If radioBtnAdd.IsChecked = True Then
                modifyQuery("update tbl_drivers_taxidamages set amount = amount + '" & editdrpdwnCalcuAmount.Value & "', descript = '" & txtDescript.Text & "' where record_no = '" & lblRecordID.Text & "' ")
                modifyQuery("Update tbl_drivers_remaining_taxidamages set remaining_taxidamage = remaining_taxidamage + '" & editdrpdwnCalcuAmount.Value & "' where remaining_id='" & lblRecordID.Text & "';")

            ElseIf radioBtnDeduct.IsChecked = True Then
                modifyQuery("update tbl_drivers_taxidamages set amount = amount + '" & editdrpdwnCalcuAmount.Value & "', descript = '" & txtDescript.Text & "' where record_no = '" & lblRecordID.Text & "' ")
                modifyQuery("Update tbl_drivers_remaining_taxidamages set remaining_taxidamage = remaining_taxidamage - '" & editdrpdwnCalcuAmount.Value & "' where remaining_id='" & lblRecordID.Text & "';")

            End If
            remaining_taxiDamages()
            gettaxidamageFromDB()
            ViewDriver.btn_editDamages.Enabled = False
            '   modifyQuery("update tbl_drivers_funds set amount = '" & txtFundAmount.Text & "' where fund_no = '" & lblIDFundEdit.Text & "' ")
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Taxi Damages sucessfully Updated", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
