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
Partial Class dlgExportToCPT
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
        Me.lblSaveDataTo = New System.Windows.Forms.Label()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblStationTwoDF = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblStationOneDF = New System.Windows.Forms.Label()
        Me.lblMultStations = New System.Windows.Forms.Label()
        Me.rdoOneDF = New System.Windows.Forms.RadioButton()
        Me.rdoTwoDFLong = New System.Windows.Forms.RadioButton()
        Me.rdoTwoDFWide = New System.Windows.Forms.RadioButton()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblSaveFile = New System.Windows.Forms.Label()
        Me.lblMissingValues = New System.Windows.Forms.Label()
        Me.ucrInputCodeMissingValues = New instat.ucrInputTextBox()
        Me.ucrReceiverMultipleStation = New instat.ucrReceiverMultiple()
        Me.ucrSelectorTwoDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverStationTwoDF = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationOneDF = New instat.ucrReceiverSingle()
        Me.ucrPnlNoOfDF = New instat.UcrPanel()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrSelectorOneDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSaveDataTo
        '
        Me.lblSaveDataTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveDataTo.Location = New System.Drawing.Point(2, 408)
        Me.lblSaveDataTo.Name = "lblSaveDataTo"
        Me.lblSaveDataTo.Size = New System.Drawing.Size(100, 23)
        Me.lblSaveDataTo.TabIndex = 13
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(353, 502)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdChooseFile.TabIndex = 11
        Me.cmdChooseFile.Text = "Browse"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'lblLatitude
        '
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(294, 273)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(100, 14)
        Me.lblLatitude.TabIndex = 9
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblLongitude
        '
        Me.lblLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitude.Location = New System.Drawing.Point(295, 336)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(100, 14)
        Me.lblLongitude.TabIndex = 10
        Me.lblLongitude.Text = "Longitude:"
        '
        'lblStationTwoDF
        '
        Me.lblStationTwoDF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationTwoDF.Location = New System.Drawing.Point(295, 395)
        Me.lblStationTwoDF.Name = "lblStationTwoDF"
        Me.lblStationTwoDF.Size = New System.Drawing.Size(100, 13)
        Me.lblStationTwoDF.TabIndex = 6
        Me.lblStationTwoDF.Text = "Station:"
        '
        'lblElement
        '
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(295, 179)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(100, 11)
        Me.lblElement.TabIndex = 15
        Me.lblElement.Text = "Element:"
        '
        'lblYear
        '
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(295, 56)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(100, 15)
        Me.lblYear.TabIndex = 16
        Me.lblYear.Text = "Year:"
        '
        'lblStationOneDF
        '
        Me.lblStationOneDF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationOneDF.Location = New System.Drawing.Point(295, 120)
        Me.lblStationOneDF.Name = "lblStationOneDF"
        Me.lblStationOneDF.Size = New System.Drawing.Size(89, 12)
        Me.lblStationOneDF.TabIndex = 17
        Me.lblStationOneDF.Text = "Station:"
        '
        'lblMultStations
        '
        Me.lblMultStations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMultStations.Location = New System.Drawing.Point(294, 120)
        Me.lblMultStations.Name = "lblMultStations"
        Me.lblMultStations.Size = New System.Drawing.Size(100, 11)
        Me.lblMultStations.TabIndex = 0
        Me.lblMultStations.Text = "Stations:"
        '
        'rdoOneDF
        '
        Me.rdoOneDF.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOneDF.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOneDF.FlatAppearance.BorderSize = 2
        Me.rdoOneDF.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOneDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOneDF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOneDF.Location = New System.Drawing.Point(14, 7)
        Me.rdoOneDF.Name = "rdoOneDF"
        Me.rdoOneDF.Size = New System.Drawing.Size(132, 27)
        Me.rdoOneDF.TabIndex = 25
        Me.rdoOneDF.TabStop = True
        Me.rdoOneDF.Text = "One Data Frame"
        Me.rdoOneDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOneDF.UseVisualStyleBackColor = True
        '
        'rdoTwoDFLong
        '
        Me.rdoTwoDFLong.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTwoDFLong.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDFLong.FlatAppearance.BorderSize = 2
        Me.rdoTwoDFLong.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDFLong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTwoDFLong.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTwoDFLong.Location = New System.Drawing.Point(145, 7)
        Me.rdoTwoDFLong.Name = "rdoTwoDFLong"
        Me.rdoTwoDFLong.Size = New System.Drawing.Size(136, 27)
        Me.rdoTwoDFLong.TabIndex = 26
        Me.rdoTwoDFLong.TabStop = True
        Me.rdoTwoDFLong.Text = "Two Data Frames Long"
        Me.rdoTwoDFLong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoDFLong.UseVisualStyleBackColor = True
        '
        'rdoTwoDFWide
        '
        Me.rdoTwoDFWide.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTwoDFWide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDFWide.FlatAppearance.BorderSize = 2
        Me.rdoTwoDFWide.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDFWide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTwoDFWide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTwoDFWide.Location = New System.Drawing.Point(280, 7)
        Me.rdoTwoDFWide.Name = "rdoTwoDFWide"
        Me.rdoTwoDFWide.Size = New System.Drawing.Size(141, 27)
        Me.rdoTwoDFWide.TabIndex = 27
        Me.rdoTwoDFWide.TabStop = True
        Me.rdoTwoDFWide.Text = "Two Data Frames Wide"
        Me.rdoTwoDFWide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoDFWide.UseVisualStyleBackColor = True
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLine.Location = New System.Drawing.Point(4, 244)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(415, 13)
        Me.lblLine.TabIndex = 28
        Me.lblLine.Text = "____________________________________________________________________"
        '
        'lblSaveFile
        '
        Me.lblSaveFile.AutoSize = True
        Me.lblSaveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveFile.Location = New System.Drawing.Point(8, 505)
        Me.lblSaveFile.Name = "lblSaveFile"
        Me.lblSaveFile.Size = New System.Drawing.Size(69, 13)
        Me.lblSaveFile.TabIndex = 29
        Me.lblSaveFile.Text = "Save File As:"
        '
        'lblMissingValues
        '
        Me.lblMissingValues.AutoSize = True
        Me.lblMissingValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingValues.Location = New System.Drawing.Point(8, 474)
        Me.lblMissingValues.Name = "lblMissingValues"
        Me.lblMissingValues.Size = New System.Drawing.Size(122, 13)
        Me.lblMissingValues.TabIndex = 31
        Me.lblMissingValues.Text = "Code Missing Values as:"
        '
        'ucrInputCodeMissingValues
        '
        Me.ucrInputCodeMissingValues.AddQuotesIfUnrecognised = True
        Me.ucrInputCodeMissingValues.AutoSize = True
        Me.ucrInputCodeMissingValues.IsMultiline = False
        Me.ucrInputCodeMissingValues.IsReadOnly = False
        Me.ucrInputCodeMissingValues.Location = New System.Drawing.Point(201, 471)
        Me.ucrInputCodeMissingValues.Name = "ucrInputCodeMissingValues"
        Me.ucrInputCodeMissingValues.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputCodeMissingValues.TabIndex = 30
        '
        'ucrReceiverMultipleStation
        '
        Me.ucrReceiverMultipleStation.AutoSize = True
        Me.ucrReceiverMultipleStation.frmParent = Me
        Me.ucrReceiverMultipleStation.Location = New System.Drawing.Point(297, 133)
        Me.ucrReceiverMultipleStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleStation.Name = "ucrReceiverMultipleStation"
        Me.ucrReceiverMultipleStation.Selector = Nothing
        Me.ucrReceiverMultipleStation.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleStation.strNcFilePath = ""
        Me.ucrReceiverMultipleStation.TabIndex = 2
        Me.ucrReceiverMultipleStation.ucrSelector = Nothing
        '
        'ucrSelectorTwoDF
        '
        Me.ucrSelectorTwoDF.AutoSize = True
        Me.ucrSelectorTwoDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorTwoDF.bShowHiddenColumns = False
        Me.ucrSelectorTwoDF.bUseCurrentFilter = True
        Me.ucrSelectorTwoDF.Location = New System.Drawing.Point(8, 269)
        Me.ucrSelectorTwoDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoDF.Name = "ucrSelectorTwoDF"
        Me.ucrSelectorTwoDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTwoDF.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 529)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrReceiverStationTwoDF
        '
        Me.ucrReceiverStationTwoDF.AutoSize = True
        Me.ucrReceiverStationTwoDF.frmParent = Me
        Me.ucrReceiverStationTwoDF.Location = New System.Drawing.Point(297, 408)
        Me.ucrReceiverStationTwoDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationTwoDF.Name = "ucrReceiverStationTwoDF"
        Me.ucrReceiverStationTwoDF.Selector = Nothing
        Me.ucrReceiverStationTwoDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationTwoDF.strNcFilePath = ""
        Me.ucrReceiverStationTwoDF.TabIndex = 7
        Me.ucrReceiverStationTwoDF.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(297, 350)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 8
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.AutoSize = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(137, 502)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(214, 21)
        Me.ucrInputFilePath.TabIndex = 12
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(297, 287)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 14
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverStationOneDF
        '
        Me.ucrReceiverStationOneDF.AutoSize = True
        Me.ucrReceiverStationOneDF.frmParent = Me
        Me.ucrReceiverStationOneDF.Location = New System.Drawing.Point(297, 133)
        Me.ucrReceiverStationOneDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationOneDF.Name = "ucrReceiverStationOneDF"
        Me.ucrReceiverStationOneDF.Selector = Nothing
        Me.ucrReceiverStationOneDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationOneDF.strNcFilePath = ""
        Me.ucrReceiverStationOneDF.TabIndex = 20
        Me.ucrReceiverStationOneDF.ucrSelector = Nothing
        '
        'ucrPnlNoOfDF
        '
        Me.ucrPnlNoOfDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlNoOfDF.Location = New System.Drawing.Point(6, 3)
        Me.ucrPnlNoOfDF.Name = "ucrPnlNoOfDF"
        Me.ucrPnlNoOfDF.Size = New System.Drawing.Size(418, 36)
        Me.ucrPnlNoOfDF.TabIndex = 21
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(297, 192)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 22
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(297, 71)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 23
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrSelectorOneDF
        '
        Me.ucrSelectorOneDF.AutoSize = True
        Me.ucrSelectorOneDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneDF.bShowHiddenColumns = False
        Me.ucrSelectorOneDF.bUseCurrentFilter = True
        Me.ucrSelectorOneDF.Location = New System.Drawing.Point(8, 53)
        Me.ucrSelectorOneDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneDF.Name = "ucrSelectorOneDF"
        Me.ucrSelectorOneDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOneDF.TabIndex = 24
        '
        'dlgExportToCPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(432, 587)
        Me.Controls.Add(Me.lblMissingValues)
        Me.Controls.Add(Me.ucrInputCodeMissingValues)
        Me.Controls.Add(Me.lblSaveFile)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.rdoTwoDFWide)
        Me.Controls.Add(Me.rdoTwoDFLong)
        Me.Controls.Add(Me.rdoOneDF)
        Me.Controls.Add(Me.lblMultStations)
        Me.Controls.Add(Me.ucrReceiverMultipleStation)
        Me.Controls.Add(Me.ucrSelectorTwoDF)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblStationTwoDF)
        Me.Controls.Add(Me.ucrReceiverStationTwoDF)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblSaveDataTo)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblStationOneDF)
        Me.Controls.Add(Me.ucrReceiverStationOneDF)
        Me.Controls.Add(Me.ucrPnlNoOfDF)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrSelectorOneDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToCPT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Export_To_CPT"
        Me.Text = "Export to CPT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorOneDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrPnlNoOfDF As UcrPanel
    Friend WithEvents lblSaveDataTo As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents lblStationTwoDF As Label
    Friend WithEvents ucrReceiverStationTwoDF As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblStationOneDF As Label
    Friend WithEvents ucrReceiverStationOneDF As ucrReceiverSingle
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblTwoDF As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOneDF As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTwoDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleStation As ucrReceiverMultiple
    Friend WithEvents lblMultStations As Label
    Friend WithEvents rdoOneDF As RadioButton
    Friend WithEvents rdoTwoDFWide As RadioButton
    Friend WithEvents rdoTwoDFLong As RadioButton
    Friend WithEvents lblLine As Label
    Friend WithEvents lblSaveFile As Label
    Friend WithEvents lblMissingValues As Label
    Friend WithEvents ucrInputCodeMissingValues As ucrInputTextBox
End Class