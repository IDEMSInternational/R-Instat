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
Partial Class dlgExtremeEvents
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
        Me.lblColumnNameExtremeEvent = New System.Windows.Forms.Label()
        Me.lblColumNameEventDay = New System.Windows.Forms.Label()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkExtremeMax = New System.Windows.Forms.CheckBox()
        Me.chkExtremeMin = New System.Windows.Forms.CheckBox()
        Me.nudTotalDays = New System.Windows.Forms.NumericUpDown()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.nudEndDay = New System.Windows.Forms.NumericUpDown()
        Me.nudStartDay = New System.Windows.Forms.NumericUpDown()
        Me.lblStartDay = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblEndDay = New System.Windows.Forms.Label()
        Me.chkThresholdValue = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputColumnNameExtremeEvents = New instat.ucrInputTextBox()
        Me.ucrInputColumnNameEventDay = New instat.ucrInputTextBox()
        CType(Me.nudTotalDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEndDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblColumnNameExtremeEvent
        '
        Me.lblColumnNameExtremeEvent.AutoSize = True
        Me.lblColumnNameExtremeEvent.Location = New System.Drawing.Point(12, 18)
        Me.lblColumnNameExtremeEvent.Name = "lblColumnNameExtremeEvent"
        Me.lblColumnNameExtremeEvent.Size = New System.Drawing.Size(145, 13)
        Me.lblColumnNameExtremeEvent.TabIndex = 2
        Me.lblColumnNameExtremeEvent.Tag = "Column_Name_Extreme_Event"
        Me.lblColumnNameExtremeEvent.Text = "Column Name Extreme Event"
        '
        'lblColumNameEventDay
        '
        Me.lblColumNameEventDay.AutoSize = True
        Me.lblColumNameEventDay.Location = New System.Drawing.Point(12, 45)
        Me.lblColumNameEventDay.Name = "lblColumNameEventDay"
        Me.lblColumNameEventDay.Size = New System.Drawing.Size(126, 13)
        Me.lblColumNameEventDay.TabIndex = 3
        Me.lblColumNameEventDay.Tag = "Column_Name_Event_Day"
        Me.lblColumNameEventDay.Text = "Column Name Event Day"
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(12, 123)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(139, 17)
        Me.chkRemoveNA.TabIndex = 10
        Me.chkRemoveNA.Tag = "Remove_Missing_Values"
        Me.chkRemoveNA.Text = "Remove Missing Values"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkExtremeMax
        '
        Me.chkExtremeMax.AutoSize = True
        Me.chkExtremeMax.Location = New System.Drawing.Point(12, 100)
        Me.chkExtremeMax.Name = "chkExtremeMax"
        Me.chkExtremeMax.Size = New System.Drawing.Size(111, 17)
        Me.chkExtremeMax.TabIndex = 11
        Me.chkExtremeMax.Tag = "Extreme_Maximum"
        Me.chkExtremeMax.Text = "Extreme Maximum"
        Me.chkExtremeMax.UseVisualStyleBackColor = True
        '
        'chkExtremeMin
        '
        Me.chkExtremeMin.AutoSize = True
        Me.chkExtremeMin.Location = New System.Drawing.Point(130, 100)
        Me.chkExtremeMin.Name = "chkExtremeMin"
        Me.chkExtremeMin.Size = New System.Drawing.Size(108, 17)
        Me.chkExtremeMin.TabIndex = 12
        Me.chkExtremeMin.Tag = "Extreme_Minimum"
        Me.chkExtremeMin.Text = "Extreme Minimum"
        Me.chkExtremeMin.UseVisualStyleBackColor = True
        '
        'nudTotalDays
        '
        Me.nudTotalDays.Location = New System.Drawing.Point(348, 69)
        Me.nudTotalDays.Name = "nudTotalDays"
        Me.nudTotalDays.Size = New System.Drawing.Size(55, 20)
        Me.nudTotalDays.TabIndex = 5
        Me.nudTotalDays.Tag = "Total_Days"
        '
        'nudThreshold
        '
        Me.nudThreshold.Location = New System.Drawing.Point(259, 120)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(55, 20)
        Me.nudThreshold.TabIndex = 7
        Me.nudThreshold.Tag = "Threshold"
        '
        'nudEndDay
        '
        Me.nudEndDay.Location = New System.Drawing.Point(223, 69)
        Me.nudEndDay.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudEndDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEndDay.Name = "nudEndDay"
        Me.nudEndDay.Size = New System.Drawing.Size(55, 20)
        Me.nudEndDay.TabIndex = 8
        Me.nudEndDay.Tag = "End_Day"
        Me.nudEndDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStartDay
        '
        Me.nudStartDay.Location = New System.Drawing.Point(83, 69)
        Me.nudStartDay.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudStartDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStartDay.Name = "nudStartDay"
        Me.nudStartDay.Size = New System.Drawing.Size(55, 20)
        Me.nudStartDay.TabIndex = 9
        Me.nudStartDay.Tag = "Start_Day"
        Me.nudStartDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStartDay
        '
        Me.lblStartDay.AutoSize = True
        Me.lblStartDay.Location = New System.Drawing.Point(12, 76)
        Me.lblStartDay.Name = "lblStartDay"
        Me.lblStartDay.Size = New System.Drawing.Size(51, 13)
        Me.lblStartDay.TabIndex = 14
        Me.lblStartDay.Tag = "Start_Day"
        Me.lblStartDay.Text = "Start Day"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Location = New System.Drawing.Point(284, 76)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalDays.TabIndex = 15
        Me.lblTotalDays.Tag = "Total_Days"
        Me.lblTotalDays.Text = "Total Days"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(177, 313)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(0, 13)
        Me.lblThreshold.TabIndex = 16
        Me.lblThreshold.Tag = "Threshold"
        '
        'lblEndDay
        '
        Me.lblEndDay.AutoSize = True
        Me.lblEndDay.Location = New System.Drawing.Point(160, 76)
        Me.lblEndDay.Name = "lblEndDay"
        Me.lblEndDay.Size = New System.Drawing.Size(48, 13)
        Me.lblEndDay.TabIndex = 17
        Me.lblEndDay.Tag = "End_Day"
        Me.lblEndDay.Text = "End Day"
        '
        'chkThresholdValue
        '
        Me.chkThresholdValue.AutoSize = True
        Me.chkThresholdValue.Location = New System.Drawing.Point(180, 123)
        Me.chkThresholdValue.Name = "chkThresholdValue"
        Me.chkThresholdValue.Size = New System.Drawing.Size(73, 17)
        Me.chkThresholdValue.TabIndex = 19
        Me.chkThresholdValue.Tag = "Threshold"
        Me.chkThresholdValue.Text = "Threshold"
        Me.chkThresholdValue.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 146)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 4
        '
        'ucrInputColumnNameExtremeEvents
        '
        Me.ucrInputColumnNameExtremeEvents.Location = New System.Drawing.Point(183, 10)
        Me.ucrInputColumnNameExtremeEvents.Name = "ucrInputColumnNameExtremeEvents"
        Me.ucrInputColumnNameExtremeEvents.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputColumnNameExtremeEvents.TabIndex = 20
        '
        'ucrInputColumnNameEventDay
        '
        Me.ucrInputColumnNameEventDay.Location = New System.Drawing.Point(180, 37)
        Me.ucrInputColumnNameEventDay.Name = "ucrInputColumnNameEventDay"
        Me.ucrInputColumnNameEventDay.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputColumnNameEventDay.TabIndex = 20
        '
        'dlgExtremeEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 213)
        Me.Controls.Add(Me.ucrInputColumnNameEventDay)
        Me.Controls.Add(Me.ucrInputColumnNameExtremeEvents)
        Me.Controls.Add(Me.chkThresholdValue)
        Me.Controls.Add(Me.lblEndDay)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblTotalDays)
        Me.Controls.Add(Me.lblStartDay)
        Me.Controls.Add(Me.chkExtremeMin)
        Me.Controls.Add(Me.chkExtremeMax)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.nudStartDay)
        Me.Controls.Add(Me.nudEndDay)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.nudTotalDays)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblColumNameEventDay)
        Me.Controls.Add(Me.lblColumnNameExtremeEvent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremeEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Extreme_Events"
        Me.Text = "Extreme Events"
        CType(Me.nudTotalDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEndDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColumnNameExtremeEvent As Label
    Friend WithEvents lblColumNameEventDay As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkExtremeMax As CheckBox
    Friend WithEvents chkExtremeMin As CheckBox
    Friend WithEvents nudTotalDays As NumericUpDown
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents nudEndDay As NumericUpDown
    Friend WithEvents nudStartDay As NumericUpDown
    Friend WithEvents lblStartDay As Label
    Friend WithEvents lblTotalDays As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblEndDay As Label
    Friend WithEvents chkThresholdValue As CheckBox
    Friend WithEvents ucrInputColumnNameExtremeEvents As ucrInputTextBox
    Friend WithEvents ucrInputColumnNameEventDay As ucrInputTextBox
End Class