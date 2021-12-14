﻿' R- Instat
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
Partial Class dlgTransform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTransform))
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
        Me.rdoStandardize = New System.Windows.Forms.RadioButton()
        Me.rdoDifference = New System.Windows.Forms.RadioButton()
        Me.rdoLead = New System.Windows.Forms.RadioButton()
        Me.rdoLag = New System.Windows.Forms.RadioButton()
        Me.grpNumericOptions = New System.Windows.Forms.GroupBox()
        Me.lblLagPosition = New System.Windows.Forms.Label()
        Me.lblRoundofDigits = New System.Windows.Forms.Label()
        Me.lblDiffLag = New System.Windows.Forms.Label()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.lblLagLeadPosition = New System.Windows.Forms.Label()
        Me.grpNonNegative = New System.Windows.Forms.GroupBox()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.rdoSquareRoot = New System.Windows.Forms.RadioButton()
        Me.rdoNaturalLog = New System.Windows.Forms.RadioButton()
        Me.rdoLogToBase10 = New System.Windows.Forms.RadioButton()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoNonNegative = New System.Windows.Forms.RadioButton()
        Me.rdoRank = New System.Windows.Forms.RadioButton()
        Me.rdoSort = New System.Windows.Forms.RadioButton()
        Me.rdoScale = New System.Windows.Forms.RadioButton()
        Me.ttEditPreview = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdUpdatePreview = New System.Windows.Forms.Button()
        Me.ucrInputPower = New instat.ucrInputComboBox()
        Me.ucrInputConstant = New instat.ucrInputComboBox()
        Me.ucrChkAddConstant = New instat.ucrCheck()
        Me.ucrPnlNonNegative = New instat.UcrPanel()
        Me.ucrChkEditPreview = New instat.ucrCheck()
        Me.ucrChkPreview = New instat.ucrCheck()
        Me.ucrInputPreview = New instat.ucrInputTextBox()
        Me.ucrInputAdd = New instat.ucrInputComboBox()
        Me.ucrInputDivide = New instat.ucrInputComboBox()
        Me.ucrInputMultiply = New instat.ucrInputComboBox()
        Me.ucrInputSubtract = New instat.ucrInputComboBox()
        Me.ucrChkAdd = New instat.ucrCheck()
        Me.ucrChkDivide = New instat.ucrCheck()
        Me.ucrChkMultiply = New instat.ucrCheck()
        Me.ucrChkSubtract = New instat.ucrCheck()
        Me.ucrPnlMissingValues = New instat.UcrPanel()
        Me.ucrPnlTransformOptions = New instat.UcrPanel()
        Me.ucrSaveNew = New instat.ucrSave()
        Me.ucrReceiverRank = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkMissingLast = New instat.ucrCheck()
        Me.ucrChkDecreasing = New instat.ucrCheck()
        Me.ucrChkOmitNA = New instat.ucrCheck()
        Me.ucrNudLagPosition = New instat.ucrNud()
        Me.ucrNudRoundOfDigits = New instat.ucrNud()
        Me.ucrNudDiffLag = New instat.ucrNud()
        Me.ucrNudLagLeadPosition = New instat.ucrNud()
        Me.ucrNudSignifDigits = New instat.ucrNud()
        Me.ucrPnlNumericOptions = New instat.UcrPanel()
        Me.ucrPnlTies = New instat.UcrPanel()
        Me.grpTies.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.grpNumericOptions.SuspendLayout()
        Me.grpNonNegative.SuspendLayout()
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
        'rdoStandardize
        '
        resources.ApplyResources(Me.rdoStandardize, "rdoStandardize")
        Me.rdoStandardize.Name = "rdoStandardize"
        Me.rdoStandardize.TabStop = True
        Me.rdoStandardize.UseVisualStyleBackColor = True
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
        Me.grpNumericOptions.Controls.Add(Me.ucrChkOmitNA)
        Me.grpNumericOptions.Controls.Add(Me.rdoDifference)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudLagPosition)
        Me.grpNumericOptions.Controls.Add(Me.lblLagPosition)
        Me.grpNumericOptions.Controls.Add(Me.rdoLead)
        Me.grpNumericOptions.Controls.Add(Me.rdoLag)
        Me.grpNumericOptions.Controls.Add(Me.rdoSignificantDigits)
        Me.grpNumericOptions.Controls.Add(Me.rdoRoundOf)
        Me.grpNumericOptions.Controls.Add(Me.rdoStandardize)
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
        'lblLagPosition
        '
        resources.ApplyResources(Me.lblLagPosition, "lblLagPosition")
        Me.lblLagPosition.Name = "lblLagPosition"
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
        'grpNonNegative
        '
        Me.grpNonNegative.Controls.Add(Me.ucrInputPower)
        Me.grpNonNegative.Controls.Add(Me.rdoPower)
        Me.grpNonNegative.Controls.Add(Me.ucrInputConstant)
        Me.grpNonNegative.Controls.Add(Me.rdoSquareRoot)
        Me.grpNonNegative.Controls.Add(Me.rdoNaturalLog)
        Me.grpNonNegative.Controls.Add(Me.rdoLogToBase10)
        Me.grpNonNegative.Controls.Add(Me.ucrChkAddConstant)
        Me.grpNonNegative.Controls.Add(Me.ucrPnlNonNegative)
        resources.ApplyResources(Me.grpNonNegative, "grpNonNegative")
        Me.grpNonNegative.Name = "grpNonNegative"
        Me.grpNonNegative.TabStop = False
        '
        'rdoPower
        '
        resources.ApplyResources(Me.rdoPower, "rdoPower")
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.TabStop = True
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoSquareRoot
        '
        resources.ApplyResources(Me.rdoSquareRoot, "rdoSquareRoot")
        Me.rdoSquareRoot.Name = "rdoSquareRoot"
        Me.rdoSquareRoot.TabStop = True
        Me.rdoSquareRoot.UseVisualStyleBackColor = True
        '
        'rdoNaturalLog
        '
        resources.ApplyResources(Me.rdoNaturalLog, "rdoNaturalLog")
        Me.rdoNaturalLog.Name = "rdoNaturalLog"
        Me.rdoNaturalLog.TabStop = True
        Me.rdoNaturalLog.UseVisualStyleBackColor = True
        '
        'rdoLogToBase10
        '
        resources.ApplyResources(Me.rdoLogToBase10, "rdoLogToBase10")
        Me.rdoLogToBase10.Name = "rdoLogToBase10"
        Me.rdoLogToBase10.TabStop = True
        Me.rdoLogToBase10.UseVisualStyleBackColor = True
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
        'rdoScale
        '
        resources.ApplyResources(Me.rdoScale, "rdoScale")
        Me.rdoScale.BackColor = System.Drawing.SystemColors.Control
        Me.rdoScale.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScale.FlatAppearance.BorderSize = 2
        Me.rdoScale.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScale.Name = "rdoScale"
        Me.rdoScale.TabStop = True
        Me.rdoScale.Tag = "Frequency"
        Me.rdoScale.UseVisualStyleBackColor = False
        '
        'cmdUpdatePreview
        '
        resources.ApplyResources(Me.cmdUpdatePreview, "cmdUpdatePreview")
        Me.cmdUpdatePreview.Name = "cmdUpdatePreview"
        Me.cmdUpdatePreview.UseVisualStyleBackColor = True
        '
        'ucrInputPower
        '
        Me.ucrInputPower.AddQuotesIfUnrecognised = True
        Me.ucrInputPower.GetSetSelectedIndex = -1
        Me.ucrInputPower.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPower, "ucrInputPower")
        Me.ucrInputPower.Name = "ucrInputPower"
        '
        'ucrInputConstant
        '
        Me.ucrInputConstant.AddQuotesIfUnrecognised = True
        Me.ucrInputConstant.GetSetSelectedIndex = -1
        Me.ucrInputConstant.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputConstant, "ucrInputConstant")
        Me.ucrInputConstant.Name = "ucrInputConstant"
        '
        'ucrChkAddConstant
        '
        Me.ucrChkAddConstant.Checked = False
        resources.ApplyResources(Me.ucrChkAddConstant, "ucrChkAddConstant")
        Me.ucrChkAddConstant.Name = "ucrChkAddConstant"
        '
        'ucrPnlNonNegative
        '
        resources.ApplyResources(Me.ucrPnlNonNegative, "ucrPnlNonNegative")
        Me.ucrPnlNonNegative.Name = "ucrPnlNonNegative"
        '
        'ucrChkEditPreview
        '
        Me.ucrChkEditPreview.Checked = False
        resources.ApplyResources(Me.ucrChkEditPreview, "ucrChkEditPreview")
        Me.ucrChkEditPreview.Name = "ucrChkEditPreview"
        '
        'ucrChkPreview
        '
        Me.ucrChkPreview.Checked = False
        resources.ApplyResources(Me.ucrChkPreview, "ucrChkPreview")
        Me.ucrChkPreview.Name = "ucrChkPreview"
        '
        'ucrInputPreview
        '
        Me.ucrInputPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputPreview.IsMultiline = False
        Me.ucrInputPreview.IsReadOnly = True
        resources.ApplyResources(Me.ucrInputPreview, "ucrInputPreview")
        Me.ucrInputPreview.Name = "ucrInputPreview"
        '
        'ucrInputAdd
        '
        Me.ucrInputAdd.AddQuotesIfUnrecognised = True
        Me.ucrInputAdd.GetSetSelectedIndex = -1
        Me.ucrInputAdd.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputAdd, "ucrInputAdd")
        Me.ucrInputAdd.Name = "ucrInputAdd"
        '
        'ucrInputDivide
        '
        Me.ucrInputDivide.AddQuotesIfUnrecognised = True
        Me.ucrInputDivide.GetSetSelectedIndex = -1
        Me.ucrInputDivide.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDivide, "ucrInputDivide")
        Me.ucrInputDivide.Name = "ucrInputDivide"
        '
        'ucrInputMultiply
        '
        Me.ucrInputMultiply.AddQuotesIfUnrecognised = True
        Me.ucrInputMultiply.GetSetSelectedIndex = -1
        Me.ucrInputMultiply.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMultiply, "ucrInputMultiply")
        Me.ucrInputMultiply.Name = "ucrInputMultiply"
        '
        'ucrInputSubtract
        '
        Me.ucrInputSubtract.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtract.GetSetSelectedIndex = -1
        Me.ucrInputSubtract.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSubtract, "ucrInputSubtract")
        Me.ucrInputSubtract.Name = "ucrInputSubtract"
        '
        'ucrChkAdd
        '
        Me.ucrChkAdd.Checked = False
        resources.ApplyResources(Me.ucrChkAdd, "ucrChkAdd")
        Me.ucrChkAdd.Name = "ucrChkAdd"
        '
        'ucrChkDivide
        '
        Me.ucrChkDivide.Checked = False
        resources.ApplyResources(Me.ucrChkDivide, "ucrChkDivide")
        Me.ucrChkDivide.Name = "ucrChkDivide"
        '
        'ucrChkMultiply
        '
        Me.ucrChkMultiply.Checked = False
        resources.ApplyResources(Me.ucrChkMultiply, "ucrChkMultiply")
        Me.ucrChkMultiply.Name = "ucrChkMultiply"
        '
        'ucrChkSubtract
        '
        Me.ucrChkSubtract.Checked = False
        resources.ApplyResources(Me.ucrChkSubtract, "ucrChkSubtract")
        Me.ucrChkSubtract.Name = "ucrChkSubtract"
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
        'ucrChkOmitNA
        '
        Me.ucrChkOmitNA.Checked = False
        resources.ApplyResources(Me.ucrChkOmitNA, "ucrChkOmitNA")
        Me.ucrChkOmitNA.Name = "ucrChkOmitNA"
        '
        'ucrNudLagPosition
        '
        Me.ucrNudLagPosition.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLagPosition.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLagPosition, "ucrNudLagPosition")
        Me.ucrNudLagPosition.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLagPosition.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLagPosition.Name = "ucrNudLagPosition"
        Me.ucrNudLagPosition.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        'dlgTransform
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdUpdatePreview)
        Me.Controls.Add(Me.grpNonNegative)
        Me.Controls.Add(Me.ucrChkEditPreview)
        Me.Controls.Add(Me.ucrChkPreview)
        Me.Controls.Add(Me.ucrInputPreview)
        Me.Controls.Add(Me.ucrInputAdd)
        Me.Controls.Add(Me.ucrInputDivide)
        Me.Controls.Add(Me.ucrInputMultiply)
        Me.Controls.Add(Me.ucrInputSubtract)
        Me.Controls.Add(Me.ucrChkAdd)
        Me.Controls.Add(Me.ucrChkDivide)
        Me.Controls.Add(Me.ucrChkMultiply)
        Me.Controls.Add(Me.ucrChkSubtract)
        Me.Controls.Add(Me.rdoScale)
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
        Me.Controls.Add(Me.ucrChkMissingLast)
        Me.Controls.Add(Me.ucrChkDecreasing)
        Me.Controls.Add(Me.grpNumericOptions)
        Me.Controls.Add(Me.grpTies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransform"
        Me.Tag = "Transform"
        Me.grpTies.ResumeLayout(False)
        Me.grpTies.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpNumericOptions.ResumeLayout(False)
        Me.grpNumericOptions.PerformLayout()
        Me.grpNonNegative.ResumeLayout(False)
        Me.grpNonNegative.PerformLayout()
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
    Friend WithEvents rdoStandardize As RadioButton
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
    Friend WithEvents ucrNudLagPosition As ucrNud
    Friend WithEvents lblLagPosition As Label
    Friend WithEvents grpNonNegative As GroupBox
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoSquareRoot As RadioButton
    Friend WithEvents rdoNaturalLog As RadioButton
    Friend WithEvents rdoLogToBase10 As RadioButton
    Friend WithEvents ucrPnlNonNegative As UcrPanel
    Friend WithEvents rdoScale As RadioButton
    Friend WithEvents ucrChkAdd As ucrCheck
    Friend WithEvents ucrChkDivide As ucrCheck
    Friend WithEvents ucrChkMultiply As ucrCheck
    Friend WithEvents ucrChkSubtract As ucrCheck
    Friend WithEvents ucrInputAdd As ucrInputComboBox
    Friend WithEvents ucrInputDivide As ucrInputComboBox
    Friend WithEvents ucrInputMultiply As ucrInputComboBox
    Friend WithEvents ucrInputSubtract As ucrInputComboBox
    Friend WithEvents ucrChkAddConstant As ucrCheck
    Friend WithEvents ucrInputPreview As ucrInputTextBox
    Friend WithEvents ucrChkPreview As ucrCheck
    Friend WithEvents ucrChkOmitNA As ucrCheck
    Friend WithEvents ucrChkEditPreview As ucrCheck
    Friend WithEvents ttEditPreview As ToolTip
    Friend WithEvents ucrInputConstant As ucrInputComboBox
    Friend WithEvents ucrInputPower As ucrInputComboBox
    Friend WithEvents cmdUpdatePreview As Button
End Class
