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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOptions))
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.spltControls = New System.Windows.Forms.SplitContainer()
        Me.cmdFactoryReset = New System.Windows.Forms.Button()
        Me.trOptions = New System.Windows.Forms.TreeView()
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpLanguages = New System.Windows.Forms.TabPage()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.ucrInputLanguage = New instat.ucrInputComboBox()
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
        Me.ucrNudAutoSaveMinutes = New instat.ucrNud()
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
        Me.tbpTailoredMenus = New System.Windows.Forms.TabPage()
        Me.ucrChkViewStructuredMenu = New instat.ucrCheck()
        Me.ucrChkViewOptionsByContextMenu = New instat.ucrCheck()
        Me.ucrChkViewProcurementMenu = New instat.ucrCheck()
        Me.ucrChkViewClimaticMenu = New instat.ucrCheck()
        Me.tbpClimsoft = New System.Windows.Forms.TabPage()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.ucrInputUserName = New instat.ucrInputTextBox()
        Me.ucrInputPort = New instat.ucrInputTextBox()
        Me.ucrInputHost = New instat.ucrInputTextBox()
        Me.ucrInputDatabaseName = New instat.ucrInputTextBox()
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltControls.Panel1.SuspendLayout()
        Me.spltControls.Panel2.SuspendLayout()
        Me.spltControls.SuspendLayout()
        Me.tbcOptions.SuspendLayout()
        Me.tbpLanguages.SuspendLayout()
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
        Me.tbpTailoredMenus.SuspendLayout()
        Me.tbpClimsoft.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdApply
        '
        resources.ApplyResources(Me.cmdApply, "cmdApply")
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Tag = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        resources.ApplyResources(Me.cmdOk, "cmdOk")
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'spltControls
        '
        resources.ApplyResources(Me.spltControls, "spltControls")
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
        '
        'cmdFactoryReset
        '
        resources.ApplyResources(Me.cmdFactoryReset, "cmdFactoryReset")
        Me.cmdFactoryReset.Name = "cmdFactoryReset"
        Me.cmdFactoryReset.Tag = "Help"
        Me.cmdFactoryReset.UseVisualStyleBackColor = True
        '
        'trOptions
        '
        resources.ApplyResources(Me.trOptions, "trOptions")
        Me.trOptions.Name = "trOptions"
        Me.trOptions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("trOptions.Nodes"), System.Windows.Forms.TreeNode), CType(resources.GetObject("trOptions.Nodes1"), System.Windows.Forms.TreeNode), CType(resources.GetObject("trOptions.Nodes2"), System.Windows.Forms.TreeNode), CType(resources.GetObject("trOptions.Nodes3"), System.Windows.Forms.TreeNode), CType(resources.GetObject("trOptions.Nodes4"), System.Windows.Forms.TreeNode), CType(resources.GetObject("trOptions.Nodes5"), System.Windows.Forms.TreeNode)})
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
        Me.tbcOptions.Controls.Add(Me.tbpTailoredMenus)
        Me.tbcOptions.Controls.Add(Me.tbpClimsoft)
        resources.ApplyResources(Me.tbcOptions, "tbcOptions")
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        '
        'tbpLanguages
        '
        Me.tbpLanguages.Controls.Add(Me.lblLanguage)
        Me.tbpLanguages.Controls.Add(Me.ucrInputLanguage)
        resources.ApplyResources(Me.tbpLanguages, "tbpLanguages")
        Me.tbpLanguages.Name = "tbpLanguages"
        Me.tbpLanguages.Tag = "Languages"
        Me.tbpLanguages.UseVisualStyleBackColor = True
        '
        'lblLanguage
        '
        resources.ApplyResources(Me.lblLanguage, "lblLanguage")
        Me.lblLanguage.Name = "lblLanguage"
        '
        'ucrInputLanguage
        '
        Me.ucrInputLanguage.AddQuotesIfUnrecognised = True
        Me.ucrInputLanguage.GetSetSelectedIndex = -1
        Me.ucrInputLanguage.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLanguage, "ucrInputLanguage")
        Me.ucrInputLanguage.Name = "ucrInputLanguage"
        '
        'tbpComments
        '
        Me.tbpComments.Controls.Add(Me.pnComments)
        resources.ApplyResources(Me.tbpComments, "tbpComments")
        Me.tbpComments.Name = "tbpComments"
        Me.tbpComments.Tag = "Comments"
        Me.tbpComments.UseVisualStyleBackColor = True
        '
        'pnComments
        '
        resources.ApplyResources(Me.pnComments, "pnComments")
        Me.pnComments.Controls.Add(Me.ucrInputComment)
        Me.pnComments.Controls.Add(Me.lblComment)
        Me.pnComments.Name = "pnComments"
        '
        'ucrInputComment
        '
        Me.ucrInputComment.AddQuotesIfUnrecognised = True
        Me.ucrInputComment.IsMultiline = False
        Me.ucrInputComment.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComment, "ucrInputComment")
        Me.ucrInputComment.Name = "ucrInputComment"
        '
        'lblComment
        '
        resources.ApplyResources(Me.lblComment, "lblComment")
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Tag = "Comment:"
        '
        'tbpImport
        '
        Me.tbpImport.Controls.Add(Me.pnImportData)
        resources.ApplyResources(Me.tbpImport, "tbpImport")
        Me.tbpImport.Name = "tbpImport"
        Me.tbpImport.UseVisualStyleBackColor = True
        '
        'pnImportData
        '
        resources.ApplyResources(Me.pnImportData, "pnImportData")
        Me.pnImportData.Controls.Add(Me.ucrNudPreviewRows)
        Me.pnImportData.Controls.Add(Me.lblPreviewRows)
        Me.pnImportData.Name = "pnImportData"
        '
        'ucrNudPreviewRows
        '
        Me.ucrNudPreviewRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudPreviewRows, "ucrNudPreviewRows")
        Me.ucrNudPreviewRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreviewRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewRows.Name = "ucrNudPreviewRows"
        Me.ucrNudPreviewRows.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblPreviewRows
        '
        resources.ApplyResources(Me.lblPreviewRows, "lblPreviewRows")
        Me.lblPreviewRows.Name = "lblPreviewRows"
        '
        'tbpOutputWindow
        '
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkShowRCommandsinOutputWindow)
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkIncludeCommentsbyDefault)
        Me.tbpOutputWindow.Controls.Add(Me.grpROptions)
        Me.tbpOutputWindow.Controls.Add(Me.pnFormatOptions)
        resources.ApplyResources(Me.tbpOutputWindow, "tbpOutputWindow")
        Me.tbpOutputWindow.Name = "tbpOutputWindow"
        Me.tbpOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrChkShowRCommandsinOutputWindow
        '
        Me.ucrChkShowRCommandsinOutputWindow.Checked = False
        resources.ApplyResources(Me.ucrChkShowRCommandsinOutputWindow, "ucrChkShowRCommandsinOutputWindow")
        Me.ucrChkShowRCommandsinOutputWindow.Name = "ucrChkShowRCommandsinOutputWindow"
        '
        'ucrChkIncludeCommentsbyDefault
        '
        Me.ucrChkIncludeCommentsbyDefault.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeCommentsbyDefault, "ucrChkIncludeCommentsbyDefault")
        Me.ucrChkIncludeCommentsbyDefault.Name = "ucrChkIncludeCommentsbyDefault"
        '
        'grpROptions
        '
        Me.grpROptions.Controls.Add(Me.ucrChkShowSignifStars)
        Me.grpROptions.Controls.Add(Me.ucrNudDigits)
        Me.grpROptions.Controls.Add(Me.lblNoDigits)
        resources.ApplyResources(Me.grpROptions, "grpROptions")
        Me.grpROptions.Name = "grpROptions"
        Me.grpROptions.TabStop = False
        '
        'ucrChkShowSignifStars
        '
        Me.ucrChkShowSignifStars.Checked = False
        resources.ApplyResources(Me.ucrChkShowSignifStars, "ucrChkShowSignifStars")
        Me.ucrChkShowSignifStars.Name = "ucrChkShowSignifStars"
        '
        'ucrNudDigits
        '
        Me.ucrNudDigits.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDigits.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDigits, "ucrNudDigits")
        Me.ucrNudDigits.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDigits.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDigits.Name = "ucrNudDigits"
        Me.ucrNudDigits.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNoDigits
        '
        resources.ApplyResources(Me.lblNoDigits, "lblNoDigits")
        Me.lblNoDigits.Name = "lblNoDigits"
        '
        'pnFormatOptions
        '
        resources.ApplyResources(Me.pnFormatOptions, "pnFormatOptions")
        Me.pnFormatOptions.Controls.Add(Me.rtbCommentPreview)
        Me.pnFormatOptions.Controls.Add(Me.rtbOutputPreview)
        Me.pnFormatOptions.Controls.Add(Me.rtbCommandPreview)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommandFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblCommentFormat)
        Me.pnFormatOptions.Controls.Add(Me.cmdOutputFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblOutputFormat)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommentFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblCommandFormat)
        Me.pnFormatOptions.Name = "pnFormatOptions"
        '
        'rtbCommentPreview
        '
        resources.ApplyResources(Me.rtbCommentPreview, "rtbCommentPreview")
        Me.rtbCommentPreview.Name = "rtbCommentPreview"
        Me.rtbCommentPreview.ReadOnly = True
        '
        'rtbOutputPreview
        '
        resources.ApplyResources(Me.rtbOutputPreview, "rtbOutputPreview")
        Me.rtbOutputPreview.Name = "rtbOutputPreview"
        Me.rtbOutputPreview.ReadOnly = True
        '
        'rtbCommandPreview
        '
        resources.ApplyResources(Me.rtbCommandPreview, "rtbCommandPreview")
        Me.rtbCommandPreview.Name = "rtbCommandPreview"
        Me.rtbCommandPreview.ReadOnly = True
        '
        'cmdCommandFormat
        '
        resources.ApplyResources(Me.cmdCommandFormat, "cmdCommandFormat")
        Me.cmdCommandFormat.Name = "cmdCommandFormat"
        Me.cmdCommandFormat.UseVisualStyleBackColor = True
        '
        'lblCommentFormat
        '
        resources.ApplyResources(Me.lblCommentFormat, "lblCommentFormat")
        Me.lblCommentFormat.Name = "lblCommentFormat"
        '
        'cmdOutputFormat
        '
        resources.ApplyResources(Me.cmdOutputFormat, "cmdOutputFormat")
        Me.cmdOutputFormat.Name = "cmdOutputFormat"
        Me.cmdOutputFormat.UseVisualStyleBackColor = True
        '
        'lblOutputFormat
        '
        resources.ApplyResources(Me.lblOutputFormat, "lblOutputFormat")
        Me.lblOutputFormat.Name = "lblOutputFormat"
        '
        'cmdCommentFormat
        '
        resources.ApplyResources(Me.cmdCommentFormat, "cmdCommentFormat")
        Me.cmdCommentFormat.Name = "cmdCommentFormat"
        Me.cmdCommentFormat.UseVisualStyleBackColor = True
        '
        'lblCommandFormat
        '
        resources.ApplyResources(Me.lblCommandFormat, "lblCommandFormat")
        Me.lblCommandFormat.Name = "lblCommandFormat"
        '
        'tbpEditor
        '
        Me.tbpEditor.Controls.Add(Me.pnFormatEditor)
        resources.ApplyResources(Me.tbpEditor, "tbpEditor")
        Me.tbpEditor.Name = "tbpEditor"
        Me.tbpEditor.UseVisualStyleBackColor = True
        '
        'pnFormatEditor
        '
        resources.ApplyResources(Me.pnFormatEditor, "pnFormatEditor")
        Me.pnFormatEditor.Controls.Add(Me.cmdEditorFont)
        Me.pnFormatEditor.Controls.Add(Me.lblFont)
        Me.pnFormatEditor.Name = "pnFormatEditor"
        '
        'cmdEditorFont
        '
        resources.ApplyResources(Me.cmdEditorFont, "cmdEditorFont")
        Me.cmdEditorFont.Name = "cmdEditorFont"
        Me.cmdEditorFont.UseVisualStyleBackColor = True
        '
        'lblFont
        '
        resources.ApplyResources(Me.lblFont, "lblFont")
        Me.lblFont.Name = "lblFont"
        '
        'tbpCommands
        '
        Me.tbpCommands.Controls.Add(Me.lblWaitSeconds)
        Me.tbpCommands.Controls.Add(Me.ucrChkShowWaitDialog)
        Me.tbpCommands.Controls.Add(Me.ucrNudWaitSeconds)
        Me.tbpCommands.Controls.Add(Me.ucrChkIncludeDefaultParams)
        resources.ApplyResources(Me.tbpCommands, "tbpCommands")
        Me.tbpCommands.Name = "tbpCommands"
        Me.tbpCommands.Tag = "Commands"
        Me.tbpCommands.UseVisualStyleBackColor = True
        '
        'lblWaitSeconds
        '
        resources.ApplyResources(Me.lblWaitSeconds, "lblWaitSeconds")
        Me.lblWaitSeconds.Name = "lblWaitSeconds"
        '
        'ucrChkShowWaitDialog
        '
        Me.ucrChkShowWaitDialog.Checked = False
        resources.ApplyResources(Me.ucrChkShowWaitDialog, "ucrChkShowWaitDialog")
        Me.ucrChkShowWaitDialog.Name = "ucrChkShowWaitDialog"
        '
        'ucrNudWaitSeconds
        '
        Me.ucrNudWaitSeconds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaitSeconds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudWaitSeconds, "ucrNudWaitSeconds")
        Me.ucrNudWaitSeconds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaitSeconds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaitSeconds.Name = "ucrNudWaitSeconds"
        Me.ucrNudWaitSeconds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkIncludeDefaultParams
        '
        Me.ucrChkIncludeDefaultParams.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeDefaultParams, "ucrChkIncludeDefaultParams")
        Me.ucrChkIncludeDefaultParams.Name = "ucrChkIncludeDefaultParams"
        '
        'tbpDataView
        '
        Me.tbpDataView.Controls.Add(Me.lblEvery)
        Me.tbpDataView.Controls.Add(Me.lblMinutes)
        Me.tbpDataView.Controls.Add(Me.ucrChkAutoSave)
        Me.tbpDataView.Controls.Add(Me.ucrChkShowDataonGrid)
        Me.tbpDataView.Controls.Add(Me.ucrNudAutoSaveMinutes)
        Me.tbpDataView.Controls.Add(Me.ucrNudMaxCols)
        Me.tbpDataView.Controls.Add(Me.lblMaxCols)
        Me.tbpDataView.Controls.Add(Me.ucrNudMaxRows)
        Me.tbpDataView.Controls.Add(Me.lblMaxRows)
        resources.ApplyResources(Me.tbpDataView, "tbpDataView")
        Me.tbpDataView.Name = "tbpDataView"
        Me.tbpDataView.UseVisualStyleBackColor = True
        '
        'lblEvery
        '
        resources.ApplyResources(Me.lblEvery, "lblEvery")
        Me.lblEvery.Name = "lblEvery"
        '
        'lblMinutes
        '
        resources.ApplyResources(Me.lblMinutes, "lblMinutes")
        Me.lblMinutes.Name = "lblMinutes"
        '
        'ucrChkAutoSave
        '
        Me.ucrChkAutoSave.Checked = False
        resources.ApplyResources(Me.ucrChkAutoSave, "ucrChkAutoSave")
        Me.ucrChkAutoSave.Name = "ucrChkAutoSave"
        '
        'ucrChkShowDataonGrid
        '
        Me.ucrChkShowDataonGrid.Checked = False
        resources.ApplyResources(Me.ucrChkShowDataonGrid, "ucrChkShowDataonGrid")
        Me.ucrChkShowDataonGrid.Name = "ucrChkShowDataonGrid"
        '
        'ucrNudAutoSaveMinutes
        '
        Me.ucrNudAutoSaveMinutes.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudAutoSaveMinutes, "ucrNudAutoSaveMinutes")
        Me.ucrNudAutoSaveMinutes.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Name = "ucrNudAutoSaveMinutes"
        Me.ucrNudAutoSaveMinutes.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxCols
        '
        Me.ucrNudMaxCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxCols, "ucrNudMaxCols")
        Me.ucrNudMaxCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCols.Name = "ucrNudMaxCols"
        Me.ucrNudMaxCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxCols
        '
        resources.ApplyResources(Me.lblMaxCols, "lblMaxCols")
        Me.lblMaxCols.Name = "lblMaxCols"
        '
        'ucrNudMaxRows
        '
        Me.ucrNudMaxRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxRows, "ucrNudMaxRows")
        Me.ucrNudMaxRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRows.Name = "ucrNudMaxRows"
        Me.ucrNudMaxRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxRows
        '
        resources.ApplyResources(Me.lblMaxRows, "lblMaxRows")
        Me.lblMaxRows.Name = "lblMaxRows"
        '
        'tbpWorkingDirectory
        '
        Me.tbpWorkingDirectory.Controls.Add(Me.cmdWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.lblWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.ucrWorkingDirectory)
        resources.ApplyResources(Me.tbpWorkingDirectory, "tbpWorkingDirectory")
        Me.tbpWorkingDirectory.Name = "tbpWorkingDirectory"
        Me.tbpWorkingDirectory.UseVisualStyleBackColor = True
        '
        'cmdWorkingDirectory
        '
        resources.ApplyResources(Me.cmdWorkingDirectory, "cmdWorkingDirectory")
        Me.cmdWorkingDirectory.Name = "cmdWorkingDirectory"
        Me.cmdWorkingDirectory.UseVisualStyleBackColor = True
        '
        'lblWorkingDirectory
        '
        resources.ApplyResources(Me.lblWorkingDirectory, "lblWorkingDirectory")
        Me.lblWorkingDirectory.Name = "lblWorkingDirectory"
        '
        'ucrWorkingDirectory
        '
        Me.ucrWorkingDirectory.AddQuotesIfUnrecognised = True
        Me.ucrWorkingDirectory.IsMultiline = False
        Me.ucrWorkingDirectory.IsReadOnly = False
        resources.ApplyResources(Me.ucrWorkingDirectory, "ucrWorkingDirectory")
        Me.ucrWorkingDirectory.Name = "ucrWorkingDirectory"
        '
        'tbpGraphDisplay
        '
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinSeparateWindows)
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinRViewer)
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinOutputWindow)
        Me.tbpGraphDisplay.Controls.Add(Me.ucrPnlGraphDisplay)
        resources.ApplyResources(Me.tbpGraphDisplay, "tbpGraphDisplay")
        Me.tbpGraphDisplay.Name = "tbpGraphDisplay"
        Me.tbpGraphDisplay.UseVisualStyleBackColor = True
        '
        'rdoDisplayinSeparateWindows
        '
        resources.ApplyResources(Me.rdoDisplayinSeparateWindows, "rdoDisplayinSeparateWindows")
        Me.rdoDisplayinSeparateWindows.Checked = True
        Me.rdoDisplayinSeparateWindows.Name = "rdoDisplayinSeparateWindows"
        Me.rdoDisplayinSeparateWindows.TabStop = True
        Me.rdoDisplayinSeparateWindows.UseVisualStyleBackColor = True
        '
        'rdoDisplayinRViewer
        '
        resources.ApplyResources(Me.rdoDisplayinRViewer, "rdoDisplayinRViewer")
        Me.rdoDisplayinRViewer.Name = "rdoDisplayinRViewer"
        Me.rdoDisplayinRViewer.UseVisualStyleBackColor = True
        '
        'rdoDisplayinOutputWindow
        '
        resources.ApplyResources(Me.rdoDisplayinOutputWindow, "rdoDisplayinOutputWindow")
        Me.rdoDisplayinOutputWindow.Name = "rdoDisplayinOutputWindow"
        Me.rdoDisplayinOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphDisplay
        '
        resources.ApplyResources(Me.ucrPnlGraphDisplay, "ucrPnlGraphDisplay")
        Me.ucrPnlGraphDisplay.Name = "ucrPnlGraphDisplay"
        '
        'tbpTailoredMenus
        '
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewStructuredMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewOptionsByContextMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewProcurementMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewClimaticMenu)
        resources.ApplyResources(Me.tbpTailoredMenus, "tbpTailoredMenus")
        Me.tbpTailoredMenus.Name = "tbpTailoredMenus"
        Me.tbpTailoredMenus.UseVisualStyleBackColor = True
        '
        'ucrChkViewStructuredMenu
        '
        Me.ucrChkViewStructuredMenu.Checked = False
        resources.ApplyResources(Me.ucrChkViewStructuredMenu, "ucrChkViewStructuredMenu")
        Me.ucrChkViewStructuredMenu.Name = "ucrChkViewStructuredMenu"
        '
        'ucrChkViewOptionsByContextMenu
        '
        Me.ucrChkViewOptionsByContextMenu.Checked = False
        resources.ApplyResources(Me.ucrChkViewOptionsByContextMenu, "ucrChkViewOptionsByContextMenu")
        Me.ucrChkViewOptionsByContextMenu.Name = "ucrChkViewOptionsByContextMenu"
        '
        'ucrChkViewProcurementMenu
        '
        Me.ucrChkViewProcurementMenu.Checked = False
        resources.ApplyResources(Me.ucrChkViewProcurementMenu, "ucrChkViewProcurementMenu")
        Me.ucrChkViewProcurementMenu.Name = "ucrChkViewProcurementMenu"
        '
        'ucrChkViewClimaticMenu
        '
        Me.ucrChkViewClimaticMenu.Checked = False
        resources.ApplyResources(Me.ucrChkViewClimaticMenu, "ucrChkViewClimaticMenu")
        Me.ucrChkViewClimaticMenu.Name = "ucrChkViewClimaticMenu"
        '
        'tbpClimsoft
        '
        Me.tbpClimsoft.Controls.Add(Me.lblUserName)
        Me.tbpClimsoft.Controls.Add(Me.lblPort)
        Me.tbpClimsoft.Controls.Add(Me.lblHost)
        Me.tbpClimsoft.Controls.Add(Me.lblDatabaseName)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputUserName)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputPort)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputHost)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputDatabaseName)
        resources.ApplyResources(Me.tbpClimsoft, "tbpClimsoft")
        Me.tbpClimsoft.Name = "tbpClimsoft"
        Me.tbpClimsoft.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        resources.ApplyResources(Me.lblUserName, "lblUserName")
        Me.lblUserName.Name = "lblUserName"
        '
        'lblPort
        '
        resources.ApplyResources(Me.lblPort, "lblPort")
        Me.lblPort.Name = "lblPort"
        '
        'lblHost
        '
        resources.ApplyResources(Me.lblHost, "lblHost")
        Me.lblHost.Name = "lblHost"
        '
        'lblDatabaseName
        '
        resources.ApplyResources(Me.lblDatabaseName, "lblDatabaseName")
        Me.lblDatabaseName.Name = "lblDatabaseName"
        '
        'ucrInputUserName
        '
        Me.ucrInputUserName.AddQuotesIfUnrecognised = True
        Me.ucrInputUserName.IsMultiline = False
        Me.ucrInputUserName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputUserName, "ucrInputUserName")
        Me.ucrInputUserName.Name = "ucrInputUserName"
        '
        'ucrInputPort
        '
        Me.ucrInputPort.AddQuotesIfUnrecognised = True
        Me.ucrInputPort.IsMultiline = False
        Me.ucrInputPort.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPort, "ucrInputPort")
        Me.ucrInputPort.Name = "ucrInputPort"
        '
        'ucrInputHost
        '
        Me.ucrInputHost.AddQuotesIfUnrecognised = True
        Me.ucrInputHost.IsMultiline = False
        Me.ucrInputHost.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputHost, "ucrInputHost")
        Me.ucrInputHost.Name = "ucrInputHost"
        '
        'ucrInputDatabaseName
        '
        Me.ucrInputDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrInputDatabaseName.IsMultiline = False
        Me.ucrInputDatabaseName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDatabaseName, "ucrInputDatabaseName")
        Me.ucrInputDatabaseName.Name = "ucrInputDatabaseName"
        '
        'dlgOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.spltControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOptions"
        Me.Tag = "Options"
        Me.spltControls.Panel1.ResumeLayout(False)
        Me.spltControls.Panel2.ResumeLayout(False)
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltControls.ResumeLayout(False)
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpLanguages.ResumeLayout(False)
        Me.tbpLanguages.PerformLayout()
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
        Me.tbpTailoredMenus.ResumeLayout(False)
        Me.tbpClimsoft.ResumeLayout(False)
        Me.tbpClimsoft.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdApply As Button
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpLanguages As TabPage
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
    Friend WithEvents ucrInputComment As ucrInputTextBox
    Friend WithEvents ucrNudMaxCols As ucrNud
    Friend WithEvents lblMaxCols As Label
    Friend WithEvents ucrChkShowDataonGrid As ucrCheck
    Friend WithEvents ucrChkAutoSave As ucrCheck
    Friend WithEvents ucrNudAutoSaveMinutes As ucrNud
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblEvery As Label
    Friend WithEvents lblWaitSeconds As Label
    Friend WithEvents ucrChkShowWaitDialog As ucrCheck
    Friend WithEvents ucrNudWaitSeconds As ucrNud
    Friend WithEvents tbpTailoredMenus As TabPage
    Friend WithEvents ucrChkViewProcurementMenu As ucrCheck
    Friend WithEvents ucrChkViewClimaticMenu As ucrCheck
    Friend WithEvents ucrChkViewOptionsByContextMenu As ucrCheck
    Friend WithEvents tbpClimsoft As TabPage
    Friend WithEvents ucrInputUserName As ucrInputTextBox
    Friend WithEvents ucrInputPort As ucrInputTextBox
    Friend WithEvents ucrInputHost As ucrInputTextBox
    Friend WithEvents ucrInputDatabaseName As ucrInputTextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents ucrChkViewStructuredMenu As ucrCheck
    Friend WithEvents lblLanguage As Label
    Friend WithEvents ucrInputLanguage As ucrInputComboBox
End Class
