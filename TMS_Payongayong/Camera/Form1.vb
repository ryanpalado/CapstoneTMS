Imports System.Data.OleDb
Public Class Form1

    Inherits System.Windows.Forms.Form
    Dim bytImage() As Byte



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_image.Click
        With ofdImage
            .InitialDirectory = "C:"
            .Filter = "Only Picture With JPG/JPEG/PNG Extension|*.jpg;*.jpeg;*.png"
            .FileName = Nothing
        End With
        If ofdImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            myimage.Image = Image.FromFile(ofdImage.FileName)
            myimage.Tag = ofdImage.FileName
        Else
            myimage.Tag = ""
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        'Try
        '    Using conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\employeedb.mdb;")
        '        conn.Open()
        '        Dim command As New OleDbCommand("insert into employees (first_name, last_name, initial, address, age, contact, status, department, gender, e_position, date_hired, myimage, rate, tin, sss, bday) values (@fname, @lname, @initial, @address, @age, @contact, @regularradio, @dept, @gender, @pos, @date1, @myimage, @rate, @tin, @sss, @bday)", conn)
        '        With command.Parameters
        '            .AddWithValue("@fname", fname.Text)
        '            .AddWithValue("@lname", lname.Text)
        '            .AddWithValue("@initial", initial.Text)
        '            .AddWithValue("@address", address.Text)
        '            .AddWithValue("@age", age.Text)
        '            .AddWithValue("@contact", contact.Text)
        '            .AddWithValue("@regularradio", regularradio.Text)
        '            .AddWithValue("@dept", dept.Text)
        '            .AddWithValue("@gender", gender.Text)
        '            .AddWithValue("@pos", pos2.Text)
        '            .AddWithValue("@date1", date1.Text)

        '            Try
        '                Dim ms As New System.IO.MemoryStream
        '                Dim bmpImage As New Bitmap(myimage.Image)

        '                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        '                bytImage = ms.ToArray()
        '                ms.Close()
        '            Catch ex As Exception
        '                MsgBox(ex.ToString)
        '            End Try

        '            .AddWithValue("@myimage", bytImage)
        '            .AddWithValue("@rate", rate.Text)
        '            .AddWithValue("@tin", tin.Text)
        '            .AddWithValue("@sss", sss.Text)
        '            .AddWithValue("@bday", bday.Text)

        '        End With


    End Sub



    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If btnReset.Text = "Cancel" Then

            myimage.Image = TMS_Payongayong.My.Resources.Resources.payins
            btnRegister.Text = "Register"
            btnReset.Text = "Reset"
            btnRegister.Text = "Select Photo"

        Else

            myimage.Image = TMS_Payongayong.My.Resources.Resources.payins
            btnRegister.Text = "Register"

        End If
    End Sub


    '///// Camera Sub Routine////////////'''

    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = myimage.Height
        Dim iWidth As Integer = myimage.Width
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, myimage.Handle.ToInt32, 0)
        If SendMessage(hHwnd, WM_Cap_Paki_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_Cap_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, myimage.Width, myimage.Height, SWP_NOMOVE Or SWP_NOZORDER)
        Else
            DestroyWindow(hHwnd)
        End If
    End Sub

    Private Sub ClosePreviewWindow()
        SendMessage(hHwnd, WM_Cap_Paki_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    '////End of Camera////////////'''

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        If btnCapture.Text = "Camera" Then
            Call OpenPreviewWindow()
            btnCapture.Text = "Capture"
            btnReset.Enabled = False
            btnRegister.Enabled = False
            select_image.Enabled = False

        ElseIf btnCapture.Text = "Capture" Then
            Dim Data As IDataObject
            Dim Bmap As Image
            SendMessage(hHwnd, WM_Cap_EDIT_COPY, 0, 0)
            Data = Clipboard.GetDataObject()
            If Data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                Bmap = CType(Data.GetData(GetType(System.Drawing.Bitmap)), Image)
                myimage.Image = Bmap
                ClosePreviewWindow()
            End If
            btnCapture.Text = "Camera"
            btnReset.Enabled = True
            btnRegister.Enabled = True
            select_image.Enabled = True
            Call ClosePreviewWindow()

        End If
    End Sub




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class