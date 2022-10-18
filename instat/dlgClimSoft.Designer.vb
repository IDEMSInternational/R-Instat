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
        Me.cmdEstablishConnection = New System.Windows.Forms.Button()
        Me.lblElements = New System.Windows.Forms.Label()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.ttClimsoft = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lbTable = New System.Windows.Forms.Label()
        Me.lblEntryDateTo = New System.Windows.Forms.Label()
        Me.lblObsDateTo = New System.Windows.Forms.Label()
        Me.btnMoreOptions = New System.Windows.Forms.Button()
        Me.ucrChkElements = New instat.ucrCheck()
        Me.ucrChkStations = New instat.ucrCheck()
        Me.ucrChkEntryDate = New instat.ucrCheck()
        Me.ucrDtpEntryEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpEntryStartdate = New instat.ucrDateTimePicker()
        Me.ucrChkObsDate = New instat.ucrCheck()
        Me.ucrDtpObsEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpObStartdate = New instat.ucrDateTimePicker()
        Me.ucrCboObsTable = New instat.ucrInputComboBox()
        Me.ucrCboElements = New instat.ucrInputComboBox()
        Me.ucrCboStations = New instat.ucrInputComboBox()
        Me.ucrSelectorForClimSoft = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverStations = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdEstablishConnection
        '
        Me.cmdEstablishConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEstablishConnection.Location = New System.Drawing.Point(8, 8)
        Me.cmdEstablishConnection.Name = "cmdEstablishConnection"
        Me.cmdEstablishConnection.Size = New System.Drawing.Size(142, 23)
        Me.cmdEstablishConnection.TabIndex = 1
        Me.cmdEstablishConnection.Text = "Establish Connection..."
        Me.ttClimsoft.SetToolTip(Me.cmdEstablishConnection, "Connect to climsoft database")
        Me.cmdEstablishConnection.UseVisualStyleBackColor = True
        '
        'lblElements
        '
        Me.lblElements.AutoSize = True
        Me.lblElements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElements.Location = New System.Drawing.Point(257, 297)
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
        Me.lblStations.Location = New System.Drawing.Point(257, 118)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(93, 13)
        Me.lblStations.TabIndex = 2
        Me.lblStations.Text = "Selected Stations:"
        Me.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttClimsoft.SetToolTip(Me.lblStations, "Select stations in the selected table")
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(153, 14)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 16
        Me.lblConnection.Text = "No Connection"
        '
        'lbTable
        '
        Me.lbTable.AutoSize = True
        Me.lbTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbTable.Location = New System.Drawing.Point(5, 118)
        Me.lbTable.Name = "lbTable"
        Me.lbTable.Size = New System.Drawing.Size(96, 13)
        Me.lbTable.TabIndex = 18
        Me.lbTable.Text = "Select Data Table:"
        Me.lbTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEntryDateTo
        '
        Me.lblEntryDateTo.AutoSize = True
        Me.lblEntryDateTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEntryDateTo.Location = New System.Drawing.Point(267, 87)
        Me.lblEntryDateTo.Name = "lblEntryDateTo"
        Me.lblEntryDateTo.Size = New System.Drawing.Size(20, 13)
        Me.lblEntryDateTo.TabIndex = 37
        Me.lblEntryDateTo.Text = "To"
        '
        'lblObsDateTo
        '
        Me.lblObsDateTo.AutoSize = True
        Me.lblObsDateTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObsDateTo.Location = New System.Drawing.Point(265, 54)
        Me.lblObsDateTo.Name = "lblObsDateTo"
        Me.lblObsDateTo.Size = New System.Drawing.Size(20, 13)
        Me.lblObsDateTo.TabIndex = 33
        Me.lblObsDateTo.Text = "To"
        '
        'btnMoreOptions
        '
        Me.btnMoreOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMoreOptions.Location = New System.Drawing.Point(7, 402)
        Me.btnMoreOptions.Name = "btnMoreOptions"
        Me.btnMoreOptions.Size = New System.Drawing.Size(87, 23)
        Me.btnMoreOptions.TabIndex = 43
        Me.btnMoreOptions.Text = "More Options"
        Me.ttClimsoft.SetToolTip(Me.btnMoreOptions, "More options")
        Me.btnMoreOptions.UseVisualStyleBackColor = True
        '
        'ucrChkElements
        '
        Me.ucrChkElements.AutoSize = True
        Me.ucrChkElements.Checked = False
        Me.ucrChkElements.Location = New System.Drawing.Point(6, 371)
        Me.ucrChkElements.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkElements.Name = "ucrChkElements"
        Me.ucrChkElements.Size = New System.Drawing.Size(180, 23)
        Me.ucrChkElements.TabIndex = 42
        Me.ttClimsoft.SetToolTip(Me.ucrChkElements, "Import selected elements metadata")
        '
        'ucrChkStations
        '
        Me.ucrChkStations.AutoSize = True
        Me.ucrChkStations.Checked = False
        Me.ucrChkStations.Location = New System.Drawing.Point(6, 341)
        Me.ucrChkStations.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkStations.Name = "ucrChkStations"
        Me.ucrChkStations.Size = New System.Drawing.Size(180, 23)
        Me.ucrChkStations.TabIndex = 41
        Me.ttClimsoft.SetToolTip(Me.ucrChkStations, "Import selected stations metadata")
        '
        'ucrChkEntryDate
        '
        Me.ucrChkEntryDate.AutoSize = True
        Me.ucrChkEntryDate.Checked = False
        Me.ucrChkEntryDate.Location = New System.Drawing.Point(6, 85)
        Me.ucrChkEntryDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkEntryDate.Name = "ucrChkEntryDate"
        Me.ucrChkEntryDate.Size = New System.Drawing.Size(142, 23)
        Me.ucrChkEntryDate.TabIndex = 38
        Me.ttClimsoft.SetToolTip(Me.ucrChkEntryDate, "Specify entry date range")
        '
        'ucrDtpEntryEndDate
        '
        Me.ucrDtpEntryEndDate.AutoSize = True
        Me.ucrDtpEntryEndDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 379)
        Me.ucrDtpEntryEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpEntryEndDate.Location = New System.Drawing.Point(296, 83)
        Me.ucrDtpEntryEndDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpEntryEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEntryEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEntryEndDate.Name = "ucrDtpEntryEndDate"
        Me.ucrDtpEntryEndDate.Size = New System.Drawing.Size(97, 20)
        Me.ucrDtpEntryEndDate.TabIndex = 40
        '
        'ucrDtpEntryStartdate
        '
        Me.ucrDtpEntryStartdate.AutoSize = True
        Me.ucrDtpEntryStartdate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 408)
        Me.ucrDtpEntryStartdate.Format = "dd MMM yyyy"
        Me.ucrDtpEntryStartdate.Location = New System.Drawing.Point(156, 84)
        Me.ucrDtpEntryStartdate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpEntryStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEntryStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEntryStartdate.Name = "ucrDtpEntryStartdate"
        Me.ucrDtpEntryStartdate.Size = New System.Drawing.Size(102, 20)
        Me.ucrDtpEntryStartdate.TabIndex = 39
        '
        'ucrChkObsDate
        '
        Me.ucrChkObsDate.AutoSize = True
        Me.ucrChkObsDate.Checked = False
        Me.ucrChkObsDate.Location = New System.Drawing.Point(5, 52)
        Me.ucrChkObsDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkObsDate.Name = "ucrChkObsDate"
        Me.ucrChkObsDate.Size = New System.Drawing.Size(139, 23)
        Me.ucrChkObsDate.TabIndex = 34
        Me.ttClimsoft.SetToolTip(Me.ucrChkObsDate, "Specify observation date range")
        '
        'ucrDtpObsEndDate
        '
        Me.ucrDtpObsEndDate.AutoSize = True
        Me.ucrDtpObsEndDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 379)
        Me.ucrDtpObsEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpObsEndDate.Location = New System.Drawing.Point(294, 50)
        Me.ucrDtpObsEndDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpObsEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpObsEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpObsEndDate.Name = "ucrDtpObsEndDate"
        Me.ucrDtpObsEndDate.Size = New System.Drawing.Size(97, 20)
        Me.ucrDtpObsEndDate.TabIndex = 36
        '
        'ucrDtpObStartdate
        '
        Me.ucrDtpObStartdate.AutoSize = True
        Me.ucrDtpObStartdate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 408)
        Me.ucrDtpObStartdate.Format = "dd MMM yyyy"
        Me.ucrDtpObStartdate.Location = New System.Drawing.Point(156, 50)
        Me.ucrDtpObStartdate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpObStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpObStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpObStartdate.Name = "ucrDtpObStartdate"
        Me.ucrDtpObStartdate.Size = New System.Drawing.Size(102, 20)
        Me.ucrDtpObStartdate.TabIndex = 35
        '
        'ucrCboObsTable
        '
        Me.ucrCboObsTable.AddQuotesIfUnrecognised = True
        Me.ucrCboObsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboObsTable.GetSetSelectedIndex = -1
        Me.ucrCboObsTable.IsReadOnly = False
        Me.ucrCboObsTable.Location = New System.Drawing.Point(7, 134)
        Me.ucrCboObsTable.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboObsTable.Name = "ucrCboObsTable"
        Me.ucrCboObsTable.Size = New System.Drawing.Size(145, 21)
        Me.ucrCboObsTable.TabIndex = 19
        Me.ttClimsoft.SetToolTip(Me.ucrCboObsTable, "Select observation data table")
        '
        'ucrCboElements
        '
        Me.ucrCboElements.AddQuotesIfUnrecognised = True
        Me.ucrCboElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboElements.GetSetSelectedIndex = -1
        Me.ucrCboElements.IsReadOnly = False
        Me.ucrCboElements.Location = New System.Drawing.Point(260, 313)
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
        Me.ucrCboStations.Location = New System.Drawing.Point(260, 132)
        Me.ucrCboStations.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboStations.Name = "ucrCboStations"
        Me.ucrCboStations.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboStations.TabIndex = 3
        '
        'ucrSelectorForClimSoft
        '
        Me.ucrSelectorForClimSoft.AutoSize = True
        Me.ucrSelectorForClimSoft.bShowHiddenColumns = False
        Me.ucrSelectorForClimSoft.Location = New System.Drawing.Point(7, 157)
        Me.ucrSelectorForClimSoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForClimSoft.Name = "ucrSelectorForClimSoft"
        Me.ucrSelectorForClimSoft.Size = New System.Drawing.Size(216, 147)
        Me.ucrSelectorForClimSoft.TabIndex = 2
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.AutoSize = True
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(260, 337)
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
        Me.ucrReceiverStations.Location = New System.Drawing.Point(260, 157)
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
        Me.ucrBase.Location = New System.Drawing.Point(4, 468)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 14
        '
        'dlgClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(413, 527)
        Me.Controls.Add(Me.btnMoreOptions)
        Me.Controls.Add(Me.ucrChkElements)
        Me.Controls.Add(Me.ucrChkStations)
        Me.Controls.Add(Me.ucrChkEntryDate)
        Me.Controls.Add(Me.ucrDtpEntryEndDate)
        Me.Controls.Add(Me.ucrDtpEntryStartdate)
        Me.Controls.Add(Me.lblEntryDateTo)
        Me.Controls.Add(Me.ucrChkObsDate)
        Me.Controls.Add(Me.ucrDtpObsEndDate)
        Me.Controls.Add(Me.ucrDtpObStartdate)
        Me.Controls.Add(Me.lblObsDateTo)
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
        Me.Controls.Add(Me.cmdEstablishConnection)
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
    Friend WithEvents cmdEstablishConnection As Button
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
    Friend WithEvents ucrChkEntryDate As ucrCheck
    Friend WithEvents ucrDtpEntryEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpEntryStartdate As ucrDateTimePicker
    Friend WithEvents lblEntryDateTo As Label
    Friend WithEvents ucrChkObsDate As ucrCheck
    Friend WithEvents ucrDtpObsEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpObStartdate As ucrDateTimePicker
    Friend WithEvents lblObsDateTo As Label
    Friend WithEvents ucrChkElements As ucrCheck
    Friend WithEvents ucrChkStations As ucrCheck
    Friend WithEvents btnMoreOptions As Button
End Class
