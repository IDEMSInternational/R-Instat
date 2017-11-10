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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrFilter))
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
        resources.ApplyResources(Me.lblSelectLevels, "lblSelectLevels")
        Me.lblSelectLevels.Name = "lblSelectLevels"
        '
        'cmdAddCondition
        '
        resources.ApplyResources(Me.cmdAddCondition, "cmdAddCondition")
        Me.cmdAddCondition.Name = "cmdAddCondition"
        Me.cmdAddCondition.Tag = "Add_Condition"
        Me.cmdAddCondition.UseVisualStyleBackColor = True
        '
        'cmdToggleSelectAll
        '
        resources.ApplyResources(Me.cmdToggleSelectAll, "cmdToggleSelectAll")
        Me.cmdToggleSelectAll.Name = "cmdToggleSelectAll"
        Me.cmdToggleSelectAll.UseVisualStyleBackColor = True
        '
        'lstFilters
        '
        resources.ApplyResources(Me.lstFilters, "lstFilters")
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.UseCompatibleStateImageBehavior = False
        Me.lstFilters.View = System.Windows.Forms.View.Details
        '
        'lblFilterPreview
        '
        resources.ApplyResources(Me.lblFilterPreview, "lblFilterPreview")
        Me.lblFilterPreview.Name = "lblFilterPreview"
        '
        'lblFilterBy
        '
        resources.ApplyResources(Me.lblFilterBy, "lblFilterBy")
        Me.lblFilterBy.Name = "lblFilterBy"
        '
        'cmdClearConditions
        '
        resources.ApplyResources(Me.cmdClearConditions, "cmdClearConditions")
        Me.cmdClearConditions.Name = "cmdClearConditions"
        Me.cmdClearConditions.Tag = "Clear_Conditions"
        Me.cmdClearConditions.UseVisualStyleBackColor = True
        '
        'mcdEditCondition
        '
        resources.ApplyResources(Me.mcdEditCondition, "mcdEditCondition")
        Me.mcdEditCondition.Name = "mcdEditCondition"
        Me.mcdEditCondition.Tag = "Edit_Condition"
        Me.mcdEditCondition.UseVisualStyleBackColor = True
        '
        'cmdRemoveCondition
        '
        resources.ApplyResources(Me.cmdRemoveCondition, "cmdRemoveCondition")
        Me.cmdRemoveCondition.Name = "cmdRemoveCondition"
        Me.cmdRemoveCondition.Tag = "Remove_Condition"
        Me.cmdRemoveCondition.UseVisualStyleBackColor = True
        '
        'lblNewFilterName
        '
        resources.ApplyResources(Me.lblNewFilterName, "lblNewFilterName")
        Me.lblNewFilterName.Name = "lblNewFilterName"
        '
        'ucrInputFilterName
        '
        Me.ucrInputFilterName.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilterName, "ucrInputFilterName")
        Me.ucrInputFilterName.Name = "ucrInputFilterName"
        '
        'ucrValueForFilter
        '
        Me.ucrValueForFilter.AddQuotesIfUnrecognised = True
        Me.ucrValueForFilter.IsMultiline = False
        Me.ucrValueForFilter.IsReadOnly = False
        resources.ApplyResources(Me.ucrValueForFilter, "ucrValueForFilter")
        Me.ucrValueForFilter.Name = "ucrValueForFilter"
        '
        'ucrFilterPreview
        '
        Me.ucrFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrFilterPreview.IsMultiline = False
        Me.ucrFilterPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrFilterPreview, "ucrFilterPreview")
        Me.ucrFilterPreview.Name = "ucrFilterPreview"
        '
        'ucrFilterOperation
        '
        Me.ucrFilterOperation.AddQuotesIfUnrecognised = True
        Me.ucrFilterOperation.IsReadOnly = False
        resources.ApplyResources(Me.ucrFilterOperation, "ucrFilterOperation")
        Me.ucrFilterOperation.Name = "ucrFilterOperation"
        '
        'ucrFactorLevels
        '
        resources.ApplyResources(Me.ucrFactorLevels, "ucrFactorLevels")
        Me.ucrFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.ucrChkLevels = Nothing
        '
        'ucrFilterByReceiver
        '
        Me.ucrFilterByReceiver.frmParent = Nothing
        resources.ApplyResources(Me.ucrFilterByReceiver, "ucrFilterByReceiver")
        Me.ucrFilterByReceiver.Name = "ucrFilterByReceiver"
        Me.ucrFilterByReceiver.Selector = Nothing
        Me.ucrFilterByReceiver.strNcFilePath = ""
        Me.ucrFilterByReceiver.ucrSelector = Nothing
        '
        'ucrSelectorForFitler
        '
        Me.ucrSelectorForFitler.bShowHiddenColumns = False
        Me.ucrSelectorForFitler.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForFitler, "ucrSelectorForFitler")
        Me.ucrSelectorForFitler.Name = "ucrSelectorForFitler"
        '
        'ucrFilter
        '
        resources.ApplyResources(Me, "$this")
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
