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
        Me.ucrChkXSidePlot = New instat.ucrCheck()
        Me.ucrChkYSidePlot = New instat.ucrCheck()
        Me.ucrRecieverFill = New instat.ucrReceiverSingle()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.ucrInputXSidePlotOptions = New instat.ucrInputComboBox()
        Me.ucrInputYSidePlotOptions = New instat.ucrInputComboBox()
        Me.grpSummaries.SuspendLayout()
        Me.grpTypeOfDispaly.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(15, 340)
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
        Me.lblSecondVariable.Location = New System.Drawing.Point(435, 302)
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
        Me.lblFirstVariables.Location = New System.Drawing.Point(435, 98)
        Me.lblFirstVariables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(124, 20)
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
        Me.grpSummaries.Location = New System.Drawing.Point(15, 380)
        Me.grpSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSummaries.Size = New System.Drawing.Size(315, 108)
        Me.grpSummaries.TabIndex = 15
        Me.grpSummaries.TabStop = False
        '
        'ucrInputCategoricalByCategorical
        '
        Me.ucrInputCategoricalByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategoricalByCategorical.GetSetSelectedIndex = -1
        Me.ucrInputCategoricalByCategorical.IsReadOnly = False
        Me.ucrInputCategoricalByCategorical.Location = New System.Drawing.Point(90, 58)
        Me.ucrInputCategoricalByCategorical.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCategoricalByCategorical.Name = "ucrInputCategoricalByCategorical"
        Me.ucrInputCategoricalByCategorical.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputCategoricalByCategorical.TabIndex = 17
        '
        'ucrInputCategoricalByNumeric
        '
        Me.ucrInputCategoricalByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategoricalByNumeric.GetSetSelectedIndex = -1
        Me.ucrInputCategoricalByNumeric.IsReadOnly = False
        Me.ucrInputCategoricalByNumeric.Location = New System.Drawing.Point(90, 60)
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
        Me.ucrInputNumericByCategorical.Location = New System.Drawing.Point(90, 60)
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
        Me.ucrInputNumericByNumeric.Location = New System.Drawing.Point(90, 60)
        Me.ucrInputNumericByNumeric.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputNumericByNumeric.Name = "ucrInputNumericByNumeric"
        Me.ucrInputNumericByNumeric.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputNumericByNumeric.TabIndex = 14
        '
        'lblFirstType
        '
        Me.lblFirstType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFirstType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstType.Location = New System.Drawing.Point(9, 24)
        Me.lblFirstType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstType.Name = "lblFirstType"
        Me.lblFirstType.Size = New System.Drawing.Size(82, 20)
        Me.lblFirstType.TabIndex = 10
        Me.lblFirstType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGraphName
        '
        Me.lblGraphName.AutoSize = True
        Me.lblGraphName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraphName.Location = New System.Drawing.Point(90, 64)
        Me.lblGraphName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGraphName.Name = "lblGraphName"
        Me.lblGraphName.Size = New System.Drawing.Size(0, 20)
        Me.lblGraphName.TabIndex = 13
        '
        'lblGraph
        '
        Me.lblGraph.AutoSize = True
        Me.lblGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraph.Location = New System.Drawing.Point(9, 64)
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
        Me.lblBy.Location = New System.Drawing.Point(96, 24)
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
        Me.lblSecondType.Location = New System.Drawing.Point(123, 24)
        Me.lblSecondType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondType.Name = "lblSecondType"
        Me.lblSecondType.Size = New System.Drawing.Size(0, 20)
        Me.lblSecondType.TabIndex = 12
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
        Me.grpTypeOfDispaly.Location = New System.Drawing.Point(28, 664)
        Me.grpTypeOfDispaly.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTypeOfDispaly.Name = "grpTypeOfDispaly"
        Me.grpTypeOfDispaly.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTypeOfDispaly.Size = New System.Drawing.Size(633, 226)
        Me.grpTypeOfDispaly.TabIndex = 22
        Me.grpTypeOfDispaly.TabStop = False
        Me.grpTypeOfDispaly.Text = "Type Of Dispaly"
        '
        'lblDiagonalNA
        '
        Me.lblDiagonalNA.AutoSize = True
        Me.lblDiagonalNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalNA.Location = New System.Drawing.Point(228, 158)
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
        Me.ucrInputDiagonalNA.Location = New System.Drawing.Point(324, 150)
        Me.ucrInputDiagonalNA.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDiagonalNA.Name = "ucrInputDiagonalNA"
        Me.ucrInputDiagonalNA.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputDiagonalNA.TabIndex = 39
        '
        'lblDiagonalDiscrete
        '
        Me.lblDiagonalDiscrete.AutoSize = True
        Me.lblDiagonalDiscrete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalDiscrete.Location = New System.Drawing.Point(225, 116)
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
        Me.ucrInputDiagonalDiscrete.Location = New System.Drawing.Point(324, 110)
        Me.ucrInputDiagonalDiscrete.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDiagonalDiscrete.Name = "ucrInputDiagonalDiscrete"
        Me.ucrInputDiagonalDiscrete.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputDiagonalDiscrete.TabIndex = 37
        '
        'lblDiagonalContinuous
        '
        Me.lblDiagonalContinuous.AutoSize = True
        Me.lblDiagonalContinuous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiagonalContinuous.Location = New System.Drawing.Point(224, 75)
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
        Me.ucrInputDiagonalContinous.Location = New System.Drawing.Point(324, 69)
        Me.ucrInputDiagonalContinous.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDiagonalContinous.Name = "ucrInputDiagonalContinous"
        Me.ucrInputDiagonalContinous.Size = New System.Drawing.Size(92, 32)
        Me.ucrInputDiagonalContinous.TabIndex = 35
        '
        'lblUpperNA
        '
        Me.lblUpperNA.AutoSize = True
        Me.lblUpperNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperNA.Location = New System.Drawing.Point(438, 196)
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
        Me.lblUpperDiscrete.Location = New System.Drawing.Point(435, 156)
        Me.lblUpperDiscrete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpperDiscrete.Name = "lblUpperDiscrete"
        Me.lblUpperDiscrete.Size = New System.Drawing.Size(72, 20)
        Me.lblUpperDiscrete.TabIndex = 33
        Me.lblUpperDiscrete.Text = "Discrete:"
        '
        'lblUpperCombo
        '
        Me.lblUpperCombo.AutoSize = True
        Me.lblUpperCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUpperCombo.Location = New System.Drawing.Point(435, 116)
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
        Me.lblUpperContinous.Location = New System.Drawing.Point(435, 75)
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
        Me.ucrInputUpperNA.Location = New System.Drawing.Point(536, 190)
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
        Me.ucrInputUpperDiscrete.Location = New System.Drawing.Point(536, 150)
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
        Me.ucrInputUpperCombo.Location = New System.Drawing.Point(536, 110)
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
        Me.ucrInputUpperContinous.Location = New System.Drawing.Point(536, 69)
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
        Me.ucrChkDiagonal.Location = New System.Drawing.Point(231, 26)
        Me.ucrChkDiagonal.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDiagonal.Name = "ucrChkDiagonal"
        Me.ucrChkDiagonal.Size = New System.Drawing.Size(150, 51)
        Me.ucrChkDiagonal.TabIndex = 2
        '
        'ucrChkLower
        '
        Me.ucrChkLower.AutoSize = True
        Me.ucrChkLower.Checked = False
        Me.ucrChkLower.Location = New System.Drawing.Point(9, 26)
        Me.ucrChkLower.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLower.Name = "ucrChkLower"
        Me.ucrChkLower.Size = New System.Drawing.Size(150, 51)
        Me.ucrChkLower.TabIndex = 1
        '
        'ucrChkUpper
        '
        Me.ucrChkUpper.AutoSize = True
        Me.ucrChkUpper.Checked = False
        Me.ucrChkUpper.Location = New System.Drawing.Point(444, 26)
        Me.ucrChkUpper.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkUpper.Name = "ucrChkUpper"
        Me.ucrChkUpper.Size = New System.Drawing.Size(180, 51)
        Me.ucrChkUpper.TabIndex = 0
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
        Me.grpOptions.Location = New System.Drawing.Point(382, 426)
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
        Me.lblPosition.Location = New System.Drawing.Point(6, 98)
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
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(9, 33)
        Me.ucrChkFlipCoordinates.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(238, 51)
        Me.ucrChkFlipCoordinates.TabIndex = 6
        '
        'ucrChkFreeScaleYAxis
        '
        Me.ucrChkFreeScaleYAxis.AutoSize = True
        Me.ucrChkFreeScaleYAxis.Checked = False
        Me.ucrChkFreeScaleYAxis.Location = New System.Drawing.Point(9, 62)
        Me.ucrChkFreeScaleYAxis.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFreeScaleYAxis.Name = "ucrChkFreeScaleYAxis"
        Me.ucrChkFreeScaleYAxis.Size = New System.Drawing.Size(238, 51)
        Me.ucrChkFreeScaleYAxis.TabIndex = 7
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(81, 94)
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
        Me.rdoPairs.Location = New System.Drawing.Point(114, 14)
        Me.rdoPairs.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPairs.Name = "rdoPairs"
        Me.rdoPairs.Size = New System.Drawing.Size(194, 40)
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
        Me.rdoBy.Location = New System.Drawing.Point(304, 14)
        Me.rdoBy.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBy.Name = "rdoBy"
        Me.rdoBy.Size = New System.Drawing.Size(194, 40)
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
        Me.lblColour.Location = New System.Drawing.Point(435, 302)
        Me.lblColour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(132, 20)
        Me.lblColour.TabIndex = 20
        Me.lblColour.Text = "Colour (Optional):"
        '
        'ucrReceiverColour
        '
        Me.ucrReceiverColour.AutoSize = True
        Me.ucrReceiverColour.frmParent = Me
        Me.ucrReceiverColour.Location = New System.Drawing.Point(435, 324)
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
        Me.ucrPnlByPairs.Location = New System.Drawing.Point(110, 8)
        Me.ucrPnlByPairs.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlByPairs.Name = "ucrPnlByPairs"
        Me.ucrPnlByPairs.Size = New System.Drawing.Size(414, 46)
        Me.ucrPnlByPairs.TabIndex = 17
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(15, 650)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(508, 36)
        Me.ucrSaveGraph.TabIndex = 7
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.AutoSize = True
        Me.ucrReceiverSecondVar.frmParent = Me
        Me.ucrReceiverSecondVar.Location = New System.Drawing.Point(435, 324)
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
        Me.ucrSelectorTwoVarGraph.Location = New System.Drawing.Point(15, 62)
        Me.ucrSelectorTwoVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoVarGraph.Name = "ucrSelectorTwoVarGraph"
        Me.ucrSelectorTwoVarGraph.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorTwoVarGraph.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 690)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.AutoSize = True
        Me.ucrReceiverFirstVars.frmParent = Me
        Me.ucrReceiverFirstVars.Location = New System.Drawing.Point(435, 75)
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
        Me.ucrInputLabelSize.Location = New System.Drawing.Point(519, 614)
        Me.ucrInputLabelSize.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLabelSize.Name = "ucrInputLabelSize"
        Me.ucrInputLabelSize.Size = New System.Drawing.Size(86, 32)
        Me.ucrInputLabelSize.TabIndex = 65
        '
        'lblLabelColour
        '
        Me.lblLabelColour.AutoSize = True
        Me.lblLabelColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelColour.Location = New System.Drawing.Point(315, 618)
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
        Me.lblLabelSize.Location = New System.Drawing.Point(470, 618)
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
        Me.ucrInputLabelPosition.Location = New System.Drawing.Point(226, 614)
        Me.ucrInputLabelPosition.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLabelPosition.Name = "ucrInputLabelPosition"
        Me.ucrInputLabelPosition.Size = New System.Drawing.Size(86, 32)
        Me.ucrInputLabelPosition.TabIndex = 60
        '
        'ucrChkAddLabelsText
        '
        Me.ucrChkAddLabelsText.AutoSize = True
        Me.ucrChkAddLabelsText.Checked = False
        Me.ucrChkAddLabelsText.Location = New System.Drawing.Point(15, 614)
        Me.ucrChkAddLabelsText.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAddLabelsText.Name = "ucrChkAddLabelsText"
        Me.ucrChkAddLabelsText.Size = New System.Drawing.Size(132, 34)
        Me.ucrChkAddLabelsText.TabIndex = 62
        '
        'lblLabelPosition
        '
        Me.lblLabelPosition.AutoSize = True
        Me.lblLabelPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelPosition.Location = New System.Drawing.Point(152, 618)
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
        Me.ucrInputLabelColour.Location = New System.Drawing.Point(378, 614)
        Me.ucrInputLabelColour.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLabelColour.Name = "ucrInputLabelColour"
        Me.ucrInputLabelColour.Size = New System.Drawing.Size(86, 32)
        Me.ucrInputLabelColour.TabIndex = 63
        '
        'cmdPairOptions
        '
        Me.cmdPairOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPairOptions.Location = New System.Drawing.Point(16, 339)
        Me.cmdPairOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPairOptions.Name = "cmdPairOptions"
        Me.cmdPairOptions.Size = New System.Drawing.Size(206, 36)
        Me.cmdPairOptions.TabIndex = 66
        Me.cmdPairOptions.Tag = "Options..."
        Me.cmdPairOptions.Text = "Pair Plot Options"
        Me.cmdPairOptions.UseVisualStyleBackColor = True
        '
        'ucrChkXSidePlot
        '
        Me.ucrChkXSidePlot.AutoSize = True
        Me.ucrChkXSidePlot.Checked = False
        Me.ucrChkXSidePlot.Location = New System.Drawing.Point(16, 558)
        Me.ucrChkXSidePlot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkXSidePlot.Name = "ucrChkXSidePlot"
        Me.ucrChkXSidePlot.Size = New System.Drawing.Size(142, 34)
        Me.ucrChkXSidePlot.TabIndex = 67
        '
        'ucrChkYSidePlot
        '
        Me.ucrChkYSidePlot.AutoSize = True
        Me.ucrChkYSidePlot.Checked = False
        Me.ucrChkYSidePlot.Location = New System.Drawing.Point(15, 508)
        Me.ucrChkYSidePlot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkYSidePlot.Name = "ucrChkYSidePlot"
        Me.ucrChkYSidePlot.Size = New System.Drawing.Size(143, 34)
        Me.ucrChkYSidePlot.TabIndex = 70
        '
        'ucrRecieverFill
        '
        Me.ucrRecieverFill.AutoSize = True
        Me.ucrRecieverFill.frmParent = Me
        Me.ucrRecieverFill.Location = New System.Drawing.Point(435, 392)
        Me.ucrRecieverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRecieverFill.Name = "ucrRecieverFill"
        Me.ucrRecieverFill.Selector = Nothing
        Me.ucrRecieverFill.Size = New System.Drawing.Size(180, 30)
        Me.ucrRecieverFill.strNcFilePath = ""
        Me.ucrRecieverFill.TabIndex = 73
        Me.ucrRecieverFill.ucrSelector = Nothing
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFill.Location = New System.Drawing.Point(440, 368)
        Me.lblFill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(143, 20)
        Me.lblFill.TabIndex = 74
        Me.lblFill.Text = "Fill (Third Variable):"
        '
        'ucrInputXSidePlotOptions
        '
        Me.ucrInputXSidePlotOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputXSidePlotOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputXSidePlotOptions.GetSetSelectedIndex = -1
        Me.ucrInputXSidePlotOptions.IsReadOnly = False
        Me.ucrInputXSidePlotOptions.Location = New System.Drawing.Point(152, 557)
        Me.ucrInputXSidePlotOptions.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputXSidePlotOptions.Name = "ucrInputXSidePlotOptions"
        Me.ucrInputXSidePlotOptions.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputXSidePlotOptions.TabIndex = 75
        '
        'ucrInputYSidePlotOptions
        '
        Me.ucrInputYSidePlotOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputYSidePlotOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputYSidePlotOptions.GetSetSelectedIndex = -1
        Me.ucrInputYSidePlotOptions.IsReadOnly = False
        Me.ucrInputYSidePlotOptions.Location = New System.Drawing.Point(152, 509)
        Me.ucrInputYSidePlotOptions.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputYSidePlotOptions.Name = "ucrInputYSidePlotOptions"
        Me.ucrInputYSidePlotOptions.Size = New System.Drawing.Size(216, 32)
        Me.ucrInputYSidePlotOptions.TabIndex = 76
        '
        'dlgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(657, 774)
        Me.Controls.Add(Me.grpTypeOfDispaly)
        Me.Controls.Add(Me.ucrInputYSidePlotOptions)
        Me.Controls.Add(Me.ucrInputXSidePlotOptions)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrRecieverFill)
        Me.Controls.Add(Me.ucrChkYSidePlot)
        Me.Controls.Add(Me.ucrChkXSidePlot)
        Me.Controls.Add(Me.ucrInputLabelSize)
        Me.Controls.Add(Me.lblLabelColour)
        Me.Controls.Add(Me.lblLabelSize)
        Me.Controls.Add(Me.ucrInputLabelPosition)
        Me.Controls.Add(Me.ucrChkAddLabelsText)
        Me.Controls.Add(Me.lblLabelPosition)
        Me.Controls.Add(Me.ucrInputLabelColour)
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
        Me.Controls.Add(Me.cmdPairOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVarGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Two Plus Variable Graph"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.grpTypeOfDispaly.ResumeLayout(False)
        Me.grpTypeOfDispaly.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
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
    Friend WithEvents cmdPairOptions As Button
    Friend WithEvents ucrChkXSidePlot As ucrCheck
    Friend WithEvents ucrChkYSidePlot As ucrCheck
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrRecieverFill As ucrReceiverSingle
    Friend WithEvents ucrInputYSidePlotOptions As ucrInputComboBox
    Friend WithEvents ucrInputXSidePlotOptions As ucrInputComboBox
End Class