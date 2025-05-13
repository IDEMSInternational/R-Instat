<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrNewCellFormats
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblFormats = New System.Windows.Forms.Label()
        Me.btnClearFormats = New System.Windows.Forms.Button()
        Me.btnTextFormat = New System.Windows.Forms.Button()
        Me.dataGridFormats = New System.Windows.Forms.DataGridView()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpFormatData = New System.Windows.Forms.GroupBox()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.rdoDate = New System.Windows.Forms.RadioButton()
        Me.rdoNumber = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFormat = New instat.UcrPanel()
        Me.ucrTxtMissingText = New instat.ucrInputComboBox()
        Me.lblMissingTexts = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.colMissingTexts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMissingText = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDateFormat = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.ucrChkDataFormat = New instat.ucrCheck()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFormatData.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMissingValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormats
        '
        Me.lblFormats.AutoSize = True
        Me.lblFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormats.Location = New System.Drawing.Point(233, 245)
        Me.lblFormats.Name = "lblFormats"
        Me.lblFormats.Size = New System.Drawing.Size(47, 13)
        Me.lblFormats.TabIndex = 340
        Me.lblFormats.Text = "Formats:"
        '
        'btnClearFormats
        '
        Me.btnClearFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearFormats.Location = New System.Drawing.Point(517, 236)
        Me.btnClearFormats.Name = "btnClearFormats"
        Me.btnClearFormats.Size = New System.Drawing.Size(75, 23)
        Me.btnClearFormats.TabIndex = 339
        Me.btnClearFormats.Tag = ""
        Me.btnClearFormats.Text = "Clear"
        Me.btnClearFormats.UseVisualStyleBackColor = True
        '
        'btnTextFormat
        '
        Me.btnTextFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnTextFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTextFormat.Location = New System.Drawing.Point(399, 91)
        Me.btnTextFormat.Name = "btnTextFormat"
        Me.btnTextFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnTextFormat.TabIndex = 337
        Me.btnTextFormat.Tag = ""
        Me.btnTextFormat.Text = "Text Format"
        Me.btnTextFormat.UseVisualStyleBackColor = True
        '
        'dataGridFormats
        '
        Me.dataGridFormats.AllowUserToAddRows = False
        Me.dataGridFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFormats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodnition, Me.colLabel, Me.colRow})
        Me.dataGridFormats.Location = New System.Drawing.Point(236, 262)
        Me.dataGridFormats.Name = "dataGridFormats"
        Me.dataGridFormats.ReadOnly = True
        Me.dataGridFormats.RowHeadersWidth = 62
        Me.dataGridFormats.Size = New System.Drawing.Size(361, 73)
        Me.dataGridFormats.TabIndex = 335
        '
        'colCodnition
        '
        Me.colCodnition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCodnition.HeaderText = "Format"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        Me.colCodnition.ReadOnly = True
        Me.colCodnition.Width = 64
        '
        'colLabel
        '
        Me.colLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colLabel.HeaderText = "Column(s)"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.ReadOnly = True
        Me.colLabel.Width = 78
        '
        'colRow
        '
        Me.colRow.HeaderText = "Row Expression"
        Me.colRow.Name = "colRow"
        Me.colRow.ReadOnly = True
        '
        'grpFormatData
        '
        Me.grpFormatData.Controls.Add(Me.rdoText)
        Me.grpFormatData.Controls.Add(Me.rdoDate)
        Me.grpFormatData.Controls.Add(Me.rdoNumber)
        Me.grpFormatData.Controls.Add(Me.ucrPnlFormat)
        Me.grpFormatData.Location = New System.Drawing.Point(226, 16)
        Me.grpFormatData.Name = "grpFormatData"
        Me.grpFormatData.Size = New System.Drawing.Size(314, 108)
        Me.grpFormatData.TabIndex = 344
        Me.grpFormatData.TabStop = False
        Me.grpFormatData.Text = "Select Format"
        '
        'rdoText
        '
        Me.rdoText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoText.Location = New System.Drawing.Point(6, 65)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(155, 17)
        Me.rdoText.TabIndex = 3
        Me.rdoText.TabStop = True
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoDate
        '
        Me.rdoDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDate.Location = New System.Drawing.Point(6, 41)
        Me.rdoDate.Name = "rdoDate"
        Me.rdoDate.Size = New System.Drawing.Size(155, 17)
        Me.rdoDate.TabIndex = 2
        Me.rdoDate.TabStop = True
        Me.rdoDate.Text = "Date"
        Me.rdoDate.UseVisualStyleBackColor = True
        '
        'rdoNumber
        '
        Me.rdoNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNumber.Location = New System.Drawing.Point(6, 17)
        Me.rdoNumber.Name = "rdoNumber"
        Me.rdoNumber.Size = New System.Drawing.Size(137, 16)
        Me.rdoNumber.TabIndex = 1
        Me.rdoNumber.TabStop = True
        Me.rdoNumber.Text = "Number"
        Me.rdoNumber.UseVisualStyleBackColor = True
        '
        'ucrPnlFormat
        '
        Me.ucrPnlFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFormat.Location = New System.Drawing.Point(3, 14)
        Me.ucrPnlFormat.Name = "ucrPnlFormat"
        Me.ucrPnlFormat.Size = New System.Drawing.Size(158, 69)
        Me.ucrPnlFormat.TabIndex = 0
        '
        'ucrTxtMissingText
        '
        Me.ucrTxtMissingText.AddQuotesIfUnrecognised = True
        Me.ucrTxtMissingText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrTxtMissingText.GetSetSelectedIndex = -1
        Me.ucrTxtMissingText.IsReadOnly = False
        Me.ucrTxtMissingText.Location = New System.Drawing.Point(29, 35)
        Me.ucrTxtMissingText.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrTxtMissingText.Name = "ucrTxtMissingText"
        Me.ucrTxtMissingText.Size = New System.Drawing.Size(120, 23)
        Me.ucrTxtMissingText.TabIndex = 378
        '
        'lblMissingTexts
        '
        Me.lblMissingTexts.AutoSize = True
        Me.lblMissingTexts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingTexts.Location = New System.Drawing.Point(235, 245)
        Me.lblMissingTexts.Name = "lblMissingTexts"
        Me.lblMissingTexts.Size = New System.Drawing.Size(74, 13)
        Me.lblMissingTexts.TabIndex = 376
        Me.lblMissingTexts.Text = "Missing Texts:"
        '
        'btnClear
        '
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(517, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 375
        Me.btnClear.Tag = ""
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMissingTexts})
        Me.dataGrid.Location = New System.Drawing.Point(236, 261)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 62
        Me.dataGrid.Size = New System.Drawing.Size(361, 73)
        Me.dataGrid.TabIndex = 373
        '
        'colMissingTexts
        '
        Me.colMissingTexts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMissingTexts.HeaderText = "Missing Text Expressions"
        Me.colMissingTexts.MinimumWidth = 8
        Me.colMissingTexts.Name = "colMissingTexts"
        '
        'lblMissingText
        '
        Me.lblMissingText.AutoSize = True
        Me.lblMissingText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingText.Location = New System.Drawing.Point(30, 16)
        Me.lblMissingText.Name = "lblMissingText"
        Me.lblMissingText.Size = New System.Drawing.Size(90, 13)
        Me.lblMissingText.TabIndex = 377
        Me.lblMissingText.Text = "Replace NA with:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(29, 60)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 23)
        Me.btnAdd.TabIndex = 374
        Me.btnAdd.Tag = ""
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDateFormat
        '
        Me.btnDateFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnDateFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDateFormat.Location = New System.Drawing.Point(399, 62)
        Me.btnDateFormat.Name = "btnDateFormat"
        Me.btnDateFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnDateFormat.TabIndex = 379
        Me.btnDateFormat.Tag = ""
        Me.btnDateFormat.Text = "Date Format"
        Me.btnDateFormat.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnNumberFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNumberFormat.Location = New System.Drawing.Point(399, 31)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnNumberFormat.TabIndex = 380
        Me.btnNumberFormat.Tag = ""
        Me.btnNumberFormat.Text = "Number Format"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.btnAdd)
        Me.grpMissingValues.Controls.Add(Me.lblMissingText)
        Me.grpMissingValues.Controls.Add(Me.ucrTxtMissingText)
        Me.grpMissingValues.Location = New System.Drawing.Point(220, 137)
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.Size = New System.Drawing.Size(167, 88)
        Me.grpMissingValues.TabIndex = 381
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Text = "Missing Values"
        '
        'ucrChkDataFormat
        '
        Me.ucrChkDataFormat.AutoSize = True
        Me.ucrChkDataFormat.Checked = False
        Me.ucrChkDataFormat.Location = New System.Drawing.Point(21, 37)
        Me.ucrChkDataFormat.Name = "ucrChkDataFormat"
        Me.ucrChkDataFormat.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkDataFormat.TabIndex = 382
        '
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.AutoSize = True
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(21, 137)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkMissingValues.TabIndex = 383
        '
        'ucrNewCellFormats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTextFormat)
        Me.Controls.Add(Me.ucrChkMissingValues)
        Me.Controls.Add(Me.ucrChkDataFormat)
        Me.Controls.Add(Me.grpMissingValues)
        Me.Controls.Add(Me.btnNumberFormat)
        Me.Controls.Add(Me.btnDateFormat)
        Me.Controls.Add(Me.lblMissingTexts)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.grpFormatData)
        Me.Controls.Add(Me.lblFormats)
        Me.Controls.Add(Me.btnClearFormats)
        Me.Controls.Add(Me.dataGridFormats)
        Me.Name = "ucrNewCellFormats"
        Me.Size = New System.Drawing.Size(602, 341)
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFormatData.ResumeLayout(False)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpMissingValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFormats As Label
    Friend WithEvents btnClearFormats As Button
    Friend WithEvents btnTextFormat As Button
    Friend WithEvents dataGridFormats As DataGridView
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colRow As DataGridViewTextBoxColumn
    Friend WithEvents grpFormatData As GroupBox
    Friend WithEvents rdoText As RadioButton
    Friend WithEvents rdoDate As RadioButton
    Friend WithEvents rdoNumber As RadioButton
    Friend WithEvents ucrPnlFormat As UcrPanel
    Friend WithEvents ucrTxtMissingText As ucrInputComboBox
    Friend WithEvents lblMissingTexts As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents colMissingTexts As DataGridViewTextBoxColumn
    Friend WithEvents lblMissingText As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDateFormat As Button
    Friend WithEvents btnNumberFormat As Button
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents ucrChkDataFormat As ucrCheck
    Friend WithEvents ucrChkMissingValues As ucrCheck
End Class
