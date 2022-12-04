Public Class frm_webBrowser

    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Dim url As String
        Dim uri As Uri

        url = txt_url.Text
        uri = New Uri(url)

        WebBrowser1.Url = uri
    End Sub

    Private Sub txt_url_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_url.KeyDown
        If e.KeyData = Keys.Enter Then
            btn_go.Focus()
        End If
    End Sub
End Class