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
Partial Class dlgEndRain
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
        Me.nudEarliestDay = New System.Windows.Forms.NumericUpDown()
        Me.nudMaximumCapacity = New System.Windows.Forms.NumericUpDown()
        Me.nudEvaporation = New System.Windows.Forms.NumericUpDown()
        Me.txtEndofRains = New System.Windows.Forms.TextBox()
        Me.txtWaterBalance = New System.Windows.Forms.TextBox()
        Me.lblEarilestDay = New System.Windows.Forms.Label()
        Me.lblMaximumCapacity = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.lblEndofRains = New System.Windows.Forms.Label()
        Me.lblWaterBalance = New System.Windows.Forms.Label()
        Me.chkReplace = New System.Windows.Forms.CheckBox()
        Me.grpColumnName = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudEarliestDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaximumCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEvaporation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpColumnName.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 247)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 57)
        Me.ucrBase.TabIndex = 0
        '
        'nudEarliestDay
        '
        Me.nudEarliestDay.Location = New System.Drawing.Point(163, 33)
        Me.nudEarliestDay.Name = "nudEarliestDay"
        Me.nudEarliestDay.Size = New System.Drawing.Size(59, 20)
        Me.nudEarliestDay.TabIndex = 1
        Me.nudEarliestDay.Tag = "Earliest_Day"
        '
        'nudMaximumCapacity
        '
        Me.nudMaximumCapacity.Location = New System.Drawing.Point(163, 59)
        Me.nudMaximumCapacity.Name = "nudMaximumCapacity"
        Me.nudMaximumCapacity.Size = New System.Drawing.Size(59, 20)
        Me.nudMaximumCapacity.TabIndex = 2
        Me.nudMaximumCapacity.Tag = "Maximum_Capacity"
        '
        'nudEvaporation
        '
        Me.nudEvaporation.Location = New System.Drawing.Point(163, 87)
        Me.nudEvaporation.Name = "nudEvaporation"
        Me.nudEvaporation.Size = New System.Drawing.Size(59, 20)
        Me.nudEvaporation.TabIndex = 3
        Me.nudEvaporation.Tag = "Evaporation"
        '
        'txtEndofRains
        '
        Me.txtEndofRains.Location = New System.Drawing.Point(150, 36)
        Me.txtEndofRains.Name = "txtEndofRains"
        Me.txtEndofRains.Size = New System.Drawing.Size(100, 20)
        Me.txtEndofRains.TabIndex = 4
        Me.txtEndofRains.Tag = "End_of_Rains"
        '
        'txtWaterBalance
        '
        Me.txtWaterBalance.Location = New System.Drawing.Point(150, 78)
        Me.txtWaterBalance.Name = "txtWaterBalance"
        Me.txtWaterBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtWaterBalance.TabIndex = 5
        Me.txtWaterBalance.Tag = "Water_Balance"
        '
        'lblEarilestDay
        '
        Me.lblEarilestDay.AutoSize = True
        Me.lblEarilestDay.Location = New System.Drawing.Point(33, 35)
        Me.lblEarilestDay.Name = "lblEarilestDay"
        Me.lblEarilestDay.Size = New System.Drawing.Size(39, 13)
        Me.lblEarilestDay.TabIndex = 6
        Me.lblEarilestDay.Tag = "Earilest_Day"
        Me.lblEarilestDay.Text = "Label1"
        '
        'lblMaximumCapacity
        '
        Me.lblMaximumCapacity.AutoSize = True
        Me.lblMaximumCapacity.Location = New System.Drawing.Point(33, 61)
        Me.lblMaximumCapacity.Name = "lblMaximumCapacity"
        Me.lblMaximumCapacity.Size = New System.Drawing.Size(39, 13)
        Me.lblMaximumCapacity.TabIndex = 7
        Me.lblMaximumCapacity.Tag = "Maximum_Capacity"
        Me.lblMaximumCapacity.Text = "Label2"
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(33, 87)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(39, 13)
        Me.lblEvaporation.TabIndex = 8
        Me.lblEvaporation.Tag = "Evaporation"
        Me.lblEvaporation.Text = "Label3"
        '
        'lblEndofRains
        '
        Me.lblEndofRains.AutoSize = True
        Me.lblEndofRains.Location = New System.Drawing.Point(20, 39)
        Me.lblEndofRains.Name = "lblEndofRains"
        Me.lblEndofRains.Size = New System.Drawing.Size(68, 13)
        Me.lblEndofRains.TabIndex = 9
        Me.lblEndofRains.Tag = "End_of_Rains"
        Me.lblEndofRains.Text = "End of Rains"
        '
        'lblWaterBalance
        '
        Me.lblWaterBalance.AutoSize = True
        Me.lblWaterBalance.Location = New System.Drawing.Point(20, 84)
        Me.lblWaterBalance.Name = "lblWaterBalance"
        Me.lblWaterBalance.Size = New System.Drawing.Size(78, 13)
        Me.lblWaterBalance.TabIndex = 10
        Me.lblWaterBalance.Tag = "Water_Balance"
        Me.lblWaterBalance.Text = "Water Balance"
        '
        'chkReplace
        '
        Me.chkReplace.AutoSize = True
        Me.chkReplace.Location = New System.Drawing.Point(338, 204)
        Me.chkReplace.Name = "chkReplace"
        Me.chkReplace.Size = New System.Drawing.Size(81, 17)
        Me.chkReplace.TabIndex = 11
        Me.chkReplace.Tag = "Replace"
        Me.chkReplace.Text = "CheckBox1"
        Me.chkReplace.UseVisualStyleBackColor = True
        '
        'grpColumnName
        '
        Me.grpColumnName.Controls.Add(Me.lblEndofRains)
        Me.grpColumnName.Controls.Add(Me.lblWaterBalance)
        Me.grpColumnName.Controls.Add(Me.txtEndofRains)
        Me.grpColumnName.Controls.Add(Me.txtWaterBalance)
        Me.grpColumnName.Location = New System.Drawing.Point(13, 124)
        Me.grpColumnName.Name = "grpColumnName"
        Me.grpColumnName.Size = New System.Drawing.Size(303, 117)
        Me.grpColumnName.TabIndex = 12
        Me.grpColumnName.TabStop = False
        Me.grpColumnName.Tag = "Column_Name"
        Me.grpColumnName.Text = "Column Names"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Data list not implemented"
        '
        'dlgEndRain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 305)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpColumnName)
        Me.Controls.Add(Me.chkReplace)
        Me.Controls.Add(Me.lblEvaporation)
        Me.Controls.Add(Me.lblMaximumCapacity)
        Me.Controls.Add(Me.lblEarilestDay)
        Me.Controls.Add(Me.nudEvaporation)
        Me.Controls.Add(Me.nudMaximumCapacity)
        Me.Controls.Add(Me.nudEarliestDay)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEndRain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "End_Rain"
        Me.Text = "End Rain"
        CType(Me.nudEarliestDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaximumCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEvaporation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpColumnName.ResumeLayout(False)
        Me.grpColumnName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudEarliestDay As NumericUpDown
    Friend WithEvents nudMaximumCapacity As NumericUpDown
    Friend WithEvents nudEvaporation As NumericUpDown
    Friend WithEvents txtEndofRains As TextBox
    Friend WithEvents txtWaterBalance As TextBox
    Friend WithEvents lblEarilestDay As Label
    Friend WithEvents lblMaximumCapacity As Label
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblEndofRains As Label
    Friend WithEvents lblWaterBalance As Label
    Friend WithEvents chkReplace As CheckBox
    Friend WithEvents grpColumnName As GroupBox
    Friend WithEvents Label1 As Label
End Class
