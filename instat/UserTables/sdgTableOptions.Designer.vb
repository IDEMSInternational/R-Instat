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
        Me.dataGridHeaderFooterNotes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblHeaderFooterNotes = New System.Windows.Forms.Label()
        Me.tbpFooters = New System.Windows.Forms.TabPage()
        Me.dataGridCellFooterNotes = New System.Windows.Forms.DataGridView()
        Me.colFooterNoteText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFooterColExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFooterRowExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFooterFormat = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblFooterCellNotes = New System.Windows.Forms.Label()
        Me.tbpSourceNotes = New System.Windows.Forms.TabPage()
        Me.UcrSourceNotes1 = New instat.ucrSourceNotes()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.ucrCboSelectThemes = New instat.ucrInputComboBox()
        Me.btnManualTheme = New System.Windows.Forms.Button()
        Me.rdoSelectTheme = New System.Windows.Forms.RadioButton()
        Me.rdoManualTheme = New System.Windows.Forms.RadioButton()
        Me.ucrPnlThemesPanel = New instat.UcrPanel()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        CType(Me.dataGridHeaderFooterNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpFooters.SuspendLayout()
        CType(Me.dataGridCellFooterNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpSourceNotes.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpHeader)
        Me.tbpFormatOptions.Controls.Add(Me.tbpFooters)
        Me.tbpFormatOptions.Controls.Add(Me.tbpSourceNotes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(3, 5)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(650, 259)
        Me.tbpFormatOptions.TabIndex = 5
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.dataGridHeaderFooterNotes)
        Me.tbpHeader.Controls.Add(Me.lblHeaderFooterNotes)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 22)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHeader.Size = New System.Drawing.Size(642, 233)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Headers"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'dataGridHeaderFooterNotes
        '
        Me.dataGridHeaderFooterNotes.AllowUserToAddRows = False
        Me.dataGridHeaderFooterNotes.AllowUserToDeleteRows = False
        Me.dataGridHeaderFooterNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridHeaderFooterNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewButtonColumn1})
        Me.dataGridHeaderFooterNotes.Location = New System.Drawing.Point(6, 26)
        Me.dataGridHeaderFooterNotes.Name = "dataGridHeaderFooterNotes"
        Me.dataGridHeaderFooterNotes.RowHeadersWidth = 62
        Me.dataGridHeaderFooterNotes.Size = New System.Drawing.Size(630, 84)
        Me.dataGridHeaderFooterNotes.TabIndex = 15
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Note Text"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Header"
        Me.DataGridViewTextBoxColumn3.Items.AddRange(New Object() {"title", "subtitle"})
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.Width = 140
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "Format"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 60
        '
        'lblHeaderFooterNotes
        '
        Me.lblHeaderFooterNotes.AutoSize = True
        Me.lblHeaderFooterNotes.Location = New System.Drawing.Point(9, 10)
        Me.lblHeaderFooterNotes.Name = "lblHeaderFooterNotes"
        Me.lblHeaderFooterNotes.Size = New System.Drawing.Size(109, 13)
        Me.lblHeaderFooterNotes.TabIndex = 14
        Me.lblHeaderFooterNotes.Text = "Header footers notes:"
        '
        'tbpFooters
        '
        Me.tbpFooters.Controls.Add(Me.dataGridCellFooterNotes)
        Me.tbpFooters.Controls.Add(Me.lblFooterCellNotes)
        Me.tbpFooters.Location = New System.Drawing.Point(4, 22)
        Me.tbpFooters.Name = "tbpFooters"
        Me.tbpFooters.Size = New System.Drawing.Size(642, 233)
        Me.tbpFooters.TabIndex = 3
        Me.tbpFooters.Text = "Footers"
        Me.tbpFooters.UseVisualStyleBackColor = True
        '
        'dataGridCellFooterNotes
        '
        Me.dataGridCellFooterNotes.AllowUserToAddRows = False
        Me.dataGridCellFooterNotes.AllowUserToDeleteRows = False
        Me.dataGridCellFooterNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridCellFooterNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFooterNoteText, Me.colFooterColExpression, Me.colFooterRowExpression, Me.colFooterFormat})
        Me.dataGridCellFooterNotes.Location = New System.Drawing.Point(7, 31)
        Me.dataGridCellFooterNotes.Name = "dataGridCellFooterNotes"
        Me.dataGridCellFooterNotes.RowHeadersWidth = 62
        Me.dataGridCellFooterNotes.Size = New System.Drawing.Size(630, 84)
        Me.dataGridCellFooterNotes.TabIndex = 5
        '
        'colFooterNoteText
        '
        Me.colFooterNoteText.HeaderText = "Note Text"
        Me.colFooterNoteText.MinimumWidth = 8
        Me.colFooterNoteText.Name = "colFooterNoteText"
        Me.colFooterNoteText.Width = 220
        '
        'colFooterColExpression
        '
        Me.colFooterColExpression.HeaderText = "Column Expression"
        Me.colFooterColExpression.MinimumWidth = 8
        Me.colFooterColExpression.Name = "colFooterColExpression"
        Me.colFooterColExpression.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colFooterColExpression.Width = 140
        '
        'colFooterRowExpression
        '
        Me.colFooterRowExpression.HeaderText = "Row Expression(s)"
        Me.colFooterRowExpression.MinimumWidth = 8
        Me.colFooterRowExpression.Name = "colFooterRowExpression"
        Me.colFooterRowExpression.Width = 140
        '
        'colFooterFormat
        '
        Me.colFooterFormat.HeaderText = ""
        Me.colFooterFormat.Name = "colFooterFormat"
        Me.colFooterFormat.ReadOnly = True
        Me.colFooterFormat.Text = "Format"
        Me.colFooterFormat.UseColumnTextForButtonValue = True
        Me.colFooterFormat.Width = 60
        '
        'lblFooterCellNotes
        '
        Me.lblFooterCellNotes.AutoSize = True
        Me.lblFooterCellNotes.Location = New System.Drawing.Point(10, 13)
        Me.lblFooterCellNotes.Name = "lblFooterCellNotes"
        Me.lblFooterCellNotes.Size = New System.Drawing.Size(91, 13)
        Me.lblFooterCellNotes.TabIndex = 4
        Me.lblFooterCellNotes.Text = "Cell footers notes:"
        '
        'tbpSourceNotes
        '
        Me.tbpSourceNotes.Controls.Add(Me.UcrSourceNotes1)
        Me.tbpSourceNotes.Location = New System.Drawing.Point(4, 22)
        Me.tbpSourceNotes.Name = "tbpSourceNotes"
        Me.tbpSourceNotes.Size = New System.Drawing.Size(642, 233)
        Me.tbpSourceNotes.TabIndex = 4
        Me.tbpSourceNotes.Text = "Source Notes"
        Me.tbpSourceNotes.UseVisualStyleBackColor = True
        '
        'UcrSourceNotes1
        '
        Me.UcrSourceNotes1.Location = New System.Drawing.Point(7, 7)
        Me.UcrSourceNotes1.Name = "UcrSourceNotes1"
        Me.UcrSourceNotes1.Size = New System.Drawing.Size(581, 190)
        Me.UcrSourceNotes1.TabIndex = 0
        '
        'tbpThemes
        '
        Me.tbpThemes.Controls.Add(Me.ucrCboSelectThemes)
        Me.tbpThemes.Controls.Add(Me.btnManualTheme)
        Me.tbpThemes.Controls.Add(Me.rdoSelectTheme)
        Me.tbpThemes.Controls.Add(Me.rdoManualTheme)
        Me.tbpThemes.Controls.Add(Me.ucrPnlThemesPanel)
        Me.tbpThemes.Location = New System.Drawing.Point(4, 22)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(642, 233)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
        '
        'ucrCboSelectThemes
        '
        Me.ucrCboSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrCboSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSelectThemes.GetSetSelectedIndex = -1
        Me.ucrCboSelectThemes.IsReadOnly = False
        Me.ucrCboSelectThemes.Location = New System.Drawing.Point(157, 29)
        Me.ucrCboSelectThemes.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboSelectThemes.Name = "ucrCboSelectThemes"
        Me.ucrCboSelectThemes.Size = New System.Drawing.Size(168, 21)
        Me.ucrCboSelectThemes.TabIndex = 3
        '
        'btnManualTheme
        '
        Me.btnManualTheme.Location = New System.Drawing.Point(157, 59)
        Me.btnManualTheme.Name = "btnManualTheme"
        Me.btnManualTheme.Size = New System.Drawing.Size(168, 21)
        Me.btnManualTheme.TabIndex = 2
        Me.btnManualTheme.Text = "Custom Theme"
        Me.btnManualTheme.UseVisualStyleBackColor = True
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
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(195, 273)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 4
        '
        'sdgTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 309)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgTableOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table Options"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpHeader.PerformLayout()
        CType(Me.dataGridHeaderFooterNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpFooters.ResumeLayout(False)
        Me.tbpFooters.PerformLayout()
        CType(Me.dataGridCellFooterNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpSourceNotes.ResumeLayout(False)
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
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents ucrCboSelectThemes As ucrInputComboBox
    Friend WithEvents btnManualTheme As Button
    Friend WithEvents rdoSelectTheme As RadioButton
    Friend WithEvents rdoManualTheme As RadioButton
    Friend WithEvents ucrPnlThemesPanel As UcrPanel
    Friend WithEvents lblFooterCellNotes As Label
    Friend WithEvents dataGridCellFooterNotes As DataGridView
    Friend WithEvents colFooterNoteText As DataGridViewTextBoxColumn
    Friend WithEvents colFooterColExpression As DataGridViewTextBoxColumn
    Friend WithEvents colFooterRowExpression As DataGridViewTextBoxColumn
    Friend WithEvents colFooterFormat As DataGridViewButtonColumn
    Friend WithEvents dataGridHeaderFooterNotes As DataGridView
    Friend WithEvents lblHeaderFooterNotes As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents UcrSourceNotes1 As ucrSourceNotes
End Class
