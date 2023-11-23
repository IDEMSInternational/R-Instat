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
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.tbpFooters = New System.Windows.Forms.TabPage()
        Me.tbpSourceNotes = New System.Windows.Forms.TabPage()
        Me.tbpColumns = New System.Windows.Forms.TabPage()
        Me.tbpRows = New System.Windows.Forms.TabPage()
        Me.tbpCells = New System.Windows.Forms.TabPage()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.cmdManualTheme = New System.Windows.Forms.Button()
        Me.rdoSelectTheme = New System.Windows.Forms.RadioButton()
        Me.rdoManualTheme = New System.Windows.Forms.RadioButton()
        Me.lblFooterNotes = New System.Windows.Forms.Label()
        Me.reoGridSourceNotes = New unvell.ReoGrid.ReoGridControl()
        Me.lblSourceNotes = New System.Windows.Forms.Label()
        Me.ucrInputHeaderSubtitle = New instat.ucrInputTextBox()
        Me.ucrInputHeaderTitle = New instat.ucrInputTextBox()
        Me.ucrInputSelectThemes = New instat.ucrInputComboBox()
        Me.ucrPnlThemesPanel = New instat.UcrPanel()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.dataGridFooterNotes = New System.Windows.Forms.DataGridView()
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRows = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.tbpFooters.SuspendLayout()
        Me.tbpSourceNotes.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        CType(Me.dataGridFooterNotes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbpFormatOptions.Location = New System.Drawing.Point(3, 5)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(588, 287)
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
        Me.tbpHeader.Location = New System.Drawing.Point(4, 22)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHeader.Size = New System.Drawing.Size(580, 261)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Header"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'btnHeaderSubTitleFormat
        '
        Me.btnHeaderSubTitleFormat.Location = New System.Drawing.Point(219, 47)
        Me.btnHeaderSubTitleFormat.Name = "btnHeaderSubTitleFormat"
        Me.btnHeaderSubTitleFormat.Size = New System.Drawing.Size(75, 23)
        Me.btnHeaderSubTitleFormat.TabIndex = 13
        Me.btnHeaderSubTitleFormat.Text = "Format"
        Me.btnHeaderSubTitleFormat.UseVisualStyleBackColor = True
        '
        'btnHeaderTitleFormat
        '
        Me.btnHeaderTitleFormat.Location = New System.Drawing.Point(219, 17)
        Me.btnHeaderTitleFormat.Name = "btnHeaderTitleFormat"
        Me.btnHeaderTitleFormat.Size = New System.Drawing.Size(75, 23)
        Me.btnHeaderTitleFormat.TabIndex = 12
        Me.btnHeaderTitleFormat.Text = "Format"
        Me.btnHeaderTitleFormat.UseVisualStyleBackColor = True
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderSubtitle.Location = New System.Drawing.Point(16, 52)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(45, 13)
        Me.lblHeaderSubtitle.TabIndex = 9
        Me.lblHeaderSubtitle.Text = "Subtitle:"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderTitle.Location = New System.Drawing.Point(16, 17)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblHeaderTitle.TabIndex = 8
        Me.lblHeaderTitle.Text = "Title:"
        '
        'tbpFooters
        '
        Me.tbpFooters.Controls.Add(Me.dataGridFooterNotes)
        Me.tbpFooters.Controls.Add(Me.lblFooterNotes)
        Me.tbpFooters.Location = New System.Drawing.Point(4, 22)
        Me.tbpFooters.Name = "tbpFooters"
        Me.tbpFooters.Size = New System.Drawing.Size(580, 261)
        Me.tbpFooters.TabIndex = 3
        Me.tbpFooters.Text = "Footers"
        Me.tbpFooters.UseVisualStyleBackColor = True
        '
        'tbpSourceNotes
        '
        Me.tbpSourceNotes.Controls.Add(Me.reoGridSourceNotes)
        Me.tbpSourceNotes.Controls.Add(Me.lblSourceNotes)
        Me.tbpSourceNotes.Location = New System.Drawing.Point(4, 22)
        Me.tbpSourceNotes.Name = "tbpSourceNotes"
        Me.tbpSourceNotes.Size = New System.Drawing.Size(580, 261)
        Me.tbpSourceNotes.TabIndex = 4
        Me.tbpSourceNotes.Text = "Source Notes"
        Me.tbpSourceNotes.UseVisualStyleBackColor = True
        '
        'tbpColumns
        '
        Me.tbpColumns.Location = New System.Drawing.Point(4, 22)
        Me.tbpColumns.Name = "tbpColumns"
        Me.tbpColumns.Size = New System.Drawing.Size(580, 261)
        Me.tbpColumns.TabIndex = 5
        Me.tbpColumns.Text = "Columns"
        Me.tbpColumns.UseVisualStyleBackColor = True
        '
        'tbpRows
        '
        Me.tbpRows.Location = New System.Drawing.Point(4, 22)
        Me.tbpRows.Name = "tbpRows"
        Me.tbpRows.Size = New System.Drawing.Size(580, 261)
        Me.tbpRows.TabIndex = 7
        Me.tbpRows.Text = "Rows"
        Me.tbpRows.UseVisualStyleBackColor = True
        '
        'tbpCells
        '
        Me.tbpCells.Location = New System.Drawing.Point(4, 22)
        Me.tbpCells.Name = "tbpCells"
        Me.tbpCells.Size = New System.Drawing.Size(580, 261)
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
        Me.tbpThemes.Location = New System.Drawing.Point(4, 22)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(580, 261)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
        '
        'cmdManualTheme
        '
        Me.cmdManualTheme.Location = New System.Drawing.Point(157, 59)
        Me.cmdManualTheme.Name = "cmdManualTheme"
        Me.cmdManualTheme.Size = New System.Drawing.Size(168, 21)
        Me.cmdManualTheme.TabIndex = 2
        Me.cmdManualTheme.Text = "Themes Sub Dialog"
        Me.cmdManualTheme.UseVisualStyleBackColor = True
        '
        'rdoSelectTheme
        '
        Me.rdoSelectTheme.AutoSize = True
        Me.rdoSelectTheme.Checked = True
        Me.rdoSelectTheme.Location = New System.Drawing.Point(22, 31)
        Me.rdoSelectTheme.Name = "rdoSelectTheme"
        Me.rdoSelectTheme.Size = New System.Drawing.Size(91, 17)
        Me.rdoSelectTheme.TabIndex = 0
        Me.rdoSelectTheme.TabStop = True
        Me.rdoSelectTheme.Text = "Select Theme"
        Me.rdoSelectTheme.UseVisualStyleBackColor = True
        '
        'rdoManualTheme
        '
        Me.rdoManualTheme.AutoSize = True
        Me.rdoManualTheme.Location = New System.Drawing.Point(22, 61)
        Me.rdoManualTheme.Name = "rdoManualTheme"
        Me.rdoManualTheme.Size = New System.Drawing.Size(96, 17)
        Me.rdoManualTheme.TabIndex = 1
        Me.rdoManualTheme.Text = "Manual Theme"
        Me.rdoManualTheme.UseVisualStyleBackColor = True
        '
        'lblFooterNotes
        '
        Me.lblFooterNotes.AutoSize = True
        Me.lblFooterNotes.Location = New System.Drawing.Point(10, 6)
        Me.lblFooterNotes.Name = "lblFooterNotes"
        Me.lblFooterNotes.Size = New System.Drawing.Size(74, 13)
        Me.lblFooterNotes.TabIndex = 4
        Me.lblFooterNotes.Text = "Footers notes:"
        '
        'reoGridSourceNotes
        '
        Me.reoGridSourceNotes.BackColor = System.Drawing.Color.White
        Me.reoGridSourceNotes.ColumnHeaderContextMenuStrip = Nothing
        Me.reoGridSourceNotes.LeadHeaderContextMenuStrip = Nothing
        Me.reoGridSourceNotes.Location = New System.Drawing.Point(5, 22)
        Me.reoGridSourceNotes.Name = "reoGridSourceNotes"
        Me.reoGridSourceNotes.RowHeaderContextMenuStrip = Nothing
        Me.reoGridSourceNotes.Script = Nothing
        Me.reoGridSourceNotes.SheetTabContextMenuStrip = Nothing
        Me.reoGridSourceNotes.SheetTabNewButtonVisible = True
        Me.reoGridSourceNotes.SheetTabVisible = True
        Me.reoGridSourceNotes.SheetTabWidth = 154
        Me.reoGridSourceNotes.ShowScrollEndSpacing = True
        Me.reoGridSourceNotes.Size = New System.Drawing.Size(445, 172)
        Me.reoGridSourceNotes.TabIndex = 9
        Me.reoGridSourceNotes.Text = "Variables"
        '
        'lblSourceNotes
        '
        Me.lblSourceNotes.AutoSize = True
        Me.lblSourceNotes.Location = New System.Drawing.Point(7, 6)
        Me.lblSourceNotes.Name = "lblSourceNotes"
        Me.lblSourceNotes.Size = New System.Drawing.Size(73, 13)
        Me.lblSourceNotes.TabIndex = 8
        Me.lblSourceNotes.Text = "Source notes:"
        '
        'ucrInputHeaderSubtitle
        '
        Me.ucrInputHeaderSubtitle.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderSubtitle.AutoSize = True
        Me.ucrInputHeaderSubtitle.IsMultiline = False
        Me.ucrInputHeaderSubtitle.IsReadOnly = False
        Me.ucrInputHeaderSubtitle.Location = New System.Drawing.Point(70, 47)
        Me.ucrInputHeaderSubtitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputHeaderSubtitle.Name = "ucrInputHeaderSubtitle"
        Me.ucrInputHeaderSubtitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHeaderSubtitle.TabIndex = 11
        '
        'ucrInputHeaderTitle
        '
        Me.ucrInputHeaderTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderTitle.AutoSize = True
        Me.ucrInputHeaderTitle.IsMultiline = False
        Me.ucrInputHeaderTitle.IsReadOnly = False
        Me.ucrInputHeaderTitle.Location = New System.Drawing.Point(70, 17)
        Me.ucrInputHeaderTitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputHeaderTitle.Name = "ucrInputHeaderTitle"
        Me.ucrInputHeaderTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHeaderTitle.TabIndex = 10
        '
        'ucrInputSelectThemes
        '
        Me.ucrInputSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSelectThemes.GetSetSelectedIndex = -1
        Me.ucrInputSelectThemes.IsReadOnly = False
        Me.ucrInputSelectThemes.Location = New System.Drawing.Point(157, 29)
        Me.ucrInputSelectThemes.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSelectThemes.Name = "ucrInputSelectThemes"
        Me.ucrInputSelectThemes.Size = New System.Drawing.Size(168, 21)
        Me.ucrInputSelectThemes.TabIndex = 3
        '
        'ucrPnlThemesPanel
        '
        Me.ucrPnlThemesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlThemesPanel.Location = New System.Drawing.Point(12, 16)
        Me.ucrPnlThemesPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlThemesPanel.Name = "ucrPnlThemesPanel"
        Me.ucrPnlThemesPanel.Size = New System.Drawing.Size(349, 70)
        Me.ucrPnlThemesPanel.TabIndex = 4
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(172, 299)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 4
        '
        'dataGridFooterNotes
        '
        Me.dataGridFooterNotes.AllowUserToAddRows = False
        Me.dataGridFooterNotes.AllowUserToDeleteRows = False
        Me.dataGridFooterNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFooterNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNote, Me.colColName, Me.colRows})
        Me.dataGridFooterNotes.Location = New System.Drawing.Point(13, 22)
        Me.dataGridFooterNotes.Name = "dataGridFooterNotes"
        Me.dataGridFooterNotes.Size = New System.Drawing.Size(424, 150)
        Me.dataGridFooterNotes.TabIndex = 5
        '
        'colNote
        '
        Me.colNote.HeaderText = "Note"
        Me.colNote.Name = "colNote"
        '
        'colColName
        '
        Me.colColName.HeaderText = "Column"
        Me.colColName.Name = "colColName"
        '
        'colRows
        '
        Me.colRows.HeaderText = "Rows"
        Me.colRows.Name = "colRows"
        '
        'sdgTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 332)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Name = "sdgTableOptions"
        Me.Text = "Table Options"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpHeader.PerformLayout()
        Me.tbpFooters.ResumeLayout(False)
        Me.tbpFooters.PerformLayout()
        Me.tbpSourceNotes.ResumeLayout(False)
        Me.tbpSourceNotes.PerformLayout()
        Me.tbpThemes.ResumeLayout(False)
        Me.tbpThemes.PerformLayout()
        CType(Me.dataGridFooterNotes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents reoGridSourceNotes As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblSourceNotes As Label
    Friend WithEvents dataGridFooterNotes As DataGridView
    Friend WithEvents colNote As DataGridViewTextBoxColumn
    Friend WithEvents colColName As DataGridViewTextBoxColumn
    Friend WithEvents colRows As DataGridViewTextBoxColumn
End Class
