﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConvertColumns
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
        Me.lblColumnsToConvert = New System.Windows.Forms.Label()
        Me.grpTo = New System.Windows.Forms.GroupBox()
        Me.rdoInteger = New System.Windows.Forms.RadioButton()
        Me.rdoCharacter = New System.Windows.Forms.RadioButton()
        Me.rdoFactor = New System.Windows.Forms.RadioButton()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.grpFactorToNumericOptions = New System.Windows.Forms.GroupBox()
        Me.rdoConvertOrdinals = New System.Windows.Forms.RadioButton()
        Me.rdoConvertLevels = New System.Windows.Forms.RadioButton()
        Me.ucrSelectorDataFrameColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColumnsToConvert = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpTo.SuspendLayout()
        Me.grpFactorToNumericOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnsToConvert
        '
        Me.lblColumnsToConvert.AutoSize = True
        Me.lblColumnsToConvert.Location = New System.Drawing.Point(255, 25)
        Me.lblColumnsToConvert.Name = "lblColumnsToConvert"
        Me.lblColumnsToConvert.Size = New System.Drawing.Size(99, 13)
        Me.lblColumnsToConvert.TabIndex = 1
        Me.lblColumnsToConvert.Tag = "Columns_to_Convert"
        Me.lblColumnsToConvert.Text = "Columns to Convert"
        '
        'grpTo
        '
        Me.grpTo.Controls.Add(Me.rdoInteger)
        Me.grpTo.Controls.Add(Me.rdoCharacter)
        Me.grpTo.Controls.Add(Me.rdoFactor)
        Me.grpTo.Controls.Add(Me.rdoNumeric)
        Me.grpTo.Location = New System.Drawing.Point(10, 193)
        Me.grpTo.Name = "grpTo"
        Me.grpTo.Size = New System.Drawing.Size(120, 103)
        Me.grpTo.TabIndex = 4
        Me.grpTo.TabStop = False
        Me.grpTo.Tag = "To"
        Me.grpTo.Text = "To"
        '
        'rdoInteger
        '
        Me.rdoInteger.AutoSize = True
        Me.rdoInteger.Location = New System.Drawing.Point(11, 77)
        Me.rdoInteger.Name = "rdoInteger"
        Me.rdoInteger.Size = New System.Drawing.Size(58, 17)
        Me.rdoInteger.TabIndex = 3
        Me.rdoInteger.TabStop = True
        Me.rdoInteger.Tag = "Integer"
        Me.rdoInteger.Text = "Integer"
        Me.rdoInteger.UseVisualStyleBackColor = True
        '
        'rdoCharacter
        '
        Me.rdoCharacter.AutoSize = True
        Me.rdoCharacter.Location = New System.Drawing.Point(11, 55)
        Me.rdoCharacter.Name = "rdoCharacter"
        Me.rdoCharacter.Size = New System.Drawing.Size(71, 17)
        Me.rdoCharacter.TabIndex = 2
        Me.rdoCharacter.TabStop = True
        Me.rdoCharacter.Tag = "Character"
        Me.rdoCharacter.Text = "Character"
        Me.rdoCharacter.UseVisualStyleBackColor = True
        '
        'rdoFactor
        '
        Me.rdoFactor.AutoSize = True
        Me.rdoFactor.Location = New System.Drawing.Point(11, 11)
        Me.rdoFactor.Name = "rdoFactor"
        Me.rdoFactor.Size = New System.Drawing.Size(55, 17)
        Me.rdoFactor.TabIndex = 1
        Me.rdoFactor.TabStop = True
        Me.rdoFactor.Tag = "Factor"
        Me.rdoFactor.Text = "Factor"
        Me.rdoFactor.UseVisualStyleBackColor = True
        '
        'rdoNumeric
        '
        Me.rdoNumeric.AutoSize = True
        Me.rdoNumeric.Location = New System.Drawing.Point(11, 33)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(64, 17)
        Me.rdoNumeric.TabIndex = 0
        Me.rdoNumeric.TabStop = True
        Me.rdoNumeric.Tag = "Numeric"
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'grpFactorToNumericOptions
        '
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertOrdinals)
        Me.grpFactorToNumericOptions.Controls.Add(Me.rdoConvertLevels)
        Me.grpFactorToNumericOptions.Location = New System.Drawing.Point(139, 215)
        Me.grpFactorToNumericOptions.Name = "grpFactorToNumericOptions"
        Me.grpFactorToNumericOptions.Size = New System.Drawing.Size(260, 37)
        Me.grpFactorToNumericOptions.TabIndex = 7
        Me.grpFactorToNumericOptions.TabStop = False
        Me.grpFactorToNumericOptions.Tag = "Factor_Options"
        Me.grpFactorToNumericOptions.Text = "Factor Options"
        '
        'rdoConvertOrdinals
        '
        Me.rdoConvertOrdinals.AutoSize = True
        Me.rdoConvertOrdinals.Location = New System.Drawing.Point(139, 13)
        Me.rdoConvertOrdinals.Name = "rdoConvertOrdinals"
        Me.rdoConvertOrdinals.Size = New System.Drawing.Size(103, 17)
        Me.rdoConvertOrdinals.TabIndex = 8
        Me.rdoConvertOrdinals.TabStop = True
        Me.rdoConvertOrdinals.Tag = "Convert_Ordinals"
        Me.rdoConvertOrdinals.Text = "Convert Ordinals"
        Me.rdoConvertOrdinals.UseVisualStyleBackColor = True
        '
        'rdoConvertLevels
        '
        Me.rdoConvertLevels.AutoSize = True
        Me.rdoConvertLevels.Location = New System.Drawing.Point(14, 13)
        Me.rdoConvertLevels.Name = "rdoConvertLevels"
        Me.rdoConvertLevels.Size = New System.Drawing.Size(96, 17)
        Me.rdoConvertLevels.TabIndex = 7
        Me.rdoConvertLevels.TabStop = True
        Me.rdoConvertLevels.Tag = "Covert_Levels"
        Me.rdoConvertLevels.Text = "Convert Levels"
        Me.rdoConvertLevels.UseVisualStyleBackColor = True
        '
        'ucrSelectorDataFrameColumns
        '
        Me.ucrSelectorDataFrameColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDataFrameColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrameColumns.Name = "ucrSelectorDataFrameColumns"
        Me.ucrSelectorDataFrameColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDataFrameColumns.TabIndex = 0
        '
        'ucrReceiverColumnsToConvert
        '
        Me.ucrReceiverColumnsToConvert.Location = New System.Drawing.Point(255, 44)
        Me.ucrReceiverColumnsToConvert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToConvert.Name = "ucrReceiverColumnsToConvert"
        Me.ucrReceiverColumnsToConvert.Selector = Nothing
        Me.ucrReceiverColumnsToConvert.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnsToConvert.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 309)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'dlgConvertColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 361)
        Me.Controls.Add(Me.grpFactorToNumericOptions)
        Me.Controls.Add(Me.grpTo)
        Me.Controls.Add(Me.ucrSelectorDataFrameColumns)
        Me.Controls.Add(Me.lblColumnsToConvert)
        Me.Controls.Add(Me.ucrReceiverColumnsToConvert)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgConvertColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Convert_columns"
        Me.Text = "Convert Columns"
        Me.grpTo.ResumeLayout(False)
        Me.grpTo.PerformLayout()
        Me.grpFactorToNumericOptions.ResumeLayout(False)
        Me.grpFactorToNumericOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverColumnsToConvert As ucrReceiverMultiple
    Friend WithEvents lblColumnsToConvert As Label
    Friend WithEvents ucrSelectorDataFrameColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpTo As GroupBox
    Friend WithEvents rdoInteger As RadioButton
    Friend WithEvents rdoCharacter As RadioButton
    Friend WithEvents rdoFactor As RadioButton
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents grpFactorToNumericOptions As GroupBox
    Friend WithEvents rdoConvertOrdinals As RadioButton
    Friend WithEvents rdoConvertLevels As RadioButton
End Class
