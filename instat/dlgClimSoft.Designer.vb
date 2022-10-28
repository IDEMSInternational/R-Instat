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
Partial Class dlgClimSoft
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEstablishConnection = New System.Windows.Forms.Button()
        Me.lblElements = New System.Windows.Forms.Label()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.ttClimsoft = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkElements = New instat.ucrCheck()
        Me.ucrChkStations = New instat.ucrCheck()
        Me.ucrChkObsDate = New instat.ucrCheck()
        Me.ucrCboObsTable = New instat.ucrInputComboBox()
        Me.ucrChkUnStackData = New instat.ucrCheck()
        Me.btnMoreOptions = New System.Windows.Forms.Button()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lbTable = New System.Windows.Forms.Label()
        Me.lblObsStartDate = New System.Windows.Forms.Label()
        Me.ucrDtpObsEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpObStartdate = New instat.ucrDateTimePicker()
        Me.ucrCboElements = New instat.ucrInputComboBox()
        Me.ucrCboStations = New instat.ucrInputComboBox()
        Me.ucrSelectorForClimSoft = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverStations = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblObsEndDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEstablishConnection
        '
        Me.btnEstablishConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEstablishConnection.Location = New System.Drawing.Point(4, 7)
        Me.btnEstablishConnection.Name = "btnEstablishConnection"
        Me.btnEstablishConnection.Size = New System.Drawing.Size(142, 23)
        Me.btnEstablishConnection.TabIndex = 1
        Me.btnEstablishConnection.Text = "Establish Connection..."
        Me.ttClimsoft.SetToolTip(Me.btnEstablishConnection, "Connect to climsoft database")
        Me.btnEstablishConnection.UseVisualStyleBackColor = True
        '
        'lblElements
        '
        Me.lblElements.AutoSize = True
        Me.lblElements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElements.Location = New System.Drawing.Point(255, 248)
        Me.lblElements.Name = "lblElements"
        Me.lblElements.Size = New System.Drawing.Size(134, 13)
        Me.lblElements.TabIndex = 4
        Me.lblElements.Text = "Selected Station Elements:"
        Me.ttClimsoft.SetToolTip(Me.lblElements, "Select elements of selected stations in the selected table")
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStations.Location = New System.Drawing.Point(255, 74)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(93, 13)
        Me.lblStations.TabIndex = 2
        Me.lblStations.Text = "Selected Stations:"
        Me.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttClimsoft.SetToolTip(Me.lblStations, "Select stations in the selected table")
        '
        'ucrChkElements
        '
        Me.ucrChkElements.AutoSize = True
        Me.ucrChkElements.Checked = False
        Me.ucrChkElements.Location = New System.Drawing.Point(7, 262)
        Me.ucrChkElements.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkElements.Name = "ucrChkElements"
        Me.ucrChkElements.Size = New System.Drawing.Size(220, 23)
        Me.ucrChkElements.TabIndex = 42
        Me.ttClimsoft.SetToolTip(Me.ucrChkElements, "Import elements metadata")
        '
        'ucrChkStations
        '
        Me.ucrChkStations.AutoSize = True
        Me.ucrChkStations.Checked = False
        Me.ucrChkStations.Location = New System.Drawing.Point(7, 236)
        Me.ucrChkStations.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkStations.Name = "ucrChkStations"
        Me.ucrChkStations.Size = New System.Drawing.Size(224, 23)
        Me.ucrChkStations.TabIndex = 41
        Me.ttClimsoft.SetToolTip(Me.ucrChkStations, "Import stations metadata")
        '
        'ucrChkObsDate
        '
        Me.ucrChkObsDate.AutoSize = True
        Me.ucrChkObsDate.Checked = False
        Me.ucrChkObsDate.Location = New System.Drawing.Point(8, 322)
        Me.ucrChkObsDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkObsDate.Name = "ucrChkObsDate"
        Me.ucrChkObsDate.Size = New System.Drawing.Size(216, 23)
        Me.ucrChkObsDate.TabIndex = 34
        Me.ttClimsoft.SetToolTip(Me.ucrChkObsDate, "Specify observation date range")
        '
        'ucrCboObsTable
        '
        Me.ucrCboObsTable.AddQuotesIfUnrecognised = True
        Me.ucrCboObsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboObsTable.GetSetSelectedIndex = -1
        Me.ucrCboObsTable.IsReadOnly = False
        Me.ucrCboObsTable.Location = New System.Drawing.Point(7, 58)
        Me.ucrCboObsTable.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboObsTable.Name = "ucrCboObsTable"
        Me.ucrCboObsTable.Size = New System.Drawing.Size(145, 21)
        Me.ucrCboObsTable.TabIndex = 19
        Me.ttClimsoft.SetToolTip(Me.ucrCboObsTable, "Select observation data table")
        '
        'ucrChkUnStackData
        '
        Me.ucrChkUnStackData.AutoSize = True
        Me.ucrChkUnStackData.Checked = False
        Me.ucrChkUnStackData.Location = New System.Drawing.Point(8, 289)
        Me.ucrChkUnStackData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkUnStackData.Name = "ucrChkUnStackData"
        Me.ucrChkUnStackData.Size = New System.Drawing.Size(214, 23)
        Me.ucrChkUnStackData.TabIndex = 45
        Me.ttClimsoft.SetToolTip(Me.ucrChkUnStackData, "Stack data")
        '
        'btnMoreOptions
        '
        Me.btnMoreOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMoreOptions.Location = New System.Drawing.Point(12, 421)
        Me.btnMoreOptions.Name = "btnMoreOptions"
        Me.btnMoreOptions.Size = New System.Drawing.Size(109, 23)
        Me.btnMoreOptions.TabIndex = 46
        Me.btnMoreOptions.Text = "More Options"
        Me.ttClimsoft.SetToolTip(Me.btnMoreOptions, "Click to view more options")
        Me.btnMoreOptions.UseVisualStyleBackColor = True
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(153, 12)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 16
        Me.lblConnection.Text = "No Connection"
        '
        'lbTable
        '
        Me.lbTable.AutoSize = True
        Me.lbTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbTable.Location = New System.Drawing.Point(5, 42)
        Me.lbTable.Name = "lbTable"
        Me.lbTable.Size = New System.Drawing.Size(96, 13)
        Me.lbTable.TabIndex = 18
        Me.lbTable.Text = "Select Data Table:"
        Me.lbTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblObsStartDate
        '
        Me.lblObsStartDate.AutoSize = True
        Me.lblObsStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObsStartDate.Location = New System.Drawing.Point(28, 353)
        Me.lblObsStartDate.Name = "lblObsStartDate"
        Me.lblObsStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblObsStartDate.TabIndex = 33
        Me.lblObsStartDate.Text = "Start Date:"
        '
        'ucrDtpObsEndDate
        '
        Me.ucrDtpObsEndDate.AutoSize = True
        Me.ucrDtpObsEndDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 379)
        Me.ucrDtpObsEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpObsEndDate.Location = New System.Drawing.Point(106, 380)
        Me.ucrDtpObsEndDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpObsEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpObsEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpObsEndDate.Name = "ucrDtpObsEndDate"
        Me.ucrDtpObsEndDate.Size = New System.Drawing.Size(118, 20)
        Me.ucrDtpObsEndDate.TabIndex = 36
        '
        'ucrDtpObStartdate
        '
        Me.ucrDtpObStartdate.AutoSize = True
        Me.ucrDtpObStartdate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 408)
        Me.ucrDtpObStartdate.Format = "dd MMM yyyy"
        Me.ucrDtpObStartdate.Location = New System.Drawing.Point(104, 349)
        Me.ucrDtpObStartdate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpObStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpObStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpObStartdate.Name = "ucrDtpObStartdate"
        Me.ucrDtpObStartdate.Size = New System.Drawing.Size(118, 20)
        Me.ucrDtpObStartdate.TabIndex = 35
        '
        'ucrCboElements
        '
        Me.ucrCboElements.AddQuotesIfUnrecognised = True
        Me.ucrCboElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboElements.GetSetSelectedIndex = -1
        Me.ucrCboElements.IsReadOnly = False
        Me.ucrCboElements.Location = New System.Drawing.Point(258, 264)
        Me.ucrCboElements.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboElements.Name = "ucrCboElements"
        Me.ucrCboElements.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboElements.TabIndex = 5
        '
        'ucrCboStations
        '
        Me.ucrCboStations.AddQuotesIfUnrecognised = True
        Me.ucrCboStations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboStations.GetSetSelectedIndex = -1
        Me.ucrCboStations.IsReadOnly = False
        Me.ucrCboStations.Location = New System.Drawing.Point(258, 88)
        Me.ucrCboStations.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboStations.Name = "ucrCboStations"
        Me.ucrCboStations.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboStations.TabIndex = 3
        '
        'ucrSelectorForClimSoft
        '
        Me.ucrSelectorForClimSoft.AutoSize = True
        Me.ucrSelectorForClimSoft.bShowHiddenColumns = False
        Me.ucrSelectorForClimSoft.Location = New System.Drawing.Point(7, 88)
        Me.ucrSelectorForClimSoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForClimSoft.Name = "ucrSelectorForClimSoft"
        Me.ucrSelectorForClimSoft.Size = New System.Drawing.Size(216, 147)
        Me.ucrSelectorForClimSoft.TabIndex = 2
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.AutoSize = True
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(258, 288)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(137, 118)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 6
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.AutoSize = True
        Me.ucrReceiverStations.frmParent = Me
        Me.ucrReceiverStations.Location = New System.Drawing.Point(258, 113)
        Me.ucrReceiverStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStations.Name = "ucrReceiverStations"
        Me.ucrReceiverStations.Selector = Nothing
        Me.ucrReceiverStations.Size = New System.Drawing.Size(137, 118)
        Me.ucrReceiverStations.strNcFilePath = ""
        Me.ucrReceiverStations.TabIndex = 4
        Me.ucrReceiverStations.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(4, 467)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 14
        '
        'lblObsEndDate
        '
        Me.lblObsEndDate.AutoSize = True
        Me.lblObsEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObsEndDate.Location = New System.Drawing.Point(28, 383)
        Me.lblObsEndDate.Name = "lblObsEndDate"
        Me.lblObsEndDate.Size = New System.Drawing.Size(55, 13)
        Me.lblObsEndDate.TabIndex = 47
        Me.lblObsEndDate.Text = "End Date:"
        '
        'dlgClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(413, 526)
        Me.Controls.Add(Me.lblObsEndDate)
        Me.Controls.Add(Me.btnMoreOptions)
        Me.Controls.Add(Me.ucrChkUnStackData)
        Me.Controls.Add(Me.ucrChkElements)
        Me.Controls.Add(Me.ucrChkStations)
        Me.Controls.Add(Me.ucrChkObsDate)
        Me.Controls.Add(Me.ucrDtpObsEndDate)
        Me.Controls.Add(Me.ucrDtpObStartdate)
        Me.Controls.Add(Me.lblObsStartDate)
        Me.Controls.Add(Me.ucrCboObsTable)
        Me.Controls.Add(Me.lbTable)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.ucrCboElements)
        Me.Controls.Add(Me.ucrCboStations)
        Me.Controls.Add(Me.ucrSelectorForClimSoft)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.lblElements)
        Me.Controls.Add(Me.ucrReceiverStations)
        Me.Controls.Add(Me.btnEstablishConnection)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimSoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From Climsoft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents btnEstablishConnection As Button
    Friend WithEvents ucrReceiverStations As ucrReceiverMultiple
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents lblStations As Label
    Friend WithEvents lblElements As Label
    Friend WithEvents ucrSelectorForClimSoft As ucrSelectorAddRemove
    Friend WithEvents ttClimsoft As ToolTip
    Friend WithEvents ucrCboStations As ucrInputComboBox
    Friend WithEvents ucrCboElements As ucrInputComboBox
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrCboObsTable As ucrInputComboBox
    Friend WithEvents lbTable As Label
    Friend WithEvents ucrChkObsDate As ucrCheck
    Friend WithEvents ucrDtpObsEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpObStartdate As ucrDateTimePicker
    Friend WithEvents lblObsStartDate As Label
    Friend WithEvents ucrChkElements As ucrCheck
    Friend WithEvents ucrChkStations As ucrCheck
    Friend WithEvents ucrChkUnStackData As ucrCheck
    Friend WithEvents btnMoreOptions As Button
    Friend WithEvents lblObsEndDate As Label
End Class
