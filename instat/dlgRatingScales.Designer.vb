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
Partial Class dlgRatingScales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRatingScales))
        Me.lblOrderedFactor = New System.Windows.Forms.Label()
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.rdoHighDescendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoLowDescendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoLowAscendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoNoneLikert = New System.Windows.Forms.RadioButton()
        Me.rdoHighAscendingLikert = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLikertOptions = New instat.UcrPanel()
        Me.rdoStacked = New System.Windows.Forms.RadioButton()
        Me.rdoLikert = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.grpSortTable = New System.Windows.Forms.GroupBox()
        Me.rdoHighDescendingTable = New System.Windows.Forms.RadioButton()
        Me.rdoLowAscendingTable = New System.Windows.Forms.RadioButton()
        Me.rdoHighAscendingTable = New System.Windows.Forms.RadioButton()
        Me.rdoLowDescendingTable = New System.Windows.Forms.RadioButton()
        Me.rdoNoneTable = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTableOptions = New instat.UcrPanel()
        Me.ucrNudNeutralLevel = New instat.ucrNud()
        Me.ucrChkNumberOfCategories = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverOrderedFactors = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorRatingScale = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpSort.SuspendLayout()
        Me.grpSortTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOrderedFactor
        '
        resources.ApplyResources(Me.lblOrderedFactor, "lblOrderedFactor")
        Me.lblOrderedFactor.Name = "lblOrderedFactor"
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoHighDescendingLikert)
        Me.grpSort.Controls.Add(Me.rdoLowDescendingLikert)
        Me.grpSort.Controls.Add(Me.rdoLowAscendingLikert)
        Me.grpSort.Controls.Add(Me.rdoNoneLikert)
        Me.grpSort.Controls.Add(Me.rdoHighAscendingLikert)
        Me.grpSort.Controls.Add(Me.ucrPnlLikertOptions)
        resources.ApplyResources(Me.grpSort, "grpSort")
        Me.grpSort.Name = "grpSort"
        Me.grpSort.TabStop = False
        '
        'rdoHighDescendingLikert
        '
        resources.ApplyResources(Me.rdoHighDescendingLikert, "rdoHighDescendingLikert")
        Me.rdoHighDescendingLikert.Name = "rdoHighDescendingLikert"
        Me.rdoHighDescendingLikert.TabStop = True
        Me.rdoHighDescendingLikert.UseVisualStyleBackColor = True
        '
        'rdoLowDescendingLikert
        '
        resources.ApplyResources(Me.rdoLowDescendingLikert, "rdoLowDescendingLikert")
        Me.rdoLowDescendingLikert.Name = "rdoLowDescendingLikert"
        Me.rdoLowDescendingLikert.TabStop = True
        Me.rdoLowDescendingLikert.UseVisualStyleBackColor = True
        '
        'rdoLowAscendingLikert
        '
        resources.ApplyResources(Me.rdoLowAscendingLikert, "rdoLowAscendingLikert")
        Me.rdoLowAscendingLikert.Name = "rdoLowAscendingLikert"
        Me.rdoLowAscendingLikert.TabStop = True
        Me.rdoLowAscendingLikert.UseVisualStyleBackColor = True
        '
        'rdoNoneLikert
        '
        resources.ApplyResources(Me.rdoNoneLikert, "rdoNoneLikert")
        Me.rdoNoneLikert.Name = "rdoNoneLikert"
        Me.rdoNoneLikert.TabStop = True
        Me.rdoNoneLikert.UseVisualStyleBackColor = True
        '
        'rdoHighAscendingLikert
        '
        resources.ApplyResources(Me.rdoHighAscendingLikert, "rdoHighAscendingLikert")
        Me.rdoHighAscendingLikert.Name = "rdoHighAscendingLikert"
        Me.rdoHighAscendingLikert.TabStop = True
        Me.rdoHighAscendingLikert.UseVisualStyleBackColor = True
        '
        'ucrPnlLikertOptions
        '
        resources.ApplyResources(Me.ucrPnlLikertOptions, "ucrPnlLikertOptions")
        Me.ucrPnlLikertOptions.Name = "ucrPnlLikertOptions"
        '
        'rdoStacked
        '
        resources.ApplyResources(Me.rdoStacked, "rdoStacked")
        Me.rdoStacked.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStacked.FlatAppearance.BorderSize = 2
        Me.rdoStacked.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStacked.Name = "rdoStacked"
        Me.rdoStacked.UseVisualStyleBackColor = True
        '
        'rdoLikert
        '
        resources.ApplyResources(Me.rdoLikert, "rdoLikert")
        Me.rdoLikert.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLikert.FlatAppearance.BorderSize = 2
        Me.rdoLikert.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLikert.Name = "rdoLikert"
        Me.rdoLikert.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        resources.ApplyResources(Me.rdoTable, "rdoTable")
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'grpSortTable
        '
        Me.grpSortTable.Controls.Add(Me.rdoHighDescendingTable)
        Me.grpSortTable.Controls.Add(Me.rdoLowAscendingTable)
        Me.grpSortTable.Controls.Add(Me.rdoHighAscendingTable)
        Me.grpSortTable.Controls.Add(Me.rdoLowDescendingTable)
        Me.grpSortTable.Controls.Add(Me.rdoNoneTable)
        Me.grpSortTable.Controls.Add(Me.ucrPnlTableOptions)
        resources.ApplyResources(Me.grpSortTable, "grpSortTable")
        Me.grpSortTable.Name = "grpSortTable"
        Me.grpSortTable.TabStop = False
        '
        'rdoHighDescendingTable
        '
        resources.ApplyResources(Me.rdoHighDescendingTable, "rdoHighDescendingTable")
        Me.rdoHighDescendingTable.Name = "rdoHighDescendingTable"
        Me.rdoHighDescendingTable.TabStop = True
        Me.rdoHighDescendingTable.UseVisualStyleBackColor = True
        '
        'rdoLowAscendingTable
        '
        resources.ApplyResources(Me.rdoLowAscendingTable, "rdoLowAscendingTable")
        Me.rdoLowAscendingTable.Name = "rdoLowAscendingTable"
        Me.rdoLowAscendingTable.TabStop = True
        Me.rdoLowAscendingTable.UseVisualStyleBackColor = True
        '
        'rdoHighAscendingTable
        '
        resources.ApplyResources(Me.rdoHighAscendingTable, "rdoHighAscendingTable")
        Me.rdoHighAscendingTable.Name = "rdoHighAscendingTable"
        Me.rdoHighAscendingTable.TabStop = True
        Me.rdoHighAscendingTable.UseVisualStyleBackColor = True
        '
        'rdoLowDescendingTable
        '
        resources.ApplyResources(Me.rdoLowDescendingTable, "rdoLowDescendingTable")
        Me.rdoLowDescendingTable.Name = "rdoLowDescendingTable"
        Me.rdoLowDescendingTable.TabStop = True
        Me.rdoLowDescendingTable.UseVisualStyleBackColor = True
        '
        'rdoNoneTable
        '
        resources.ApplyResources(Me.rdoNoneTable, "rdoNoneTable")
        Me.rdoNoneTable.Name = "rdoNoneTable"
        Me.rdoNoneTable.TabStop = True
        Me.rdoNoneTable.UseVisualStyleBackColor = True
        '
        'ucrPnlTableOptions
        '
        resources.ApplyResources(Me.ucrPnlTableOptions, "ucrPnlTableOptions")
        Me.ucrPnlTableOptions.Name = "ucrPnlTableOptions"
        '
        'ucrNudNeutralLevel
        '
        Me.ucrNudNeutralLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNeutralLevel, "ucrNudNeutralLevel")
        Me.ucrNudNeutralLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNeutralLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Name = "ucrNudNeutralLevel"
        Me.ucrNudNeutralLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNumberOfCategories
        '
        Me.ucrChkNumberOfCategories.Checked = False
        resources.ApplyResources(Me.ucrChkNumberOfCategories, "ucrChkNumberOfCategories")
        Me.ucrChkNumberOfCategories.Name = "ucrChkNumberOfCategories"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrPnlGraphType
        '
        resources.ApplyResources(Me.ucrPnlGraphType, "ucrPnlGraphType")
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        resources.ApplyResources(Me.ucrChkFlip, "ucrChkFlip")
        Me.ucrChkFlip.Name = "ucrChkFlip"
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWeights, "ucrReceiverWeights")
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        resources.ApplyResources(Me.ucrChkWeights, "ucrChkWeights")
        Me.ucrChkWeights.Name = "ucrChkWeights"
        '
        'ucrReceiverOrderedFactors
        '
        Me.ucrReceiverOrderedFactors.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOrderedFactors, "ucrReceiverOrderedFactors")
        Me.ucrReceiverOrderedFactors.Name = "ucrReceiverOrderedFactors"
        Me.ucrReceiverOrderedFactors.Selector = Nothing
        Me.ucrReceiverOrderedFactors.strNcFilePath = ""
        Me.ucrReceiverOrderedFactors.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorRatingScale
        '
        Me.ucrSelectorRatingScale.bDropUnusedFilterLevels = False
        Me.ucrSelectorRatingScale.bShowHiddenColumns = False
        Me.ucrSelectorRatingScale.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRatingScale, "ucrSelectorRatingScale")
        Me.ucrSelectorRatingScale.Name = "ucrSelectorRatingScale"
        '
        'dlgRatingScales
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNudNeutralLevel)
        Me.Controls.Add(Me.ucrChkNumberOfCategories)
        Me.Controls.Add(Me.grpSortTable)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.rdoStacked)
        Me.Controls.Add(Me.rdoLikert)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.ucrPnlGraphType)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.lblOrderedFactor)
        Me.Controls.Add(Me.ucrReceiverOrderedFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorRatingScale)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRatingScales"
        Me.grpSort.ResumeLayout(False)
        Me.grpSort.PerformLayout()
        Me.grpSortTable.ResumeLayout(False)
        Me.grpSortTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorRatingScale As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverOrderedFactors As ucrReceiverMultiple
    Friend WithEvents lblOrderedFactor As Label
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents grpSort As GroupBox
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrNudNeutralLevel As ucrNud
    Friend WithEvents rdoHighDescendingLikert As RadioButton
    Friend WithEvents rdoNoneLikert As RadioButton
    Friend WithEvents rdoHighAscendingLikert As RadioButton
    Friend WithEvents rdoLowDescendingLikert As RadioButton
    Friend WithEvents rdoLowAscendingLikert As RadioButton
    Friend WithEvents rdoStacked As RadioButton
    Friend WithEvents rdoLikert As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents ucrChkNumberOfCategories As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents grpSortTable As GroupBox
    Friend WithEvents rdoHighDescendingTable As RadioButton
    Friend WithEvents rdoLowDescendingTable As RadioButton
    Friend WithEvents rdoLowAscendingTable As RadioButton
    Friend WithEvents rdoNoneTable As RadioButton
    Friend WithEvents rdoHighAscendingTable As RadioButton
    Friend WithEvents ucrPnlTableOptions As UcrPanel
    Friend WithEvents ucrPnlLikertOptions As UcrPanel
End Class
