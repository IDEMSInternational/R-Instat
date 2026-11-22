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
Partial Class dlgImportGriddedData
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
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblMaxLat = New System.Windows.Forms.Label()
        Me.lblLon = New System.Windows.Forms.Label()
        Me.lblMaxLon = New System.Windows.Forms.Label()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.grpDateRange = New System.Windows.Forms.GroupBox()
        Me.rdoCustomRange = New System.Windows.Forms.RadioButton()
        Me.rdoEntireRange = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrDtpMinDate = New instat.ucrDateTimePicker()
        Me.ucrDtpMaxDate = New instat.ucrDateTimePicker()
        Me.ucrPnlDateRange = New instat.UcrPanel()
        Me.grpLocationRange = New System.Windows.Forms.GroupBox()
        Me.rdoPoint = New System.Windows.Forms.RadioButton()
        Me.rdoArea = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLocationRange = New instat.UcrPanel()
        Me.lblMinLon = New System.Windows.Forms.Label()
        Me.lblMinLat = New System.Windows.Forms.Label()
        Me.ucrInputMinLon = New instat.ucrInputTextBox()
        Me.ucrInputMinLat = New instat.ucrInputTextBox()
        Me.ucrInputMaxLat = New instat.ucrInputTextBox()
        Me.ucrInputMaxLon = New instat.ucrInputTextBox()
        Me.lblSaveDownloadedFileTo = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrChkDontImportData = New instat.ucrCheck()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputData = New instat.ucrInputComboBox()
        Me.ucrInputSource = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpImportIRIVariable = New System.Windows.Forms.GroupBox()
        Me.rdoMaxPlantValue = New System.Windows.Forms.RadioButton()
        Me.rdoVariableMaxPlant = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMaxPlantingDate = New instat.UcrPanel()
        Me.ucrNudMaxPlantingDate = New instat.ucrNud()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.lblLongtude = New System.Windows.Forms.Label()
        Me.lblPlantingDateMin = New System.Windows.Forms.Label()
        Me.lblPlantingDateMax = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.ucrReceiverMaxPlantingDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinPlantingDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongtitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverIDVariable = New instat.ucrReceiverSingle()
        Me.lblIDVariable = New System.Windows.Forms.Label()
        Me.ucrSelectorIRIVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoIRIVariable = New System.Windows.Forms.RadioButton()
        Me.rdoIRIValue = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.grpDateRange.SuspendLayout()
        Me.grpLocationRange.SuspendLayout()
        Me.grpImportIRIVariable.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLat.Location = New System.Drawing.Point(11, 92)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(48, 13)
        Me.lblLat.TabIndex = 10
        Me.lblLat.Text = "Latitude:"
        '
        'lblMaxLat
        '
        Me.lblMaxLat.AutoSize = True
        Me.lblMaxLat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxLat.Location = New System.Drawing.Point(179, 92)
        Me.lblMaxLat.Name = "lblMaxLat"
        Me.lblMaxLat.Size = New System.Drawing.Size(27, 13)
        Me.lblMaxLat.TabIndex = 12
        Me.lblMaxLat.Text = "Max"
        '
        'lblLon
        '
        Me.lblLon.AutoSize = True
        Me.lblLon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLon.Location = New System.Drawing.Point(11, 67)
        Me.lblLon.Name = "lblLon"
        Me.lblLon.Size = New System.Drawing.Size(57, 13)
        Me.lblLon.TabIndex = 6
        Me.lblLon.Text = "Longitude:"
        '
        'lblMaxLon
        '
        Me.lblMaxLon.AutoSize = True
        Me.lblMaxLon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxLon.Location = New System.Drawing.Point(179, 67)
        Me.lblMaxLon.Name = "lblMaxLon"
        Me.lblMaxLon.Size = New System.Drawing.Size(27, 13)
        Me.lblMaxLon.TabIndex = 8
        Me.lblMaxLon.Text = "Max"
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(8, 403)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDataFrameName.TabIndex = 10
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSource.Location = New System.Drawing.Point(8, 10)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(44, 13)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "Source:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(8, 37)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Data:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(338, 350)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(71, 23)
        Me.cmdBrowse.TabIndex = 8
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'grpDateRange
        '
        Me.grpDateRange.Controls.Add(Me.rdoCustomRange)
        Me.grpDateRange.Controls.Add(Me.rdoEntireRange)
        Me.grpDateRange.Controls.Add(Me.lblTo)
        Me.grpDateRange.Controls.Add(Me.lblFrom)
        Me.grpDateRange.Controls.Add(Me.ucrDtpMinDate)
        Me.grpDateRange.Controls.Add(Me.ucrDtpMaxDate)
        Me.grpDateRange.Controls.Add(Me.ucrPnlDateRange)
        Me.grpDateRange.Location = New System.Drawing.Point(3, 112)
        Me.grpDateRange.Name = "grpDateRange"
        Me.grpDateRange.Size = New System.Drawing.Size(408, 117)
        Me.grpDateRange.TabIndex = 4
        Me.grpDateRange.TabStop = False
        Me.grpDateRange.Text = "Date Range"
        '
        'rdoCustomRange
        '
        Me.rdoCustomRange.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCustomRange.BackColor = System.Drawing.SystemColors.Control
        Me.rdoCustomRange.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCustomRange.FlatAppearance.BorderSize = 2
        Me.rdoCustomRange.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCustomRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCustomRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCustomRange.Location = New System.Drawing.Point(201, 25)
        Me.rdoCustomRange.Name = "rdoCustomRange"
        Me.rdoCustomRange.Size = New System.Drawing.Size(127, 28)
        Me.rdoCustomRange.TabIndex = 21
        Me.rdoCustomRange.TabStop = True
        Me.rdoCustomRange.Tag = ""
        Me.rdoCustomRange.Text = "Custom Range"
        Me.rdoCustomRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCustomRange.UseVisualStyleBackColor = False
        '
        'rdoEntireRange
        '
        Me.rdoEntireRange.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEntireRange.BackColor = System.Drawing.SystemColors.Control
        Me.rdoEntireRange.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEntireRange.FlatAppearance.BorderSize = 2
        Me.rdoEntireRange.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEntireRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEntireRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEntireRange.Location = New System.Drawing.Point(76, 25)
        Me.rdoEntireRange.Name = "rdoEntireRange"
        Me.rdoEntireRange.Size = New System.Drawing.Size(127, 28)
        Me.rdoEntireRange.TabIndex = 22
        Me.rdoEntireRange.TabStop = True
        Me.rdoEntireRange.Tag = ""
        Me.rdoEntireRange.Text = "Entire Range"
        Me.rdoEntireRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEntireRange.UseVisualStyleBackColor = False
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(11, 93)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(11, 69)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'ucrDtpMinDate
        '
        Me.ucrDtpMinDate.AutoSize = True
        Me.ucrDtpMinDate.DateValue = New Date(2021, 5, 18, 13, 18, 46, 901)
        Me.ucrDtpMinDate.Format = "dd MMM yyyy"
        Me.ucrDtpMinDate.Location = New System.Drawing.Point(48, 65)
        Me.ucrDtpMinDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpMinDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpMinDate.Name = "ucrDtpMinDate"
        Me.ucrDtpMinDate.Size = New System.Drawing.Size(180, 20)
        Me.ucrDtpMinDate.TabIndex = 1
        '
        'ucrDtpMaxDate
        '
        Me.ucrDtpMaxDate.AutoSize = True
        Me.ucrDtpMaxDate.DateValue = New Date(2021, 5, 18, 13, 18, 46, 931)
        Me.ucrDtpMaxDate.Format = "dd MMM yyyy"
        Me.ucrDtpMaxDate.Location = New System.Drawing.Point(48, 90)
        Me.ucrDtpMaxDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpMaxDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpMaxDate.Name = "ucrDtpMaxDate"
        Me.ucrDtpMaxDate.Size = New System.Drawing.Size(180, 20)
        Me.ucrDtpMaxDate.TabIndex = 3
        '
        'ucrPnlDateRange
        '
        Me.ucrPnlDateRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDateRange.Location = New System.Drawing.Point(75, 20)
        Me.ucrPnlDateRange.Name = "ucrPnlDateRange"
        Me.ucrPnlDateRange.Size = New System.Drawing.Size(253, 37)
        Me.ucrPnlDateRange.TabIndex = 23
        '
        'grpLocationRange
        '
        Me.grpLocationRange.Controls.Add(Me.rdoPoint)
        Me.grpLocationRange.Controls.Add(Me.rdoArea)
        Me.grpLocationRange.Controls.Add(Me.ucrPnlLocationRange)
        Me.grpLocationRange.Controls.Add(Me.lblMinLon)
        Me.grpLocationRange.Controls.Add(Me.lblMinLat)
        Me.grpLocationRange.Controls.Add(Me.ucrInputMinLon)
        Me.grpLocationRange.Controls.Add(Me.ucrInputMinLat)
        Me.grpLocationRange.Controls.Add(Me.lblMaxLon)
        Me.grpLocationRange.Controls.Add(Me.lblMaxLat)
        Me.grpLocationRange.Controls.Add(Me.ucrInputMaxLat)
        Me.grpLocationRange.Controls.Add(Me.ucrInputMaxLon)
        Me.grpLocationRange.Controls.Add(Me.lblLon)
        Me.grpLocationRange.Controls.Add(Me.lblLat)
        Me.grpLocationRange.Location = New System.Drawing.Point(3, 229)
        Me.grpLocationRange.Name = "grpLocationRange"
        Me.grpLocationRange.Size = New System.Drawing.Size(408, 117)
        Me.grpLocationRange.TabIndex = 5
        Me.grpLocationRange.TabStop = False
        Me.grpLocationRange.Text = "Location Range"
        '
        'rdoPoint
        '
        Me.rdoPoint.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPoint.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPoint.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoint.FlatAppearance.BorderSize = 2
        Me.rdoPoint.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPoint.Location = New System.Drawing.Point(104, 19)
        Me.rdoPoint.Name = "rdoPoint"
        Me.rdoPoint.Size = New System.Drawing.Size(102, 28)
        Me.rdoPoint.TabIndex = 24
        Me.rdoPoint.TabStop = True
        Me.rdoPoint.Tag = ""
        Me.rdoPoint.Text = "Point"
        Me.rdoPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPoint.UseVisualStyleBackColor = False
        '
        'rdoArea
        '
        Me.rdoArea.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoArea.BackColor = System.Drawing.SystemColors.Control
        Me.rdoArea.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoArea.FlatAppearance.BorderSize = 2
        Me.rdoArea.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoArea.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoArea.Location = New System.Drawing.Point(204, 19)
        Me.rdoArea.Name = "rdoArea"
        Me.rdoArea.Size = New System.Drawing.Size(102, 28)
        Me.rdoArea.TabIndex = 25
        Me.rdoArea.TabStop = True
        Me.rdoArea.Tag = ""
        Me.rdoArea.Text = "Area"
        Me.rdoArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoArea.UseVisualStyleBackColor = False
        '
        'ucrPnlLocationRange
        '
        Me.ucrPnlLocationRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLocationRange.Location = New System.Drawing.Point(103, 16)
        Me.ucrPnlLocationRange.Name = "ucrPnlLocationRange"
        Me.ucrPnlLocationRange.Size = New System.Drawing.Size(214, 37)
        Me.ucrPnlLocationRange.TabIndex = 26
        '
        'lblMinLon
        '
        Me.lblMinLon.AutoSize = True
        Me.lblMinLon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinLon.Location = New System.Drawing.Point(72, 67)
        Me.lblMinLon.Name = "lblMinLon"
        Me.lblMinLon.Size = New System.Drawing.Size(24, 13)
        Me.lblMinLon.TabIndex = 10
        Me.lblMinLon.Text = "Min"
        '
        'lblMinLat
        '
        Me.lblMinLat.AutoSize = True
        Me.lblMinLat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinLat.Location = New System.Drawing.Point(72, 92)
        Me.lblMinLat.Name = "lblMinLat"
        Me.lblMinLat.Size = New System.Drawing.Size(24, 13)
        Me.lblMinLat.TabIndex = 9
        Me.lblMinLat.Text = "Min"
        '
        'ucrInputMinLon
        '
        Me.ucrInputMinLon.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLon.AutoSize = True
        Me.ucrInputMinLon.IsMultiline = False
        Me.ucrInputMinLon.IsReadOnly = False
        Me.ucrInputMinLon.Location = New System.Drawing.Point(99, 64)
        Me.ucrInputMinLon.Name = "ucrInputMinLon"
        Me.ucrInputMinLon.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputMinLon.TabIndex = 7
        '
        'ucrInputMinLat
        '
        Me.ucrInputMinLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLat.AutoSize = True
        Me.ucrInputMinLat.IsMultiline = False
        Me.ucrInputMinLat.IsReadOnly = False
        Me.ucrInputMinLat.Location = New System.Drawing.Point(99, 88)
        Me.ucrInputMinLat.Name = "ucrInputMinLat"
        Me.ucrInputMinLat.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputMinLat.TabIndex = 11
        '
        'ucrInputMaxLat
        '
        Me.ucrInputMaxLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLat.AutoSize = True
        Me.ucrInputMaxLat.IsMultiline = False
        Me.ucrInputMaxLat.IsReadOnly = False
        Me.ucrInputMaxLat.Location = New System.Drawing.Point(210, 88)
        Me.ucrInputMaxLat.Name = "ucrInputMaxLat"
        Me.ucrInputMaxLat.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputMaxLat.TabIndex = 13
        '
        'ucrInputMaxLon
        '
        Me.ucrInputMaxLon.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLon.AutoSize = True
        Me.ucrInputMaxLon.IsMultiline = False
        Me.ucrInputMaxLon.IsReadOnly = False
        Me.ucrInputMaxLon.Location = New System.Drawing.Point(210, 64)
        Me.ucrInputMaxLon.Name = "ucrInputMaxLon"
        Me.ucrInputMaxLon.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputMaxLon.TabIndex = 9
        '
        'lblSaveDownloadedFileTo
        '
        Me.lblSaveDownloadedFileTo.AutoSize = True
        Me.lblSaveDownloadedFileTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveDownloadedFileTo.Location = New System.Drawing.Point(5, 355)
        Me.lblSaveDownloadedFileTo.Name = "lblSaveDownloadedFileTo"
        Me.lblSaveDownloadedFileTo.Size = New System.Drawing.Size(133, 13)
        Me.lblSaveDownloadedFileTo.TabIndex = 6
        Me.lblSaveDownloadedFileTo.Text = "Save Downloaded File To:"
        '
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.AutoSize = True
        Me.ucrInputNewDataFrameName.IsMultiline = False
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        Me.ucrInputNewDataFrameName.Location = New System.Drawing.Point(199, 398)
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        Me.ucrInputNewDataFrameName.Size = New System.Drawing.Size(153, 21)
        Me.ucrInputNewDataFrameName.TabIndex = 11
        '
        'ucrChkDontImportData
        '
        Me.ucrChkDontImportData.AutoSize = True
        Me.ucrChkDontImportData.Checked = False
        Me.ucrChkDontImportData.Location = New System.Drawing.Point(8, 377)
        Me.ucrChkDontImportData.Name = "ucrChkDontImportData"
        Me.ucrChkDontImportData.Size = New System.Drawing.Size(344, 23)
        Me.ucrChkDontImportData.TabIndex = 9
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.AutoSize = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(188, 352)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(150, 21)
        Me.ucrInputFilePath.TabIndex = 7
        '
        'ucrInputData
        '
        Me.ucrInputData.AddQuotesIfUnrecognised = True
        Me.ucrInputData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputData.GetSetSelectedIndex = -1
        Me.ucrInputData.IsReadOnly = False
        Me.ucrInputData.Location = New System.Drawing.Point(67, 33)
        Me.ucrInputData.Name = "ucrInputData"
        Me.ucrInputData.Size = New System.Drawing.Size(206, 21)
        Me.ucrInputData.TabIndex = 3
        '
        'ucrInputSource
        '
        Me.ucrInputSource.AddQuotesIfUnrecognised = True
        Me.ucrInputSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSource.GetSetSelectedIndex = -1
        Me.ucrInputSource.IsReadOnly = False
        Me.ucrInputSource.Location = New System.Drawing.Point(68, 6)
        Me.ucrInputSource.Name = "ucrInputSource"
        Me.ucrInputSource.Size = New System.Drawing.Size(205, 21)
        Me.ucrInputSource.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 426)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 12
        '
        'grpImportIRIVariable
        '
        Me.grpImportIRIVariable.Controls.Add(Me.rdoMaxPlantValue)
        Me.grpImportIRIVariable.Controls.Add(Me.rdoVariableMaxPlant)
        Me.grpImportIRIVariable.Controls.Add(Me.ucrPnlMaxPlantingDate)
        Me.grpImportIRIVariable.Controls.Add(Me.ucrNudMaxPlantingDate)
        Me.grpImportIRIVariable.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpImportIRIVariable.Controls.Add(Me.lblLongtude)
        Me.grpImportIRIVariable.Controls.Add(Me.lblPlantingDateMin)
        Me.grpImportIRIVariable.Controls.Add(Me.lblPlantingDateMax)
        Me.grpImportIRIVariable.Controls.Add(Me.lblLatitude)
        Me.grpImportIRIVariable.Controls.Add(Me.ucrReceiverMaxPlantingDate)
        Me.grpImportIRIVariable.Controls.Add(Me.ucrReceiverMinPlantingDate)
        Me.grpImportIRIVariable.Controls.Add(Me.ucrReceiverLongtitude)
        Me.grpImportIRIVariable.Controls.Add(Me.ucrReceiverIDVariable)
        Me.grpImportIRIVariable.Controls.Add(Me.lblIDVariable)
        Me.grpImportIRIVariable.Controls.Add(Me.ucrSelectorIRIVariable)
        Me.grpImportIRIVariable.Location = New System.Drawing.Point(8, 101)
        Me.grpImportIRIVariable.Name = "grpImportIRIVariable"
        Me.grpImportIRIVariable.Size = New System.Drawing.Size(397, 245)
        Me.grpImportIRIVariable.TabIndex = 13
        Me.grpImportIRIVariable.TabStop = False
        Me.grpImportIRIVariable.Text = "Variable"
        '
        'rdoMaxPlantValue
        '
        Me.rdoMaxPlantValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMaxPlantValue.Location = New System.Drawing.Point(337, 192)
        Me.rdoMaxPlantValue.Name = "rdoMaxPlantValue"
        Me.rdoMaxPlantValue.Size = New System.Drawing.Size(54, 16)
        Me.rdoMaxPlantValue.TabIndex = 14
        Me.rdoMaxPlantValue.TabStop = True
        Me.rdoMaxPlantValue.Text = "Value"
        Me.rdoMaxPlantValue.UseVisualStyleBackColor = True
        '
        'rdoVariableMaxPlant
        '
        Me.rdoVariableMaxPlant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVariableMaxPlant.Location = New System.Drawing.Point(258, 191)
        Me.rdoVariableMaxPlant.Name = "rdoVariableMaxPlant"
        Me.rdoVariableMaxPlant.Size = New System.Drawing.Size(79, 17)
        Me.rdoVariableMaxPlant.TabIndex = 15
        Me.rdoVariableMaxPlant.TabStop = True
        Me.rdoVariableMaxPlant.Text = "Variable"
        Me.rdoVariableMaxPlant.UseVisualStyleBackColor = True
        '
        'ucrPnlMaxPlantingDate
        '
        Me.ucrPnlMaxPlantingDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMaxPlantingDate.Location = New System.Drawing.Point(253, 189)
        Me.ucrPnlMaxPlantingDate.Name = "ucrPnlMaxPlantingDate"
        Me.ucrPnlMaxPlantingDate.Size = New System.Drawing.Size(137, 21)
        Me.ucrPnlMaxPlantingDate.TabIndex = 14
        '
        'ucrNudMaxPlantingDate
        '
        Me.ucrNudMaxPlantingDate.AutoSize = True
        Me.ucrNudMaxPlantingDate.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxPlantingDate.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxPlantingDate.Location = New System.Drawing.Point(333, 216)
        Me.ucrNudMaxPlantingDate.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxPlantingDate.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxPlantingDate.Name = "ucrNudMaxPlantingDate"
        Me.ucrNudMaxPlantingDate.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxPlantingDate.TabIndex = 17
        Me.ucrNudMaxPlantingDate.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(272, 110)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 6
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'lblLongtude
        '
        Me.lblLongtude.AutoSize = True
        Me.lblLongtude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongtude.Location = New System.Drawing.Point(274, 56)
        Me.lblLongtude.Name = "lblLongtude"
        Me.lblLongtude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongtude.TabIndex = 3
        Me.lblLongtude.Text = "Longitude:"
        '
        'lblPlantingDateMin
        '
        Me.lblPlantingDateMin.AutoSize = True
        Me.lblPlantingDateMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlantingDateMin.Location = New System.Drawing.Point(274, 132)
        Me.lblPlantingDateMin.Name = "lblPlantingDateMin"
        Me.lblPlantingDateMin.Size = New System.Drawing.Size(97, 13)
        Me.lblPlantingDateMin.TabIndex = 7
        Me.lblPlantingDateMin.Text = "Planting Date(Min):"
        '
        'lblPlantingDateMax
        '
        Me.lblPlantingDateMax.AutoSize = True
        Me.lblPlantingDateMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlantingDateMax.Location = New System.Drawing.Point(269, 172)
        Me.lblPlantingDateMax.Name = "lblPlantingDateMax"
        Me.lblPlantingDateMax.Size = New System.Drawing.Size(103, 13)
        Me.lblPlantingDateMax.TabIndex = 9
        Me.lblPlantingDateMax.Text = "Planting Date (Max):"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(274, 96)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(45, 13)
        Me.lblLatitude.TabIndex = 5
        Me.lblLatitude.Text = "Latitude"
        '
        'ucrReceiverMaxPlantingDate
        '
        Me.ucrReceiverMaxPlantingDate.AutoSize = True
        Me.ucrReceiverMaxPlantingDate.frmParent = Me
        Me.ucrReceiverMaxPlantingDate.Location = New System.Drawing.Point(272, 217)
        Me.ucrReceiverMaxPlantingDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxPlantingDate.Name = "ucrReceiverMaxPlantingDate"
        Me.ucrReceiverMaxPlantingDate.Selector = Nothing
        Me.ucrReceiverMaxPlantingDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxPlantingDate.strNcFilePath = ""
        Me.ucrReceiverMaxPlantingDate.TabIndex = 10
        Me.ucrReceiverMaxPlantingDate.ucrSelector = Nothing
        '
        'ucrReceiverMinPlantingDate
        '
        Me.ucrReceiverMinPlantingDate.AutoSize = True
        Me.ucrReceiverMinPlantingDate.frmParent = Me
        Me.ucrReceiverMinPlantingDate.Location = New System.Drawing.Point(272, 149)
        Me.ucrReceiverMinPlantingDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinPlantingDate.Name = "ucrReceiverMinPlantingDate"
        Me.ucrReceiverMinPlantingDate.Selector = Nothing
        Me.ucrReceiverMinPlantingDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMinPlantingDate.strNcFilePath = ""
        Me.ucrReceiverMinPlantingDate.TabIndex = 8
        Me.ucrReceiverMinPlantingDate.ucrSelector = Nothing
        '
        'ucrReceiverLongtitude
        '
        Me.ucrReceiverLongtitude.AutoSize = True
        Me.ucrReceiverLongtitude.frmParent = Me
        Me.ucrReceiverLongtitude.Location = New System.Drawing.Point(272, 71)
        Me.ucrReceiverLongtitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongtitude.Name = "ucrReceiverLongtitude"
        Me.ucrReceiverLongtitude.Selector = Nothing
        Me.ucrReceiverLongtitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLongtitude.strNcFilePath = ""
        Me.ucrReceiverLongtitude.TabIndex = 4
        Me.ucrReceiverLongtitude.ucrSelector = Nothing
        '
        'ucrReceiverIDVariable
        '
        Me.ucrReceiverIDVariable.AutoSize = True
        Me.ucrReceiverIDVariable.frmParent = Me
        Me.ucrReceiverIDVariable.Location = New System.Drawing.Point(272, 32)
        Me.ucrReceiverIDVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVariable.Name = "ucrReceiverIDVariable"
        Me.ucrReceiverIDVariable.Selector = Nothing
        Me.ucrReceiverIDVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverIDVariable.strNcFilePath = ""
        Me.ucrReceiverIDVariable.TabIndex = 2
        Me.ucrReceiverIDVariable.ucrSelector = Nothing
        '
        'lblIDVariable
        '
        Me.lblIDVariable.AutoSize = True
        Me.lblIDVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIDVariable.Location = New System.Drawing.Point(274, 10)
        Me.lblIDVariable.Name = "lblIDVariable"
        Me.lblIDVariable.Size = New System.Drawing.Size(62, 13)
        Me.lblIDVariable.TabIndex = 1
        Me.lblIDVariable.Text = "ID Variable:"
        '
        'ucrSelectorIRIVariable
        '
        Me.ucrSelectorIRIVariable.AutoSize = True
        Me.ucrSelectorIRIVariable.bDropUnusedFilterLevels = False
        Me.ucrSelectorIRIVariable.bShowHiddenColumns = False
        Me.ucrSelectorIRIVariable.bUseCurrentFilter = True
        Me.ucrSelectorIRIVariable.Location = New System.Drawing.Point(6, 16)
        Me.ucrSelectorIRIVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIRIVariable.Name = "ucrSelectorIRIVariable"
        Me.ucrSelectorIRIVariable.Size = New System.Drawing.Size(213, 185)
        Me.ucrSelectorIRIVariable.TabIndex = 0
        '
        'rdoIRIVariable
        '
        Me.rdoIRIVariable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoIRIVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIRIVariable.FlatAppearance.BorderSize = 2
        Me.rdoIRIVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIRIVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoIRIVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIRIVariable.Location = New System.Drawing.Point(182, 60)
        Me.rdoIRIVariable.Name = "rdoIRIVariable"
        Me.rdoIRIVariable.Size = New System.Drawing.Size(145, 28)
        Me.rdoIRIVariable.TabIndex = 37
        Me.rdoIRIVariable.TabStop = True
        Me.rdoIRIVariable.Tag = ""
        Me.rdoIRIVariable.Text = "Variable"
        Me.rdoIRIVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoIRIVariable.UseVisualStyleBackColor = True
        '
        'rdoIRIValue
        '
        Me.rdoIRIValue.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoIRIValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIRIValue.FlatAppearance.BorderSize = 2
        Me.rdoIRIValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIRIValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoIRIValue.Location = New System.Drawing.Point(40, 60)
        Me.rdoIRIValue.Name = "rdoIRIValue"
        Me.rdoIRIValue.Size = New System.Drawing.Size(145, 28)
        Me.rdoIRIValue.TabIndex = 36
        Me.rdoIRIValue.TabStop = True
        Me.rdoIRIValue.Tag = ""
        Me.rdoIRIValue.Text = "Value"
        Me.rdoIRIValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoIRIValue.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(3, 59)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(408, 30)
        Me.ucrPnlOptions.TabIndex = 35
        '
        'dlgImportGriddedData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 478)
        Me.Controls.Add(Me.rdoIRIVariable)
        Me.Controls.Add(Me.rdoIRIValue)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.grpImportIRIVariable)
        Me.Controls.Add(Me.lblSaveDownloadedFileTo)
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.ucrChkDontImportData)
        Me.Controls.Add(Me.grpDateRange)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrInputData)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.ucrInputSource)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpLocationRange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportGriddedData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From IRI (Internet connection needed)"
        Me.grpDateRange.ResumeLayout(False)
        Me.grpDateRange.PerformLayout()
        Me.grpLocationRange.ResumeLayout(False)
        Me.grpLocationRange.PerformLayout()
        Me.grpImportIRIVariable.ResumeLayout(False)
        Me.grpImportIRIVariable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblLat As Label
    Friend WithEvents lblMaxLat As Label
    Friend WithEvents lblLon As Label
    Friend WithEvents lblMaxLon As Label
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrInputSource As ucrInputComboBox
    Friend WithEvents lblSource As Label
    Friend WithEvents ucrInputData As ucrInputComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrDtpMinDate As ucrDateTimePicker
    Friend WithEvents ucrDtpMaxDate As ucrDateTimePicker
    Friend WithEvents grpDateRange As GroupBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrInputMaxLon As ucrInputTextBox
    Friend WithEvents ucrInputMinLon As ucrInputTextBox
    Friend WithEvents ucrInputMaxLat As ucrInputTextBox
    Friend WithEvents ucrInputMinLat As ucrInputTextBox
    Friend WithEvents ucrChkDontImportData As ucrCheck
    Friend WithEvents ucrInputNewDataFrameName As ucrInputTextBox
    Friend WithEvents rdoCustomRange As RadioButton
    Friend WithEvents rdoEntireRange As RadioButton
    Friend WithEvents ucrPnlDateRange As UcrPanel
    Friend WithEvents grpLocationRange As GroupBox
    Friend WithEvents lblMinLon As Label
    Friend WithEvents lblMinLat As Label
    Friend WithEvents rdoPoint As RadioButton
    Friend WithEvents rdoArea As RadioButton
    Friend WithEvents ucrPnlLocationRange As UcrPanel
    Friend WithEvents lblSaveDownloadedFileTo As Label
    Friend WithEvents grpImportIRIVariable As GroupBox
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents lblLongtude As Label
    Friend WithEvents lblPlantingDateMin As Label
    Friend WithEvents lblPlantingDateMax As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrReceiverMaxPlantingDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverMinPlantingDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongtitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverIDVariable As ucrReceiverSingle
    Friend WithEvents lblIDVariable As Label
    Friend WithEvents ucrSelectorIRIVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoMaxPlantValue As RadioButton
    Friend WithEvents rdoVariableMaxPlant As RadioButton
    Friend WithEvents ucrNudMaxPlantingDate As ucrNud
    Friend WithEvents ucrPnlMaxPlantingDate As UcrPanel
    Friend WithEvents rdoIRIVariable As RadioButton
    Friend WithEvents rdoIRIValue As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
