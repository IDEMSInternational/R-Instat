﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.rdoCharacter = New System.Windows.Forms.RadioButton()
        Me.rdoInteger = New System.Windows.Forms.RadioButton()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoOrderedFactor = New System.Windows.Forms.RadioButton()
        Me.rdoFactor = New System.Windows.Forms.RadioButton()
        Me.rdoConvertOrdinals = New System.Windows.Forms.RadioButton()
        Me.rdoConvertLevels = New System.Windows.Forms.RadioButton()
        Me.grpFactorToNumericOptions = New System.Windows.Forms.GroupBox()
        Me.ucrNudDisplayDecimals = New instat.ucrNud()
        Me.ucrChkSpecifyDecimalsToDisplay = New instat.ucrCheck()
        Me.ucrPnlConvertTo = New instat.UcrPanel()
        Me.ucrPnlFactorToNumericOptions = New instat.UcrPanel()
        Me.ucrSelectorDataFrameColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColumnsToConvert = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpConvertTo.SuspendLayout()
        Me.grpFactorToNumericOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnsToConvert
        '
        Me.lblColumnsToConvert.AutoSize = True
        Me.lblColumnsToConvert.Location = New System.Drawing.Point(249, 17)
        Me.lblColumnsToConvert.Name = "lblColumnsToConvert"
        Me.lblColumnsToConvert.Size = New System.Drawing.Size(102, 13)
        Me.lblColumnsToConvert.TabIndex = 1
        Me.lblColumnsToConvert.Tag = "Columns_to_Convert:"
        Me.lblColumnsToConvert.Text = "Columns to Convert:"
        '
        'grpConvertTo
        '
        Me.grpConvertTo.Controls.Add(Me.rdoCharacter)
        Me.grpConvertTo.Controls.Add(Me.rdoInteger)
        Me.grpConvertTo.Controls.Add(Me.rdoNumeric)
        Me.grpConvertTo.Controls.Add(Me.rdoOrderedFactor)
        Me.grpConvertTo.Controls.Add(Me.rdoFactor)
        Me.grpConvertTo.Controls.Add(Me.ucrPnlConvertTo)
        Me.grpConvertTo.Location = New System.Drawing.Point(10, 193)
        Me.grpConvertTo.Name = "grpConvertTo"
        Me.grpConvertTo.Size = New System.Drawing.Size(349, 68)
        Me.grpConvertTo.TabIndex = 16
        Me.grpConvertTo.TabStop = False
        Me.grpConvertTo.Text = "Convert To"
        '
        'rdoCharacter
        '
        Me.rdoCharacter.AutoSize = True
        Me.rdoCharacter.Location = New System.Drawing.Point(126, 43)
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
        Me.rdoInteger.Location = New System.Drawing.Point(220, 21)
        Me.rdoInteger.Name = "rdoInteger"
        Me.rdoInteger.Size = New System.Drawing.Size(58, 17)
        Me.rdoInteger.TabIndex = 3
        Me.rdoInteger.TabStop = True
        Me.rdoInteger.Text = "Integer"
        Me.rdoInteger.UseVisualStyleBackColor = True
        '
        'rdoNumeric
        '
        Me.rdoNumeric.AutoSize = True
        Me.rdoNumeric.Location = New System.Drawing.Point(126, 21)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(64, 17)
        Me.rdoNumeric.TabIndex = 3
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
        'rdoConvertOrdinals
        '
        Me.rdoConvertOrdinals.AutoSize = True
        Me.rdoConvertOrdinals.Location = New System.Drawing.Point(126, 23)
        Me.rdoConvertOrdinals.Name = "rdoConvertOrdinals"
        Me.rdoConvertOrdinals.Size = New System.Drawing.Size(103, 17)
        Me.rdoConvertOrdinals.TabIndex = 3
        Me.rdoConvertOrdinals.TabStop = True
        Me.rdoConvertOrdinals.Text = "Convert Ordinals"
        Me.rdoConvertOrdinals.UseVisualStyleBackColor = True
        '
        'rdoConvertLevels
        '
        Me.rdoConvertLevels.AutoSize = True
        Me.rdoConvertLevels.Location = New System.Drawing.Point(10, 21)
        Me.rdoConvertLevels.Name = "rdoConvertLevels"
        Me.rdoConvertLevels.Size = New System.Drawing.Size(96, 17)
        Me.rdoConvertLevels.TabIndex = 1
        Me.rdoConvertLevels.TabStop = True
        Me.rdoConvertLevels.Text = "Convert Levels"
        Me.rdoConvertLevels.UseVisualStyleBackColor = True
        '
        'grpFactorToNumericOptions
        '
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertOrdinals)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertLevels)
        Me.grpFactorToNumericOptions.Controls.Add(Me.ucrPnlFactorToNumericOptions)
        Me.grpFactorToNumericOptions.Location = New System.Drawing.Point(10, 290)
        Me.grpFactorToNumericOptions.Name = "grpFactorToNumericOptions"
        Me.grpFactorToNumericOptions.Size = New System.Drawing.Size(293, 46)
        Me.grpFactorToNumericOptions.TabIndex = 17
        Me.grpFactorToNumericOptions.TabStop = False
        Me.grpFactorToNumericOptions.Text = "Factor Options"
        '
        'ucrNudDisplayDecimals
        '
        Me.ucrNudDisplayDecimals.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Location = New System.Drawing.Point(205, 264)
        Me.ucrNudDisplayDecimals.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDisplayDecimals.Name = "ucrNudDisplayDecimals"
        Me.ucrNudDisplayDecimals.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDisplayDecimals.TabIndex = 19
        Me.ucrNudDisplayDecimals.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSpecifyDecimalsToDisplay
        '
        Me.ucrChkSpecifyDecimalsToDisplay.Checked = False
        Me.ucrChkSpecifyDecimalsToDisplay.Location = New System.Drawing.Point(10, 265)
        Me.ucrChkSpecifyDecimalsToDisplay.Name = "ucrChkSpecifyDecimalsToDisplay"
        Me.ucrChkSpecifyDecimalsToDisplay.Size = New System.Drawing.Size(190, 20)
        Me.ucrChkSpecifyDecimalsToDisplay.TabIndex = 18
        '
        'ucrPnlConvertTo
        '
        Me.ucrPnlConvertTo.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlConvertTo.Name = "ucrPnlConvertTo"
        Me.ucrPnlConvertTo.Size = New System.Drawing.Size(328, 44)
        Me.ucrPnlConvertTo.TabIndex = 0
        '
        'ucrPnlFactorToNumericOptions
        '
        Me.ucrPnlFactorToNumericOptions.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlFactorToNumericOptions.Name = "ucrPnlFactorToNumericOptions"
        Me.ucrPnlFactorToNumericOptions.Size = New System.Drawing.Size(284, 24)
        Me.ucrPnlFactorToNumericOptions.TabIndex = 0
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
        Me.ucrReceiverColumnsToConvert.Location = New System.Drawing.Point(247, 32)
        Me.ucrReceiverColumnsToConvert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToConvert.Name = "ucrReceiverColumnsToConvert"
        Me.ucrReceiverColumnsToConvert.Selector = Nothing
        Me.ucrReceiverColumnsToConvert.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnsToConvert.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 342)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'dlgConvertColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 396)
        Me.Controls.Add(Me.ucrNudDisplayDecimals)
        Me.Controls.Add(Me.ucrChkSpecifyDecimalsToDisplay)
        Me.Controls.Add(Me.grpConvertTo)
        Me.Controls.Add(Me.grpFactorToNumericOptions)
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
    Friend WithEvents rdoConvertLevels As RadioButton
    Friend WithEvents ucrPnlFactorToNumericOptions As UcrPanel
    Friend WithEvents ucrNudDisplayDecimals As ucrNud
End Class
