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
        Me.cmdCheckUnique = New System.Windows.Forms.Button()
        Me.lblStationName = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblAltitude = New System.Windows.Forms.Label()
        Me.grpStation = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverAltitude = New instat.ucrReceiverSingle()
        Me.grpDateTime = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpMeta = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverStationMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverLonMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverAltMeta = New instat.ucrReceiverSingle()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverMaxRH = New instat.ucrReceiverSingle()
        Me.lblMaxRH = New System.Windows.Forms.Label()
        Me.ucrReceiverMinRH = New instat.ucrReceiverSingle()
        Me.lblMinimumRH = New System.Windows.Forms.Label()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverSunshine = New instat.ucrReceiverSingle()
        Me.ucrReceiverRadiation = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverCloudCover = New instat.ucrReceiverSingle()
        Me.lblMaxTemp = New System.Windows.Forms.Label()
        Me.lblCloudCover = New System.Windows.Forms.Label()
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.lblRadiation = New System.Windows.Forms.Label()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.lblSunshine = New System.Windows.Forms.Label()
        Me.ucrReceiverMinTemp = New instat.ucrReceiverSingle()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.ucrChkLinkedMetaData = New instat.ucrCheck()
        Me.ucrSelectorLinkedDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.ucrSelectorDefineClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpStation.SuspendLayout()
        Me.grpDateTime.SuspendLayout()
        Me.grpMeta.SuspendLayout()
        Me.grpElements.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCheckUnique
        '
        Me.cmdCheckUnique.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheckUnique.Location = New System.Drawing.Point(6, 437)
        Me.cmdCheckUnique.Name = "cmdCheckUnique"
        Me.cmdCheckUnique.Size = New System.Drawing.Size(139, 23)
        Me.cmdCheckUnique.TabIndex = 17
        Me.cmdCheckUnique.Text = "Check Duplicates"
        Me.cmdCheckUnique.UseVisualStyleBackColor = True
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationName.Location = New System.Drawing.Point(10, 14)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(38, 13)
        Me.lblStationName.TabIndex = 0
        Me.lblStationName.Text = "Name:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDOY.Location = New System.Drawing.Point(12, 155)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 8
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitude.Location = New System.Drawing.Point(10, 91)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongitude.TabIndex = 6
        Me.lblLongitude.Text = "Longitude:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(10, 53)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(48, 13)
        Me.lblLatitude.TabIndex = 4
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblAltitude
        '
        Me.lblAltitude.AutoSize = True
        Me.lblAltitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltitude.Location = New System.Drawing.Point(10, 130)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.Size = New System.Drawing.Size(45, 13)
        Me.lblAltitude.TabIndex = 2
        Me.lblAltitude.Text = "Altitude:"
        '
        'grpStation
        '
        Me.grpStation.Controls.Add(Me.lblLongitude)
        Me.grpStation.Controls.Add(Me.lblLatitude)
        Me.grpStation.Controls.Add(Me.lblAltitude)
        Me.grpStation.Controls.Add(Me.lblStationName)
        Me.grpStation.Controls.Add(Me.ucrReceiverStation)
        Me.grpStation.Controls.Add(Me.ucrReceiverLongitude)
        Me.grpStation.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpStation.Controls.Add(Me.ucrReceiverAltitude)
        Me.grpStation.Location = New System.Drawing.Point(242, 234)
        Me.grpStation.Name = "grpStation"
        Me.grpStation.Size = New System.Drawing.Size(126, 173)
        Me.grpStation.TabIndex = 14
        Me.grpStation.TabStop = False
        Me.grpStation.Tag = ""
        Me.grpStation.Text = "Station"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(10, 29)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(100, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(10, 106)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(100, 20)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 8
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(10, 68)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(100, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 7
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverAltitude
        '
        Me.ucrReceiverAltitude.AutoSize = True
        Me.ucrReceiverAltitude.frmParent = Me
        Me.ucrReceiverAltitude.Location = New System.Drawing.Point(10, 145)
        Me.ucrReceiverAltitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltitude.Name = "ucrReceiverAltitude"
        Me.ucrReceiverAltitude.Selector = Nothing
        Me.ucrReceiverAltitude.Size = New System.Drawing.Size(100, 20)
        Me.ucrReceiverAltitude.strNcFilePath = ""
        Me.ucrReceiverAltitude.TabIndex = 9
        Me.ucrReceiverAltitude.ucrSelector = Nothing
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
        Me.grpDateTime.Location = New System.Drawing.Point(242, 12)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Size = New System.Drawing.Size(126, 196)
        Me.grpDateTime.TabIndex = 15
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Tag = ""
        Me.grpDateTime.Text = "Date and Time"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(12, 62)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 2
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(12, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(12, 84)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "Month:"
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(12, 170)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 5
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(12, 48)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(12, 26)
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
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(12, 98)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 3
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.AutoSize = True
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(12, 133)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 4
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDay.Location = New System.Drawing.Point(12, 120)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Longitude:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(9, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Latitude:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(9, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altitude:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Name:"
        '
        'grpMeta
        '
        Me.grpMeta.Controls.Add(Me.Label1)
        Me.grpMeta.Controls.Add(Me.Label2)
        Me.grpMeta.Controls.Add(Me.Label3)
        Me.grpMeta.Controls.Add(Me.Label4)
        Me.grpMeta.Controls.Add(Me.ucrReceiverStationMeta)
        Me.grpMeta.Controls.Add(Me.ucrReceiverLonMeta)
        Me.grpMeta.Controls.Add(Me.ucrReceiverLatMeta)
        Me.grpMeta.Controls.Add(Me.ucrReceiverAltMeta)
        Me.grpMeta.Location = New System.Drawing.Point(242, 234)
        Me.grpMeta.Name = "grpMeta"
        Me.grpMeta.Size = New System.Drawing.Size(112, 173)
        Me.grpMeta.TabIndex = 22
        Me.grpMeta.TabStop = False
        Me.grpMeta.Tag = ""
        Me.grpMeta.Text = "Station"
        '
        'ucrReceiverStationMeta
        '
        Me.ucrReceiverStationMeta.AutoSize = True
        Me.ucrReceiverStationMeta.frmParent = Me
        Me.ucrReceiverStationMeta.Location = New System.Drawing.Point(11, 31)
        Me.ucrReceiverStationMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationMeta.Name = "ucrReceiverStationMeta"
        Me.ucrReceiverStationMeta.Selector = Nothing
        Me.ucrReceiverStationMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverStationMeta.strNcFilePath = ""
        Me.ucrReceiverStationMeta.TabIndex = 8
        Me.ucrReceiverStationMeta.ucrSelector = Nothing
        '
        'ucrReceiverLonMeta
        '
        Me.ucrReceiverLonMeta.AutoSize = True
        Me.ucrReceiverLonMeta.frmParent = Me
        Me.ucrReceiverLonMeta.Location = New System.Drawing.Point(9, 108)
        Me.ucrReceiverLonMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLonMeta.Name = "ucrReceiverLonMeta"
        Me.ucrReceiverLonMeta.Selector = Nothing
        Me.ucrReceiverLonMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverLonMeta.strNcFilePath = ""
        Me.ucrReceiverLonMeta.TabIndex = 10
        Me.ucrReceiverLonMeta.ucrSelector = Nothing
        '
        'ucrReceiverLatMeta
        '
        Me.ucrReceiverLatMeta.AutoSize = True
        Me.ucrReceiverLatMeta.frmParent = Me
        Me.ucrReceiverLatMeta.Location = New System.Drawing.Point(9, 70)
        Me.ucrReceiverLatMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatMeta.Name = "ucrReceiverLatMeta"
        Me.ucrReceiverLatMeta.Selector = Nothing
        Me.ucrReceiverLatMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverLatMeta.strNcFilePath = ""
        Me.ucrReceiverLatMeta.TabIndex = 9
        Me.ucrReceiverLatMeta.ucrSelector = Nothing
        '
        'ucrReceiverAltMeta
        '
        Me.ucrReceiverAltMeta.AutoSize = True
        Me.ucrReceiverAltMeta.frmParent = Me
        Me.ucrReceiverAltMeta.Location = New System.Drawing.Point(9, 147)
        Me.ucrReceiverAltMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltMeta.Name = "ucrReceiverAltMeta"
        Me.ucrReceiverAltMeta.Selector = Nothing
        Me.ucrReceiverAltMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverAltMeta.strNcFilePath = ""
        Me.ucrReceiverAltMeta.TabIndex = 11
        Me.ucrReceiverAltMeta.ucrSelector = Nothing
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRain.Location = New System.Drawing.Point(15, 15)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 0
        Me.lblRain.Text = "Rain:"
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
        Me.grpElements.Location = New System.Drawing.Point(374, 12)
        Me.grpElements.Name = "grpElements"
        Me.grpElements.Size = New System.Drawing.Size(151, 395)
        Me.grpElements.TabIndex = 16
        Me.grpElements.TabStop = False
        Me.grpElements.Text = "Elements"
        '
        'ucrReceiverMaxRH
        '
        Me.ucrReceiverMaxRH.AutoSize = True
        Me.ucrReceiverMaxRH.frmParent = Me
        Me.ucrReceiverMaxRH.Location = New System.Drawing.Point(18, 366)
        Me.ucrReceiverMaxRH.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxRH.Name = "ucrReceiverMaxRH"
        Me.ucrReceiverMaxRH.Selector = Nothing
        Me.ucrReceiverMaxRH.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverMaxRH.strNcFilePath = ""
        Me.ucrReceiverMaxRH.TabIndex = 19
        Me.ucrReceiverMaxRH.ucrSelector = Nothing
        '
        'lblMaxRH
        '
        Me.lblMaxRH.AutoSize = True
        Me.lblMaxRH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxRH.Location = New System.Drawing.Point(15, 351)
        Me.lblMaxRH.Name = "lblMaxRH"
        Me.lblMaxRH.Size = New System.Drawing.Size(90, 13)
        Me.lblMaxRH.TabIndex = 18
        Me.lblMaxRH.Text = "Maximum RH (%):"
        '
        'ucrReceiverMinRH
        '
        Me.ucrReceiverMinRH.AutoSize = True
        Me.ucrReceiverMinRH.frmParent = Me
        Me.ucrReceiverMinRH.Location = New System.Drawing.Point(18, 330)
        Me.ucrReceiverMinRH.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinRH.Name = "ucrReceiverMinRH"
        Me.ucrReceiverMinRH.Selector = Nothing
        Me.ucrReceiverMinRH.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverMinRH.strNcFilePath = ""
        Me.ucrReceiverMinRH.TabIndex = 18
        Me.ucrReceiverMinRH.ucrSelector = Nothing
        '
        'lblMinimumRH
        '
        Me.lblMinimumRH.AutoSize = True
        Me.lblMinimumRH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinimumRH.Location = New System.Drawing.Point(15, 315)
        Me.lblMinimumRH.Name = "lblMinimumRH"
        Me.lblMinimumRH.Size = New System.Drawing.Size(87, 13)
        Me.lblMinimumRH.TabIndex = 16
        Me.lblMinimumRH.Text = "Minimum RH (%):"
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.AutoSize = True
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(18, 177)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 14
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(18, 30)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 10
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverSunshine
        '
        Me.ucrReceiverSunshine.AutoSize = True
        Me.ucrReceiverSunshine.frmParent = Me
        Me.ucrReceiverSunshine.Location = New System.Drawing.Point(18, 215)
        Me.ucrReceiverSunshine.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSunshine.Name = "ucrReceiverSunshine"
        Me.ucrReceiverSunshine.Selector = Nothing
        Me.ucrReceiverSunshine.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverSunshine.strNcFilePath = ""
        Me.ucrReceiverSunshine.TabIndex = 15
        Me.ucrReceiverSunshine.ucrSelector = Nothing
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.AutoSize = True
        Me.ucrReceiverRadiation.frmParent = Me
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(18, 254)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverRadiation.strNcFilePath = ""
        Me.ucrReceiverRadiation.TabIndex = 16
        Me.ucrReceiverRadiation.ucrSelector = Nothing
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.AutoSize = True
        Me.ucrReceiverMaxTemp.frmParent = Me
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(18, 103)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverMaxTemp.strNcFilePath = ""
        Me.ucrReceiverMaxTemp.TabIndex = 12
        Me.ucrReceiverMaxTemp.ucrSelector = Nothing
        '
        'ucrReceiverCloudCover
        '
        Me.ucrReceiverCloudCover.AutoSize = True
        Me.ucrReceiverCloudCover.frmParent = Me
        Me.ucrReceiverCloudCover.Location = New System.Drawing.Point(18, 292)
        Me.ucrReceiverCloudCover.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCloudCover.Name = "ucrReceiverCloudCover"
        Me.ucrReceiverCloudCover.Selector = Nothing
        Me.ucrReceiverCloudCover.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverCloudCover.strNcFilePath = ""
        Me.ucrReceiverCloudCover.TabIndex = 17
        Me.ucrReceiverCloudCover.ucrSelector = Nothing
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxTemp.Location = New System.Drawing.Point(15, 88)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(117, 13)
        Me.lblMaxTemp.TabIndex = 4
        Me.lblMaxTemp.Text = "Maximum Temperature:"
        '
        'lblCloudCover
        '
        Me.lblCloudCover.AutoSize = True
        Me.lblCloudCover.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCloudCover.Location = New System.Drawing.Point(15, 277)
        Me.lblCloudCover.Name = "lblCloudCover"
        Me.lblCloudCover.Size = New System.Drawing.Size(68, 13)
        Me.lblCloudCover.TabIndex = 14
        Me.lblCloudCover.Text = "Cloud Cover:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinTemp.Location = New System.Drawing.Point(15, 51)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(114, 13)
        Me.lblMinTemp.TabIndex = 2
        Me.lblMinTemp.Text = "Minimum Temperature:"
        '
        'lblRadiation
        '
        Me.lblRadiation.AutoSize = True
        Me.lblRadiation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRadiation.Location = New System.Drawing.Point(15, 239)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(55, 13)
        Me.lblRadiation.TabIndex = 12
        Me.lblRadiation.Text = "Radiation:"
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(18, 140)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 13
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'lblSunshine
        '
        Me.lblSunshine.AutoSize = True
        Me.lblSunshine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSunshine.Location = New System.Drawing.Point(15, 199)
        Me.lblSunshine.Name = "lblSunshine"
        Me.lblSunshine.Size = New System.Drawing.Size(85, 13)
        Me.lblSunshine.TabIndex = 10
        Me.lblSunshine.Text = "Sunshine Hours:"
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.AutoSize = True
        Me.ucrReceiverMinTemp.frmParent = Me
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(18, 66)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(111, 20)
        Me.ucrReceiverMinTemp.strNcFilePath = ""
        Me.ucrReceiverMinTemp.TabIndex = 11
        Me.ucrReceiverMinTemp.ucrSelector = Nothing
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWindSpeed.Location = New System.Drawing.Point(15, 125)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 6
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWindDirection.Location = New System.Drawing.Point(15, 162)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 8
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'ucrChkLinkedMetaData
        '
        Me.ucrChkLinkedMetaData.AutoSize = True
        Me.ucrChkLinkedMetaData.Checked = False
        Me.ucrChkLinkedMetaData.Location = New System.Drawing.Point(16, 204)
        Me.ucrChkLinkedMetaData.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkLinkedMetaData.Name = "ucrChkLinkedMetaData"
        Me.ucrChkLinkedMetaData.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkLinkedMetaData.TabIndex = 21
        '
        'ucrSelectorLinkedDataFrame
        '
        Me.ucrSelectorLinkedDataFrame.AutoSize = True
        Me.ucrSelectorLinkedDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorLinkedDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorLinkedDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorLinkedDataFrame.Location = New System.Drawing.Point(16, 224)
        Me.ucrSelectorLinkedDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLinkedDataFrame.Name = "ucrSelectorLinkedDataFrame"
        Me.ucrSelectorLinkedDataFrame.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorLinkedDataFrame.TabIndex = 20
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInput.AutoSize = True
        Me.ucrInputCheckInput.IsMultiline = False
        Me.ucrInputCheckInput.IsReadOnly = False
        Me.ucrInputCheckInput.Location = New System.Drawing.Point(147, 439)
        Me.ucrInputCheckInput.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        Me.ucrInputCheckInput.Size = New System.Drawing.Size(253, 21)
        Me.ucrInputCheckInput.TabIndex = 18
        '
        'ucrSelectorDefineClimaticData
        '
        Me.ucrSelectorDefineClimaticData.AutoSize = True
        Me.ucrSelectorDefineClimaticData.bDropUnusedFilterLevels = False
        Me.ucrSelectorDefineClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDefineClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDefineClimaticData.Location = New System.Drawing.Point(16, 9)
        Me.ucrSelectorDefineClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineClimaticData.Name = "ucrSelectorDefineClimaticData"
        Me.ucrSelectorDefineClimaticData.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDefineClimaticData.TabIndex = 13
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 476)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 19
        '
        'DlgDefineClimaticData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(533, 531)
        Me.Controls.Add(Me.ucrChkLinkedMetaData)
        Me.Controls.Add(Me.ucrSelectorLinkedDataFrame)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUnique)
        Me.Controls.Add(Me.ucrSelectorDefineClimaticData)
        Me.Controls.Add(Me.grpStation)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpDateTime)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.grpMeta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgDefineClimaticData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Climatic Data"
        Me.grpStation.ResumeLayout(False)
        Me.grpStation.PerformLayout()
        Me.grpDateTime.ResumeLayout(False)
        Me.grpDateTime.PerformLayout()
        Me.grpMeta.ResumeLayout(False)
        Me.grpMeta.PerformLayout()
        Me.grpElements.ResumeLayout(False)
        Me.grpElements.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkLinkedMetaData As ucrCheck
    Friend WithEvents ucrSelectorLinkedDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputCheckInput As ucrInputTextBox
    Friend WithEvents cmdCheckUnique As Button
    Friend WithEvents ucrSelectorDefineClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblStationName As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblAltitude As Label
    Friend WithEvents grpStation As GroupBox
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDateTime As GroupBox
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblDay As Label
    Friend WithEvents grpMeta As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ucrReceiverStationMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverLonMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverAltMeta As ucrReceiverSingle
    Friend WithEvents grpElements As GroupBox
    Friend WithEvents ucrReceiverMaxRH As ucrReceiverSingle
    Friend WithEvents lblMaxRH As Label
    Friend WithEvents ucrReceiverMinRH As ucrReceiverSingle
    Friend WithEvents lblMinimumRH As Label
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents ucrReceiverSunshine As ucrReceiverSingle
    Friend WithEvents lblRain As Label
    Friend WithEvents ucrReceiverRadiation As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverCloudCover As ucrReceiverSingle
    Friend WithEvents lblMaxTemp As Label
    Friend WithEvents lblCloudCover As Label
    Friend WithEvents lblMinTemp As Label
    Friend WithEvents lblRadiation As Label
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblSunshine As Label
    Friend WithEvents ucrReceiverMinTemp As ucrReceiverSingle
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverAltitude As ucrReceiverSingle
End Class
