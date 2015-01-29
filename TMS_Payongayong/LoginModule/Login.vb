Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        If txtUser.Text = "" And txtPass.Text = "" Then
            RadMessageBox.SetThemeName("Windows8")
            Dim prompt As DialogResult = RadMessageBox.Show(Me, "Invalid Login. Please try again.", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If

        If txtUser.Text = "" And txtPass.Text <> "" Then
            RadMessageBox.SetThemeName("Windows8")
            Dim prompt As DialogResult = RadMessageBox.Show(Me, "Invalid Login. Please try again.", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If

        If txtUser.Text <> "" And txtPass.Text = "" Then
            RadMessageBox.SetThemeName("Windows8")
            Dim prompt As DialogResult = RadMessageBox.Show(Me, "Invalid Login. Please try again.", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If

        If txtUser.Text <> "" And txtPass.Text <> "" Then
            selectQuery("select * from tbl_users where username='" & txtUser.Text & "'  ")

            If dr.HasRows Then
                Dim Password As String = dr.Item("password")
                Dim DecryptedPass As String = decryptHash(Password)

                If txtPass.Text = DecryptedPass Then
                    MsgBox("Login Success")
                Else
                    MsgBox("Incorrect username or password. Please try again.")
                End If

            End If
            If dr.HasRows = False Then
                RadMessageBox.SetThemeName("Windows8")
                Dim prompt As DialogResult = RadMessageBox.Show(Me, "Incorrect username or password. Please try again.", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        End If
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
End Class
