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
        Me.ucrBase = New instat.ucrButtons()
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
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtFactor = New System.Windows.Forms.TextBox()
        Me.txtDataPeriodLabel = New System.Windows.Forms.TextBox()
        Me.txtXLabel = New System.Windows.Forms.TextBox()
        Me.txtYLabel = New System.Windows.Forms.TextBox()
        Me.txtVariable = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtBorder = New System.Windows.Forms.TextBox()
        Me.txtAT = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
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
        Me.txtPARS = New System.Windows.Forms.TextBox()
        Me.grpOptions.SuspendLayout()
        CType(Me.nudRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWhisklty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(54, 376)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
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
        Me.chkVarwidth.Location = New System.Drawing.Point(10, 73)
        Me.chkVarwidth.Name = "chkVarwidth"
        Me.chkVarwidth.Size = New System.Drawing.Size(81, 17)
        Me.chkVarwidth.TabIndex = 3
        Me.chkVarwidth.Tag = "varwidth"
        Me.chkVarwidth.Text = "CheckBox2"
        Me.chkVarwidth.UseVisualStyleBackColor = True
        '
        'chkAdd
        '
        Me.chkAdd.AutoSize = True
        Me.chkAdd.Location = New System.Drawing.Point(10, 28)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(81, 17)
        Me.chkAdd.TabIndex = 4
        Me.chkAdd.Tag = "add"
        Me.chkAdd.Text = "CheckBox3"
        Me.chkAdd.UseVisualStyleBackColor = True
        '
        'chkNotch
        '
        Me.chkNotch.AutoSize = True
        Me.chkNotch.Location = New System.Drawing.Point(10, 110)
        Me.chkNotch.Name = "chkNotch"
        Me.chkNotch.Size = New System.Drawing.Size(81, 17)
        Me.chkNotch.TabIndex = 5
        Me.chkNotch.Tag = "notch"
        Me.chkNotch.Text = "CheckBox4"
        Me.chkNotch.UseVisualStyleBackColor = True
        '
        'chkOutline
        '
        Me.chkOutline.AutoSize = True
        Me.chkOutline.Location = New System.Drawing.Point(118, 28)
        Me.chkOutline.Name = "chkOutline"
        Me.chkOutline.Size = New System.Drawing.Size(81, 17)
        Me.chkOutline.TabIndex = 6
        Me.chkOutline.Tag = "outline"
        Me.chkOutline.Text = "CheckBox5"
        Me.chkOutline.UseVisualStyleBackColor = True
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Location = New System.Drawing.Point(118, 73)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(81, 17)
        Me.chkPlot.TabIndex = 7
        Me.chkPlot.Tag = "plot"
        Me.chkPlot.Text = "CheckBox6"
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'chkFactorLevel
        '
        Me.chkFactorLevel.AutoSize = True
        Me.chkFactorLevel.Location = New System.Drawing.Point(118, 110)
        Me.chkFactorLevel.Name = "chkFactorLevel"
        Me.chkFactorLevel.Size = New System.Drawing.Size(81, 17)
        Me.chkFactorLevel.TabIndex = 8
        Me.chkFactorLevel.Tag = "Factor_Level"
        Me.chkFactorLevel.Text = "CheckBox7"
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
        Me.grpOptions.Location = New System.Drawing.Point(211, 239)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(342, 134)
        Me.grpOptions.TabIndex = 9
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(238, 73)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(81, 17)
        Me.chkMonthAbbreviations.TabIndex = 10
        Me.chkMonthAbbreviations.Tag = "Month_Abb"
        Me.chkMonthAbbreviations.Text = "CheckBox9"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'chkHorizontal
        '
        Me.chkHorizontal.AutoSize = True
        Me.chkHorizontal.Location = New System.Drawing.Point(238, 29)
        Me.chkHorizontal.Name = "chkHorizontal"
        Me.chkHorizontal.Size = New System.Drawing.Size(81, 17)
        Me.chkHorizontal.TabIndex = 9
        Me.chkHorizontal.Tag = "Horizontal"
        Me.chkHorizontal.Text = "CheckBox8"
        Me.chkHorizontal.UseVisualStyleBackColor = True
        '
        'nudRange
        '
        Me.nudRange.Location = New System.Drawing.Point(132, 309)
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
        Me.nudThreshold.Location = New System.Drawing.Point(132, 286)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(58, 20)
        Me.nudThreshold.TabIndex = 13
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(30, 312)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(39, 13)
        Me.lblRange.TabIndex = 14
        Me.lblRange.Text = "Label2"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(30, 293)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold.TabIndex = 15
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label3"
        '
        'lblWhiskLineType
        '
        Me.lblWhiskLineType.AutoSize = True
        Me.lblWhiskLineType.Location = New System.Drawing.Point(30, 272)
        Me.lblWhiskLineType.Name = "lblWhiskLineType"
        Me.lblWhiskLineType.Size = New System.Drawing.Size(39, 13)
        Me.lblWhiskLineType.TabIndex = 16
        Me.lblWhiskLineType.Tag = "Whisk_line_type"
        Me.lblWhiskLineType.Text = "Label4"
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(132, 213)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(100, 20)
        Me.txtColour.TabIndex = 11
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(132, 189)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 12
        '
        'txtFactor
        '
        Me.txtFactor.Location = New System.Drawing.Point(132, 166)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(100, 20)
        Me.txtFactor.TabIndex = 13
        '
        'txtDataPeriodLabel
        '
        Me.txtDataPeriodLabel.Location = New System.Drawing.Point(132, 140)
        Me.txtDataPeriodLabel.Name = "txtDataPeriodLabel"
        Me.txtDataPeriodLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtDataPeriodLabel.TabIndex = 14
        '
        'txtXLabel
        '
        Me.txtXLabel.Location = New System.Drawing.Point(132, 114)
        Me.txtXLabel.Name = "txtXLabel"
        Me.txtXLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtXLabel.TabIndex = 15
        '
        'txtYLabel
        '
        Me.txtYLabel.Location = New System.Drawing.Point(132, 88)
        Me.txtYLabel.Name = "txtYLabel"
        Me.txtYLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtYLabel.TabIndex = 16
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(132, 62)
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtVariable.TabIndex = 17
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(132, 36)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 18
        Me.txtTitle.Tag = ""
        '
        'txtBorder
        '
        Me.txtBorder.Location = New System.Drawing.Point(395, 92)
        Me.txtBorder.Name = "txtBorder"
        Me.txtBorder.Size = New System.Drawing.Size(100, 20)
        Me.txtBorder.TabIndex = 11
        '
        'txtAT
        '
        Me.txtAT.Location = New System.Drawing.Point(395, 66)
        Me.txtAT.Name = "txtAT"
        Me.txtAT.Size = New System.Drawing.Size(100, 20)
        Me.txtAT.TabIndex = 12
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(395, 36)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(100, 20)
        Me.txtLog.TabIndex = 13
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(30, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Label2"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(30, 69)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(39, 13)
        Me.lblVariable.TabIndex = 15
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Label3"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(30, 95)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblYLabel.TabIndex = 16
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Label4"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(30, 117)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblXLabel.TabIndex = 17
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "Label5"
        '
        'lblDataPeriodLabel
        '
        Me.lblDataPeriodLabel.AutoSize = True
        Me.lblDataPeriodLabel.Location = New System.Drawing.Point(30, 143)
        Me.lblDataPeriodLabel.Name = "lblDataPeriodLabel"
        Me.lblDataPeriodLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblDataPeriodLabel.TabIndex = 18
        Me.lblDataPeriodLabel.Tag = "Data_Period_Label"
        Me.lblDataPeriodLabel.Text = "Label6"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(30, 166)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(39, 13)
        Me.lblFactor.TabIndex = 19
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Label7"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(30, 192)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(39, 13)
        Me.lblWidth.TabIndex = 20
        Me.lblWidth.Tag = "Width"
        Me.lblWidth.Text = "Label8"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(30, 216)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(39, 13)
        Me.lblColour.TabIndex = 21
        Me.lblColour.Tag = "Colour"
        Me.lblColour.Text = "Label9"
        '
        'lblBorder
        '
        Me.lblBorder.AutoSize = True
        Me.lblBorder.Location = New System.Drawing.Point(324, 95)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(45, 13)
        Me.lblBorder.TabIndex = 22
        Me.lblBorder.Tag = "Border"
        Me.lblBorder.Text = "Label10"
        '
        'lblAT
        '
        Me.lblAT.AutoSize = True
        Me.lblAT.Location = New System.Drawing.Point(324, 73)
        Me.lblAT.Name = "lblAT"
        Me.lblAT.Size = New System.Drawing.Size(45, 13)
        Me.lblAT.TabIndex = 23
        Me.lblAT.Tag = "at"
        Me.lblAT.Text = "Label11"
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(324, 43)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(45, 13)
        Me.lblLog.TabIndex = 24
        Me.lblLog.Tag = "Log"
        Me.lblLog.Text = "Label12"
        '
        'lblpars
        '
        Me.lblpars.AutoSize = True
        Me.lblpars.Location = New System.Drawing.Point(324, 121)
        Me.lblpars.Name = "lblpars"
        Me.lblpars.Size = New System.Drawing.Size(45, 13)
        Me.lblpars.TabIndex = 25
        Me.lblpars.Tag = "pars"
        Me.lblpars.Text = "Label13"
        '
        'txtPARS
        '
        Me.txtPARS.Location = New System.Drawing.Point(395, 118)
        Me.txtPARS.Name = "txtPARS"
        Me.txtPARS.Size = New System.Drawing.Size(100, 20)
        Me.txtPARS.TabIndex = 26
        '
        'dlgCliBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 409)
        Me.Controls.Add(Me.txtPARS)
        Me.Controls.Add(Me.lblpars)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.lblAT)
        Me.Controls.Add(Me.lblBorder)
        Me.Controls.Add(Me.txtBorder)
        Me.Controls.Add(Me.txtAT)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblDataPeriodLabel)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtFactor)
        Me.Controls.Add(Me.txtDataPeriodLabel)
        Me.Controls.Add(Me.txtXLabel)
        Me.Controls.Add(Me.txtYLabel)
        Me.Controls.Add(Me.txtVariable)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblWhiskLineType)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.nudRange)
        Me.Controls.Add(Me.nudWhisklty)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.Name = "dlgCliBoxplot"
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
    Friend WithEvents txtColour As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtFactor As TextBox
    Friend WithEvents txtDataPeriodLabel As TextBox
    Friend WithEvents txtXLabel As TextBox
    Friend WithEvents txtYLabel As TextBox
    Friend WithEvents txtVariable As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtBorder As TextBox
    Friend WithEvents txtAT As TextBox
    Friend WithEvents txtLog As TextBox
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
    Friend WithEvents txtPARS As TextBox
End Class
