<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplayTopN
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
        Me.lbOrder = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputDisplay = New instat.ucrInputComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputLayout = New instat.ucrInputComboBox()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.ucrInputOrder = New instat.ucrInputComboBox()
        Me.ucrInputSymbol = New instat.ucrInputTextBox()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.ucrSaveDisplay = New instat.ucrSave()
        Me.ucrChkIsCurrency = New instat.ucrCheck()
        Me.rdoPrimary = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblWeightBy = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverWeightBy = New instat.ucrReceiverSingle()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorDisplayTopN = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlDataType = New instat.UcrPanel()
        Me.ucrInputNLevels = New instat.ucrInputTextBox()
        Me.lblTopLevels = New System.Windows.Forms.Label()
        Me.ucrInputSummary = New instat.ucrInputComboBox()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbOrder
        '
        Me.lbOrder.AutoSize = True
        Me.lbOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbOrder.Location = New System.Drawing.Point(251, 149)
        Me.lbOrder.Name = "lbOrder"
        Me.lbOrder.Size = New System.Drawing.Size(36, 13)
        Me.lbOrder.TabIndex = 38
        Me.lbOrder.Text = "Order:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputDisplay)
        Me.grpOptions.Controls.Add(Me.Label1)
        Me.grpOptions.Controls.Add(Me.ucrInputLayout)
        Me.grpOptions.Controls.Add(Me.lblLayout)
        Me.grpOptions.Location = New System.Drawing.Point(6, 265)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(210, 80)
        Me.grpOptions.TabIndex = 56
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrInputDisplay
        '
        Me.ucrInputDisplay.AddQuotesIfUnrecognised = True
        Me.ucrInputDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDisplay.GetSetSelectedIndex = -1
        Me.ucrInputDisplay.IsReadOnly = False
        Me.ucrInputDisplay.Location = New System.Drawing.Point(98, 24)
        Me.ucrInputDisplay.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputDisplay.Name = "ucrInputDisplay"
        Me.ucrInputDisplay.Size = New System.Drawing.Size(103, 21)
        Me.ucrInputDisplay.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Display:"
        '
        'ucrInputLayout
        '
        Me.ucrInputLayout.AddQuotesIfUnrecognised = True
        Me.ucrInputLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLayout.GetSetSelectedIndex = -1
        Me.ucrInputLayout.IsReadOnly = False
        Me.ucrInputLayout.Location = New System.Drawing.Point(98, 49)
        Me.ucrInputLayout.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputLayout.Name = "ucrInputLayout"
        Me.ucrInputLayout.Size = New System.Drawing.Size(103, 21)
        Me.ucrInputLayout.TabIndex = 61
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLayout.Location = New System.Drawing.Point(9, 53)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(42, 13)
        Me.lblLayout.TabIndex = 59
        Me.lblLayout.Text = "Layout:"
        '
        'ucrInputOrder
        '
        Me.ucrInputOrder.AddQuotesIfUnrecognised = True
        Me.ucrInputOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputOrder.GetSetSelectedIndex = -1
        Me.ucrInputOrder.IsReadOnly = False
        Me.ucrInputOrder.Location = New System.Drawing.Point(251, 165)
        Me.ucrInputOrder.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputOrder.Name = "ucrInputOrder"
        Me.ucrInputOrder.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputOrder.TabIndex = 60
        '
        'ucrInputSymbol
        '
        Me.ucrInputSymbol.AddQuotesIfUnrecognised = True
        Me.ucrInputSymbol.AutoSize = True
        Me.ucrInputSymbol.IsMultiline = False
        Me.ucrInputSymbol.IsReadOnly = False
        Me.ucrInputSymbol.Location = New System.Drawing.Point(319, 296)
        Me.ucrInputSymbol.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputSymbol.Name = "ucrInputSymbol"
        Me.ucrInputSymbol.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputSymbol.TabIndex = 53
        '
        'lblSymbol
        '
        Me.lblSymbol.AutoSize = True
        Me.lblSymbol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSymbol.Location = New System.Drawing.Point(269, 299)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(44, 13)
        Me.lblSymbol.TabIndex = 52
        Me.lblSymbol.Text = "Symbol:"
        '
        'ucrSaveDisplay
        '
        Me.ucrSaveDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDisplay.Location = New System.Drawing.Point(6, 351)
        Me.ucrSaveDisplay.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDisplay.Name = "ucrSaveDisplay"
        Me.ucrSaveDisplay.Size = New System.Drawing.Size(311, 24)
        Me.ucrSaveDisplay.TabIndex = 50
        '
        'ucrChkIsCurrency
        '
        Me.ucrChkIsCurrency.AutoSize = True
        Me.ucrChkIsCurrency.Checked = False
        Me.ucrChkIsCurrency.Location = New System.Drawing.Point(251, 272)
        Me.ucrChkIsCurrency.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkIsCurrency.Name = "ucrChkIsCurrency"
        Me.ucrChkIsCurrency.Size = New System.Drawing.Size(120, 23)
        Me.ucrChkIsCurrency.TabIndex = 49
        '
        'rdoPrimary
        '
        Me.rdoPrimary.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPrimary.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPrimary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPrimary.FlatAppearance.BorderSize = 2
        Me.rdoPrimary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPrimary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPrimary.Location = New System.Drawing.Point(99, 11)
        Me.rdoPrimary.Name = "rdoPrimary"
        Me.rdoPrimary.Size = New System.Drawing.Size(110, 28)
        Me.rdoPrimary.TabIndex = 39
        Me.rdoPrimary.TabStop = True
        Me.rdoPrimary.Tag = ""
        Me.rdoPrimary.Text = "Primary data"
        Me.rdoPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPrimary.UseVisualStyleBackColor = False
        Me.rdoPrimary.Visible = False
        '
        'rdoSummary
        '
        Me.rdoSummary.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSummary.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSummary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatAppearance.BorderSize = 2
        Me.rdoSummary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummary.Location = New System.Drawing.Point(207, 11)
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.Size = New System.Drawing.Size(110, 28)
        Me.rdoSummary.TabIndex = 40
        Me.rdoSummary.TabStop = True
        Me.rdoSummary.Tag = "Pie_Chart"
        Me.rdoSummary.Text = "Summary data"
        Me.rdoSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummary.UseVisualStyleBackColor = False
        Me.rdoSummary.Visible = False
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(6, 232)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(147, 25)
        Me.cmdOptions.TabIndex = 48
        Me.cmdOptions.Tag = "Plot_Options..."
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblWeightBy
        '
        Me.lblWeightBy.AutoSize = True
        Me.lblWeightBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWeightBy.Location = New System.Drawing.Point(251, 194)
        Me.lblWeightBy.Name = "lblWeightBy"
        Me.lblWeightBy.Size = New System.Drawing.Size(107, 13)
        Me.lblWeightBy.TabIndex = 44
        Me.lblWeightBy.Tag = ""
        Me.lblWeightBy.Text = "Weight By (Optional):"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariable.Location = New System.Drawing.Point(251, 61)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(48, 13)
        Me.lblVariable.TabIndex = 42
        Me.lblVariable.Tag = ""
        Me.lblVariable.Text = "Variable:"
        '
        'ucrReceiverWeightBy
        '
        Me.ucrReceiverWeightBy.AutoSize = True
        Me.ucrReceiverWeightBy.frmParent = Me
        Me.ucrReceiverWeightBy.Location = New System.Drawing.Point(251, 211)
        Me.ucrReceiverWeightBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeightBy.Name = "ucrReceiverWeightBy"
        Me.ucrReceiverWeightBy.Selector = Nothing
        Me.ucrReceiverWeightBy.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeightBy.strNcFilePath = ""
        Me.ucrReceiverWeightBy.TabIndex = 45
        Me.ucrReceiverWeightBy.ucrSelector = Nothing
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.AutoSize = True
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(251, 76)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 43
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrSelectorDisplayTopN
        '
        Me.ucrSelectorDisplayTopN.AutoSize = True
        Me.ucrSelectorDisplayTopN.bDropUnusedFilterLevels = False
        Me.ucrSelectorDisplayTopN.bShowHiddenColumns = False
        Me.ucrSelectorDisplayTopN.bUseCurrentFilter = True
        Me.ucrSelectorDisplayTopN.Location = New System.Drawing.Point(6, 40)
        Me.ucrSelectorDisplayTopN.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDisplayTopN.Name = "ucrSelectorDisplayTopN"
        Me.ucrSelectorDisplayTopN.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDisplayTopN.TabIndex = 41
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 381)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 51
        '
        'ucrPnlDataType
        '
        Me.ucrPnlDataType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDataType.Location = New System.Drawing.Point(88, 5)
        Me.ucrPnlDataType.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrPnlDataType.Name = "ucrPnlDataType"
        Me.ucrPnlDataType.Size = New System.Drawing.Size(241, 36)
        Me.ucrPnlDataType.TabIndex = 38
        Me.ucrPnlDataType.Visible = False
        '
        'ucrInputNLevels
        '
        Me.ucrInputNLevels.AddQuotesIfUnrecognised = True
        Me.ucrInputNLevels.AutoSize = True
        Me.ucrInputNLevels.IsMultiline = False
        Me.ucrInputNLevels.IsReadOnly = False
        Me.ucrInputNLevels.Location = New System.Drawing.Point(251, 116)
        Me.ucrInputNLevels.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputNLevels.Name = "ucrInputNLevels"
        Me.ucrInputNLevels.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputNLevels.TabIndex = 59
        '
        'lblTopLevels
        '
        Me.lblTopLevels.AutoSize = True
        Me.lblTopLevels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTopLevels.Location = New System.Drawing.Point(251, 101)
        Me.lblTopLevels.Name = "lblTopLevels"
        Me.lblTopLevels.Size = New System.Drawing.Size(106, 13)
        Me.lblTopLevels.TabIndex = 58
        Me.lblTopLevels.Text = "Top levels displayed:"
        '
        'ucrInputSummary
        '
        Me.ucrInputSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummary.GetSetSelectedIndex = -1
        Me.ucrInputSummary.IsReadOnly = False
        Me.ucrInputSummary.Location = New System.Drawing.Point(304, 247)
        Me.ucrInputSummary.Name = "ucrInputSummary"
        Me.ucrInputSummary.Size = New System.Drawing.Size(67, 21)
        Me.ucrInputSummary.TabIndex = 62
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummary.Location = New System.Drawing.Point(249, 249)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblSummary.TabIndex = 61
        Me.lblSummary.Text = "Summary:"
        '
        'dlgDisplayTopN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 437)
        Me.Controls.Add(Me.ucrInputSummary)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.ucrInputNLevels)
        Me.Controls.Add(Me.ucrInputOrder)
        Me.Controls.Add(Me.lblTopLevels)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lbOrder)
        Me.Controls.Add(Me.ucrInputSymbol)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.ucrSaveDisplay)
        Me.Controls.Add(Me.ucrChkIsCurrency)
        Me.Controls.Add(Me.rdoPrimary)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblWeightBy)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverWeightBy)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrSelectorDisplayTopN)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlDataType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayTopN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display Top N"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbOrder As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrInputSymbol As ucrInputTextBox
    Friend WithEvents lblSymbol As Label
    Friend WithEvents ucrSaveDisplay As ucrSave
    Friend WithEvents ucrChkIsCurrency As ucrCheck
    Friend WithEvents rdoPrimary As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblWeightBy As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverWeightBy As ucrReceiverSingle
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrSelectorDisplayTopN As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlDataType As UcrPanel
    Friend WithEvents ucrInputLayout As ucrInputComboBox
    Friend WithEvents ucrInputOrder As ucrInputComboBox
    Friend WithEvents lblLayout As Label
    Friend WithEvents ucrInputNLevels As ucrInputTextBox
    Friend WithEvents lblTopLevels As Label
    Friend WithEvents ucrInputDisplay As ucrInputComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputSummary As ucrInputComboBox
    Friend WithEvents lblSummary As Label
End Class
