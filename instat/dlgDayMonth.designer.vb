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
Partial Class dlgDayMonth
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.lblTimePeriod = New System.Windows.Forms.Label()
        Me.lblRequiredTimeFormat = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputColumnName1 = New instat.ucrInputTextBox()
        Me.ucrInputTimePeriod = New instat.ucrInputTextBox()
        Me.ucrInputRequiredTimeFormat = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Not Implemented"
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(40, 75)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(73, 13)
        Me.lblColumnName.TabIndex = 5
        Me.lblColumnName.Tag = "Column_Name"
        Me.lblColumnName.Text = "Column Name"
        '
        'lblTimePeriod
        '
        Me.lblTimePeriod.AutoSize = True
        Me.lblTimePeriod.Location = New System.Drawing.Point(40, 102)
        Me.lblTimePeriod.Name = "lblTimePeriod"
        Me.lblTimePeriod.Size = New System.Drawing.Size(63, 13)
        Me.lblTimePeriod.TabIndex = 6
        Me.lblTimePeriod.Tag = "Time_Period"
        Me.lblTimePeriod.Text = "Time Period"
        '
        'lblRequiredTimeFormat
        '
        Me.lblRequiredTimeFormat.AutoSize = True
        Me.lblRequiredTimeFormat.Location = New System.Drawing.Point(40, 129)
        Me.lblRequiredTimeFormat.Name = "lblRequiredTimeFormat"
        Me.lblRequiredTimeFormat.Size = New System.Drawing.Size(111, 13)
        Me.lblRequiredTimeFormat.TabIndex = 7
        Me.lblRequiredTimeFormat.Tag = "Required_Time_Format"
        Me.lblRequiredTimeFormat.Text = "Required Time Format"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 148)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputColumnName1
        '
        Me.ucrInputColumnName1.AddQuotesIfUnrecognised = True
        Me.ucrInputColumnName1.AutoSize = True
        Me.ucrInputColumnName1.IsMultiline = False
        Me.ucrInputColumnName1.IsReadOnly = False
        Me.ucrInputColumnName1.Location = New System.Drawing.Point(161, 67)
        Me.ucrInputColumnName1.Name = "ucrInputColumnName1"
        Me.ucrInputColumnName1.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputColumnName1.TabIndex = 8
        '
        'ucrInputTimePeriod
        '
        Me.ucrInputTimePeriod.AddQuotesIfUnrecognised = True
        Me.ucrInputTimePeriod.AutoSize = True
        Me.ucrInputTimePeriod.IsMultiline = False
        Me.ucrInputTimePeriod.IsReadOnly = False
        Me.ucrInputTimePeriod.Location = New System.Drawing.Point(161, 94)
        Me.ucrInputTimePeriod.Name = "ucrInputTimePeriod"
        Me.ucrInputTimePeriod.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputTimePeriod.TabIndex = 9
        '
        'ucrInputRequiredTimeFormat
        '
        Me.ucrInputRequiredTimeFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputRequiredTimeFormat.AutoSize = True
        Me.ucrInputRequiredTimeFormat.IsMultiline = False
        Me.ucrInputRequiredTimeFormat.IsReadOnly = False
        Me.ucrInputRequiredTimeFormat.Location = New System.Drawing.Point(161, 121)
        Me.ucrInputRequiredTimeFormat.Name = "ucrInputRequiredTimeFormat"
        Me.ucrInputRequiredTimeFormat.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputRequiredTimeFormat.TabIndex = 10
        '
        'dlgDayMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(441, 211)
        Me.Controls.Add(Me.ucrInputRequiredTimeFormat)
        Me.Controls.Add(Me.ucrInputTimePeriod)
        Me.Controls.Add(Me.ucrInputColumnName1)
        Me.Controls.Add(Me.lblRequiredTimeFormat)
        Me.Controls.Add(Me.lblTimePeriod)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDayMonth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Day_Month"
        Me.Text = "Day Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblColumnName As Label
    Friend WithEvents lblTimePeriod As Label
    Friend WithEvents lblRequiredTimeFormat As Label
    Friend WithEvents ucrInputColumnName1 As ucrInputTextBox
    Friend WithEvents ucrInputTimePeriod As ucrInputTextBox
    Friend WithEvents ucrInputRequiredTimeFormat As ucrInputTextBox
End Class
