' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
        Me.spltControls = New System.Windows.Forms.SplitContainer()
        Me.cmdFactoryReset = New System.Windows.Forms.Button()
        Me.trOptions = New System.Windows.Forms.TreeView()
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpLanguages = New System.Windows.Forms.TabPage()
        Me.pnLanguages = New System.Windows.Forms.Panel()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.rdoSpanish = New System.Windows.Forms.RadioButton()
        Me.rdoEnglish = New System.Windows.Forms.RadioButton()
        Me.rdoFrench = New System.Windows.Forms.RadioButton()
        Me.rdoKiswahili = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLanguage = New instat.UcrPanel()
        Me.tbpComments = New System.Windows.Forms.TabPage()
        Me.pnComments = New System.Windows.Forms.Panel()
        Me.ucrInputComment = New instat.ucrInputTextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.tbpImport = New System.Windows.Forms.TabPage()
        Me.pnImportData = New System.Windows.Forms.Panel()
        Me.ucrNudPreviewRows = New instat.ucrNud()
        Me.lblPreviewRows = New System.Windows.Forms.Label()
        Me.tbpOutputWindow = New System.Windows.Forms.TabPage()
        Me.ucrChkShowRCommandsinOutputWindow = New instat.ucrCheck()
        Me.ucrChkIncludeCommentsbyDefault = New instat.ucrCheck()
        Me.grpROptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkShowSignifStars = New instat.ucrCheck()
        Me.ucrNudDigits = New instat.ucrNud()
        Me.lblNoDigits = New System.Windows.Forms.Label()
        Me.pnFormatOptions = New System.Windows.Forms.Panel()
        Me.rtbCommentPreview = New System.Windows.Forms.RichTextBox()
        Me.rtbOutputPreview = New System.Windows.Forms.RichTextBox()
        Me.rtbCommandPreview = New System.Windows.Forms.RichTextBox()
        Me.cmdCommandFormat = New System.Windows.Forms.Button()
        Me.lblCommentFormat = New System.Windows.Forms.Label()
        Me.cmdOutputFormat = New System.Windows.Forms.Button()
        Me.lblOutputFormat = New System.Windows.Forms.Label()
        Me.cmdCommentFormat = New System.Windows.Forms.Button()
        Me.lblCommandFormat = New System.Windows.Forms.Label()
        Me.tbpEditor = New System.Windows.Forms.TabPage()
        Me.pnFormatEditor = New System.Windows.Forms.Panel()
        Me.cmdEditorFont = New System.Windows.Forms.Button()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.tbpCommands = New System.Windows.Forms.TabPage()
        Me.lblWaitSeconds = New System.Windows.Forms.Label()
        Me.ucrChkShowWaitDialog = New instat.ucrCheck()
        Me.ucrNudWaitSeconds = New instat.ucrNud()
        Me.ucrChkIncludeDefaultParams = New instat.ucrCheck()
        Me.tbpDataView = New System.Windows.Forms.TabPage()
        Me.lblEvery = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.ucrChkAutoSave = New instat.ucrCheck()
        Me.ucrChkShowDataonGrid = New instat.ucrCheck()
        Me.ucrNudMinutes = New instat.ucrNud()
        Me.ucrNudMaxCols = New instat.ucrNud()
        Me.lblMaxCols = New System.Windows.Forms.Label()
        Me.ucrNudMaxRows = New instat.ucrNud()
        Me.lblMaxRows = New System.Windows.Forms.Label()
        Me.tbpWorkingDirectory = New System.Windows.Forms.TabPage()
        Me.cmdWorkingDirectory = New System.Windows.Forms.Button()
        Me.lblWorkingDirectory = New System.Windows.Forms.Label()
        Me.ucrWorkingDirectory = New instat.ucrInputTextBox()
        Me.tbpGraphDisplay = New System.Windows.Forms.TabPage()
        Me.rdoDisplayinSeparateWindows = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayinRViewer = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayinOutputWindow = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphDisplay = New instat.UcrPanel()
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltControls.Panel1.SuspendLayout()
        Me.spltControls.Panel2.SuspendLayout()
        Me.spltControls.SuspendLayout()
        Me.tbcOptions.SuspendLayout()
        Me.tbpLanguages.SuspendLayout()
        Me.pnLanguages.SuspendLayout()
        Me.grpLanguage.SuspendLayout()
        Me.tbpComments.SuspendLayout()
        Me.pnComments.SuspendLayout()
        Me.tbpImport.SuspendLayout()
        Me.pnImportData.SuspendLayout()
        Me.tbpOutputWindow.SuspendLayout()
        Me.grpROptions.SuspendLayout()
        Me.pnFormatOptions.SuspendLayout()
        Me.tbpEditor.SuspendLayout()
        Me.pnFormatEditor.SuspendLayout()
        Me.tbpCommands.SuspendLayout()
        Me.tbpDataView.SuspendLayout()
        Me.tbpWorkingDirectory.SuspendLayout()
        Me.tbpGraphDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(396, 324)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 10
        Me.cmdApply.Tag = "Apply"
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(477, 324)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 12
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(315, 324)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(234, 324)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'spltControls
        '
        Me.spltControls.Location = New System.Drawing.Point(5, 1)
        Me.spltControls.Name = "spltControls"
        '
        'spltControls.Panel1
        '
        Me.spltControls.Panel1.Controls.Add(Me.cmdFactoryReset)
        Me.spltControls.Panel1.Controls.Add(Me.trOptions)
        '
        'spltControls.Panel2
        '
        Me.spltControls.Panel2.Controls.Add(Me.tbcOptions)
        Me.spltControls.Size = New System.Drawing.Size(760, 317)
        Me.spltControls.SplitterDistance = 184
        Me.spltControls.TabIndex = 8
        '
        'cmdFactoryReset
        '
        Me.cmdFactoryReset.Location = New System.Drawing.Point(13, 287)
        Me.cmdFactoryReset.Name = "cmdFactoryReset"
        Me.cmdFactoryReset.Size = New System.Drawing.Size(100, 23)
        Me.cmdFactoryReset.TabIndex = 13
        Me.cmdFactoryReset.Tag = "Help"
        Me.cmdFactoryReset.Text = "Factory Reset"
        Me.cmdFactoryReset.UseVisualStyleBackColor = True
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
        Me.tbcOptions.Controls.Add(Me.tbpGraphDisplay)
        Me.tbcOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcOptions.Location = New System.Drawing.Point(0, 0)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(572, 317)
        Me.tbcOptions.TabIndex = 0
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
        Me.pnLanguages.Size = New System.Drawing.Size(122, 126)
        Me.pnLanguages.TabIndex = 1
        '
        'grpLanguage
        '
        Me.grpLanguage.Controls.Add(Me.rdoSpanish)
        Me.grpLanguage.Controls.Add(Me.rdoEnglish)
        Me.grpLanguage.Controls.Add(Me.rdoFrench)
        Me.grpLanguage.Controls.Add(Me.rdoKiswahili)
        Me.grpLanguage.Controls.Add(Me.ucrPnlLanguage)
        Me.grpLanguage.Location = New System.Drawing.Point(3, 3)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(109, 113)
        Me.grpLanguage.TabIndex = 2
        Me.grpLanguage.TabStop = False
        Me.grpLanguage.Text = "Language"
        '
        'rdoSpanish
        '
        Me.rdoSpanish.AutoSize = True
        Me.rdoSpanish.Enabled = False
        Me.rdoSpanish.Location = New System.Drawing.Point(6, 84)
        Me.rdoSpanish.Name = "rdoSpanish"
        Me.rdoSpanish.Size = New System.Drawing.Size(63, 17)
        Me.rdoSpanish.TabIndex = 2
        Me.rdoSpanish.Text = "Spanish"
        Me.rdoSpanish.UseVisualStyleBackColor = True
        '
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Location = New System.Drawing.Point(6, 19)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rdoEnglish.TabIndex = 1
        Me.rdoEnglish.Tag = "English"
        Me.rdoEnglish.Text = "English"
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'rdoFrench
        '
        Me.rdoFrench.AutoSize = True
        Me.rdoFrench.Location = New System.Drawing.Point(6, 42)
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
        Me.rdoKiswahili.Location = New System.Drawing.Point(6, 65)
        Me.rdoKiswahili.Name = "rdoKiswahili"
        Me.rdoKiswahili.Size = New System.Drawing.Size(65, 17)
        Me.rdoKiswahili.TabIndex = 3
        Me.rdoKiswahili.Tag = "Kiswahili"
        Me.rdoKiswahili.Text = "Kiswahili"
        Me.rdoKiswahili.UseVisualStyleBackColor = True
        '
        'ucrPnlLanguage
        '
        Me.ucrPnlLanguage.Location = New System.Drawing.Point(0, 17)
        Me.ucrPnlLanguage.Name = "ucrPnlLanguage"
        Me.ucrPnlLanguage.Size = New System.Drawing.Size(103, 90)
        Me.ucrPnlLanguage.TabIndex = 0
        '
        'tbpComments
        '
        Me.tbpComments.Controls.Add(Me.pnComments)
        Me.tbpComments.Location = New System.Drawing.Point(4, 22)
        Me.tbpComments.Name = "tbpComments"
        Me.tbpComments.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpComments.Size = New System.Drawing.Size(564, 291)
        Me.tbpComments.TabIndex = 1
        Me.tbpComments.Tag = "Comments"
        Me.tbpComments.Text = "Comments"
        Me.tbpComments.UseVisualStyleBackColor = True
        '
        'pnComments
        '
        Me.pnComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnComments.Controls.Add(Me.ucrInputComment)
        Me.pnComments.Controls.Add(Me.lblComment)
        Me.pnComments.Location = New System.Drawing.Point(10, 10)
        Me.pnComments.Name = "pnComments"
        Me.pnComments.Size = New System.Drawing.Size(338, 29)
        Me.pnComments.TabIndex = 2
        '
        'ucrInputComment
        '
        Me.ucrInputComment.AddQuotesIfUnrecognised = True
        Me.ucrInputComment.IsMultiline = False
        Me.ucrInputComment.IsReadOnly = False
        Me.ucrInputComment.Location = New System.Drawing.Point(58, 5)
        Me.ucrInputComment.Name = "ucrInputComment"
        Me.ucrInputComment.Size = New System.Drawing.Size(277, 21)
        Me.ucrInputComment.TabIndex = 1
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(2, 9)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(54, 13)
        Me.lblComment.TabIndex = 0
        Me.lblComment.Tag = "Comment:"
        Me.lblComment.Text = "Comment:"
        '
        'tbpImport
        '
        Me.tbpImport.Controls.Add(Me.pnImportData)
        Me.tbpImport.Location = New System.Drawing.Point(4, 22)
        Me.tbpImport.Name = "tbpImport"
        Me.tbpImport.Size = New System.Drawing.Size(564, 291)
        Me.tbpImport.TabIndex = 3
        Me.tbpImport.Text = "Import"
        Me.tbpImport.UseVisualStyleBackColor = True
        '
        'pnImportData
        '
        Me.pnImportData.AutoSize = True
        Me.pnImportData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnImportData.Controls.Add(Me.ucrNudPreviewRows)
        Me.pnImportData.Controls.Add(Me.lblPreviewRows)
        Me.pnImportData.Location = New System.Drawing.Point(10, 10)
        Me.pnImportData.Name = "pnImportData"
        Me.pnImportData.Size = New System.Drawing.Size(186, 28)
        Me.pnImportData.TabIndex = 2
        '
        'ucrNudPreviewRows
        '
        Me.ucrNudPreviewRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreviewRows.Location = New System.Drawing.Point(133, 5)
        Me.ucrNudPreviewRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreviewRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewRows.Name = "ucrNudPreviewRows"
        Me.ucrNudPreviewRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreviewRows.TabIndex = 3
        Me.ucrNudPreviewRows.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblPreviewRows
        '
        Me.lblPreviewRows.AutoSize = True
        Me.lblPreviewRows.Location = New System.Drawing.Point(3, 9)
        Me.lblPreviewRows.Name = "lblPreviewRows"
        Me.lblPreviewRows.Size = New System.Drawing.Size(130, 13)
        Me.lblPreviewRows.TabIndex = 0
        Me.lblPreviewRows.Text = "Number of Preview Rows:"
        '
        'tbpOutputWindow
        '
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkShowRCommandsinOutputWindow)
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkIncludeCommentsbyDefault)
        Me.tbpOutputWindow.Controls.Add(Me.grpROptions)
        Me.tbpOutputWindow.Controls.Add(Me.pnFormatOptions)
        Me.tbpOutputWindow.Location = New System.Drawing.Point(4, 22)
        Me.tbpOutputWindow.Name = "tbpOutputWindow"
        Me.tbpOutputWindow.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOutputWindow.Size = New System.Drawing.Size(564, 291)
        Me.tbpOutputWindow.TabIndex = 2
        Me.tbpOutputWindow.Text = "Output Window"
        Me.tbpOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrChkShowRCommandsinOutputWindow
        '
        Me.ucrChkShowRCommandsinOutputWindow.Checked = False
        Me.ucrChkShowRCommandsinOutputWindow.Location = New System.Drawing.Point(10, 168)
        Me.ucrChkShowRCommandsinOutputWindow.Name = "ucrChkShowRCommandsinOutputWindow"
        Me.ucrChkShowRCommandsinOutputWindow.Size = New System.Drawing.Size(271, 20)
        Me.ucrChkShowRCommandsinOutputWindow.TabIndex = 27
        '
        'ucrChkIncludeCommentsbyDefault
        '
        Me.ucrChkIncludeCommentsbyDefault.Checked = False
        Me.ucrChkIncludeCommentsbyDefault.Location = New System.Drawing.Point(10, 145)
        Me.ucrChkIncludeCommentsbyDefault.Name = "ucrChkIncludeCommentsbyDefault"
        Me.ucrChkIncludeCommentsbyDefault.Size = New System.Drawing.Size(271, 20)
        Me.ucrChkIncludeCommentsbyDefault.TabIndex = 26
        '
        'grpROptions
        '
        Me.grpROptions.Controls.Add(Me.ucrChkShowSignifStars)
        Me.grpROptions.Controls.Add(Me.ucrNudDigits)
        Me.grpROptions.Controls.Add(Me.lblNoDigits)
        Me.grpROptions.Location = New System.Drawing.Point(10, 192)
        Me.grpROptions.Name = "grpROptions"
        Me.grpROptions.Size = New System.Drawing.Size(271, 93)
        Me.grpROptions.TabIndex = 25
        Me.grpROptions.TabStop = False
        Me.grpROptions.Text = "R Options"
        '
        'ucrChkShowSignifStars
        '
        Me.ucrChkShowSignifStars.Checked = False
        Me.ucrChkShowSignifStars.Location = New System.Drawing.Point(7, 49)
        Me.ucrChkShowSignifStars.Name = "ucrChkShowSignifStars"
        Me.ucrChkShowSignifStars.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkShowSignifStars.TabIndex = 28
        '
        'ucrNudDigits
        '
        Me.ucrNudDigits.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDigits.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDigits.Location = New System.Drawing.Point(152, 21)
        Me.ucrNudDigits.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDigits.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDigits.Name = "ucrNudDigits"
        Me.ucrNudDigits.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDigits.TabIndex = 27
        Me.ucrNudDigits.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNoDigits
        '
        Me.lblNoDigits.AutoSize = True
        Me.lblNoDigits.Location = New System.Drawing.Point(6, 23)
        Me.lblNoDigits.Name = "lblNoDigits"
        Me.lblNoDigits.Size = New System.Drawing.Size(137, 13)
        Me.lblNoDigits.TabIndex = 1
        Me.lblNoDigits.Text = "Number of Digits to Display:"
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
        Me.pnFormatOptions.Location = New System.Drawing.Point(10, 10)
        Me.pnFormatOptions.Name = "pnFormatOptions"
        Me.pnFormatOptions.Size = New System.Drawing.Size(391, 118)
        Me.pnFormatOptions.TabIndex = 21
        '
        'rtbCommentPreview
        '
        Me.rtbCommentPreview.Location = New System.Drawing.Point(100, 89)
        Me.rtbCommentPreview.Name = "rtbCommentPreview"
        Me.rtbCommentPreview.ReadOnly = True
        Me.rtbCommentPreview.Size = New System.Drawing.Size(171, 26)
        Me.rtbCommentPreview.TabIndex = 22
        Me.rtbCommentPreview.Text = ""
        '
        'rtbOutputPreview
        '
        Me.rtbOutputPreview.Location = New System.Drawing.Point(100, 49)
        Me.rtbOutputPreview.Name = "rtbOutputPreview"
        Me.rtbOutputPreview.ReadOnly = True
        Me.rtbOutputPreview.Size = New System.Drawing.Size(171, 26)
        Me.rtbOutputPreview.TabIndex = 21
        Me.rtbOutputPreview.Text = ""
        '
        'rtbCommandPreview
        '
        Me.rtbCommandPreview.Location = New System.Drawing.Point(100, 9)
        Me.rtbCommandPreview.Name = "rtbCommandPreview"
        Me.rtbCommandPreview.ReadOnly = True
        Me.rtbCommandPreview.Size = New System.Drawing.Size(171, 26)
        Me.rtbCommandPreview.TabIndex = 20
        Me.rtbCommandPreview.Text = ""
        '
        'cmdCommandFormat
        '
        Me.cmdCommandFormat.Location = New System.Drawing.Point(288, 9)
        Me.cmdCommandFormat.Name = "cmdCommandFormat"
        Me.cmdCommandFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommandFormat.TabIndex = 10
        Me.cmdCommandFormat.Text = "Change..."
        Me.cmdCommandFormat.UseVisualStyleBackColor = True
        '
        'lblCommentFormat
        '
        Me.lblCommentFormat.AutoSize = True
        Me.lblCommentFormat.Location = New System.Drawing.Point(4, 94)
        Me.lblCommentFormat.Name = "lblCommentFormat"
        Me.lblCommentFormat.Size = New System.Drawing.Size(89, 13)
        Me.lblCommentFormat.TabIndex = 19
        Me.lblCommentFormat.Text = "Comment Format:"
        '
        'cmdOutputFormat
        '
        Me.cmdOutputFormat.Location = New System.Drawing.Point(288, 49)
        Me.cmdOutputFormat.Name = "cmdOutputFormat"
        Me.cmdOutputFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdOutputFormat.TabIndex = 16
        Me.cmdOutputFormat.Text = "Change..."
        Me.cmdOutputFormat.UseVisualStyleBackColor = True
        '
        'lblOutputFormat
        '
        Me.lblOutputFormat.AutoSize = True
        Me.lblOutputFormat.Location = New System.Drawing.Point(4, 54)
        Me.lblOutputFormat.Name = "lblOutputFormat"
        Me.lblOutputFormat.Size = New System.Drawing.Size(77, 13)
        Me.lblOutputFormat.TabIndex = 18
        Me.lblOutputFormat.Text = "Output Format:"
        '
        'cmdCommentFormat
        '
        Me.cmdCommentFormat.Location = New System.Drawing.Point(288, 89)
        Me.cmdCommentFormat.Name = "cmdCommentFormat"
        Me.cmdCommentFormat.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommentFormat.TabIndex = 16
        Me.cmdCommentFormat.Text = "Change..."
        Me.cmdCommentFormat.UseVisualStyleBackColor = True
        '
        'lblCommandFormat
        '
        Me.lblCommandFormat.AutoSize = True
        Me.lblCommandFormat.Location = New System.Drawing.Point(4, 14)
        Me.lblCommandFormat.Name = "lblCommandFormat"
        Me.lblCommandFormat.Size = New System.Drawing.Size(92, 13)
        Me.lblCommandFormat.TabIndex = 17
        Me.lblCommandFormat.Text = "Command Format:"
        '
        'tbpEditor
        '
        Me.tbpEditor.Controls.Add(Me.pnFormatEditor)
        Me.tbpEditor.Location = New System.Drawing.Point(4, 22)
        Me.tbpEditor.Name = "tbpEditor"
        Me.tbpEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEditor.Size = New System.Drawing.Size(564, 291)
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
        Me.pnFormatEditor.Location = New System.Drawing.Point(10, 10)
        Me.pnFormatEditor.Name = "pnFormatEditor"
        Me.pnFormatEditor.Size = New System.Drawing.Size(212, 28)
        Me.pnFormatEditor.TabIndex = 22
        '
        'cmdEditorFont
        '
        Me.cmdEditorFont.Location = New System.Drawing.Point(109, 2)
        Me.cmdEditorFont.Name = "cmdEditorFont"
        Me.cmdEditorFont.Size = New System.Drawing.Size(100, 23)
        Me.cmdEditorFont.TabIndex = 10
        Me.cmdEditorFont.Text = "Change..."
        Me.cmdEditorFont.UseVisualStyleBackColor = True
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(4, 7)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(66, 13)
        Me.lblFont.TabIndex = 17
        Me.lblFont.Text = "Format Font:"
        '
        'tbpCommands
        '
        Me.tbpCommands.Controls.Add(Me.lblWaitSeconds)
        Me.tbpCommands.Controls.Add(Me.ucrChkShowWaitDialog)
        Me.tbpCommands.Controls.Add(Me.ucrNudWaitSeconds)
        Me.tbpCommands.Controls.Add(Me.ucrChkIncludeDefaultParams)
        Me.tbpCommands.Location = New System.Drawing.Point(4, 22)
        Me.tbpCommands.Name = "tbpCommands"
        Me.tbpCommands.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCommands.Size = New System.Drawing.Size(564, 291)
        Me.tbpCommands.TabIndex = 4
        Me.tbpCommands.Tag = "Commands"
        Me.tbpCommands.Text = "Commands"
        Me.tbpCommands.UseVisualStyleBackColor = True
        '
        'lblWaitSeconds
        '
        Me.lblWaitSeconds.AutoSize = True
        Me.lblWaitSeconds.Location = New System.Drawing.Point(357, 50)
        Me.lblWaitSeconds.Name = "lblWaitSeconds"
        Me.lblWaitSeconds.Size = New System.Drawing.Size(47, 13)
        Me.lblWaitSeconds.TabIndex = 8
        Me.lblWaitSeconds.Text = "seconds"
        '
        'ucrChkShowWaitDialog
        '
        Me.ucrChkShowWaitDialog.Checked = False
        Me.ucrChkShowWaitDialog.Location = New System.Drawing.Point(6, 47)
        Me.ucrChkShowWaitDialog.Name = "ucrChkShowWaitDialog"
        Me.ucrChkShowWaitDialog.Size = New System.Drawing.Size(293, 20)
        Me.ucrChkShowWaitDialog.TabIndex = 6
        '
        'ucrNudWaitSeconds
        '
        Me.ucrNudWaitSeconds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaitSeconds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaitSeconds.Location = New System.Drawing.Point(305, 47)
        Me.ucrNudWaitSeconds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaitSeconds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaitSeconds.Name = "ucrNudWaitSeconds"
        Me.ucrNudWaitSeconds.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWaitSeconds.TabIndex = 5
        Me.ucrNudWaitSeconds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkIncludeDefaultParams
        '
        Me.ucrChkIncludeDefaultParams.Checked = False
        Me.ucrChkIncludeDefaultParams.Location = New System.Drawing.Point(6, 20)
        Me.ucrChkIncludeDefaultParams.Name = "ucrChkIncludeDefaultParams"
        Me.ucrChkIncludeDefaultParams.Size = New System.Drawing.Size(261, 21)
        Me.ucrChkIncludeDefaultParams.TabIndex = 3
        '
        'tbpDataView
        '
        Me.tbpDataView.Controls.Add(Me.lblEvery)
        Me.tbpDataView.Controls.Add(Me.lblMinutes)
        Me.tbpDataView.Controls.Add(Me.ucrChkAutoSave)
        Me.tbpDataView.Controls.Add(Me.ucrChkShowDataonGrid)
        Me.tbpDataView.Controls.Add(Me.ucrNudMinutes)
        Me.tbpDataView.Controls.Add(Me.ucrNudMaxCols)
        Me.tbpDataView.Controls.Add(Me.lblMaxCols)
        Me.tbpDataView.Controls.Add(Me.ucrNudMaxRows)
        Me.tbpDataView.Controls.Add(Me.lblMaxRows)
        Me.tbpDataView.Location = New System.Drawing.Point(4, 22)
        Me.tbpDataView.Name = "tbpDataView"
        Me.tbpDataView.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDataView.Size = New System.Drawing.Size(564, 291)
        Me.tbpDataView.TabIndex = 9
        Me.tbpDataView.Text = "Data View"
        Me.tbpDataView.UseVisualStyleBackColor = True
        '
        'lblEvery
        '
        Me.lblEvery.AutoSize = True
        Me.lblEvery.Location = New System.Drawing.Point(255, 104)
        Me.lblEvery.Name = "lblEvery"
        Me.lblEvery.Size = New System.Drawing.Size(34, 13)
        Me.lblEvery.TabIndex = 4
        Me.lblEvery.Text = "Every"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(362, 104)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutes.TabIndex = 4
        Me.lblMinutes.Text = "Minutes"
        '
        'ucrChkAutoSave
        '
        Me.ucrChkAutoSave.Checked = False
        Me.ucrChkAutoSave.Location = New System.Drawing.Point(13, 104)
        Me.ucrChkAutoSave.Name = "ucrChkAutoSave"
        Me.ucrChkAutoSave.Size = New System.Drawing.Size(236, 20)
        Me.ucrChkAutoSave.TabIndex = 3
        '
        'ucrChkShowDataonGrid
        '
        Me.ucrChkShowDataonGrid.Checked = False
        Me.ucrChkShowDataonGrid.Location = New System.Drawing.Point(13, 78)
        Me.ucrChkShowDataonGrid.Name = "ucrChkShowDataonGrid"
        Me.ucrChkShowDataonGrid.Size = New System.Drawing.Size(257, 20)
        Me.ucrChkShowDataonGrid.TabIndex = 3
        '
        'ucrNudMinutes
        '
        Me.ucrNudMinutes.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinutes.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinutes.Location = New System.Drawing.Point(305, 104)
        Me.ucrNudMinutes.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinutes.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinutes.Name = "ucrNudMinutes"
        Me.ucrNudMinutes.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinutes.TabIndex = 2
        Me.ucrNudMinutes.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxCols
        '
        Me.ucrNudMaxCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxCols.Location = New System.Drawing.Point(221, 41)
        Me.ucrNudMaxCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCols.Name = "ucrNudMaxCols"
        Me.ucrNudMaxCols.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxCols.TabIndex = 2
        Me.ucrNudMaxCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxCols
        '
        Me.lblMaxCols.AutoSize = True
        Me.lblMaxCols.Location = New System.Drawing.Point(10, 44)
        Me.lblMaxCols.Name = "lblMaxCols"
        Me.lblMaxCols.Size = New System.Drawing.Size(198, 13)
        Me.lblMaxCols.TabIndex = 1
        Me.lblMaxCols.Text = "Maximum Number of Columns to Display:"
        '
        'ucrNudMaxRows
        '
        Me.ucrNudMaxRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxRows.Location = New System.Drawing.Point(220, 15)
        Me.ucrNudMaxRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRows.Name = "ucrNudMaxRows"
        Me.ucrNudMaxRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxRows.TabIndex = 2
        Me.ucrNudMaxRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxRows
        '
        Me.lblMaxRows.AutoSize = True
        Me.lblMaxRows.Location = New System.Drawing.Point(10, 18)
        Me.lblMaxRows.Name = "lblMaxRows"
        Me.lblMaxRows.Size = New System.Drawing.Size(185, 13)
        Me.lblMaxRows.TabIndex = 1
        Me.lblMaxRows.Text = "Maximum Number of Rows to Display:"
        '
        'tbpWorkingDirectory
        '
        Me.tbpWorkingDirectory.Controls.Add(Me.cmdWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.lblWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.ucrWorkingDirectory)
        Me.tbpWorkingDirectory.Location = New System.Drawing.Point(4, 22)
        Me.tbpWorkingDirectory.Name = "tbpWorkingDirectory"
        Me.tbpWorkingDirectory.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpWorkingDirectory.Size = New System.Drawing.Size(564, 291)
        Me.tbpWorkingDirectory.TabIndex = 11
        Me.tbpWorkingDirectory.Text = "Working Directory"
        Me.tbpWorkingDirectory.UseVisualStyleBackColor = True
        '
        'cmdWorkingDirectory
        '
        Me.cmdWorkingDirectory.Location = New System.Drawing.Point(399, 16)
        Me.cmdWorkingDirectory.Name = "cmdWorkingDirectory"
        Me.cmdWorkingDirectory.Size = New System.Drawing.Size(24, 21)
        Me.cmdWorkingDirectory.TabIndex = 2
        Me.cmdWorkingDirectory.Text = "..."
        Me.cmdWorkingDirectory.UseVisualStyleBackColor = True
        '
        'lblWorkingDirectory
        '
        Me.lblWorkingDirectory.AutoSize = True
        Me.lblWorkingDirectory.Location = New System.Drawing.Point(13, 20)
        Me.lblWorkingDirectory.Name = "lblWorkingDirectory"
        Me.lblWorkingDirectory.Size = New System.Drawing.Size(95, 13)
        Me.lblWorkingDirectory.TabIndex = 0
        Me.lblWorkingDirectory.Text = "Working Directory:"
        '
        'ucrWorkingDirectory
        '
        Me.ucrWorkingDirectory.AddQuotesIfUnrecognised = True
        Me.ucrWorkingDirectory.IsMultiline = False
        Me.ucrWorkingDirectory.IsReadOnly = False
        Me.ucrWorkingDirectory.Location = New System.Drawing.Point(111, 17)
        Me.ucrWorkingDirectory.Name = "ucrWorkingDirectory"
        Me.ucrWorkingDirectory.Size = New System.Drawing.Size(282, 21)
        Me.ucrWorkingDirectory.TabIndex = 1
        '
        'tbpGraphDisplay
        '
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinSeparateWindows)
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinRViewer)
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinOutputWindow)
        Me.tbpGraphDisplay.Controls.Add(Me.ucrPnlGraphDisplay)
        Me.tbpGraphDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraphDisplay.Name = "tbpGraphDisplay"
        Me.tbpGraphDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGraphDisplay.Size = New System.Drawing.Size(564, 291)
        Me.tbpGraphDisplay.TabIndex = 12
        Me.tbpGraphDisplay.Text = "Graph Display"
        Me.tbpGraphDisplay.UseVisualStyleBackColor = True
        '
        'rdoDisplayinSeparateWindows
        '
        Me.rdoDisplayinSeparateWindows.AutoSize = True
        Me.rdoDisplayinSeparateWindows.Checked = True
        Me.rdoDisplayinSeparateWindows.Location = New System.Drawing.Point(6, 52)
        Me.rdoDisplayinSeparateWindows.Name = "rdoDisplayinSeparateWindows"
        Me.rdoDisplayinSeparateWindows.Size = New System.Drawing.Size(163, 17)
        Me.rdoDisplayinSeparateWindows.TabIndex = 1
        Me.rdoDisplayinSeparateWindows.TabStop = True
        Me.rdoDisplayinSeparateWindows.Text = "Display in Separate Windows"
        Me.rdoDisplayinSeparateWindows.UseVisualStyleBackColor = True
        '
        'rdoDisplayinRViewer
        '
        Me.rdoDisplayinRViewer.AutoSize = True
        Me.rdoDisplayinRViewer.Location = New System.Drawing.Point(6, 29)
        Me.rdoDisplayinRViewer.Name = "rdoDisplayinRViewer"
        Me.rdoDisplayinRViewer.Size = New System.Drawing.Size(116, 17)
        Me.rdoDisplayinRViewer.TabIndex = 1
        Me.rdoDisplayinRViewer.Text = "Display in R Viewer"
        Me.rdoDisplayinRViewer.UseVisualStyleBackColor = True
        '
        'rdoDisplayinOutputWindow
        '
        Me.rdoDisplayinOutputWindow.AutoSize = True
        Me.rdoDisplayinOutputWindow.Location = New System.Drawing.Point(6, 6)
        Me.rdoDisplayinOutputWindow.Name = "rdoDisplayinOutputWindow"
        Me.rdoDisplayinOutputWindow.Size = New System.Drawing.Size(147, 17)
        Me.rdoDisplayinOutputWindow.TabIndex = 1
        Me.rdoDisplayinOutputWindow.Text = "Display in Output Window"
        Me.rdoDisplayinOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphDisplay
        '
        Me.ucrPnlGraphDisplay.Location = New System.Drawing.Point(0, 3)
        Me.ucrPnlGraphDisplay.Name = "ucrPnlGraphDisplay"
        Me.ucrPnlGraphDisplay.Size = New System.Drawing.Size(169, 66)
        Me.ucrPnlGraphDisplay.TabIndex = 3
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 353)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.spltControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Options"
        Me.Text = "Options"
        Me.spltControls.Panel1.ResumeLayout(False)
        Me.spltControls.Panel2.ResumeLayout(False)
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltControls.ResumeLayout(False)
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpLanguages.ResumeLayout(False)
        Me.tbpLanguages.PerformLayout()
        Me.pnLanguages.ResumeLayout(False)
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        Me.tbpComments.ResumeLayout(False)
        Me.pnComments.ResumeLayout(False)
        Me.pnComments.PerformLayout()
        Me.tbpImport.ResumeLayout(False)
        Me.tbpImport.PerformLayout()
        Me.pnImportData.ResumeLayout(False)
        Me.pnImportData.PerformLayout()
        Me.tbpOutputWindow.ResumeLayout(False)
        Me.tbpOutputWindow.PerformLayout()
        Me.grpROptions.ResumeLayout(False)
        Me.grpROptions.PerformLayout()
        Me.pnFormatOptions.ResumeLayout(False)
        Me.pnFormatOptions.PerformLayout()
        Me.tbpEditor.ResumeLayout(False)
        Me.tbpEditor.PerformLayout()
        Me.pnFormatEditor.ResumeLayout(False)
        Me.pnFormatEditor.PerformLayout()
        Me.tbpCommands.ResumeLayout(False)
        Me.tbpCommands.PerformLayout()
        Me.tbpDataView.ResumeLayout(False)
        Me.tbpDataView.PerformLayout()
        Me.tbpWorkingDirectory.ResumeLayout(False)
        Me.tbpWorkingDirectory.PerformLayout()
        Me.tbpGraphDisplay.ResumeLayout(False)
        Me.tbpGraphDisplay.PerformLayout()
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
    Friend WithEvents tbpImport As TabPage
    Friend WithEvents pnImportData As Panel
    Friend WithEvents lblPreviewRows As Label
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
    Friend WithEvents tbpDataView As TabPage
    Friend WithEvents lblMaxRows As Label
    Friend WithEvents tbpWorkingDirectory As TabPage
    Friend WithEvents cmdWorkingDirectory As Button
    Friend WithEvents ucrWorkingDirectory As ucrInputTextBox
    Friend WithEvents lblWorkingDirectory As Label
    Friend WithEvents trOptions As TreeView
    Friend WithEvents spltControls As SplitContainer
    Friend WithEvents tbpGraphDisplay As TabPage
    Friend WithEvents rdoDisplayinSeparateWindows As RadioButton
    Friend WithEvents rdoDisplayinRViewer As RadioButton
    Friend WithEvents rdoDisplayinOutputWindow As RadioButton
    Friend WithEvents grpROptions As GroupBox
    Friend WithEvents lblNoDigits As Label
    Friend WithEvents cmdFactoryReset As Button
    Friend WithEvents ucrNudPreviewRows As ucrNud
    Friend WithEvents ucrNudDigits As ucrNud
    Friend WithEvents ucrChkIncludeCommentsbyDefault As ucrCheck
    Friend WithEvents ucrChkShowRCommandsinOutputWindow As ucrCheck
    Friend WithEvents ucrChkShowSignifStars As ucrCheck
    Friend WithEvents ucrChkIncludeDefaultParams As ucrCheck
    Friend WithEvents ucrNudMaxRows As ucrNud
    Friend WithEvents ucrPnlGraphDisplay As UcrPanel
    Friend WithEvents ucrPnlLanguage As UcrPanel
    Friend WithEvents ucrInputComment As ucrInputTextBox
    Friend WithEvents ucrNudMaxCols As ucrNud
    Friend WithEvents lblMaxCols As Label
    Friend WithEvents ucrChkShowDataonGrid As ucrCheck
    Friend WithEvents ucrChkAutoSave As ucrCheck
    Friend WithEvents ucrNudMinutes As ucrNud
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblEvery As Label
    Friend WithEvents lblWaitSeconds As Label
    Friend WithEvents ucrChkShowWaitDialog As ucrCheck
    Friend WithEvents ucrNudWaitSeconds As ucrNud
End Class
