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
Partial Class dlgDisplaySpellLength
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
        Me.lblColunmName = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.ucrInputColumnName = New instat.ucrInputTextBox()
        Me.ucrInputDisplayDay = New instat.ucrInputTextBox()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.ucrChkMonthAbbreviations = New instat.ucrCheck()
        Me.ucrChkRemoveMissingValues = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 144)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 0
        '
        'lblColunmName
        '
        Me.lblColunmName.AutoSize = True
        Me.lblColunmName.Location = New System.Drawing.Point(9, 20)
        Me.lblColunmName.Name = "lblColunmName"
        Me.lblColunmName.Size = New System.Drawing.Size(76, 13)
        Me.lblColunmName.TabIndex = 6
        Me.lblColunmName.Tag = "Colunm_Name"
        Me.lblColunmName.Text = "Column Name:"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(9, 47)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(66, 13)
        Me.lblDayDisplay.TabIndex = 7
        Me.lblDayDisplay.Tag = "Day_Display"
        Me.lblDayDisplay.Text = "Display Day:"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(9, 70)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 8
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold:"
        '
        'ucrInputColumnName
        '
        Me.ucrInputColumnName.bAddRemoveParameter = True
        Me.ucrInputColumnName.bChangeParameterValue = True
        Me.ucrInputColumnName.IsMultiline = False
        Me.ucrInputColumnName.IsReadOnly = False
        Me.ucrInputColumnName.Location = New System.Drawing.Point(89, 17)
        Me.ucrInputColumnName.Name = "ucrInputColumnName"
        Me.ucrInputColumnName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputColumnName.TabIndex = 10
        '
        'ucrInputDisplayDay
        '
        Me.ucrInputDisplayDay.bAddRemoveParameter = True
        Me.ucrInputDisplayDay.bChangeParameterValue = True
        Me.ucrInputDisplayDay.IsMultiline = False
        Me.ucrInputDisplayDay.IsReadOnly = False
        Me.ucrInputDisplayDay.Location = New System.Drawing.Point(89, 43)
        Me.ucrInputDisplayDay.Name = "ucrInputDisplayDay"
        Me.ucrInputDisplayDay.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputDisplayDay.TabIndex = 11
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.bAddRemoveParameter = True
        Me.ucrNudThreshold.bChangeParameterValue = True
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(89, 68)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreshold.TabIndex = 12
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMonthAbbreviations
        '
        Me.ucrChkMonthAbbreviations.bAddRemoveParameter = True
        Me.ucrChkMonthAbbreviations.bChangeParameterValue = True
        Me.ucrChkMonthAbbreviations.Checked = False
        Me.ucrChkMonthAbbreviations.Location = New System.Drawing.Point(9, 92)
        Me.ucrChkMonthAbbreviations.Name = "ucrChkMonthAbbreviations"
        Me.ucrChkMonthAbbreviations.Size = New System.Drawing.Size(178, 20)
        Me.ucrChkMonthAbbreviations.TabIndex = 13
        '
        'ucrChkRemoveMissingValues
        '
        Me.ucrChkRemoveMissingValues.bAddRemoveParameter = True
        Me.ucrChkRemoveMissingValues.bChangeParameterValue = True
        Me.ucrChkRemoveMissingValues.Checked = False
        Me.ucrChkRemoveMissingValues.Location = New System.Drawing.Point(9, 118)
        Me.ucrChkRemoveMissingValues.Name = "ucrChkRemoveMissingValues"
        Me.ucrChkRemoveMissingValues.Size = New System.Drawing.Size(178, 20)
        Me.ucrChkRemoveMissingValues.TabIndex = 14
        '
        'dlgDisplaySpellLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 202)
        Me.Controls.Add(Me.ucrChkRemoveMissingValues)
        Me.Controls.Add(Me.ucrChkMonthAbbreviations)
        Me.Controls.Add(Me.ucrNudThreshold)
        Me.Controls.Add(Me.ucrInputDisplayDay)
        Me.Controls.Add(Me.ucrInputColumnName)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblColunmName)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplaySpellLength"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_Spell_Length"
        Me.Text = "Display Spell Length"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblColunmName As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents ucrInputColumnName As ucrInputTextBox
    Friend WithEvents ucrInputDisplayDay As ucrInputTextBox
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents ucrChkMonthAbbreviations As ucrCheck
    Friend WithEvents ucrChkRemoveMissingValues As ucrCheck
End Class
