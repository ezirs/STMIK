Imports System.IO
Public Class frm_notepadSederhana


    Private Sub menu_fileTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_fileTutup.Click
        Dim msg As String
        Dim dr As DialogResult

        msg = "Apakah anda yakin untuk menutup program?"
        dr = MessageBox.Show(msg, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If dr = Windows.Forms.DialogResult.OK Then Me.Close()
    End Sub

    Private Sub menu_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_simpan.Click
        Dim fs As FileStream
        Dim sw As StreamWriter
        Dim msg As String

        If sfd_notepad.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub

        fs = New FileStream(sfd_notepad.FileName, FileMode.Create, FileAccess.Write)
        sw = New StreamWriter(fs)
        sw.Write(rtb_notepad.Text)
        sw.Flush()
        sw.Close()
        fs.Close()

        msg = "File telah disimpan ke : " + sfd_notepad.FileName
        status_lbl.Text = msg

    End Sub

    Private Sub menu_fileBuka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_fileBuka.Click
        Dim fs As FileStream
        Dim sr As StreamReader
        Dim msg As String

        If ofd_notepad.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub

        fs = New FileStream(ofd_notepad.FileName, FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        rtb_notepad.Text = sr.ReadToEnd()
        sr.Close()
        fs.Close()

        msg = "File telah dibuka dari : " + ofd_notepad.FileName
        status_lbl.Text = msg
    End Sub

    Private Sub menu_editCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_editCut.Click
        rtb_notepad.Cut()
    End Sub

    Private Sub menu_editCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_editCopy.Click
        rtb_notepad.Copy()
    End Sub

    Private Sub menu_formatFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_formatFont.Click
        If fd_notepad.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub

        rtb_notepad.Font = fd_notepad.Font
    End Sub

    Private Sub menu_editPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_editPaste.Click
        rtb_notepad.Paste()
    End Sub
End Class