<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgInsertColumn
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
        Me.lblStartPos = New System.Windows.Forms.Label()
        Me.lblNumberOfRowsToInsert = New System.Windows.Forms.Label()
        Me.lblNumberOfColumnsToInsert = New System.Windows.Forms.Label()
        Me.lblDefaultValue = New System.Windows.Forms.Label()
        Me.lblPrefixforInsertedColumns = New System.Windows.Forms.Label()
        Me.ucrInputPrefixForInsertedColumns = New instat.ucrInputTextBox()
        Me.ucrInputDefaultValue = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFramesList = New instat.ucrDataFrame()
        Me.ucrNudInsertColumns = New instat.ucrNud()
        Me.grpColRows = New System.Windows.Forms.GroupBox()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColRows = New instat.UcrPanel()
        Me.grpInsert = New System.Windows.Forms.GroupBox()
        Me.ucrInputBeforeAfter = New instat.ucrInputComboBox()
        Me.ucrReceiverColumnsToInsert = New instat.ucrReceiverSingle()
        Me.rdoBeforeAfter = New System.Windows.Forms.RadioButton()
        Me.rdoAtStart = New System.Windows.Forms.RadioButton()
        Me.rdoAtEnd = New System.Windows.Forms.RadioButton()
        Me.ucrPnlInsert = New instat.UcrPanel()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.rdoAfter = New System.Windows.Forms.RadioButton()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.UcrNudNumCols = New instat.ucrNud()
        Me.ucrNudPos = New instat.ucrNud()
        Me.ucrSelectorInseertColumns = New instat.ucrSelectorAddRemove()
        Me.grpColRows.SuspendLayout()
        Me.grpInsert.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStartPos
        '
        Me.lblStartPos.AutoSize = True
        Me.lblStartPos.Location = New System.Drawing.Point(12, 109)
        Me.lblStartPos.Name = "lblStartPos"
        Me.lblStartPos.Size = New System.Drawing.Size(88, 13)
        Me.lblStartPos.TabIndex = 4
        Me.lblStartPos.Text = "Insert at Position:"
        '
        'lblNumberOfRowsToInsert
        '
        Me.lblNumberOfRowsToInsert.AutoSize = True
        Me.lblNumberOfRowsToInsert.Location = New System.Drawing.Point(12, 83)
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
        Me.lblNumberOfRowsToInsert.Size = New System.Drawing.Size(130, 13)
        Me.lblNumberOfRowsToInsert.TabIndex = 14
        Me.lblNumberOfRowsToInsert.Text = "Number of Rows to Insert:"
        '
        'lblNumberOfColumnsToInsert
        '
        Me.lblNumberOfColumnsToInsert.AutoSize = True
        Me.lblNumberOfColumnsToInsert.Location = New System.Drawing.Point(263, 163)
        Me.lblNumberOfColumnsToInsert.Name = "lblNumberOfColumnsToInsert"
        Me.lblNumberOfColumnsToInsert.Size = New System.Drawing.Size(143, 13)
        Me.lblNumberOfColumnsToInsert.TabIndex = 21
        Me.lblNumberOfColumnsToInsert.Text = "Number of Columns to Insert:"
        '
        'lblDefaultValue
        '
        Me.lblDefaultValue.AutoSize = True
        Me.lblDefaultValue.Location = New System.Drawing.Point(264, 188)
        Me.lblDefaultValue.Name = "lblDefaultValue"
        Me.lblDefaultValue.Size = New System.Drawing.Size(74, 13)
        Me.lblDefaultValue.TabIndex = 23
        Me.lblDefaultValue.Text = "Default Value:"
        '
        'lblPrefixforInsertedColumns
        '
        Me.lblPrefixforInsertedColumns.AutoSize = True
        Me.lblPrefixforInsertedColumns.Location = New System.Drawing.Point(9, 278)
        Me.lblPrefixforInsertedColumns.Name = "lblPrefixforInsertedColumns"
        Me.lblPrefixforInsertedColumns.Size = New System.Drawing.Size(141, 13)
        Me.lblPrefixforInsertedColumns.TabIndex = 25
        Me.lblPrefixforInsertedColumns.Text = "Prefix for Inserted Column(s):"
        '
        'ucrInputPrefixForInsertedColumns
        '
        Me.ucrInputPrefixForInsertedColumns.bAddRemoveParameter = True
        Me.ucrInputPrefixForInsertedColumns.bChangeParameterValue = True
        Me.ucrInputPrefixForInsertedColumns.IsMultiline = False
        Me.ucrInputPrefixForInsertedColumns.IsReadOnly = False
        Me.ucrInputPrefixForInsertedColumns.Location = New System.Drawing.Point(156, 276)
        Me.ucrInputPrefixForInsertedColumns.Name = "ucrInputPrefixForInsertedColumns"
        Me.ucrInputPrefixForInsertedColumns.Size = New System.Drawing.Size(254, 21)
        Me.ucrInputPrefixForInsertedColumns.TabIndex = 26
        '
        'ucrInputDefaultValue
        '
        Me.ucrInputDefaultValue.bAddRemoveParameter = True
        Me.ucrInputDefaultValue.bChangeParameterValue = True
        Me.ucrInputDefaultValue.IsMultiline = False
        Me.ucrInputDefaultValue.IsReadOnly = False
        Me.ucrInputDefaultValue.Location = New System.Drawing.Point(418, 188)
        Me.ucrInputDefaultValue.Name = "ucrInputDefaultValue"
        Me.ucrInputDefaultValue.Size = New System.Drawing.Size(45, 21)
        Me.ucrInputDefaultValue.TabIndex = 24
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(11, 300)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'ucrDataFramesList
        '
        Me.ucrDataFramesList.bAddRemoveParameter = True
        Me.ucrDataFramesList.bChangeParameterValue = True
        Me.ucrDataFramesList.bUseCurrentFilter = True
        Me.ucrDataFramesList.Location = New System.Drawing.Point(9, 32)
        Me.ucrDataFramesList.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFramesList.Name = "ucrDataFramesList"
        Me.ucrDataFramesList.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFramesList.TabIndex = 0
        '
        'ucrNudInsertColumns
        '
        Me.ucrNudInsertColumns.bAddRemoveParameter = True
        Me.ucrNudInsertColumns.bChangeParameterValue = True
        Me.ucrNudInsertColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudInsertColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudInsertColumns.Location = New System.Drawing.Point(418, 158)
        Me.ucrNudInsertColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudInsertColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudInsertColumns.Name = "ucrNudInsertColumns"
        Me.ucrNudInsertColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudInsertColumns.TabIndex = 28
        Me.ucrNudInsertColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpColRows
        '
        Me.grpColRows.Controls.Add(Me.rdoRows)
        Me.grpColRows.Controls.Add(Me.rdoColumns)
        Me.grpColRows.Controls.Add(Me.ucrPnlColRows)
        Me.grpColRows.Location = New System.Drawing.Point(106, 2)
        Me.grpColRows.Name = "grpColRows"
        Me.grpColRows.Size = New System.Drawing.Size(304, 40)
        Me.grpColRows.TabIndex = 29
        Me.grpColRows.TabStop = False
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(117, 16)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(81, 17)
        Me.rdoRows.TabIndex = 2
        Me.rdoRows.TabStop = True
        Me.rdoRows.Text = "Insert Rows"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'rdoColumns
        '
        Me.rdoColumns.AutoSize = True
        Me.rdoColumns.Location = New System.Drawing.Point(10, 16)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(94, 17)
        Me.rdoColumns.TabIndex = 1
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Text = "Insert Columns"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'ucrPnlColRows
        '
        Me.ucrPnlColRows.bAddRemoveParameter = True
        Me.ucrPnlColRows.bChangeParameterValue = True
        Me.ucrPnlColRows.Location = New System.Drawing.Point(3, 11)
        Me.ucrPnlColRows.Name = "ucrPnlColRows"
        Me.ucrPnlColRows.Size = New System.Drawing.Size(280, 23)
        Me.ucrPnlColRows.TabIndex = 0
        '
        'grpInsert
        '
        Me.grpInsert.Controls.Add(Me.ucrInputBeforeAfter)
        Me.grpInsert.Controls.Add(Me.ucrReceiverColumnsToInsert)
        Me.grpInsert.Controls.Add(Me.rdoBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoAtStart)
        Me.grpInsert.Controls.Add(Me.rdoAtEnd)
        Me.grpInsert.Controls.Add(Me.ucrPnlInsert)
        Me.grpInsert.Location = New System.Drawing.Point(267, 48)
        Me.grpInsert.Name = "grpInsert"
        Me.grpInsert.Size = New System.Drawing.Size(211, 103)
        Me.grpInsert.TabIndex = 30
        Me.grpInsert.TabStop = False
        Me.grpInsert.Text = "Insert"
        '
        'ucrInputBeforeAfter
        '
        Me.ucrInputBeforeAfter.bAddRemoveParameter = True
        Me.ucrInputBeforeAfter.bChangeParameterValue = True
        Me.ucrInputBeforeAfter.IsReadOnly = False
        Me.ucrInputBeforeAfter.Location = New System.Drawing.Point(30, 62)
        Me.ucrInputBeforeAfter.Name = "ucrInputBeforeAfter"
        Me.ucrInputBeforeAfter.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputBeforeAfter.TabIndex = 21
        '
        'ucrReceiverColumnsToInsert
        '
        Me.ucrReceiverColumnsToInsert.bAddRemoveParameter = True
        Me.ucrReceiverColumnsToInsert.bChangeParameterValue = True
        Me.ucrReceiverColumnsToInsert.frmParent = Me
        Me.ucrReceiverColumnsToInsert.Location = New System.Drawing.Point(129, 62)
        Me.ucrReceiverColumnsToInsert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToInsert.Name = "ucrReceiverColumnsToInsert"
        Me.ucrReceiverColumnsToInsert.Selector = Nothing
        Me.ucrReceiverColumnsToInsert.Size = New System.Drawing.Size(75, 20)
        Me.ucrReceiverColumnsToInsert.TabIndex = 22
        '
        'rdoBeforeAfter
        '
        Me.rdoBeforeAfter.AutoSize = True
        Me.rdoBeforeAfter.Location = New System.Drawing.Point(10, 65)
        Me.rdoBeforeAfter.Name = "rdoBeforeAfter"
        Me.rdoBeforeAfter.Size = New System.Drawing.Size(14, 13)
        Me.rdoBeforeAfter.TabIndex = 3
        Me.rdoBeforeAfter.TabStop = True
        Me.rdoBeforeAfter.UseVisualStyleBackColor = True
        '
        'rdoAtStart
        '
        Me.rdoAtStart.AutoSize = True
        Me.rdoAtStart.Location = New System.Drawing.Point(10, 43)
        Me.rdoAtStart.Name = "rdoAtStart"
        Me.rdoAtStart.Size = New System.Drawing.Size(60, 17)
        Me.rdoAtStart.TabIndex = 2
        Me.rdoAtStart.TabStop = True
        Me.rdoAtStart.Text = "At Start"
        Me.rdoAtStart.UseVisualStyleBackColor = True
        '
        'rdoAtEnd
        '
        Me.rdoAtEnd.AutoSize = True
        Me.rdoAtEnd.Location = New System.Drawing.Point(10, 21)
        Me.rdoAtEnd.Name = "rdoAtEnd"
        Me.rdoAtEnd.Size = New System.Drawing.Size(57, 17)
        Me.rdoAtEnd.TabIndex = 1
        Me.rdoAtEnd.TabStop = True
        Me.rdoAtEnd.Text = "At End"
        Me.rdoAtEnd.UseVisualStyleBackColor = True
        '
        'ucrPnlInsert
        '
        Me.ucrPnlInsert.bAddRemoveParameter = True
        Me.ucrPnlInsert.bChangeParameterValue = True
        Me.ucrPnlInsert.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlInsert.Name = "ucrPnlInsert"
        Me.ucrPnlInsert.Size = New System.Drawing.Size(204, 76)
        Me.ucrPnlInsert.TabIndex = 0
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.rdoAfter)
        Me.grpOptions.Controls.Add(Me.rdoBefore)
        Me.grpOptions.Controls.Add(Me.ucrPnlOptions)
        Me.grpOptions.Location = New System.Drawing.Point(508, 60)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(127, 91)
        Me.grpOptions.TabIndex = 31
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'rdoAfter
        '
        Me.rdoAfter.AutoSize = True
        Me.rdoAfter.Location = New System.Drawing.Point(10, 51)
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.Size = New System.Drawing.Size(47, 17)
        Me.rdoAfter.TabIndex = 2
        Me.rdoAfter.TabStop = True
        Me.rdoAfter.Text = "After"
        Me.rdoAfter.UseVisualStyleBackColor = True
        '
        'rdoBefore
        '
        Me.rdoBefore.AutoSize = True
        Me.rdoBefore.Location = New System.Drawing.Point(10, 21)
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.Size = New System.Drawing.Size(56, 17)
        Me.rdoBefore.TabIndex = 1
        Me.rdoBefore.TabStop = True
        Me.rdoBefore.Text = "Before"
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.bAddRemoveParameter = True
        Me.ucrPnlOptions.bChangeParameterValue = True
        Me.ucrPnlOptions.Location = New System.Drawing.Point(7, 15)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(111, 69)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'UcrNudNumCols
        '
        Me.UcrNudNumCols.bAddRemoveParameter = True
        Me.UcrNudNumCols.bChangeParameterValue = True
        Me.UcrNudNumCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudNumCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudNumCols.Location = New System.Drawing.Point(156, 81)
        Me.UcrNudNumCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudNumCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudNumCols.Name = "UcrNudNumCols"
        Me.UcrNudNumCols.Size = New System.Drawing.Size(50, 20)
        Me.UcrNudNumCols.TabIndex = 32
        Me.UcrNudNumCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPos
        '
        Me.ucrNudPos.bAddRemoveParameter = True
        Me.ucrNudPos.bChangeParameterValue = True
        Me.ucrNudPos.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPos.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPos.Location = New System.Drawing.Point(156, 111)
        Me.ucrNudPos.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPos.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPos.Name = "ucrNudPos"
        Me.ucrNudPos.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPos.TabIndex = 33
        Me.ucrNudPos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectorInseertColumns
        '
        Me.ucrSelectorInseertColumns.bAddRemoveParameter = True
        Me.ucrSelectorInseertColumns.bChangeParameterValue = True
        Me.ucrSelectorInseertColumns.bShowHiddenColumns = False
        Me.ucrSelectorInseertColumns.Location = New System.Drawing.Point(508, 184)
        Me.ucrSelectorInseertColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInseertColumns.Name = "ucrSelectorInseertColumns"
        Me.ucrSelectorInseertColumns.Size = New System.Drawing.Size(250, 189)
        Me.ucrSelectorInseertColumns.TabIndex = 15
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 382)
        Me.Controls.Add(Me.ucrNudPos)
        Me.Controls.Add(Me.UcrNudNumCols)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpInsert)
        Me.Controls.Add(Me.grpColRows)
        Me.Controls.Add(Me.ucrSelectorInseertColumns)
        Me.Controls.Add(Me.ucrNudInsertColumns)
        Me.Controls.Add(Me.ucrInputPrefixForInsertedColumns)
        Me.Controls.Add(Me.lblPrefixforInsertedColumns)
        Me.Controls.Add(Me.ucrInputDefaultValue)
        Me.Controls.Add(Me.lblDefaultValue)
        Me.Controls.Add(Me.lblNumberOfColumnsToInsert)
        Me.Controls.Add(Me.lblStartPos)
        Me.Controls.Add(Me.lblNumberOfRowsToInsert)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDataFramesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInsertColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Columns/Rows"
        Me.grpColRows.ResumeLayout(False)
        Me.grpColRows.PerformLayout()
        Me.grpInsert.ResumeLayout(False)
        Me.grpInsert.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFramesList As ucrDataFrame
    Friend WithEvents lblStartPos As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberOfRowsToInsert As Label
    Friend WithEvents lblNumberOfColumnsToInsert As Label
    Friend WithEvents lblDefaultValue As Label
    Friend WithEvents ucrInputDefaultValue As ucrInputTextBox
    Friend WithEvents lblPrefixforInsertedColumns As Label
    Friend WithEvents ucrInputPrefixForInsertedColumns As ucrInputTextBox
    Friend WithEvents ucrNudInsertColumns As ucrNud
    Friend WithEvents grpColRows As GroupBox
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents ucrPnlColRows As UcrPanel
    Friend WithEvents grpInsert As GroupBox
    Friend WithEvents rdoBeforeAfter As RadioButton
    Friend WithEvents rdoAtStart As RadioButton
    Friend WithEvents rdoAtEnd As RadioButton
    Friend WithEvents ucrPnlInsert As UcrPanel
    Friend WithEvents ucrInputBeforeAfter As ucrInputComboBox
    Friend WithEvents ucrReceiverColumnsToInsert As ucrReceiverSingle
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents rdoAfter As RadioButton
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrNudPos As ucrNud
    Friend WithEvents UcrNudNumCols As ucrNud
    Friend WithEvents ucrSelectorInseertColumns As ucrSelectorAddRemove
End Class
