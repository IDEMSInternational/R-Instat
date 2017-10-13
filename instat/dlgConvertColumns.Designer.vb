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
        Me.lblColumnsToConvert.AutoSize = True
        Me.lblColumnsToConvert.Location = New System.Drawing.Point(247, 45)
        Me.lblColumnsToConvert.Name = "lblColumnsToConvert"
        Me.lblColumnsToConvert.Size = New System.Drawing.Size(102, 13)
        Me.lblColumnsToConvert.TabIndex = 1
        Me.lblColumnsToConvert.Tag = "Columns_to_Convert:"
        Me.lblColumnsToConvert.Text = "Columns to Convert:"
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
        Me.grpConvertTo.Location = New System.Drawing.Point(10, 196)
        Me.grpConvertTo.Name = "grpConvertTo"
        Me.grpConvertTo.Size = New System.Drawing.Size(357, 88)
        Me.grpConvertTo.TabIndex = 3
        Me.grpConvertTo.TabStop = False
        Me.grpConvertTo.Text = "Convert To"
        '
        'rdoLogical
        '
        Me.rdoLogical.AutoSize = True
        Me.rdoLogical.Location = New System.Drawing.Point(237, 66)
        Me.rdoLogical.Name = "rdoLogical"
        Me.rdoLogical.Size = New System.Drawing.Size(59, 17)
        Me.rdoLogical.TabIndex = 6
        Me.rdoLogical.TabStop = True
        Me.rdoLogical.Text = "Logical"
        Me.rdoLogical.UseVisualStyleBackColor = True
        '
        'rdoCharacter
        '
        Me.rdoCharacter.AutoSize = True
        Me.rdoCharacter.Location = New System.Drawing.Point(10, 66)
        Me.rdoCharacter.Name = "rdoCharacter"
        Me.rdoCharacter.Size = New System.Drawing.Size(71, 17)
        Me.rdoCharacter.TabIndex = 3
        Me.rdoCharacter.TabStop = True
        Me.rdoCharacter.Text = "Character"
        Me.rdoCharacter.UseVisualStyleBackColor = True
        '
        'rdoInteger
        '
        Me.rdoInteger.AutoSize = True
        Me.rdoInteger.Location = New System.Drawing.Point(237, 43)
        Me.rdoInteger.Name = "rdoInteger"
        Me.rdoInteger.Size = New System.Drawing.Size(58, 17)
        Me.rdoInteger.TabIndex = 5
        Me.rdoInteger.TabStop = True
        Me.rdoInteger.Text = "Integer"
        Me.rdoInteger.UseVisualStyleBackColor = True
        '
        'rdoNumeric
        '
        Me.rdoNumeric.AutoSize = True
        Me.rdoNumeric.Location = New System.Drawing.Point(237, 21)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(64, 17)
        Me.rdoNumeric.TabIndex = 4
        Me.rdoNumeric.TabStop = True
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'rdoOrderedFactor
        '
        Me.rdoOrderedFactor.AutoSize = True
        Me.rdoOrderedFactor.Location = New System.Drawing.Point(10, 43)
        Me.rdoOrderedFactor.Name = "rdoOrderedFactor"
        Me.rdoOrderedFactor.Size = New System.Drawing.Size(96, 17)
        Me.rdoOrderedFactor.TabIndex = 2
        Me.rdoOrderedFactor.TabStop = True
        Me.rdoOrderedFactor.Text = "Ordered Factor"
        Me.rdoOrderedFactor.UseVisualStyleBackColor = True
        '
        'rdoFactor
        '
        Me.rdoFactor.AutoSize = True
        Me.rdoFactor.Location = New System.Drawing.Point(10, 21)
        Me.rdoFactor.Name = "rdoFactor"
        Me.rdoFactor.Size = New System.Drawing.Size(55, 17)
        Me.rdoFactor.TabIndex = 1
        Me.rdoFactor.TabStop = True
        Me.rdoFactor.Text = "Factor"
        Me.rdoFactor.UseVisualStyleBackColor = True
        '
        'ucrPnlConvertTo
        '
        Me.ucrPnlConvertTo.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlConvertTo.Name = "ucrPnlConvertTo"
        Me.ucrPnlConvertTo.Size = New System.Drawing.Size(348, 67)
        Me.ucrPnlConvertTo.TabIndex = 0
        '
        'rdoConvertOrdinals
        '
        Me.rdoConvertOrdinals.AutoSize = True
        Me.rdoConvertOrdinals.Location = New System.Drawing.Point(11, 66)
        Me.rdoConvertOrdinals.Name = "rdoConvertOrdinals"
        Me.rdoConvertOrdinals.Size = New System.Drawing.Size(115, 17)
        Me.rdoConvertOrdinals.TabIndex = 3
        Me.rdoConvertOrdinals.TabStop = True
        Me.rdoConvertOrdinals.Text = "Always Use Values"
        Me.rdoConvertOrdinals.UseVisualStyleBackColor = True
        '
        'grpFactorToNumericOptions
        '
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoDefault)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertOrdinals)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertLevels)
        Me.grpFactorToNumericOptions.Controls.Add(Me.ucrPnlFactorToNumericOptions)
        Me.grpFactorToNumericOptions.Location = New System.Drawing.Point(10, 312)
        Me.grpFactorToNumericOptions.Name = "grpFactorToNumericOptions"
        Me.grpFactorToNumericOptions.Size = New System.Drawing.Size(143, 92)
        Me.grpFactorToNumericOptions.TabIndex = 7
        Me.grpFactorToNumericOptions.TabStop = False
        Me.grpFactorToNumericOptions.Text = "Factor Options"
        '
        'rdoDefault
        '
        Me.rdoDefault.AutoSize = True
        Me.rdoDefault.Location = New System.Drawing.Point(11, 22)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(59, 17)
        Me.rdoDefault.TabIndex = 1
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "Default"
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'rdoConvertLevels
        '
        Me.rdoConvertLevels.AutoSize = True
        Me.rdoConvertLevels.Location = New System.Drawing.Point(11, 44)
        Me.rdoConvertLevels.Name = "rdoConvertLevels"
        Me.rdoConvertLevels.Size = New System.Drawing.Size(114, 17)
        Me.rdoConvertLevels.TabIndex = 2
        Me.rdoConvertLevels.TabStop = True
        Me.rdoConvertLevels.Text = "Always Use Levels"
        Me.rdoConvertLevels.UseVisualStyleBackColor = True
        '
        'ucrPnlFactorToNumericOptions
        '
        Me.ucrPnlFactorToNumericOptions.Location = New System.Drawing.Point(3, 21)
        Me.ucrPnlFactorToNumericOptions.Name = "ucrPnlFactorToNumericOptions"
        Me.ucrPnlFactorToNumericOptions.Size = New System.Drawing.Size(134, 65)
        Me.ucrPnlFactorToNumericOptions.TabIndex = 0
        '
        'ucrChkKeepAttributes
        '
        Me.ucrChkKeepAttributes.Checked = False
        Me.ucrChkKeepAttributes.Location = New System.Drawing.Point(10, 290)
        Me.ucrChkKeepAttributes.Name = "ucrChkKeepAttributes"
        Me.ucrChkKeepAttributes.Size = New System.Drawing.Size(190, 20)
        Me.ucrChkKeepAttributes.TabIndex = 4
        '
        'ucrNudDisplayDecimals
        '
        Me.ucrNudDisplayDecimals.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Location = New System.Drawing.Point(205, 316)
        Me.ucrNudDisplayDecimals.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Name = "ucrNudDisplayDecimals"
        Me.ucrNudDisplayDecimals.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDisplayDecimals.TabIndex = 6
        Me.ucrNudDisplayDecimals.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSpecifyDecimalsToDisplay
        '
        Me.ucrChkSpecifyDecimalsToDisplay.Checked = False
        Me.ucrChkSpecifyDecimalsToDisplay.Location = New System.Drawing.Point(10, 316)
        Me.ucrChkSpecifyDecimalsToDisplay.Name = "ucrChkSpecifyDecimalsToDisplay"
        Me.ucrChkSpecifyDecimalsToDisplay.Size = New System.Drawing.Size(190, 20)
        Me.ucrChkSpecifyDecimalsToDisplay.TabIndex = 5
        '
        'ucrSelectorDataFrameColumns
        '
        Me.ucrSelectorDataFrameColumns.bShowHiddenColumns = False
        Me.ucrSelectorDataFrameColumns.bUseCurrentFilter = True
        Me.ucrSelectorDataFrameColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDataFrameColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrameColumns.Name = "ucrSelectorDataFrameColumns"
        Me.ucrSelectorDataFrameColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDataFrameColumns.TabIndex = 0
        '
        'ucrReceiverColumnsToConvert
        '
        Me.ucrReceiverColumnsToConvert.frmParent = Me
        Me.ucrReceiverColumnsToConvert.Location = New System.Drawing.Point(247, 60)
        Me.ucrReceiverColumnsToConvert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToConvert.Name = "ucrReceiverColumnsToConvert"
        Me.ucrReceiverColumnsToConvert.Selector = Nothing
        Me.ucrReceiverColumnsToConvert.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnsToConvert.strNcFilePath = ""
        Me.ucrReceiverColumnsToConvert.TabIndex = 2
        Me.ucrReceiverColumnsToConvert.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 410)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrChkCreateLabels
        '
        Me.ucrChkCreateLabels.Checked = False
        Me.ucrChkCreateLabels.Location = New System.Drawing.Point(247, 290)
        Me.ucrChkCreateLabels.Name = "ucrChkCreateLabels"
        Me.ucrChkCreateLabels.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCreateLabels.TabIndex = 9
        '
        'dlgConvertColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 463)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Convert_columns"
        Me.Text = "Convert Columns"
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
