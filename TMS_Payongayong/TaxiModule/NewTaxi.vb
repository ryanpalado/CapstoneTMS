Imports Telerik.WinControls
Public Class NewTaxi
    Dim d1 As Date
    Dim days, months, years As Long
    Dim ymodel, reg, fran, codingDay As String

    Private Sub NewTaxi_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dashboard.Enabled = True
    End Sub

    Private Sub AddTaxi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtreg_date.Value = Now
        txtdate_fran.Value = Now

        reg_date()
        date_fran()

        notifran()
        notireg()
        notiymodel()
        'txtreg_date.Value = Format(Date.Today, "Short Date").ToString
        'txtdate_fran.Value = Format(Date.Today, "Short Date").ToString
       
    End Sub
    Public Sub TaxiCoding()
        Dim last_char, string1, lastNum As String
        string1 = txtplate_no.Text
        last_char = string1.Substring(string1.Length - 1)
        lastNum = last_char

        If lastNum = 1 Or lastNum = 2 Then
            codingDay = "Monday"
        ElseIf lastNum = 3 Or lastNum = 4 Then
            codingDay = "Tuesday"
        ElseIf lastNum = 5 Or lastNum = 6 Then
            codingDay = "Wednesday"
        ElseIf lastNum = 7 Or lastNum = 8 Then
            codingDay = "Thursday"
        ElseIf lastNum = 9 Or lastNum = 0 Then
            codingDay = "Friday"
        End If
    End Sub

    Public Sub reg_date()
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
    Public Sub date_fran()
        Dim d1 As Date
        Dim days, months, years As Long
        d1 = txtdate_fran.Value.ToShortDateString
        years = Year(d1)
        months = Month(d1)
        days = d1.Day
        years = Year(d1) + 5
        txtexp_fran.Text = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString

    End Sub

    Public Sub notifran()
        Dim d1 As Date
        Dim days, months, years As Long
        d1 = txtdate_fran.Value.ToShortDateString
        years = Year(d1)
        months = Month(d1)
        If months = 1 Then
            Dim m As String
            days = d1.Day
            m = 11
            years = Year(d1) + 4
            fran = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString
        ElseIf months = 2 Then
            Dim m As String
            days = d1.Day
            m = 12
            years = Year(d1) + 4
            fran = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString
        Else
            days = d1.Day
            years = Year(d1) + 5
            fran = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString
        End If
      

    End Sub

    Public Sub notireg()
        Dim d1 As Date
        Dim days, months, years As Long
        d1 = txtdate_fran.Value.ToShortDateString
        years = Year(d1)
        months = Month(d1)
        If months = 1 Then
            Dim m As String
            days = d1.Day
            m = 11
            years = Year(d1) + 4
            reg = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString
        ElseIf months = 2 Then
            Dim m As String
            days = d1.Day
            m = 12
            years = Year(d1) + 4
            reg = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString
        Else
            days = d1.Day
            years = Year(d1) + 5
            reg = months.ToString + ("/").ToString + days.ToString + ("/").ToString + years.ToString
        End If


    End Sub

    Public Sub notiymodel()
        d1 = txtdate_fran.Value.ToShortDateString
        years = Year(d1) + 10
        ymodel = years.ToString

    End Sub


    Private Sub addTaxi()
        modifyQuery("insert into tbl_taxi_info (plate_no, chassis_no, brand_name, year_model, reg_date, reg_exp, franchise_date, franchise_exp,coding_day, taxi_status, Driver, removed) values('" & txtplate_no.Text & "', '" & txtchassis_no.Text & "', '" & txtBrandName.Text & "', '" & txtyear_model.Text & "', '" & txtreg_date.Text & "', '" & txtexp_date.Text & "', '" & txtdate_fran.Text & "', '" & txtexp_fran.Text & "', '" & codingDay & "', '" & "Available" & "', '" & 2 & "', '" & "No" & "');")
    End Sub

    Public Sub addNoti()
        modifyQuery("insert into tbl_noti(plate_no, yearModel, franchise, register) values('" & txtplate_no.Text & "', '" & ymodel & "', '" & fran & "', '" & reg & "');")

    End Sub
    Private Sub deleteTaxi()
        modifyQuery("delete from tbl_taxi_info where taxi_id= '" & lbl_id.Text & "';")
    End Sub

    'Private Sub updateTaxi()
    '    modifyQuery("update taxi_info set plate_no='" & txtplate_no.Text & "', chassis_no='" & txtchassis_no.Text & "', year_model='" & txtyear_model.Text & "', reg_date='" & txtreg_date.Text & "', reg_exp='" & txtexp_date.Text & "', franchise_date='" & txtdate_fran.Text & "', franchise_exp='" & txtexp_fran.Text & "', coding_day='" & codingDay & "', taxi_status='" & cbtstatus.Text & "' where taxi_id='" & lbl_id.Text & "';")

    'End Sub

    Private Sub txtreg_date_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreg_date.MouseHover
        reg_date()
        notireg()
    End Sub

    Private Sub txtdate_fran_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate_fran.MouseHover
        date_fran()
        notifran()
    End Sub


    Private Sub txtdate_fran_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate_fran.ValueChanged
        date_fran()
        notifran()
    End Sub

    Private Sub txtreg_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreg_date.ValueChanged
        reg_date()
        notireg()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        TaxiCoding()
        addTaxi()
        addNoti()
        RadMessageBox.SetThemeName("Office2010Silver")
        Dim dialog As DialogResult = RadMessageBox.Show("New taxi added.")
        clearAll()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearAll()
    End Sub
    Public Sub clearAll()
        txtplate_no.Clear()
        txtBrandName.Clear()
        txtchassis_no.Clear()
        txtyear_model.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
