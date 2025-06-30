<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgBeforeTablesOption
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
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.lblMissingText = New System.Windows.Forms.Label()
        Me.ucrTxtMissingText = New instat.ucrInputComboBox()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.rdoDate = New System.Windows.Forms.RadioButton()
        Me.rdoNumber = New System.Windows.Forms.RadioButton()
        Me.btnTextFormat = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.btnDateFormat = New System.Windows.Forms.Button()
        Me.ucrPnlFormat = New instat.UcrPanel()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.ucrChkDataFormat = New instat.ucrCheck()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
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
        Me.tbpFormatOptions.Controls.Add(Me.tbpSourceNotes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpOtherStyles)
        Me.tbpFormatOptions.Controls.Add(Me.tbpTables)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(2, 1)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(645, 389)
        Me.tbpFormatOptions.TabIndex = 6
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.ucrHeader)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 22)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHeader.Size = New System.Drawing.Size(637, 363)
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
        'tbpSourceNotes
        '
        Me.tbpSourceNotes.Controls.Add(Me.ucrSourceNotes)
        Me.tbpSourceNotes.Location = New System.Drawing.Point(4, 22)
        Me.tbpSourceNotes.Name = "tbpSourceNotes"
        Me.tbpSourceNotes.Size = New System.Drawing.Size(637, 363)
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
        Me.tbpThemes.Size = New System.Drawing.Size(637, 363)
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
        Me.tbpOtherStyles.Size = New System.Drawing.Size(637, 363)
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
        Me.tbpTables.Controls.Add(Me.ucrPnlFormat)
        Me.tbpTables.Controls.Add(Me.grpMissingValues)
        Me.tbpTables.Controls.Add(Me.ucrChkMissingValues)
        Me.tbpTables.Controls.Add(Me.ucrChkDataFormat)
        Me.tbpTables.Location = New System.Drawing.Point(4, 22)
        Me.tbpTables.Name = "tbpTables"
        Me.tbpTables.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTables.Size = New System.Drawing.Size(637, 363)
        Me.tbpTables.TabIndex = 11
        Me.tbpTables.Text = "Table"
        Me.tbpTables.UseVisualStyleBackColor = True
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.lblMissingText)
        Me.grpMissingValues.Controls.Add(Me.ucrTxtMissingText)
        Me.grpMissingValues.Location = New System.Drawing.Point(168, 166)
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.Size = New System.Drawing.Size(167, 88)
        Me.grpMissingValues.TabIndex = 387
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
        Me.rdoText.Location = New System.Drawing.Point(168, 108)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(89, 17)
        Me.rdoText.TabIndex = 3
        Me.rdoText.TabStop = True
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoDate
        '
        Me.rdoDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDate.Location = New System.Drawing.Point(168, 73)
        Me.rdoDate.Name = "rdoDate"
        Me.rdoDate.Size = New System.Drawing.Size(89, 17)
        Me.rdoDate.TabIndex = 2
        Me.rdoDate.TabStop = True
        Me.rdoDate.Text = "Date"
        Me.rdoDate.UseVisualStyleBackColor = True
        '
        'rdoNumber
        '
        Me.rdoNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNumber.Location = New System.Drawing.Point(168, 39)
        Me.rdoNumber.Name = "rdoNumber"
        Me.rdoNumber.Size = New System.Drawing.Size(89, 16)
        Me.rdoNumber.TabIndex = 1
        Me.rdoNumber.TabStop = True
        Me.rdoNumber.Text = "Number"
        Me.rdoNumber.UseVisualStyleBackColor = True
        '
        'btnTextFormat
        '
        Me.btnTextFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnTextFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTextFormat.Location = New System.Drawing.Point(260, 102)
        Me.btnTextFormat.Name = "btnTextFormat"
        Me.btnTextFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnTextFormat.TabIndex = 381
        Me.btnTextFormat.Tag = ""
        Me.btnTextFormat.Text = "Text Format"
        Me.btnTextFormat.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnNumberFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNumberFormat.Location = New System.Drawing.Point(260, 36)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnNumberFormat.TabIndex = 383
        Me.btnNumberFormat.Tag = ""
        Me.btnNumberFormat.Text = "Number Format"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'btnDateFormat
        '
        Me.btnDateFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnDateFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDateFormat.Location = New System.Drawing.Point(260, 67)
        Me.btnDateFormat.Name = "btnDateFormat"
        Me.btnDateFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnDateFormat.TabIndex = 382
        Me.btnDateFormat.Tag = ""
        Me.btnDateFormat.Text = "Date Format"
        Me.btnDateFormat.UseVisualStyleBackColor = True
        '
        'ucrPnlFormat
        '
        Me.ucrPnlFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFormat.Location = New System.Drawing.Point(164, 36)
        Me.ucrPnlFormat.Name = "ucrPnlFormat"
        Me.ucrPnlFormat.Size = New System.Drawing.Size(224, 88)
        Me.ucrPnlFormat.TabIndex = 0
        '
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.AutoSize = True
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(36, 166)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkMissingValues.TabIndex = 385
        '
        'ucrChkDataFormat
        '
        Me.ucrChkDataFormat.AutoSize = True
        Me.ucrChkDataFormat.Checked = False
        Me.ucrChkDataFormat.Location = New System.Drawing.Point(36, 38)
        Me.ucrChkDataFormat.Name = "ucrChkDataFormat"
        Me.ucrChkDataFormat.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkDataFormat.TabIndex = 384
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(195, 424)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 344
        '
        'sdgBeforeTablesOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 466)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgBeforeTablesOption"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tables Option"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
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
    Friend WithEvents ucrHeader As ucrHeader
    Friend WithEvents tbpSourceNotes As TabPage
    Friend WithEvents ucrSourceNotes As ucrSourceNotes
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents ucrChkSelectTheme As ucrCheck
    Friend WithEvents ucrChkManualTheme As ucrCheck
    Friend WithEvents ucrCboSelectThemes As ucrInputComboBox
    Friend WithEvents btnManualTheme As Button
    Friend WithEvents tbpOtherStyles As TabPage
    Friend WithEvents ucrOtherStyles As ucrOtherStyles
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
    Friend WithEvents tbpTables As TabPage
    Friend WithEvents ucrChkMissingValues As ucrCheck
    Friend WithEvents ucrChkDataFormat As ucrCheck
    Friend WithEvents rdoText As RadioButton
    Friend WithEvents rdoDate As RadioButton
    Friend WithEvents rdoNumber As RadioButton
    Friend WithEvents ucrPnlFormat As UcrPanel
    Friend WithEvents btnTextFormat As Button
    Friend WithEvents btnNumberFormat As Button
    Friend WithEvents btnDateFormat As Button
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents lblMissingText As Label
    Friend WithEvents ucrTxtMissingText As ucrInputComboBox
End Class
