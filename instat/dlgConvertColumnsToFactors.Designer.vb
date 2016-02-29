<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConvertColumnsToFactors
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
        Me.grpToType = New System.Windows.Forms.GroupBox()
        Me.rdoInteger = New System.Windows.Forms.RadioButton()
        Me.rdoCharacter = New System.Windows.Forms.RadioButton()
        Me.rdoFactor = New System.Windows.Forms.RadioButton()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.cboFactorNumeric = New System.Windows.Forms.ComboBox()
        Me.lblFactorNumeric = New System.Windows.Forms.Label()
        Me.ucrSelectorDataFrameColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColumnsToConvert = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpFactorNumeric = New System.Windows.Forms.GroupBox()
        Me.grpToType.SuspendLayout()
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
        'grpToType
        '
        Me.grpToType.Controls.Add(Me.rdoInteger)
        Me.grpToType.Controls.Add(Me.rdoCharacter)
        Me.grpToType.Controls.Add(Me.rdoFactor)
        Me.grpToType.Controls.Add(Me.rdoNumeric)
        Me.grpToType.Location = New System.Drawing.Point(18, 183)
        Me.grpToType.Name = "grpToType"
        Me.grpToType.Size = New System.Drawing.Size(101, 132)
        Me.grpToType.TabIndex = 4
        Me.grpToType.TabStop = False
        Me.grpToType.Tag = "To_type"
        Me.grpToType.Text = "To type"
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
        'cboFactorNumeric
        '
        Me.cboFactorNumeric.AllowDrop = True
        Me.cboFactorNumeric.FormattingEnabled = True
        Me.cboFactorNumeric.Items.AddRange(New Object() {"by_levels", "by_ordinals"})
        Me.cboFactorNumeric.Location = New System.Drawing.Point(92, 12)
        Me.cboFactorNumeric.Name = "cboFactorNumeric"
        Me.cboFactorNumeric.Size = New System.Drawing.Size(121, 21)
        Me.cboFactorNumeric.TabIndex = 5
        Me.cboFactorNumeric.Tag = "by_levels"
        Me.cboFactorNumeric.Text = "by_levels"
        '
        'lblFactorNumeric
        '
        Me.lblFactorNumeric.AutoSize = True
        Me.lblFactorNumeric.Location = New System.Drawing.Point(6, 16)
        Me.lblFactorNumeric.Name = "lblFactorNumeric"
        Me.lblFactorNumeric.Size = New System.Drawing.Size(80, 13)
        Me.lblFactorNumeric.TabIndex = 6
        Me.lblFactorNumeric.Tag = "Factor_numeric"
        Me.lblFactorNumeric.Text = "Factor_numeric"
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
        Me.grpFactorNumeric.Controls.Add(Me.lblFactorNumeric)
        Me.grpFactorNumeric.Controls.Add(Me.cboFactorNumeric)
        Me.grpFactorNumeric.Location = New System.Drawing.Point(144, 187)
        Me.grpFactorNumeric.Name = "grpFactorNumeric"
        Me.grpFactorNumeric.Size = New System.Drawing.Size(217, 57)
        Me.grpFactorNumeric.TabIndex = 7
        Me.grpFactorNumeric.TabStop = False
        '
        'dlgConvertColumnsToFactors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 382)
        Me.Controls.Add(Me.grpFactorNumeric)
        Me.Controls.Add(Me.grpToType)
        Me.Controls.Add(Me.ucrSelectorDataFrameColumns)
        Me.Controls.Add(Me.lblColumnsToConvert)
        Me.Controls.Add(Me.ucrReceiverColumnsToConvert)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgConvertColumnsToFactors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Convert_columns"
        Me.Text = "Convert Columns"
        Me.grpToType.ResumeLayout(False)
        Me.grpToType.PerformLayout()
        Me.grpFactorNumeric.ResumeLayout(False)
        Me.grpFactorNumeric.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverColumnsToConvert As ucrReceiverMultiple
    Friend WithEvents lblColumnsToConvert As Label
    Friend WithEvents ucrSelectorDataFrameColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpToType As GroupBox
    Friend WithEvents rdoInteger As RadioButton
    Friend WithEvents rdoCharacter As RadioButton
    Friend WithEvents rdoFactor As RadioButton
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents cboFactorNumeric As ComboBox
    Friend WithEvents lblFactorNumeric As Label
    Friend WithEvents grpFactorNumeric As GroupBox
End Class
