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
Partial Class dlgCliBoxplot
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
        Me.chkVarwidth = New System.Windows.Forms.CheckBox()
        Me.chkAdd = New System.Windows.Forms.CheckBox()
        Me.chkNotch = New System.Windows.Forms.CheckBox()
        Me.chkOutline = New System.Windows.Forms.CheckBox()
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.chkFactorLevel = New System.Windows.Forms.CheckBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkMonthAbbreviations = New System.Windows.Forms.CheckBox()
        Me.chkHorizontal = New System.Windows.Forms.CheckBox()
        Me.nudRange = New System.Windows.Forms.NumericUpDown()
        Me.nudWhisklty = New System.Windows.Forms.NumericUpDown()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblWhiskLineType = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.lblDataPeriodLabel = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblBorder = New System.Windows.Forms.Label()
        Me.lblAT = New System.Windows.Forms.Label()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblpars = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrInputDataPeriod = New instat.ucrInputTextBox()
        Me.ucrInputVariable = New instat.ucrInputTextBox()
        Me.ucrInputXLabel = New instat.ucrInputTextBox()
        Me.ucrInputWidth = New instat.ucrInputTextBox()
        Me.ucrInputYLabel = New instat.ucrInputTextBox()
        Me.ucrInputFactorLab = New instat.ucrInputTextBox()
        Me.ucrInputColour = New instat.ucrInputTextBox()
        Me.ucrInputLog = New instat.ucrInputTextBox()
        Me.ucrInputAt = New instat.ucrInputTextBox()
        Me.ucrInputBorder = New instat.ucrInputTextBox()
        Me.ucrInputPars = New instat.ucrInputTextBox()
        Me.grpOptions.SuspendLayout()
        CType(Me.nudRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWhisklty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'chkVarwidth
        '
        Me.chkVarwidth.AutoSize = True
        Me.chkVarwidth.Location = New System.Drawing.Point(6, 42)
        Me.chkVarwidth.Name = "chkVarwidth"
        Me.chkVarwidth.Size = New System.Drawing.Size(95, 17)
        Me.chkVarwidth.TabIndex = 3
        Me.chkVarwidth.Tag = "Variable_Width"
        Me.chkVarwidth.Text = "Variable Width"
        Me.chkVarwidth.UseVisualStyleBackColor = True
        '
        'chkAdd
        '
        Me.chkAdd.AutoSize = True
        Me.chkAdd.Location = New System.Drawing.Point(6, 19)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(45, 17)
        Me.chkAdd.TabIndex = 4
        Me.chkAdd.Tag = "add"
        Me.chkAdd.Text = "Add"
        Me.chkAdd.UseVisualStyleBackColor = True
        '
        'chkNotch
        '
        Me.chkNotch.AutoSize = True
        Me.chkNotch.Location = New System.Drawing.Point(6, 65)
        Me.chkNotch.Name = "chkNotch"
        Me.chkNotch.Size = New System.Drawing.Size(55, 17)
        Me.chkNotch.TabIndex = 5
        Me.chkNotch.Tag = "Notch"
        Me.chkNotch.Text = "Notch"
        Me.chkNotch.UseVisualStyleBackColor = True
        '
        'chkOutline
        '
        Me.chkOutline.AutoSize = True
        Me.chkOutline.Location = New System.Drawing.Point(6, 88)
        Me.chkOutline.Name = "chkOutline"
        Me.chkOutline.Size = New System.Drawing.Size(59, 17)
        Me.chkOutline.TabIndex = 6
        Me.chkOutline.Tag = "Outline"
        Me.chkOutline.Text = "Outline"
        Me.chkOutline.UseVisualStyleBackColor = True
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Location = New System.Drawing.Point(61, 19)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(44, 17)
        Me.chkPlot.TabIndex = 7
        Me.chkPlot.Tag = "Plot"
        Me.chkPlot.Text = "Plot"
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'chkFactorLevel
        '
        Me.chkFactorLevel.AutoSize = True
        Me.chkFactorLevel.Location = New System.Drawing.Point(132, 65)
        Me.chkFactorLevel.Name = "chkFactorLevel"
        Me.chkFactorLevel.Size = New System.Drawing.Size(85, 17)
        Me.chkFactorLevel.TabIndex = 8
        Me.chkFactorLevel.Tag = "Factor_Level"
        Me.chkFactorLevel.Text = "Factor Level"
        Me.chkFactorLevel.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkMonthAbbreviations)
        Me.grpOptions.Controls.Add(Me.chkHorizontal)
        Me.grpOptions.Controls.Add(Me.chkFactorLevel)
        Me.grpOptions.Controls.Add(Me.chkVarwidth)
        Me.grpOptions.Controls.Add(Me.chkAdd)
        Me.grpOptions.Controls.Add(Me.chkNotch)
        Me.grpOptions.Controls.Add(Me.chkOutline)
        Me.grpOptions.Controls.Add(Me.chkPlot)
        Me.grpOptions.Location = New System.Drawing.Point(256, 148)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(251, 116)
        Me.grpOptions.TabIndex = 9
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(132, 19)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(123, 17)
        Me.chkMonthAbbreviations.TabIndex = 10
        Me.chkMonthAbbreviations.Tag = "Month_Abbreviations"
        Me.chkMonthAbbreviations.Text = "Month Abbreviations"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'chkHorizontal
        '
        Me.chkHorizontal.AutoSize = True
        Me.chkHorizontal.Location = New System.Drawing.Point(132, 42)
        Me.chkHorizontal.Name = "chkHorizontal"
        Me.chkHorizontal.Size = New System.Drawing.Size(73, 17)
        Me.chkHorizontal.TabIndex = 9
        Me.chkHorizontal.Tag = "Horizontal"
        Me.chkHorizontal.Text = "Horizontal"
        Me.chkHorizontal.UseVisualStyleBackColor = True
        '
        'nudRange
        '
        Me.nudRange.Location = New System.Drawing.Point(449, 273)
        Me.nudRange.Name = "nudRange"
        Me.nudRange.Size = New System.Drawing.Size(58, 20)
        Me.nudRange.TabIndex = 11
        '
        'nudWhisklty
        '
        Me.nudWhisklty.Location = New System.Drawing.Point(132, 268)
        Me.nudWhisklty.Name = "nudWhisklty"
        Me.nudWhisklty.Size = New System.Drawing.Size(58, 20)
        Me.nudWhisklty.TabIndex = 12
        '
        'nudThreshold
        '
        Me.nudThreshold.Location = New System.Drawing.Point(272, 270)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(58, 20)
        Me.nudThreshold.TabIndex = 13
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(355, 277)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(39, 13)
        Me.lblRange.TabIndex = 14
        Me.lblRange.Tag = "Range"
        Me.lblRange.Text = "Range"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(212, 275)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 15
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'lblWhiskLineType
        '
        Me.lblWhiskLineType.AutoSize = True
        Me.lblWhiskLineType.Location = New System.Drawing.Point(30, 272)
        Me.lblWhiskLineType.Name = "lblWhiskLineType"
        Me.lblWhiskLineType.Size = New System.Drawing.Size(87, 13)
        Me.lblWhiskLineType.TabIndex = 16
        Me.lblWhiskLineType.Tag = "Whisk_line_type"
        Me.lblWhiskLineType.Text = "Whisk Line Type"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(30, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(30, 69)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(45, 13)
        Me.lblVariable.TabIndex = 15
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Variable"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(30, 95)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblYLabel.TabIndex = 16
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Y Label"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(32, 121)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblXLabel.TabIndex = 17
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "X Label"
        '
        'lblDataPeriodLabel
        '
        Me.lblDataPeriodLabel.AutoSize = True
        Me.lblDataPeriodLabel.Location = New System.Drawing.Point(25, 148)
        Me.lblDataPeriodLabel.Name = "lblDataPeriodLabel"
        Me.lblDataPeriodLabel.Size = New System.Drawing.Size(92, 13)
        Me.lblDataPeriodLabel.TabIndex = 18
        Me.lblDataPeriodLabel.Tag = "Data_Period_Label"
        Me.lblDataPeriodLabel.Text = "Data Period Label"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(30, 174)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 19
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(30, 201)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 20
        Me.lblWidth.Tag = "Width"
        Me.lblWidth.Text = "Width"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(30, 229)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(37, 13)
        Me.lblColour.TabIndex = 21
        Me.lblColour.Tag = "Colour"
        Me.lblColour.Text = "Colour"
        '
        'lblBorder
        '
        Me.lblBorder.AutoSize = True
        Me.lblBorder.Location = New System.Drawing.Point(241, 95)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(38, 13)
        Me.lblBorder.TabIndex = 22
        Me.lblBorder.Tag = "Border"
        Me.lblBorder.Text = "Border"
        '
        'lblAT
        '
        Me.lblAT.AutoSize = True
        Me.lblAT.Location = New System.Drawing.Point(241, 69)
        Me.lblAT.Name = "lblAT"
        Me.lblAT.Size = New System.Drawing.Size(21, 13)
        Me.lblAT.TabIndex = 23
        Me.lblAT.Tag = "AT"
        Me.lblAT.Text = "AT"
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(241, 43)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(25, 13)
        Me.lblLog.TabIndex = 24
        Me.lblLog.Tag = "Log"
        Me.lblLog.Text = "Log"
        '
        'lblpars
        '
        Me.lblpars.AutoSize = True
        Me.lblpars.Location = New System.Drawing.Point(241, 121)
        Me.lblpars.Name = "lblpars"
        Me.lblpars.Size = New System.Drawing.Size(28, 13)
        Me.lblpars.TabIndex = 25
        Me.lblpars.Tag = "pars"
        Me.lblpars.Text = "Pars"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(33, 296)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(128, 36)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputTitle.TabIndex = 27
        '
        'ucrInputDataPeriod
        '
        Me.ucrInputDataPeriod.AddQuotesIfUnrecognised = True
        Me.ucrInputDataPeriod.AutoSize = True
        Me.ucrInputDataPeriod.IsMultiline = False
        Me.ucrInputDataPeriod.IsReadOnly = False
        Me.ucrInputDataPeriod.Location = New System.Drawing.Point(128, 140)
        Me.ucrInputDataPeriod.Name = "ucrInputDataPeriod"
        Me.ucrInputDataPeriod.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputDataPeriod.TabIndex = 27
        '
        'ucrInputVariable
        '
        Me.ucrInputVariable.AddQuotesIfUnrecognised = True
        Me.ucrInputVariable.AutoSize = True
        Me.ucrInputVariable.IsMultiline = False
        Me.ucrInputVariable.IsReadOnly = False
        Me.ucrInputVariable.Location = New System.Drawing.Point(128, 61)
        Me.ucrInputVariable.Name = "ucrInputVariable"
        Me.ucrInputVariable.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputVariable.TabIndex = 27
        '
        'ucrInputXLabel
        '
        Me.ucrInputXLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputXLabel.AutoSize = True
        Me.ucrInputXLabel.IsMultiline = False
        Me.ucrInputXLabel.IsReadOnly = False
        Me.ucrInputXLabel.Location = New System.Drawing.Point(128, 113)
        Me.ucrInputXLabel.Name = "ucrInputXLabel"
        Me.ucrInputXLabel.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputXLabel.TabIndex = 27
        '
        'ucrInputWidth
        '
        Me.ucrInputWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputWidth.AutoSize = True
        Me.ucrInputWidth.IsMultiline = False
        Me.ucrInputWidth.IsReadOnly = False
        Me.ucrInputWidth.Location = New System.Drawing.Point(128, 193)
        Me.ucrInputWidth.Name = "ucrInputWidth"
        Me.ucrInputWidth.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputWidth.TabIndex = 28
        '
        'ucrInputYLabel
        '
        Me.ucrInputYLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputYLabel.AutoSize = True
        Me.ucrInputYLabel.IsMultiline = False
        Me.ucrInputYLabel.IsReadOnly = False
        Me.ucrInputYLabel.Location = New System.Drawing.Point(128, 87)
        Me.ucrInputYLabel.Name = "ucrInputYLabel"
        Me.ucrInputYLabel.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputYLabel.TabIndex = 29
        '
        'ucrInputFactorLab
        '
        Me.ucrInputFactorLab.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorLab.AutoSize = True
        Me.ucrInputFactorLab.IsMultiline = False
        Me.ucrInputFactorLab.IsReadOnly = False
        Me.ucrInputFactorLab.Location = New System.Drawing.Point(128, 166)
        Me.ucrInputFactorLab.Name = "ucrInputFactorLab"
        Me.ucrInputFactorLab.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputFactorLab.TabIndex = 30
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.AutoSize = True
        Me.ucrInputColour.IsMultiline = False
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(128, 221)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputColour.TabIndex = 31
        '
        'ucrInputLog
        '
        Me.ucrInputLog.AddQuotesIfUnrecognised = True
        Me.ucrInputLog.AutoSize = True
        Me.ucrInputLog.IsMultiline = False
        Me.ucrInputLog.IsReadOnly = False
        Me.ucrInputLog.Location = New System.Drawing.Point(282, 35)
        Me.ucrInputLog.Name = "ucrInputLog"
        Me.ucrInputLog.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputLog.TabIndex = 32
        '
        'ucrInputAt
        '
        Me.ucrInputAt.AddQuotesIfUnrecognised = True
        Me.ucrInputAt.AutoSize = True
        Me.ucrInputAt.IsMultiline = False
        Me.ucrInputAt.IsReadOnly = False
        Me.ucrInputAt.Location = New System.Drawing.Point(282, 63)
        Me.ucrInputAt.Name = "ucrInputAt"
        Me.ucrInputAt.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputAt.TabIndex = 33
        '
        'ucrInputBorder
        '
        Me.ucrInputBorder.AddQuotesIfUnrecognised = True
        Me.ucrInputBorder.AutoSize = True
        Me.ucrInputBorder.IsMultiline = False
        Me.ucrInputBorder.IsReadOnly = False
        Me.ucrInputBorder.Location = New System.Drawing.Point(282, 86)
        Me.ucrInputBorder.Name = "ucrInputBorder"
        Me.ucrInputBorder.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputBorder.TabIndex = 34
        '
        'ucrInputPars
        '
        Me.ucrInputPars.AddQuotesIfUnrecognised = True
        Me.ucrInputPars.AutoSize = True
        Me.ucrInputPars.IsMultiline = False
        Me.ucrInputPars.IsReadOnly = False
        Me.ucrInputPars.Location = New System.Drawing.Point(282, 112)
        Me.ucrInputPars.Name = "ucrInputPars"
        Me.ucrInputPars.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputPars.TabIndex = 35
        '
        'dlgCliBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(518, 359)
        Me.Controls.Add(Me.ucrInputPars)
        Me.Controls.Add(Me.ucrInputBorder)
        Me.Controls.Add(Me.ucrInputAt)
        Me.Controls.Add(Me.ucrInputLog)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.ucrInputFactorLab)
        Me.Controls.Add(Me.ucrInputYLabel)
        Me.Controls.Add(Me.ucrInputWidth)
        Me.Controls.Add(Me.ucrInputVariable)
        Me.Controls.Add(Me.ucrInputXLabel)
        Me.Controls.Add(Me.ucrInputDataPeriod)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.lblpars)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.lblAT)
        Me.Controls.Add(Me.lblBorder)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblDataPeriodLabel)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblWhiskLineType)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.nudRange)
        Me.Controls.Add(Me.nudWhisklty)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCliBoxplot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliboxplot"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        CType(Me.nudRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWhisklty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents chkVarwidth As CheckBox
    Friend WithEvents chkAdd As CheckBox
    Friend WithEvents chkNotch As CheckBox
    Friend WithEvents chkOutline As CheckBox
    Friend WithEvents chkPlot As CheckBox
    Friend WithEvents chkFactorLevel As CheckBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents chkMonthAbbreviations As CheckBox
    Friend WithEvents chkHorizontal As CheckBox
    Friend WithEvents nudRange As NumericUpDown
    Friend WithEvents nudWhisklty As NumericUpDown
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents lblRange As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblWhiskLineType As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents lblDataPeriodLabel As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents lblBorder As Label
    Friend WithEvents lblAT As Label
    Friend WithEvents lblLog As Label
    Friend WithEvents lblpars As Label
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrInputDataPeriod As ucrInputTextBox
    Friend WithEvents ucrInputVariable As ucrInputTextBox
    Friend WithEvents ucrInputXLabel As ucrInputTextBox
    Friend WithEvents ucrInputWidth As ucrInputTextBox
    Friend WithEvents ucrInputYLabel As ucrInputTextBox
    Friend WithEvents ucrInputFactorLab As ucrInputTextBox
    Friend WithEvents ucrInputColour As ucrInputTextBox
    Friend WithEvents ucrInputLog As ucrInputTextBox
    Friend WithEvents ucrInputAt As ucrInputTextBox
    Friend WithEvents ucrInputBorder As ucrInputTextBox
    Friend WithEvents ucrInputPars As ucrInputTextBox
End Class
