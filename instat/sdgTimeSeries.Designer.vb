<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTimeSeries
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
        Me.grpComparisonSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrChkKge = New instat.ucrCheck()
        Me.ucrChkRmse = New instat.ucrCheck()
        Me.ucrChkMae = New instat.ucrCheck()
        Me.ucrChkMe = New instat.ucrCheck()
        Me.ucrChkRSd = New instat.ucrCheck()
        Me.ucrChkPBias = New instat.ucrCheck()
        Me.ucrChkCor = New instat.ucrCheck()
        Me.ucrChkN = New instat.ucrCheck()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblPositionReference = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.ucrInputPositionReference = New instat.ucrInputComboBox()
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.ucrInputSeparator = New instat.ucrInputTextBox()
        Me.ucrInputFontSize = New instat.ucrInputTextBox()
        Me.rdoIndividual = New System.Windows.Forms.RadioButton()
        Me.rdoComparison = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSummaries = New instat.UcrPanel()
        Me.ucrInputPositionEstimates = New instat.ucrInputComboBox()
        Me.lblPositionEstimates = New System.Windows.Forms.Label()
        Me.grpIndividualSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrChkSlopeIndividual = New instat.ucrCheck()
        Me.ucrChkSdIndividual = New instat.ucrCheck()
        Me.ucrChkMeanIndividual = New instat.ucrCheck()
        Me.ucrChkNIndividual = New instat.ucrCheck()
        Me.grpComparisonSummaries.SuspendLayout()
        Me.grpIndividualSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpComparisonSummaries
        '
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkKge)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkRmse)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkMae)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkMe)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkRSd)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkPBias)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkCor)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkN)
        Me.grpComparisonSummaries.Location = New System.Drawing.Point(14, 66)
        Me.grpComparisonSummaries.Name = "grpComparisonSummaries"
        Me.grpComparisonSummaries.Size = New System.Drawing.Size(294, 95)
        Me.grpComparisonSummaries.TabIndex = 0
        Me.grpComparisonSummaries.TabStop = False
        Me.grpComparisonSummaries.Text = "Comparison Summaries"
        '
        'ucrChkKge
        '
        Me.ucrChkKge.AutoSize = True
        Me.ucrChkKge.Checked = False
        Me.ucrChkKge.Location = New System.Drawing.Point(224, 61)
        Me.ucrChkKge.Name = "ucrChkKge"
        Me.ucrChkKge.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkKge.TabIndex = 10
        '
        'ucrChkRmse
        '
        Me.ucrChkRmse.AutoSize = True
        Me.ucrChkRmse.Checked = False
        Me.ucrChkRmse.Location = New System.Drawing.Point(153, 61)
        Me.ucrChkRmse.Name = "ucrChkRmse"
        Me.ucrChkRmse.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkRmse.TabIndex = 9
        '
        'ucrChkMae
        '
        Me.ucrChkMae.AutoSize = True
        Me.ucrChkMae.Checked = False
        Me.ucrChkMae.Location = New System.Drawing.Point(82, 61)
        Me.ucrChkMae.Name = "ucrChkMae"
        Me.ucrChkMae.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkMae.TabIndex = 8
        '
        'ucrChkMe
        '
        Me.ucrChkMe.AutoSize = True
        Me.ucrChkMe.Checked = False
        Me.ucrChkMe.Location = New System.Drawing.Point(11, 61)
        Me.ucrChkMe.Name = "ucrChkMe"
        Me.ucrChkMe.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkMe.TabIndex = 7
        '
        'ucrChkRSd
        '
        Me.ucrChkRSd.AutoSize = True
        Me.ucrChkRSd.Checked = False
        Me.ucrChkRSd.Location = New System.Drawing.Point(224, 29)
        Me.ucrChkRSd.Name = "ucrChkRSd"
        Me.ucrChkRSd.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkRSd.TabIndex = 6
        '
        'ucrChkPBias
        '
        Me.ucrChkPBias.AutoSize = True
        Me.ucrChkPBias.Checked = False
        Me.ucrChkPBias.Location = New System.Drawing.Point(153, 29)
        Me.ucrChkPBias.Name = "ucrChkPBias"
        Me.ucrChkPBias.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkPBias.TabIndex = 2
        '
        'ucrChkCor
        '
        Me.ucrChkCor.AutoSize = True
        Me.ucrChkCor.Checked = False
        Me.ucrChkCor.Location = New System.Drawing.Point(82, 29)
        Me.ucrChkCor.Name = "ucrChkCor"
        Me.ucrChkCor.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkCor.TabIndex = 1
        '
        'ucrChkN
        '
        Me.ucrChkN.AutoSize = True
        Me.ucrChkN.Checked = False
        Me.ucrChkN.Location = New System.Drawing.Point(11, 29)
        Me.ucrChkN.Name = "ucrChkN"
        Me.ucrChkN.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkN.TabIndex = 0
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(11, 177)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 2
        Me.lblSeparator.Text = "Separator:"
        '
        'lblPositionReference
        '
        Me.lblPositionReference.AutoSize = True
        Me.lblPositionReference.Location = New System.Drawing.Point(11, 237)
        Me.lblPositionReference.Name = "lblPositionReference"
        Me.lblPositionReference.Size = New System.Drawing.Size(47, 13)
        Me.lblPositionReference.TabIndex = 3
        Me.lblPositionReference.Text = "Position:"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(11, 207)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(54, 13)
        Me.lblFontSize.TabIndex = 4
        Me.lblFontSize.Text = "Font Size:"
        '
        'ucrInputPositionReference
        '
        Me.ucrInputPositionReference.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionReference.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionReference.GetSetSelectedIndex = -1
        Me.ucrInputPositionReference.IsReadOnly = False
        Me.ucrInputPositionReference.Location = New System.Drawing.Point(124, 233)
        Me.ucrInputPositionReference.Name = "ucrInputPositionReference"
        Me.ucrInputPositionReference.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputPositionReference.TabIndex = 5
        '
        'ucrButtonsSummaries
        '
        Me.ucrButtonsSummaries.AutoSize = True
        Me.ucrButtonsSummaries.Location = New System.Drawing.Point(87, 312)
        Me.ucrButtonsSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        Me.ucrButtonsSummaries.Size = New System.Drawing.Size(224, 31)
        Me.ucrButtonsSummaries.TabIndex = 7
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.AutoSize = True
        Me.ucrInputSeparator.IsMultiline = False
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(124, 173)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(40, 21)
        Me.ucrInputSeparator.TabIndex = 8
        '
        'ucrInputFontSize
        '
        Me.ucrInputFontSize.AddQuotesIfUnrecognised = True
        Me.ucrInputFontSize.AutoSize = True
        Me.ucrInputFontSize.IsMultiline = False
        Me.ucrInputFontSize.IsReadOnly = False
        Me.ucrInputFontSize.Location = New System.Drawing.Point(124, 203)
        Me.ucrInputFontSize.Name = "ucrInputFontSize"
        Me.ucrInputFontSize.Size = New System.Drawing.Size(40, 21)
        Me.ucrInputFontSize.TabIndex = 9
        '
        'rdoIndividual
        '
        Me.rdoIndividual.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoIndividual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIndividual.FlatAppearance.BorderSize = 2
        Me.rdoIndividual.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoIndividual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIndividual.Location = New System.Drawing.Point(161, 14)
        Me.rdoIndividual.Name = "rdoIndividual"
        Me.rdoIndividual.Size = New System.Drawing.Size(110, 27)
        Me.rdoIndividual.TabIndex = 12
        Me.rdoIndividual.TabStop = True
        Me.rdoIndividual.Text = "Individual"
        Me.rdoIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoIndividual.UseVisualStyleBackColor = True
        '
        'rdoComparison
        '
        Me.rdoComparison.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoComparison.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoComparison.FlatAppearance.BorderSize = 2
        Me.rdoComparison.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoComparison.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoComparison.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoComparison.Location = New System.Drawing.Point(53, 14)
        Me.rdoComparison.Name = "rdoComparison"
        Me.rdoComparison.Size = New System.Drawing.Size(110, 27)
        Me.rdoComparison.TabIndex = 11
        Me.rdoComparison.TabStop = True
        Me.rdoComparison.Text = "Comparison"
        Me.rdoComparison.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoComparison.UseVisualStyleBackColor = True
        '
        'ucrPnlSummaries
        '
        Me.ucrPnlSummaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSummaries.Location = New System.Drawing.Point(40, 11)
        Me.ucrPnlSummaries.Name = "ucrPnlSummaries"
        Me.ucrPnlSummaries.Size = New System.Drawing.Size(244, 35)
        Me.ucrPnlSummaries.TabIndex = 10
        '
        'ucrInputPositionEstimates
        '
        Me.ucrInputPositionEstimates.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionEstimates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionEstimates.GetSetSelectedIndex = -1
        Me.ucrInputPositionEstimates.IsReadOnly = False
        Me.ucrInputPositionEstimates.Location = New System.Drawing.Point(124, 263)
        Me.ucrInputPositionEstimates.Name = "ucrInputPositionEstimates"
        Me.ucrInputPositionEstimates.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputPositionEstimates.TabIndex = 14
        '
        'lblPositionEstimates
        '
        Me.lblPositionEstimates.AutoSize = True
        Me.lblPositionEstimates.Location = New System.Drawing.Point(11, 267)
        Me.lblPositionEstimates.Name = "lblPositionEstimates"
        Me.lblPositionEstimates.Size = New System.Drawing.Size(101, 13)
        Me.lblPositionEstimates.TabIndex = 13
        Me.lblPositionEstimates.Text = "Position - Estimates:"
        '
        'grpIndividualSummaries
        '
        Me.grpIndividualSummaries.Controls.Add(Me.ucrChkSlopeIndividual)
        Me.grpIndividualSummaries.Controls.Add(Me.ucrChkSdIndividual)
        Me.grpIndividualSummaries.Controls.Add(Me.ucrChkMeanIndividual)
        Me.grpIndividualSummaries.Controls.Add(Me.ucrChkNIndividual)
        Me.grpIndividualSummaries.Location = New System.Drawing.Point(14, 66)
        Me.grpIndividualSummaries.Name = "grpIndividualSummaries"
        Me.grpIndividualSummaries.Size = New System.Drawing.Size(294, 61)
        Me.grpIndividualSummaries.TabIndex = 11
        Me.grpIndividualSummaries.TabStop = False
        Me.grpIndividualSummaries.Text = "Individual Summaries"
        '
        'ucrChkSlopeIndividual
        '
        Me.ucrChkSlopeIndividual.AutoSize = True
        Me.ucrChkSlopeIndividual.Checked = False
        Me.ucrChkSlopeIndividual.Location = New System.Drawing.Point(224, 29)
        Me.ucrChkSlopeIndividual.Name = "ucrChkSlopeIndividual"
        Me.ucrChkSlopeIndividual.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkSlopeIndividual.TabIndex = 6
        '
        'ucrChkSdIndividual
        '
        Me.ucrChkSdIndividual.AutoSize = True
        Me.ucrChkSdIndividual.Checked = False
        Me.ucrChkSdIndividual.Location = New System.Drawing.Point(153, 29)
        Me.ucrChkSdIndividual.Name = "ucrChkSdIndividual"
        Me.ucrChkSdIndividual.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkSdIndividual.TabIndex = 2
        '
        'ucrChkMeanIndividual
        '
        Me.ucrChkMeanIndividual.AutoSize = True
        Me.ucrChkMeanIndividual.Checked = False
        Me.ucrChkMeanIndividual.Location = New System.Drawing.Point(82, 29)
        Me.ucrChkMeanIndividual.Name = "ucrChkMeanIndividual"
        Me.ucrChkMeanIndividual.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkMeanIndividual.TabIndex = 1
        '
        'ucrChkNIndividual
        '
        Me.ucrChkNIndividual.AutoSize = True
        Me.ucrChkNIndividual.Checked = False
        Me.ucrChkNIndividual.Location = New System.Drawing.Point(11, 29)
        Me.ucrChkNIndividual.Name = "ucrChkNIndividual"
        Me.ucrChkNIndividual.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkNIndividual.TabIndex = 0
        '
        'sdgTimeSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(325, 342)
        Me.Controls.Add(Me.grpIndividualSummaries)
        Me.Controls.Add(Me.ucrInputPositionEstimates)
        Me.Controls.Add(Me.lblPositionEstimates)
        Me.Controls.Add(Me.rdoIndividual)
        Me.Controls.Add(Me.rdoComparison)
        Me.Controls.Add(Me.ucrPnlSummaries)
        Me.Controls.Add(Me.ucrInputFontSize)
        Me.Controls.Add(Me.ucrInputSeparator)
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.Controls.Add(Me.ucrInputPositionReference)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.lblPositionReference)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.grpComparisonSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTimeSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Annotations"
        Me.grpComparisonSummaries.ResumeLayout(False)
        Me.grpComparisonSummaries.PerformLayout()
        Me.grpIndividualSummaries.ResumeLayout(False)
        Me.grpIndividualSummaries.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpComparisonSummaries As GroupBox
    Friend WithEvents ucrChkPBias As ucrCheck
    Friend WithEvents ucrChkCor As ucrCheck
    Friend WithEvents ucrChkN As ucrCheck
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblPositionReference As Label
    Friend WithEvents lblFontSize As Label
    Friend WithEvents ucrInputPositionReference As ucrInputComboBox
    Friend WithEvents ucrButtonsSummaries As ucrButtonsSubdialogue
    Friend WithEvents ucrChkKge As ucrCheck
    Friend WithEvents ucrChkRmse As ucrCheck
    Friend WithEvents ucrChkMae As ucrCheck
    Friend WithEvents ucrChkMe As ucrCheck
    Friend WithEvents ucrChkRSd As ucrCheck
    Friend WithEvents ucrInputSeparator As ucrInputTextBox
    Friend WithEvents ucrInputFontSize As ucrInputTextBox
    Friend WithEvents rdoIndividual As RadioButton
    Friend WithEvents rdoComparison As RadioButton
    Friend WithEvents ucrPnlSummaries As UcrPanel
    Friend WithEvents ucrInputPositionEstimates As ucrInputComboBox
    Friend WithEvents lblPositionEstimates As Label
    Friend WithEvents grpIndividualSummaries As GroupBox
    Friend WithEvents ucrChkSlopeIndividual As ucrCheck
    Friend WithEvents ucrChkSdIndividual As ucrCheck
    Friend WithEvents ucrChkMeanIndividual As ucrCheck
    Friend WithEvents ucrChkNIndividual As ucrCheck
End Class
