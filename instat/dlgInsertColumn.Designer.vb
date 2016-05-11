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
        Me.lblDefaultValues = New System.Windows.Forms.Label()
        Me.lblStartPos = New System.Windows.Forms.Label()
        Me.nudPos = New System.Windows.Forms.NumericUpDown()
        Me.nudNumCols = New System.Windows.Forms.NumericUpDown()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFramesList = New instat.ucrDataFrame()
        Me.ucrInputDefaultData = New instat.ucrInputTextBox()
        Me.rdoInsertRows = New System.Windows.Forms.RadioButton()
        Me.rdoInsertColumns = New System.Windows.Forms.RadioButton()
        Me.lblNumberOfRowsToInsert = New System.Windows.Forms.Label()
        Me.ucrSelectorInseertColumns = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverInsertColumns = New instat.ucrReceiverMultiple()
        Me.lblColumnsToInsert = New System.Windows.Forms.Label()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.grpInsert = New System.Windows.Forms.GroupBox()
        Me.rdoAtEnd = New System.Windows.Forms.RadioButton()
        Me.rdoAtStart = New System.Windows.Forms.RadioButton()
        Me.rdoBeforeAfter = New System.Windows.Forms.RadioButton()
        Me.ucrInputBeforeAfter = New instat.ucrInputComboBox()
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInsert.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDefaultValues
        '
        Me.lblDefaultValues.AutoSize = True
        Me.lblDefaultValues.Location = New System.Drawing.Point(9, 137)
        Me.lblDefaultValues.Name = "lblDefaultValues"
        Me.lblDefaultValues.Size = New System.Drawing.Size(71, 13)
        Me.lblDefaultValues.TabIndex = 2
        Me.lblDefaultValues.Text = "Default Value"
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
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 257)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'ucrDataFramesList
        '
        Me.ucrDataFramesList.Location = New System.Drawing.Point(12, 32)
        Me.ucrDataFramesList.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFramesList.Name = "ucrDataFramesList"
        Me.ucrDataFramesList.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFramesList.TabIndex = 0
        '
        'ucrInputDefaultData
        '
        Me.ucrInputDefaultData.Location = New System.Drawing.Point(157, 130)
        Me.ucrInputDefaultData.Name = "ucrInputDefaultData"
        Me.ucrInputDefaultData.Size = New System.Drawing.Size(121, 21)
        Me.ucrInputDefaultData.TabIndex = 10
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
        'ucrSelectorInseertColumns
        '
        Me.ucrSelectorInseertColumns.Location = New System.Drawing.Point(12, 47)
        Me.ucrSelectorInseertColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInseertColumns.Name = "ucrSelectorInseertColumns"
        Me.ucrSelectorInseertColumns.Size = New System.Drawing.Size(250, 187)
        Me.ucrSelectorInseertColumns.TabIndex = 15
        '
        'ucrReceiverInsertColumns
        '
        Me.ucrReceiverInsertColumns.Location = New System.Drawing.Point(281, 47)
        Me.ucrReceiverInsertColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverInsertColumns.Name = "ucrReceiverInsertColumns"
        Me.ucrReceiverInsertColumns.Selector = Nothing
        Me.ucrReceiverInsertColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverInsertColumns.TabIndex = 16
        '
        'lblColumnsToInsert
        '
        Me.lblColumnsToInsert.AutoSize = True
        Me.lblColumnsToInsert.Location = New System.Drawing.Point(278, 30)
        Me.lblColumnsToInsert.Name = "lblColumnsToInsert"
        Me.lblColumnsToInsert.Size = New System.Drawing.Size(88, 13)
        Me.lblColumnsToInsert.TabIndex = 17
        Me.lblColumnsToInsert.Text = "Columns to Insert"
        '
        'lblDataFrame
        '
        Me.lblDataFrame.AutoSize = True
        Me.lblDataFrame.Location = New System.Drawing.Point(9, 30)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(62, 13)
        Me.lblDataFrame.TabIndex = 18
        Me.lblDataFrame.Text = "Data Frame"
        '
        'grpInsert
        '
        Me.grpInsert.Controls.Add(Me.ucrInputBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoAtStart)
        Me.grpInsert.Controls.Add(Me.rdoAtEnd)
        Me.grpInsert.Location = New System.Drawing.Point(281, 151)
        Me.grpInsert.Name = "grpInsert"
        Me.grpInsert.Size = New System.Drawing.Size(200, 100)
        Me.grpInsert.TabIndex = 19
        Me.grpInsert.TabStop = False
        Me.grpInsert.Text = "Insert"
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
        'rdoAtStart
        '
        Me.rdoAtStart.AutoSize = True
        Me.rdoAtStart.Location = New System.Drawing.Point(7, 43)
        Me.rdoAtStart.Name = "rdoAtStart"
        Me.rdoAtStart.Size = New System.Drawing.Size(60, 17)
        Me.rdoAtStart.TabIndex = 1
        Me.rdoAtStart.TabStop = True
        Me.rdoAtStart.Text = "At Start"
        Me.rdoAtStart.UseVisualStyleBackColor = True
        '
        'rdoBeforeAfter
        '
        Me.rdoBeforeAfter.AutoSize = True
        Me.rdoBeforeAfter.Location = New System.Drawing.Point(7, 65)
        Me.rdoBeforeAfter.Name = "rdoBeforeAfter"
        Me.rdoBeforeAfter.Size = New System.Drawing.Size(14, 13)
        Me.rdoBeforeAfter.TabIndex = 2
        Me.rdoBeforeAfter.TabStop = True
        Me.rdoBeforeAfter.UseVisualStyleBackColor = True
        '
        'ucrInputBeforeAfter
        '
        Me.ucrInputBeforeAfter.Location = New System.Drawing.Point(27, 62)
        Me.ucrInputBeforeAfter.Name = "ucrInputBeforeAfter"
        Me.ucrInputBeforeAfter.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputBeforeAfter.TabIndex = 3
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 318)
        Me.Controls.Add(Me.grpInsert)
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.lblColumnsToInsert)
        Me.Controls.Add(Me.ucrReceiverInsertColumns)
        Me.Controls.Add(Me.ucrSelectorInseertColumns)
        Me.Controls.Add(Me.ucrInputDefaultData)
        Me.Controls.Add(Me.lblDefaultValues)
        Me.Controls.Add(Me.lblStartPos)
        Me.Controls.Add(Me.nudNumCols)
        Me.Controls.Add(Me.nudPos)
        Me.Controls.Add(Me.lblNumberOfRowsToInsert)
        Me.Controls.Add(Me.rdoInsertColumns)
        Me.Controls.Add(Me.rdoInsertRows)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDataFramesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgInsertColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Columns/Rows"
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInsert.ResumeLayout(False)
        Me.grpInsert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFramesList As ucrDataFrame
    Friend WithEvents lblDefaultValues As Label
    Friend WithEvents lblStartPos As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudPos As NumericUpDown
    Friend WithEvents nudNumCols As NumericUpDown
    Friend WithEvents ucrInputDefaultData As ucrInputTextBox
    Friend WithEvents rdoInsertRows As RadioButton
    Friend WithEvents rdoInsertColumns As RadioButton
    Friend WithEvents lblNumberOfRowsToInsert As Label
    Friend WithEvents ucrSelectorInseertColumns As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverInsertColumns As ucrReceiverMultiple
    Friend WithEvents lblColumnsToInsert As Label
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents grpInsert As GroupBox
    Friend WithEvents ucrInputBeforeAfter As ucrInputComboBox
    Friend WithEvents rdoBeforeAfter As RadioButton
    Friend WithEvents rdoAtStart As RadioButton
    Friend WithEvents rdoAtEnd As RadioButton
End Class
