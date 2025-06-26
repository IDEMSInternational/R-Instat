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
        Me.tbpFormatOptions = New System.Windows.Forms.TabControl()
        Me.tbpHeader = New System.Windows.Forms.TabPage()
        Me.ucrHeader = New instat.ucrHeader()
        Me.tbpStub = New System.Windows.Forms.TabPage()
        Me.ucrStub = New instat.ucrStub()
        Me.tbpColumns = New System.Windows.Forms.TabPage()
        Me.ucrColumns = New instat.ucrColumns()
        Me.tbpRows = New System.Windows.Forms.TabPage()
        Me.ucrRows = New instat.ucrRows()
        Me.tbpCells = New System.Windows.Forms.TabPage()
        Me.ucrCells = New instat.ucrCells()
        Me.tbpSourceNotes = New System.Windows.Forms.TabPage()
        Me.ucrSourceNotes = New instat.ucrSourceNotes()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.ucrChkSelectTheme = New instat.ucrCheck()
        Me.ucrChkManualTheme = New instat.ucrCheck()
        Me.ucrCboSelectThemes = New instat.ucrInputComboBox()
        Me.btnManualTheme = New System.Windows.Forms.Button()
        Me.tbpOtherStyles = New System.Windows.Forms.TabPage()
        Me.ucrOtherStyles = New instat.ucrOtherStyles()
        Me.tbpTables = New System.Windows.Forms.TabPage()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.ucrTxtMissingText = New instat.ucrInputComboBox()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.rdoDate = New System.Windows.Forms.RadioButton()
        Me.rdoNumber = New System.Windows.Forms.RadioButton()
        Me.btnTextFormat = New System.Windows.Forms.Button()
        Me.btnDateFormat = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.lblMissingText = New System.Windows.Forms.Label()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.ucrChkDataFormat = New instat.ucrCheck()
        Me.ucrPnlFormat = New instat.UcrPanel()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.tbpStub.SuspendLayout()
        Me.tbpColumns.SuspendLayout()
        Me.tbpRows.SuspendLayout()
        Me.tbpCells.SuspendLayout()
        Me.tbpSourceNotes.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        Me.tbpOtherStyles.SuspendLayout()
        Me.tbpTables.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpHeader)
        Me.tbpFormatOptions.Controls.Add(Me.tbpStub)
        Me.tbpFormatOptions.Controls.Add(Me.tbpColumns)
        Me.tbpFormatOptions.Controls.Add(Me.tbpRows)
        Me.tbpFormatOptions.Controls.Add(Me.tbpCells)
        Me.tbpFormatOptions.Controls.Add(Me.tbpSourceNotes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpOtherStyles)
        Me.tbpFormatOptions.Controls.Add(Me.tbpTables)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(3, 5)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(773, 457)
        Me.tbpFormatOptions.TabIndex = 5
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.ucrHeader)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 22)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHeader.Size = New System.Drawing.Size(765, 431)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Header"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'ucrHeader
        '
        Me.ucrHeader.Location = New System.Drawing.Point(7, 6)
        Me.ucrHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrHeader.Name = "ucrHeader"
        Me.ucrHeader.Size = New System.Drawing.Size(601, 300)
        Me.ucrHeader.TabIndex = 16
        '
        'tbpStub
        '
        Me.tbpStub.Controls.Add(Me.ucrStub)
        Me.tbpStub.Location = New System.Drawing.Point(4, 22)
        Me.tbpStub.Name = "tbpStub"
        Me.tbpStub.Size = New System.Drawing.Size(765, 431)
        Me.tbpStub.TabIndex = 9
        Me.tbpStub.Text = "Stub"
        Me.tbpStub.UseVisualStyleBackColor = True
        '
        'ucrStub
        '
        Me.ucrStub.Location = New System.Drawing.Point(7, 7)
        Me.ucrStub.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrStub.Name = "ucrStub"
        Me.ucrStub.Size = New System.Drawing.Size(425, 258)
        Me.ucrStub.TabIndex = 0
        '
        'tbpColumns
        '
        Me.tbpColumns.Controls.Add(Me.ucrColumns)
        Me.tbpColumns.Location = New System.Drawing.Point(4, 22)
        Me.tbpColumns.Name = "tbpColumns"
        Me.tbpColumns.Size = New System.Drawing.Size(765, 431)
        Me.tbpColumns.TabIndex = 8
        Me.tbpColumns.Text = "Columns"
        Me.tbpColumns.UseVisualStyleBackColor = True
        '
        'ucrColumns
        '
        Me.ucrColumns.Location = New System.Drawing.Point(5, 6)
        Me.ucrColumns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrColumns.Name = "ucrColumns"
        Me.ucrColumns.Size = New System.Drawing.Size(754, 424)
        Me.ucrColumns.TabIndex = 0
        '
        'tbpRows
        '
        Me.tbpRows.Controls.Add(Me.ucrRows)
        Me.tbpRows.Location = New System.Drawing.Point(4, 22)
        Me.tbpRows.Name = "tbpRows"
        Me.tbpRows.Size = New System.Drawing.Size(765, 431)
        Me.tbpRows.TabIndex = 7
        Me.tbpRows.Text = "Rows"
        Me.tbpRows.UseVisualStyleBackColor = True
        '
        'ucrRows
        '
        Me.ucrRows.Location = New System.Drawing.Point(7, 9)
        Me.ucrRows.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrRows.Name = "ucrRows"
        Me.ucrRows.Size = New System.Drawing.Size(755, 421)
        Me.ucrRows.TabIndex = 0
        '
        'tbpCells
        '
        Me.tbpCells.Controls.Add(Me.ucrCells)
        Me.tbpCells.Location = New System.Drawing.Point(4, 22)
        Me.tbpCells.Name = "tbpCells"
        Me.tbpCells.Size = New System.Drawing.Size(765, 431)
        Me.tbpCells.TabIndex = 3
        Me.tbpCells.Text = "Cells"
        Me.tbpCells.UseVisualStyleBackColor = True
        '
        'ucrCells
        '
        Me.ucrCells.Location = New System.Drawing.Point(8, 8)
        Me.ucrCells.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrCells.Name = "ucrCells"
        Me.ucrCells.Size = New System.Drawing.Size(644, 360)
        Me.ucrCells.TabIndex = 6
        '
        'tbpSourceNotes
        '
        Me.tbpSourceNotes.Controls.Add(Me.ucrSourceNotes)
        Me.tbpSourceNotes.Location = New System.Drawing.Point(4, 22)
        Me.tbpSourceNotes.Name = "tbpSourceNotes"
        Me.tbpSourceNotes.Size = New System.Drawing.Size(765, 431)
        Me.tbpSourceNotes.TabIndex = 4
        Me.tbpSourceNotes.Text = "Source Notes"
        Me.tbpSourceNotes.UseVisualStyleBackColor = True
        '
        'ucrSourceNotes
        '
        Me.ucrSourceNotes.Location = New System.Drawing.Point(7, 7)
        Me.ucrSourceNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSourceNotes.Name = "ucrSourceNotes"
        Me.ucrSourceNotes.Size = New System.Drawing.Size(581, 190)
        Me.ucrSourceNotes.TabIndex = 0
        '
        'tbpThemes
        '
        Me.tbpThemes.Controls.Add(Me.ucrChkSelectTheme)
        Me.tbpThemes.Controls.Add(Me.ucrChkManualTheme)
        Me.tbpThemes.Controls.Add(Me.ucrCboSelectThemes)
        Me.tbpThemes.Controls.Add(Me.btnManualTheme)
        Me.tbpThemes.Location = New System.Drawing.Point(4, 22)
        Me.tbpThemes.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(765, 431)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
        '
        'ucrChkSelectTheme
        '
        Me.ucrChkSelectTheme.AutoSize = True
        Me.ucrChkSelectTheme.Checked = False
        Me.ucrChkSelectTheme.Location = New System.Drawing.Point(17, 19)
        Me.ucrChkSelectTheme.Margin = New System.Windows.Forms.Padding(2)
        Me.ucrChkSelectTheme.Name = "ucrChkSelectTheme"
        Me.ucrChkSelectTheme.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkSelectTheme.TabIndex = 29
        '
        'ucrChkManualTheme
        '
        Me.ucrChkManualTheme.AutoSize = True
        Me.ucrChkManualTheme.Checked = False
        Me.ucrChkManualTheme.Location = New System.Drawing.Point(17, 59)
        Me.ucrChkManualTheme.Margin = New System.Windows.Forms.Padding(2)
        Me.ucrChkManualTheme.Name = "ucrChkManualTheme"
        Me.ucrChkManualTheme.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkManualTheme.TabIndex = 28
        '
        'ucrCboSelectThemes
        '
        Me.ucrCboSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrCboSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSelectThemes.GetSetSelectedIndex = -1
        Me.ucrCboSelectThemes.IsReadOnly = False
        Me.ucrCboSelectThemes.Location = New System.Drawing.Point(153, 19)
        Me.ucrCboSelectThemes.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrCboSelectThemes.Name = "ucrCboSelectThemes"
        Me.ucrCboSelectThemes.Size = New System.Drawing.Size(150, 21)
        Me.ucrCboSelectThemes.TabIndex = 3
        '
        'btnManualTheme
        '
        Me.btnManualTheme.Location = New System.Drawing.Point(154, 60)
        Me.btnManualTheme.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManualTheme.Name = "btnManualTheme"
        Me.btnManualTheme.Size = New System.Drawing.Size(149, 21)
        Me.btnManualTheme.TabIndex = 2
        Me.btnManualTheme.Text = "Custom Theme"
        Me.btnManualTheme.UseVisualStyleBackColor = True
        '
        'tbpOtherStyles
        '
        Me.tbpOtherStyles.Controls.Add(Me.ucrOtherStyles)
        Me.tbpOtherStyles.Location = New System.Drawing.Point(4, 22)
        Me.tbpOtherStyles.Name = "tbpOtherStyles"
        Me.tbpOtherStyles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOtherStyles.Size = New System.Drawing.Size(765, 431)
        Me.tbpOtherStyles.TabIndex = 10
        Me.tbpOtherStyles.Text = "Other Styles"
        Me.tbpOtherStyles.UseVisualStyleBackColor = True
        '
        'ucrOtherStyles
        '
        Me.ucrOtherStyles.Location = New System.Drawing.Point(8, 7)
        Me.ucrOtherStyles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrOtherStyles.Name = "ucrOtherStyles"
        Me.ucrOtherStyles.Size = New System.Drawing.Size(326, 179)
        Me.ucrOtherStyles.TabIndex = 0
        '
        'tbpTables
        '
        Me.tbpTables.Controls.Add(Me.rdoText)
        Me.tbpTables.Controls.Add(Me.rdoDate)
        Me.tbpTables.Controls.Add(Me.rdoNumber)
        Me.tbpTables.Controls.Add(Me.btnTextFormat)
        Me.tbpTables.Controls.Add(Me.btnDateFormat)
        Me.tbpTables.Controls.Add(Me.btnNumberFormat)
        Me.tbpTables.Controls.Add(Me.grpMissingValues)
        Me.tbpTables.Controls.Add(Me.ucrChkMissingValues)
        Me.tbpTables.Controls.Add(Me.ucrChkDataFormat)
        Me.tbpTables.Controls.Add(Me.ucrPnlFormat)
        Me.tbpTables.Location = New System.Drawing.Point(4, 22)
        Me.tbpTables.Name = "tbpTables"
        Me.tbpTables.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTables.Size = New System.Drawing.Size(765, 431)
        Me.tbpTables.TabIndex = 11
        Me.tbpTables.Text = "Table"
        Me.tbpTables.UseVisualStyleBackColor = True
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(268, 465)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 343
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
        'rdoText
        '
        Me.rdoText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoText.Location = New System.Drawing.Point(198, 112)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(89, 17)
        Me.rdoText.TabIndex = 391
        Me.rdoText.TabStop = True
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoDate
        '
        Me.rdoDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDate.Location = New System.Drawing.Point(198, 77)
        Me.rdoDate.Name = "rdoDate"
        Me.rdoDate.Size = New System.Drawing.Size(89, 17)
        Me.rdoDate.TabIndex = 390
        Me.rdoDate.TabStop = True
        Me.rdoDate.Text = "Date"
        Me.rdoDate.UseVisualStyleBackColor = True
        '
        'rdoNumber
        '
        Me.rdoNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNumber.Location = New System.Drawing.Point(198, 43)
        Me.rdoNumber.Name = "rdoNumber"
        Me.rdoNumber.Size = New System.Drawing.Size(89, 16)
        Me.rdoNumber.TabIndex = 389
        Me.rdoNumber.TabStop = True
        Me.rdoNumber.Text = "Number"
        Me.rdoNumber.UseVisualStyleBackColor = True
        '
        'btnTextFormat
        '
        Me.btnTextFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnTextFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTextFormat.Location = New System.Drawing.Point(290, 106)
        Me.btnTextFormat.Name = "btnTextFormat"
        Me.btnTextFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnTextFormat.TabIndex = 392
        Me.btnTextFormat.Tag = ""
        Me.btnTextFormat.Text = "Text Format"
        Me.btnTextFormat.UseVisualStyleBackColor = True
        '
        'btnDateFormat
        '
        Me.btnDateFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnDateFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDateFormat.Location = New System.Drawing.Point(290, 71)
        Me.btnDateFormat.Name = "btnDateFormat"
        Me.btnDateFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnDateFormat.TabIndex = 393
        Me.btnDateFormat.Tag = ""
        Me.btnDateFormat.Text = "Date Format"
        Me.btnDateFormat.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnNumberFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNumberFormat.Location = New System.Drawing.Point(290, 40)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnNumberFormat.TabIndex = 394
        Me.btnNumberFormat.Tag = ""
        Me.btnNumberFormat.Text = "Number Format"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.lblMissingText)
        Me.grpMissingValues.Controls.Add(Me.ucrTxtMissingText)
        Me.grpMissingValues.Location = New System.Drawing.Point(198, 170)
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.Size = New System.Drawing.Size(167, 88)
        Me.grpMissingValues.TabIndex = 397
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Text = "Missing Values"
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
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.AutoSize = True
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(66, 170)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkMissingValues.TabIndex = 396
        '
        'ucrChkDataFormat
        '
        Me.ucrChkDataFormat.AutoSize = True
        Me.ucrChkDataFormat.Checked = False
        Me.ucrChkDataFormat.Location = New System.Drawing.Point(66, 42)
        Me.ucrChkDataFormat.Name = "ucrChkDataFormat"
        Me.ucrChkDataFormat.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkDataFormat.TabIndex = 395
        '
        'ucrPnlFormat
        '
        Me.ucrPnlFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFormat.Location = New System.Drawing.Point(194, 40)
        Me.ucrPnlFormat.Name = "ucrPnlFormat"
        Me.ucrPnlFormat.Size = New System.Drawing.Size(224, 88)
        Me.ucrPnlFormat.TabIndex = 388
        '
        'sdgTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 500)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgTableOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table Options"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpStub.ResumeLayout(False)
        Me.tbpColumns.ResumeLayout(False)
        Me.tbpRows.ResumeLayout(False)
        Me.tbpCells.ResumeLayout(False)
        Me.tbpSourceNotes.ResumeLayout(False)
        Me.tbpThemes.ResumeLayout(False)
        Me.tbpThemes.PerformLayout()
        Me.tbpOtherStyles.ResumeLayout(False)
        Me.tbpTables.ResumeLayout(False)
        Me.tbpTables.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpMissingValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbpFormatOptions As TabControl
    Friend WithEvents tbpHeader As TabPage
    Friend WithEvents tbpCells As TabPage
    Friend WithEvents tbpSourceNotes As TabPage
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents ucrCboSelectThemes As ucrInputComboBox
    Friend WithEvents btnManualTheme As Button
    Friend WithEvents ucrSourceNotes As ucrSourceNotes
    Friend WithEvents tbpRows As TabPage
    Friend WithEvents ucrHeader As ucrHeader
    Friend WithEvents tbpColumns As TabPage
    Friend WithEvents ucrColumns As ucrColumns
    Friend WithEvents ucrRows As ucrRows
    Friend WithEvents tbpStub As TabPage
    Friend WithEvents ucrStub As ucrStub
    Friend WithEvents ucrCells As ucrCells
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
    Friend WithEvents tbpOtherStyles As TabPage
    Friend WithEvents ucrOtherStyles As ucrOtherStyles
    Friend WithEvents ucrChkSelectTheme As ucrCheck
    Friend WithEvents ucrChkManualTheme As ucrCheck
    Friend WithEvents tbpTables As TabPage
    Friend WithEvents rdoText As RadioButton
    Friend WithEvents rdoDate As RadioButton
    Friend WithEvents rdoNumber As RadioButton
    Friend WithEvents btnTextFormat As Button
    Friend WithEvents btnDateFormat As Button
    Friend WithEvents btnNumberFormat As Button
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents lblMissingText As Label
    Friend WithEvents ucrTxtMissingText As ucrInputComboBox
    Friend WithEvents ucrChkMissingValues As ucrCheck
    Friend WithEvents ucrChkDataFormat As ucrCheck
    Friend WithEvents ucrPnlFormat As UcrPanel
End Class
