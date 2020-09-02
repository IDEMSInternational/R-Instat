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
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.grpDownloadType = New System.Windows.Forms.GroupBox()
        Me.rdoPoint = New System.Windows.Forms.RadioButton()
        Me.rdoArea = New System.Windows.Forms.RadioButton()
        Me.grpDataRange = New System.Windows.Forms.GroupBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrChkDontImportData = New instat.ucrCheck()
        Me.ucrChkSaveFileLocation = New instat.ucrCheck()
        Me.ucrInputMinLat = New instat.ucrInputTextBox()
        Me.ucrInputMaxLat = New instat.ucrInputTextBox()
        Me.ucrInputMinLon = New instat.ucrInputTextBox()
        Me.ucrInputMaxLon = New instat.ucrInputTextBox()
        Me.ucrChkWholeRange = New instat.ucrCheck()
        Me.ucrDtpMinDate = New instat.ucrDateTimePicker()
        Me.ucrDtpMaxDate = New instat.ucrDateTimePicker()
        Me.ucrPnlDownloadType = New instat.UcrPanel()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputData = New instat.ucrInputComboBox()
        Me.ucrInputSource = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDownloadType.SuspendLayout()
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
        'lblNewDataFrameName
        '
        resources.ApplyResources(Me.lblNewDataFrameName, "lblNewDataFrameName")
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        '
        'lblSource
        '
        resources.ApplyResources(Me.lblSource, "lblSource")
        Me.lblSource.Name = "lblSource"
        '
        'lblData
        '
        resources.ApplyResources(Me.lblData, "lblData")
        Me.lblData.Name = "lblData"
        '
        'cmdBrowse
        '
        resources.ApplyResources(Me.cmdBrowse, "cmdBrowse")
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'grpDownloadType
        '
        Me.grpDownloadType.Controls.Add(Me.rdoPoint)
        Me.grpDownloadType.Controls.Add(Me.rdoArea)
        Me.grpDownloadType.Controls.Add(Me.ucrPnlDownloadType)
        resources.ApplyResources(Me.grpDownloadType, "grpDownloadType")
        Me.grpDownloadType.Name = "grpDownloadType"
        Me.grpDownloadType.TabStop = False
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
        'grpDataRange
        '
        Me.grpDataRange.Controls.Add(Me.ucrChkWholeRange)
        Me.grpDataRange.Controls.Add(Me.lblTo)
        Me.grpDataRange.Controls.Add(Me.lblFrom)
        Me.grpDataRange.Controls.Add(Me.ucrDtpMinDate)
        Me.grpDataRange.Controls.Add(Me.ucrDtpMaxDate)
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
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.IsMultiline = False
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewDataFrameName, "ucrInputNewDataFrameName")
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        '
        'ucrChkDontImportData
        '
        Me.ucrChkDontImportData.Checked = False
        resources.ApplyResources(Me.ucrChkDontImportData, "ucrChkDontImportData")
        Me.ucrChkDontImportData.Name = "ucrChkDontImportData"
        '
        'ucrChkSaveFileLocation
        '
        Me.ucrChkSaveFileLocation.Checked = False
        resources.ApplyResources(Me.ucrChkSaveFileLocation, "ucrChkSaveFileLocation")
        Me.ucrChkSaveFileLocation.Name = "ucrChkSaveFileLocation"
        '
        'ucrInputMinLat
        '
        Me.ucrInputMinLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLat.IsMultiline = False
        Me.ucrInputMinLat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLat, "ucrInputMinLat")
        Me.ucrInputMinLat.Name = "ucrInputMinLat"
        '
        'ucrInputMaxLat
        '
        Me.ucrInputMaxLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLat.IsMultiline = False
        Me.ucrInputMaxLat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLat, "ucrInputMaxLat")
        Me.ucrInputMaxLat.Name = "ucrInputMaxLat"
        '
        'ucrInputMinLon
        '
        Me.ucrInputMinLon.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLon.IsMultiline = False
        Me.ucrInputMinLon.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLon, "ucrInputMinLon")
        Me.ucrInputMinLon.Name = "ucrInputMinLon"
        '
        'ucrInputMaxLon
        '
        Me.ucrInputMaxLon.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLon.IsMultiline = False
        Me.ucrInputMaxLon.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLon, "ucrInputMaxLon")
        Me.ucrInputMaxLon.Name = "ucrInputMaxLon"
        '
        'ucrChkWholeRange
        '
        Me.ucrChkWholeRange.Checked = False
        resources.ApplyResources(Me.ucrChkWholeRange, "ucrChkWholeRange")
        Me.ucrChkWholeRange.Name = "ucrChkWholeRange"
        '
        'ucrDtpMinDate
        '
        resources.ApplyResources(Me.ucrDtpMinDate, "ucrDtpMinDate")
        Me.ucrDtpMinDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpMinDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpMinDate.Name = "ucrDtpMinDate"
        '
        'ucrDtpMaxDate
        '
        resources.ApplyResources(Me.ucrDtpMaxDate, "ucrDtpMaxDate")
        Me.ucrDtpMaxDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpMaxDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpMaxDate.Name = "ucrDtpMaxDate"
        '
        'ucrPnlDownloadType
        '
        resources.ApplyResources(Me.ucrPnlDownloadType, "ucrPnlDownloadType")
        Me.ucrPnlDownloadType.Name = "ucrPnlDownloadType"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilePath, "ucrInputFilePath")
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        '
        'ucrInputData
        '
        Me.ucrInputData.AddQuotesIfUnrecognised = True
        Me.ucrInputData.GetSetSelectedIndex = -1
        Me.ucrInputData.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputData, "ucrInputData")
        Me.ucrInputData.Name = "ucrInputData"
        '
        'ucrInputSource
        '
        Me.ucrInputSource.AddQuotesIfUnrecognised = True
        Me.ucrInputSource.GetSetSelectedIndex = -1
        Me.ucrInputSource.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSource, "ucrInputSource")
        Me.ucrInputSource.Name = "ucrInputSource"
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
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.ucrChkDontImportData)
        Me.Controls.Add(Me.ucrChkSaveFileLocation)
        Me.Controls.Add(Me.ucrInputMinLat)
        Me.Controls.Add(Me.ucrInputMaxLat)
        Me.Controls.Add(Me.ucrInputMinLon)
        Me.Controls.Add(Me.ucrInputMaxLon)
        Me.Controls.Add(Me.grpDataRange)
        Me.Controls.Add(Me.grpDownloadType)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrInputData)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.ucrInputSource)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.lblMaxLon)
        Me.Controls.Add(Me.lblMinLon)
        Me.Controls.Add(Me.lblMaxLat)
        Me.Controls.Add(Me.lblMinLat)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportGriddedData"
        Me.grpDownloadType.ResumeLayout(False)
        Me.grpDownloadType.PerformLayout()
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
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrInputSource As ucrInputComboBox
    Friend WithEvents lblSource As Label
    Friend WithEvents ucrInputData As ucrInputComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents grpDownloadType As GroupBox
    Friend WithEvents rdoPoint As RadioButton
    Friend WithEvents rdoArea As RadioButton
    Friend WithEvents ucrPnlDownloadType As UcrPanel
    Friend WithEvents ucrDtpMinDate As ucrDateTimePicker
    Friend WithEvents ucrDtpMaxDate As ucrDateTimePicker
    Friend WithEvents grpDataRange As GroupBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrInputMaxLon As ucrInputTextBox
    Friend WithEvents ucrInputMinLon As ucrInputTextBox
    Friend WithEvents ucrInputMaxLat As ucrInputTextBox
    Friend WithEvents ucrInputMinLat As ucrInputTextBox
    Friend WithEvents ucrChkSaveFileLocation As ucrCheck
    Friend WithEvents ucrChkDontImportData As ucrCheck
    Friend WithEvents ucrInputNewDataFrameName As ucrInputTextBox
    Friend WithEvents ucrChkWholeRange As ucrCheck
End Class
