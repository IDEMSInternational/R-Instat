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
        Me.ucrReceiverByOrSort = New instat.ucrReceiverMultiple()
        Me.ucrCalculationName = New instat.ucrInputComboBox()
        Me.lblReceiverLabel = New System.Windows.Forms.Label()
        Me.ucrResultName = New instat.ucrInputComboBox()
        Me.lblResultName = New System.Windows.Forms.Label()
        Me.lblCalcName = New System.Windows.Forms.Label()
        Me.rdoSaveCalcAndResult = New System.Windows.Forms.RadioButton()
        Me.rdoSaveCalculation = New System.Windows.Forms.RadioButton()
        Me.rdoDoNotSave = New System.Windows.Forms.RadioButton()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrType = New instat.ucrInputComboBox()
        Me.ucrSelectorBy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrCalcSummary = New instat.ucrCalculator()
        Me.ucrDefineFilter = New instat.ucrFilter()
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
        Me.ucrBaseSummmaryCalcSubdialog = New instat.ucrButtonsSubdialogue()
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
        Me.tbSummaryCalcs.Name = "tbSummaryCalcs"
        Me.tbSummaryCalcs.SelectedIndex = 0
        Me.tbSummaryCalcs.Size = New System.Drawing.Size(803, 533)
        Me.tbSummaryCalcs.TabIndex = 1
        '
        'tbMain
        '
        Me.tbMain.Controls.Add(Me.ucrReceiverByOrSort)
        Me.tbMain.Controls.Add(Me.ucrCalculationName)
        Me.tbMain.Controls.Add(Me.lblReceiverLabel)
        Me.tbMain.Controls.Add(Me.ucrResultName)
        Me.tbMain.Controls.Add(Me.lblResultName)
        Me.tbMain.Controls.Add(Me.lblCalcName)
        Me.tbMain.Controls.Add(Me.rdoSaveCalcAndResult)
        Me.tbMain.Controls.Add(Me.rdoSaveCalculation)
        Me.tbMain.Controls.Add(Me.rdoDoNotSave)
        Me.tbMain.Controls.Add(Me.lblType)
        Me.tbMain.Controls.Add(Me.ucrType)
        Me.tbMain.Controls.Add(Me.ucrSelectorBy)
        Me.tbMain.Controls.Add(Me.ucrCalcSummary)
        Me.tbMain.Controls.Add(Me.ucrDefineFilter)
        Me.tbMain.Location = New System.Drawing.Point(4, 22)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMain.Size = New System.Drawing.Size(795, 507)
        Me.tbMain.TabIndex = 0
        Me.tbMain.Text = "Main"
        Me.tbMain.UseVisualStyleBackColor = True
        '
        'ucrReceiverByOrSort
        '
        Me.ucrReceiverByOrSort.Location = New System.Drawing.Point(239, 143)
        Me.ucrReceiverByOrSort.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByOrSort.Name = "ucrReceiverByOrSort"
        Me.ucrReceiverByOrSort.Selector = Nothing
        Me.ucrReceiverByOrSort.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverByOrSort.TabIndex = 18
        '
        'ucrCalculationName
        '
        Me.ucrCalculationName.IsReadOnly = False
        Me.ucrCalculationName.Location = New System.Drawing.Point(112, 421)
        Me.ucrCalculationName.Name = "ucrCalculationName"
        Me.ucrCalculationName.Size = New System.Drawing.Size(137, 21)
        Me.ucrCalculationName.TabIndex = 12
        '
        'lblReceiverLabel
        '
        Me.lblReceiverLabel.AutoSize = True
        Me.lblReceiverLabel.Location = New System.Drawing.Point(236, 126)
        Me.lblReceiverLabel.Name = "lblReceiverLabel"
        Me.lblReceiverLabel.Size = New System.Drawing.Size(45, 13)
        Me.lblReceiverLabel.TabIndex = 15
        Me.lblReceiverLabel.Text = "Factors:"
        '
        'ucrResultName
        '
        Me.ucrResultName.IsReadOnly = False
        Me.ucrResultName.Location = New System.Drawing.Point(112, 444)
        Me.ucrResultName.Name = "ucrResultName"
        Me.ucrResultName.Size = New System.Drawing.Size(137, 21)
        Me.ucrResultName.TabIndex = 13
        '
        'lblResultName
        '
        Me.lblResultName.AutoSize = True
        Me.lblResultName.Location = New System.Drawing.Point(12, 448)
        Me.lblResultName.Name = "lblResultName"
        Me.lblResultName.Size = New System.Drawing.Size(71, 13)
        Me.lblResultName.TabIndex = 10
        Me.lblResultName.Text = "Result Name:"
        '
        'lblCalcName
        '
        Me.lblCalcName.AutoSize = True
        Me.lblCalcName.Location = New System.Drawing.Point(12, 425)
        Me.lblCalcName.Name = "lblCalcName"
        Me.lblCalcName.Size = New System.Drawing.Size(93, 13)
        Me.lblCalcName.TabIndex = 9
        Me.lblCalcName.Text = "Calculation Name:"
        '
        'rdoSaveCalcAndResult
        '
        Me.rdoSaveCalcAndResult.AutoSize = True
        Me.rdoSaveCalcAndResult.Location = New System.Drawing.Point(262, 471)
        Me.rdoSaveCalcAndResult.Name = "rdoSaveCalcAndResult"
        Me.rdoSaveCalcAndResult.Size = New System.Drawing.Size(159, 17)
        Me.rdoSaveCalcAndResult.TabIndex = 8
        Me.rdoSaveCalcAndResult.TabStop = True
        Me.rdoSaveCalcAndResult.Text = "Save Calculation and Result"
        Me.rdoSaveCalcAndResult.UseVisualStyleBackColor = True
        '
        'rdoSaveCalculation
        '
        Me.rdoSaveCalculation.AutoSize = True
        Me.rdoSaveCalculation.Location = New System.Drawing.Point(139, 471)
        Me.rdoSaveCalculation.Name = "rdoSaveCalculation"
        Me.rdoSaveCalculation.Size = New System.Drawing.Size(105, 17)
        Me.rdoSaveCalculation.TabIndex = 7
        Me.rdoSaveCalculation.TabStop = True
        Me.rdoSaveCalculation.Text = "Save Calculation"
        Me.rdoSaveCalculation.UseVisualStyleBackColor = True
        '
        'rdoDoNotSave
        '
        Me.rdoDoNotSave.AutoSize = True
        Me.rdoDoNotSave.Location = New System.Drawing.Point(15, 471)
        Me.rdoDoNotSave.Name = "rdoDoNotSave"
        Me.rdoDoNotSave.Size = New System.Drawing.Size(87, 17)
        Me.rdoDoNotSave.TabIndex = 6
        Me.rdoDoNotSave.TabStop = True
        Me.rdoDoNotSave.Text = "Do Not Save"
        Me.rdoDoNotSave.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(9, 12)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Type:"
        '
        'ucrType
        '
        Me.ucrType.IsReadOnly = False
        Me.ucrType.Location = New System.Drawing.Point(8, 28)
        Me.ucrType.Name = "ucrType"
        Me.ucrType.Size = New System.Drawing.Size(120, 21)
        Me.ucrType.TabIndex = 3
        '
        'ucrSelectorBy
        '
        Me.ucrSelectorBy.bShowHiddenColumns = False
        Me.ucrSelectorBy.bUseCurrentFilter = True
        Me.ucrSelectorBy.Location = New System.Drawing.Point(8, 114)
        Me.ucrSelectorBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorBy.Name = "ucrSelectorBy"
        Me.ucrSelectorBy.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorBy.TabIndex = 14
        '
        'ucrCalcSummary
        '
        Me.ucrCalcSummary.Location = New System.Drawing.Point(8, 50)
        Me.ucrCalcSummary.Name = "ucrCalcSummary"
        Me.ucrCalcSummary.Size = New System.Drawing.Size(623, 282)
        Me.ucrCalcSummary.TabIndex = 17
        '
        'ucrDefineFilter
        '
        Me.ucrDefineFilter.Location = New System.Drawing.Point(8, 55)
        Me.ucrDefineFilter.Name = "ucrDefineFilter"
        Me.ucrDefineFilter.Size = New System.Drawing.Size(770, 359)
        Me.ucrDefineFilter.TabIndex = 19
        '
        'tbManipulations
        '
        Me.tbManipulations.Controls.Add(Me.ucrManipulations)
        Me.tbManipulations.Controls.Add(Me.cmdManipDuplicate)
        Me.tbManipulations.Controls.Add(Me.cmdManipDelete)
        Me.tbManipulations.Controls.Add(Me.lblManipulations)
        Me.tbManipulations.Controls.Add(Me.cmdManipEdit)
        Me.tbManipulations.Controls.Add(Me.cmdManipAdd)
        Me.tbManipulations.Location = New System.Drawing.Point(4, 22)
        Me.tbManipulations.Name = "tbManipulations"
        Me.tbManipulations.Padding = New System.Windows.Forms.Padding(3)
        Me.tbManipulations.Size = New System.Drawing.Size(795, 507)
        Me.tbManipulations.TabIndex = 1
        Me.tbManipulations.Text = "Manipulations"
        Me.tbManipulations.UseVisualStyleBackColor = True
        '
        'ucrManipulations
        '
        Me.ucrManipulations.Location = New System.Drawing.Point(6, 30)
        Me.ucrManipulations.Name = "ucrManipulations"
        Me.ucrManipulations.Size = New System.Drawing.Size(154, 139)
        Me.ucrManipulations.TabIndex = 21
        Me.ucrManipulations.ucrDataFrameList = Nothing
        Me.ucrManipulations.ucrReceiver = Nothing
        '
        'cmdManipDuplicate
        '
        Me.cmdManipDuplicate.Location = New System.Drawing.Point(166, 132)
        Me.cmdManipDuplicate.Name = "cmdManipDuplicate"
        Me.cmdManipDuplicate.Size = New System.Drawing.Size(75, 23)
        Me.cmdManipDuplicate.TabIndex = 20
        Me.cmdManipDuplicate.Text = "Duplicate"
        Me.cmdManipDuplicate.UseVisualStyleBackColor = True
        '
        'cmdManipDelete
        '
        Me.cmdManipDelete.Location = New System.Drawing.Point(166, 103)
        Me.cmdManipDelete.Name = "cmdManipDelete"
        Me.cmdManipDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdManipDelete.TabIndex = 17
        Me.cmdManipDelete.Text = "Delete"
        Me.cmdManipDelete.UseVisualStyleBackColor = True
        '
        'lblManipulations
        '
        Me.lblManipulations.AutoSize = True
        Me.lblManipulations.Location = New System.Drawing.Point(9, 17)
        Me.lblManipulations.Name = "lblManipulations"
        Me.lblManipulations.Size = New System.Drawing.Size(75, 13)
        Me.lblManipulations.TabIndex = 16
        Me.lblManipulations.Text = "Manipulations:"
        '
        'cmdManipEdit
        '
        Me.cmdManipEdit.Location = New System.Drawing.Point(166, 74)
        Me.cmdManipEdit.Name = "cmdManipEdit"
        Me.cmdManipEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdManipEdit.TabIndex = 18
        Me.cmdManipEdit.Text = "Edit"
        Me.cmdManipEdit.UseVisualStyleBackColor = True
        '
        'cmdManipAdd
        '
        Me.cmdManipAdd.Location = New System.Drawing.Point(166, 45)
        Me.cmdManipAdd.Name = "cmdManipAdd"
        Me.cmdManipAdd.Size = New System.Drawing.Size(75, 23)
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
        Me.tbSubCalcs.Location = New System.Drawing.Point(4, 22)
        Me.tbSubCalcs.Name = "tbSubCalcs"
        Me.tbSubCalcs.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSubCalcs.Size = New System.Drawing.Size(795, 507)
        Me.tbSubCalcs.TabIndex = 2
        Me.tbSubCalcs.Text = "Sub Calculations"
        Me.tbSubCalcs.UseVisualStyleBackColor = True
        '
        'lstSubCalcs
        '
        Me.lstSubCalcs.Location = New System.Drawing.Point(9, 33)
        Me.lstSubCalcs.Name = "lstSubCalcs"
        Me.lstSubCalcs.Size = New System.Drawing.Size(121, 133)
        Me.lstSubCalcs.TabIndex = 21
        Me.lstSubCalcs.UseCompatibleStateImageBehavior = False
        Me.lstSubCalcs.View = System.Windows.Forms.View.List
        '
        'cmdSubCalcDuplicate
        '
        Me.cmdSubCalcDuplicate.Location = New System.Drawing.Point(166, 132)
        Me.cmdSubCalcDuplicate.Name = "cmdSubCalcDuplicate"
        Me.cmdSubCalcDuplicate.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubCalcDuplicate.TabIndex = 26
        Me.cmdSubCalcDuplicate.Text = "Duplicate"
        Me.cmdSubCalcDuplicate.UseVisualStyleBackColor = True
        '
        'cmdSubCalcDelete
        '
        Me.cmdSubCalcDelete.Location = New System.Drawing.Point(166, 103)
        Me.cmdSubCalcDelete.Name = "cmdSubCalcDelete"
        Me.cmdSubCalcDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubCalcDelete.TabIndex = 23
        Me.cmdSubCalcDelete.Text = "Delete"
        Me.cmdSubCalcDelete.UseVisualStyleBackColor = True
        '
        'cmdSubCalcAdd
        '
        Me.cmdSubCalcAdd.Location = New System.Drawing.Point(166, 45)
        Me.cmdSubCalcAdd.Name = "cmdSubCalcAdd"
        Me.cmdSubCalcAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubCalcAdd.TabIndex = 25
        Me.cmdSubCalcAdd.Text = "Add"
        Me.cmdSubCalcAdd.UseVisualStyleBackColor = True
        '
        'lblSubCalcs
        '
        Me.lblSubCalcs.AutoSize = True
        Me.lblSubCalcs.Location = New System.Drawing.Point(9, 17)
        Me.lblSubCalcs.Name = "lblSubCalcs"
        Me.lblSubCalcs.Size = New System.Drawing.Size(89, 13)
        Me.lblSubCalcs.TabIndex = 22
        Me.lblSubCalcs.Text = "Sub-Calculations:"
        '
        'cmdSubCalcEdit
        '
        Me.cmdSubCalcEdit.Location = New System.Drawing.Point(166, 74)
        Me.cmdSubCalcEdit.Name = "cmdSubCalcEdit"
        Me.cmdSubCalcEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubCalcEdit.TabIndex = 24
        Me.cmdSubCalcEdit.Text = "Edit"
        Me.cmdSubCalcEdit.UseVisualStyleBackColor = True
        '
        'ucrBaseSummmaryCalcSubdialog
        '
        Me.ucrBaseSummmaryCalcSubdialog.Location = New System.Drawing.Point(312, 533)
        Me.ucrBaseSummmaryCalcSubdialog.Name = "ucrBaseSummmaryCalcSubdialog"
        Me.ucrBaseSummmaryCalcSubdialog.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSummmaryCalcSubdialog.TabIndex = 0
        '
        'sdgCalculationsSummmary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 565)
        Me.Controls.Add(Me.ucrBaseSummmaryCalcSubdialog)
        Me.Controls.Add(Me.tbSummaryCalcs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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

    End Sub

    Friend WithEvents ucrBaseSummmaryCalcSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbSummaryCalcs As TabControl
    Friend WithEvents tbMain As TabPage
    Friend WithEvents lblResultName As Label
    Friend WithEvents lblCalcName As Label
    Friend WithEvents rdoSaveCalcAndResult As RadioButton
    Friend WithEvents rdoSaveCalculation As RadioButton
    Friend WithEvents rdoDoNotSave As RadioButton
    Friend WithEvents lblType As Label
    Friend WithEvents ucrType As ucrInputComboBox
    Friend WithEvents tbManipulations As TabPage
    Friend WithEvents tbSubCalcs As TabPage
    Friend WithEvents ucrResultName As ucrInputComboBox
    Friend WithEvents ucrCalculationName As ucrInputComboBox
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
End Class
