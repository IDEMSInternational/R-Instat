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
        Me.ucrChkStackData = New instat.ucrCheck()
        Me.ucrChkFlagsData = New instat.ucrCheck()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.ucrComboBoxElements = New instat.ucrInputComboBox()
        Me.ucrComboBoxStations = New instat.ucrInputComboBox()
        Me.ucrSelectorForClimSoft = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverStnElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverStations = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrComboBoxObsTable = New instat.ucrInputComboBox()
        Me.lbTable = New System.Windows.Forms.Label()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.rdoStations = New System.Windows.Forms.RadioButton()
        Me.rdoElements = New System.Windows.Forms.RadioButton()
        Me.rdoData = New System.Windows.Forms.RadioButton()
        Me.ucrChkObsEntryDate = New instat.ucrCheck()
        Me.ucrDtpEntryEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpEntryStartdate = New instat.ucrDateTimePicker()
        Me.lblEntryDateTo = New System.Windows.Forms.Label()
        Me.ucrChkObsDate = New instat.ucrCheck()
        Me.ucrDtpObsEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpObStartdate = New instat.ucrDateTimePicker()
        Me.lblObsDateTo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdEstablishConnection
        '
        Me.cmdEstablishConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEstablishConnection.Location = New System.Drawing.Point(8, 43)
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
        Me.lblElements.Location = New System.Drawing.Point(270, 255)
        Me.lblElements.Name = "lblElements"
        Me.lblElements.Size = New System.Drawing.Size(134, 13)
        Me.lblElements.TabIndex = 4
        Me.lblElements.Text = "Selected Station Elements:"
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStations.Location = New System.Drawing.Point(270, 76)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(93, 13)
        Me.lblStations.TabIndex = 2
        Me.lblStations.Text = "Selected Stations:"
        Me.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrChkStackData
        '
        Me.ucrChkStackData.AutoSize = True
        Me.ucrChkStackData.Checked = False
        Me.ucrChkStackData.Location = New System.Drawing.Point(6, 366)
        Me.ucrChkStackData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkStackData.Name = "ucrChkStackData"
        Me.ucrChkStackData.Size = New System.Drawing.Size(180, 23)
        Me.ucrChkStackData.TabIndex = 9
        Me.ttClimsoft.SetToolTip(Me.ucrChkStackData, "Select Observation Data Date Range")
        '
        'ucrChkFlagsData
        '
        Me.ucrChkFlagsData.AutoSize = True
        Me.ucrChkFlagsData.Checked = False
        Me.ucrChkFlagsData.Location = New System.Drawing.Point(6, 391)
        Me.ucrChkFlagsData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkFlagsData.Name = "ucrChkFlagsData"
        Me.ucrChkFlagsData.Size = New System.Drawing.Size(180, 23)
        Me.ucrChkFlagsData.TabIndex = 8
        Me.ttClimsoft.SetToolTip(Me.ucrChkFlagsData, "Select Observation Data Date Range")
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(153, 49)
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
        Me.ucrComboBoxElements.Location = New System.Drawing.Point(273, 271)
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
        Me.ucrComboBoxStations.Location = New System.Drawing.Point(270, 94)
        Me.ucrComboBoxStations.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxStations.Name = "ucrComboBoxStations"
        Me.ucrComboBoxStations.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboBoxStations.TabIndex = 3
        '
        'ucrSelectorForClimSoft
        '
        Me.ucrSelectorForClimSoft.AutoSize = True
        Me.ucrSelectorForClimSoft.bShowHiddenColumns = False
        Me.ucrSelectorForClimSoft.Location = New System.Drawing.Point(5, 113)
        Me.ucrSelectorForClimSoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForClimSoft.Name = "ucrSelectorForClimSoft"
        Me.ucrSelectorForClimSoft.Size = New System.Drawing.Size(216, 147)
        Me.ucrSelectorForClimSoft.TabIndex = 2
        '
        'ucrReceiverStnElements
        '
        Me.ucrReceiverStnElements.AutoSize = True
        Me.ucrReceiverStnElements.frmParent = Me
        Me.ucrReceiverStnElements.Location = New System.Drawing.Point(273, 295)
        Me.ucrReceiverStnElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStnElements.Name = "ucrReceiverStnElements"
        Me.ucrReceiverStnElements.Selector = Nothing
        Me.ucrReceiverStnElements.Size = New System.Drawing.Size(137, 118)
        Me.ucrReceiverStnElements.strNcFilePath = ""
        Me.ucrReceiverStnElements.TabIndex = 6
        Me.ucrReceiverStnElements.ucrSelector = Nothing
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.AutoSize = True
        Me.ucrReceiverStations.frmParent = Me
        Me.ucrReceiverStations.Location = New System.Drawing.Point(270, 118)
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
        Me.ucrBase.Location = New System.Drawing.Point(6, 422)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 14
        '
        'ucrComboBoxObsTable
        '
        Me.ucrComboBoxObsTable.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxObsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxObsTable.GetSetSelectedIndex = -1
        Me.ucrComboBoxObsTable.IsReadOnly = False
        Me.ucrComboBoxObsTable.Location = New System.Drawing.Point(5, 90)
        Me.ucrComboBoxObsTable.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxObsTable.Name = "ucrComboBoxObsTable"
        Me.ucrComboBoxObsTable.Size = New System.Drawing.Size(145, 21)
        Me.ucrComboBoxObsTable.TabIndex = 19
        '
        'lbTable
        '
        Me.lbTable.AutoSize = True
        Me.lbTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbTable.Location = New System.Drawing.Point(3, 74)
        Me.lbTable.Name = "lbTable"
        Me.lbTable.Size = New System.Drawing.Size(127, 13)
        Me.lbTable.TabIndex = 18
        Me.lbTable.Text = "Select Observation Table"
        Me.lbTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(4, 5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(410, 29)
        Me.ucrPnlOptions.TabIndex = 25
        '
        'rdoStations
        '
        Me.rdoStations.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStations.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStations.FlatAppearance.BorderSize = 2
        Me.rdoStations.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStations.Location = New System.Drawing.Point(13, 6)
        Me.rdoStations.Name = "rdoStations"
        Me.rdoStations.Size = New System.Drawing.Size(129, 27)
        Me.rdoStations.TabIndex = 27
        Me.rdoStations.TabStop = True
        Me.rdoStations.Text = "Stations"
        Me.rdoStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStations.UseVisualStyleBackColor = True
        '
        'rdoElements
        '
        Me.rdoElements.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoElements.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoElements.FlatAppearance.BorderSize = 2
        Me.rdoElements.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoElements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoElements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoElements.Location = New System.Drawing.Point(141, 6)
        Me.rdoElements.Name = "rdoElements"
        Me.rdoElements.Size = New System.Drawing.Size(133, 27)
        Me.rdoElements.TabIndex = 26
        Me.rdoElements.TabStop = True
        Me.rdoElements.Text = "Elements"
        Me.rdoElements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoElements.UseVisualStyleBackColor = True
        '
        'rdoData
        '
        Me.rdoData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoData.FlatAppearance.BorderSize = 2
        Me.rdoData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoData.Location = New System.Drawing.Point(273, 6)
        Me.rdoData.Name = "rdoData"
        Me.rdoData.Size = New System.Drawing.Size(133, 27)
        Me.rdoData.TabIndex = 28
        Me.rdoData.TabStop = True
        Me.rdoData.Text = "Observation Data"
        Me.rdoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoData.UseVisualStyleBackColor = True
        '
        'ucrChkObsEntryDate
        '
        Me.ucrChkObsEntryDate.AutoSize = True
        Me.ucrChkObsEntryDate.Checked = False
        Me.ucrChkObsEntryDate.Location = New System.Drawing.Point(8, 310)
        Me.ucrChkObsEntryDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkObsEntryDate.Name = "ucrChkObsEntryDate"
        Me.ucrChkObsEntryDate.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkObsEntryDate.TabIndex = 38
        '
        'ucrDtpEntryEndDate
        '
        Me.ucrDtpEntryEndDate.AutoSize = True
        Me.ucrDtpEntryEndDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 379)
        Me.ucrDtpEntryEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpEntryEndDate.Location = New System.Drawing.Point(148, 335)
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
        Me.ucrDtpEntryStartdate.Location = New System.Drawing.Point(8, 336)
        Me.ucrDtpEntryStartdate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpEntryStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEntryStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEntryStartdate.Name = "ucrDtpEntryStartdate"
        Me.ucrDtpEntryStartdate.Size = New System.Drawing.Size(102, 20)
        Me.ucrDtpEntryStartdate.TabIndex = 39
        '
        'lblEntryDateTo
        '
        Me.lblEntryDateTo.AutoSize = True
        Me.lblEntryDateTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEntryDateTo.Location = New System.Drawing.Point(119, 341)
        Me.lblEntryDateTo.Name = "lblEntryDateTo"
        Me.lblEntryDateTo.Size = New System.Drawing.Size(20, 13)
        Me.lblEntryDateTo.TabIndex = 37
        Me.lblEntryDateTo.Text = "To"
        '
        'ucrChkObsDate
        '
        Me.ucrChkObsDate.AutoSize = True
        Me.ucrChkObsDate.Checked = False
        Me.ucrChkObsDate.Location = New System.Drawing.Point(8, 258)
        Me.ucrChkObsDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkObsDate.Name = "ucrChkObsDate"
        Me.ucrChkObsDate.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkObsDate.TabIndex = 34
        '
        'ucrDtpObsEndDate
        '
        Me.ucrDtpObsEndDate.AutoSize = True
        Me.ucrDtpObsEndDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 379)
        Me.ucrDtpObsEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpObsEndDate.Location = New System.Drawing.Point(148, 282)
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
        Me.ucrDtpObStartdate.Location = New System.Drawing.Point(6, 282)
        Me.ucrDtpObStartdate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpObStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpObStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpObStartdate.Name = "ucrDtpObStartdate"
        Me.ucrDtpObStartdate.Size = New System.Drawing.Size(102, 20)
        Me.ucrDtpObStartdate.TabIndex = 35
        '
        'lblObsDateTo
        '
        Me.lblObsDateTo.AutoSize = True
        Me.lblObsDateTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObsDateTo.Location = New System.Drawing.Point(117, 286)
        Me.lblObsDateTo.Name = "lblObsDateTo"
        Me.lblObsDateTo.Size = New System.Drawing.Size(20, 13)
        Me.lblObsDateTo.TabIndex = 33
        Me.lblObsDateTo.Text = "To"
        '
        'dlgClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 480)
        Me.Controls.Add(Me.ucrChkObsEntryDate)
        Me.Controls.Add(Me.ucrDtpEntryEndDate)
        Me.Controls.Add(Me.ucrDtpEntryStartdate)
        Me.Controls.Add(Me.lblEntryDateTo)
        Me.Controls.Add(Me.ucrChkObsDate)
        Me.Controls.Add(Me.ucrDtpObsEndDate)
        Me.Controls.Add(Me.ucrDtpObStartdate)
        Me.Controls.Add(Me.lblObsDateTo)
        Me.Controls.Add(Me.rdoData)
        Me.Controls.Add(Me.rdoStations)
        Me.Controls.Add(Me.rdoElements)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrComboBoxObsTable)
        Me.Controls.Add(Me.lbTable)
        Me.Controls.Add(Me.ucrChkStackData)
        Me.Controls.Add(Me.ucrChkFlagsData)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.ucrComboBoxElements)
        Me.Controls.Add(Me.ucrComboBoxStations)
        Me.Controls.Add(Me.ucrSelectorForClimSoft)
        Me.Controls.Add(Me.ucrReceiverStnElements)
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
    Friend WithEvents ucrReceiverStnElements As ucrReceiverMultiple
    Friend WithEvents lblStations As Label
    Friend WithEvents lblElements As Label
    Friend WithEvents ucrSelectorForClimSoft As ucrSelectorAddRemove
    Friend WithEvents ttClimsoft As ToolTip
    Friend WithEvents ucrComboBoxStations As ucrInputComboBox
    Friend WithEvents ucrComboBoxElements As ucrInputComboBox
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrChkFlagsData As ucrCheck
    Friend WithEvents ucrChkStackData As ucrCheck
    Friend WithEvents ucrComboBoxObsTable As ucrInputComboBox
    Friend WithEvents lbTable As Label
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoData As RadioButton
    Friend WithEvents rdoStations As RadioButton
    Friend WithEvents rdoElements As RadioButton
    Friend WithEvents ucrChkObsEntryDate As ucrCheck
    Friend WithEvents ucrDtpEntryEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpEntryStartdate As ucrDateTimePicker
    Friend WithEvents lblEntryDateTo As Label
    Friend WithEvents ucrChkObsDate As ucrCheck
    Friend WithEvents ucrDtpObsEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpObStartdate As ucrDateTimePicker
    Friend WithEvents lblObsDateTo As Label
End Class
