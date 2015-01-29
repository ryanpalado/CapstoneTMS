Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class TransactionShortBoundary

    Private Sub TransactionShortBoundary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        getDataPayBoundary()
    End Sub

    Public Sub getDataPayBoundary()
        lvPayBoundary.Items.Clear()
        'select SHORTBOUNDARY
        selectQuery("SELECT * from tbl_drivers_payshortboundary where driver_id='" & ViewDriver.lblDriverID.Text & "'; ")

        While dr.Read
            Dim lvl As System.Windows.Forms.ListViewItem
            lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("payment_mode").ToString, dr.Item("encoded_by").ToString}, -1)
            lvPayBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})

        End While

    End Sub

    ''=======>Sort by Month
    Public Sub MonthShortBoundary()
        Try
            lvPayBoundary.Items.Clear()
            selectQuery("select * from tbl_drivers_funds where month='" & drpdwnMonth.Text & "' AND year='" & drpdwnYear.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

            If dr.HasRows Then
                While dr.Read
                    Dim lvl As System.Windows.Forms.ListViewItem
                    lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("payment_mode").ToString, dr.Item("encoded_by").ToString}, -1)
                    lvPayBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})

                End While
                Return
            Else
                While dr.Read
                    Dim lvl As System.Windows.Forms.ListViewItem
                    lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("payment_mode").ToString, dr.Item("encoded_by").ToString}, -1)
                    lvPayBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})

                End While
                lvPayBoundary.Items.Clear()
                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")
                Return
            End If

        Catch ex As Exception

        End Try

    End Sub


    Public Sub YearShortBoundary()
        Try
            lvPayBoundary.Items.Clear()
            selectQuery("select * from tbl_drivers_payshortboundary where year='" & drpdwnYear.Text & "' AND month='" & drpdwnMonth.Text & "' AND driver_id='" & ViewDriver.lblDriverID.Text & "' ;")

            If dr.HasRows Then
                While dr.Read
                    Dim lvl As System.Windows.Forms.ListViewItem
                    lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("payment_mode").ToString, dr.Item("encoded_by").ToString}, -1)
                    lvPayBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})

                End While
                Return
            Else
                lvPayBoundary.Items.Clear()
                While dr.Read
                    Dim lvl As System.Windows.Forms.ListViewItem
                    lvl = New System.Windows.Forms.ListViewItem(New String() {dr.Item("full_date").ToString, dr.Item("amount").ToString, dr.Item("payment_mode").ToString, dr.Item("encoded_by").ToString}, -1)
                    lvPayBoundary.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})

                End While

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show("Sorry no transaction found.")

                Return
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub drpdwnMonth_SelectedIndexChanged(sender As System.Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnMonth.SelectedIndexChanged
        MonthShortBoundary()
    End Sub

    Private Sub drpdwnYear_SelectedIndexChanged(sender As System.Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnYear.SelectedIndexChanged
        YearShortBoundary()
    End Sub
End Class
