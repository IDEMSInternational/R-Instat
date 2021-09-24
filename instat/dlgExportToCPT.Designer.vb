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
        resources.ApplyResources(Me.lblSaveDataTo, "lblSaveDataTo")
        Me.lblSaveDataTo.Name = "lblSaveDataTo"
        '
        'cmdChooseFile
        '
        resources.ApplyResources(Me.cmdChooseFile, "cmdChooseFile")
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
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
        'lblStationTwoDF
        '
        resources.ApplyResources(Me.lblStationTwoDF, "lblStationTwoDF")
        Me.lblStationTwoDF.Name = "lblStationTwoDF"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblStationOneDF
        '
        resources.ApplyResources(Me.lblStationOneDF, "lblStationOneDF")
        Me.lblStationOneDF.Name = "lblStationOneDF"
        '
        'lblMultStations
        '
        resources.ApplyResources(Me.lblMultStations, "lblMultStations")
        Me.lblMultStations.Name = "lblMultStations"
        '
        'rdoOneDF
        '
        resources.ApplyResources(Me.rdoOneDF, "rdoOneDF")
        Me.rdoOneDF.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOneDF.FlatAppearance.BorderSize = 2
        Me.rdoOneDF.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOneDF.Name = "rdoOneDF"
        Me.rdoOneDF.TabStop = True
        Me.rdoOneDF.UseVisualStyleBackColor = True
        '
        'rdoTwoDFLong
        '
        resources.ApplyResources(Me.rdoTwoDFLong, "rdoTwoDFLong")
        Me.rdoTwoDFLong.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDFLong.FlatAppearance.BorderSize = 2
        Me.rdoTwoDFLong.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDFLong.Name = "rdoTwoDFLong"
        Me.rdoTwoDFLong.TabStop = True
        Me.rdoTwoDFLong.UseVisualStyleBackColor = True
        '
        'rdoTwoDFWide
        '
        resources.ApplyResources(Me.rdoTwoDFWide, "rdoTwoDFWide")
        Me.rdoTwoDFWide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDFWide.FlatAppearance.BorderSize = 2
        Me.rdoTwoDFWide.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoDFWide.Name = "rdoTwoDFWide"
        Me.rdoTwoDFWide.TabStop = True
        Me.rdoTwoDFWide.UseVisualStyleBackColor = True
        '
        'lblLine
        '
        resources.ApplyResources(Me.lblLine, "lblLine")
        Me.lblLine.Name = "lblLine"
        '
        'lblSaveFile
        '
        resources.ApplyResources(Me.lblSaveFile, "lblSaveFile")
        Me.lblSaveFile.Name = "lblSaveFile"
        '
        'lblMissingValues
        '
        resources.ApplyResources(Me.lblMissingValues, "lblMissingValues")
        Me.lblMissingValues.Name = "lblMissingValues"
        '
        'ucrInputCodeMissingValues
        '
        Me.ucrInputCodeMissingValues.AddQuotesIfUnrecognised = True
        Me.ucrInputCodeMissingValues.IsMultiline = False
        Me.ucrInputCodeMissingValues.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCodeMissingValues, "ucrInputCodeMissingValues")
        Me.ucrInputCodeMissingValues.Name = "ucrInputCodeMissingValues"
        '
        'ucrReceiverMultipleStation
        '
        Me.ucrReceiverMultipleStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleStation, "ucrReceiverMultipleStation")
        Me.ucrReceiverMultipleStation.Name = "ucrReceiverMultipleStation"
        Me.ucrReceiverMultipleStation.Selector = Nothing
        Me.ucrReceiverMultipleStation.strNcFilePath = ""
        Me.ucrReceiverMultipleStation.ucrSelector = Nothing
        '
        'ucrSelectorTwoDF
        '
        Me.ucrSelectorTwoDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorTwoDF.bShowHiddenColumns = False
        Me.ucrSelectorTwoDF.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTwoDF, "ucrSelectorTwoDF")
        Me.ucrSelectorTwoDF.Name = "ucrSelectorTwoDF"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverStationTwoDF
        '
        Me.ucrReceiverStationTwoDF.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStationTwoDF, "ucrReceiverStationTwoDF")
        Me.ucrReceiverStationTwoDF.Name = "ucrReceiverStationTwoDF"
        Me.ucrReceiverStationTwoDF.Selector = Nothing
        Me.ucrReceiverStationTwoDF.strNcFilePath = ""
        Me.ucrReceiverStationTwoDF.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLongitude, "ucrReceiverLongitude")
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilePath, "ucrInputFilePath")
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLatitude, "ucrReceiverLatitude")
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverStationOneDF
        '
        Me.ucrReceiverStationOneDF.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStationOneDF, "ucrReceiverStationOneDF")
        Me.ucrReceiverStationOneDF.Name = "ucrReceiverStationOneDF"
        Me.ucrReceiverStationOneDF.Selector = Nothing
        Me.ucrReceiverStationOneDF.strNcFilePath = ""
        Me.ucrReceiverStationOneDF.ucrSelector = Nothing
        '
        'ucrPnlNoOfDF
        '
        resources.ApplyResources(Me.ucrPnlNoOfDF, "ucrPnlNoOfDF")
        Me.ucrPnlNoOfDF.Name = "ucrPnlNoOfDF"
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
        'ucrSelectorOneDF
        '
        Me.ucrSelectorOneDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneDF.bShowHiddenColumns = False
        Me.ucrSelectorOneDF.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorOneDF, "ucrSelectorOneDF")
        Me.ucrSelectorOneDF.Name = "ucrSelectorOneDF"
        '
        'dlgExportToCPT
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Export_To_CPT"
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