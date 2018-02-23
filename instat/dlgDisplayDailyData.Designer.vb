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
Partial Class dlgDisplayDailyData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDisplayDailyData))
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayOfTheYear = New System.Windows.Forms.Label()
        Me.lblYaxisUpper = New System.Windows.Forms.Label()
        Me.grpGraph = New System.Windows.Forms.GroupBox()
        Me.lblRugColor = New System.Windows.Forms.Label()
        Me.lblBarColour = New System.Windows.Forms.Label()
        Me.lblMonStat = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputRugColour = New instat.ucrInputComboBox()
        Me.ucrInputBarColour = New instat.ucrInputComboBox()
        Me.ucrNudUpperYaxis = New instat.ucrNud()
        Me.ucrInputComboMonStat = New instat.ucrInputComboBox()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayOfYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStations = New instat.ucrReceiverSingle()
        Me.ucrPnlFrequencyDisplay = New instat.UcrPanel()
        Me.ucrSelectorDisplayDailyClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkTrace = New instat.ucrCheck()
        Me.ucrChkZero = New instat.ucrCheck()
        Me.ucrChkMissing = New instat.ucrCheck()
        Me.ucrInputComboTrace = New instat.ucrInputComboBox()
        Me.ucrInputComboMissing = New instat.ucrInputComboBox()
        Me.ucrInputComboZero = New instat.ucrInputComboBox()
        Me.grpGraph.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoTable
        '
        resources.ApplyResources(Me.rdoTable, "rdoTable")
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        resources.ApplyResources(Me.rdoGraph, "rdoGraph")
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblDayOfTheYear
        '
        resources.ApplyResources(Me.lblDayOfTheYear, "lblDayOfTheYear")
        Me.lblDayOfTheYear.Name = "lblDayOfTheYear"
        '
        'lblYaxisUpper
        '
        resources.ApplyResources(Me.lblYaxisUpper, "lblYaxisUpper")
        Me.lblYaxisUpper.Name = "lblYaxisUpper"
        '
        'grpGraph
        '
        Me.grpGraph.Controls.Add(Me.ucrSaveGraph)
        Me.grpGraph.Controls.Add(Me.ucrInputRugColour)
        Me.grpGraph.Controls.Add(Me.lblRugColor)
        Me.grpGraph.Controls.Add(Me.ucrInputBarColour)
        Me.grpGraph.Controls.Add(Me.lblBarColour)
        Me.grpGraph.Controls.Add(Me.ucrNudUpperYaxis)
        Me.grpGraph.Controls.Add(Me.lblYaxisUpper)
        resources.ApplyResources(Me.grpGraph, "grpGraph")
        Me.grpGraph.Name = "grpGraph"
        Me.grpGraph.TabStop = False
        '
        'lblRugColor
        '
        resources.ApplyResources(Me.lblRugColor, "lblRugColor")
        Me.lblRugColor.Name = "lblRugColor"
        '
        'lblBarColour
        '
        resources.ApplyResources(Me.lblBarColour, "lblBarColour")
        Me.lblBarColour.Name = "lblBarColour"
        '
        'lblMonStat
        '
        resources.ApplyResources(Me.lblMonStat, "lblMonStat")
        Me.lblMonStat.Name = "lblMonStat"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrInputRugColour
        '
        Me.ucrInputRugColour.AddQuotesIfUnrecognised = True
        Me.ucrInputRugColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRugColour, "ucrInputRugColour")
        Me.ucrInputRugColour.Name = "ucrInputRugColour"
        '
        'ucrInputBarColour
        '
        Me.ucrInputBarColour.AddQuotesIfUnrecognised = True
        Me.ucrInputBarColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBarColour, "ucrInputBarColour")
        Me.ucrInputBarColour.Name = "ucrInputBarColour"
        '
        'ucrNudUpperYaxis
        '
        Me.ucrNudUpperYaxis.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudUpperYaxis, "ucrNudUpperYaxis")
        Me.ucrNudUpperYaxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperYaxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Name = "ucrNudUpperYaxis"
        Me.ucrNudUpperYaxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputComboMonStat
        '
        Me.ucrInputComboMonStat.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMonStat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMonStat, "ucrInputComboMonStat")
        Me.ucrInputComboMonStat.Name = "ucrInputComboMonStat"
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElements, "ucrReceiverElements")
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.ucrSelector = Nothing
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
        'ucrReceiverDayOfYear
        '
        Me.ucrReceiverDayOfYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDayOfYear, "ucrReceiverDayOfYear")
        Me.ucrReceiverDayOfYear.Name = "ucrReceiverDayOfYear"
        Me.ucrReceiverDayOfYear.Selector = Nothing
        Me.ucrReceiverDayOfYear.strNcFilePath = ""
        Me.ucrReceiverDayOfYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStations, "ucrReceiverStations")
        Me.ucrReceiverStations.Name = "ucrReceiverStations"
        Me.ucrReceiverStations.Selector = Nothing
        Me.ucrReceiverStations.strNcFilePath = ""
        Me.ucrReceiverStations.ucrSelector = Nothing
        '
        'ucrPnlFrequencyDisplay
        '
        resources.ApplyResources(Me.ucrPnlFrequencyDisplay, "ucrPnlFrequencyDisplay")
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        '
        'ucrSelectorDisplayDailyClimaticData
        '
        Me.ucrSelectorDisplayDailyClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDisplayDailyClimaticData.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDisplayDailyClimaticData, "ucrSelectorDisplayDailyClimaticData")
        Me.ucrSelectorDisplayDailyClimaticData.Name = "ucrSelectorDisplayDailyClimaticData"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrChkTrace
        '
        Me.ucrChkTrace.Checked = False
        resources.ApplyResources(Me.ucrChkTrace, "ucrChkTrace")
        Me.ucrChkTrace.Name = "ucrChkTrace"
        '
        'ucrChkZero
        '
        Me.ucrChkZero.Checked = False
        resources.ApplyResources(Me.ucrChkZero, "ucrChkZero")
        Me.ucrChkZero.Name = "ucrChkZero"
        '
        'ucrChkMissing
        '
        Me.ucrChkMissing.Checked = False
        resources.ApplyResources(Me.ucrChkMissing, "ucrChkMissing")
        Me.ucrChkMissing.Name = "ucrChkMissing"
        '
        'ucrInputComboTrace
        '
        Me.ucrInputComboTrace.AddQuotesIfUnrecognised = True
        Me.ucrInputComboTrace.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboTrace, "ucrInputComboTrace")
        Me.ucrInputComboTrace.Name = "ucrInputComboTrace"
        '
        'ucrInputComboMissing
        '
        Me.ucrInputComboMissing.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMissing.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMissing, "ucrInputComboMissing")
        Me.ucrInputComboMissing.Name = "ucrInputComboMissing"
        '
        'ucrInputComboZero
        '
        Me.ucrInputComboZero.AddQuotesIfUnrecognised = True
        Me.ucrInputComboZero.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboZero, "ucrInputComboZero")
        Me.ucrInputComboZero.Name = "ucrInputComboZero"
        '
        'dlgDisplayDailyData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpGraph)
        Me.Controls.Add(Me.ucrInputComboZero)
        Me.Controls.Add(Me.ucrInputComboMissing)
        Me.Controls.Add(Me.ucrInputComboTrace)
        Me.Controls.Add(Me.ucrChkMissing)
        Me.Controls.Add(Me.ucrChkZero)
        Me.Controls.Add(Me.ucrChkTrace)
        Me.Controls.Add(Me.lblMonStat)
        Me.Controls.Add(Me.ucrInputComboMonStat)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDayOfTheYear)
        Me.Controls.Add(Me.ucrReceiverDayOfYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStations)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrPnlFrequencyDisplay)
        Me.Controls.Add(Me.ucrSelectorDisplayDailyClimaticData)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDailyData"
        Me.grpGraph.ResumeLayout(False)
        Me.grpGraph.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDisplayDailyClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents ucrPnlFrequencyDisplay As UcrPanel
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStations As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents lblYaxisUpper As Label
    Friend WithEvents ucrReceiverDayOfYear As ucrReceiverSingle
    Friend WithEvents lblDayOfTheYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents grpGraph As GroupBox
    Friend WithEvents ucrNudUpperYaxis As ucrNud
    Friend WithEvents ucrInputRugColour As ucrInputComboBox
    Friend WithEvents lblRugColor As Label
    Friend WithEvents ucrInputBarColour As ucrInputComboBox
    Friend WithEvents lblBarColour As Label
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents lblMonStat As Label
    Friend WithEvents ucrInputComboMonStat As ucrInputComboBox
    Friend WithEvents ucrChkTrace As ucrCheck
    Friend WithEvents ucrChkMissing As ucrCheck
    Friend WithEvents ucrChkZero As ucrCheck
    Friend WithEvents ucrInputComboZero As ucrInputComboBox
    Friend WithEvents ucrInputComboMissing As ucrInputComboBox
    Friend WithEvents ucrInputComboTrace As ucrInputComboBox
End Class