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
        Me.rdoHourly = New System.Windows.Forms.RadioButton()
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.rdoExportData = New System.Windows.Forms.RadioButton()
        Me.rdoNewDataFrame = New System.Windows.Forms.RadioButton()
        Me.grpSave = New System.Windows.Forms.GroupBox()
        Me.rdoExportComments = New System.Windows.Forms.RadioButton()
        Me.ucrDataFrameSheets = New instat.ucrDataFrame()
        Me.ucrPnlOutput = New instat.UcrPanel()
        Me.ucrReceiverStationID = New instat.ucrReceiverSingle()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrInputHour = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorImportToClimsoft = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlDailyHourly = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(278, 179)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(53, 13)
        Me.lblElement.TabIndex = 10
        Me.lblElement.Text = "Elements:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(278, 93)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date:"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(278, 136)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(33, 13)
        Me.lblHour.TabIndex = 8
        Me.lblHour.Text = "Hour:"
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(9, 431)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(59, 13)
        Me.lblExport.TabIndex = 15
        Me.lblExport.Text = "Export File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(326, 426)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(80, 23)
        Me.cmdBrowse.TabIndex = 17
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
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
        Me.rdoHourly.Location = New System.Drawing.Point(190, 8)
        Me.rdoHourly.Name = "rdoHourly"
        Me.rdoHourly.Size = New System.Drawing.Size(91, 28)
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
        Me.rdoDaily.Location = New System.Drawing.Point(101, 8)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(91, 28)
        Me.rdoDaily.TabIndex = 1
        Me.rdoDaily.TabStop = True
        Me.rdoDaily.Tag = "Frequency"
        Me.rdoDaily.Text = "Daily"
        Me.rdoDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDaily.UseVisualStyleBackColor = False
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(279, 56)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(57, 13)
        Me.lblStationID.TabIndex = 4
        Me.lblStationID.Text = "Station ID:"
        '
        'rdoExportData
        '
        Me.rdoExportData.AutoSize = True
        Me.rdoExportData.Location = New System.Drawing.Point(15, 281)
        Me.rdoExportData.Name = "rdoExportData"
        Me.rdoExportData.Size = New System.Drawing.Size(107, 17)
        Me.rdoExportData.TabIndex = 94
        Me.rdoExportData.TabStop = True
        Me.rdoExportData.Text = "Export Data (csv)"
        Me.rdoExportData.UseVisualStyleBackColor = True
        '
        'rdoNewDataFrame
        '
        Me.rdoNewDataFrame.AutoSize = True
        Me.rdoNewDataFrame.Location = New System.Drawing.Point(15, 252)
        Me.rdoNewDataFrame.Name = "rdoNewDataFrame"
        Me.rdoNewDataFrame.Size = New System.Drawing.Size(105, 17)
        Me.rdoNewDataFrame.TabIndex = 93
        Me.rdoNewDataFrame.TabStop = True
        Me.rdoNewDataFrame.Text = "New Data Frame"
        Me.rdoNewDataFrame.UseVisualStyleBackColor = True
        '
        'grpSave
        '
        Me.grpSave.Location = New System.Drawing.Point(8, 237)
        Me.grpSave.Name = "grpSave"
        Me.grpSave.Size = New System.Drawing.Size(165, 109)
        Me.grpSave.TabIndex = 96
        Me.grpSave.TabStop = False
        Me.grpSave.Text = "Save"
        '
        'rdoExportComments
        '
        Me.rdoExportComments.AutoSize = True
        Me.rdoExportComments.Location = New System.Drawing.Point(15, 306)
        Me.rdoExportComments.Name = "rdoExportComments"
        Me.rdoExportComments.Size = New System.Drawing.Size(107, 17)
        Me.rdoExportComments.TabIndex = 97
        Me.rdoExportComments.TabStop = True
        Me.rdoExportComments.Text = "Export Comments"
        Me.rdoExportComments.UseVisualStyleBackColor = True
        '
        'ucrDataFrameSheets
        '
        Me.ucrDataFrameSheets.AutoSize = True
        Me.ucrDataFrameSheets.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSheets.bUseCurrentFilter = True
        Me.ucrDataFrameSheets.Location = New System.Drawing.Point(11, 349)
        Me.ucrDataFrameSheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSheets.Name = "ucrDataFrameSheets"
        Me.ucrDataFrameSheets.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameSheets.TabIndex = 89
        '
        'ucrPnlOutput
        '
        Me.ucrPnlOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOutput.Location = New System.Drawing.Point(12, 251)
        Me.ucrPnlOutput.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlOutput.Name = "ucrPnlOutput"
        Me.ucrPnlOutput.Size = New System.Drawing.Size(151, 86)
        Me.ucrPnlOutput.TabIndex = 95
        '
        'ucrReceiverStationID
        '
        Me.ucrReceiverStationID.AutoSize = True
        Me.ucrReceiverStationID.frmParent = Me
        Me.ucrReceiverStationID.Location = New System.Drawing.Point(276, 73)
        Me.ucrReceiverStationID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationID.Name = "ucrReceiverStationID"
        Me.ucrReceiverStationID.Selector = Nothing
        Me.ucrReceiverStationID.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationID.strNcFilePath = ""
        Me.ucrReceiverStationID.TabIndex = 5
        Me.ucrReceiverStationID.ucrSelector = Nothing
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.AutoSize = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(142, 427)
        Me.ucrInputExportFile.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(182, 21)
        Me.ucrInputExportFile.TabIndex = 16
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(9, 399)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(348, 24)
        Me.ucrSaveNewDataFrame.TabIndex = 14
        '
        'ucrInputHour
        '
        Me.ucrInputHour.AddQuotesIfUnrecognised = True
        Me.ucrInputHour.AutoSize = True
        Me.ucrInputHour.IsMultiline = False
        Me.ucrInputHour.IsReadOnly = False
        Me.ucrInputHour.Location = New System.Drawing.Point(278, 153)
        Me.ucrInputHour.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputHour.Name = "ucrInputHour"
        Me.ucrInputHour.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputHour.TabIndex = 9
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 459)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 18
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.AutoSize = True
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(278, 199)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 11
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(278, 110)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
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
        Me.ucrSelectorImportToClimsoft.Location = New System.Drawing.Point(9, 52)
        Me.ucrSelectorImportToClimsoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorImportToClimsoft.Name = "ucrSelectorImportToClimsoft"
        Me.ucrSelectorImportToClimsoft.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorImportToClimsoft.TabIndex = 3
        '
        'ucrPnlDailyHourly
        '
        Me.ucrPnlDailyHourly.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDailyHourly.Location = New System.Drawing.Point(91, 8)
        Me.ucrPnlDailyHourly.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrPnlDailyHourly.Name = "ucrPnlDailyHourly"
        Me.ucrPnlDailyHourly.Size = New System.Drawing.Size(207, 28)
        Me.ucrPnlDailyHourly.TabIndex = 0
        '
        'dlgExportToClimsoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 467)
        Me.Controls.Add(Me.rdoExportComments)
        Me.Controls.Add(Me.rdoExportData)
        Me.Controls.Add(Me.rdoNewDataFrame)
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
    Friend WithEvents ucrDataFrameSheets As ucrDataFrame
    Friend WithEvents ucrPnlOutput As UcrPanel
    Friend WithEvents grpSave As GroupBox
    Friend WithEvents rdoExportComments As RadioButton
End Class
