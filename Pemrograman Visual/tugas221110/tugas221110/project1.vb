Public Class frm_helloWorld

    Private Sub btn_Click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Click.Click
        MessageBox.Show("Hello world! Ini Visual Basic .NET")
    End Sub

    Private Sub frm_helloWorld_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dlg_login As frm_login

        dlg_login = New frm_login()

        If dlg_login.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Me.Close()
    End Sub
End Class