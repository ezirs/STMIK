<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_panelDanNumericUpDown
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
        Me.gb_luas = New System.Windows.Forms.GroupBox()
        Me.rb_persegi = New System.Windows.Forms.RadioButton()
        Me.rb_persegiPanjang = New System.Windows.Forms.RadioButton()
        Me.pn_persegi = New System.Windows.Forms.Panel()
        Me.lbl_sisi = New System.Windows.Forms.Label()
        Me.nud_sisi = New System.Windows.Forms.NumericUpDown()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.pn_persegiPanjang = New System.Windows.Forms.Panel()
        Me.lbl_panjang = New System.Windows.Forms.Label()
        Me.lbl_lebar = New System.Windows.Forms.Label()
        Me.nud_panjang = New System.Windows.Forms.NumericUpDown()
        Me.nud_lebar = New System.Windows.Forms.NumericUpDown()
        Me.gb_luas.SuspendLayout()
        Me.pn_persegi.SuspendLayout()
        CType(Me.nud_sisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_persegiPanjang.SuspendLayout()
        CType(Me.nud_panjang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_lebar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_luas
        '
        Me.gb_luas.Controls.Add(Me.rb_persegiPanjang)
        Me.gb_luas.Controls.Add(Me.rb_persegi)
        Me.gb_luas.Location = New System.Drawing.Point(12, 12)
        Me.gb_luas.Name = "gb_luas"
        Me.gb_luas.Size = New System.Drawing.Size(260, 74)
        Me.gb_luas.TabIndex = 0
        Me.gb_luas.TabStop = False
        Me.gb_luas.Text = "Luas"
        '
        'rb_persegi
        '
        Me.rb_persegi.AutoSize = True
        Me.rb_persegi.Checked = True
        Me.rb_persegi.Location = New System.Drawing.Point(6, 19)
        Me.rb_persegi.Name = "rb_persegi"
        Me.rb_persegi.Size = New System.Drawing.Size(60, 17)
        Me.rb_persegi.TabIndex = 0
        Me.rb_persegi.TabStop = True
        Me.rb_persegi.Text = "Persegi"
        Me.rb_persegi.UseVisualStyleBackColor = True
        '
        'rb_persegiPanjang
        '
        Me.rb_persegiPanjang.AutoSize = True
        Me.rb_persegiPanjang.Location = New System.Drawing.Point(6, 42)
        Me.rb_persegiPanjang.Name = "rb_persegiPanjang"
        Me.rb_persegiPanjang.Size = New System.Drawing.Size(101, 17)
        Me.rb_persegiPanjang.TabIndex = 1
        Me.rb_persegiPanjang.Text = "Persegi panjang"
        Me.rb_persegiPanjang.UseVisualStyleBackColor = True
        '
        'pn_persegi
        '
        Me.pn_persegi.Controls.Add(Me.nud_sisi)
        Me.pn_persegi.Controls.Add(Me.lbl_sisi)
        Me.pn_persegi.Location = New System.Drawing.Point(12, 102)
        Me.pn_persegi.Name = "pn_persegi"
        Me.pn_persegi.Size = New System.Drawing.Size(260, 107)
        Me.pn_persegi.TabIndex = 1
        '
        'lbl_sisi
        '
        Me.lbl_sisi.AutoSize = True
        Me.lbl_sisi.Location = New System.Drawing.Point(12, 13)
        Me.lbl_sisi.Name = "lbl_sisi"
        Me.lbl_sisi.Size = New System.Drawing.Size(23, 13)
        Me.lbl_sisi.TabIndex = 0
        Me.lbl_sisi.Text = "Sisi"
        '
        'nud_sisi
        '
        Me.nud_sisi.Location = New System.Drawing.Point(41, 11)
        Me.nud_sisi.Name = "nud_sisi"
        Me.nud_sisi.Size = New System.Drawing.Size(50, 20)
        Me.nud_sisi.TabIndex = 1
        Me.nud_sisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_sisi.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(197, 215)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(75, 23)
        Me.btn_hitung.TabIndex = 2
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'pn_persegiPanjang
        '
        Me.pn_persegiPanjang.Controls.Add(Me.nud_lebar)
        Me.pn_persegiPanjang.Controls.Add(Me.nud_panjang)
        Me.pn_persegiPanjang.Controls.Add(Me.lbl_lebar)
        Me.pn_persegiPanjang.Controls.Add(Me.lbl_panjang)
        Me.pn_persegiPanjang.Location = New System.Drawing.Point(12, 102)
        Me.pn_persegiPanjang.Name = "pn_persegiPanjang"
        Me.pn_persegiPanjang.Size = New System.Drawing.Size(260, 107)
        Me.pn_persegiPanjang.TabIndex = 2
        '
        'lbl_panjang
        '
        Me.lbl_panjang.AutoSize = True
        Me.lbl_panjang.Location = New System.Drawing.Point(12, 11)
        Me.lbl_panjang.Name = "lbl_panjang"
        Me.lbl_panjang.Size = New System.Drawing.Size(46, 13)
        Me.lbl_panjang.TabIndex = 0
        Me.lbl_panjang.Text = "Panjang"
        '
        'lbl_lebar
        '
        Me.lbl_lebar.AutoSize = True
        Me.lbl_lebar.Location = New System.Drawing.Point(12, 34)
        Me.lbl_lebar.Name = "lbl_lebar"
        Me.lbl_lebar.Size = New System.Drawing.Size(34, 13)
        Me.lbl_lebar.TabIndex = 1
        Me.lbl_lebar.Text = "Lebar"
        '
        'nud_panjang
        '
        Me.nud_panjang.Location = New System.Drawing.Point(64, 9)
        Me.nud_panjang.Name = "nud_panjang"
        Me.nud_panjang.Size = New System.Drawing.Size(50, 20)
        Me.nud_panjang.TabIndex = 2
        Me.nud_panjang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_panjang.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'nud_lebar
        '
        Me.nud_lebar.Location = New System.Drawing.Point(64, 32)
        Me.nud_lebar.Name = "nud_lebar"
        Me.nud_lebar.Size = New System.Drawing.Size(50, 20)
        Me.nud_lebar.TabIndex = 3
        Me.nud_lebar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_lebar.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'frm_panelDanNumericUpDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pn_persegiPanjang)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.pn_persegi)
        Me.Controls.Add(Me.gb_luas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_panelDanNumericUpDown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel dan NumericUpDown"
        Me.gb_luas.ResumeLayout(False)
        Me.gb_luas.PerformLayout()
        Me.pn_persegi.ResumeLayout(False)
        Me.pn_persegi.PerformLayout()
        CType(Me.nud_sisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_persegiPanjang.ResumeLayout(False)
        Me.pn_persegiPanjang.PerformLayout()
        CType(Me.nud_panjang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_lebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_luas As System.Windows.Forms.GroupBox
    Friend WithEvents rb_persegiPanjang As System.Windows.Forms.RadioButton
    Friend WithEvents rb_persegi As System.Windows.Forms.RadioButton
    Friend WithEvents pn_persegi As System.Windows.Forms.Panel
    Friend WithEvents nud_sisi As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_sisi As System.Windows.Forms.Label
    Friend WithEvents btn_hitung As System.Windows.Forms.Button
    Friend WithEvents pn_persegiPanjang As System.Windows.Forms.Panel
    Friend WithEvents nud_lebar As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_panjang As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_lebar As System.Windows.Forms.Label
    Friend WithEvents lbl_panjang As System.Windows.Forms.Label
End Class
