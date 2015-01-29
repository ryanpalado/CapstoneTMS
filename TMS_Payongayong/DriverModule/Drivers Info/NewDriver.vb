Imports System.IO
Imports System.Data.Odbc
Imports Telerik.WinControls

Public Class NewDriver
    Dim imgMemoryStream As MemoryStream = New MemoryStream()
    Dim imgByteArray As Byte() = Nothing

    Private Sub NewDriver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TaxiCombo()
        txtSSS.Clear()
        txtLicense.Clear()
        getTaxiID()
    End Sub

    Public Sub TaxiCombo()
        cmd = New OdbcCommand("select plate_no from tbl_taxi_info where taxi_status='Available' AND driver=2 Or driver=1 ", conn)
        Using dr = cmd.ExecuteReader()
            While dr.Read
                txtAssignedTaxi.Items.Add(dr("plate_no").ToString())
            End While
        End Using
    End Sub
    Private Sub getTaxiID()

        selectQuery("select * from tbl_taxi_info")
        If dr.HasRows Then
            lblTaxiID.Text = dr.Item("plate_no")
        End If
    End Sub


    Private Sub NewDriver_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dashboard.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim removed As String
        removed = "No"

        Try
            conn.Close()
            conn.Open()
            Dim addDriverInfo As New OdbcCommand("insert into tbl_drivers_info (last_name,first_name,middle_name,license_no,sss_no,driver_status,assigned_taxi,age,gender,address,civil_status,mobile_no,religion,contact_name,contact_no,image,removed) values ('" & txtLastName.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLicense.Text & "','" & txtSSS.Text & "','" & drpdwnDriverStatus.Text & "','" & txtAssignedTaxi.Text & "','" & txtAge.Text & "','" & drpdwnGender.Text & "','" & txtAddress.Text & "','" & drpdwnCivilStatus.Text & "','" & txtDriverMobile.Text & "','" & txtReligion.Text & "','" & txtContactName.Text & "','" & txtContactNo.Text & "', ?, '" & removed & "' ) ", conn)
            addDriverInfo.Parameters.AddWithValue("Image_Data", imgByteArray)
            addDriverInfo.ExecuteNonQuery()
            modifyQuery("Update tbl_taxi_info set Driver = Driver - 1 where plate_no='" & lblTaxiID.Text & "';")

            RadMessageBox.SetThemeName("Office2010Silver")
            Dim dialog As DialogResult = RadMessageBox.Show(Me, "Driver information successfully added to the database. Add another?", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)

            Me.Text = dialog.ToString()
            getAllDriversInfoFromDB()

            If dialog = DialogResult.Yes Then
                ClearText()
            ElseIf dialog = DialogResult.No Then
                Me.Close()
                Dashboard.Enabled = True
            End If

            picDriver.Image = Nothing
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBrowseImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseImage.Click

        Me.OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.Filter = "*.JPG|*.PNG"
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.ShowDialog()

        If Not OpenFileDialog1.FileName = Nothing Then

            Dim path As String = OpenFileDialog1.FileName
            picDriver.Image = Image.FromFile(path)

            Dim myImage As Image = Image.FromFile(path)

            'Image to byte[]      
            myImage.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            imgByteArray = imgMemoryStream.GetBuffer()

        End If
    End Sub

    Private Sub ClearText()
        picDriver.Image = Nothing
        txtLastName.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        drpdwnCivilStatus.Text = ""
        txtDriverMobile.Text = ""
        txtLicense.Clear()
        drpdwnDriverStatus.Text = ""
        txtSSS.Clear()
        txtAssignedTaxi.Text = ""
        txtContactName.Text = ""
        txtContactNo.Text = ""
        drpdwnGender.Text = ""
        txtReligion.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
