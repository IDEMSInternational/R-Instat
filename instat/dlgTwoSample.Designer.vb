<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTwoSample
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
        Me.cboLayout = New System.Windows.Forms.ComboBox()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.lblDataColumn1 = New System.Windows.Forms.Label()
        Me.lblDataColumn2 = New System.Windows.Forms.Label()
        Me.grpAnalysis = New System.Windows.Forms.GroupBox()
        Me.chkSignificanceTest = New System.Windows.Forms.CheckBox()
        Me.cboParameter = New System.Windows.Forms.ComboBox()
        Me.lblParameter = New System.Windows.Forms.Label()
        Me.cboModel = New System.Windows.Forms.ComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.ucrDataColumn2Receiver = New instat.ucrReceiverSingle()
        Me.ucrDataColumn1Receiver = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpGraphs = New System.Windows.Forms.GroupBox()
        Me.chkPlots = New System.Windows.Forms.CheckBox()
        Me.grpAnalysis.SuspendLayout()
        Me.grpGraphs.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboLayout
        '
        Me.cboLayout.FormattingEnabled = True
        Me.cboLayout.Items.AddRange(New Object() {"Two data columns", "Data column and two factor levels"})
        Me.cboLayout.Location = New System.Drawing.Point(26, 31)
        Me.cboLayout.Name = "cboLayout"
        Me.cboLayout.Size = New System.Drawing.Size(121, 21)
        Me.cboLayout.TabIndex = 1
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(26, 12)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(39, 13)
        Me.lblLayout.TabIndex = 2
        Me.lblLayout.Tag = "Layout"
        Me.lblLayout.Text = "Layout"
        '
        'lblDataColumn1
        '
        Me.lblDataColumn1.AutoSize = True
        Me.lblDataColumn1.Location = New System.Drawing.Point(227, 93)
        Me.lblDataColumn1.Name = "lblDataColumn1"
        Me.lblDataColumn1.Size = New System.Drawing.Size(77, 13)
        Me.lblDataColumn1.TabIndex = 5
        Me.lblDataColumn1.Tag = "Data_Column_1"
        Me.lblDataColumn1.Text = "Data Column 1"
        '
        'lblDataColumn2
        '
        Me.lblDataColumn2.AutoSize = True
        Me.lblDataColumn2.Location = New System.Drawing.Point(227, 140)
        Me.lblDataColumn2.Name = "lblDataColumn2"
        Me.lblDataColumn2.Size = New System.Drawing.Size(77, 13)
        Me.lblDataColumn2.TabIndex = 5
        Me.lblDataColumn2.Tag = "Data_Column_2"
        Me.lblDataColumn2.Text = "Data Column 2"
        '
        'grpAnalysis
        '
        Me.grpAnalysis.Controls.Add(Me.chkSignificanceTest)
        Me.grpAnalysis.Controls.Add(Me.cboParameter)
        Me.grpAnalysis.Controls.Add(Me.lblParameter)
        Me.grpAnalysis.Controls.Add(Me.cboModel)
        Me.grpAnalysis.Controls.Add(Me.lblModel)
        Me.grpAnalysis.Location = New System.Drawing.Point(381, 16)
        Me.grpAnalysis.Name = "grpAnalysis"
        Me.grpAnalysis.Size = New System.Drawing.Size(200, 167)
        Me.grpAnalysis.TabIndex = 6
        Me.grpAnalysis.TabStop = False
        Me.grpAnalysis.Tag = "Analysis"
        Me.grpAnalysis.Text = "Analysis"
        '
        'chkSignificanceTest
        '
        Me.chkSignificanceTest.AutoSize = True
        Me.chkSignificanceTest.Location = New System.Drawing.Point(17, 140)
        Me.chkSignificanceTest.Name = "chkSignificanceTest"
        Me.chkSignificanceTest.Size = New System.Drawing.Size(108, 17)
        Me.chkSignificanceTest.TabIndex = 4
        Me.chkSignificanceTest.Tag = "Significance_Test"
        Me.chkSignificanceTest.Text = "Significance Test"
        Me.chkSignificanceTest.UseVisualStyleBackColor = True
        '
        'cboParameter
        '
        Me.cboParameter.FormattingEnabled = True
        Me.cboParameter.Items.AddRange(New Object() {"Means[t-interval]", "Means, known variance[z-interval]", "Variances[F-interval]"})
        Me.cboParameter.Location = New System.Drawing.Point(17, 105)
        Me.cboParameter.Name = "cboParameter"
        Me.cboParameter.Size = New System.Drawing.Size(121, 21)
        Me.cboParameter.TabIndex = 3
        '
        'lblParameter
        '
        Me.lblParameter.AutoSize = True
        Me.lblParameter.Location = New System.Drawing.Point(17, 78)
        Me.lblParameter.Name = "lblParameter"
        Me.lblParameter.Size = New System.Drawing.Size(55, 13)
        Me.lblParameter.TabIndex = 2
        Me.lblParameter.Tag = "Parameter"
        Me.lblParameter.Text = "Parameter"
        '
        'cboModel
        '
        Me.cboModel.FormattingEnabled = True
        Me.cboModel.Items.AddRange(New Object() {"Normal", "Binomial"})
        Me.cboModel.Location = New System.Drawing.Point(17, 43)
        Me.cboModel.Name = "cboModel"
        Me.cboModel.Size = New System.Drawing.Size(121, 21)
        Me.cboModel.TabIndex = 1
        Me.cboModel.Tag = "Model"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(17, 16)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(36, 13)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Tag = "Model"
        Me.lblModel.Text = "Model"
        '
        'ucrDataColumn2Receiver
        '
        Me.ucrDataColumn2Receiver.Location = New System.Drawing.Point(227, 157)
        Me.ucrDataColumn2Receiver.Name = "ucrDataColumn2Receiver"
        Me.ucrDataColumn2Receiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrDataColumn2Receiver.TabIndex = 4
        '
        'ucrDataColumn1Receiver
        '
        Me.ucrDataColumn1Receiver.Location = New System.Drawing.Point(187, 71)
        Me.ucrDataColumn1Receiver.Name = "ucrDataColumn1Receiver"
        Me.ucrDataColumn1Receiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrDataColumn1Receiver.TabIndex = 4
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(26, 71)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 123)
        Me.ucrAddRemove.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(83, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'grpGraphs
        '
        Me.grpGraphs.Controls.Add(Me.chkPlots)
        Me.grpGraphs.Location = New System.Drawing.Point(26, 200)
        Me.grpGraphs.Name = "grpGraphs"
        Me.grpGraphs.Size = New System.Drawing.Size(307, 89)
        Me.grpGraphs.TabIndex = 7
        Me.grpGraphs.TabStop = False
        Me.grpGraphs.Tag = "Graphs_with_confidence_limits"
        Me.grpGraphs.Text = "Graphs with confidence limits"
        '
        'chkPlots
        '
        Me.chkPlots.AutoSize = True
        Me.chkPlots.Location = New System.Drawing.Point(18, 30)
        Me.chkPlots.Name = "chkPlots"
        Me.chkPlots.Size = New System.Drawing.Size(49, 17)
        Me.chkPlots.TabIndex = 0
        Me.chkPlots.Tag = "Plots"
        Me.chkPlots.Text = "Plots"
        Me.chkPlots.UseVisualStyleBackColor = True
        '
        'dlgTwoSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 349)
        Me.Controls.Add(Me.grpGraphs)
        Me.Controls.Add(Me.grpAnalysis)
        Me.Controls.Add(Me.lblDataColumn2)
        Me.Controls.Add(Me.lblDataColumn1)
        Me.Controls.Add(Me.ucrDataColumn2Receiver)
        Me.Controls.Add(Me.ucrDataColumn1Receiver)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.cboLayout)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTwoSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgTwoSample"
        Me.grpAnalysis.ResumeLayout(False)
        Me.grpAnalysis.PerformLayout()
        Me.grpGraphs.ResumeLayout(False)
        Me.grpGraphs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cboLayout As ComboBox
    Friend WithEvents lblLayout As Label
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrDataColumn1Receiver As ucrReceiverSingle
    Friend WithEvents lblDataColumn1 As Label
    Friend WithEvents ucrDataColumn2Receiver As ucrReceiverSingle
    Friend WithEvents lblDataColumn2 As Label
    Friend WithEvents grpAnalysis As GroupBox
    Friend WithEvents cboModel As ComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents chkSignificanceTest As CheckBox
    Friend WithEvents cboParameter As ComboBox
    Friend WithEvents lblParameter As Label
    Friend WithEvents grpGraphs As GroupBox
    Friend WithEvents chkPlots As CheckBox
End Class
