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
        Me.lblThirdType = New System.Windows.Forms.Label()
        Me.lblSecondBy = New System.Windows.Forms.Label()
        Me.lblFirstType = New System.Windows.Forms.Label()
        Me.lblGraphName = New System.Windows.Forms.Label()
        Me.lblGraph = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblSecondType = New System.Windows.Forms.Label()
        Me.ucrInputCategoricalByNumeric = New instat.ucrInputComboBox()
        Me.ucrInputNumericByCategorical = New instat.ucrInputComboBox()
        Me.ucrInputNumericByNumeric = New instat.ucrInputComboBox()
        Me.ucrInputCategoricalByCategorical = New instat.ucrInputComboBox()
        Me.ucrInputCategoricalByNumericByCategorical = New instat.ucrInputComboBox()
        Me.ucrInputNumericByCategoricalByCategorical = New instat.ucrInputComboBox()
        Me.ucrInputCategoricalByCategoricalByCategorical = New instat.ucrInputComboBox()
        Me.ucrInputNumericByNumericByCategorical = New instat.ucrInputComboBox()
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
        Me.rdoSummarize = New System.Windows.Forms.RadioButton()
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
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
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
        Me.UcrVariablesAsFactor1 = New instat.ucrVariablesAsFactor()
        Me.ucrChkUpper = New instat.ucrCheck()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.lblFillThirdVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
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
        Me.cmdPairOptions = New System.Windows.Forms.Button()
        Me.ucrInputXSidePlotOptions = New instat.ucrInputComboBox()
        Me.ucrChkXSidePlot = New instat.ucrCheck()
        Me.ucrInputYSidePlotOptions = New instat.ucrInputComboBox()
        Me.ucrChkYSidePlot = New instat.ucrCheck()
        Me.rdoSide = New System.Windows.Forms.RadioButton()
        Me.rdoThreeVars = New System.Windows.Forms.RadioButton()
        Me.rdoTwoVars = New System.Windows.Forms.RadioButton()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.grpSummaries.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpTypeOfDispaly.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(36, 341)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(207, 34)
        Me.cmdOptions.TabIndex = 5
        Me.cmdOptions.Tag = "Options..."
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSecondVariable
        '
        Me.lblSecondVariable.AutoSize = True
        Me.lblSecondVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondVariable.Location = New System.Drawing.Point(538, 281)
        Me.lblSecondVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(130, 20)
        Me.lblSecondVariable.TabIndex = 3
        Me.lblSecondVariable.Text = "Second Variable:"
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariables.Location = New System.Drawing.Point(540, 98)
        Me.lblFirstVariables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(124, 20)
        Me.lblFirstVariables.TabIndex = 2
        Me.lblFirstVariables.Tag = "First_Variable(s)"
        Me.lblFirstVariables.Text = "First Variable(s):"
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.lblThirdType)
        Me.grpSummaries.Controls.Add(Me.lblSecondBy)
        Me.grpSummaries.Controls.Add(Me.lblFirstType)
        Me.grpSummaries.Controls.Add(Me.lblGraphName)
        Me.grpSummaries.Controls.Add(Me.lblGraph)
        Me.grpSummaries.Controls.Add(Me.lblBy)
        Me.grpSummaries.Controls.Add(Me.lblSecondType)
        Me.grpSummaries.Controls.Add(Me.ucrInputCategoricalByNumeric)
        Me.grpSummaries.Controls.Add(Me.ucrInputNumericByCategorical)
        Me.grpSummaries.Controls.Add(Me.ucrInputNumericByNumeric)
        Me.grpSummaries.Controls.Add(Me.ucrInputCategoricalByCategorical)
        Me.grpSummaries.Controls.Add(Me.ucrInputCategoricalByNumericByCategorical)
        Me.grpSummaries.Controls.Add(Me.ucrInputNumericByCategoricalByCategorical)
        Me.grpSummaries.Controls.Add(Me.ucrInputCategoricalByCategoricalByCategorical)
        Me.grpSummaries.Controls.Add(Me.ucrInputNumericByNumericByCategorical)
        Me.grpSummaries.Location = New System.Drawing.Point(36, 380)
        Me.grpSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSummaries.Size = New System.Drawing.Size(336, 120)
        Me.grpSummaries.TabIndex = 15
        Me.grpSummaries.TabStop = False
        '
        'lblThirdType
        '
        Me.lblThirdType.AutoSize = True
        Me.lblThirdType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThirdType.Location = New System.Drawing.Point(67, 50)
        Me.lblThirdType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThirdType.Name = "lblThirdType"
        Me.lblThirdType.Size = New System.Drawing.Size(69, 20)
        Me.lblThirdType.TabIndex = 19
        Me.lblThirdType.Text = "third ype"
        '
        'lblSecondBy
        '
        Me.lblSecondBy.AutoSize = True
        Me.lblSecondBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondBy.Location = New System.Drawing.Point(281, 17)
        Me.lblSecondBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondBy.Name = "lblSecondBy"
        Me.lblSecondBy.Size = New System.Drawing.Size(25, 20)
        Me.lblSecondBy.TabIndex = 18
        Me.lblSecondBy.Text = "by"
        '
        'lblFirstType
        '
        Me.lblFirstType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFirstType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstType.Location = New System.Drawing.Point(9, 17)
        Me.lblFirstType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstType.Name = "lblFirstType"
        Me.lblFirstType.Size = New System.Drawing.Size(82, 20)
        Me.lblFirstType.TabIndex = 10
        Me.lblFirstType.Text = "first type"
        Me.lblFirstType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGraphName
        '
        Me.lblGraphName.AutoSize = True
        Me.lblGraphName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraphName.Location = New System.Drawing.Point(88, 88)
        Me.lblGraphName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGraphName.Name = "lblGraphName"
        Me.lblGraphName.Size = New System.Drawing.Size(0, 20)
        Me.lblGraphName.TabIndex = 13
        '
        'lblGraph
        '
        Me.lblGraph.AutoSize = True
        Me.lblGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraph.Location = New System.Drawing.Point(9, 88)
        Me.lblGraph.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGraph.Name = "lblGraph"
        Me.lblGraph.Size = New System.Drawing.Size(58, 20)
        Me.lblGraph.TabIndex = 9
        Me.lblGraph.Text = "Graph:"
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBy.Location = New System.Drawing.Point(117, 17)
        Me.lblBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(25, 20)
        Me.lblBy.TabIndex = 11
        Me.lblBy.Text = "by"
        '
        'lblSecondType
        '
        Me.lblSecondType.AutoSize = True
        Me.lblSecondType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondType.Location = New System.Drawing.Point(152, 17)
        Me.lblSecondType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondType.Name = "lblSecondType"
        Me.lblSecondType.Size = New System.Drawing.Size(95, 20)
        Me.lblSecondType.TabIndex = 12
        Me.lblSecondType.Text = "second type"
        '
        'ucrInputCategoricalByNumeric
        '
        Me.ucrInputCategoricalByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategoricalByNumeric.GetSetSelectedIndex = -1
        Me.ucrInputCategoricalByNumeric.IsReadOnly = False
        Me.ucrInputCategoricalByNumeric.Location = New System.Drawing.Point(90, 81)
        Me.ucrInputCategoricalByNumeric.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCategoricalByNumeric.Name = "ucrInputCategoricalByNumeric"
        Me.ucrInputCategoricalByNumeric.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputCategoricalByNumeric.TabIndex = 16
        '
        'ucrInputNumericByCategorical
        '
        Me.ucrInputNumericByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputNumericByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNumericByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputNumericByCategorical.IsReadOnly = False
        Me.ucrInputNumericByCategorical.Location = New System.Drawing.Point(90, 81)
        Me.ucrInputNumericByCategorical.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputNumericByCategorical.Name = "ucrInputNumericByCategorical"
        Me.ucrInputNumericByCategorical.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputNumericByCategorical.TabIndex = 15
        '
        'ucrInputNumericByNumeric
        '
        Me.ucrInputNumericByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputNumericByNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNumericByNumeric.GetSetSelectedIndex = -1
        Me.ucrInputNumericByNumeric.IsReadOnly = False
        Me.ucrInputNumericByNumeric.Location = New System.Drawing.Point(90, 81)
        Me.ucrInputNumericByNumeric.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputNumericByNumeric.Name = "ucrInputNumericByNumeric"
        Me.ucrInputNumericByNumeric.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputNumericByNumeric.TabIndex = 14
        '
        'ucrInputCategoricalByCategorical
        '
        Me.ucrInputCategoricalByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategoricalByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputCategoricalByCategorical.IsReadOnly = False
        Me.ucrInputCategoricalByCategorical.Location = New System.Drawing.Point(90, 81)
        Me.ucrInputCategoricalByCategorical.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCategoricalByCategorical.Name = "ucrInputCategoricalByCategorical"
        Me.ucrInputCategoricalByCategorical.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputCategoricalByCategorical.TabIndex = 17
        '
        'ucrInputCategoricalByNumericByCategorical
        '
        Me.ucrInputCategoricalByNumericByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByNumericByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategoricalByNumericByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputCategoricalByNumericByCategorical.IsReadOnly = False
        Me.ucrInputCategoricalByNumericByCategorical.Location = New System.Drawing.Point(90, 81)
        Me.ucrInputCategoricalByNumericByCategorical.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCategoricalByNumericByCategorical.Name = "ucrInputCategoricalByNumericByCategorical"
        Me.ucrInputCategoricalByNumericByCategorical.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputCategoricalByNumericByCategorical.TabIndex = 83
        '
        'ucrInputNumericByCategoricalByCategorical
        '
        Me.ucrInputNumericByCategoricalByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputNumericByCategoricalByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNumericByCategoricalByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputNumericByCategoricalByCategorical.IsReadOnly = False
        Me.ucrInputNumericByCategoricalByCategorical.Location = New System.Drawing.Point(90, 81)
        Me.ucrInputNumericByCategoricalByCategorical.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputNumericByCategoricalByCategorical.Name = "ucrInputNumericByCategoricalByCategorical"
        Me.ucrInputNumericByCategoricalByCategorical.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputNumericByCategoricalByCategorical.TabIndex = 80
        '
        'ucrInputCategoricalByCategoricalByCategorical
        '
        Me.ucrInputCategoricalByCategoricalByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByCategoricalByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategoricalByCategoricalByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputCategoricalByCategoricalByCategorical.IsReadOnly = False
        Me.ucrInputCategoricalByCategoricalByCategorical.Location = New System.Drawing.Point(90, 81)
        Me.ucrInputCategoricalByCategoricalByCategorical.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCategoricalByCategoricalByCategorical.Name = "ucrInputCategoricalByCategoricalByCategorical"
        Me.ucrInputCategoricalByCategoricalByCategorical.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputCategoricalByCategoricalByCategorical.TabIndex = 81
        '
        'ucrInputNumericByNumericByCategorical
        '
        Me.ucrInputNumericByNumericByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputNumericByNumericByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNumericByNumericByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputNumericByNumericByCategorical.IsReadOnly = False
        Me.ucrInputNumericByNumericByCategorical.Location = New System.Drawing.Point(90, 81)
        Me.ucrInputNumericByNumericByCategorical.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputNumericByNumericByCategorical.Name = "ucrInputNumericByNumericByCategorical"
        Me.ucrInputNumericByNumericByCategorical.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputNumericByNumericByCategorical.TabIndex = 78
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
        Me.grpOptions.Location = New System.Drawing.Point(476, 438)
        Me.grpOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOptions.Size = New System.Drawing.Size(256, 166)
        Me.grpOptions.TabIndex = 16
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPosition.Location = New System.Drawing.Point(6, 106)
        Me.lblPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(69, 20)
        Me.lblPosition.TabIndex = 12
        Me.lblPosition.Text = "Position:"
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.AutoSize = True
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTransparency.Location = New System.Drawing.Point(168, 130)
        Me.ucrNudTransparency.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudTransparency.TabIndex = 11
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJitter
        '
        Me.ucrNudJitter.AutoSize = True
        Me.ucrNudJitter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJitter.Location = New System.Drawing.Point(168, 93)
        Me.ucrNudJitter.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudJitter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJitter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Name = "ucrNudJitter"
        Me.ucrNudJitter.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudJitter.TabIndex = 10
        Me.ucrNudJitter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPointTransparency
        '
        Me.lblPointTransparency.AutoSize = True
        Me.lblPointTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPointTransparency.Location = New System.Drawing.Point(6, 135)
        Me.lblPointTransparency.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPointTransparency.Name = "lblPointTransparency"
        Me.lblPointTransparency.Size = New System.Drawing.Size(149, 20)
        Me.lblPointTransparency.TabIndex = 9
        Me.lblPointTransparency.Text = "Point Transparency:"
        '
        'lblPointJitter
        '
        Me.lblPointJitter.AutoSize = True
        Me.lblPointJitter.Location = New System.Drawing.Point(6, 98)
        Me.lblPointJitter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPointJitter.Name = "lblPointJitter"
        Me.lblPointJitter.Size = New System.Drawing.Size(88, 20)
        Me.lblPointJitter.TabIndex = 8
        Me.lblPointJitter.Text = "Point Jitter:"
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.AutoSize = True
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(9, 28)
        Me.ucrChkFlipCoordinates.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(238, 34)
        Me.ucrChkFlipCoordinates.TabIndex = 6
        '
        'ucrChkFreeScaleYAxis
        '
        Me.ucrChkFreeScaleYAxis.AutoSize = True
        Me.ucrChkFreeScaleYAxis.Checked = False
        Me.ucrChkFreeScaleYAxis.Location = New System.Drawing.Point(9, 62)
        Me.ucrChkFreeScaleYAxis.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFreeScaleYAxis.Name = "ucrChkFreeScaleYAxis"
        Me.ucrChkFreeScaleYAxis.Size = New System.Drawing.Size(238, 34)
        Me.ucrChkFreeScaleYAxis.TabIndex = 7
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(81, 102)
        Me.ucrInputPosition.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(166, 32)
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
        Me.rdoPairs.Location = New System.Drawing.Point(461, 12)
        Me.rdoPairs.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPairs.Name = "rdoPairs"
        Me.rdoPairs.Size = New System.Drawing.Size(145, 40)
        Me.rdoPairs.TabIndex = 19
        Me.rdoPairs.TabStop = True
        Me.rdoPairs.Text = "Pairs"
        Me.rdoPairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPairs.UseVisualStyleBackColor = True
        '
        'rdoSummarize
        '
        Me.rdoSummarize.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSummarize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummarize.FlatAppearance.BorderSize = 2
        Me.rdoSummarize.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummarize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSummarize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummarize.Location = New System.Drawing.Point(604, 12)
        Me.rdoSummarize.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSummarize.Name = "rdoSummarize"
        Me.rdoSummarize.Size = New System.Drawing.Size(145, 40)
        Me.rdoSummarize.TabIndex = 18
        Me.rdoSummarize.TabStop = True
        Me.rdoSummarize.Text = "Summarize"
        Me.rdoSummarize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummarize.UseVisualStyleBackColor = True
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColour.Location = New System.Drawing.Point(536, 282)
        Me.lblColour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(132, 20)
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
        Me.grpTypeOfDispaly.Controls.Add(Me.UcrReceiverSingle2)
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
        Me.grpTypeOfDispaly.Controls.Add(Me.UcrVariablesAsFactor1)
        Me.grpTypeOfDispaly.Controls.Add(Me.ucrChkUpper)
        Me.grpTypeOfDispaly.Controls.Add(Me.UcrReceiverSingle1)
        Me.grpTypeOfDispaly.Location = New System.Drawing.Point(37, 408)
        Me.grpTypeOfDispaly.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTypeOfDispaly.Name = "grpTypeOfDispaly"
        Me.grpTypeOfDispaly.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTypeOfDispaly.Size = New System.Drawing.Size(695, 226)
        Me.grpTypeOfDispaly.TabIndex = 22
        Me.grpTypeOfDispaly.TabStop = False
        Me.grpTypeOfDispaly.Text = "Type Of Display"
        '
        'lblDiagonalNA
        '
        Me.lblDiagonalNA.AutoSize = True
        Me.lblDiagonalNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalNA.Location = New System.Drawing.Point(257, 158)
        Me.lblDiagonalNA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiagonalNA.Name = "lblDiagonalNA"
        Me.lblDiagonalNA.Size = New System.Drawing.Size(35, 20)
        Me.lblDiagonalNA.TabIndex = 40
        Me.lblDiagonalNA.Text = "NA:"
        '
        'ucrInputDiagonalNA
        '
        Me.ucrInputDiagonalNA.AddQuotesIfUnrecognised = True
        Me.ucrInputDiagonalNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDiagonalNA.GetSetSelectedIndex = -1
        Me.ucrInputDiagonalNA.IsReadOnly = False
        Me.ucrInputDiagonalNA.Location = New System.Drawing.Point(353, 150)
        Me.ucrInputDiagonalNA.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDiagonalNA.Name = "ucrInputDiagonalNA"
        Me.ucrInputDiagonalNA.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputDiagonalNA.TabIndex = 39
        '
        'lblDiagonalDiscrete
        '
        Me.lblDiagonalDiscrete.AutoSize = True
        Me.lblDiagonalDiscrete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalDiscrete.Location = New System.Drawing.Point(254, 116)
        Me.lblDiagonalDiscrete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiagonalDiscrete.Name = "lblDiagonalDiscrete"
        Me.lblDiagonalDiscrete.Size = New System.Drawing.Size(72, 20)
        Me.lblDiagonalDiscrete.TabIndex = 38
        Me.lblDiagonalDiscrete.Text = "Discrete:"
        '
        'ucrInputDiagonalDiscrete
        '
        Me.ucrInputDiagonalDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputDiagonalDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDiagonalDiscrete.GetSetSelectedIndex = -1
        Me.ucrInputDiagonalDiscrete.IsReadOnly = False
        Me.ucrInputDiagonalDiscrete.Location = New System.Drawing.Point(353, 110)
        Me.ucrInputDiagonalDiscrete.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDiagonalDiscrete.Name = "ucrInputDiagonalDiscrete"
        Me.ucrInputDiagonalDiscrete.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputDiagonalDiscrete.TabIndex = 37
        '
        'lblDiagonalContinuous
        '
        Me.lblDiagonalContinuous.AutoSize = True
        Me.lblDiagonalContinuous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalContinuous.Location = New System.Drawing.Point(253, 75)
        Me.lblDiagonalContinuous.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiagonalContinuous.Name = "lblDiagonalContinuous"
        Me.lblDiagonalContinuous.Size = New System.Drawing.Size(94, 20)
        Me.lblDiagonalContinuous.TabIndex = 36
        Me.lblDiagonalContinuous.Text = "Continuous:"
        '
        'ucrInputDiagonalContinous
        '
        Me.ucrInputDiagonalContinous.AddQuotesIfUnrecognised = True
        Me.ucrInputDiagonalContinous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDiagonalContinous.GetSetSelectedIndex = -1
        Me.ucrInputDiagonalContinous.IsReadOnly = False
        Me.ucrInputDiagonalContinous.Location = New System.Drawing.Point(353, 69)
        Me.ucrInputDiagonalContinous.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDiagonalContinous.Name = "ucrInputDiagonalContinous"
        Me.ucrInputDiagonalContinous.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputDiagonalContinous.TabIndex = 35
        '
        'lblUpperNA
        '
        Me.lblUpperNA.AutoSize = True
        Me.lblUpperNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperNA.Location = New System.Drawing.Point(497, 196)
        Me.lblUpperNA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpperNA.Name = "lblUpperNA"
        Me.lblUpperNA.Size = New System.Drawing.Size(35, 20)
        Me.lblUpperNA.TabIndex = 34
        Me.lblUpperNA.Text = "NA:"
        '
        'lblUpperDiscrete
        '
        Me.lblUpperDiscrete.AutoSize = True
        Me.lblUpperDiscrete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperDiscrete.Location = New System.Drawing.Point(494, 156)
        Me.lblUpperDiscrete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpperDiscrete.Name = "lblUpperDiscrete"
        Me.lblUpperDiscrete.Size = New System.Drawing.Size(72, 20)
        Me.lblUpperDiscrete.TabIndex = 33
        Me.lblUpperDiscrete.Text = "Discrete:"
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.AutoSize = True
        Me.UcrReceiverSingle2.frmParent = Me
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(419, -36)
        Me.UcrReceiverSingle2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Selector = Nothing
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(180, 30)
        Me.UcrReceiverSingle2.strNcFilePath = ""
        Me.UcrReceiverSingle2.TabIndex = 68
        Me.UcrReceiverSingle2.ucrSelector = Nothing
        '
        'lblUpperCombo
        '
        Me.lblUpperCombo.AutoSize = True
        Me.lblUpperCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperCombo.Location = New System.Drawing.Point(494, 116)
        Me.lblUpperCombo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpperCombo.Name = "lblUpperCombo"
        Me.lblUpperCombo.Size = New System.Drawing.Size(64, 20)
        Me.lblUpperCombo.TabIndex = 32
        Me.lblUpperCombo.Text = "Combo:"
        '
        'lblUpperContinous
        '
        Me.lblUpperContinous.AutoSize = True
        Me.lblUpperContinous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperContinous.Location = New System.Drawing.Point(494, 75)
        Me.lblUpperContinous.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpperContinous.Name = "lblUpperContinous"
        Me.lblUpperContinous.Size = New System.Drawing.Size(94, 20)
        Me.lblUpperContinous.TabIndex = 31
        Me.lblUpperContinous.Text = "Continuous:"
        '
        'ucrInputUpperNA
        '
        Me.ucrInputUpperNA.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUpperNA.GetSetSelectedIndex = -1
        Me.ucrInputUpperNA.IsReadOnly = False
        Me.ucrInputUpperNA.Location = New System.Drawing.Point(595, 190)
        Me.ucrInputUpperNA.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputUpperNA.Name = "ucrInputUpperNA"
        Me.ucrInputUpperNA.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputUpperNA.TabIndex = 30
        '
        'ucrInputUpperDiscrete
        '
        Me.ucrInputUpperDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUpperDiscrete.GetSetSelectedIndex = -1
        Me.ucrInputUpperDiscrete.IsReadOnly = False
        Me.ucrInputUpperDiscrete.Location = New System.Drawing.Point(595, 150)
        Me.ucrInputUpperDiscrete.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputUpperDiscrete.Name = "ucrInputUpperDiscrete"
        Me.ucrInputUpperDiscrete.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputUpperDiscrete.TabIndex = 29
        '
        'ucrInputUpperCombo
        '
        Me.ucrInputUpperCombo.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperCombo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUpperCombo.GetSetSelectedIndex = -1
        Me.ucrInputUpperCombo.IsReadOnly = False
        Me.ucrInputUpperCombo.Location = New System.Drawing.Point(595, 110)
        Me.ucrInputUpperCombo.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputUpperCombo.Name = "ucrInputUpperCombo"
        Me.ucrInputUpperCombo.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputUpperCombo.TabIndex = 28
        '
        'ucrInputUpperContinous
        '
        Me.ucrInputUpperContinous.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperContinous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUpperContinous.GetSetSelectedIndex = -1
        Me.ucrInputUpperContinous.IsReadOnly = False
        Me.ucrInputUpperContinous.Location = New System.Drawing.Point(595, 69)
        Me.ucrInputUpperContinous.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputUpperContinous.Name = "ucrInputUpperContinous"
        Me.ucrInputUpperContinous.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputUpperContinous.TabIndex = 27
        '
        'lblLowerNA
        '
        Me.lblLowerNA.AutoSize = True
        Me.lblLowerNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLowerNA.Location = New System.Drawing.Point(4, 195)
        Me.lblLowerNA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLowerNA.Name = "lblLowerNA"
        Me.lblLowerNA.Size = New System.Drawing.Size(35, 20)
        Me.lblLowerNA.TabIndex = 26
        Me.lblLowerNA.Text = "NA:"
        '
        'lblLowerDiscrete
        '
        Me.lblLowerDiscrete.AutoSize = True
        Me.lblLowerDiscrete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLowerDiscrete.Location = New System.Drawing.Point(2, 158)
        Me.lblLowerDiscrete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLowerDiscrete.Name = "lblLowerDiscrete"
        Me.lblLowerDiscrete.Size = New System.Drawing.Size(72, 20)
        Me.lblLowerDiscrete.TabIndex = 25
        Me.lblLowerDiscrete.Text = "Discrete:"
        '
        'lblLowerCombo
        '
        Me.lblLowerCombo.AutoSize = True
        Me.lblLowerCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLowerCombo.Location = New System.Drawing.Point(2, 117)
        Me.lblLowerCombo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLowerCombo.Name = "lblLowerCombo"
        Me.lblLowerCombo.Size = New System.Drawing.Size(64, 20)
        Me.lblLowerCombo.TabIndex = 24
        Me.lblLowerCombo.Text = "Combo:"
        '
        'lblLowerContinous
        '
        Me.lblLowerContinous.AutoSize = True
        Me.lblLowerContinous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLowerContinous.Location = New System.Drawing.Point(2, 75)
        Me.lblLowerContinous.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLowerContinous.Name = "lblLowerContinous"
        Me.lblLowerContinous.Size = New System.Drawing.Size(94, 20)
        Me.lblLowerContinous.TabIndex = 23
        Me.lblLowerContinous.Text = "Continuous:"
        '
        'ucrInputLowerNA
        '
        Me.ucrInputLowerNA.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLowerNA.GetSetSelectedIndex = -1
        Me.ucrInputLowerNA.IsReadOnly = False
        Me.ucrInputLowerNA.Location = New System.Drawing.Point(102, 190)
        Me.ucrInputLowerNA.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLowerNA.Name = "ucrInputLowerNA"
        Me.ucrInputLowerNA.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputLowerNA.TabIndex = 22
        '
        'ucrInputLowerDiscrete
        '
        Me.ucrInputLowerDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLowerDiscrete.GetSetSelectedIndex = -1
        Me.ucrInputLowerDiscrete.IsReadOnly = False
        Me.ucrInputLowerDiscrete.Location = New System.Drawing.Point(102, 150)
        Me.ucrInputLowerDiscrete.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLowerDiscrete.Name = "ucrInputLowerDiscrete"
        Me.ucrInputLowerDiscrete.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputLowerDiscrete.TabIndex = 5
        '
        'ucrInputLowerCombo
        '
        Me.ucrInputLowerCombo.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerCombo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLowerCombo.GetSetSelectedIndex = -1
        Me.ucrInputLowerCombo.IsReadOnly = False
        Me.ucrInputLowerCombo.Location = New System.Drawing.Point(102, 110)
        Me.ucrInputLowerCombo.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLowerCombo.Name = "ucrInputLowerCombo"
        Me.ucrInputLowerCombo.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputLowerCombo.TabIndex = 4
        '
        'ucrInputLowerContinous
        '
        Me.ucrInputLowerContinous.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerContinous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLowerContinous.GetSetSelectedIndex = -1
        Me.ucrInputLowerContinous.IsReadOnly = False
        Me.ucrInputLowerContinous.Location = New System.Drawing.Point(102, 69)
        Me.ucrInputLowerContinous.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLowerContinous.Name = "ucrInputLowerContinous"
        Me.ucrInputLowerContinous.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputLowerContinous.TabIndex = 3
        '
        'ucrChkDiagonal
        '
        Me.ucrChkDiagonal.AutoSize = True
        Me.ucrChkDiagonal.Checked = False
        Me.ucrChkDiagonal.Location = New System.Drawing.Point(257, 26)
        Me.ucrChkDiagonal.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDiagonal.Name = "ucrChkDiagonal"
        Me.ucrChkDiagonal.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkDiagonal.TabIndex = 2
        '
        'ucrChkLower
        '
        Me.ucrChkLower.AutoSize = True
        Me.ucrChkLower.Checked = False
        Me.ucrChkLower.Location = New System.Drawing.Point(9, 26)
        Me.ucrChkLower.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLower.Name = "ucrChkLower"
        Me.ucrChkLower.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkLower.TabIndex = 1
        '
        'UcrVariablesAsFactor1
        '
        Me.UcrVariablesAsFactor1.AutoSize = True
        Me.UcrVariablesAsFactor1.frmParent = Me
        Me.UcrVariablesAsFactor1.Location = New System.Drawing.Point(419, -333)
        Me.UcrVariablesAsFactor1.Margin = New System.Windows.Forms.Padding(9)
        Me.UcrVariablesAsFactor1.Name = "UcrVariablesAsFactor1"
        Me.UcrVariablesAsFactor1.Selector = Nothing
        Me.UcrVariablesAsFactor1.Size = New System.Drawing.Size(180, 207)
        Me.UcrVariablesAsFactor1.strNcFilePath = ""
        Me.UcrVariablesAsFactor1.TabIndex = 1
        Me.UcrVariablesAsFactor1.ucrSelector = Nothing
        Me.UcrVariablesAsFactor1.ucrVariableSelector = Nothing
        '
        'ucrChkUpper
        '
        Me.ucrChkUpper.AutoSize = True
        Me.ucrChkUpper.Checked = False
        Me.ucrChkUpper.Location = New System.Drawing.Point(498, 26)
        Me.ucrChkUpper.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkUpper.Name = "ucrChkUpper"
        Me.ucrChkUpper.Size = New System.Drawing.Size(180, 34)
        Me.ucrChkUpper.TabIndex = 0
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.AutoSize = True
        Me.UcrReceiverSingle1.frmParent = Me
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(419, -104)
        Me.UcrReceiverSingle1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Selector = Nothing
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(180, 30)
        Me.UcrReceiverSingle1.strNcFilePath = ""
        Me.UcrReceiverSingle1.TabIndex = 21
        Me.UcrReceiverSingle1.ucrSelector = Nothing
        '
        'lblFillThirdVariable
        '
        Me.lblFillThirdVariable.AutoSize = True
        Me.lblFillThirdVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillThirdVariable.Location = New System.Drawing.Point(536, 347)
        Me.lblFillThirdVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFillThirdVariable.Name = "lblFillThirdVariable"
        Me.lblFillThirdVariable.Size = New System.Drawing.Size(139, 20)
        Me.lblFillThirdVariable.TabIndex = 67
        Me.lblFillThirdVariable.Text = "Fill (Third Variable)"
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.AutoSize = True
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Location = New System.Drawing.Point(536, 372)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 68
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrReceiverColour
        '
        Me.ucrReceiverColour.AutoSize = True
        Me.ucrReceiverColour.frmParent = Me
        Me.ucrReceiverColour.Location = New System.Drawing.Point(535, 304)
        Me.ucrReceiverColour.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColour.Name = "ucrReceiverColour"
        Me.ucrReceiverColour.Selector = Nothing
        Me.ucrReceiverColour.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverColour.strNcFilePath = ""
        Me.ucrReceiverColour.TabIndex = 21
        Me.ucrReceiverColour.ucrSelector = Nothing
        '
        'ucrPnlByPairs
        '
        Me.ucrPnlByPairs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlByPairs.Location = New System.Drawing.Point(25, 8)
        Me.ucrPnlByPairs.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlByPairs.Name = "ucrPnlByPairs"
        Me.ucrPnlByPairs.Size = New System.Drawing.Size(735, 46)
        Me.ucrPnlByPairs.TabIndex = 17
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(36, 678)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(508, 36)
        Me.ucrSaveGraph.TabIndex = 7
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.AutoSize = True
        Me.ucrReceiverSecondVar.frmParent = Me
        Me.ucrReceiverSecondVar.Location = New System.Drawing.Point(537, 303)
        Me.ucrReceiverSecondVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondVar.Name = "ucrReceiverSecondVar"
        Me.ucrReceiverSecondVar.Selector = Nothing
        Me.ucrReceiverSecondVar.Size = New System.Drawing.Size(180, 30)
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
        Me.ucrSelectorTwoVarGraph.Location = New System.Drawing.Point(36, 62)
        Me.ucrSelectorTwoVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoVarGraph.Name = "ucrSelectorTwoVarGraph"
        Me.ucrSelectorTwoVarGraph.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorTwoVarGraph.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(36, 718)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.AutoSize = True
        Me.ucrReceiverFirstVars.frmParent = Me
        Me.ucrReceiverFirstVars.Location = New System.Drawing.Point(536, 75)
        Me.ucrReceiverFirstVars.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrReceiverFirstVars.Name = "ucrReceiverFirstVars"
        Me.ucrReceiverFirstVars.Selector = Nothing
        Me.ucrReceiverFirstVars.Size = New System.Drawing.Size(180, 207)
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
        Me.ucrInputLabelSize.Location = New System.Drawing.Point(639, 642)
        Me.ucrInputLabelSize.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLabelSize.Name = "ucrInputLabelSize"
        Me.ucrInputLabelSize.Size = New System.Drawing.Size(86, 32)
        Me.ucrInputLabelSize.TabIndex = 65
        '
        'lblLabelColour
        '
        Me.lblLabelColour.AutoSize = True
        Me.lblLabelColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelColour.Location = New System.Drawing.Point(409, 646)
        Me.lblLabelColour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabelColour.Name = "lblLabelColour"
        Me.lblLabelColour.Size = New System.Drawing.Size(59, 20)
        Me.lblLabelColour.TabIndex = 61
        Me.lblLabelColour.Text = "Colour:"
        '
        'lblLabelSize
        '
        Me.lblLabelSize.AutoSize = True
        Me.lblLabelSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelSize.Location = New System.Drawing.Point(590, 646)
        Me.lblLabelSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabelSize.Name = "lblLabelSize"
        Me.lblLabelSize.Size = New System.Drawing.Size(44, 20)
        Me.lblLabelSize.TabIndex = 64
        Me.lblLabelSize.Text = "Size:"
        '
        'ucrInputLabelPosition
        '
        Me.ucrInputLabelPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabelPosition.GetSetSelectedIndex = -1
        Me.ucrInputLabelPosition.IsReadOnly = False
        Me.ucrInputLabelPosition.Location = New System.Drawing.Point(284, 642)
        Me.ucrInputLabelPosition.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLabelPosition.Name = "ucrInputLabelPosition"
        Me.ucrInputLabelPosition.Size = New System.Drawing.Size(86, 32)
        Me.ucrInputLabelPosition.TabIndex = 60
        '
        'ucrChkAddLabelsText
        '
        Me.ucrChkAddLabelsText.AutoSize = True
        Me.ucrChkAddLabelsText.Checked = False
        Me.ucrChkAddLabelsText.Location = New System.Drawing.Point(36, 642)
        Me.ucrChkAddLabelsText.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAddLabelsText.Name = "ucrChkAddLabelsText"
        Me.ucrChkAddLabelsText.Size = New System.Drawing.Size(132, 34)
        Me.ucrChkAddLabelsText.TabIndex = 62
        '
        'lblLabelPosition
        '
        Me.lblLabelPosition.AutoSize = True
        Me.lblLabelPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelPosition.Location = New System.Drawing.Point(210, 646)
        Me.lblLabelPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabelPosition.Name = "lblLabelPosition"
        Me.lblLabelPosition.Size = New System.Drawing.Size(69, 20)
        Me.lblLabelPosition.TabIndex = 59
        Me.lblLabelPosition.Text = "Position:"
        '
        'ucrInputLabelColour
        '
        Me.ucrInputLabelColour.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabelColour.GetSetSelectedIndex = -1
        Me.ucrInputLabelColour.IsReadOnly = False
        Me.ucrInputLabelColour.Location = New System.Drawing.Point(472, 642)
        Me.ucrInputLabelColour.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLabelColour.Name = "ucrInputLabelColour"
        Me.ucrInputLabelColour.Size = New System.Drawing.Size(86, 32)
        Me.ucrInputLabelColour.TabIndex = 63
        '
        'cmdPairOptions
        '
        Me.cmdPairOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPairOptions.Location = New System.Drawing.Point(37, 340)
        Me.cmdPairOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPairOptions.Name = "cmdPairOptions"
        Me.cmdPairOptions.Size = New System.Drawing.Size(206, 36)
        Me.cmdPairOptions.TabIndex = 66
        Me.cmdPairOptions.Tag = "Options..."
        Me.cmdPairOptions.Text = "Pair Plot Options"
        Me.cmdPairOptions.UseVisualStyleBackColor = True
        '
        'ucrInputXSidePlotOptions
        '
        Me.ucrInputXSidePlotOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputXSidePlotOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputXSidePlotOptions.GetSetSelectedIndex = -1
        Me.ucrInputXSidePlotOptions.IsReadOnly = False
        Me.ucrInputXSidePlotOptions.Location = New System.Drawing.Point(186, 550)
        Me.ucrInputXSidePlotOptions.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputXSidePlotOptions.Name = "ucrInputXSidePlotOptions"
        Me.ucrInputXSidePlotOptions.Size = New System.Drawing.Size(190, 32)
        Me.ucrInputXSidePlotOptions.TabIndex = 72
        '
        'ucrChkXSidePlot
        '
        Me.ucrChkXSidePlot.AutoSize = True
        Me.ucrChkXSidePlot.Checked = False
        Me.ucrChkXSidePlot.Location = New System.Drawing.Point(41, 550)
        Me.ucrChkXSidePlot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkXSidePlot.Name = "ucrChkXSidePlot"
        Me.ucrChkXSidePlot.Size = New System.Drawing.Size(127, 34)
        Me.ucrChkXSidePlot.TabIndex = 73
        '
        'ucrInputYSidePlotOptions
        '
        Me.ucrInputYSidePlotOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputYSidePlotOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputYSidePlotOptions.GetSetSelectedIndex = -1
        Me.ucrInputYSidePlotOptions.IsReadOnly = False
        Me.ucrInputYSidePlotOptions.Location = New System.Drawing.Point(186, 507)
        Me.ucrInputYSidePlotOptions.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputYSidePlotOptions.Name = "ucrInputYSidePlotOptions"
        Me.ucrInputYSidePlotOptions.Size = New System.Drawing.Size(190, 32)
        Me.ucrInputYSidePlotOptions.TabIndex = 70
        '
        'ucrChkYSidePlot
        '
        Me.ucrChkYSidePlot.AutoSize = True
        Me.ucrChkYSidePlot.Checked = False
        Me.ucrChkYSidePlot.Location = New System.Drawing.Point(41, 507)
        Me.ucrChkYSidePlot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkYSidePlot.Name = "ucrChkYSidePlot"
        Me.ucrChkYSidePlot.Size = New System.Drawing.Size(127, 34)
        Me.ucrChkYSidePlot.TabIndex = 71
        '
        'rdoSide
        '
        Me.rdoSide.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSide.FlatAppearance.BorderSize = 2
        Me.rdoSide.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSide.Location = New System.Drawing.Point(318, 12)
        Me.rdoSide.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSide.Name = "rdoSide"
        Me.rdoSide.Size = New System.Drawing.Size(145, 40)
        Me.rdoSide.TabIndex = 74
        Me.rdoSide.TabStop = True
        Me.rdoSide.Text = "Side"
        Me.rdoSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSide.UseVisualStyleBackColor = True
        '
        'rdoThreeVars
        '
        Me.rdoThreeVars.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoThreeVars.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeVars.FlatAppearance.BorderSize = 2
        Me.rdoThreeVars.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeVars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoThreeVars.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoThreeVars.Location = New System.Drawing.Point(175, 12)
        Me.rdoThreeVars.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoThreeVars.Name = "rdoThreeVars"
        Me.rdoThreeVars.Size = New System.Drawing.Size(145, 40)
        Me.rdoThreeVars.TabIndex = 75
        Me.rdoThreeVars.TabStop = True
        Me.rdoThreeVars.Text = "Three Variables"
        Me.rdoThreeVars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreeVars.UseVisualStyleBackColor = True
        '
        'rdoTwoVars
        '
        Me.rdoTwoVars.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTwoVars.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoVars.FlatAppearance.BorderSize = 2
        Me.rdoTwoVars.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoVars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTwoVars.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTwoVars.Location = New System.Drawing.Point(32, 12)
        Me.rdoTwoVars.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTwoVars.Name = "rdoTwoVars"
        Me.rdoTwoVars.Size = New System.Drawing.Size(145, 40)
        Me.rdoTwoVars.TabIndex = 76
        Me.rdoTwoVars.TabStop = True
        Me.rdoTwoVars.Text = "Two Variables"
        Me.rdoTwoVars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoVars.UseVisualStyleBackColor = True
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(585, 669)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(147, 32)
        Me.ucrInputStation.TabIndex = 79
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(434, 670)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(147, 39)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 78
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(434, 648)
        Me.lblFacetBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(76, 20)
        Me.lblFacetBy.TabIndex = 77
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'dlgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(783, 802)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.rdoTwoVars)
        Me.Controls.Add(Me.rdoThreeVars)
        Me.Controls.Add(Me.rdoSide)
        Me.Controls.Add(Me.ucrInputXSidePlotOptions)
        Me.Controls.Add(Me.ucrChkXSidePlot)
        Me.Controls.Add(Me.ucrInputYSidePlotOptions)
        Me.Controls.Add(Me.ucrChkYSidePlot)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblFillThirdVariable)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrInputLabelSize)
        Me.Controls.Add(Me.lblLabelColour)
        Me.Controls.Add(Me.lblLabelSize)
        Me.Controls.Add(Me.ucrInputLabelPosition)
        Me.Controls.Add(Me.lblLabelPosition)
        Me.Controls.Add(Me.ucrInputLabelColour)
        Me.Controls.Add(Me.rdoPairs)
        Me.Controls.Add(Me.rdoSummarize)
        Me.Controls.Add(Me.ucrPnlByPairs)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSelectorTwoVarGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverFirstVars)
        Me.Controls.Add(Me.cmdPairOptions)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.ucrReceiverSecondVar)
        Me.Controls.Add(Me.ucrChkAddLabelsText)
        Me.Controls.Add(Me.grpTypeOfDispaly)
        Me.Controls.Add(Me.ucrReceiverColour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents rdoSummarize As RadioButton
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
    Friend WithEvents cmdPairOptions As Button
    Friend WithEvents lblFillThirdVariable As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents ucrInputXSidePlotOptions As ucrInputComboBox
    Friend WithEvents ucrChkXSidePlot As ucrCheck
    Friend WithEvents ucrInputYSidePlotOptions As ucrInputComboBox
    Friend WithEvents ucrChkYSidePlot As ucrCheck
    Friend WithEvents rdoTwoVars As RadioButton
    Friend WithEvents rdoThreeVars As RadioButton
    Friend WithEvents rdoSide As RadioButton
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents UcrVariablesAsFactor1 As ucrVariablesAsFactor
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents lblThirdType As Label
    Friend WithEvents lblSecondBy As Label
    Friend WithEvents ucrInputCategoricalByNumericByCategorical As ucrInputComboBox
    Friend WithEvents ucrInputNumericByCategoricalByCategorical As ucrInputComboBox
    Friend WithEvents ucrInputCategoricalByCategoricalByCategorical As ucrInputComboBox
    Friend WithEvents ucrInputNumericByNumericByCategorical As ucrInputComboBox
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
End Class