<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_notifyIcon
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
        Me.components = New System.ComponentModel.Container()
        Me.ni_salam = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lbl_salam = New System.Windows.Forms.Label()
        Me.txt_salam = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ni_salam
        '
        Me.ni_salam.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ni_salam.BalloonTipTitle = "Salam"
        Me.ni_salam.Text = "NotifyIcon1"
        Me.ni_salam.Visible = True
        '
        'lbl_salam
        '
        Me.lbl_salam.AutoSize = True
        Me.lbl_salam.Location = New System.Drawing.Point(12, 23)
        Me.lbl_salam.Name = "lbl_salam"
        Me.lbl_salam.Size = New System.Drawing.Size(36, 13)
        Me.lbl_salam.TabIndex = 0
        Me.lbl_salam.Text = "Salam"
        '
        'txt_salam
        '
        Me.txt_salam.Location = New System.Drawing.Point(54, 20)
        Me.txt_salam.MaxLength = 64
        Me.txt_salam.Name = "txt_salam"
        Me.txt_salam.Size = New System.Drawing.Size(218, 20)
        Me.txt_salam.TabIndex = 1
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(54, 46)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'frm_notifyIcon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_salam)
        Me.Controls.Add(Me.lbl_salam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_notifyIcon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NotifyIcon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ni_salam As System.Windows.Forms.NotifyIcon
    Friend WithEvents lbl_salam As System.Windows.Forms.Label
    Friend WithEvents txt_salam As System.Windows.Forms.TextBox
    Friend WithEvents btn_ok As System.Windows.Forms.Button
End Class
