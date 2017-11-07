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
        resources.ApplyResources(Me.cmdBrowse, "cmdBrowse")
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        resources.ApplyResources(Me.lblExport, "lblExport")
        Me.lblExport.Name = "lblExport"
        '
        'lblYears
        '
        resources.ApplyResources(Me.lblYears, "lblYears")
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Tag = "Years:"
        '
        'lblStations
        '
        resources.ApplyResources(Me.lblStations, "lblStations")
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Tag = "Stations:"
        '
        'lblDataColumn
        '
        resources.ApplyResources(Me.lblDataColumn, "lblDataColumn")
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Tag = "Data_Column:"
        '
        'lblDataColumns
        '
        resources.ApplyResources(Me.lblDataColumns, "lblDataColumns")
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Tag = "Data_Columns:"
        '
        'ucrBaseExportToCPT
        '
        resources.ApplyResources(Me.ucrBaseExportToCPT, "ucrBaseExportToCPT")
        Me.ucrBaseExportToCPT.Name = "ucrBaseExportToCPT"
        '
        'ucrLocationDataFrame
        '
        Me.ucrLocationDataFrame.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrLocationDataFrame, "ucrLocationDataFrame")
        Me.ucrLocationDataFrame.Name = "ucrLocationDataFrame"
        '
        'ucrReceiverMultipleDataColumns
        '
        Me.ucrReceiverMultipleDataColumns.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleDataColumns, "ucrReceiverMultipleDataColumns")
        Me.ucrReceiverMultipleDataColumns.Name = "ucrReceiverMultipleDataColumns"
        Me.ucrReceiverMultipleDataColumns.Selector = Nothing
        Me.ucrReceiverMultipleDataColumns.strNcFilePath = ""
        Me.ucrReceiverMultipleDataColumns.ucrSelector = Nothing
        '
        'ucrReceiverDataColumn
        '
        Me.ucrReceiverDataColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDataColumn, "ucrReceiverDataColumn")
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        Me.ucrReceiverDataColumn.strNcFilePath = ""
        Me.ucrReceiverDataColumn.ucrSelector = Nothing
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
        'ucrReceiverYears
        '
        Me.ucrReceiverYears.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYears, "ucrReceiverYears")
        Me.ucrReceiverYears.Name = "ucrReceiverYears"
        Me.ucrReceiverYears.Selector = Nothing
        Me.ucrReceiverYears.strNcFilePath = ""
        Me.ucrReceiverYears.ucrSelector = Nothing
        '
        'ucrSSTDataframe
        '
        Me.ucrSSTDataframe.bShowHiddenColumns = False
        Me.ucrSSTDataframe.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSSTDataframe, "ucrSSTDataframe")
        Me.ucrSSTDataframe.Name = "ucrSSTDataframe"
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputExportFile, "ucrInputExportFile")
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        '
        'ucrChkLong
        '
        Me.ucrChkLong.Checked = False
        resources.ApplyResources(Me.ucrChkLong, "ucrChkLong")
        Me.ucrChkLong.Name = "ucrChkLong"
        '
        'dlgExportToCPT
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Export_To_CPT"
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