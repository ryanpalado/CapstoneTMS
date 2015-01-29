Public Class ChangeTaxi

    Private Sub ChangeTaxi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gettaxiavailability()

    End Sub
    Private Sub gettaxiavailability()
        lvavailtaxi.Items.Clear()
        selectQuery("select * from taxi_info where taxi_status='available' ")
        While dr.Read
            Dim lvl As System.Windows.Forms.ListViewItem
            lvl = New System.Windows.Forms.ListViewItem(New String() {dr("plate_no").ToString}, -1)
            lvavailtaxi.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
        End While
    End Sub

  

    'Private Sub lvavailtaxi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvavailtaxi.DoubleClick
    '    lblplateno.Text = lvavailtaxi.SelectedItems(0).SubItems(0).Text
    '    Me.Close()
    'End Sub
End Class
