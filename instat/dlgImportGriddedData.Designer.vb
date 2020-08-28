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
        Me.grpGetArea = New System.Windows.Forms.GroupBox()
        Me.rdoPoint = New System.Windows.Forms.RadioButton()
        Me.rdoArea = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetArea = New instat.UcrPanel()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrInputDataFile = New instat.ucrInputComboBox()
        Me.ucrInputDownloadFrom = New instat.ucrInputComboBox()
        Me.ucrInputMainDataName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.UcrDateTimePicker1 = New instat.ucrDateTimePicker()
        Me.UcrDateTimePicker2 = New instat.ucrDateTimePicker()
        Me.grpDataRange = New System.Windows.Forms.GroupBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrInputMaxLon = New instat.ucrInputTextBox()
        Me.ucrInputMinLon = New instat.ucrInputTextBox()
        Me.ucrInputMaxLat = New instat.ucrInputTextBox()
        Me.ucrInputMinLat = New instat.ucrInputTextBox()
        Me.ucrChkTempLocation = New instat.ucrCheck()
        Me.ucrChkDontImportData = New instat.ucrCheck()
        Me.grpGetArea.SuspendLayout()
        Me.grpDataRange.SuspendLayout()
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
        Me.ucrInputDataFile.GetSetSelectedIndex = -1
        Me.ucrInputDataFile.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDataFile, "ucrInputDataFile")
        Me.ucrInputDataFile.Name = "ucrInputDataFile"
        '
        'ucrInputDownloadFrom
        '
        Me.ucrInputDownloadFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputDownloadFrom.GetSetSelectedIndex = -1
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
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'UcrDateTimePicker1
        '
        resources.ApplyResources(Me.UcrDateTimePicker1, "UcrDateTimePicker1")
        Me.UcrDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.UcrDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UcrDateTimePicker1.Name = "UcrDateTimePicker1"
        '
        'UcrDateTimePicker2
        '
        resources.ApplyResources(Me.UcrDateTimePicker2, "UcrDateTimePicker2")
        Me.UcrDateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.UcrDateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UcrDateTimePicker2.Name = "UcrDateTimePicker2"
        '
        'grpDataRange
        '
        Me.grpDataRange.Controls.Add(Me.lblTo)
        Me.grpDataRange.Controls.Add(Me.lblFrom)
        Me.grpDataRange.Controls.Add(Me.UcrDateTimePicker1)
        Me.grpDataRange.Controls.Add(Me.UcrDateTimePicker2)
        resources.ApplyResources(Me.grpDataRange, "grpDataRange")
        Me.grpDataRange.Name = "grpDataRange"
        Me.grpDataRange.TabStop = False
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'ucrInputMaxLon
        '
        Me.ucrInputMaxLon.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLon.IsMultiline = False
        Me.ucrInputMaxLon.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLon, "ucrInputMaxLon")
        Me.ucrInputMaxLon.Name = "ucrInputMaxLon"
        '
        'ucrInputMinLon
        '
        Me.ucrInputMinLon.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLon.IsMultiline = False
        Me.ucrInputMinLon.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLon, "ucrInputMinLon")
        Me.ucrInputMinLon.Name = "ucrInputMinLon"
        '
        'ucrInputMaxLat
        '
        Me.ucrInputMaxLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLat.IsMultiline = False
        Me.ucrInputMaxLat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLat, "ucrInputMaxLat")
        Me.ucrInputMaxLat.Name = "ucrInputMaxLat"
        '
        'ucrInputMinLat
        '
        Me.ucrInputMinLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLat.IsMultiline = False
        Me.ucrInputMinLat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLat, "ucrInputMinLat")
        Me.ucrInputMinLat.Name = "ucrInputMinLat"
        '
        'ucrChkTempLocation
        '
        Me.ucrChkTempLocation.Checked = False
        resources.ApplyResources(Me.ucrChkTempLocation, "ucrChkTempLocation")
        Me.ucrChkTempLocation.Name = "ucrChkTempLocation"
        '
        'ucrChkDontImportData
        '
        Me.ucrChkDontImportData.Checked = False
        resources.ApplyResources(Me.ucrChkDontImportData, "ucrChkDontImportData")
        Me.ucrChkDontImportData.Name = "ucrChkDontImportData"
        '
        'dlgImportGriddedData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkDontImportData)
        Me.Controls.Add(Me.ucrChkTempLocation)
        Me.Controls.Add(Me.ucrInputMinLat)
        Me.Controls.Add(Me.ucrInputMaxLat)
        Me.Controls.Add(Me.ucrInputMinLon)
        Me.Controls.Add(Me.ucrInputMaxLon)
        Me.Controls.Add(Me.grpDataRange)
        Me.Controls.Add(Me.grpGetArea)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.cmdBrowse)
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
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportGriddedData"
        Me.grpGetArea.ResumeLayout(False)
        Me.grpGetArea.PerformLayout()
        Me.grpDataRange.ResumeLayout(False)
        Me.grpDataRange.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
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
    Friend WithEvents grpGetArea As GroupBox
    Friend WithEvents rdoPoint As RadioButton
    Friend WithEvents rdoArea As RadioButton
    Friend WithEvents ucrPnlGetArea As UcrPanel
    Friend WithEvents UcrDateTimePicker1 As ucrDateTimePicker
    Friend WithEvents UcrDateTimePicker2 As ucrDateTimePicker
    Friend WithEvents grpDataRange As GroupBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrInputMaxLon As ucrInputTextBox
    Friend WithEvents ucrInputMinLon As ucrInputTextBox
    Friend WithEvents ucrInputMaxLat As ucrInputTextBox
    Friend WithEvents ucrInputMinLat As ucrInputTextBox
    Friend WithEvents ucrChkTempLocation As ucrCheck
    Friend WithEvents ucrChkDontImportData As ucrCheck
End Class
