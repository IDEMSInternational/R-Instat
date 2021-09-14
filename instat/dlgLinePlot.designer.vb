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
Partial Class dlgLinePlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLinePlot))
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdLinePathStepSmoothOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblGroupLine = New System.Windows.Forms.Label()
        Me.rdoPath = New System.Windows.Forms.RadioButton()
        Me.rdoStep = New System.Windows.Forms.RadioButton()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.rdoSmoothing = New System.Windows.Forms.RadioButton()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.ucrChkSpan = New instat.ucrCheck()
        Me.ucrChkFormula = New instat.ucrCheck()
        Me.ucrInputFormula = New instat.ucrInputComboBox()
        Me.ucrFamilyInput = New instat.ucrInputComboBox()
        Me.ucrNudSpan = New instat.ucrNud()
        Me.ucrChkAddLine = New instat.ucrCheck()
        Me.ucrChkAddPoints = New instat.ucrCheck()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrChkAddSE = New instat.ucrCheck()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrPnlStepOrPath = New instat.UcrPanel()
        Me.ucrChkPathOrStep = New instat.ucrCheck()
        Me.ucrChkValley = New instat.ucrCheck()
        Me.ucrChkPeak = New instat.ucrCheck()
        Me.ucrReceiverGroup = New instat.ucrReceiverSingle()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrVariablesAsFactorForLinePlot = New instat.ucrVariablesAsFactor()
        Me.ucrLinePlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.grpSmoothOptions = New System.Windows.Forms.GroupBox()
        Me.grpSmoothOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'lblAvailable
        '
        resources.ApplyResources(Me.lblAvailable, "lblAvailable")
        Me.lblAvailable.Name = "lblAvailable"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdLinePathStepSmoothOptions
        '
        resources.ApplyResources(Me.cmdLinePathStepSmoothOptions, "cmdLinePathStepSmoothOptions")
        Me.cmdLinePathStepSmoothOptions.Name = "cmdLinePathStepSmoothOptions"
        Me.cmdLinePathStepSmoothOptions.Tag = "Line_Options"
        Me.cmdLinePathStepSmoothOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        resources.ApplyResources(Me.lblFactorOptional, "lblFactorOptional")
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        '
        'lblGroupLine
        '
        resources.ApplyResources(Me.lblGroupLine, "lblGroupLine")
        Me.lblGroupLine.Name = "lblGroupLine"
        '
        'rdoPath
        '
        resources.ApplyResources(Me.rdoPath, "rdoPath")
        Me.rdoPath.Name = "rdoPath"
        Me.rdoPath.TabStop = True
        Me.rdoPath.UseVisualStyleBackColor = True
        '
        'rdoStep
        '
        resources.ApplyResources(Me.rdoStep, "rdoStep")
        Me.rdoStep.Name = "rdoStep"
        Me.rdoStep.TabStop = True
        Me.rdoStep.UseVisualStyleBackColor = True
        '
        'rdoLine
        '
        resources.ApplyResources(Me.rdoLine, "rdoLine")
        Me.rdoLine.BackColor = System.Drawing.SystemColors.Control
        Me.rdoLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLine.FlatAppearance.BorderSize = 2
        Me.rdoLine.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.TabStop = True
        Me.rdoLine.Tag = "linepathstep"
        Me.rdoLine.UseVisualStyleBackColor = False
        '
        'rdoSmoothing
        '
        resources.ApplyResources(Me.rdoSmoothing, "rdoSmoothing")
        Me.rdoSmoothing.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSmoothing.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSmoothing.FlatAppearance.BorderSize = 2
        Me.rdoSmoothing.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSmoothing.Name = "rdoSmoothing"
        Me.rdoSmoothing.TabStop = True
        Me.rdoSmoothing.Tag = "Smooth"
        Me.rdoSmoothing.UseVisualStyleBackColor = False
        '
        'lblMethod
        '
        resources.ApplyResources(Me.lblMethod, "lblMethod")
        Me.lblMethod.Name = "lblMethod"
        '
        'lblFamily
        '
        resources.ApplyResources(Me.lblFamily, "lblFamily")
        Me.lblFamily.Name = "lblFamily"
        '
        'ucrChkSpan
        '
        Me.ucrChkSpan.Checked = False
        resources.ApplyResources(Me.ucrChkSpan, "ucrChkSpan")
        Me.ucrChkSpan.Name = "ucrChkSpan"
        '
        'ucrChkFormula
        '
        Me.ucrChkFormula.Checked = False
        resources.ApplyResources(Me.ucrChkFormula, "ucrChkFormula")
        Me.ucrChkFormula.Name = "ucrChkFormula"
        '
        'ucrInputFormula
        '
        Me.ucrInputFormula.AddQuotesIfUnrecognised = True
        Me.ucrInputFormula.GetSetSelectedIndex = -1
        Me.ucrInputFormula.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFormula, "ucrInputFormula")
        Me.ucrInputFormula.Name = "ucrInputFormula"
        '
        'ucrFamilyInput
        '
        Me.ucrFamilyInput.AddQuotesIfUnrecognised = True
        Me.ucrFamilyInput.GetSetSelectedIndex = -1
        Me.ucrFamilyInput.IsReadOnly = False
        resources.ApplyResources(Me.ucrFamilyInput, "ucrFamilyInput")
        Me.ucrFamilyInput.Name = "ucrFamilyInput"
        '
        'ucrNudSpan
        '
        Me.ucrNudSpan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSpan, "ucrNudSpan")
        Me.ucrNudSpan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSpan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Name = "ucrNudSpan"
        Me.ucrNudSpan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkAddLine
        '
        Me.ucrChkAddLine.Checked = False
        resources.ApplyResources(Me.ucrChkAddLine, "ucrChkAddLine")
        Me.ucrChkAddLine.Name = "ucrChkAddLine"
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.Checked = False
        resources.ApplyResources(Me.ucrChkAddPoints, "ucrChkAddPoints")
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMethod, "ucrInputMethod")
        Me.ucrInputMethod.Name = "ucrInputMethod"
        '
        'ucrChkAddSE
        '
        Me.ucrChkAddSE.Checked = False
        resources.ApplyResources(Me.ucrChkAddSE, "ucrChkAddSE")
        Me.ucrChkAddSE.Name = "ucrChkAddSE"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrPnlStepOrPath
        '
        resources.ApplyResources(Me.ucrPnlStepOrPath, "ucrPnlStepOrPath")
        Me.ucrPnlStepOrPath.Name = "ucrPnlStepOrPath"
        '
        'ucrChkPathOrStep
        '
        Me.ucrChkPathOrStep.Checked = False
        resources.ApplyResources(Me.ucrChkPathOrStep, "ucrChkPathOrStep")
        Me.ucrChkPathOrStep.Name = "ucrChkPathOrStep"
        '
        'ucrChkValley
        '
        Me.ucrChkValley.Checked = False
        resources.ApplyResources(Me.ucrChkValley, "ucrChkValley")
        Me.ucrChkValley.Name = "ucrChkValley"
        '
        'ucrChkPeak
        '
        Me.ucrChkPeak.Checked = False
        resources.ApplyResources(Me.ucrChkPeak, "ucrChkPeak")
        Me.ucrChkPeak.Name = "ucrChkPeak"
        '
        'ucrReceiverGroup
        '
        Me.ucrReceiverGroup.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverGroup, "ucrReceiverGroup")
        Me.ucrReceiverGroup.Name = "ucrReceiverGroup"
        Me.ucrReceiverGroup.Selector = Nothing
        Me.ucrReceiverGroup.strNcFilePath = ""
        Me.ucrReceiverGroup.ucrSelector = Nothing
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.Checked = False
        resources.ApplyResources(Me.ucrChkWithSE, "ucrChkWithSE")
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.Checked = False
        resources.ApplyResources(Me.ucrChkLineofBestFit, "ucrChkLineofBestFit")
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        '
        'ucrSave
        '
        resources.ApplyResources(Me.ucrSave, "ucrSave")
        Me.ucrSave.Name = "ucrSave"
        '
        'ucrVariablesAsFactorForLinePlot
        '
        Me.ucrVariablesAsFactorForLinePlot.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForLinePlot, "ucrVariablesAsFactorForLinePlot")
        Me.ucrVariablesAsFactorForLinePlot.Name = "ucrVariablesAsFactorForLinePlot"
        Me.ucrVariablesAsFactorForLinePlot.Selector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForLinePlot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.ucrVariableSelector = Nothing
        '
        'ucrLinePlotSelector
        '
        Me.ucrLinePlotSelector.bDropUnusedFilterLevels = False
        Me.ucrLinePlotSelector.bShowHiddenColumns = False
        Me.ucrLinePlotSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrLinePlotSelector, "ucrLinePlotSelector")
        Me.ucrLinePlotSelector.Name = "ucrLinePlotSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorOptionalReceiver, "ucrFactorOptionalReceiver")
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'grpSmoothOptions
        '
        Me.grpSmoothOptions.Controls.Add(Me.ucrInputFormula)
        Me.grpSmoothOptions.Controls.Add(Me.ucrChkSpan)
        Me.grpSmoothOptions.Controls.Add(Me.ucrChkFormula)
        Me.grpSmoothOptions.Controls.Add(Me.ucrChkAddSE)
        Me.grpSmoothOptions.Controls.Add(Me.ucrNudSpan)
        Me.grpSmoothOptions.Controls.Add(Me.lblFamily)
        Me.grpSmoothOptions.Controls.Add(Me.ucrInputMethod)
        Me.grpSmoothOptions.Controls.Add(Me.ucrFamilyInput)
        Me.grpSmoothOptions.Controls.Add(Me.lblMethod)
        resources.ApplyResources(Me.grpSmoothOptions, "grpSmoothOptions")
        Me.grpSmoothOptions.Name = "grpSmoothOptions"
        Me.grpSmoothOptions.TabStop = False
        '
        'dlgLinePlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpSmoothOptions)
        Me.Controls.Add(Me.ucrChkAddLine)
        Me.Controls.Add(Me.ucrChkAddPoints)
        Me.Controls.Add(Me.rdoSmoothing)
        Me.Controls.Add(Me.rdoLine)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.rdoStep)
        Me.Controls.Add(Me.rdoPath)
        Me.Controls.Add(Me.ucrPnlStepOrPath)
        Me.Controls.Add(Me.ucrChkPathOrStep)
        Me.Controls.Add(Me.lblGroupLine)
        Me.Controls.Add(Me.ucrChkValley)
        Me.Controls.Add(Me.ucrChkPeak)
        Me.Controls.Add(Me.ucrReceiverGroup)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrVariablesAsFactorForLinePlot)
        Me.Controls.Add(Me.cmdLinePathStepSmoothOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrLinePlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.lblAvailable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLinePlot"
        Me.Tag = "Line_Plot"
        Me.grpSmoothOptions.ResumeLayout(False)
        Me.grpSmoothOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrLinePlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdLinePathStepSmoothOptions As Button
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents ucrVariablesAsFactorForLinePlot As ucrVariablesAsFactor
    Friend WithEvents ucrChkAddPoints As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents ucrReceiverGroup As ucrReceiverSingle
    Friend WithEvents ucrChkValley As ucrCheck
    Friend WithEvents ucrChkPeak As ucrCheck
    Friend WithEvents lblGroupLine As Label
    Friend WithEvents ucrChkPathOrStep As ucrCheck
    Friend WithEvents ucrPnlStepOrPath As UcrPanel
    Friend WithEvents rdoStep As RadioButton
    Friend WithEvents rdoPath As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoSmoothing As RadioButton
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents ucrChkAddLine As ucrCheck
    Friend WithEvents ucrChkAddSE As ucrCheck
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents ucrNudSpan As ucrNud
    Friend WithEvents ucrFamilyInput As ucrInputComboBox
    Friend WithEvents lblFamily As Label
    Friend WithEvents ucrInputFormula As ucrInputComboBox
    Friend WithEvents ucrChkFormula As ucrCheck
    Friend WithEvents ucrChkSpan As ucrCheck
    Friend WithEvents grpSmoothOptions As GroupBox
End Class
