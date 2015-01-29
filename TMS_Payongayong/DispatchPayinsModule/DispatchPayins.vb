Module DispatchPayins
    Public d = Format(Date.Today, "Short Date").ToString
    Public Day = Date.Today.DayOfWeek.ToString
    Public coding As String
    Public nulltxt As String = "null"

    Public Sub boundaryset()
        selectQuery("select * from tbl_boundary")
        While dr.Read
            ADDDispatch.txtboundary.Text = dr("boundary").ToString

        End While
    End Sub

    Public Sub visibleTrue()
        ADDDispatch.lblboundary.Visible = True
        ADDDispatch.btnmodify.Visible = True
        ADDDispatch.txtboundary.Visible = True
        ADDDispatch.lbltaxistanding.Visible = True
        ADDDispatch.cbtaxistanding.Visible = True
        ADDDispatch.lbltimein.Visible = True
        ADDDispatch.lblin.Visible = True
        ADDDispatch.lbldboundary.Visible = True
        ADDDispatch.txtdboundary.Visible = True


    End Sub

    Public Sub MyDamage()
      
        
        ADDDispatch.lbldamage.Visible = True
        ADDDispatch.txtdamage.Visible = True
     
        ADDDispatch.lblshortgas.Visible = True
        ADDDispatch.txtsgasamount.Visible = True
    End Sub

    'Public Sub lvdispacthpayins()
    '    ADDDispatch.dispay_id.Text = ADDDispatch.lvdispatch.SelectedItems(0).SubItems(0).Text
    '    ADDDispatch.lbl_date.Text = ADDDispatch.lvdispatch.SelectedItems(0).SubItems(1).Text
    '    ADDDispatch.lbldaytype.Text = Dashboard.lvdispatch.SelectedItems(0).SubItems(2).Text
    '    ADDDispatch.lbldname.Text = Dashboard.lvdispatch.SelectedItems(0).SubItems(3).Text
    '    ADDDispatch.lbltimein.Text = Dashboard.lvdispatch.SelectedItems(0).SubItems(4).Text
    '    ADDDispatch.lblplateno.Text = Dashboard.lvdispatch.SelectedItems(0).SubItems(5).Text
    '    ADDDispatch.lbldstatus.Text = Dashboard.lvdispatch.SelectedItems(0).SubItems(6).Text
    '    ADDDispatch.lbltstatus.Text = Dashboard.lvdispatch.SelectedItems(0).SubItems(7).Text
    'End Sub


    Public Sub dispatch()
        modifyQuery("insert into taxi_dispatch (date,day_type,driversName,timeIn,plateNo,driver_status,taxi_status) values('" & ADDDispatch.lbl_date.Text & "','" & ADDDispatch.lbldaytype.Text & "', '" & ADDDispatch.lbldname.Text & "', '" & ADDDispatch.lbltimein.Text & "', '" & ADDDispatch.lblplateno.Text & "', '" & ADDDispatch.lbldstatus.Text & "', '" & ADDDispatch.lbltstatus.Text & "');")

    End Sub
   
    'Public Sub getDataDispatch()

    '    Dashboard.lvdispatch.Items.Clear()
    '    selectQuery("select dispatchNo,date,day_type,driversName,timeIn,timeOut,plateNo,driver_status,taxi_status from taxi_dispatch where timeOut IS NULL ")
    '    While dr.Read
    '        Dim lvl As System.Windows.Forms.ListViewItem
    '        lvl = New System.Windows.Forms.ListViewItem(New String() {dr("dispatchNo").ToString, dr("date").ToString, dr("day_type").ToString, dr("driversName").ToString, dr("timeIn").ToString, dr("plateNo").ToString, dr("driver_status").ToString, dr("taxi_status").ToString}, -1)
    '        Dashboard.lvdispatch.Items.AddRange(New System.Windows.Forms.ListViewItem() {lvl})
    '    End While

    'End Sub

    Public Sub AutoCompleteDriver()
        ADDDispatch.txtdname.AutoCompleteCustomSource.Clear()
        selectQuery("select * from drivers_info")
        While dr.Read
            ADDDispatch.txtdname.AutoCompleteCustomSource.Add(dr("full_name").ToString)
        End While
       

    End Sub
    Public Sub taxiiscoding()

        selectQuery("select * from taxi_info where plate_no='" & ADDDispatch.lblplateno.Text & "' ")
        While dr.Read
            coding = dr("coding_day").ToString
        End While
        If coding = day Then
            ADDDispatch.lbltstatus.Text = "Coding"
        Else
            taxiisnotcoding()
        End If
    End Sub

    Public Sub taxiisnotcoding()
        selectQuery("select * from taxi_info where plate_no='" & ADDDispatch.lblplateno.Text & "' ")
        While dr.Read
            ADDDispatch.lbltstatus.Text = dr("taxi_status").ToString
        End While
    End Sub


    'Public Sub Payins()
    '    modifyQuery("update taxi_dispatch set timeOut ='" &  ADDDispatch.lbl_time.Text & "', boundary ='" & Dashboard.txtdboundary.Text & "',valid_reason ='" & Dashboard.cbvalidreason.Text & "',damage_amount ='" & Dashboard.txtdamage.Text & "',short_boundary ='" & Dashboard.txtsboundary.Text & "',short_gas ='" & Dashboard.txtsgasamount.Text & "' where dispatchNo='" & Dashboard.dispay_id.Text & "' ;")
    'End Sub


   

End Module
