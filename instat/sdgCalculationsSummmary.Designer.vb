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
Partial Class sdgCalculationsSummmary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgCalculationsSummmary))
        Me.tbSummaryCalcs = New System.Windows.Forms.TabControl()
        Me.tbMain = New System.Windows.Forms.TabPage()
        Me.ucrReceiverByOrSort = New instat.ucrReceiverMultiple()
        Me.ucrInputCalculationName = New instat.ucrInputTextBox()
        Me.lblReceiverLabel = New System.Windows.Forms.Label()
        Me.ucrInputResultName = New instat.ucrInputTextBox()
        Me.lblResultName = New System.Windows.Forms.Label()
        Me.lblCalcName = New System.Windows.Forms.Label()
        Me.rdoSaveCalcAndResult = New System.Windows.Forms.RadioButton()
        Me.rdoSaveCalculation = New System.Windows.Forms.RadioButton()
        Me.rdoDoNotSave = New System.Windows.Forms.RadioButton()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrSelectorBy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrCalcSummary = New instat.ucrCalculator()
        Me.ucrDefineFilter = New instat.ucrFilter()
        Me.ucrPnlSave = New instat.UcrPanel()
        Me.tbManipulations = New System.Windows.Forms.TabPage()
        Me.ucrManipulations = New instat.ucrReorder()
        Me.cmdManipDuplicate = New System.Windows.Forms.Button()
        Me.cmdManipDelete = New System.Windows.Forms.Button()
        Me.lblManipulations = New System.Windows.Forms.Label()
        Me.cmdManipEdit = New System.Windows.Forms.Button()
        Me.cmdManipAdd = New System.Windows.Forms.Button()
        Me.tbSubCalcs = New System.Windows.Forms.TabPage()
        Me.lstSubCalcs = New System.Windows.Forms.ListView()
        Me.cmdSubCalcDuplicate = New System.Windows.Forms.Button()
        Me.cmdSubCalcDelete = New System.Windows.Forms.Button()
        Me.cmdSubCalcAdd = New System.Windows.Forms.Button()
        Me.lblSubCalcs = New System.Windows.Forms.Label()
        Me.cmdSubCalcEdit = New System.Windows.Forms.Button()
        Me.ucrBaseSubDialog = New instat.ucrButtonsSubdialogue()
        Me.tbSummaryCalcs.SuspendLayout()
        Me.tbMain.SuspendLayout()
        Me.tbManipulations.SuspendLayout()
        Me.tbSubCalcs.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSummaryCalcs
        '
        Me.tbSummaryCalcs.Controls.Add(Me.tbMain)
        Me.tbSummaryCalcs.Controls.Add(Me.tbManipulations)
        Me.tbSummaryCalcs.Controls.Add(Me.tbSubCalcs)
        resources.ApplyResources(Me.tbSummaryCalcs, "tbSummaryCalcs")
        Me.tbSummaryCalcs.Name = "tbSummaryCalcs"
        Me.tbSummaryCalcs.SelectedIndex = 0
        '
        'tbMain
        '
        Me.tbMain.Controls.Add(Me.ucrReceiverByOrSort)
        Me.tbMain.Controls.Add(Me.ucrInputCalculationName)
        Me.tbMain.Controls.Add(Me.lblReceiverLabel)
        Me.tbMain.Controls.Add(Me.ucrInputResultName)
        Me.tbMain.Controls.Add(Me.lblResultName)
        Me.tbMain.Controls.Add(Me.lblCalcName)
        Me.tbMain.Controls.Add(Me.rdoSaveCalcAndResult)
        Me.tbMain.Controls.Add(Me.rdoSaveCalculation)
        Me.tbMain.Controls.Add(Me.rdoDoNotSave)
        Me.tbMain.Controls.Add(Me.lblType)
        Me.tbMain.Controls.Add(Me.ucrInputType)
        Me.tbMain.Controls.Add(Me.ucrSelectorBy)
        Me.tbMain.Controls.Add(Me.ucrCalcSummary)
        Me.tbMain.Controls.Add(Me.ucrDefineFilter)
        Me.tbMain.Controls.Add(Me.ucrPnlSave)
        resources.ApplyResources(Me.tbMain, "tbMain")
        Me.tbMain.Name = "tbMain"
        Me.tbMain.UseVisualStyleBackColor = True
        '
        'ucrReceiverByOrSort
        '
        Me.ucrReceiverByOrSort.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverByOrSort, "ucrReceiverByOrSort")
        Me.ucrReceiverByOrSort.Name = "ucrReceiverByOrSort"
        Me.ucrReceiverByOrSort.Selector = Nothing
        Me.ucrReceiverByOrSort.strNcFilePath = ""
        Me.ucrReceiverByOrSort.ucrSelector = Nothing
        '
        'ucrInputCalculationName
        '
        Me.ucrInputCalculationName.AddQuotesIfUnrecognised = True
        Me.ucrInputCalculationName.IsMultiline = False
        Me.ucrInputCalculationName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCalculationName, "ucrInputCalculationName")
        Me.ucrInputCalculationName.Name = "ucrInputCalculationName"
        '
        'lblReceiverLabel
        '
        resources.ApplyResources(Me.lblReceiverLabel, "lblReceiverLabel")
        Me.lblReceiverLabel.Name = "lblReceiverLabel"
        '
        'ucrInputResultName
        '
        Me.ucrInputResultName.AddQuotesIfUnrecognised = True
        Me.ucrInputResultName.IsMultiline = False
        Me.ucrInputResultName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputResultName, "ucrInputResultName")
        Me.ucrInputResultName.Name = "ucrInputResultName"
        '
        'lblResultName
        '
        resources.ApplyResources(Me.lblResultName, "lblResultName")
        Me.lblResultName.Name = "lblResultName"
        '
        'lblCalcName
        '
        resources.ApplyResources(Me.lblCalcName, "lblCalcName")
        Me.lblCalcName.Name = "lblCalcName"
        '
        'rdoSaveCalcAndResult
        '
        resources.ApplyResources(Me.rdoSaveCalcAndResult, "rdoSaveCalcAndResult")
        Me.rdoSaveCalcAndResult.Name = "rdoSaveCalcAndResult"
        Me.rdoSaveCalcAndResult.TabStop = True
        Me.rdoSaveCalcAndResult.UseVisualStyleBackColor = True
        '
        'rdoSaveCalculation
        '
        resources.ApplyResources(Me.rdoSaveCalculation, "rdoSaveCalculation")
        Me.rdoSaveCalculation.Name = "rdoSaveCalculation"
        Me.rdoSaveCalculation.TabStop = True
        Me.rdoSaveCalculation.UseVisualStyleBackColor = True
        '
        'rdoDoNotSave
        '
        resources.ApplyResources(Me.rdoDoNotSave, "rdoDoNotSave")
        Me.rdoDoNotSave.Name = "rdoDoNotSave"
        Me.rdoDoNotSave.TabStop = True
        Me.rdoDoNotSave.UseVisualStyleBackColor = True
        '
        'lblType
        '
        resources.ApplyResources(Me.lblType, "lblType")
        Me.lblType.Name = "lblType"
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputType, "ucrInputType")
        Me.ucrInputType.Name = "ucrInputType"
        '
        'ucrSelectorBy
        '
        Me.ucrSelectorBy.bShowHiddenColumns = False
        Me.ucrSelectorBy.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorBy, "ucrSelectorBy")
        Me.ucrSelectorBy.Name = "ucrSelectorBy"
        '
        'ucrCalcSummary
        '
        resources.ApplyResources(Me.ucrCalcSummary, "ucrCalcSummary")
        Me.ucrCalcSummary.Name = "ucrCalcSummary"
        '
        'ucrDefineFilter
        '
        resources.ApplyResources(Me.ucrDefineFilter, "ucrDefineFilter")
        Me.ucrDefineFilter.Name = "ucrDefineFilter"
        '
        'ucrPnlSave
        '
        resources.ApplyResources(Me.ucrPnlSave, "ucrPnlSave")
        Me.ucrPnlSave.Name = "ucrPnlSave"
        '
        'tbManipulations
        '
        Me.tbManipulations.Controls.Add(Me.ucrManipulations)
        Me.tbManipulations.Controls.Add(Me.cmdManipDuplicate)
        Me.tbManipulations.Controls.Add(Me.cmdManipDelete)
        Me.tbManipulations.Controls.Add(Me.lblManipulations)
        Me.tbManipulations.Controls.Add(Me.cmdManipEdit)
        Me.tbManipulations.Controls.Add(Me.cmdManipAdd)
        resources.ApplyResources(Me.tbManipulations, "tbManipulations")
        Me.tbManipulations.Name = "tbManipulations"
        Me.tbManipulations.UseVisualStyleBackColor = True
        '
        'ucrManipulations
        '
        resources.ApplyResources(Me.ucrManipulations, "ucrManipulations")
        Me.ucrManipulations.Name = "ucrManipulations"
        Me.ucrManipulations.ucrDataFrameList = Nothing
        Me.ucrManipulations.ucrReceiver = Nothing
        '
        'cmdManipDuplicate
        '
        resources.ApplyResources(Me.cmdManipDuplicate, "cmdManipDuplicate")
        Me.cmdManipDuplicate.Name = "cmdManipDuplicate"
        Me.cmdManipDuplicate.UseVisualStyleBackColor = True
        '
        'cmdManipDelete
        '
        resources.ApplyResources(Me.cmdManipDelete, "cmdManipDelete")
        Me.cmdManipDelete.Name = "cmdManipDelete"
        Me.cmdManipDelete.UseVisualStyleBackColor = True
        '
        'lblManipulations
        '
        resources.ApplyResources(Me.lblManipulations, "lblManipulations")
        Me.lblManipulations.Name = "lblManipulations"
        '
        'cmdManipEdit
        '
        resources.ApplyResources(Me.cmdManipEdit, "cmdManipEdit")
        Me.cmdManipEdit.Name = "cmdManipEdit"
        Me.cmdManipEdit.UseVisualStyleBackColor = True
        '
        'cmdManipAdd
        '
        resources.ApplyResources(Me.cmdManipAdd, "cmdManipAdd")
        Me.cmdManipAdd.Name = "cmdManipAdd"
        Me.cmdManipAdd.UseVisualStyleBackColor = True
        '
        'tbSubCalcs
        '
        Me.tbSubCalcs.Controls.Add(Me.lstSubCalcs)
        Me.tbSubCalcs.Controls.Add(Me.cmdSubCalcDuplicate)
        Me.tbSubCalcs.Controls.Add(Me.cmdSubCalcDelete)
        Me.tbSubCalcs.Controls.Add(Me.cmdSubCalcAdd)
        Me.tbSubCalcs.Controls.Add(Me.lblSubCalcs)
        Me.tbSubCalcs.Controls.Add(Me.cmdSubCalcEdit)
        resources.ApplyResources(Me.tbSubCalcs, "tbSubCalcs")
        Me.tbSubCalcs.Name = "tbSubCalcs"
        Me.tbSubCalcs.UseVisualStyleBackColor = True
        '
        'lstSubCalcs
        '
        resources.ApplyResources(Me.lstSubCalcs, "lstSubCalcs")
        Me.lstSubCalcs.Name = "lstSubCalcs"
        Me.lstSubCalcs.UseCompatibleStateImageBehavior = False
        Me.lstSubCalcs.View = System.Windows.Forms.View.List
        '
        'cmdSubCalcDuplicate
        '
        resources.ApplyResources(Me.cmdSubCalcDuplicate, "cmdSubCalcDuplicate")
        Me.cmdSubCalcDuplicate.Name = "cmdSubCalcDuplicate"
        Me.cmdSubCalcDuplicate.UseVisualStyleBackColor = True
        '
        'cmdSubCalcDelete
        '
        resources.ApplyResources(Me.cmdSubCalcDelete, "cmdSubCalcDelete")
        Me.cmdSubCalcDelete.Name = "cmdSubCalcDelete"
        Me.cmdSubCalcDelete.UseVisualStyleBackColor = True
        '
        'cmdSubCalcAdd
        '
        resources.ApplyResources(Me.cmdSubCalcAdd, "cmdSubCalcAdd")
        Me.cmdSubCalcAdd.Name = "cmdSubCalcAdd"
        Me.cmdSubCalcAdd.UseVisualStyleBackColor = True
        '
        'lblSubCalcs
        '
        resources.ApplyResources(Me.lblSubCalcs, "lblSubCalcs")
        Me.lblSubCalcs.Name = "lblSubCalcs"
        '
        'cmdSubCalcEdit
        '
        resources.ApplyResources(Me.cmdSubCalcEdit, "cmdSubCalcEdit")
        Me.cmdSubCalcEdit.Name = "cmdSubCalcEdit"
        Me.cmdSubCalcEdit.UseVisualStyleBackColor = True
        '
        'ucrBaseSubDialog
        '
        resources.ApplyResources(Me.ucrBaseSubDialog, "ucrBaseSubDialog")
        Me.ucrBaseSubDialog.Name = "ucrBaseSubDialog"
        '
        'sdgCalculationsSummmary
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBaseSubDialog)
        Me.Controls.Add(Me.tbSummaryCalcs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCalculationsSummmary"
        Me.tbSummaryCalcs.ResumeLayout(False)
        Me.tbMain.ResumeLayout(False)
        Me.tbMain.PerformLayout()
        Me.tbManipulations.ResumeLayout(False)
        Me.tbManipulations.PerformLayout()
        Me.tbSubCalcs.ResumeLayout(False)
        Me.tbSubCalcs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubDialog As ucrButtonsSubdialogue
    Friend WithEvents tbSummaryCalcs As TabControl
    Friend WithEvents tbMain As TabPage
    Friend WithEvents lblResultName As Label
    Friend WithEvents lblCalcName As Label
    Friend WithEvents rdoSaveCalcAndResult As RadioButton
    Friend WithEvents rdoSaveCalculation As RadioButton
    Friend WithEvents rdoDoNotSave As RadioButton
    Friend WithEvents lblType As Label
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents tbManipulations As TabPage
    Friend WithEvents tbSubCalcs As TabPage
    Friend WithEvents ucrInputResultName As ucrInputTextBox
    Friend WithEvents ucrInputCalculationName As ucrInputTextBox
    Friend WithEvents lblReceiverLabel As Label
    Friend WithEvents ucrSelectorBy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCalcSummary As ucrCalculator
    Friend WithEvents cmdManipDuplicate As Button
    Friend WithEvents cmdManipDelete As Button
    Friend WithEvents lblManipulations As Label
    Friend WithEvents cmdManipEdit As Button
    Friend WithEvents cmdManipAdd As Button
    Friend WithEvents lstSubCalcs As ListView
    Friend WithEvents ucrManipulations As ucrReorder
    Friend WithEvents cmdSubCalcDuplicate As Button
    Friend WithEvents cmdSubCalcDelete As Button
    Friend WithEvents cmdSubCalcAdd As Button
    Friend WithEvents lblSubCalcs As Label
    Friend WithEvents cmdSubCalcEdit As Button
    Friend WithEvents ucrReceiverByOrSort As ucrReceiverMultiple
    Friend WithEvents ucrDefineFilter As ucrFilter
    Friend WithEvents ucrPnlSave As UcrPanel
End Class
