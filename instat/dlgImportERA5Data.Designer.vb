<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportERA5Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgImportERA5Data))
        Me.grpTimeSelection = New System.Windows.Forms.GroupBox()
        Me.rdoRange = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.rdoSelection = New System.Windows.Forms.RadioButton()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblAPIKey = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblMinLongitude = New System.Windows.Forms.Label()
        Me.lblMinLatitude = New System.Windows.Forms.Label()
        Me.lblMaxLatitude = New System.Windows.Forms.Label()
        Me.lblMaxLongitude = New System.Windows.Forms.Label()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.grpLocationSelection = New System.Windows.Forms.GroupBox()
        Me.lblResolutionLabel = New System.Windows.Forms.Label()
        Me.grpLoginToCDS = New System.Windows.Forms.GroupBox()
        Me.lblResolution = New System.Windows.Forms.Label()
        Me.lnkCreateAnAccount = New System.Windows.Forms.LinkLabel()
        Me.lblSaveDownloadedFileTo = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputMinLongitude = New instat.ucrInputTextBox()
        Me.ucrInputMinLatitude = New instat.ucrInputTextBox()
        Me.ucrInputMaxLongitude = New instat.ucrInputTextBox()
        Me.ucrInputMaxLatitude = New instat.ucrInputTextBox()
        Me.ucrChkDoNotImport = New instat.ucrCheck()
        Me.ucrInputNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpStartDate = New instat.ucrDateTimePicker()
        Me.ucrPnlRangeSelection = New instat.UcrPanel()
        Me.ucrInputElement = New instat.ucrInputComboBox()
        Me.ucrInputData = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputUserID = New instat.ucrInputTextBox()
        Me.ucrInputAPIKey = New instat.ucrInputTextBox()
        Me.grpTimeSelection.SuspendLayout()
        Me.grpLocationSelection.SuspendLayout()
        Me.grpLoginToCDS.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTimeSelection
        '
        Me.grpTimeSelection.Controls.Add(Me.rdoRange)
        Me.grpTimeSelection.Controls.Add(Me.lblTo)
        Me.grpTimeSelection.Controls.Add(Me.rdoSelection)
        Me.grpTimeSelection.Controls.Add(Me.lblFrom)
        Me.grpTimeSelection.Controls.Add(Me.ucrDtpEndDate)
        Me.grpTimeSelection.Controls.Add(Me.ucrDtpStartDate)
        Me.grpTimeSelection.Controls.Add(Me.ucrPnlRangeSelection)
        resources.ApplyResources(Me.grpTimeSelection, "grpTimeSelection")
        Me.grpTimeSelection.Name = "grpTimeSelection"
        Me.grpTimeSelection.TabStop = False
        '
        'rdoRange
        '
        resources.ApplyResources(Me.rdoRange, "rdoRange")
        Me.rdoRange.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRange.Checked = True
        Me.rdoRange.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRange.FlatAppearance.BorderSize = 2
        Me.rdoRange.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRange.Name = "rdoRange"
        Me.rdoRange.TabStop = True
        Me.rdoRange.Tag = ""
        Me.rdoRange.UseVisualStyleBackColor = False
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'rdoSelection
        '
        resources.ApplyResources(Me.rdoSelection, "rdoSelection")
        Me.rdoSelection.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSelection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelection.FlatAppearance.BorderSize = 2
        Me.rdoSelection.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelection.Name = "rdoSelection"
        Me.rdoSelection.TabStop = True
        Me.rdoSelection.Tag = ""
        Me.rdoSelection.UseVisualStyleBackColor = False
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'lblData
        '
        resources.ApplyResources(Me.lblData, "lblData")
        Me.lblData.Name = "lblData"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblAPIKey
        '
        resources.ApplyResources(Me.lblAPIKey, "lblAPIKey")
        Me.lblAPIKey.Name = "lblAPIKey"
        '
        'lblUserID
        '
        resources.ApplyResources(Me.lblUserID, "lblUserID")
        Me.lblUserID.Name = "lblUserID"
        '
        'lblMinLongitude
        '
        resources.ApplyResources(Me.lblMinLongitude, "lblMinLongitude")
        Me.lblMinLongitude.Name = "lblMinLongitude"
        '
        'lblMinLatitude
        '
        resources.ApplyResources(Me.lblMinLatitude, "lblMinLatitude")
        Me.lblMinLatitude.Name = "lblMinLatitude"
        '
        'lblMaxLatitude
        '
        resources.ApplyResources(Me.lblMaxLatitude, "lblMaxLatitude")
        Me.lblMaxLatitude.Name = "lblMaxLatitude"
        '
        'lblMaxLongitude
        '
        resources.ApplyResources(Me.lblMaxLongitude, "lblMaxLongitude")
        Me.lblMaxLongitude.Name = "lblMaxLongitude"
        '
        'lblNewDataFrameName
        '
        resources.ApplyResources(Me.lblNewDataFrameName, "lblNewDataFrameName")
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        '
        'lblLatitude
        '
        resources.ApplyResources(Me.lblLatitude, "lblLatitude")
        Me.lblLatitude.Name = "lblLatitude"
        '
        'lblLongitude
        '
        resources.ApplyResources(Me.lblLongitude, "lblLongitude")
        Me.lblLongitude.Name = "lblLongitude"
        '
        'grpLocationSelection
        '
        Me.grpLocationSelection.Controls.Add(Me.lblLongitude)
        Me.grpLocationSelection.Controls.Add(Me.lblLatitude)
        Me.grpLocationSelection.Controls.Add(Me.lblMaxLatitude)
        Me.grpLocationSelection.Controls.Add(Me.lblMaxLongitude)
        Me.grpLocationSelection.Controls.Add(Me.lblMinLongitude)
        Me.grpLocationSelection.Controls.Add(Me.lblMinLatitude)
        Me.grpLocationSelection.Controls.Add(Me.ucrInputMinLongitude)
        Me.grpLocationSelection.Controls.Add(Me.ucrInputMinLatitude)
        Me.grpLocationSelection.Controls.Add(Me.ucrInputMaxLongitude)
        Me.grpLocationSelection.Controls.Add(Me.ucrInputMaxLatitude)
        resources.ApplyResources(Me.grpLocationSelection, "grpLocationSelection")
        Me.grpLocationSelection.Name = "grpLocationSelection"
        Me.grpLocationSelection.TabStop = False
        '
        'lblResolutionLabel
        '
        resources.ApplyResources(Me.lblResolutionLabel, "lblResolutionLabel")
        Me.lblResolutionLabel.ForeColor = System.Drawing.Color.Red
        Me.lblResolutionLabel.Name = "lblResolutionLabel"
        '
        'grpLoginToCDS
        '
        Me.grpLoginToCDS.Controls.Add(Me.lblUserID)
        Me.grpLoginToCDS.Controls.Add(Me.lblAPIKey)
        Me.grpLoginToCDS.Controls.Add(Me.ucrInputUserID)
        Me.grpLoginToCDS.Controls.Add(Me.ucrInputAPIKey)
        resources.ApplyResources(Me.grpLoginToCDS, "grpLoginToCDS")
        Me.grpLoginToCDS.Name = "grpLoginToCDS"
        Me.grpLoginToCDS.TabStop = False
        '
        'lblResolution
        '
        resources.ApplyResources(Me.lblResolution, "lblResolution")
        Me.lblResolution.Name = "lblResolution"
        '
        'lnkCreateAnAccount
        '
        resources.ApplyResources(Me.lnkCreateAnAccount, "lnkCreateAnAccount")
        Me.lnkCreateAnAccount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lnkCreateAnAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lnkCreateAnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCreateAnAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkCreateAnAccount.Name = "lnkCreateAnAccount"
        Me.lnkCreateAnAccount.TabStop = True
        '
        'lblSaveDownloadedFileTo
        '
        resources.ApplyResources(Me.lblSaveDownloadedFileTo, "lblSaveDownloadedFileTo")
        Me.lblSaveDownloadedFileTo.Name = "lblSaveDownloadedFileTo"
        '
        'cmdBrowse
        '
        resources.ApplyResources(Me.cmdBrowse, "cmdBrowse")
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilePath, "ucrInputFilePath")
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        '
        'ucrInputMinLongitude
        '
        Me.ucrInputMinLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLongitude.IsMultiline = False
        Me.ucrInputMinLongitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLongitude, "ucrInputMinLongitude")
        Me.ucrInputMinLongitude.Name = "ucrInputMinLongitude"
        '
        'ucrInputMinLatitude
        '
        Me.ucrInputMinLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLatitude.IsMultiline = False
        Me.ucrInputMinLatitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLatitude, "ucrInputMinLatitude")
        Me.ucrInputMinLatitude.Name = "ucrInputMinLatitude"
        '
        'ucrInputMaxLongitude
        '
        Me.ucrInputMaxLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLongitude.IsMultiline = False
        Me.ucrInputMaxLongitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLongitude, "ucrInputMaxLongitude")
        Me.ucrInputMaxLongitude.Name = "ucrInputMaxLongitude"
        '
        'ucrInputMaxLatitude
        '
        Me.ucrInputMaxLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLatitude.IsMultiline = False
        Me.ucrInputMaxLatitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLatitude, "ucrInputMaxLatitude")
        Me.ucrInputMaxLatitude.Name = "ucrInputMaxLatitude"
        '
        'ucrChkDoNotImport
        '
        Me.ucrChkDoNotImport.Checked = False
        resources.ApplyResources(Me.ucrChkDoNotImport, "ucrChkDoNotImport")
        Me.ucrChkDoNotImport.Name = "ucrChkDoNotImport"
        '
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.IsMultiline = False
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewDataFrameName, "ucrInputNewDataFrameName")
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        '
        'ucrDtpEndDate
        '
        Me.ucrDtpEndDate.DateValue = New Date(2021, 3, 29, 10, 5, 8, 139)
        Me.ucrDtpEndDate.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpEndDate, "ucrDtpEndDate")
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        '
        'ucrDtpStartDate
        '
        Me.ucrDtpStartDate.DateValue = New Date(2021, 3, 29, 10, 5, 8, 139)
        Me.ucrDtpStartDate.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpStartDate, "ucrDtpStartDate")
        Me.ucrDtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartDate.Name = "ucrDtpStartDate"
        '
        'ucrPnlRangeSelection
        '
        resources.ApplyResources(Me.ucrPnlRangeSelection, "ucrPnlRangeSelection")
        Me.ucrPnlRangeSelection.Name = "ucrPnlRangeSelection"
        '
        'ucrInputElement
        '
        Me.ucrInputElement.AddQuotesIfUnrecognised = True
        Me.ucrInputElement.GetSetSelectedIndex = -1
        Me.ucrInputElement.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputElement, "ucrInputElement")
        Me.ucrInputElement.Name = "ucrInputElement"
        '
        'ucrInputData
        '
        Me.ucrInputData.AddQuotesIfUnrecognised = True
        Me.ucrInputData.GetSetSelectedIndex = -1
        Me.ucrInputData.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputData, "ucrInputData")
        Me.ucrInputData.Name = "ucrInputData"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputUserID
        '
        Me.ucrInputUserID.AddQuotesIfUnrecognised = True
        Me.ucrInputUserID.IsMultiline = False
        Me.ucrInputUserID.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputUserID, "ucrInputUserID")
        Me.ucrInputUserID.Name = "ucrInputUserID"
        '
        'ucrInputAPIKey
        '
        Me.ucrInputAPIKey.AddQuotesIfUnrecognised = True
        Me.ucrInputAPIKey.IsMultiline = False
        Me.ucrInputAPIKey.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputAPIKey, "ucrInputAPIKey")
        Me.ucrInputAPIKey.Name = "ucrInputAPIKey"
        '
        'dlgImportERA5Data
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSaveDownloadedFileTo)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lnkCreateAnAccount)
        Me.Controls.Add(Me.lblResolution)
        Me.Controls.Add(Me.lblResolutionLabel)
        Me.Controls.Add(Me.grpLocationSelection)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrChkDoNotImport)
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.grpTimeSelection)
        Me.Controls.Add(Me.ucrInputElement)
        Me.Controls.Add(Me.ucrInputData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpLoginToCDS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportERA5Data"
        Me.grpTimeSelection.ResumeLayout(False)
        Me.grpTimeSelection.PerformLayout()
        Me.grpLocationSelection.ResumeLayout(False)
        Me.grpLocationSelection.PerformLayout()
        Me.grpLoginToCDS.ResumeLayout(False)
        Me.grpLoginToCDS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputData As ucrInputComboBox
    Friend WithEvents ucrInputElement As ucrInputComboBox
    Friend WithEvents grpTimeSelection As GroupBox
    Friend WithEvents ucrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartDate As ucrDateTimePicker
    Friend WithEvents ucrInputMinLongitude As ucrInputTextBox
    Friend WithEvents ucrInputMaxLatitude As ucrInputTextBox
    Friend WithEvents ucrInputMaxLongitude As ucrInputTextBox
    Friend WithEvents ucrInputMinLatitude As ucrInputTextBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrInputNewDataFrameName As ucrInputTextBox
    Friend WithEvents ucrChkDoNotImport As ucrCheck
    Friend WithEvents ucrInputAPIKey As ucrInputTextBox
    Friend WithEvents ucrInputUserID As ucrInputTextBox
    Friend WithEvents lblData As Label
    Friend WithEvents lblElement As Label
    Friend WithEvents lblAPIKey As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblMinLongitude As Label
    Friend WithEvents lblMinLatitude As Label
    Friend WithEvents lblMaxLatitude As Label
    Friend WithEvents lblMaxLongitude As Label
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents grpLocationSelection As GroupBox
    Friend WithEvents rdoRange As RadioButton
    Friend WithEvents rdoSelection As RadioButton
    Friend WithEvents ucrPnlRangeSelection As UcrPanel
    Friend WithEvents lblResolutionLabel As Label
    Friend WithEvents grpLoginToCDS As GroupBox
    Friend WithEvents lblResolution As Label
    Friend WithEvents lnkCreateAnAccount As LinkLabel
    Friend WithEvents lblSaveDownloadedFileTo As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
End Class
