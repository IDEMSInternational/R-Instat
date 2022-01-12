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
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrNudJitter = New instat.ucrNud()
        Me.lblPointTransparency = New System.Windows.Forms.Label()
        Me.lblPointJitter = New System.Windows.Forms.Label()
        Me.ucrChkFreeScaleYAxis = New instat.ucrCheck()
        Me.ucrFlipCoordinates = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverSecondVar = New instat.ucrReceiverSingle()
        Me.ucrSelectorTwoVarGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFirstVars = New instat.ucrVariablesAsFactor()
        Me.grpSummaries.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 197)
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
        Me.lblSecondVariable.Location = New System.Drawing.Point(268, 165)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(88, 13)
        Me.lblSecondVariable.TabIndex = 3
        Me.lblSecondVariable.Text = "Second Variable:"
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariables.Location = New System.Drawing.Point(268, 45)
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
        Me.grpSummaries.Location = New System.Drawing.Point(10, 221)
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
        Me.grpOptions.Controls.Add(Me.ucrInputPosition)
        Me.grpOptions.Controls.Add(Me.lblPosition)
        Me.grpOptions.Controls.Add(Me.ucrNudTransparency)
        Me.grpOptions.Controls.Add(Me.ucrNudJitter)
        Me.grpOptions.Controls.Add(Me.lblPointTransparency)
        Me.grpOptions.Controls.Add(Me.lblPointJitter)
        Me.grpOptions.Controls.Add(Me.ucrChkFreeScaleYAxis)
        Me.grpOptions.Controls.Add(Me.ucrFlipCoordinates)
        Me.grpOptions.Location = New System.Drawing.Point(236, 203)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(171, 111)
        Me.grpOptions.TabIndex = 16
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
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
        'ucrChkFreeScaleYAxis
        '
        Me.ucrChkFreeScaleYAxis.AutoSize = True
        Me.ucrChkFreeScaleYAxis.Checked = False
        Me.ucrChkFreeScaleYAxis.Location = New System.Drawing.Point(6, 41)
        Me.ucrChkFreeScaleYAxis.Name = "ucrChkFreeScaleYAxis"
        Me.ucrChkFreeScaleYAxis.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkFreeScaleYAxis.TabIndex = 7
        '
        'ucrFlipCoordinates
        '
        Me.ucrFlipCoordinates.AutoSize = True
        Me.ucrFlipCoordinates.Checked = False
        Me.ucrFlipCoordinates.Location = New System.Drawing.Point(6, 19)
        Me.ucrFlipCoordinates.Name = "ucrFlipCoordinates"
        Me.ucrFlipCoordinates.Size = New System.Drawing.Size(159, 23)
        Me.ucrFlipCoordinates.TabIndex = 6
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 319)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(339, 24)
        Me.ucrSaveGraph.TabIndex = 7
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.AutoSize = True
        Me.ucrReceiverSecondVar.frmParent = Me
        Me.ucrReceiverSecondVar.Location = New System.Drawing.Point(270, 180)
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
        Me.ucrSelectorTwoVarGraph.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorTwoVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoVarGraph.Name = "ucrSelectorTwoVarGraph"
        Me.ucrSelectorTwoVarGraph.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTwoVarGraph.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 347)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.AutoSize = True
        Me.ucrReceiverFirstVars.frmParent = Me
        Me.ucrReceiverFirstVars.Location = New System.Drawing.Point(268, 30)
        Me.ucrReceiverFirstVars.Name = "ucrReceiverFirstVars"
        Me.ucrReceiverFirstVars.Selector = Nothing
        Me.ucrReceiverFirstVars.Size = New System.Drawing.Size(120, 138)
        Me.ucrReceiverFirstVars.strNcFilePath = ""
        Me.ucrReceiverFirstVars.TabIndex = 1
        Me.ucrReceiverFirstVars.ucrSelector = Nothing
        Me.ucrReceiverFirstVars.ucrVariableSelector = Nothing
        '
        'dlgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 401)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.ucrReceiverSecondVar)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSelectorTwoVarGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverFirstVars)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVarGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Two Variable Graph"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
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
    Friend WithEvents ucrFlipCoordinates As ucrCheck
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
End Class