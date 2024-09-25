<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrRowSummary
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
        Me.dataGridSummaries = New System.Windows.Forms.DataGridView()
        Me.btnStyle = New System.Windows.Forms.Button()
        Me.lblSummaryTypes = New System.Windows.Forms.Label()
        Me.lblSummaries = New System.Windows.Forms.Label()
        Me.btnClearSummaries = New System.Windows.Forms.Button()
        Me.btnAddSummaries = New System.Windows.Forms.Button()
        Me.lblSummaryLabel = New System.Windows.Forms.Label()
        Me.lblReplaceWith = New System.Windows.Forms.Label()
        Me.btnFormat = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblGroupId = New System.Windows.Forms.Label()
        Me.lblSide = New System.Windows.Forms.Label()
        Me.ucrCboSide = New instat.ucrInputComboBox()
        Me.ucrTxtGroupId = New instat.ucrInputTextBox()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrTxtReplaceNa = New instat.ucrInputTextBox()
        Me.ucrCboSummaryType = New instat.ucrInputComboBox()
        Me.ucrTxtSummaryLabel = New instat.ucrInputTextBox()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridSummaries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridSummaries
        '
        Me.dataGridSummaries.AllowUserToAddRows = False
        Me.dataGridSummaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridSummaries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colExpression})
        Me.dataGridSummaries.Location = New System.Drawing.Point(360, 451)
        Me.dataGridSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataGridSummaries.Name = "dataGridSummaries"
        Me.dataGridSummaries.ReadOnly = True
        Me.dataGridSummaries.RowHeadersWidth = 62
        Me.dataGridSummaries.Size = New System.Drawing.Size(522, 120)
        Me.dataGridSummaries.TabIndex = 335
        '
        'btnStyle
        '
        Me.btnStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStyle.Location = New System.Drawing.Point(740, 303)
        Me.btnStyle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStyle.Name = "btnStyle"
        Me.btnStyle.Size = New System.Drawing.Size(126, 35)
        Me.btnStyle.TabIndex = 341
        Me.btnStyle.Tag = ""
        Me.btnStyle.Text = "Style"
        Me.btnStyle.UseVisualStyleBackColor = True
        '
        'lblSummaryTypes
        '
        Me.lblSummaryTypes.AutoSize = True
        Me.lblSummaryTypes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryTypes.Location = New System.Drawing.Point(356, 144)
        Me.lblSummaryTypes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummaryTypes.Name = "lblSummaryTypes"
        Me.lblSummaryTypes.Size = New System.Drawing.Size(118, 20)
        Me.lblSummaryTypes.TabIndex = 339
        Me.lblSummaryTypes.Text = "Summary Type:"
        '
        'lblSummaries
        '
        Me.lblSummaries.AutoSize = True
        Me.lblSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaries.Location = New System.Drawing.Point(362, 426)
        Me.lblSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummaries.Name = "lblSummaries"
        Me.lblSummaries.Size = New System.Drawing.Size(93, 20)
        Me.lblSummaries.TabIndex = 338
        Me.lblSummaries.Text = "Summaries:"
        '
        'btnClearSummaries
        '
        Me.btnClearSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearSummaries.Location = New System.Drawing.Point(758, 410)
        Me.btnClearSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearSummaries.Name = "btnClearSummaries"
        Me.btnClearSummaries.Size = New System.Drawing.Size(118, 35)
        Me.btnClearSummaries.TabIndex = 337
        Me.btnClearSummaries.Tag = ""
        Me.btnClearSummaries.Text = "Clear"
        Me.btnClearSummaries.UseVisualStyleBackColor = True
        '
        'btnAddSummaries
        '
        Me.btnAddSummaries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddSummaries.Location = New System.Drawing.Point(359, 373)
        Me.btnAddSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddSummaries.Name = "btnAddSummaries"
        Me.btnAddSummaries.Size = New System.Drawing.Size(144, 35)
        Me.btnAddSummaries.TabIndex = 336
        Me.btnAddSummaries.Tag = ""
        Me.btnAddSummaries.Text = "Add"
        Me.btnAddSummaries.UseVisualStyleBackColor = True
        '
        'lblSummaryLabel
        '
        Me.lblSummaryLabel.AutoSize = True
        Me.lblSummaryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryLabel.Location = New System.Drawing.Point(355, 286)
        Me.lblSummaryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummaryLabel.Name = "lblSummaryLabel"
        Me.lblSummaryLabel.Size = New System.Drawing.Size(196, 20)
        Me.lblSummaryLabel.TabIndex = 342
        Me.lblSummaryLabel.Text = "Summary Label (Optional):"
        '
        'lblReplaceWith
        '
        Me.lblReplaceWith.AutoSize = True
        Me.lblReplaceWith.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReplaceWith.Location = New System.Drawing.Point(590, 144)
        Me.lblReplaceWith.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReplaceWith.Name = "lblReplaceWith"
        Me.lblReplaceWith.Size = New System.Drawing.Size(203, 20)
        Me.lblReplaceWith.TabIndex = 346
        Me.lblReplaceWith.Text = "Replace NA with (Optional):"
        '
        'btnFormat
        '
        Me.btnFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFormat.Location = New System.Drawing.Point(594, 304)
        Me.btnFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFormat.Name = "btnFormat"
        Me.btnFormat.Size = New System.Drawing.Size(136, 35)
        Me.btnFormat.TabIndex = 348
        Me.btnFormat.Tag = ""
        Me.btnFormat.Text = "Format"
        Me.btnFormat.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(362, 13)
        Me.lblColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(85, 20)
        Me.lblColumns.TabIndex = 350
        Me.lblColumns.Text = "Column(s):"
        '
        'lblGroupId
        '
        Me.lblGroupId.AutoSize = True
        Me.lblGroupId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupId.Location = New System.Drawing.Point(590, 216)
        Me.lblGroupId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGroupId.Name = "lblGroupId"
        Me.lblGroupId.Size = New System.Drawing.Size(152, 20)
        Me.lblGroupId.TabIndex = 352
        Me.lblGroupId.Text = "Group ID (Optional):"
        '
        'lblSide
        '
        Me.lblSide.AutoSize = True
        Me.lblSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSide.Location = New System.Drawing.Point(361, 216)
        Me.lblSide.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(45, 20)
        Me.lblSide.TabIndex = 354
        Me.lblSide.Text = "Side:"
        '
        'ucrCboSide
        '
        Me.ucrCboSide.AddQuotesIfUnrecognised = True
        Me.ucrCboSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSide.GetSetSelectedIndex = -1
        Me.ucrCboSide.IsReadOnly = False
        Me.ucrCboSide.Location = New System.Drawing.Point(359, 237)
        Me.ucrCboSide.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrCboSide.Name = "ucrCboSide"
        Me.ucrCboSide.Size = New System.Drawing.Size(176, 40)
        Me.ucrCboSide.TabIndex = 355
        '
        'ucrTxtGroupId
        '
        Me.ucrTxtGroupId.AddQuotesIfUnrecognised = True
        Me.ucrTxtGroupId.AutoSize = True
        Me.ucrTxtGroupId.IsMultiline = False
        Me.ucrTxtGroupId.IsReadOnly = False
        Me.ucrTxtGroupId.Location = New System.Drawing.Point(594, 240)
        Me.ucrTxtGroupId.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrTxtGroupId.Name = "ucrTxtGroupId"
        Me.ucrTxtGroupId.Size = New System.Drawing.Size(180, 32)
        Me.ucrTxtGroupId.TabIndex = 353
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(359, 38)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(198, 85)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 351
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(9, 7)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorCols.TabIndex = 349
        '
        'ucrTxtReplaceNa
        '
        Me.ucrTxtReplaceNa.AddQuotesIfUnrecognised = True
        Me.ucrTxtReplaceNa.AutoSize = True
        Me.ucrTxtReplaceNa.IsMultiline = False
        Me.ucrTxtReplaceNa.IsReadOnly = False
        Me.ucrTxtReplaceNa.Location = New System.Drawing.Point(594, 166)
        Me.ucrTxtReplaceNa.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrTxtReplaceNa.Name = "ucrTxtReplaceNa"
        Me.ucrTxtReplaceNa.Size = New System.Drawing.Size(180, 32)
        Me.ucrTxtReplaceNa.TabIndex = 347
        '
        'ucrCboSummaryType
        '
        Me.ucrCboSummaryType.AddQuotesIfUnrecognised = True
        Me.ucrCboSummaryType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSummaryType.GetSetSelectedIndex = -1
        Me.ucrCboSummaryType.IsReadOnly = False
        Me.ucrCboSummaryType.Location = New System.Drawing.Point(359, 167)
        Me.ucrCboSummaryType.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrCboSummaryType.Name = "ucrCboSummaryType"
        Me.ucrCboSummaryType.Size = New System.Drawing.Size(176, 40)
        Me.ucrCboSummaryType.TabIndex = 345
        '
        'ucrTxtSummaryLabel
        '
        Me.ucrTxtSummaryLabel.AddQuotesIfUnrecognised = True
        Me.ucrTxtSummaryLabel.AutoSize = True
        Me.ucrTxtSummaryLabel.IsMultiline = False
        Me.ucrTxtSummaryLabel.IsReadOnly = False
        Me.ucrTxtSummaryLabel.Location = New System.Drawing.Point(360, 312)
        Me.ucrTxtSummaryLabel.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrTxtSummaryLabel.Name = "ucrTxtSummaryLabel"
        Me.ucrTxtSummaryLabel.Size = New System.Drawing.Size(180, 32)
        Me.ucrTxtSummaryLabel.TabIndex = 343
        '
        'colType
        '
        Me.colType.HeaderText = "Summary Expression"
        Me.colType.MinimumWidth = 8
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 150
        '
        'colExpression
        '
        Me.colExpression.HeaderText = "Style Expression"
        Me.colExpression.MinimumWidth = 8
        Me.colExpression.Name = "colExpression"
        Me.colExpression.ReadOnly = True
        Me.colExpression.Width = 150
        '
        'ucrRowSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrCboSide)
        Me.Controls.Add(Me.lblSide)
        Me.Controls.Add(Me.ucrTxtGroupId)
        Me.Controls.Add(Me.lblGroupId)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.btnFormat)
        Me.Controls.Add(Me.ucrTxtReplaceNa)
        Me.Controls.Add(Me.lblReplaceWith)
        Me.Controls.Add(Me.ucrCboSummaryType)
        Me.Controls.Add(Me.ucrTxtSummaryLabel)
        Me.Controls.Add(Me.lblSummaryLabel)
        Me.Controls.Add(Me.dataGridSummaries)
        Me.Controls.Add(Me.btnStyle)
        Me.Controls.Add(Me.lblSummaryTypes)
        Me.Controls.Add(Me.lblSummaries)
        Me.Controls.Add(Me.btnClearSummaries)
        Me.Controls.Add(Me.btnAddSummaries)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrRowSummary"
        Me.Size = New System.Drawing.Size(890, 576)
        CType(Me.dataGridSummaries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridSummaries As DataGridView
    Friend WithEvents btnStyle As Button
    Friend WithEvents lblSummaryTypes As Label
    Friend WithEvents lblSummaries As Label
    Friend WithEvents btnClearSummaries As Button
    Friend WithEvents btnAddSummaries As Button
    Friend WithEvents ucrTxtSummaryLabel As ucrInputTextBox
    Friend WithEvents lblSummaryLabel As Label
    Friend WithEvents ucrCboSummaryType As ucrInputComboBox
    Friend WithEvents ucrTxtReplaceNa As ucrInputTextBox
    Friend WithEvents lblReplaceWith As Label
    Friend WithEvents btnFormat As Button
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrTxtGroupId As ucrInputTextBox
    Friend WithEvents lblGroupId As Label
    Friend WithEvents lblSide As Label
    Friend WithEvents ucrCboSide As ucrInputComboBox
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colExpression As DataGridViewTextBoxColumn
End Class
