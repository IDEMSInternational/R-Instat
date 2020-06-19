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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDescribeTwoVarGraph))
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
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSecondVariable
        '
        resources.ApplyResources(Me.lblSecondVariable, "lblSecondVariable")
        Me.lblSecondVariable.Name = "lblSecondVariable"
        '
        'lblFirstVariables
        '
        resources.ApplyResources(Me.lblFirstVariables, "lblFirstVariables")
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Tag = "First_Variable(s)"
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
        resources.ApplyResources(Me.grpSummaries, "grpSummaries")
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.TabStop = False
        '
        'ucrInputCategoricalByCategorical
        '
        Me.ucrInputCategoricalByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByCategorical.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCategoricalByCategorical, "ucrInputCategoricalByCategorical")
        Me.ucrInputCategoricalByCategorical.Name = "ucrInputCategoricalByCategorical"
        '
        'ucrInputCategoricalByNumeric
        '
        Me.ucrInputCategoricalByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoricalByNumeric.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCategoricalByNumeric, "ucrInputCategoricalByNumeric")
        Me.ucrInputCategoricalByNumeric.Name = "ucrInputCategoricalByNumeric"
        '
        'ucrInputNumericByCategorical
        '
        Me.ucrInputNumericByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputNumericByCategorical.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNumericByCategorical, "ucrInputNumericByCategorical")
        Me.ucrInputNumericByCategorical.Name = "ucrInputNumericByCategorical"
        '
        'ucrInputNumericByNumeric
        '
        Me.ucrInputNumericByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputNumericByNumeric.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNumericByNumeric, "ucrInputNumericByNumeric")
        Me.ucrInputNumericByNumeric.Name = "ucrInputNumericByNumeric"
        '
        'lblFirstType
        '
        Me.lblFirstType.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.lblFirstType, "lblFirstType")
        Me.lblFirstType.Name = "lblFirstType"
        '
        'lblGraphName
        '
        resources.ApplyResources(Me.lblGraphName, "lblGraphName")
        Me.lblGraphName.Name = "lblGraphName"
        '
        'lblGraph
        '
        resources.ApplyResources(Me.lblGraph, "lblGraph")
        Me.lblGraph.Name = "lblGraph"
        '
        'lblBy
        '
        resources.ApplyResources(Me.lblBy, "lblBy")
        Me.lblBy.Name = "lblBy"
        '
        'lblSecondType
        '
        resources.ApplyResources(Me.lblSecondType, "lblSecondType")
        Me.lblSecondType.Name = "lblSecondType"
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
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPosition, "ucrInputPosition")
        Me.ucrInputPosition.Name = "ucrInputPosition"
        '
        'lblPosition
        '
        resources.ApplyResources(Me.lblPosition, "lblPosition")
        Me.lblPosition.Name = "lblPosition"
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTransparency, "ucrNudTransparency")
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJitter
        '
        Me.ucrNudJitter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudJitter, "ucrNudJitter")
        Me.ucrNudJitter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJitter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Name = "ucrNudJitter"
        Me.ucrNudJitter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPointTransparency
        '
        resources.ApplyResources(Me.lblPointTransparency, "lblPointTransparency")
        Me.lblPointTransparency.Name = "lblPointTransparency"
        '
        'lblPointJitter
        '
        resources.ApplyResources(Me.lblPointJitter, "lblPointJitter")
        Me.lblPointJitter.Name = "lblPointJitter"
        '
        'ucrChkFreeScaleYAxis
        '
        Me.ucrChkFreeScaleYAxis.Checked = False
        resources.ApplyResources(Me.ucrChkFreeScaleYAxis, "ucrChkFreeScaleYAxis")
        Me.ucrChkFreeScaleYAxis.Name = "ucrChkFreeScaleYAxis"
        '
        'ucrFlipCoordinates
        '
        Me.ucrFlipCoordinates.Checked = False
        resources.ApplyResources(Me.ucrFlipCoordinates, "ucrFlipCoordinates")
        Me.ucrFlipCoordinates.Name = "ucrFlipCoordinates"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSecondVar, "ucrReceiverSecondVar")
        Me.ucrReceiverSecondVar.Name = "ucrReceiverSecondVar"
        Me.ucrReceiverSecondVar.Selector = Nothing
        Me.ucrReceiverSecondVar.strNcFilePath = ""
        Me.ucrReceiverSecondVar.ucrSelector = Nothing
        '
        'ucrSelectorTwoVarGraph
        '
        Me.ucrSelectorTwoVarGraph.bDropUnusedFilterLevels = False
        Me.ucrSelectorTwoVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorTwoVarGraph.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTwoVarGraph, "ucrSelectorTwoVarGraph")
        Me.ucrSelectorTwoVarGraph.Name = "ucrSelectorTwoVarGraph"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirstVars, "ucrReceiverFirstVars")
        Me.ucrReceiverFirstVars.Name = "ucrReceiverFirstVars"
        Me.ucrReceiverFirstVars.Selector = Nothing
        Me.ucrReceiverFirstVars.strNcFilePath = ""
        Me.ucrReceiverFirstVars.ucrSelector = Nothing
        Me.ucrReceiverFirstVars.ucrVariableSelector = Nothing
        '
        'dlgDescribeTwoVarGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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