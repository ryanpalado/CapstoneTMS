Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Module DriversFundMod

    'ALL OF THE COMMANDS REGARDING TO THE DRIVER ACCOUNTS ARE HERE

    '---------------- DRIVERS FUND------------------'

    'Fetching of all drivers funds and displays to the lvDriverFunds(ListView)
    Public Sub getAllDriversFundFromDB()
        'clear listview
        ViewDriver.lvDriversFund.Items.Clear()
        'select all drivers info

        selectQuery("SELECT tbl_drivers_funds.fund_no,tbl_drivers_funds.full_date, tbl_drivers_funds.amount, tbl_drivers_funds.encoded_by from tbl_drivers_info, tbl_drivers_funds where tbl_drivers_info.driver_id = tbl_drivers_funds.driver_id AND tbl_drivers_funds.driver_id='" & ViewDriver.lblDriverID.Text & "'; ")

        While dr.Read
            Dim lvl As System.Windows.Forms.ListViewItem
            lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("fund_no").ToString, dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
            ViewDriver.lvDriversFund.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
        End While
        ComputeTotalFunds()

    End Sub



    Public Sub updateFunds()
        modifyQuery("Update tbl_drivers_remaining_funds set remaining_funds = remaining_funds + '" & AddFunds.txtFundAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
    End Sub

    Public Sub addFundsRemain()
        modifyQuery("insert into tbl_drivers_remaining_funds(driver_id,remaining_funds) values('" & ViewDriver.lblDriverID.Text & "','" & AddFunds.txtFundAmount.Text & "')")
    End Sub

    Public Sub remaining_funds()
        selectQuery("select * from tbl_drivers_remaining_funds where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            ViewDriver.lblRemainFunds.Text = dr.Item("remaining_funds")
        End If
    End Sub


    Public Sub deductRemainbalance()
        modifyQuery("Update tbl_drivers_remainingbalance set remaining_balance = remaining_balance - '" & ViewDriver.lblAmount.Text & "' where driver_id='" & ViewDriver.lblDriverID.Text & "';")
    End Sub


    Public Sub viewremainingbalance()
        selectQuery("select * from tbl_drivers_cashadvance where driver_id='" & ViewDriver.lblDriverID.Text & "' ")
        If dr.HasRows Then
            ViewDriver.lblBalNo.Text = dr.Item("balance_no")
            ViewDriver.lblAmount.Text = dr.Item("amount")
        End If
    End Sub


    ''=======>Sort by Month
    Public Sub queryMontDriver()
        ViewDriver.lvDriversFund.Items.Clear()
        selectQuery("select * from tbl_drivers_cashadvance where month='" & ViewDriver.drpdwnMonth.Text & "' AND year='" & ViewDriver.drpdwnYear.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvDriversFund.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvCashAdvance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            ViewDriver.lvDriversFund.Items.Clear()
            Return
        End If

    End Sub


    Public Sub queryYearDriver()
        ViewDriver.lvDriversFund.Items.Clear()
        selectQuery("select * from tbl_drivers_funds where year='" & ViewDriver.drpdwnYear.Text & "' OR month='" & ViewDriver.drpdwnMonth.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvDriversFund.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                ViewDriver.lvDriversFund.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            ViewDriver.lvDriversFund.Items.Clear()
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")

            Return
        End If


    End Sub

    Public Sub ComputeTotalFunds()

        '-------------> DRIVERS TOTAL AMOUNT OF FUNDS <-----------
        Dim TotalSum As Double = 0
        Dim TempNode As ListViewItem
        For Each TempNode In ViewDriver.lvDriversFund.Items
            TotalSum += CDbl(TempNode.SubItems.Item(2).Text)
        Next

        ViewDriver.lblTotalFunds.Text = Decimal.Parse(TotalSum).ToString("F2")


    End Sub


    'Public Sub queryBalanceStatus()

    '        selectQuery("select * from tbl_drivers_cashadvance where balance_status='" & ViewDriver.drpdwnBalStatus.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")
    '        queryBalances()

    'End Sub

    'Public Sub queryBalances()
    '    If dr.HasRows Then
    '        'setting datasource
    '        ViewDriver.gridDriverFunds.DataSource = dr
    '    End If

    '    'change header text of the grid
    '    With ViewDriver.gridDriverFunds
    '        .Columns(2).HeaderText = "Fund No."
    '        .Columns(3).HeaderText = "Date"
    '        .Columns(4).HeaderText = "Day"
    '        .Columns(6).HeaderText = "Amount"
    '        .Columns(7).HeaderText = "Encoded By"

    '        ''Hide columns
    '        .Columns(2).IsVisible = False
    '        .Columns(5).IsVisible = False
    '        .Columns(8).IsVisible = False
    '        .Columns(9).IsVisible = False
    '        .Columns(10).IsVisible = False
    '        .Columns(11).IsVisible = False
    '        'Fit all the columns
    '        .Columns(0).Width = 100
    '        .Columns(1).Width = 100
    '        .Columns(2).Width = 200
    '        .Columns(3).Width = 200
    '        .Columns(4).Width = 200
    '        .Columns(5).Width = 200
    '        .Columns(6).Width = 200
    '        .Columns(7).Width = 200

    '    End With
    'End Sub


    '-------------------END DRIVERS FUND -------------------'



End Module
