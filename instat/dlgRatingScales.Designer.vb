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
        Me.lblOrderedFactor.AutoSize = True
        Me.lblOrderedFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrderedFactor.Location = New System.Drawing.Point(262, 84)
        Me.lblOrderedFactor.Name = "lblOrderedFactor"
        Me.lblOrderedFactor.Size = New System.Drawing.Size(81, 13)
        Me.lblOrderedFactor.TabIndex = 5
        Me.lblOrderedFactor.Text = "Ordered Factor:"
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoHighDescendingLikert)
        Me.grpSort.Controls.Add(Me.rdoLowDescendingLikert)
        Me.grpSort.Controls.Add(Me.rdoLowAscendingLikert)
        Me.grpSort.Controls.Add(Me.rdoNoneLikert)
        Me.grpSort.Controls.Add(Me.rdoHighAscendingLikert)
        Me.grpSort.Controls.Add(Me.ucrPnlLikertOptions)
        Me.grpSort.Location = New System.Drawing.Point(262, 205)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(135, 149)
        Me.grpSort.TabIndex = 7
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort"
        '
        'rdoHighDescendingLikert
        '
        Me.rdoHighDescendingLikert.AutoSize = True
        Me.rdoHighDescendingLikert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHighDescendingLikert.Location = New System.Drawing.Point(14, 115)
        Me.rdoHighDescendingLikert.Name = "rdoHighDescendingLikert"
        Me.rdoHighDescendingLikert.Size = New System.Drawing.Size(107, 17)
        Me.rdoHighDescendingLikert.TabIndex = 0
        Me.rdoHighDescendingLikert.TabStop = True
        Me.rdoHighDescendingLikert.Text = "High Descending"
        Me.rdoHighDescendingLikert.UseVisualStyleBackColor = True
        '
        'rdoLowDescendingLikert
        '
        Me.rdoLowDescendingLikert.AutoSize = True
        Me.rdoLowDescendingLikert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLowDescendingLikert.Location = New System.Drawing.Point(14, 67)
        Me.rdoLowDescendingLikert.Name = "rdoLowDescendingLikert"
        Me.rdoLowDescendingLikert.Size = New System.Drawing.Size(105, 17)
        Me.rdoLowDescendingLikert.TabIndex = 4
        Me.rdoLowDescendingLikert.TabStop = True
        Me.rdoLowDescendingLikert.Text = "Low Descending"
        Me.rdoLowDescendingLikert.UseVisualStyleBackColor = True
        '
        'rdoLowAscendingLikert
        '
        Me.rdoLowAscendingLikert.AutoSize = True
        Me.rdoLowAscendingLikert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLowAscendingLikert.Location = New System.Drawing.Point(14, 43)
        Me.rdoLowAscendingLikert.Name = "rdoLowAscendingLikert"
        Me.rdoLowAscendingLikert.Size = New System.Drawing.Size(98, 17)
        Me.rdoLowAscendingLikert.TabIndex = 3
        Me.rdoLowAscendingLikert.TabStop = True
        Me.rdoLowAscendingLikert.Text = "Low Ascending"
        Me.rdoLowAscendingLikert.UseVisualStyleBackColor = True
        '
        'rdoNoneLikert
        '
        Me.rdoNoneLikert.AutoSize = True
        Me.rdoNoneLikert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoneLikert.Location = New System.Drawing.Point(14, 19)
        Me.rdoNoneLikert.Name = "rdoNoneLikert"
        Me.rdoNoneLikert.Size = New System.Drawing.Size(51, 17)
        Me.rdoNoneLikert.TabIndex = 2
        Me.rdoNoneLikert.TabStop = True
        Me.rdoNoneLikert.Text = "None"
        Me.rdoNoneLikert.UseVisualStyleBackColor = True
        '
        'rdoHighAscendingLikert
        '
        Me.rdoHighAscendingLikert.AutoSize = True
        Me.rdoHighAscendingLikert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHighAscendingLikert.Location = New System.Drawing.Point(14, 91)
        Me.rdoHighAscendingLikert.Name = "rdoHighAscendingLikert"
        Me.rdoHighAscendingLikert.Size = New System.Drawing.Size(100, 17)
        Me.rdoHighAscendingLikert.TabIndex = 5
        Me.rdoHighAscendingLikert.TabStop = True
        Me.rdoHighAscendingLikert.Text = "High Ascending"
        Me.rdoHighAscendingLikert.UseVisualStyleBackColor = True
        '
        'ucrPnlLikertOptions
        '
        Me.ucrPnlLikertOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLikertOptions.Location = New System.Drawing.Point(7, 19)
        Me.ucrPnlLikertOptions.Name = "ucrPnlLikertOptions"
        Me.ucrPnlLikertOptions.Size = New System.Drawing.Size(114, 119)
        Me.ucrPnlLikertOptions.TabIndex = 6
        '
        'rdoStacked
        '
        Me.rdoStacked.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStacked.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStacked.FlatAppearance.BorderSize = 2
        Me.rdoStacked.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStacked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStacked.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStacked.Location = New System.Drawing.Point(162, 10)
        Me.rdoStacked.Name = "rdoStacked"
        Me.rdoStacked.Size = New System.Drawing.Size(100, 28)
        Me.rdoStacked.TabIndex = 3
        Me.rdoStacked.Text = "Stacked Graph"
        Me.rdoStacked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStacked.UseVisualStyleBackColor = True
        '
        'rdoLikert
        '
        Me.rdoLikert.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLikert.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLikert.FlatAppearance.BorderSize = 2
        Me.rdoLikert.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLikert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLikert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLikert.Location = New System.Drawing.Point(260, 10)
        Me.rdoLikert.Name = "rdoLikert"
        Me.rdoLikert.Size = New System.Drawing.Size(100, 28)
        Me.rdoLikert.TabIndex = 2
        Me.rdoLikert.Text = "Likert Graph"
        Me.rdoLikert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLikert.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTable.Location = New System.Drawing.Point(64, 10)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.grpSortTable.Location = New System.Drawing.Point(262, 205)
        Me.grpSortTable.Name = "grpSortTable"
        Me.grpSortTable.Size = New System.Drawing.Size(135, 149)
        Me.grpSortTable.TabIndex = 8
        Me.grpSortTable.TabStop = False
        Me.grpSortTable.Text = "Sort"
        '
        'rdoHighDescendingTable
        '
        Me.rdoHighDescendingTable.AutoSize = True
        Me.rdoHighDescendingTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHighDescendingTable.Location = New System.Drawing.Point(14, 115)
        Me.rdoHighDescendingTable.Name = "rdoHighDescendingTable"
        Me.rdoHighDescendingTable.Size = New System.Drawing.Size(107, 17)
        Me.rdoHighDescendingTable.TabIndex = 0
        Me.rdoHighDescendingTable.TabStop = True
        Me.rdoHighDescendingTable.Text = "High Descending"
        Me.rdoHighDescendingTable.UseVisualStyleBackColor = True
        '
        'rdoLowAscendingTable
        '
        Me.rdoLowAscendingTable.AutoSize = True
        Me.rdoLowAscendingTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLowAscendingTable.Location = New System.Drawing.Point(14, 43)
        Me.rdoLowAscendingTable.Name = "rdoLowAscendingTable"
        Me.rdoLowAscendingTable.Size = New System.Drawing.Size(98, 17)
        Me.rdoLowAscendingTable.TabIndex = 3
        Me.rdoLowAscendingTable.TabStop = True
        Me.rdoLowAscendingTable.Text = "Low Ascending"
        Me.rdoLowAscendingTable.UseVisualStyleBackColor = True
        '
        'rdoHighAscendingTable
        '
        Me.rdoHighAscendingTable.AutoSize = True
        Me.rdoHighAscendingTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHighAscendingTable.Location = New System.Drawing.Point(14, 91)
        Me.rdoHighAscendingTable.Name = "rdoHighAscendingTable"
        Me.rdoHighAscendingTable.Size = New System.Drawing.Size(100, 17)
        Me.rdoHighAscendingTable.TabIndex = 5
        Me.rdoHighAscendingTable.TabStop = True
        Me.rdoHighAscendingTable.Text = "High Ascending"
        Me.rdoHighAscendingTable.UseVisualStyleBackColor = True
        '
        'rdoLowDescendingTable
        '
        Me.rdoLowDescendingTable.AutoSize = True
        Me.rdoLowDescendingTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLowDescendingTable.Location = New System.Drawing.Point(14, 67)
        Me.rdoLowDescendingTable.Name = "rdoLowDescendingTable"
        Me.rdoLowDescendingTable.Size = New System.Drawing.Size(105, 17)
        Me.rdoLowDescendingTable.TabIndex = 4
        Me.rdoLowDescendingTable.TabStop = True
        Me.rdoLowDescendingTable.Text = "Low Descending"
        Me.rdoLowDescendingTable.UseVisualStyleBackColor = True
        '
        'rdoNoneTable
        '
        Me.rdoNoneTable.AutoSize = True
        Me.rdoNoneTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoneTable.Location = New System.Drawing.Point(14, 19)
        Me.rdoNoneTable.Name = "rdoNoneTable"
        Me.rdoNoneTable.Size = New System.Drawing.Size(51, 17)
        Me.rdoNoneTable.TabIndex = 2
        Me.rdoNoneTable.TabStop = True
        Me.rdoNoneTable.Text = "None"
        Me.rdoNoneTable.UseVisualStyleBackColor = True
        '
        'ucrPnlTableOptions
        '
        Me.ucrPnlTableOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTableOptions.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlTableOptions.Name = "ucrPnlTableOptions"
        Me.ucrPnlTableOptions.Size = New System.Drawing.Size(123, 124)
        Me.ucrPnlTableOptions.TabIndex = 6
        '
        'ucrNudNeutralLevel
        '
        Me.ucrNudNeutralLevel.AutoSize = True
        Me.ucrNudNeutralLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNeutralLevel.Location = New System.Drawing.Point(152, 297)
        Me.ucrNudNeutralLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNeutralLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Name = "ucrNudNeutralLevel"
        Me.ucrNudNeutralLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNeutralLevel.TabIndex = 2
        Me.ucrNudNeutralLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNumberOfCategories
        '
        Me.ucrChkNumberOfCategories.AutoSize = True
        Me.ucrChkNumberOfCategories.Checked = False
        Me.ucrChkNumberOfCategories.Location = New System.Drawing.Point(12, 299)
        Me.ucrChkNumberOfCategories.Name = "ucrChkNumberOfCategories"
        Me.ucrChkNumberOfCategories.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkNumberOfCategories.TabIndex = 0
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 383)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(301, 24)
        Me.ucrSaveGraph.TabIndex = 15
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(53, 8)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(315, 35)
        Me.ucrPnlGraphType.TabIndex = 0
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.AutoSize = True
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(12, 272)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(224, 23)
        Me.ucrChkFlip.TabIndex = 11
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(115, 245)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 10
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.AutoSize = True
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(12, 245)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkWeights.TabIndex = 9
        '
        'ucrReceiverOrderedFactors
        '
        Me.ucrReceiverOrderedFactors.AutoSize = True
        Me.ucrReceiverOrderedFactors.frmParent = Me
        Me.ucrReceiverOrderedFactors.Location = New System.Drawing.Point(262, 99)
        Me.ucrReceiverOrderedFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOrderedFactors.Name = "ucrReceiverOrderedFactors"
        Me.ucrReceiverOrderedFactors.Selector = Nothing
        Me.ucrReceiverOrderedFactors.Size = New System.Drawing.Size(119, 100)
        Me.ucrReceiverOrderedFactors.strNcFilePath = ""
        Me.ucrReceiverOrderedFactors.TabIndex = 6
        Me.ucrReceiverOrderedFactors.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 413)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 14
        '
        'ucrSelectorRatingScale
        '
        Me.ucrSelectorRatingScale.AutoSize = True
        Me.ucrSelectorRatingScale.bDropUnusedFilterLevels = False
        Me.ucrSelectorRatingScale.bShowHiddenColumns = False
        Me.ucrSelectorRatingScale.bUseCurrentFilter = True
        Me.ucrSelectorRatingScale.Location = New System.Drawing.Point(10, 49)
        Me.ucrSelectorRatingScale.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRatingScale.Name = "ucrSelectorRatingScale"
        Me.ucrSelectorRatingScale.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorRatingScale.TabIndex = 4
        '
        'dlgRatingScales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 470)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rating Data"
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
