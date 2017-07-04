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
Partial Class dlgDisplayDailyDataRain
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
        Me.ucrBase = New instat.ucrButtons()
        Me.txtSumLabel = New System.Windows.Forms.TextBox()
        Me.txtMaxLabel = New System.Windows.Forms.TextBox()
        Me.lblMaxLabel = New System.Windows.Forms.Label()
        Me.lblSumLabel = New System.Windows.Forms.Label()
        Me.chkMonthAbbreviation = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMonth_Summaries = New System.Windows.Forms.Label()
        Me.lblSummaryNames = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblDecimalPlaces = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.txtMonthSummaries = New System.Windows.Forms.TextBox()
        Me.txtVariable = New System.Windows.Forms.TextBox()
        Me.txtDayDisplay = New System.Windows.Forms.TextBox()
        Me.txtSummaryNames = New System.Windows.Forms.TextBox()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.nudDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkPrintTables = New System.Windows.Forms.CheckBox()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(56, 330)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'txtSumLabel
        '
        Me.txtSumLabel.Location = New System.Drawing.Point(433, 35)
        Me.txtSumLabel.Name = "txtSumLabel"
        Me.txtSumLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtSumLabel.TabIndex = 114
        '
        'txtMaxLabel
        '
        Me.txtMaxLabel.Location = New System.Drawing.Point(433, 68)
        Me.txtMaxLabel.Name = "txtMaxLabel"
        Me.txtMaxLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxLabel.TabIndex = 113
        '
        'lblMaxLabel
        '
        Me.lblMaxLabel.AutoSize = True
        Me.lblMaxLabel.Location = New System.Drawing.Point(339, 75)
        Me.lblMaxLabel.Name = "lblMaxLabel"
        Me.lblMaxLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblMaxLabel.TabIndex = 112
        Me.lblMaxLabel.Tag = "Max_Label"
        Me.lblMaxLabel.Text = "Label2"
        '
        'lblSumLabel
        '
        Me.lblSumLabel.AutoSize = True
        Me.lblSumLabel.Location = New System.Drawing.Point(339, 34)
        Me.lblSumLabel.Name = "lblSumLabel"
        Me.lblSumLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblSumLabel.TabIndex = 111
        Me.lblSumLabel.Tag = "Sum_Label"
        Me.lblSumLabel.Text = "Label1"
        '
        'chkMonthAbbreviation
        '
        Me.chkMonthAbbreviation.AutoSize = True
        Me.chkMonthAbbreviation.Location = New System.Drawing.Point(56, 246)
        Me.chkMonthAbbreviation.Name = "chkMonthAbbreviation"
        Me.chkMonthAbbreviation.Size = New System.Drawing.Size(81, 17)
        Me.chkMonthAbbreviation.TabIndex = 110
        Me.chkMonthAbbreviation.Tag = "Month_Abbreviation"
        Me.chkMonthAbbreviation.Text = "CheckBox1"
        Me.chkMonthAbbreviation.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Not implememted"
        '
        'lblMonth_Summaries
        '
        Me.lblMonth_Summaries.AutoSize = True
        Me.lblMonth_Summaries.Location = New System.Drawing.Point(50, 38)
        Me.lblMonth_Summaries.Name = "lblMonth_Summaries"
        Me.lblMonth_Summaries.Size = New System.Drawing.Size(39, 13)
        Me.lblMonth_Summaries.TabIndex = 108
        Me.lblMonth_Summaries.Tag = "Month_Summaries"
        Me.lblMonth_Summaries.Text = "Label7"
        '
        'lblSummaryNames
        '
        Me.lblSummaryNames.AutoSize = True
        Me.lblSummaryNames.Location = New System.Drawing.Point(50, 196)
        Me.lblSummaryNames.Name = "lblSummaryNames"
        Me.lblSummaryNames.Size = New System.Drawing.Size(39, 13)
        Me.lblSummaryNames.TabIndex = 107
        Me.lblSummaryNames.Tag = "Summary_Names"
        Me.lblSummaryNames.Text = "Label5"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(49, 158)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold.TabIndex = 106
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label4"
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(339, 158)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(39, 13)
        Me.lblDecimalPlaces.TabIndex = 105
        Me.lblDecimalPlaces.Tag = "Decimal_Places"
        Me.lblDecimalPlaces.Text = "Label3"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(50, 104)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblDayDisplay.TabIndex = 104
        Me.lblDayDisplay.Tag = "Day_Display"
        Me.lblDayDisplay.Text = "Label2"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(49, 68)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(39, 13)
        Me.lblVariable.TabIndex = 103
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Label1"
        '
        'txtMonthSummaries
        '
        Me.txtMonthSummaries.Location = New System.Drawing.Point(157, 31)
        Me.txtMonthSummaries.Name = "txtMonthSummaries"
        Me.txtMonthSummaries.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthSummaries.TabIndex = 102
        Me.txtMonthSummaries.Tag = ""
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(157, 68)
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtVariable.TabIndex = 101
        '
        'txtDayDisplay
        '
        Me.txtDayDisplay.Location = New System.Drawing.Point(157, 97)
        Me.txtDayDisplay.Name = "txtDayDisplay"
        Me.txtDayDisplay.Size = New System.Drawing.Size(100, 20)
        Me.txtDayDisplay.TabIndex = 100
        Me.txtDayDisplay.Tag = ""
        '
        'txtSummaryNames
        '
        Me.txtSummaryNames.Location = New System.Drawing.Point(157, 193)
        Me.txtSummaryNames.Name = "txtSummaryNames"
        Me.txtSummaryNames.Size = New System.Drawing.Size(100, 20)
        Me.txtSummaryNames.TabIndex = 99
        '
        'nudThreshold
        '
        Me.nudThreshold.Location = New System.Drawing.Point(157, 153)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(76, 20)
        Me.nudThreshold.TabIndex = 98
        '
        'nudDecimalPlaces
        '
        Me.nudDecimalPlaces.Location = New System.Drawing.Point(433, 153)
        Me.nudDecimalPlaces.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudDecimalPlaces.Name = "nudDecimalPlaces"
        Me.nudDecimalPlaces.Size = New System.Drawing.Size(67, 20)
        Me.nudDecimalPlaces.TabIndex = 97
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(372, 246)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 96
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox2"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkPrintTables
        '
        Me.chkPrintTables.AutoSize = True
        Me.chkPrintTables.Location = New System.Drawing.Point(220, 246)
        Me.chkPrintTables.Name = "chkPrintTables"
        Me.chkPrintTables.Size = New System.Drawing.Size(81, 17)
        Me.chkPrintTables.TabIndex = 95
        Me.chkPrintTables.Tag = "Print_Tables"
        Me.chkPrintTables.Text = "CheckBox1"
        Me.chkPrintTables.UseVisualStyleBackColor = True
        '
        'dlgDisplayDailyDataRain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 394)
        Me.Controls.Add(Me.txtSumLabel)
        Me.Controls.Add(Me.txtMaxLabel)
        Me.Controls.Add(Me.lblMaxLabel)
        Me.Controls.Add(Me.lblSumLabel)
        Me.Controls.Add(Me.chkMonthAbbreviation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMonth_Summaries)
        Me.Controls.Add(Me.lblSummaryNames)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDecimalPlaces)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.txtMonthSummaries)
        Me.Controls.Add(Me.txtVariable)
        Me.Controls.Add(Me.txtDayDisplay)
        Me.Controls.Add(Me.txtSummaryNames)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.nudDecimalPlaces)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkPrintTables)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDailyDataRain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_Daily_Data_Rain"
        Me.Text = "dlgDisplayDailyDataRain"
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtSumLabel As TextBox
    Friend WithEvents txtMaxLabel As TextBox
    Friend WithEvents lblMaxLabel As Label
    Friend WithEvents lblSumLabel As Label
    Friend WithEvents chkMonthAbbreviation As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMonth_Summaries As Label
    Friend WithEvents lblSummaryNames As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblDecimalPlaces As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents txtMonthSummaries As TextBox
    Friend WithEvents txtVariable As TextBox
    Friend WithEvents txtDayDisplay As TextBox
    Friend WithEvents txtSummaryNames As TextBox
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents nudDecimalPlaces As NumericUpDown
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkPrintTables As CheckBox
End Class
