<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGeneralTable
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
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnMoreOptions = New System.Windows.Forms.Button()
        Me.grpBoxTitle = New System.Windows.Forms.GroupBox()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.btnTitleStyle = New System.Windows.Forms.Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.ucrInputTitleFooter = New instat.ucrInputTextBox()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrChkSelectTheme = New instat.ucrCheck()
        Me.ucrCboSelectThemes = New instat.ucrInputComboBox()
        Me.ucrNudPreview = New instat.ucrNud()
        Me.ucrChkPreview = New instat.ucrCheck()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblRowFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleRowFactors = New instat.ucrReceiverMultiple()
        Me.lblColFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleColFactor = New instat.ucrReceiverMultiple()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblVariblesMul = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleVariablesMul = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSingleVariable = New instat.ucrReceiverSingle()
        Me.grpBoxTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(290, 80)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(53, 13)
        Me.lblColumns.TabIndex = 24
        Me.lblColumns.Text = "Variables:"
        '
        'btnMoreOptions
        '
        Me.btnMoreOptions.Location = New System.Drawing.Point(9, 270)
        Me.btnMoreOptions.Name = "btnMoreOptions"
        Me.btnMoreOptions.Size = New System.Drawing.Size(141, 23)
        Me.btnMoreOptions.TabIndex = 25
        Me.btnMoreOptions.Text = "Table Options"
        Me.btnMoreOptions.UseVisualStyleBackColor = True
        '
        'grpBoxTitle
        '
        Me.grpBoxTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpBoxTitle.Controls.Add(Me.btnTitleStyle)
        Me.grpBoxTitle.Controls.Add(Me.lblHeaderTitle)
        Me.grpBoxTitle.Controls.Add(Me.ucrInputTitleFooter)
        Me.grpBoxTitle.Location = New System.Drawing.Point(7, 434)
        Me.grpBoxTitle.Name = "grpBoxTitle"
        Me.grpBoxTitle.Size = New System.Drawing.Size(463, 101)
        Me.grpBoxTitle.TabIndex = 34
        Me.grpBoxTitle.TabStop = False
        Me.grpBoxTitle.Text = "Title"
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(11, 22)
        Me.ucrInputTitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(359, 21)
        Me.ucrInputTitle.TabIndex = 28
        '
        'btnTitleStyle
        '
        Me.btnTitleStyle.Location = New System.Drawing.Point(374, 22)
        Me.btnTitleStyle.Name = "btnTitleStyle"
        Me.btnTitleStyle.Size = New System.Drawing.Size(79, 23)
        Me.btnTitleStyle.TabIndex = 30
        Me.btnTitleStyle.Text = "Style"
        Me.btnTitleStyle.UseVisualStyleBackColor = True
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderTitle.Location = New System.Drawing.Point(8, 52)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(63, 13)
        Me.lblHeaderTitle.TabIndex = 20
        Me.lblHeaderTitle.Text = "Title Footer:"
        '
        'ucrInputTitleFooter
        '
        Me.ucrInputTitleFooter.AddQuotesIfUnrecognised = True
        Me.ucrInputTitleFooter.AutoSize = True
        Me.ucrInputTitleFooter.IsMultiline = False
        Me.ucrInputTitleFooter.IsReadOnly = False
        Me.ucrInputTitleFooter.Location = New System.Drawing.Point(11, 69)
        Me.ucrInputTitleFooter.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTitleFooter.Name = "ucrInputTitleFooter"
        Me.ucrInputTitleFooter.Size = New System.Drawing.Size(359, 21)
        Me.ucrInputTitleFooter.TabIndex = 22
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(193, 21)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(91, 28)
        Me.rdoMultiple.TabIndex = 36
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Tag = "Multiple"
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'rdoSingle
        '
        Me.rdoSingle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSingle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingle.Location = New System.Drawing.Point(104, 21)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(91, 28)
        Me.rdoSingle.TabIndex = 37
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Tag = "Single"
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataFrame.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataFrame.Location = New System.Drawing.Point(282, 21)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(91, 28)
        Me.rdoDataFrame.TabIndex = 38
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.Tag = "Data Frame"
        Me.rdoDataFrame.Text = "Data Frame"
        Me.rdoDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFrame.UseVisualStyleBackColor = False
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(18, 12)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(431, 49)
        Me.ucrPnlOptions.TabIndex = 35
        '
        'ucrChkSelectTheme
        '
        Me.ucrChkSelectTheme.AutoSize = True
        Me.ucrChkSelectTheme.Checked = False
        Me.ucrChkSelectTheme.Location = New System.Drawing.Point(9, 312)
        Me.ucrChkSelectTheme.Name = "ucrChkSelectTheme"
        Me.ucrChkSelectTheme.Size = New System.Drawing.Size(94, 23)
        Me.ucrChkSelectTheme.TabIndex = 33
        '
        'ucrCboSelectThemes
        '
        Me.ucrCboSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrCboSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSelectThemes.GetSetSelectedIndex = -1
        Me.ucrCboSelectThemes.IsReadOnly = False
        Me.ucrCboSelectThemes.Location = New System.Drawing.Point(93, 312)
        Me.ucrCboSelectThemes.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboSelectThemes.Name = "ucrCboSelectThemes"
        Me.ucrCboSelectThemes.Size = New System.Drawing.Size(168, 21)
        Me.ucrCboSelectThemes.TabIndex = 32
        '
        'ucrNudPreview
        '
        Me.ucrNudPreview.AutoSize = True
        Me.ucrNudPreview.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreview.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreview.Location = New System.Drawing.Point(413, 204)
        Me.ucrNudPreview.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudPreview.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreview.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreview.Name = "ucrNudPreview"
        Me.ucrNudPreview.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreview.TabIndex = 31
        Me.ucrNudPreview.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPreview
        '
        Me.ucrChkPreview.AutoSize = True
        Me.ucrChkPreview.Checked = False
        Me.ucrChkPreview.Location = New System.Drawing.Point(293, 205)
        Me.ucrChkPreview.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkPreview.Name = "ucrChkPreview"
        Me.ucrChkPreview.Size = New System.Drawing.Size(119, 23)
        Me.ucrChkPreview.TabIndex = 30
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(9, 545)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(319, 24)
        Me.ucrSaveTable.TabIndex = 27
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 580)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 26
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Me
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(293, 93)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(141, 100)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 23
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(9, 75)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 22
        '
        'lblRowFactor
        '
        Me.lblRowFactor.AutoSize = True
        Me.lblRowFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowFactor.Location = New System.Drawing.Point(290, 80)
        Me.lblRowFactor.Name = "lblRowFactor"
        Me.lblRowFactor.Size = New System.Drawing.Size(70, 13)
        Me.lblRowFactor.TabIndex = 40
        Me.lblRowFactor.Text = "Row Factors:"
        '
        'ucrReceiverMultipleRowFactors
        '
        Me.ucrReceiverMultipleRowFactors.AutoSize = True
        Me.ucrReceiverMultipleRowFactors.frmParent = Me
        Me.ucrReceiverMultipleRowFactors.Location = New System.Drawing.Point(293, 93)
        Me.ucrReceiverMultipleRowFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleRowFactors.Name = "ucrReceiverMultipleRowFactors"
        Me.ucrReceiverMultipleRowFactors.Selector = Nothing
        Me.ucrReceiverMultipleRowFactors.Size = New System.Drawing.Size(141, 74)
        Me.ucrReceiverMultipleRowFactors.strNcFilePath = ""
        Me.ucrReceiverMultipleRowFactors.TabIndex = 39
        Me.ucrReceiverMultipleRowFactors.ucrSelector = Nothing
        '
        'lblColFactor
        '
        Me.lblColFactor.AutoSize = True
        Me.lblColFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColFactor.Location = New System.Drawing.Point(290, 191)
        Me.lblColFactor.Name = "lblColFactor"
        Me.lblColFactor.Size = New System.Drawing.Size(83, 13)
        Me.lblColFactor.TabIndex = 42
        Me.lblColFactor.Text = "Column Factors:"
        '
        'ucrReceiverMultipleColFactor
        '
        Me.ucrReceiverMultipleColFactor.AutoSize = True
        Me.ucrReceiverMultipleColFactor.frmParent = Me
        Me.ucrReceiverMultipleColFactor.Location = New System.Drawing.Point(293, 207)
        Me.ucrReceiverMultipleColFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleColFactor.Name = "ucrReceiverMultipleColFactor"
        Me.ucrReceiverMultipleColFactor.Selector = Nothing
        Me.ucrReceiverMultipleColFactor.Size = New System.Drawing.Size(141, 74)
        Me.ucrReceiverMultipleColFactor.strNcFilePath = ""
        Me.ucrReceiverMultipleColFactor.TabIndex = 41
        Me.ucrReceiverMultipleColFactor.ucrSelector = Nothing
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariable.Location = New System.Drawing.Point(292, 298)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(48, 13)
        Me.lblVariable.TabIndex = 44
        Me.lblVariable.Text = "Variable:"
        '
        'lblVariblesMul
        '
        Me.lblVariblesMul.AutoSize = True
        Me.lblVariblesMul.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariblesMul.Location = New System.Drawing.Point(290, 296)
        Me.lblVariblesMul.Name = "lblVariblesMul"
        Me.lblVariblesMul.Size = New System.Drawing.Size(53, 13)
        Me.lblVariblesMul.TabIndex = 46
        Me.lblVariblesMul.Text = "Variables:"
        '
        'ucrReceiverMultipleVariablesMul
        '
        Me.ucrReceiverMultipleVariablesMul.AutoSize = True
        Me.ucrReceiverMultipleVariablesMul.Enabled = False
        Me.ucrReceiverMultipleVariablesMul.frmParent = Me
        Me.ucrReceiverMultipleVariablesMul.Location = New System.Drawing.Point(293, 312)
        Me.ucrReceiverMultipleVariablesMul.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleVariablesMul.Name = "ucrReceiverMultipleVariablesMul"
        Me.ucrReceiverMultipleVariablesMul.Selector = Nothing
        Me.ucrReceiverMultipleVariablesMul.Size = New System.Drawing.Size(141, 74)
        Me.ucrReceiverMultipleVariablesMul.strNcFilePath = ""
        Me.ucrReceiverMultipleVariablesMul.TabIndex = 45
        Me.ucrReceiverMultipleVariablesMul.ucrSelector = Nothing
        '
        'ucrReceiverSingleVariable
        '
        Me.ucrReceiverSingleVariable.AutoSize = True
        Me.ucrReceiverSingleVariable.frmParent = Me
        Me.ucrReceiverSingleVariable.Location = New System.Drawing.Point(293, 312)
        Me.ucrReceiverSingleVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleVariable.Name = "ucrReceiverSingleVariable"
        Me.ucrReceiverSingleVariable.Selector = Nothing
        Me.ucrReceiverSingleVariable.Size = New System.Drawing.Size(141, 26)
        Me.ucrReceiverSingleVariable.strNcFilePath = ""
        Me.ucrReceiverSingleVariable.TabIndex = 142
        Me.ucrReceiverSingleVariable.ucrSelector = Nothing
        '
        'dlgGeneralTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 636)
        Me.Controls.Add(Me.lblVariblesMul)
        Me.Controls.Add(Me.ucrReceiverMultipleVariablesMul)
        Me.Controls.Add(Me.ucrCboSelectThemes)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.grpBoxTitle)
        Me.Controls.Add(Me.ucrChkSelectTheme)
        Me.Controls.Add(Me.ucrNudPreview)
        Me.Controls.Add(Me.ucrChkPreview)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.btnMoreOptions)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.lblRowFactor)
        Me.Controls.Add(Me.ucrReceiverMultipleRowFactors)
        Me.Controls.Add(Me.lblColFactor)
        Me.Controls.Add(Me.ucrReceiverMultipleColFactor)
        Me.Controls.Add(Me.ucrReceiverSingleVariable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgGeneralTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentation Table"
        Me.grpBoxTitle.ResumeLayout(False)
        Me.grpBoxTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents btnMoreOptions As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents ucrNudPreview As ucrNud
    Friend WithEvents ucrChkPreview As ucrCheck
    Friend WithEvents ucrChkSelectTheme As ucrCheck
    Friend WithEvents ucrCboSelectThemes As ucrInputComboBox
    Friend WithEvents grpBoxTitle As GroupBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents btnTitleStyle As Button
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents ucrInputTitleFooter As ucrInputTextBox
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoDataFrame As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents lblRowFactor As Label
    Friend WithEvents ucrReceiverMultipleRowFactors As ucrReceiverMultiple
    Friend WithEvents lblColFactor As Label
    Friend WithEvents ucrReceiverMultipleColFactor As ucrReceiverMultiple
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblVariblesMul As Label
    Friend WithEvents ucrReceiverMultipleVariablesMul As ucrReceiverMultiple
    Friend WithEvents ucrReceiverSingleVariable As ucrReceiverSingle
End Class
