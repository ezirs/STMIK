<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_groupBoxDanRadioButtot
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_laki = New System.Windows.Forms.RadioButton()
        Me.rb_perempuan = New System.Windows.Forms.RadioButton()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_perempuan)
        Me.GroupBox1.Controls.Add(Me.rb_laki)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'rb_laki
        '
        Me.rb_laki.AutoSize = True
        Me.rb_laki.Checked = True
        Me.rb_laki.Location = New System.Drawing.Point(6, 19)
        Me.rb_laki.Name = "rb_laki"
        Me.rb_laki.Size = New System.Drawing.Size(68, 17)
        Me.rb_laki.TabIndex = 0
        Me.rb_laki.TabStop = True
        Me.rb_laki.Text = "Laki-Laki"
        Me.rb_laki.UseVisualStyleBackColor = True
        '
        'rb_perempuan
        '
        Me.rb_perempuan.AutoSize = True
        Me.rb_perempuan.Location = New System.Drawing.Point(6, 42)
        Me.rb_perempuan.Name = "rb_perempuan"
        Me.rb_perempuan.Size = New System.Drawing.Size(79, 17)
        Me.rb_perempuan.TabIndex = 1
        Me.rb_perempuan.TabStop = True
        Me.rb_perempuan.Text = "Perempuan"
        Me.rb_perempuan.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(11, 89)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 1
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'frm_groupBoxDanRadioButtot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_groupBoxDanRadioButtot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GroupBox dan RadioButton"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rb_laki As System.Windows.Forms.RadioButton
    Friend WithEvents btn_ok As System.Windows.Forms.Button
End Class
