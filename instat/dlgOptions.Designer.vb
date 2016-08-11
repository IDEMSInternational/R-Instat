<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOptions
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Languages")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comments")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Output Window")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Commands")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Data View")
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpWorkingDirectory = New System.Windows.Forms.TabPage()
        Me.lblWorkingDirectory = New System.Windows.Forms.Label()
        Me.ucrWorkingDirectory = New instat.ucrInputTextBox()
        Me.cmdWorkingDirectory = New System.Windows.Forms.Button()
        Me.tbpDataView = New System.Windows.Forms.TabPage()
        Me.nudMaxRows = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxRows = New System.Windows.Forms.Label()
        Me.tbpCommands = New System.Windows.Forms.TabPage()
        Me.pnScriptOptions = New System.Windows.Forms.Panel()
        Me.chkIncludeDefaultParams = New System.Windows.Forms.CheckBox()
        Me.tbpEditor = New System.Windows.Forms.TabPage()
        Me.pnFormatEditor = New System.Windows.Forms.Panel()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.cmdEditorFont = New System.Windows.Forms.Button()
        Me.tbpOutputWindow = New System.Windows.Forms.TabPage()
        Me.pnFormatOptions = New System.Windows.Forms.Panel()
        Me.lblCommandFormat = New System.Windows.Forms.Label()
        Me.cmdCommentFormat = New System.Windows.Forms.Button()
        Me.lblOutputFormat = New System.Windows.Forms.Label()
        Me.cmdOutputFormat = New System.Windows.Forms.Button()
        Me.lblCommentFormat = New System.Windows.Forms.Label()
        Me.cmdCommandFormat = New System.Windows.Forms.Button()
        Me.rtbCommandPreview = New System.Windows.Forms.RichTextBox()
        Me.rtbOutputPreview = New System.Windows.Forms.RichTextBox()
        Me.rtbCommentPreview = New System.Windows.Forms.RichTextBox()
        Me.tbpImport = New System.Windows.Forms.TabPage()
        Me.pnImportData = New System.Windows.Forms.Panel()
        Me.nudPreviewRows = New System.Windows.Forms.NumericUpDown()
        Me.lblPreviewRows = New System.Windows.Forms.Label()
        Me.tbpComments = New System.Windows.Forms.TabPage()
        Me.pnComments = New System.Windows.Forms.Panel()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.tbpLanguages = New System.Windows.Forms.TabPage()
        Me.pnLanguages = New System.Windows.Forms.Panel()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.rdoFrench = New System.Windows.Forms.RadioButton()
        Me.rdoKiswahili = New System.Windows.Forms.RadioButton()
        Me.rdoEnglish = New System.Windows.Forms.RadioButton()
        Me.rdoSpanish = New System.Windows.Forms.RadioButton()
        Me.trOptions = New System.Windows.Forms.TreeView()
        Me.spltControls = New System.Windows.Forms.SplitContainer()
        Me.tbcOptions.SuspendLayout()
        Me.tbpWorkingDirectory.SuspendLayout()
        Me.tbpDataView.SuspendLayout()
        CType(Me.nudMaxRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpCommands.SuspendLayout()
        Me.pnScriptOptions.SuspendLayout()
        Me.tbpEditor.SuspendLayout()
        Me.pnFormatEditor.SuspendLayout()
        Me.tbpOutputWindow.SuspendLayout()
        Me.pnFormatOptions.SuspendLayout()
        Me.tbpImport.SuspendLayout()
        Me.pnImportData.SuspendLayout()
        CType(Me.nudPreviewRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpComments.SuspendLayout()
        Me.pnComments.SuspendLayout()
        Me.tbpLanguages.SuspendLayout()
        Me.pnLanguages.SuspendLayout()
        Me.grpLanguage.SuspendLayout()
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltControls.Panel1.SuspendLayout()
        Me.spltControls.Panel2.SuspendLayout()
        Me.spltControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(316, 320)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 10
        Me.cmdApply.Tag = "Apply"
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(397, 320)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 12
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(235, 320)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(154, 320)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpLanguages)
        Me.tbcOptions.Controls.Add(Me.tbpComments)
        Me.tbcOptions.Controls.Add(Me.tbpImport)
        Me.tbcOptions.Controls.Add(Me.tbpOutputWindow)
        Me.tbcOptions.Controls.Add(Me.tbpEditor)
        Me.tbcOptions.Controls.Add(Me.tbpCommands)
        Me.tbcOptions.Controls.Add(Me.tbpDataView)
        Me.tbcOptions.Controls.Add(Me.tbpWorkingDirectory)
        Me.tbcOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcOptions.Location = New System.Drawing.Point(0, 0)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(572, 317)
        Me.tbcOptions.TabIndex = 0
        '
        'tbpWorkingDirectory
        '
        Me.tbpWorkingDirectory.Controls.Add(Me.cmdWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.ucrWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.lblWorkingDirectory)
        Me.tbpWorkingDirectory.Location = New System.Drawing.Point(4, 22)
        Me.tbpWorkingDirectory.Name = "tbpWorkingDirectory"
        Me.tbpWorkingDirectory.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpWorkingDirectory.Size = New System.Drawing.Size(564, 291)
        Me.tbpWorkingDirectory.TabIndex = 11
        Me.tbpWorkingDirectory.Text = "Working Directory"
        Me.tbpWorkingDirectory.UseVisualStyleBackColor = True
        '
        'lblWorkingDirectory
        '
        Me.lblWorkingDirectory.AutoSize = True
        Me.lblWorkingDirectory.Location = New System.Drawing.Point(3, 17)
        Me.lblWorkingDirectory.Name = "lblWorkingDirectory"
        Me.lblWorkingDirectory.Size = New System.Drawing.Size(92, 13)
        Me.lblWorkingDirectory.TabIndex = 0
        Me.lblWorkingDirectory.Text = "Working Directory"
        '
        'ucrWorkingDirectory
        '
        Me.ucrWorkingDirectory.IsReadOnly = False
        Me.ucrWorkingDirectory.Location = New System.Drawing.Point(101, 17)
        Me.ucrWorkingDirectory.Name = "ucrWorkingDirectory"
        Me.ucrWorkingDirectory.Size = New System.Drawing.Size(282, 21)
        Me.ucrWorkingDirectory.TabIndex = 1
        '
        'cmdWorkingDirectory
        '
        Me.cmdWorkingDirectory.Location = New System.Drawing.Point(383, 17)
        Me.cmdWorkingDirectory.Name = "cmdWorkingDirectory"
        Me.cmdWorkingDirectory.Size = New System.Drawing.Size(24, 21)
        Me.cmdWorkingDirectory.TabIndex = 2
        Me.cmdWorkingDirectory.Text = "..."
        Me.cmdWorkingDirectory.UseVisualStyleBackColor = True
        '
        'tbpDataView
        '
        Me.tbpDataView.Controls.Add(Me.lblMaxRows)
        Me.tbpDataView.Controls.Add(Me.nudMaxRows)
        Me.tbpDataView.Location = New System.Drawing.Point(4, 22)
        Me.tbpDataView.Name = "tbpDataView"
        Me.tbpDataView.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDataView.Size = New System.Drawing.Size(420, 291)
        Me.tbpDataView.TabIndex = 9
        Me.tbpDataView.Text = "Data View"
        Me.tbpDataView.UseVisualStyleBackColor = True
        '
        'nudMaxRows
        '
        Me.nudMaxRows.Location = New System.Drawing.Point(194, 39)
        Me.nudMaxRows.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMaxRows.Name = "nudMaxRows"
        Me.nudMaxRows.Size = New System.Drawing.Size(62, 20)
        Me.nudMaxRows.TabIndex = 0
        Me.nudMaxRows.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMaxRows
        '
        Me.lblMaxRows.AutoSize = True
        Me.lblMaxRows.Location = New System.Drawing.Point(6, 41)
        Me.lblMaxRows.Name = "lblMaxRows"
        Me.lblMaxRows.Size = New System.Drawing.Size(182, 13)
        Me.lblMaxRows.TabIndex = 1
        Me.lblMaxRows.Text = "Maximum Number of Rows to Display"
        '
        'tbpCommands
        '
        Me.tbpCommands.Controls.Add(Me.pnScriptOptions)
        Me.tbpCommands.Location = New System.Drawing.Point(4, 22)
        Me.tbpCommands.Name = "tbpCommands"
        Me.tbpCommands.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCommands.Size = New System.Drawing.Size(420, 291)
        Me.tbpCommands.TabIndex = 4
        Me.tbpCommands.Tag = "Commands"
        Me.tbpCommands.Text = "Commands"
        Me.tbpCommands.UseVisualStyleBackColor = True
        '
        'pnScriptOptions
        '
        Me.pnScriptOptions.AutoSize = True
        Me.pnScriptOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnScriptOptions.Controls.Add(Me.chkIncludeDefaultParams)
        Me.pnScriptOptions.Location = New System.Drawing.Point(3, 6)
        Me.pnScriptOptions.Name = "pnScriptOptions"
        Me.pnScriptOptions.Size = New System.Drawing.Size(267, 23)
        Me.pnScriptOptions.TabIndex = 1
        '
        'chkIncludeDefaultParams
        '
        Me.chkIncludeDefaultParams.AutoSize = True
        Me.chkIncludeDefaultParams.Location = New System.Drawing.Point(3, 3)
        Me.chkIncludeDefaultParams.Name = "chkIncludeDefaultParams"
        Me.chkIncludeDefaultParams.Size = New System.Drawing.Size(261, 17)
        Me.chkIncludeDefaultParams.TabIndex = 0
        Me.chkIncludeDefaultParams.Tag = "Include_Default_Parameter_Values_in_R_Commands"
        Me.chkIncludeDefaultParams.Text = "Include Default Parameter Values in R Commands"
        Me.chkIncludeDefaultParams.UseVisualStyleBackColor = True
        '
        'tbpEditor
        '
        Me.tbpEditor.Controls.Add(Me.pnFormatEditor)
        Me.tbpEditor.Location = New System.Drawing.Point(4, 22)
        Me.tbpEditor.Name = "tbpEditor"
        Me.tbpEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEditor.Size = New System.Drawing.Size(420, 291)
        Me.tbpEditor.TabIndex = 10
        Me.tbpEditor.Text = "Editor Window"
        Me.tbpEditor.ToolTipText = "Data View"
        Me.tbpEditor.UseVisualStyleBackColor = True
        '
        'pnFormatEditor
        '
        Me.pnFormatEditor.AutoSize = True
        Me.pnFormatEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnFormatEditor.Controls.Add(Me.cmdEditorFont)
        Me.pnFormatEditor.Controls.Add(Me.lblFont)
        Me.pnFormatEditor.Location = New System.Drawing.Point(6, 6)
        Me.pnFormatEditor.Name = "pnFormatEditor"
        Me.pnFormatEditor.Size = New System.Drawing.Size(391, 46)
        Me.pnFormatEditor.TabIndex = 22
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(0, 25)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(63, 13)
        Me.lblFont.TabIndex = 17
        Me.lblFont.Text = "Format Font"
        '
        'cmdEditorFont
        '
        Me.cmdEditorFont.Location = New System.Drawing.Point(288, 20)
        Me.cmdEditorFont.Name = "cmdEditorFont"
        Me.cmdEditorFont.Size = New System.Drawing.Size(100, 23)
        Me.cmdEditorFont.TabIndex = 10
        Me.cmdEditorFont.Text = "Change..."
        Me.cmdEditorFont.UseVisualStyleBackColor = True
        '
        'tbpOutputWindow
        '
        Me.tbpOutputWindow.Controls.Add(Me.pnFormatOptions)
        Me.tbpOutputWindow.Location = New System.Drawing.Point(4, 22)
        Me.tbpOutputWindow.Name = "tbpOutputWindow"
        Me.tbpOutputWindow.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOutputWindow.Size = New System.Drawing.Size(420, 291)
        Me.tbpOutputWindow.TabIndex = 2
        Me.tbpOutputWindow.Text = "Output Window"
        Me.tbpOutputWindow.UseVisualStyleBackColor = True
        '
        'pnFormatOptions
        '
        Me.pnFormatOptions.AutoSize = True
        Me.pnFormatOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnFormatOptions.Controls.Add(Me.rtbCommentPreview)
        Me.pnFormatOptions.Controls.Add(Me.rtbOutputPreview)
        Me.pnFormatOptions.Controls.Add(Me.rtbCommandPreview)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommandFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblCommentFormat)
        Me.pnFormatOptions.Controls.Add(Me.cmdOutputFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblOutputFormat)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommentFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblCommandFormat)
        Me.pnFormatOptions.Location = New System.Drawing.Point(0, 0)
        Me.pnFormatOptions.Name = "pnFormatOptions"
        Me.pnFormatOptions.Size = New System.Drawing.Size(391, 129)
        Me.pnFormatOptions.TabIndex = 21
        '
        'lblCommandFormat
        '
        Me.lblCommandFormat.AutoSize = True
        Me.lblCommandFormat.Location = New System.Drawing.Point(0, 25)
        Me.lblCommandFormat.Name = "lblCommandFormat"
        Me.lblCommandFormat.Size = New System.Drawing.Size(89, 13)
        Me.lblCommandFormat.TabIndex = 17
        Me.lblCommandFormat.Text = "Command Format"
        '
        'cmdCommentFormat
        '
        Me.cmdCommentFormat.Location = New System.Drawing.Point(288, 100)
        Me.cmdCommentFormat.Name = "cmdCommentFormat"
        Me.cmdCommentFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommentFormat.TabIndex = 16
        Me.cmdCommentFormat.Text = "Change..."
        Me.cmdCommentFormat.UseVisualStyleBackColor = True
        '
        'lblOutputFormat
        '
        Me.lblOutputFormat.AutoSize = True
        Me.lblOutputFormat.Location = New System.Drawing.Point(0, 65)
        Me.lblOutputFormat.Name = "lblOutputFormat"
        Me.lblOutputFormat.Size = New System.Drawing.Size(74, 13)
        Me.lblOutputFormat.TabIndex = 18
        Me.lblOutputFormat.Text = "Output Format"
        '
        'cmdOutputFormat
        '
        Me.cmdOutputFormat.Location = New System.Drawing.Point(288, 60)
        Me.cmdOutputFormat.Name = "cmdOutputFormat"
        Me.cmdOutputFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdOutputFormat.TabIndex = 16
        Me.cmdOutputFormat.Text = "Change..."
        Me.cmdOutputFormat.UseVisualStyleBackColor = True
        '
        'lblCommentFormat
        '
        Me.lblCommentFormat.AutoSize = True
        Me.lblCommentFormat.Location = New System.Drawing.Point(0, 105)
        Me.lblCommentFormat.Name = "lblCommentFormat"
        Me.lblCommentFormat.Size = New System.Drawing.Size(86, 13)
        Me.lblCommentFormat.TabIndex = 19
        Me.lblCommentFormat.Text = "Comment Format"
        '
        'cmdCommandFormat
        '
        Me.cmdCommandFormat.Location = New System.Drawing.Point(288, 20)
        Me.cmdCommandFormat.Name = "cmdCommandFormat"
        Me.cmdCommandFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommandFormat.TabIndex = 10
        Me.cmdCommandFormat.Text = "Change..."
        Me.cmdCommandFormat.UseVisualStyleBackColor = True
        '
        'rtbCommandPreview
        '
        Me.rtbCommandPreview.Location = New System.Drawing.Point(100, 20)
        Me.rtbCommandPreview.Name = "rtbCommandPreview"
        Me.rtbCommandPreview.ReadOnly = True
        Me.rtbCommandPreview.Size = New System.Drawing.Size(171, 26)
        Me.rtbCommandPreview.TabIndex = 20
        Me.rtbCommandPreview.Text = ""
        '
        'rtbOutputPreview
        '
        Me.rtbOutputPreview.Location = New System.Drawing.Point(100, 60)
        Me.rtbOutputPreview.Name = "rtbOutputPreview"
        Me.rtbOutputPreview.ReadOnly = True
        Me.rtbOutputPreview.Size = New System.Drawing.Size(171, 26)
        Me.rtbOutputPreview.TabIndex = 21
        Me.rtbOutputPreview.Text = ""
        '
        'rtbCommentPreview
        '
        Me.rtbCommentPreview.Location = New System.Drawing.Point(100, 100)
        Me.rtbCommentPreview.Name = "rtbCommentPreview"
        Me.rtbCommentPreview.ReadOnly = True
        Me.rtbCommentPreview.Size = New System.Drawing.Size(171, 26)
        Me.rtbCommentPreview.TabIndex = 22
        Me.rtbCommentPreview.Text = ""
        '
        'tbpImport
        '
        Me.tbpImport.Controls.Add(Me.pnImportData)
        Me.tbpImport.Location = New System.Drawing.Point(4, 22)
        Me.tbpImport.Name = "tbpImport"
        Me.tbpImport.Size = New System.Drawing.Size(420, 291)
        Me.tbpImport.TabIndex = 3
        Me.tbpImport.Text = "Import"
        Me.tbpImport.UseVisualStyleBackColor = True
        '
        'pnImportData
        '
        Me.pnImportData.AutoSize = True
        Me.pnImportData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnImportData.Controls.Add(Me.lblPreviewRows)
        Me.pnImportData.Controls.Add(Me.nudPreviewRows)
        Me.pnImportData.Location = New System.Drawing.Point(3, 3)
        Me.pnImportData.Name = "pnImportData"
        Me.pnImportData.Size = New System.Drawing.Size(181, 30)
        Me.pnImportData.TabIndex = 2
        '
        'nudPreviewRows
        '
        Me.nudPreviewRows.Location = New System.Drawing.Point(134, 7)
        Me.nudPreviewRows.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPreviewRows.Name = "nudPreviewRows"
        Me.nudPreviewRows.Size = New System.Drawing.Size(44, 20)
        Me.nudPreviewRows.TabIndex = 1
        Me.nudPreviewRows.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblPreviewRows
        '
        Me.lblPreviewRows.AutoSize = True
        Me.lblPreviewRows.Location = New System.Drawing.Point(3, 9)
        Me.lblPreviewRows.Name = "lblPreviewRows"
        Me.lblPreviewRows.Size = New System.Drawing.Size(127, 13)
        Me.lblPreviewRows.TabIndex = 0
        Me.lblPreviewRows.Text = "Number of Preview Rows"
        '
        'tbpComments
        '
        Me.tbpComments.Controls.Add(Me.pnComments)
        Me.tbpComments.Location = New System.Drawing.Point(4, 22)
        Me.tbpComments.Name = "tbpComments"
        Me.tbpComments.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpComments.Size = New System.Drawing.Size(420, 291)
        Me.tbpComments.TabIndex = 1
        Me.tbpComments.Tag = "Comments"
        Me.tbpComments.Text = "Comments"
        Me.tbpComments.UseVisualStyleBackColor = True
        '
        'pnComments
        '
        Me.pnComments.AutoSize = True
        Me.pnComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnComments.Controls.Add(Me.lblComment)
        Me.pnComments.Controls.Add(Me.txtComment)
        Me.pnComments.Location = New System.Drawing.Point(6, 6)
        Me.pnComments.Name = "pnComments"
        Me.pnComments.Size = New System.Drawing.Size(338, 33)
        Me.pnComments.TabIndex = 2
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(59, 10)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(276, 20)
        Me.txtComment.TabIndex = 1
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(2, 10)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(51, 13)
        Me.lblComment.TabIndex = 0
        Me.lblComment.Tag = "Comment"
        Me.lblComment.Text = "Comment"
        '
        'tbpLanguages
        '
        Me.tbpLanguages.Controls.Add(Me.pnLanguages)
        Me.tbpLanguages.Location = New System.Drawing.Point(4, 22)
        Me.tbpLanguages.Name = "tbpLanguages"
        Me.tbpLanguages.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLanguages.Size = New System.Drawing.Size(564, 291)
        Me.tbpLanguages.TabIndex = 0
        Me.tbpLanguages.Tag = "Languages"
        Me.tbpLanguages.Text = "Languages"
        Me.tbpLanguages.UseVisualStyleBackColor = True
        '
        'pnLanguages
        '
        Me.pnLanguages.AutoSize = True
        Me.pnLanguages.Controls.Add(Me.grpLanguage)
        Me.pnLanguages.Location = New System.Drawing.Point(3, 3)
        Me.pnLanguages.Name = "pnLanguages"
        Me.pnLanguages.Size = New System.Drawing.Size(118, 121)
        Me.pnLanguages.TabIndex = 1
        '
        'grpLanguage
        '
        Me.grpLanguage.Controls.Add(Me.rdoSpanish)
        Me.grpLanguage.Controls.Add(Me.rdoEnglish)
        Me.grpLanguage.Controls.Add(Me.rdoKiswahili)
        Me.grpLanguage.Controls.Add(Me.rdoFrench)
        Me.grpLanguage.Location = New System.Drawing.Point(3, 3)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(109, 113)
        Me.grpLanguage.TabIndex = 2
        Me.grpLanguage.TabStop = False
        Me.grpLanguage.Text = "Language"
        '
        'rdoFrench
        '
        Me.rdoFrench.AutoSize = True
        Me.rdoFrench.Location = New System.Drawing.Point(7, 42)
        Me.rdoFrench.Name = "rdoFrench"
        Me.rdoFrench.Size = New System.Drawing.Size(58, 17)
        Me.rdoFrench.TabIndex = 2
        Me.rdoFrench.Tag = "French"
        Me.rdoFrench.Text = "French"
        Me.rdoFrench.UseVisualStyleBackColor = True
        '
        'rdoKiswahili
        '
        Me.rdoKiswahili.AutoSize = True
        Me.rdoKiswahili.Location = New System.Drawing.Point(7, 65)
        Me.rdoKiswahili.Name = "rdoKiswahili"
        Me.rdoKiswahili.Size = New System.Drawing.Size(65, 17)
        Me.rdoKiswahili.TabIndex = 3
        Me.rdoKiswahili.Tag = "Kiswahili"
        Me.rdoKiswahili.Text = "Kiswahili"
        Me.rdoKiswahili.UseVisualStyleBackColor = True
        '
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Location = New System.Drawing.Point(7, 19)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rdoEnglish.TabIndex = 1
        Me.rdoEnglish.Tag = "English"
        Me.rdoEnglish.Text = "English"
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'rdoSpanish
        '
        Me.rdoSpanish.AutoSize = True
        Me.rdoSpanish.Enabled = False
        Me.rdoSpanish.Location = New System.Drawing.Point(7, 88)
        Me.rdoSpanish.Name = "rdoSpanish"
        Me.rdoSpanish.Size = New System.Drawing.Size(63, 17)
        Me.rdoSpanish.TabIndex = 2
        Me.rdoSpanish.Text = "Spanish"
        Me.rdoSpanish.UseVisualStyleBackColor = True
        '
        'trOptions
        '
        Me.trOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trOptions.Location = New System.Drawing.Point(0, 0)
        Me.trOptions.Name = "trOptions"
        TreeNode1.Name = "ndLanguages"
        TreeNode1.Tag = "1"
        TreeNode1.Text = "Languages"
        TreeNode1.ToolTipText = "Choose different languages"
        TreeNode2.Name = "ndComments"
        TreeNode2.Tag = "2"
        TreeNode2.Text = "Comments"
        TreeNode2.ToolTipText = "Comments for the dialogs"
        TreeNode3.Name = "ndImport"
        TreeNode3.Tag = "3"
        TreeNode3.Text = "Import"
        TreeNode3.ToolTipText = "Import Data Settings"
        TreeNode4.Name = "ndOutputWindow"
        TreeNode4.Tag = "4"
        TreeNode4.Text = "Output Window"
        TreeNode4.ToolTipText = "Output Window Formatting Options"
        TreeNode5.Name = "ndCommands"
        TreeNode5.Tag = "8"
        TreeNode5.Text = "Commands"
        TreeNode5.ToolTipText = "Commands Options"
        TreeNode6.Name = "ndDataView"
        TreeNode6.Text = "Data View"
        Me.trOptions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.trOptions.Size = New System.Drawing.Size(184, 317)
        Me.trOptions.TabIndex = 0
        '
        'spltControls
        '
        Me.spltControls.Location = New System.Drawing.Point(5, 1)
        Me.spltControls.Name = "spltControls"
        '
        'spltControls.Panel1
        '
        Me.spltControls.Panel1.Controls.Add(Me.trOptions)
        '
        'spltControls.Panel2
        '
        Me.spltControls.Panel2.Controls.Add(Me.tbcOptions)
        Me.spltControls.Size = New System.Drawing.Size(760, 317)
        Me.spltControls.SplitterDistance = 184
        Me.spltControls.TabIndex = 8
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 343)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.spltControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Options"
        Me.Text = "Options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpWorkingDirectory.ResumeLayout(False)
        Me.tbpWorkingDirectory.PerformLayout()
        Me.tbpDataView.ResumeLayout(False)
        Me.tbpDataView.PerformLayout()
        CType(Me.nudMaxRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpCommands.ResumeLayout(False)
        Me.tbpCommands.PerformLayout()
        Me.pnScriptOptions.ResumeLayout(False)
        Me.pnScriptOptions.PerformLayout()
        Me.tbpEditor.ResumeLayout(False)
        Me.tbpEditor.PerformLayout()
        Me.pnFormatEditor.ResumeLayout(False)
        Me.pnFormatEditor.PerformLayout()
        Me.tbpOutputWindow.ResumeLayout(False)
        Me.tbpOutputWindow.PerformLayout()
        Me.pnFormatOptions.ResumeLayout(False)
        Me.pnFormatOptions.PerformLayout()
        Me.tbpImport.ResumeLayout(False)
        Me.tbpImport.PerformLayout()
        Me.pnImportData.ResumeLayout(False)
        Me.pnImportData.PerformLayout()
        CType(Me.nudPreviewRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpComments.ResumeLayout(False)
        Me.tbpComments.PerformLayout()
        Me.pnComments.ResumeLayout(False)
        Me.pnComments.PerformLayout()
        Me.tbpLanguages.ResumeLayout(False)
        Me.tbpLanguages.PerformLayout()
        Me.pnLanguages.ResumeLayout(False)
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        Me.spltControls.Panel1.ResumeLayout(False)
        Me.spltControls.Panel2.ResumeLayout(False)
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdApply As Button
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpLanguages As TabPage
    Friend WithEvents pnLanguages As Panel
    Friend WithEvents grpLanguage As GroupBox
    Friend WithEvents rdoSpanish As RadioButton
    Friend WithEvents rdoEnglish As RadioButton
    Friend WithEvents rdoKiswahili As RadioButton
    Friend WithEvents rdoFrench As RadioButton
    Friend WithEvents tbpComments As TabPage
    Friend WithEvents pnComments As Panel
    Friend WithEvents lblComment As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents tbpImport As TabPage
    Friend WithEvents pnImportData As Panel
    Friend WithEvents lblPreviewRows As Label
    Friend WithEvents nudPreviewRows As NumericUpDown
    Friend WithEvents tbpOutputWindow As TabPage
    Friend WithEvents pnFormatOptions As Panel
    Friend WithEvents rtbCommentPreview As RichTextBox
    Friend WithEvents rtbOutputPreview As RichTextBox
    Friend WithEvents rtbCommandPreview As RichTextBox
    Friend WithEvents cmdCommandFormat As Button
    Friend WithEvents lblCommentFormat As Label
    Friend WithEvents cmdOutputFormat As Button
    Friend WithEvents lblOutputFormat As Label
    Friend WithEvents cmdCommentFormat As Button
    Friend WithEvents lblCommandFormat As Label
    Friend WithEvents tbpEditor As TabPage
    Friend WithEvents pnFormatEditor As Panel
    Friend WithEvents cmdEditorFont As Button
    Friend WithEvents lblFont As Label
    Friend WithEvents tbpCommands As TabPage
    Friend WithEvents pnScriptOptions As Panel
    Friend WithEvents chkIncludeDefaultParams As CheckBox
    Friend WithEvents tbpDataView As TabPage
    Friend WithEvents lblMaxRows As Label
    Friend WithEvents nudMaxRows As NumericUpDown
    Friend WithEvents tbpWorkingDirectory As TabPage
    Friend WithEvents cmdWorkingDirectory As Button
    Friend WithEvents ucrWorkingDirectory As ucrInputTextBox
    Friend WithEvents lblWorkingDirectory As Label
    Friend WithEvents trOptions As TreeView
    Friend WithEvents spltControls As SplitContainer
End Class
