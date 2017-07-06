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
Partial Class dlgDisplayRainRunningTotal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblColunmName = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblDecimalPlaces = New System.Windows.Forms.Label()
        Me.ucrInputColumnName = New instat.ucrInputTextBox()
        Me.ucrInputDisplayDay = New instat.ucrInputTextBox()
        Me.ucrChkRemoveMissingValues = New instat.ucrCheck()
        Me.ucrChkMonthList = New instat.ucrCheck()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.ucrNudTotalDays = New instat.ucrNud()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 191)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data list not implemented"
        '
        'lblColunmName
        '
        Me.lblColunmName.AutoSize = True
        Me.lblColunmName.Location = New System.Drawing.Point(9, 40)
        Me.lblColunmName.Name = "lblColunmName"
        Me.lblColunmName.Size = New System.Drawing.Size(76, 13)
        Me.lblColunmName.TabIndex = 4
        Me.lblColunmName.Tag = "Colunm_Name"
        Me.lblColunmName.Text = "Column Name:"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(9, 63)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(66, 13)
        Me.lblDayDisplay.TabIndex = 5
        Me.lblDayDisplay.Tag = "Display_Day"
        Me.lblDayDisplay.Text = "Display Day:"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(9, 89)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 6
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold:"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Location = New System.Drawing.Point(9, 112)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalDays.TabIndex = 7
        Me.lblTotalDays.Tag = "Total_Days"
        Me.lblTotalDays.Text = "Total Days:"
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(11, 136)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(83, 13)
        Me.lblDecimalPlaces.TabIndex = 8
        Me.lblDecimalPlaces.Tag = "Decimal_Places"
        Me.lblDecimalPlaces.Text = "Decimal Places:"
        '
        'ucrInputColumnName
        '
        Me.ucrInputColumnName.bAddRemoveParameter = True
        Me.ucrInputColumnName.bChangeParameterValue = True
        Me.ucrInputColumnName.IsMultiline = False
        Me.ucrInputColumnName.IsReadOnly = False
        Me.ucrInputColumnName.Location = New System.Drawing.Point(102, 37)
        Me.ucrInputColumnName.Name = "ucrInputColumnName"
        Me.ucrInputColumnName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputColumnName.TabIndex = 14
        '
        'ucrInputDisplayDay
        '
        Me.ucrInputDisplayDay.bAddRemoveParameter = True
        Me.ucrInputDisplayDay.bChangeParameterValue = True
        Me.ucrInputDisplayDay.IsMultiline = False
        Me.ucrInputDisplayDay.IsReadOnly = False
        Me.ucrInputDisplayDay.Location = New System.Drawing.Point(102, 60)
        Me.ucrInputDisplayDay.Name = "ucrInputDisplayDay"
        Me.ucrInputDisplayDay.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputDisplayDay.TabIndex = 14
        '
        'ucrChkRemoveMissingValues
        '
        Me.ucrChkRemoveMissingValues.bAddRemoveParameter = True
        Me.ucrChkRemoveMissingValues.bChangeParameterValue = True
        Me.ucrChkRemoveMissingValues.Checked = False
        Me.ucrChkRemoveMissingValues.Location = New System.Drawing.Point(12, 165)
        Me.ucrChkRemoveMissingValues.Name = "ucrChkRemoveMissingValues"
        Me.ucrChkRemoveMissingValues.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkRemoveMissingValues.TabIndex = 15
        '
        'ucrChkMonthList
        '
        Me.ucrChkMonthList.bAddRemoveParameter = True
        Me.ucrChkMonthList.bChangeParameterValue = True
        Me.ucrChkMonthList.Checked = False
        Me.ucrChkMonthList.Location = New System.Drawing.Point(182, 165)
        Me.ucrChkMonthList.Name = "ucrChkMonthList"
        Me.ucrChkMonthList.Size = New System.Drawing.Size(112, 20)
        Me.ucrChkMonthList.TabIndex = 16
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.bAddRemoveParameter = True
        Me.ucrNudDecimalPlaces.bChangeParameterValue = True
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(102, 134)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(58, 20)
        Me.ucrNudDecimalPlaces.TabIndex = 17
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTotalDays
        '
        Me.ucrNudTotalDays.bAddRemoveParameter = True
        Me.ucrNudTotalDays.bChangeParameterValue = True
        Me.ucrNudTotalDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTotalDays.Location = New System.Drawing.Point(102, 109)
        Me.ucrNudTotalDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTotalDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalDays.Name = "ucrNudTotalDays"
        Me.ucrNudTotalDays.Size = New System.Drawing.Size(58, 20)
        Me.ucrNudTotalDays.TabIndex = 18
        Me.ucrNudTotalDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.bAddRemoveParameter = True
        Me.ucrNudThreshold.bChangeParameterValue = True
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(102, 84)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(58, 20)
        Me.ucrNudThreshold.TabIndex = 19
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgDisplayRainRunningTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 255)
        Me.Controls.Add(Me.ucrNudThreshold)
        Me.Controls.Add(Me.ucrNudTotalDays)
        Me.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.Controls.Add(Me.ucrChkMonthList)
        Me.Controls.Add(Me.ucrChkRemoveMissingValues)
        Me.Controls.Add(Me.ucrInputDisplayDay)
        Me.Controls.Add(Me.ucrInputColumnName)
        Me.Controls.Add(Me.lblDecimalPlaces)
        Me.Controls.Add(Me.lblTotalDays)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblColunmName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayRainRunningTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_Rain_Running_Total"
        Me.Text = "Display Rain Running Total"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblColunmName As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblTotalDays As Label
    Friend WithEvents lblDecimalPlaces As Label
    Friend WithEvents ucrInputColumnName As ucrInputTextBox
    Friend WithEvents ucrInputDisplayDay As ucrInputTextBox
    Friend WithEvents ucrChkRemoveMissingValues As ucrCheck
    Friend WithEvents ucrChkMonthList As ucrCheck
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
    Friend WithEvents ucrNudTotalDays As ucrNud
    Friend WithEvents ucrNudThreshold As ucrNud
End Class
