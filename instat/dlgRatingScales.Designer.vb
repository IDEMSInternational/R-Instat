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
        Me.lblOrderedFactor = New System.Windows.Forms.Label()
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.rdoHighDescendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoLowDescendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoLowAscendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoNoneLikert = New System.Windows.Forms.RadioButton()
        Me.rdoHighAscendingLikert = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSjpLikert = New instat.UcrPanel()
        Me.grpLikertType = New System.Windows.Forms.GroupBox()
        Me.ucrChkNumberOfCategories = New instat.ucrCheck()
        Me.ucrNudNeutralLevel = New instat.ucrNud()
        Me.lblNeutralLevel = New System.Windows.Forms.Label()
        Me.rdoStacked = New System.Windows.Forms.RadioButton()
        Me.rdoLikert = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverOrderedFactors = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorRatingScale = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpSort.SuspendLayout()
        Me.grpLikertType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOrderedFactor
        '
        Me.lblOrderedFactor.AutoSize = True
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
        Me.grpSort.Controls.Add(Me.ucrPnlSjpLikert)
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
        Me.rdoHighAscendingLikert.Location = New System.Drawing.Point(14, 91)
        Me.rdoHighAscendingLikert.Name = "rdoHighAscendingLikert"
        Me.rdoHighAscendingLikert.Size = New System.Drawing.Size(100, 17)
        Me.rdoHighAscendingLikert.TabIndex = 5
        Me.rdoHighAscendingLikert.TabStop = True
        Me.rdoHighAscendingLikert.Text = "High Ascending"
        Me.rdoHighAscendingLikert.UseVisualStyleBackColor = True
        '
        'ucrPnlSjpLikert
        '
        Me.ucrPnlSjpLikert.Location = New System.Drawing.Point(8, 14)
        Me.ucrPnlSjpLikert.Name = "ucrPnlSjpLikert"
        Me.ucrPnlSjpLikert.Size = New System.Drawing.Size(126, 127)
        Me.ucrPnlSjpLikert.TabIndex = 1
        '
        'grpLikertType
        '
        Me.grpLikertType.Controls.Add(Me.ucrChkNumberOfCategories)
        Me.grpLikertType.Controls.Add(Me.ucrNudNeutralLevel)
        Me.grpLikertType.Controls.Add(Me.lblNeutralLevel)
        Me.grpLikertType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpLikertType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLikertType.Location = New System.Drawing.Point(10, 297)
        Me.grpLikertType.Name = "grpLikertType"
        Me.grpLikertType.Size = New System.Drawing.Size(224, 80)
        Me.grpLikertType.TabIndex = 12
        Me.grpLikertType.TabStop = False
        Me.grpLikertType.Tag = "Graph_type"
        Me.grpLikertType.Text = "Likert Options"
        '
        'ucrChkNumberOfCategories
        '
        Me.ucrChkNumberOfCategories.Checked = False
        Me.ucrChkNumberOfCategories.Location = New System.Drawing.Point(6, 26)
        Me.ucrChkNumberOfCategories.Name = "ucrChkNumberOfCategories"
        Me.ucrChkNumberOfCategories.Size = New System.Drawing.Size(212, 20)
        Me.ucrChkNumberOfCategories.TabIndex = 0
        '
        'ucrNudNeutralLevel
        '
        Me.ucrNudNeutralLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNeutralLevel.Location = New System.Drawing.Point(83, 52)
        Me.ucrNudNeutralLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNeutralLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Name = "ucrNudNeutralLevel"
        Me.ucrNudNeutralLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNeutralLevel.TabIndex = 2
        Me.ucrNudNeutralLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNeutralLevel
        '
        Me.lblNeutralLevel.AutoSize = True
        Me.lblNeutralLevel.Location = New System.Drawing.Point(8, 56)
        Me.lblNeutralLevel.Name = "lblNeutralLevel"
        Me.lblNeutralLevel.Size = New System.Drawing.Size(73, 13)
        Me.lblNeutralLevel.TabIndex = 1
        Me.lblNeutralLevel.Tag = "Neutral_Level"
        Me.lblNeutralLevel.Text = "Neutral Level:"
        '
        'rdoStacked
        '
        Me.rdoStacked.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStacked.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStacked.FlatAppearance.BorderSize = 2
        Me.rdoStacked.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStacked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.rdoTable.Location = New System.Drawing.Point(64, 10)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 383)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveGraph.TabIndex = 15
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(53, 8)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(315, 35)
        Me.ucrPnlGraphType.TabIndex = 0
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(12, 271)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(224, 20)
        Me.ucrChkFlip.TabIndex = 11
        '
        'ucrReceiverWeights
        '
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
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(12, 245)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 9
        '
        'ucrReceiverOrderedFactors
        '
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 413)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 14
        '
        'ucrSelectorRatingScale
        '
        Me.ucrSelectorRatingScale.bShowHiddenColumns = False
        Me.ucrSelectorRatingScale.bUseCurrentFilter = True
        Me.ucrSelectorRatingScale.Location = New System.Drawing.Point(10, 49)
        Me.ucrSelectorRatingScale.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRatingScale.Name = "ucrSelectorRatingScale"
        Me.ucrSelectorRatingScale.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorRatingScale.TabIndex = 4
        '
        'dlgRatingScales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 470)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.rdoStacked)
        Me.Controls.Add(Me.rdoLikert)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.ucrPnlGraphType)
        Me.Controls.Add(Me.grpLikertType)
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
        Me.grpLikertType.ResumeLayout(False)
        Me.grpLikertType.PerformLayout()
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
    Friend WithEvents grpLikertType As GroupBox
    Friend WithEvents ucrNudNeutralLevel As ucrNud
    Friend WithEvents lblNeutralLevel As Label
    Friend WithEvents rdoHighDescendingLikert As RadioButton
    Friend WithEvents rdoNoneLikert As RadioButton
    Friend WithEvents rdoHighAscendingLikert As RadioButton
    Friend WithEvents rdoLowDescendingLikert As RadioButton
    Friend WithEvents rdoLowAscendingLikert As RadioButton
    Friend WithEvents ucrPnlSjpLikert As UcrPanel
    Friend WithEvents rdoStacked As RadioButton
    Friend WithEvents rdoLikert As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents ucrChkNumberOfCategories As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
