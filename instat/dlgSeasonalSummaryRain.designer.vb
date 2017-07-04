' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkSumLabel = New System.Windows.Forms.CheckBox()
        Me.chkLongestDrySpellName = New System.Windows.Forms.CheckBox()
        Me.chkReplace = New System.Windows.Forms.CheckBox()
        Me.chkCountLabel = New System.Windows.Forms.CheckBox()
        Me.chkStrictThreshold = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.lblMeanLabel = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.lblStartMonth = New System.Windows.Forms.Label()
        Me.nudNosofMonth = New System.Windows.Forms.NumericUpDown()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.lblNumberofMonths = New System.Windows.Forms.Label()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.nudStartMonth = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.txtSpellLengthName = New System.Windows.Forms.TextBox()
        Me.txtLongDrySpellName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLongDrySpellLabel = New System.Windows.Forms.Label()
        Me.lblSpelllengthName = New System.Windows.Forms.Label()
        Me.grpSummaries.SuspendLayout()
        CType(Me.nudNosofMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(98, 347)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(338, 293)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 1
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox1"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkSumLabel
        '
        Me.chkSumLabel.AutoSize = True
        Me.chkSumLabel.Location = New System.Drawing.Point(6, 16)
        Me.chkSumLabel.Name = "chkSumLabel"
        Me.chkSumLabel.Size = New System.Drawing.Size(81, 17)
        Me.chkSumLabel.TabIndex = 2
        Me.chkSumLabel.Tag = "Totals"
        Me.chkSumLabel.Text = "CheckBox2"
        Me.chkSumLabel.UseVisualStyleBackColor = True
        '
        'chkLongestDrySpellName
        '
        Me.chkLongestDrySpellName.AutoSize = True
        Me.chkLongestDrySpellName.Location = New System.Drawing.Point(162, 293)
        Me.chkLongestDrySpellName.Name = "chkLongestDrySpellName"
        Me.chkLongestDrySpellName.Size = New System.Drawing.Size(81, 17)
        Me.chkLongestDrySpellName.TabIndex = 3
        Me.chkLongestDrySpellName.Tag = "Longest_Dry_Spell_Name"
        Me.chkLongestDrySpellName.Text = "CheckBox3"
        Me.chkLongestDrySpellName.UseVisualStyleBackColor = True
        '
        'chkReplace
        '
        Me.chkReplace.AutoSize = True
        Me.chkReplace.Location = New System.Drawing.Point(499, 293)
        Me.chkReplace.Name = "chkReplace"
        Me.chkReplace.Size = New System.Drawing.Size(81, 17)
        Me.chkReplace.TabIndex = 4
        Me.chkReplace.Tag = "Replace"
        Me.chkReplace.Text = "CheckBox4"
        Me.chkReplace.UseVisualStyleBackColor = True
        '
        'chkCountLabel
        '
        Me.chkCountLabel.AutoSize = True
        Me.chkCountLabel.Location = New System.Drawing.Point(108, 16)
        Me.chkCountLabel.Name = "chkCountLabel"
        Me.chkCountLabel.Size = New System.Drawing.Size(81, 17)
        Me.chkCountLabel.TabIndex = 5
        Me.chkCountLabel.Tag = "Counts"
        Me.chkCountLabel.Text = "CheckBox5"
        Me.chkCountLabel.UseVisualStyleBackColor = True
        '
        'chkStrictThreshold
        '
        Me.chkStrictThreshold.AutoSize = True
        Me.chkStrictThreshold.Location = New System.Drawing.Point(18, 293)
        Me.chkStrictThreshold.Name = "chkStrictThreshold"
        Me.chkStrictThreshold.Size = New System.Drawing.Size(81, 17)
        Me.chkStrictThreshold.TabIndex = 6
        Me.chkStrictThreshold.Tag = "Strict_Threshold"
        Me.chkStrictThreshold.Text = "CheckBox6"
        Me.chkStrictThreshold.UseVisualStyleBackColor = True
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(6, 49)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(81, 17)
        Me.chkMean.TabIndex = 7
        Me.chkMean.Tag = "Mean"
        Me.chkMean.Text = "CheckBox7"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(17, 19)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox8.TabIndex = 8
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(178, 19)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox9.TabIndex = 9
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'chk
        '
        Me.chk.AutoSize = True
        Me.chk.Location = New System.Drawing.Point(17, 58)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(87, 17)
        Me.chk.TabIndex = 10
        Me.chk.Text = "CheckBox10"
        Me.chk.UseVisualStyleBackColor = True
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.lblMeanLabel)
        Me.grpSummaries.Controls.Add(Me.lblCount)
        Me.grpSummaries.Controls.Add(Me.lblTotals)
        Me.grpSummaries.Controls.Add(Me.lblStartMonth)
        Me.grpSummaries.Controls.Add(Me.nudNosofMonth)
        Me.grpSummaries.Controls.Add(Me.txtTotal)
        Me.grpSummaries.Controls.Add(Me.txtCount)
        Me.grpSummaries.Controls.Add(Me.lblNumberofMonths)
        Me.grpSummaries.Controls.Add(Me.txtMean)
        Me.grpSummaries.Controls.Add(Me.chkMean)
        Me.grpSummaries.Controls.Add(Me.chkCountLabel)
        Me.grpSummaries.Controls.Add(Me.nudStartMonth)
        Me.grpSummaries.Controls.Add(Me.chkSumLabel)
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
        'nudNosofMonth
        '
        Me.nudNosofMonth.Location = New System.Drawing.Point(118, 110)
        Me.nudNosofMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudNosofMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNosofMonth.Name = "nudNosofMonth"
        Me.nudNosofMonth.Size = New System.Drawing.Size(55, 20)
        Me.nudNosofMonth.TabIndex = 11
        Me.nudNosofMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        'nudStartMonth
        '
        Me.nudStartMonth.Location = New System.Drawing.Point(118, 84)
        Me.nudStartMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudStartMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStartMonth.Name = "nudStartMonth"
        Me.nudStartMonth.Size = New System.Drawing.Size(55, 20)
        Me.nudStartMonth.TabIndex = 12
        Me.nudStartMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblThreshold)
        Me.GroupBox2.Controls.Add(Me.nudThreshold)
        Me.GroupBox2.Controls.Add(Me.chk)
        Me.GroupBox2.Controls.Add(Me.CheckBox9)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
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
        'nudThreshold
        '
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudThreshold.Location = New System.Drawing.Point(205, 55)
        Me.nudThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(54, 20)
        Me.nudThreshold.TabIndex = 24
        Me.nudThreshold.Tag = ""
        Me.nudThreshold.Value = New Decimal(New Integer() {85, 0, 0, 131072})
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
        'dlgSeasonalSummaryRain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 380)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblLongDrySpellLabel)
        Me.Controls.Add(Me.lblSpelllengthName)
        Me.Controls.Add(Me.txtSpellLengthName)
        Me.Controls.Add(Me.txtLongDrySpellName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkStrictThreshold)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkReplace)
        Me.Controls.Add(Me.chkLongestDrySpellName)
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
        CType(Me.nudNosofMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkSumLabel As CheckBox
    Friend WithEvents chkLongestDrySpellName As CheckBox
    Friend WithEvents chkReplace As CheckBox
    Friend WithEvents chkCountLabel As CheckBox
    Friend WithEvents chkStrictThreshold As CheckBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents chk As CheckBox
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents lblMeanLabel As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents lblTotals As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtMean As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nudNosofMonth As NumericUpDown
    Friend WithEvents nudStartMonth As NumericUpDown
    Friend WithEvents lblNumberofMonths As Label
    Friend WithEvents lblStartMonth As Label
    Friend WithEvents txtSpellLengthName As TextBox
    Friend WithEvents txtLongDrySpellName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLongDrySpellLabel As Label
    Friend WithEvents lblSpelllengthName As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents nudThreshold As NumericUpDown
End Class
