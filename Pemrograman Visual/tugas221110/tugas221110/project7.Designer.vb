<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_webBrowser
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
        Me.lbl_url = New System.Windows.Forms.Label()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.btn_go = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'lbl_url
        '
        Me.lbl_url.AutoSize = True
        Me.lbl_url.Location = New System.Drawing.Point(18, 29)
        Me.lbl_url.Name = "lbl_url"
        Me.lbl_url.Size = New System.Drawing.Size(29, 13)
        Me.lbl_url.TabIndex = 0
        Me.lbl_url.Text = "URL"
        '
        'txt_url
        '
        Me.txt_url.Location = New System.Drawing.Point(62, 25)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(225, 20)
        Me.txt_url.TabIndex = 1
        '
        'btn_go
        '
        Me.btn_go.Location = New System.Drawing.Point(293, 23)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(75, 23)
        Me.btn_go.TabIndex = 2
        Me.btn_go.Text = "Go"
        Me.btn_go.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 53)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(356, 197)
        Me.WebBrowser1.TabIndex = 3
        '
        'frm_webBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 261)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.txt_url)
        Me.Controls.Add(Me.lbl_url)
        Me.Name = "frm_webBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_url As System.Windows.Forms.Label
    Friend WithEvents txt_url As System.Windows.Forms.TextBox
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
