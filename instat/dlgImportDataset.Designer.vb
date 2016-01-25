<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportDataset
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
        Me.lblInputFile = New System.Windows.Forms.Label()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblRowNames = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblNAStrings = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cboEncoding = New System.Windows.Forms.ComboBox()
        Me.cboRowNames = New System.Windows.Forms.ComboBox()
        Me.cboSeparator = New System.Windows.Forms.ComboBox()
        Me.cboDecimal = New System.Windows.Forms.ComboBox()
        Me.cboQuote = New System.Windows.Forms.ComboBox()
        Me.cboComment = New System.Windows.Forms.ComboBox()
        Me.txtNAStrings = New System.Windows.Forms.TextBox()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.txtDataFrame = New System.Windows.Forms.TextBox()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chlStringsAsFactors = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblInputFile
        '
        Me.lblInputFile.AutoSize = True
        Me.lblInputFile.Location = New System.Drawing.Point(262, 9)
        Me.lblInputFile.Name = "lblInputFile"
        Me.lblInputFile.Size = New System.Drawing.Size(50, 13)
        Me.lblInputFile.TabIndex = 0
        Me.lblInputFile.Tag = "Input_File"
        Me.lblInputFile.Text = "Input File"
        '
        'lblDataFrame
        '
        Me.lblDataFrame.AutoSize = True
        Me.lblDataFrame.Location = New System.Drawing.Point(262, 239)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(62, 13)
        Me.lblDataFrame.TabIndex = 1
        Me.lblDataFrame.Tag = "Data_Frame"
        Me.lblDataFrame.Text = "Data Frame"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Tag = "Name"
        Me.lblName.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Tag = "Encoding"
        Me.Label4.Text = "Encoding"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(12, 110)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(47, 13)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Tag = "Heading"
        Me.lblHeading.Text = "Heading"
        '
        'lblRowNames
        '
        Me.lblRowNames.AutoSize = True
        Me.lblRowNames.Location = New System.Drawing.Point(12, 153)
        Me.lblRowNames.Name = "lblRowNames"
        Me.lblRowNames.Size = New System.Drawing.Size(63, 13)
        Me.lblRowNames.TabIndex = 5
        Me.lblRowNames.Tag = "Row_names"
        Me.lblRowNames.Text = "Row names"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(12, 200)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(53, 13)
        Me.lblSeparator.TabIndex = 6
        Me.lblSeparator.Tag = "Separator"
        Me.lblSeparator.Text = "Separator"
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.Location = New System.Drawing.Point(12, 244)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(45, 13)
        Me.lblDecimal.TabIndex = 7
        Me.lblDecimal.Tag = "Decimal"
        Me.lblDecimal.Text = "Decimal"
        '
        'lblQuote
        '
        Me.lblQuote.AutoSize = True
        Me.lblQuote.Location = New System.Drawing.Point(12, 293)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(36, 13)
        Me.lblQuote.TabIndex = 8
        Me.lblQuote.Tag = "Quote"
        Me.lblQuote.Text = "Quote"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(12, 341)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(51, 13)
        Me.lblComment.TabIndex = 9
        Me.lblComment.Tag = "Comment"
        Me.lblComment.Text = "Comment"
        '
        'lblNAStrings
        '
        Me.lblNAStrings.AutoSize = True
        Me.lblNAStrings.Location = New System.Drawing.Point(12, 392)
        Me.lblNAStrings.Name = "lblNAStrings"
        Me.lblNAStrings.Size = New System.Drawing.Size(52, 13)
        Me.lblNAStrings.TabIndex = 10
        Me.lblNAStrings.Text = "na.strings"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 11
        '
        'cboEncoding
        '
        Me.cboEncoding.FormattingEnabled = True
        Me.cboEncoding.Items.AddRange(New Object() {"Automatic"})
        Me.cboEncoding.Location = New System.Drawing.Point(67, 62)
        Me.cboEncoding.Name = "cboEncoding"
        Me.cboEncoding.Size = New System.Drawing.Size(121, 21)
        Me.cboEncoding.TabIndex = 12
        '
        'cboRowNames
        '
        Me.cboRowNames.FormattingEnabled = True
        Me.cboRowNames.Items.AddRange(New Object() {"Automatic", "Use first column", "Use numbers"})
        Me.cboRowNames.Location = New System.Drawing.Point(81, 145)
        Me.cboRowNames.Name = "cboRowNames"
        Me.cboRowNames.Size = New System.Drawing.Size(136, 21)
        Me.cboRowNames.TabIndex = 14
        '
        'cboSeparator
        '
        Me.cboSeparator.FormattingEnabled = True
        Me.cboSeparator.Items.AddRange(New Object() {"Comma", "Whitespace", "Semicolon", "Tab"})
        Me.cboSeparator.Location = New System.Drawing.Point(81, 192)
        Me.cboSeparator.Name = "cboSeparator"
        Me.cboSeparator.Size = New System.Drawing.Size(136, 21)
        Me.cboSeparator.TabIndex = 15
        '
        'cboDecimal
        '
        Me.cboDecimal.FormattingEnabled = True
        Me.cboDecimal.Items.AddRange(New Object() {"Period", "Comma"})
        Me.cboDecimal.Location = New System.Drawing.Point(81, 236)
        Me.cboDecimal.Name = "cboDecimal"
        Me.cboDecimal.Size = New System.Drawing.Size(136, 21)
        Me.cboDecimal.TabIndex = 16
        '
        'cboQuote
        '
        Me.cboQuote.FormattingEnabled = True
        Me.cboQuote.Items.AddRange(New Object() {"Double quote ("")", "Single quote (')", "None"})
        Me.cboQuote.Location = New System.Drawing.Point(81, 285)
        Me.cboQuote.Name = "cboQuote"
        Me.cboQuote.Size = New System.Drawing.Size(136, 21)
        Me.cboQuote.TabIndex = 17
        '
        'cboComment
        '
        Me.cboComment.FormattingEnabled = True
        Me.cboComment.Items.AddRange(New Object() {"#", "%", "@", "~", "/", "None"})
        Me.cboComment.Location = New System.Drawing.Point(81, 333)
        Me.cboComment.Name = "cboComment"
        Me.cboComment.Size = New System.Drawing.Size(136, 21)
        Me.cboComment.TabIndex = 18
        '
        'txtNAStrings
        '
        Me.txtNAStrings.Location = New System.Drawing.Point(81, 385)
        Me.txtNAStrings.Name = "txtNAStrings"
        Me.txtNAStrings.Size = New System.Drawing.Size(100, 20)
        Me.txtNAStrings.TabIndex = 19
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Location = New System.Drawing.Point(72, 105)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoYes.TabIndex = 20
        Me.rdoYes.TabStop = True
        Me.rdoYes.Tag = "Yes"
        Me.rdoYes.Text = "Yes"
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Location = New System.Drawing.Point(137, 105)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoNo.TabIndex = 21
        Me.rdoNo.TabStop = True
        Me.rdoNo.Tag = "No"
        Me.rdoNo.Text = "No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(265, 25)
        Me.txtInputFile.Multiline = True
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.Size = New System.Drawing.Size(422, 205)
        Me.txtInputFile.TabIndex = 22
        '
        'txtDataFrame
        '
        Me.txtDataFrame.Location = New System.Drawing.Point(265, 255)
        Me.txtDataFrame.Multiline = True
        Me.txtDataFrame.Name = "txtDataFrame"
        Me.txtDataFrame.Size = New System.Drawing.Size(422, 178)
        Me.txtDataFrame.TabIndex = 23
        '
        'cmdImport
        '
        Me.cmdImport.Location = New System.Drawing.Point(484, 453)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(75, 23)
        Me.cmdImport.TabIndex = 24
        Me.cmdImport.Tag = "Import"
        Me.cmdImport.Text = "Import"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(596, 453)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 25
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'chlStringsAsFactors
        '
        Me.chlStringsAsFactors.AutoSize = True
        Me.chlStringsAsFactors.Location = New System.Drawing.Point(15, 432)
        Me.chlStringsAsFactors.Name = "chlStringsAsFactors"
        Me.chlStringsAsFactors.Size = New System.Drawing.Size(107, 17)
        Me.chlStringsAsFactors.TabIndex = 26
        Me.chlStringsAsFactors.Tag = "Strings_as_factors"
        Me.chlStringsAsFactors.Text = "Strings as factors"
        Me.chlStringsAsFactors.UseVisualStyleBackColor = True
        '
        'dlgImportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 483)
        Me.Controls.Add(Me.chlStringsAsFactors)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.txtDataFrame)
        Me.Controls.Add(Me.txtInputFile)
        Me.Controls.Add(Me.rdoNo)
        Me.Controls.Add(Me.rdoYes)
        Me.Controls.Add(Me.txtNAStrings)
        Me.Controls.Add(Me.cboComment)
        Me.Controls.Add(Me.cboQuote)
        Me.Controls.Add(Me.cboDecimal)
        Me.Controls.Add(Me.cboSeparator)
        Me.Controls.Add(Me.cboRowNames)
        Me.Controls.Add(Me.cboEncoding)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblNAStrings)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblQuote)
        Me.Controls.Add(Me.lblDecimal)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.lblRowNames)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.lblInputFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgImportDataset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Import_Dataset"
        Me.Text = "Import Dataset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInputFile As Label
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblRowNames As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblQuote As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents lblNAStrings As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cboEncoding As ComboBox
    Friend WithEvents cboRowNames As ComboBox
    Friend WithEvents cboSeparator As ComboBox
    Friend WithEvents cboDecimal As ComboBox
    Friend WithEvents cboQuote As ComboBox
    Friend WithEvents cboComment As ComboBox
    Friend WithEvents txtNAStrings As TextBox
    Friend WithEvents rdoYes As RadioButton
    Friend WithEvents rdoNo As RadioButton
    Friend WithEvents txtInputFile As TextBox
    Friend WithEvents txtDataFrame As TextBox
    Friend WithEvents cmdImport As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents chlStringsAsFactors As CheckBox
End Class
