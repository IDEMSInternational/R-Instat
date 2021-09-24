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
Partial Class dlgDuplicateColumns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDuplicateColumns))
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.grpConvertTo = New System.Windows.Forms.GroupBox()
        Me.rdoConvertToLogical = New System.Windows.Forms.RadioButton()
        Me.rdoConvertToCharacter = New System.Windows.Forms.RadioButton()
        Me.rdoConvertToInteger = New System.Windows.Forms.RadioButton()
        Me.rdoConvertToNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoConvertToOrderedFactor = New System.Windows.Forms.RadioButton()
        Me.rdoConvertToFactor = New System.Windows.Forms.RadioButton()
        Me.ucrPnlConvertTo = New instat.UcrPanel()
        Me.grpFactorToNumericOptions = New System.Windows.Forms.GroupBox()
        Me.rdoConvertDefault = New System.Windows.Forms.RadioButton()
        Me.rdoConvertOrdinals = New System.Windows.Forms.RadioButton()
        Me.rdoConvertLevels = New System.Windows.Forms.RadioButton()
        Me.ucrPnlConvertFactorToNumericOptions = New instat.UcrPanel()
        Me.ucrChkChangeType = New instat.ucrCheck()
        Me.ucrChkConvertCreateLabels = New instat.ucrCheck()
        Me.ucrChkConvertKeepAttributes = New instat.ucrCheck()
        Me.ucrNudConvertDisplayDecimals = New instat.ucrNud()
        Me.ucrChkConvertSpecifyDecimalsToDisplay = New instat.ucrCheck()
        Me.ucrReceiverDuplicateColumns = New instat.ucrReceiverSingle()
        Me.ucrSelectorForDuplicateColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.grpConvertTo.SuspendLayout()
        Me.grpFactorToNumericOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumns
        '
        resources.ApplyResources(Me.lblColumns, "lblColumns")
        Me.lblColumns.Name = "lblColumns"
        '
        'grpConvertTo
        '
        Me.grpConvertTo.Controls.Add(Me.rdoConvertToLogical)
        Me.grpConvertTo.Controls.Add(Me.rdoConvertToCharacter)
        Me.grpConvertTo.Controls.Add(Me.rdoConvertToInteger)
        Me.grpConvertTo.Controls.Add(Me.rdoConvertToNumeric)
        Me.grpConvertTo.Controls.Add(Me.rdoConvertToOrderedFactor)
        Me.grpConvertTo.Controls.Add(Me.rdoConvertToFactor)
        Me.grpConvertTo.Controls.Add(Me.ucrPnlConvertTo)
        resources.ApplyResources(Me.grpConvertTo, "grpConvertTo")
        Me.grpConvertTo.Name = "grpConvertTo"
        Me.grpConvertTo.TabStop = False
        '
        'rdoConvertToLogical
        '
        resources.ApplyResources(Me.rdoConvertToLogical, "rdoConvertToLogical")
        Me.rdoConvertToLogical.Name = "rdoConvertToLogical"
        Me.rdoConvertToLogical.TabStop = True
        Me.rdoConvertToLogical.UseVisualStyleBackColor = True
        '
        'rdoConvertToCharacter
        '
        resources.ApplyResources(Me.rdoConvertToCharacter, "rdoConvertToCharacter")
        Me.rdoConvertToCharacter.Name = "rdoConvertToCharacter"
        Me.rdoConvertToCharacter.TabStop = True
        Me.rdoConvertToCharacter.UseVisualStyleBackColor = True
        '
        'rdoConvertToInteger
        '
        resources.ApplyResources(Me.rdoConvertToInteger, "rdoConvertToInteger")
        Me.rdoConvertToInteger.Name = "rdoConvertToInteger"
        Me.rdoConvertToInteger.TabStop = True
        Me.rdoConvertToInteger.UseVisualStyleBackColor = True
        '
        'rdoConvertToNumeric
        '
        resources.ApplyResources(Me.rdoConvertToNumeric, "rdoConvertToNumeric")
        Me.rdoConvertToNumeric.Name = "rdoConvertToNumeric"
        Me.rdoConvertToNumeric.TabStop = True
        Me.rdoConvertToNumeric.UseVisualStyleBackColor = True
        '
        'rdoConvertToOrderedFactor
        '
        resources.ApplyResources(Me.rdoConvertToOrderedFactor, "rdoConvertToOrderedFactor")
        Me.rdoConvertToOrderedFactor.Name = "rdoConvertToOrderedFactor"
        Me.rdoConvertToOrderedFactor.TabStop = True
        Me.rdoConvertToOrderedFactor.UseVisualStyleBackColor = True
        '
        'rdoConvertToFactor
        '
        resources.ApplyResources(Me.rdoConvertToFactor, "rdoConvertToFactor")
        Me.rdoConvertToFactor.Name = "rdoConvertToFactor"
        Me.rdoConvertToFactor.TabStop = True
        Me.rdoConvertToFactor.UseVisualStyleBackColor = True
        '
        'ucrPnlConvertTo
        '
        resources.ApplyResources(Me.ucrPnlConvertTo, "ucrPnlConvertTo")
        Me.ucrPnlConvertTo.Name = "ucrPnlConvertTo"
        '
        'grpFactorToNumericOptions
        '
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertDefault)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertOrdinals)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertLevels)
        Me.grpFactorToNumericOptions.Controls.Add(Me.ucrPnlConvertFactorToNumericOptions)
        resources.ApplyResources(Me.grpFactorToNumericOptions, "grpFactorToNumericOptions")
        Me.grpFactorToNumericOptions.Name = "grpFactorToNumericOptions"
        Me.grpFactorToNumericOptions.TabStop = False
        '
        'rdoConvertDefault
        '
        resources.ApplyResources(Me.rdoConvertDefault, "rdoConvertDefault")
        Me.rdoConvertDefault.Name = "rdoConvertDefault"
        Me.rdoConvertDefault.TabStop = True
        Me.rdoConvertDefault.UseVisualStyleBackColor = True
        '
        'rdoConvertOrdinals
        '
        resources.ApplyResources(Me.rdoConvertOrdinals, "rdoConvertOrdinals")
        Me.rdoConvertOrdinals.Name = "rdoConvertOrdinals"
        Me.rdoConvertOrdinals.TabStop = True
        Me.rdoConvertOrdinals.UseVisualStyleBackColor = True
        '
        'rdoConvertLevels
        '
        resources.ApplyResources(Me.rdoConvertLevels, "rdoConvertLevels")
        Me.rdoConvertLevels.Name = "rdoConvertLevels"
        Me.rdoConvertLevels.TabStop = True
        Me.rdoConvertLevels.UseVisualStyleBackColor = True
        '
        'ucrPnlConvertFactorToNumericOptions
        '
        resources.ApplyResources(Me.ucrPnlConvertFactorToNumericOptions, "ucrPnlConvertFactorToNumericOptions")
        Me.ucrPnlConvertFactorToNumericOptions.Name = "ucrPnlConvertFactorToNumericOptions"
        '
        'ucrChkChangeType
        '
        Me.ucrChkChangeType.Checked = False
        resources.ApplyResources(Me.ucrChkChangeType, "ucrChkChangeType")
        Me.ucrChkChangeType.Name = "ucrChkChangeType"
        '
        'ucrChkConvertCreateLabels
        '
        Me.ucrChkConvertCreateLabels.Checked = False
        resources.ApplyResources(Me.ucrChkConvertCreateLabels, "ucrChkConvertCreateLabels")
        Me.ucrChkConvertCreateLabels.Name = "ucrChkConvertCreateLabels"
        '
        'ucrChkConvertKeepAttributes
        '
        Me.ucrChkConvertKeepAttributes.Checked = False
        resources.ApplyResources(Me.ucrChkConvertKeepAttributes, "ucrChkConvertKeepAttributes")
        Me.ucrChkConvertKeepAttributes.Name = "ucrChkConvertKeepAttributes"
        '
        'ucrNudConvertDisplayDecimals
        '
        Me.ucrNudConvertDisplayDecimals.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConvertDisplayDecimals.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudConvertDisplayDecimals, "ucrNudConvertDisplayDecimals")
        Me.ucrNudConvertDisplayDecimals.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudConvertDisplayDecimals.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConvertDisplayDecimals.Name = "ucrNudConvertDisplayDecimals"
        Me.ucrNudConvertDisplayDecimals.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkConvertSpecifyDecimalsToDisplay
        '
        Me.ucrChkConvertSpecifyDecimalsToDisplay.Checked = False
        resources.ApplyResources(Me.ucrChkConvertSpecifyDecimalsToDisplay, "ucrChkConvertSpecifyDecimalsToDisplay")
        Me.ucrChkConvertSpecifyDecimalsToDisplay.Name = "ucrChkConvertSpecifyDecimalsToDisplay"
        '
        'ucrReceiverDuplicateColumns
        '
        Me.ucrReceiverDuplicateColumns.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDuplicateColumns, "ucrReceiverDuplicateColumns")
        Me.ucrReceiverDuplicateColumns.Name = "ucrReceiverDuplicateColumns"
        Me.ucrReceiverDuplicateColumns.Selector = Nothing
        Me.ucrReceiverDuplicateColumns.strNcFilePath = ""
        Me.ucrReceiverDuplicateColumns.ucrSelector = Nothing
        '
        'ucrSelectorForDuplicateColumn
        '
        Me.ucrSelectorForDuplicateColumn.bDropUnusedFilterLevels = False
        Me.ucrSelectorForDuplicateColumn.bShowHiddenColumns = False
        Me.ucrSelectorForDuplicateColumn.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForDuplicateColumn, "ucrSelectorForDuplicateColumn")
        Me.ucrSelectorForDuplicateColumn.Name = "ucrSelectorForDuplicateColumn"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSaveColumn
        '
        resources.ApplyResources(Me.ucrSaveColumn, "ucrSaveColumn")
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        '
        'dlgDuplicateColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrChkChangeType)
        Me.Controls.Add(Me.ucrChkConvertCreateLabels)
        Me.Controls.Add(Me.ucrChkConvertKeepAttributes)
        Me.Controls.Add(Me.ucrNudConvertDisplayDecimals)
        Me.Controls.Add(Me.grpFactorToNumericOptions)
        Me.Controls.Add(Me.grpConvertTo)
        Me.Controls.Add(Me.ucrChkConvertSpecifyDecimalsToDisplay)
        Me.Controls.Add(Me.ucrReceiverDuplicateColumns)
        Me.Controls.Add(Me.ucrSelectorForDuplicateColumn)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDuplicateColumns"
        Me.Tag = ""
        Me.grpConvertTo.ResumeLayout(False)
        Me.grpConvertTo.PerformLayout()
        Me.grpFactorToNumericOptions.ResumeLayout(False)
        Me.grpFactorToNumericOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrSelectorForDuplicateColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDuplicateColumns As ucrReceiverSingle
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpConvertTo As GroupBox
    Friend WithEvents rdoConvertToLogical As RadioButton
    Friend WithEvents rdoConvertToCharacter As RadioButton
    Friend WithEvents rdoConvertToInteger As RadioButton
    Friend WithEvents rdoConvertToNumeric As RadioButton
    Friend WithEvents rdoConvertToOrderedFactor As RadioButton
    Friend WithEvents rdoConvertToFactor As RadioButton
    Friend WithEvents ucrPnlConvertTo As UcrPanel
    Friend WithEvents grpFactorToNumericOptions As GroupBox
    Friend WithEvents rdoConvertDefault As RadioButton
    Friend WithEvents rdoConvertOrdinals As RadioButton
    Friend WithEvents rdoConvertLevels As RadioButton
    Friend WithEvents ucrPnlConvertFactorToNumericOptions As UcrPanel
    Friend WithEvents ucrChkConvertSpecifyDecimalsToDisplay As ucrCheck
    Friend WithEvents ucrNudConvertDisplayDecimals As ucrNud
    Friend WithEvents ucrChkConvertCreateLabels As ucrCheck
    Friend WithEvents ucrChkConvertKeepAttributes As ucrCheck
    Friend WithEvents ucrChkChangeType As ucrCheck
    Friend WithEvents ucrSaveColumn As ucrSave
End Class
