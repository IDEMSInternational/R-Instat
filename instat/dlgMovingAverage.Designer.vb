<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMovingAverage
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
        Me.lblDataToAverage = New System.Windows.Forms.Label()
        Me.lblSaveResultsIn = New System.Windows.Forms.Label()
        Me.cboSaveResultsIn = New System.Windows.Forms.ComboBox()
        Me.chkSaveResiduals = New System.Windows.Forms.CheckBox()
        Me.chkDisplayResults = New System.Windows.Forms.CheckBox()
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.lblLag = New System.Windows.Forms.Label()
        Me.txtLag = New System.Windows.Forms.TextBox()
        Me.ucrReceiverDataToAverage = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'lblDataToAverage
        '
        Me.lblDataToAverage.AutoSize = True
        Me.lblDataToAverage.Location = New System.Drawing.Point(233, 12)
        Me.lblDataToAverage.Name = "lblDataToAverage"
        Me.lblDataToAverage.Size = New System.Drawing.Size(105, 13)
        Me.lblDataToAverage.TabIndex = 3
        Me.lblDataToAverage.Tag = "Data_to_be_averaged"
        Me.lblDataToAverage.Text = "Data to be averaged"
        '
        'lblSaveResultsIn
        '
        Me.lblSaveResultsIn.AutoSize = True
        Me.lblSaveResultsIn.Location = New System.Drawing.Point(224, 95)
        Me.lblSaveResultsIn.Name = "lblSaveResultsIn"
        Me.lblSaveResultsIn.Size = New System.Drawing.Size(85, 13)
        Me.lblSaveResultsIn.TabIndex = 4
        Me.lblSaveResultsIn.Tag = "Save_results_in"
        Me.lblSaveResultsIn.Text = "Save results into"
        '
        'cboSaveResultsIn
        '
        Me.cboSaveResultsIn.FormattingEnabled = True
        Me.cboSaveResultsIn.Location = New System.Drawing.Point(328, 92)
        Me.cboSaveResultsIn.Name = "cboSaveResultsIn"
        Me.cboSaveResultsIn.Size = New System.Drawing.Size(87, 21)
        Me.cboSaveResultsIn.TabIndex = 5
        '
        'chkSaveResiduals
        '
        Me.chkSaveResiduals.AutoSize = True
        Me.chkSaveResiduals.Location = New System.Drawing.Point(13, 145)
        Me.chkSaveResiduals.Name = "chkSaveResiduals"
        Me.chkSaveResiduals.Size = New System.Drawing.Size(95, 17)
        Me.chkSaveResiduals.TabIndex = 6
        Me.chkSaveResiduals.Tag = "Save_residuals"
        Me.chkSaveResiduals.Text = "Save residuals"
        Me.chkSaveResiduals.UseVisualStyleBackColor = True
        '
        'chkDisplayResults
        '
        Me.chkDisplayResults.AutoSize = True
        Me.chkDisplayResults.Location = New System.Drawing.Point(112, 145)
        Me.chkDisplayResults.Name = "chkDisplayResults"
        Me.chkDisplayResults.Size = New System.Drawing.Size(93, 17)
        Me.chkDisplayResults.TabIndex = 7
        Me.chkDisplayResults.Tag = "Display_residuals"
        Me.chkDisplayResults.Text = "Display results"
        Me.chkDisplayResults.UseVisualStyleBackColor = True
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Location = New System.Drawing.Point(227, 142)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(44, 17)
        Me.chkPlot.TabIndex = 8
        Me.chkPlot.Text = "Plot"
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'lblLag
        '
        Me.lblLag.AutoSize = True
        Me.lblLag.Location = New System.Drawing.Point(304, 143)
        Me.lblLag.Name = "lblLag"
        Me.lblLag.Size = New System.Drawing.Size(25, 13)
        Me.lblLag.TabIndex = 9
        Me.lblLag.Tag = "Lag"
        Me.lblLag.Text = "Lag"
        '
        'txtLag
        '
        Me.txtLag.Location = New System.Drawing.Point(344, 140)
        Me.txtLag.Name = "txtLag"
        Me.txtLag.Size = New System.Drawing.Size(55, 20)
        Me.txtLag.TabIndex = 10
        '
        'ucrReceiverDataToAverage
        '
        Me.ucrReceiverDataToAverage.Location = New System.Drawing.Point(236, 38)
        Me.ucrReceiverDataToAverage.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataToAverage.Name = "ucrReceiverDataToAverage"
        Me.ucrReceiverDataToAverage.Selector = Nothing
        Me.ucrReceiverDataToAverage.Size = New System.Drawing.Size(102, 26)
        Me.ucrReceiverDataToAverage.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 186)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(2, 12)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'dlgMovingAverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(427, 221)
        Me.Controls.Add(Me.txtLag)
        Me.Controls.Add(Me.lblLag)
        Me.Controls.Add(Me.chkPlot)
        Me.Controls.Add(Me.chkDisplayResults)
        Me.Controls.Add(Me.chkSaveResiduals)
        Me.Controls.Add(Me.cboSaveResultsIn)
        Me.Controls.Add(Me.lblSaveResultsIn)
        Me.Controls.Add(Me.lblDataToAverage)
        Me.Controls.Add(Me.ucrReceiverDataToAverage)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMovingAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Moving_Averages"
        Me.Text = "Moving Averages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverDataToAverage As ucrReceiverSingle
    Friend WithEvents lblDataToAverage As Label
    Friend WithEvents lblSaveResultsIn As Label
    Friend WithEvents cboSaveResultsIn As ComboBox
    Friend WithEvents chkSaveResiduals As CheckBox
    Friend WithEvents chkDisplayResults As CheckBox
    Friend WithEvents chkPlot As CheckBox
    Friend WithEvents lblLag As Label
    Friend WithEvents txtLag As TextBox
End Class
