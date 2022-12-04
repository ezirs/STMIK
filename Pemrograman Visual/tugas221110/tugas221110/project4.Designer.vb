<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_checkBox
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chbx_olahraga = New System.Windows.Forms.CheckBox()
        Me.chbx_musik = New System.Windows.Forms.CheckBox()
        Me.chbx_sinema = New System.Windows.Forms.CheckBox()
        Me.chbx_belanja = New System.Windows.Forms.CheckBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hobi Anda"
        '
        'chbx_olahraga
        '
        Me.chbx_olahraga.AutoSize = True
        Me.chbx_olahraga.Location = New System.Drawing.Point(15, 58)
        Me.chbx_olahraga.Name = "chbx_olahraga"
        Me.chbx_olahraga.Size = New System.Drawing.Size(69, 17)
        Me.chbx_olahraga.TabIndex = 1
        Me.chbx_olahraga.Text = "Olahraga"
        Me.chbx_olahraga.UseVisualStyleBackColor = True
        '
        'chbx_musik
        '
        Me.chbx_musik.AutoSize = True
        Me.chbx_musik.Location = New System.Drawing.Point(15, 81)
        Me.chbx_musik.Name = "chbx_musik"
        Me.chbx_musik.Size = New System.Drawing.Size(54, 17)
        Me.chbx_musik.TabIndex = 2
        Me.chbx_musik.Text = "Musik"
        Me.chbx_musik.UseVisualStyleBackColor = True
        '
        'chbx_sinema
        '
        Me.chbx_sinema.AutoSize = True
        Me.chbx_sinema.Location = New System.Drawing.Point(15, 104)
        Me.chbx_sinema.Name = "chbx_sinema"
        Me.chbx_sinema.Size = New System.Drawing.Size(61, 17)
        Me.chbx_sinema.TabIndex = 3
        Me.chbx_sinema.Text = "Sinema"
        Me.chbx_sinema.UseVisualStyleBackColor = True
        '
        'chbx_belanja
        '
        Me.chbx_belanja.AutoSize = True
        Me.chbx_belanja.Location = New System.Drawing.Point(15, 127)
        Me.chbx_belanja.Name = "chbx_belanja"
        Me.chbx_belanja.Size = New System.Drawing.Size(61, 17)
        Me.chbx_belanja.TabIndex = 4
        Me.chbx_belanja.Text = "Belanja"
        Me.chbx_belanja.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(12, 160)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 5
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'frm_checkBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.chbx_belanja)
        Me.Controls.Add(Me.chbx_sinema)
        Me.Controls.Add(Me.chbx_musik)
        Me.Controls.Add(Me.chbx_olahraga)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_checkBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chbx_olahraga As System.Windows.Forms.CheckBox
    Friend WithEvents chbx_musik As System.Windows.Forms.CheckBox
    Friend WithEvents chbx_sinema As System.Windows.Forms.CheckBox
    Friend WithEvents chbx_belanja As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ok As System.Windows.Forms.Button
End Class
