Public Class frm_panelDanNumericUpDown

    Private Sub gantiPanel()
        If rb_persegi.Checked Then
            pn_persegi.Visible = True
            pn_persegiPanjang.Visible = False

            nud_sisi.Select()
            nud_sisi.Focus()
        Else
            pn_persegi.Visible = False
            pn_persegiPanjang.Visible = True

            nud_panjang.Select()
            nud_panjang.Focus()
        End If
    End Sub

    Private Sub rb_persegi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_persegi.CheckedChanged
        gantiPanel()
    End Sub

    Private Sub rb_persegiPanjang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_persegiPanjang.CheckedChanged
        gantiPanel()
    End Sub

    Private Sub btn_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hitung.Click
        Dim sisi, panjang, lebar, luas As Double
        Dim msg As String

        If rb_persegi.Checked Then
            sisi = Double.Parse(nud_sisi.Value.ToString())
            luas = sisi ^ 2

            msg = "Luas persegi : " + sisi.ToString() + " x " + sisi.ToString() + " = " + luas.ToString()
            MessageBox.Show(msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            panjang = Double.Parse(nud_panjang.Value.ToString())
            lebar = Double.Parse(nud_lebar.Value.ToString())
            luas = panjang * lebar

            msg = "Luas persegi panjang : " & panjang.ToString() + " x " & lebar.ToString() & " = " & luas.ToString()
            MessageBox.Show(msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class