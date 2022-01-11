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
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.ttClimsoft = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkUnstackData = New instat.ucrCheck()
        Me.ucrChkFlagsData = New instat.ucrCheck()
        Me.ucrChkElements = New instat.ucrCheck()
        Me.ucrChkDateRange = New instat.ucrCheck()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpStartdate = New instat.ucrDateTimePicker()
        Me.ucrChkObservationData = New instat.ucrCheck()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.ucrComboBoxElements = New instat.ucrInputComboBox()
        Me.ucrComboBoxStations = New instat.ucrInputComboBox()
        Me.ucrSelectorForClimSoft = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverMultipleElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMultipleStations = New instat.ucrReceiverMultiple()
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
        Me.cmdEstablishConnection.UseVisualStyleBackColor = True
        '
        'lblElements
        '
        Me.lblElements.AutoSize = True
        Me.lblElements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElements.Location = New System.Drawing.Point(256, 194)
        Me.lblElements.Name = "lblElements"
        Me.lblElements.Size = New System.Drawing.Size(98, 13)
        Me.lblElements.TabIndex = 4
        Me.lblElements.Text = "Selected Elements:"
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStations.Location = New System.Drawing.Point(256, 38)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(93, 13)
        Me.lblStations.TabIndex = 2
        Me.lblStations.Text = "Selected Stations:"
        Me.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartDate.Location = New System.Drawing.Point(32, 307)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDate.TabIndex = 7
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEndDate.Location = New System.Drawing.Point(34, 349)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(55, 13)
        Me.lblEndDate.TabIndex = 9
        Me.lblEndDate.Text = "End Date:"
        '
        'ucrChkUnstackData
        '
        Me.ucrChkUnstackData.AutoSize = True
        Me.ucrChkUnstackData.Checked = True
        Me.ucrChkUnstackData.Location = New System.Drawing.Point(8, 235)
        Me.ucrChkUnstackData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkUnstackData.Name = "ucrChkUnstackData"
        Me.ucrChkUnstackData.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkUnstackData.TabIndex = 9
        Me.ttClimsoft.SetToolTip(Me.ucrChkUnstackData, "Select Observation Data Date Range")
        '
        'ucrChkFlagsData
        '
        Me.ucrChkFlagsData.AutoSize = True
        Me.ucrChkFlagsData.Checked = False
        Me.ucrChkFlagsData.Location = New System.Drawing.Point(8, 212)
        Me.ucrChkFlagsData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkFlagsData.Name = "ucrChkFlagsData"
        Me.ucrChkFlagsData.Size = New System.Drawing.Size(213, 23)
        Me.ucrChkFlagsData.TabIndex = 8
        Me.ttClimsoft.SetToolTip(Me.ucrChkFlagsData, "Select Observation Data Date Range")
        '
        'ucrChkElements
        '
        Me.ucrChkElements.AutoSize = True
        Me.ucrChkElements.Checked = False
        Me.ucrChkElements.Location = New System.Drawing.Point(8, 258)
        Me.ucrChkElements.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkElements.Name = "ucrChkElements"
        Me.ucrChkElements.Size = New System.Drawing.Size(230, 23)
        Me.ucrChkElements.TabIndex = 10
        Me.ttClimsoft.SetToolTip(Me.ucrChkElements, "Select Observation Data Date Range")
        '
        'ucrChkDateRange
        '
        Me.ucrChkDateRange.AutoSize = True
        Me.ucrChkDateRange.Checked = False
        Me.ucrChkDateRange.Location = New System.Drawing.Point(8, 283)
        Me.ucrChkDateRange.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkDateRange.Name = "ucrChkDateRange"
        Me.ucrChkDateRange.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkDateRange.TabIndex = 11
        Me.ttClimsoft.SetToolTip(Me.ucrChkDateRange, "Select Observation Data Date Range")
        '
        'ucrDtpEndDate
        '
        Me.ucrDtpEndDate.AutoSize = True
        Me.ucrDtpEndDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 379)
        Me.ucrDtpEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpEndDate.Location = New System.Drawing.Point(36, 367)
        Me.ucrDtpEndDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        Me.ucrDtpEndDate.Size = New System.Drawing.Size(163, 20)
        Me.ucrDtpEndDate.TabIndex = 13
        Me.ttClimsoft.SetToolTip(Me.ucrDtpEndDate, "End Date (To)")
        '
        'ucrDtpStartdate
        '
        Me.ucrDtpStartdate.AutoSize = True
        Me.ucrDtpStartdate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 408)
        Me.ucrDtpStartdate.Format = "dd MMM yyyy"
        Me.ucrDtpStartdate.Location = New System.Drawing.Point(35, 322)
        Me.ucrDtpStartdate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartdate.Name = "ucrDtpStartdate"
        Me.ucrDtpStartdate.Size = New System.Drawing.Size(163, 20)
        Me.ucrDtpStartdate.TabIndex = 12
        Me.ttClimsoft.SetToolTip(Me.ucrDtpStartdate, "Start Date (From)")
        '
        'ucrChkObservationData
        '
        Me.ucrChkObservationData.AutoSize = True
        Me.ucrChkObservationData.Checked = False
        Me.ucrChkObservationData.Location = New System.Drawing.Point(8, 188)
        Me.ucrChkObservationData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkObservationData.Name = "ucrChkObservationData"
        Me.ucrChkObservationData.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkObservationData.TabIndex = 7
        Me.ttClimsoft.SetToolTip(Me.ucrChkObservationData, "Select Observation Data Date Range")
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
        'ucrComboBoxElements
        '
        Me.ucrComboBoxElements.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxElements.GetSetSelectedIndex = -1
        Me.ucrComboBoxElements.IsReadOnly = False
        Me.ucrComboBoxElements.Location = New System.Drawing.Point(259, 210)
        Me.ucrComboBoxElements.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxElements.Name = "ucrComboBoxElements"
        Me.ucrComboBoxElements.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboBoxElements.TabIndex = 5
        '
        'ucrComboBoxStations
        '
        Me.ucrComboBoxStations.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxStations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxStations.GetSetSelectedIndex = -1
        Me.ucrComboBoxStations.IsReadOnly = False
        Me.ucrComboBoxStations.Location = New System.Drawing.Point(256, 53)
        Me.ucrComboBoxStations.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxStations.Name = "ucrComboBoxStations"
        Me.ucrComboBoxStations.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboBoxStations.TabIndex = 3
        '
        'ucrSelectorForClimSoft
        '
        Me.ucrSelectorForClimSoft.AutoSize = True
        Me.ucrSelectorForClimSoft.bShowHiddenColumns = False
        Me.ucrSelectorForClimSoft.Location = New System.Drawing.Point(8, 43)
        Me.ucrSelectorForClimSoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForClimSoft.Name = "ucrSelectorForClimSoft"
        Me.ucrSelectorForClimSoft.Size = New System.Drawing.Size(216, 147)
        Me.ucrSelectorForClimSoft.TabIndex = 2
        '
        'ucrReceiverMultipleElements
        '
        Me.ucrReceiverMultipleElements.AutoSize = True
        Me.ucrReceiverMultipleElements.frmParent = Me
        Me.ucrReceiverMultipleElements.Location = New System.Drawing.Point(259, 234)
        Me.ucrReceiverMultipleElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleElements.Name = "ucrReceiverMultipleElements"
        Me.ucrReceiverMultipleElements.Selector = Nothing
        Me.ucrReceiverMultipleElements.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverMultipleElements.strNcFilePath = ""
        Me.ucrReceiverMultipleElements.TabIndex = 6
        Me.ucrReceiverMultipleElements.ucrSelector = Nothing
        '
        'ucrReceiverMultipleStations
        '
        Me.ucrReceiverMultipleStations.AutoSize = True
        Me.ucrReceiverMultipleStations.frmParent = Me
        Me.ucrReceiverMultipleStations.Location = New System.Drawing.Point(256, 77)
        Me.ucrReceiverMultipleStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleStations.Name = "ucrReceiverMultipleStations"
        Me.ucrReceiverMultipleStations.Selector = Nothing
        Me.ucrReceiverMultipleStations.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverMultipleStations.strNcFilePath = ""
        Me.ucrReceiverMultipleStations.TabIndex = 4
        Me.ucrReceiverMultipleStations.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 402)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 14
        '
        'dlgClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(408, 459)
        Me.Controls.Add(Me.ucrChkUnstackData)
        Me.Controls.Add(Me.ucrChkFlagsData)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.ucrChkElements)
        Me.Controls.Add(Me.ucrComboBoxElements)
        Me.Controls.Add(Me.ucrComboBoxStations)
        Me.Controls.Add(Me.ucrChkDateRange)
        Me.Controls.Add(Me.ucrDtpEndDate)
        Me.Controls.Add(Me.ucrDtpStartdate)
        Me.Controls.Add(Me.ucrChkObservationData)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.ucrSelectorForClimSoft)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.ucrReceiverMultipleElements)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.lblElements)
        Me.Controls.Add(Me.ucrReceiverMultipleStations)
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
    Friend WithEvents ucrReceiverMultipleStations As ucrReceiverMultiple
    Friend WithEvents ucrReceiverMultipleElements As ucrReceiverMultiple
    Friend WithEvents lblStations As Label
    Friend WithEvents lblElements As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents ucrSelectorForClimSoft As ucrSelectorAddRemove
    Friend WithEvents lblEndDate As Label
    Friend WithEvents ttClimsoft As ToolTip
    Friend WithEvents ucrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartdate As ucrDateTimePicker
    Friend WithEvents ucrChkObservationData As ucrCheck
    Friend WithEvents ucrChkDateRange As ucrCheck
    Friend WithEvents ucrComboBoxStations As ucrInputComboBox
    Friend WithEvents ucrComboBoxElements As ucrInputComboBox
    Friend WithEvents ucrChkElements As ucrCheck
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrChkFlagsData As ucrCheck
    Friend WithEvents ucrChkUnstackData As ucrCheck
End Class
