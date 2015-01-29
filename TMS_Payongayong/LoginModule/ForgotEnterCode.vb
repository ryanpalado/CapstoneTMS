Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class ForgotEnterCode

    Private Sub ForgotEnterCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ForgotEnterCode_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        ForgotSendEmail.Show()
        Me.Hide()

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click
        'Required field validation.
        If txtCode.Text = "" Then
            lblResult.Visible = True
            lblResult.ForeColor = Color.Red
            lblResult.Text = "Field empty."
        End If

        If txtCode.Text <> "" Then
            selectQuery("select temp_code from tbl_users where email='" & ForgotSendEmail.txtForgotEmail.Text & "' ")
            If dr.HasRows Then
                If dr.Item("temp_code") = txtCode.Text Then
                    RadMessageBox.SetThemeName("Windows8")
                    Dim prompt As DialogResult = RadMessageBox.Show(Me, "Code Valid.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)
                    ChangePassword.Show()
                    Me.Hide()
                Else
                    lblResult.Visible = True
                    lblResult.ForeColor = Color.Red
                    lblResult.Text = "Invalid Code.Please try again."
                End If
            End If
        End If



    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        'Remove error label if the textbox is not empty
        If txtCode.Text <> "" Then
            lblResult.Visible = False
        End If

        'Numbers Only
        Dim ValidChars As String = _
            "0123456789"
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
               OrElse e.KeyChar = Convert.ToChar(Keys.Back))



    End Sub

    Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click

    End Sub
End Class
