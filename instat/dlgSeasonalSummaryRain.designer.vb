<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSeasonalSummaryRain
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
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.lblMeanLabel = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.lblStartMonth = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.lblNumberofMonths = New System.Windows.Forms.Label()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.txtSpellLengthName = New System.Windows.Forms.TextBox()
        Me.txtLongDrySpellName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLongDrySpellLabel = New System.Windows.Forms.Label()
        Me.lblSpelllengthName = New System.Windows.Forms.Label()
        Me.ucrNudStartMonth = New instat.ucrNud()
        Me.ucrNudNosOfMonths = New instat.ucrNud()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.UcrCheck2 = New instat.ucrCheck()
        Me.UcrCheck3 = New instat.ucrCheck()
        Me.ucrChkStrictThreshold = New instat.ucrCheck()
        Me.ucrChkCountLabel = New instat.ucrCheck()
        Me.ucrChkSumLabel = New instat.ucrCheck()
        Me.ucrChkReplace = New instat.ucrCheck()
        Me.ucrChkLongestDrySpellName = New instat.ucrCheck()
        Me.ucrChkMean = New instat.ucrCheck()
        Me.ucrChkRemoveNA = New instat.ucrCheck()
        Me.grpSummaries.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 325)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 53)
        Me.ucrBase.TabIndex = 0
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.ucrChkMean)
        Me.grpSummaries.Controls.Add(Me.ucrNudNosOfMonths)
        Me.grpSummaries.Controls.Add(Me.ucrNudStartMonth)
        Me.grpSummaries.Controls.Add(Me.lblMeanLabel)
        Me.grpSummaries.Controls.Add(Me.ucrChkCountLabel)
        Me.grpSummaries.Controls.Add(Me.ucrChkSumLabel)
        Me.grpSummaries.Controls.Add(Me.lblCount)
        Me.grpSummaries.Controls.Add(Me.lblTotals)
        Me.grpSummaries.Controls.Add(Me.lblStartMonth)
        Me.grpSummaries.Controls.Add(Me.txtTotal)
        Me.grpSummaries.Controls.Add(Me.txtCount)
        Me.grpSummaries.Controls.Add(Me.lblNumberofMonths)
        Me.grpSummaries.Controls.Add(Me.txtMean)
        Me.grpSummaries.Location = New System.Drawing.Point(12, 26)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(496, 134)
        Me.grpSummaries.TabIndex = 11
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Tag = "Summaries"
        Me.grpSummaries.Text = "Summaries"
        '
        'lblMeanLabel
        '
        Me.lblMeanLabel.AutoSize = True
        Me.lblMeanLabel.Location = New System.Drawing.Point(232, 106)
        Me.lblMeanLabel.Name = "lblMeanLabel"
        Me.lblMeanLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblMeanLabel.TabIndex = 23
        Me.lblMeanLabel.Tag = "Mean_Label"
        Me.lblMeanLabel.Text = "Label5"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(232, 62)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(39, 13)
        Me.lblCount.TabIndex = 22
        Me.lblCount.Tag = "Count_Label"
        Me.lblCount.Text = "Label4"
        '
        'lblTotals
        '
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Location = New System.Drawing.Point(232, 20)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(39, 13)
        Me.lblTotals.TabIndex = 21
        Me.lblTotals.Tag = "Total_Label"
        Me.lblTotals.Text = "Label3"
        '
        'lblStartMonth
        '
        Me.lblStartMonth.AutoSize = True
        Me.lblStartMonth.Location = New System.Drawing.Point(6, 86)
        Me.lblStartMonth.Name = "lblStartMonth"
        Me.lblStartMonth.Size = New System.Drawing.Size(39, 13)
        Me.lblStartMonth.TabIndex = 14
        Me.lblStartMonth.Tag = "Start_Month"
        Me.lblStartMonth.Text = "Label2"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(301, 19)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(189, 20)
        Me.txtTotal.TabIndex = 16
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(301, 62)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(189, 20)
        Me.txtCount.TabIndex = 19
        '
        'lblNumberofMonths
        '
        Me.lblNumberofMonths.AutoSize = True
        Me.lblNumberofMonths.Location = New System.Drawing.Point(6, 106)
        Me.lblNumberofMonths.Name = "lblNumberofMonths"
        Me.lblNumberofMonths.Size = New System.Drawing.Size(39, 13)
        Me.lblNumberofMonths.TabIndex = 13
        Me.lblNumberofMonths.Tag = "Nos._of_Months"
        Me.lblNumberofMonths.Text = "Label1"
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(301, 102)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.Size = New System.Drawing.Size(189, 20)
        Me.txtMean.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UcrCheck3)
        Me.GroupBox2.Controls.Add(Me.UcrCheck2)
        Me.GroupBox2.Controls.Add(Me.UcrCheck1)
        Me.GroupBox2.Controls.Add(Me.ucrNudThreshold)
        Me.GroupBox2.Controls.Add(Me.lblThreshold)
        Me.GroupBox2.Location = New System.Drawing.Point(321, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 82)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Threshold"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(142, 58)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold.TabIndex = 25
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label3"
        '
        'txtSpellLengthName
        '
        Me.txtSpellLengthName.Location = New System.Drawing.Point(130, 234)
        Me.txtSpellLengthName.Name = "txtSpellLengthName"
        Me.txtSpellLengthName.Size = New System.Drawing.Size(100, 20)
        Me.txtSpellLengthName.TabIndex = 17
        '
        'txtLongDrySpellName
        '
        Me.txtLongDrySpellName.Location = New System.Drawing.Point(130, 208)
        Me.txtLongDrySpellName.Name = "txtLongDrySpellName"
        Me.txtLongDrySpellName.Size = New System.Drawing.Size(100, 20)
        Me.txtLongDrySpellName.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Data list not implemented"
        '
        'lblLongDrySpellLabel
        '
        Me.lblLongDrySpellLabel.AutoSize = True
        Me.lblLongDrySpellLabel.Location = New System.Drawing.Point(37, 208)
        Me.lblLongDrySpellLabel.Name = "lblLongDrySpellLabel"
        Me.lblLongDrySpellLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblLongDrySpellLabel.TabIndex = 25
        Me.lblLongDrySpellLabel.Tag = "Long_Dry_Spell_Label"
        Me.lblLongDrySpellLabel.Text = "Label7"
        '
        'lblSpelllengthName
        '
        Me.lblSpelllengthName.AutoSize = True
        Me.lblSpelllengthName.Location = New System.Drawing.Point(37, 237)
        Me.lblSpelllengthName.Name = "lblSpelllengthName"
        Me.lblSpelllengthName.Size = New System.Drawing.Size(39, 13)
        Me.lblSpelllengthName.TabIndex = 26
        Me.lblSpelllengthName.Tag = "Spell_Name"
        Me.lblSpelllengthName.Text = "Label8"
        '
        'ucrNudStartMonth
        '
        Me.ucrNudStartMonth.bAddRemoveParameter = True
        Me.ucrNudStartMonth.bChangeParameterValue = True
        Me.ucrNudStartMonth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStartMonth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudStartMonth.Location = New System.Drawing.Point(118, 84)
        Me.ucrNudStartMonth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudStartMonth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStartMonth.Name = "ucrNudStartMonth"
        Me.ucrNudStartMonth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudStartMonth.TabIndex = 24
        Me.ucrNudStartMonth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNosOfMonths
        '
        Me.ucrNudNosOfMonths.bAddRemoveParameter = True
        Me.ucrNudNosOfMonths.bChangeParameterValue = True
        Me.ucrNudNosOfMonths.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNosOfMonths.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNosOfMonths.Location = New System.Drawing.Point(118, 110)
        Me.ucrNudNosOfMonths.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNosOfMonths.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNosOfMonths.Name = "ucrNudNosOfMonths"
        Me.ucrNudNosOfMonths.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNosOfMonths.TabIndex = 25
        Me.ucrNudNosOfMonths.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.bAddRemoveParameter = True
        Me.ucrNudThreshold.bChangeParameterValue = True
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(187, 56)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreshold.TabIndex = 26
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrCheck1
        '
        Me.UcrCheck1.bAddRemoveParameter = True
        Me.UcrCheck1.bChangeParameterValue = True
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(17, 56)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck1.TabIndex = 27
        '
        'UcrCheck2
        '
        Me.UcrCheck2.bAddRemoveParameter = True
        Me.UcrCheck2.bChangeParameterValue = True
        Me.UcrCheck2.Checked = False
        Me.UcrCheck2.Location = New System.Drawing.Point(17, 19)
        Me.UcrCheck2.Name = "UcrCheck2"
        Me.UcrCheck2.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck2.TabIndex = 28
        '
        'UcrCheck3
        '
        Me.UcrCheck3.bAddRemoveParameter = True
        Me.UcrCheck3.bChangeParameterValue = True
        Me.UcrCheck3.Checked = False
        Me.UcrCheck3.Location = New System.Drawing.Point(145, 19)
        Me.UcrCheck3.Name = "UcrCheck3"
        Me.UcrCheck3.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck3.TabIndex = 29
        '
        'ucrChkStrictThreshold
        '
        Me.ucrChkStrictThreshold.bAddRemoveParameter = True
        Me.ucrChkStrictThreshold.bChangeParameterValue = True
        Me.ucrChkStrictThreshold.Checked = False
        Me.ucrChkStrictThreshold.Location = New System.Drawing.Point(18, 299)
        Me.ucrChkStrictThreshold.Name = "ucrChkStrictThreshold"
        Me.ucrChkStrictThreshold.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkStrictThreshold.TabIndex = 30
        '
        'ucrChkCountLabel
        '
        Me.ucrChkCountLabel.bAddRemoveParameter = True
        Me.ucrChkCountLabel.bChangeParameterValue = True
        Me.ucrChkCountLabel.Checked = False
        Me.ucrChkCountLabel.Location = New System.Drawing.Point(103, 16)
        Me.ucrChkCountLabel.Name = "ucrChkCountLabel"
        Me.ucrChkCountLabel.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCountLabel.TabIndex = 31
        '
        'ucrChkSumLabel
        '
        Me.ucrChkSumLabel.bAddRemoveParameter = True
        Me.ucrChkSumLabel.bChangeParameterValue = True
        Me.ucrChkSumLabel.Checked = False
        Me.ucrChkSumLabel.Location = New System.Drawing.Point(6, 16)
        Me.ucrChkSumLabel.Name = "ucrChkSumLabel"
        Me.ucrChkSumLabel.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSumLabel.TabIndex = 32
        '
        'ucrChkReplace
        '
        Me.ucrChkReplace.bAddRemoveParameter = True
        Me.ucrChkReplace.bChangeParameterValue = True
        Me.ucrChkReplace.Checked = False
        Me.ucrChkReplace.Location = New System.Drawing.Point(499, 299)
        Me.ucrChkReplace.Name = "ucrChkReplace"
        Me.ucrChkReplace.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkReplace.TabIndex = 33
        '
        'ucrChkLongestDrySpellName
        '
        Me.ucrChkLongestDrySpellName.bAddRemoveParameter = True
        Me.ucrChkLongestDrySpellName.bChangeParameterValue = True
        Me.ucrChkLongestDrySpellName.Checked = False
        Me.ucrChkLongestDrySpellName.Location = New System.Drawing.Point(162, 299)
        Me.ucrChkLongestDrySpellName.Name = "ucrChkLongestDrySpellName"
        Me.ucrChkLongestDrySpellName.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLongestDrySpellName.TabIndex = 34
        '
        'ucrChkMean
        '
        Me.ucrChkMean.bAddRemoveParameter = True
        Me.ucrChkMean.bChangeParameterValue = True
        Me.ucrChkMean.Checked = False
        Me.ucrChkMean.Location = New System.Drawing.Point(6, 42)
        Me.ucrChkMean.Name = "ucrChkMean"
        Me.ucrChkMean.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMean.TabIndex = 35
        '
        'ucrChkRemoveNA
        '
        Me.ucrChkRemoveNA.bAddRemoveParameter = True
        Me.ucrChkRemoveNA.bChangeParameterValue = True
        Me.ucrChkRemoveNA.Checked = False
        Me.ucrChkRemoveNA.Location = New System.Drawing.Point(338, 299)
        Me.ucrChkRemoveNA.Name = "ucrChkRemoveNA"
        Me.ucrChkRemoveNA.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRemoveNA.TabIndex = 36
        '
        'dlgSeasonalSummaryRain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 380)
        Me.Controls.Add(Me.ucrChkReplace)
        Me.Controls.Add(Me.ucrChkLongestDrySpellName)
        Me.Controls.Add(Me.ucrChkStrictThreshold)
        Me.Controls.Add(Me.ucrChkRemoveNA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblLongDrySpellLabel)
        Me.Controls.Add(Me.lblSpelllengthName)
        Me.Controls.Add(Me.txtSpellLengthName)
        Me.Controls.Add(Me.txtLongDrySpellName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSeasonalSummaryRain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Seasonal_Summary_Rain"
        Me.Text = "dlgSeasonalSummaryRain"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents lblMeanLabel As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents lblTotals As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtMean As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblNumberofMonths As Label
    Friend WithEvents lblStartMonth As Label
    Friend WithEvents txtSpellLengthName As TextBox
    Friend WithEvents txtLongDrySpellName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLongDrySpellLabel As Label
    Friend WithEvents lblSpelllengthName As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents ucrChkMean As ucrCheck
    Friend WithEvents ucrNudNosOfMonths As ucrNud
    Friend WithEvents ucrNudStartMonth As ucrNud
    Friend WithEvents ucrChkCountLabel As ucrCheck
    Friend WithEvents ucrChkSumLabel As ucrCheck
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents UcrCheck2 As ucrCheck
    Friend WithEvents UcrCheck3 As ucrCheck
    Friend WithEvents ucrChkStrictThreshold As ucrCheck
    Friend WithEvents ucrChkReplace As ucrCheck
    Friend WithEvents ucrChkLongestDrySpellName As ucrCheck
    Friend WithEvents ucrChkRemoveNA As ucrCheck
End Class
