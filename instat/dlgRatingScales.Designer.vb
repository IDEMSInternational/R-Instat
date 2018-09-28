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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRatingScales))
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
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.grpSort.SuspendLayout()
        Me.grpLikertType.SuspendLayout()
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
        Me.grpSort.Controls.Add(Me.ucrPnlSjpLikert)
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
        'ucrPnlSjpLikert
        '
        resources.ApplyResources(Me.ucrPnlSjpLikert, "ucrPnlSjpLikert")
        Me.ucrPnlSjpLikert.Name = "ucrPnlSjpLikert"
        '
        'grpLikertType
        '
        Me.grpLikertType.Controls.Add(Me.ucrChkNumberOfCategories)
        Me.grpLikertType.Controls.Add(Me.ucrNudNeutralLevel)
        Me.grpLikertType.Controls.Add(Me.lblNeutralLevel)
        Me.grpLikertType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.grpLikertType, "grpLikertType")
        Me.grpLikertType.Name = "grpLikertType"
        Me.grpLikertType.TabStop = False
        Me.grpLikertType.Tag = "Graph_type"
        '
        'ucrChkNumberOfCategories
        '
        Me.ucrChkNumberOfCategories.Checked = False
        resources.ApplyResources(Me.ucrChkNumberOfCategories, "ucrChkNumberOfCategories")
        Me.ucrChkNumberOfCategories.Name = "ucrChkNumberOfCategories"
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
        'lblNeutralLevel
        '
        resources.ApplyResources(Me.lblNeutralLevel, "lblNeutralLevel")
        Me.lblNeutralLevel.Name = "lblNeutralLevel"
        Me.lblNeutralLevel.Tag = "Neutral_Level"
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
        Me.ucrSelectorRatingScale.bShowHiddenColumns = False
        Me.ucrSelectorRatingScale.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRatingScale, "ucrSelectorRatingScale")
        Me.ucrSelectorRatingScale.Name = "ucrSelectorRatingScale"
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.UcrDialogDisabled1, "UcrDialogDisabled1")
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        '
        'dlgRatingScales
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcrDialogDisabled1)
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
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
End Class
