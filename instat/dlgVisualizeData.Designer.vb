<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgVisualizeData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rdoVisDat = New System.Windows.Forms.RadioButton()
        Me.rdoVisMiss = New System.Windows.Forms.RadioButton()
        Me.rdoVisGuess = New System.Windows.Forms.RadioButton()
        Me.rdoWholeDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedColumn = New System.Windows.Forms.RadioButton()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.lblMillionDataPoints = New System.Windows.Forms.Label()
        Me.lblPaltte = New System.Windows.Forms.Label()
        Me.lblSampling = New System.Windows.Forms.Label()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblpalettecolor = New System.Windows.Forms.Label()
        Me.ucrInputColourPalette = New instat.ucrInputComboBox()
        Me.ucrInputColour = New instat.ucrInputComboBox()
        Me.ucrNudAdjustSize = New instat.ucrNud()
        Me.ucrChkAdjustSize = New instat.ucrCheck()
        Me.ucrNudSamplingFunction = New instat.ucrNud()
        Me.ucrNudMaximumSize = New instat.ucrNud()
        Me.ucrChkSortVariables = New instat.ucrCheck()
        Me.ucrInputComboboxPalette = New instat.ucrInputComboBox()
        Me.ucrReceiverVisualizeData = New instat.ucrReceiverMultiple()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.ucrPnlVisualizeData = New instat.UcrPanel()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrSelectorVisualizeData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrByFactorsReceiver = New instat.ucrReceiverSingle()
        Me.ucrChkFacet = New instat.ucrCheck()
        Me.grpDataFrame = New System.Windows.Forms.GroupBox()
        Me.grpNames = New System.Windows.Forms.GroupBox()
        Me.ucrChkLimitLength = New instat.ucrCheck()
        Me.grpDataFrame.SuspendLayout()
        Me.grpNames.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoVisDat
        '
        Me.rdoVisDat.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisDat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisDat.FlatAppearance.BorderSize = 2
        Me.rdoVisDat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisDat.Location = New System.Drawing.Point(42, 16)
        Me.rdoVisDat.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVisDat.Name = "rdoVisDat"
        Me.rdoVisDat.Size = New System.Drawing.Size(150, 42)
        Me.rdoVisDat.TabIndex = 1
        Me.rdoVisDat.TabStop = True
        Me.rdoVisDat.Text = "Column Type "
        Me.rdoVisDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisDat.UseVisualStyleBackColor = True
        '
        'rdoVisMiss
        '
        Me.rdoVisMiss.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisMiss.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisMiss.FlatAppearance.BorderSize = 2
        Me.rdoVisMiss.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisMiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisMiss.Location = New System.Drawing.Point(189, 16)
        Me.rdoVisMiss.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVisMiss.Name = "rdoVisMiss"
        Me.rdoVisMiss.Size = New System.Drawing.Size(116, 42)
        Me.rdoVisMiss.TabIndex = 2
        Me.rdoVisMiss.TabStop = True
        Me.rdoVisMiss.Text = "Missing"
        Me.rdoVisMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisMiss.UseVisualStyleBackColor = True
        '
        'rdoVisGuess
        '
        Me.rdoVisGuess.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisGuess.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisGuess.FlatAppearance.BorderSize = 2
        Me.rdoVisGuess.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisGuess.Location = New System.Drawing.Point(302, 16)
        Me.rdoVisGuess.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVisGuess.Name = "rdoVisGuess"
        Me.rdoVisGuess.Size = New System.Drawing.Size(150, 42)
        Me.rdoVisGuess.TabIndex = 3
        Me.rdoVisGuess.TabStop = True
        Me.rdoVisGuess.Text = "Row Type"
        Me.rdoVisGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisGuess.UseVisualStyleBackColor = True
        '
        'rdoWholeDataFrame
        '
        Me.rdoWholeDataFrame.AutoSize = True
        Me.rdoWholeDataFrame.Location = New System.Drawing.Point(390, 78)
        Me.rdoWholeDataFrame.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoWholeDataFrame.Name = "rdoWholeDataFrame"
        Me.rdoWholeDataFrame.Size = New System.Drawing.Size(119, 24)
        Me.rdoWholeDataFrame.TabIndex = 6
        Me.rdoWholeDataFrame.TabStop = True
        Me.rdoWholeDataFrame.Text = "Data Frame"
        Me.rdoWholeDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSelectedColumn
        '
        Me.rdoSelectedColumn.Location = New System.Drawing.Point(390, 112)
        Me.rdoSelectedColumn.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSelectedColumn.Name = "rdoSelectedColumn"
        Me.rdoSelectedColumn.Size = New System.Drawing.Size(261, 36)
        Me.rdoSelectedColumn.TabIndex = 7
        Me.rdoSelectedColumn.TabStop = True
        Me.rdoSelectedColumn.Text = "Selected Variables"
        Me.rdoSelectedColumn.UseVisualStyleBackColor = True
        '
        'lblMaximumSize
        '
        Me.lblMaximumSize.AutoSize = True
        Me.lblMaximumSize.Location = New System.Drawing.Point(7, 70)
        Me.lblMaximumSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Size = New System.Drawing.Size(115, 20)
        Me.lblMaximumSize.TabIndex = 14
        Me.lblMaximumSize.Text = "Maximum Size:"
        '
        'lblMillionDataPoints
        '
        Me.lblMillionDataPoints.AutoSize = True
        Me.lblMillionDataPoints.Location = New System.Drawing.Point(205, 73)
        Me.lblMillionDataPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMillionDataPoints.Name = "lblMillionDataPoints"
        Me.lblMillionDataPoints.Size = New System.Drawing.Size(139, 20)
        Me.lblMillionDataPoints.TabIndex = 16
        Me.lblMillionDataPoints.Text = "Million Data Points"
        '
        'lblPaltte
        '
        Me.lblPaltte.AutoSize = True
        Me.lblPaltte.Location = New System.Drawing.Point(15, 539)
        Me.lblPaltte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaltte.Name = "lblPaltte"
        Me.lblPaltte.Size = New System.Drawing.Size(63, 20)
        Me.lblPaltte.TabIndex = 12
        Me.lblPaltte.Text = "Palette:"
        '
        'lblSampling
        '
        Me.lblSampling.AutoSize = True
        Me.lblSampling.Location = New System.Drawing.Point(8, 31)
        Me.lblSampling.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSampling.Name = "lblSampling"
        Me.lblSampling.Size = New System.Drawing.Size(141, 20)
        Me.lblSampling.TabIndex = 9
        Me.lblSampling.Text = "Sampling Fraction:"
        '
        'rdoNumeric
        '
        Me.rdoNumeric.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoNumeric.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNumeric.FlatAppearance.BorderSize = 2
        Me.rdoNumeric.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNumeric.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoNumeric.Location = New System.Drawing.Point(432, 16)
        Me.rdoNumeric.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(141, 42)
        Me.rdoNumeric.TabIndex = 21
        Me.rdoNumeric.TabStop = True
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(15, 544)
        Me.lblColour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(59, 20)
        Me.lblColour.TabIndex = 23
        Me.lblColour.Text = "Colour:"
        '
        'lblpalettecolor
        '
        Me.lblpalettecolor.AutoSize = True
        Me.lblpalettecolor.Location = New System.Drawing.Point(15, 499)
        Me.lblpalettecolor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpalettecolor.Name = "lblpalettecolor"
        Me.lblpalettecolor.Size = New System.Drawing.Size(63, 20)
        Me.lblpalettecolor.TabIndex = 24
        Me.lblpalettecolor.Text = "Palette:"
        '
        'ucrInputColourPalette
        '
        Me.ucrInputColourPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputColourPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColourPalette.GetSetSelectedIndex = -1
        Me.ucrInputColourPalette.IsReadOnly = False
        Me.ucrInputColourPalette.Location = New System.Drawing.Point(88, 498)
        Me.ucrInputColourPalette.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputColourPalette.Name = "ucrInputColourPalette"
        Me.ucrInputColourPalette.Size = New System.Drawing.Size(128, 32)
        Me.ucrInputColourPalette.TabIndex = 25
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColour.GetSetSelectedIndex = -1
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(88, 540)
        Me.ucrInputColour.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(128, 32)
        Me.ucrInputColour.TabIndex = 22
        '
        'ucrNudAdjustSize
        '
        Me.ucrNudAdjustSize.AutoSize = True
        Me.ucrNudAdjustSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAdjustSize.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAdjustSize.Location = New System.Drawing.Point(531, 411)
        Me.ucrNudAdjustSize.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudAdjustSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAdjustSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAdjustSize.Name = "ucrNudAdjustSize"
        Me.ucrNudAdjustSize.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudAdjustSize.TabIndex = 20
        Me.ucrNudAdjustSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrChkAdjustSize
        '
        Me.ucrChkAdjustSize.AutoSize = True
        Me.ucrChkAdjustSize.Checked = False
        Me.ucrChkAdjustSize.Location = New System.Drawing.Point(391, 409)
        Me.ucrChkAdjustSize.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAdjustSize.Name = "ucrChkAdjustSize"
        Me.ucrChkAdjustSize.Size = New System.Drawing.Size(134, 34)
        Me.ucrChkAdjustSize.TabIndex = 19
        '
        'ucrNudSamplingFunction
        '
        Me.ucrNudSamplingFunction.AutoSize = True
        Me.ucrNudSamplingFunction.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSamplingFunction.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSamplingFunction.Location = New System.Drawing.Point(201, 28)
        Me.ucrNudSamplingFunction.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudSamplingFunction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSamplingFunction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSamplingFunction.Name = "ucrNudSamplingFunction"
        Me.ucrNudSamplingFunction.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudSamplingFunction.TabIndex = 10
        Me.ucrNudSamplingFunction.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrNudMaximumSize
        '
        Me.ucrNudMaximumSize.AutoSize = True
        Me.ucrNudMaximumSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximumSize.Location = New System.Drawing.Point(124, 69)
        Me.ucrNudMaximumSize.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudMaximumSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximumSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Name = "ucrNudMaximumSize"
        Me.ucrNudMaximumSize.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudMaximumSize.TabIndex = 15
        Me.ucrNudMaximumSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSortVariables
        '
        Me.ucrChkSortVariables.AutoSize = True
        Me.ucrChkSortVariables.Checked = False
        Me.ucrChkSortVariables.Location = New System.Drawing.Point(19, 496)
        Me.ucrChkSortVariables.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSortVariables.Name = "ucrChkSortVariables"
        Me.ucrChkSortVariables.Size = New System.Drawing.Size(218, 34)
        Me.ucrChkSortVariables.TabIndex = 11
        '
        'ucrInputComboboxPalette
        '
        Me.ucrInputComboboxPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputComboboxPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboboxPalette.GetSetSelectedIndex = -1
        Me.ucrInputComboboxPalette.IsReadOnly = False
        Me.ucrInputComboboxPalette.Location = New System.Drawing.Point(88, 530)
        Me.ucrInputComboboxPalette.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputComboboxPalette.Name = "ucrInputComboboxPalette"
        Me.ucrInputComboboxPalette.Size = New System.Drawing.Size(128, 32)
        Me.ucrInputComboboxPalette.TabIndex = 13
        '
        'ucrReceiverVisualizeData
        '
        Me.ucrReceiverVisualizeData.AutoSize = True
        Me.ucrReceiverVisualizeData.frmParent = Me
        Me.ucrReceiverVisualizeData.Location = New System.Drawing.Point(390, 152)
        Me.ucrReceiverVisualizeData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVisualizeData.Name = "ucrReceiverVisualizeData"
        Me.ucrReceiverVisualizeData.Selector = Nothing
        Me.ucrReceiverVisualizeData.Size = New System.Drawing.Size(180, 150)
        Me.ucrReceiverVisualizeData.strNcFilePath = ""
        Me.ucrReceiverVisualizeData.TabIndex = 8
        Me.ucrReceiverVisualizeData.ucrSelector = Nothing
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(387, 71)
        Me.ucrPnlSelectData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(213, 74)
        Me.ucrPnlSelectData.TabIndex = 5
        '
        'ucrPnlVisualizeData
        '
        Me.ucrPnlVisualizeData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlVisualizeData.Location = New System.Drawing.Point(18, 3)
        Me.ucrPnlVisualizeData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlVisualizeData.Name = "ucrPnlVisualizeData"
        Me.ucrPnlVisualizeData.Size = New System.Drawing.Size(582, 64)
        Me.ucrPnlVisualizeData.TabIndex = 0
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(15, 579)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(520, 36)
        Me.ucrSaveGraph.TabIndex = 17
        '
        'ucrSelectorVisualizeData
        '
        Me.ucrSelectorVisualizeData.AutoSize = True
        Me.ucrSelectorVisualizeData.bDropUnusedFilterLevels = False
        Me.ucrSelectorVisualizeData.bShowHiddenColumns = False
        Me.ucrSelectorVisualizeData.bUseCurrentFilter = True
        Me.ucrSelectorVisualizeData.Location = New System.Drawing.Point(15, 69)
        Me.ucrSelectorVisualizeData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVisualizeData.Name = "ucrSelectorVisualizeData"
        Me.ucrSelectorVisualizeData.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorVisualizeData.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 623)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 18
        '
        'ucrByFactorsReceiver
        '
        Me.ucrByFactorsReceiver.AutoSize = True
        Me.ucrByFactorsReceiver.frmParent = Me
        Me.ucrByFactorsReceiver.Location = New System.Drawing.Point(393, 347)
        Me.ucrByFactorsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrByFactorsReceiver.Name = "ucrByFactorsReceiver"
        Me.ucrByFactorsReceiver.Selector = Nothing
        Me.ucrByFactorsReceiver.Size = New System.Drawing.Size(180, 30)
        Me.ucrByFactorsReceiver.strNcFilePath = ""
        Me.ucrByFactorsReceiver.TabIndex = 26
        Me.ucrByFactorsReceiver.ucrSelector = Nothing
        '
        'ucrChkFacet
        '
        Me.ucrChkFacet.AutoSize = True
        Me.ucrChkFacet.Checked = False
        Me.ucrChkFacet.Location = New System.Drawing.Point(387, 308)
        Me.ucrChkFacet.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFacet.Name = "ucrChkFacet"
        Me.ucrChkFacet.Size = New System.Drawing.Size(186, 34)
        Me.ucrChkFacet.TabIndex = 27
        '
        'grpDataFrame
        '
        Me.grpDataFrame.Controls.Add(Me.lblMaximumSize)
        Me.grpDataFrame.Controls.Add(Me.ucrNudMaximumSize)
        Me.grpDataFrame.Controls.Add(Me.lblMillionDataPoints)
        Me.grpDataFrame.Controls.Add(Me.ucrNudSamplingFunction)
        Me.grpDataFrame.Controls.Add(Me.lblSampling)
        Me.grpDataFrame.Location = New System.Drawing.Point(15, 372)
        Me.grpDataFrame.Name = "grpDataFrame"
        Me.grpDataFrame.Size = New System.Drawing.Size(363, 115)
        Me.grpDataFrame.TabIndex = 28
        Me.grpDataFrame.TabStop = False
        Me.grpDataFrame.Text = "Data Frame"
        '
        'grpNames
        '
        Me.grpNames.Controls.Add(Me.ucrChkLimitLength)
        Me.grpNames.Location = New System.Drawing.Point(387, 382)
        Me.grpNames.Name = "grpNames"
        Me.grpNames.Size = New System.Drawing.Size(228, 105)
        Me.grpNames.TabIndex = 29
        Me.grpNames.TabStop = False
        Me.grpNames.Text = "Variable Names"
        '
        'ucrChkLimitLength
        '
        Me.ucrChkLimitLength.AutoSize = True
        Me.ucrChkLimitLength.Checked = False
        Me.ucrChkLimitLength.Location = New System.Drawing.Point(3, 66)
        Me.ucrChkLimitLength.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLimitLength.Name = "ucrChkLimitLength"
        Me.ucrChkLimitLength.Size = New System.Drawing.Size(135, 34)
        Me.ucrChkLimitLength.TabIndex = 30
        '
        'dlgVisualizeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(619, 718)
        Me.Controls.Add(Me.ucrChkAdjustSize)
        Me.Controls.Add(Me.ucrNudAdjustSize)
        Me.Controls.Add(Me.grpNames)
        Me.Controls.Add(Me.grpDataFrame)
        Me.Controls.Add(Me.ucrChkFacet)
        Me.Controls.Add(Me.ucrByFactorsReceiver)
        Me.Controls.Add(Me.ucrInputColourPalette)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.rdoNumeric)
        Me.Controls.Add(Me.lblPaltte)
        Me.Controls.Add(Me.ucrInputComboboxPalette)
        Me.Controls.Add(Me.ucrReceiverVisualizeData)
        Me.Controls.Add(Me.rdoSelectedColumn)
        Me.Controls.Add(Me.rdoWholeDataFrame)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.rdoVisGuess)
        Me.Controls.Add(Me.rdoVisMiss)
        Me.Controls.Add(Me.rdoVisDat)
        Me.Controls.Add(Me.ucrPnlVisualizeData)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrSelectorVisualizeData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblpalettecolor)
        Me.Controls.Add(Me.ucrChkSortVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgVisualizeData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualise Data"
        Me.grpDataFrame.ResumeLayout(False)
        Me.grpDataFrame.PerformLayout()
        Me.grpNames.ResumeLayout(False)
        Me.grpNames.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorVisualizeData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrPnlVisualizeData As UcrPanel
    Friend WithEvents rdoVisDat As RadioButton
    Friend WithEvents rdoVisMiss As RadioButton
    Friend WithEvents rdoVisGuess As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents rdoWholeDataFrame As RadioButton
    Friend WithEvents rdoSelectedColumn As RadioButton
    Friend WithEvents ucrReceiverVisualizeData As ucrReceiverMultiple
    Friend WithEvents ucrInputComboboxPalette As ucrInputComboBox
    Friend WithEvents lblMillionDataPoints As Label
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents ucrChkSortVariables As ucrCheck
    Friend WithEvents lblPaltte As Label
    Friend WithEvents ucrNudMaximumSize As ucrNud
    Friend WithEvents lblSampling As Label
    Friend WithEvents ucrNudSamplingFunction As ucrNud
    Friend WithEvents ucrNudAdjustSize As ucrNud
    Friend WithEvents ucrChkAdjustSize As ucrCheck
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents ucrInputColour As ucrInputComboBox
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrInputColourPalette As ucrInputComboBox
    Friend WithEvents lblpalettecolor As Label
    Friend WithEvents ucrChkFacet As ucrCheck
    Friend WithEvents ucrByFactorsReceiver As ucrReceiverSingle
    Friend WithEvents grpDataFrame As GroupBox
    Friend WithEvents grpNames As GroupBox
    Friend WithEvents ucrChkLimitLength As ucrCheck
End Class