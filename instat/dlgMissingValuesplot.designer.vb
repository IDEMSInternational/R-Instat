<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrBase = New instat.ucrButtons()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkStationName = New System.Windows.Forms.CheckBox()
        Me.chkHorizontal = New System.Windows.Forms.CheckBox()
        Me.txtlog = New System.Windows.Forms.TextBox()
        Me.txtASP = New System.Windows.Forms.TextBox()
        Me.txtFillColour = New System.Windows.Forms.TextBox()
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
        Me.lblFillColour = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblLegend = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYlim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(74, 355)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
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
        Me.chkStationName.Size = New System.Drawing.Size(81, 17)
        Me.chkStationName.TabIndex = 2
        Me.chkStationName.Tag = "Station_Name"
        Me.chkStationName.Text = "CheckBox1"
        Me.chkStationName.UseVisualStyleBackColor = True
        '
        'chkHorizontal
        '
        Me.chkHorizontal.AutoSize = True
        Me.chkHorizontal.Location = New System.Drawing.Point(379, 205)
        Me.chkHorizontal.Name = "chkHorizontal"
        Me.chkHorizontal.Size = New System.Drawing.Size(81, 17)
        Me.chkHorizontal.TabIndex = 3
        Me.chkHorizontal.Tag = "Horizontal"
        Me.chkHorizontal.Text = "CheckBox2"
        Me.chkHorizontal.UseVisualStyleBackColor = True
        '
        'txtlog
        '
        Me.txtlog.Location = New System.Drawing.Point(147, 206)
        Me.txtlog.Name = "txtlog"
        Me.txtlog.Size = New System.Drawing.Size(100, 20)
        Me.txtlog.TabIndex = 5
        Me.txtlog.Tag = ""
        '
        'txtASP
        '
        Me.txtASP.Location = New System.Drawing.Point(147, 180)
        Me.txtASP.Name = "txtASP"
        Me.txtASP.Size = New System.Drawing.Size(100, 20)
        Me.txtASP.TabIndex = 6
        '
        'txtFillColour
        '
        Me.txtFillColour.Location = New System.Drawing.Point(147, 154)
        Me.txtFillColour.Name = "txtFillColour"
        Me.txtFillColour.Size = New System.Drawing.Size(100, 20)
        Me.txtFillColour.TabIndex = 7
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
        Me.lblYLimits.Size = New System.Drawing.Size(39, 13)
        Me.lblYLimits.TabIndex = 19
        Me.lblYLimits.Tag = "lblYLimits"
        Me.lblYLimits.Text = "Label2"
        '
        'lblPlotCharacter
        '
        Me.lblPlotCharacter.AutoSize = True
        Me.lblPlotCharacter.Location = New System.Drawing.Point(28, 307)
        Me.lblPlotCharacter.Name = "lblPlotCharacter"
        Me.lblPlotCharacter.Size = New System.Drawing.Size(39, 13)
        Me.lblPlotCharacter.TabIndex = 20
        Me.lblPlotCharacter.Tag = "Plot_Character"
        Me.lblPlotCharacter.Text = "Label3"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(28, 281)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold.TabIndex = 21
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label4"
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(28, 206)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(39, 13)
        Me.lblLog.TabIndex = 22
        Me.lblLog.Tag = "log"
        Me.lblLog.Text = "Label5"
        '
        'lblASP
        '
        Me.lblASP.AutoSize = True
        Me.lblASP.Location = New System.Drawing.Point(28, 180)
        Me.lblASP.Name = "lblASP"
        Me.lblASP.Size = New System.Drawing.Size(39, 13)
        Me.lblASP.TabIndex = 23
        Me.lblASP.Tag = "asp"
        Me.lblASP.Text = "Label6"
        '
        'lblFillColour
        '
        Me.lblFillColour.AutoSize = True
        Me.lblFillColour.Location = New System.Drawing.Point(28, 154)
        Me.lblFillColour.Name = "lblFillColour"
        Me.lblFillColour.Size = New System.Drawing.Size(39, 13)
        Me.lblFillColour.TabIndex = 24
        Me.lblFillColour.Tag = "Fill_Colour"
        Me.lblFillColour.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Label8"
        '
        'lblLegend
        '
        Me.lblLegend.AutoSize = True
        Me.lblLegend.Location = New System.Drawing.Point(28, 102)
        Me.lblLegend.Name = "lblLegend"
        Me.lblLegend.Size = New System.Drawing.Size(39, 13)
        Me.lblLegend.TabIndex = 26
        Me.lblLegend.Tag = "Legend"
        Me.lblLegend.Text = "Label9"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(28, 76)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(45, 13)
        Me.lblYLabel.TabIndex = 27
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Label10"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(28, 50)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(45, 13)
        Me.lblXLabel.TabIndex = 28
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "Label11"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(28, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(45, 13)
        Me.lblTitle.TabIndex = 29
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Label12"
        '
        'dlgMissingValuesplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 387)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblLegend)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblFillColour)
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
        Me.Controls.Add(Me.txtFillColour)
        Me.Controls.Add(Me.txtASP)
        Me.Controls.Add(Me.txtlog)
        Me.Controls.Add(Me.chkHorizontal)
        Me.Controls.Add(Me.chkStationName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.Name = "dlgMissingValuesplot"
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
    Friend WithEvents txtFillColour As TextBox
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
    Friend WithEvents lblFillColour As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblLegend As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents lblTitle As Label
End Class
