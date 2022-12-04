<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tapConrol
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp_while = New System.Windows.Forms.TabPage()
        Me.Llbl_jlhLoopWhile = New System.Windows.Forms.Label()
        Me.nud_jlhLoopWhile = New System.Windows.Forms.NumericUpDown()
        Me.btn_loopWhile = New System.Windows.Forms.Button()
        Me.tp_doWhile = New System.Windows.Forms.TabPage()
        Me.btn_loopDoWhile = New System.Windows.Forms.Button()
        Me.nud_jlhLoopDoWhile = New System.Windows.Forms.NumericUpDown()
        Me.lbl_jlhLoopDoWhile = New System.Windows.Forms.Label()
        Me.tp_doUntil = New System.Windows.Forms.TabPage()
        Me.tp_for = New System.Windows.Forms.TabPage()
        Me.btn_loopDoUntil = New System.Windows.Forms.Button()
        Me.nud_jlhLoopDoUntil = New System.Windows.Forms.NumericUpDown()
        Me.lbl_jlhLoopDoUntil = New System.Windows.Forms.Label()
        Me.btn_loopFor = New System.Windows.Forms.Button()
        Me.nud_jlhLoopFor = New System.Windows.Forms.NumericUpDown()
        Me.lbl_jlhLoopFor = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tp_while.SuspendLayout()
        CType(Me.nud_jlhLoopWhile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_doWhile.SuspendLayout()
        CType(Me.nud_jlhLoopDoWhile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_doUntil.SuspendLayout()
        Me.tp_for.SuspendLayout()
        CType(Me.nud_jlhLoopDoUntil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_jlhLoopFor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tp_while)
        Me.TabControl1.Controls.Add(Me.tp_doWhile)
        Me.TabControl1.Controls.Add(Me.tp_doUntil)
        Me.TabControl1.Controls.Add(Me.tp_for)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(320, 100)
        Me.TabControl1.TabIndex = 0
        '
        'tp_while
        '
        Me.tp_while.Controls.Add(Me.btn_loopWhile)
        Me.tp_while.Controls.Add(Me.nud_jlhLoopWhile)
        Me.tp_while.Controls.Add(Me.Llbl_jlhLoopWhile)
        Me.tp_while.Location = New System.Drawing.Point(4, 22)
        Me.tp_while.Name = "tp_while"
        Me.tp_while.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_while.Size = New System.Drawing.Size(312, 74)
        Me.tp_while.TabIndex = 0
        Me.tp_while.Text = "While...end while"
        Me.tp_while.UseVisualStyleBackColor = True
        '
        'Llbl_jlhLoopWhile
        '
        Me.Llbl_jlhLoopWhile.AutoSize = True
        Me.Llbl_jlhLoopWhile.Location = New System.Drawing.Point(6, 7)
        Me.Llbl_jlhLoopWhile.Name = "Llbl_jlhLoopWhile"
        Me.Llbl_jlhLoopWhile.Size = New System.Drawing.Size(67, 13)
        Me.Llbl_jlhLoopWhile.TabIndex = 1
        Me.Llbl_jlhLoopWhile.Text = "Jumlah Loop"
        '
        'nud_jlhLoopWhile
        '
        Me.nud_jlhLoopWhile.Location = New System.Drawing.Point(79, 7)
        Me.nud_jlhLoopWhile.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_jlhLoopWhile.Name = "nud_jlhLoopWhile"
        Me.nud_jlhLoopWhile.Size = New System.Drawing.Size(50, 20)
        Me.nud_jlhLoopWhile.TabIndex = 2
        Me.nud_jlhLoopWhile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_jlhLoopWhile.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_loopWhile
        '
        Me.btn_loopWhile.Location = New System.Drawing.Point(135, 7)
        Me.btn_loopWhile.Name = "btn_loopWhile"
        Me.btn_loopWhile.Size = New System.Drawing.Size(75, 23)
        Me.btn_loopWhile.TabIndex = 3
        Me.btn_loopWhile.Text = "Loop"
        Me.btn_loopWhile.UseVisualStyleBackColor = True
        '
        'tp_doWhile
        '
        Me.tp_doWhile.Controls.Add(Me.btn_loopDoWhile)
        Me.tp_doWhile.Controls.Add(Me.nud_jlhLoopDoWhile)
        Me.tp_doWhile.Controls.Add(Me.lbl_jlhLoopDoWhile)
        Me.tp_doWhile.Location = New System.Drawing.Point(4, 22)
        Me.tp_doWhile.Name = "tp_doWhile"
        Me.tp_doWhile.Size = New System.Drawing.Size(312, 74)
        Me.tp_doWhile.TabIndex = 1
        Me.tp_doWhile.Text = "Do while...loop"
        Me.tp_doWhile.UseVisualStyleBackColor = True
        '
        'btn_loopDoWhile
        '
        Me.btn_loopDoWhile.Location = New System.Drawing.Point(132, 5)
        Me.btn_loopDoWhile.Name = "btn_loopDoWhile"
        Me.btn_loopDoWhile.Size = New System.Drawing.Size(75, 23)
        Me.btn_loopDoWhile.TabIndex = 6
        Me.btn_loopDoWhile.Text = "Loop"
        Me.btn_loopDoWhile.UseVisualStyleBackColor = True
        '
        'nud_jlhLoopDoWhile
        '
        Me.nud_jlhLoopDoWhile.Location = New System.Drawing.Point(76, 5)
        Me.nud_jlhLoopDoWhile.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_jlhLoopDoWhile.Name = "nud_jlhLoopDoWhile"
        Me.nud_jlhLoopDoWhile.Size = New System.Drawing.Size(50, 20)
        Me.nud_jlhLoopDoWhile.TabIndex = 5
        Me.nud_jlhLoopDoWhile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_jlhLoopDoWhile.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_jlhLoopDoWhile
        '
        Me.lbl_jlhLoopDoWhile.AutoSize = True
        Me.lbl_jlhLoopDoWhile.Location = New System.Drawing.Point(3, 5)
        Me.lbl_jlhLoopDoWhile.Name = "lbl_jlhLoopDoWhile"
        Me.lbl_jlhLoopDoWhile.Size = New System.Drawing.Size(67, 13)
        Me.lbl_jlhLoopDoWhile.TabIndex = 4
        Me.lbl_jlhLoopDoWhile.Text = "Jumlah Loop"
        '
        'tp_doUntil
        '
        Me.tp_doUntil.Controls.Add(Me.btn_loopDoUntil)
        Me.tp_doUntil.Controls.Add(Me.nud_jlhLoopDoUntil)
        Me.tp_doUntil.Controls.Add(Me.lbl_jlhLoopDoUntil)
        Me.tp_doUntil.Location = New System.Drawing.Point(4, 22)
        Me.tp_doUntil.Name = "tp_doUntil"
        Me.tp_doUntil.Size = New System.Drawing.Size(312, 74)
        Me.tp_doUntil.TabIndex = 2
        Me.tp_doUntil.Text = "Do until...end"
        Me.tp_doUntil.UseVisualStyleBackColor = True
        '
        'tp_for
        '
        Me.tp_for.Controls.Add(Me.btn_loopFor)
        Me.tp_for.Controls.Add(Me.nud_jlhLoopFor)
        Me.tp_for.Controls.Add(Me.lbl_jlhLoopFor)
        Me.tp_for.Location = New System.Drawing.Point(4, 22)
        Me.tp_for.Name = "tp_for"
        Me.tp_for.Size = New System.Drawing.Size(312, 74)
        Me.tp_for.TabIndex = 3
        Me.tp_for.Text = "For"
        Me.tp_for.UseVisualStyleBackColor = True
        '
        'btn_loopDoUntil
        '
        Me.btn_loopDoUntil.Location = New System.Drawing.Point(132, 5)
        Me.btn_loopDoUntil.Name = "btn_loopDoUntil"
        Me.btn_loopDoUntil.Size = New System.Drawing.Size(75, 23)
        Me.btn_loopDoUntil.TabIndex = 9
        Me.btn_loopDoUntil.Text = "Loop"
        Me.btn_loopDoUntil.UseVisualStyleBackColor = True
        '
        'nud_jlhLoopDoUntil
        '
        Me.nud_jlhLoopDoUntil.Location = New System.Drawing.Point(76, 5)
        Me.nud_jlhLoopDoUntil.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_jlhLoopDoUntil.Name = "nud_jlhLoopDoUntil"
        Me.nud_jlhLoopDoUntil.Size = New System.Drawing.Size(50, 20)
        Me.nud_jlhLoopDoUntil.TabIndex = 8
        Me.nud_jlhLoopDoUntil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_jlhLoopDoUntil.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_jlhLoopDoUntil
        '
        Me.lbl_jlhLoopDoUntil.AutoSize = True
        Me.lbl_jlhLoopDoUntil.Location = New System.Drawing.Point(3, 5)
        Me.lbl_jlhLoopDoUntil.Name = "lbl_jlhLoopDoUntil"
        Me.lbl_jlhLoopDoUntil.Size = New System.Drawing.Size(67, 13)
        Me.lbl_jlhLoopDoUntil.TabIndex = 7
        Me.lbl_jlhLoopDoUntil.Text = "Jumlah Loop"
        '
        'btn_loopFor
        '
        Me.btn_loopFor.Location = New System.Drawing.Point(132, 5)
        Me.btn_loopFor.Name = "btn_loopFor"
        Me.btn_loopFor.Size = New System.Drawing.Size(75, 23)
        Me.btn_loopFor.TabIndex = 12
        Me.btn_loopFor.Text = "Loop"
        Me.btn_loopFor.UseVisualStyleBackColor = True
        '
        'nud_jlhLoopFor
        '
        Me.nud_jlhLoopFor.Location = New System.Drawing.Point(76, 5)
        Me.nud_jlhLoopFor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_jlhLoopFor.Name = "nud_jlhLoopFor"
        Me.nud_jlhLoopFor.Size = New System.Drawing.Size(50, 20)
        Me.nud_jlhLoopFor.TabIndex = 11
        Me.nud_jlhLoopFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_jlhLoopFor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_jlhLoopFor
        '
        Me.lbl_jlhLoopFor.AutoSize = True
        Me.lbl_jlhLoopFor.Location = New System.Drawing.Point(3, 5)
        Me.lbl_jlhLoopFor.Name = "lbl_jlhLoopFor"
        Me.lbl_jlhLoopFor.Size = New System.Drawing.Size(67, 13)
        Me.lbl_jlhLoopFor.TabIndex = 10
        Me.lbl_jlhLoopFor.Text = "Jumlah Loop"
        '
        'frm_tapConrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 269)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_tapConrol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tap Control"
        Me.TabControl1.ResumeLayout(False)
        Me.tp_while.ResumeLayout(False)
        Me.tp_while.PerformLayout()
        CType(Me.nud_jlhLoopWhile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_doWhile.ResumeLayout(False)
        Me.tp_doWhile.PerformLayout()
        CType(Me.nud_jlhLoopDoWhile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_doUntil.ResumeLayout(False)
        Me.tp_doUntil.PerformLayout()
        Me.tp_for.ResumeLayout(False)
        Me.tp_for.PerformLayout()
        CType(Me.nud_jlhLoopDoUntil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_jlhLoopFor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tp_while As System.Windows.Forms.TabPage
    Friend WithEvents btn_loopWhile As System.Windows.Forms.Button
    Friend WithEvents nud_jlhLoopWhile As System.Windows.Forms.NumericUpDown
    Friend WithEvents Llbl_jlhLoopWhile As System.Windows.Forms.Label
    Friend WithEvents tp_doWhile As System.Windows.Forms.TabPage
    Friend WithEvents btn_loopDoWhile As System.Windows.Forms.Button
    Friend WithEvents nud_jlhLoopDoWhile As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_jlhLoopDoWhile As System.Windows.Forms.Label
    Friend WithEvents tp_doUntil As System.Windows.Forms.TabPage
    Friend WithEvents btn_loopDoUntil As System.Windows.Forms.Button
    Friend WithEvents nud_jlhLoopDoUntil As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_jlhLoopDoUntil As System.Windows.Forms.Label
    Friend WithEvents tp_for As System.Windows.Forms.TabPage
    Friend WithEvents btn_loopFor As System.Windows.Forms.Button
    Friend WithEvents nud_jlhLoopFor As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_jlhLoopFor As System.Windows.Forms.Label
End Class
