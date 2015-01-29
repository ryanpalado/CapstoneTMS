Imports Telerik.WinControls


Public Class ChangePassword

    Private Sub NewPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewPassword_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        ForgotEnterCode.Show()
        Me.Hide()
    End Sub

    Private Sub txtNewPass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPass.KeyPress
        If txtNewPass.Text <> "" Then
            lblResult.Visible = False
        End If

        Dim ValidChars As String = _
          "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
               OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txtConfirmPass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmPass.KeyPress

        If txtConfirmPass.Text <> "" Then
            lblResult2.Visible = False
        End If

        Dim ValidChars As String = _
          "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
               OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click


        If txtNewPass.Text = "" Then
            lblResult.Visible = True
            lblResult.ForeColor = Color.Red
            lblResult.Text = "Field Empty."
        End If
        If txtConfirmPass.Text = "" Then
            lblResult2.Visible = True
            lblResult2.ForeColor = Color.Red
            lblResult2.Text = "Field Empty."
        End If

        If lblResult2.Text = "Password matched." Then
            Dim MD5Password As String = encryptHash(txtNewPass.Text)

            modifyQuery("update tbl_users set password = '" & MD5Password & "' where email = '" & ForgotSendEmail.txtForgotEmail.Text & "' ")
            RadMessageBox.SetThemeName("Windows8")
            Dim prompt As DialogResult = RadMessageBox.Show(Me, "Password successfully reset. You may now login again.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)
            Login.Show()
            Login.Enabled = True
            Me.Close()
            ForgotEnterCode.Close()
            ForgotSendEmail.Close()
        End If

    End Sub

    Private Sub txtConfirmPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmPass.TextChanged
        If txtConfirmPass.Text <> txtNewPass.Text Then
            lblResult2.Visible = True
            lblResult2.ForeColor = Color.Red
            lblResult2.Text = "Password not match. Try Again."
        End If
        If txtConfirmPass.Text = txtNewPass.Text Then
            lblResult2.Visible = True
            lblResult2.ForeColor = Color.Green
            lblResult2.Text = "Password matched."
            If txtConfirmPass.Text = "" Then
                lblResult2.Visible = False
            End If
        End If
    End Sub
End Class
