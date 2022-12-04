Public Class frm_notifyIcon

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        If txt_salam.Text.Trim().Length > 0 Then
            ni_salam.BalloonTipText = txt_salam.Text
            ni_salam.Text = txt_salam.Text
            ni_salam.ShowBalloonTip(10000)
        Else
            MessageBox.Show("Salam belum diisi", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txt_salam.SelectAll()
        txt_salam.Focus()
    End Sub

    Private Sub txt_salam_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_salam.KeyDown
        If e.KeyData = Keys.Enter Then
            btn_ok.Focus()
        End If
    End Sub
End Class