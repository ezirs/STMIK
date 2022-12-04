Public Class frm_parent

    Private Sub menu_fClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_fClose.Click
        Dim dlg_login As frm_login

        dlg_login = New frm_login()

        If dlg_login.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Me.Close()
    End Sub

    Private Sub menu_wCascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_wCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub menu_wTHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_wTHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub menu_wTVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_wTVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub menu_fNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_fNew.Click
        Dim dlg_new As frm_new
        dlg_new = New frm_new()
        dlg_new.MdiParent = Me
        dlg_new.Show()
    End Sub

    Private Sub menu_fEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_fEdit.Click
        Dim dlg_edit As frm_edit
        dlg_edit = New frm_edit()
        dlg_edit.MdiParent = Me
        dlg_edit.Show()
    End Sub
End Class