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
Partial Class dlgClimSoft
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
        Me.components = New System.ComponentModel.Container()
        Me.btnConnection = New System.Windows.Forms.Button()
        Me.lblSelectElements = New System.Windows.Forms.Label()
        Me.lblSelectStations = New System.Windows.Forms.Label()
        Me.ttClimsoft = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkImportElementsMetadata = New instat.ucrCheck()
        Me.ucrChkImportStationsMetadata = New instat.ucrCheck()
        Me.ucrChkDataDate = New instat.ucrCheck()
        Me.ucrDtpEndDataDate = New instat.ucrDateTimePicker()
        Me.ucrDtpStartDataDate = New instat.ucrDateTimePicker()
        Me.ucrChkImportFlagsMetadata = New instat.ucrCheck()
        Me.ucrChKUnstackData = New instat.ucrCheck()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lblToDataDate = New System.Windows.Forms.Label()
        Me.lblSelectTable = New System.Windows.Forms.Label()
        Me.lblSelectQCStatus = New System.Windows.Forms.Label()
        Me.btnCheckRecords = New System.Windows.Forms.Button()
        Me.lblRecordsNum = New System.Windows.Forms.Label()
        Me.btnMoreOptions = New System.Windows.Forms.Button()
        Me.rdoMetadata = New System.Windows.Forms.RadioButton()
        Me.rdoData = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrCboQCStatus = New instat.ucrInputComboBox()
        Me.ucrCboTable = New instat.ucrInputComboBox()
        Me.ucrCboElements = New instat.ucrInputComboBox()
        Me.ucrCboStations = New instat.ucrInputComboBox()
        Me.ucrSelectorForClimSoft = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverMultipleElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMultipleStations = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.btnUseDataFrameFilter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConnection
        '
        Me.btnConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnection.Location = New System.Drawing.Point(7, 45)
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(147, 23)
        Me.btnConnection.TabIndex = 1
        Me.btnConnection.Text = "Connect to Database"
        Me.btnConnection.UseVisualStyleBackColor = True
        '
        'lblSelectElements
        '
        Me.lblSelectElements.AutoSize = True
        Me.lblSelectElements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectElements.Location = New System.Drawing.Point(285, 248)
        Me.lblSelectElements.Name = "lblSelectElements"
        Me.lblSelectElements.Size = New System.Drawing.Size(86, 13)
        Me.lblSelectElements.TabIndex = 5
        Me.lblSelectElements.Text = "Select Elements:"
        '
        'lblSelectStations
        '
        Me.lblSelectStations.AutoSize = True
        Me.lblSelectStations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectStations.Location = New System.Drawing.Point(285, 70)
        Me.lblSelectStations.Name = "lblSelectStations"
        Me.lblSelectStations.Size = New System.Drawing.Size(81, 13)
        Me.lblSelectStations.TabIndex = 2
        Me.lblSelectStations.Text = "Select Stations:"
        Me.lblSelectStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrChkImportElementsMetadata
        '
        Me.ucrChkImportElementsMetadata.AutoSize = True
        Me.ucrChkImportElementsMetadata.Checked = True
        Me.ucrChkImportElementsMetadata.Location = New System.Drawing.Point(10, 110)
        Me.ucrChkImportElementsMetadata.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkImportElementsMetadata.Name = "ucrChkImportElementsMetadata"
        Me.ucrChkImportElementsMetadata.Size = New System.Drawing.Size(213, 23)
        Me.ucrChkImportElementsMetadata.TabIndex = 36
        Me.ttClimsoft.SetToolTip(Me.ucrChkImportElementsMetadata, "Unstack elements")
        '
        'ucrChkImportStationsMetadata
        '
        Me.ucrChkImportStationsMetadata.AutoSize = True
        Me.ucrChkImportStationsMetadata.Checked = True
        Me.ucrChkImportStationsMetadata.Location = New System.Drawing.Point(10, 85)
        Me.ucrChkImportStationsMetadata.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkImportStationsMetadata.Name = "ucrChkImportStationsMetadata"
        Me.ucrChkImportStationsMetadata.Size = New System.Drawing.Size(213, 23)
        Me.ucrChkImportStationsMetadata.TabIndex = 35
        Me.ttClimsoft.SetToolTip(Me.ucrChkImportStationsMetadata, "Unstack elements")
        '
        'ucrChkDataDate
        '
        Me.ucrChkDataDate.AutoSize = True
        Me.ucrChkDataDate.Checked = False
        Me.ucrChkDataDate.Location = New System.Drawing.Point(9, 317)
        Me.ucrChkDataDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkDataDate.Name = "ucrChkDataDate"
        Me.ucrChkDataDate.Size = New System.Drawing.Size(169, 23)
        Me.ucrChkDataDate.TabIndex = 21
        Me.ttClimsoft.SetToolTip(Me.ucrChkDataDate, "Select Observation Data Date Range")
        '
        'ucrDtpEndDataDate
        '
        Me.ucrDtpEndDataDate.AutoSize = True
        Me.ucrDtpEndDataDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 379)
        Me.ucrDtpEndDataDate.Format = "dd MMM yyyy"
        Me.ucrDtpEndDataDate.Location = New System.Drawing.Point(156, 340)
        Me.ucrDtpEndDataDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpEndDataDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDataDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDataDate.Name = "ucrDtpEndDataDate"
        Me.ucrDtpEndDataDate.Size = New System.Drawing.Size(102, 20)
        Me.ucrDtpEndDataDate.TabIndex = 23
        Me.ttClimsoft.SetToolTip(Me.ucrDtpEndDataDate, "End Date (To)")
        '
        'ucrDtpStartDataDate
        '
        Me.ucrDtpStartDataDate.AutoSize = True
        Me.ucrDtpStartDataDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 408)
        Me.ucrDtpStartDataDate.Format = "dd MMM yyyy"
        Me.ucrDtpStartDataDate.Location = New System.Drawing.Point(23, 341)
        Me.ucrDtpStartDataDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpStartDataDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartDataDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartDataDate.Name = "ucrDtpStartDataDate"
        Me.ucrDtpStartDataDate.Size = New System.Drawing.Size(102, 20)
        Me.ucrDtpStartDataDate.TabIndex = 22
        Me.ttClimsoft.SetToolTip(Me.ucrDtpStartDataDate, "Start Date (From)")
        '
        'ucrChkImportFlagsMetadata
        '
        Me.ucrChkImportFlagsMetadata.AutoSize = True
        Me.ucrChkImportFlagsMetadata.Checked = True
        Me.ucrChkImportFlagsMetadata.Location = New System.Drawing.Point(10, 135)
        Me.ucrChkImportFlagsMetadata.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkImportFlagsMetadata.Name = "ucrChkImportFlagsMetadata"
        Me.ucrChkImportFlagsMetadata.Size = New System.Drawing.Size(213, 23)
        Me.ucrChkImportFlagsMetadata.TabIndex = 37
        Me.ttClimsoft.SetToolTip(Me.ucrChkImportFlagsMetadata, "Unstack elements")
        '
        'ucrChKUnstackData
        '
        Me.ucrChKUnstackData.AutoSize = True
        Me.ucrChKUnstackData.Checked = False
        Me.ucrChKUnstackData.Location = New System.Drawing.Point(8, 289)
        Me.ucrChKUnstackData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChKUnstackData.Name = "ucrChKUnstackData"
        Me.ucrChKUnstackData.Size = New System.Drawing.Size(169, 23)
        Me.ucrChKUnstackData.TabIndex = 38
        Me.ttClimsoft.SetToolTip(Me.ucrChKUnstackData, "Select Observation Data Date Range")
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(164, 51)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 16
        Me.lblConnection.Text = "No Connection"
        '
        'lblToDataDate
        '
        Me.lblToDataDate.AutoSize = True
        Me.lblToDataDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblToDataDate.Location = New System.Drawing.Point(130, 345)
        Me.lblToDataDate.Name = "lblToDataDate"
        Me.lblToDataDate.Size = New System.Drawing.Size(20, 13)
        Me.lblToDataDate.TabIndex = 20
        Me.lblToDataDate.Text = "To"
        '
        'lblSelectTable
        '
        Me.lblSelectTable.AutoSize = True
        Me.lblSelectTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectTable.Location = New System.Drawing.Point(5, 238)
        Me.lblSelectTable.Name = "lblSelectTable"
        Me.lblSelectTable.Size = New System.Drawing.Size(96, 13)
        Me.lblSelectTable.TabIndex = 24
        Me.lblSelectTable.Text = "Select Data Table:"
        Me.lblSelectTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelectQCStatus
        '
        Me.lblSelectQCStatus.AutoSize = True
        Me.lblSelectQCStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectQCStatus.Location = New System.Drawing.Point(5, 265)
        Me.lblSelectQCStatus.Name = "lblSelectQCStatus"
        Me.lblSelectQCStatus.Size = New System.Drawing.Size(117, 13)
        Me.lblSelectQCStatus.TabIndex = 26
        Me.lblSelectQCStatus.Text = "Select Data QC Status:"
        Me.lblSelectQCStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckRecords
        '
        Me.btnCheckRecords.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCheckRecords.Location = New System.Drawing.Point(6, 404)
        Me.btnCheckRecords.Name = "btnCheckRecords"
        Me.btnCheckRecords.Size = New System.Drawing.Size(139, 23)
        Me.btnCheckRecords.TabIndex = 28
        Me.btnCheckRecords.Text = "Check Records"
        Me.btnCheckRecords.UseVisualStyleBackColor = True
        '
        'lblRecordsNum
        '
        Me.lblRecordsNum.AutoSize = True
        Me.lblRecordsNum.ForeColor = System.Drawing.Color.Red
        Me.lblRecordsNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecordsNum.Location = New System.Drawing.Point(156, 408)
        Me.lblRecordsNum.Name = "lblRecordsNum"
        Me.lblRecordsNum.Size = New System.Drawing.Size(64, 13)
        Me.lblRecordsNum.TabIndex = 29
        Me.lblRecordsNum.Text = "No Records"
        '
        'btnMoreOptions
        '
        Me.btnMoreOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMoreOptions.Location = New System.Drawing.Point(5, 373)
        Me.btnMoreOptions.Name = "btnMoreOptions"
        Me.btnMoreOptions.Size = New System.Drawing.Size(139, 23)
        Me.btnMoreOptions.TabIndex = 31
        Me.btnMoreOptions.Text = "Options"
        Me.btnMoreOptions.UseVisualStyleBackColor = True
        '
        'rdoMetadata
        '
        Me.rdoMetadata.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMetadata.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMetadata.FlatAppearance.BorderSize = 2
        Me.rdoMetadata.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMetadata.Location = New System.Drawing.Point(197, 5)
        Me.rdoMetadata.Name = "rdoMetadata"
        Me.rdoMetadata.Size = New System.Drawing.Size(145, 28)
        Me.rdoMetadata.TabIndex = 34
        Me.rdoMetadata.TabStop = True
        Me.rdoMetadata.Tag = ""
        Me.rdoMetadata.Text = "Metadata"
        Me.rdoMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMetadata.UseVisualStyleBackColor = True
        '
        'rdoData
        '
        Me.rdoData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoData.FlatAppearance.BorderSize = 2
        Me.rdoData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoData.Location = New System.Drawing.Point(55, 5)
        Me.rdoData.Name = "rdoData"
        Me.rdoData.Size = New System.Drawing.Size(145, 28)
        Me.rdoData.TabIndex = 33
        Me.rdoData.TabStop = True
        Me.rdoData.Tag = ""
        Me.rdoData.Text = "Observation Data"
        Me.rdoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoData.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(6, 4)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(428, 30)
        Me.ucrPnlOptions.TabIndex = 32
        '
        'ucrCboQCStatus
        '
        Me.ucrCboQCStatus.AddQuotesIfUnrecognised = True
        Me.ucrCboQCStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboQCStatus.GetSetSelectedIndex = -1
        Me.ucrCboQCStatus.IsReadOnly = False
        Me.ucrCboQCStatus.Location = New System.Drawing.Point(154, 259)
        Me.ucrCboQCStatus.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboQCStatus.Name = "ucrCboQCStatus"
        Me.ucrCboQCStatus.Size = New System.Drawing.Size(104, 21)
        Me.ucrCboQCStatus.TabIndex = 27
        '
        'ucrCboTable
        '
        Me.ucrCboTable.AddQuotesIfUnrecognised = True
        Me.ucrCboTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboTable.GetSetSelectedIndex = -1
        Me.ucrCboTable.IsReadOnly = False
        Me.ucrCboTable.Location = New System.Drawing.Point(154, 233)
        Me.ucrCboTable.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboTable.Name = "ucrCboTable"
        Me.ucrCboTable.Size = New System.Drawing.Size(104, 21)
        Me.ucrCboTable.TabIndex = 25
        '
        'ucrCboElements
        '
        Me.ucrCboElements.AddQuotesIfUnrecognised = True
        Me.ucrCboElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboElements.GetSetSelectedIndex = -1
        Me.ucrCboElements.IsReadOnly = False
        Me.ucrCboElements.Location = New System.Drawing.Point(288, 264)
        Me.ucrCboElements.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboElements.Name = "ucrCboElements"
        Me.ucrCboElements.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboElements.TabIndex = 6
        '
        'ucrCboStations
        '
        Me.ucrCboStations.AddQuotesIfUnrecognised = True
        Me.ucrCboStations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboStations.GetSetSelectedIndex = -1
        Me.ucrCboStations.IsReadOnly = False
        Me.ucrCboStations.Location = New System.Drawing.Point(285, 85)
        Me.ucrCboStations.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboStations.Name = "ucrCboStations"
        Me.ucrCboStations.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboStations.TabIndex = 3
        '
        'ucrSelectorForClimSoft
        '
        Me.ucrSelectorForClimSoft.AutoSize = True
        Me.ucrSelectorForClimSoft.bShowHiddenColumns = False
        Me.ucrSelectorForClimSoft.Location = New System.Drawing.Point(7, 84)
        Me.ucrSelectorForClimSoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForClimSoft.Name = "ucrSelectorForClimSoft"
        Me.ucrSelectorForClimSoft.Size = New System.Drawing.Size(216, 147)
        Me.ucrSelectorForClimSoft.TabIndex = 2
        '
        'ucrReceiverMultipleElements
        '
        Me.ucrReceiverMultipleElements.AutoSize = True
        Me.ucrReceiverMultipleElements.frmParent = Me
        Me.ucrReceiverMultipleElements.Location = New System.Drawing.Point(288, 288)
        Me.ucrReceiverMultipleElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleElements.Name = "ucrReceiverMultipleElements"
        Me.ucrReceiverMultipleElements.Selector = Nothing
        Me.ucrReceiverMultipleElements.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverMultipleElements.strNcFilePath = ""
        Me.ucrReceiverMultipleElements.TabIndex = 7
        Me.ucrReceiverMultipleElements.ucrSelector = Nothing
        '
        'ucrReceiverMultipleStations
        '
        Me.ucrReceiverMultipleStations.AutoSize = True
        Me.ucrReceiverMultipleStations.frmParent = Me
        Me.ucrReceiverMultipleStations.Location = New System.Drawing.Point(285, 136)
        Me.ucrReceiverMultipleStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleStations.Name = "ucrReceiverMultipleStations"
        Me.ucrReceiverMultipleStations.Selector = Nothing
        Me.ucrReceiverMultipleStations.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverMultipleStations.strNcFilePath = ""
        Me.ucrReceiverMultipleStations.TabIndex = 4
        Me.ucrReceiverMultipleStations.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 444)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 14
        '
        'btnUseDataFrameFilter
        '
        Me.btnUseDataFrameFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnUseDataFrameFilter.Location = New System.Drawing.Point(284, 110)
        Me.btnUseDataFrameFilter.Name = "btnUseDataFrameFilter"
        Me.btnUseDataFrameFilter.Size = New System.Drawing.Size(137, 23)
        Me.btnUseDataFrameFilter.TabIndex = 39
        Me.btnUseDataFrameFilter.Text = "Use Data Frame Filter"
        Me.btnUseDataFrameFilter.UseVisualStyleBackColor = True
        '
        'dlgClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(438, 505)
        Me.Controls.Add(Me.btnUseDataFrameFilter)
        Me.Controls.Add(Me.ucrChKUnstackData)
        Me.Controls.Add(Me.ucrChkImportFlagsMetadata)
        Me.Controls.Add(Me.ucrChkImportElementsMetadata)
        Me.Controls.Add(Me.ucrChkImportStationsMetadata)
        Me.Controls.Add(Me.rdoMetadata)
        Me.Controls.Add(Me.rdoData)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.btnMoreOptions)
        Me.Controls.Add(Me.lblRecordsNum)
        Me.Controls.Add(Me.btnCheckRecords)
        Me.Controls.Add(Me.ucrCboQCStatus)
        Me.Controls.Add(Me.lblSelectQCStatus)
        Me.Controls.Add(Me.ucrCboTable)
        Me.Controls.Add(Me.lblSelectTable)
        Me.Controls.Add(Me.ucrChkDataDate)
        Me.Controls.Add(Me.ucrDtpEndDataDate)
        Me.Controls.Add(Me.ucrDtpStartDataDate)
        Me.Controls.Add(Me.lblToDataDate)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.ucrCboElements)
        Me.Controls.Add(Me.ucrCboStations)
        Me.Controls.Add(Me.ucrSelectorForClimSoft)
        Me.Controls.Add(Me.ucrReceiverMultipleElements)
        Me.Controls.Add(Me.lblSelectStations)
        Me.Controls.Add(Me.lblSelectElements)
        Me.Controls.Add(Me.ucrReceiverMultipleStations)
        Me.Controls.Add(Me.btnConnection)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimSoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From Climsoft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents btnConnection As Button
    Friend WithEvents ucrReceiverMultipleStations As ucrReceiverMultiple
    Friend WithEvents ucrReceiverMultipleElements As ucrReceiverMultiple
    Friend WithEvents lblSelectStations As Label
    Friend WithEvents lblSelectElements As Label
    Friend WithEvents ucrSelectorForClimSoft As ucrSelectorAddRemove
    Friend WithEvents ttClimsoft As ToolTip
    Friend WithEvents ucrCboStations As ucrInputComboBox
    Friend WithEvents ucrCboElements As ucrInputComboBox
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrChkDataDate As ucrCheck
    Friend WithEvents ucrDtpEndDataDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartDataDate As ucrDateTimePicker
    Friend WithEvents lblToDataDate As Label
    Friend WithEvents ucrCboTable As ucrInputComboBox
    Friend WithEvents lblSelectTable As Label
    Friend WithEvents ucrCboQCStatus As ucrInputComboBox
    Friend WithEvents lblSelectQCStatus As Label
    Friend WithEvents lblRecordsNum As Label
    Friend WithEvents btnCheckRecords As Button
    Friend WithEvents btnMoreOptions As Button
    Friend WithEvents rdoMetadata As RadioButton
    Friend WithEvents rdoData As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrChkImportElementsMetadata As ucrCheck
    Friend WithEvents ucrChkImportStationsMetadata As ucrCheck
    Friend WithEvents ucrChkImportFlagsMetadata As ucrCheck
    Friend WithEvents ucrChKUnstackData As ucrCheck
    Friend WithEvents btnUseDataFrameFilter As Button
End Class