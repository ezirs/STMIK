Public Class frm_tapConrol

    Private Sub btn_loopWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_loopWhile.Click
        Dim i, jlhLoop As Integer

        jlhLoop = Integer.Parse(nud_jlhLoopWhile.Value.ToString())

        i = 1

        While (i <= jlhLoop)
            MessageBox.Show("Ini loop ke-" + i.ToString() + " dari " + jlhLoop.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            i += 1
        End While
    End Sub

    Private Sub btn_loopDoWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_loopDoWhile.Click
        Dim i, jlhLoop As Integer

        jlhLoop = Integer.Parse(nud_jlhLoopDoWhile.Value.ToString())

        i = 1

        Do While (i <= jlhLoop)
            MessageBox.Show("Ini loop ke-" + i.ToString() + " dari " + jlhLoop.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            i += 1
        Loop
    End Sub

    Private Sub btn_loopDoUntil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_loopDoUntil.Click
        Dim i, jlhLoop As Integer

        jlhLoop = Integer.Parse(nud_jlhLoopDoUntil.Value.ToString())

        i = 1

        Do Until (i > jlhLoop)
            MessageBox.Show("Ini loop ke-" + i.ToString() + " dari " + jlhLoop.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            i += 1
        Loop
    End Sub

    Private Sub btn_loopFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_loopFor.Click
        Dim i, jlhLoop As Integer

        jlhLoop = Integer.Parse(nud_jlhLoopFor.Value.ToString())

        For i = 1 To jlhLoop
            MessageBox.Show("Ini loop ke-" + i.ToString() + " dari " + jlhLoop.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Next
    End Sub
End Class