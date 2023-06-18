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
Partial Class dlgThreeSummaries
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
        Me.lblLinetype = New System.Windows.Forms.Label()
        Me.lblLineWidth = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblYlabel = New System.Windows.Forms.Label()
        Me.lblPlotType = New System.Windows.Forms.Label()
        Me.lblMaximum = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.nudlineWidth = New System.Windows.Forms.NumericUpDown()
        Me.nudPlotCharacter = New System.Windows.Forms.NumericUpDown()
        Me.nudLineType = New System.Windows.Forms.NumericUpDown()
        Me.txtColourMaximum = New System.Windows.Forms.TextBox()
        Me.txtColourMean = New System.Windows.Forms.TextBox()
        Me.txtPlotType = New System.Windows.Forms.TextBox()
        Me.txtColourMinimum = New System.Windows.Forms.TextBox()
        Me.txtYlabel = New System.Windows.Forms.TextBox()
        Me.txtVariable = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.grpColour = New System.Windows.Forms.GroupBox()
        Me.lblPlotCharacter = New System.Windows.Forms.Label()
        CType(Me.nudlineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLineType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpColour.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 303)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'lblLinetype
        '
        Me.lblLinetype.AutoSize = True
        Me.lblLinetype.Location = New System.Drawing.Point(12, 214)
        Me.lblLinetype.Name = "lblLinetype"
        Me.lblLinetype.Size = New System.Drawing.Size(39, 13)
        Me.lblLinetype.TabIndex = 1
        Me.lblLinetype.Tag = "Line_type"
        Me.lblLinetype.Text = "Label1"
        '
        'lblLineWidth
        '
        Me.lblLineWidth.AutoSize = True
        Me.lblLineWidth.Location = New System.Drawing.Point(54, 265)
        Me.lblLineWidth.Name = "lblLineWidth"
        Me.lblLineWidth.Size = New System.Drawing.Size(39, 13)
        Me.lblLineWidth.TabIndex = 2
        Me.lblLineWidth.Tag = "Line_Width"
        Me.lblLineWidth.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data list not implemented"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(54, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Label4"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(54, 42)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(39, 13)
        Me.lblVariable.TabIndex = 5
        Me.lblVariable.Text = "Label5"
        '
        'lblYlabel
        '
        Me.lblYlabel.AutoSize = True
        Me.lblYlabel.Location = New System.Drawing.Point(54, 62)
        Me.lblYlabel.Name = "lblYlabel"
        Me.lblYlabel.Size = New System.Drawing.Size(39, 13)
        Me.lblYlabel.TabIndex = 6
        Me.lblYlabel.Tag = "Y_label"
        Me.lblYlabel.Text = "Label6"
        '
        'lblPlotType
        '
        Me.lblPlotType.AutoSize = True
        Me.lblPlotType.Location = New System.Drawing.Point(231, 256)
        Me.lblPlotType.Name = "lblPlotType"
        Me.lblPlotType.Size = New System.Drawing.Size(39, 13)
        Me.lblPlotType.TabIndex = 7
        Me.lblPlotType.Tag = "Plot_Type"
        Me.lblPlotType.Text = "Label7"
        '
        'lblMaximum
        '
        Me.lblMaximum.AutoSize = True
        Me.lblMaximum.Location = New System.Drawing.Point(6, 22)
        Me.lblMaximum.Name = "lblMaximum"
        Me.lblMaximum.Size = New System.Drawing.Size(39, 13)
        Me.lblMaximum.TabIndex = 8
        Me.lblMaximum.Tag = "Mean"
        Me.lblMaximum.Text = "Label8"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(91, 55)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(39, 13)
        Me.lblMean.TabIndex = 9
        Me.lblMean.Text = "Label9"
        '
        'lblMinimum
        '
        Me.lblMinimum.AutoSize = True
        Me.lblMinimum.Location = New System.Drawing.Point(6, 87)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(45, 13)
        Me.lblMinimum.TabIndex = 10
        Me.lblMinimum.Text = "Label10"
        '
        'nudlineWidth
        '
        Me.nudlineWidth.Location = New System.Drawing.Point(142, 254)
        Me.nudlineWidth.Name = "nudlineWidth"
        Me.nudlineWidth.Size = New System.Drawing.Size(49, 20)
        Me.nudlineWidth.TabIndex = 11
        '
        'nudPlotCharacter
        '
        Me.nudPlotCharacter.Location = New System.Drawing.Point(195, 207)
        Me.nudPlotCharacter.Name = "nudPlotCharacter"
        Me.nudPlotCharacter.Size = New System.Drawing.Size(49, 20)
        Me.nudPlotCharacter.TabIndex = 12
        '
        'nudLineType
        '
        Me.nudLineType.Location = New System.Drawing.Point(66, 207)
        Me.nudLineType.Name = "nudLineType"
        Me.nudLineType.Size = New System.Drawing.Size(49, 20)
        Me.nudLineType.TabIndex = 13
        '
        'txtColourMaximum
        '
        Me.txtColourMaximum.Location = New System.Drawing.Point(109, 19)
        Me.txtColourMaximum.Name = "txtColourMaximum"
        Me.txtColourMaximum.Size = New System.Drawing.Size(100, 20)
        Me.txtColourMaximum.TabIndex = 16
        '
        'txtColourMean
        '
        Me.txtColourMean.Location = New System.Drawing.Point(183, 52)
        Me.txtColourMean.Name = "txtColourMean"
        Me.txtColourMean.Size = New System.Drawing.Size(100, 20)
        Me.txtColourMean.TabIndex = 17
        '
        'txtPlotType
        '
        Me.txtPlotType.Location = New System.Drawing.Point(289, 249)
        Me.txtPlotType.Name = "txtPlotType"
        Me.txtPlotType.Size = New System.Drawing.Size(149, 20)
        Me.txtPlotType.TabIndex = 18
        '
        'txtColourMinimum
        '
        Me.txtColourMinimum.Location = New System.Drawing.Point(109, 87)
        Me.txtColourMinimum.Name = "txtColourMinimum"
        Me.txtColourMinimum.Size = New System.Drawing.Size(100, 20)
        Me.txtColourMinimum.TabIndex = 19
        '
        'txtYlabel
        '
        Me.txtYlabel.Location = New System.Drawing.Point(142, 59)
        Me.txtYlabel.Name = "txtYlabel"
        Me.txtYlabel.Size = New System.Drawing.Size(210, 20)
        Me.txtYlabel.TabIndex = 20
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(142, 39)
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(210, 20)
        Me.txtVariable.TabIndex = 21
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(142, 17)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(210, 20)
        Me.txtTitle.TabIndex = 22
        '
        'grpColour
        '
        Me.grpColour.Controls.Add(Me.txtColourMaximum)
        Me.grpColour.Controls.Add(Me.txtColourMinimum)
        Me.grpColour.Controls.Add(Me.txtColourMean)
        Me.grpColour.Controls.Add(Me.lblMinimum)
        Me.grpColour.Controls.Add(Me.lblMean)
        Me.grpColour.Controls.Add(Me.lblMaximum)
        Me.grpColour.Location = New System.Drawing.Point(12, 94)
        Me.grpColour.Name = "grpColour"
        Me.grpColour.Size = New System.Drawing.Size(411, 107)
        Me.grpColour.TabIndex = 23
        Me.grpColour.TabStop = False
        Me.grpColour.Tag = "Colour"
        Me.grpColour.Text = "Colours for Summaries"
        '
        'lblPlotCharacter
        '
        Me.lblPlotCharacter.AutoSize = True
        Me.lblPlotCharacter.Location = New System.Drawing.Point(152, 214)
        Me.lblPlotCharacter.Name = "lblPlotCharacter"
        Me.lblPlotCharacter.Size = New System.Drawing.Size(39, 13)
        Me.lblPlotCharacter.TabIndex = 24
        Me.lblPlotCharacter.Tag = "lblPlotCharacter"
        Me.lblPlotCharacter.Text = "Label4"
        '
        'dlgThreeSummaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(555, 378)
        Me.Controls.Add(Me.lblPlotCharacter)
        Me.Controls.Add(Me.grpColour)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtVariable)
        Me.Controls.Add(Me.txtYlabel)
        Me.Controls.Add(Me.txtPlotType)
        Me.Controls.Add(Me.nudLineType)
        Me.Controls.Add(Me.nudPlotCharacter)
        Me.Controls.Add(Me.nudlineWidth)
        Me.Controls.Add(Me.lblPlotType)
        Me.Controls.Add(Me.lblYlabel)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLineWidth)
        Me.Controls.Add(Me.lblLinetype)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeSummaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Three Summaries"
        CType(Me.nudlineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLineType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpColour.ResumeLayout(False)
        Me.grpColour.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblLinetype As Label
    Friend WithEvents lblLineWidth As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblYlabel As Label
    Friend WithEvents lblPlotType As Label
    Friend WithEvents lblMaximum As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents lblMinimum As Label
    Friend WithEvents nudlineWidth As NumericUpDown
    Friend WithEvents nudPlotCharacter As NumericUpDown
    Friend WithEvents nudLineType As NumericUpDown
    Friend WithEvents txtColourMaximum As TextBox
    Friend WithEvents txtColourMean As TextBox
    Friend WithEvents txtPlotType As TextBox
    Friend WithEvents txtColourMinimum As TextBox
    Friend WithEvents txtYlabel As TextBox
    Friend WithEvents txtVariable As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents grpColour As GroupBox
    Friend WithEvents lblPlotCharacter As Label
End Class