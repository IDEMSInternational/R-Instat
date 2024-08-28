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
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ucrChkExportDataFrame = New instat.ucrCheck()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrChkNewDataFrame = New instat.ucrCheck()
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
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(417, 325)
        Me.lblElement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(80, 20)
        Me.lblElement.TabIndex = 12
        Me.lblElement.Text = "Elements:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(417, 197)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(417, 261)
        Me.lblHour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(48, 20)
        Me.lblHour.TabIndex = 10
        Me.lblHour.Text = "Hour:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(417, 73)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Text = "Station:"
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(14, 566)
        Me.lblExport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(88, 20)
        Me.lblExport.TabIndex = 17
        Me.lblExport.Text = "Export File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(489, 558)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(120, 34)
        Me.cmdBrowse.TabIndex = 19
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ucrChkExportDataFrame
        '
        Me.ucrChkExportDataFrame.AutoSize = True
        Me.ucrChkExportDataFrame.Checked = False
        Me.ucrChkExportDataFrame.Location = New System.Drawing.Point(14, 459)
        Me.ucrChkExportDataFrame.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkExportDataFrame.Name = "ucrChkExportDataFrame"
        Me.ucrChkExportDataFrame.Size = New System.Drawing.Size(399, 34)
        Me.ucrChkExportDataFrame.TabIndex = 15
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.AutoSize = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(213, 560)
        Me.ucrInputExportFile.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(273, 32)
        Me.ucrInputExportFile.TabIndex = 18
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(417, 101)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 5
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(14, 513)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(522, 36)
        Me.ucrSaveNewDataFrame.TabIndex = 16
        '
        'ucrChkNewDataFrame
        '
        Me.ucrChkNewDataFrame.AutoSize = True
        Me.ucrChkNewDataFrame.Checked = False
        Me.ucrChkNewDataFrame.Location = New System.Drawing.Point(14, 416)
        Me.ucrChkNewDataFrame.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkNewDataFrame.Name = "ucrChkNewDataFrame"
        Me.ucrChkNewDataFrame.Size = New System.Drawing.Size(399, 34)
        Me.ucrChkNewDataFrame.TabIndex = 14
        '
        'ucrInputHour
        '
        Me.ucrInputHour.AddQuotesIfUnrecognised = True
        Me.ucrInputHour.AutoSize = True
        Me.ucrInputHour.IsMultiline = False
        Me.ucrInputHour.IsReadOnly = False
        Me.ucrInputHour.Location = New System.Drawing.Point(417, 287)
        Me.ucrInputHour.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputHour.Name = "ucrInputHour"
        Me.ucrInputHour.Size = New System.Drawing.Size(178, 32)
        Me.ucrInputHour.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 604)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 20
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.AutoSize = True
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(417, 355)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(180, 150)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 13
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(417, 222)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 9
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
        Me.ucrReceiverStationID.Location = New System.Drawing.Point(414, 167)
        Me.ucrReceiverStationID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationID.Name = "ucrReceiverStationID"
        Me.ucrReceiverStationID.Selector = Nothing
        Me.ucrReceiverStationID.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStationID.strNcFilePath = ""
        Me.ucrReceiverStationID.TabIndex = 7
        Me.ucrReceiverStationID.ucrSelector = Nothing
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(419, 141)
        Me.lblStationID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(85, 20)
        Me.lblStationID.TabIndex = 6
        Me.lblStationID.Text = "Station ID:"
        '
        'dlgExportToClimsoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(626, 690)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.ucrReceiverStationID)
        Me.Controls.Add(Me.rdoDaily)
        Me.Controls.Add(Me.rdoHourly)
        Me.Controls.Add(Me.ucrChkExportDataFrame)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrChkNewDataFrame)
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
    Friend WithEvents ucrChkNewDataFrame As ucrCheck
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblExport As Label
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents ucrChkExportDataFrame As ucrCheck
    Friend WithEvents rdoDaily As RadioButton
    Friend WithEvents rdoHourly As RadioButton
    Friend WithEvents ucrPnlDailyHourly As UcrPanel
    Friend WithEvents lblStationID As Label
    Friend WithEvents ucrReceiverStationID As ucrReceiverSingle
End Class
