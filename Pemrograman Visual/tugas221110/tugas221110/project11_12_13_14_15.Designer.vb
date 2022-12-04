<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_notepadSederhana
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_fileBuka = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_simpan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_fileTutup = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_editCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_editCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_editPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_format = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_formatFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status_lbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.rtb_notepad = New System.Windows.Forms.RichTextBox()
        Me.sfd_notepad = New System.Windows.Forms.SaveFileDialog()
        Me.ofd_notepad = New System.Windows.Forms.OpenFileDialog()
        Me.fd_notepad = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_file, Me.menu_edit, Me.menu_format})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_file
        '
        Me.menu_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_fileBuka, Me.menu_simpan, Me.ToolStripSeparator1, Me.menu_fileTutup})
        Me.menu_file.Name = "menu_file"
        Me.menu_file.Size = New System.Drawing.Size(37, 20)
        Me.menu_file.Text = "File"
        '
        'menu_fileBuka
        '
        Me.menu_fileBuka.Name = "menu_fileBuka"
        Me.menu_fileBuka.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menu_fileBuka.Size = New System.Drawing.Size(154, 22)
        Me.menu_fileBuka.Text = "Buka"
        '
        'menu_simpan
        '
        Me.menu_simpan.Name = "menu_simpan"
        Me.menu_simpan.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menu_simpan.Size = New System.Drawing.Size(154, 22)
        Me.menu_simpan.Text = "Simpan"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(151, 6)
        '
        'menu_fileTutup
        '
        Me.menu_fileTutup.Name = "menu_fileTutup"
        Me.menu_fileTutup.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.menu_fileTutup.Size = New System.Drawing.Size(154, 22)
        Me.menu_fileTutup.Text = "Tutup"
        '
        'menu_edit
        '
        Me.menu_edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_editCut, Me.menu_editCopy, Me.menu_editPaste})
        Me.menu_edit.Name = "menu_edit"
        Me.menu_edit.Size = New System.Drawing.Size(39, 20)
        Me.menu_edit.Text = "Edit"
        '
        'menu_editCut
        '
        Me.menu_editCut.Name = "menu_editCut"
        Me.menu_editCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.menu_editCut.Size = New System.Drawing.Size(144, 22)
        Me.menu_editCut.Text = "Cut"
        '
        'menu_editCopy
        '
        Me.menu_editCopy.Name = "menu_editCopy"
        Me.menu_editCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menu_editCopy.Size = New System.Drawing.Size(144, 22)
        Me.menu_editCopy.Text = "Copy"
        '
        'menu_editPaste
        '
        Me.menu_editPaste.Name = "menu_editPaste"
        Me.menu_editPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.menu_editPaste.Size = New System.Drawing.Size(152, 22)
        Me.menu_editPaste.Text = "Paste"
        '
        'menu_format
        '
        Me.menu_format.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_formatFont})
        Me.menu_format.Name = "menu_format"
        Me.menu_format.Size = New System.Drawing.Size(57, 20)
        Me.menu_format.Text = "Format"
        '
        'menu_formatFont
        '
        Me.menu_formatFont.Name = "menu_formatFont"
        Me.menu_formatFont.Size = New System.Drawing.Size(152, 22)
        Me.menu_formatFont.Text = "Font"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_lbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status_lbl
        '
        Me.status_lbl.Name = "status_lbl"
        Me.status_lbl.Size = New System.Drawing.Size(269, 17)
        Me.status_lbl.Spring = True
        Me.status_lbl.Text = "ToolStripStatusLabel1"
        Me.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtb_notepad
        '
        Me.rtb_notepad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_notepad.Location = New System.Drawing.Point(0, 24)
        Me.rtb_notepad.Name = "rtb_notepad"
        Me.rtb_notepad.Size = New System.Drawing.Size(284, 215)
        Me.rtb_notepad.TabIndex = 2
        Me.rtb_notepad.Text = ""
        '
        'sfd_notepad
        '
        Me.sfd_notepad.DefaultExt = "txt"
        Me.sfd_notepad.Filter = "Text files (*.txt)|*.txt"
        Me.sfd_notepad.InitialDirectory = "My Documents"
        Me.sfd_notepad.Title = "Simpan"
        '
        'ofd_notepad
        '
        Me.ofd_notepad.DefaultExt = "txt"
        Me.ofd_notepad.FileName = "OpenFileDialog1"
        Me.ofd_notepad.Filter = "Text files (*.txt)|*.txt"
        Me.ofd_notepad.InitialDirectory = "My Documents"
        Me.ofd_notepad.Title = "Buka"
        '
        'frm_notepadSederhana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.rtb_notepad)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_notepadSederhana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notepad sederhana"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_fileTutup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents status_lbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rtb_notepad As System.Windows.Forms.RichTextBox
    Friend WithEvents menu_simpan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sfd_notepad As System.Windows.Forms.SaveFileDialog
    Friend WithEvents menu_fileBuka As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofd_notepad As System.Windows.Forms.OpenFileDialog
    Friend WithEvents menu_edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_editCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_editCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_editPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_format As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_formatFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fd_notepad As System.Windows.Forms.FontDialog
End Class
