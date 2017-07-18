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
Partial Class dlgEndofRains
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
        Me.nudCapacityMax = New System.Windows.Forms.NumericUpDown()
        Me.nudEarliest = New System.Windows.Forms.NumericUpDown()
        Me.txtColumnName = New System.Windows.Forms.TextBox()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.lblCapacityMax = New System.Windows.Forms.Label()
        Me.nudEvaporation = New System.Windows.Forms.NumericUpDown()
        Me.lblEarliest = New System.Windows.Forms.Label()
        Me.lblDataList = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.txtWaterBalanceColumnName = New System.Windows.Forms.TextBox()
        Me.IbIWaterBalanceColumnName = New System.Windows.Forms.Label()
        CType(Me.nudCapacityMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEarliest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEvaporation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudCapacityMax
        '
        Me.nudCapacityMax.DecimalPlaces = 2
        Me.nudCapacityMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudCapacityMax.Location = New System.Drawing.Point(187, 79)
        Me.nudCapacityMax.Name = "nudCapacityMax"
        Me.nudCapacityMax.Size = New System.Drawing.Size(53, 20)
        Me.nudCapacityMax.TabIndex = 37
        Me.nudCapacityMax.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudEarliest
        '
        Me.nudEarliest.Location = New System.Drawing.Point(187, 58)
        Me.nudEarliest.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudEarliest.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEarliest.Name = "nudEarliest"
        Me.nudEarliest.Size = New System.Drawing.Size(53, 20)
        Me.nudEarliest.TabIndex = 36
        Me.nudEarliest.Value = New Decimal(New Integer() {228, 0, 0, 0})
        '
        'txtColumnName
        '
        Me.txtColumnName.Location = New System.Drawing.Point(187, 159)
        Me.txtColumnName.Name = "txtColumnName"
        Me.txtColumnName.Size = New System.Drawing.Size(100, 20)
        Me.txtColumnName.TabIndex = 35
        Me.txtColumnName.Tag = "End_of_Rain"
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(34, 162)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(39, 13)
        Me.lblColumnName.TabIndex = 34
        Me.lblColumnName.Tag = "Column_Name"
        Me.lblColumnName.Text = "Label1"
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(34, 105)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(39, 13)
        Me.lblEvaporation.TabIndex = 25
        Me.lblEvaporation.Tag = "Evaporation"
        Me.lblEvaporation.Text = "Label1"
        '
        'lblCapacityMax
        '
        Me.lblCapacityMax.AutoSize = True
        Me.lblCapacityMax.Location = New System.Drawing.Point(34, 85)
        Me.lblCapacityMax.Name = "lblCapacityMax"
        Me.lblCapacityMax.Size = New System.Drawing.Size(39, 13)
        Me.lblCapacityMax.TabIndex = 24
        Me.lblCapacityMax.Tag = "Capacity_Max"
        Me.lblCapacityMax.Text = "Label1"
        '
        'nudEvaporation
        '
        Me.nudEvaporation.Location = New System.Drawing.Point(187, 100)
        Me.nudEvaporation.Name = "nudEvaporation"
        Me.nudEvaporation.Size = New System.Drawing.Size(35, 20)
        Me.nudEvaporation.TabIndex = 23
        Me.nudEvaporation.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblEarliest
        '
        Me.lblEarliest.AutoSize = True
        Me.lblEarliest.Location = New System.Drawing.Point(34, 65)
        Me.lblEarliest.Name = "lblEarliest"
        Me.lblEarliest.Size = New System.Drawing.Size(61, 13)
        Me.lblEarliest.TabIndex = 22
        Me.lblEarliest.Tag = "Earliest_day"
        Me.lblEarliest.Text = "Earliest day"
        '
        'lblDataList
        '
        Me.lblDataList.AutoSize = True
        Me.lblDataList.Location = New System.Drawing.Point(31, 25)
        Me.lblDataList.Name = "lblDataList"
        Me.lblDataList.Size = New System.Drawing.Size(106, 13)
        Me.lblDataList.TabIndex = 21
        Me.lblDataList.Tag = "Not_Yet_Implemented"
        Me.lblDataList.Text = "Not Yet Implemented"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(24, 256)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 50)
        Me.ucrBase.TabIndex = 20
        '
        'txtWaterBalanceColumnName
        '
        Me.txtWaterBalanceColumnName.Location = New System.Drawing.Point(187, 214)
        Me.txtWaterBalanceColumnName.Name = "txtWaterBalanceColumnName"
        Me.txtWaterBalanceColumnName.Size = New System.Drawing.Size(100, 20)
        Me.txtWaterBalanceColumnName.TabIndex = 38
        Me.txtWaterBalanceColumnName.Tag = "End_of_Rains"
        '
        'IbIWaterBalanceColumnName
        '
        Me.IbIWaterBalanceColumnName.AutoSize = True
        Me.IbIWaterBalanceColumnName.Location = New System.Drawing.Point(34, 221)
        Me.IbIWaterBalanceColumnName.Name = "IbIWaterBalanceColumnName"
        Me.IbIWaterBalanceColumnName.Size = New System.Drawing.Size(39, 13)
        Me.IbIWaterBalanceColumnName.TabIndex = 39
        Me.IbIWaterBalanceColumnName.Tag = "WaterBalanceColumnName"
        Me.IbIWaterBalanceColumnName.Text = "Label1"
        '
        'dlgEndofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 307)
        Me.Controls.Add(Me.IbIWaterBalanceColumnName)
        Me.Controls.Add(Me.txtWaterBalanceColumnName)
        Me.Controls.Add(Me.nudCapacityMax)
        Me.Controls.Add(Me.nudEarliest)
        Me.Controls.Add(Me.txtColumnName)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.lblEvaporation)
        Me.Controls.Add(Me.lblCapacityMax)
        Me.Controls.Add(Me.nudEvaporation)
        Me.Controls.Add(Me.lblEarliest)
        Me.Controls.Add(Me.lblDataList)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEndofRains"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "End_of_Rains"
        Me.Text = "End of Rains"
        CType(Me.nudCapacityMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEarliest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEvaporation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudCapacityMax As NumericUpDown
    Friend WithEvents nudEarliest As NumericUpDown
    Friend WithEvents txtColumnName As TextBox
    Friend WithEvents lblColumnName As Label
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblCapacityMax As Label
    Friend WithEvents nudEvaporation As NumericUpDown
    Friend WithEvents lblEarliest As Label
    Friend WithEvents lblDataList As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtWaterBalanceColumnName As TextBox
    Friend WithEvents IbIWaterBalanceColumnName As Label
End Class
