Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class TransactionCashAdvance

    Private Sub TransactionCashAdvance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        getDataPayBalance()
    End Sub

    Public Sub getDataPayBalance()

        lvPayBalance.Items.Clear()
        'select all drivers info

        selectQuery("SELECT * from tbl_drivers_paybalances where driver_id='" & ViewDriver.lblDriverID.Text & "'")

        While dr.Read
            Dim lvl As System.Windows.Forms.ListViewItem
            lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
            lvPayBalance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
        End While


    End Sub

    ''=======>Sort by Month
    Public Sub MonthCashAdv()
        lvPayBalance.Items.Clear()
        selectQuery("select * from tbl_drivers_funds where month='" & drpdwnMonth.Text & "' AND year='" & drpdwnYear.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                lvPayBalance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            lvPayBalance.Items.Clear()
            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                lvPayBalance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While

            Return
        End If

    End Sub


    Public Sub YearCashAdv()
        lvPayBalance.Items.Clear()
        selectQuery("select * from tbl_drivers_cashadvance where year='" & drpdwnYear.Text & "' AND month='" & drpdwnMonth.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

        If dr.HasRows Then
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                lvPayBalance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While
            Return
        Else
            lvPayBalance.Items.Clear()
            While dr.Read
                Dim lvl As System.Windows.Forms.ListViewItem
                lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("encoded_by").ToString}, -1)
                lvPayBalance.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
            End While

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")

            Return
        End If


    End Sub

   
    Private Sub drpdwnMonth_SelectedIndexChanged(sender As System.Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnMonth.SelectedIndexChanged
        MonthCashAdv()
    End Sub

    Private Sub drpdwnYear_SelectedIndexChanged(sender As System.Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnYear.SelectedIndexChanged
        YearCashAdv()
    End Sub
End Class
