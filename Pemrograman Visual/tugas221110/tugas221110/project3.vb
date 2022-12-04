Public Class frm_groupBoxDanRadioButtot

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Dim msg As String

        msg = "Anda adalah seorang "

        If rb_laki.Checked Then
            msg += "laki-laki"
        Else
            msg += "perempuan"
        End If

        MessageBox.Show(msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class