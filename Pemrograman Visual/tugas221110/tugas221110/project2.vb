Public Class frm_labelDanTextBox


    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        MessageBox.Show("Helo, " & txt_nama.Text & "!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txt_nama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nama.KeyDown
        If e.KeyData = Keys.Enter Then
            btn_ok.Focus()
        End If
    End Sub
End Class