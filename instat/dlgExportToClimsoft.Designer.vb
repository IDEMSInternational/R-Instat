<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportToClimsoft
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
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblcomments = New System.Windows.Forms.Label()
        Me.rdoData = New System.Windows.Forms.RadioButton()
        Me.rdoStation = New System.Windows.Forms.RadioButton()
        Me.ucrChkSingleValue = New instat.ucrCheck()
        Me.ucrPnlPrepareData = New instat.UcrPanel()
        Me.ucrReceiverComments = New instat.ucrReceiverSingle()
        Me.ucrChkAddReport = New instat.ucrCheck()
        Me.ucrDataFrameSheets = New instat.ucrDataFrame()
        Me.ucrChkExportDataFrame = New instat.ucrCheck()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrChkNewDataFrame = New instat.ucrCheck()
        Me.ucrInputLevel = New instat.ucrInputTextBox()
        Me.ucrInputHour = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorImportToClimsoft = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(278, 240)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(53, 13)
        Me.lblElement.TabIndex = 10
        Me.lblElement.Text = "Elements:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(278, 87)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "Date:"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(278, 151)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(33, 13)
        Me.lblHour.TabIndex = 20
        Me.lblHour.Text = "Hour:"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(278, 195)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(36, 13)
        Me.lblLevel.TabIndex = 21
        Me.lblLevel.Text = "Level:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(278, 46)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 69
        Me.lblStation.Text = "Station:"
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(9, 462)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(59, 13)
        Me.lblExport.TabIndex = 71
        Me.lblExport.Text = "Export File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(326, 457)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(80, 23)
        Me.cmdBrowse.TabIndex = 73
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblcomments
        '
        Me.lblcomments.AutoSize = True
        Me.lblcomments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblcomments.Location = New System.Drawing.Point(278, 371)
        Me.lblcomments.Name = "lblcomments"
        Me.lblcomments.Size = New System.Drawing.Size(59, 13)
        Me.lblcomments.TabIndex = 76
        Me.lblcomments.Tag = "New_Name"
        Me.lblcomments.Text = "Comments:"
        '
        'rdoData
        '
        Me.rdoData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoData.FlatAppearance.BorderSize = 2
        Me.rdoData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoData.Location = New System.Drawing.Point(89, 7)
        Me.rdoData.Name = "rdoData"
        Me.rdoData.Size = New System.Drawing.Size(115, 28)
        Me.rdoData.TabIndex = 80
        Me.rdoData.Text = "Data"
        Me.rdoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoData.UseVisualStyleBackColor = True
        '
        'rdoStation
        '
        Me.rdoStation.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStation.Enabled = False
        Me.rdoStation.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatAppearance.BorderSize = 2
        Me.rdoStation.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStation.Location = New System.Drawing.Point(202, 7)
        Me.rdoStation.Name = "rdoStation"
        Me.rdoStation.Size = New System.Drawing.Size(112, 28)
        Me.rdoStation.TabIndex = 82
        Me.rdoStation.Text = "Station"
        Me.rdoStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStation.UseVisualStyleBackColor = True
        '
        'ucrChkSingleValue
        '
        Me.ucrChkSingleValue.AutoSize = True
        Me.ucrChkSingleValue.Checked = False
        Me.ucrChkSingleValue.Location = New System.Drawing.Point(276, 129)
        Me.ucrChkSingleValue.Name = "ucrChkSingleValue"
        Me.ucrChkSingleValue.Size = New System.Drawing.Size(129, 23)
        Me.ucrChkSingleValue.TabIndex = 83
        '
        'ucrPnlPrepareData
        '
        Me.ucrPnlPrepareData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPrepareData.Location = New System.Drawing.Point(81, 7)
        Me.ucrPnlPrepareData.Name = "ucrPnlPrepareData"
        Me.ucrPnlPrepareData.Size = New System.Drawing.Size(240, 30)
        Me.ucrPnlPrepareData.TabIndex = 81
        '
        'ucrReceiverComments
        '
        Me.ucrReceiverComments.AutoSize = True
        Me.ucrReceiverComments.frmParent = Me
        Me.ucrReceiverComments.Location = New System.Drawing.Point(278, 388)
        Me.ucrReceiverComments.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverComments.Name = "ucrReceiverComments"
        Me.ucrReceiverComments.Selector = Nothing
        Me.ucrReceiverComments.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverComments.strNcFilePath = ""
        Me.ucrReceiverComments.TabIndex = 79
        Me.ucrReceiverComments.ucrSelector = Nothing
        '
        'ucrChkAddReport
        '
        Me.ucrChkAddReport.AutoSize = True
        Me.ucrChkAddReport.Checked = False
        Me.ucrChkAddReport.Location = New System.Drawing.Point(9, 326)
        Me.ucrChkAddReport.Name = "ucrChkAddReport"
        Me.ucrChkAddReport.Size = New System.Drawing.Size(266, 23)
        Me.ucrChkAddReport.TabIndex = 78
        '
        'ucrDataFrameSheets
        '
        Me.ucrDataFrameSheets.AutoSize = True
        Me.ucrDataFrameSheets.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSheets.bUseCurrentFilter = True
        Me.ucrDataFrameSheets.Location = New System.Drawing.Point(9, 366)
        Me.ucrDataFrameSheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSheets.Name = "ucrDataFrameSheets"
        Me.ucrDataFrameSheets.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameSheets.TabIndex = 75
        '
        'ucrChkExportDataFrame
        '
        Me.ucrChkExportDataFrame.AutoSize = True
        Me.ucrChkExportDataFrame.Checked = False
        Me.ucrChkExportDataFrame.Location = New System.Drawing.Point(9, 272)
        Me.ucrChkExportDataFrame.Name = "ucrChkExportDataFrame"
        Me.ucrChkExportDataFrame.Size = New System.Drawing.Size(266, 23)
        Me.ucrChkExportDataFrame.TabIndex = 74
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.AutoSize = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(142, 458)
        Me.ucrInputExportFile.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(182, 21)
        Me.ucrInputExportFile.TabIndex = 72
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(278, 64)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 70
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(9, 422)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(348, 24)
        Me.ucrSaveNewDataFrame.TabIndex = 68
        '
        'ucrChkNewDataFrame
        '
        Me.ucrChkNewDataFrame.AutoSize = True
        Me.ucrChkNewDataFrame.Checked = False
        Me.ucrChkNewDataFrame.Location = New System.Drawing.Point(9, 235)
        Me.ucrChkNewDataFrame.Name = "ucrChkNewDataFrame"
        Me.ucrChkNewDataFrame.Size = New System.Drawing.Size(266, 23)
        Me.ucrChkNewDataFrame.TabIndex = 22
        '
        'ucrInputLevel
        '
        Me.ucrInputLevel.AddQuotesIfUnrecognised = True
        Me.ucrInputLevel.AutoSize = True
        Me.ucrInputLevel.IsMultiline = False
        Me.ucrInputLevel.IsReadOnly = False
        Me.ucrInputLevel.Location = New System.Drawing.Point(278, 213)
        Me.ucrInputLevel.Name = "ucrInputLevel"
        Me.ucrInputLevel.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputLevel.TabIndex = 19
        '
        'ucrInputHour
        '
        Me.ucrInputHour.AddQuotesIfUnrecognised = True
        Me.ucrInputHour.AutoSize = True
        Me.ucrInputHour.IsMultiline = False
        Me.ucrInputHour.IsReadOnly = False
        Me.ucrInputHour.Location = New System.Drawing.Point(278, 170)
        Me.ucrInputHour.Name = "ucrInputHour"
        Me.ucrInputHour.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputHour.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 487)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 17
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.AutoSize = True
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(278, 260)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 6
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(278, 105)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 5
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrSelectorImportToClimsoft
        '
        Me.ucrSelectorImportToClimsoft.AutoSize = True
        Me.ucrSelectorImportToClimsoft.bDropUnusedFilterLevels = False
        Me.ucrSelectorImportToClimsoft.bShowHiddenColumns = False
        Me.ucrSelectorImportToClimsoft.bUseCurrentFilter = True
        Me.ucrSelectorImportToClimsoft.Location = New System.Drawing.Point(9, 37)
        Me.ucrSelectorImportToClimsoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorImportToClimsoft.Name = "ucrSelectorImportToClimsoft"
        Me.ucrSelectorImportToClimsoft.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorImportToClimsoft.TabIndex = 1
        '
        'dlgExportToClimsoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(417, 537)
        Me.Controls.Add(Me.ucrChkSingleValue)
        Me.Controls.Add(Me.rdoData)
        Me.Controls.Add(Me.rdoStation)
        Me.Controls.Add(Me.ucrPnlPrepareData)
        Me.Controls.Add(Me.ucrReceiverComments)
        Me.Controls.Add(Me.ucrChkAddReport)
        Me.Controls.Add(Me.lblcomments)
        Me.Controls.Add(Me.ucrDataFrameSheets)
        Me.Controls.Add(Me.ucrChkExportDataFrame)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrChkNewDataFrame)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.ucrInputLevel)
        Me.Controls.Add(Me.ucrInputHour)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSelectorImportToClimsoft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgExportToClimsoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export For Climsoft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorImportToClimsoft As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents lblElement As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents ucrInputLevel As ucrInputTextBox
    Friend WithEvents ucrInputHour As ucrInputTextBox
    Friend WithEvents ucrChkNewDataFrame As ucrCheck
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblExport As Label
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents ucrChkExportDataFrame As ucrCheck
    Friend WithEvents lblcomments As Label
    Friend WithEvents ucrDataFrameSheets As ucrDataFrame
    Friend WithEvents ucrChkAddReport As ucrCheck
    Friend WithEvents ucrReceiverComments As ucrReceiverSingle
    Friend WithEvents rdoData As RadioButton
    Friend WithEvents rdoStation As RadioButton
    Friend WithEvents ucrPnlPrepareData As UcrPanel
    Friend WithEvents ucrChkSingleValue As ucrCheck
End Class
