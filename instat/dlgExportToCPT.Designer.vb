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
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.lblDataColumns = New System.Windows.Forms.Label()
        Me.ucrBaseExportToCPT = New instat.ucrButtons()
        Me.ucrLocationDataFrame = New instat.ucrDataFrame()
        Me.ucrReceiverMultipleDataColumns = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDataColumn = New instat.ucrReceiverSingle()
        Me.ucrReceiverStations = New instat.ucrReceiverSingle()
        Me.ucrReceiverYears = New instat.ucrReceiverSingle()
        Me.ucrSSTDataframe = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrChkLong = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(347, 243)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 11
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(10, 249)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(56, 13)
        Me.lblExport.TabIndex = 9
        Me.lblExport.Text = "Export file:"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(280, 45)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(37, 13)
        Me.lblYears.TabIndex = 2
        Me.lblYears.Tag = "Years:"
        Me.lblYears.Text = "Years:"
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.Location = New System.Drawing.Point(280, 145)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(48, 13)
        Me.lblStations.TabIndex = 6
        Me.lblStations.Tag = "Stations:"
        Me.lblStations.Text = "Stations:"
        '
        'lblDataColumn
        '
        Me.lblDataColumn.AutoSize = True
        Me.lblDataColumn.Location = New System.Drawing.Point(280, 95)
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Size = New System.Drawing.Size(71, 13)
        Me.lblDataColumn.TabIndex = 6
        Me.lblDataColumn.Tag = "Data_Column:"
        Me.lblDataColumn.Text = "Data Column:"
        '
        'lblDataColumns
        '
        Me.lblDataColumns.AutoSize = True
        Me.lblDataColumns.Location = New System.Drawing.Point(280, 95)
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Size = New System.Drawing.Size(76, 13)
        Me.lblDataColumns.TabIndex = 4
        Me.lblDataColumns.Tag = "Data_Columns:"
        Me.lblDataColumns.Text = "Data Columns:"
        '
        'ucrBaseExportToCPT
        '
        Me.ucrBaseExportToCPT.Location = New System.Drawing.Point(10, 276)
        Me.ucrBaseExportToCPT.Name = "ucrBaseExportToCPT"
        Me.ucrBaseExportToCPT.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseExportToCPT.TabIndex = 12
        '
        'ucrLocationDataFrame
        '
        Me.ucrLocationDataFrame.bUseCurrentFilter = True
        Me.ucrLocationDataFrame.Location = New System.Drawing.Point(10, 193)
        Me.ucrLocationDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrLocationDataFrame.Name = "ucrLocationDataFrame"
        Me.ucrLocationDataFrame.Size = New System.Drawing.Size(127, 50)
        Me.ucrLocationDataFrame.TabIndex = 8
        '
        'ucrReceiverMultipleDataColumns
        '
        Me.ucrReceiverMultipleDataColumns.frmParent = Me
        Me.ucrReceiverMultipleDataColumns.Location = New System.Drawing.Point(280, 110)
        Me.ucrReceiverMultipleDataColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleDataColumns.Name = "ucrReceiverMultipleDataColumns"
        Me.ucrReceiverMultipleDataColumns.Selector = Nothing
        Me.ucrReceiverMultipleDataColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleDataColumns.strNcFilePath = ""
        Me.ucrReceiverMultipleDataColumns.TabIndex = 5
        Me.ucrReceiverMultipleDataColumns.ucrSelector = Nothing
        '
        'ucrReceiverDataColumn
        '
        Me.ucrReceiverDataColumn.frmParent = Me
        Me.ucrReceiverDataColumn.Location = New System.Drawing.Point(280, 110)
        Me.ucrReceiverDataColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        Me.ucrReceiverDataColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDataColumn.strNcFilePath = ""
        Me.ucrReceiverDataColumn.TabIndex = 7
        Me.ucrReceiverDataColumn.ucrSelector = Nothing
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.frmParent = Me
        Me.ucrReceiverStations.Location = New System.Drawing.Point(280, 160)
        Me.ucrReceiverStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStations.Name = "ucrReceiverStations"
        Me.ucrReceiverStations.Selector = Nothing
        Me.ucrReceiverStations.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStations.strNcFilePath = ""
        Me.ucrReceiverStations.TabIndex = 7
        Me.ucrReceiverStations.ucrSelector = Nothing
        '
        'ucrReceiverYears
        '
        Me.ucrReceiverYears.frmParent = Me
        Me.ucrReceiverYears.Location = New System.Drawing.Point(280, 60)
        Me.ucrReceiverYears.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYears.Name = "ucrReceiverYears"
        Me.ucrReceiverYears.Selector = Nothing
        Me.ucrReceiverYears.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYears.strNcFilePath = ""
        Me.ucrReceiverYears.TabIndex = 3
        Me.ucrReceiverYears.ucrSelector = Nothing
        '
        'ucrSSTDataframe
        '
        Me.ucrSSTDataframe.bShowHiddenColumns = False
        Me.ucrSSTDataframe.bUseCurrentFilter = True
        Me.ucrSSTDataframe.Location = New System.Drawing.Point(10, 10)
        Me.ucrSSTDataframe.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSSTDataframe.Name = "ucrSSTDataframe"
        Me.ucrSSTDataframe.Size = New System.Drawing.Size(210, 180)
        Me.ucrSSTDataframe.TabIndex = 0
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(72, 245)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(269, 21)
        Me.ucrInputExportFile.TabIndex = 10
        '
        'ucrChkLong
        '
        Me.ucrChkLong.Checked = False
        Me.ucrChkLong.Location = New System.Drawing.Point(280, 17)
        Me.ucrChkLong.Name = "ucrChkLong"
        Me.ucrChkLong.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkLong.TabIndex = 1
        '
        'dlgExportToCPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 329)
        Me.Controls.Add(Me.ucrChkLong)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.ucrBaseExportToCPT)
        Me.Controls.Add(Me.ucrLocationDataFrame)
        Me.Controls.Add(Me.lblDataColumns)
        Me.Controls.Add(Me.ucrReceiverMultipleDataColumns)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.ucrReceiverDataColumn)
        Me.Controls.Add(Me.ucrReceiverStations)
        Me.Controls.Add(Me.ucrReceiverYears)
        Me.Controls.Add(Me.ucrSSTDataframe)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblExport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToCPT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Export_To_CPT"
        Me.Text = "Export to CPT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblExport As Label
    Friend WithEvents ucrSSTDataframe As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYears As ucrReceiverSingle
    Friend WithEvents ucrReceiverStations As ucrReceiverSingle
    Friend WithEvents ucrReceiverDataColumn As ucrReceiverSingle
    Friend WithEvents lblYears As Label
    Friend WithEvents lblStations As Label
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents ucrReceiverMultipleDataColumns As ucrReceiverMultiple
    Friend WithEvents lblDataColumns As Label
    Friend WithEvents ucrLocationDataFrame As ucrDataFrame
    Friend WithEvents ucrBaseExportToCPT As ucrButtons
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents ucrChkLong As ucrCheck
End Class