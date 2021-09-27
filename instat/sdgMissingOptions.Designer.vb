<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMissingOptions
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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrInputPercentage = New instat.ucrInputTextBox()
        Me.ucrChkMinNumNonMissing = New instat.ucrCheck()
        Me.ucrNudNumberNotMissing = New instat.ucrNud()
        Me.ucrNudConsecutive = New instat.ucrNud()
        Me.ucrChkConsecutiveMissing = New instat.ucrCheck()
        Me.ucrChkMaxNumMissing = New instat.ucrCheck()
        Me.ucrChkMaxPercMissing = New instat.ucrCheck()
        Me.ucrNudNumber = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(81, 145)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(155, 30)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputPercentage
        '
        Me.ucrInputPercentage.AddQuotesIfUnrecognised = True
        Me.ucrInputPercentage.IsMultiline = False
        Me.ucrInputPercentage.IsReadOnly = False
        Me.ucrInputPercentage.Location = New System.Drawing.Point(268, 70)
        Me.ucrInputPercentage.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputPercentage.Name = "ucrInputPercentage"
        Me.ucrInputPercentage.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputPercentage.TabIndex = 14
        '
        'ucrChkMinNumNonMissing
        '
        Me.ucrChkMinNumNonMissing.Checked = False
        Me.ucrChkMinNumNonMissing.Location = New System.Drawing.Point(9, 41)
        Me.ucrChkMinNumNonMissing.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMinNumNonMissing.Name = "ucrChkMinNumNonMissing"
        Me.ucrChkMinNumNonMissing.Size = New System.Drawing.Size(258, 20)
        Me.ucrChkMinNumNonMissing.TabIndex = 11
        '
        'ucrNudNumberNotMissing
        '
        Me.ucrNudNumberNotMissing.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberNotMissing.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberNotMissing.Location = New System.Drawing.Point(268, 41)
        Me.ucrNudNumberNotMissing.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudNumberNotMissing.Maximum = New Decimal(New Integer() {340, 0, 0, 0})
        Me.ucrNudNumberNotMissing.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberNotMissing.Name = "ucrNudNumberNotMissing"
        Me.ucrNudNumberNotMissing.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberNotMissing.TabIndex = 12
        Me.ucrNudNumberNotMissing.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudConsecutive
        '
        Me.ucrNudConsecutive.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConsecutive.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudConsecutive.Location = New System.Drawing.Point(268, 99)
        Me.ucrNudConsecutive.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudConsecutive.Maximum = New Decimal(New Integer() {340, 0, 0, 0})
        Me.ucrNudConsecutive.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConsecutive.Name = "ucrNudConsecutive"
        Me.ucrNudConsecutive.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudConsecutive.TabIndex = 16
        Me.ucrNudConsecutive.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkConsecutiveMissing
        '
        Me.ucrChkConsecutiveMissing.Checked = False
        Me.ucrChkConsecutiveMissing.Location = New System.Drawing.Point(9, 99)
        Me.ucrChkConsecutiveMissing.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkConsecutiveMissing.Name = "ucrChkConsecutiveMissing"
        Me.ucrChkConsecutiveMissing.Size = New System.Drawing.Size(258, 20)
        Me.ucrChkConsecutiveMissing.TabIndex = 15
        '
        'ucrChkMaxNumMissing
        '
        Me.ucrChkMaxNumMissing.Checked = False
        Me.ucrChkMaxNumMissing.Location = New System.Drawing.Point(9, 12)
        Me.ucrChkMaxNumMissing.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMaxNumMissing.Name = "ucrChkMaxNumMissing"
        Me.ucrChkMaxNumMissing.Size = New System.Drawing.Size(258, 20)
        Me.ucrChkMaxNumMissing.TabIndex = 9
        '
        'ucrChkMaxPercMissing
        '
        Me.ucrChkMaxPercMissing.Checked = False
        Me.ucrChkMaxPercMissing.Location = New System.Drawing.Point(9, 70)
        Me.ucrChkMaxPercMissing.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMaxPercMissing.Name = "ucrChkMaxPercMissing"
        Me.ucrChkMaxPercMissing.Size = New System.Drawing.Size(258, 20)
        Me.ucrChkMaxPercMissing.TabIndex = 13
        '
        'ucrNudNumber
        '
        Me.ucrNudNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumber.Location = New System.Drawing.Point(268, 11)
        Me.ucrNudNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Name = "ucrNudNumber"
        Me.ucrNudNumber.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumber.TabIndex = 10
        Me.ucrNudNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'sdgMissingOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 176)
        Me.Controls.Add(Me.ucrInputPercentage)
        Me.Controls.Add(Me.ucrChkMinNumNonMissing)
        Me.Controls.Add(Me.ucrNudNumberNotMissing)
        Me.Controls.Add(Me.ucrNudConsecutive)
        Me.Controls.Add(Me.ucrChkConsecutiveMissing)
        Me.Controls.Add(Me.ucrChkMaxNumMissing)
        Me.Controls.Add(Me.ucrChkMaxPercMissing)
        Me.Controls.Add(Me.ucrNudNumber)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMissingOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options for Missing Values"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrInputPercentage As ucrInputTextBox
    Friend WithEvents ucrChkMinNumNonMissing As ucrCheck
    Friend WithEvents ucrNudNumberNotMissing As ucrNud
    Friend WithEvents ucrNudConsecutive As ucrNud
    Friend WithEvents ucrChkConsecutiveMissing As ucrCheck
    Friend WithEvents ucrChkMaxNumMissing As ucrCheck
    Friend WithEvents ucrChkMaxPercMissing As ucrCheck
    Friend WithEvents ucrNudNumber As ucrNud
End Class
