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
Partial Class dlgRank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRank))
        Me.lblSelectColumns = New System.Windows.Forms.Label()
        Me.grpTies = New System.Windows.Forms.GroupBox()
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoAverage = New System.Windows.Forms.RadioButton()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirstMissingValues = New System.Windows.Forms.RadioButton()
        Me.rdoKeptAsMissing = New System.Windows.Forms.RadioButton()
        Me.rdoRoundOf = New System.Windows.Forms.RadioButton()
        Me.rdoSignificantDigits = New System.Windows.Forms.RadioButton()
        Me.rdoScale = New System.Windows.Forms.RadioButton()
        Me.rdoDifference = New System.Windows.Forms.RadioButton()
        Me.rdoLead = New System.Windows.Forms.RadioButton()
        Me.rdoLag = New System.Windows.Forms.RadioButton()
        Me.grpNumericOptions = New System.Windows.Forms.GroupBox()
        Me.lblRoundofDigits = New System.Windows.Forms.Label()
        Me.lblDiffLag = New System.Windows.Forms.Label()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.lblLagLeadPosition = New System.Windows.Forms.Label()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoNonNegative = New System.Windows.Forms.RadioButton()
        Me.rdoRank = New System.Windows.Forms.RadioButton()
        Me.rdoSort = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMissingValues = New instat.UcrPanel()
        Me.ucrPnlTransformOptions = New instat.UcrPanel()
        Me.ucrSaveNew = New instat.ucrSave()
        Me.ucrReceiverRank = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrNudRoundOfDigits = New instat.ucrNud()
        Me.ucrNudDiffLag = New instat.ucrNud()
        Me.ucrNudLagLeadPosition = New instat.ucrNud()
        Me.ucrNudSignifDigits = New instat.ucrNud()
        Me.ucrPnlNumericOptions = New instat.UcrPanel()
        Me.ucrPnlTies = New instat.UcrPanel()
        Me.ucrChkMissingLast = New instat.ucrCheck()
        Me.ucrChkDecreasing = New instat.ucrCheck()
        Me.grpTies.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.grpNumericOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectColumns
        '
        resources.ApplyResources(Me.lblSelectColumns, "lblSelectColumns")
        Me.lblSelectColumns.Name = "lblSelectColumns"
        Me.lblSelectColumns.Tag = ""
        '
        'grpTies
        '
        Me.grpTies.Controls.Add(Me.rdoRandom)
        Me.grpTies.Controls.Add(Me.rdoFirst)
        Me.grpTies.Controls.Add(Me.rdoMaximum)
        Me.grpTies.Controls.Add(Me.rdoMinimum)
        Me.grpTies.Controls.Add(Me.rdoAverage)
        Me.grpTies.Controls.Add(Me.ucrPnlTies)
        resources.ApplyResources(Me.grpTies, "grpTies")
        Me.grpTies.Name = "grpTies"
        Me.grpTies.TabStop = False
        Me.grpTies.Tag = "Ties"
        '
        'rdoRandom
        '
        resources.ApplyResources(Me.rdoRandom, "rdoRandom")
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.Tag = "Random"
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        resources.ApplyResources(Me.rdoFirst, "rdoFirst")
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        resources.ApplyResources(Me.rdoMaximum, "rdoMaximum")
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoMinimum
        '
        resources.ApplyResources(Me.rdoMinimum, "rdoMinimum")
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoAverage
        '
        resources.ApplyResources(Me.rdoAverage, "rdoAverage")
        Me.rdoAverage.Name = "rdoAverage"
        Me.rdoAverage.TabStop = True
        Me.rdoAverage.Tag = "Average"
        Me.rdoAverage.UseVisualStyleBackColor = True
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.rdoLast)
        Me.grpMissingValues.Controls.Add(Me.rdoFirstMissingValues)
        Me.grpMissingValues.Controls.Add(Me.rdoKeptAsMissing)
        Me.grpMissingValues.Controls.Add(Me.ucrPnlMissingValues)
        resources.ApplyResources(Me.grpMissingValues, "grpMissingValues")
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Tag = "Misssing_Values"
        '
        'rdoLast
        '
        resources.ApplyResources(Me.rdoLast, "rdoLast")
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirstMissingValues
        '
        resources.ApplyResources(Me.rdoFirstMissingValues, "rdoFirstMissingValues")
        Me.rdoFirstMissingValues.Name = "rdoFirstMissingValues"
        Me.rdoFirstMissingValues.TabStop = True
        Me.rdoFirstMissingValues.Tag = "First"
        Me.rdoFirstMissingValues.UseVisualStyleBackColor = True
        '
        'rdoKeptAsMissing
        '
        resources.ApplyResources(Me.rdoKeptAsMissing, "rdoKeptAsMissing")
        Me.rdoKeptAsMissing.Name = "rdoKeptAsMissing"
        Me.rdoKeptAsMissing.TabStop = True
        Me.rdoKeptAsMissing.Tag = "Kept_as_missing"
        Me.rdoKeptAsMissing.UseVisualStyleBackColor = True
        '
        'rdoRoundOf
        '
        resources.ApplyResources(Me.rdoRoundOf, "rdoRoundOf")
        Me.rdoRoundOf.Name = "rdoRoundOf"
        Me.rdoRoundOf.TabStop = True
        Me.rdoRoundOf.UseVisualStyleBackColor = True
        '
        'rdoSignificantDigits
        '
        resources.ApplyResources(Me.rdoSignificantDigits, "rdoSignificantDigits")
        Me.rdoSignificantDigits.Name = "rdoSignificantDigits"
        Me.rdoSignificantDigits.TabStop = True
        Me.rdoSignificantDigits.UseVisualStyleBackColor = True
        '
        'rdoScale
        '
        resources.ApplyResources(Me.rdoScale, "rdoScale")
        Me.rdoScale.Name = "rdoScale"
        Me.rdoScale.TabStop = True
        Me.rdoScale.UseVisualStyleBackColor = True
        '
        'rdoDifference
        '
        resources.ApplyResources(Me.rdoDifference, "rdoDifference")
        Me.rdoDifference.Name = "rdoDifference"
        Me.rdoDifference.TabStop = True
        Me.rdoDifference.UseVisualStyleBackColor = True
        '
        'rdoLead
        '
        resources.ApplyResources(Me.rdoLead, "rdoLead")
        Me.rdoLead.Name = "rdoLead"
        Me.rdoLead.TabStop = True
        Me.rdoLead.UseVisualStyleBackColor = True
        '
        'rdoLag
        '
        resources.ApplyResources(Me.rdoLag, "rdoLag")
        Me.rdoLag.Name = "rdoLag"
        Me.rdoLag.TabStop = True
        Me.rdoLag.UseVisualStyleBackColor = True
        '
        'grpNumericOptions
        '
        Me.grpNumericOptions.Controls.Add(Me.rdoLead)
        Me.grpNumericOptions.Controls.Add(Me.rdoDifference)
        Me.grpNumericOptions.Controls.Add(Me.rdoLag)
        Me.grpNumericOptions.Controls.Add(Me.rdoSignificantDigits)
        Me.grpNumericOptions.Controls.Add(Me.rdoRoundOf)
        Me.grpNumericOptions.Controls.Add(Me.rdoScale)
        Me.grpNumericOptions.Controls.Add(Me.lblRoundofDigits)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudRoundOfDigits)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudDiffLag)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudLagLeadPosition)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudSignifDigits)
        Me.grpNumericOptions.Controls.Add(Me.lblDiffLag)
        Me.grpNumericOptions.Controls.Add(Me.lblDigits)
        Me.grpNumericOptions.Controls.Add(Me.lblLagLeadPosition)
        Me.grpNumericOptions.Controls.Add(Me.ucrPnlNumericOptions)
        resources.ApplyResources(Me.grpNumericOptions, "grpNumericOptions")
        Me.grpNumericOptions.Name = "grpNumericOptions"
        Me.grpNumericOptions.TabStop = False
        '
        'lblRoundofDigits
        '
        resources.ApplyResources(Me.lblRoundofDigits, "lblRoundofDigits")
        Me.lblRoundofDigits.Name = "lblRoundofDigits"
        '
        'lblDiffLag
        '
        resources.ApplyResources(Me.lblDiffLag, "lblDiffLag")
        Me.lblDiffLag.Name = "lblDiffLag"
        '
        'lblDigits
        '
        resources.ApplyResources(Me.lblDigits, "lblDigits")
        Me.lblDigits.Name = "lblDigits"
        '
        'lblLagLeadPosition
        '
        resources.ApplyResources(Me.lblLagLeadPosition, "lblLagLeadPosition")
        Me.lblLagLeadPosition.Name = "lblLagLeadPosition"
        '
        'rdoNumeric
        '
        resources.ApplyResources(Me.rdoNumeric, "rdoNumeric")
        Me.rdoNumeric.BackColor = System.Drawing.SystemColors.Control
        Me.rdoNumeric.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNumeric.FlatAppearance.BorderSize = 2
        Me.rdoNumeric.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.TabStop = True
        Me.rdoNumeric.Tag = "Frequency"
        Me.rdoNumeric.UseVisualStyleBackColor = False
        '
        'rdoNonNegative
        '
        resources.ApplyResources(Me.rdoNonNegative, "rdoNonNegative")
        Me.rdoNonNegative.BackColor = System.Drawing.SystemColors.Control
        Me.rdoNonNegative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNonNegative.FlatAppearance.BorderSize = 2
        Me.rdoNonNegative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNonNegative.Name = "rdoNonNegative"
        Me.rdoNonNegative.TabStop = True
        Me.rdoNonNegative.Tag = "Frequency"
        Me.rdoNonNegative.UseVisualStyleBackColor = False
        '
        'rdoRank
        '
        resources.ApplyResources(Me.rdoRank, "rdoRank")
        Me.rdoRank.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRank.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRank.FlatAppearance.BorderSize = 2
        Me.rdoRank.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRank.Name = "rdoRank"
        Me.rdoRank.TabStop = True
        Me.rdoRank.Tag = "Frequency"
        Me.rdoRank.UseVisualStyleBackColor = False
        '
        'rdoSort
        '
        resources.ApplyResources(Me.rdoSort, "rdoSort")
        Me.rdoSort.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSort.FlatAppearance.BorderSize = 2
        Me.rdoSort.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSort.Name = "rdoSort"
        Me.rdoSort.TabStop = True
        Me.rdoSort.Tag = "Frequency"
        Me.rdoSort.UseVisualStyleBackColor = False
        '
        'ucrPnlMissingValues
        '
        resources.ApplyResources(Me.ucrPnlMissingValues, "ucrPnlMissingValues")
        Me.ucrPnlMissingValues.Name = "ucrPnlMissingValues"
        '
        'ucrPnlTransformOptions
        '
        resources.ApplyResources(Me.ucrPnlTransformOptions, "ucrPnlTransformOptions")
        Me.ucrPnlTransformOptions.Name = "ucrPnlTransformOptions"
        '
        'ucrSaveNew
        '
        resources.ApplyResources(Me.ucrSaveNew, "ucrSaveNew")
        Me.ucrSaveNew.Name = "ucrSaveNew"
        '
        'ucrReceiverRank
        '
        Me.ucrReceiverRank.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRank, "ucrReceiverRank")
        Me.ucrReceiverRank.Name = "ucrReceiverRank"
        Me.ucrReceiverRank.Selector = Nothing
        Me.ucrReceiverRank.strNcFilePath = ""
        Me.ucrReceiverRank.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorForRank
        '
        Me.ucrSelectorForRank.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRank.bShowHiddenColumns = False
        Me.ucrSelectorForRank.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForRank, "ucrSelectorForRank")
        Me.ucrSelectorForRank.Name = "ucrSelectorForRank"
        '
        'ucrNudRoundOfDigits
        '
        Me.ucrNudRoundOfDigits.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRoundOfDigits.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRoundOfDigits, "ucrNudRoundOfDigits")
        Me.ucrNudRoundOfDigits.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRoundOfDigits.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRoundOfDigits.Name = "ucrNudRoundOfDigits"
        Me.ucrNudRoundOfDigits.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDiffLag
        '
        Me.ucrNudDiffLag.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDiffLag.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDiffLag, "ucrNudDiffLag")
        Me.ucrNudDiffLag.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDiffLag.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDiffLag.Name = "ucrNudDiffLag"
        Me.ucrNudDiffLag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLagLeadPosition
        '
        Me.ucrNudLagLeadPosition.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLagLeadPosition.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLagLeadPosition, "ucrNudLagLeadPosition")
        Me.ucrNudLagLeadPosition.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLagLeadPosition.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLagLeadPosition.Name = "ucrNudLagLeadPosition"
        Me.ucrNudLagLeadPosition.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSignifDigits
        '
        Me.ucrNudSignifDigits.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSignifDigits.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSignifDigits, "ucrNudSignifDigits")
        Me.ucrNudSignifDigits.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSignifDigits.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSignifDigits.Name = "ucrNudSignifDigits"
        Me.ucrNudSignifDigits.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlNumericOptions
        '
        resources.ApplyResources(Me.ucrPnlNumericOptions, "ucrPnlNumericOptions")
        Me.ucrPnlNumericOptions.Name = "ucrPnlNumericOptions"
        '
        'ucrPnlTies
        '
        resources.ApplyResources(Me.ucrPnlTies, "ucrPnlTies")
        Me.ucrPnlTies.Name = "ucrPnlTies"
        '
        'ucrChkMissingLast
        '
        Me.ucrChkMissingLast.Checked = False
        resources.ApplyResources(Me.ucrChkMissingLast, "ucrChkMissingLast")
        Me.ucrChkMissingLast.Name = "ucrChkMissingLast"
        '
        'ucrChkDecreasing
        '
        Me.ucrChkDecreasing.Checked = False
        resources.ApplyResources(Me.ucrChkDecreasing, "ucrChkDecreasing")
        Me.ucrChkDecreasing.Name = "ucrChkDecreasing"
        '
        'dlgRank
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoSort)
        Me.Controls.Add(Me.rdoRank)
        Me.Controls.Add(Me.rdoNonNegative)
        Me.Controls.Add(Me.rdoNumeric)
        Me.Controls.Add(Me.grpMissingValues)
        Me.Controls.Add(Me.ucrPnlTransformOptions)
        Me.Controls.Add(Me.ucrSaveNew)
        Me.Controls.Add(Me.lblSelectColumns)
        Me.Controls.Add(Me.ucrReceiverRank)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorForRank)
        Me.Controls.Add(Me.grpNumericOptions)
        Me.Controls.Add(Me.grpTies)
        Me.Controls.Add(Me.ucrChkMissingLast)
        Me.Controls.Add(Me.ucrChkDecreasing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRank"
        Me.Tag = "Rank"
        Me.grpTies.ResumeLayout(False)
        Me.grpTies.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpNumericOptions.ResumeLayout(False)
        Me.grpNumericOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverRank As ucrReceiverSingle
    Friend WithEvents lblSelectColumns As Label
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents rdoKeptAsMissing As RadioButton
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirstMissingValues As RadioButton
    Friend WithEvents ucrSelectorForRank As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpTies As GroupBox
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoAverage As RadioButton
    Friend WithEvents ucrPnlTies As UcrPanel
    Friend WithEvents ucrPnlMissingValues As UcrPanel
    Friend WithEvents ucrSaveNew As ucrSave
    Friend WithEvents ucrPnlTransformOptions As UcrPanel
    Friend WithEvents ucrChkMissingLast As ucrCheck
    Friend WithEvents ucrChkDecreasing As ucrCheck
    Friend WithEvents rdoSignificantDigits As RadioButton
    Friend WithEvents rdoRoundOf As RadioButton
    Friend WithEvents ucrPnlNumericOptions As UcrPanel
    Friend WithEvents grpNumericOptions As GroupBox
    Friend WithEvents rdoLead As RadioButton
    Friend WithEvents rdoDifference As RadioButton
    Friend WithEvents rdoLag As RadioButton
    Friend WithEvents rdoScale As RadioButton
    Friend WithEvents lblDigits As Label
    Friend WithEvents ucrNudSignifDigits As ucrNud
    Friend WithEvents lblLagLeadPosition As Label
    Friend WithEvents ucrNudLagLeadPosition As ucrNud
    Friend WithEvents ucrNudDiffLag As ucrNud
    Friend WithEvents lblDiffLag As Label
    Friend WithEvents lblRoundofDigits As Label
    Friend WithEvents ucrNudRoundOfDigits As ucrNud
    Friend WithEvents rdoNonNegative As RadioButton
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents rdoSort As RadioButton
    Friend WithEvents rdoRank As RadioButton
End Class
