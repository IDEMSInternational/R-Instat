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
        Me.lblDiscrit = New System.Windows.Forms.Label()
        Me.ucrReceiverDiscrit = New instat.ucrReceiverSingle()
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
        Me.lblDiscritMeta = New System.Windows.Forms.Label()
        Me.ucrReceiverDiscritMeta = New instat.ucrReceiverSingle()
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
        Me.cmdCheckUnique.Location = New System.Drawing.Point(9, 656)
        Me.cmdCheckUnique.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCheckUnique.Name = "cmdCheckUnique"
        Me.cmdCheckUnique.Size = New System.Drawing.Size(208, 34)
        Me.cmdCheckUnique.TabIndex = 9
        Me.cmdCheckUnique.Text = "Check Duplicates"
        Me.cmdCheckUnique.UseVisualStyleBackColor = True
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationName.Location = New System.Drawing.Point(15, 21)
        Me.lblStationName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(55, 20)
        Me.lblStationName.TabIndex = 0
        Me.lblStationName.Text = "Name:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDOY.Location = New System.Drawing.Point(18, 232)
        Me.lblDOY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(97, 20)
        Me.lblDOY.TabIndex = 7
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitude.Location = New System.Drawing.Point(15, 200)
        Me.lblLongitude.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(84, 20)
        Me.lblLongitude.TabIndex = 6
        Me.lblLongitude.Text = "Longitude:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(15, 142)
        Me.lblLatitude.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(71, 20)
        Me.lblLatitude.TabIndex = 4
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblAltitude
        '
        Me.lblAltitude.AutoSize = True
        Me.lblAltitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltitude.Location = New System.Drawing.Point(15, 258)
        Me.lblAltitude.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.Size = New System.Drawing.Size(67, 20)
        Me.lblAltitude.TabIndex = 8
        Me.lblAltitude.Text = "Altitude:"
        '
        'grpStation
        '
        Me.grpStation.Controls.Add(Me.lblDiscrit)
        Me.grpStation.Controls.Add(Me.ucrReceiverDiscrit)
        Me.grpStation.Controls.Add(Me.lblLongitude)
        Me.grpStation.Controls.Add(Me.lblLatitude)
        Me.grpStation.Controls.Add(Me.lblAltitude)
        Me.grpStation.Controls.Add(Me.lblStationName)
        Me.grpStation.Controls.Add(Me.ucrReceiverStation)
        Me.grpStation.Controls.Add(Me.ucrReceiverLongitude)
        Me.grpStation.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpStation.Controls.Add(Me.ucrReceiverAltitude)
        Me.grpStation.Location = New System.Drawing.Point(363, 316)
        Me.grpStation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpStation.Name = "grpStation"
        Me.grpStation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpStation.Size = New System.Drawing.Size(189, 324)
        Me.grpStation.TabIndex = 4
        Me.grpStation.TabStop = False
        Me.grpStation.Tag = ""
        Me.grpStation.Text = "Station"
        '
        'lblDiscrit
        '
        Me.lblDiscrit.AutoSize = True
        Me.lblDiscrit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiscrit.Location = New System.Drawing.Point(15, 86)
        Me.lblDiscrit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscrit.Name = "lblDiscrit"
        Me.lblDiscrit.Size = New System.Drawing.Size(59, 20)
        Me.lblDiscrit.TabIndex = 2
        Me.lblDiscrit.Text = "district:"
        '
        'ucrReceiverDiscrit
        '
        Me.ucrReceiverDiscrit.AutoSize = True
        Me.ucrReceiverDiscrit.frmParent = Me
        Me.ucrReceiverDiscrit.Location = New System.Drawing.Point(15, 108)
        Me.ucrReceiverDiscrit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDiscrit.Name = "ucrReceiverDiscrit"
        Me.ucrReceiverDiscrit.Selector = Nothing
        Me.ucrReceiverDiscrit.Size = New System.Drawing.Size(150, 30)
        Me.ucrReceiverDiscrit.strNcFilePath = ""
        Me.ucrReceiverDiscrit.TabIndex = 3
        Me.ucrReceiverDiscrit.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(15, 44)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(150, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 1
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(15, 222)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(150, 30)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 7
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(15, 165)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(150, 30)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 5
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverAltitude
        '
        Me.ucrReceiverAltitude.AutoSize = True
        Me.ucrReceiverAltitude.frmParent = Me
        Me.ucrReceiverAltitude.Location = New System.Drawing.Point(15, 280)
        Me.ucrReceiverAltitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltitude.Name = "ucrReceiverAltitude"
        Me.ucrReceiverAltitude.Selector = Nothing
        Me.ucrReceiverAltitude.Size = New System.Drawing.Size(150, 30)
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
        Me.grpDateTime.Location = New System.Drawing.Point(363, 18)
        Me.grpDateTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDateTime.Size = New System.Drawing.Size(189, 294)
        Me.grpDateTime.TabIndex = 3
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Tag = ""
        Me.grpDateTime.Text = "Date and Time"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(18, 93)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 2
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(18, 20)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(18, 126)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(58, 20)
        Me.lblMonth.TabIndex = 3
        Me.lblMonth.Text = "Month:"
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(18, 255)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 8
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(18, 72)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(18, 39)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 1
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(18, 147)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 4
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.AutoSize = True
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(18, 200)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 6
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDay.Location = New System.Drawing.Point(18, 180)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(41, 20)
        Me.lblDay.TabIndex = 5
        Me.lblDay.Text = "Day:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(14, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Longitude:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(14, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Latitude:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(14, 264)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Altitude:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(14, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Name:"
        '
        'grpMeta
        '
        Me.grpMeta.Controls.Add(Me.lblDiscritMeta)
        Me.grpMeta.Controls.Add(Me.ucrReceiverDiscritMeta)
        Me.grpMeta.Controls.Add(Me.Label1)
        Me.grpMeta.Controls.Add(Me.Label2)
        Me.grpMeta.Controls.Add(Me.Label3)
        Me.grpMeta.Controls.Add(Me.Label4)
        Me.grpMeta.Controls.Add(Me.ucrReceiverStationMeta)
        Me.grpMeta.Controls.Add(Me.ucrReceiverLonMeta)
        Me.grpMeta.Controls.Add(Me.ucrReceiverLatMeta)
        Me.grpMeta.Controls.Add(Me.ucrReceiverAltMeta)
        Me.grpMeta.Location = New System.Drawing.Point(363, 316)
        Me.grpMeta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMeta.Name = "grpMeta"
        Me.grpMeta.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMeta.Size = New System.Drawing.Size(168, 324)
        Me.grpMeta.TabIndex = 5
        Me.grpMeta.TabStop = False
        Me.grpMeta.Tag = ""
        Me.grpMeta.Text = "Station"
        '
        'lblDiscritMeta
        '
        Me.lblDiscritMeta.AutoSize = True
        Me.lblDiscritMeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiscritMeta.Location = New System.Drawing.Point(14, 87)
        Me.lblDiscritMeta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscritMeta.Name = "lblDiscritMeta"
        Me.lblDiscritMeta.Size = New System.Drawing.Size(59, 20)
        Me.lblDiscritMeta.TabIndex = 2
        Me.lblDiscritMeta.Text = "district:"
        '
        'ucrReceiverDiscritMeta
        '
        Me.ucrReceiverDiscritMeta.AutoSize = True
        Me.ucrReceiverDiscritMeta.frmParent = Me
        Me.ucrReceiverDiscritMeta.Location = New System.Drawing.Point(16, 110)
        Me.ucrReceiverDiscritMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDiscritMeta.Name = "ucrReceiverDiscritMeta"
        Me.ucrReceiverDiscritMeta.Selector = Nothing
        Me.ucrReceiverDiscritMeta.Size = New System.Drawing.Size(140, 30)
        Me.ucrReceiverDiscritMeta.strNcFilePath = ""
        Me.ucrReceiverDiscritMeta.TabIndex = 3
        Me.ucrReceiverDiscritMeta.ucrSelector = Nothing
        '
        'ucrReceiverStationMeta
        '
        Me.ucrReceiverStationMeta.AutoSize = True
        Me.ucrReceiverStationMeta.frmParent = Me
        Me.ucrReceiverStationMeta.Location = New System.Drawing.Point(16, 50)
        Me.ucrReceiverStationMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationMeta.Name = "ucrReceiverStationMeta"
        Me.ucrReceiverStationMeta.Selector = Nothing
        Me.ucrReceiverStationMeta.Size = New System.Drawing.Size(140, 30)
        Me.ucrReceiverStationMeta.strNcFilePath = ""
        Me.ucrReceiverStationMeta.TabIndex = 1
        Me.ucrReceiverStationMeta.ucrSelector = Nothing
        '
        'ucrReceiverLonMeta
        '
        Me.ucrReceiverLonMeta.AutoSize = True
        Me.ucrReceiverLonMeta.frmParent = Me
        Me.ucrReceiverLonMeta.Location = New System.Drawing.Point(14, 225)
        Me.ucrReceiverLonMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLonMeta.Name = "ucrReceiverLonMeta"
        Me.ucrReceiverLonMeta.Selector = Nothing
        Me.ucrReceiverLonMeta.Size = New System.Drawing.Size(140, 30)
        Me.ucrReceiverLonMeta.strNcFilePath = ""
        Me.ucrReceiverLonMeta.TabIndex = 8
        Me.ucrReceiverLonMeta.ucrSelector = Nothing
        '
        'ucrReceiverLatMeta
        '
        Me.ucrReceiverLatMeta.AutoSize = True
        Me.ucrReceiverLatMeta.frmParent = Me
        Me.ucrReceiverLatMeta.Location = New System.Drawing.Point(14, 168)
        Me.ucrReceiverLatMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatMeta.Name = "ucrReceiverLatMeta"
        Me.ucrReceiverLatMeta.Selector = Nothing
        Me.ucrReceiverLatMeta.Size = New System.Drawing.Size(140, 30)
        Me.ucrReceiverLatMeta.strNcFilePath = ""
        Me.ucrReceiverLatMeta.TabIndex = 5
        Me.ucrReceiverLatMeta.ucrSelector = Nothing
        '
        'ucrReceiverAltMeta
        '
        Me.ucrReceiverAltMeta.AutoSize = True
        Me.ucrReceiverAltMeta.frmParent = Me
        Me.ucrReceiverAltMeta.Location = New System.Drawing.Point(14, 286)
        Me.ucrReceiverAltMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltMeta.Name = "ucrReceiverAltMeta"
        Me.ucrReceiverAltMeta.Selector = Nothing
        Me.ucrReceiverAltMeta.Size = New System.Drawing.Size(140, 30)
        Me.ucrReceiverAltMeta.strNcFilePath = ""
        Me.ucrReceiverAltMeta.TabIndex = 9
        Me.ucrReceiverAltMeta.ucrSelector = Nothing
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRain.Location = New System.Drawing.Point(22, 22)
        Me.lblRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(46, 20)
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
        Me.grpElements.Location = New System.Drawing.Point(561, 18)
        Me.grpElements.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpElements.Name = "grpElements"
        Me.grpElements.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpElements.Size = New System.Drawing.Size(226, 592)
        Me.grpElements.TabIndex = 6
        Me.grpElements.TabStop = False
        Me.grpElements.Text = "Elements"
        '
        'ucrReceiverMaxRH
        '
        Me.ucrReceiverMaxRH.AutoSize = True
        Me.ucrReceiverMaxRH.frmParent = Me
        Me.ucrReceiverMaxRH.Location = New System.Drawing.Point(27, 549)
        Me.ucrReceiverMaxRH.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxRH.Name = "ucrReceiverMaxRH"
        Me.ucrReceiverMaxRH.Selector = Nothing
        Me.ucrReceiverMaxRH.Size = New System.Drawing.Size(174, 30)
        Me.ucrReceiverMaxRH.strNcFilePath = ""
        Me.ucrReceiverMaxRH.TabIndex = 19
        Me.ucrReceiverMaxRH.ucrSelector = Nothing
        '
        'lblMaxRH
        '
        Me.lblMaxRH.AutoSize = True
        Me.lblMaxRH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxRH.Location = New System.Drawing.Point(22, 526)
        Me.lblMaxRH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxRH.Name = "lblMaxRH"
        Me.lblMaxRH.Size = New System.Drawing.Size(136, 20)
        Me.lblMaxRH.TabIndex = 18
        Me.lblMaxRH.Text = "Maximum RH (%):"
        '
        'ucrReceiverMinRH
        '
        Me.ucrReceiverMinRH.AutoSize = True
        Me.ucrReceiverMinRH.frmParent = Me
        Me.ucrReceiverMinRH.Location = New System.Drawing.Point(27, 495)
        Me.ucrReceiverMinRH.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinRH.Name = "ucrReceiverMinRH"
        Me.ucrReceiverMinRH.Selector = Nothing
        Me.ucrReceiverMinRH.Size = New System.Drawing.Size(174, 30)
        Me.ucrReceiverMinRH.strNcFilePath = ""
        Me.ucrReceiverMinRH.TabIndex = 17
        Me.ucrReceiverMinRH.ucrSelector = Nothing
        '
        'lblMinimumRH
        '
        Me.lblMinimumRH.AutoSize = True
        Me.lblMinimumRH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinimumRH.Location = New System.Drawing.Point(22, 472)
        Me.lblMinimumRH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimumRH.Name = "lblMinimumRH"
        Me.lblMinimumRH.Size = New System.Drawing.Size(132, 20)
        Me.lblMinimumRH.TabIndex = 16
        Me.lblMinimumRH.Text = "Minimum RH (%):"
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.AutoSize = True
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(27, 266)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(166, 30)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 9
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(27, 45)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(166, 30)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 1
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverSunshine
        '
        Me.ucrReceiverSunshine.AutoSize = True
        Me.ucrReceiverSunshine.frmParent = Me
        Me.ucrReceiverSunshine.Location = New System.Drawing.Point(27, 322)
        Me.ucrReceiverSunshine.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSunshine.Name = "ucrReceiverSunshine"
        Me.ucrReceiverSunshine.Selector = Nothing
        Me.ucrReceiverSunshine.Size = New System.Drawing.Size(174, 30)
        Me.ucrReceiverSunshine.strNcFilePath = ""
        Me.ucrReceiverSunshine.TabIndex = 11
        Me.ucrReceiverSunshine.ucrSelector = Nothing
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.AutoSize = True
        Me.ucrReceiverRadiation.frmParent = Me
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(27, 381)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(174, 30)
        Me.ucrReceiverRadiation.strNcFilePath = ""
        Me.ucrReceiverRadiation.TabIndex = 13
        Me.ucrReceiverRadiation.ucrSelector = Nothing
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.AutoSize = True
        Me.ucrReceiverMaxTemp.frmParent = Me
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(27, 154)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(166, 30)
        Me.ucrReceiverMaxTemp.strNcFilePath = ""
        Me.ucrReceiverMaxTemp.TabIndex = 5
        Me.ucrReceiverMaxTemp.ucrSelector = Nothing
        '
        'ucrReceiverCloudCover
        '
        Me.ucrReceiverCloudCover.AutoSize = True
        Me.ucrReceiverCloudCover.frmParent = Me
        Me.ucrReceiverCloudCover.Location = New System.Drawing.Point(27, 438)
        Me.ucrReceiverCloudCover.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCloudCover.Name = "ucrReceiverCloudCover"
        Me.ucrReceiverCloudCover.Selector = Nothing
        Me.ucrReceiverCloudCover.Size = New System.Drawing.Size(174, 30)
        Me.ucrReceiverCloudCover.strNcFilePath = ""
        Me.ucrReceiverCloudCover.TabIndex = 15
        Me.ucrReceiverCloudCover.ucrSelector = Nothing
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxTemp.Location = New System.Drawing.Point(22, 132)
        Me.lblMaxTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(175, 20)
        Me.lblMaxTemp.TabIndex = 4
        Me.lblMaxTemp.Text = "Maximum Temperature:"
        '
        'lblCloudCover
        '
        Me.lblCloudCover.AutoSize = True
        Me.lblCloudCover.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCloudCover.Location = New System.Drawing.Point(22, 416)
        Me.lblCloudCover.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCloudCover.Name = "lblCloudCover"
        Me.lblCloudCover.Size = New System.Drawing.Size(99, 20)
        Me.lblCloudCover.TabIndex = 14
        Me.lblCloudCover.Text = "Cloud Cover:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinTemp.Location = New System.Drawing.Point(22, 76)
        Me.lblMinTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(171, 20)
        Me.lblMinTemp.TabIndex = 2
        Me.lblMinTemp.Text = "Minimum Temperature:"
        '
        'lblRadiation
        '
        Me.lblRadiation.AutoSize = True
        Me.lblRadiation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRadiation.Location = New System.Drawing.Point(22, 358)
        Me.lblRadiation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(81, 20)
        Me.lblRadiation.TabIndex = 12
        Me.lblRadiation.Text = "Radiation:"
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(27, 210)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(166, 30)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 7
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'lblSunshine
        '
        Me.lblSunshine.AutoSize = True
        Me.lblSunshine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSunshine.Location = New System.Drawing.Point(22, 298)
        Me.lblSunshine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSunshine.Name = "lblSunshine"
        Me.lblSunshine.Size = New System.Drawing.Size(127, 20)
        Me.lblSunshine.TabIndex = 10
        Me.lblSunshine.Text = "Sunshine Hours:"
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.AutoSize = True
        Me.ucrReceiverMinTemp.frmParent = Me
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(27, 99)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(166, 30)
        Me.ucrReceiverMinTemp.strNcFilePath = ""
        Me.ucrReceiverMinTemp.TabIndex = 3
        Me.ucrReceiverMinTemp.ucrSelector = Nothing
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWindSpeed.Location = New System.Drawing.Point(22, 188)
        Me.lblWindSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(100, 20)
        Me.lblWindSpeed.TabIndex = 6
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWindDirection.Location = New System.Drawing.Point(22, 243)
        Me.lblWindDirection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(116, 20)
        Me.lblWindDirection.TabIndex = 8
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'ucrChkLinkedMetaData
        '
        Me.ucrChkLinkedMetaData.AutoSize = True
        Me.ucrChkLinkedMetaData.Checked = False
        Me.ucrChkLinkedMetaData.Location = New System.Drawing.Point(24, 306)
        Me.ucrChkLinkedMetaData.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkLinkedMetaData.Name = "ucrChkLinkedMetaData"
        Me.ucrChkLinkedMetaData.Size = New System.Drawing.Size(292, 34)
        Me.ucrChkLinkedMetaData.TabIndex = 7
        '
        'ucrSelectorLinkedDataFrame
        '
        Me.ucrSelectorLinkedDataFrame.AutoSize = True
        Me.ucrSelectorLinkedDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorLinkedDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorLinkedDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorLinkedDataFrame.Location = New System.Drawing.Point(24, 336)
        Me.ucrSelectorLinkedDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLinkedDataFrame.Name = "ucrSelectorLinkedDataFrame"
        Me.ucrSelectorLinkedDataFrame.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorLinkedDataFrame.TabIndex = 8
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInput.AutoSize = True
        Me.ucrInputCheckInput.IsMultiline = False
        Me.ucrInputCheckInput.IsReadOnly = False
        Me.ucrInputCheckInput.Location = New System.Drawing.Point(220, 658)
        Me.ucrInputCheckInput.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        Me.ucrInputCheckInput.Size = New System.Drawing.Size(380, 32)
        Me.ucrInputCheckInput.TabIndex = 10
        '
        'ucrSelectorDefineClimaticData
        '
        Me.ucrSelectorDefineClimaticData.AutoSize = True
        Me.ucrSelectorDefineClimaticData.bDropUnusedFilterLevels = False
        Me.ucrSelectorDefineClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDefineClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDefineClimaticData.Location = New System.Drawing.Point(24, 14)
        Me.ucrSelectorDefineClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineClimaticData.Name = "ucrSelectorDefineClimaticData"
        Me.ucrSelectorDefineClimaticData.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorDefineClimaticData.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 714)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 11
        '
        'DlgDefineClimaticData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 796)
        Me.Controls.Add(Me.ucrChkLinkedMetaData)
        Me.Controls.Add(Me.ucrSelectorLinkedDataFrame)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUnique)
        Me.Controls.Add(Me.ucrSelectorDefineClimaticData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpDateTime)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.grpMeta)
        Me.Controls.Add(Me.grpStation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents lblDiscritMeta As Label
    Friend WithEvents ucrReceiverDiscritMeta As ucrReceiverSingle
    Friend WithEvents lblDiscrit As Label
    Friend WithEvents ucrReceiverDiscrit As ucrReceiverSingle
End Class
