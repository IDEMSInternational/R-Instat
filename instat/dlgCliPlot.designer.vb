<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCliPlot
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
        Me.txtXLim = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtVariableY = New System.Windows.Forms.TextBox()
        Me.txtVariableX = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVariableX = New System.Windows.Forms.Label()
        Me.lblVariableY = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblXLimits = New System.Windows.Forms.Label()
        Me.lblYAxis = New System.Windows.Forms.Label()
        Me.txtYAxis = New System.Windows.Forms.TextBox()
        Me.txtXAxis = New System.Windows.Forms.TextBox()
        Me.lblXAxis = New System.Windows.Forms.Label()
        Me.lblLineType = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.txtStat = New System.Windows.Forms.TextBox()
        Me.txtYLim = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.txtDataperiodLabel = New System.Windows.Forms.TextBox()
        Me.lblDataperiodLabel = New System.Windows.Forms.Label()
        Me.lblYLim = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.txtFactorVariable = New System.Windows.Forms.TextBox()
        Me.txtVariableName = New System.Windows.Forms.TextBox()
        Me.lblVariableName = New System.Windows.Forms.Label()
        Me.txtShowLegend = New System.Windows.Forms.TextBox()
        Me.lblShowLegend = New System.Windows.Forms.Label()
        Me.ucrNudSize = New instat.ucrNud()
        Me.ucrNudLineType = New instat.ucrNud()
        Me.ucrChkStationName = New instat.ucrCheck()
        Me.ucrChkInheritAES = New instat.ucrCheck()
        Me.ucrChkRemoveNA = New instat.ucrCheck()
        Me.ucrChkByFactor = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(15, 323)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'txtXLim
        '
        Me.txtXLim.Location = New System.Drawing.Point(112, 128)
        Me.txtXLim.Name = "txtXLim"
        Me.txtXLim.Size = New System.Drawing.Size(100, 20)
        Me.txtXLim.TabIndex = 7
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(112, 99)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtPosition.TabIndex = 8
        '
        'txtVariableY
        '
        Me.txtVariableY.Location = New System.Drawing.Point(402, 63)
        Me.txtVariableY.Name = "txtVariableY"
        Me.txtVariableY.Size = New System.Drawing.Size(100, 20)
        Me.txtVariableY.TabIndex = 9
        '
        'txtVariableX
        '
        Me.txtVariableX.Location = New System.Drawing.Point(112, 63)
        Me.txtVariableX.Name = "txtVariableX"
        Me.txtVariableX.Size = New System.Drawing.Size(100, 20)
        Me.txtVariableX.TabIndex = 10
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(112, 37)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 11
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Tag = "Title:"
        Me.lblTitle.Text = "Title:"
        '
        'lblVariableX
        '
        Me.lblVariableX.AutoSize = True
        Me.lblVariableX.Location = New System.Drawing.Point(12, 70)
        Me.lblVariableX.Name = "lblVariableX"
        Me.lblVariableX.Size = New System.Drawing.Size(58, 13)
        Me.lblVariableX.TabIndex = 13
        Me.lblVariableX.Tag = "Variable_X:"
        Me.lblVariableX.Text = "Variable X:"
        '
        'lblVariableY
        '
        Me.lblVariableY.AutoSize = True
        Me.lblVariableY.Location = New System.Drawing.Point(304, 70)
        Me.lblVariableY.Name = "lblVariableY"
        Me.lblVariableY.Size = New System.Drawing.Size(58, 13)
        Me.lblVariableY.TabIndex = 14
        Me.lblVariableY.Tag = "Variable_Y:"
        Me.lblVariableY.Text = "Variable Y:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(12, 102)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 15
        Me.lblPosition.Tag = "Position:"
        Me.lblPosition.Text = "Position:"
        '
        'lblXLimits
        '
        Me.lblXLimits.AutoSize = True
        Me.lblXLimits.Location = New System.Drawing.Point(12, 135)
        Me.lblXLimits.Name = "lblXLimits"
        Me.lblXLimits.Size = New System.Drawing.Size(49, 13)
        Me.lblXLimits.TabIndex = 16
        Me.lblXLimits.Tag = "X_Limits:"
        Me.lblXLimits.Text = "X_Limits:"
        '
        'lblYAxis
        '
        Me.lblYAxis.AutoSize = True
        Me.lblYAxis.Location = New System.Drawing.Point(12, 187)
        Me.lblYAxis.Name = "lblYAxis"
        Me.lblYAxis.Size = New System.Drawing.Size(39, 13)
        Me.lblYAxis.TabIndex = 17
        Me.lblYAxis.Tag = "Y_Axis:"
        Me.lblYAxis.Text = "Y Axis:"
        '
        'txtYAxis
        '
        Me.txtYAxis.Location = New System.Drawing.Point(112, 180)
        Me.txtYAxis.Name = "txtYAxis"
        Me.txtYAxis.Size = New System.Drawing.Size(100, 20)
        Me.txtYAxis.TabIndex = 18
        Me.txtYAxis.Tag = ""
        '
        'txtXAxis
        '
        Me.txtXAxis.Location = New System.Drawing.Point(402, 180)
        Me.txtXAxis.Name = "txtXAxis"
        Me.txtXAxis.Size = New System.Drawing.Size(100, 20)
        Me.txtXAxis.TabIndex = 19
        '
        'lblXAxis
        '
        Me.lblXAxis.AutoSize = True
        Me.lblXAxis.Location = New System.Drawing.Point(304, 187)
        Me.lblXAxis.Name = "lblXAxis"
        Me.lblXAxis.Size = New System.Drawing.Size(39, 13)
        Me.lblXAxis.TabIndex = 20
        Me.lblXAxis.Tag = "X_Axis"
        Me.lblXAxis.Text = "X Axis:"
        '
        'lblLineType
        '
        Me.lblLineType.AutoSize = True
        Me.lblLineType.Location = New System.Drawing.Point(12, 245)
        Me.lblLineType.Name = "lblLineType"
        Me.lblLineType.Size = New System.Drawing.Size(57, 13)
        Me.lblLineType.TabIndex = 25
        Me.lblLineType.Tag = "Line_Type:"
        Me.lblLineType.Text = "Line Type:"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(12, 278)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 26
        Me.lblSize.Tag = "Size:"
        Me.lblSize.Text = "Size:"
        '
        'lblStat
        '
        Me.lblStat.AutoSize = True
        Me.lblStat.Location = New System.Drawing.Point(304, 102)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(29, 13)
        Me.lblStat.TabIndex = 27
        Me.lblStat.Tag = "Stat:"
        Me.lblStat.Text = "Stat:"
        '
        'txtStat
        '
        Me.txtStat.Location = New System.Drawing.Point(402, 95)
        Me.txtStat.Name = "txtStat"
        Me.txtStat.Size = New System.Drawing.Size(100, 20)
        Me.txtStat.TabIndex = 28
        '
        'txtYLim
        '
        Me.txtYLim.Location = New System.Drawing.Point(402, 121)
        Me.txtYLim.Name = "txtYLim"
        Me.txtYLim.Size = New System.Drawing.Size(100, 20)
        Me.txtYLim.TabIndex = 29
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(402, 147)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(100, 20)
        Me.txtColour.TabIndex = 30
        '
        'txtDataperiodLabel
        '
        Me.txtDataperiodLabel.Location = New System.Drawing.Point(112, 154)
        Me.txtDataperiodLabel.Name = "txtDataperiodLabel"
        Me.txtDataperiodLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtDataperiodLabel.TabIndex = 31
        '
        'lblDataperiodLabel
        '
        Me.lblDataperiodLabel.AutoSize = True
        Me.lblDataperiodLabel.Location = New System.Drawing.Point(12, 161)
        Me.lblDataperiodLabel.Name = "lblDataperiodLabel"
        Me.lblDataperiodLabel.Size = New System.Drawing.Size(95, 13)
        Me.lblDataperiodLabel.TabIndex = 32
        Me.lblDataperiodLabel.Tag = "Data_Period_Label:"
        Me.lblDataperiodLabel.Text = "Data Period Label:"
        '
        'lblYLim
        '
        Me.lblYLim.AutoSize = True
        Me.lblYLim.Location = New System.Drawing.Point(304, 128)
        Me.lblYLim.Name = "lblYLim"
        Me.lblYLim.Size = New System.Drawing.Size(46, 13)
        Me.lblYLim.TabIndex = 33
        Me.lblYLim.Tag = "Y_Limits"
        Me.lblYLim.Text = "Y Limits:"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(304, 154)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(40, 13)
        Me.lblColour.TabIndex = 34
        Me.lblColour.Text = "Colour:"
        '
        'lblFactorVariable
        '
        Me.lblFactorVariable.AutoSize = True
        Me.lblFactorVariable.Location = New System.Drawing.Point(12, 216)
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Size = New System.Drawing.Size(81, 13)
        Me.lblFactorVariable.TabIndex = 35
        Me.lblFactorVariable.Tag = "Factor_Variable:"
        Me.lblFactorVariable.Text = "Factor Variable:"
        '
        'txtFactorVariable
        '
        Me.txtFactorVariable.Location = New System.Drawing.Point(112, 209)
        Me.txtFactorVariable.Name = "txtFactorVariable"
        Me.txtFactorVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtFactorVariable.TabIndex = 36
        '
        'txtVariableName
        '
        Me.txtVariableName.Location = New System.Drawing.Point(402, 33)
        Me.txtVariableName.Name = "txtVariableName"
        Me.txtVariableName.Size = New System.Drawing.Size(100, 20)
        Me.txtVariableName.TabIndex = 37
        '
        'lblVariableName
        '
        Me.lblVariableName.AutoSize = True
        Me.lblVariableName.Location = New System.Drawing.Point(304, 40)
        Me.lblVariableName.Name = "lblVariableName"
        Me.lblVariableName.Size = New System.Drawing.Size(79, 13)
        Me.lblVariableName.TabIndex = 38
        Me.lblVariableName.Tag = "Variable_Name:"
        Me.lblVariableName.Text = "Variable Name:"
        '
        'txtShowLegend
        '
        Me.txtShowLegend.Location = New System.Drawing.Point(103, 297)
        Me.txtShowLegend.Name = "txtShowLegend"
        Me.txtShowLegend.Size = New System.Drawing.Size(100, 20)
        Me.txtShowLegend.TabIndex = 39
        '
        'lblShowLegend
        '
        Me.lblShowLegend.AutoSize = True
        Me.lblShowLegend.Location = New System.Drawing.Point(12, 304)
        Me.lblShowLegend.Name = "lblShowLegend"
        Me.lblShowLegend.Size = New System.Drawing.Size(76, 13)
        Me.lblShowLegend.TabIndex = 40
        Me.lblShowLegend.Tag = "Show_Legend:"
        Me.lblShowLegend.Text = "Show Legend:"
        '
        'ucrNudSize
        '
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSize.Location = New System.Drawing.Point(103, 271)
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSize.TabIndex = 41
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLineType
        '
        Me.ucrNudLineType.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineType.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineType.Location = New System.Drawing.Point(103, 245)
        Me.ucrNudLineType.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineType.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineType.Name = "ucrNudLineType"
        Me.ucrNudLineType.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLineType.TabIndex = 42
        Me.ucrNudLineType.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkStationName
        '
        Me.ucrChkStationName.Checked = False
        Me.ucrChkStationName.Location = New System.Drawing.Point(433, 264)
        Me.ucrChkStationName.Name = "ucrChkStationName"
        Me.ucrChkStationName.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkStationName.TabIndex = 43
        '
        'ucrChkInheritAES
        '
        Me.ucrChkInheritAES.Checked = False
        Me.ucrChkInheritAES.Location = New System.Drawing.Point(307, 264)
        Me.ucrChkInheritAES.Name = "ucrChkInheritAES"
        Me.ucrChkInheritAES.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkInheritAES.TabIndex = 44
        '
        'ucrChkRemoveNA
        '
        Me.ucrChkRemoveNA.Checked = False
        Me.ucrChkRemoveNA.Location = New System.Drawing.Point(433, 238)
        Me.ucrChkRemoveNA.Name = "ucrChkRemoveNA"
        Me.ucrChkRemoveNA.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRemoveNA.TabIndex = 45
        '
        'ucrChkByFactor
        '
        Me.ucrChkByFactor.Checked = False
        Me.ucrChkByFactor.Location = New System.Drawing.Point(307, 238)
        Me.ucrChkByFactor.Name = "ucrChkByFactor"
        Me.ucrChkByFactor.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkByFactor.TabIndex = 46
        '
        'dlgCliPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 378)
        Me.Controls.Add(Me.ucrChkByFactor)
        Me.Controls.Add(Me.ucrChkRemoveNA)
        Me.Controls.Add(Me.ucrChkInheritAES)
        Me.Controls.Add(Me.ucrChkStationName)
        Me.Controls.Add(Me.ucrNudLineType)
        Me.Controls.Add(Me.ucrNudSize)
        Me.Controls.Add(Me.lblShowLegend)
        Me.Controls.Add(Me.txtShowLegend)
        Me.Controls.Add(Me.lblVariableName)
        Me.Controls.Add(Me.txtVariableName)
        Me.Controls.Add(Me.txtFactorVariable)
        Me.Controls.Add(Me.lblFactorVariable)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblYLim)
        Me.Controls.Add(Me.lblDataperiodLabel)
        Me.Controls.Add(Me.txtDataperiodLabel)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtYLim)
        Me.Controls.Add(Me.txtStat)
        Me.Controls.Add(Me.lblStat)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblLineType)
        Me.Controls.Add(Me.lblXAxis)
        Me.Controls.Add(Me.txtXAxis)
        Me.Controls.Add(Me.txtYAxis)
        Me.Controls.Add(Me.lblYAxis)
        Me.Controls.Add(Me.lblXLimits)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblVariableY)
        Me.Controls.Add(Me.lblVariableX)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtVariableX)
        Me.Controls.Add(Me.txtVariableY)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtXLim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCliPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CliPlot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents txtXLim As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtVariableY As TextBox
    Friend WithEvents txtVariableX As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVariableX As Label
    Friend WithEvents lblVariableY As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblXLimits As Label
    Friend WithEvents lblYAxis As Label
    Friend WithEvents txtYAxis As TextBox
    Friend WithEvents txtXAxis As TextBox
    Friend WithEvents lblXAxis As Label
    Friend WithEvents lblLineType As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblStat As Label
    Friend WithEvents txtStat As TextBox
    Friend WithEvents txtYLim As TextBox
    Friend WithEvents txtColour As TextBox
    Friend WithEvents txtDataperiodLabel As TextBox
    Friend WithEvents lblDataperiodLabel As Label
    Friend WithEvents lblYLim As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents txtFactorVariable As TextBox
    Friend WithEvents txtVariableName As TextBox
    Friend WithEvents lblVariableName As Label
    Friend WithEvents txtShowLegend As TextBox
    Friend WithEvents lblShowLegend As Label
    Friend WithEvents ucrNudSize As ucrNud
    Friend WithEvents ucrNudLineType As ucrNud
    Friend WithEvents ucrChkStationName As ucrCheck
    Friend WithEvents ucrChkInheritAES As ucrCheck
    Friend WithEvents ucrChkRemoveNA As ucrCheck
    Friend WithEvents ucrChkByFactor As ucrCheck
End Class
