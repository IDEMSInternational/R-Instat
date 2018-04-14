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
Partial Class dlgConvertColumns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgConvertColumns))
        Me.lblColumnsToConvert = New System.Windows.Forms.Label()
        Me.grpConvertTo = New System.Windows.Forms.GroupBox()
        Me.rdoLogical = New System.Windows.Forms.RadioButton()
        Me.rdoCharacter = New System.Windows.Forms.RadioButton()
        Me.rdoInteger = New System.Windows.Forms.RadioButton()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoOrderedFactor = New System.Windows.Forms.RadioButton()
        Me.rdoFactor = New System.Windows.Forms.RadioButton()
        Me.ucrPnlConvertTo = New instat.UcrPanel()
        Me.rdoConvertOrdinals = New System.Windows.Forms.RadioButton()
        Me.grpFactorToNumericOptions = New System.Windows.Forms.GroupBox()
        Me.rdoDefault = New System.Windows.Forms.RadioButton()
        Me.rdoConvertLevels = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFactorToNumericOptions = New instat.UcrPanel()
        Me.ucrChkKeepAttributes = New instat.ucrCheck()
        Me.ucrNudDisplayDecimals = New instat.ucrNud()
        Me.ucrChkSpecifyDecimalsToDisplay = New instat.ucrCheck()
        Me.ucrSelectorDataFrameColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColumnsToConvert = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkCreateLabels = New instat.ucrCheck()
        Me.grpConvertTo.SuspendLayout()
        Me.grpFactorToNumericOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnsToConvert
        '
        resources.ApplyResources(Me.lblColumnsToConvert, "lblColumnsToConvert")
        Me.lblColumnsToConvert.Name = "lblColumnsToConvert"
        Me.lblColumnsToConvert.Tag = "Columns_to_Convert:"
        '
        'grpConvertTo
        '
        Me.grpConvertTo.Controls.Add(Me.rdoLogical)
        Me.grpConvertTo.Controls.Add(Me.rdoCharacter)
        Me.grpConvertTo.Controls.Add(Me.rdoInteger)
        Me.grpConvertTo.Controls.Add(Me.rdoNumeric)
        Me.grpConvertTo.Controls.Add(Me.rdoOrderedFactor)
        Me.grpConvertTo.Controls.Add(Me.rdoFactor)
        Me.grpConvertTo.Controls.Add(Me.ucrPnlConvertTo)
        resources.ApplyResources(Me.grpConvertTo, "grpConvertTo")
        Me.grpConvertTo.Name = "grpConvertTo"
        Me.grpConvertTo.TabStop = False
        '
        'rdoLogical
        '
        resources.ApplyResources(Me.rdoLogical, "rdoLogical")
        Me.rdoLogical.Name = "rdoLogical"
        Me.rdoLogical.TabStop = True
        Me.rdoLogical.UseVisualStyleBackColor = True
        '
        'rdoCharacter
        '
        resources.ApplyResources(Me.rdoCharacter, "rdoCharacter")
        Me.rdoCharacter.Name = "rdoCharacter"
        Me.rdoCharacter.TabStop = True
        Me.rdoCharacter.UseVisualStyleBackColor = True
        '
        'rdoInteger
        '
        resources.ApplyResources(Me.rdoInteger, "rdoInteger")
        Me.rdoInteger.Name = "rdoInteger"
        Me.rdoInteger.TabStop = True
        Me.rdoInteger.UseVisualStyleBackColor = True
        '
        'rdoNumeric
        '
        resources.ApplyResources(Me.rdoNumeric, "rdoNumeric")
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.TabStop = True
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'rdoOrderedFactor
        '
        resources.ApplyResources(Me.rdoOrderedFactor, "rdoOrderedFactor")
        Me.rdoOrderedFactor.Name = "rdoOrderedFactor"
        Me.rdoOrderedFactor.TabStop = True
        Me.rdoOrderedFactor.UseVisualStyleBackColor = True
        '
        'rdoFactor
        '
        resources.ApplyResources(Me.rdoFactor, "rdoFactor")
        Me.rdoFactor.Name = "rdoFactor"
        Me.rdoFactor.TabStop = True
        Me.rdoFactor.UseVisualStyleBackColor = True
        '
        'ucrPnlConvertTo
        '
        resources.ApplyResources(Me.ucrPnlConvertTo, "ucrPnlConvertTo")
        Me.ucrPnlConvertTo.Name = "ucrPnlConvertTo"
        '
        'rdoConvertOrdinals
        '
        resources.ApplyResources(Me.rdoConvertOrdinals, "rdoConvertOrdinals")
        Me.rdoConvertOrdinals.Name = "rdoConvertOrdinals"
        Me.rdoConvertOrdinals.TabStop = True
        Me.rdoConvertOrdinals.UseVisualStyleBackColor = True
        '
        'grpFactorToNumericOptions
        '
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoDefault)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertOrdinals)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertLevels)
        Me.grpFactorToNumericOptions.Controls.Add(Me.ucrPnlFactorToNumericOptions)
        resources.ApplyResources(Me.grpFactorToNumericOptions, "grpFactorToNumericOptions")
        Me.grpFactorToNumericOptions.Name = "grpFactorToNumericOptions"
        Me.grpFactorToNumericOptions.TabStop = False
        '
        'rdoDefault
        '
        resources.ApplyResources(Me.rdoDefault, "rdoDefault")
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'rdoConvertLevels
        '
        resources.ApplyResources(Me.rdoConvertLevels, "rdoConvertLevels")
        Me.rdoConvertLevels.Name = "rdoConvertLevels"
        Me.rdoConvertLevels.TabStop = True
        Me.rdoConvertLevels.UseVisualStyleBackColor = True
        '
        'ucrPnlFactorToNumericOptions
        '
        resources.ApplyResources(Me.ucrPnlFactorToNumericOptions, "ucrPnlFactorToNumericOptions")
        Me.ucrPnlFactorToNumericOptions.Name = "ucrPnlFactorToNumericOptions"
        '
        'ucrChkKeepAttributes
        '
        Me.ucrChkKeepAttributes.Checked = False
        resources.ApplyResources(Me.ucrChkKeepAttributes, "ucrChkKeepAttributes")
        Me.ucrChkKeepAttributes.Name = "ucrChkKeepAttributes"
        '
        'ucrNudDisplayDecimals
        '
        Me.ucrNudDisplayDecimals.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDisplayDecimals, "ucrNudDisplayDecimals")
        Me.ucrNudDisplayDecimals.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Name = "ucrNudDisplayDecimals"
        Me.ucrNudDisplayDecimals.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSpecifyDecimalsToDisplay
        '
        Me.ucrChkSpecifyDecimalsToDisplay.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyDecimalsToDisplay, "ucrChkSpecifyDecimalsToDisplay")
        Me.ucrChkSpecifyDecimalsToDisplay.Name = "ucrChkSpecifyDecimalsToDisplay"
        '
        'ucrSelectorDataFrameColumns
        '
        Me.ucrSelectorDataFrameColumns.bShowHiddenColumns = False
        Me.ucrSelectorDataFrameColumns.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDataFrameColumns, "ucrSelectorDataFrameColumns")
        Me.ucrSelectorDataFrameColumns.Name = "ucrSelectorDataFrameColumns"
        '
        'ucrReceiverColumnsToConvert
        '
        Me.ucrReceiverColumnsToConvert.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumnsToConvert, "ucrReceiverColumnsToConvert")
        Me.ucrReceiverColumnsToConvert.Name = "ucrReceiverColumnsToConvert"
        Me.ucrReceiverColumnsToConvert.Selector = Nothing
        Me.ucrReceiverColumnsToConvert.strNcFilePath = ""
        Me.ucrReceiverColumnsToConvert.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrChkCreateLabels
        '
        Me.ucrChkCreateLabels.Checked = False
        resources.ApplyResources(Me.ucrChkCreateLabels, "ucrChkCreateLabels")
        Me.ucrChkCreateLabels.Name = "ucrChkCreateLabels"
        '
        'dlgConvertColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkCreateLabels)
        Me.Controls.Add(Me.grpFactorToNumericOptions)
        Me.Controls.Add(Me.ucrChkKeepAttributes)
        Me.Controls.Add(Me.ucrNudDisplayDecimals)
        Me.Controls.Add(Me.ucrChkSpecifyDecimalsToDisplay)
        Me.Controls.Add(Me.grpConvertTo)
        Me.Controls.Add(Me.ucrSelectorDataFrameColumns)
        Me.Controls.Add(Me.lblColumnsToConvert)
        Me.Controls.Add(Me.ucrReceiverColumnsToConvert)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConvertColumns"
        Me.Tag = "Convert_columns"
        Me.grpConvertTo.ResumeLayout(False)
        Me.grpConvertTo.PerformLayout()
        Me.grpFactorToNumericOptions.ResumeLayout(False)
        Me.grpFactorToNumericOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverColumnsToConvert As ucrReceiverMultiple
    Friend WithEvents lblColumnsToConvert As Label
    Friend WithEvents ucrSelectorDataFrameColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkSpecifyDecimalsToDisplay As ucrCheck
    Friend WithEvents grpConvertTo As GroupBox
    Friend WithEvents rdoCharacter As RadioButton
    Friend WithEvents rdoInteger As RadioButton
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents rdoOrderedFactor As RadioButton
    Friend WithEvents rdoFactor As RadioButton
    Friend WithEvents ucrPnlConvertTo As UcrPanel
    Friend WithEvents grpFactorToNumericOptions As GroupBox
    Friend WithEvents rdoConvertOrdinals As RadioButton
    Friend WithEvents ucrPnlFactorToNumericOptions As UcrPanel
    Friend WithEvents ucrNudDisplayDecimals As ucrNud
    Friend WithEvents ucrChkKeepAttributes As ucrCheck
    Friend WithEvents rdoDefault As RadioButton
    Friend WithEvents rdoConvertLevels As RadioButton
    Friend WithEvents rdoLogical As RadioButton
    Friend WithEvents ucrChkCreateLabels As ucrCheck
End Class
