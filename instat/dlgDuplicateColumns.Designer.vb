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
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(228, 11)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(105, 13)
        Me.lblColumns.TabIndex = 1
        Me.lblColumns.Text = "Column to Duplicate:"
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
        Me.grpConvertTo.Location = New System.Drawing.Point(228, 77)
        Me.grpConvertTo.Name = "grpConvertTo"
        Me.grpConvertTo.Size = New System.Drawing.Size(235, 100)
        Me.grpConvertTo.TabIndex = 4
        Me.grpConvertTo.TabStop = False
        Me.grpConvertTo.Text = "Convert To"
        '
        'rdoConvertToLogical
        '
        Me.rdoConvertToLogical.AutoSize = True
        Me.rdoConvertToLogical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertToLogical.Location = New System.Drawing.Point(149, 72)
        Me.rdoConvertToLogical.Name = "rdoConvertToLogical"
        Me.rdoConvertToLogical.Size = New System.Drawing.Size(59, 17)
        Me.rdoConvertToLogical.TabIndex = 11
        Me.rdoConvertToLogical.TabStop = True
        Me.rdoConvertToLogical.Text = "Logical"
        Me.rdoConvertToLogical.UseVisualStyleBackColor = True
        '
        'rdoConvertToCharacter
        '
        Me.rdoConvertToCharacter.AutoSize = True
        Me.rdoConvertToCharacter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertToCharacter.Location = New System.Drawing.Point(16, 72)
        Me.rdoConvertToCharacter.Name = "rdoConvertToCharacter"
        Me.rdoConvertToCharacter.Size = New System.Drawing.Size(71, 17)
        Me.rdoConvertToCharacter.TabIndex = 8
        Me.rdoConvertToCharacter.TabStop = True
        Me.rdoConvertToCharacter.Text = "Character"
        Me.rdoConvertToCharacter.UseVisualStyleBackColor = True
        '
        'rdoConvertToInteger
        '
        Me.rdoConvertToInteger.AutoSize = True
        Me.rdoConvertToInteger.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertToInteger.Location = New System.Drawing.Point(149, 49)
        Me.rdoConvertToInteger.Name = "rdoConvertToInteger"
        Me.rdoConvertToInteger.Size = New System.Drawing.Size(58, 17)
        Me.rdoConvertToInteger.TabIndex = 10
        Me.rdoConvertToInteger.TabStop = True
        Me.rdoConvertToInteger.Text = "Integer"
        Me.rdoConvertToInteger.UseVisualStyleBackColor = True
        '
        'rdoConvertToNumeric
        '
        Me.rdoConvertToNumeric.AutoSize = True
        Me.rdoConvertToNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertToNumeric.Location = New System.Drawing.Point(149, 27)
        Me.rdoConvertToNumeric.Name = "rdoConvertToNumeric"
        Me.rdoConvertToNumeric.Size = New System.Drawing.Size(64, 17)
        Me.rdoConvertToNumeric.TabIndex = 9
        Me.rdoConvertToNumeric.TabStop = True
        Me.rdoConvertToNumeric.Text = "Numeric"
        Me.rdoConvertToNumeric.UseVisualStyleBackColor = True
        '
        'rdoConvertToOrderedFactor
        '
        Me.rdoConvertToOrderedFactor.AutoSize = True
        Me.rdoConvertToOrderedFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertToOrderedFactor.Location = New System.Drawing.Point(16, 49)
        Me.rdoConvertToOrderedFactor.Name = "rdoConvertToOrderedFactor"
        Me.rdoConvertToOrderedFactor.Size = New System.Drawing.Size(96, 17)
        Me.rdoConvertToOrderedFactor.TabIndex = 7
        Me.rdoConvertToOrderedFactor.TabStop = True
        Me.rdoConvertToOrderedFactor.Text = "Ordered Factor"
        Me.rdoConvertToOrderedFactor.UseVisualStyleBackColor = True
        '
        'rdoConvertToFactor
        '
        Me.rdoConvertToFactor.AutoSize = True
        Me.rdoConvertToFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertToFactor.Location = New System.Drawing.Point(16, 27)
        Me.rdoConvertToFactor.Name = "rdoConvertToFactor"
        Me.rdoConvertToFactor.Size = New System.Drawing.Size(55, 17)
        Me.rdoConvertToFactor.TabIndex = 6
        Me.rdoConvertToFactor.TabStop = True
        Me.rdoConvertToFactor.Text = "Factor"
        Me.rdoConvertToFactor.UseVisualStyleBackColor = True
        '
        'ucrPnlConvertTo
        '
        Me.ucrPnlConvertTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlConvertTo.Location = New System.Drawing.Point(7, 17)
        Me.ucrPnlConvertTo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrPnlConvertTo.Name = "ucrPnlConvertTo"
        Me.ucrPnlConvertTo.Size = New System.Drawing.Size(220, 80)
        Me.ucrPnlConvertTo.TabIndex = 5
        '
        'grpFactorToNumericOptions
        '
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertDefault)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertOrdinals)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertLevels)
        Me.grpFactorToNumericOptions.Controls.Add(Me.ucrPnlConvertFactorToNumericOptions)
        Me.grpFactorToNumericOptions.Location = New System.Drawing.Point(228, 236)
        Me.grpFactorToNumericOptions.Name = "grpFactorToNumericOptions"
        Me.grpFactorToNumericOptions.Size = New System.Drawing.Size(196, 102)
        Me.grpFactorToNumericOptions.TabIndex = 16
        Me.grpFactorToNumericOptions.TabStop = False
        Me.grpFactorToNumericOptions.Text = "Factor Options"
        '
        'rdoConvertDefault
        '
        Me.rdoConvertDefault.AutoSize = True
        Me.rdoConvertDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertDefault.Location = New System.Drawing.Point(14, 28)
        Me.rdoConvertDefault.Name = "rdoConvertDefault"
        Me.rdoConvertDefault.Size = New System.Drawing.Size(59, 17)
        Me.rdoConvertDefault.TabIndex = 18
        Me.rdoConvertDefault.TabStop = True
        Me.rdoConvertDefault.Text = "Default"
        Me.rdoConvertDefault.UseVisualStyleBackColor = True
        '
        'rdoConvertOrdinals
        '
        Me.rdoConvertOrdinals.AutoSize = True
        Me.rdoConvertOrdinals.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertOrdinals.Location = New System.Drawing.Point(14, 72)
        Me.rdoConvertOrdinals.Name = "rdoConvertOrdinals"
        Me.rdoConvertOrdinals.Size = New System.Drawing.Size(115, 17)
        Me.rdoConvertOrdinals.TabIndex = 20
        Me.rdoConvertOrdinals.TabStop = True
        Me.rdoConvertOrdinals.Text = "Always Use Values"
        Me.rdoConvertOrdinals.UseVisualStyleBackColor = True
        '
        'rdoConvertLevels
        '
        Me.rdoConvertLevels.AutoSize = True
        Me.rdoConvertLevels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConvertLevels.Location = New System.Drawing.Point(14, 50)
        Me.rdoConvertLevels.Name = "rdoConvertLevels"
        Me.rdoConvertLevels.Size = New System.Drawing.Size(114, 17)
        Me.rdoConvertLevels.TabIndex = 19
        Me.rdoConvertLevels.TabStop = True
        Me.rdoConvertLevels.Text = "Always Use Levels"
        Me.rdoConvertLevels.UseVisualStyleBackColor = True
        '
        'ucrPnlConvertFactorToNumericOptions
        '
        Me.ucrPnlConvertFactorToNumericOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlConvertFactorToNumericOptions.Location = New System.Drawing.Point(6, 22)
        Me.ucrPnlConvertFactorToNumericOptions.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrPnlConvertFactorToNumericOptions.Name = "ucrPnlConvertFactorToNumericOptions"
        Me.ucrPnlConvertFactorToNumericOptions.Size = New System.Drawing.Size(190, 74)
        Me.ucrPnlConvertFactorToNumericOptions.TabIndex = 17
        '
        'ucrChkChangeType
        '
        Me.ucrChkChangeType.AutoSize = True
        Me.ucrChkChangeType.Checked = False
        Me.ucrChkChangeType.Location = New System.Drawing.Point(228, 55)
        Me.ucrChkChangeType.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkChangeType.Name = "ucrChkChangeType"
        Me.ucrChkChangeType.Size = New System.Drawing.Size(165, 23)
        Me.ucrChkChangeType.TabIndex = 3
        '
        'ucrChkConvertCreateLabels
        '
        Me.ucrChkConvertCreateLabels.AutoSize = True
        Me.ucrChkConvertCreateLabels.Checked = False
        Me.ucrChkConvertCreateLabels.Location = New System.Drawing.Point(371, 181)
        Me.ucrChkConvertCreateLabels.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkConvertCreateLabels.Name = "ucrChkConvertCreateLabels"
        Me.ucrChkConvertCreateLabels.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkConvertCreateLabels.TabIndex = 13
        '
        'ucrChkConvertKeepAttributes
        '
        Me.ucrChkConvertKeepAttributes.AutoSize = True
        Me.ucrChkConvertKeepAttributes.Checked = False
        Me.ucrChkConvertKeepAttributes.Location = New System.Drawing.Point(230, 181)
        Me.ucrChkConvertKeepAttributes.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkConvertKeepAttributes.Name = "ucrChkConvertKeepAttributes"
        Me.ucrChkConvertKeepAttributes.Size = New System.Drawing.Size(139, 23)
        Me.ucrChkConvertKeepAttributes.TabIndex = 12
        '
        'ucrNudConvertDisplayDecimals
        '
        Me.ucrNudConvertDisplayDecimals.AutoSize = True
        Me.ucrNudConvertDisplayDecimals.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConvertDisplayDecimals.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudConvertDisplayDecimals.Location = New System.Drawing.Point(413, 209)
        Me.ucrNudConvertDisplayDecimals.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudConvertDisplayDecimals.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudConvertDisplayDecimals.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConvertDisplayDecimals.Name = "ucrNudConvertDisplayDecimals"
        Me.ucrNudConvertDisplayDecimals.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudConvertDisplayDecimals.TabIndex = 15
        Me.ucrNudConvertDisplayDecimals.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkConvertSpecifyDecimalsToDisplay
        '
        Me.ucrChkConvertSpecifyDecimalsToDisplay.AutoSize = True
        Me.ucrChkConvertSpecifyDecimalsToDisplay.Checked = False
        Me.ucrChkConvertSpecifyDecimalsToDisplay.Location = New System.Drawing.Point(230, 209)
        Me.ucrChkConvertSpecifyDecimalsToDisplay.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkConvertSpecifyDecimalsToDisplay.Name = "ucrChkConvertSpecifyDecimalsToDisplay"
        Me.ucrChkConvertSpecifyDecimalsToDisplay.Size = New System.Drawing.Size(180, 23)
        Me.ucrChkConvertSpecifyDecimalsToDisplay.TabIndex = 14
        '
        'ucrReceiverDuplicateColumns
        '
        Me.ucrReceiverDuplicateColumns.AutoSize = True
        Me.ucrReceiverDuplicateColumns.frmParent = Me
        Me.ucrReceiverDuplicateColumns.Location = New System.Drawing.Point(228, 28)
        Me.ucrReceiverDuplicateColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDuplicateColumns.Name = "ucrReceiverDuplicateColumns"
        Me.ucrReceiverDuplicateColumns.Selector = Nothing
        Me.ucrReceiverDuplicateColumns.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverDuplicateColumns.strNcFilePath = ""
        Me.ucrReceiverDuplicateColumns.TabIndex = 2
        Me.ucrReceiverDuplicateColumns.ucrSelector = Nothing
        '
        'ucrSelectorForDuplicateColumn
        '
        Me.ucrSelectorForDuplicateColumn.AutoSize = True
        Me.ucrSelectorForDuplicateColumn.bDropUnusedFilterLevels = False
        Me.ucrSelectorForDuplicateColumn.bShowHiddenColumns = False
        Me.ucrSelectorForDuplicateColumn.bUseCurrentFilter = True
        Me.ucrSelectorForDuplicateColumn.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForDuplicateColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDuplicateColumn.Name = "ucrSelectorForDuplicateColumn"
        Me.ucrSelectorForDuplicateColumn.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForDuplicateColumn.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 371)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 29
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveColumn.Location = New System.Drawing.Point(6, 343)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(327, 22)
        Me.ucrSaveColumn.TabIndex = 30
        '
        'dlgDuplicateColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(486, 432)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Duplicate Column"
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
