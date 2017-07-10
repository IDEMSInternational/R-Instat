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
Partial Class dlgMissingValuesplot
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkStationName = New System.Windows.Forms.CheckBox()
        Me.chkHorizontal = New System.Windows.Forms.CheckBox()
        Me.txtlog = New System.Windows.Forms.TextBox()
        Me.txtASP = New System.Windows.Forms.TextBox()
        Me.txtRainFillColour = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtXLabel = New System.Windows.Forms.TextBox()
        Me.txtYLabel = New System.Windows.Forms.TextBox()
        Me.txtLegend = New System.Windows.Forms.TextBox()
        Me.txtLegendPosition = New System.Windows.Forms.TextBox()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.nudYlim = New System.Windows.Forms.NumericUpDown()
        Me.nudPlotCharacter = New System.Windows.Forms.NumericUpDown()
        Me.lblYLimits = New System.Windows.Forms.Label()
        Me.lblPlotCharacter = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblASP = New System.Windows.Forms.Label()
        Me.lblRainFillColour = New System.Windows.Forms.Label()
        Me.lblLegendPosition = New System.Windows.Forms.Label()
        Me.lblLegend = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtMissingFillColor = New System.Windows.Forms.TextBox()
        Me.lblMissingFillColor = New System.Windows.Forms.Label()
        Me.txtDryFillColor = New System.Windows.Forms.TextBox()
        Me.lblDryFillColor = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYlim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'chkStationName
        '
        Me.chkStationName.AutoSize = True
        Me.chkStationName.Location = New System.Drawing.Point(339, 238)
        Me.chkStationName.Name = "chkStationName"
        Me.chkStationName.Size = New System.Drawing.Size(90, 17)
        Me.chkStationName.TabIndex = 2
        Me.chkStationName.Tag = "Station_Name"
        Me.chkStationName.Text = "Station Name"
        Me.chkStationName.UseVisualStyleBackColor = True
        '
        'chkHorizontal
        '
        Me.chkHorizontal.AutoSize = True
        Me.chkHorizontal.Location = New System.Drawing.Point(379, 205)
        Me.chkHorizontal.Name = "chkHorizontal"
        Me.chkHorizontal.Size = New System.Drawing.Size(73, 17)
        Me.chkHorizontal.TabIndex = 3
        Me.chkHorizontal.Tag = "Horizontal"
        Me.chkHorizontal.Text = "Horizontal"
        Me.chkHorizontal.UseVisualStyleBackColor = True
        '
        'txtlog
        '
        Me.txtlog.Location = New System.Drawing.Point(147, 256)
        Me.txtlog.Name = "txtlog"
        Me.txtlog.Size = New System.Drawing.Size(100, 20)
        Me.txtlog.TabIndex = 5
        Me.txtlog.Tag = ""
        '
        'txtASP
        '
        Me.txtASP.Location = New System.Drawing.Point(147, 230)
        Me.txtASP.Name = "txtASP"
        Me.txtASP.Size = New System.Drawing.Size(100, 20)
        Me.txtASP.TabIndex = 6
        '
        'txtRainFillColour
        '
        Me.txtRainFillColour.Location = New System.Drawing.Point(147, 154)
        Me.txtRainFillColour.Name = "txtRainFillColour"
        Me.txtRainFillColour.Size = New System.Drawing.Size(100, 20)
        Me.txtRainFillColour.TabIndex = 7
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(147, 25)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 11
        '
        'txtXLabel
        '
        Me.txtXLabel.Location = New System.Drawing.Point(147, 50)
        Me.txtXLabel.Name = "txtXLabel"
        Me.txtXLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtXLabel.TabIndex = 12
        '
        'txtYLabel
        '
        Me.txtYLabel.Location = New System.Drawing.Point(147, 76)
        Me.txtYLabel.Name = "txtYLabel"
        Me.txtYLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtYLabel.TabIndex = 13
        '
        'txtLegend
        '
        Me.txtLegend.Location = New System.Drawing.Point(147, 102)
        Me.txtLegend.Name = "txtLegend"
        Me.txtLegend.Size = New System.Drawing.Size(100, 20)
        Me.txtLegend.TabIndex = 14
        '
        'txtLegendPosition
        '
        Me.txtLegendPosition.Location = New System.Drawing.Point(147, 128)
        Me.txtLegendPosition.Name = "txtLegendPosition"
        Me.txtLegendPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtLegendPosition.TabIndex = 15
        Me.txtLegendPosition.Tag = "Legend_Position"
        '
        'nudThreshold
        '
        Me.nudThreshold.Location = New System.Drawing.Point(147, 281)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(57, 20)
        Me.nudThreshold.TabIndex = 16
        '
        'nudYlim
        '
        Me.nudYlim.Location = New System.Drawing.Point(339, 279)
        Me.nudYlim.Name = "nudYlim"
        Me.nudYlim.Size = New System.Drawing.Size(57, 20)
        Me.nudYlim.TabIndex = 17
        '
        'nudPlotCharacter
        '
        Me.nudPlotCharacter.Location = New System.Drawing.Point(147, 307)
        Me.nudPlotCharacter.Name = "nudPlotCharacter"
        Me.nudPlotCharacter.Size = New System.Drawing.Size(57, 20)
        Me.nudPlotCharacter.TabIndex = 18
        '
        'lblYLimits
        '
        Me.lblYLimits.AutoSize = True
        Me.lblYLimits.Location = New System.Drawing.Point(255, 283)
        Me.lblYLimits.Name = "lblYLimits"
        Me.lblYLimits.Size = New System.Drawing.Size(43, 13)
        Me.lblYLimits.TabIndex = 19
        Me.lblYLimits.Tag = "lblYLimits"
        Me.lblYLimits.Text = "Y Limits"
        '
        'lblPlotCharacter
        '
        Me.lblPlotCharacter.AutoSize = True
        Me.lblPlotCharacter.Location = New System.Drawing.Point(28, 307)
        Me.lblPlotCharacter.Name = "lblPlotCharacter"
        Me.lblPlotCharacter.Size = New System.Drawing.Size(74, 13)
        Me.lblPlotCharacter.TabIndex = 20
        Me.lblPlotCharacter.Tag = "Plot_Character"
        Me.lblPlotCharacter.Text = "Plot Character"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(28, 281)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 21
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(28, 256)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(25, 13)
        Me.lblLog.TabIndex = 22
        Me.lblLog.Tag = "log"
        Me.lblLog.Text = "Log"
        '
        'lblASP
        '
        Me.lblASP.AutoSize = True
        Me.lblASP.Location = New System.Drawing.Point(28, 230)
        Me.lblASP.Name = "lblASP"
        Me.lblASP.Size = New System.Drawing.Size(28, 13)
        Me.lblASP.TabIndex = 23
        Me.lblASP.Tag = "asp"
        Me.lblASP.Text = "ASP"
        '
        'lblRainFillColour
        '
        Me.lblRainFillColour.AutoSize = True
        Me.lblRainFillColour.Location = New System.Drawing.Point(28, 154)
        Me.lblRainFillColour.Name = "lblRainFillColour"
        Me.lblRainFillColour.Size = New System.Drawing.Size(71, 13)
        Me.lblRainFillColour.TabIndex = 24
        Me.lblRainFillColour.Tag = "Fill_Colour"
        Me.lblRainFillColour.Text = "Rain Fill Color"
        '
        'lblLegendPosition
        '
        Me.lblLegendPosition.AutoSize = True
        Me.lblLegendPosition.Location = New System.Drawing.Point(28, 128)
        Me.lblLegendPosition.Name = "lblLegendPosition"
        Me.lblLegendPosition.Size = New System.Drawing.Size(83, 13)
        Me.lblLegendPosition.TabIndex = 25
        Me.lblLegendPosition.Tag = "Legend_Position"
        Me.lblLegendPosition.Text = "Legend Position"
        '
        'lblLegend
        '
        Me.lblLegend.AutoSize = True
        Me.lblLegend.Location = New System.Drawing.Point(28, 102)
        Me.lblLegend.Name = "lblLegend"
        Me.lblLegend.Size = New System.Drawing.Size(43, 13)
        Me.lblLegend.TabIndex = 26
        Me.lblLegend.Tag = "Legend"
        Me.lblLegend.Text = "Legend"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(28, 76)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblYLabel.TabIndex = 27
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Y Label"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(28, 50)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblXLabel.TabIndex = 28
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "X Label"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(28, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 29
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'txtMissingFillColor
        '
        Me.txtMissingFillColor.Location = New System.Drawing.Point(147, 180)
        Me.txtMissingFillColor.Name = "txtMissingFillColor"
        Me.txtMissingFillColor.Size = New System.Drawing.Size(100, 20)
        Me.txtMissingFillColor.TabIndex = 7
        '
        'lblMissingFillColor
        '
        Me.lblMissingFillColor.AutoSize = True
        Me.lblMissingFillColor.Location = New System.Drawing.Point(28, 180)
        Me.lblMissingFillColor.Name = "lblMissingFillColor"
        Me.lblMissingFillColor.Size = New System.Drawing.Size(84, 13)
        Me.lblMissingFillColor.TabIndex = 24
        Me.lblMissingFillColor.Tag = "Fill_Colour"
        Me.lblMissingFillColor.Text = "Missing Fill Color"
        '
        'txtDryFillColor
        '
        Me.txtDryFillColor.Location = New System.Drawing.Point(147, 205)
        Me.txtDryFillColor.Name = "txtDryFillColor"
        Me.txtDryFillColor.Size = New System.Drawing.Size(100, 20)
        Me.txtDryFillColor.TabIndex = 7
        '
        'lblDryFillColor
        '
        Me.lblDryFillColor.AutoSize = True
        Me.lblDryFillColor.Location = New System.Drawing.Point(28, 205)
        Me.lblDryFillColor.Name = "lblDryFillColor"
        Me.lblDryFillColor.Size = New System.Drawing.Size(65, 13)
        Me.lblDryFillColor.TabIndex = 24
        Me.lblDryFillColor.Tag = "Fill_Colour"
        Me.lblDryFillColor.Text = "Dry Fill Color"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(21, 333)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 0
        '
        'dlgMissingValuesplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 391)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblLegend)
        Me.Controls.Add(Me.lblLegendPosition)
        Me.Controls.Add(Me.lblDryFillColor)
        Me.Controls.Add(Me.lblMissingFillColor)
        Me.Controls.Add(Me.lblRainFillColour)
        Me.Controls.Add(Me.lblASP)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblPlotCharacter)
        Me.Controls.Add(Me.lblYLimits)
        Me.Controls.Add(Me.nudPlotCharacter)
        Me.Controls.Add(Me.nudYlim)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.txtLegendPosition)
        Me.Controls.Add(Me.txtLegend)
        Me.Controls.Add(Me.txtYLabel)
        Me.Controls.Add(Me.txtXLabel)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtDryFillColor)
        Me.Controls.Add(Me.txtMissingFillColor)
        Me.Controls.Add(Me.txtRainFillColour)
        Me.Controls.Add(Me.txtASP)
        Me.Controls.Add(Me.txtlog)
        Me.Controls.Add(Me.chkHorizontal)
        Me.Controls.Add(Me.chkStationName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMissingValuesplot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgMissingValuesplot"
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYlim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents chkStationName As CheckBox
    Friend WithEvents chkHorizontal As CheckBox
    Friend WithEvents txtlog As TextBox
    Friend WithEvents txtASP As TextBox
    Friend WithEvents txtRainFillColour As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtXLabel As TextBox
    Friend WithEvents txtYLabel As TextBox
    Friend WithEvents txtLegend As TextBox
    Friend WithEvents txtLegendPosition As TextBox
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents nudYlim As NumericUpDown
    Friend WithEvents nudPlotCharacter As NumericUpDown
    Friend WithEvents lblYLimits As Label
    Friend WithEvents lblPlotCharacter As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblLog As Label
    Friend WithEvents lblASP As Label
    Friend WithEvents lblRainFillColour As Label
    Friend WithEvents lblLegendPosition As Label
    Friend WithEvents lblLegend As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtMissingFillColor As TextBox
    Friend WithEvents lblMissingFillColor As Label
    Friend WithEvents txtDryFillColor As TextBox
    Friend WithEvents lblDryFillColor As Label
End Class
