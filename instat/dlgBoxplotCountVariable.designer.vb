<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtFillColour = New System.Windows.Forms.TextBox()
        Me.txtTimeperiod = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtVariableLabel = New System.Windows.Forms.TextBox()
        Me.txtWhiskerColour = New System.Windows.Forms.TextBox()
        CType(Me.nudWhiskLineType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 234)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'chkVarwidth
        '
        Me.chkVarwidth.AutoSize = True
        Me.chkVarwidth.Location = New System.Drawing.Point(313, 193)
        Me.chkVarwidth.Name = "chkVarwidth"
        Me.chkVarwidth.Size = New System.Drawing.Size(81, 17)
        Me.chkVarwidth.TabIndex = 1
        Me.chkVarwidth.Tag = "Varwidth"
        Me.chkVarwidth.Text = "CheckBox1"
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
        Me.lblTitle.Location = New System.Drawing.Point(16, 62)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Label2"
        '
        'lblVariableLabel
        '
        Me.lblVariableLabel.AutoSize = True
        Me.lblVariableLabel.Location = New System.Drawing.Point(16, 88)
        Me.lblVariableLabel.Name = "lblVariableLabel"
        Me.lblVariableLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblVariableLabel.TabIndex = 4
        Me.lblVariableLabel.Tag = "Variable_Label"
        Me.lblVariableLabel.Text = "Label3"
        '
        'lblWhisker_Colour
        '
        Me.lblWhisker_Colour.AutoSize = True
        Me.lblWhisker_Colour.Location = New System.Drawing.Point(242, 123)
        Me.lblWhisker_Colour.Name = "lblWhisker_Colour"
        Me.lblWhisker_Colour.Size = New System.Drawing.Size(39, 13)
        Me.lblWhisker_Colour.TabIndex = 5
        Me.lblWhisker_Colour.Text = "Label4"
        '
        'lblFillColour
        '
        Me.lblFillColour.AutoSize = True
        Me.lblFillColour.Location = New System.Drawing.Point(16, 123)
        Me.lblFillColour.Name = "lblFillColour"
        Me.lblFillColour.Size = New System.Drawing.Size(39, 13)
        Me.lblFillColour.TabIndex = 6
        Me.lblFillColour.Tag = "Fill_Colour"
        Me.lblFillColour.Text = "Label5"
        '
        'lblTimeperiod
        '
        Me.lblTimeperiod.AutoSize = True
        Me.lblTimeperiod.Location = New System.Drawing.Point(16, 148)
        Me.lblTimeperiod.Name = "lblTimeperiod"
        Me.lblTimeperiod.Size = New System.Drawing.Size(39, 13)
        Me.lblTimeperiod.TabIndex = 7
        Me.lblTimeperiod.Tag = "Time_period"
        Me.lblTimeperiod.Text = "Label6"
        '
        'lblWhiskLineType
        '
        Me.lblWhiskLineType.AutoSize = True
        Me.lblWhiskLineType.Location = New System.Drawing.Point(16, 194)
        Me.lblWhiskLineType.Name = "lblWhiskLineType"
        Me.lblWhiskLineType.Size = New System.Drawing.Size(39, 13)
        Me.lblWhiskLineType.TabIndex = 8
        Me.lblWhiskLineType.Tag = "Whisklty"
        Me.lblWhiskLineType.Text = "Label7"
        '
        'nudWhiskLineType
        '
        Me.nudWhiskLineType.Location = New System.Drawing.Point(107, 187)
        Me.nudWhiskLineType.Name = "nudWhiskLineType"
        Me.nudWhiskLineType.Size = New System.Drawing.Size(58, 20)
        Me.nudWhiskLineType.TabIndex = 9
        '
        'txtFillColour
        '
        Me.txtFillColour.Location = New System.Drawing.Point(107, 116)
        Me.txtFillColour.Name = "txtFillColour"
        Me.txtFillColour.Size = New System.Drawing.Size(100, 20)
        Me.txtFillColour.TabIndex = 11
        '
        'txtTimeperiod
        '
        Me.txtTimeperiod.Location = New System.Drawing.Point(107, 142)
        Me.txtTimeperiod.Name = "txtTimeperiod"
        Me.txtTimeperiod.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeperiod.TabIndex = 12
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(107, 57)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 13
        '
        'txtVariableLabel
        '
        Me.txtVariableLabel.Location = New System.Drawing.Point(107, 84)
        Me.txtVariableLabel.Name = "txtVariableLabel"
        Me.txtVariableLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtVariableLabel.TabIndex = 15
        '
        'txtWhiskerColour
        '
        Me.txtWhiskerColour.Location = New System.Drawing.Point(313, 123)
        Me.txtWhiskerColour.Name = "txtWhiskerColour"
        Me.txtWhiskerColour.Size = New System.Drawing.Size(100, 20)
        Me.txtWhiskerColour.TabIndex = 16
        '
        'dlgBoxplotCountVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 262)
        Me.Controls.Add(Me.txtWhiskerColour)
        Me.Controls.Add(Me.txtVariableLabel)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtTimeperiod)
        Me.Controls.Add(Me.txtFillColour)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxplotCountVariable"
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
    Friend WithEvents txtFillColour As TextBox
    Friend WithEvents txtTimeperiod As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtVariableLabel As TextBox
    Friend WithEvents txtWhiskerColour As TextBox
End Class
