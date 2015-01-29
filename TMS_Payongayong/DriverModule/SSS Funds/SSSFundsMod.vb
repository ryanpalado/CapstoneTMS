Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Module SSSFundsMod
    Public Sub remaining_sssfunds()
        selectQuery("select * from tbl_drivers_remaining_sssfunds where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            ViewDriver.lblRemainSSS.Text = dr.Item("remaining_sssfunds")
        End If
    End Sub

    Public Sub getsssfundsFromDB()
        ViewDriver.lvSSSFunds.Items.Clear()
        'select SHORTBOUNDARY
        selectQuery("SELECT tbl_drivers_sssfunds.fund_id, tbl_drivers_sssfunds.full_date,tbl_drivers_sssfunds.driver_id, tbl_drivers_sssfunds.amount, tbl_drivers_sssfunds.payment_mode, tbl_drivers_sssfunds.encoded_by from tbl_drivers_info, tbl_drivers_sssfunds where tbl_drivers_info.driver_id = tbl_drivers_sssfunds.driver_id AND tbl_drivers_sssfunds.driver_id='" & ViewDriver.lblDriverID.Text & "'; ")

        While dr.Read
            Dim lvl As System.Windows.Forms.ListViewItem
            lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("fund_id").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("payment_mode").ToString, dr.Item("encoded_by").ToString}, -1)
            ViewDriver.lvSSSFunds.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
        End While

    End Sub

End Module
