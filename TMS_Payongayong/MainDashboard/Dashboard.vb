Imports System.Data.Odbc
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports CrystalDecisions.CrystalReports.Engine

Public Class Dashboard
    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gridDriver.AllowDragToGroup = False
        gridDriverRemoved.AllowDragToGroup = False
        monthyear()
        getAllTaxiInfoFromDB()
    End Sub
    '-----------------------DRIVERS INFO--------------------------------'

    Private Sub tabDriversList_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tabDriversList.Paint
        If Me.Enabled = True Then
            If txtSearchDriver.Text = "" Then
                getAllDriversInfoFromDB()
            End If
        End If
    End Sub

    Private Sub tabRemovedDrivers_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tabRemovedDrivers.Paint
        If Me.Enabled = True Then
            If txtSearchDriver.Text = "" Then
                getAllRemovedDriversInfoFromDB()
            End If
        End If
    End Sub

    'executes when VIEW INFORMATION clicked 

    Private Sub gridDriver_CommandCellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDriver.CommandCellClick

        Dim GridCommandCellElement As Telerik.WinControls.UI.GridCommandCellElement = TryCast(sender, GridCommandCellElement)
        Dim strText As String = GridCommandCellElement.CommandButton.Text
        Select Case strText
            Case "View Information"

                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)

                'GET IMAGE FROM SELECTED ROW
                Dim myBlob() As Byte = Me.gridDriver.Rows(cell.RowIndex).Cells(18).Value
                Dim myStream As System.IO.MemoryStream = New System.IO.MemoryStream(myBlob)
                ViewDriver.picDriver.Image = System.Drawing.Image.FromStream(myStream)

                'GET TEXT DATA FROM ROW
                Dim fname As String = Me.gridDriver.Rows(cell.RowIndex).Cells(4).Value + " "
                Dim mname As String = Me.gridDriver.Rows(cell.RowIndex).Cells(5).Value + " "
                Dim lname As String = Me.gridDriver.Rows(cell.RowIndex).Cells(3).Value + " "

                With ViewDriver
                    .lblDriverID.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(2).Value
                    .lblFullName.Text = String.Concat(fname, mname, lname)
                    .lblDriverStatus.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(8).Value
                    .lblSSSNo.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(7).Value
                    .lblLicenseNo.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(6).Value
                    .lblAssignedTaxi.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(9).Value
                    .lblAge.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(10).Value + " years old"
                    .lblGender.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(11).Value
                    .lblAddress.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(12).Value
                    .lblCivilStatus.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(13).Value
                    .lblMobileNo.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(14).Value
                    .lblReligion.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(15).Value
                    .lblContactName.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(16).Value
                    .lblContactNo.Text = Me.gridDriver.Rows(cell.RowIndex).Cells(17).Value
                End With

                ViewDriver.Show()
                Me.Enabled = False

                If Me.Enabled = True Then
                    If txtSearchDriver.Text <> "" Then
                        searchDriversFromDB()
                    End If
                End If

            Case "Delete"
                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)
                Dim idNo As String = Me.gridDriver.Rows(cell.RowIndex).Cells(2).Value
                Dim driverID As String = idNo

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Are you sure?", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)

                If dialog = DialogResult.Yes Then
                    modifyQuery("update tbl_drivers_info set removed= 'Yes' where driver_id='" & driverID & "' ")

                    RadMessageBox.SetThemeName("Office2010Silver")
                    Dim success As DialogResult = RadMessageBox.Show(Me, "Record Successfully Deleted.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                ElseIf dialog = DialogResult.No Then

                End If

        End Select


    End Sub

    Private Sub gridDriverRemoved_CommandCellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDriverRemoved.CommandCellClick
        Dim GridCommandCellElement As Telerik.WinControls.UI.GridCommandCellElement = TryCast(sender, GridCommandCellElement)
        Dim strText As String = GridCommandCellElement.CommandButton.Text
        Select Case strText
            Case "Restore"

                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)
                Dim idNo As String = Me.gridDriverRemoved.Rows(cell.RowIndex).Cells(1).Value
                Dim driverID As String = idNo

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Are you sure you want to restore?", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)

                If dialog = DialogResult.Yes Then
                    modifyQuery("update tbl_drivers_info set removed= 'No' where driver_id='" & driverID & "' ")

                    RadMessageBox.SetThemeName("Office2010Silver")
                    Dim success As DialogResult = RadMessageBox.Show(Me, "Record Successfully Restored.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                ElseIf dialog = DialogResult.No Then

                End If

        End Select
    End Sub

    Private Sub btnNewDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDriver.Click
        'add new driver function
        NewDriver.Show()
        Me.Enabled = False
    End Sub

    Private Sub txtSearchDriver_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchDriver.TextChanged
        If txtSearchDriver.Text = "" Then
            getAllDriversInfoFromDB()
        ElseIf txtSearchDriver.Text <> "" Then
            searchDriversFromDB()
        End If
    End Sub

    Private Sub txtSearchRemoved_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchDriverRemoved.TextChanged
        If txtSearchDriverRemoved.Text = "" Then
            getAllRemovedDriversInfoFromDB()
        ElseIf txtSearchDriverRemoved.Text <> "" Then
            searchRemovedDriversFromDB()
        End If
    End Sub

    '-----------------------END DRIVERS INFO--------------------------------'

    Public Sub monthyear()
        'lblMonth.Text = Date.Today.Month.ToString

        '==========> month

        Dim thisMonth As Integer
        Dim name As String
        thisMonth = Date.Today.Month.ToString
        ' Set Abbreviate to True to return an abbreviated name.
        name = MonthName(thisMonth, False)
        ' name now contains "Apr".
        lblMonth.Text = name

        '=========> year
        lblYear.Text = Date.Today.Year
        lblDate.Text = Date.Today.Day

    End Sub

    Private Sub RadButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton6.Click
        NewTaxi.Show()
    End Sub

    Private Sub gridTaxi_CommandCellClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridTaxi.CommandCellClick

        Dim GridCommandCellElement As Telerik.WinControls.UI.GridCommandCellElement = TryCast(sender, GridCommandCellElement)
        Dim strText As String = GridCommandCellElement.CommandButton.Text
        Select Case strText
            Case "View Information"

                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)

                'GET TEXT DATA FROM ROW


                With ViewTaxi_vb
                    .lblTaxiID.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(2).Value
                    .lblPlateno.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(3).Value
                    .lblChasisNo.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(4).Value
                    .lblBrandName.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(5).Value
                    .lblRegDate.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(7).Value
                    .lblFranDate.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(10).Value
                    .lblYearModel.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(6).Value
                    .lblCodingDay.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(14).Value
                    .lblTaxiStatus.Text = Me.gridTaxi.Rows(cell.RowIndex).Cells(15).Value
                End With

                ViewTaxi_vb.Show()
                Me.Enabled = False

                If Me.Enabled = True Then
                    If txtSearchTaxi.Text <> "" Then
                        'searchDriversFromDB()
                    End If
                End If

            Case "Delete"
                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)
                Dim idNo As String = Me.gridTaxi.Rows(cell.RowIndex).Cells(2).Value
                Dim taxiID As String = idNo

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Are you sure?", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)

                If dialog = DialogResult.Yes Then
                    modifyQuery("update tbl_taxi_info set removed= 'Yes' where taxi_id='" & taxiID & "' ")

                    RadMessageBox.SetThemeName("Office2010Silver")
                    Dim success As DialogResult = RadMessageBox.Show(Me, "Record Successfully Deleted.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                ElseIf dialog = DialogResult.No Then

                End If

        End Select

    End Sub

   
    Private Sub RadButton7_Click(sender As System.Object, e As System.EventArgs) Handles RadButton7.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\RPALADO\Desktop\01-27-15\TMS_Payongayong\TMS_Payongayong\Crystal Report\DriverInfoRprt.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub RadButton8_Click(sender As System.Object, e As System.EventArgs) Handles RadButton8.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\RPALADO\Desktop\01-27-15\TMS_Payongayong\TMS_Payongayong\Crystal Report\TaxiInfoRprt.rpt")
        CrystalReportViewer2.ReportSource = cryRpt
        CrystalReportViewer2.Refresh()
    End Sub

    Private Sub TabDriverFunds_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles TabDriverFunds.Paint

    End Sub

    Private Sub RadButton9_Click(sender As System.Object, e As System.EventArgs) Handles RadButton9.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\RPALADO\Desktop\01-27-15\TMS_Payongayong\TMS_Payongayong\Crystal Report\DriverFund.rpt")
        CrystalReportViewer3.ReportSource = cryRpt
        CrystalReportViewer3.Refresh()
    End Sub

    Private Sub RadButton10_Click(sender As System.Object, e As System.EventArgs) Handles RadButton10.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\RPALADO\Desktop\01-27-15\TMS_Payongayong\TMS_Payongayong\Crystal Report\CashAdvanceRprt.rpt")
        CrystalReportViewer4.ReportSource = cryRpt
        CrystalReportViewer4.Refresh()
    End Sub

    Private Sub RadButton11_Click(sender As System.Object, e As System.EventArgs) Handles RadButton11.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\RPALADO\Desktop\01-27-15\TMS_Payongayong\TMS_Payongayong\Crystal Report\TaxiDamagesRprt.rpt")
        CrystalReportViewer5.ReportSource = cryRpt
        CrystalReportViewer5.Refresh()
    End Sub

    Private Sub RadButton12_Click(sender As System.Object, e As System.EventArgs) Handles RadButton12.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\RPALADO\Desktop\01-27-15\TMS_Payongayong\TMS_Payongayong\Crystal Report\ShortBoundaryRprt.rpt")
        CrystalReportViewer6.ReportSource = cryRpt
        CrystalReportViewer6.Refresh()
    End Sub

    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton3.Click
        ADDDispatch.Show()
    End Sub
End Class
