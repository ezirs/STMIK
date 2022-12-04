Public Class frm_multipleForm

    Private Sub frm_multipleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dlg_login As frm_login

        dlg_login = New frm_login()

        If dlg_login.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Me.Close()
    End Sub

End Class