Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class ViewTaxi_vb

    Private Sub ViewTaxi_vb_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dashboard.Enabled = True
    End Sub

    Private Sub ViewTaxi_vb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub getTaxiPlate()
        selectQuery("select * from tbl_taxi_info")
        If dr.HasRows Then
            lblTaxiID.Text = dr.Item("taxi_id")

        End If
    End Sub

    Private Sub btnEditInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditInfo.Click
        btnEditInfo.Enabled = False
        btnSave.Enabled = True
        txtPlateNo.Visible = True
        txtChassisNo.Visible = True
        txtBrandName.Visible = True
        txtYearModel.Visible = True
        txtCoding.Visible = True
        txtTaxiStatus.Visible = True
        txtreg_date.Visible = True
        txtdate_fran.Visible = True

        lblPlateno.Visible = False
        lblChasisNo.Visible = False
        lblBrandName.Visible = False
        lblYearModel.Visible = False
        lblCodingDay.Visible = False
        lblTaxiStatus.Visible = False
        lblRegDate.Visible = False
        lblFranDate.Visible = False

        txtPlateNo.Text = lblPlateno.Text
        txtChassisNo.Text = lblChasisNo.Text
        txtBrandName.Text = lblBrandName.Text
        txtYearModel.Text = lblYearModel.Text
        txtCoding.Text = lblCodingDay.Text
        txtTaxiStatus.Text = lblTaxiStatus.Text
        txtreg_date.Text = lblRegDate.Text
        txtdate_fran.Text = lblRegDate.Text



    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnEditInfo.Enabled = True
        btnSave.Enabled = False

        txtPlateNo.Visible = False
        txtChassisNo.Visible = False
        txtBrandName.Visible = False
        txtYearModel.Visible = False
        txtCoding.Visible = False
        txtTaxiStatus.Visible = False
        txtreg_date.Visible = False
        txtdate_fran.Visible = False

        lblPlateno.Visible = True
        lblChasisNo.Visible = True
        lblBrandName.Visible = True
        lblYearModel.Visible = True
        lblCodingDay.Visible = True
        lblTaxiStatus.Visible = True
        lblRegDate.Visible = True
        lblFranDate.Visible = True

        lblPlateno.Text = txtPlateNo.Text
        lblChasisNo.Text = txtChassisNo.Text
        lblBrandName.Text = txtBrandName.Text
        lblYearModel.Text = txtYearModel.Text
        lblCodingDay.Text = txtCoding.Text
        lblTaxiStatus.Text = txtTaxiStatus.Text
        lblRegDate.Text = txtreg_date.Text
        lblRegDate.Text = txtdate_fran.Text


        modifyQuery("Update tbl_taxi_info set plate_no = '" & txtPlateNo.Text & "',chassis_no = '" & txtChassisNo.Text & "',brand_name = '" & txtBrandName.Text & "',year_model = '" & txtYearModel.Text & "',coding_day = '" & txtCoding.Text & "',taxi_status = '" & txtTaxiStatus.Text & "',reg_date = '" & txtreg_date.Text & "', franchise_date = '" & txtdate_fran.Text & "', reg_exp = '" & txtexp_date.Text & "', franchise_exp = '" & txtexp_fran.Text & "' where taxi_id='" & lblTaxiID.Text & "';")

        RadMessageBox.SetThemeName("Office2010Silver")
        Dim dialog As DialogResult = RadMessageBox.Show("Taxi Details Updated.")


    End Sub

    Private Sub txtreg_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreg_date.ValueChanged
        Dim d1 As Date
        Dim days, months, years As Long
        ' Dim yearxp As Long
        d1 = txtreg_date.Value.ToShortDateString
        'd2 = Now.ToShortDateString
        years = Year(d1)
        months = Month(d1)
        days = d1.Day
        years = Year(d1) + 1
        txtexp_date.Text = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString
        'y = 
    End Sub

    Private Sub txtdate_fran_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate_fran.ValueChanged
        Dim d1 As Date
        Dim days, months, years As Long
        d1 = txtdate_fran.Value.ToShortDateString
        years = Year(d1)
        months = Month(d1)
        days = d1.Day
        years = Year(d1) + 5
        txtexp_fran.Text = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString

    End Sub
End Class
