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
        Me.lblEncoding = New System.Windows.Forms.Label()
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
        Me.rdoHeadingsYes = New System.Windows.Forms.RadioButton()
        Me.rdoHeadingsNo = New System.Windows.Forms.RadioButton()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.chlStringsAsFactors = New System.Windows.Forms.CheckBox()
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblLinesToSkip = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.nudSkips = New System.Windows.Forms.NumericUpDown()
        Me.cmdOpenDataSet = New System.Windows.Forms.Button()
        CType(Me.nudSkips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInputFile
        '
        Me.lblInputFile.AutoSize = True
        Me.lblInputFile.Location = New System.Drawing.Point(292, 9)
        Me.lblInputFile.Name = "lblInputFile"
        Me.lblInputFile.Size = New System.Drawing.Size(50, 13)
        Me.lblInputFile.TabIndex = 0
        Me.lblInputFile.Tag = "Input_File"
        Me.lblInputFile.Text = "Input File"
        '
        'lblDataFrame
        '
        Me.lblDataFrame.AutoSize = True
        Me.lblDataFrame.Location = New System.Drawing.Point(292, 239)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(62, 13)
        Me.lblDataFrame.TabIndex = 1
        Me.lblDataFrame.Tag = "Data_Frame"
        Me.lblDataFrame.Text = "Data Frame"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 61)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Tag = "Name"
        Me.lblName.Text = "Name"
        '
        'lblEncoding
        '
        Me.lblEncoding.AutoSize = True
        Me.lblEncoding.Location = New System.Drawing.Point(12, 99)
        Me.lblEncoding.Name = "lblEncoding"
        Me.lblEncoding.Size = New System.Drawing.Size(52, 13)
        Me.lblEncoding.TabIndex = 3
        Me.lblEncoding.Tag = "Encoding"
        Me.lblEncoding.Text = "Encoding"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(12, 135)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(47, 13)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Tag = "Heading"
        Me.lblHeading.Text = "Heading"
        '
        'lblRowNames
        '
        Me.lblRowNames.AutoSize = True
        Me.lblRowNames.Location = New System.Drawing.Point(12, 171)
        Me.lblRowNames.Name = "lblRowNames"
        Me.lblRowNames.Size = New System.Drawing.Size(63, 13)
        Me.lblRowNames.TabIndex = 5
        Me.lblRowNames.Tag = "Row_names"
        Me.lblRowNames.Text = "Row names"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(12, 218)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(53, 13)
        Me.lblSeparator.TabIndex = 6
        Me.lblSeparator.Tag = "Separator"
        Me.lblSeparator.Text = "Separator"
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.Location = New System.Drawing.Point(12, 262)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(45, 13)
        Me.lblDecimal.TabIndex = 7
        Me.lblDecimal.Tag = "Decimal"
        Me.lblDecimal.Text = "Decimal"
        '
        'lblQuote
        '
        Me.lblQuote.AutoSize = True
        Me.lblQuote.Location = New System.Drawing.Point(12, 311)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(36, 13)
        Me.lblQuote.TabIndex = 8
        Me.lblQuote.Tag = "Quote"
        Me.lblQuote.Text = "Quote"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(12, 359)
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
        Me.txtName.Location = New System.Drawing.Point(50, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(202, 20)
        Me.txtName.TabIndex = 11
        '
        'cboEncoding
        '
        Me.cboEncoding.FormattingEnabled = True
        Me.cboEncoding.Items.AddRange(New Object() {"Automatic"})
        Me.cboEncoding.Location = New System.Drawing.Point(81, 96)
        Me.cboEncoding.Name = "cboEncoding"
        Me.cboEncoding.Size = New System.Drawing.Size(136, 21)
        Me.cboEncoding.TabIndex = 12
        '
        'cboRowNames
        '
        Me.cboRowNames.FormattingEnabled = True
        Me.cboRowNames.Items.AddRange(New Object() {"Automatic", "Use first column", "Use numbers"})
        Me.cboRowNames.Location = New System.Drawing.Point(81, 163)
        Me.cboRowNames.Name = "cboRowNames"
        Me.cboRowNames.Size = New System.Drawing.Size(136, 21)
        Me.cboRowNames.TabIndex = 14
        '
        'cboSeparator
        '
        Me.cboSeparator.FormattingEnabled = True
        Me.cboSeparator.Items.AddRange(New Object() {"Comma", "Whitespace", "Semicolon"})
        Me.cboSeparator.Location = New System.Drawing.Point(81, 210)
        Me.cboSeparator.Name = "cboSeparator"
        Me.cboSeparator.Size = New System.Drawing.Size(136, 21)
        Me.cboSeparator.TabIndex = 15
        '
        'cboDecimal
        '
        Me.cboDecimal.FormattingEnabled = True
        Me.cboDecimal.Items.AddRange(New Object() {"Period", "Comma"})
        Me.cboDecimal.Location = New System.Drawing.Point(81, 254)
        Me.cboDecimal.Name = "cboDecimal"
        Me.cboDecimal.Size = New System.Drawing.Size(136, 21)
        Me.cboDecimal.TabIndex = 16
        '
        'cboQuote
        '
        Me.cboQuote.FormattingEnabled = True
        Me.cboQuote.Items.AddRange(New Object() {"Double quote ("")", "Single quote (')", "None"})
        Me.cboQuote.Location = New System.Drawing.Point(81, 303)
        Me.cboQuote.Name = "cboQuote"
        Me.cboQuote.Size = New System.Drawing.Size(136, 21)
        Me.cboQuote.TabIndex = 17
        '
        'cboComment
        '
        Me.cboComment.FormattingEnabled = True
        Me.cboComment.Items.AddRange(New Object() {"#", "%", "@", "~", "/", "None"})
        Me.cboComment.Location = New System.Drawing.Point(81, 351)
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
        'rdoHeadingsYes
        '
        Me.rdoHeadingsYes.AutoSize = True
        Me.rdoHeadingsYes.Location = New System.Drawing.Point(72, 130)
        Me.rdoHeadingsYes.Name = "rdoHeadingsYes"
        Me.rdoHeadingsYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoHeadingsYes.TabIndex = 20
        Me.rdoHeadingsYes.TabStop = True
        Me.rdoHeadingsYes.Tag = "Yes"
        Me.rdoHeadingsYes.Text = "Yes"
        Me.rdoHeadingsYes.UseVisualStyleBackColor = True
        '
        'rdoHeadingsNo
        '
        Me.rdoHeadingsNo.AutoSize = True
        Me.rdoHeadingsNo.Location = New System.Drawing.Point(137, 130)
        Me.rdoHeadingsNo.Name = "rdoHeadingsNo"
        Me.rdoHeadingsNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoHeadingsNo.TabIndex = 21
        Me.rdoHeadingsNo.TabStop = True
        Me.rdoHeadingsNo.Tag = "No"
        Me.rdoHeadingsNo.Text = "No"
        Me.rdoHeadingsNo.UseVisualStyleBackColor = True
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(295, 25)
        Me.txtInputFile.Multiline = True
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInputFile.Size = New System.Drawing.Size(422, 205)
        Me.txtInputFile.TabIndex = 22
        '
        'chlStringsAsFactors
        '
        Me.chlStringsAsFactors.AutoSize = True
        Me.chlStringsAsFactors.Location = New System.Drawing.Point(15, 451)
        Me.chlStringsAsFactors.Name = "chlStringsAsFactors"
        Me.chlStringsAsFactors.Size = New System.Drawing.Size(107, 17)
        Me.chlStringsAsFactors.TabIndex = 26
        Me.chlStringsAsFactors.Tag = "Strings_as_factors"
        Me.chlStringsAsFactors.Text = "Strings as factors"
        Me.chlStringsAsFactors.UseVisualStyleBackColor = True
        '
        'grdDataPreview
        '
        Me.grdDataPreview.BackColor = System.Drawing.Color.White
        Me.grdDataPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Location = New System.Drawing.Point(295, 256)
        Me.grdDataPreview.Name = "grdDataPreview"
        Me.grdDataPreview.Readonly = True
        Me.grdDataPreview.RowHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Script = Nothing
        Me.grdDataPreview.SheetTabContextMenuStrip = Nothing
        Me.grdDataPreview.SheetTabNewButtonVisible = False
        Me.grdDataPreview.SheetTabWidth = 60
        Me.grdDataPreview.SheetTabNewButtonVisible = False
        Me.grdDataPreview.Size = New System.Drawing.Size(422, 174)
        Me.grdDataPreview.TabIndex = 28
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(277, 445)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 27
        '
        'lblFileOpenPath
        '
        Me.lblFileOpenPath.AutoSize = True
        Me.lblFileOpenPath.Location = New System.Drawing.Point(12, 28)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(23, 13)
        Me.lblFileOpenPath.TabIndex = 29
        Me.lblFileOpenPath.Text = "File"
        '
        'lblLinesToSkip
        '
        Me.lblLinesToSkip.AutoSize = True
        Me.lblLinesToSkip.Location = New System.Drawing.Point(12, 418)
        Me.lblLinesToSkip.Name = "lblLinesToSkip"
        Me.lblLinesToSkip.Size = New System.Drawing.Size(72, 13)
        Me.lblLinesToSkip.TabIndex = 30
        Me.lblLinesToSkip.Text = "Lines To Skip"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(50, 25)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(167, 20)
        Me.txtFilePath.TabIndex = 31
        '
        'nudSkips
        '
        Me.nudSkips.Location = New System.Drawing.Point(158, 411)
        Me.nudSkips.Name = "nudSkips"
        Me.nudSkips.Size = New System.Drawing.Size(59, 20)
        Me.nudSkips.TabIndex = 32
        '
        'cmdOpenDataSet
        '
        Me.cmdOpenDataSet.Location = New System.Drawing.Point(223, 23)
        Me.cmdOpenDataSet.Name = "cmdOpenDataSet"
        Me.cmdOpenDataSet.Size = New System.Drawing.Size(66, 23)
        Me.cmdOpenDataSet.TabIndex = 33
        Me.cmdOpenDataSet.Tag = "select_file"
        Me.cmdOpenDataSet.Text = "Select File"
        Me.cmdOpenDataSet.UseVisualStyleBackColor = True
        '
        'dlgImportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 501)
        Me.Controls.Add(Me.cmdOpenDataSet)
        Me.Controls.Add(Me.nudSkips)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.lblLinesToSkip)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.grdDataPreview)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.chlStringsAsFactors)
        Me.Controls.Add(Me.txtInputFile)
        Me.Controls.Add(Me.rdoHeadingsNo)
        Me.Controls.Add(Me.rdoHeadingsYes)
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
        Me.Controls.Add(Me.lblEncoding)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.lblInputFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgImportDataset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Import_Dataset"
        Me.Text = "Import Dataset"
        CType(Me.nudSkips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInputFile As Label
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEncoding As Label
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
    Friend WithEvents rdoHeadingsYes As RadioButton
    Friend WithEvents rdoHeadingsNo As RadioButton
    Friend WithEvents txtInputFile As TextBox
    Friend WithEvents chlStringsAsFactors As CheckBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grdDataPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblLinesToSkip As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents nudSkips As NumericUpDown
    Friend WithEvents cmdOpenDataSet As Button
End Class
