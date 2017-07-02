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
Partial Class dlgRainStats
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
        Me.lblThreshold1 = New System.Windows.Forms.Label()
        Me.lblThreshold2 = New System.Windows.Forms.Label()
        Me.lblThresholdAmounts = New System.Windows.Forms.Label()
        Me.nudThreshold1 = New System.Windows.Forms.NumericUpDown()
        Me.nudThreshold2 = New System.Windows.Forms.NumericUpDown()
        Me.nudThresholdRainAmounts = New System.Windows.Forms.NumericUpDown()
        Me.txtColunnName1 = New System.Windows.Forms.TextBox()
        Me.txtColunnName2 = New System.Windows.Forms.TextBox()
        Me.txtColunnName3 = New System.Windows.Forms.TextBox()
        Me.lblColunnName1 = New System.Windows.Forms.Label()
        Me.lblColunnName2 = New System.Windows.Forms.Label()
        Me.lblColunnName3 = New System.Windows.Forms.Label()
        CType(Me.nudThreshold1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThresholdRainAmounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 264)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'lblThreshold1
        '
        Me.lblThreshold1.AutoSize = True
        Me.lblThreshold1.Location = New System.Drawing.Point(23, 131)
        Me.lblThreshold1.Name = "lblThreshold1"
        Me.lblThreshold1.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold1.TabIndex = 2
        Me.lblThreshold1.Tag = "Threshold_1"
        Me.lblThreshold1.Text = "Label2"
        '
        'lblThreshold2
        '
        Me.lblThreshold2.AutoSize = True
        Me.lblThreshold2.Location = New System.Drawing.Point(23, 157)
        Me.lblThreshold2.Name = "lblThreshold2"
        Me.lblThreshold2.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold2.TabIndex = 3
        Me.lblThreshold2.Tag = "Threshold_2"
        Me.lblThreshold2.Text = "Label3"
        '
        'lblThresholdAmounts
        '
        Me.lblThresholdAmounts.AutoSize = True
        Me.lblThresholdAmounts.Location = New System.Drawing.Point(23, 190)
        Me.lblThresholdAmounts.Name = "lblThresholdAmounts"
        Me.lblThresholdAmounts.Size = New System.Drawing.Size(39, 13)
        Me.lblThresholdAmounts.TabIndex = 4
        Me.lblThresholdAmounts.Tag = "Threshold_Amounts"
        Me.lblThresholdAmounts.Text = "Label4"
        '
        'nudThreshold1
        '
        Me.nudThreshold1.Location = New System.Drawing.Point(144, 131)
        Me.nudThreshold1.Name = "nudThreshold1"
        Me.nudThreshold1.Size = New System.Drawing.Size(58, 20)
        Me.nudThreshold1.TabIndex = 5
        '
        'nudThreshold2
        '
        Me.nudThreshold2.Location = New System.Drawing.Point(144, 157)
        Me.nudThreshold2.Name = "nudThreshold2"
        Me.nudThreshold2.Size = New System.Drawing.Size(58, 20)
        Me.nudThreshold2.TabIndex = 6
        '
        'nudThresholdRainAmounts
        '
        Me.nudThresholdRainAmounts.Location = New System.Drawing.Point(144, 183)
        Me.nudThresholdRainAmounts.Name = "nudThresholdRainAmounts"
        Me.nudThresholdRainAmounts.Size = New System.Drawing.Size(58, 20)
        Me.nudThresholdRainAmounts.TabIndex = 7
        '
        'txtColunnName1
        '
        Me.txtColunnName1.Location = New System.Drawing.Point(144, 37)
        Me.txtColunnName1.Name = "txtColunnName1"
        Me.txtColunnName1.Size = New System.Drawing.Size(100, 20)
        Me.txtColunnName1.TabIndex = 8
        '
        'txtColunnName2
        '
        Me.txtColunnName2.Location = New System.Drawing.Point(144, 62)
        Me.txtColunnName2.Name = "txtColunnName2"
        Me.txtColunnName2.Size = New System.Drawing.Size(100, 20)
        Me.txtColunnName2.TabIndex = 9
        '
        'txtColunnName3
        '
        Me.txtColunnName3.Location = New System.Drawing.Point(144, 88)
        Me.txtColunnName3.Name = "txtColunnName3"
        Me.txtColunnName3.Size = New System.Drawing.Size(100, 20)
        Me.txtColunnName3.TabIndex = 10
        '
        'lblColunnName1
        '
        Me.lblColunnName1.AutoSize = True
        Me.lblColunnName1.Location = New System.Drawing.Point(23, 44)
        Me.lblColunnName1.Name = "lblColunnName1"
        Me.lblColunnName1.Size = New System.Drawing.Size(39, 13)
        Me.lblColunnName1.TabIndex = 11
        Me.lblColunnName1.Tag = "Colunn_Name1"
        Me.lblColunnName1.Text = "Label5"
        '
        'lblColunnName2
        '
        Me.lblColunnName2.AutoSize = True
        Me.lblColunnName2.Location = New System.Drawing.Point(23, 69)
        Me.lblColunnName2.Name = "lblColunnName2"
        Me.lblColunnName2.Size = New System.Drawing.Size(39, 13)
        Me.lblColunnName2.TabIndex = 12
        Me.lblColunnName2.Tag = "ColunnName_2"
        Me.lblColunnName2.Text = "Label6"
        '
        'lblColunnName3
        '
        Me.lblColunnName3.AutoSize = True
        Me.lblColunnName3.Location = New System.Drawing.Point(23, 95)
        Me.lblColunnName3.Name = "lblColunnName3"
        Me.lblColunnName3.Size = New System.Drawing.Size(39, 13)
        Me.lblColunnName3.TabIndex = 13
        Me.lblColunnName3.Tag = "Colunn_Name3"
        Me.lblColunnName3.Text = "Label7"
        '
        'dlgRainStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 297)
        Me.Controls.Add(Me.lblColunnName3)
        Me.Controls.Add(Me.lblColunnName2)
        Me.Controls.Add(Me.lblColunnName1)
        Me.Controls.Add(Me.txtColunnName3)
        Me.Controls.Add(Me.txtColunnName2)
        Me.Controls.Add(Me.txtColunnName1)
        Me.Controls.Add(Me.nudThresholdRainAmounts)
        Me.Controls.Add(Me.nudThreshold2)
        Me.Controls.Add(Me.nudThreshold1)
        Me.Controls.Add(Me.lblThresholdAmounts)
        Me.Controls.Add(Me.lblThreshold2)
        Me.Controls.Add(Me.lblThreshold1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRainStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rain_Stats"
        Me.Text = "Rain Statistics"
        CType(Me.nudThreshold1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreshold2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThresholdRainAmounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblThreshold1 As Label
    Friend WithEvents lblThreshold2 As Label
    Friend WithEvents lblThresholdAmounts As Label
    Friend WithEvents nudThreshold1 As NumericUpDown
    Friend WithEvents nudThreshold2 As NumericUpDown
    Friend WithEvents nudThresholdRainAmounts As NumericUpDown
    Friend WithEvents txtColunnName1 As TextBox
    Friend WithEvents txtColunnName2 As TextBox
    Friend WithEvents txtColunnName3 As TextBox
    Friend WithEvents lblColunnName1 As Label
    Friend WithEvents lblColunnName2 As Label
    Friend WithEvents lblColunnName3 As Label
End Class
