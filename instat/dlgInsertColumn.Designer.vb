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
        Me.rdoInsertRows = New System.Windows.Forms.RadioButton()
        Me.rdoInsertColumns = New System.Windows.Forms.RadioButton()
        Me.lblNumberOfRowsToInsert = New System.Windows.Forms.Label()
        Me.grpInsert = New System.Windows.Forms.GroupBox()
        Me.ucrInputBeforeAfter = New instat.ucrInputComboBox()
        Me.rdoBeforeAfter = New System.Windows.Forms.RadioButton()
        Me.rdoAtStart = New System.Windows.Forms.RadioButton()
        Me.rdoAtEnd = New System.Windows.Forms.RadioButton()
        Me.lblNumberOfColumnsToInsert = New System.Windows.Forms.Label()
        Me.nudInsertColumns = New System.Windows.Forms.NumericUpDown()
        Me.lblDefaultValue = New System.Windows.Forms.Label()
        Me.lblPrefixforInsertedColumns = New System.Windows.Forms.Label()
        Me.ucrInputPrefixForInsertedColumns = New instat.ucrInputTextBox()
        Me.ucrInputDefaultValue = New instat.ucrInputTextBox()
        Me.ucrReceiverColumnsToInsert = New instat.ucrReceiverSingle()
        Me.ucrSelectorInseertColumns = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFramesList = New instat.ucrDataFrame()
        Me.grpOPtions = New System.Windows.Forms.GroupBox()
        Me.rdoAfter = New System.Windows.Forms.RadioButton()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
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
        Me.lblStartPos.Location = New System.Drawing.Point(12, 111)
        Me.lblStartPos.Name = "lblStartPos"
        Me.lblStartPos.Size = New System.Drawing.Size(85, 13)
        Me.lblStartPos.TabIndex = 4
        Me.lblStartPos.Text = "Insert at Position"
        '
        'nudPos
        '
        Me.nudPos.Location = New System.Drawing.Point(157, 104)
        Me.nudPos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPos.Name = "nudPos"
        Me.nudPos.Size = New System.Drawing.Size(36, 20)
        Me.nudPos.TabIndex = 7
        Me.nudPos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNumCols
        '
        Me.nudNumCols.Location = New System.Drawing.Point(157, 78)
        Me.nudNumCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumCols.Name = "nudNumCols"
        Me.nudNumCols.Size = New System.Drawing.Size(36, 20)
        Me.nudNumCols.TabIndex = 1
        Me.nudNumCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoInsertRows
        '
        Me.rdoInsertRows.AutoSize = True
        Me.rdoInsertRows.Location = New System.Drawing.Point(112, 12)
        Me.rdoInsertRows.Name = "rdoInsertRows"
        Me.rdoInsertRows.Size = New System.Drawing.Size(81, 17)
        Me.rdoInsertRows.TabIndex = 11
        Me.rdoInsertRows.TabStop = True
        Me.rdoInsertRows.Text = "Insert Rows"
        Me.rdoInsertRows.UseVisualStyleBackColor = True
        '
        'rdoInsertColumns
        '
        Me.rdoInsertColumns.AutoSize = True
        Me.rdoInsertColumns.Location = New System.Drawing.Point(12, 12)
        Me.rdoInsertColumns.Name = "rdoInsertColumns"
        Me.rdoInsertColumns.Size = New System.Drawing.Size(94, 17)
        Me.rdoInsertColumns.TabIndex = 11
        Me.rdoInsertColumns.TabStop = True
        Me.rdoInsertColumns.Text = "Insert Columns"
        Me.rdoInsertColumns.UseVisualStyleBackColor = True
        '
        'lblNumberOfRowsToInsert
        '
        Me.lblNumberOfRowsToInsert.AutoSize = True
        Me.lblNumberOfRowsToInsert.Location = New System.Drawing.Point(12, 80)
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
        Me.lblNumberOfRowsToInsert.Size = New System.Drawing.Size(127, 13)
        Me.lblNumberOfRowsToInsert.TabIndex = 14
        Me.lblNumberOfRowsToInsert.Text = "Number of Rows to Insert"
        '
        'grpInsert
        '
        Me.grpInsert.Controls.Add(Me.ucrInputBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoAtStart)
        Me.grpInsert.Controls.Add(Me.rdoAtEnd)
        Me.grpInsert.Location = New System.Drawing.Point(265, 58)
        Me.grpInsert.Name = "grpInsert"
        Me.grpInsert.Size = New System.Drawing.Size(137, 92)
        Me.grpInsert.TabIndex = 19
        Me.grpInsert.TabStop = False
        Me.grpInsert.Text = "Insert"
        '
        'ucrInputBeforeAfter
        '
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
        'lblNumberOfColumnsToInsert
        '
        Me.lblNumberOfColumnsToInsert.AutoSize = True
        Me.lblNumberOfColumnsToInsert.Location = New System.Drawing.Point(262, 163)
        Me.lblNumberOfColumnsToInsert.Name = "lblNumberOfColumnsToInsert"
        Me.lblNumberOfColumnsToInsert.Size = New System.Drawing.Size(140, 13)
        Me.lblNumberOfColumnsToInsert.TabIndex = 21
        Me.lblNumberOfColumnsToInsert.Text = "Number of Columns to Insert"
        '
        'nudInsertColumns
        '
        Me.nudInsertColumns.Location = New System.Drawing.Point(408, 156)
        Me.nudInsertColumns.Name = "nudInsertColumns"
        Me.nudInsertColumns.Size = New System.Drawing.Size(45, 20)
        Me.nudInsertColumns.TabIndex = 22
        '
        'lblDefaultValue
        '
        Me.lblDefaultValue.AutoSize = True
        Me.lblDefaultValue.Location = New System.Drawing.Point(265, 187)
        Me.lblDefaultValue.Name = "lblDefaultValue"
        Me.lblDefaultValue.Size = New System.Drawing.Size(71, 13)
        Me.lblDefaultValue.TabIndex = 23
        Me.lblDefaultValue.Text = "Default Value"
        '
        'lblPrefixforInsertedColumns
        '
        Me.lblPrefixforInsertedColumns.AutoSize = True
        Me.lblPrefixforInsertedColumns.Location = New System.Drawing.Point(9, 270)
        Me.lblPrefixforInsertedColumns.Name = "lblPrefixforInsertedColumns"
        Me.lblPrefixforInsertedColumns.Size = New System.Drawing.Size(138, 13)
        Me.lblPrefixforInsertedColumns.TabIndex = 25
        Me.lblPrefixforInsertedColumns.Text = "Prefix for Inserted Column(s)"
        '
        'ucrInputPrefixForInsertedColumns
        '
        Me.ucrInputPrefixForInsertedColumns.IsReadOnly = False
        Me.ucrInputPrefixForInsertedColumns.Location = New System.Drawing.Point(166, 265)
        Me.ucrInputPrefixForInsertedColumns.Name = "ucrInputPrefixForInsertedColumns"
        Me.ucrInputPrefixForInsertedColumns.Size = New System.Drawing.Size(256, 21)
        Me.ucrInputPrefixForInsertedColumns.TabIndex = 26
        '
        'ucrInputDefaultValue
        '
        Me.ucrInputDefaultValue.IsReadOnly = False
        Me.ucrInputDefaultValue.Location = New System.Drawing.Point(408, 182)
        Me.ucrInputDefaultValue.Name = "ucrInputDefaultValue"
        Me.ucrInputDefaultValue.Size = New System.Drawing.Size(45, 21)
        Me.ucrInputDefaultValue.TabIndex = 24
        '
        'ucrReceiverColumnsToInsert
        '
        Me.ucrReceiverColumnsToInsert.Location = New System.Drawing.Point(408, 121)
        Me.ucrReceiverColumnsToInsert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToInsert.Name = "ucrReceiverColumnsToInsert"
        Me.ucrReceiverColumnsToInsert.Selector = Nothing
        Me.ucrReceiverColumnsToInsert.Size = New System.Drawing.Size(75, 20)
        Me.ucrReceiverColumnsToInsert.TabIndex = 20
        '
        'ucrSelectorInseertColumns
        '
        Me.ucrSelectorInseertColumns.bShowHiddenColumns = False
        Me.ucrSelectorInseertColumns.Location = New System.Drawing.Point(9, 75)
        Me.ucrSelectorInseertColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInseertColumns.Name = "ucrSelectorInseertColumns"
        Me.ucrSelectorInseertColumns.Size = New System.Drawing.Size(250, 187)
        Me.ucrSelectorInseertColumns.TabIndex = 15
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 292)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'ucrDataFramesList
        '
        Me.ucrDataFramesList.bUseCurrentFilter = False
        Me.ucrDataFramesList.Location = New System.Drawing.Point(12, 32)
        Me.ucrDataFramesList.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFramesList.Name = "ucrDataFramesList"
        Me.ucrDataFramesList.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFramesList.TabIndex = 0
        '
        'grpOPtions
        '
        Me.grpOPtions.Controls.Add(Me.rdoAfter)
        Me.grpOPtions.Controls.Add(Me.rdoBefore)
        Me.grpOPtions.Location = New System.Drawing.Point(265, 58)
        Me.grpOPtions.Name = "grpOPtions"
        Me.grpOPtions.Size = New System.Drawing.Size(124, 67)
        Me.grpOPtions.TabIndex = 27
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
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 351)
        Me.Controls.Add(Me.grpOPtions)
        Me.Controls.Add(Me.ucrInputPrefixForInsertedColumns)
        Me.Controls.Add(Me.lblPrefixforInsertedColumns)
        Me.Controls.Add(Me.ucrInputDefaultValue)
        Me.Controls.Add(Me.lblDefaultValue)
        Me.Controls.Add(Me.nudInsertColumns)
        Me.Controls.Add(Me.lblNumberOfColumnsToInsert)
        Me.Controls.Add(Me.ucrReceiverColumnsToInsert)
        Me.Controls.Add(Me.grpInsert)
        Me.Controls.Add(Me.ucrSelectorInseertColumns)
        Me.Controls.Add(Me.lblStartPos)
        Me.Controls.Add(Me.nudNumCols)
        Me.Controls.Add(Me.nudPos)
        Me.Controls.Add(Me.lblNumberOfRowsToInsert)
        Me.Controls.Add(Me.rdoInsertColumns)
        Me.Controls.Add(Me.rdoInsertRows)
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
    Friend WithEvents rdoInsertRows As RadioButton
    Friend WithEvents rdoInsertColumns As RadioButton
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
End Class
