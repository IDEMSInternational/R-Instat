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
Partial Class dlgRecodeFactor
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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.grpSelectedValues = New System.Windows.Forms.GroupBox()
        Me.rdoKeep = New System.Windows.Forms.RadioButton()
        Me.rdoDrop = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMethods = New instat.UcrPanel()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.rdoRecode = New System.Windows.Forms.RadioButton()
        Me.rdoOther = New System.Windows.Forms.RadioButton()
        Me.rdoLump = New System.Windows.Forms.RadioButton()
        Me.grpKeep = New System.Windows.Forms.GroupBox()
        Me.ucrNudFrequentValues = New instat.ucrNud()
        Me.ucrNudCommonValues = New instat.ucrNud()
        Me.ucrNudLevels = New instat.ucrNud()
        Me.rdoMore = New System.Windows.Forms.RadioButton()
        Me.rdoFrequentValues = New System.Windows.Forms.RadioButton()
        Me.rdoCommonValues = New System.Windows.Forms.RadioButton()
        Me.rdoLevels = New System.Windows.Forms.RadioButton()
        Me.ucrPnlKeep = New instat.UcrPanel()
        Me.rdoAddNa = New System.Windows.Forms.RadioButton()
        Me.lblNameForNa = New System.Windows.Forms.Label()
        Me.ucrInputAddNa = New instat.ucrInputTextBox()
        Me.ucrFactorLevels = New instat.ucrFactor()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputOther = New instat.ucrInputTextBox()
        Me.ucrSaveNewColumn = New instat.ucrSave()
        Me.ucrFactorGrid = New instat.ucrFactor()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSelectedValues.SuspendLayout()
        Me.grpKeep.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor.Location = New System.Drawing.Point(248, 56)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblFactor.TabIndex = 6
        Me.lblFactor.Text = "Factor Selected:"
        '
        'grpSelectedValues
        '
        Me.grpSelectedValues.Controls.Add(Me.rdoKeep)
        Me.grpSelectedValues.Controls.Add(Me.rdoDrop)
        Me.grpSelectedValues.Controls.Add(Me.ucrPnlMethods)
        Me.grpSelectedValues.Location = New System.Drawing.Point(10, 240)
        Me.grpSelectedValues.Name = "grpSelectedValues"
        Me.grpSelectedValues.Size = New System.Drawing.Size(152, 59)
        Me.grpSelectedValues.TabIndex = 18
        Me.grpSelectedValues.TabStop = False
        Me.grpSelectedValues.Text = "Selected Values"
        '
        'rdoKeep
        '
        Me.rdoKeep.AutoSize = True
        Me.rdoKeep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoKeep.Location = New System.Drawing.Point(15, 25)
        Me.rdoKeep.Name = "rdoKeep"
        Me.rdoKeep.Size = New System.Drawing.Size(50, 17)
        Me.rdoKeep.TabIndex = 20
        Me.rdoKeep.TabStop = True
        Me.rdoKeep.Text = "Keep"
        Me.rdoKeep.UseVisualStyleBackColor = True
        '
        'rdoDrop
        '
        Me.rdoDrop.AutoSize = True
        Me.rdoDrop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDrop.Location = New System.Drawing.Point(77, 25)
        Me.rdoDrop.Name = "rdoDrop"
        Me.rdoDrop.Size = New System.Drawing.Size(48, 17)
        Me.rdoDrop.TabIndex = 21
        Me.rdoDrop.TabStop = True
        Me.rdoDrop.Text = "Drop"
        Me.rdoDrop.UseVisualStyleBackColor = True
        '
        'ucrPnlMethods
        '
        Me.ucrPnlMethods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMethods.Location = New System.Drawing.Point(5, 15)
        Me.ucrPnlMethods.Name = "ucrPnlMethods"
        Me.ucrPnlMethods.Size = New System.Drawing.Size(140, 37)
        Me.ucrPnlMethods.TabIndex = 19
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOther.Location = New System.Drawing.Point(248, 314)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(82, 13)
        Me.lblOther.TabIndex = 16
        Me.lblOther.Text = "Name for Other:"
        '
        'rdoRecode
        '
        Me.rdoRecode.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRecode.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRecode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRecode.FlatAppearance.BorderSize = 2
        Me.rdoRecode.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRecode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRecode.Location = New System.Drawing.Point(142, 12)
        Me.rdoRecode.Name = "rdoRecode"
        Me.rdoRecode.Size = New System.Drawing.Size(68, 28)
        Me.rdoRecode.TabIndex = 1
        Me.rdoRecode.TabStop = True
        Me.rdoRecode.Tag = "Recode"
        Me.rdoRecode.Text = "Recode"
        Me.rdoRecode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRecode.UseVisualStyleBackColor = False
        '
        'rdoOther
        '
        Me.rdoOther.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOther.BackColor = System.Drawing.SystemColors.Control
        Me.rdoOther.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOther.FlatAppearance.BorderSize = 2
        Me.rdoOther.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOther.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOther.Location = New System.Drawing.Point(276, 12)
        Me.rdoOther.Name = "rdoOther"
        Me.rdoOther.Size = New System.Drawing.Size(75, 28)
        Me.rdoOther.TabIndex = 3
        Me.rdoOther.TabStop = True
        Me.rdoOther.Tag = "Other"
        Me.rdoOther.Text = "Other"
        Me.rdoOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOther.UseVisualStyleBackColor = False
        '
        'rdoLump
        '
        Me.rdoLump.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLump.BackColor = System.Drawing.SystemColors.Control
        Me.rdoLump.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLump.FlatAppearance.BorderSize = 2
        Me.rdoLump.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLump.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLump.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLump.Location = New System.Drawing.Point(350, 12)
        Me.rdoLump.Name = "rdoLump"
        Me.rdoLump.Size = New System.Drawing.Size(75, 28)
        Me.rdoLump.TabIndex = 4
        Me.rdoLump.TabStop = True
        Me.rdoLump.Tag = "Lump"
        Me.rdoLump.Text = "Lump"
        Me.rdoLump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLump.UseVisualStyleBackColor = False
        '
        'grpKeep
        '
        Me.grpKeep.Controls.Add(Me.ucrNudFrequentValues)
        Me.grpKeep.Controls.Add(Me.ucrNudCommonValues)
        Me.grpKeep.Controls.Add(Me.ucrNudLevels)
        Me.grpKeep.Controls.Add(Me.rdoMore)
        Me.grpKeep.Controls.Add(Me.rdoFrequentValues)
        Me.grpKeep.Controls.Add(Me.rdoCommonValues)
        Me.grpKeep.Controls.Add(Me.rdoLevels)
        Me.grpKeep.Controls.Add(Me.ucrPnlKeep)
        Me.grpKeep.Location = New System.Drawing.Point(248, 99)
        Me.grpKeep.Name = "grpKeep"
        Me.grpKeep.Size = New System.Drawing.Size(285, 119)
        Me.grpKeep.TabIndex = 11
        Me.grpKeep.TabStop = False
        Me.grpKeep.Text = "Keep"
        '
        'ucrNudFrequentValues
        '
        Me.ucrNudFrequentValues.AutoSize = True
        Me.ucrNudFrequentValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrequentValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrequentValues.Location = New System.Drawing.Point(208, 67)
        Me.ucrNudFrequentValues.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrequentValues.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrequentValues.Name = "ucrNudFrequentValues"
        Me.ucrNudFrequentValues.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrequentValues.TabIndex = 18
        Me.ucrNudFrequentValues.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCommonValues
        '
        Me.ucrNudCommonValues.AutoSize = True
        Me.ucrNudCommonValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCommonValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCommonValues.Location = New System.Drawing.Point(208, 44)
        Me.ucrNudCommonValues.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCommonValues.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCommonValues.Name = "ucrNudCommonValues"
        Me.ucrNudCommonValues.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCommonValues.TabIndex = 17
        Me.ucrNudCommonValues.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLevels
        '
        Me.ucrNudLevels.AutoSize = True
        Me.ucrNudLevels.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLevels.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLevels.Location = New System.Drawing.Point(208, 21)
        Me.ucrNudLevels.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLevels.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLevels.Name = "ucrNudLevels"
        Me.ucrNudLevels.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLevels.TabIndex = 16
        Me.ucrNudLevels.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoMore
        '
        Me.rdoMore.AutoSize = True
        Me.rdoMore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMore.Location = New System.Drawing.Point(12, 93)
        Me.rdoMore.Name = "rdoMore"
        Me.rdoMore.Size = New System.Drawing.Size(157, 17)
        Me.rdoMore.TabIndex = 16
        Me.rdoMore.TabStop = True
        Me.rdoMore.Text = "Levels with more than Other"
        Me.rdoMore.UseVisualStyleBackColor = True
        '
        'rdoFrequentValues
        '
        Me.rdoFrequentValues.AutoSize = True
        Me.rdoFrequentValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrequentValues.Location = New System.Drawing.Point(12, 70)
        Me.rdoFrequentValues.Name = "rdoFrequentValues"
        Me.rdoFrequentValues.Size = New System.Drawing.Size(184, 17)
        Me.rdoFrequentValues.TabIndex = 15
        Me.rdoFrequentValues.TabStop = True
        Me.rdoFrequentValues.Text = "Levels with at least this proportion"
        Me.rdoFrequentValues.UseVisualStyleBackColor = True
        '
        'rdoCommonValues
        '
        Me.rdoCommonValues.AutoSize = True
        Me.rdoCommonValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCommonValues.Location = New System.Drawing.Point(12, 47)
        Me.rdoCommonValues.Name = "rdoCommonValues"
        Me.rdoCommonValues.Size = New System.Drawing.Size(168, 17)
        Me.rdoCommonValues.TabIndex = 14
        Me.rdoCommonValues.TabStop = True
        Me.rdoCommonValues.Text = "This number of common levels"
        Me.rdoCommonValues.UseVisualStyleBackColor = True
        '
        'rdoLevels
        '
        Me.rdoLevels.AutoSize = True
        Me.rdoLevels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLevels.Location = New System.Drawing.Point(12, 24)
        Me.rdoLevels.Name = "rdoLevels"
        Me.rdoLevels.Size = New System.Drawing.Size(184, 17)
        Me.rdoLevels.TabIndex = 13
        Me.rdoLevels.TabStop = True
        Me.rdoLevels.Text = "Levels with at least this frequency"
        Me.rdoLevels.UseVisualStyleBackColor = True
        '
        'ucrPnlKeep
        '
        Me.ucrPnlKeep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlKeep.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlKeep.Name = "ucrPnlKeep"
        Me.ucrPnlKeep.Size = New System.Drawing.Size(273, 95)
        Me.ucrPnlKeep.TabIndex = 12
        '
        'rdoAddNa
        '
        Me.rdoAddNa.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAddNa.BackColor = System.Drawing.SystemColors.Control
        Me.rdoAddNa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAddNa.FlatAppearance.BorderSize = 2
        Me.rdoAddNa.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAddNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAddNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAddNa.Location = New System.Drawing.Point(209, 12)
        Me.rdoAddNa.Name = "rdoAddNa"
        Me.rdoAddNa.Size = New System.Drawing.Size(68, 28)
        Me.rdoAddNa.TabIndex = 2
        Me.rdoAddNa.TabStop = True
        Me.rdoAddNa.Tag = "add_na"
        Me.rdoAddNa.Text = "Add NA"
        Me.rdoAddNa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAddNa.UseVisualStyleBackColor = False
        '
        'lblNameForNa
        '
        Me.lblNameForNa.AutoSize = True
        Me.lblNameForNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNameForNa.Location = New System.Drawing.Point(248, 97)
        Me.lblNameForNa.Name = "lblNameForNa"
        Me.lblNameForNa.Size = New System.Drawing.Size(71, 13)
        Me.lblNameForNa.TabIndex = 8
        Me.lblNameForNa.Text = "Name for NA:"
        '
        'ucrInputAddNa
        '
        Me.ucrInputAddNa.AddQuotesIfUnrecognised = True
        Me.ucrInputAddNa.AutoSize = True
        Me.ucrInputAddNa.IsMultiline = False
        Me.ucrInputAddNa.IsReadOnly = False
        Me.ucrInputAddNa.Location = New System.Drawing.Point(248, 113)
        Me.ucrInputAddNa.Name = "ucrInputAddNa"
        Me.ucrInputAddNa.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputAddNa.TabIndex = 9
        '
        'ucrFactorLevels
        '
        Me.ucrFactorLevels.AutoSize = True
        Me.ucrFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Location = New System.Drawing.Point(248, 99)
        Me.ucrFactorLevels.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.Size = New System.Drawing.Size(295, 210)
        Me.ucrFactorLevels.TabIndex = 15
        Me.ucrFactorLevels.ucrChkLevels = Nothing
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(139, 6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(289, 36)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrInputOther
        '
        Me.ucrInputOther.AddQuotesIfUnrecognised = True
        Me.ucrInputOther.AutoSize = True
        Me.ucrInputOther.IsMultiline = False
        Me.ucrInputOther.IsReadOnly = False
        Me.ucrInputOther.Location = New System.Drawing.Point(248, 329)
        Me.ucrInputOther.Name = "ucrInputOther"
        Me.ucrInputOther.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputOther.TabIndex = 17
        '
        'ucrSaveNewColumn
        '
        Me.ucrSaveNewColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewColumn.Location = New System.Drawing.Point(10, 381)
        Me.ucrSaveNewColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
        Me.ucrSaveNewColumn.Size = New System.Drawing.Size(358, 22)
        Me.ucrSaveNewColumn.TabIndex = 22
        '
        'ucrFactorGrid
        '
        Me.ucrFactorGrid.AutoSize = True
        Me.ucrFactorGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorGrid.clsReceiver = Nothing
        Me.ucrFactorGrid.Location = New System.Drawing.Point(248, 99)
        Me.ucrFactorGrid.Name = "ucrFactorGrid"
        Me.ucrFactorGrid.shtCurrSheet = Nothing
        Me.ucrFactorGrid.Size = New System.Drawing.Size(288, 210)
        Me.ucrFactorGrid.TabIndex = 10
        Me.ucrFactorGrid.ucrChkLevels = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.AutoSize = True
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(248, 71)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 7
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.AutoSize = True
        Me.ucrSelectorForRecode.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        Me.ucrSelectorForRecode.Location = New System.Drawing.Point(10, 47)
        Me.ucrSelectorForRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        Me.ucrSelectorForRecode.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRecode.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 410)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 23
        '
        'dlgRecodeFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(550, 467)
        Me.Controls.Add(Me.lblNameForNa)
        Me.Controls.Add(Me.ucrInputAddNa)
        Me.Controls.Add(Me.rdoAddNa)
        Me.Controls.Add(Me.ucrFactorLevels)
        Me.Controls.Add(Me.grpKeep)
        Me.Controls.Add(Me.rdoLump)
        Me.Controls.Add(Me.rdoRecode)
        Me.Controls.Add(Me.rdoOther)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.ucrInputOther)
        Me.Controls.Add(Me.grpSelectedValues)
        Me.Controls.Add(Me.ucrSaveNewColumn)
        Me.Controls.Add(Me.ucrFactorGrid)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeFactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recode Factor"
        Me.grpSelectedValues.ResumeLayout(False)
        Me.grpSelectedValues.PerformLayout()
        Me.grpKeep.ResumeLayout(False)
        Me.grpKeep.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrFactorGrid As ucrFactor
    Friend WithEvents ucrSaveNewColumn As ucrSave
    Friend WithEvents grpSelectedValues As GroupBox
    Friend WithEvents ucrPnlMethods As UcrPanel
    Friend WithEvents rdoKeep As RadioButton
    Friend WithEvents rdoDrop As RadioButton
    Friend WithEvents lblOther As Label
    Friend WithEvents ucrInputOther As ucrInputTextBox
    Friend WithEvents rdoLump As RadioButton
    Friend WithEvents rdoRecode As RadioButton
    Friend WithEvents rdoOther As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents grpKeep As GroupBox
    Friend WithEvents rdoMore As RadioButton
    Friend WithEvents rdoFrequentValues As RadioButton
    Friend WithEvents rdoCommonValues As RadioButton
    Friend WithEvents rdoLevels As RadioButton
    Friend WithEvents ucrPnlKeep As UcrPanel
    Friend WithEvents ucrNudFrequentValues As ucrNud
    Friend WithEvents ucrNudCommonValues As ucrNud
    Friend WithEvents ucrNudLevels As ucrNud
    Friend WithEvents ucrFactorLevels As ucrFactor
    Friend WithEvents rdoAddNa As RadioButton
    Friend WithEvents lblNameForNa As Label
    Friend WithEvents ucrInputAddNa As ucrInputTextBox
End Class
