Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Module TaxiDamagesMod
    'ALL OF THE COMMANDS REGARDING TO THE TAXIDAMAGES ARE HERE

    '---------------- TAXIDAMAGES------------------'

    'Fetching of TAXIDAMAGES and displays to the gridDriver(GridView)
    Public Sub gettaxidamageFromDB()
        ViewDriver.lvTaxiDamages.Items.Clear()
        'select TAXIDAMAGES
        selectQuery("SELECT tbl_drivers_taxidamages.record_no, tbl_drivers_taxidamages.full_date,tbl_drivers_taxidamages.driver_id, tbl_drivers_taxidamages.amount, tbl_drivers_taxidamages.descript, tbl_drivers_taxidamages.encoded_by from tbl_drivers_info, tbl_drivers_taxidamages where tbl_drivers_info.driver_id = tbl_drivers_taxidamages.driver_id AND tbl_drivers_taxidamages.driver_id='" & ViewDriver.lblDriverID.Text & "'; ")

        While dr.Read
            Dim lvl As System.Windows.Forms.ListViewItem
            lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("record_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("descript").ToString, dr.Item("encoded_by").ToString}, -1)
            ViewDriver.lvTaxiDamages.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
        End While


    End Sub



    Public Sub remaining_taxiDamages()
        selectQuery("select * from tbl_drivers_remaining_taxidamages where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            ViewDriver.lblRemTaxiDamage.Text = dr.Item("remaining_taxidamage")
        End If
    End Sub

    Public Sub deductRemainTaxiDamage()
        modifyQuery("Update tbl_drivers_remaining_taxidamages set remaining_taxidamage = remaining_taxidamage - '" & ViewDriver.lblDamageAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
    End Sub

    Public Sub viewremainingTaxiDamages()
        selectQuery("select * from tbl_drivers_taxidamages where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            ViewDriver.lblDamageNo.Text = dr.Item("record_no")
            ViewDriver.lblDamageAmount.Text = dr.Item("amount")
        End If
    End Sub

    ''=======>Sort by Month
    Public Sub queryMonthTD()
        ViewDriver.lvTaxiDamages.Items.Clear()
        selectQuery("select * from tbl_drivers_taxidamages where month='" & ViewDriver.drpdwnMonthTD.Text & "' AND year='" & ViewDriver.drpdwnYearTD.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("record_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvTaxiDamages.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            ViewDriver.lvTaxiDamages.Items.Clear()
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("record_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvTaxiDamages.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While

            Return
        End If

    End Sub


    Public Sub queryYearTD()
        ViewDriver.lvTaxiDamages.Items.Clear()
        selectQuery("select * from tbl_drivers_taxidamages where year='" & ViewDriver.drpdwnYearTD.Text & "' AND month='" & ViewDriver.drpdwnMonthTD.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("record_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvTaxiDamages.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            ViewDriver.lvTaxiDamages.Items.Clear()
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("record_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvTaxiDamages.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")

            Return
        End If


    End Sub

End Module
