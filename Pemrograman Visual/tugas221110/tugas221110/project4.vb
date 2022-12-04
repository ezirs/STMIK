Public Class frm_checkBox

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Dim msg, msg2 As String

        msg2 = ""

        If chbx_olahraga.Checked Then msg2 += "olahraga, "
        If chbx_musik.Checked Then msg2 += "musik, "
        If chbx_sinema.Checked Then msg2 += "sinema, "
        If chbx_belanja.Checked Then msg2 += "belanja, "

        If msg2.Length > 0 Then
            'menghilangkan tanda [, ] di akhir variabel [msg2]...
            msg2 = msg2.Substring(0, msg2.Length - 2)
            msg = "Hobi anda : " & msg2
        Else
            msg = "Anda tidak punya hobi!"
        End If

        MessageBox.Show(msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class