<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.ucrBase.Location = New System.Drawing.Point(73, 345)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'grpOptioins
        '
        Me.grpOptioins.Controls.Add(Me.chkPlotWindow)
        Me.grpOptioins.Controls.Add(Me.chkGridSquare)
        Me.grpOptioins.Controls.Add(Me.chkStationName)
        Me.grpOptioins.Controls.Add(Me.chkPercents)
        Me.grpOptioins.Controls.Add(Me.chkCumulativeGraph)
        Me.grpOptioins.Location = New System.Drawing.Point(310, 188)
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
        Me.chkPlotWindow.Size = New System.Drawing.Size(81, 17)
        Me.chkPlotWindow.TabIndex = 4
        Me.chkPlotWindow.Tag = "Plot_Window"
        Me.chkPlotWindow.Text = "CheckBox5"
        Me.chkPlotWindow.UseVisualStyleBackColor = True
        '
        'chkGridSquare
        '
        Me.chkGridSquare.AutoSize = True
        Me.chkGridSquare.Location = New System.Drawing.Point(157, 61)
        Me.chkGridSquare.Name = "chkGridSquare"
        Me.chkGridSquare.Size = New System.Drawing.Size(81, 17)
        Me.chkGridSquare.TabIndex = 3
        Me.chkGridSquare.Tag = "Grid"
        Me.chkGridSquare.Text = "CheckBox4"
        Me.chkGridSquare.UseVisualStyleBackColor = True
        '
        'chkStationName
        '
        Me.chkStationName.AutoSize = True
        Me.chkStationName.Location = New System.Drawing.Point(6, 61)
        Me.chkStationName.Name = "chkStationName"
        Me.chkStationName.Size = New System.Drawing.Size(81, 17)
        Me.chkStationName.TabIndex = 2
        Me.chkStationName.Tag = "Station_Name"
        Me.chkStationName.Text = "CheckBox3"
        Me.chkStationName.UseVisualStyleBackColor = True
        '
        'chkPercents
        '
        Me.chkPercents.AutoSize = True
        Me.chkPercents.Location = New System.Drawing.Point(157, 19)
        Me.chkPercents.Name = "chkPercents"
        Me.chkPercents.Size = New System.Drawing.Size(81, 17)
        Me.chkPercents.TabIndex = 1
        Me.chkPercents.Tag = "Percents"
        Me.chkPercents.Text = "CheckBox2"
        Me.chkPercents.UseVisualStyleBackColor = True
        '
        'chkCumulativeGraph
        '
        Me.chkCumulativeGraph.AutoSize = True
        Me.chkCumulativeGraph.Location = New System.Drawing.Point(6, 100)
        Me.chkCumulativeGraph.Name = "chkCumulativeGraph"
        Me.chkCumulativeGraph.Size = New System.Drawing.Size(81, 17)
        Me.chkCumulativeGraph.TabIndex = 0
        Me.chkCumulativeGraph.Tag = "Cumulative_Graph"
        Me.chkCumulativeGraph.Text = "CheckBox1"
        Me.chkCumulativeGraph.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(130, 38)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtInterestedVariable
        '
        Me.txtInterestedVariable.Location = New System.Drawing.Point(130, 64)
        Me.txtInterestedVariable.Name = "txtInterestedVariable"
        Me.txtInterestedVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestedVariable.TabIndex = 4
        '
        'txtXLabel
        '
        Me.txtXLabel.Location = New System.Drawing.Point(130, 95)
        Me.txtXLabel.Name = "txtXLabel"
        Me.txtXLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtXLabel.TabIndex = 5
        '
        'txtDataperiodLabel
        '
        Me.txtDataperiodLabel.Location = New System.Drawing.Point(130, 121)
        Me.txtDataperiodLabel.Name = "txtDataperiodLabel"
        Me.txtDataperiodLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtDataperiodLabel.TabIndex = 6
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(27, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Label2"
        '
        'lblInterestedVariable
        '
        Me.lblInterestedVariable.AutoSize = True
        Me.lblInterestedVariable.Location = New System.Drawing.Point(27, 67)
        Me.lblInterestedVariable.Name = "lblInterestedVariable"
        Me.lblInterestedVariable.Size = New System.Drawing.Size(39, 13)
        Me.lblInterestedVariable.TabIndex = 8
        Me.lblInterestedVariable.Text = "Label3"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(27, 95)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblXLabel.TabIndex = 9
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "Label4"
        '
        'lblDataperiodLabel
        '
        Me.lblDataperiodLabel.AutoSize = True
        Me.lblDataperiodLabel.Location = New System.Drawing.Point(27, 128)
        Me.lblDataperiodLabel.Name = "lblDataperiodLabel"
        Me.lblDataperiodLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblDataperiodLabel.TabIndex = 10
        Me.lblDataperiodLabel.Tag = "Data_Period_Label"
        Me.lblDataperiodLabel.Text = "Label5"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(326, 102)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblYLabel.TabIndex = 11
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Label6"
        '
        'txtYLabel
        '
        Me.txtYLabel.Location = New System.Drawing.Point(392, 95)
        Me.txtYLabel.Name = "txtYLabel"
        Me.txtYLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtYLabel.TabIndex = 12
        '
        'txtLegendPosition
        '
        Me.txtLegendPosition.Location = New System.Drawing.Point(392, 316)
        Me.txtLegendPosition.Name = "txtLegendPosition"
        Me.txtLegendPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtLegendPosition.TabIndex = 5
        '
        'lblLegendPosition
        '
        Me.lblLegendPosition.AutoSize = True
        Me.lblLegendPosition.Location = New System.Drawing.Point(313, 319)
        Me.lblLegendPosition.Name = "lblLegendPosition"
        Me.lblLegendPosition.Size = New System.Drawing.Size(39, 13)
        Me.lblLegendPosition.TabIndex = 13
        Me.lblLegendPosition.Tag = "Legend_Position"
        Me.lblLegendPosition.Text = "Label7"
        '
        'nudLineWidth
        '
        Me.nudLineWidth.Location = New System.Drawing.Point(130, 147)
        Me.nudLineWidth.Name = "nudLineWidth"
        Me.nudLineWidth.Size = New System.Drawing.Size(47, 20)
        Me.nudLineWidth.TabIndex = 14
        '
        'nudPlotCharacter
        '
        Me.nudPlotCharacter.Location = New System.Drawing.Point(130, 171)
        Me.nudPlotCharacter.Name = "nudPlotCharacter"
        Me.nudPlotCharacter.Size = New System.Drawing.Size(47, 20)
        Me.nudPlotCharacter.TabIndex = 15
        '
        'lblLineWidth
        '
        Me.lblLineWidth.AutoSize = True
        Me.lblLineWidth.Location = New System.Drawing.Point(27, 154)
        Me.lblLineWidth.Name = "lblLineWidth"
        Me.lblLineWidth.Size = New System.Drawing.Size(39, 13)
        Me.lblLineWidth.TabIndex = 16
        Me.lblLineWidth.Tag = "Line_Width"
        Me.lblLineWidth.Text = "Label3"
        '
        'lblPlotCharacter
        '
        Me.lblPlotCharacter.AutoSize = True
        Me.lblPlotCharacter.Location = New System.Drawing.Point(27, 173)
        Me.lblPlotCharacter.Name = "lblPlotCharacter"
        Me.lblPlotCharacter.Size = New System.Drawing.Size(39, 13)
        Me.lblPlotCharacter.TabIndex = 17
        Me.lblPlotCharacter.Tag = "Plot_Character"
        Me.lblPlotCharacter.Text = "Label4"
        '
        'lblColourRainbow
        '
        Me.lblColourRainbow.AutoSize = True
        Me.lblColourRainbow.Location = New System.Drawing.Point(27, 199)
        Me.lblColourRainbow.Name = "lblColourRainbow"
        Me.lblColourRainbow.Size = New System.Drawing.Size(39, 13)
        Me.lblColourRainbow.TabIndex = 18
        Me.lblColourRainbow.Text = "Label3"
        '
        'nudColourRainbow
        '
        Me.nudColourRainbow.Location = New System.Drawing.Point(130, 197)
        Me.nudColourRainbow.Name = "nudColourRainbow"
        Me.nudColourRainbow.Size = New System.Drawing.Size(47, 20)
        Me.nudColourRainbow.TabIndex = 19
        '
        'lblLegendLabel
        '
        Me.lblLegendLabel.AutoSize = True
        Me.lblLegendLabel.Location = New System.Drawing.Point(27, 256)
        Me.lblLegendLabel.Name = "lblLegendLabel"
        Me.lblLegendLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblLegendLabel.TabIndex = 20
        Me.lblLegendLabel.Tag = "Legend_Label"
        Me.lblLegendLabel.Text = "Label3"
        '
        'lblLegendBty
        '
        Me.lblLegendBty.AutoSize = True
        Me.lblLegendBty.Location = New System.Drawing.Point(27, 230)
        Me.lblLegendBty.Name = "lblLegendBty"
        Me.lblLegendBty.Size = New System.Drawing.Size(39, 13)
        Me.lblLegendBty.TabIndex = 21
        Me.lblLegendBty.Tag = "legendbty"
        Me.lblLegendBty.Text = "Label4"
        '
        'txtLegendBtype
        '
        Me.txtLegendBtype.Location = New System.Drawing.Point(130, 223)
        Me.txtLegendBtype.Name = "txtLegendBtype"
        Me.txtLegendBtype.Size = New System.Drawing.Size(100, 20)
        Me.txtLegendBtype.TabIndex = 22
        '
        'txtLegendLabel
        '
        Me.txtLegendLabel.Location = New System.Drawing.Point(130, 249)
        Me.txtLegendLabel.Name = "txtLegendLabel"
        Me.txtLegendLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtLegendLabel.TabIndex = 23
        '
        'dlgCumulativeExceedance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 378)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCumulativeExceedance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cumulative Exceedance"
        Me.grpOptioins.ResumeLayout(False)
        Me.grpOptioins.PerformLayout()
        CType(Me.nudLineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColourRainbow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
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
