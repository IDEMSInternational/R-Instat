<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescribeTwoVariableMoreLikertGraphs
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblLevelsWarning = New System.Windows.Forms.Label()
        Me.ucrSelectorGGLikert = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleGGLikert = New instat.ucrReceiverMultiple()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.cmdLikertOptions = New System.Windows.Forms.Button()
        Me.ucrChkSort = New instat.ucrCheck()
        Me.ucrChkDescending = New instat.ucrCheck()
        Me.ucrChkReverse = New instat.ucrCheck()
        Me.ucrChkSymmetric = New instat.ucrCheck()
        Me.ucrChkCutoff = New instat.ucrCheck()
        Me.ucrNudCutoff = New instat.ucrNud()
        Me.grpLabels = New System.Windows.Forms.GroupBox()
        Me.ucrChkWrap = New instat.ucrCheck()
        Me.ucrNudWrap = New instat.ucrNud()
        Me.ucrChkValues = New instat.ucrCheck()
        Me.ucrChkTotals = New instat.ucrCheck()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.rdoLikert = New System.Windows.Forms.RadioButton()
        Me.rdoStacked = New System.Windows.Forms.RadioButton()
        Me.rdoSide = New System.Windows.Forms.RadioButton()
        Me.lblCutoffLevel = New System.Windows.Forms.Label()
        Me.ucrNudCutoffLevel = New instat.ucrNud()
        Me.lblExclude = New System.Windows.Forms.Label()
        Me.ucrNudExclude = New instat.ucrNud()
        Me.ucrSaveGGLikert = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.grpLabels.SuspendLayout()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLevelsWarning
        '
        Me.lblLevelsWarning.ForeColor = System.Drawing.Color.Red
        Me.lblLevelsWarning.Location = New System.Drawing.Point(232, 190)
        Me.lblLevelsWarning.Name = "lblLevelsWarning"
        Me.lblLevelsWarning.Size = New System.Drawing.Size(203, 32)
        Me.lblLevelsWarning.TabIndex = 7
        Me.lblLevelsWarning.Text = "All factors must have the same number of levels."
        Me.lblLevelsWarning.Visible = False
        '
        'ucrSelectorGGLikert
        '
        Me.ucrSelectorGGLikert.AutoSize = True
        Me.ucrSelectorGGLikert.bDropUnusedFilterLevels = False
        Me.ucrSelectorGGLikert.bShowHiddenColumns = False
        Me.ucrSelectorGGLikert.bUseCurrentFilter = True
        Me.ucrSelectorGGLikert.Location = New System.Drawing.Point(9, 10)
        Me.ucrSelectorGGLikert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGGLikert.Name = "ucrSelectorGGLikert"
        Me.ucrSelectorGGLikert.Size = New System.Drawing.Size(213, 220)
        Me.ucrSelectorGGLikert.TabIndex = 0
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactors.Location = New System.Drawing.Point(232, 42)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Text = "Factors:"
        '
        'ucrReceiverMultipleGGLikert
        '
        Me.ucrReceiverMultipleGGLikert.AutoSize = True
        Me.ucrReceiverMultipleGGLikert.frmParent = Me
        Me.ucrReceiverMultipleGGLikert.Location = New System.Drawing.Point(232, 60)
        Me.ucrReceiverMultipleGGLikert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleGGLikert.Name = "ucrReceiverMultipleGGLikert"
        Me.ucrReceiverMultipleGGLikert.Selector = Nothing
        Me.ucrReceiverMultipleGGLikert.Size = New System.Drawing.Size(167, 130)
        Me.ucrReceiverMultipleGGLikert.strNcFilePath = ""
        Me.ucrReceiverMultipleGGLikert.TabIndex = 2
        Me.ucrReceiverMultipleGGLikert.ucrSelector = Nothing
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(9, 234)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(148, 23)
        Me.cmdPlotOptions.TabIndex = 4
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdLikertOptions
        '
        Me.cmdLikertOptions.Enabled = False
        Me.cmdLikertOptions.Location = New System.Drawing.Point(9, 263)
        Me.cmdLikertOptions.Name = "cmdLikertOptions"
        Me.cmdLikertOptions.Size = New System.Drawing.Size(148, 23)
        Me.cmdLikertOptions.TabIndex = 5
        Me.cmdLikertOptions.Text = "Likert Options"
        Me.cmdLikertOptions.UseVisualStyleBackColor = True
        '
        'ucrChkSort
        '
        Me.ucrChkSort.AutoSize = True
        Me.ucrChkSort.Checked = False
        Me.ucrChkSort.Location = New System.Drawing.Point(9, 298)
        Me.ucrChkSort.Name = "ucrChkSort"
        Me.ucrChkSort.Size = New System.Drawing.Size(148, 23)
        Me.ucrChkSort.TabIndex = 6
        '
        'ucrChkDescending
        '
        Me.ucrChkDescending.AutoSize = True
        Me.ucrChkDescending.Checked = False
        Me.ucrChkDescending.Enabled = False
        Me.ucrChkDescending.Location = New System.Drawing.Point(25, 323)
        Me.ucrChkDescending.Name = "ucrChkDescending"
        Me.ucrChkDescending.Size = New System.Drawing.Size(148, 23)
        Me.ucrChkDescending.TabIndex = 7
        '
        'ucrChkReverse
        '
        Me.ucrChkReverse.AutoSize = True
        Me.ucrChkReverse.Checked = False
        Me.ucrChkReverse.Location = New System.Drawing.Point(9, 350)
        Me.ucrChkReverse.Name = "ucrChkReverse"
        Me.ucrChkReverse.Size = New System.Drawing.Size(148, 23)
        Me.ucrChkReverse.TabIndex = 8
        '
        'ucrChkSymmetric
        '
        Me.ucrChkSymmetric.AutoSize = True
        Me.ucrChkSymmetric.Checked = False
        Me.ucrChkSymmetric.Location = New System.Drawing.Point(9, 376)
        Me.ucrChkSymmetric.Name = "ucrChkSymmetric"
        Me.ucrChkSymmetric.Size = New System.Drawing.Size(148, 23)
        Me.ucrChkSymmetric.TabIndex = 9
        '
        'ucrChkCutoff
        '
        Me.ucrChkCutoff.AutoSize = True
        Me.ucrChkCutoff.Checked = False
        Me.ucrChkCutoff.Location = New System.Drawing.Point(9, 402)
        Me.ucrChkCutoff.Name = "ucrChkCutoff"
        Me.ucrChkCutoff.Size = New System.Drawing.Size(148, 23)
        Me.ucrChkCutoff.TabIndex = 10
        '
        'ucrNudCutoff
        '
        Me.ucrNudCutoff.AutoSize = True
        Me.ucrNudCutoff.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoff.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ucrNudCutoff.Location = New System.Drawing.Point(160, 403)
        Me.ucrNudCutoff.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.ucrNudCutoff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Name = "ucrNudCutoff"
        Me.ucrNudCutoff.Size = New System.Drawing.Size(55, 20)
        Me.ucrNudCutoff.TabIndex = 11
        Me.ucrNudCutoff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Visible = False
        '
        'grpLabels
        '
        Me.grpLabels.Controls.Add(Me.ucrChkWrap)
        Me.grpLabels.Controls.Add(Me.ucrNudWrap)
        Me.grpLabels.Controls.Add(Me.ucrChkValues)
        Me.grpLabels.Controls.Add(Me.ucrChkTotals)
        Me.grpLabels.Location = New System.Drawing.Point(232, 222)
        Me.grpLabels.Name = "grpLabels"
        Me.grpLabels.Padding = New System.Windows.Forms.Padding(4)
        Me.grpLabels.Size = New System.Drawing.Size(209, 100)
        Me.grpLabels.TabIndex = 3
        Me.grpLabels.TabStop = False
        Me.grpLabels.Text = "Labels"
        '
        'ucrChkWrap
        '
        Me.ucrChkWrap.AutoSize = True
        Me.ucrChkWrap.Checked = False
        Me.ucrChkWrap.Location = New System.Drawing.Point(6, 18)
        Me.ucrChkWrap.Name = "ucrChkWrap"
        Me.ucrChkWrap.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkWrap.TabIndex = 0
        '
        'ucrNudWrap
        '
        Me.ucrNudWrap.AutoSize = True
        Me.ucrNudWrap.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWrap.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWrap.Location = New System.Drawing.Point(148, 20)
        Me.ucrNudWrap.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ucrNudWrap.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrNudWrap.Name = "ucrNudWrap"
        Me.ucrNudWrap.Size = New System.Drawing.Size(55, 20)
        Me.ucrNudWrap.TabIndex = 1
        Me.ucrNudWrap.Value = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ucrNudWrap.Visible = False
        '
        'ucrChkValues
        '
        Me.ucrChkValues.AutoSize = True
        Me.ucrChkValues.Checked = True
        Me.ucrChkValues.Location = New System.Drawing.Point(6, 47)
        Me.ucrChkValues.Name = "ucrChkValues"
        Me.ucrChkValues.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkValues.TabIndex = 2
        '
        'ucrChkTotals
        '
        Me.ucrChkTotals.AutoSize = True
        Me.ucrChkTotals.Checked = True
        Me.ucrChkTotals.Location = New System.Drawing.Point(6, 72)
        Me.ucrChkTotals.Name = "ucrChkTotals"
        Me.ucrChkTotals.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkTotals.TabIndex = 3
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdoLikert)
        Me.grpType.Controls.Add(Me.rdoStacked)
        Me.grpType.Controls.Add(Me.rdoSide)
        Me.grpType.Controls.Add(Me.lblCutoffLevel)
        Me.grpType.Controls.Add(Me.ucrNudCutoffLevel)
        Me.grpType.Controls.Add(Me.lblExclude)
        Me.grpType.Controls.Add(Me.ucrNudExclude)
        Me.grpType.Location = New System.Drawing.Point(9, 432)
        Me.grpType.Name = "grpType"
        Me.grpType.Padding = New System.Windows.Forms.Padding(4)
        Me.grpType.Size = New System.Drawing.Size(436, 70)
        Me.grpType.TabIndex = 16
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type"
        '
        'rdoLikert
        '
        Me.rdoLikert.AutoSize = True
        Me.rdoLikert.Checked = True
        Me.rdoLikert.Location = New System.Drawing.Point(6, 22)
        Me.rdoLikert.Name = "rdoLikert"
        Me.rdoLikert.Size = New System.Drawing.Size(51, 17)
        Me.rdoLikert.TabIndex = 0
        Me.rdoLikert.TabStop = True
        Me.rdoLikert.Text = "Likert"
        Me.rdoLikert.UseVisualStyleBackColor = True
        '
        'rdoStacked
        '
        Me.rdoStacked.AutoSize = True
        Me.rdoStacked.Location = New System.Drawing.Point(80, 22)
        Me.rdoStacked.Name = "rdoStacked"
        Me.rdoStacked.Size = New System.Drawing.Size(65, 17)
        Me.rdoStacked.TabIndex = 1
        Me.rdoStacked.Text = "Stacked"
        Me.rdoStacked.UseVisualStyleBackColor = True
        '
        'rdoSide
        '
        Me.rdoSide.AutoSize = True
        Me.rdoSide.Location = New System.Drawing.Point(162, 22)
        Me.rdoSide.Name = "rdoSide"
        Me.rdoSide.Size = New System.Drawing.Size(46, 17)
        Me.rdoSide.TabIndex = 2
        Me.rdoSide.Text = "Side"
        Me.rdoSide.UseVisualStyleBackColor = True
        '
        'lblCutoffLevel
        '
        Me.lblCutoffLevel.AutoSize = True
        Me.lblCutoffLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCutoffLevel.Location = New System.Drawing.Point(218, 24)
        Me.lblCutoffLevel.Name = "lblCutoffLevel"
        Me.lblCutoffLevel.Size = New System.Drawing.Size(50, 13)
        Me.lblCutoffLevel.TabIndex = 3
        Me.lblCutoffLevel.Text = "Cutoff at:"
        '
        'ucrNudCutoffLevel
        '
        Me.ucrNudCutoffLevel.AutoSize = True
        Me.ucrNudCutoffLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoffLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoffLevel.Location = New System.Drawing.Point(278, 22)
        Me.ucrNudCutoffLevel.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ucrNudCutoffLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoffLevel.Name = "ucrNudCutoffLevel"
        Me.ucrNudCutoffLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCutoffLevel.TabIndex = 4
        Me.ucrNudCutoffLevel.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblExclude
        '
        Me.lblExclude.AutoSize = True
        Me.lblExclude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExclude.Location = New System.Drawing.Point(334, 24)
        Me.lblExclude.Name = "lblExclude"
        Me.lblExclude.Size = New System.Drawing.Size(48, 13)
        Me.lblExclude.TabIndex = 5
        Me.lblExclude.Text = "Exclude:"
        '
        'ucrNudExclude
        '
        Me.ucrNudExclude.AutoSize = True
        Me.ucrNudExclude.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudExclude.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudExclude.Location = New System.Drawing.Point(386, 22)
        Me.ucrNudExclude.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ucrNudExclude.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudExclude.Name = "ucrNudExclude"
        Me.ucrNudExclude.Size = New System.Drawing.Size(44, 20)
        Me.ucrNudExclude.TabIndex = 6
        Me.ucrNudExclude.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveGGLikert
        '
        Me.ucrSaveGGLikert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGGLikert.Location = New System.Drawing.Point(9, 512)
        Me.ucrSaveGGLikert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGGLikert.Name = "ucrSaveGGLikert"
        Me.ucrSaveGGLikert.Size = New System.Drawing.Size(361, 24)
        Me.ucrSaveGGLikert.TabIndex = 17
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 543)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 18
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(336, 356)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(98, 21)
        Me.ucrInputStation.TabIndex = 29
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(235, 357)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(98, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 28
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(235, 342)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 27
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'dlgDescribeTwoVariableMoreLikertGraphs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(453, 603)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrSelectorGGLikert)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverMultipleGGLikert)
        Me.Controls.Add(Me.lblLevelsWarning)
        Me.Controls.Add(Me.grpLabels)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdLikertOptions)
        Me.Controls.Add(Me.ucrChkSort)
        Me.Controls.Add(Me.ucrChkDescending)
        Me.Controls.Add(Me.ucrChkReverse)
        Me.Controls.Add(Me.ucrChkSymmetric)
        Me.Controls.Add(Me.ucrChkCutoff)
        Me.Controls.Add(Me.ucrNudCutoff)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.ucrSaveGGLikert)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariableMoreLikertGraphs"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "More Likert Graph (gglikert)"
        Me.grpLabels.ResumeLayout(False)
        Me.grpLabels.PerformLayout()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorGGLikert As instat.ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As System.Windows.Forms.Label
    Friend WithEvents ucrReceiverMultipleGGLikert As instat.ucrReceiverMultiple
    Friend WithEvents cmdPlotOptions As System.Windows.Forms.Button
    Friend WithEvents cmdLikertOptions As System.Windows.Forms.Button
    Friend WithEvents ucrChkSort As instat.ucrCheck
    Friend WithEvents ucrChkDescending As instat.ucrCheck
    Friend WithEvents ucrChkReverse As instat.ucrCheck
    Friend WithEvents ucrChkSymmetric As instat.ucrCheck
    Friend WithEvents ucrChkCutoff As instat.ucrCheck
    Friend WithEvents ucrNudCutoff As instat.ucrNud
    Friend WithEvents grpLabels As System.Windows.Forms.GroupBox
    Friend WithEvents ucrChkWrap As instat.ucrCheck
    Friend WithEvents ucrNudWrap As instat.ucrNud
    Friend WithEvents ucrChkValues As instat.ucrCheck
    Friend WithEvents ucrChkTotals As instat.ucrCheck
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents rdoLikert As System.Windows.Forms.RadioButton
    Friend WithEvents rdoStacked As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSide As System.Windows.Forms.RadioButton
    Friend WithEvents lblCutoffLevel As System.Windows.Forms.Label
    Friend WithEvents ucrNudCutoffLevel As instat.ucrNud
    Friend WithEvents lblExclude As System.Windows.Forms.Label
    Friend WithEvents ucrNudExclude As instat.ucrNud
    Friend WithEvents lblLevelsWarning As System.Windows.Forms.Label
    Friend WithEvents ucrSaveGGLikert As instat.ucrSave
    Friend WithEvents ucrBase As instat.ucrButtons
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
End Class