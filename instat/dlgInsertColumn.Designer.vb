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
        Me.ucrReceiverColumnsToInsert = New instat.ucrReceiverSingle()
        Me.lblNumberOfColumnsToInsert = New System.Windows.Forms.Label()
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
        Me.ucrNudInsertColumns = New instat.ucrNud()
        Me.grpColRows = New System.Windows.Forms.GroupBox()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColRows = New instat.UcrPanel()
        Me.grpinsert1 = New System.Windows.Forms.GroupBox()
        Me.ucrInputBeforeAfter1 = New instat.ucrInputComboBox()
        Me.ucrReceiverColumnsToInsert1 = New instat.ucrReceiverSingle()
        Me.rdoBeforeAfter1 = New System.Windows.Forms.RadioButton()
        Me.rdoAtStart1 = New System.Windows.Forms.RadioButton()
        Me.rdoAtEnd1 = New System.Windows.Forms.RadioButton()
        Me.ucrPnlInsert = New instat.UcrPanel()
        Me.grpOptions1 = New System.Windows.Forms.GroupBox()
        Me.rdoAfter1 = New System.Windows.Forms.RadioButton()
        Me.rdoBefore1 = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInsert.SuspendLayout()
        Me.grpOPtions.SuspendLayout()
        Me.grpColRows.SuspendLayout()
        Me.grpinsert1.SuspendLayout()
        Me.grpOptions1.SuspendLayout()
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
        'nudPos
        '
        Me.nudPos.Location = New System.Drawing.Point(148, 107)
        Me.nudPos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPos.Name = "nudPos"
        Me.nudPos.Size = New System.Drawing.Size(52, 20)
        Me.nudPos.TabIndex = 7
        Me.nudPos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNumCols
        '
        Me.nudNumCols.Location = New System.Drawing.Point(148, 81)
        Me.nudNumCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumCols.Name = "nudNumCols"
        Me.nudNumCols.Size = New System.Drawing.Size(52, 20)
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
        Me.lblNumberOfRowsToInsert.Location = New System.Drawing.Point(12, 83)
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
        Me.lblNumberOfRowsToInsert.Size = New System.Drawing.Size(130, 13)
        Me.lblNumberOfRowsToInsert.TabIndex = 14
        Me.lblNumberOfRowsToInsert.Text = "Number of Rows to Insert:"
        '
        'grpInsert
        '
        Me.grpInsert.Controls.Add(Me.ucrInputBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoAtStart)
        Me.grpInsert.Controls.Add(Me.rdoAtEnd)
        Me.grpInsert.Controls.Add(Me.ucrReceiverColumnsToInsert)
        Me.grpInsert.Location = New System.Drawing.Point(265, 58)
        Me.grpInsert.Name = "grpInsert"
        Me.grpInsert.Size = New System.Drawing.Size(215, 92)
        Me.grpInsert.TabIndex = 19
        Me.grpInsert.TabStop = False
        Me.grpInsert.Text = "Insert"
        '
        'ucrInputBeforeAfter
        '
        Me.ucrInputBeforeAfter.bAddRemoveParameter = True
        Me.ucrInputBeforeAfter.bChangeParameterValue = True
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
        Me.ucrReceiverColumnsToInsert.bAddRemoveParameter = True
        Me.ucrReceiverColumnsToInsert.bChangeParameterValue = True
        Me.ucrReceiverColumnsToInsert.frmParent = Me
        Me.ucrReceiverColumnsToInsert.Location = New System.Drawing.Point(128, 65)
        Me.ucrReceiverColumnsToInsert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToInsert.Name = "ucrReceiverColumnsToInsert"
        Me.ucrReceiverColumnsToInsert.Selector = Nothing
        Me.ucrReceiverColumnsToInsert.Size = New System.Drawing.Size(75, 20)
        Me.ucrReceiverColumnsToInsert.TabIndex = 20
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
        'ucrSelectorInseertColumns
        '
        Me.ucrSelectorInseertColumns.bAddRemoveParameter = True
        Me.ucrSelectorInseertColumns.bChangeParameterValue = True
        Me.ucrSelectorInseertColumns.bShowHiddenColumns = False
        Me.ucrSelectorInseertColumns.Location = New System.Drawing.Point(9, 80)
        Me.ucrSelectorInseertColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInseertColumns.Name = "ucrSelectorInseertColumns"
        Me.ucrSelectorInseertColumns.Size = New System.Drawing.Size(250, 189)
        Me.ucrSelectorInseertColumns.TabIndex = 15
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
        'grpOPtions
        '
        Me.grpOPtions.Controls.Add(Me.rdoAfter)
        Me.grpOPtions.Controls.Add(Me.rdoBefore)
        Me.grpOPtions.Location = New System.Drawing.Point(450, 230)
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
        Me.grpColRows.Location = New System.Drawing.Point(291, 12)
        Me.grpColRows.Name = "grpColRows"
        Me.grpColRows.Size = New System.Drawing.Size(304, 40)
        Me.grpColRows.TabIndex = 29
        Me.grpColRows.TabStop = False
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(117, 21)
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
        Me.rdoColumns.Location = New System.Drawing.Point(10, 21)
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
        'grpinsert1
        '
        Me.grpinsert1.Controls.Add(Me.ucrInputBeforeAfter1)
        Me.grpinsert1.Controls.Add(Me.ucrReceiverColumnsToInsert1)
        Me.grpinsert1.Controls.Add(Me.rdoBeforeAfter1)
        Me.grpinsert1.Controls.Add(Me.rdoAtStart1)
        Me.grpinsert1.Controls.Add(Me.rdoAtEnd1)
        Me.grpinsert1.Controls.Add(Me.ucrPnlInsert)
        Me.grpinsert1.Location = New System.Drawing.Point(564, 58)
        Me.grpinsert1.Name = "grpinsert1"
        Me.grpinsert1.Size = New System.Drawing.Size(227, 103)
        Me.grpinsert1.TabIndex = 30
        Me.grpinsert1.TabStop = False
        Me.grpinsert1.Text = "Insert"
        '
        'ucrInputBeforeAfter1
        '
        Me.ucrInputBeforeAfter1.bAddRemoveParameter = True
        Me.ucrInputBeforeAfter1.bChangeParameterValue = True
        Me.ucrInputBeforeAfter1.IsReadOnly = False
        Me.ucrInputBeforeAfter1.Location = New System.Drawing.Point(30, 62)
        Me.ucrInputBeforeAfter1.Name = "ucrInputBeforeAfter1"
        Me.ucrInputBeforeAfter1.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputBeforeAfter1.TabIndex = 21
        '
        'ucrReceiverColumnsToInsert1
        '
        Me.ucrReceiverColumnsToInsert1.bAddRemoveParameter = True
        Me.ucrReceiverColumnsToInsert1.bChangeParameterValue = True
        Me.ucrReceiverColumnsToInsert1.frmParent = Me
        Me.ucrReceiverColumnsToInsert1.Location = New System.Drawing.Point(132, 62)
        Me.ucrReceiverColumnsToInsert1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToInsert1.Name = "ucrReceiverColumnsToInsert1"
        Me.ucrReceiverColumnsToInsert1.Selector = Nothing
        Me.ucrReceiverColumnsToInsert1.Size = New System.Drawing.Size(75, 20)
        Me.ucrReceiverColumnsToInsert1.TabIndex = 22
        '
        'rdoBeforeAfter1
        '
        Me.rdoBeforeAfter1.AutoSize = True
        Me.rdoBeforeAfter1.Location = New System.Drawing.Point(10, 65)
        Me.rdoBeforeAfter1.Name = "rdoBeforeAfter1"
        Me.rdoBeforeAfter1.Size = New System.Drawing.Size(14, 13)
        Me.rdoBeforeAfter1.TabIndex = 3
        Me.rdoBeforeAfter1.TabStop = True
        Me.rdoBeforeAfter1.UseVisualStyleBackColor = True
        '
        'rdoAtStart1
        '
        Me.rdoAtStart1.AutoSize = True
        Me.rdoAtStart1.Location = New System.Drawing.Point(10, 43)
        Me.rdoAtStart1.Name = "rdoAtStart1"
        Me.rdoAtStart1.Size = New System.Drawing.Size(60, 17)
        Me.rdoAtStart1.TabIndex = 2
        Me.rdoAtStart1.TabStop = True
        Me.rdoAtStart1.Text = "At Start"
        Me.rdoAtStart1.UseVisualStyleBackColor = True
        '
        'rdoAtEnd1
        '
        Me.rdoAtEnd1.AutoSize = True
        Me.rdoAtEnd1.Location = New System.Drawing.Point(10, 21)
        Me.rdoAtEnd1.Name = "rdoAtEnd1"
        Me.rdoAtEnd1.Size = New System.Drawing.Size(57, 17)
        Me.rdoAtEnd1.TabIndex = 1
        Me.rdoAtEnd1.TabStop = True
        Me.rdoAtEnd1.Text = "At End"
        Me.rdoAtEnd1.UseVisualStyleBackColor = True
        '
        'ucrPnlInsert
        '
        Me.ucrPnlInsert.bAddRemoveParameter = True
        Me.ucrPnlInsert.bChangeParameterValue = True
        Me.ucrPnlInsert.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlInsert.Name = "ucrPnlInsert"
        Me.ucrPnlInsert.Size = New System.Drawing.Size(215, 76)
        Me.ucrPnlInsert.TabIndex = 0
        '
        'grpOptions1
        '
        Me.grpOptions1.Controls.Add(Me.rdoAfter1)
        Me.grpOptions1.Controls.Add(Me.rdoBefore1)
        Me.grpOptions1.Controls.Add(Me.ucrPnlOptions)
        Me.grpOptions1.Location = New System.Drawing.Point(644, 230)
        Me.grpOptions1.Name = "grpOptions1"
        Me.grpOptions1.Size = New System.Drawing.Size(127, 91)
        Me.grpOptions1.TabIndex = 31
        Me.grpOptions1.TabStop = False
        Me.grpOptions1.Text = "Options"
        '
        'rdoAfter1
        '
        Me.rdoAfter1.AutoSize = True
        Me.rdoAfter1.Location = New System.Drawing.Point(10, 51)
        Me.rdoAfter1.Name = "rdoAfter1"
        Me.rdoAfter1.Size = New System.Drawing.Size(47, 17)
        Me.rdoAfter1.TabIndex = 2
        Me.rdoAfter1.TabStop = True
        Me.rdoAfter1.Text = "After"
        Me.rdoAfter1.UseVisualStyleBackColor = True
        '
        'rdoBefore1
        '
        Me.rdoBefore1.AutoSize = True
        Me.rdoBefore1.Location = New System.Drawing.Point(10, 21)
        Me.rdoBefore1.Name = "rdoBefore1"
        Me.rdoBefore1.Size = New System.Drawing.Size(56, 17)
        Me.rdoBefore1.TabIndex = 1
        Me.rdoBefore1.TabStop = True
        Me.rdoBefore1.Text = "Before"
        Me.rdoBefore1.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.bAddRemoveParameter = True
        Me.ucrPnlOptions.bChangeParameterValue = True
        Me.ucrPnlOptions.Location = New System.Drawing.Point(3, 15)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(111, 74)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 382)
        Me.Controls.Add(Me.grpOptions1)
        Me.Controls.Add(Me.grpinsert1)
        Me.Controls.Add(Me.grpColRows)
        Me.Controls.Add(Me.ucrNudInsertColumns)
        Me.Controls.Add(Me.grpOPtions)
        Me.Controls.Add(Me.ucrInputPrefixForInsertedColumns)
        Me.Controls.Add(Me.lblPrefixforInsertedColumns)
        Me.Controls.Add(Me.ucrInputDefaultValue)
        Me.Controls.Add(Me.lblDefaultValue)
        Me.Controls.Add(Me.lblNumberOfColumnsToInsert)
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
        Me.grpOPtions.ResumeLayout(False)
        Me.grpOPtions.PerformLayout()
        Me.grpColRows.ResumeLayout(False)
        Me.grpColRows.PerformLayout()
        Me.grpinsert1.ResumeLayout(False)
        Me.grpinsert1.PerformLayout()
        Me.grpOptions1.ResumeLayout(False)
        Me.grpOptions1.PerformLayout()
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
    Friend WithEvents lblDefaultValue As Label
    Friend WithEvents ucrInputDefaultValue As ucrInputTextBox
    Friend WithEvents lblPrefixforInsertedColumns As Label
    Friend WithEvents ucrInputPrefixForInsertedColumns As ucrInputTextBox
    Friend WithEvents grpOPtions As GroupBox
    Friend WithEvents rdoAfter As RadioButton
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents ucrNudInsertColumns As ucrNud
    Friend WithEvents grpColRows As GroupBox
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents ucrPnlColRows As UcrPanel
    Friend WithEvents grpinsert1 As GroupBox
    Friend WithEvents rdoBeforeAfter1 As RadioButton
    Friend WithEvents rdoAtStart1 As RadioButton
    Friend WithEvents rdoAtEnd1 As RadioButton
    Friend WithEvents ucrPnlInsert As UcrPanel
    Friend WithEvents ucrInputBeforeAfter1 As ucrInputComboBox
    Friend WithEvents ucrReceiverColumnsToInsert1 As ucrReceiverSingle
    Friend WithEvents grpOptions1 As GroupBox
    Friend WithEvents rdoAfter1 As RadioButton
    Friend WithEvents rdoBefore1 As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
