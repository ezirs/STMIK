<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_comboBoxDanListBox
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
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.cmbx_status = New System.Windows.Forms.ComboBox()
        Me.btn_status = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsbx_tinggal = New System.Windows.Forms.ListBox()
        Me.btn_tinggal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(8, 34)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(64, 13)
        Me.lbl_status.TabIndex = 0
        Me.lbl_status.Text = "Status anda"
        '
        'cmbx_status
        '
        Me.cmbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbx_status.FormattingEnabled = True
        Me.cmbx_status.Items.AddRange(New Object() {"Belum menikah", "Menikah", "Duda", "Janda"})
        Me.cmbx_status.Location = New System.Drawing.Point(98, 31)
        Me.cmbx_status.Name = "cmbx_status"
        Me.cmbx_status.Size = New System.Drawing.Size(96, 21)
        Me.cmbx_status.TabIndex = 1
        '
        'btn_status
        '
        Me.btn_status.Location = New System.Drawing.Point(200, 29)
        Me.btn_status.Name = "btn_status"
        Me.btn_status.Size = New System.Drawing.Size(75, 23)
        Me.btn_status.TabIndex = 6
        Me.btn_status.Text = "Status"
        Me.btn_status.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tinggal bersama"
        '
        'lsbx_tinggal
        '
        Me.lsbx_tinggal.FormattingEnabled = True
        Me.lsbx_tinggal.Items.AddRange(New Object() {"Kakek", "Nenek", "Papa", "Mama", "Paman", "Bibi", "Saudara", "Sepupu"})
        Me.lsbx_tinggal.Location = New System.Drawing.Point(98, 102)
        Me.lsbx_tinggal.Name = "lsbx_tinggal"
        Me.lsbx_tinggal.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lsbx_tinggal.Size = New System.Drawing.Size(96, 95)
        Me.lsbx_tinggal.TabIndex = 9
        '
        'btn_tinggal
        '
        Me.btn_tinggal.Location = New System.Drawing.Point(200, 102)
        Me.btn_tinggal.Name = "btn_tinggal"
        Me.btn_tinggal.Size = New System.Drawing.Size(75, 23)
        Me.btn_tinggal.TabIndex = 10
        Me.btn_tinggal.Text = "Tinggal"
        Me.btn_tinggal.UseVisualStyleBackColor = True
        '
        'frm_comboBoxDanListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_tinggal)
        Me.Controls.Add(Me.lsbx_tinggal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_status)
        Me.Controls.Add(Me.cmbx_status)
        Me.Controls.Add(Me.lbl_status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_comboBoxDanListBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ComboBox dan ListBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents cmbx_status As System.Windows.Forms.ComboBox
    Friend WithEvents btn_status As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lsbx_tinggal As System.Windows.Forms.ListBox
    Friend WithEvents btn_tinggal As System.Windows.Forms.Button
End Class
