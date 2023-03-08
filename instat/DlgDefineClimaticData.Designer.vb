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
Partial Class DlgDefineClimaticData
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
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.lblMaxRH = New System.Windows.Forms.Label()
        Me.lblMinimumRH = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblMaxTemp = New System.Windows.Forms.Label()
        Me.lblCloudCover = New System.Windows.Forms.Label()
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.lblRadiation = New System.Windows.Forms.Label()
        Me.lblSunshine = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblStationName = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.grpDateTime = New System.Windows.Forms.GroupBox()
        Me.grpStation = New System.Windows.Forms.GroupBox()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblAltitude = New System.Windows.Forms.Label()
        Me.cmdCheckUnique = New System.Windows.Forms.Button()
        Me.ucrChkLinkedMetaData = New instat.ucrCheck()
        Me.ucrSelectorLinkedDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverAltitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationName = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverAltitude1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxRH = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinRH = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverSunshine = New instat.ucrReceiverSingle()
        Me.ucrReceiverRadiation = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverCloudCover = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinTemp = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDefineClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpElements.SuspendLayout()
        Me.grpDateTime.SuspendLayout()
        Me.grpStation.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpElements
        '
        Me.grpElements.Controls.Add(Me.ucrReceiverMaxRH)
        Me.grpElements.Controls.Add(Me.lblMaxRH)
        Me.grpElements.Controls.Add(Me.ucrReceiverMinRH)
        Me.grpElements.Controls.Add(Me.lblMinimumRH)
        Me.grpElements.Controls.Add(Me.ucrReceiverWindDirection)
        Me.grpElements.Controls.Add(Me.ucrReceiverRain)
        Me.grpElements.Controls.Add(Me.ucrReceiverSunshine)
        Me.grpElements.Controls.Add(Me.lblRain)
        Me.grpElements.Controls.Add(Me.ucrReceiverRadiation)
        Me.grpElements.Controls.Add(Me.ucrReceiverMaxTemp)
        Me.grpElements.Controls.Add(Me.ucrReceiverCloudCover)
        Me.grpElements.Controls.Add(Me.lblMaxTemp)
        Me.grpElements.Controls.Add(Me.lblCloudCover)
        Me.grpElements.Controls.Add(Me.lblMinTemp)
        Me.grpElements.Controls.Add(Me.lblRadiation)
        Me.grpElements.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.grpElements.Controls.Add(Me.lblSunshine)
        Me.grpElements.Controls.Add(Me.ucrReceiverMinTemp)
        Me.grpElements.Controls.Add(Me.lblWindSpeed)
        Me.grpElements.Controls.Add(Me.lblWindDirection)
        Me.grpElements.Location = New System.Drawing.Point(245, 10)
        Me.grpElements.Name = "grpElements"
        Me.grpElements.Size = New System.Drawing.Size(260, 225)
        Me.grpElements.TabIndex = 3
        Me.grpElements.TabStop = False
        Me.grpElements.Text = "Elements"
        '
        'lblMaxRH
        '
        Me.lblMaxRH.AutoSize = True
        Me.lblMaxRH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxRH.Location = New System.Drawing.Point(139, 178)
        Me.lblMaxRH.Name = "lblMaxRH"
        Me.lblMaxRH.Size = New System.Drawing.Size(90, 13)
        Me.lblMaxRH.TabIndex = 18
        Me.lblMaxRH.Text = "Maximum RH (%):"
        '
        'lblMinimumRH
        '
        Me.lblMinimumRH.AutoSize = True
        Me.lblMinimumRH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinimumRH.Location = New System.Drawing.Point(139, 137)
        Me.lblMinimumRH.Name = "lblMinimumRH"
        Me.lblMinimumRH.Size = New System.Drawing.Size(87, 13)
        Me.lblMinimumRH.TabIndex = 16
        Me.lblMinimumRH.Text = "Minimum RH (%):"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRain.Location = New System.Drawing.Point(13, 15)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 0
        Me.lblRain.Text = "Rain:"
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxTemp.Location = New System.Drawing.Point(13, 96)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(117, 13)
        Me.lblMaxTemp.TabIndex = 4
        Me.lblMaxTemp.Text = "Maximum Temperature:"
        '
        'lblCloudCover
        '
        Me.lblCloudCover.AutoSize = True
        Me.lblCloudCover.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCloudCover.Location = New System.Drawing.Point(139, 96)
        Me.lblCloudCover.Name = "lblCloudCover"
        Me.lblCloudCover.Size = New System.Drawing.Size(68, 13)
        Me.lblCloudCover.TabIndex = 14
        Me.lblCloudCover.Text = "Cloud Cover:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinTemp.Location = New System.Drawing.Point(13, 55)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(111, 13)
        Me.lblMinTemp.TabIndex = 2
        Me.lblMinTemp.Text = "Minimum Temperature"
        '
        'lblRadiation
        '
        Me.lblRadiation.AutoSize = True
        Me.lblRadiation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRadiation.Location = New System.Drawing.Point(139, 55)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(55, 13)
        Me.lblRadiation.TabIndex = 12
        Me.lblRadiation.Text = "Radiation:"
        '
        'lblSunshine
        '
        Me.lblSunshine.AutoSize = True
        Me.lblSunshine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSunshine.Location = New System.Drawing.Point(139, 15)
        Me.lblSunshine.Name = "lblSunshine"
        Me.lblSunshine.Size = New System.Drawing.Size(85, 13)
        Me.lblSunshine.TabIndex = 10
        Me.lblSunshine.Text = "Sunshine Hours:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWindSpeed.Location = New System.Drawing.Point(13, 137)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 6
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWindDirection.Location = New System.Drawing.Point(13, 178)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 8
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationName.Location = New System.Drawing.Point(7, 16)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(38, 13)
        Me.lblStationName.TabIndex = 0
        Me.lblStationName.Text = "Name:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDOY.Location = New System.Drawing.Point(11, 157)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 8
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDay.Location = New System.Drawing.Point(11, 122)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(11, 86)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(11, 50)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(11, 15)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        '
        'grpDateTime
        '
        Me.grpDateTime.Controls.Add(Me.lblDOY)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverYear)
        Me.grpDateTime.Controls.Add(Me.lblDate)
        Me.grpDateTime.Controls.Add(Me.lblMonth)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverDOY)
        Me.grpDateTime.Controls.Add(Me.lblYear)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverDate)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverMonth)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverDay)
        Me.grpDateTime.Controls.Add(Me.lblDay)
        Me.grpDateTime.Location = New System.Drawing.Point(379, 246)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Size = New System.Drawing.Size(126, 196)
        Me.grpDateTime.TabIndex = 2
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Tag = ""
        Me.grpDateTime.Text = "Date and Time"
        '
        'grpStation
        '
        Me.grpStation.Controls.Add(Me.lblLongitude)
        Me.grpStation.Controls.Add(Me.ucrReceiverLongitude)
        Me.grpStation.Controls.Add(Me.lblLatitude)
        Me.grpStation.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpStation.Controls.Add(Me.lblAltitude)
        Me.grpStation.Controls.Add(Me.ucrReceiverAltitude)
        Me.grpStation.Controls.Add(Me.lblStationName)
        Me.grpStation.Controls.Add(Me.ucrReceiverStationName)
        Me.grpStation.Controls.Add(Me.ucrReceiverStation)
        Me.grpStation.Controls.Add(Me.ucrReceiverLongitude1)
        Me.grpStation.Controls.Add(Me.ucrReceiverLatitude1)
        Me.grpStation.Controls.Add(Me.ucrReceiverAltitude1)
        Me.grpStation.Location = New System.Drawing.Point(248, 257)
        Me.grpStation.Name = "grpStation"
        Me.grpStation.Size = New System.Drawing.Size(112, 173)
        Me.grpStation.TabIndex = 1
        Me.grpStation.TabStop = False
        Me.grpStation.Tag = ""
        Me.grpStation.Text = "Station"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitude.Location = New System.Drawing.Point(7, 93)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongitude.TabIndex = 6
        Me.lblLongitude.Text = "Longitude:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(7, 55)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(48, 13)
        Me.lblLatitude.TabIndex = 4
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblAltitude
        '
        Me.lblAltitude.AutoSize = True
        Me.lblAltitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltitude.Location = New System.Drawing.Point(7, 132)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.Size = New System.Drawing.Size(45, 13)
        Me.lblAltitude.TabIndex = 2
        Me.lblAltitude.Text = "Altitude:"
        '
        'cmdCheckUnique
        '
        Me.cmdCheckUnique.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheckUnique.Location = New System.Drawing.Point(9, 453)
        Me.cmdCheckUnique.Name = "cmdCheckUnique"
        Me.cmdCheckUnique.Size = New System.Drawing.Size(139, 23)
        Me.cmdCheckUnique.TabIndex = 4
        Me.cmdCheckUnique.Text = "Check Duplicates"
        Me.cmdCheckUnique.UseVisualStyleBackColor = True
        '
        'ucrChkLinkedMetaData
        '
        Me.ucrChkLinkedMetaData.AutoSize = True
        Me.ucrChkLinkedMetaData.Checked = False
        Me.ucrChkLinkedMetaData.Location = New System.Drawing.Point(13, 206)
        Me.ucrChkLinkedMetaData.Name = "ucrChkLinkedMetaData"
        Me.ucrChkLinkedMetaData.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkLinkedMetaData.TabIndex = 8
        '
        'ucrSelectorLinkedDataFrame
        '
        Me.ucrSelectorLinkedDataFrame.AutoSize = True
        Me.ucrSelectorLinkedDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorLinkedDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorLinkedDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorLinkedDataFrame.Location = New System.Drawing.Point(13, 246)
        Me.ucrSelectorLinkedDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLinkedDataFrame.Name = "ucrSelectorLinkedDataFrame"
        Me.ucrSelectorLinkedDataFrame.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorLinkedDataFrame.TabIndex = 7
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInput.AutoSize = True
        Me.ucrInputCheckInput.IsMultiline = False
        Me.ucrInputCheckInput.IsReadOnly = False
        Me.ucrInputCheckInput.Location = New System.Drawing.Point(154, 455)
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        Me.ucrInputCheckInput.Size = New System.Drawing.Size(253, 21)
        Me.ucrInputCheckInput.TabIndex = 5
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Nothing
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(7, 108)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 7
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Nothing
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(7, 70)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 5
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverAltitude
        '
        Me.ucrReceiverAltitude.AutoSize = True
        Me.ucrReceiverAltitude.frmParent = Nothing
        Me.ucrReceiverAltitude.Location = New System.Drawing.Point(7, 147)
        Me.ucrReceiverAltitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltitude.Name = "ucrReceiverAltitude"
        Me.ucrReceiverAltitude.Selector = Nothing
        Me.ucrReceiverAltitude.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverAltitude.strNcFilePath = ""
        Me.ucrReceiverAltitude.TabIndex = 3
        Me.ucrReceiverAltitude.ucrSelector = Nothing
        '
        'ucrReceiverStationName
        '
        Me.ucrReceiverStationName.AutoSize = True
        Me.ucrReceiverStationName.frmParent = Nothing
        Me.ucrReceiverStationName.Location = New System.Drawing.Point(7, 31)
        Me.ucrReceiverStationName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationName.Name = "ucrReceiverStationName"
        Me.ucrReceiverStationName.Selector = Nothing
        Me.ucrReceiverStationName.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverStationName.strNcFilePath = ""
        Me.ucrReceiverStationName.TabIndex = 1
        Me.ucrReceiverStationName.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Nothing
        Me.ucrReceiverStation.Location = New System.Drawing.Point(7, 31)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 8
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverLongitude1
        '
        Me.ucrReceiverLongitude1.AutoSize = True
        Me.ucrReceiverLongitude1.frmParent = Nothing
        Me.ucrReceiverLongitude1.Location = New System.Drawing.Point(7, 108)
        Me.ucrReceiverLongitude1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude1.Name = "ucrReceiverLongitude1"
        Me.ucrReceiverLongitude1.Selector = Nothing
        Me.ucrReceiverLongitude1.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverLongitude1.strNcFilePath = ""
        Me.ucrReceiverLongitude1.TabIndex = 10
        Me.ucrReceiverLongitude1.ucrSelector = Nothing
        '
        'ucrReceiverLatitude1
        '
        Me.ucrReceiverLatitude1.AutoSize = True
        Me.ucrReceiverLatitude1.frmParent = Nothing
        Me.ucrReceiverLatitude1.Location = New System.Drawing.Point(7, 70)
        Me.ucrReceiverLatitude1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude1.Name = "ucrReceiverLatitude1"
        Me.ucrReceiverLatitude1.Selector = Nothing
        Me.ucrReceiverLatitude1.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverLatitude1.strNcFilePath = ""
        Me.ucrReceiverLatitude1.TabIndex = 9
        Me.ucrReceiverLatitude1.ucrSelector = Nothing
        '
        'ucrReceiverAltitude1
        '
        Me.ucrReceiverAltitude1.AutoSize = True
        Me.ucrReceiverAltitude1.frmParent = Nothing
        Me.ucrReceiverAltitude1.Location = New System.Drawing.Point(7, 147)
        Me.ucrReceiverAltitude1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltitude1.Name = "ucrReceiverAltitude1"
        Me.ucrReceiverAltitude1.Selector = Nothing
        Me.ucrReceiverAltitude1.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverAltitude1.strNcFilePath = ""
        Me.ucrReceiverAltitude1.TabIndex = 11
        Me.ucrReceiverAltitude1.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Nothing
        Me.ucrReceiverYear.Location = New System.Drawing.Point(11, 64)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 3
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Nothing
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(11, 172)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 9
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Nothing
        Me.ucrReceiverDate.Location = New System.Drawing.Point(11, 28)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 1
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Nothing
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(11, 100)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 5
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.AutoSize = True
        Me.ucrReceiverDay.frmParent = Nothing
        Me.ucrReceiverDay.Location = New System.Drawing.Point(11, 135)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 7
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverMaxRH
        '
        Me.ucrReceiverMaxRH.AutoSize = True
        Me.ucrReceiverMaxRH.frmParent = Nothing
        Me.ucrReceiverMaxRH.Location = New System.Drawing.Point(142, 193)
        Me.ucrReceiverMaxRH.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxRH.Name = "ucrReceiverMaxRH"
        Me.ucrReceiverMaxRH.Selector = Nothing
        Me.ucrReceiverMaxRH.Size = New System.Drawing.Size(99, 20)
        Me.ucrReceiverMaxRH.strNcFilePath = ""
        Me.ucrReceiverMaxRH.TabIndex = 19
        Me.ucrReceiverMaxRH.ucrSelector = Nothing
        '
        'ucrReceiverMinRH
        '
        Me.ucrReceiverMinRH.AutoSize = True
        Me.ucrReceiverMinRH.frmParent = Nothing
        Me.ucrReceiverMinRH.Location = New System.Drawing.Point(142, 152)
        Me.ucrReceiverMinRH.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinRH.Name = "ucrReceiverMinRH"
        Me.ucrReceiverMinRH.Selector = Nothing
        Me.ucrReceiverMinRH.Size = New System.Drawing.Size(99, 20)
        Me.ucrReceiverMinRH.strNcFilePath = ""
        Me.ucrReceiverMinRH.TabIndex = 17
        Me.ucrReceiverMinRH.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.AutoSize = True
        Me.ucrReceiverWindDirection.frmParent = Nothing
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(16, 193)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 9
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Nothing
        Me.ucrReceiverRain.Location = New System.Drawing.Point(16, 31)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 1
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverSunshine
        '
        Me.ucrReceiverSunshine.AutoSize = True
        Me.ucrReceiverSunshine.frmParent = Nothing
        Me.ucrReceiverSunshine.Location = New System.Drawing.Point(142, 31)
        Me.ucrReceiverSunshine.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSunshine.Name = "ucrReceiverSunshine"
        Me.ucrReceiverSunshine.Selector = Nothing
        Me.ucrReceiverSunshine.Size = New System.Drawing.Size(99, 20)
        Me.ucrReceiverSunshine.strNcFilePath = ""
        Me.ucrReceiverSunshine.TabIndex = 11
        Me.ucrReceiverSunshine.ucrSelector = Nothing
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.AutoSize = True
        Me.ucrReceiverRadiation.frmParent = Nothing
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(142, 70)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(99, 20)
        Me.ucrReceiverRadiation.strNcFilePath = ""
        Me.ucrReceiverRadiation.TabIndex = 13
        Me.ucrReceiverRadiation.ucrSelector = Nothing
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.AutoSize = True
        Me.ucrReceiverMaxTemp.frmParent = Nothing
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(16, 111)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverMaxTemp.strNcFilePath = ""
        Me.ucrReceiverMaxTemp.TabIndex = 5
        Me.ucrReceiverMaxTemp.ucrSelector = Nothing
        '
        'ucrReceiverCloudCover
        '
        Me.ucrReceiverCloudCover.AutoSize = True
        Me.ucrReceiverCloudCover.frmParent = Nothing
        Me.ucrReceiverCloudCover.Location = New System.Drawing.Point(142, 111)
        Me.ucrReceiverCloudCover.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCloudCover.Name = "ucrReceiverCloudCover"
        Me.ucrReceiverCloudCover.Selector = Nothing
        Me.ucrReceiverCloudCover.Size = New System.Drawing.Size(99, 20)
        Me.ucrReceiverCloudCover.strNcFilePath = ""
        Me.ucrReceiverCloudCover.TabIndex = 15
        Me.ucrReceiverCloudCover.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Nothing
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(16, 152)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 7
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.AutoSize = True
        Me.ucrReceiverMinTemp.frmParent = Nothing
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(16, 70)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverMinTemp.strNcFilePath = ""
        Me.ucrReceiverMinTemp.TabIndex = 3
        Me.ucrReceiverMinTemp.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(80, 492)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrSelectorDefineClimaticData
        '
        Me.ucrSelectorDefineClimaticData.AutoSize = True
        Me.ucrSelectorDefineClimaticData.bDropUnusedFilterLevels = False
        Me.ucrSelectorDefineClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDefineClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDefineClimaticData.Location = New System.Drawing.Point(13, 10)
        Me.ucrSelectorDefineClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineClimaticData.Name = "ucrSelectorDefineClimaticData"
        Me.ucrSelectorDefineClimaticData.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDefineClimaticData.TabIndex = 0
        '
        'DlgDefineClimaticData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(521, 553)
        Me.Controls.Add(Me.ucrChkLinkedMetaData)
        Me.Controls.Add(Me.ucrSelectorLinkedDataFrame)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUnique)
        Me.Controls.Add(Me.grpStation)
        Me.Controls.Add(Me.grpDateTime)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorDefineClimaticData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgDefineClimaticData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Climatic Data"
        Me.grpElements.ResumeLayout(False)
        Me.grpElements.PerformLayout()
        Me.grpDateTime.ResumeLayout(False)
        Me.grpDateTime.PerformLayout()
        Me.grpStation.ResumeLayout(False)
        Me.grpStation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorDefineClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpElements As GroupBox
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents ucrReceiverSunshine As ucrReceiverSingle
    Friend WithEvents ucrReceiverRadiation As ucrReceiverSingle
    Friend WithEvents ucrReceiverCloudCover As ucrReceiverSingle
    Friend WithEvents lblCloudCover As Label
    Friend WithEvents lblRadiation As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblSunshine As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents ucrReceiverMinTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblRain As Label
    Friend WithEvents lblMinTemp As Label
    Friend WithEvents lblMaxTemp As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblDay As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverStationName As ucrReceiverSingle
    Friend WithEvents lblStationName As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents grpDateTime As GroupBox
    Friend WithEvents grpStation As GroupBox
    Friend WithEvents ucrInputCheckInput As ucrInputTextBox
    Friend WithEvents cmdCheckUnique As Button
    Friend WithEvents ucrReceiverMinRH As ucrReceiverSingle
    Friend WithEvents lblMinimumRH As Label
    Friend WithEvents ucrReceiverMaxRH As ucrReceiverSingle
    Friend WithEvents lblMaxRH As Label
    Friend WithEvents lblAltitude As Label
    Friend WithEvents ucrReceiverAltitude As ucrReceiverSingle
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrSelectorLinkedDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkLinkedMetaData As ucrCheck
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongitude1 As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude1 As ucrReceiverSingle
    Friend WithEvents ucrReceiverAltitude1 As ucrReceiverSingle
End Class
