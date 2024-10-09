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
        Me.lblExport = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrInputHour = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorImportToClimsoft = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoHourly = New System.Windows.Forms.RadioButton()
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDailyHourly = New instat.UcrPanel()
        Me.ucrReceiverStationID = New instat.ucrReceiverSingle()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.rdoExportData = New System.Windows.Forms.RadioButton()
        Me.rdoNewDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverComments = New instat.ucrReceiverSingle()
        Me.ucrChkAddReport = New instat.ucrCheck()
        Me.lblcomments = New System.Windows.Forms.Label()
        Me.ucrDataFrameSheets = New instat.ucrDataFrame()
        Me.ucrPnlOutput = New instat.UcrPanel()
        Me.grpSave = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(417, 268)
        Me.lblElement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(80, 20)
        Me.lblElement.TabIndex = 10
        Me.lblElement.Text = "Elements:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(417, 140)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date:"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(417, 204)
        Me.lblHour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(48, 20)
        Me.lblHour.TabIndex = 8
        Me.lblHour.Text = "Hour:"
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(14, 654)
        Me.lblExport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(88, 20)
        Me.lblExport.TabIndex = 15
        Me.lblExport.Text = "Export File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(489, 646)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(120, 34)
        Me.cmdBrowse.TabIndex = 17
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.AutoSize = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(213, 648)
        Me.ucrInputExportFile.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(273, 32)
        Me.ucrInputExportFile.TabIndex = 16
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(14, 604)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(522, 36)
        Me.ucrSaveNewDataFrame.TabIndex = 14
        '
        'ucrInputHour
        '
        Me.ucrInputHour.AddQuotesIfUnrecognised = True
        Me.ucrInputHour.AutoSize = True
        Me.ucrInputHour.IsMultiline = False
        Me.ucrInputHour.IsReadOnly = False
        Me.ucrInputHour.Location = New System.Drawing.Point(417, 230)
        Me.ucrInputHour.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputHour.Name = "ucrInputHour"
        Me.ucrInputHour.Size = New System.Drawing.Size(178, 32)
        Me.ucrInputHour.TabIndex = 9
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 688)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 18
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.AutoSize = True
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(417, 298)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(180, 150)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 11
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(417, 165)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 7
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrSelectorImportToClimsoft
        '
        Me.ucrSelectorImportToClimsoft.AutoSize = True
        Me.ucrSelectorImportToClimsoft.bDropUnusedFilterLevels = False
        Me.ucrSelectorImportToClimsoft.bShowHiddenColumns = False
        Me.ucrSelectorImportToClimsoft.bUseCurrentFilter = True
        Me.ucrSelectorImportToClimsoft.Location = New System.Drawing.Point(14, 78)
        Me.ucrSelectorImportToClimsoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorImportToClimsoft.Name = "ucrSelectorImportToClimsoft"
        Me.ucrSelectorImportToClimsoft.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorImportToClimsoft.TabIndex = 3
        '
        'rdoHourly
        '
        Me.rdoHourly.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHourly.BackColor = System.Drawing.SystemColors.Control
        Me.rdoHourly.Enabled = False
        Me.rdoHourly.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHourly.FlatAppearance.BorderSize = 2
        Me.rdoHourly.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHourly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHourly.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHourly.Location = New System.Drawing.Point(285, 12)
        Me.rdoHourly.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoHourly.Name = "rdoHourly"
        Me.rdoHourly.Size = New System.Drawing.Size(136, 42)
        Me.rdoHourly.TabIndex = 2
        Me.rdoHourly.TabStop = True
        Me.rdoHourly.Tag = "Frequency"
        Me.rdoHourly.Text = "Hourly"
        Me.rdoHourly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHourly.UseVisualStyleBackColor = False
        '
        'rdoDaily
        '
        Me.rdoDaily.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDaily.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDaily.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDaily.FlatAppearance.BorderSize = 2
        Me.rdoDaily.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDaily.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDaily.Location = New System.Drawing.Point(151, 12)
        Me.rdoDaily.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(136, 42)
        Me.rdoDaily.TabIndex = 1
        Me.rdoDaily.TabStop = True
        Me.rdoDaily.Tag = "Frequency"
        Me.rdoDaily.Text = "Daily"
        Me.rdoDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDaily.UseVisualStyleBackColor = False
        '
        'ucrPnlDailyHourly
        '
        Me.ucrPnlDailyHourly.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDailyHourly.Location = New System.Drawing.Point(136, 12)
        Me.ucrPnlDailyHourly.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlDailyHourly.Name = "ucrPnlDailyHourly"
        Me.ucrPnlDailyHourly.Size = New System.Drawing.Size(310, 42)
        Me.ucrPnlDailyHourly.TabIndex = 0
        '
        'ucrReceiverStationID
        '
        Me.ucrReceiverStationID.AutoSize = True
        Me.ucrReceiverStationID.frmParent = Me
        Me.ucrReceiverStationID.Location = New System.Drawing.Point(414, 110)
        Me.ucrReceiverStationID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationID.Name = "ucrReceiverStationID"
        Me.ucrReceiverStationID.Selector = Nothing
        Me.ucrReceiverStationID.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStationID.strNcFilePath = ""
        Me.ucrReceiverStationID.TabIndex = 5
        Me.ucrReceiverStationID.ucrSelector = Nothing
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(419, 84)
        Me.lblStationID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(85, 20)
        Me.lblStationID.TabIndex = 4
        Me.lblStationID.Text = "Station ID:"
        '
        'rdoExportData
        '
        Me.rdoExportData.AutoSize = True
        Me.rdoExportData.Location = New System.Drawing.Point(22, 421)
        Me.rdoExportData.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoExportData.Name = "rdoExportData"
        Me.rdoExportData.Size = New System.Drawing.Size(156, 24)
        Me.rdoExportData.TabIndex = 94
        Me.rdoExportData.TabStop = True
        Me.rdoExportData.Text = "Export Data (csv)"
        Me.rdoExportData.UseVisualStyleBackColor = True
        '
        'rdoNewDataFrame
        '
        Me.rdoNewDataFrame.AutoSize = True
        Me.rdoNewDataFrame.Location = New System.Drawing.Point(22, 378)
        Me.rdoNewDataFrame.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoNewDataFrame.Name = "rdoNewDataFrame"
        Me.rdoNewDataFrame.Size = New System.Drawing.Size(154, 24)
        Me.rdoNewDataFrame.TabIndex = 93
        Me.rdoNewDataFrame.TabStop = True
        Me.rdoNewDataFrame.Text = "New Data Frame"
        Me.rdoNewDataFrame.UseVisualStyleBackColor = True
        '
        'ucrReceiverComments
        '
        Me.ucrReceiverComments.AutoSize = True
        Me.ucrReceiverComments.frmParent = Me
        Me.ucrReceiverComments.Location = New System.Drawing.Point(427, 557)
        Me.ucrReceiverComments.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverComments.Name = "ucrReceiverComments"
        Me.ucrReceiverComments.Selector = Nothing
        Me.ucrReceiverComments.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverComments.strNcFilePath = ""
        Me.ucrReceiverComments.TabIndex = 92
        Me.ucrReceiverComments.ucrSelector = Nothing
        '
        'ucrChkAddReport
        '
        Me.ucrChkAddReport.AutoSize = True
        Me.ucrChkAddReport.Checked = False
        Me.ucrChkAddReport.Location = New System.Drawing.Point(8, 483)
        Me.ucrChkAddReport.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAddReport.Name = "ucrChkAddReport"
        Me.ucrChkAddReport.Size = New System.Drawing.Size(315, 34)
        Me.ucrChkAddReport.TabIndex = 91
        '
        'lblcomments
        '
        Me.lblcomments.AutoSize = True
        Me.lblcomments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblcomments.Location = New System.Drawing.Point(427, 531)
        Me.lblcomments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcomments.Name = "lblcomments"
        Me.lblcomments.Size = New System.Drawing.Size(90, 20)
        Me.lblcomments.TabIndex = 90
        Me.lblcomments.Tag = "New_Name"
        Me.lblcomments.Text = "Comments:"
        '
        'ucrDataFrameSheets
        '
        Me.ucrDataFrameSheets.AutoSize = True
        Me.ucrDataFrameSheets.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSheets.bUseCurrentFilter = True
        Me.ucrDataFrameSheets.Location = New System.Drawing.Point(17, 524)
        Me.ucrDataFrameSheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSheets.Name = "ucrDataFrameSheets"
        Me.ucrDataFrameSheets.Size = New System.Drawing.Size(226, 75)
        Me.ucrDataFrameSheets.TabIndex = 89
        '
        'ucrPnlOutput
        '
        Me.ucrPnlOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOutput.Location = New System.Drawing.Point(18, 377)
        Me.ucrPnlOutput.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlOutput.Name = "ucrPnlOutput"
        Me.ucrPnlOutput.Size = New System.Drawing.Size(226, 90)
        Me.ucrPnlOutput.TabIndex = 95
        '
        'grpSave
        '
        Me.grpSave.Location = New System.Drawing.Point(12, 356)
        Me.grpSave.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSave.Name = "grpSave"
        Me.grpSave.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSave.Size = New System.Drawing.Size(248, 110)
        Me.grpSave.TabIndex = 96
        Me.grpSave.TabStop = False
        Me.grpSave.Text = "Save"
        '
        'dlgExportToClimsoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(626, 775)
        Me.Controls.Add(Me.rdoExportData)
        Me.Controls.Add(Me.rdoNewDataFrame)
        Me.Controls.Add(Me.ucrReceiverComments)
        Me.Controls.Add(Me.ucrChkAddReport)
        Me.Controls.Add(Me.lblcomments)
        Me.Controls.Add(Me.ucrDataFrameSheets)
        Me.Controls.Add(Me.ucrPnlOutput)
        Me.Controls.Add(Me.grpSave)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.ucrReceiverStationID)
        Me.Controls.Add(Me.rdoDaily)
        Me.Controls.Add(Me.rdoHourly)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.ucrInputHour)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSelectorImportToClimsoft)
        Me.Controls.Add(Me.ucrPnlDailyHourly)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "dlgExportToClimsoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
    Friend WithEvents lblHour As Label
    Friend WithEvents ucrInputHour As ucrInputTextBox
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents lblExport As Label
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents rdoDaily As RadioButton
    Friend WithEvents rdoHourly As RadioButton
    Friend WithEvents ucrPnlDailyHourly As UcrPanel
    Friend WithEvents lblStationID As Label
    Friend WithEvents ucrReceiverStationID As ucrReceiverSingle
    Friend WithEvents rdoExportData As RadioButton
    Friend WithEvents rdoNewDataFrame As RadioButton
    Friend WithEvents ucrReceiverComments As ucrReceiverSingle
    Friend WithEvents ucrChkAddReport As ucrCheck
    Friend WithEvents lblcomments As Label
    Friend WithEvents ucrDataFrameSheets As ucrDataFrame
    Friend WithEvents ucrPnlOutput As UcrPanel
    Friend WithEvents grpSave As GroupBox
End Class
