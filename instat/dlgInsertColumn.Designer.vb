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
        Me.nudPos = New System.Windows.Forms.NumericUpDown()
        Me.nudNumCols = New System.Windows.Forms.NumericUpDown()
        Me.lblNumberOfRowsToInsert = New System.Windows.Forms.Label()
        Me.grpInsert = New System.Windows.Forms.GroupBox()
        Me.ucrInputBeforeAfter = New instat.ucrInputComboBox()
        Me.rdoBeforeAfter = New System.Windows.Forms.RadioButton()
        Me.rdoAtStart = New System.Windows.Forms.RadioButton()
        Me.rdoAtEnd = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverColumnsToInsert = New instat.ucrReceiverSingle()
        Me.lblNumberOfColumnsToInsert = New System.Windows.Forms.Label()
        Me.nudInsertColumns = New System.Windows.Forms.NumericUpDown()
        Me.lblDefaultValue = New System.Windows.Forms.Label()
        Me.lblPrefixforInsertedColumns = New System.Windows.Forms.Label()
        Me.ucrInputPrefixForInsertedColumns = New instat.ucrInputTextBox()
        Me.ucrInputDefaultValue = New instat.ucrInputTextBox()
        Me.ucrSelectorInseertColumns = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFramesList = New instat.ucrDataFrame()
        Me.grpOPtions = New System.Windows.Forms.GroupBox()
        Me.rdoAfter = New System.Windows.Forms.RadioButton()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
        Me.rdoInsertColumns = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColumnsOrRows = New instat.UcrPanel()
        Me.rdoInsertRows = New System.Windows.Forms.RadioButton()
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInsert.SuspendLayout()
        CType(Me.nudInsertColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOPtions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStartPos
        '
        Me.lblStartPos.AutoSize = True
        Me.lblStartPos.Location = New System.Drawing.Point(12, 129)
        Me.lblStartPos.Name = "lblStartPos"
        Me.lblStartPos.Size = New System.Drawing.Size(88, 13)
        Me.lblStartPos.TabIndex = 7
        Me.lblStartPos.Text = "Insert at Position:"
        '
        'nudPos
        '
        Me.nudPos.Location = New System.Drawing.Point(148, 127)
        Me.nudPos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPos.Name = "nudPos"
        Me.nudPos.Size = New System.Drawing.Size(52, 20)
        Me.nudPos.TabIndex = 8
        Me.nudPos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNumCols
        '
        Me.nudNumCols.Location = New System.Drawing.Point(148, 101)
        Me.nudNumCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumCols.Name = "nudNumCols"
        Me.nudNumCols.Size = New System.Drawing.Size(52, 20)
        Me.nudNumCols.TabIndex = 6
        Me.nudNumCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNumberOfRowsToInsert
        '
        Me.lblNumberOfRowsToInsert.AutoSize = True
        Me.lblNumberOfRowsToInsert.Location = New System.Drawing.Point(12, 103)
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
        Me.lblNumberOfRowsToInsert.Size = New System.Drawing.Size(130, 13)
        Me.lblNumberOfRowsToInsert.TabIndex = 5
        Me.lblNumberOfRowsToInsert.Text = "Number of Rows to Insert:"
        '
        'grpInsert
        '
        Me.grpInsert.Controls.Add(Me.ucrInputBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoAtStart)
        Me.grpInsert.Controls.Add(Me.rdoAtEnd)
        Me.grpInsert.Controls.Add(Me.ucrReceiverColumnsToInsert)
        Me.grpInsert.Location = New System.Drawing.Point(265, 78)
        Me.grpInsert.Name = "grpInsert"
        Me.grpInsert.Size = New System.Drawing.Size(215, 92)
        Me.grpInsert.TabIndex = 10
        Me.grpInsert.TabStop = False
        Me.grpInsert.Text = "Insert"
        '
        'ucrInputBeforeAfter
        '
        Me.ucrInputBeforeAfter.AddQuotesIfUnrecognised = True
        Me.ucrInputBeforeAfter.IsReadOnly = False
        Me.ucrInputBeforeAfter.Location = New System.Drawing.Point(26, 65)
        Me.ucrInputBeforeAfter.Name = "ucrInputBeforeAfter"
        Me.ucrInputBeforeAfter.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputBeforeAfter.TabIndex = 3
        '
        'rdoBeforeAfter
        '
        Me.rdoBeforeAfter.AutoSize = True
        Me.rdoBeforeAfter.Location = New System.Drawing.Point(6, 70)
        Me.rdoBeforeAfter.Name = "rdoBeforeAfter"
        Me.rdoBeforeAfter.Size = New System.Drawing.Size(14, 13)
        Me.rdoBeforeAfter.TabIndex = 2
        Me.rdoBeforeAfter.TabStop = True
        Me.rdoBeforeAfter.UseVisualStyleBackColor = True
        '
        'rdoAtStart
        '
        Me.rdoAtStart.AutoSize = True
        Me.rdoAtStart.Location = New System.Drawing.Point(6, 42)
        Me.rdoAtStart.Name = "rdoAtStart"
        Me.rdoAtStart.Size = New System.Drawing.Size(60, 17)
        Me.rdoAtStart.TabIndex = 1
        Me.rdoAtStart.TabStop = True
        Me.rdoAtStart.Text = "At Start"
        Me.rdoAtStart.UseVisualStyleBackColor = True
        '
        'rdoAtEnd
        '
        Me.rdoAtEnd.AutoSize = True
        Me.rdoAtEnd.Location = New System.Drawing.Point(6, 19)
        Me.rdoAtEnd.Name = "rdoAtEnd"
        Me.rdoAtEnd.Size = New System.Drawing.Size(57, 17)
        Me.rdoAtEnd.TabIndex = 0
        Me.rdoAtEnd.TabStop = True
        Me.rdoAtEnd.Text = "At End"
        Me.rdoAtEnd.UseVisualStyleBackColor = True
        '
        'ucrReceiverColumnsToInsert
        '
        Me.ucrReceiverColumnsToInsert.frmParent = Me
        Me.ucrReceiverColumnsToInsert.Location = New System.Drawing.Point(128, 65)
        Me.ucrReceiverColumnsToInsert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToInsert.Name = "ucrReceiverColumnsToInsert"
        Me.ucrReceiverColumnsToInsert.Selector = Nothing
        Me.ucrReceiverColumnsToInsert.Size = New System.Drawing.Size(75, 20)
        Me.ucrReceiverColumnsToInsert.strNcFilePath = ""
        Me.ucrReceiverColumnsToInsert.TabIndex = 4
        Me.ucrReceiverColumnsToInsert.ucrSelector = Nothing
        '
        'lblNumberOfColumnsToInsert
        '
        Me.lblNumberOfColumnsToInsert.AutoSize = True
        Me.lblNumberOfColumnsToInsert.Location = New System.Drawing.Point(263, 183)
        Me.lblNumberOfColumnsToInsert.Name = "lblNumberOfColumnsToInsert"
        Me.lblNumberOfColumnsToInsert.Size = New System.Drawing.Size(143, 13)
        Me.lblNumberOfColumnsToInsert.TabIndex = 11
        Me.lblNumberOfColumnsToInsert.Text = "Number of Columns to Insert:"
        '
        'nudInsertColumns
        '
        Me.nudInsertColumns.Location = New System.Drawing.Point(408, 179)
        Me.nudInsertColumns.Name = "nudInsertColumns"
        Me.nudInsertColumns.Size = New System.Drawing.Size(45, 20)
        Me.nudInsertColumns.TabIndex = 12
        '
        'lblDefaultValue
        '
        Me.lblDefaultValue.AutoSize = True
        Me.lblDefaultValue.Location = New System.Drawing.Point(264, 208)
        Me.lblDefaultValue.Name = "lblDefaultValue"
        Me.lblDefaultValue.Size = New System.Drawing.Size(74, 13)
        Me.lblDefaultValue.TabIndex = 13
        Me.lblDefaultValue.Text = "Default Value:"
        '
        'lblPrefixforInsertedColumns
        '
        Me.lblPrefixforInsertedColumns.AutoSize = True
        Me.lblPrefixforInsertedColumns.Location = New System.Drawing.Point(10, 248)
        Me.lblPrefixforInsertedColumns.Name = "lblPrefixforInsertedColumns"
        Me.lblPrefixforInsertedColumns.Size = New System.Drawing.Size(141, 13)
        Me.lblPrefixforInsertedColumns.TabIndex = 15
        Me.lblPrefixforInsertedColumns.Text = "Prefix for Inserted Column(s):"
        '
        'ucrInputPrefixForInsertedColumns
        '
        Me.ucrInputPrefixForInsertedColumns.AddQuotesIfUnrecognised = True
        Me.ucrInputPrefixForInsertedColumns.IsMultiline = False
        Me.ucrInputPrefixForInsertedColumns.IsReadOnly = False
        Me.ucrInputPrefixForInsertedColumns.Location = New System.Drawing.Point(158, 246)
        Me.ucrInputPrefixForInsertedColumns.Name = "ucrInputPrefixForInsertedColumns"
        Me.ucrInputPrefixForInsertedColumns.Size = New System.Drawing.Size(250, 21)
        Me.ucrInputPrefixForInsertedColumns.TabIndex = 16
        '
        'ucrInputDefaultValue
        '
        Me.ucrInputDefaultValue.AddQuotesIfUnrecognised = True
        Me.ucrInputDefaultValue.IsMultiline = False
        Me.ucrInputDefaultValue.IsReadOnly = False
        Me.ucrInputDefaultValue.Location = New System.Drawing.Point(408, 204)
        Me.ucrInputDefaultValue.Name = "ucrInputDefaultValue"
        Me.ucrInputDefaultValue.Size = New System.Drawing.Size(45, 21)
        Me.ucrInputDefaultValue.TabIndex = 14
        '
        'ucrSelectorInseertColumns
        '
        Me.ucrSelectorInseertColumns.bShowHiddenColumns = False
        Me.ucrSelectorInseertColumns.Location = New System.Drawing.Point(9, 97)
        Me.ucrSelectorInseertColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInseertColumns.Name = "ucrSelectorInseertColumns"
        Me.ucrSelectorInseertColumns.Size = New System.Drawing.Size(202, 148)
        Me.ucrSelectorInseertColumns.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 270)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 17
        '
        'ucrDataFramesList
        '
        Me.ucrDataFramesList.bUseCurrentFilter = True
        Me.ucrDataFramesList.Location = New System.Drawing.Point(10, 52)
        Me.ucrDataFramesList.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFramesList.Name = "ucrDataFramesList"
        Me.ucrDataFramesList.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFramesList.TabIndex = 3
        '
        'grpOPtions
        '
        Me.grpOPtions.Controls.Add(Me.rdoAfter)
        Me.grpOPtions.Controls.Add(Me.rdoBefore)
        Me.grpOPtions.Location = New System.Drawing.Point(265, 78)
        Me.grpOPtions.Name = "grpOPtions"
        Me.grpOPtions.Size = New System.Drawing.Size(124, 67)
        Me.grpOPtions.TabIndex = 9
        Me.grpOPtions.TabStop = False
        Me.grpOPtions.Text = "Options"
        '
        'rdoAfter
        '
        Me.rdoAfter.AutoSize = True
        Me.rdoAfter.Location = New System.Drawing.Point(6, 44)
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.Size = New System.Drawing.Size(47, 17)
        Me.rdoAfter.TabIndex = 1
        Me.rdoAfter.TabStop = True
        Me.rdoAfter.Text = "After"
        Me.rdoAfter.UseVisualStyleBackColor = True
        '
        'rdoBefore
        '
        Me.rdoBefore.AutoSize = True
        Me.rdoBefore.Location = New System.Drawing.Point(6, 20)
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.Size = New System.Drawing.Size(56, 17)
        Me.rdoBefore.TabIndex = 0
        Me.rdoBefore.TabStop = True
        Me.rdoBefore.Text = "Before"
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'rdoInsertColumns
        '
        Me.rdoInsertColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInsertColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertColumns.FlatAppearance.BorderSize = 2
        Me.rdoInsertColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInsertColumns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoInsertColumns.Location = New System.Drawing.Point(140, 12)
        Me.rdoInsertColumns.Name = "rdoInsertColumns"
        Me.rdoInsertColumns.Size = New System.Drawing.Size(100, 28)
        Me.rdoInsertColumns.TabIndex = 1
        Me.rdoInsertColumns.Text = "Insert Columns"
        Me.rdoInsertColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInsertColumns.UseVisualStyleBackColor = True
        '
        'ucrPnlColumnsOrRows
        '
        Me.ucrPnlColumnsOrRows.Location = New System.Drawing.Point(132, 11)
        Me.ucrPnlColumnsOrRows.Name = "ucrPnlColumnsOrRows"
        Me.ucrPnlColumnsOrRows.Size = New System.Drawing.Size(214, 29)
        Me.ucrPnlColumnsOrRows.TabIndex = 0
        '
        'rdoInsertRows
        '
        Me.rdoInsertRows.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInsertRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertRows.FlatAppearance.BorderSize = 2
        Me.rdoInsertRows.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInsertRows.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoInsertRows.Location = New System.Drawing.Point(238, 12)
        Me.rdoInsertRows.Name = "rdoInsertRows"
        Me.rdoInsertRows.Size = New System.Drawing.Size(100, 28)
        Me.rdoInsertRows.TabIndex = 2
        Me.rdoInsertRows.Text = "Insert Rows"
        Me.rdoInsertRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInsertRows.UseVisualStyleBackColor = True
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 327)
        Me.Controls.Add(Me.rdoInsertRows)
        Me.Controls.Add(Me.rdoInsertColumns)
        Me.Controls.Add(Me.ucrPnlColumnsOrRows)
        Me.Controls.Add(Me.grpOPtions)
        Me.Controls.Add(Me.ucrInputPrefixForInsertedColumns)
        Me.Controls.Add(Me.lblPrefixforInsertedColumns)
        Me.Controls.Add(Me.ucrInputDefaultValue)
        Me.Controls.Add(Me.lblDefaultValue)
        Me.Controls.Add(Me.nudInsertColumns)
        Me.Controls.Add(Me.lblNumberOfColumnsToInsert)
        Me.Controls.Add(Me.grpInsert)
        Me.Controls.Add(Me.ucrSelectorInseertColumns)
        Me.Controls.Add(Me.lblStartPos)
        Me.Controls.Add(Me.nudNumCols)
        Me.Controls.Add(Me.nudPos)
        Me.Controls.Add(Me.lblNumberOfRowsToInsert)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDataFramesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInsertColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Columns/Rows"
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInsert.ResumeLayout(False)
        Me.grpInsert.PerformLayout()
        CType(Me.nudInsertColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOPtions.ResumeLayout(False)
        Me.grpOPtions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFramesList As ucrDataFrame
    Friend WithEvents lblStartPos As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudPos As NumericUpDown
    Friend WithEvents nudNumCols As NumericUpDown
    Friend WithEvents lblNumberOfRowsToInsert As Label
    Friend WithEvents ucrSelectorInseertColumns As ucrSelectorAddRemove
    Friend WithEvents grpInsert As GroupBox
    Friend WithEvents ucrInputBeforeAfter As ucrInputComboBox
    Friend WithEvents rdoBeforeAfter As RadioButton
    Friend WithEvents rdoAtStart As RadioButton
    Friend WithEvents rdoAtEnd As RadioButton
    Friend WithEvents ucrReceiverColumnsToInsert As ucrReceiverSingle
    Friend WithEvents lblNumberOfColumnsToInsert As Label
    Friend WithEvents nudInsertColumns As NumericUpDown
    Friend WithEvents lblDefaultValue As Label
    Friend WithEvents ucrInputDefaultValue As ucrInputTextBox
    Friend WithEvents lblPrefixforInsertedColumns As Label
    Friend WithEvents ucrInputPrefixForInsertedColumns As ucrInputTextBox
    Friend WithEvents grpOPtions As GroupBox
    Friend WithEvents rdoAfter As RadioButton
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents rdoInsertColumns As RadioButton
    Friend WithEvents ucrPnlColumnsOrRows As UcrPanel
    Friend WithEvents rdoInsertRows As RadioButton
End Class
