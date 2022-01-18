<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCompareSummary
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
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblSatellite = New System.Windows.Forms.Label()
        Me.rdoContinuous = New System.Windows.Forms.RadioButton()
        Me.rdoCategorical = New System.Windows.Forms.RadioButton()
        Me.rdoBinary = New System.Windows.Forms.RadioButton()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrReceiverSatellite = New instat.ucrReceiverMultiple()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.ucrChkIgnoreMissing = New instat.ucrCheck()
        Me.ucrPnlObservationType = New instat.UcrPanel()
        Me.ucrReceiverMultipleFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorVerificationSummary = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(290, 70)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(56, 13)
        Me.lblStation.TabIndex = 5
        Me.lblStation.Text = "Observed:"
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(290, 237)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 9
        Me.lblFactors.Text = "Factors:"
        '
        'lblSatellite
        '
        Me.lblSatellite.AutoSize = True
        Me.lblSatellite.Location = New System.Drawing.Point(290, 115)
        Me.lblSatellite.Name = "lblSatellite"
        Me.lblSatellite.Size = New System.Drawing.Size(56, 13)
        Me.lblSatellite.TabIndex = 7
        Me.lblSatellite.Text = "Estimated:"
        '
        'rdoContinuous
        '
        Me.rdoContinuous.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoContinuous.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoContinuous.FlatAppearance.BorderSize = 2
        Me.rdoContinuous.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoContinuous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoContinuous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoContinuous.Location = New System.Drawing.Point(67, 12)
        Me.rdoContinuous.Name = "rdoContinuous"
        Me.rdoContinuous.Size = New System.Drawing.Size(98, 27)
        Me.rdoContinuous.TabIndex = 1
        Me.rdoContinuous.TabStop = True
        Me.rdoContinuous.Text = "Continuous"
        Me.rdoContinuous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoContinuous.UseVisualStyleBackColor = True
        '
        'rdoCategorical
        '
        Me.rdoCategorical.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCategorical.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCategorical.FlatAppearance.BorderSize = 2
        Me.rdoCategorical.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCategorical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCategorical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCategorical.Location = New System.Drawing.Point(259, 12)
        Me.rdoCategorical.Name = "rdoCategorical"
        Me.rdoCategorical.Size = New System.Drawing.Size(98, 27)
        Me.rdoCategorical.TabIndex = 3
        Me.rdoCategorical.TabStop = True
        Me.rdoCategorical.Text = "Categorical"
        Me.rdoCategorical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCategorical.UseVisualStyleBackColor = True
        '
        'rdoBinary
        '
        Me.rdoBinary.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBinary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBinary.FlatAppearance.BorderSize = 2
        Me.rdoBinary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBinary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBinary.Location = New System.Drawing.Point(163, 12)
        Me.rdoBinary.Name = "rdoBinary"
        Me.rdoBinary.Size = New System.Drawing.Size(98, 27)
        Me.rdoBinary.TabIndex = 2
        Me.rdoBinary.TabStop = True
        Me.rdoBinary.Text = "Binary"
        Me.rdoBinary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBinary.UseVisualStyleBackColor = True
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(290, 356)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(120, 23)
        Me.cmdSummaries.TabIndex = 14
        Me.cmdSummaries.Text = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrReceiverSatellite
        '
        Me.ucrReceiverSatellite.AutoSize = True
        Me.ucrReceiverSatellite.frmParent = Me
        Me.ucrReceiverSatellite.Location = New System.Drawing.Point(290, 132)
        Me.ucrReceiverSatellite.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSatellite.Name = "ucrReceiverSatellite"
        Me.ucrReceiverSatellite.Selector = Nothing
        Me.ucrReceiverSatellite.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSatellite.strNcFilePath = ""
        Me.ucrReceiverSatellite.TabIndex = 8
        Me.ucrReceiverSatellite.ucrSelector = Nothing
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.AutoSize = True
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(10, 255)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(273, 23)
        Me.ucrChkStoreResults.TabIndex = 11
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.AutoSize = True
        Me.ucrChkPrintOutput.Checked = False
        Me.ucrChkPrintOutput.Location = New System.Drawing.Point(10, 281)
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        Me.ucrChkPrintOutput.Size = New System.Drawing.Size(273, 23)
        Me.ucrChkPrintOutput.TabIndex = 12
        '
        'ucrChkIgnoreMissing
        '
        Me.ucrChkIgnoreMissing.AutoSize = True
        Me.ucrChkIgnoreMissing.Checked = False
        Me.ucrChkIgnoreMissing.Location = New System.Drawing.Point(10, 307)
        Me.ucrChkIgnoreMissing.Name = "ucrChkIgnoreMissing"
        Me.ucrChkIgnoreMissing.Size = New System.Drawing.Size(274, 23)
        Me.ucrChkIgnoreMissing.TabIndex = 13
        '
        'ucrPnlObservationType
        '
        Me.ucrPnlObservationType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlObservationType.Location = New System.Drawing.Point(63, 4)
        Me.ucrPnlObservationType.Name = "ucrPnlObservationType"
        Me.ucrPnlObservationType.Size = New System.Drawing.Size(300, 50)
        Me.ucrPnlObservationType.TabIndex = 0
        '
        'ucrReceiverMultipleFactors
        '
        Me.ucrReceiverMultipleFactors.AutoSize = True
        Me.ucrReceiverMultipleFactors.frmParent = Me
        Me.ucrReceiverMultipleFactors.Location = New System.Drawing.Point(290, 253)
        Me.ucrReceiverMultipleFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleFactors.Name = "ucrReceiverMultipleFactors"
        Me.ucrReceiverMultipleFactors.Selector = Nothing
        Me.ucrReceiverMultipleFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleFactors.strNcFilePath = ""
        Me.ucrReceiverMultipleFactors.TabIndex = 10
        Me.ucrReceiverMultipleFactors.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(290, 87)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorVerificationSummary
        '
        Me.ucrSelectorVerificationSummary.AutoSize = True
        Me.ucrSelectorVerificationSummary.bDropUnusedFilterLevels = False
        Me.ucrSelectorVerificationSummary.bShowHiddenColumns = False
        Me.ucrSelectorVerificationSummary.bUseCurrentFilter = True
        Me.ucrSelectorVerificationSummary.Location = New System.Drawing.Point(10, 57)
        Me.ucrSelectorVerificationSummary.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVerificationSummary.Name = "ucrSelectorVerificationSummary"
        Me.ucrSelectorVerificationSummary.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorVerificationSummary.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 385)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'dlgCompareSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 441)
        Me.Controls.Add(Me.ucrReceiverSatellite)
        Me.Controls.Add(Me.ucrChkStoreResults)
        Me.Controls.Add(Me.ucrChkPrintOutput)
        Me.Controls.Add(Me.ucrChkIgnoreMissing)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.rdoBinary)
        Me.Controls.Add(Me.rdoCategorical)
        Me.Controls.Add(Me.rdoContinuous)
        Me.Controls.Add(Me.ucrPnlObservationType)
        Me.Controls.Add(Me.lblSatellite)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverMultipleFactors)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorVerificationSummary)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCompareSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verification Summaries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorVerificationSummary As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverMultipleFactors As ucrReceiverMultiple
    Friend WithEvents lblSatellite As Label
    Friend WithEvents lblFactors As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrPnlObservationType As UcrPanel
    Friend WithEvents rdoBinary As RadioButton
    Friend WithEvents rdoCategorical As RadioButton
    Friend WithEvents rdoContinuous As RadioButton
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkIgnoreMissing As ucrCheck
    Friend WithEvents ucrChkPrintOutput As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrReceiverSatellite As ucrReceiverMultiple
End Class
