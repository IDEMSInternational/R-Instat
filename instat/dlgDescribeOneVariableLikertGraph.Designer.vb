' R-Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program. If not, see http://www.gnu.org/licenses/.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescribeOneVariableLikertGraph
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDescribeOneVariableLikertGraph))
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.pnlGraph = New System.Windows.Forms.Panel()
        Me.cmdLikertOptions = New System.Windows.Forms.Button()
        Me.grpLikertOptions = New System.Windows.Forms.GroupBox()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoHeat = New System.Windows.Forms.RadioButton()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblFactorsSummary = New System.Windows.Forms.Label()
        Me.ucrChkWrap = New instat.ucrCheck()
        Me.ucrNudWrap = New instat.ucrNud()
        Me.ucrChkCentre = New instat.ucrCheck()
        Me.ucrNudCentre = New instat.ucrNud()
        Me.ucrChkIncludeHistogram = New instat.ucrCheck()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverMultipleLikert = New instat.ucrReceiverMultiple()
        Me.ucrSelectorLikert = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMultipleLikertSummary = New instat.ucrReceiverMultiple()
        Me.ucrSelectorLikertSummary = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveSummary = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.pnlGraph.SuspendLayout()
        Me.grpLikertOptions.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoGraph
        '
        resources.ApplyResources(Me.rdoGraph, "rdoGraph")
        Me.rdoGraph.Checked = True
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.TabStop = True
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'rdoSummary
        '
        resources.ApplyResources(Me.rdoSummary, "rdoSummary")
        Me.rdoSummary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatAppearance.BorderSize = 2
        Me.rdoSummary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.UseVisualStyleBackColor = True
        '
        'pnlGraph
        '
        Me.pnlGraph.Controls.Add(Me.cmdLikertOptions)
        Me.pnlGraph.Controls.Add(Me.grpLikertOptions)
        Me.pnlGraph.Controls.Add(Me.ucrSaveGraph)
        Me.pnlGraph.Controls.Add(Me.lblFactors)
        Me.pnlGraph.Controls.Add(Me.ucrReceiverMultipleLikert)
        Me.pnlGraph.Controls.Add(Me.ucrSelectorLikert)
        resources.ApplyResources(Me.pnlGraph, "pnlGraph")
        Me.pnlGraph.Name = "pnlGraph"
        '
        'cmdLikertOptions
        '
        resources.ApplyResources(Me.cmdLikertOptions, "cmdLikertOptions")
        Me.cmdLikertOptions.Name = "cmdLikertOptions"
        Me.cmdLikertOptions.UseVisualStyleBackColor = True
        '
        'grpLikertOptions
        '
        Me.grpLikertOptions.Controls.Add(Me.ucrChkWrap)
        Me.grpLikertOptions.Controls.Add(Me.ucrNudWrap)
        Me.grpLikertOptions.Controls.Add(Me.ucrChkCentre)
        Me.grpLikertOptions.Controls.Add(Me.ucrNudCentre)
        Me.grpLikertOptions.Controls.Add(Me.ucrChkIncludeHistogram)
        Me.grpLikertOptions.Controls.Add(Me.rdoDensity)
        Me.grpLikertOptions.Controls.Add(Me.rdoHeat)
        Me.grpLikertOptions.Controls.Add(Me.rdoBar)
        Me.grpLikertOptions.Controls.Add(Me.ucrPnlGraphType)
        resources.ApplyResources(Me.grpLikertOptions, "grpLikertOptions")
        Me.grpLikertOptions.Name = "grpLikertOptions"
        Me.grpLikertOptions.TabStop = False
        '
        'rdoDensity
        '
        resources.ApplyResources(Me.rdoDensity, "rdoDensity")
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoHeat
        '
        resources.ApplyResources(Me.rdoHeat, "rdoHeat")
        Me.rdoHeat.Name = "rdoHeat"
        Me.rdoHeat.UseVisualStyleBackColor = True
        '
        'rdoBar
        '
        resources.ApplyResources(Me.rdoBar, "rdoBar")
        Me.rdoBar.Checked = True
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.TabStop = True
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        '
        'pnlSummary
        '
        Me.pnlSummary.Controls.Add(Me.lblFactorsSummary)
        Me.pnlSummary.Controls.Add(Me.ucrReceiverMultipleLikertSummary)
        Me.pnlSummary.Controls.Add(Me.ucrSelectorLikertSummary)
        Me.pnlSummary.Controls.Add(Me.ucrSaveSummary)
        resources.ApplyResources(Me.pnlSummary, "pnlSummary")
        Me.pnlSummary.Name = "pnlSummary"
        '
        'lblFactorsSummary
        '
        resources.ApplyResources(Me.lblFactorsSummary, "lblFactorsSummary")
        Me.lblFactorsSummary.Name = "lblFactorsSummary"
        '
        'ucrChkWrap
        '
        resources.ApplyResources(Me.ucrChkWrap, "ucrChkWrap")
        Me.ucrChkWrap.Checked = False
        Me.ucrChkWrap.Name = "ucrChkWrap"
        '
        'ucrNudWrap
        '
        resources.ApplyResources(Me.ucrNudWrap, "ucrNudWrap")
        Me.ucrNudWrap.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWrap.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWrap.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWrap.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrNudWrap.Name = "ucrNudWrap"
        Me.ucrNudWrap.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'ucrChkCentre
        '
        resources.ApplyResources(Me.ucrChkCentre, "ucrChkCentre")
        Me.ucrChkCentre.Checked = False
        Me.ucrChkCentre.Name = "ucrChkCentre"
        '
        'ucrNudCentre
        '
        resources.ApplyResources(Me.ucrNudCentre, "ucrNudCentre")
        Me.ucrNudCentre.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCentre.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ucrNudCentre.Maximum = New Decimal(New Integer() {35, 0, 0, 65536})
        Me.ucrNudCentre.Minimum = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ucrNudCentre.Name = "ucrNudCentre"
        Me.ucrNudCentre.Value = New Decimal(New Integer() {25, 0, 0, 65536})
        '
        'ucrChkIncludeHistogram
        '
        resources.ApplyResources(Me.ucrChkIncludeHistogram, "ucrChkIncludeHistogram")
        Me.ucrChkIncludeHistogram.Checked = False
        Me.ucrChkIncludeHistogram.Name = "ucrChkIncludeHistogram"
        '
        'ucrPnlGraphType
        '
        resources.ApplyResources(Me.ucrPnlGraphType, "ucrPnlGraphType")
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrReceiverMultipleLikert
        '
        resources.ApplyResources(Me.ucrReceiverMultipleLikert, "ucrReceiverMultipleLikert")
        Me.ucrReceiverMultipleLikert.frmParent = Nothing
        Me.ucrReceiverMultipleLikert.Name = "ucrReceiverMultipleLikert"
        Me.ucrReceiverMultipleLikert.Selector = Nothing
        Me.ucrReceiverMultipleLikert.strNcFilePath = ""
        Me.ucrReceiverMultipleLikert.ucrSelector = Nothing
        '
        'ucrSelectorLikert
        '
        resources.ApplyResources(Me.ucrSelectorLikert, "ucrSelectorLikert")
        Me.ucrSelectorLikert.bDropUnusedFilterLevels = False
        Me.ucrSelectorLikert.bShowHiddenColumns = False
        Me.ucrSelectorLikert.bUseCurrentFilter = True
        Me.ucrSelectorLikert.Name = "ucrSelectorLikert"
        '
        'ucrReceiverMultipleLikertSummary
        '
        resources.ApplyResources(Me.ucrReceiverMultipleLikertSummary, "ucrReceiverMultipleLikertSummary")
        Me.ucrReceiverMultipleLikertSummary.frmParent = Nothing
        Me.ucrReceiverMultipleLikertSummary.Name = "ucrReceiverMultipleLikertSummary"
        Me.ucrReceiverMultipleLikertSummary.Selector = Nothing
        Me.ucrReceiverMultipleLikertSummary.strNcFilePath = ""
        Me.ucrReceiverMultipleLikertSummary.ucrSelector = Nothing
        '
        'ucrSelectorLikertSummary
        '
        resources.ApplyResources(Me.ucrSelectorLikertSummary, "ucrSelectorLikertSummary")
        Me.ucrSelectorLikertSummary.bDropUnusedFilterLevels = False
        Me.ucrSelectorLikertSummary.bShowHiddenColumns = False
        Me.ucrSelectorLikertSummary.bUseCurrentFilter = True
        Me.ucrSelectorLikertSummary.Name = "ucrSelectorLikertSummary"
        '
        'ucrSaveSummary
        '
        resources.ApplyResources(Me.ucrSaveSummary, "ucrSaveSummary")
        Me.ucrSaveSummary.Name = "ucrSaveSummary"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgDescribeOneVariableLikertGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.pnlGraph)
        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeOneVariableLikertGraph"
        Me.pnlGraph.ResumeLayout(False)
        Me.pnlGraph.PerformLayout()
        Me.grpLikertOptions.ResumeLayout(False)
        Me.grpLikertOptions.PerformLayout()
        Me.pnlSummary.ResumeLayout(False)
        Me.pnlSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents pnlGraph As Panel
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents ucrSelectorLikert As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrReceiverMultipleLikert As ucrReceiverMultiple
    Friend WithEvents grpLikertOptions As GroupBox
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents rdoHeat As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents ucrChkIncludeHistogram As ucrCheck
    Friend WithEvents ucrChkCentre As ucrCheck
    Friend WithEvents ucrNudCentre As ucrNud
    Friend WithEvents ucrChkWrap As ucrCheck
    Friend WithEvents ucrNudWrap As ucrNud
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrSelectorLikertSummary As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorsSummary As Label
    Friend WithEvents ucrReceiverMultipleLikertSummary As ucrReceiverMultiple
    Friend WithEvents ucrSaveSummary As ucrSave
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdLikertOptions As Button
End Class