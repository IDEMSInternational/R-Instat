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
Partial Class ucrFilter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSelectLevels = New System.Windows.Forms.Label()
        Me.cmdAddCondition = New System.Windows.Forms.Button()
        Me.cmdToggleSelectAll = New System.Windows.Forms.Button()
        Me.lstFilters = New System.Windows.Forms.ListView()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.lblFilterBy = New System.Windows.Forms.Label()
        Me.cmdClearConditions = New System.Windows.Forms.Button()
        Me.mcdEditCondition = New System.Windows.Forms.Button()
        Me.cmdRemoveCondition = New System.Windows.Forms.Button()
        Me.lblNewFilterName = New System.Windows.Forms.Label()
        Me.ucrInputFilterName = New instat.ucrInputComboBox()
        Me.ucrValueForFilter = New instat.ucrInputTextBox()
        Me.ucrFilterPreview = New instat.ucrInputTextBox()
        Me.ucrFilterOperation = New instat.ucrInputComboBox()
        Me.ucrFactorLevels = New instat.ucrFactor()
        Me.ucrFilterByReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorForFitler = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSelectLevels
        '
        Me.lblSelectLevels.AutoSize = True
        Me.lblSelectLevels.Location = New System.Drawing.Point(413, 42)
        Me.lblSelectLevels.Name = "lblSelectLevels"
        Me.lblSelectLevels.Size = New System.Drawing.Size(74, 13)
        Me.lblSelectLevels.TabIndex = 3
        Me.lblSelectLevels.Text = "Select Levels:"
        '
        'cmdAddCondition
        '
        Me.cmdAddCondition.Location = New System.Drawing.Point(278, 64)
        Me.cmdAddCondition.Name = "cmdAddCondition"
        Me.cmdAddCondition.Size = New System.Drawing.Size(93, 23)
        Me.cmdAddCondition.TabIndex = 4
        Me.cmdAddCondition.Tag = "Add_Condition"
        Me.cmdAddCondition.Text = "Add Condition"
        Me.cmdAddCondition.UseVisualStyleBackColor = True
        '
        'cmdToggleSelectAll
        '
        Me.cmdToggleSelectAll.Location = New System.Drawing.Point(413, 283)
        Me.cmdToggleSelectAll.Name = "cmdToggleSelectAll"
        Me.cmdToggleSelectAll.Size = New System.Drawing.Size(93, 23)
        Me.cmdToggleSelectAll.TabIndex = 7
        Me.cmdToggleSelectAll.Text = "Select All"
        Me.cmdToggleSelectAll.UseVisualStyleBackColor = True
        '
        'lstFilters
        '
        Me.lstFilters.Location = New System.Drawing.Point(4, 195)
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.Size = New System.Drawing.Size(268, 132)
        Me.lstFilters.TabIndex = 8
        Me.lstFilters.UseCompatibleStateImageBehavior = False
        Me.lstFilters.View = System.Windows.Forms.View.Details
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.AutoSize = True
        Me.lblFilterPreview.Location = New System.Drawing.Point(5, 339)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(73, 13)
        Me.lblFilterPreview.TabIndex = 9
        Me.lblFilterPreview.Text = "Fliter Preview:"
        '
        'lblFilterBy
        '
        Me.lblFilterBy.AutoSize = True
        Me.lblFilterBy.Location = New System.Drawing.Point(278, 27)
        Me.lblFilterBy.Name = "lblFilterBy"
        Me.lblFilterBy.Size = New System.Drawing.Size(47, 13)
        Me.lblFilterBy.TabIndex = 13
        Me.lblFilterBy.Text = "Filter By:"
        '
        'cmdClearConditions
        '
        Me.cmdClearConditions.Location = New System.Drawing.Point(278, 304)
        Me.cmdClearConditions.Name = "cmdClearConditions"
        Me.cmdClearConditions.Size = New System.Drawing.Size(94, 23)
        Me.cmdClearConditions.TabIndex = 14
        Me.cmdClearConditions.Tag = "Clear_Conditions"
        Me.cmdClearConditions.Text = "Clear Conditions"
        Me.cmdClearConditions.UseVisualStyleBackColor = True
        '
        'mcdEditCondition
        '
        Me.mcdEditCondition.Enabled = False
        Me.mcdEditCondition.Location = New System.Drawing.Point(278, 216)
        Me.mcdEditCondition.Name = "mcdEditCondition"
        Me.mcdEditCondition.Size = New System.Drawing.Size(93, 36)
        Me.mcdEditCondition.TabIndex = 15
        Me.mcdEditCondition.Tag = "Edit_Condition"
        Me.mcdEditCondition.Text = "Edit Condition"
        Me.mcdEditCondition.UseVisualStyleBackColor = True
        '
        'cmdRemoveCondition
        '
        Me.cmdRemoveCondition.Enabled = False
        Me.cmdRemoveCondition.Location = New System.Drawing.Point(278, 260)
        Me.cmdRemoveCondition.Name = "cmdRemoveCondition"
        Me.cmdRemoveCondition.Size = New System.Drawing.Size(93, 36)
        Me.cmdRemoveCondition.TabIndex = 16
        Me.cmdRemoveCondition.Tag = "Remove_Condition"
        Me.cmdRemoveCondition.Text = "Remove Condition"
        Me.cmdRemoveCondition.UseVisualStyleBackColor = True
        '
        'lblNewFilterName
        '
        Me.lblNewFilterName.AutoSize = True
        Me.lblNewFilterName.Location = New System.Drawing.Point(5, 366)
        Me.lblNewFilterName.Name = "lblNewFilterName"
        Me.lblNewFilterName.Size = New System.Drawing.Size(88, 13)
        Me.lblNewFilterName.TabIndex = 17
        Me.lblNewFilterName.Text = "New Filter Name:"
        '
        'ucrInputFilterName
        '
        Me.ucrInputFilterName.IsReadOnly = False
        Me.ucrInputFilterName.Location = New System.Drawing.Point(96, 364)
        Me.ucrInputFilterName.Name = "ucrInputFilterName"
        Me.ucrInputFilterName.Size = New System.Drawing.Size(176, 21)
        Me.ucrInputFilterName.TabIndex = 18
        '
        'ucrValueForFilter
        '
        Me.ucrValueForFilter.IsReadOnly = False
        Me.ucrValueForFilter.Location = New System.Drawing.Point(490, 40)
        Me.ucrValueForFilter.Name = "ucrValueForFilter"
        Me.ucrValueForFilter.Size = New System.Drawing.Size(120, 21)
        Me.ucrValueForFilter.TabIndex = 11
        '
        'ucrFilterPreview
        '
        Me.ucrFilterPreview.IsReadOnly = False
        Me.ucrFilterPreview.Location = New System.Drawing.Point(96, 337)
        Me.ucrFilterPreview.Name = "ucrFilterPreview"
        Me.ucrFilterPreview.Size = New System.Drawing.Size(275, 21)
        Me.ucrFilterPreview.TabIndex = 10
        '
        'ucrFilterOperation
        '
        Me.ucrFilterOperation.IsReadOnly = False
        Me.ucrFilterOperation.Location = New System.Drawing.Point(420, 40)
        Me.ucrFilterOperation.Name = "ucrFilterOperation"
        Me.ucrFilterOperation.Size = New System.Drawing.Size(44, 21)
        Me.ucrFilterOperation.TabIndex = 5
        '
        'ucrFactorLevels
        '
        Me.ucrFactorLevels.AutoSize = True
        Me.ucrFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Location = New System.Drawing.Point(413, 61)
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.Size = New System.Drawing.Size(354, 216)
        Me.ucrFactorLevels.TabIndex = 2
        '
        'ucrFilterByReceiver
        '
        Me.ucrFilterByReceiver.Location = New System.Drawing.Point(278, 42)
        Me.ucrFilterByReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFilterByReceiver.Name = "ucrFilterByReceiver"
        Me.ucrFilterByReceiver.Selector = Nothing
        Me.ucrFilterByReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFilterByReceiver.TabIndex = 1
        '
        'ucrSelectorForFitler
        '
        Me.ucrSelectorForFitler.bShowHiddenColumns = False
        Me.ucrSelectorForFitler.bUseCurrentFilter = True
        Me.ucrSelectorForFitler.Location = New System.Drawing.Point(4, 4)
        Me.ucrSelectorForFitler.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForFitler.Name = "ucrSelectorForFitler"
        Me.ucrSelectorForFitler.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForFitler.TabIndex = 0
        '
        'ucrFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputFilterName)
        Me.Controls.Add(Me.lblNewFilterName)
        Me.Controls.Add(Me.cmdRemoveCondition)
        Me.Controls.Add(Me.mcdEditCondition)
        Me.Controls.Add(Me.cmdClearConditions)
        Me.Controls.Add(Me.lblFilterBy)
        Me.Controls.Add(Me.ucrValueForFilter)
        Me.Controls.Add(Me.ucrFilterPreview)
        Me.Controls.Add(Me.lblFilterPreview)
        Me.Controls.Add(Me.lstFilters)
        Me.Controls.Add(Me.cmdToggleSelectAll)
        Me.Controls.Add(Me.ucrFilterOperation)
        Me.Controls.Add(Me.cmdAddCondition)
        Me.Controls.Add(Me.lblSelectLevels)
        Me.Controls.Add(Me.ucrFactorLevels)
        Me.Controls.Add(Me.ucrFilterByReceiver)
        Me.Controls.Add(Me.ucrSelectorForFitler)
        Me.Name = "ucrFilter"
        Me.Size = New System.Drawing.Size(770, 395)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorForFitler As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFilterByReceiver As ucrReceiverSingle
    Friend WithEvents ucrFactorLevels As ucrFactor
    Friend WithEvents lblSelectLevels As Label
    Friend WithEvents cmdAddCondition As Button
    Friend WithEvents ucrFilterOperation As ucrInputComboBox
    Friend WithEvents cmdToggleSelectAll As Button
    Friend WithEvents lstFilters As ListView
    Friend WithEvents lblFilterPreview As Label
    Friend WithEvents ucrFilterPreview As ucrInputTextBox
    Friend WithEvents ucrValueForFilter As ucrInputTextBox
    Friend WithEvents lblFilterBy As Label
    Friend WithEvents cmdClearConditions As Button
    Friend WithEvents mcdEditCondition As Button
    Friend WithEvents cmdRemoveCondition As Button
    Friend WithEvents lblNewFilterName As Label
    Friend WithEvents ucrInputFilterName As ucrInputComboBox
End Class
