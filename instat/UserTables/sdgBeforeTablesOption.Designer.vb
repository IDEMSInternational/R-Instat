<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgBeforeTablesOption
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
        Me.ucrNewCellFormats = New instat.ucrNewCellFormats()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.tbpSourceNotes.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        Me.tbpOtherStyles.SuspendLayout()
        Me.tbpTables.SuspendLayout()
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
        Me.tbpTables.Controls.Add(Me.ucrNewCellFormats)
        Me.tbpTables.Location = New System.Drawing.Point(4, 22)
        Me.tbpTables.Name = "tbpTables"
        Me.tbpTables.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTables.Size = New System.Drawing.Size(637, 363)
        Me.tbpTables.TabIndex = 11
        Me.tbpTables.Text = "Table"
        Me.tbpTables.UseVisualStyleBackColor = True
        '
        'ucrNewCellFormats
        '
        Me.ucrNewCellFormats.Location = New System.Drawing.Point(10, 11)
        Me.ucrNewCellFormats.Name = "ucrNewCellFormats"
        Me.ucrNewCellFormats.Size = New System.Drawing.Size(602, 343)
        Me.ucrNewCellFormats.TabIndex = 298
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
    Friend WithEvents ucrNewCellFormats As ucrNewCellFormats
End Class
