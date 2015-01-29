Imports System.IO
Imports System.Data.Odbc
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ViewDriver
    Dim imgMemoryStream As MemoryStream = New MemoryStream()
    Dim imgByteArray As Byte() = Nothing

    Private Sub ViewDriver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gettaxidamageFromDB()
        getsssfundsFromDB()
        getShortBoundaryFromDB()
        getCashAdvanceFromDB()
        gettaxidamageFromDB()
        getAllDriversFundFromDB()
        viewremainingbalance()
        remaining_taxiDamages()
        remaining_funds()
        remainingbalance()
        remaining_ShortBoundary()
        remaining_sssfunds()

    End Sub





    Private Sub ViewDriver_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dashboard.Enabled = True
    End Sub

    Private Sub btnNewFund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFund.Click
        AddFunds.Show()
        Me.Enabled = False
    End Sub

    Private Sub TabDriverFunds_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabDriverFunds.Paint

        getAllDriversFundFromDB()
    End Sub



    Private Sub gridDriverFunds_CellClick(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs)

    End Sub


    Private Sub btnFundsTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFundsTransactions.Click
        Transactions.Show()
    End Sub

    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCashAdvance.Click
        getCashAdvanceFromDB()
        AddCashAdvance.Show()
        Me.Enabled = False
    End Sub

    Private Sub drpdwnMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnMonth.SelectedIndexChanged

    End Sub



    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayCashAdvance.Click
        Me.Enabled = False
        PayBalances.Show()
    End Sub




    Private Sub RadPageViewPage10_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabTa.Paint

        gettaxidamageFromDB()
    End Sub



    Private Sub btnAddTaxiDamages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTaxiDamages.Click
        Me.Enabled = False
        AddRecord.Show()
    End Sub

    Private Sub btnPayTaxiDamages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayTaxiDamages.Click
        Me.Enabled = False
        PayDamages.Show()
    End Sub




    Private Sub gridShortBoundary_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        getShortBoundaryFromDB()
    End Sub



    Private Sub btnAddSSSFunds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddSSSFunds.Show()
    End Sub




    Private Sub btnAddShortBoundary_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddShortBoundary.Click
        Me.Enabled = False
        AddShortBoundary.Show()
    End Sub

    Private Sub btnPayShortBoundary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayShortBoundary.Click
        Me.Enabled = False
        PayShortBoundary.Show()

    End Sub

    Private Sub TabShortBoundary_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabShortBoundary.Paint

    End Sub

    Private Sub RadPageView2_SelectedPageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPageView2.SelectedPageChanged

    End Sub

    Private Sub gridSSSFunds_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        getsssfundsFromDB()
    End Sub

    Private Sub gridShortBoundary_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        getShortBoundaryFromDB()
    End Sub

    Private Sub btnAddSSSFunds_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSSSFunds.Click
        Me.Enabled = False
        AddSSSFunds.Show()
    End Sub

    Private Sub drpdwnYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnYear.SelectedIndexChanged



    End Sub

    Private Sub btnTransactionCashAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransactionCashAdvance.Click
        TransactionCashAdvance.Show()
    End Sub

    Private Sub drpdwnMonth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpdwnMonth.TextChanged
        queryMontDriver()
    End Sub

    Private Sub drpdwnYear_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpdwnYear.TextChanged
        queryYearDriver()
    End Sub


    Private Sub drpdwnMonthCA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnMonthCA.SelectedIndexChanged
        queryMontCashAdv()
    End Sub

    Private Sub drpdwnYearCA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnYearCA.SelectedIndexChanged
        queryYearCashAdv()
    End Sub


    Private Sub drpdwnMonthTD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnMonthTD.SelectedIndexChanged
        queryMonthTD()
    End Sub

    Private Sub drpdwnYearTD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnYearTD.SelectedIndexChanged
        queryYearTD()
    End Sub

    Private Sub drpdwnMonthSB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnMonthSB.SelectedIndexChanged
        queryMonthSB()
    End Sub

    Private Sub drpdwnYearSB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnYearSB.SelectedIndexChanged
        queryYearSB()
    End Sub



    Private Sub btnTransactionShortBoundary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransactionShortBoundary.Click
        TransactionShortBoundary.Show()
    End Sub

    Private Sub btnTransactionTaxiDamages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransactionTaxiDamages.Click
        TransactionTaxiDamages.Show()
    End Sub

    Private Sub RadButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditInfo.Click
        Dim str = lblAge.Text
        Dim num1 = str.Substring(0, 2)
        GetFullName()

        txtAge.Visible = True
        txtGender.Visible = True
        txtAddress.Visible = True
        txtCivilStatus.Visible = True
        txtMobileNo.Visible = True
        txtReligion.Visible = True
        txtContactName.Visible = True
        txtContactNo.Visible = True
        txtLastName.Visible = True
        txtFirstName.Visible = True
        txtMiddleName.Visible = True
        drpdwnDriverStatus.Visible = True
        txtSSS.Visible = True
        txtLicense.Visible = True
        txtAssignedTaxi.Visible = True

        txtAge.Text = num1
        txtGender.Text = lblGender.Text
        txtAddress.Text = lblAddress.Text
        txtCivilStatus.Text = lblCivilStatus.Text
        txtMobileNo.Text = lblMobileNo.Text
        txtReligion.Text = lblReligion.Text
        txtContactName.Text = lblContactName.Text
        txtContactNo.Text = lblContactNo.Text
        drpdwnDriverStatus.Text = lblDriverStatus.Text
        txtSSS.Text = lblSSSNo.Text
        txtLicense.Text = lblLicenseNo.Text
        txtAssignedTaxi.Text = lblAssignedTaxi.Text

        lblFullName.Visible = False
        lblDriverStatus.Visible = False
        lblSSSNo.Visible = False
        lblLicenseNo.Visible = False
        lblAssignedTaxi.Visible = False
        lblAge.Visible = False
        lblGender.Visible = False
        lblAddress.Visible = False
        lblCivilStatus.Visible = False
        lblMobileNo.Visible = False
        lblReligion.Visible = False
        lblContactName.Visible = False
        lblContactNo.Visible = False

        btnSave.Enabled = True
        btnEditInfo.Enabled = False

    End Sub

    Public Sub GetFullName()
        selectQuery("select * from tbl_drivers_info where driver_id='" & lblDriverID.Text & "' ")
        If dr.HasRows Then
            txtLastName.Text = dr.Item("last_name")
            txtFirstName.Text = dr.Item("first_name")
            txtMiddleName.Text = dr.Item("middle_name")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        txtAge.Visible = False
        txtGender.Visible = False
        txtAddress.Visible = False
        txtCivilStatus.Visible = False
        txtMobileNo.Visible = False
        txtReligion.Visible = False
        txtContactName.Visible = False
        txtContactNo.Visible = False
        txtSSS.Visible = False
        txtLicense.Visible = False
        txtAssignedTaxi.Visible = False
        txtLastName.Visible = False
        txtFirstName.Visible = False
        txtMiddleName.Visible = False
        drpdwnDriverStatus.Visible = False

        lblFullName.Visible = True
        lblAge.Visible = True
        lblGender.Visible = True
        lblAddress.Visible = True
        lblCivilStatus.Visible = True
        lblMobileNo.Visible = True
        lblReligion.Visible = True
        lblContactName.Visible = True
        lblContactNo.Visible = True
        lblSSSNo.Visible = True
        lblLicenseNo.Visible = True
        lblAssignedTaxi.Visible = True
        lblDriverStatus.Visible = True

        lblFullName.Text = txtLastName.Text + " " + txtFirstName.Text + " " + txtMiddleName.Text
        lblAge.Text = txtAge.Text + " yrs old"
        lblGender.Text = txtGender.Text
        lblAddress.Text = txtAddress.Text
        lblCivilStatus.Text = txtCivilStatus.Text
        lblMobileNo.Text = txtMobileNo.Text
        lblReligion.Text = txtReligion.Text
        lblContactName.Text = txtContactName.Text
        lblContactNo.Text = txtContactNo.Text
        lblSSSNo.Text = txtSSS.Text
        lblLicenseNo.Text = txtLicense.Text
        lblAssignedTaxi.Text = txtAssignedTaxi.Text

        btnSave.Enabled = False
        btnEditInfo.Enabled = True

        modifyQuery("Update tbl_drivers_info set last_name = '" & txtLastName.Text & "',first_name = '" & txtFirstName.Text & "',middle_name = '" & txtMiddleName.Text & "',license_no = '" & txtLicense.Text & "',sss_no = '" & txtSSS.Text & "',driver_status = '" & drpdwnDriverStatus.Text & "',age = '" & txtAge.Text & "', gender = '" & txtGender.Text & "', address = '" & txtAddress.Text & "', civil_status = '" & txtCivilStatus.Text & "', age = '" & txtAge.Text & "', mobile_no = '" & txtMobileNo.Text & "', religion = '" & txtReligion.Text & "', contact_name = '" & txtContactName.Text & "', mobile_no = '" & txtContactNo.Text & "' where driver_id='" & lblDriverID.Text & "';")
        RadMessageBox.SetThemeName("Office2010Silver")
        Dim dialog As DialogResult = RadMessageBox.Show("Driver's Information Updated.")
    End Sub

    Public Sub Edit_Funds()
        EditFunds.lblIDFundEdit.Text = lvDriversFund.SelectedItems(0).SubItems(0).Text
        ' EditFunds.txtFundAmount.Text = lvDriversFund.SelectedItems(0).SubItems(2).Text
        EditFunds.lblPrevAmount.Text = lvDriversFund.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub lvDriversFund_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDriversFund.Click


    End Sub

    Private Sub lvDriversFund_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvDriversFund.MouseClick
        btn_editFunds.Enabled = True
        Edit_Funds()

    End Sub

    Private Sub btn_editFunds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editFunds.Click
        Me.Enabled = False
        EditFunds.Show()
    End Sub

    Private Sub lvCashAdvance_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvCashAdvance.MouseClick
        Edit_CashADv()
        btnEdit_Bal.Enabled = True
    End Sub

    Public Sub Edit_CashADv()
        EditCashAdvance.lblIDCashAdvEdit.Text = lvCashAdvance.SelectedItems(0).SubItems(0).Text
        ' EditFunds.txtFundAmount.Text = lvDriversFund.SelectedItems(0).SubItems(2).Text
        EditCashAdvance.lblPrevAmount.Text = lvCashAdvance.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub btnEdit_Bal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit_Bal.Click
        EditCashAdvance.Show()
    End Sub

    Public Sub Edit_TaxiDamage()
        btn_editDamages.Enabled = True
        EditRecord.lblRecordID.Text = lvTaxiDamages.SelectedItems(0).SubItems(0).Text
        ' EditFunds.txtFundAmount.Text = lvDriversFund.SelectedItems(0).SubItems(2).Text
        EditRecord.lblPrevAmount.Text = lvTaxiDamages.SelectedItems(0).SubItems(2).Text
    End Sub


    Private Sub RadButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editDamages.Click
        EditRecord.Show()

    End Sub

    Private Sub lvTaxiDamages_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvTaxiDamages.MouseClick
        Edit_TaxiDamage()
    End Sub
End Class
