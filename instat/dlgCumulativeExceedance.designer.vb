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
Partial Class dlgCumulativeExceedance
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
        Me.grpOptioins = New System.Windows.Forms.GroupBox()
        Me.chkPlotWindow = New System.Windows.Forms.CheckBox()
        Me.chkGridSquare = New System.Windows.Forms.CheckBox()
        Me.chkStationName = New System.Windows.Forms.CheckBox()
        Me.chkPercents = New System.Windows.Forms.CheckBox()
        Me.chkCumulativeGraph = New System.Windows.Forms.CheckBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtInterestedVariable = New System.Windows.Forms.TextBox()
        Me.txtXLabel = New System.Windows.Forms.TextBox()
        Me.txtDataperiodLabel = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInterestedVariable = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.lblDataperiodLabel = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.txtYLabel = New System.Windows.Forms.TextBox()
        Me.txtLegendPosition = New System.Windows.Forms.TextBox()
        Me.lblLegendPosition = New System.Windows.Forms.Label()
        Me.nudLineWidth = New System.Windows.Forms.NumericUpDown()
        Me.nudPlotCharacter = New System.Windows.Forms.NumericUpDown()
        Me.lblLineWidth = New System.Windows.Forms.Label()
        Me.lblPlotCharacter = New System.Windows.Forms.Label()
        Me.lblColourRainbow = New System.Windows.Forms.Label()
        Me.nudColourRainbow = New System.Windows.Forms.NumericUpDown()
        Me.lblLegendLabel = New System.Windows.Forms.Label()
        Me.lblLegendBty = New System.Windows.Forms.Label()
        Me.txtLegendBtype = New System.Windows.Forms.TextBox()
        Me.txtLegendLabel = New System.Windows.Forms.TextBox()
        Me.grpOptioins.SuspendLayout()
        CType(Me.nudLineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColourRainbow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(30, 338)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 0
        '
        'grpOptioins
        '
        Me.grpOptioins.Controls.Add(Me.chkPlotWindow)
        Me.grpOptioins.Controls.Add(Me.chkGridSquare)
        Me.grpOptioins.Controls.Add(Me.chkStationName)
        Me.grpOptioins.Controls.Add(Me.chkPercents)
        Me.grpOptioins.Controls.Add(Me.chkCumulativeGraph)
        Me.grpOptioins.Location = New System.Drawing.Point(248, 171)
        Me.grpOptioins.Name = "grpOptioins"
        Me.grpOptioins.Size = New System.Drawing.Size(257, 122)
        Me.grpOptioins.TabIndex = 2
        Me.grpOptioins.TabStop = False
        Me.grpOptioins.Tag = "Options"
        Me.grpOptioins.Text = "Options"
        '
        'chkPlotWindow
        '
        Me.chkPlotWindow.AutoSize = True
        Me.chkPlotWindow.Location = New System.Drawing.Point(6, 19)
        Me.chkPlotWindow.Name = "chkPlotWindow"
        Me.chkPlotWindow.Size = New System.Drawing.Size(83, 17)
        Me.chkPlotWindow.TabIndex = 4
        Me.chkPlotWindow.Tag = "Plot_window"
        Me.chkPlotWindow.Text = "Plot window"
        Me.chkPlotWindow.UseVisualStyleBackColor = True
        '
        'chkGridSquare
        '
        Me.chkGridSquare.AutoSize = True
        Me.chkGridSquare.Location = New System.Drawing.Point(157, 61)
        Me.chkGridSquare.Name = "chkGridSquare"
        Me.chkGridSquare.Size = New System.Drawing.Size(80, 17)
        Me.chkGridSquare.TabIndex = 3
        Me.chkGridSquare.Tag = "Grid_square"
        Me.chkGridSquare.Text = "Grid square"
        Me.chkGridSquare.UseVisualStyleBackColor = True
        '
        'chkStationName
        '
        Me.chkStationName.AutoSize = True
        Me.chkStationName.Location = New System.Drawing.Point(6, 61)
        Me.chkStationName.Name = "chkStationName"
        Me.chkStationName.Size = New System.Drawing.Size(88, 17)
        Me.chkStationName.TabIndex = 2
        Me.chkStationName.Tag = "Station_name"
        Me.chkStationName.Text = "Station name"
        Me.chkStationName.UseVisualStyleBackColor = True
        '
        'chkPercents
        '
        Me.chkPercents.AutoSize = True
        Me.chkPercents.Location = New System.Drawing.Point(157, 19)
        Me.chkPercents.Name = "chkPercents"
        Me.chkPercents.Size = New System.Drawing.Size(68, 17)
        Me.chkPercents.TabIndex = 1
        Me.chkPercents.Tag = "Percents"
        Me.chkPercents.Text = "Percents"
        Me.chkPercents.UseVisualStyleBackColor = True
        '
        'chkCumulativeGraph
        '
        Me.chkCumulativeGraph.AutoSize = True
        Me.chkCumulativeGraph.Location = New System.Drawing.Point(6, 100)
        Me.chkCumulativeGraph.Name = "chkCumulativeGraph"
        Me.chkCumulativeGraph.Size = New System.Drawing.Size(108, 17)
        Me.chkCumulativeGraph.TabIndex = 0
        Me.chkCumulativeGraph.Tag = "Cumulative_graph"
        Me.chkCumulativeGraph.Text = "Cumulative graph"
        Me.chkCumulativeGraph.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(127, 38)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtInterestedVariable
        '
        Me.txtInterestedVariable.Location = New System.Drawing.Point(127, 66)
        Me.txtInterestedVariable.Name = "txtInterestedVariable"
        Me.txtInterestedVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestedVariable.TabIndex = 4
        '
        'txtXLabel
        '
        Me.txtXLabel.Location = New System.Drawing.Point(127, 91)
        Me.txtXLabel.Name = "txtXLabel"
        Me.txtXLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtXLabel.TabIndex = 5
        '
        'txtDataperiodLabel
        '
        Me.txtDataperiodLabel.Location = New System.Drawing.Point(127, 117)
        Me.txtDataperiodLabel.Name = "txtDataperiodLabel"
        Me.txtDataperiodLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtDataperiodLabel.TabIndex = 6
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(27, 45)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'lblInterestedVariable
        '
        Me.lblInterestedVariable.AutoSize = True
        Me.lblInterestedVariable.Location = New System.Drawing.Point(27, 71)
        Me.lblInterestedVariable.Name = "lblInterestedVariable"
        Me.lblInterestedVariable.Size = New System.Drawing.Size(94, 13)
        Me.lblInterestedVariable.TabIndex = 8
        Me.lblInterestedVariable.Tag = "Interested_variable"
        Me.lblInterestedVariable.Text = "Interested variable"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(27, 98)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblXLabel.TabIndex = 9
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "X label"
        '
        'lblDataperiodLabel
        '
        Me.lblDataperiodLabel.AutoSize = True
        Me.lblDataperiodLabel.Location = New System.Drawing.Point(27, 124)
        Me.lblDataperiodLabel.Name = "lblDataperiodLabel"
        Me.lblDataperiodLabel.Size = New System.Drawing.Size(88, 13)
        Me.lblDataperiodLabel.TabIndex = 10
        Me.lblDataperiodLabel.Tag = "Data_Period_Label"
        Me.lblDataperiodLabel.Text = "Data Period label"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(360, 98)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblYLabel.TabIndex = 11
        Me.lblYLabel.Tag = "Y_label"
        Me.lblYLabel.Text = "Y label"
        '
        'txtYLabel
        '
        Me.txtYLabel.Location = New System.Drawing.Point(405, 91)
        Me.txtYLabel.Name = "txtYLabel"
        Me.txtYLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtYLabel.TabIndex = 12
        '
        'txtLegendPosition
        '
        Me.txtLegendPosition.Location = New System.Drawing.Point(405, 299)
        Me.txtLegendPosition.Name = "txtLegendPosition"
        Me.txtLegendPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtLegendPosition.TabIndex = 5
        Me.txtLegendPosition.Tag = "Legend_position"
        '
        'lblLegendPosition
        '
        Me.lblLegendPosition.AutoSize = True
        Me.lblLegendPosition.Location = New System.Drawing.Point(245, 306)
        Me.lblLegendPosition.Name = "lblLegendPosition"
        Me.lblLegendPosition.Size = New System.Drawing.Size(82, 13)
        Me.lblLegendPosition.TabIndex = 13
        Me.lblLegendPosition.Tag = "Legend_Position"
        Me.lblLegendPosition.Text = "Legend position"
        '
        'nudLineWidth
        '
        Me.nudLineWidth.Location = New System.Drawing.Point(127, 143)
        Me.nudLineWidth.Name = "nudLineWidth"
        Me.nudLineWidth.Size = New System.Drawing.Size(47, 20)
        Me.nudLineWidth.TabIndex = 14
        '
        'nudPlotCharacter
        '
        Me.nudPlotCharacter.Location = New System.Drawing.Point(127, 170)
        Me.nudPlotCharacter.Name = "nudPlotCharacter"
        Me.nudPlotCharacter.Size = New System.Drawing.Size(47, 20)
        Me.nudPlotCharacter.TabIndex = 15
        '
        'lblLineWidth
        '
        Me.lblLineWidth.AutoSize = True
        Me.lblLineWidth.Location = New System.Drawing.Point(27, 151)
        Me.lblLineWidth.Name = "lblLineWidth"
        Me.lblLineWidth.Size = New System.Drawing.Size(55, 13)
        Me.lblLineWidth.TabIndex = 16
        Me.lblLineWidth.Tag = "Line_width"
        Me.lblLineWidth.Text = "Line width"
        '
        'lblPlotCharacter
        '
        Me.lblPlotCharacter.AutoSize = True
        Me.lblPlotCharacter.Location = New System.Drawing.Point(27, 177)
        Me.lblPlotCharacter.Name = "lblPlotCharacter"
        Me.lblPlotCharacter.Size = New System.Drawing.Size(73, 13)
        Me.lblPlotCharacter.TabIndex = 17
        Me.lblPlotCharacter.Tag = "Plot_character"
        Me.lblPlotCharacter.Text = "Plot character"
        '
        'lblColourRainbow
        '
        Me.lblColourRainbow.AutoSize = True
        Me.lblColourRainbow.Location = New System.Drawing.Point(27, 203)
        Me.lblColourRainbow.Name = "lblColourRainbow"
        Me.lblColourRainbow.Size = New System.Drawing.Size(77, 13)
        Me.lblColourRainbow.TabIndex = 18
        Me.lblColourRainbow.Tag = "Colour_rainbow"
        Me.lblColourRainbow.Text = "Colour rainbow"
        '
        'nudColourRainbow
        '
        Me.nudColourRainbow.Location = New System.Drawing.Point(127, 196)
        Me.nudColourRainbow.Name = "nudColourRainbow"
        Me.nudColourRainbow.Size = New System.Drawing.Size(47, 20)
        Me.nudColourRainbow.TabIndex = 19
        '
        'lblLegendLabel
        '
        Me.lblLegendLabel.AutoSize = True
        Me.lblLegendLabel.Location = New System.Drawing.Point(27, 255)
        Me.lblLegendLabel.Name = "lblLegendLabel"
        Me.lblLegendLabel.Size = New System.Drawing.Size(68, 13)
        Me.lblLegendLabel.TabIndex = 20
        Me.lblLegendLabel.Tag = "Legend_Label"
        Me.lblLegendLabel.Text = "Legend label"
        '
        'lblLegendBty
        '
        Me.lblLegendBty.AutoSize = True
        Me.lblLegendBty.Location = New System.Drawing.Point(27, 229)
        Me.lblLegendBty.Name = "lblLegendBty"
        Me.lblLegendBty.Size = New System.Drawing.Size(56, 13)
        Me.lblLegendBty.TabIndex = 21
        Me.lblLegendBty.Tag = "legend_bty"
        Me.lblLegendBty.Text = "legend bty"
        '
        'txtLegendBtype
        '
        Me.txtLegendBtype.Location = New System.Drawing.Point(127, 222)
        Me.txtLegendBtype.Name = "txtLegendBtype"
        Me.txtLegendBtype.Size = New System.Drawing.Size(100, 20)
        Me.txtLegendBtype.TabIndex = 22
        '
        'txtLegendLabel
        '
        Me.txtLegendLabel.Location = New System.Drawing.Point(127, 248)
        Me.txtLegendLabel.Name = "txtLegendLabel"
        Me.txtLegendLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtLegendLabel.TabIndex = 23
        '
        'dlgCumulativeExceedance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 404)
        Me.Controls.Add(Me.txtLegendLabel)
        Me.Controls.Add(Me.txtLegendBtype)
        Me.Controls.Add(Me.lblLegendBty)
        Me.Controls.Add(Me.lblLegendLabel)
        Me.Controls.Add(Me.nudColourRainbow)
        Me.Controls.Add(Me.lblColourRainbow)
        Me.Controls.Add(Me.lblPlotCharacter)
        Me.Controls.Add(Me.lblLineWidth)
        Me.Controls.Add(Me.nudPlotCharacter)
        Me.Controls.Add(Me.nudLineWidth)
        Me.Controls.Add(Me.lblLegendPosition)
        Me.Controls.Add(Me.txtLegendPosition)
        Me.Controls.Add(Me.txtYLabel)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblDataperiodLabel)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblInterestedVariable)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtDataperiodLabel)
        Me.Controls.Add(Me.txtXLabel)
        Me.Controls.Add(Me.txtInterestedVariable)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.grpOptioins)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCumulativeExceedance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Cumulative_exceedance"
        Me.Text = "Cumulative exceedance"
        Me.grpOptioins.ResumeLayout(False)
        Me.grpOptioins.PerformLayout()
        CType(Me.nudLineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColourRainbow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpOptioins As GroupBox
    Friend WithEvents chkPlotWindow As CheckBox
    Friend WithEvents chkGridSquare As CheckBox
    Friend WithEvents chkStationName As CheckBox
    Friend WithEvents chkPercents As CheckBox
    Friend WithEvents chkCumulativeGraph As CheckBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtInterestedVariable As TextBox
    Friend WithEvents txtXLabel As TextBox
    Friend WithEvents txtDataperiodLabel As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInterestedVariable As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents lblDataperiodLabel As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents txtYLabel As TextBox
    Friend WithEvents txtLegendPosition As TextBox
    Friend WithEvents lblLegendPosition As Label
    Friend WithEvents nudLineWidth As NumericUpDown
    Friend WithEvents nudPlotCharacter As NumericUpDown
    Friend WithEvents lblLineWidth As Label
    Friend WithEvents lblPlotCharacter As Label
    Friend WithEvents lblColourRainbow As Label
    Friend WithEvents nudColourRainbow As NumericUpDown
    Friend WithEvents lblLegendLabel As Label
    Friend WithEvents lblLegendBty As Label
    Friend WithEvents txtLegendBtype As TextBox
    Friend WithEvents txtLegendLabel As TextBox
End Class
