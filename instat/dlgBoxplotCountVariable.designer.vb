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
Partial Class dlgBoxplotCountVariable
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
        Me.chkVarwidth = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVariableLabel = New System.Windows.Forms.Label()
        Me.lblWhisker_Colour = New System.Windows.Forms.Label()
        Me.lblFillColour = New System.Windows.Forms.Label()
        Me.lblTimeperiod = New System.Windows.Forms.Label()
        Me.lblWhiskLineType = New System.Windows.Forms.Label()
        Me.nudWhiskLineType = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrInputVariable = New instat.ucrInputTextBox()
        Me.ucrInputColour = New instat.ucrInputTextBox()
        Me.ucrInputTimePeriod = New instat.ucrInputTextBox()
        Me.ucrInputWhiskerColour = New instat.ucrInputTextBox()
        CType(Me.nudWhiskLineType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 188)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 55)
        Me.ucrBase.TabIndex = 0
        '
        'chkVarwidth
        '
        Me.chkVarwidth.AutoSize = True
        Me.chkVarwidth.Location = New System.Drawing.Point(198, 162)
        Me.chkVarwidth.Name = "chkVarwidth"
        Me.chkVarwidth.Size = New System.Drawing.Size(95, 17)
        Me.chkVarwidth.TabIndex = 1
        Me.chkVarwidth.Tag = "Variable_Width"
        Me.chkVarwidth.Text = "Variable Width"
        Me.chkVarwidth.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data list not implemented"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'lblVariableLabel
        '
        Me.lblVariableLabel.AutoSize = True
        Me.lblVariableLabel.Location = New System.Drawing.Point(16, 62)
        Me.lblVariableLabel.Name = "lblVariableLabel"
        Me.lblVariableLabel.Size = New System.Drawing.Size(45, 13)
        Me.lblVariableLabel.TabIndex = 4
        Me.lblVariableLabel.Tag = "Variable_Label"
        Me.lblVariableLabel.Text = "Variable"
        '
        'lblWhisker_Colour
        '
        Me.lblWhisker_Colour.AutoSize = True
        Me.lblWhisker_Colour.Location = New System.Drawing.Point(16, 143)
        Me.lblWhisker_Colour.Name = "lblWhisker_Colour"
        Me.lblWhisker_Colour.Size = New System.Drawing.Size(79, 13)
        Me.lblWhisker_Colour.TabIndex = 5
        Me.lblWhisker_Colour.Tag = "Whisker_Colour"
        Me.lblWhisker_Colour.Text = "Whisker Colour"
        '
        'lblFillColour
        '
        Me.lblFillColour.AutoSize = True
        Me.lblFillColour.Location = New System.Drawing.Point(16, 90)
        Me.lblFillColour.Name = "lblFillColour"
        Me.lblFillColour.Size = New System.Drawing.Size(37, 13)
        Me.lblFillColour.TabIndex = 6
        Me.lblFillColour.Tag = "Colour"
        Me.lblFillColour.Text = "Colour"
        '
        'lblTimeperiod
        '
        Me.lblTimeperiod.AutoSize = True
        Me.lblTimeperiod.Location = New System.Drawing.Point(16, 118)
        Me.lblTimeperiod.Name = "lblTimeperiod"
        Me.lblTimeperiod.Size = New System.Drawing.Size(63, 13)
        Me.lblTimeperiod.TabIndex = 7
        Me.lblTimeperiod.Tag = "Time_period"
        Me.lblTimeperiod.Text = "Time Period"
        '
        'lblWhiskLineType
        '
        Me.lblWhiskLineType.AutoSize = True
        Me.lblWhiskLineType.Location = New System.Drawing.Point(14, 169)
        Me.lblWhiskLineType.Name = "lblWhiskLineType"
        Me.lblWhiskLineType.Size = New System.Drawing.Size(87, 13)
        Me.lblWhiskLineType.TabIndex = 8
        Me.lblWhiskLineType.Tag = "Whisk_Line_Type"
        Me.lblWhiskLineType.Text = "Whisk Line Type"
        '
        'nudWhiskLineType
        '
        Me.nudWhiskLineType.Location = New System.Drawing.Point(101, 162)
        Me.nudWhiskLineType.Name = "nudWhiskLineType"
        Me.nudWhiskLineType.Size = New System.Drawing.Size(58, 20)
        Me.nudWhiskLineType.TabIndex = 9
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.Location = New System.Drawing.Point(101, 25)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(111, 21)
        Me.ucrInputTitle.TabIndex = 10
        '
        'ucrInputVariable
        '
        Me.ucrInputVariable.Location = New System.Drawing.Point(101, 54)
        Me.ucrInputVariable.Name = "ucrInputVariable"
        Me.ucrInputVariable.Size = New System.Drawing.Size(111, 21)
        Me.ucrInputVariable.TabIndex = 11
        '
        'ucrInputColour
        '
        Me.ucrInputColour.Location = New System.Drawing.Point(101, 82)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(111, 21)
        Me.ucrInputColour.TabIndex = 12
        '
        'ucrInputTimePeriod
        '
        Me.ucrInputTimePeriod.Location = New System.Drawing.Point(101, 109)
        Me.ucrInputTimePeriod.Name = "ucrInputTimePeriod"
        Me.ucrInputTimePeriod.Size = New System.Drawing.Size(111, 21)
        Me.ucrInputTimePeriod.TabIndex = 13
        '
        'ucrInputWhiskerColour
        '
        Me.ucrInputWhiskerColour.Location = New System.Drawing.Point(101, 135)
        Me.ucrInputWhiskerColour.Name = "ucrInputWhiskerColour"
        Me.ucrInputWhiskerColour.Size = New System.Drawing.Size(111, 21)
        Me.ucrInputWhiskerColour.TabIndex = 14
        '
        'dlgBoxplotCountVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 252)
        Me.Controls.Add(Me.ucrInputWhiskerColour)
        Me.Controls.Add(Me.ucrInputTimePeriod)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.ucrInputVariable)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.nudWhiskLineType)
        Me.Controls.Add(Me.lblWhiskLineType)
        Me.Controls.Add(Me.lblTimeperiod)
        Me.Controls.Add(Me.lblFillColour)
        Me.Controls.Add(Me.lblWhisker_Colour)
        Me.Controls.Add(Me.lblVariableLabel)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkVarwidth)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxplotCountVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Boxplot_Count_Variable"
        Me.Text = "Boxplot Count Variable"
        CType(Me.nudWhiskLineType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkVarwidth As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVariableLabel As Label
    Friend WithEvents lblWhisker_Colour As Label
    Friend WithEvents lblFillColour As Label
    Friend WithEvents lblTimeperiod As Label
    Friend WithEvents lblWhiskLineType As Label
    Friend WithEvents nudWhiskLineType As NumericUpDown
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrInputVariable As ucrInputTextBox
    Friend WithEvents ucrInputColour As ucrInputTextBox
    Friend WithEvents ucrInputTimePeriod As ucrInputTextBox
    Friend WithEvents ucrInputWhiskerColour As ucrInputTextBox
End Class
