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
Partial Class dlgDisplayDaily
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
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblDecimalPlaces = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblSummaryNames = New System.Windows.Forms.Label()
        Me.lblMonth_Summaries = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputMonthSummaries = New instat.ucrInputTextBox()
        Me.ucrInputVariable = New instat.ucrInputTextBox()
        Me.ucrInputDayDisplay = New instat.ucrInputTextBox()
        Me.ucrInputSummaryNames = New instat.ucrInputTextBox()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.ucrChkMonthAbbreviation = New instat.ucrCheck()
        Me.ucrChkPrintTables = New instat.ucrCheck()
        Me.ucrChkRemoveMissingValues = New instat.ucrCheck()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(7, 58)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(48, 13)
        Me.lblVariable.TabIndex = 2
        Me.lblVariable.Tag = "Variable:"
        Me.lblVariable.Text = "Variable:"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(7, 85)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(66, 13)
        Me.lblDayDisplay.TabIndex = 4
        Me.lblDayDisplay.Tag = "Day_Display:"
        Me.lblDayDisplay.Text = "Day Display:"
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(237, 112)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(83, 13)
        Me.lblDecimalPlaces.TabIndex = 8
        Me.lblDecimalPlaces.Tag = "Decimal_Places:"
        Me.lblDecimalPlaces.Text = "Decimal Places:"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(7, 112)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 6
        Me.lblThreshold.Tag = "Threshold:"
        Me.lblThreshold.Text = "Threshold:"
        '
        'lblSummaryNames
        '
        Me.lblSummaryNames.AutoSize = True
        Me.lblSummaryNames.Location = New System.Drawing.Point(7, 139)
        Me.lblSummaryNames.Name = "lblSummaryNames"
        Me.lblSummaryNames.Size = New System.Drawing.Size(89, 13)
        Me.lblSummaryNames.TabIndex = 10
        Me.lblSummaryNames.Tag = "Summary_Names:"
        Me.lblSummaryNames.Text = "Summary Names:"
        '
        'lblMonth_Summaries
        '
        Me.lblMonth_Summaries.AutoSize = True
        Me.lblMonth_Summaries.Location = New System.Drawing.Point(7, 31)
        Me.lblMonth_Summaries.Name = "lblMonth_Summaries"
        Me.lblMonth_Summaries.Size = New System.Drawing.Size(94, 13)
        Me.lblMonth_Summaries.TabIndex = 0
        Me.lblMonth_Summaries.Tag = "Month_Summaries:"
        Me.lblMonth_Summaries.Text = "Month Summaries:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 238)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 15
        '
        'ucrInputMonthSummaries
        '
        Me.ucrInputMonthSummaries.bAddRemoveParameter = True
        Me.ucrInputMonthSummaries.bChangeParameterValue = True
        Me.ucrInputMonthSummaries.IsMultiline = False
        Me.ucrInputMonthSummaries.IsReadOnly = False
        Me.ucrInputMonthSummaries.Location = New System.Drawing.Point(116, 28)
        Me.ucrInputMonthSummaries.Name = "ucrInputMonthSummaries"
        Me.ucrInputMonthSummaries.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputMonthSummaries.TabIndex = 1
        '
        'ucrInputVariable
        '
        Me.ucrInputVariable.bAddRemoveParameter = True
        Me.ucrInputVariable.bChangeParameterValue = True
        Me.ucrInputVariable.IsMultiline = False
        Me.ucrInputVariable.IsReadOnly = False
        Me.ucrInputVariable.Location = New System.Drawing.Point(116, 55)
        Me.ucrInputVariable.Name = "ucrInputVariable"
        Me.ucrInputVariable.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputVariable.TabIndex = 3
        '
        'ucrInputDayDisplay
        '
        Me.ucrInputDayDisplay.bAddRemoveParameter = True
        Me.ucrInputDayDisplay.bChangeParameterValue = True
        Me.ucrInputDayDisplay.IsMultiline = False
        Me.ucrInputDayDisplay.IsReadOnly = False
        Me.ucrInputDayDisplay.Location = New System.Drawing.Point(116, 82)
        Me.ucrInputDayDisplay.Name = "ucrInputDayDisplay"
        Me.ucrInputDayDisplay.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputDayDisplay.TabIndex = 5
        '
        'ucrInputSummaryNames
        '
        Me.ucrInputSummaryNames.bAddRemoveParameter = True
        Me.ucrInputSummaryNames.bChangeParameterValue = True
        Me.ucrInputSummaryNames.IsMultiline = False
        Me.ucrInputSummaryNames.IsReadOnly = False
        Me.ucrInputSummaryNames.Location = New System.Drawing.Point(116, 136)
        Me.ucrInputSummaryNames.Name = "ucrInputSummaryNames"
        Me.ucrInputSummaryNames.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputSummaryNames.TabIndex = 11
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcrDialogDisabled1.Location = New System.Drawing.Point(102, 112)
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        Me.UcrDialogDisabled1.Size = New System.Drawing.Size(251, 78)
        Me.UcrDialogDisabled1.TabIndex = 16
        '
        'ucrChkMonthAbbreviation
        '
        Me.ucrChkMonthAbbreviation.bAddRemoveParameter = True
        Me.ucrChkMonthAbbreviation.bChangeParameterValue = True
        Me.ucrChkMonthAbbreviation.Checked = False
        Me.ucrChkMonthAbbreviation.Location = New System.Drawing.Point(10, 160)
        Me.ucrChkMonthAbbreviation.Name = "ucrChkMonthAbbreviation"
        Me.ucrChkMonthAbbreviation.Size = New System.Drawing.Size(150, 20)
        Me.ucrChkMonthAbbreviation.TabIndex = 12
        '
        'ucrChkPrintTables
        '
        Me.ucrChkPrintTables.bAddRemoveParameter = True
        Me.ucrChkPrintTables.bChangeParameterValue = True
        Me.ucrChkPrintTables.Checked = False
        Me.ucrChkPrintTables.Location = New System.Drawing.Point(10, 186)
        Me.ucrChkPrintTables.Name = "ucrChkPrintTables"
        Me.ucrChkPrintTables.Size = New System.Drawing.Size(129, 20)
        Me.ucrChkPrintTables.TabIndex = 13
        '
        'ucrChkRemoveMissingValues
        '
        Me.ucrChkRemoveMissingValues.bAddRemoveParameter = True
        Me.ucrChkRemoveMissingValues.bChangeParameterValue = True
        Me.ucrChkRemoveMissingValues.Checked = False
        Me.ucrChkRemoveMissingValues.Location = New System.Drawing.Point(10, 212)
        Me.ucrChkRemoveMissingValues.Name = "ucrChkRemoveMissingValues"
        Me.ucrChkRemoveMissingValues.Size = New System.Drawing.Size(185, 20)
        Me.ucrChkRemoveMissingValues.TabIndex = 14
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.bAddRemoveParameter = True
        Me.ucrNudThreshold.bChangeParameterValue = True
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(116, 109)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreshold.TabIndex = 7
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.bAddRemoveParameter = True
        Me.ucrNudDecimalPlaces.bChangeParameterValue = True
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(326, 109)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimalPlaces.TabIndex = 9
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgDisplayDaily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 295)
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.Controls.Add(Me.ucrNudThreshold)
        Me.Controls.Add(Me.ucrChkRemoveMissingValues)
        Me.Controls.Add(Me.ucrChkPrintTables)
        Me.Controls.Add(Me.ucrChkMonthAbbreviation)
        Me.Controls.Add(Me.ucrInputSummaryNames)
        Me.Controls.Add(Me.ucrInputDayDisplay)
        Me.Controls.Add(Me.ucrInputVariable)
        Me.Controls.Add(Me.ucrInputMonthSummaries)
        Me.Controls.Add(Me.lblMonth_Summaries)
        Me.Controls.Add(Me.lblSummaryNames)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDecimalPlaces)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDaily"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_Daily"
        Me.Text = "Display Daily"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblDecimalPlaces As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblSummaryNames As Label
    Friend WithEvents lblMonth_Summaries As Label
    Friend WithEvents ucrInputMonthSummaries As ucrInputTextBox
    Friend WithEvents ucrInputVariable As ucrInputTextBox
    Friend WithEvents ucrInputDayDisplay As ucrInputTextBox
    Friend WithEvents ucrInputSummaryNames As ucrInputTextBox
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
    Friend WithEvents ucrChkMonthAbbreviation As ucrCheck
    Friend WithEvents ucrChkPrintTables As ucrCheck
    Friend WithEvents ucrChkRemoveMissingValues As ucrCheck
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
End Class
