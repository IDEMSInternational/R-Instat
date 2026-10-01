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
        Me.tbSummaryCalcs = New System.Windows.Forms.TabControl()
        Me.tbMain = New System.Windows.Forms.TabPage()
        Me.ucrDefineFilter = New instat.ucrFilter()
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
        Me.ucrPnlSave = New instat.UcrPanel()
        Me.ucrCalcSummary = New instat.ucrCalculator()
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
        Me.tbSummaryCalcs.Location = New System.Drawing.Point(0, 0)
        Me.tbSummaryCalcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSummaryCalcs.Name = "tbSummaryCalcs"
        Me.tbSummaryCalcs.SelectedIndex = 0
        Me.tbSummaryCalcs.Size = New System.Drawing.Size(1004, 666)
        Me.tbSummaryCalcs.TabIndex = 1
        '
        'tbMain
        '
        Me.tbMain.Controls.Add(Me.ucrDefineFilter)
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
        Me.tbMain.Controls.Add(Me.ucrPnlSave)
        Me.tbMain.Controls.Add(Me.ucrCalcSummary)
        Me.tbMain.Location = New System.Drawing.Point(4, 25)
        Me.tbMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbMain.Size = New System.Drawing.Size(996, 637)
        Me.tbMain.TabIndex = 0
        Me.tbMain.Text = "Main"
        Me.tbMain.UseVisualStyleBackColor = True
        '
        'ucrDefineFilter
        '
        Me.ucrDefineFilter.AutoSize = True
        Me.ucrDefineFilter.Location = New System.Drawing.Point(10, 69)
        Me.ucrDefineFilter.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrDefineFilter.Name = "ucrDefineFilter"
        Me.ucrDefineFilter.Size = New System.Drawing.Size(962, 608)
        Me.ucrDefineFilter.TabIndex = 19
        '
        'ucrReceiverByOrSort
        '
        Me.ucrReceiverByOrSort.AutoSize = True
        Me.ucrReceiverByOrSort.frmParent = Nothing
        Me.ucrReceiverByOrSort.Location = New System.Drawing.Point(299, 179)
        Me.ucrReceiverByOrSort.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByOrSort.Name = "ucrReceiverByOrSort"
        Me.ucrReceiverByOrSort.Selector = Nothing
        Me.ucrReceiverByOrSort.Size = New System.Drawing.Size(150, 125)
        Me.ucrReceiverByOrSort.strNcFilePath = ""
        Me.ucrReceiverByOrSort.TabIndex = 18
        Me.ucrReceiverByOrSort.ucrSelector = Nothing
        '
        'ucrInputCalculationName
        '
        Me.ucrInputCalculationName.AddQuotesIfUnrecognised = True
        Me.ucrInputCalculationName.AutoSize = True
        Me.ucrInputCalculationName.IsMultiline = False
        Me.ucrInputCalculationName.IsReadOnly = False
        Me.ucrInputCalculationName.Location = New System.Drawing.Point(466, 549)
        Me.ucrInputCalculationName.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputCalculationName.Name = "ucrInputCalculationName"
        Me.ucrInputCalculationName.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputCalculationName.TabIndex = 12
        '
        'lblReceiverLabel
        '
        Me.lblReceiverLabel.AutoSize = True
        Me.lblReceiverLabel.Location = New System.Drawing.Point(295, 158)
        Me.lblReceiverLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReceiverLabel.Name = "lblReceiverLabel"
        Me.lblReceiverLabel.Size = New System.Drawing.Size(55, 16)
        Me.lblReceiverLabel.TabIndex = 15
        Me.lblReceiverLabel.Text = "Factors:"
        '
        'ucrInputResultName
        '
        Me.ucrInputResultName.AddQuotesIfUnrecognised = True
        Me.ucrInputResultName.AutoSize = True
        Me.ucrInputResultName.IsMultiline = False
        Me.ucrInputResultName.IsReadOnly = False
        Me.ucrInputResultName.Location = New System.Drawing.Point(128, 549)
        Me.ucrInputResultName.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputResultName.Name = "ucrInputResultName"
        Me.ucrInputResultName.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputResultName.TabIndex = 13
        '
        'lblResultName
        '
        Me.lblResultName.AutoSize = True
        Me.lblResultName.Location = New System.Drawing.Point(15, 552)
        Me.lblResultName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResultName.Name = "lblResultName"
        Me.lblResultName.Size = New System.Drawing.Size(88, 16)
        Me.lblResultName.TabIndex = 10
        Me.lblResultName.Text = "Result Name:"
        '
        'lblCalcName
        '
        Me.lblCalcName.AutoSize = True
        Me.lblCalcName.Location = New System.Drawing.Point(341, 552)
        Me.lblCalcName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalcName.Name = "lblCalcName"
        Me.lblCalcName.Size = New System.Drawing.Size(116, 16)
        Me.lblCalcName.TabIndex = 9
        Me.lblCalcName.Text = "Calculation Name:"
        '
        'rdoSaveCalcAndResult
        '
        Me.rdoSaveCalcAndResult.AutoSize = True
        Me.rdoSaveCalcAndResult.Location = New System.Drawing.Point(15, 595)
        Me.rdoSaveCalcAndResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSaveCalcAndResult.Name = "rdoSaveCalcAndResult"
        Me.rdoSaveCalcAndResult.Size = New System.Drawing.Size(196, 20)
        Me.rdoSaveCalcAndResult.TabIndex = 8
        Me.rdoSaveCalcAndResult.TabStop = True
        Me.rdoSaveCalcAndResult.Text = "Save Calculation and Result"
        Me.rdoSaveCalcAndResult.UseVisualStyleBackColor = True
        '
        'rdoSaveCalculation
        '
        Me.rdoSaveCalculation.AutoSize = True
        Me.rdoSaveCalculation.Location = New System.Drawing.Point(232, 595)
        Me.rdoSaveCalculation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSaveCalculation.Name = "rdoSaveCalculation"
        Me.rdoSaveCalculation.Size = New System.Drawing.Size(159, 20)
        Me.rdoSaveCalculation.TabIndex = 7
        Me.rdoSaveCalculation.TabStop = True
        Me.rdoSaveCalculation.Text = "Save Calculation Only"
        Me.rdoSaveCalculation.UseVisualStyleBackColor = True
        '
        'rdoDoNotSave
        '
        Me.rdoDoNotSave.AutoSize = True
        Me.rdoDoNotSave.Location = New System.Drawing.Point(412, 595)
        Me.rdoDoNotSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDoNotSave.Name = "rdoDoNotSave"
        Me.rdoDoNotSave.Size = New System.Drawing.Size(109, 20)
        Me.rdoDoNotSave.TabIndex = 6
        Me.rdoDoNotSave.TabStop = True
        Me.rdoDoNotSave.Text = "Save Nothing"
        Me.rdoDoNotSave.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(11, 15)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(42, 16)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Type:"
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(10, 35)
        Me.ucrInputType.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(150, 26)
        Me.ucrInputType.TabIndex = 3
        '
        'ucrSelectorBy
        '
        Me.ucrSelectorBy.AutoSize = True
        Me.ucrSelectorBy.bDropUnusedFilterLevels = False
        Me.ucrSelectorBy.bShowHiddenColumns = False
        Me.ucrSelectorBy.bUseCurrentFilter = True
        Me.ucrSelectorBy.Location = New System.Drawing.Point(10, 142)
        Me.ucrSelectorBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorBy.Name = "ucrSelectorBy"
        Me.ucrSelectorBy.Size = New System.Drawing.Size(334, 285)
        Me.ucrSelectorBy.TabIndex = 14
        '
        'ucrPnlSave
        '
        Me.ucrPnlSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSave.Location = New System.Drawing.Point(4, 582)
        Me.ucrPnlSave.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlSave.Name = "ucrPnlSave"
        Me.ucrPnlSave.Size = New System.Drawing.Size(534, 48)
        Me.ucrPnlSave.TabIndex = 20
        '
        'ucrCalcSummary
        '
        Me.ucrCalcSummary.AutoSize = True
        Me.ucrCalcSummary.Location = New System.Drawing.Point(10, 62)
        Me.ucrCalcSummary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrCalcSummary.Name = "ucrCalcSummary"
        Me.ucrCalcSummary.Size = New System.Drawing.Size(1355, 518)
        Me.ucrCalcSummary.TabIndex = 17
        '
        'tbManipulations
        '
        Me.tbManipulations.Controls.Add(Me.cmdManipDuplicate)
        Me.tbManipulations.Controls.Add(Me.cmdManipDelete)
        Me.tbManipulations.Controls.Add(Me.lblManipulations)
        Me.tbManipulations.Controls.Add(Me.cmdManipEdit)
        Me.tbManipulations.Controls.Add(Me.cmdManipAdd)
        Me.tbManipulations.Controls.Add(Me.ucrManipulations)
        Me.tbManipulations.Location = New System.Drawing.Point(4, 25)
        Me.tbManipulations.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbManipulations.Name = "tbManipulations"
        Me.tbManipulations.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbManipulations.Size = New System.Drawing.Size(996, 637)
        Me.tbManipulations.TabIndex = 1
        Me.tbManipulations.Text = "Manipulations"
        Me.tbManipulations.UseVisualStyleBackColor = True
        '
        'ucrManipulations
        '
        Me.ucrManipulations.AutoSize = True
        Me.ucrManipulations.Location = New System.Drawing.Point(8, 40)
        Me.ucrManipulations.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrManipulations.Name = "ucrManipulations"
        Me.ucrManipulations.Size = New System.Drawing.Size(375, 235)
        Me.ucrManipulations.TabIndex = 21
        Me.ucrManipulations.ucrDataFrameList = Nothing
        Me.ucrManipulations.ucrReceiver = Nothing
        '
        'cmdManipDuplicate
        '
        Me.cmdManipDuplicate.Location = New System.Drawing.Point(273, 199)
        Me.cmdManipDuplicate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdManipDuplicate.Name = "cmdManipDuplicate"
        Me.cmdManipDuplicate.Size = New System.Drawing.Size(94, 29)
        Me.cmdManipDuplicate.TabIndex = 20
        Me.cmdManipDuplicate.Text = "Duplicate"
        Me.cmdManipDuplicate.UseVisualStyleBackColor = True
        '
        'cmdManipDelete
        '
        Me.cmdManipDelete.Location = New System.Drawing.Point(273, 163)
        Me.cmdManipDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdManipDelete.Name = "cmdManipDelete"
        Me.cmdManipDelete.Size = New System.Drawing.Size(94, 29)
        Me.cmdManipDelete.TabIndex = 17
        Me.cmdManipDelete.Text = "Delete"
        Me.cmdManipDelete.UseVisualStyleBackColor = True
        '
        'lblManipulations
        '
        Me.lblManipulations.AutoSize = True
        Me.lblManipulations.Location = New System.Drawing.Point(11, 21)
        Me.lblManipulations.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManipulations.Name = "lblManipulations"
        Me.lblManipulations.Size = New System.Drawing.Size(93, 16)
        Me.lblManipulations.TabIndex = 16
        Me.lblManipulations.Text = "Manipulations:"
        '
        'cmdManipEdit
        '
        Me.cmdManipEdit.Location = New System.Drawing.Point(273, 126)
        Me.cmdManipEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdManipEdit.Name = "cmdManipEdit"
        Me.cmdManipEdit.Size = New System.Drawing.Size(94, 29)
        Me.cmdManipEdit.TabIndex = 18
        Me.cmdManipEdit.Text = "Edit"
        Me.cmdManipEdit.UseVisualStyleBackColor = True
        '
        'cmdManipAdd
        '
        Me.cmdManipAdd.Location = New System.Drawing.Point(273, 90)
        Me.cmdManipAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdManipAdd.Name = "cmdManipAdd"
        Me.cmdManipAdd.Size = New System.Drawing.Size(94, 29)
        Me.cmdManipAdd.TabIndex = 19
        Me.cmdManipAdd.Text = "Add"
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
        Me.tbSubCalcs.Location = New System.Drawing.Point(4, 25)
        Me.tbSubCalcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSubCalcs.Name = "tbSubCalcs"
        Me.tbSubCalcs.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSubCalcs.Size = New System.Drawing.Size(996, 637)
        Me.tbSubCalcs.TabIndex = 2
        Me.tbSubCalcs.Text = "Sub Calculations"
        Me.tbSubCalcs.UseVisualStyleBackColor = True
        '
        'lstSubCalcs
        '
        Me.lstSubCalcs.HideSelection = False
        Me.lstSubCalcs.Location = New System.Drawing.Point(11, 41)
        Me.lstSubCalcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstSubCalcs.Name = "lstSubCalcs"
        Me.lstSubCalcs.Size = New System.Drawing.Size(150, 165)
        Me.lstSubCalcs.TabIndex = 21
        Me.lstSubCalcs.UseCompatibleStateImageBehavior = False
        Me.lstSubCalcs.View = System.Windows.Forms.View.List
        '
        'cmdSubCalcDuplicate
        '
        Me.cmdSubCalcDuplicate.Location = New System.Drawing.Point(208, 165)
        Me.cmdSubCalcDuplicate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSubCalcDuplicate.Name = "cmdSubCalcDuplicate"
        Me.cmdSubCalcDuplicate.Size = New System.Drawing.Size(94, 29)
        Me.cmdSubCalcDuplicate.TabIndex = 26
        Me.cmdSubCalcDuplicate.Text = "Duplicate"
        Me.cmdSubCalcDuplicate.UseVisualStyleBackColor = True
        '
        'cmdSubCalcDelete
        '
        Me.cmdSubCalcDelete.Location = New System.Drawing.Point(208, 129)
        Me.cmdSubCalcDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSubCalcDelete.Name = "cmdSubCalcDelete"
        Me.cmdSubCalcDelete.Size = New System.Drawing.Size(94, 29)
        Me.cmdSubCalcDelete.TabIndex = 23
        Me.cmdSubCalcDelete.Text = "Delete"
        Me.cmdSubCalcDelete.UseVisualStyleBackColor = True
        '
        'cmdSubCalcAdd
        '
        Me.cmdSubCalcAdd.Location = New System.Drawing.Point(208, 56)
        Me.cmdSubCalcAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSubCalcAdd.Name = "cmdSubCalcAdd"
        Me.cmdSubCalcAdd.Size = New System.Drawing.Size(94, 29)
        Me.cmdSubCalcAdd.TabIndex = 25
        Me.cmdSubCalcAdd.Text = "Add"
        Me.cmdSubCalcAdd.UseVisualStyleBackColor = True
        '
        'lblSubCalcs
        '
        Me.lblSubCalcs.AutoSize = True
        Me.lblSubCalcs.Location = New System.Drawing.Point(11, 21)
        Me.lblSubCalcs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubCalcs.Name = "lblSubCalcs"
        Me.lblSubCalcs.Size = New System.Drawing.Size(111, 16)
        Me.lblSubCalcs.TabIndex = 22
        Me.lblSubCalcs.Text = "Sub-Calculations:"
        '
        'cmdSubCalcEdit
        '
        Me.cmdSubCalcEdit.Location = New System.Drawing.Point(208, 92)
        Me.cmdSubCalcEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSubCalcEdit.Name = "cmdSubCalcEdit"
        Me.cmdSubCalcEdit.Size = New System.Drawing.Size(94, 29)
        Me.cmdSubCalcEdit.TabIndex = 24
        Me.cmdSubCalcEdit.Text = "Edit"
        Me.cmdSubCalcEdit.UseVisualStyleBackColor = True
        '
        'ucrBaseSubDialog
        '
        Me.ucrBaseSubDialog.AutoSize = True
        Me.ucrBaseSubDialog.Location = New System.Drawing.Point(384, 666)
        Me.ucrBaseSubDialog.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBaseSubDialog.Name = "ucrBaseSubDialog"
        Me.ucrBaseSubDialog.Size = New System.Drawing.Size(281, 38)
        Me.ucrBaseSubDialog.TabIndex = 0
        '
        'sdgCalculationsSummmary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1008, 706)
        Me.Controls.Add(Me.ucrBaseSubDialog)
        Me.Controls.Add(Me.tbSummaryCalcs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCalculationsSummmary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "General Summaries"
        Me.tbSummaryCalcs.ResumeLayout(False)
        Me.tbMain.ResumeLayout(False)
        Me.tbMain.PerformLayout()
        Me.tbManipulations.ResumeLayout(False)
        Me.tbManipulations.PerformLayout()
        Me.tbSubCalcs.ResumeLayout(False)
        Me.tbSubCalcs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
