Public Class CreateAccount

    Private Sub CreateAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CreateAccount_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        Login.Enabled = True
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click

        getnow("Select username from tbl_users username='" & txtuname.Text & "'")

        If dt.Rows.Count > 0 Then
            MsgBox("Username is already used!", MsgBoxStyle.Exclamation)
            txtuname.Clear()
            txtuname.Focus()

        Else

            getnow("Insert into tbl_users (full_name,username,password,email,user_type,status) " & _
                   "Values('" & txtlname.Text & " " & txtmname.Text & " " & txtlname.Text & "','" & txtuname.Text &
                   "','" & encryptHash(txtpass.Text) & "','" & txtemail.Text & "','Secretary','Inactive' ) ")
            MsgBox("Add Successfully!", MsgBoxStyle.Information)

            ''txtclear nyo nlng.. lagyan ng validations


        End If



    End Sub
End Class



