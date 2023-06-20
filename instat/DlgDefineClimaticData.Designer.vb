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
        Me.lblRain = New System.Windows.Forms.Label()
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
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.grpDateTime = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.grpStation = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverStationName = New instat.ucrReceiverSingle()
        Me.cmdCheckUnique = New System.Windows.Forms.Button()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDefineClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStationMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverLonMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverAltMeta = New instat.ucrReceiverSingle()
        Me.grpElements.SuspendLayout()
        Me.grpDateTime.SuspendLayout()
        Me.grpStation.SuspendLayout()
        Me.grpMeta.SuspendLayout()
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
        Me.lblMaxRH.Name = "lblMaxRH"
        Me.lblMaxRH.Size = New System.Drawing.Size(90, 13)
        Me.lblMaxRH.TabIndex = 18
        Me.lblMaxRH.Text = "Maximum RH (%):"
        '
        'lblMinimumRH
        '
        Me.lblMinimumRH.AutoSize = True
        Me.lblMinimumRH.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.AutoSize = True
        Me.ucrReceiverRadiation.frmParent = Me
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(16, 272)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRadiation.strNcFilePath = ""
        Me.ucrReceiverRadiation.TabIndex = 13
        Me.ucrReceiverRadiation.ucrSelector = Nothing
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.AutoSize = True
        Me.ucrReceiverMaxTemp.frmParent = Me
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(16, 111)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxTemp.strNcFilePath = ""
        Me.ucrReceiverMaxTemp.TabIndex = 5
        Me.ucrReceiverMaxTemp.ucrSelector = Nothing
        '
        'ucrReceiverCloudCover
        '
        Me.ucrReceiverCloudCover.AutoSize = True
        Me.ucrReceiverCloudCover.frmParent = Me
        Me.ucrReceiverCloudCover.Location = New System.Drawing.Point(16, 313)
        Me.ucrReceiverCloudCover.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCloudCover.Name = "ucrReceiverCloudCover"
        Me.ucrReceiverCloudCover.Selector = Nothing
        Me.ucrReceiverCloudCover.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCloudCover.strNcFilePath = ""
        Me.ucrReceiverCloudCover.TabIndex = 15
        Me.ucrReceiverCloudCover.ucrSelector = Nothing
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
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(16, 152)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 7
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
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
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.AutoSize = True
        Me.ucrReceiverMinTemp.frmParent = Me
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(16, 70)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMinTemp.strNcFilePath = ""
        Me.ucrReceiverMinTemp.TabIndex = 3
        Me.ucrReceiverMinTemp.ucrSelector = Nothing
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
        Me.grpDateTime.Location = New System.Drawing.Point(379, 250)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Size = New System.Drawing.Size(126, 196)
        Me.grpDateTime.TabIndex = 2
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Tag = ""
        Me.grpDateTime.Text = "Date and Time"
        '

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
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(98, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 7
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        '
        'ucrReceiverStationName
        '
        '
        'cmdCheckUnique
        '
        '
        'ucrInputCheckInput
        '
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(13, 492)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
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
        'ucrReceiverStationMeta
        '
        Me.ucrReceiverStationMeta.AutoSize = True
        Me.ucrReceiverStationMeta.frmParent = Nothing
        Me.ucrReceiverStationMeta.Location = New System.Drawing.Point(9, 31)
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
        Me.ucrReceiverLonMeta.frmParent = Nothing
        Me.ucrReceiverLonMeta.Location = New System.Drawing.Point(7, 108)
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
        Me.ucrReceiverLatMeta.frmParent = Nothing
        Me.ucrReceiverLatMeta.Location = New System.Drawing.Point(7, 70)
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
        Me.ucrReceiverAltMeta.frmParent = Nothing
        Me.ucrReceiverAltMeta.Location = New System.Drawing.Point(7, 147)
        Me.ucrReceiverAltMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltMeta.Name = "ucrReceiverAltMeta"
        Me.ucrReceiverAltMeta.Selector = Nothing
        Me.ucrReceiverAltMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverAltMeta.strNcFilePath = ""
        Me.ucrReceiverAltMeta.TabIndex = 11
        Me.ucrReceiverAltMeta.ucrSelector = Nothing
        '
        'DlgDefineClimaticData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(518, 499)
        Me.Controls.Add(Me.ucrChkLinkedMetaData)
        Me.Controls.Add(Me.ucrSelectorLinkedDataFrame)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUnique)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorDefineClimaticData)
        Me.Controls.Add(Me.grpStation)
        Me.Controls.Add(Me.grpDateTime)
        Me.Controls.Add(Me.grpMeta)
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
        Me.grpMeta.ResumeLayout(False)
        Me.grpMeta.PerformLayout()
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
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents grpDateTime As GroupBox
    Friend WithEvents ucrInputCheckInput As ucrInputTextBox
    Friend WithEvents cmdCheckUnique As Button
    Friend WithEvents ucrReceiverMinRH As ucrReceiverSingle
    Friend WithEvents lblMinimumRH As Label
    Friend WithEvents ucrReceiverMaxRH As ucrReceiverSingle
    Friend WithEvents lblMaxRH As Label
    Friend WithEvents ucrSelectorLinkedDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkLinkedMetaData As ucrCheck
    Friend WithEvents grpStation As GroupBox
    Friend WithEvents grpMeta As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ucrReceiverStationMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverLonMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverAltMeta As ucrReceiverSingle
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblAltitude As Label
    Friend WithEvents lblStationName As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverAltitude As ucrReceiverSingle
End Class
