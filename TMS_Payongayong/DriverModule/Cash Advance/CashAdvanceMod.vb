Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Module CashAdvanceMod

    'ALL OF THE COMMANDS REGARDING TO THE CASHADVANCE ARE HERE

    '---------------- CASHADVANCE------------------'

    'Fetching of cashadvance and displays to the gridDriver(GridView)
    Public Sub getCashAdvanceFromDB()

        ViewDriver.lvCashAdvance.Items.Clear()
        ''select all drivers info
        selectQuery("SELECT tbl_drivers_cashadvance.balance_no,tbl_drivers_cashadvance.full_date,tbl_drivers_cashadvance.amount, tbl_drivers_cashadvance.reason, tbl_drivers_cashadvance.encoded_by from tbl_drivers_info, tbl_drivers_cashadvance where tbl_drivers_info.driver_id = tbl_drivers_cashadvance.driver_id AND tbl_drivers_cashadvance.driver_id='" & ViewDriver.lblDriverID.Text & "'; ")
        'selectQuery("select * from tbl_drivers_cashadvance")
        'While dr.Read
        While dr.Read

            Dim lvl As System.Windows.Forms.ListViewItem
            lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("balance_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("reason").ToString, dr.Item("encoded_by").ToString}, -1)
            ViewDriver.lvCashAdvance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})



            'Dim lvl As Telerik.WinControls.UI.ListViewDataItem
            'lvl = New Telerik.WinControls.UI.ListViewDataItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("reason").ToString, dr.Item("encoded_by").ToString})
            'ViewDriver.RadListView1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {lvl})


            'ViewDriver.RadListView1.Columns.Add("Column1")
            'ViewDriver.RadListView1.Columns.Add("Column2", "Column2Header")
            'ViewDriver.RadListView1.Columns.Add(New ListViewDetailColumn("Column3", "Column3Header"))


            'ViewDriver.RadListView1.Items.Add(New ListViewDataItem(dr.Item("full_date").ToString()))
            'ViewDriver.RadListView1.Items.Add(dr.Item("amount").ToString())
            'ViewDriver.RadListView1.Items.Add(dr.Item("reason").ToString())
            'ViewDriver.RadListView1.Items.Add(dr.Item("encoded_by").ToString())


        End While

        'ViewDriver.lvCashAdvance.Items.Add(New ListViewDataItem(dr.Item("full_date").ToString() + dr.Item("amount").ToString() + dr.Item("reason").ToString() + dr.Item("encoded_by").ToString()))
        'Dim item As ListViewDataItem = ViewDriver.lvCashAdvance.Items(0)



        'End While
    End Sub

    Public Sub remainingbalance()
        selectQuery("select * from tbl_drivers_remainingbalance where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            ViewDriver.lblTotalBalance.Text = dr.Item("remaining_balance")
        End If
    End Sub


    ''=======>Sort by Month
    Public Sub queryMontCashAdv()
        ViewDriver.lvCashAdvance.Items.Clear()
        selectQuery("select * from tbl_drivers_funds where month='" & ViewDriver.drpdwnMonthCA.Text & "' AND year='" & ViewDriver.drpdwnYearCA.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("balance_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvCashAdvance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            ViewDriver.lvCashAdvance.Items.Clear()
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("balance_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvCashAdvance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While

            Return
        End If

    End Sub


    Public Sub queryYearCashAdv()
        ViewDriver.lvCashAdvance.Items.Clear()
        selectQuery("select * from tbl_drivers_cashadvance where year='" & ViewDriver.drpdwnYearCA.Text & "' AND month='" & ViewDriver.drpdwnMonthCA.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("balance_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvCashAdvance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            ViewDriver.lvCashAdvance.Items.Clear()
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("balance_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvCashAdvance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")

            Return
        End If


    End Sub



End Module
