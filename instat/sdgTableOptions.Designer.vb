<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTableOptions
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
        Me.tbpFormatOptions = New System.Windows.Forms.TabControl()
        Me.tbpHeader = New System.Windows.Forms.TabPage()
        Me.btnHeaderSubTitleFormat = New System.Windows.Forms.Button()
        Me.btnHeaderTitleFormat = New System.Windows.Forms.Button()
        Me.ucrInputHeaderSubtitle = New instat.ucrInputTextBox()
        Me.ucrInputHeaderTitle = New instat.ucrInputTextBox()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.tbpFooters = New System.Windows.Forms.TabPage()
        Me.dataGridFooterNotes = New System.Windows.Forms.DataGridView()
        Me.lblFooterNotes = New System.Windows.Forms.Label()
        Me.tbpSourceNotes = New System.Windows.Forms.TabPage()
        Me.dataGridViewSourceNotes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSourceNotes = New System.Windows.Forms.Label()
        Me.tbpColumns = New System.Windows.Forms.TabPage()
        Me.tbpRows = New System.Windows.Forms.TabPage()
        Me.tbpCells = New System.Windows.Forms.TabPage()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.ucrInputSelectThemes = New instat.ucrInputComboBox()
        Me.cmdManualTheme = New System.Windows.Forms.Button()
        Me.rdoSelectTheme = New System.Windows.Forms.RadioButton()
        Me.rdoManualTheme = New System.Windows.Forms.RadioButton()
        Me.ucrPnlThemesPanel = New instat.UcrPanel()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRows = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.tbpFooters.SuspendLayout()
        CType(Me.dataGridFooterNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpSourceNotes.SuspendLayout()
        CType(Me.dataGridViewSourceNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpThemes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpHeader)
        Me.tbpFormatOptions.Controls.Add(Me.tbpFooters)
        Me.tbpFormatOptions.Controls.Add(Me.tbpSourceNotes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpColumns)
        Me.tbpFormatOptions.Controls.Add(Me.tbpRows)
        Me.tbpFormatOptions.Controls.Add(Me.tbpCells)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(4, 8)
        Me.tbpFormatOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(882, 442)
        Me.tbpFormatOptions.TabIndex = 5
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.btnHeaderSubTitleFormat)
        Me.tbpHeader.Controls.Add(Me.btnHeaderTitleFormat)
        Me.tbpHeader.Controls.Add(Me.ucrInputHeaderSubtitle)
        Me.tbpHeader.Controls.Add(Me.ucrInputHeaderTitle)
        Me.tbpHeader.Controls.Add(Me.lblHeaderSubtitle)
        Me.tbpHeader.Controls.Add(Me.lblHeaderTitle)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 29)
        Me.tbpHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpHeader.Size = New System.Drawing.Size(874, 409)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Header"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'btnHeaderSubTitleFormat
        '
        Me.btnHeaderSubTitleFormat.Location = New System.Drawing.Point(328, 72)
        Me.btnHeaderSubTitleFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHeaderSubTitleFormat.Name = "btnHeaderSubTitleFormat"
        Me.btnHeaderSubTitleFormat.Size = New System.Drawing.Size(112, 35)
        Me.btnHeaderSubTitleFormat.TabIndex = 13
        Me.btnHeaderSubTitleFormat.Text = "Format"
        Me.btnHeaderSubTitleFormat.UseVisualStyleBackColor = True
        '
        'btnHeaderTitleFormat
        '
        Me.btnHeaderTitleFormat.Location = New System.Drawing.Point(328, 26)
        Me.btnHeaderTitleFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHeaderTitleFormat.Name = "btnHeaderTitleFormat"
        Me.btnHeaderTitleFormat.Size = New System.Drawing.Size(112, 35)
        Me.btnHeaderTitleFormat.TabIndex = 12
        Me.btnHeaderTitleFormat.Text = "Format"
        Me.btnHeaderTitleFormat.UseVisualStyleBackColor = True
        '
        'ucrInputHeaderSubtitle
        '
        Me.ucrInputHeaderSubtitle.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderSubtitle.AutoSize = True
        Me.ucrInputHeaderSubtitle.IsMultiline = False
        Me.ucrInputHeaderSubtitle.IsReadOnly = False
        Me.ucrInputHeaderSubtitle.Location = New System.Drawing.Point(101, 75)
        Me.ucrInputHeaderSubtitle.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputHeaderSubtitle.Name = "ucrInputHeaderSubtitle"
        Me.ucrInputHeaderSubtitle.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputHeaderSubtitle.TabIndex = 11
        '
        'ucrInputHeaderTitle
        '
        Me.ucrInputHeaderTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderTitle.AutoSize = True
        Me.ucrInputHeaderTitle.IsMultiline = False
        Me.ucrInputHeaderTitle.IsReadOnly = False
        Me.ucrInputHeaderTitle.Location = New System.Drawing.Point(101, 29)
        Me.ucrInputHeaderTitle.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputHeaderTitle.Name = "ucrInputHeaderTitle"
        Me.ucrInputHeaderTitle.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputHeaderTitle.TabIndex = 10
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderSubtitle.Location = New System.Drawing.Point(20, 83)
        Me.lblHeaderSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(67, 20)
        Me.lblHeaderSubtitle.TabIndex = 9
        Me.lblHeaderSubtitle.Text = "Subtitle:"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 29)
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(42, 20)
        Me.lblHeaderTitle.TabIndex = 8
        Me.lblHeaderTitle.Text = "Title:"
        '
        'tbpFooters
        '
        Me.tbpFooters.Controls.Add(Me.dataGridFooterNotes)
        Me.tbpFooters.Controls.Add(Me.lblFooterNotes)
        Me.tbpFooters.Location = New System.Drawing.Point(4, 29)
        Me.tbpFooters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpFooters.Name = "tbpFooters"
        Me.tbpFooters.Size = New System.Drawing.Size(874, 409)
        Me.tbpFooters.TabIndex = 3
        Me.tbpFooters.Text = "Footers"
        Me.tbpFooters.UseVisualStyleBackColor = True
        '
        'dataGridFooterNotes
        '
        Me.dataGridFooterNotes.AllowUserToAddRows = False
        Me.dataGridFooterNotes.AllowUserToDeleteRows = False
        Me.dataGridFooterNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFooterNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNote, Me.colColName, Me.colRows})
        Me.dataGridFooterNotes.Location = New System.Drawing.Point(20, 34)
        Me.dataGridFooterNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataGridFooterNotes.Name = "dataGridFooterNotes"
        Me.dataGridFooterNotes.RowHeadersWidth = 62
        Me.dataGridFooterNotes.Size = New System.Drawing.Size(665, 231)
        Me.dataGridFooterNotes.TabIndex = 5
        '
        'lblFooterNotes
        '
        Me.lblFooterNotes.AutoSize = True
        Me.lblFooterNotes.Location = New System.Drawing.Point(15, 9)
        Me.lblFooterNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFooterNotes.Name = "lblFooterNotes"
        Me.lblFooterNotes.Size = New System.Drawing.Size(112, 20)
        Me.lblFooterNotes.TabIndex = 4
        Me.lblFooterNotes.Text = "Footers notes:"
        '
        'tbpSourceNotes
        '
        Me.tbpSourceNotes.Controls.Add(Me.dataGridViewSourceNotes)
        Me.tbpSourceNotes.Controls.Add(Me.lblSourceNotes)
        Me.tbpSourceNotes.Location = New System.Drawing.Point(4, 29)
        Me.tbpSourceNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpSourceNotes.Name = "tbpSourceNotes"
        Me.tbpSourceNotes.Size = New System.Drawing.Size(874, 409)
        Me.tbpSourceNotes.TabIndex = 4
        Me.tbpSourceNotes.Text = "Source Notes"
        Me.tbpSourceNotes.UseVisualStyleBackColor = True
        '
        'dataGridViewSourceNotes
        '
        Me.dataGridViewSourceNotes.AllowUserToAddRows = False
        Me.dataGridViewSourceNotes.AllowUserToDeleteRows = False
        Me.dataGridViewSourceNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewSourceNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dataGridViewSourceNotes.Location = New System.Drawing.Point(12, 37)
        Me.dataGridViewSourceNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataGridViewSourceNotes.Name = "dataGridViewSourceNotes"
        Me.dataGridViewSourceNotes.RowHeadersWidth = 62
        Me.dataGridViewSourceNotes.Size = New System.Drawing.Size(519, 231)
        Me.dataGridViewSourceNotes.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Source Text"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'lblSourceNotes
        '
        Me.lblSourceNotes.AutoSize = True
        Me.lblSourceNotes.Location = New System.Drawing.Point(7, 12)
        Me.lblSourceNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSourceNotes.Name = "lblSourceNotes"
        Me.lblSourceNotes.Size = New System.Drawing.Size(112, 20)
        Me.lblSourceNotes.TabIndex = 6
        Me.lblSourceNotes.Text = "Footers notes:"
        '
        'tbpColumns
        '
        Me.tbpColumns.Location = New System.Drawing.Point(4, 29)
        Me.tbpColumns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpColumns.Name = "tbpColumns"
        Me.tbpColumns.Size = New System.Drawing.Size(874, 409)
        Me.tbpColumns.TabIndex = 5
        Me.tbpColumns.Text = "Columns"
        Me.tbpColumns.UseVisualStyleBackColor = True
        '
        'tbpRows
        '
        Me.tbpRows.Location = New System.Drawing.Point(4, 29)
        Me.tbpRows.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpRows.Name = "tbpRows"
        Me.tbpRows.Size = New System.Drawing.Size(874, 409)
        Me.tbpRows.TabIndex = 7
        Me.tbpRows.Text = "Rows"
        Me.tbpRows.UseVisualStyleBackColor = True
        '
        'tbpCells
        '
        Me.tbpCells.Location = New System.Drawing.Point(4, 29)
        Me.tbpCells.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpCells.Name = "tbpCells"
        Me.tbpCells.Size = New System.Drawing.Size(874, 409)
        Me.tbpCells.TabIndex = 8
        Me.tbpCells.Text = "Cells"
        Me.tbpCells.UseVisualStyleBackColor = True
        '
        'tbpThemes
        '
        Me.tbpThemes.Controls.Add(Me.ucrInputSelectThemes)
        Me.tbpThemes.Controls.Add(Me.cmdManualTheme)
        Me.tbpThemes.Controls.Add(Me.rdoSelectTheme)
        Me.tbpThemes.Controls.Add(Me.rdoManualTheme)
        Me.tbpThemes.Controls.Add(Me.ucrPnlThemesPanel)
        Me.tbpThemes.Location = New System.Drawing.Point(4, 29)
        Me.tbpThemes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(874, 409)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
        '
        'ucrInputSelectThemes
        '
        Me.ucrInputSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSelectThemes.GetSetSelectedIndex = -1
        Me.ucrInputSelectThemes.IsReadOnly = False
        Me.ucrInputSelectThemes.Location = New System.Drawing.Point(236, 45)
        Me.ucrInputSelectThemes.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSelectThemes.Name = "ucrInputSelectThemes"
        Me.ucrInputSelectThemes.Size = New System.Drawing.Size(252, 32)
        Me.ucrInputSelectThemes.TabIndex = 3
        '
        'cmdManualTheme
        '
        Me.cmdManualTheme.Location = New System.Drawing.Point(236, 91)
        Me.cmdManualTheme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdManualTheme.Name = "cmdManualTheme"
        Me.cmdManualTheme.Size = New System.Drawing.Size(252, 32)
        Me.cmdManualTheme.TabIndex = 2
        Me.cmdManualTheme.Text = "Themes Sub Dialog"
        Me.cmdManualTheme.UseVisualStyleBackColor = True
        '
        'rdoSelectTheme
        '
        Me.rdoSelectTheme.AutoSize = True
        Me.rdoSelectTheme.Checked = True
        Me.rdoSelectTheme.Location = New System.Drawing.Point(33, 48)
        Me.rdoSelectTheme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoSelectTheme.Name = "rdoSelectTheme"
        Me.rdoSelectTheme.Size = New System.Drawing.Size(132, 24)
        Me.rdoSelectTheme.TabIndex = 0
        Me.rdoSelectTheme.TabStop = True
        Me.rdoSelectTheme.Text = "Select Theme"
        Me.rdoSelectTheme.UseVisualStyleBackColor = True
        '
        'rdoManualTheme
        '
        Me.rdoManualTheme.AutoSize = True
        Me.rdoManualTheme.Location = New System.Drawing.Point(33, 94)
        Me.rdoManualTheme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoManualTheme.Name = "rdoManualTheme"
        Me.rdoManualTheme.Size = New System.Drawing.Size(139, 24)
        Me.rdoManualTheme.TabIndex = 1
        Me.rdoManualTheme.Text = "Manual Theme"
        Me.rdoManualTheme.UseVisualStyleBackColor = True
        '
        'ucrPnlThemesPanel
        '
        Me.ucrPnlThemesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlThemesPanel.Location = New System.Drawing.Point(18, 25)
        Me.ucrPnlThemesPanel.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlThemesPanel.Name = "ucrPnlThemesPanel"
        Me.ucrPnlThemesPanel.Size = New System.Drawing.Size(524, 108)
        Me.ucrPnlThemesPanel.TabIndex = 4
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(258, 460)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(336, 45)
        Me.ucrBaseSubdialog.TabIndex = 4
        '
        'colNote
        '
        Me.colNote.HeaderText = "Note Text"
        Me.colNote.MinimumWidth = 8
        Me.colNote.Name = "colNote"
        Me.colNote.Width = 272
        '
        'colColName
        '
        Me.colColName.HeaderText = "Column Expression(s)"
        Me.colColName.MinimumWidth = 8
        Me.colColName.Name = "colColName"
        Me.colColName.Width = 134
        '
        'colRows
        '
        Me.colRows.HeaderText = "Row Expression(s)"
        Me.colRows.MinimumWidth = 8
        Me.colRows.Name = "colRows"
        Me.colRows.Width = 162
        '
        'sdgTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 511)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "sdgTableOptions"
        Me.Text = "Table Options"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpHeader.PerformLayout()
        Me.tbpFooters.ResumeLayout(False)
        Me.tbpFooters.PerformLayout()
        CType(Me.dataGridFooterNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpSourceNotes.ResumeLayout(False)
        Me.tbpSourceNotes.PerformLayout()
        CType(Me.dataGridViewSourceNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpThemes.ResumeLayout(False)
        Me.tbpThemes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbpFormatOptions As TabControl
    Friend WithEvents tbpHeader As TabPage
    Friend WithEvents tbpFooters As TabPage
    Friend WithEvents tbpSourceNotes As TabPage
    Friend WithEvents tbpColumns As TabPage
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents ucrInputSelectThemes As ucrInputComboBox
    Friend WithEvents cmdManualTheme As Button
    Friend WithEvents rdoSelectTheme As RadioButton
    Friend WithEvents rdoManualTheme As RadioButton
    Friend WithEvents ucrPnlThemesPanel As UcrPanel
    Friend WithEvents ucrInputHeaderSubtitle As ucrInputTextBox
    Friend WithEvents ucrInputHeaderTitle As ucrInputTextBox
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents tbpRows As TabPage
    Friend WithEvents tbpCells As TabPage
    Friend WithEvents btnHeaderSubTitleFormat As Button
    Friend WithEvents btnHeaderTitleFormat As Button
    Friend WithEvents lblFooterNotes As Label
    Friend WithEvents dataGridFooterNotes As DataGridView
    Friend WithEvents dataGridViewSourceNotes As DataGridView
    Friend WithEvents lblSourceNotes As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colNote As DataGridViewTextBoxColumn
    Friend WithEvents colColName As DataGridViewTextBoxColumn
    Friend WithEvents colRows As DataGridViewTextBoxColumn
End Class
