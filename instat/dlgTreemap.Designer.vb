<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTreemap
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
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.rdoPrimary = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblWeightBy = New System.Windows.Forms.Label()
        Me.lblIdentifier = New System.Windows.Forms.Label()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.lblTextColour = New System.Windows.Forms.Label()
        Me.ucrColourText = New instat.ucrColors()
        Me.lblTileColour = New System.Windows.Forms.Label()
        Me.ucrColourTile = New instat.ucrColors()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.ucrInputSummary = New instat.ucrInputComboBox()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrInputSymbol = New instat.ucrInputTextBox()
        Me.ucrInputLabel = New instat.ucrInputComboBox()
        Me.ucrSaveTreemap = New instat.ucrSave()
        Me.ucrChkIsCurrency = New instat.ucrCheck()
        Me.ucrReceiverWeightBy = New instat.ucrReceiverSingle()
        Me.ucrReceiverIdentifier = New instat.ucrReceiverSingle()
        Me.ucrSelectorTreemap = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlDataType = New instat.UcrPanel()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabel.Location = New System.Drawing.Point(251, 224)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(36, 13)
        Me.lblLabel.TabIndex = 23
        Me.lblLabel.Text = "Label:"
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
        Me.rdoPrimary.Location = New System.Drawing.Point(73, 11)
        Me.rdoPrimary.Name = "rdoPrimary"
        Me.rdoPrimary.Size = New System.Drawing.Size(134, 28)
        Me.rdoPrimary.TabIndex = 16
        Me.rdoPrimary.TabStop = True
        Me.rdoPrimary.Tag = ""
        Me.rdoPrimary.Text = "Primary data"
        Me.rdoPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPrimary.UseVisualStyleBackColor = False
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
        Me.rdoSummary.Location = New System.Drawing.Point(205, 11)
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.Size = New System.Drawing.Size(139, 28)
        Me.rdoSummary.TabIndex = 17
        Me.rdoSummary.TabStop = True
        Me.rdoSummary.Tag = "Pie_Chart"
        Me.rdoSummary.Text = "Summary data"
        Me.rdoSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummary.UseVisualStyleBackColor = False
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(9, 232)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(147, 25)
        Me.cmdOptions.TabIndex = 27
        Me.cmdOptions.Tag = "Plot_Options..."
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblWeightBy
        '
        Me.lblWeightBy.AutoSize = True
        Me.lblWeightBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWeightBy.Location = New System.Drawing.Point(254, 111)
        Me.lblWeightBy.Name = "lblWeightBy"
        Me.lblWeightBy.Size = New System.Drawing.Size(107, 13)
        Me.lblWeightBy.TabIndex = 21
        Me.lblWeightBy.Tag = ""
        Me.lblWeightBy.Text = "Weight By (Optional):"
        '
        'lblIdentifier
        '
        Me.lblIdentifier.AutoSize = True
        Me.lblIdentifier.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIdentifier.Location = New System.Drawing.Point(254, 61)
        Me.lblIdentifier.Name = "lblIdentifier"
        Me.lblIdentifier.Size = New System.Drawing.Size(50, 13)
        Me.lblIdentifier.TabIndex = 19
        Me.lblIdentifier.Tag = "Variable:"
        Me.lblIdentifier.Text = "Identifier:"
        '
        'lblSymbol
        '
        Me.lblSymbol.AutoSize = True
        Me.lblSymbol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSymbol.Location = New System.Drawing.Point(272, 203)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(44, 13)
        Me.lblSymbol.TabIndex = 31
        Me.lblSymbol.Text = "Symbol:"
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFill.Location = New System.Drawing.Point(254, 265)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(22, 13)
        Me.lblFill.TabIndex = 33
        Me.lblFill.Tag = ""
        Me.lblFill.Text = "Fill:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.lblTextColour)
        Me.grpOptions.Controls.Add(Me.ucrColourText)
        Me.grpOptions.Controls.Add(Me.lblTileColour)
        Me.grpOptions.Controls.Add(Me.ucrColourTile)
        Me.grpOptions.Location = New System.Drawing.Point(9, 304)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(267, 79)
        Me.grpOptions.TabIndex = 35
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'lblTextColour
        '
        Me.lblTextColour.AutoSize = True
        Me.lblTextColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTextColour.Location = New System.Drawing.Point(9, 54)
        Me.lblTextColour.Name = "lblTextColour"
        Me.lblTextColour.Size = New System.Drawing.Size(63, 13)
        Me.lblTextColour.TabIndex = 38
        Me.lblTextColour.Text = "Text colour:"
        '
        'ucrColourText
        '
        Me.ucrColourText.AddQuotesIfUnrecognised = True
        Me.ucrColourText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrColourText.GetSetSelectedIndex = -1
        Me.ucrColourText.IsReadOnly = False
        Me.ucrColourText.Location = New System.Drawing.Point(115, 49)
        Me.ucrColourText.Name = "ucrColourText"
        Me.ucrColourText.Size = New System.Drawing.Size(137, 21)
        Me.ucrColourText.TabIndex = 37
        '
        'lblTileColour
        '
        Me.lblTileColour.AutoSize = True
        Me.lblTileColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTileColour.Location = New System.Drawing.Point(9, 23)
        Me.lblTileColour.Name = "lblTileColour"
        Me.lblTileColour.Size = New System.Drawing.Size(59, 13)
        Me.lblTileColour.TabIndex = 36
        Me.lblTileColour.Text = "Tile colour:"
        '
        'ucrColourTile
        '
        Me.ucrColourTile.AddQuotesIfUnrecognised = True
        Me.ucrColourTile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrColourTile.GetSetSelectedIndex = -1
        Me.ucrColourTile.IsReadOnly = False
        Me.ucrColourTile.Location = New System.Drawing.Point(115, 19)
        Me.ucrColourTile.Name = "ucrColourTile"
        Me.ucrColourTile.Size = New System.Drawing.Size(137, 21)
        Me.ucrColourTile.TabIndex = 0
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummary.Location = New System.Drawing.Point(252, 156)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblSummary.TabIndex = 36
        Me.lblSummary.Text = "Summary:"
        '
        'ucrInputSummary
        '
        Me.ucrInputSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummary.GetSetSelectedIndex = -1
        Me.ucrInputSummary.IsReadOnly = False
        Me.ucrInputSummary.Location = New System.Drawing.Point(307, 154)
        Me.ucrInputSummary.Name = "ucrInputSummary"
        Me.ucrInputSummary.Size = New System.Drawing.Size(67, 21)
        Me.ucrInputSummary.TabIndex = 37
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.AutoSize = True
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Location = New System.Drawing.Point(254, 281)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 34
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrInputSymbol
        '
        Me.ucrInputSymbol.AddQuotesIfUnrecognised = True
        Me.ucrInputSymbol.AutoSize = True
        Me.ucrInputSymbol.IsMultiline = False
        Me.ucrInputSymbol.IsReadOnly = False
        Me.ucrInputSymbol.Location = New System.Drawing.Point(323, 201)
        Me.ucrInputSymbol.Name = "ucrInputSymbol"
        Me.ucrInputSymbol.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputSymbol.TabIndex = 32
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabel.GetSetSelectedIndex = -1
        Me.ucrInputLabel.IsReadOnly = False
        Me.ucrInputLabel.Location = New System.Drawing.Point(254, 240)
        Me.ucrInputLabel.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLabel.Name = "ucrInputLabel"
        Me.ucrInputLabel.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputLabel.TabIndex = 25
        '
        'ucrSaveTreemap
        '
        Me.ucrSaveTreemap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTreemap.Location = New System.Drawing.Point(9, 384)
        Me.ucrSaveTreemap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTreemap.Name = "ucrSaveTreemap"
        Me.ucrSaveTreemap.Size = New System.Drawing.Size(327, 24)
        Me.ucrSaveTreemap.TabIndex = 29
        '
        'ucrChkIsCurrency
        '
        Me.ucrChkIsCurrency.AutoSize = True
        Me.ucrChkIsCurrency.Checked = False
        Me.ucrChkIsCurrency.Location = New System.Drawing.Point(254, 180)
        Me.ucrChkIsCurrency.Name = "ucrChkIsCurrency"
        Me.ucrChkIsCurrency.Size = New System.Drawing.Size(82, 23)
        Me.ucrChkIsCurrency.TabIndex = 28
        '
        'ucrReceiverWeightBy
        '
        Me.ucrReceiverWeightBy.AutoSize = True
        Me.ucrReceiverWeightBy.frmParent = Me
        Me.ucrReceiverWeightBy.Location = New System.Drawing.Point(254, 126)
        Me.ucrReceiverWeightBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeightBy.Name = "ucrReceiverWeightBy"
        Me.ucrReceiverWeightBy.Selector = Nothing
        Me.ucrReceiverWeightBy.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeightBy.strNcFilePath = ""
        Me.ucrReceiverWeightBy.TabIndex = 22
        Me.ucrReceiverWeightBy.ucrSelector = Nothing
        '
        'ucrReceiverIdentifier
        '
        Me.ucrReceiverIdentifier.AutoSize = True
        Me.ucrReceiverIdentifier.frmParent = Me
        Me.ucrReceiverIdentifier.Location = New System.Drawing.Point(254, 76)
        Me.ucrReceiverIdentifier.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIdentifier.Name = "ucrReceiverIdentifier"
        Me.ucrReceiverIdentifier.Selector = Nothing
        Me.ucrReceiverIdentifier.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverIdentifier.strNcFilePath = ""
        Me.ucrReceiverIdentifier.TabIndex = 20
        Me.ucrReceiverIdentifier.ucrSelector = Nothing
        '
        'ucrSelectorTreemap
        '
        Me.ucrSelectorTreemap.AutoSize = True
        Me.ucrSelectorTreemap.bDropUnusedFilterLevels = False
        Me.ucrSelectorTreemap.bShowHiddenColumns = False
        Me.ucrSelectorTreemap.bUseCurrentFilter = True
        Me.ucrSelectorTreemap.Location = New System.Drawing.Point(9, 40)
        Me.ucrSelectorTreemap.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTreemap.Name = "ucrSelectorTreemap"
        Me.ucrSelectorTreemap.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTreemap.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 410)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 30
        '
        'ucrPnlDataType
        '
        Me.ucrPnlDataType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDataType.Location = New System.Drawing.Point(64, 5)
        Me.ucrPnlDataType.Name = "ucrPnlDataType"
        Me.ucrPnlDataType.Size = New System.Drawing.Size(297, 38)
        Me.ucrPnlDataType.TabIndex = 15
        '
        'dlgTreemap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 464)
        Me.Controls.Add(Me.ucrInputSummary)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrInputSymbol)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.ucrInputLabel)
        Me.Controls.Add(Me.ucrSaveTreemap)
        Me.Controls.Add(Me.ucrChkIsCurrency)
        Me.Controls.Add(Me.rdoPrimary)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblWeightBy)
        Me.Controls.Add(Me.lblIdentifier)
        Me.Controls.Add(Me.ucrReceiverWeightBy)
        Me.Controls.Add(Me.ucrReceiverIdentifier)
        Me.Controls.Add(Me.ucrSelectorTreemap)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlDataType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTreemap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treemap"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputLabel As ucrInputComboBox
    Friend WithEvents ucrSaveTreemap As ucrSave
    Friend WithEvents ucrChkIsCurrency As ucrCheck
    Friend WithEvents rdoPrimary As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblWeightBy As Label
    Friend WithEvents lblIdentifier As Label
    Friend WithEvents ucrReceiverWeightBy As ucrReceiverSingle
    Friend WithEvents ucrReceiverIdentifier As ucrReceiverSingle
    Friend WithEvents ucrSelectorTreemap As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlDataType As UcrPanel
    Friend WithEvents ucrInputSymbol As ucrInputTextBox
    Friend WithEvents lblSymbol As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblTextColour As Label
    Friend WithEvents ucrColourText As ucrColors
    Friend WithEvents lblTileColour As Label
    Friend WithEvents ucrColourTile As ucrColors
    Friend WithEvents lblSummary As Label
    Friend WithEvents ucrInputSummary As ucrInputComboBox
End Class
