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
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ucrSelectorByDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrTxtReplaceNa = New instat.ucrInputTextBox()
        Me.ucrCboSummaryType = New instat.ucrInputComboBox()
        Me.ucrTxtSummaryLabel = New instat.ucrInputTextBox()
        Me.ucrSelectorByTableDF = New instat.ucrSelectorByOutputObject()
        CType(Me.dataGridSummaries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridSummaries
        '
        Me.dataGridSummaries.AllowUserToAddRows = False
        Me.dataGridSummaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridSummaries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colExpression})
        Me.dataGridSummaries.Location = New System.Drawing.Point(240, 293)
        Me.dataGridSummaries.Name = "dataGridSummaries"
        Me.dataGridSummaries.ReadOnly = True
        Me.dataGridSummaries.RowHeadersWidth = 62
        Me.dataGridSummaries.Size = New System.Drawing.Size(348, 78)
        Me.dataGridSummaries.TabIndex = 335
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
        'btnStyle
        '
        Me.btnStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStyle.Location = New System.Drawing.Point(493, 198)
        Me.btnStyle.Name = "btnStyle"
        Me.btnStyle.Size = New System.Drawing.Size(84, 23)
        Me.btnStyle.TabIndex = 341
        Me.btnStyle.Tag = ""
        Me.btnStyle.Text = "Style"
        Me.btnStyle.UseVisualStyleBackColor = True
        '
        'lblSummaryTypes
        '
        Me.lblSummaryTypes.AutoSize = True
        Me.lblSummaryTypes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryTypes.Location = New System.Drawing.Point(237, 94)
        Me.lblSummaryTypes.Name = "lblSummaryTypes"
        Me.lblSummaryTypes.Size = New System.Drawing.Size(80, 13)
        Me.lblSummaryTypes.TabIndex = 339
        Me.lblSummaryTypes.Text = "Summary Type:"
        '
        'lblSummaries
        '
        Me.lblSummaries.AutoSize = True
        Me.lblSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaries.Location = New System.Drawing.Point(241, 277)
        Me.lblSummaries.Name = "lblSummaries"
        Me.lblSummaries.Size = New System.Drawing.Size(61, 13)
        Me.lblSummaries.TabIndex = 338
        Me.lblSummaries.Text = "Summaries:"
        '
        'btnClearSummaries
        '
        Me.btnClearSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearSummaries.Location = New System.Drawing.Point(505, 266)
        Me.btnClearSummaries.Name = "btnClearSummaries"
        Me.btnClearSummaries.Size = New System.Drawing.Size(79, 23)
        Me.btnClearSummaries.TabIndex = 337
        Me.btnClearSummaries.Tag = ""
        Me.btnClearSummaries.Text = "Clear"
        Me.btnClearSummaries.UseVisualStyleBackColor = True
        '
        'btnAddSummaries
        '
        Me.btnAddSummaries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddSummaries.Location = New System.Drawing.Point(239, 242)
        Me.btnAddSummaries.Name = "btnAddSummaries"
        Me.btnAddSummaries.Size = New System.Drawing.Size(96, 23)
        Me.btnAddSummaries.TabIndex = 336
        Me.btnAddSummaries.Tag = ""
        Me.btnAddSummaries.Text = "Add"
        Me.btnAddSummaries.UseVisualStyleBackColor = True
        '
        'lblSummaryLabel
        '
        Me.lblSummaryLabel.AutoSize = True
        Me.lblSummaryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryLabel.Location = New System.Drawing.Point(237, 186)
        Me.lblSummaryLabel.Name = "lblSummaryLabel"
        Me.lblSummaryLabel.Size = New System.Drawing.Size(130, 13)
        Me.lblSummaryLabel.TabIndex = 342
        Me.lblSummaryLabel.Text = "Summary Label (Optional):"
        '
        'lblReplaceWith
        '
        Me.lblReplaceWith.AutoSize = True
        Me.lblReplaceWith.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReplaceWith.Location = New System.Drawing.Point(393, 140)
        Me.lblReplaceWith.Name = "lblReplaceWith"
        Me.lblReplaceWith.Size = New System.Drawing.Size(138, 13)
        Me.lblReplaceWith.TabIndex = 346
        Me.lblReplaceWith.Text = "Replace NA with (Optional):"
        '
        'btnFormat
        '
        Me.btnFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFormat.Location = New System.Drawing.Point(396, 198)
        Me.btnFormat.Name = "btnFormat"
        Me.btnFormat.Size = New System.Drawing.Size(91, 23)
        Me.btnFormat.TabIndex = 348
        Me.btnFormat.Tag = ""
        Me.btnFormat.Text = "Format"
        Me.btnFormat.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(241, 8)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 350
        Me.lblColumns.Text = "Column(s):"
        '
        'lblGroupId
        '
        Me.lblGroupId.AutoSize = True
        Me.lblGroupId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupId.Location = New System.Drawing.Point(393, 94)
        Me.lblGroupId.Name = "lblGroupId"
        Me.lblGroupId.Size = New System.Drawing.Size(53, 13)
        Me.lblGroupId.TabIndex = 352
        Me.lblGroupId.Text = "Group ID:"
        '
        'lblSide
        '
        Me.lblSide.AutoSize = True
        Me.lblSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSide.Location = New System.Drawing.Point(241, 140)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(31, 13)
        Me.lblSide.TabIndex = 354
        Me.lblSide.Text = "Side:"
        '
        'ucrCboSide
        '
        Me.ucrCboSide.AddQuotesIfUnrecognised = True
        Me.ucrCboSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSide.GetSetSelectedIndex = -1
        Me.ucrCboSide.IsReadOnly = False
        Me.ucrCboSide.Location = New System.Drawing.Point(239, 154)
        Me.ucrCboSide.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrCboSide.Name = "ucrCboSide"
        Me.ucrCboSide.Size = New System.Drawing.Size(117, 26)
        Me.ucrCboSide.TabIndex = 355
        '
        'ucrTxtGroupId
        '
        Me.ucrTxtGroupId.AddQuotesIfUnrecognised = True
        Me.ucrTxtGroupId.AutoSize = True
        Me.ucrTxtGroupId.IsMultiline = False
        Me.ucrTxtGroupId.IsReadOnly = False
        Me.ucrTxtGroupId.Location = New System.Drawing.Point(396, 109)
        Me.ucrTxtGroupId.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrTxtGroupId.Name = "ucrTxtGroupId"
        Me.ucrTxtGroupId.Size = New System.Drawing.Size(120, 21)
        Me.ucrTxtGroupId.TabIndex = 353
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(239, 25)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(132, 55)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 351
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'ucrSelectorByDF
        '
        Me.ucrSelectorByDF.AutoSize = True
        Me.ucrSelectorByDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDF.bShowHiddenColumns = False
        Me.ucrSelectorByDF.bUseCurrentFilter = True
        Me.ucrSelectorByDF.Location = New System.Drawing.Point(6, 5)
        Me.ucrSelectorByDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDF.Name = "ucrSelectorByDF"
        Me.ucrSelectorByDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDF.TabIndex = 349
        '
        'ucrTxtReplaceNa
        '
        Me.ucrTxtReplaceNa.AddQuotesIfUnrecognised = True
        Me.ucrTxtReplaceNa.AutoSize = True
        Me.ucrTxtReplaceNa.IsMultiline = False
        Me.ucrTxtReplaceNa.IsReadOnly = False
        Me.ucrTxtReplaceNa.Location = New System.Drawing.Point(396, 155)
        Me.ucrTxtReplaceNa.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrTxtReplaceNa.Name = "ucrTxtReplaceNa"
        Me.ucrTxtReplaceNa.Size = New System.Drawing.Size(120, 21)
        Me.ucrTxtReplaceNa.TabIndex = 347
        '
        'ucrCboSummaryType
        '
        Me.ucrCboSummaryType.AddQuotesIfUnrecognised = True
        Me.ucrCboSummaryType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSummaryType.GetSetSelectedIndex = -1
        Me.ucrCboSummaryType.IsReadOnly = False
        Me.ucrCboSummaryType.Location = New System.Drawing.Point(239, 109)
        Me.ucrCboSummaryType.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrCboSummaryType.Name = "ucrCboSummaryType"
        Me.ucrCboSummaryType.Size = New System.Drawing.Size(117, 26)
        Me.ucrCboSummaryType.TabIndex = 345
        '
        'ucrTxtSummaryLabel
        '
        Me.ucrTxtSummaryLabel.AddQuotesIfUnrecognised = True
        Me.ucrTxtSummaryLabel.AutoSize = True
        Me.ucrTxtSummaryLabel.IsMultiline = False
        Me.ucrTxtSummaryLabel.IsReadOnly = False
        Me.ucrTxtSummaryLabel.Location = New System.Drawing.Point(240, 203)
        Me.ucrTxtSummaryLabel.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrTxtSummaryLabel.Name = "ucrTxtSummaryLabel"
        Me.ucrTxtSummaryLabel.Size = New System.Drawing.Size(120, 21)
        Me.ucrTxtSummaryLabel.TabIndex = 343
        '
        'ucrSelectorByTableDF
        '
        Me.ucrSelectorByTableDF.AutoSize = True
        Me.ucrSelectorByTableDF.bShowHiddenColumns = False
        Me.ucrSelectorByTableDF.Location = New System.Drawing.Point(4, 5)
        Me.ucrSelectorByTableDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByTableDF.Name = "ucrSelectorByTableDF"
        Me.ucrSelectorByTableDF.Size = New System.Drawing.Size(216, 194)
        Me.ucrSelectorByTableDF.TabIndex = 363
        '
        'ucrRowSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectorByTableDF)
        Me.Controls.Add(Me.ucrCboSide)
        Me.Controls.Add(Me.lblSide)
        Me.Controls.Add(Me.ucrTxtGroupId)
        Me.Controls.Add(Me.lblGroupId)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrSelectorByDF)
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
        Me.Name = "ucrRowSummary"
        Me.Size = New System.Drawing.Size(593, 374)
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
    Friend WithEvents ucrSelectorByDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrTxtGroupId As ucrInputTextBox
    Friend WithEvents lblGroupId As Label
    Friend WithEvents lblSide As Label
    Friend WithEvents ucrCboSide As ucrInputComboBox
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colExpression As DataGridViewTextBoxColumn
    Friend WithEvents ucrSelectorByTableDF As ucrSelectorByOutputObject
End Class
