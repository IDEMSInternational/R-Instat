<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgTableOptions
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
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.tbpOtherStyles = New System.Windows.Forms.TabPage()
        Me.ucrOtherStyles = New instat.ucrOtherStyles()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.ucrChkSelectTheme = New instat.ucrCheck()
        Me.ucrChkManualTheme = New instat.ucrCheck()
        Me.ucrCboSelectThemes = New instat.ucrInputComboBox()
        Me.btnManualTheme = New System.Windows.Forms.Button()
        Me.tbpSourceNotes = New System.Windows.Forms.TabPage()
        Me.ucrSourceNotes = New instat.ucrSourceNotes()
        Me.tbpCells = New System.Windows.Forms.TabPage()
        Me.ucrCells = New instat.ucrCells()
        Me.tbpRows = New System.Windows.Forms.TabPage()
        Me.ucrRows = New instat.ucrRows()
        Me.tbpColumns = New System.Windows.Forms.TabPage()
        Me.ucrColumns = New instat.ucrColumns()
        Me.tbpStub = New System.Windows.Forms.TabPage()
        Me.ucrStub = New instat.ucrStub()
        Me.tbpHeader = New System.Windows.Forms.TabPage()
        Me.ucrHeader = New instat.ucrHeader()
        Me.tbTableOptions = New System.Windows.Forms.TabControl()
        Me.tbpTable = New System.Windows.Forms.TabPage()
        Me.ucrTableOptions = New instat.ucrTableOptions()
        Me.tbpOtherStyles.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        Me.tbpSourceNotes.SuspendLayout()
        Me.tbpCells.SuspendLayout()
        Me.tbpRows.SuspendLayout()
        Me.tbpColumns.SuspendLayout()
        Me.tbpStub.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.tbTableOptions.SuspendLayout()
        Me.tbpTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(402, 715)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(336, 46)
        Me.ucrSdgBaseButtons.TabIndex = 343
        '
        'tbpOtherStyles
        '
        Me.tbpOtherStyles.Controls.Add(Me.ucrOtherStyles)
        Me.tbpOtherStyles.Location = New System.Drawing.Point(4, 29)
        Me.tbpOtherStyles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpOtherStyles.Name = "tbpOtherStyles"
        Me.tbpOtherStyles.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpOtherStyles.Size = New System.Drawing.Size(1152, 670)
        Me.tbpOtherStyles.TabIndex = 10
        Me.tbpOtherStyles.Text = "Other Styles"
        Me.tbpOtherStyles.UseVisualStyleBackColor = True
        '
        'ucrOtherStyles
        '
        Me.ucrOtherStyles.Location = New System.Drawing.Point(12, 11)
        Me.ucrOtherStyles.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrOtherStyles.Name = "ucrOtherStyles"
        Me.ucrOtherStyles.Size = New System.Drawing.Size(489, 275)
        Me.ucrOtherStyles.TabIndex = 0
        '
        'tbpThemes
        '
        Me.tbpThemes.Controls.Add(Me.ucrChkSelectTheme)
        Me.tbpThemes.Controls.Add(Me.ucrChkManualTheme)
        Me.tbpThemes.Controls.Add(Me.ucrCboSelectThemes)
        Me.tbpThemes.Controls.Add(Me.btnManualTheme)
        Me.tbpThemes.Location = New System.Drawing.Point(4, 29)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(1152, 670)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
        '
        'ucrChkSelectTheme
        '
        Me.ucrChkSelectTheme.AutoSize = True
        Me.ucrChkSelectTheme.Checked = False
        Me.ucrChkSelectTheme.Location = New System.Drawing.Point(26, 29)
        Me.ucrChkSelectTheme.Name = "ucrChkSelectTheme"
        Me.ucrChkSelectTheme.Size = New System.Drawing.Size(182, 52)
        Me.ucrChkSelectTheme.TabIndex = 29
        '
        'ucrChkManualTheme
        '
        Me.ucrChkManualTheme.AutoSize = True
        Me.ucrChkManualTheme.Checked = False
        Me.ucrChkManualTheme.Location = New System.Drawing.Point(26, 91)
        Me.ucrChkManualTheme.Name = "ucrChkManualTheme"
        Me.ucrChkManualTheme.Size = New System.Drawing.Size(182, 52)
        Me.ucrChkManualTheme.TabIndex = 28
        '
        'ucrCboSelectThemes
        '
        Me.ucrCboSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrCboSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSelectThemes.GetSetSelectedIndex = -1
        Me.ucrCboSelectThemes.IsReadOnly = False
        Me.ucrCboSelectThemes.Location = New System.Drawing.Point(230, 29)
        Me.ucrCboSelectThemes.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrCboSelectThemes.Name = "ucrCboSelectThemes"
        Me.ucrCboSelectThemes.Size = New System.Drawing.Size(225, 32)
        Me.ucrCboSelectThemes.TabIndex = 3
        '
        'btnManualTheme
        '
        Me.btnManualTheme.Location = New System.Drawing.Point(231, 92)
        Me.btnManualTheme.Name = "btnManualTheme"
        Me.btnManualTheme.Size = New System.Drawing.Size(224, 32)
        Me.btnManualTheme.TabIndex = 2
        Me.btnManualTheme.Text = "Custom Theme"
        Me.btnManualTheme.UseVisualStyleBackColor = True
        '
        'tbpSourceNotes
        '
        Me.tbpSourceNotes.Controls.Add(Me.ucrSourceNotes)
        Me.tbpSourceNotes.Location = New System.Drawing.Point(4, 29)
        Me.tbpSourceNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpSourceNotes.Name = "tbpSourceNotes"
        Me.tbpSourceNotes.Size = New System.Drawing.Size(1152, 670)
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
        'tbpCells
        '
        Me.tbpCells.Controls.Add(Me.ucrCells)
        Me.tbpCells.Location = New System.Drawing.Point(4, 29)
        Me.tbpCells.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpCells.Name = "tbpCells"
        Me.tbpCells.Size = New System.Drawing.Size(1152, 670)
        Me.tbpCells.TabIndex = 3
        Me.tbpCells.Text = "Cells"
        Me.tbpCells.UseVisualStyleBackColor = True
        '
        'ucrCells
        '
        Me.ucrCells.Location = New System.Drawing.Point(12, 12)
        Me.ucrCells.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrCells.Name = "ucrCells"
        Me.ucrCells.Size = New System.Drawing.Size(966, 554)
        Me.ucrCells.TabIndex = 6
        '
        'tbpRows
        '
        Me.tbpRows.Controls.Add(Me.ucrRows)
        Me.tbpRows.Location = New System.Drawing.Point(4, 29)
        Me.tbpRows.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpRows.Name = "tbpRows"
        Me.tbpRows.Size = New System.Drawing.Size(1152, 670)
        Me.tbpRows.TabIndex = 7
        Me.tbpRows.Text = "Rows"
        Me.tbpRows.UseVisualStyleBackColor = True
        '
        'ucrRows
        '
        Me.ucrRows.Location = New System.Drawing.Point(10, 14)
        Me.ucrRows.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrRows.Name = "ucrRows"
        Me.ucrRows.Size = New System.Drawing.Size(1132, 648)
        Me.ucrRows.TabIndex = 0
        '
        'tbpColumns
        '
        Me.tbpColumns.Controls.Add(Me.ucrColumns)
        Me.tbpColumns.Location = New System.Drawing.Point(4, 29)
        Me.tbpColumns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpColumns.Name = "tbpColumns"
        Me.tbpColumns.Size = New System.Drawing.Size(1152, 670)
        Me.tbpColumns.TabIndex = 8
        Me.tbpColumns.Text = "Columns"
        Me.tbpColumns.UseVisualStyleBackColor = True
        '
        'ucrColumns
        '
        Me.ucrColumns.Location = New System.Drawing.Point(8, 9)
        Me.ucrColumns.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrColumns.Name = "ucrColumns"
        Me.ucrColumns.Size = New System.Drawing.Size(1131, 652)
        Me.ucrColumns.TabIndex = 0
        '
        'tbpStub
        '
        Me.tbpStub.Controls.Add(Me.ucrStub)
        Me.tbpStub.Location = New System.Drawing.Point(4, 29)
        Me.tbpStub.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpStub.Name = "tbpStub"
        Me.tbpStub.Size = New System.Drawing.Size(1152, 670)
        Me.tbpStub.TabIndex = 9
        Me.tbpStub.Text = "Stub"
        Me.tbpStub.UseVisualStyleBackColor = True
        '
        'ucrStub
        '
        Me.ucrStub.Location = New System.Drawing.Point(10, 11)
        Me.ucrStub.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrStub.Name = "ucrStub"
        Me.ucrStub.Size = New System.Drawing.Size(638, 397)
        Me.ucrStub.TabIndex = 0
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.ucrHeader)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 29)
        Me.tbpHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpHeader.Size = New System.Drawing.Size(1152, 670)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Titles"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'ucrHeader
        '
        Me.ucrHeader.Location = New System.Drawing.Point(10, 9)
        Me.ucrHeader.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrHeader.Name = "ucrHeader"
        Me.ucrHeader.Size = New System.Drawing.Size(902, 462)
        Me.ucrHeader.TabIndex = 16
        '
        'tbTableOptions
        '
        Me.tbTableOptions.Controls.Add(Me.tbpHeader)
        Me.tbTableOptions.Controls.Add(Me.tbpStub)
        Me.tbTableOptions.Controls.Add(Me.tbpColumns)
        Me.tbTableOptions.Controls.Add(Me.tbpRows)
        Me.tbTableOptions.Controls.Add(Me.tbpCells)
        Me.tbTableOptions.Controls.Add(Me.tbpSourceNotes)
        Me.tbTableOptions.Controls.Add(Me.tbpThemes)
        Me.tbTableOptions.Controls.Add(Me.tbpOtherStyles)
        Me.tbTableOptions.Controls.Add(Me.tbpTable)
        Me.tbTableOptions.Location = New System.Drawing.Point(4, 8)
        Me.tbTableOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTableOptions.Name = "tbTableOptions"
        Me.tbTableOptions.SelectedIndex = 0
        Me.tbTableOptions.Size = New System.Drawing.Size(1160, 703)
        Me.tbTableOptions.TabIndex = 5
        '
        'tbpTable
        '
        Me.tbpTable.Controls.Add(Me.ucrTableOptions)
        Me.tbpTable.Location = New System.Drawing.Point(4, 29)
        Me.tbpTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpTable.Name = "tbpTable"
        Me.tbpTable.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpTable.Size = New System.Drawing.Size(1152, 670)
        Me.tbpTable.TabIndex = 11
        Me.tbpTable.Text = "Table"
        Me.tbpTable.UseVisualStyleBackColor = True
        '
        'ucrTableOptions
        '
        Me.ucrTableOptions.Location = New System.Drawing.Point(9, 9)
        Me.ucrTableOptions.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrTableOptions.Name = "ucrTableOptions"
        Me.ucrTableOptions.Size = New System.Drawing.Size(796, 474)
        Me.ucrTableOptions.TabIndex = 0
        '
        'sdgTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 769)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.tbTableOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "sdgTableOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table Options"
        Me.tbpOtherStyles.ResumeLayout(False)
        Me.tbpThemes.ResumeLayout(False)
        Me.tbpThemes.PerformLayout()
        Me.tbpSourceNotes.ResumeLayout(False)
        Me.tbpCells.ResumeLayout(False)
        Me.tbpRows.ResumeLayout(False)
        Me.tbpColumns.ResumeLayout(False)
        Me.tbpStub.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbTableOptions.ResumeLayout(False)
        Me.tbpTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
    Friend WithEvents tbpOtherStyles As TabPage
    Friend WithEvents ucrOtherStyles As ucrOtherStyles
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents ucrChkSelectTheme As ucrCheck
    Friend WithEvents ucrChkManualTheme As ucrCheck
    Friend WithEvents ucrCboSelectThemes As ucrInputComboBox
    Friend WithEvents btnManualTheme As Button
    Friend WithEvents tbpSourceNotes As TabPage
    Friend WithEvents ucrSourceNotes As ucrSourceNotes
    Friend WithEvents tbpCells As TabPage
    Friend WithEvents ucrCells As ucrCells
    Friend WithEvents tbpRows As TabPage
    Friend WithEvents ucrRows As ucrRows
    Friend WithEvents tbpColumns As TabPage
    Friend WithEvents ucrColumns As ucrColumns
    Friend WithEvents tbpStub As TabPage
    Friend WithEvents ucrStub As ucrStub
    Friend WithEvents tbpHeader As TabPage
    Friend WithEvents ucrHeader As ucrHeader
    Friend WithEvents tbTableOptions As TabControl
    Friend WithEvents tbpTable As TabPage
    Friend WithEvents ucrTableOptions As ucrTableOptions
End Class
