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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExportToCPT))
        Me.rdoTwoDF = New System.Windows.Forms.RadioButton()
        Me.rdoOneDF = New System.Windows.Forms.RadioButton()
        Me.lblStationElement = New System.Windows.Forms.Label()
        Me.lblStationOneDF = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblStationLatLon = New System.Windows.Forms.Label()
        Me.ucrSectorTwoDF = New instat.ucrDataFrame()
        Me.UcrSaveExportFile = New instat.ucrSave()
        Me.ucrReceiverStationElementData = New instat.ucrReceiverSingle()
        Me.UcrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.UcrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrPnlNoOfDF = New instat.UcrPanel()
        Me.ucrChkLongData = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverStationLatLon = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrSelectorExporCPT = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'rdoTwoDF
        '
        resources.ApplyResources(Me.rdoTwoDF, "rdoTwoDF")
        Me.rdoTwoDF.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDF.FlatAppearance.BorderSize = 2
        Me.rdoTwoDF.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDF.Name = "rdoTwoDF"
        Me.rdoTwoDF.UseVisualStyleBackColor = True
        '
        'rdoOneDF
        '
        resources.ApplyResources(Me.rdoOneDF, "rdoOneDF")
        Me.rdoOneDF.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOneDF.FlatAppearance.BorderSize = 2
        Me.rdoOneDF.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOneDF.Name = "rdoOneDF"
        Me.rdoOneDF.UseVisualStyleBackColor = True
        '
        'lblStationElement
        '
        resources.ApplyResources(Me.lblStationElement, "lblStationElement")
        Me.lblStationElement.Name = "lblStationElement"
        '
        'lblStationOneDF
        '
        resources.ApplyResources(Me.lblStationOneDF, "lblStationOneDF")
        Me.lblStationOneDF.Name = "lblStationOneDF"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblLatitude
        '
        resources.ApplyResources(Me.lblLatitude, "lblLatitude")
        Me.lblLatitude.Name = "lblLatitude"
        '
        'lblLongitude
        '
        resources.ApplyResources(Me.lblLongitude, "lblLongitude")
        Me.lblLongitude.Name = "lblLongitude"
        '
        'lblStationLatLon
        '
        resources.ApplyResources(Me.lblStationLatLon, "lblStationLatLon")
        Me.lblStationLatLon.Name = "lblStationLatLon"
        '
        'ucrSectorTwoDF
        '
        Me.ucrSectorTwoDF.bDropUnusedFilterLevels = False
        Me.ucrSectorTwoDF.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSectorTwoDF, "ucrSectorTwoDF")
        Me.ucrSectorTwoDF.Name = "ucrSectorTwoDF"
        '
        'UcrSaveExportFile
        '
        resources.ApplyResources(Me.UcrSaveExportFile, "UcrSaveExportFile")
        Me.UcrSaveExportFile.Name = "UcrSaveExportFile"
        '
        'ucrReceiverStationElementData
        '
        Me.ucrReceiverStationElementData.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStationElementData, "ucrReceiverStationElementData")
        Me.ucrReceiverStationElementData.Name = "ucrReceiverStationElementData"
        Me.ucrReceiverStationElementData.Selector = Nothing
        Me.ucrReceiverStationElementData.strNcFilePath = ""
        Me.ucrReceiverStationElementData.ucrSelector = Nothing
        '
        'UcrReceiverLongitude
        '
        Me.UcrReceiverLongitude.frmParent = Me
        resources.ApplyResources(Me.UcrReceiverLongitude, "UcrReceiverLongitude")
        Me.UcrReceiverLongitude.Name = "UcrReceiverLongitude"
        Me.UcrReceiverLongitude.Selector = Nothing
        Me.UcrReceiverLongitude.strNcFilePath = ""
        Me.UcrReceiverLongitude.ucrSelector = Nothing
        '
        'UcrReceiverLatitude
        '
        Me.UcrReceiverLatitude.frmParent = Me
        resources.ApplyResources(Me.UcrReceiverLatitude, "UcrReceiverLatitude")
        Me.UcrReceiverLatitude.Name = "UcrReceiverLatitude"
        Me.UcrReceiverLatitude.Selector = Nothing
        Me.UcrReceiverLatitude.strNcFilePath = ""
        Me.UcrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrPnlNoOfDF
        '
        resources.ApplyResources(Me.ucrPnlNoOfDF, "ucrPnlNoOfDF")
        Me.ucrPnlNoOfDF.Name = "ucrPnlNoOfDF"
        '
        'ucrChkLongData
        '
        Me.ucrChkLongData.Checked = False
        resources.ApplyResources(Me.ucrChkLongData, "ucrChkLongData")
        Me.ucrChkLongData.Name = "ucrChkLongData"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverStationLatLon
        '
        Me.ucrReceiverStationLatLon.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStationLatLon, "ucrReceiverStationLatLon")
        Me.ucrReceiverStationLatLon.Name = "ucrReceiverStationLatLon"
        Me.ucrReceiverStationLatLon.Selector = Nothing
        Me.ucrReceiverStationLatLon.strNcFilePath = ""
        Me.ucrReceiverStationLatLon.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement, "ucrReceiverElement")
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrSelectorExporCPT
        '
        Me.ucrSelectorExporCPT.bDropUnusedFilterLevels = False
        Me.ucrSelectorExporCPT.bShowHiddenColumns = False
        Me.ucrSelectorExporCPT.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorExporCPT, "ucrSelectorExporCPT")
        Me.ucrSelectorExporCPT.Name = "ucrSelectorExporCPT"
        '
        'dlgExportToCPT
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblStationLatLon)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblStationOneDF)
        Me.Controls.Add(Me.lblStationElement)
        Me.Controls.Add(Me.rdoOneDF)
        Me.Controls.Add(Me.rdoTwoDF)
        Me.Controls.Add(Me.ucrSectorTwoDF)
        Me.Controls.Add(Me.UcrSaveExportFile)
        Me.Controls.Add(Me.ucrReceiverStationElementData)
        Me.Controls.Add(Me.UcrReceiverLongitude)
        Me.Controls.Add(Me.UcrReceiverLatitude)
        Me.Controls.Add(Me.ucrPnlNoOfDF)
        Me.Controls.Add(Me.ucrChkLongData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverStationLatLon)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrSelectorExporCPT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToCPT"
        Me.Tag = "Export_To_CPT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorExporCPT As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationLatLon As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkLongData As ucrCheck
    Friend WithEvents ucrPnlNoOfDF As UcrPanel
    Friend WithEvents UcrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationElementData As ucrReceiverSingle
    Friend WithEvents UcrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents UcrSaveExportFile As ucrSave
    Friend WithEvents ucrSectorTwoDF As ucrDataFrame
    Friend WithEvents lblYear As Label
    Friend WithEvents lblStationOneDF As Label
    Friend WithEvents lblStationElement As Label
    Friend WithEvents rdoOneDF As RadioButton
    Friend WithEvents rdoTwoDF As RadioButton
    Friend WithEvents lblElement As Label
    Friend WithEvents lblStationLatLon As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
End Class