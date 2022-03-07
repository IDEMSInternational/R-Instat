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
Partial Class dlgDescribeTwoVarGraph
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
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.lblFirstVariables = New System.Windows.Forms.Label()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrInputCategoricalByCategorical = New instat.ucrInputComboBox()
        Me.ucrInputCategoricalByNumeric = New instat.ucrInputComboBox()
        Me.ucrInputNumericByCategorical = New instat.ucrInputComboBox()
        Me.ucrInputNumericByNumeric = New instat.ucrInputComboBox()
        Me.lblFirstType = New System.Windows.Forms.Label()
        Me.lblGraphName = New System.Windows.Forms.Label()
        Me.lblGraph = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblSecondType = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrNudJitter = New instat.ucrNud()
        Me.lblPointTransparency = New System.Windows.Forms.Label()
        Me.lblPointJitter = New System.Windows.Forms.Label()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrChkFreeScaleYAxis = New instat.ucrCheck()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.rdoPairs = New System.Windows.Forms.RadioButton()
        Me.rdoBy = New System.Windows.Forms.RadioButton()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.grpTypeOfDispaly = New System.Windows.Forms.GroupBox()
        Me.lblDiagonalNA = New System.Windows.Forms.Label()
        Me.ucrInputDiagonalNA = New instat.ucrInputComboBox()
        Me.lblDiagonalDiscrete = New System.Windows.Forms.Label()
        Me.ucrInputDiagonalDiscrete = New instat.ucrInputComboBox()
        Me.lblDiagonalContinuous = New System.Windows.Forms.Label()
        Me.ucrInputDiagonalContinous = New instat.ucrInputComboBox()
        Me.lblUpperNA = New System.Windows.Forms.Label()
        Me.lblUpperDiscrete = New System.Windows.Forms.Label()
        Me.lblUpperCombo = New System.Windows.Forms.Label()
        Me.lblUpperContinous = New System.Windows.Forms.Label()
        Me.ucrInputUpperNA = New instat.ucrInputComboBox()
        Me.ucrInputUpperDiscrete = New instat.ucrInputComboBox()
        Me.ucrInputUpperCombo = New instat.ucrInputComboBox()
        Me.ucrInputUpperContinous = New instat.ucrInputComboBox()
        Me.lblLowerNA = New System.Windows.Forms.Label()
        Me.lblLowerDiscrete = New System.Windows.Forms.Label()
        Me.lblLowerCombo = New System.Windows.Forms.Label()
        Me.lblLowerContinous = New System.Windows.Forms.Label()
        Me.ucrInputLowerNA = New instat.ucrInputComboBox()
        Me.ucrInputLowerDiscrete = New instat.ucrInputComboBox()
        Me.ucrInputLowerCombo = New instat.ucrInputComboBox()
        Me.ucrInputLowerContinous = New instat.ucrInputComboBox()
        Me.ucrChkDiagonal = New instat.ucrCheck()
        Me.ucrChkLower = New instat.ucrCheck()
        Me.ucrChkUpper = New instat.ucrCheck()
        Me.ucrReceiverColour = New instat.ucrReceiverSingle()
        Me.ucrPnlByPairs = New instat.UcrPanel()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverSecondVar = New instat.ucrReceiverSingle()
        Me.ucrSelectorTwoVarGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFirstVars = New instat.ucrVariablesAsFactor()
        Me.ucrInputLabelSize = New instat.ucrInputComboBox()
        Me.lblLabelColour = New System.Windows.Forms.Label()
        Me.lblLabelSize = New System.Windows.Forms.Label()
        Me.ucrInputLabelPosition = New instat.ucrInputComboBox()
        Me.ucrChkAddLabelsText = New instat.ucrCheck()
        Me.lblLabelPosition = New System.Windows.Forms.Label()
        Me.ucrInputLabelColour = New instat.ucrInputComboBox()
        Me.grpSummaries.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpTypeOfDispaly.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 227)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(119, 23)
        Me.cmdOptions.TabIndex = 5
        Me.cmdOptions.Tag = "Options..."
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSecondVariable
        '
        Me.lblSecondVariable.AutoSize = True
        Me.lblSecondVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondVariable.Location = New System.Drawing.Point(290, 201)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(88, 13)
        Me.lblSecondVariable.TabIndex = 3
        Me.lblSecondVariable.Text = "Second Variable:"
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariables.Location = New System.Drawing.Point(290, 65)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(81, 13)
        Me.lblFirstVariables.TabIndex = 2
        Me.lblFirstVariables.Tag = "First_Variable(s)"
        Me.lblFirstVariables.Text = "First Variable(s):"
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.ucrInputCategoricalByCategorical)
        Me.grpSummaries.Controls.Add(Me.ucrInputCategoricalByNumeric)
        Me.grpSummaries.Controls.Add(Me.ucrInputNumericByCategorical)
        Me.grpSummaries.Controls.Add(Me.ucrInputNumericByNumeric)
        Me.grpSummaries.Controls.Add(Me.lblFirstType)
        Me.grpSummaries.Controls.Add(Me.lblGraphName)
        Me.grpSummaries.Controls.Add(Me.lblGraph)
        Me.grpSummaries.Controls.Add(Me.lblBy)
        Me.grpSummaries.Controls.Add(Me.lblSecondType)
        Me.grpSummaries.Location = New System.Drawing.Point(10, 253)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(210, 72)
        Me.grpSummaries.TabIndex = 15
        Me.grpSummaries.TabStop = False
        '
        'ucrInputCategoricalByCategorical
        '
        Me.ucrInputCategoricalByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategoricalByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputCategoricalByCategorical.IsReadOnly = False
        Me.ucrInputCategoricalByCategorical.Location = New System.Drawing.Point(60, 40)
        Me.ucrInputCategoricalByCategorical.Name = "ucrInputCategoricalByCategorical"
        Me.ucrInputCategoricalByCategorical.Size = New System.Drawing.Size(144, 21)
        Me.ucrInputCategoricalByCategorical.TabIndex = 17
        '
        'ucrInputCategoricalByNumeric
        '
        Me.ucrInputCategoricalByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategoricalByNumeric.GetSetSelectedIndex = -1
        Me.ucrInputCategoricalByNumeric.IsReadOnly = False
        Me.ucrInputCategoricalByNumeric.Location = New System.Drawing.Point(60, 40)
        Me.ucrInputCategoricalByNumeric.Name = "ucrInputCategoricalByNumeric"
        Me.ucrInputCategoricalByNumeric.Size = New System.Drawing.Size(144, 21)
        Me.ucrInputCategoricalByNumeric.TabIndex = 16
        '
        'ucrInputNumericByCategorical
        '
        Me.ucrInputNumericByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputNumericByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNumericByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputNumericByCategorical.IsReadOnly = False
        Me.ucrInputNumericByCategorical.Location = New System.Drawing.Point(60, 40)
        Me.ucrInputNumericByCategorical.Name = "ucrInputNumericByCategorical"
        Me.ucrInputNumericByCategorical.Size = New System.Drawing.Size(144, 21)
        Me.ucrInputNumericByCategorical.TabIndex = 15
        '
        'ucrInputNumericByNumeric
        '
        Me.ucrInputNumericByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputNumericByNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNumericByNumeric.GetSetSelectedIndex = -1
        Me.ucrInputNumericByNumeric.IsReadOnly = False
        Me.ucrInputNumericByNumeric.Location = New System.Drawing.Point(60, 40)
        Me.ucrInputNumericByNumeric.Name = "ucrInputNumericByNumeric"
        Me.ucrInputNumericByNumeric.Size = New System.Drawing.Size(144, 21)
        Me.ucrInputNumericByNumeric.TabIndex = 14
        '
        'lblFirstType
        '
        Me.lblFirstType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFirstType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstType.Location = New System.Drawing.Point(6, 16)
        Me.lblFirstType.Name = "lblFirstType"
        Me.lblFirstType.Size = New System.Drawing.Size(55, 13)
        Me.lblFirstType.TabIndex = 10
        Me.lblFirstType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGraphName
        '
        Me.lblGraphName.AutoSize = True
        Me.lblGraphName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraphName.Location = New System.Drawing.Point(60, 43)
        Me.lblGraphName.Name = "lblGraphName"
        Me.lblGraphName.Size = New System.Drawing.Size(0, 13)
        Me.lblGraphName.TabIndex = 13
        '
        'lblGraph
        '
        Me.lblGraph.AutoSize = True
        Me.lblGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraph.Location = New System.Drawing.Point(6, 43)
        Me.lblGraph.Name = "lblGraph"
        Me.lblGraph.Size = New System.Drawing.Size(39, 13)
        Me.lblGraph.TabIndex = 9
        Me.lblGraph.Text = "Graph:"
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBy.Location = New System.Drawing.Point(64, 16)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(18, 13)
        Me.lblBy.TabIndex = 11
        Me.lblBy.Text = "by"
        '
        'lblSecondType
        '
        Me.lblSecondType.AutoSize = True
        Me.lblSecondType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondType.Location = New System.Drawing.Point(82, 16)
        Me.lblSecondType.Name = "lblSecondType"
        Me.lblSecondType.Size = New System.Drawing.Size(0, 13)
        Me.lblSecondType.TabIndex = 12
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.lblPosition)
        Me.grpOptions.Controls.Add(Me.ucrNudTransparency)
        Me.grpOptions.Controls.Add(Me.ucrNudJitter)
        Me.grpOptions.Controls.Add(Me.lblPointTransparency)
        Me.grpOptions.Controls.Add(Me.lblPointJitter)
        Me.grpOptions.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.grpOptions.Controls.Add(Me.ucrChkFreeScaleYAxis)
        Me.grpOptions.Controls.Add(Me.ucrInputPosition)
        Me.grpOptions.Location = New System.Drawing.Point(226, 252)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(171, 111)
        Me.grpOptions.TabIndex = 16
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPosition.Location = New System.Drawing.Point(4, 65)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 12
        Me.lblPosition.Text = "Position:"
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.AutoSize = True
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTransparency.Location = New System.Drawing.Point(112, 87)
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTransparency.TabIndex = 11
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJitter
        '
        Me.ucrNudJitter.AutoSize = True
        Me.ucrNudJitter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJitter.Location = New System.Drawing.Point(112, 62)
        Me.ucrNudJitter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJitter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Name = "ucrNudJitter"
        Me.ucrNudJitter.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudJitter.TabIndex = 10
        Me.ucrNudJitter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPointTransparency
        '
        Me.lblPointTransparency.AutoSize = True
        Me.lblPointTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPointTransparency.Location = New System.Drawing.Point(4, 90)
        Me.lblPointTransparency.Name = "lblPointTransparency"
        Me.lblPointTransparency.Size = New System.Drawing.Size(102, 13)
        Me.lblPointTransparency.TabIndex = 9
        Me.lblPointTransparency.Text = "Point Transparency:"
        '
        'lblPointJitter
        '
        Me.lblPointJitter.AutoSize = True
        Me.lblPointJitter.Location = New System.Drawing.Point(4, 65)
        Me.lblPointJitter.Name = "lblPointJitter"
        Me.lblPointJitter.Size = New System.Drawing.Size(59, 13)
        Me.lblPointJitter.TabIndex = 8
        Me.lblPointJitter.Text = "Point Jitter:"
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.AutoSize = True
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkFlipCoordinates.TabIndex = 6
        '
        'ucrChkFreeScaleYAxis
        '
        Me.ucrChkFreeScaleYAxis.AutoSize = True
        Me.ucrChkFreeScaleYAxis.Checked = False
        Me.ucrChkFreeScaleYAxis.Location = New System.Drawing.Point(6, 41)
        Me.ucrChkFreeScaleYAxis.Name = "ucrChkFreeScaleYAxis"
        Me.ucrChkFreeScaleYAxis.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkFreeScaleYAxis.TabIndex = 7
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(54, 63)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(111, 21)
        Me.ucrInputPosition.TabIndex = 13
        '
        'rdoPairs
        '
        Me.rdoPairs.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPairs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPairs.FlatAppearance.BorderSize = 2
        Me.rdoPairs.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPairs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPairs.Location = New System.Drawing.Point(76, 9)
        Me.rdoPairs.Name = "rdoPairs"
        Me.rdoPairs.Size = New System.Drawing.Size(129, 27)
        Me.rdoPairs.TabIndex = 19
        Me.rdoPairs.TabStop = True
        Me.rdoPairs.Text = "Pairs"
        Me.rdoPairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPairs.UseVisualStyleBackColor = True
        '
        'rdoBy
        '
        Me.rdoBy.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBy.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBy.FlatAppearance.BorderSize = 2
        Me.rdoBy.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBy.Location = New System.Drawing.Point(203, 9)
        Me.rdoBy.Name = "rdoBy"
        Me.rdoBy.Size = New System.Drawing.Size(129, 27)
        Me.rdoBy.TabIndex = 18
        Me.rdoBy.TabStop = True
        Me.rdoBy.Text = "By"
        Me.rdoBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBy.UseVisualStyleBackColor = True
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColour.Location = New System.Drawing.Point(290, 201)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(88, 13)
        Me.lblColour.TabIndex = 20
        Me.lblColour.Text = "Colour (Optional):"
        '
        'grpTypeOfDispaly
        '
        Me.grpTypeOfDispaly.Controls.Add(Me.lblDiagonalNA)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputDiagonalNA)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblDiagonalDiscrete)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputDiagonalDiscrete)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblDiagonalContinuous)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputDiagonalContinous)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblUpperNA)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblUpperDiscrete)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblUpperCombo)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblUpperContinous)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputUpperNA)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputUpperDiscrete)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputUpperCombo)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputUpperContinous)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblLowerNA)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblLowerDiscrete)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblLowerCombo)
        Me.grpTypeOfDispaly.Controls.Add(Me.lblLowerContinous)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputLowerNA)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputLowerDiscrete)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputLowerCombo)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrInputLowerContinous)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrChkDiagonal)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrChkLower)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrChkUpper)
        Me.grpTypeOfDispaly.Location = New System.Drawing.Point(11, 255)
        Me.grpTypeOfDispaly.Name = "grpTypeOfDispaly"
        Me.grpTypeOfDispaly.Size = New System.Drawing.Size(422, 151)
        Me.grpTypeOfDispaly.TabIndex = 22
        Me.grpTypeOfDispaly.TabStop = False
        Me.grpTypeOfDispaly.Text = "Type Of Dispaly"
        '
        'lblDiagonalNA
        '
        Me.lblDiagonalNA.AutoSize = True
        Me.lblDiagonalNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalNA.Location = New System.Drawing.Point(152, 105)
        Me.lblDiagonalNA.Name = "lblDiagonalNA"
        Me.lblDiagonalNA.Size = New System.Drawing.Size(25, 13)
        Me.lblDiagonalNA.TabIndex = 40
        Me.lblDiagonalNA.Text = "NA:"
        '
        'ucrInputDiagonalNA
        '
        Me.ucrInputDiagonalNA.AddQuotesIfUnrecognised = True
        Me.ucrInputDiagonalNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDiagonalNA.GetSetSelectedIndex = -1
        Me.ucrInputDiagonalNA.IsReadOnly = False
        Me.ucrInputDiagonalNA.Location = New System.Drawing.Point(216, 100)
        Me.ucrInputDiagonalNA.Name = "ucrInputDiagonalNA"
        Me.ucrInputDiagonalNA.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputDiagonalNA.TabIndex = 39
        '
        'lblDiagonalDiscrete
        '
        Me.lblDiagonalDiscrete.AutoSize = True
        Me.lblDiagonalDiscrete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalDiscrete.Location = New System.Drawing.Point(150, 77)
        Me.lblDiagonalDiscrete.Name = "lblDiagonalDiscrete"
        Me.lblDiagonalDiscrete.Size = New System.Drawing.Size(49, 13)
        Me.lblDiagonalDiscrete.TabIndex = 38
        Me.lblDiagonalDiscrete.Text = "Discrete:"
        '
        'ucrInputDiagonalDiscrete
        '
        Me.ucrInputDiagonalDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputDiagonalDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDiagonalDiscrete.GetSetSelectedIndex = -1
        Me.ucrInputDiagonalDiscrete.IsReadOnly = False
        Me.ucrInputDiagonalDiscrete.Location = New System.Drawing.Point(216, 73)
        Me.ucrInputDiagonalDiscrete.Name = "ucrInputDiagonalDiscrete"
        Me.ucrInputDiagonalDiscrete.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputDiagonalDiscrete.TabIndex = 37
        '
        'lblDiagonalContinuous
        '
        Me.lblDiagonalContinuous.AutoSize = True
        Me.lblDiagonalContinuous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalContinuous.Location = New System.Drawing.Point(149, 50)
        Me.lblDiagonalContinuous.Name = "lblDiagonalContinuous"
        Me.lblDiagonalContinuous.Size = New System.Drawing.Size(63, 13)
        Me.lblDiagonalContinuous.TabIndex = 36
        Me.lblDiagonalContinuous.Text = "Continuous:"
        '
        'ucrInputDiagonalContinous
        '
        Me.ucrInputDiagonalContinous.AddQuotesIfUnrecognised = True
        Me.ucrInputDiagonalContinous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDiagonalContinous.GetSetSelectedIndex = -1
        Me.ucrInputDiagonalContinous.IsReadOnly = False
        Me.ucrInputDiagonalContinous.Location = New System.Drawing.Point(216, 46)
        Me.ucrInputDiagonalContinous.Name = "ucrInputDiagonalContinous"
        Me.ucrInputDiagonalContinous.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputDiagonalContinous.TabIndex = 35
        '
        'lblUpperNA
        '
        Me.lblUpperNA.AutoSize = True
        Me.lblUpperNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperNA.Location = New System.Drawing.Point(292, 131)
        Me.lblUpperNA.Name = "lblUpperNA"
        Me.lblUpperNA.Size = New System.Drawing.Size(25, 13)
        Me.lblUpperNA.TabIndex = 34
        Me.lblUpperNA.Text = "NA:"
        '
        'lblUpperDiscrete
        '
        Me.lblUpperDiscrete.AutoSize = True
        Me.lblUpperDiscrete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperDiscrete.Location = New System.Drawing.Point(290, 104)
        Me.lblUpperDiscrete.Name = "lblUpperDiscrete"
        Me.lblUpperDiscrete.Size = New System.Drawing.Size(49, 13)
        Me.lblUpperDiscrete.TabIndex = 33
        Me.lblUpperDiscrete.Text = "Discrete:"
        '
        'lblUpperCombo
        '
        Me.lblUpperCombo.AutoSize = True
        Me.lblUpperCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperCombo.Location = New System.Drawing.Point(290, 77)
        Me.lblUpperCombo.Name = "lblUpperCombo"
        Me.lblUpperCombo.Size = New System.Drawing.Size(43, 13)
        Me.lblUpperCombo.TabIndex = 32
        Me.lblUpperCombo.Text = "Combo:"
        '
        'lblUpperContinous
        '
        Me.lblUpperContinous.AutoSize = True
        Me.lblUpperContinous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperContinous.Location = New System.Drawing.Point(290, 50)
        Me.lblUpperContinous.Name = "lblUpperContinous"
        Me.lblUpperContinous.Size = New System.Drawing.Size(63, 13)
        Me.lblUpperContinous.TabIndex = 31
        Me.lblUpperContinous.Text = "Continuous:"
        '
        'ucrInputUpperNA
        '
        Me.ucrInputUpperNA.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUpperNA.GetSetSelectedIndex = -1
        Me.ucrInputUpperNA.IsReadOnly = False
        Me.ucrInputUpperNA.Location = New System.Drawing.Point(357, 127)
        Me.ucrInputUpperNA.Name = "ucrInputUpperNA"
        Me.ucrInputUpperNA.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputUpperNA.TabIndex = 30
        '
        'ucrInputUpperDiscrete
        '
        Me.ucrInputUpperDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUpperDiscrete.GetSetSelectedIndex = -1
        Me.ucrInputUpperDiscrete.IsReadOnly = False
        Me.ucrInputUpperDiscrete.Location = New System.Drawing.Point(357, 100)
        Me.ucrInputUpperDiscrete.Name = "ucrInputUpperDiscrete"
        Me.ucrInputUpperDiscrete.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputUpperDiscrete.TabIndex = 29
        '
        'ucrInputUpperCombo
        '
        Me.ucrInputUpperCombo.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperCombo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUpperCombo.GetSetSelectedIndex = -1
        Me.ucrInputUpperCombo.IsReadOnly = False
        Me.ucrInputUpperCombo.Location = New System.Drawing.Point(357, 73)
        Me.ucrInputUpperCombo.Name = "ucrInputUpperCombo"
        Me.ucrInputUpperCombo.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputUpperCombo.TabIndex = 28
        '
        'ucrInputUpperContinous
        '
        Me.ucrInputUpperContinous.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperContinous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUpperContinous.GetSetSelectedIndex = -1
        Me.ucrInputUpperContinous.IsReadOnly = False
        Me.ucrInputUpperContinous.Location = New System.Drawing.Point(357, 46)
        Me.ucrInputUpperContinous.Name = "ucrInputUpperContinous"
        Me.ucrInputUpperContinous.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputUpperContinous.TabIndex = 27
        '
        'lblLowerNA
        '
        Me.lblLowerNA.AutoSize = True
        Me.lblLowerNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLowerNA.Location = New System.Drawing.Point(3, 130)
        Me.lblLowerNA.Name = "lblLowerNA"
        Me.lblLowerNA.Size = New System.Drawing.Size(25, 13)
        Me.lblLowerNA.TabIndex = 26
        Me.lblLowerNA.Text = "NA:"
        '
        'lblLowerDiscrete
        '
        Me.lblLowerDiscrete.AutoSize = True
        Me.lblLowerDiscrete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLowerDiscrete.Location = New System.Drawing.Point(1, 105)
        Me.lblLowerDiscrete.Name = "lblLowerDiscrete"
        Me.lblLowerDiscrete.Size = New System.Drawing.Size(49, 13)
        Me.lblLowerDiscrete.TabIndex = 25
        Me.lblLowerDiscrete.Text = "Discrete:"
        '
        'lblLowerCombo
        '
        Me.lblLowerCombo.AutoSize = True
        Me.lblLowerCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLowerCombo.Location = New System.Drawing.Point(1, 78)
        Me.lblLowerCombo.Name = "lblLowerCombo"
        Me.lblLowerCombo.Size = New System.Drawing.Size(43, 13)
        Me.lblLowerCombo.TabIndex = 24
        Me.lblLowerCombo.Text = "Combo:"
        '
        'lblLowerContinous
        '
        Me.lblLowerContinous.AutoSize = True
        Me.lblLowerContinous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLowerContinous.Location = New System.Drawing.Point(1, 50)
        Me.lblLowerContinous.Name = "lblLowerContinous"
        Me.lblLowerContinous.Size = New System.Drawing.Size(63, 13)
        Me.lblLowerContinous.TabIndex = 23
        Me.lblLowerContinous.Text = "Continuous:"
        '
        'ucrInputLowerNA
        '
        Me.ucrInputLowerNA.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLowerNA.GetSetSelectedIndex = -1
        Me.ucrInputLowerNA.IsReadOnly = False
        Me.ucrInputLowerNA.Location = New System.Drawing.Point(68, 127)
        Me.ucrInputLowerNA.Name = "ucrInputLowerNA"
        Me.ucrInputLowerNA.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputLowerNA.TabIndex = 22
        '
        'ucrInputLowerDiscrete
        '
        Me.ucrInputLowerDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLowerDiscrete.GetSetSelectedIndex = -1
        Me.ucrInputLowerDiscrete.IsReadOnly = False
        Me.ucrInputLowerDiscrete.Location = New System.Drawing.Point(68, 100)
        Me.ucrInputLowerDiscrete.Name = "ucrInputLowerDiscrete"
        Me.ucrInputLowerDiscrete.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputLowerDiscrete.TabIndex = 5
        '
        'ucrInputLowerCombo
        '
        Me.ucrInputLowerCombo.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerCombo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLowerCombo.GetSetSelectedIndex = -1
        Me.ucrInputLowerCombo.IsReadOnly = False
        Me.ucrInputLowerCombo.Location = New System.Drawing.Point(68, 73)
        Me.ucrInputLowerCombo.Name = "ucrInputLowerCombo"
        Me.ucrInputLowerCombo.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputLowerCombo.TabIndex = 4
        '
        'ucrInputLowerContinous
        '
        Me.ucrInputLowerContinous.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerContinous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLowerContinous.GetSetSelectedIndex = -1
        Me.ucrInputLowerContinous.IsReadOnly = False
        Me.ucrInputLowerContinous.Location = New System.Drawing.Point(68, 46)
        Me.ucrInputLowerContinous.Name = "ucrInputLowerContinous"
        Me.ucrInputLowerContinous.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputLowerContinous.TabIndex = 3
        '
        'ucrChkDiagonal
        '
        Me.ucrChkDiagonal.AutoSize = True
        Me.ucrChkDiagonal.Checked = False
        Me.ucrChkDiagonal.Location = New System.Drawing.Point(154, 17)
        Me.ucrChkDiagonal.Name = "ucrChkDiagonal"
        Me.ucrChkDiagonal.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDiagonal.TabIndex = 2
        '
        'ucrChkLower
        '
        Me.ucrChkLower.AutoSize = True
        Me.ucrChkLower.Checked = False
        Me.ucrChkLower.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkLower.Name = "ucrChkLower"
        Me.ucrChkLower.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkLower.TabIndex = 1
        '
        'ucrChkUpper
        '
        Me.ucrChkUpper.AutoSize = True
        Me.ucrChkUpper.Checked = False
        Me.ucrChkUpper.Location = New System.Drawing.Point(296, 17)
        Me.ucrChkUpper.Name = "ucrChkUpper"
        Me.ucrChkUpper.Size = New System.Drawing.Size(120, 23)
        Me.ucrChkUpper.TabIndex = 0
        '
        'ucrReceiverColour
        '
        Me.ucrReceiverColour.AutoSize = True
        Me.ucrReceiverColour.frmParent = Me
        Me.ucrReceiverColour.Location = New System.Drawing.Point(290, 216)
        Me.ucrReceiverColour.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColour.Name = "ucrReceiverColour"
        Me.ucrReceiverColour.Selector = Nothing
        Me.ucrReceiverColour.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColour.strNcFilePath = ""
        Me.ucrReceiverColour.TabIndex = 21
        Me.ucrReceiverColour.ucrSelector = Nothing
        '
        'ucrPnlByPairs
        '
        Me.ucrPnlByPairs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlByPairs.Location = New System.Drawing.Point(73, 5)
        Me.ucrPnlByPairs.Name = "ucrPnlByPairs"
        Me.ucrPnlByPairs.Size = New System.Drawing.Size(276, 31)
        Me.ucrPnlByPairs.TabIndex = 17
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 433)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(339, 24)
        Me.ucrSaveGraph.TabIndex = 7
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.AutoSize = True
        Me.ucrReceiverSecondVar.frmParent = Me
        Me.ucrReceiverSecondVar.Location = New System.Drawing.Point(290, 216)
        Me.ucrReceiverSecondVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondVar.Name = "ucrReceiverSecondVar"
        Me.ucrReceiverSecondVar.Selector = Nothing
        Me.ucrReceiverSecondVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondVar.strNcFilePath = ""
        Me.ucrReceiverSecondVar.TabIndex = 4
        Me.ucrReceiverSecondVar.ucrSelector = Nothing
        '
        'ucrSelectorTwoVarGraph
        '
        Me.ucrSelectorTwoVarGraph.AutoSize = True
        Me.ucrSelectorTwoVarGraph.bDropUnusedFilterLevels = False
        Me.ucrSelectorTwoVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorTwoVarGraph.bUseCurrentFilter = True
        Me.ucrSelectorTwoVarGraph.Location = New System.Drawing.Point(10, 41)
        Me.ucrSelectorTwoVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoVarGraph.Name = "ucrSelectorTwoVarGraph"
        Me.ucrSelectorTwoVarGraph.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTwoVarGraph.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 460)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.AutoSize = True
        Me.ucrReceiverFirstVars.frmParent = Me
        Me.ucrReceiverFirstVars.Location = New System.Drawing.Point(290, 50)
        Me.ucrReceiverFirstVars.Name = "ucrReceiverFirstVars"
        Me.ucrReceiverFirstVars.Selector = Nothing
        Me.ucrReceiverFirstVars.Size = New System.Drawing.Size(120, 138)
        Me.ucrReceiverFirstVars.strNcFilePath = ""
        Me.ucrReceiverFirstVars.TabIndex = 1
        Me.ucrReceiverFirstVars.ucrSelector = Nothing
        Me.ucrReceiverFirstVars.ucrVariableSelector = Nothing
        '
        'ucrInputLabelSize
        '
        Me.ucrInputLabelSize.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabelSize.GetSetSelectedIndex = -1
        Me.ucrInputLabelSize.IsReadOnly = False
        Me.ucrInputLabelSize.Location = New System.Drawing.Point(346, 409)
        Me.ucrInputLabelSize.Name = "ucrInputLabelSize"
        Me.ucrInputLabelSize.Size = New System.Drawing.Size(57, 21)
        Me.ucrInputLabelSize.TabIndex = 65
        '
        'lblLabelColour
        '
        Me.lblLabelColour.AutoSize = True
        Me.lblLabelColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelColour.Location = New System.Drawing.Point(210, 412)
        Me.lblLabelColour.Name = "lblLabelColour"
        Me.lblLabelColour.Size = New System.Drawing.Size(40, 13)
        Me.lblLabelColour.TabIndex = 61
        Me.lblLabelColour.Text = "Colour:"
        '
        'lblLabelSize
        '
        Me.lblLabelSize.AutoSize = True
        Me.lblLabelSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelSize.Location = New System.Drawing.Point(313, 412)
        Me.lblLabelSize.Name = "lblLabelSize"
        Me.lblLabelSize.Size = New System.Drawing.Size(30, 13)
        Me.lblLabelSize.TabIndex = 64
        Me.lblLabelSize.Text = "Size:"
        '
        'ucrInputLabelPosition
        '
        Me.ucrInputLabelPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabelPosition.GetSetSelectedIndex = -1
        Me.ucrInputLabelPosition.IsReadOnly = False
        Me.ucrInputLabelPosition.Location = New System.Drawing.Point(151, 409)
        Me.ucrInputLabelPosition.Name = "ucrInputLabelPosition"
        Me.ucrInputLabelPosition.Size = New System.Drawing.Size(57, 21)
        Me.ucrInputLabelPosition.TabIndex = 60
        '
        'ucrChkAddLabelsText
        '
        Me.ucrChkAddLabelsText.AutoSize = True
        Me.ucrChkAddLabelsText.Checked = False
        Me.ucrChkAddLabelsText.Location = New System.Drawing.Point(10, 409)
        Me.ucrChkAddLabelsText.Name = "ucrChkAddLabelsText"
        Me.ucrChkAddLabelsText.Size = New System.Drawing.Size(88, 23)
        Me.ucrChkAddLabelsText.TabIndex = 62
        '
        'lblLabelPosition
        '
        Me.lblLabelPosition.AutoSize = True
        Me.lblLabelPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelPosition.Location = New System.Drawing.Point(101, 412)
        Me.lblLabelPosition.Name = "lblLabelPosition"
        Me.lblLabelPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblLabelPosition.TabIndex = 59
        Me.lblLabelPosition.Text = "Position:"
        '
        'ucrInputLabelColour
        '
        Me.ucrInputLabelColour.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabelColour.GetSetSelectedIndex = -1
        Me.ucrInputLabelColour.IsReadOnly = False
        Me.ucrInputLabelColour.Location = New System.Drawing.Point(252, 409)
        Me.ucrInputLabelColour.Name = "ucrInputLabelColour"
        Me.ucrInputLabelColour.Size = New System.Drawing.Size(57, 21)
        Me.ucrInputLabelColour.TabIndex = 63
        '
        'dlgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(438, 516)
        Me.Controls.Add(Me.ucrInputLabelSize)
        Me.Controls.Add(Me.lblLabelColour)
        Me.Controls.Add(Me.lblLabelSize)
        Me.Controls.Add(Me.ucrInputLabelPosition)
        Me.Controls.Add(Me.ucrChkAddLabelsText)
        Me.Controls.Add(Me.lblLabelPosition)
        Me.Controls.Add(Me.ucrInputLabelColour)
        Me.Controls.Add(Me.grpTypeOfDispaly)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.ucrReceiverColour)
        Me.Controls.Add(Me.rdoPairs)
        Me.Controls.Add(Me.rdoBy)
        Me.Controls.Add(Me.ucrPnlByPairs)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.ucrReceiverSecondVar)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSelectorTwoVarGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverFirstVars)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVarGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Two Plus Variable Graph"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpTypeOfDispaly.ResumeLayout(False)
        Me.grpTypeOfDispaly.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSelectorTwoVarGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSecondVar As ucrReceiverSingle
    Friend WithEvents lblSecondVariable As Label
    Friend WithEvents ucrReceiverFirstVars As ucrVariablesAsFactor
    Friend WithEvents lblFirstVariables As Label
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents lblFirstType As Label
    Friend WithEvents lblGraph As Label
    Friend WithEvents lblBy As Label
    Friend WithEvents lblSecondType As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblGraphName As Label
    Friend WithEvents ucrInputNumericByNumeric As ucrInputComboBox
    Friend WithEvents ucrInputNumericByCategorical As ucrInputComboBox
    Friend WithEvents ucrInputCategoricalByNumeric As ucrInputComboBox
    Friend WithEvents ucrInputCategoricalByCategorical As ucrInputComboBox
    Friend WithEvents ucrChkFreeScaleYAxis As ucrCheck
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents ucrNudTransparency As ucrNud
    Friend WithEvents ucrNudJitter As ucrNud
    Friend WithEvents lblPointTransparency As Label
    Friend WithEvents lblPointJitter As Label
    Friend WithEvents ucrPnlByPairs As UcrPanel
    Friend WithEvents rdoPairs As RadioButton
    Friend WithEvents rdoBy As RadioButton
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrReceiverColour As ucrReceiverSingle
    Friend WithEvents grpTypeOfDispaly As GroupBox
    Friend WithEvents ucrChkDiagonal As ucrCheck
    Friend WithEvents ucrChkLower As ucrCheck
    Friend WithEvents ucrChkUpper As ucrCheck
    Friend WithEvents ucrInputLowerContinous As ucrInputComboBox
    Friend WithEvents ucrInputLowerDiscrete As ucrInputComboBox
    Friend WithEvents ucrInputLowerCombo As ucrInputComboBox
    Friend WithEvents ucrInputLowerNA As ucrInputComboBox
    Friend WithEvents lblLowerCombo As Label
    Friend WithEvents lblLowerContinous As Label
    Friend WithEvents lblLowerNA As Label
    Friend WithEvents lblLowerDiscrete As Label
    Friend WithEvents lblDiagonalNA As Label
    Friend WithEvents ucrInputDiagonalNA As ucrInputComboBox
    Friend WithEvents lblDiagonalDiscrete As Label
    Friend WithEvents ucrInputDiagonalDiscrete As ucrInputComboBox
    Friend WithEvents lblDiagonalContinuous As Label
    Friend WithEvents ucrInputDiagonalContinous As ucrInputComboBox
    Friend WithEvents lblUpperNA As Label
    Friend WithEvents lblUpperDiscrete As Label
    Friend WithEvents lblUpperCombo As Label
    Friend WithEvents lblUpperContinous As Label
    Friend WithEvents ucrInputUpperNA As ucrInputComboBox
    Friend WithEvents ucrInputUpperDiscrete As ucrInputComboBox
    Friend WithEvents ucrInputUpperCombo As ucrInputComboBox
    Friend WithEvents ucrInputUpperContinous As ucrInputComboBox
    Friend WithEvents ucrInputLabelSize As ucrInputComboBox
    Friend WithEvents lblLabelColour As Label
    Friend WithEvents lblLabelSize As Label
    Friend WithEvents ucrInputLabelPosition As ucrInputComboBox
    Friend WithEvents ucrChkAddLabelsText As ucrCheck
    Friend WithEvents lblLabelPosition As Label
    Friend WithEvents ucrInputLabelColour As ucrInputComboBox
End Class