Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Module ShortBoundaryMod

    'ALL OF THE COMMANDS REGARDING TO THE SHORTBOUNDARY ARE HERE

    '----------------SHORTBOUNDARY------------------'

    'Fetching of SHORTBOUNDARY and displays to the gridDriver(GridView)
    Public Sub getShortBoundaryFromDB()
        ViewDriver.lvShortBoundary.Items.Clear()
        'select SHORTBOUNDARY
        selectQuery("SELECT tbl_drivers_shortboundary.record_no, tbl_drivers_shortboundary.full_date,tbl_drivers_shortboundary.driver_id, tbl_drivers_shortboundary.amount, tbl_drivers_shortboundary.reason, tbl_drivers_shortboundary.encoded_by from tbl_drivers_info, tbl_drivers_shortboundary where tbl_drivers_info.driver_id = tbl_drivers_shortboundary.driver_id AND tbl_drivers_shortboundary.driver_id='" & ViewDriver.lblDriverID.Text & "'; ")

        While dr.Read
            Dim lvl As System.Windows.Forms.ListViewItem
            lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("reason").ToString, dr.Item("encoded_by").ToString}, -1)
            ViewDriver.lvShortBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})

        End While

    End Sub



    Public Sub remaining_ShortBoundary()
        selectQuery("select * from tbl_drivers_remaining_shortboundary where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            ViewDriver.lblRemainShortBoundary.Text = dr.Item("remaining_shortboundary")
        End If
    End Sub

    Public Sub deductRemainShortBoundary()
        modifyQuery("Update tbl_drivers_remaining_taxidamages set remaining_taxidamage = remaining_taxidamage - '" & ViewDriver.lblDamageAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
    End Sub

    Public Sub viewremainingShortBoundary()
        selectQuery("select * from tbl_drivers_shortboundary where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            ViewDriver.lblDamageNo.Text = dr.Item("record_no")
            ViewDriver.lblDamageAmount.Text = dr.Item("amount")
        End If
    End Sub

    ''=======>Sort by Month
    Public Sub queryMonthSB()
        ViewDriver.lvShortBoundary.Items.Clear()
        selectQuery("select * from tbl_drivers_shortboundary where month='" & ViewDriver.drpdwnMonthSB.Text & "' AND year='" & ViewDriver.drpdwnYearSB.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvShortBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            ViewDriver.lvShortBoundary.Items.Clear()
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvShortBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While

            Return
        End If

    End Sub


    Public Sub queryYearSB()
        ViewDriver.lvShortBoundary.Items.Clear()
        selectQuery("select * from tbl_drivers_shortboundary where year='" & ViewDriver.drpdwnYearSB.Text & "' AND month='" & ViewDriver.drpdwnMonthSB.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvShortBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            ViewDriver.lvShortBoundary.Items.Clear()
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvShortBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")

            Return
        End If


    End Sub



End Module
