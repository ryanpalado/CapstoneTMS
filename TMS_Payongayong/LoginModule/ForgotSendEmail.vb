Imports Telerik.WinControls.UI
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports Telerik.WinControls

Public Class ForgotSendEmail
    'Declare random code generated as string on  "RandomNumber Module"
    Dim generatedCode As String = GetRandomString(6)
    Private Sub ForgotChooseMethod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ForgotChooseMethod_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        'Enable login form when this form closed.
        Login.Show()
        Login.Enabled = True

    End Sub

    Private Sub txtForgotEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtForgotEmail.KeyPress
        If txtForgotEmail.Text <> "" Then
            lblResult.Visible = False
        End If

        Dim ValidChars As String = _
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._"

        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
               OrElse e.KeyChar = Convert.ToChar(Keys.Back))

        'Enable Select All
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, RadTextBox).SelectAll()
            e.Handled = True
        End If

        'Check if the entered email address is in valid format
        If Regex.Match(txtForgotEmail.Text, "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$").Success Then
            lblResult.Visible = False
        Else
            lblResult.Visible = True
            lblResult.ForeColor = Color.Red
            lblResult.Text = "Invalid Email Format."
        End If

        'Clear result if the textbox is empty
        If txtForgotEmail.Text = "" Then
            lblResult.Visible = False
            lblResult.Text = ""
        End If


    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        'Required field validation.
        If txtForgotEmail.Text = "" Then
            lblResult.Visible = True
            lblResult.ForeColor = Color.Red
            lblResult.Text = "Field empty."
        End If

        If txtForgotEmail.Text <> "" Then

            selectQuery("select * from tbl_users where email = '" & txtForgotEmail.Text & "' ")
            If dr.HasRows Then
                sendEmailVerification()
                addVerificationCode()
            Else
                lblResult.Visible = True
                lblResult.ForeColor = Color.Red
                lblResult.Text = "Email not found.Enter the registered e-mail address."
            End If

        End If


    End Sub

    Public Sub sendEmailVerification()
        Dim bodyString As String
        Dim emailTo As String

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("ryanpalado11@gmail.com", "family11")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("ryanpalado11@gmail.com")
            emailTo = txtForgotEmail.Text
            e_mail.To.Add(emailTo)
            e_mail.Subject = "Password Reset"
            e_mail.IsBodyHtml = False
            bodyString = "To reset your password, kindly enter the verification code below to the system. " & vbCrLf
            bodyString += "Your Username: " + dr.Item("username") & vbCrLf
            bodyString += "Verification Code: " + generatedCode & vbCrLf & vbCrLf
            bodyString += "This message is sent to " + dr.Item("email") + " upon request." & vbCrLf
            bodyString += "Thanks."

            e_mail.Body = bodyString
            Smtp_Server.Send(e_mail)
            RadMessageBox.SetThemeName("Windows8")
            Dim prompt As DialogResult = RadMessageBox.Show(Me, "Email Successfully Sent.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)
            ForgotEnterCode.Show()
            Me.Hide()

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

    End Sub

    Public Sub addVerificationCode()

        selectQuery("select temp_code from tbl_users where email='" & txtForgotEmail.Text & "'")
        If dr.HasRows Then
            modifyQuery("update tbl_users set temp_code='" & generatedCode & "' where email='" & txtForgotEmail.Text & "' ")
        ElseIf dr.HasRows = False Then
            modifyQuery("insert into tbl_users (temp_code) values('" & generatedCode & "') where email='" & txtForgotEmail.Text & "' ")
        End If

    End Sub
End Class
