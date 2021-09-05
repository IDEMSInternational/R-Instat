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
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblMaxLat = New System.Windows.Forms.Label()
        Me.lblLon = New System.Windows.Forms.Label()
        Me.lblMaxLon = New System.Windows.Forms.Label()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.grpDateRange = New System.Windows.Forms.GroupBox()
        Me.rdoCustomRange = New System.Windows.Forms.RadioButton()
        Me.rdoEntireRange = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrDtpMinDate = New instat.ucrDateTimePicker()
        Me.ucrDtpMaxDate = New instat.ucrDateTimePicker()
        Me.ucrPnlDateRange = New instat.UcrPanel()
        Me.grpLocationRange = New System.Windows.Forms.GroupBox()
        Me.rdoPoint = New System.Windows.Forms.RadioButton()
        Me.rdoArea = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLocationRange = New instat.UcrPanel()
        Me.lblMinLon = New System.Windows.Forms.Label()
        Me.lblMinLat = New System.Windows.Forms.Label()
        Me.ucrInputMinLon = New instat.ucrInputTextBox()
        Me.ucrInputMinLat = New instat.ucrInputTextBox()
        Me.ucrInputMaxLat = New instat.ucrInputTextBox()
        Me.ucrInputMaxLon = New instat.ucrInputTextBox()
        Me.lblSaveDownloadedFileTo = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrChkDontImportData = New instat.ucrCheck()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputData = New instat.ucrInputComboBox()
        Me.ucrInputSource = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDateRange.SuspendLayout()
        Me.grpLocationRange.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLat
        '
        resources.ApplyResources(Me.lblLat, "lblLat")
        Me.lblLat.Name = "lblLat"
        '
        'lblMaxLat
        '
        resources.ApplyResources(Me.lblMaxLat, "lblMaxLat")
        Me.lblMaxLat.Name = "lblMaxLat"
        '
        'lblLon
        '
        resources.ApplyResources(Me.lblLon, "lblLon")
        Me.lblLon.Name = "lblLon"
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
        'grpDateRange
        '
        Me.grpDateRange.Controls.Add(Me.rdoCustomRange)
        Me.grpDateRange.Controls.Add(Me.rdoEntireRange)
        Me.grpDateRange.Controls.Add(Me.lblTo)
        Me.grpDateRange.Controls.Add(Me.lblFrom)
        Me.grpDateRange.Controls.Add(Me.ucrDtpMinDate)
        Me.grpDateRange.Controls.Add(Me.ucrDtpMaxDate)
        Me.grpDateRange.Controls.Add(Me.ucrPnlDateRange)
        resources.ApplyResources(Me.grpDateRange, "grpDateRange")
        Me.grpDateRange.Name = "grpDateRange"
        Me.grpDateRange.TabStop = False
        '
        'rdoCustomRange
        '
        resources.ApplyResources(Me.rdoCustomRange, "rdoCustomRange")
        Me.rdoCustomRange.BackColor = System.Drawing.SystemColors.Control
        Me.rdoCustomRange.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCustomRange.FlatAppearance.BorderSize = 2
        Me.rdoCustomRange.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCustomRange.Name = "rdoCustomRange"
        Me.rdoCustomRange.TabStop = True
        Me.rdoCustomRange.Tag = ""
        Me.rdoCustomRange.UseVisualStyleBackColor = False
        '
        'rdoEntireRange
        '
        resources.ApplyResources(Me.rdoEntireRange, "rdoEntireRange")
        Me.rdoEntireRange.BackColor = System.Drawing.SystemColors.Control
        Me.rdoEntireRange.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEntireRange.FlatAppearance.BorderSize = 2
        Me.rdoEntireRange.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEntireRange.Name = "rdoEntireRange"
        Me.rdoEntireRange.TabStop = True
        Me.rdoEntireRange.Tag = ""
        Me.rdoEntireRange.UseVisualStyleBackColor = False
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
        'ucrDtpMinDate
        '
        Me.ucrDtpMinDate.DateValue = New Date(2021, 5, 18, 13, 18, 46, 901)
        Me.ucrDtpMinDate.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpMinDate, "ucrDtpMinDate")
        Me.ucrDtpMinDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpMinDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpMinDate.Name = "ucrDtpMinDate"
        '
        'ucrDtpMaxDate
        '
        Me.ucrDtpMaxDate.DateValue = New Date(2021, 5, 18, 13, 18, 46, 931)
        Me.ucrDtpMaxDate.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpMaxDate, "ucrDtpMaxDate")
        Me.ucrDtpMaxDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpMaxDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpMaxDate.Name = "ucrDtpMaxDate"
        '
        'ucrPnlDateRange
        '
        resources.ApplyResources(Me.ucrPnlDateRange, "ucrPnlDateRange")
        Me.ucrPnlDateRange.Name = "ucrPnlDateRange"
        '
        'grpLocationRange
        '
        Me.grpLocationRange.Controls.Add(Me.rdoPoint)
        Me.grpLocationRange.Controls.Add(Me.rdoArea)
        Me.grpLocationRange.Controls.Add(Me.ucrPnlLocationRange)
        Me.grpLocationRange.Controls.Add(Me.lblMinLon)
        Me.grpLocationRange.Controls.Add(Me.lblMinLat)
        Me.grpLocationRange.Controls.Add(Me.ucrInputMinLon)
        Me.grpLocationRange.Controls.Add(Me.ucrInputMinLat)
        Me.grpLocationRange.Controls.Add(Me.lblMaxLon)
        Me.grpLocationRange.Controls.Add(Me.lblMaxLat)
        Me.grpLocationRange.Controls.Add(Me.ucrInputMaxLat)
        Me.grpLocationRange.Controls.Add(Me.ucrInputMaxLon)
        Me.grpLocationRange.Controls.Add(Me.lblLon)
        Me.grpLocationRange.Controls.Add(Me.lblLat)
        resources.ApplyResources(Me.grpLocationRange, "grpLocationRange")
        Me.grpLocationRange.Name = "grpLocationRange"
        Me.grpLocationRange.TabStop = False
        '
        'rdoPoint
        '
        resources.ApplyResources(Me.rdoPoint, "rdoPoint")
        Me.rdoPoint.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPoint.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoint.FlatAppearance.BorderSize = 2
        Me.rdoPoint.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoint.Name = "rdoPoint"
        Me.rdoPoint.TabStop = True
        Me.rdoPoint.Tag = ""
        Me.rdoPoint.UseVisualStyleBackColor = False
        '
        'rdoArea
        '
        resources.ApplyResources(Me.rdoArea, "rdoArea")
        Me.rdoArea.BackColor = System.Drawing.SystemColors.Control
        Me.rdoArea.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoArea.FlatAppearance.BorderSize = 2
        Me.rdoArea.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoArea.Name = "rdoArea"
        Me.rdoArea.TabStop = True
        Me.rdoArea.Tag = ""
        Me.rdoArea.UseVisualStyleBackColor = False
        '
        'ucrPnlLocationRange
        '
        resources.ApplyResources(Me.ucrPnlLocationRange, "ucrPnlLocationRange")
        Me.ucrPnlLocationRange.Name = "ucrPnlLocationRange"
        '
        'lblMinLon
        '
        resources.ApplyResources(Me.lblMinLon, "lblMinLon")
        Me.lblMinLon.Name = "lblMinLon"
        '
        'lblMinLat
        '
        resources.ApplyResources(Me.lblMinLat, "lblMinLat")
        Me.lblMinLat.Name = "lblMinLat"
        '
        'ucrInputMinLon
        '
        Me.ucrInputMinLon.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLon.IsMultiline = False
        Me.ucrInputMinLon.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLon, "ucrInputMinLon")
        Me.ucrInputMinLon.Name = "ucrInputMinLon"
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
        'ucrInputMaxLon
        '
        Me.ucrInputMaxLon.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLon.IsMultiline = False
        Me.ucrInputMaxLon.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLon, "ucrInputMaxLon")
        Me.ucrInputMaxLon.Name = "ucrInputMaxLon"
        '
        'lblSaveDownloadedFileTo
        '
        resources.ApplyResources(Me.lblSaveDownloadedFileTo, "lblSaveDownloadedFileTo")
        Me.lblSaveDownloadedFileTo.Name = "lblSaveDownloadedFileTo"
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
        Me.Controls.Add(Me.lblSaveDownloadedFileTo)
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.ucrChkDontImportData)
        Me.Controls.Add(Me.grpDateRange)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrInputData)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.ucrInputSource)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpLocationRange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportGriddedData"
        Me.grpDateRange.ResumeLayout(False)
        Me.grpDateRange.PerformLayout()
        Me.grpLocationRange.ResumeLayout(False)
        Me.grpLocationRange.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblLat As Label
    Friend WithEvents lblMaxLat As Label
    Friend WithEvents lblLon As Label
    Friend WithEvents lblMaxLon As Label
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrInputSource As ucrInputComboBox
    Friend WithEvents lblSource As Label
    Friend WithEvents ucrInputData As ucrInputComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrDtpMinDate As ucrDateTimePicker
    Friend WithEvents ucrDtpMaxDate As ucrDateTimePicker
    Friend WithEvents grpDateRange As GroupBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrInputMaxLon As ucrInputTextBox
    Friend WithEvents ucrInputMinLon As ucrInputTextBox
    Friend WithEvents ucrInputMaxLat As ucrInputTextBox
    Friend WithEvents ucrInputMinLat As ucrInputTextBox
    Friend WithEvents ucrChkDontImportData As ucrCheck
    Friend WithEvents ucrInputNewDataFrameName As ucrInputTextBox
    Friend WithEvents rdoCustomRange As RadioButton
    Friend WithEvents rdoEntireRange As RadioButton
    Friend WithEvents ucrPnlDateRange As UcrPanel
    Friend WithEvents grpLocationRange As GroupBox
    Friend WithEvents lblMinLon As Label
    Friend WithEvents lblMinLat As Label
    Friend WithEvents rdoPoint As RadioButton
    Friend WithEvents rdoArea As RadioButton
    Friend WithEvents ucrPnlLocationRange As UcrPanel
    Friend WithEvents lblSaveDownloadedFileTo As Label
End Class
