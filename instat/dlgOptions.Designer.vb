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
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Languages")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comments")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Data")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("R Script")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("R Output")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comments")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Formatting Options", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Load Settings")
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.tbpRScript = New System.Windows.Forms.TabPage()
        Me.pnRScript = New System.Windows.Forms.Panel()
        Me.cmdScript = New System.Windows.Forms.Button()
        Me.lblScript = New System.Windows.Forms.Label()
        Me.tbpROutput = New System.Windows.Forms.TabPage()
        Me.pnRoutput = New System.Windows.Forms.Panel()
        Me.cmdOutput = New System.Windows.Forms.Button()
        Me.lblROutput = New System.Windows.Forms.Label()
        Me.cmdScriptChange = New System.Windows.Forms.Button()
        Me.pnCommentFormat = New System.Windows.Forms.Panel()
        Me.cmdRComments = New System.Windows.Forms.Button()
        Me.lblRComments = New System.Windows.Forms.Label()
        Me.tbpRScriptOptions = New System.Windows.Forms.TabPage()
        Me.pnScriptOptions = New System.Windows.Forms.Panel()
        Me.chkIncludeDefaultParams = New System.Windows.Forms.CheckBox()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.tbpComment = New System.Windows.Forms.TabPage()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.tbpLanguageSettings = New System.Windows.Forms.TabPage()
        Me.pnLanguages = New System.Windows.Forms.Panel()
        Me.rdoEnglish = New System.Windows.Forms.RadioButton()
        Me.rdoFrench = New System.Windows.Forms.RadioButton()
        Me.rdoKiswahili = New System.Windows.Forms.RadioButton()
        Me.spltControls = New System.Windows.Forms.SplitContainer()
        Me.trOptions = New System.Windows.Forms.TreeView()
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpGeneral = New System.Windows.Forms.TabPage()
        Me.pnGeneral = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.tbpComments = New System.Windows.Forms.TabPage()
        Me.pnComments = New System.Windows.Forms.Panel()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.tbpImport = New System.Windows.Forms.TabPage()
        Me.pnImportData = New System.Windows.Forms.Panel()
        Me.lblShowLines = New System.Windows.Forms.Label()
        Me.nudNoLines = New System.Windows.Forms.NumericUpDown()
        Me.tbpFormat = New System.Windows.Forms.TabPage()
        Me.pnFormatOptions = New System.Windows.Forms.Panel()
        Me.cmdOutputChange = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdCommentsChange = New System.Windows.Forms.Button()
        Me.lblRScript = New System.Windows.Forms.Label()
        Me.tbpRScript.SuspendLayout()
        Me.pnRScript.SuspendLayout()
        Me.tbpROutput.SuspendLayout()
        Me.pnRoutput.SuspendLayout()
        Me.pnCommentFormat.SuspendLayout()
        Me.tbpRScriptOptions.SuspendLayout()
        Me.pnScriptOptions.SuspendLayout()
        Me.tbpComment.SuspendLayout()
        Me.tbpLanguageSettings.SuspendLayout()
        Me.pnLanguages.SuspendLayout()
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltControls.Panel1.SuspendLayout()
        Me.spltControls.Panel2.SuspendLayout()
        Me.spltControls.SuspendLayout()
        Me.tbcOptions.SuspendLayout()
        Me.tbpGeneral.SuspendLayout()
        Me.pnGeneral.SuspendLayout()
        Me.tbpComments.SuspendLayout()
        Me.pnComments.SuspendLayout()
        Me.tbpImport.SuspendLayout()
        Me.pnImportData.SuspendLayout()
        CType(Me.nudNoLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpFormat.SuspendLayout()
        Me.pnFormatOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(13, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(333, 15)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Preview and Set the Font and Color Formats for the following Options"
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(456, 320)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 10
        Me.cmdApply.Tag = "Apply"
        Me.cmdApply.Text = "&Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'tbpRScript
        '
        Me.tbpRScript.Controls.Add(Me.pnRScript)
        Me.tbpRScript.Location = New System.Drawing.Point(4, 22)
        Me.tbpRScript.Name = "tbpRScript"
        Me.tbpRScript.Size = New System.Drawing.Size(420, 291)
        Me.tbpRScript.TabIndex = 7
        Me.tbpRScript.Text = "R Script"
        Me.tbpRScript.UseVisualStyleBackColor = True
        '
        'pnRScript
        '
        Me.pnRScript.AutoSize = True
        Me.pnRScript.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnRScript.Controls.Add(Me.cmdScript)
        Me.pnRScript.Controls.Add(Me.lblScript)
        Me.pnRScript.Location = New System.Drawing.Point(3, 3)
        Me.pnRScript.Name = "pnRScript"
        Me.pnRScript.Size = New System.Drawing.Size(186, 26)
        Me.pnRScript.TabIndex = 0
        '
        'cmdScript
        '
        Me.cmdScript.Location = New System.Drawing.Point(83, 0)
        Me.cmdScript.Name = "cmdScript"
        Me.cmdScript.Size = New System.Drawing.Size(100, 23)
        Me.cmdScript.TabIndex = 18
        Me.cmdScript.Text = "Preview Settings"
        Me.cmdScript.UseVisualStyleBackColor = True
        '
        'lblScript
        '
        Me.lblScript.AutoSize = True
        Me.lblScript.Location = New System.Drawing.Point(4, 10)
        Me.lblScript.Name = "lblScript"
        Me.lblScript.Size = New System.Drawing.Size(45, 13)
        Me.lblScript.TabIndex = 19
        Me.lblScript.Text = "R Script"
        '
        'tbpROutput
        '
        Me.tbpROutput.Controls.Add(Me.pnRoutput)
        Me.tbpROutput.Location = New System.Drawing.Point(4, 22)
        Me.tbpROutput.Name = "tbpROutput"
        Me.tbpROutput.Size = New System.Drawing.Size(420, 291)
        Me.tbpROutput.TabIndex = 6
        Me.tbpROutput.Text = "R Output"
        Me.tbpROutput.UseVisualStyleBackColor = True
        '
        'pnRoutput
        '
        Me.pnRoutput.AutoSize = True
        Me.pnRoutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnRoutput.Controls.Add(Me.cmdOutput)
        Me.pnRoutput.Controls.Add(Me.lblROutput)
        Me.pnRoutput.Location = New System.Drawing.Point(3, 3)
        Me.pnRoutput.Name = "pnRoutput"
        Me.pnRoutput.Size = New System.Drawing.Size(185, 29)
        Me.pnRoutput.TabIndex = 21
        '
        'cmdOutput
        '
        Me.cmdOutput.Location = New System.Drawing.Point(82, 3)
        Me.cmdOutput.Name = "cmdOutput"
        Me.cmdOutput.Size = New System.Drawing.Size(100, 23)
        Me.cmdOutput.TabIndex = 19
        Me.cmdOutput.Text = "Preview Settings"
        Me.cmdOutput.UseVisualStyleBackColor = True
        '
        'lblROutput
        '
        Me.lblROutput.AutoSize = True
        Me.lblROutput.Location = New System.Drawing.Point(3, 13)
        Me.lblROutput.Name = "lblROutput"
        Me.lblROutput.Size = New System.Drawing.Size(50, 13)
        Me.lblROutput.TabIndex = 20
        Me.lblROutput.Text = "R Output"
        '
        'cmdScriptChange
        '
        Me.cmdScriptChange.Location = New System.Drawing.Point(92, 43)
        Me.cmdScriptChange.Name = "cmdScriptChange"
        Me.cmdScriptChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdScriptChange.TabIndex = 10
        Me.cmdScriptChange.Text = "Preview Settings"
        Me.cmdScriptChange.UseVisualStyleBackColor = True
        '
        'pnCommentFormat
        '
        Me.pnCommentFormat.AutoSize = True
        Me.pnCommentFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnCommentFormat.Controls.Add(Me.cmdRComments)
        Me.pnCommentFormat.Controls.Add(Me.lblRComments)
        Me.pnCommentFormat.Location = New System.Drawing.Point(3, 3)
        Me.pnCommentFormat.Name = "pnCommentFormat"
        Me.pnCommentFormat.Size = New System.Drawing.Size(184, 26)
        Me.pnCommentFormat.TabIndex = 22
        '
        'cmdRComments
        '
        Me.cmdRComments.Location = New System.Drawing.Point(81, 0)
        Me.cmdRComments.Name = "cmdRComments"
        Me.cmdRComments.Size = New System.Drawing.Size(100, 23)
        Me.cmdRComments.TabIndex = 20
        Me.cmdRComments.Text = "Preview Settings"
        Me.cmdRComments.UseVisualStyleBackColor = True
        '
        'lblRComments
        '
        Me.lblRComments.AutoSize = True
        Me.lblRComments.Location = New System.Drawing.Point(2, 10)
        Me.lblRComments.Name = "lblRComments"
        Me.lblRComments.Size = New System.Drawing.Size(56, 13)
        Me.lblRComments.TabIndex = 21
        Me.lblRComments.Text = "Comments"
        '
        'tbpRScriptOptions
        '
        Me.tbpRScriptOptions.Controls.Add(Me.pnScriptOptions)
        Me.tbpRScriptOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbpRScriptOptions.Name = "tbpRScriptOptions"
        Me.tbpRScriptOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRScriptOptions.Size = New System.Drawing.Size(420, 291)
        Me.tbpRScriptOptions.TabIndex = 4
        Me.tbpRScriptOptions.Tag = "R_Script_Options"
        Me.tbpRScriptOptions.Text = "R Script Options"
        Me.tbpRScriptOptions.UseVisualStyleBackColor = True
        '
        'pnScriptOptions
        '
        Me.pnScriptOptions.AutoSize = True
        Me.pnScriptOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnScriptOptions.Controls.Add(Me.chkIncludeDefaultParams)
        Me.pnScriptOptions.Location = New System.Drawing.Point(3, 6)
        Me.pnScriptOptions.Name = "pnScriptOptions"
        Me.pnScriptOptions.Size = New System.Drawing.Size(242, 23)
        Me.pnScriptOptions.TabIndex = 1
        '
        'chkIncludeDefaultParams
        '
        Me.chkIncludeDefaultParams.AutoSize = True
        Me.chkIncludeDefaultParams.Location = New System.Drawing.Point(3, 3)
        Me.chkIncludeDefaultParams.Name = "chkIncludeDefaultParams"
        Me.chkIncludeDefaultParams.Size = New System.Drawing.Size(236, 17)
        Me.chkIncludeDefaultParams.TabIndex = 0
        Me.chkIncludeDefaultParams.Tag = "Include_Default_Parameter_Values_in_R_Script"
        Me.chkIncludeDefaultParams.Text = "Include Default Parameter Values in R Script"
        Me.chkIncludeDefaultParams.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(358, 320)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 12
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "&Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(249, 320)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'tbpComment
        '
        Me.tbpComment.Controls.Add(Me.pnCommentFormat)
        Me.tbpComment.Location = New System.Drawing.Point(4, 22)
        Me.tbpComment.Name = "tbpComment"
        Me.tbpComment.Size = New System.Drawing.Size(420, 291)
        Me.tbpComment.TabIndex = 8
        Me.tbpComment.Text = "Comments"
        Me.tbpComment.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(154, 320)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(13, 131)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(56, 13)
        Me.lblComments.TabIndex = 19
        Me.lblComments.Text = "Comments"
        '
        'tbpLanguageSettings
        '
        Me.tbpLanguageSettings.Controls.Add(Me.pnLanguages)
        Me.tbpLanguageSettings.Location = New System.Drawing.Point(4, 22)
        Me.tbpLanguageSettings.Name = "tbpLanguageSettings"
        Me.tbpLanguageSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLanguageSettings.Size = New System.Drawing.Size(420, 291)
        Me.tbpLanguageSettings.TabIndex = 0
        Me.tbpLanguageSettings.Tag = "Language_Settings"
        Me.tbpLanguageSettings.Text = "Language Settings"
        Me.tbpLanguageSettings.UseVisualStyleBackColor = True
        '
        'pnLanguages
        '
        Me.pnLanguages.AutoSize = True
        Me.pnLanguages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnLanguages.Controls.Add(Me.rdoEnglish)
        Me.pnLanguages.Controls.Add(Me.rdoFrench)
        Me.pnLanguages.Controls.Add(Me.rdoKiswahili)
        Me.pnLanguages.Location = New System.Drawing.Point(6, 6)
        Me.pnLanguages.Name = "pnLanguages"
        Me.pnLanguages.Size = New System.Drawing.Size(71, 77)
        Me.pnLanguages.TabIndex = 1
        '
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Checked = True
        Me.rdoEnglish.Location = New System.Drawing.Point(3, 57)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rdoEnglish.TabIndex = 1
        Me.rdoEnglish.TabStop = True
        Me.rdoEnglish.Tag = "English"
        Me.rdoEnglish.Text = "English"
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'rdoFrench
        '
        Me.rdoFrench.AutoSize = True
        Me.rdoFrench.Location = New System.Drawing.Point(3, 34)
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
        Me.rdoKiswahili.Location = New System.Drawing.Point(3, 11)
        Me.rdoKiswahili.Name = "rdoKiswahili"
        Me.rdoKiswahili.Size = New System.Drawing.Size(65, 17)
        Me.rdoKiswahili.TabIndex = 3
        Me.rdoKiswahili.Tag = "Kiswahili"
        Me.rdoKiswahili.Text = "Kiswahili"
        Me.rdoKiswahili.UseVisualStyleBackColor = True
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
        Me.spltControls.Size = New System.Drawing.Size(570, 317)
        Me.spltControls.SplitterDistance = 138
        Me.spltControls.TabIndex = 8
        '
        'trOptions
        '
        Me.trOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trOptions.Location = New System.Drawing.Point(0, 0)
        Me.trOptions.Name = "trOptions"
        TreeNode10.Name = "ndGeneral"
        TreeNode10.Tag = "0"
        TreeNode10.Text = "General"
        TreeNode10.ToolTipText = "General Options"
        TreeNode11.Name = "ndLanguages"
        TreeNode11.Tag = "1"
        TreeNode11.Text = "Languages"
        TreeNode11.ToolTipText = "Choose different languages"
        TreeNode12.Name = "ndComments"
        TreeNode12.Tag = "2"
        TreeNode12.Text = "Comments"
        TreeNode12.ToolTipText = "Comments for the dialogs"
        TreeNode13.Name = "ndImportData"
        TreeNode13.Tag = "3"
        TreeNode13.Text = "Import Data"
        TreeNode13.ToolTipText = "Import Data Settings"
        TreeNode14.Name = "ndRscript"
        TreeNode14.Tag = "5"
        TreeNode14.Text = "R Script"
        TreeNode14.ToolTipText = "R Script options"
        TreeNode15.Name = "ndRoutPut"
        TreeNode15.Tag = "6"
        TreeNode15.Text = "R Output"
        TreeNode15.ToolTipText = "R Output options"
        TreeNode16.Name = "ndCommentsFormat"
        TreeNode16.Tag = "7"
        TreeNode16.Text = "Comments"
        TreeNode16.ToolTipText = "Comments formatting options"
        TreeNode17.Name = "ndFormat"
        TreeNode17.Tag = "4"
        TreeNode17.Text = "Formatting Options"
        TreeNode17.ToolTipText = "Format Options"
        TreeNode18.Name = "ndLoad Settings"
        TreeNode18.Tag = "8"
        TreeNode18.Text = "Load Settings"
        TreeNode18.ToolTipText = "Load Settings"
        Me.trOptions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode17, TreeNode18})
        Me.trOptions.Size = New System.Drawing.Size(138, 317)
        Me.trOptions.TabIndex = 0
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpGeneral)
        Me.tbcOptions.Controls.Add(Me.tbpLanguageSettings)
        Me.tbcOptions.Controls.Add(Me.tbpComments)
        Me.tbcOptions.Controls.Add(Me.tbpImport)
        Me.tbcOptions.Controls.Add(Me.tbpFormat)
        Me.tbcOptions.Controls.Add(Me.tbpRScript)
        Me.tbcOptions.Controls.Add(Me.tbpROutput)
        Me.tbcOptions.Controls.Add(Me.tbpComment)
        Me.tbcOptions.Controls.Add(Me.tbpRScriptOptions)
        Me.tbcOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcOptions.Location = New System.Drawing.Point(0, 0)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(428, 317)
        Me.tbcOptions.TabIndex = 0
        '
        'tbpGeneral
        '
        Me.tbpGeneral.Controls.Add(Me.pnGeneral)
        Me.tbpGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tbpGeneral.Name = "tbpGeneral"
        Me.tbpGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGeneral.Size = New System.Drawing.Size(420, 291)
        Me.tbpGeneral.TabIndex = 5
        Me.tbpGeneral.Tag = "General"
        Me.tbpGeneral.Text = "General"
        Me.tbpGeneral.UseVisualStyleBackColor = True
        '
        'pnGeneral
        '
        Me.pnGeneral.AutoSize = True
        Me.pnGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnGeneral.Controls.Add(Me.lblWelcome)
        Me.pnGeneral.Location = New System.Drawing.Point(6, 6)
        Me.pnGeneral.Name = "pnGeneral"
        Me.pnGeneral.Size = New System.Drawing.Size(58, 22)
        Me.pnGeneral.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(3, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(52, 13)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome"
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
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(59, 10)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(276, 20)
        Me.txtComment.TabIndex = 1
        '
        'tbpImport
        '
        Me.tbpImport.Controls.Add(Me.pnImportData)
        Me.tbpImport.Location = New System.Drawing.Point(4, 22)
        Me.tbpImport.Name = "tbpImport"
        Me.tbpImport.Size = New System.Drawing.Size(420, 291)
        Me.tbpImport.TabIndex = 3
        Me.tbpImport.Text = "Import Data"
        Me.tbpImport.UseVisualStyleBackColor = True
        '
        'pnImportData
        '
        Me.pnImportData.AutoSize = True
        Me.pnImportData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnImportData.Controls.Add(Me.lblShowLines)
        Me.pnImportData.Controls.Add(Me.nudNoLines)
        Me.pnImportData.Location = New System.Drawing.Point(3, 3)
        Me.pnImportData.Name = "pnImportData"
        Me.pnImportData.Size = New System.Drawing.Size(304, 32)
        Me.pnImportData.TabIndex = 2
        '
        'lblShowLines
        '
        Me.lblShowLines.AutoSize = True
        Me.lblShowLines.Location = New System.Drawing.Point(3, 9)
        Me.lblShowLines.Name = "lblShowLines"
        Me.lblShowLines.Size = New System.Drawing.Size(158, 13)
        Me.lblShowLines.TabIndex = 0
        Me.lblShowLines.Text = "Number of lines to show on load"
        '
        'nudNoLines
        '
        Me.nudNoLines.Location = New System.Drawing.Point(226, 9)
        Me.nudNoLines.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNoLines.Name = "nudNoLines"
        Me.nudNoLines.Size = New System.Drawing.Size(75, 20)
        Me.nudNoLines.TabIndex = 1
        Me.nudNoLines.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'tbpFormat
        '
        Me.tbpFormat.Controls.Add(Me.pnFormatOptions)
        Me.tbpFormat.Location = New System.Drawing.Point(4, 22)
        Me.tbpFormat.Name = "tbpFormat"
        Me.tbpFormat.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFormat.Size = New System.Drawing.Size(420, 291)
        Me.tbpFormat.TabIndex = 2
        Me.tbpFormat.Text = "Format Options"
        Me.tbpFormat.UseVisualStyleBackColor = True
        '
        'pnFormatOptions
        '
        Me.pnFormatOptions.AutoSize = True
        Me.pnFormatOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnFormatOptions.Controls.Add(Me.lblTitle)
        Me.pnFormatOptions.Controls.Add(Me.cmdScriptChange)
        Me.pnFormatOptions.Controls.Add(Me.lblComments)
        Me.pnFormatOptions.Controls.Add(Me.cmdOutputChange)
        Me.pnFormatOptions.Controls.Add(Me.lblOutput)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommentsChange)
        Me.pnFormatOptions.Controls.Add(Me.lblRScript)
        Me.pnFormatOptions.Location = New System.Drawing.Point(6, 6)
        Me.pnFormatOptions.Name = "pnFormatOptions"
        Me.pnFormatOptions.Size = New System.Drawing.Size(349, 147)
        Me.pnFormatOptions.TabIndex = 21
        '
        'cmdOutputChange
        '
        Me.cmdOutputChange.Location = New System.Drawing.Point(92, 82)
        Me.cmdOutputChange.Name = "cmdOutputChange"
        Me.cmdOutputChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdOutputChange.TabIndex = 16
        Me.cmdOutputChange.Text = "Preview Settings"
        Me.cmdOutputChange.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(13, 92)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(50, 13)
        Me.lblOutput.TabIndex = 18
        Me.lblOutput.Text = "R Output"
        '
        'cmdCommentsChange
        '
        Me.cmdCommentsChange.Location = New System.Drawing.Point(92, 121)
        Me.cmdCommentsChange.Name = "cmdCommentsChange"
        Me.cmdCommentsChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommentsChange.TabIndex = 16
        Me.cmdCommentsChange.Text = "Preview Settings"
        Me.cmdCommentsChange.UseVisualStyleBackColor = True
        '
        'lblRScript
        '
        Me.lblRScript.AutoSize = True
        Me.lblRScript.Location = New System.Drawing.Point(13, 53)
        Me.lblRScript.Name = "lblRScript"
        Me.lblRScript.Size = New System.Drawing.Size(45, 13)
        Me.lblRScript.TabIndex = 17
        Me.lblRScript.Text = "R Script"
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 343)
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
        Me.tbpRScript.ResumeLayout(False)
        Me.tbpRScript.PerformLayout()
        Me.pnRScript.ResumeLayout(False)
        Me.pnRScript.PerformLayout()
        Me.tbpROutput.ResumeLayout(False)
        Me.tbpROutput.PerformLayout()
        Me.pnRoutput.ResumeLayout(False)
        Me.pnRoutput.PerformLayout()
        Me.pnCommentFormat.ResumeLayout(False)
        Me.pnCommentFormat.PerformLayout()
        Me.tbpRScriptOptions.ResumeLayout(False)
        Me.tbpRScriptOptions.PerformLayout()
        Me.pnScriptOptions.ResumeLayout(False)
        Me.pnScriptOptions.PerformLayout()
        Me.tbpComment.ResumeLayout(False)
        Me.tbpComment.PerformLayout()
        Me.tbpLanguageSettings.ResumeLayout(False)
        Me.tbpLanguageSettings.PerformLayout()
        Me.pnLanguages.ResumeLayout(False)
        Me.pnLanguages.PerformLayout()
        Me.spltControls.Panel1.ResumeLayout(False)
        Me.spltControls.Panel2.ResumeLayout(False)
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltControls.ResumeLayout(False)
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpGeneral.ResumeLayout(False)
        Me.tbpGeneral.PerformLayout()
        Me.pnGeneral.ResumeLayout(False)
        Me.pnGeneral.PerformLayout()
        Me.tbpComments.ResumeLayout(False)
        Me.tbpComments.PerformLayout()
        Me.pnComments.ResumeLayout(False)
        Me.pnComments.PerformLayout()
        Me.tbpImport.ResumeLayout(False)
        Me.tbpImport.PerformLayout()
        Me.pnImportData.ResumeLayout(False)
        Me.pnImportData.PerformLayout()
        CType(Me.nudNoLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpFormat.ResumeLayout(False)
        Me.tbpFormat.PerformLayout()
        Me.pnFormatOptions.ResumeLayout(False)
        Me.pnFormatOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpRScript As TabPage
    Friend WithEvents pnRScript As Panel
    Friend WithEvents cmdScript As Button
    Friend WithEvents lblScript As Label
    Friend WithEvents tbpROutput As TabPage
    Friend WithEvents pnRoutput As Panel
    Friend WithEvents cmdOutput As Button
    Friend WithEvents lblROutput As Label
    Friend WithEvents pnCommentFormat As Panel
    Friend WithEvents cmdRComments As Button
    Friend WithEvents lblRComments As Label
    Friend WithEvents pnScriptOptions As Panel
    Friend WithEvents tbpComment As TabPage
    Friend WithEvents pnLanguages As Panel
    Friend WithEvents spltControls As SplitContainer
    Friend WithEvents trOptions As TreeView
    Friend WithEvents tbpGeneral As TabPage
    Friend WithEvents pnGeneral As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnComments As Panel
    Friend WithEvents pnImportData As Panel
    Friend WithEvents pnFormatOptions As Panel
    Friend WithEvents lblRScript As Label
    Friend WithEvents cmdCommentsChange As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdOutputChange As Button
    Friend WithEvents tbpFormat As TabPage
    Friend WithEvents nudNoLines As NumericUpDown
    Friend WithEvents lblShowLines As Label
    Friend WithEvents tbpImport As TabPage
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents tbpComments As TabPage
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents rdoKiswahili As RadioButton
    Friend WithEvents rdoFrench As RadioButton
    Friend WithEvents rdoEnglish As RadioButton
    Friend WithEvents tbpLanguageSettings As TabPage
    Friend WithEvents lblComments As Label
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents chkIncludeDefaultParams As CheckBox
    Friend WithEvents tbpRScriptOptions As TabPage
    Friend WithEvents cmdScriptChange As Button
    Friend WithEvents cmdApply As Button
    Friend WithEvents lblTitle As Label
End Class
