Public Class ADDDispatch
    Dim d1, d2 As String
    Dim d, day
    Dim coding As String
    Dim recordcount As Integer
    Public regnoti As String
   

    Private Sub txtdname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdname.TextChanged

        searchdispatch()
    End Sub
    Public Sub searchdispatch()
        selectQuery("select * from tbl_drivers_info where last_name= '" & txtdname.Text & "' ")
        While dr.Read

            lbldname.Text = dr("last_name").ToString
            lblplateno.Text = dr("assigned_taxi").ToString
            lbldstatus.Text = dr("driver_dstatus").ToString
            lbl_date.Text = d1
            lblday.Text = day
            taxiiscoding()
        End While
    End Sub

End Class
