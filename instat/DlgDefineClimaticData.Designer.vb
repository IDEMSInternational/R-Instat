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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DlgDefineClimaticData))
        Me.grpElements = New System.Windows.Forms.GroupBox()
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
        Me.cmdCheckUnique = New System.Windows.Forms.Button()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.ucrReceiverStationName = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
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
        resources.ApplyResources(Me.grpElements, "grpElements")
        Me.grpElements.Name = "grpElements"
        Me.grpElements.TabStop = False
        '
        'lblRain
        '
        resources.ApplyResources(Me.lblRain, "lblRain")
        Me.lblRain.Name = "lblRain"
        '
        'lblMaxTemp
        '
        resources.ApplyResources(Me.lblMaxTemp, "lblMaxTemp")
        Me.lblMaxTemp.Name = "lblMaxTemp"
        '
        'lblCloudCover
        '
        resources.ApplyResources(Me.lblCloudCover, "lblCloudCover")
        Me.lblCloudCover.Name = "lblCloudCover"
        '
        'lblMinTemp
        '
        resources.ApplyResources(Me.lblMinTemp, "lblMinTemp")
        Me.lblMinTemp.Name = "lblMinTemp"
        '
        'lblRadiation
        '
        resources.ApplyResources(Me.lblRadiation, "lblRadiation")
        Me.lblRadiation.Name = "lblRadiation"
        '
        'lblSunshine
        '
        resources.ApplyResources(Me.lblSunshine, "lblSunshine")
        Me.lblSunshine.Name = "lblSunshine"
        '
        'lblWindSpeed
        '
        resources.ApplyResources(Me.lblWindSpeed, "lblWindSpeed")
        Me.lblWindSpeed.Name = "lblWindSpeed"
        '
        'lblWindDirection
        '
        resources.ApplyResources(Me.lblWindDirection, "lblWindDirection")
        Me.lblWindDirection.Name = "lblWindDirection"
        '
        'lblStationName
        '
        resources.ApplyResources(Me.lblStationName, "lblStationName")
        Me.lblStationName.Name = "lblStationName"
        '
        'lblDOY
        '
        resources.ApplyResources(Me.lblDOY, "lblDOY")
        Me.lblDOY.Name = "lblDOY"
        '
        'lblDay
        '
        resources.ApplyResources(Me.lblDay, "lblDay")
        Me.lblDay.Name = "lblDay"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
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
        resources.ApplyResources(Me.grpDateTime, "grpDateTime")
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Tag = ""
        '
        'grpStation
        '
        Me.grpStation.Controls.Add(Me.lblStationName)
        Me.grpStation.Controls.Add(Me.ucrReceiverStationName)
        resources.ApplyResources(Me.grpStation, "grpStation")
        Me.grpStation.Name = "grpStation"
        Me.grpStation.TabStop = False
        Me.grpStation.Tag = ""
        '
        'cmdCheckUnique
        '
        resources.ApplyResources(Me.cmdCheckUnique, "cmdCheckUnique")
        Me.cmdCheckUnique.Name = "cmdCheckUnique"
        Me.cmdCheckUnique.UseVisualStyleBackColor = True
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInput.IsMultiline = False
        Me.ucrInputCheckInput.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCheckInput, "ucrInputCheckInput")
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        '
        'ucrReceiverStationName
        '
        Me.ucrReceiverStationName.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverStationName, "ucrReceiverStationName")
        Me.ucrReceiverStationName.Name = "ucrReceiverStationName"
        Me.ucrReceiverStationName.Selector = Nothing
        Me.ucrReceiverStationName.strNcFilePath = ""
        Me.ucrReceiverStationName.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverDOY, "ucrReceiverDOY")
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverDay, "ucrReceiverDay")
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverWindDirection, "ucrReceiverWindDirection")
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverRain, "ucrReceiverRain")
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverSunshine
        '
        Me.ucrReceiverSunshine.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverSunshine, "ucrReceiverSunshine")
        Me.ucrReceiverSunshine.Name = "ucrReceiverSunshine"
        Me.ucrReceiverSunshine.Selector = Nothing
        Me.ucrReceiverSunshine.strNcFilePath = ""
        Me.ucrReceiverSunshine.ucrSelector = Nothing
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverRadiation, "ucrReceiverRadiation")
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.strNcFilePath = ""
        Me.ucrReceiverRadiation.ucrSelector = Nothing
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverMaxTemp, "ucrReceiverMaxTemp")
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.strNcFilePath = ""
        Me.ucrReceiverMaxTemp.ucrSelector = Nothing
        '
        'ucrReceiverCloudCover
        '
        Me.ucrReceiverCloudCover.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverCloudCover, "ucrReceiverCloudCover")
        Me.ucrReceiverCloudCover.Name = "ucrReceiverCloudCover"
        Me.ucrReceiverCloudCover.Selector = Nothing
        Me.ucrReceiverCloudCover.strNcFilePath = ""
        Me.ucrReceiverCloudCover.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverWindSpeed, "ucrReceiverWindSpeed")
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverMinTemp, "ucrReceiverMinTemp")
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.strNcFilePath = ""
        Me.ucrReceiverMinTemp.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorDefineClimaticData
        '
        Me.ucrSelectorDefineClimaticData.bDropUnusedFilterLevels = False
        Me.ucrSelectorDefineClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDefineClimaticData.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDefineClimaticData, "ucrSelectorDefineClimaticData")
        Me.ucrSelectorDefineClimaticData.Name = "ucrSelectorDefineClimaticData"
        '
        'DlgDefineClimaticData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.grpElements.ResumeLayout(False)
        Me.grpElements.PerformLayout()
        Me.grpDateTime.ResumeLayout(False)
        Me.grpDateTime.PerformLayout()
        Me.grpStation.ResumeLayout(False)
        Me.grpStation.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
