<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgKaplanMeier
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
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.UcrSelectorAddRemove1 = New instat.ucrSelectorAddRemove()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.lblCensoringColumn = New System.Windows.Forms.Label()
        Me.lblGreenwoodConfidenceInterval = New System.Windows.Forms.CheckBox()
        Me.chkSurvivorFunctionPlot = New System.Windows.Forms.CheckBox()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.cmbConfidenceLevel = New System.Windows.Forms.ComboBox()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(1, 190)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 32)
        Me.UcrButtons1.TabIndex = 0
        '
        'UcrSelectorAddRemove1
        '
        Me.UcrSelectorAddRemove1.Location = New System.Drawing.Point(12, 9)
        Me.UcrSelectorAddRemove1.Name = "UcrSelectorAddRemove1"
        Me.UcrSelectorAddRemove1.Size = New System.Drawing.Size(203, 127)
        Me.UcrSelectorAddRemove1.TabIndex = 1
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(276, 35)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 2
        '
        'lblDataColumn
        '
        Me.lblDataColumn.AutoSize = True
        Me.lblDataColumn.Location = New System.Drawing.Point(295, 19)
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Size = New System.Drawing.Size(68, 13)
        Me.lblDataColumn.TabIndex = 3
        Me.lblDataColumn.Tag = "Data_Column"
        Me.lblDataColumn.Text = "Data Column"
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(276, 80)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle2.TabIndex = 4
        '
        'lblCensoringColumn
        '
        Me.lblCensoringColumn.AutoSize = True
        Me.lblCensoringColumn.Location = New System.Drawing.Point(283, 64)
        Me.lblCensoringColumn.Name = "lblCensoringColumn"
        Me.lblCensoringColumn.Size = New System.Drawing.Size(92, 13)
        Me.lblCensoringColumn.TabIndex = 5
        Me.lblCensoringColumn.Tag = "Censoring_Column"
        Me.lblCensoringColumn.Text = "Censoring Column"
        '
        'lblGreenwoodConfidenceInterval
        '
        Me.lblGreenwoodConfidenceInterval.AutoSize = True
        Me.lblGreenwoodConfidenceInterval.Location = New System.Drawing.Point(26, 137)
        Me.lblGreenwoodConfidenceInterval.Name = "lblGreenwoodConfidenceInterval"
        Me.lblGreenwoodConfidenceInterval.Size = New System.Drawing.Size(118, 30)
        Me.lblGreenwoodConfidenceInterval.TabIndex = 6
        Me.lblGreenwoodConfidenceInterval.Tag = "Greenwood_Confidence_Interval"
        Me.lblGreenwoodConfidenceInterval.Text = "Greenwood" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Confidence Interval"
        Me.lblGreenwoodConfidenceInterval.UseVisualStyleBackColor = True
        '
        'chkSurvivorFunctionPlot
        '
        Me.chkSurvivorFunctionPlot.AutoSize = True
        Me.chkSurvivorFunctionPlot.Location = New System.Drawing.Point(26, 173)
        Me.chkSurvivorFunctionPlot.Name = "chkSurvivorFunctionPlot"
        Me.chkSurvivorFunctionPlot.Size = New System.Drawing.Size(130, 17)
        Me.chkSurvivorFunctionPlot.TabIndex = 7
        Me.chkSurvivorFunctionPlot.Tag = "Survivor_Function_Plot"
        Me.chkSurvivorFunctionPlot.Text = "Survivor Function Plot"
        Me.chkSurvivorFunctionPlot.UseVisualStyleBackColor = True
        '
        'lblConfidenceLevel
        '
        Me.lblConfidenceLevel.AutoSize = True
        Me.lblConfidenceLevel.Location = New System.Drawing.Point(216, 148)
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Size = New System.Drawing.Size(90, 13)
        Me.lblConfidenceLevel.TabIndex = 8
        Me.lblConfidenceLevel.Tag = "Confidence_Level"
        Me.lblConfidenceLevel.Text = "Confidence Level"
        '
        'cmbConfidenceLevel
        '
        Me.cmbConfidenceLevel.FormattingEnabled = True
        Me.cmbConfidenceLevel.Location = New System.Drawing.Point(312, 142)
        Me.cmbConfidenceLevel.Name = "cmbConfidenceLevel"
        Me.cmbConfidenceLevel.Size = New System.Drawing.Size(48, 21)
        Me.cmbConfidenceLevel.TabIndex = 9
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(366, 145)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(15, 13)
        Me.lblPercentage.TabIndex = 10
        Me.lblPercentage.Tag = ""
        Me.lblPercentage.Text = "%"
        '
        'dlgKaplanMeier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 223)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.cmbConfidenceLevel)
        Me.Controls.Add(Me.lblConfidenceLevel)
        Me.Controls.Add(Me.chkSurvivorFunctionPlot)
        Me.Controls.Add(Me.lblGreenwoodConfidenceInterval)
        Me.Controls.Add(Me.lblCensoringColumn)
        Me.Controls.Add(Me.UcrReceiverSingle2)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.UcrSelectorAddRemove1)
        Me.Controls.Add(Me.UcrButtons1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgKaplanMeier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Kaplan_Meier"
        Me.Text = "Kaplan Meier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents UcrSelectorAddRemove1 As ucrSelectorAddRemove
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents lblCensoringColumn As Label
    Friend WithEvents lblGreenwoodConfidenceInterval As CheckBox
    Friend WithEvents chkSurvivorFunctionPlot As CheckBox
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents cmbConfidenceLevel As ComboBox
    Friend WithEvents lblPercentage As Label
End Class
