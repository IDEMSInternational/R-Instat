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
        Me.lblMinLat.AutoSize = True
        Me.lblMinLat.Location = New System.Drawing.Point(11, 234)
        Me.lblMinLat.Name = "lblMinLat"
        Me.lblMinLat.Size = New System.Drawing.Size(92, 13)
        Me.lblMinLat.TabIndex = 13
        Me.lblMinLat.Text = "Minimum Latitude:"
        '
        'lblMaxLat
        '
        Me.lblMaxLat.AutoSize = True
        Me.lblMaxLat.Location = New System.Drawing.Point(225, 234)
        Me.lblMaxLat.Name = "lblMaxLat"
        Me.lblMaxLat.Size = New System.Drawing.Size(95, 13)
        Me.lblMaxLat.TabIndex = 15
        Me.lblMaxLat.Text = "Maximum Latitude:"
        '
        'lblMinLon
        '
        Me.lblMinLon.AutoSize = True
        Me.lblMinLon.Location = New System.Drawing.Point(11, 210)
        Me.lblMinLon.Name = "lblMinLon"
        Me.lblMinLon.Size = New System.Drawing.Size(101, 13)
        Me.lblMinLon.TabIndex = 9
        Me.lblMinLon.Text = "Minimum Longitude:"
        '
        'lblMaxLon
        '
        Me.lblMaxLon.AutoSize = True
        Me.lblMaxLon.Location = New System.Drawing.Point(225, 209)
        Me.lblMaxLon.Name = "lblMaxLon"
        Me.lblMaxLon.Size = New System.Drawing.Size(104, 13)
        Me.lblMaxLon.TabIndex = 11
        Me.lblMaxLon.Text = "Maximum Longitude:"
        '
        'lblMainDataName
        '
        Me.lblMainDataName.AutoSize = True
        Me.lblMainDataName.Location = New System.Drawing.Point(11, 79)
        Me.lblMainDataName.Name = "lblMainDataName"
        Me.lblMainDataName.Size = New System.Drawing.Size(90, 13)
        Me.lblMainDataName.TabIndex = 4
        Me.lblMainDataName.Text = "Main Data Name:"
        '
        'lblDownloadFrom
        '
        Me.lblDownloadFrom.AutoSize = True
        Me.lblDownloadFrom.Location = New System.Drawing.Point(11, 25)
        Me.lblDownloadFrom.Name = "lblDownloadFrom"
        Me.lblDownloadFrom.Size = New System.Drawing.Size(84, 13)
        Me.lblDownloadFrom.TabIndex = 0
        Me.lblDownloadFrom.Text = "Download From:"
        '
        'lblDataFile
        '
        Me.lblDataFile.AutoSize = True
        Me.lblDataFile.Location = New System.Drawing.Point(11, 52)
        Me.lblDataFile.Name = "lblDataFile"
        Me.lblDataFile.Size = New System.Drawing.Size(52, 13)
        Me.lblDataFile.TabIndex = 2
        Me.lblDataFile.Text = "Data File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(376, 258)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 19
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(11, 263)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(116, 13)
        Me.lblExport.TabIndex = 17
        Me.lblExport.Text = "Temporary file location:"
        '
        'lblLocationData
        '
        Me.lblLocationData.AutoSize = True
        Me.lblLocationData.Location = New System.Drawing.Point(11, 106)
        Me.lblLocationData.Name = "lblLocationData"
        Me.lblLocationData.Size = New System.Drawing.Size(108, 13)
        Me.lblLocationData.TabIndex = 6
        Me.lblLocationData.Text = "Location Data Name:"
        '
        'grpGetArea
        '
        Me.grpGetArea.Controls.Add(Me.rdoPoint)
        Me.grpGetArea.Controls.Add(Me.rdoArea)
        Me.grpGetArea.Controls.Add(Me.ucrPnlGetArea)
        Me.grpGetArea.Location = New System.Drawing.Point(11, 140)
        Me.grpGetArea.Name = "grpGetArea"
        Me.grpGetArea.Size = New System.Drawing.Size(197, 47)
        Me.grpGetArea.TabIndex = 8
        Me.grpGetArea.TabStop = False
        Me.grpGetArea.Text = "Download Type"
        '
        'rdoPoint
        '
        Me.rdoPoint.AutoSize = True
        Me.rdoPoint.Location = New System.Drawing.Point(120, 19)
        Me.rdoPoint.Name = "rdoPoint"
        Me.rdoPoint.Size = New System.Drawing.Size(49, 17)
        Me.rdoPoint.TabIndex = 2
        Me.rdoPoint.TabStop = True
        Me.rdoPoint.Text = "Point"
        Me.rdoPoint.UseVisualStyleBackColor = True
        '
        'rdoArea
        '
        Me.rdoArea.AutoSize = True
        Me.rdoArea.Location = New System.Drawing.Point(10, 19)
        Me.rdoArea.Name = "rdoArea"
        Me.rdoArea.Size = New System.Drawing.Size(47, 17)
        Me.rdoArea.TabIndex = 1
        Me.rdoArea.TabStop = True
        Me.rdoArea.Text = "Area"
        Me.rdoArea.UseVisualStyleBackColor = True
        '
        'ucrPnlGetArea
        '
        Me.ucrPnlGetArea.Location = New System.Drawing.Point(7, 13)
        Me.ucrPnlGetArea.Name = "ucrPnlGetArea"
        Me.ucrPnlGetArea.Size = New System.Drawing.Size(184, 28)
        Me.ucrPnlGetArea.TabIndex = 0
        '
        'ucrInputLocDataName
        '
        Me.ucrInputLocDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputLocDataName.IsMultiline = False
        Me.ucrInputLocDataName.IsReadOnly = False
        Me.ucrInputLocDataName.Location = New System.Drawing.Point(131, 102)
        Me.ucrInputLocDataName.Name = "ucrInputLocDataName"
        Me.ucrInputLocDataName.Size = New System.Drawing.Size(161, 21)
        Me.ucrInputLocDataName.TabIndex = 7
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(132, 259)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(227, 21)
        Me.ucrInputExportFile.TabIndex = 18
        '
        'ucrInputDataFile
        '
        Me.ucrInputDataFile.AddQuotesIfUnrecognised = True
        Me.ucrInputDataFile.IsReadOnly = False
        Me.ucrInputDataFile.Location = New System.Drawing.Point(131, 48)
        Me.ucrInputDataFile.Name = "ucrInputDataFile"
        Me.ucrInputDataFile.Size = New System.Drawing.Size(161, 21)
        Me.ucrInputDataFile.TabIndex = 3
        '
        'ucrInputDownloadFrom
        '
        Me.ucrInputDownloadFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputDownloadFrom.IsReadOnly = False
        Me.ucrInputDownloadFrom.Location = New System.Drawing.Point(131, 21)
        Me.ucrInputDownloadFrom.Name = "ucrInputDownloadFrom"
        Me.ucrInputDownloadFrom.Size = New System.Drawing.Size(161, 21)
        Me.ucrInputDownloadFrom.TabIndex = 1
        '
        'ucrInputMainDataName
        '
        Me.ucrInputMainDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputMainDataName.IsMultiline = False
        Me.ucrInputMainDataName.IsReadOnly = False
        Me.ucrInputMainDataName.Location = New System.Drawing.Point(131, 75)
        Me.ucrInputMainDataName.Name = "ucrInputMainDataName"
        Me.ucrInputMainDataName.Size = New System.Drawing.Size(161, 21)
        Me.ucrInputMainDataName.TabIndex = 5
        '
        'ucrNudMaxLat
        '
        Me.ucrNudMaxLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxLat.Location = New System.Drawing.Point(332, 230)
        Me.ucrNudMaxLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Name = "ucrNudMaxLat"
        Me.ucrNudMaxLat.Size = New System.Drawing.Size(72, 20)
        Me.ucrNudMaxLat.TabIndex = 16
        Me.ucrNudMaxLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxLon
        '
        Me.ucrNudMaxLon.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLon.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxLon.Location = New System.Drawing.Point(332, 205)
        Me.ucrNudMaxLon.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLon.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLon.Name = "ucrNudMaxLon"
        Me.ucrNudMaxLon.Size = New System.Drawing.Size(72, 20)
        Me.ucrNudMaxLon.TabIndex = 12
        Me.ucrNudMaxLon.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLon
        '
        Me.ucrNudMinLon.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLon.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinLon.Location = New System.Drawing.Point(116, 206)
        Me.ucrNudMinLon.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLon.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLon.Name = "ucrNudMinLon"
        Me.ucrNudMinLon.Size = New System.Drawing.Size(72, 20)
        Me.ucrNudMinLon.TabIndex = 10
        Me.ucrNudMinLon.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLat
        '
        Me.ucrNudMinLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinLat.Location = New System.Drawing.Point(116, 231)
        Me.ucrNudMinLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Name = "ucrNudMinLat"
        Me.ucrNudMinLat.Size = New System.Drawing.Size(72, 20)
        Me.ucrNudMinLat.TabIndex = 14
        Me.ucrNudMinLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(11, 287)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(416, 52)
        Me.ucrBase.TabIndex = 20
        '
        'dlgImportGriddedData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 346)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Gridded Data"
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
