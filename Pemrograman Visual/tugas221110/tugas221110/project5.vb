Public Class frm_comboBoxDanListBox

    Private Sub btn_status_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_status.Click
        Dim msg As String

        If cmbx_status.SelectedIndex < 0 Then
            msg = "Anda belum memilih status anda"
        Else
            msg = "Status anda : " & cmbx_status.SelectedItem.ToString()
        End If

        MessageBox.Show(msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        cmbx_status.SelectAll()
        cmbx_status.Focus()
    End Sub

    Private Sub cmbx_status_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbx_status.KeyDown
        If e.KeyData = Keys.Enter Then btn_status.Focus()
    End Sub

    Private Sub btn_tinggal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tinggal.Click
        Dim i As Integer
        Dim msg, msg2 As String

        msg2 = ""

        For i = 0 To lsbx_tinggal.SelectedItems.Count - 1
            msg2 += lsbx_tinggal.SelectedItems(i) & ", "
        Next

        If msg2.Length > 0 Then
            msg2 = msg2.Substring(0, msg2.Length - 2)
            msg = "Anda tinggal bersama " & msg2
        Else
            msg = "Anda seorang diri!"
        End If

        MessageBox.Show(msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        lsbx_tinggal.Focus()
    End Sub

    Private Sub lsbx_tinggal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsbx_tinggal.KeyDown
        If e.KeyData = Keys.Enter Then btn_tinggal.Focus()
    End Sub
End Class