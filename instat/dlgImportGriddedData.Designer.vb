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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgImportGriddedData))
        Me.lblMinLat = New System.Windows.Forms.Label()
        Me.lblMaxLat = New System.Windows.Forms.Label()
        Me.lblMinLon = New System.Windows.Forms.Label()
        Me.lblMaxLon = New System.Windows.Forms.Label()
        Me.lblMainDataName = New System.Windows.Forms.Label()
        Me.lblDownloadFrom = New System.Windows.Forms.Label()
        Me.lblDataFile = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.lblLocationData = New System.Windows.Forms.Label()
        Me.grpGetArea = New System.Windows.Forms.GroupBox()
        Me.rdoPoint = New System.Windows.Forms.RadioButton()
        Me.rdoArea = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetArea = New instat.UcrPanel()
        Me.ucrInputLocDataName = New instat.ucrInputTextBox()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrInputDataFile = New instat.ucrInputComboBox()
        Me.ucrInputDownloadFrom = New instat.ucrInputComboBox()
        Me.ucrInputMainDataName = New instat.ucrInputTextBox()
        Me.ucrNudMaxLat = New instat.ucrNud()
        Me.ucrNudMaxLon = New instat.ucrNud()
        Me.ucrNudMinLon = New instat.ucrNud()
        Me.ucrNudMinLat = New instat.ucrNud()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpGetArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMinLat
        '
        resources.ApplyResources(Me.lblMinLat, "lblMinLat")
        Me.lblMinLat.Name = "lblMinLat"
        '
        'lblMaxLat
        '
        resources.ApplyResources(Me.lblMaxLat, "lblMaxLat")
        Me.lblMaxLat.Name = "lblMaxLat"
        '
        'lblMinLon
        '
        resources.ApplyResources(Me.lblMinLon, "lblMinLon")
        Me.lblMinLon.Name = "lblMinLon"
        '
        'lblMaxLon
        '
        resources.ApplyResources(Me.lblMaxLon, "lblMaxLon")
        Me.lblMaxLon.Name = "lblMaxLon"
        '
        'lblMainDataName
        '
        resources.ApplyResources(Me.lblMainDataName, "lblMainDataName")
        Me.lblMainDataName.Name = "lblMainDataName"
        '
        'lblDownloadFrom
        '
        resources.ApplyResources(Me.lblDownloadFrom, "lblDownloadFrom")
        Me.lblDownloadFrom.Name = "lblDownloadFrom"
        '
        'lblDataFile
        '
        resources.ApplyResources(Me.lblDataFile, "lblDataFile")
        Me.lblDataFile.Name = "lblDataFile"
        '
        'cmdBrowse
        '
        resources.ApplyResources(Me.cmdBrowse, "cmdBrowse")
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        resources.ApplyResources(Me.lblExport, "lblExport")
        Me.lblExport.Name = "lblExport"
        '
        'lblLocationData
        '
        resources.ApplyResources(Me.lblLocationData, "lblLocationData")
        Me.lblLocationData.Name = "lblLocationData"
        '
        'grpGetArea
        '
        Me.grpGetArea.Controls.Add(Me.rdoPoint)
        Me.grpGetArea.Controls.Add(Me.rdoArea)
        Me.grpGetArea.Controls.Add(Me.ucrPnlGetArea)
        resources.ApplyResources(Me.grpGetArea, "grpGetArea")
        Me.grpGetArea.Name = "grpGetArea"
        Me.grpGetArea.TabStop = False
        '
        'rdoPoint
        '
        resources.ApplyResources(Me.rdoPoint, "rdoPoint")
        Me.rdoPoint.Name = "rdoPoint"
        Me.rdoPoint.TabStop = True
        Me.rdoPoint.UseVisualStyleBackColor = True
        '
        'rdoArea
        '
        resources.ApplyResources(Me.rdoArea, "rdoArea")
        Me.rdoArea.Name = "rdoArea"
        Me.rdoArea.TabStop = True
        Me.rdoArea.UseVisualStyleBackColor = True
        '
        'ucrPnlGetArea
        '
        resources.ApplyResources(Me.ucrPnlGetArea, "ucrPnlGetArea")
        Me.ucrPnlGetArea.Name = "ucrPnlGetArea"
        '
        'ucrInputLocDataName
        '
        Me.ucrInputLocDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputLocDataName.IsMultiline = False
        Me.ucrInputLocDataName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLocDataName, "ucrInputLocDataName")
        Me.ucrInputLocDataName.Name = "ucrInputLocDataName"
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputExportFile, "ucrInputExportFile")
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        '
        'ucrInputDataFile
        '
        Me.ucrInputDataFile.AddQuotesIfUnrecognised = True
        Me.ucrInputDataFile.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDataFile, "ucrInputDataFile")
        Me.ucrInputDataFile.Name = "ucrInputDataFile"
        '
        'ucrInputDownloadFrom
        '
        Me.ucrInputDownloadFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputDownloadFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDownloadFrom, "ucrInputDownloadFrom")
        Me.ucrInputDownloadFrom.Name = "ucrInputDownloadFrom"
        '
        'ucrInputMainDataName
        '
        Me.ucrInputMainDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputMainDataName.IsMultiline = False
        Me.ucrInputMainDataName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMainDataName, "ucrInputMainDataName")
        Me.ucrInputMainDataName.Name = "ucrInputMainDataName"
        '
        'ucrNudMaxLat
        '
        Me.ucrNudMaxLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxLat, "ucrNudMaxLat")
        Me.ucrNudMaxLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Name = "ucrNudMaxLat"
        Me.ucrNudMaxLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxLon
        '
        Me.ucrNudMaxLon.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLon.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxLon, "ucrNudMaxLon")
        Me.ucrNudMaxLon.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLon.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLon.Name = "ucrNudMaxLon"
        Me.ucrNudMaxLon.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLon
        '
        Me.ucrNudMinLon.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLon.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMinLon, "ucrNudMinLon")
        Me.ucrNudMinLon.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLon.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLon.Name = "ucrNudMinLon"
        Me.ucrNudMinLon.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLat
        '
        Me.ucrNudMinLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMinLat, "ucrNudMinLat")
        Me.ucrNudMinLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Name = "ucrNudMinLat"
        Me.ucrNudMinLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgImportGriddedData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpGetArea)
        Me.Controls.Add(Me.ucrInputLocDataName)
        Me.Controls.Add(Me.lblLocationData)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.lblDataFile)
        Me.Controls.Add(Me.ucrInputDataFile)
        Me.Controls.Add(Me.lblDownloadFrom)
        Me.Controls.Add(Me.ucrInputDownloadFrom)
        Me.Controls.Add(Me.ucrInputMainDataName)
        Me.Controls.Add(Me.lblMainDataName)
        Me.Controls.Add(Me.lblMaxLon)
        Me.Controls.Add(Me.lblMinLon)
        Me.Controls.Add(Me.lblMaxLat)
        Me.Controls.Add(Me.lblMinLat)
        Me.Controls.Add(Me.ucrNudMaxLat)
        Me.Controls.Add(Me.ucrNudMaxLon)
        Me.Controls.Add(Me.ucrNudMinLon)
        Me.Controls.Add(Me.ucrNudMinLat)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportGriddedData"
        Me.grpGetArea.ResumeLayout(False)
        Me.grpGetArea.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrNudMinLat As ucrNud
    Friend WithEvents ucrNudMinLon As ucrNud
    Friend WithEvents ucrNudMaxLon As ucrNud
    Friend WithEvents ucrNudMaxLat As ucrNud
    Friend WithEvents lblMinLat As Label
    Friend WithEvents lblMaxLat As Label
    Friend WithEvents lblMinLon As Label
    Friend WithEvents lblMaxLon As Label
    Friend WithEvents lblMainDataName As Label
    Friend WithEvents ucrInputMainDataName As ucrInputTextBox
    Friend WithEvents ucrInputDownloadFrom As ucrInputComboBox
    Friend WithEvents lblDownloadFrom As Label
    Friend WithEvents ucrInputDataFile As ucrInputComboBox
    Friend WithEvents lblDataFile As Label
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblExport As Label
    Friend WithEvents ucrInputLocDataName As ucrInputTextBox
    Friend WithEvents lblLocationData As Label
    Friend WithEvents grpGetArea As GroupBox
    Friend WithEvents rdoPoint As RadioButton
    Friend WithEvents rdoArea As RadioButton
    Friend WithEvents ucrPnlGetArea As UcrPanel
End Class
