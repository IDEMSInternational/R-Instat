<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrSelectorDataFrameColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColumnsToConvert = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpFactorNumeric = New System.Windows.Forms.GroupBox()
        Me.rdoByLevels = New System.Windows.Forms.RadioButton()
        Me.rdoByOrdinals = New System.Windows.Forms.RadioButton()
        Me.grpTo.SuspendLayout()
        Me.grpFactorNumeric.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnsToConvert
        '
        Me.lblColumnsToConvert.AutoSize = True
        Me.lblColumnsToConvert.Location = New System.Drawing.Point(263, 50)
        Me.lblColumnsToConvert.Name = "lblColumnsToConvert"
        Me.lblColumnsToConvert.Size = New System.Drawing.Size(98, 13)
        Me.lblColumnsToConvert.TabIndex = 1
        Me.lblColumnsToConvert.Tag = "Columns_to_convert"
        Me.lblColumnsToConvert.Text = "Columns to convert"
        '
        'grpTo
        '
        Me.grpTo.Controls.Add(Me.rdoInteger)
        Me.grpTo.Controls.Add(Me.rdoCharacter)
        Me.grpTo.Controls.Add(Me.rdoFactor)
        Me.grpTo.Controls.Add(Me.rdoNumeric)
        Me.grpTo.Location = New System.Drawing.Point(18, 183)
        Me.grpTo.Name = "grpTo"
        Me.grpTo.Size = New System.Drawing.Size(101, 132)
        Me.grpTo.TabIndex = 4
        Me.grpTo.TabStop = False
        Me.grpTo.Tag = "To"
        Me.grpTo.Text = "To"
        '
        'rdoInteger
        '
        Me.rdoInteger.AutoSize = True
        Me.rdoInteger.Location = New System.Drawing.Point(7, 96)
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
        Me.rdoCharacter.Location = New System.Drawing.Point(7, 70)
        Me.rdoCharacter.Name = "rdoCharacter"
        Me.rdoCharacter.Size = New System.Drawing.Size(70, 17)
        Me.rdoCharacter.TabIndex = 2
        Me.rdoCharacter.TabStop = True
        Me.rdoCharacter.Tag = "character"
        Me.rdoCharacter.Text = "character"
        Me.rdoCharacter.UseVisualStyleBackColor = True
        '
        'rdoFactor
        '
        Me.rdoFactor.AutoSize = True
        Me.rdoFactor.Location = New System.Drawing.Point(7, 18)
        Me.rdoFactor.Name = "rdoFactor"
        Me.rdoFactor.Size = New System.Drawing.Size(52, 17)
        Me.rdoFactor.TabIndex = 1
        Me.rdoFactor.TabStop = True
        Me.rdoFactor.Tag = "factor"
        Me.rdoFactor.Text = "factor"
        Me.rdoFactor.UseVisualStyleBackColor = True
        '
        'rdoNumeric
        '
        Me.rdoNumeric.AutoSize = True
        Me.rdoNumeric.Location = New System.Drawing.Point(7, 44)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(62, 17)
        Me.rdoNumeric.TabIndex = 0
        Me.rdoNumeric.TabStop = True
        Me.rdoNumeric.Tag = "numeric"
        Me.rdoNumeric.Text = "numeric"
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'ucrSelectorDataFrameColumns
        '
        Me.ucrSelectorDataFrameColumns.Location = New System.Drawing.Point(4, 2)
        Me.ucrSelectorDataFrameColumns.Name = "ucrSelectorDataFrameColumns"
        Me.ucrSelectorDataFrameColumns.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorDataFrameColumns.TabIndex = 0
        '
        'ucrReceiverColumnsToConvert
        '
        Me.ucrReceiverColumnsToConvert.Location = New System.Drawing.Point(257, 65)
        Me.ucrReceiverColumnsToConvert.Name = "ucrReceiverColumnsToConvert"
        Me.ucrReceiverColumnsToConvert.Selector = Nothing
        Me.ucrReceiverColumnsToConvert.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverColumnsToConvert.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 326)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 3
        '
        'grpFactorNumeric
        '
        Me.grpFactorNumeric.Controls.Add(Me.rdoByOrdinals)
        Me.grpFactorNumeric.Controls.Add(Me.rdoByLevels)
        Me.grpFactorNumeric.Location = New System.Drawing.Point(144, 240)
        Me.grpFactorNumeric.Name = "grpFactorNumeric"
        Me.grpFactorNumeric.Size = New System.Drawing.Size(217, 44)
        Me.grpFactorNumeric.TabIndex = 7
        Me.grpFactorNumeric.TabStop = False
        Me.grpFactorNumeric.Tag = "Factor numeric"
        Me.grpFactorNumeric.Text = "Factor numeric"
        '
        'rdoByLevels
        '
        Me.rdoByLevels.AutoSize = True
        Me.rdoByLevels.Location = New System.Drawing.Point(6, 16)
        Me.rdoByLevels.Name = "rdoByLevels"
        Me.rdoByLevels.Size = New System.Drawing.Size(69, 17)
        Me.rdoByLevels.TabIndex = 7
        Me.rdoByLevels.TabStop = True
        Me.rdoByLevels.Tag = "by_levels"
        Me.rdoByLevels.Text = "by_levels"
        Me.rdoByLevels.UseVisualStyleBackColor = True
        '
        'rdoByOrdinals
        '
        Me.rdoByOrdinals.AutoSize = True
        Me.rdoByOrdinals.Location = New System.Drawing.Point(113, 16)
        Me.rdoByOrdinals.Name = "rdoByOrdinals"
        Me.rdoByOrdinals.Size = New System.Drawing.Size(78, 17)
        Me.rdoByOrdinals.TabIndex = 8
        Me.rdoByOrdinals.TabStop = True
        Me.rdoByOrdinals.Tag = "by_ordinals"
        Me.rdoByOrdinals.Text = "by_ordinals"
        Me.rdoByOrdinals.UseVisualStyleBackColor = True
        '
        'dlgConvertToColumnFactors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 382)
        Me.Controls.Add(Me.grpFactorNumeric)
        Me.Controls.Add(Me.grpTo)
        Me.Controls.Add(Me.ucrSelectorDataFrameColumns)
        Me.Controls.Add(Me.lblColumnsToConvert)
        Me.Controls.Add(Me.ucrReceiverColumnsToConvert)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgConvertToColumnFactors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Convert_columns"
        Me.Text = "Convert Columns"
        Me.grpTo.ResumeLayout(False)
        Me.grpTo.PerformLayout()
        Me.grpFactorNumeric.ResumeLayout(False)
        Me.grpFactorNumeric.PerformLayout()
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
    Friend WithEvents grpFactorNumeric As GroupBox
    Friend WithEvents rdoByOrdinals As RadioButton
    Friend WithEvents rdoByLevels As RadioButton
End Class
