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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRecodeFactor))
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.grpSelectedValues = New System.Windows.Forms.GroupBox()
        Me.rdoKeep = New System.Windows.Forms.RadioButton()
        Me.rdoDrop = New System.Windows.Forms.RadioButton()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.rdoRecode = New System.Windows.Forms.RadioButton()
        Me.rdoOther = New System.Windows.Forms.RadioButton()
        Me.rdoLump = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputOther = New instat.ucrInputTextBox()
        Me.ucrPnlMethods = New instat.UcrPanel()
        Me.ucrSaveNewColumn = New instat.ucrSave()
        Me.ucrFactorGrid = New instat.ucrFactor()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpKeep = New System.Windows.Forms.GroupBox()
        Me.ucrPnlKeep = New instat.UcrPanel()
        Me.rdoLevels = New System.Windows.Forms.RadioButton()
        Me.rdoCommonValues = New System.Windows.Forms.RadioButton()
        Me.rdoFrequentValues = New System.Windows.Forms.RadioButton()
        Me.rdoMore = New System.Windows.Forms.RadioButton()
        Me.ucrNudLevels = New instat.ucrNud()
        Me.ucrNudCommonValues = New instat.ucrNud()
        Me.ucrNudFrequentValues = New instat.ucrNud()
        Me.grpSelectedValues.SuspendLayout()
        Me.grpKeep.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        '
        'grpSelectedValues
        '
        Me.grpSelectedValues.Controls.Add(Me.rdoKeep)
        Me.grpSelectedValues.Controls.Add(Me.rdoDrop)
        Me.grpSelectedValues.Controls.Add(Me.ucrPnlMethods)
        resources.ApplyResources(Me.grpSelectedValues, "grpSelectedValues")
        Me.grpSelectedValues.Name = "grpSelectedValues"
        Me.grpSelectedValues.TabStop = False
        '
        'rdoKeep
        '
        resources.ApplyResources(Me.rdoKeep, "rdoKeep")
        Me.rdoKeep.Name = "rdoKeep"
        Me.rdoKeep.TabStop = True
        Me.rdoKeep.UseVisualStyleBackColor = True
        '
        'rdoDrop
        '
        resources.ApplyResources(Me.rdoDrop, "rdoDrop")
        Me.rdoDrop.Name = "rdoDrop"
        Me.rdoDrop.TabStop = True
        Me.rdoDrop.UseVisualStyleBackColor = True
        '
        'lblOther
        '
        resources.ApplyResources(Me.lblOther, "lblOther")
        Me.lblOther.Name = "lblOther"
        '
        'rdoRecode
        '
        resources.ApplyResources(Me.rdoRecode, "rdoRecode")
        Me.rdoRecode.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRecode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRecode.FlatAppearance.BorderSize = 2
        Me.rdoRecode.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRecode.Name = "rdoRecode"
        Me.rdoRecode.TabStop = True
        Me.rdoRecode.Tag = "Recode"
        Me.rdoRecode.UseVisualStyleBackColor = False
        '
        'rdoOther
        '
        resources.ApplyResources(Me.rdoOther, "rdoOther")
        Me.rdoOther.BackColor = System.Drawing.SystemColors.Control
        Me.rdoOther.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOther.FlatAppearance.BorderSize = 2
        Me.rdoOther.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOther.Name = "rdoOther"
        Me.rdoOther.TabStop = True
        Me.rdoOther.Tag = "Other"
        Me.rdoOther.UseVisualStyleBackColor = False
        '
        'rdoLump
        '
        resources.ApplyResources(Me.rdoLump, "rdoLump")
        Me.rdoLump.BackColor = System.Drawing.SystemColors.Control
        Me.rdoLump.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLump.FlatAppearance.BorderSize = 2
        Me.rdoLump.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLump.Name = "rdoLump"
        Me.rdoLump.TabStop = True
        Me.rdoLump.Tag = "Lump"
        Me.rdoLump.UseVisualStyleBackColor = False
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrInputOther
        '
        Me.ucrInputOther.AddQuotesIfUnrecognised = True
        Me.ucrInputOther.IsMultiline = False
        Me.ucrInputOther.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOther, "ucrInputOther")
        Me.ucrInputOther.Name = "ucrInputOther"
        '
        'ucrPnlMethods
        '
        resources.ApplyResources(Me.ucrPnlMethods, "ucrPnlMethods")
        Me.ucrPnlMethods.Name = "ucrPnlMethods"
        '
        'ucrSaveNewColumn
        '
        resources.ApplyResources(Me.ucrSaveNewColumn, "ucrSaveNewColumn")
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
        '
        'ucrFactorGrid
        '
        resources.ApplyResources(Me.ucrFactorGrid, "ucrFactorGrid")
        Me.ucrFactorGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorGrid.clsReceiver = Nothing
        Me.ucrFactorGrid.Name = "ucrFactorGrid"
        Me.ucrFactorGrid.shtCurrSheet = Nothing
        Me.ucrFactorGrid.ucrChkLevels = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForRecode, "ucrSelectorForRecode")
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
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
        resources.ApplyResources(Me.grpKeep, "grpKeep")
        Me.grpKeep.Name = "grpKeep"
        Me.grpKeep.TabStop = False
        '
        'ucrPnlKeep
        '
        resources.ApplyResources(Me.ucrPnlKeep, "ucrPnlKeep")
        Me.ucrPnlKeep.Name = "ucrPnlKeep"
        '
        'rdoLevels
        '
        resources.ApplyResources(Me.rdoLevels, "rdoLevels")
        Me.rdoLevels.Name = "rdoLevels"
        Me.rdoLevels.TabStop = True
        Me.rdoLevels.UseVisualStyleBackColor = True
        '
        'rdoCommonValues
        '
        resources.ApplyResources(Me.rdoCommonValues, "rdoCommonValues")
        Me.rdoCommonValues.Name = "rdoCommonValues"
        Me.rdoCommonValues.TabStop = True
        Me.rdoCommonValues.UseVisualStyleBackColor = True
        '
        'rdoFrequentValues
        '
        resources.ApplyResources(Me.rdoFrequentValues, "rdoFrequentValues")
        Me.rdoFrequentValues.Name = "rdoFrequentValues"
        Me.rdoFrequentValues.TabStop = True
        Me.rdoFrequentValues.UseVisualStyleBackColor = True
        '
        'rdoMore
        '
        resources.ApplyResources(Me.rdoMore, "rdoMore")
        Me.rdoMore.Name = "rdoMore"
        Me.rdoMore.TabStop = True
        Me.rdoMore.UseVisualStyleBackColor = True
        '
        'ucrNudLevels
        '
        Me.ucrNudLevels.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLevels.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLevels, "ucrNudLevels")
        Me.ucrNudLevels.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLevels.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLevels.Name = "ucrNudLevels"
        Me.ucrNudLevels.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCommonValues
        '
        Me.ucrNudCommonValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCommonValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCommonValues, "ucrNudCommonValues")
        Me.ucrNudCommonValues.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCommonValues.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCommonValues.Name = "ucrNudCommonValues"
        Me.ucrNudCommonValues.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrequentValues
        '
        Me.ucrNudFrequentValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrequentValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFrequentValues, "ucrNudFrequentValues")
        Me.ucrNudFrequentValues.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrequentValues.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrequentValues.Name = "ucrNudFrequentValues"
        Me.ucrNudFrequentValues.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgRecodeFactor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
End Class
