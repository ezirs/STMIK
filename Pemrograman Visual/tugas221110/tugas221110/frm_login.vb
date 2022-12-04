Public Class frm_login

    Private Sub txt_username_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyData = Keys.Enter Then
            txt_password.SelectAll()
            txt_password.Focus()
        End If
    End Sub

    Private Sub txt_password_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyData = Keys.Enter Then
            btn_login.Focus()
        End If
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_password.Text = "Andi" Then
            MessageBox.Show("Selamat datang, " + txt_username.Text + "!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Password anda salah", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

            txt_password.Clear()
            txt_password.Focus()
        End If
    End Sub
End Class