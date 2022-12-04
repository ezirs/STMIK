<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_parent
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
        Me.menu_form = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_fNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_fEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_fClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_window = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_wCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_wTHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_wTVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_form, Me.menu_window})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.menu_window
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_form
        '
        Me.menu_form.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_fNew, Me.menu_fEdit, Me.ToolStripSeparator1, Me.menu_fClose})
        Me.menu_form.Name = "menu_form"
        Me.menu_form.Size = New System.Drawing.Size(47, 20)
        Me.menu_form.Text = "Form"
        '
        'menu_fNew
        '
        Me.menu_fNew.Name = "menu_fNew"
        Me.menu_fNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menu_fNew.Size = New System.Drawing.Size(152, 22)
        Me.menu_fNew.Text = "New"
        '
        'menu_fEdit
        '
        Me.menu_fEdit.Name = "menu_fEdit"
        Me.menu_fEdit.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.menu_fEdit.Size = New System.Drawing.Size(152, 22)
        Me.menu_fEdit.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'menu_fClose
        '
        Me.menu_fClose.Name = "menu_fClose"
        Me.menu_fClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F14), System.Windows.Forms.Keys)
        Me.menu_fClose.Size = New System.Drawing.Size(152, 22)
        Me.menu_fClose.Text = "Close"
        '
        'menu_window
        '
        Me.menu_window.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_wCascade, Me.menu_wTHorizontal, Me.menu_wTVertical})
        Me.menu_window.Name = "menu_window"
        Me.menu_window.Size = New System.Drawing.Size(63, 20)
        Me.menu_window.Text = "Window"
        '
        'menu_wCascade
        '
        Me.menu_wCascade.Name = "menu_wCascade"
        Me.menu_wCascade.Size = New System.Drawing.Size(162, 22)
        Me.menu_wCascade.Text = "Cascade"
        '
        'menu_wTHorizontal
        '
        Me.menu_wTHorizontal.Name = "menu_wTHorizontal"
        Me.menu_wTHorizontal.Size = New System.Drawing.Size(162, 22)
        Me.menu_wTHorizontal.Text = "Tile & Horizontally"
        '
        'menu_wTVertical
        '
        Me.menu_wTVertical.Name = "menu_wTVertical"
        Me.menu_wTVertical.Size = New System.Drawing.Size(162, 22)
        Me.menu_wTVertical.Text = "Tile & Vertically"
        '
        'frm_parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_parent"
        Me.Text = "MDI Parent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_form As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_fNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_fEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menu_fClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_window As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_wCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_wTHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_wTVertical As System.Windows.Forms.ToolStripMenuItem
End Class
