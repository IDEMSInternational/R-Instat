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
        Me.ucrHeaderOptions = New instat.ucrHeader()
        Me.tbpRowGroups = New System.Windows.Forms.TabPage()
        Me.UcrRowGroup1 = New instat.ucrRowGroup()
        Me.tbpFooters = New System.Windows.Forms.TabPage()
        Me.dataGridCellFooterNotes = New System.Windows.Forms.DataGridView()
        Me.colFooterNoteText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFooterColExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFooterRowExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFooterFormat = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblFooterCellNotes = New System.Windows.Forms.Label()
        Me.tbpSourceNotes = New System.Windows.Forms.TabPage()
        Me.ucrSourceNotes = New instat.ucrSourceNotes()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.ucrCboSelectThemes = New instat.ucrInputComboBox()
        Me.btnManualTheme = New System.Windows.Forms.Button()
        Me.rdoSelectTheme = New System.Windows.Forms.RadioButton()
        Me.rdoManualTheme = New System.Windows.Forms.RadioButton()
        Me.ucrPnlThemesPanel = New instat.UcrPanel()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.tbpRowGroups.SuspendLayout()
        Me.tbpFooters.SuspendLayout()
        CType(Me.dataGridCellFooterNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpSourceNotes.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpHeader)
        Me.tbpFormatOptions.Controls.Add(Me.tbpRowGroups)
        Me.tbpFormatOptions.Controls.Add(Me.tbpFooters)
        Me.tbpFormatOptions.Controls.Add(Me.tbpSourceNotes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(4, 8)
        Me.tbpFormatOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(975, 398)
        Me.tbpFormatOptions.TabIndex = 5
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.ucrHeaderOptions)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 29)
        Me.tbpHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpHeader.Size = New System.Drawing.Size(967, 365)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Headers Notes"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'ucrHeaderOptions
        '
        Me.ucrHeaderOptions.Location = New System.Drawing.Point(11, 10)
        Me.ucrHeaderOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrHeaderOptions.Name = "ucrHeaderOptions"
        Me.ucrHeaderOptions.Size = New System.Drawing.Size(454, 176)
        Me.ucrHeaderOptions.TabIndex = 16
        '
        'tbpRowGroups
        '
        Me.tbpRowGroups.Controls.Add(Me.UcrRowGroup1)
        Me.tbpRowGroups.Location = New System.Drawing.Point(4, 29)
        Me.tbpRowGroups.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpRowGroups.Name = "tbpRowGroups"
        Me.tbpRowGroups.Size = New System.Drawing.Size(967, 365)
        Me.tbpRowGroups.TabIndex = 7
        Me.tbpRowGroups.Text = "Row Groups"
        Me.tbpRowGroups.UseVisualStyleBackColor = True
        '
        'UcrRowGroup1
        '
        Me.UcrRowGroup1.Location = New System.Drawing.Point(12, 6)
        Me.UcrRowGroup1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrRowGroup1.Name = "UcrRowGroup1"
        Me.UcrRowGroup1.Size = New System.Drawing.Size(874, 346)
        Me.UcrRowGroup1.TabIndex = 0
        '
        'tbpFooters
        '
        Me.tbpFooters.Controls.Add(Me.dataGridCellFooterNotes)
        Me.tbpFooters.Controls.Add(Me.lblFooterCellNotes)
        Me.tbpFooters.Location = New System.Drawing.Point(4, 29)
        Me.tbpFooters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpFooters.Name = "tbpFooters"
        Me.tbpFooters.Size = New System.Drawing.Size(967, 365)
        Me.tbpFooters.TabIndex = 3
        Me.tbpFooters.Text = "Cells"
        Me.tbpFooters.UseVisualStyleBackColor = True
        '
        'dataGridCellFooterNotes
        '
        Me.dataGridCellFooterNotes.AllowUserToAddRows = False
        Me.dataGridCellFooterNotes.AllowUserToDeleteRows = False
        Me.dataGridCellFooterNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridCellFooterNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFooterNoteText, Me.colFooterColExpression, Me.colFooterRowExpression, Me.colFooterFormat})
        Me.dataGridCellFooterNotes.Location = New System.Drawing.Point(10, 48)
        Me.dataGridCellFooterNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataGridCellFooterNotes.Name = "dataGridCellFooterNotes"
        Me.dataGridCellFooterNotes.RowHeadersWidth = 62
        Me.dataGridCellFooterNotes.Size = New System.Drawing.Size(945, 129)
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
        Me.colFooterFormat.MinimumWidth = 8
        Me.colFooterFormat.Name = "colFooterFormat"
        Me.colFooterFormat.ReadOnly = True
        Me.colFooterFormat.Text = "Format"
        Me.colFooterFormat.UseColumnTextForButtonValue = True
        Me.colFooterFormat.Width = 60
        '
        'lblFooterCellNotes
        '
        Me.lblFooterCellNotes.AutoSize = True
        Me.lblFooterCellNotes.Location = New System.Drawing.Point(15, 20)
        Me.lblFooterCellNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFooterCellNotes.Name = "lblFooterCellNotes"
        Me.lblFooterCellNotes.Size = New System.Drawing.Size(137, 20)
        Me.lblFooterCellNotes.TabIndex = 4
        Me.lblFooterCellNotes.Text = "Cell footers notes:"
        '
        'tbpSourceNotes
        '
        Me.tbpSourceNotes.Controls.Add(Me.ucrSourceNotes)
        Me.tbpSourceNotes.Location = New System.Drawing.Point(4, 29)
        Me.tbpSourceNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpSourceNotes.Name = "tbpSourceNotes"
        Me.tbpSourceNotes.Size = New System.Drawing.Size(967, 365)
        Me.tbpSourceNotes.TabIndex = 4
        Me.tbpSourceNotes.Text = "Source Notes"
        Me.tbpSourceNotes.UseVisualStyleBackColor = True
        '
        'ucrSourceNotes
        '
        Me.ucrSourceNotes.Location = New System.Drawing.Point(10, 11)
        Me.ucrSourceNotes.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSourceNotes.Name = "ucrSourceNotes"
        Me.ucrSourceNotes.Size = New System.Drawing.Size(872, 292)
        Me.ucrSourceNotes.TabIndex = 0
        '
        'tbpThemes
        '
        Me.tbpThemes.Controls.Add(Me.ucrCboSelectThemes)
        Me.tbpThemes.Controls.Add(Me.btnManualTheme)
        Me.tbpThemes.Controls.Add(Me.rdoSelectTheme)
        Me.tbpThemes.Controls.Add(Me.rdoManualTheme)
        Me.tbpThemes.Controls.Add(Me.ucrPnlThemesPanel)
        Me.tbpThemes.Location = New System.Drawing.Point(4, 29)
        Me.tbpThemes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(967, 365)
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
        Me.ucrCboSelectThemes.Location = New System.Drawing.Point(236, 45)
        Me.ucrCboSelectThemes.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrCboSelectThemes.Name = "ucrCboSelectThemes"
        Me.ucrCboSelectThemes.Size = New System.Drawing.Size(252, 32)
        Me.ucrCboSelectThemes.TabIndex = 3
        '
        'btnManualTheme
        '
        Me.btnManualTheme.Location = New System.Drawing.Point(236, 91)
        Me.btnManualTheme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnManualTheme.Name = "btnManualTheme"
        Me.btnManualTheme.Size = New System.Drawing.Size(252, 32)
        Me.btnManualTheme.TabIndex = 2
        Me.btnManualTheme.Text = "Custom Theme"
        Me.btnManualTheme.UseVisualStyleBackColor = True
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
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(292, 420)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(336, 45)
        Me.ucrBaseSubdialog.TabIndex = 4
        '
        'sdgTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 475)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "sdgTableOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table Options"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpRowGroups.ResumeLayout(False)
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
    Friend WithEvents ucrSourceNotes As ucrSourceNotes
    Friend WithEvents tbpRowGroups As TabPage
    Friend WithEvents UcrRowGroup1 As ucrRowGroup
    Friend WithEvents ucrHeaderOptions As ucrHeader
End Class
