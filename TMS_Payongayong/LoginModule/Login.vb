Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        'Check if there is a stored username
        If My.Settings.status = True Then
            txtUser.Text = My.Settings.username
            'Username input focus
            txtUser.Focus()
        End If

        If My.Settings.status = True Then
            checkRemember.Checked = True
        End If

    End Sub


    Private Sub checkRemember_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles checkRemember.ToggleStateChanged
        If checkRemember.Checked = True Then
            My.Settings.status = True
            My.Settings.username = txtUser.Text
            My.Settings.Save()
        Else
            My.Settings.status = False
        End If
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If txtUser.Text <> "" Then
            Me.ErrorProvider1.Dispose()
        End If

        Dim ValidChars As String = _
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
               OrElse e.KeyChar = Convert.ToChar(Keys.Back))

        'Enable Select All
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, RadTextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub txtUser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Leave
        If txtUser.Text = "" Then
            ErrorProvider1.SetError(txtUser, "Username Required")
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If txtPass.Text <> "" Then
            ErrorProvider2.Dispose()
        End If

        Dim ValidChars As String = _
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
               OrElse e.KeyChar = Convert.ToChar(Keys.Back))

        'Enable Select All
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, RadTextBox).SelectAll()
            e.Handled = True
        End If

    End Sub

    Private Sub txtPass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.Leave
        If txtPass.Text = "" Then
            ErrorProvider2.SetError(txtPass, "Password Required")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Enabled = False
        ForgotSendEmail.Show()
    End Sub

    Private Sub txtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
         getnow("SELECT  `full_name`,  `user_type`, `temp_code`, `status` FROM `tbl_users` WHERE username='" & txtUser.Text.Replace("'", " ") & "' and password='" & encryptHash(txtPass.Text) & "'")

        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item(3) = "Active" Then

                If dt.Rows(0).Item(1) = "Secretary" Then
                    Dashboard.Show()
                    ''Maglagay kyo ng iba pang function like may ma didisabled sa DashBorad .. ky0 na bahala
                    Me.Close()

                ElseIf dt.Rows(0).Item(1) = "Administrator" Then

                    Dashboard.Show()
                    Me.Close()

                End If

            Else
                MsgBox("User is inActive, please contact your adminstartor!", MsgBoxStyle.Information)

            End If

        Else
            MsgBox("Invalid Account, Please try Again!", MsgBoxStyle.Exclamation)

        End If











        'conn.Close()
        'conn.Open()
        'MsgBox("Success")



        'RadMessageBox.SetThemeName("Windows8")
        'If txtUser.Text = "" And txtPass.Text = "" Then

        '    Dim prompt As DialogResult = RadMessageBox.Show(Me, "Invalid Login. Please try again.", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
        'End If

        'If txtUser.Text = "" And txtPass.Text <> "" Then

        '    Dim prompt As DialogResult = RadMessageBox.Show(Me, "Invalid Login. Please try again.", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
        'End If

        'If txtUser.Text <> "" And txtPass.Text = "" Then

        '    Dim prompt As DialogResult = RadMessageBox.Show(Me, "Invalid Login. Please try again.", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
        'End If

        'If txtUser.Text <> "" And txtPass.Text <> "" Then
        '    selectQuery("select * from tbl_users where username='" & txtUser.Text & "'  ")

        '    If dr.HasRows Then
        '        Dim Password As String = dr.Item("password")
        '        Dim DecryptedPass As String = decryptHash(Password)

        '        If txtPass.Text = DecryptedPass Then
        '            MsgBox("Login Success")
        '        Else
        '            MsgBox("Incorrect username or password. Please try again.")
        '        End If

        '    End If
        '    If dr.HasRows = False Then

        '        Dim prompt As DialogResult = RadMessageBox.Show(Me, "Incorrect username or password. Please try again.", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
        '    End If
        'End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Enabled = False
        CreateAccount.Show()
    End Sub

    Private Sub RadLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadLabel1.Click

    End Sub

    Private Sub RadLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadLabel2.Click

    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged

    End Sub

 
    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
     
    End Sub

    Private Sub Login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
      
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
            ConnectionSettings.Show()
    End Sub
End Class
