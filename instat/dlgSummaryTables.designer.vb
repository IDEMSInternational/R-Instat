<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSummaryTables
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverVariate = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblVariates = New System.Windows.Forms.Label()
        Me.grpTwoways = New System.Windows.Forms.GroupBox()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.nudDecimals = New System.Windows.Forms.NumericUpDown()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.txtColumnFactors = New System.Windows.Forms.TextBox()
        Me.chkDisplayMargins = New System.Windows.Forms.CheckBox()
        Me.grpSummaryStat = New System.Windows.Forms.GroupBox()
        Me.cmdMore = New System.Windows.Forms.Button()
        Me.chkMeans = New System.Windows.Forms.CheckBox()
        Me.chkTotals = New System.Windows.Forms.CheckBox()
        Me.cboWeights = New System.Windows.Forms.ComboBox()
        Me.chkWeights = New System.Windows.Forms.CheckBox()
        Me.chkTobeImplementedLater = New System.Windows.Forms.CheckBox()
        Me.grpTwoways.SuspendLayout()
        CType(Me.nudDecimals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSummaryStat.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(2, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 55)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(2, 3)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(207, 127)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(205, 19)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(91, 101)
        Me.ucrReceiverFactor.TabIndex = 2
        '
        'ucrReceiverVariate
        '
        Me.ucrReceiverVariate.Location = New System.Drawing.Point(305, 19)
        Me.ucrReceiverVariate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariate.Name = "ucrReceiverVariate"
        Me.ucrReceiverVariate.Selector = Nothing
        Me.ucrReceiverVariate.Size = New System.Drawing.Size(91, 101)
        Me.ucrReceiverVariate.TabIndex = 3
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(202, 3)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(42, 13)
        Me.lblFactors.TabIndex = 4
        Me.lblFactors.Tag = "Factors"
        Me.lblFactors.Text = "Factors"
        '
        'lblVariates
        '
        Me.lblVariates.AutoSize = True
        Me.lblVariates.Location = New System.Drawing.Point(302, 3)
        Me.lblVariates.Name = "lblVariates"
        Me.lblVariates.Size = New System.Drawing.Size(45, 13)
        Me.lblVariates.TabIndex = 5
        Me.lblVariates.Tag = "Variates"
        Me.lblVariates.Text = "Variates"
        '
        'grpTwoways
        '
        Me.grpTwoways.Controls.Add(Me.lblDecimals)
        Me.grpTwoways.Controls.Add(Me.nudDecimals)
        Me.grpTwoways.Controls.Add(Me.lblColumnFactors)
        Me.grpTwoways.Controls.Add(Me.txtColumnFactors)
        Me.grpTwoways.Controls.Add(Me.chkDisplayMargins)
        Me.grpTwoways.Location = New System.Drawing.Point(12, 166)
        Me.grpTwoways.Name = "grpTwoways"
        Me.grpTwoways.Size = New System.Drawing.Size(207, 100)
        Me.grpTwoways.TabIndex = 6
        Me.grpTwoways.TabStop = False
        Me.grpTwoways.Tag = "Two_ways_table(s)"
        Me.grpTwoways.Text = "Two way table(s)"
        '
        'lblDecimals
        '
        Me.lblDecimals.AutoSize = True
        Me.lblDecimals.Location = New System.Drawing.Point(6, 77)
        Me.lblDecimals.Name = "lblDecimals"
        Me.lblDecimals.Size = New System.Drawing.Size(50, 13)
        Me.lblDecimals.TabIndex = 4
        Me.lblDecimals.Tag = "Decimals"
        Me.lblDecimals.Text = "Decimals"
        '
        'nudDecimals
        '
        Me.nudDecimals.AllowDrop = True
        Me.nudDecimals.Location = New System.Drawing.Point(95, 75)
        Me.nudDecimals.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudDecimals.Name = "nudDecimals"
        Me.nudDecimals.Size = New System.Drawing.Size(44, 20)
        Me.nudDecimals.TabIndex = 3
        '
        'lblColumnFactors
        '
        Me.lblColumnFactors.AutoSize = True
        Me.lblColumnFactors.Location = New System.Drawing.Point(6, 46)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(77, 13)
        Me.lblColumnFactors.TabIndex = 2
        Me.lblColumnFactors.Tag = "Column_factors"
        Me.lblColumnFactors.Text = "Column factors"
        '
        'txtColumnFactors
        '
        Me.txtColumnFactors.Location = New System.Drawing.Point(95, 42)
        Me.txtColumnFactors.Name = "txtColumnFactors"
        Me.txtColumnFactors.Size = New System.Drawing.Size(29, 20)
        Me.txtColumnFactors.TabIndex = 1
        '
        'chkDisplayMargins
        '
        Me.chkDisplayMargins.AutoSize = True
        Me.chkDisplayMargins.Location = New System.Drawing.Point(23, 19)
        Me.chkDisplayMargins.Name = "chkDisplayMargins"
        Me.chkDisplayMargins.Size = New System.Drawing.Size(99, 17)
        Me.chkDisplayMargins.TabIndex = 0
        Me.chkDisplayMargins.Tag = "Display_margins"
        Me.chkDisplayMargins.Text = "Display margins"
        Me.chkDisplayMargins.UseVisualStyleBackColor = True
        '
        'grpSummaryStat
        '
        Me.grpSummaryStat.Controls.Add(Me.cmdMore)
        Me.grpSummaryStat.Controls.Add(Me.chkMeans)
        Me.grpSummaryStat.Controls.Add(Me.chkTotals)
        Me.grpSummaryStat.Location = New System.Drawing.Point(234, 166)
        Me.grpSummaryStat.Name = "grpSummaryStat"
        Me.grpSummaryStat.Size = New System.Drawing.Size(151, 100)
        Me.grpSummaryStat.TabIndex = 7
        Me.grpSummaryStat.TabStop = False
        Me.grpSummaryStat.Tag = "Summary_statistics"
        Me.grpSummaryStat.Text = "Summary statistics"
        '
        'cmdMore
        '
        Me.cmdMore.Location = New System.Drawing.Point(36, 65)
        Me.cmdMore.Name = "cmdMore"
        Me.cmdMore.Size = New System.Drawing.Size(75, 23)
        Me.cmdMore.TabIndex = 2
        Me.cmdMore.Tag = "More"
        Me.cmdMore.Text = "More"
        Me.cmdMore.UseVisualStyleBackColor = True
        '
        'chkMeans
        '
        Me.chkMeans.AutoSize = True
        Me.chkMeans.Location = New System.Drawing.Point(7, 42)
        Me.chkMeans.Name = "chkMeans"
        Me.chkMeans.Size = New System.Drawing.Size(58, 17)
        Me.chkMeans.TabIndex = 1
        Me.chkMeans.Tag = "Means"
        Me.chkMeans.Text = "Means"
        Me.chkMeans.UseVisualStyleBackColor = True
        '
        'chkTotals
        '
        Me.chkTotals.AutoSize = True
        Me.chkTotals.Location = New System.Drawing.Point(7, 19)
        Me.chkTotals.Name = "chkTotals"
        Me.chkTotals.Size = New System.Drawing.Size(55, 17)
        Me.chkTotals.TabIndex = 0
        Me.chkTotals.Tag = "Totals"
        Me.chkTotals.Text = "Totals"
        Me.chkTotals.UseVisualStyleBackColor = True
        '
        'cboWeights
        '
        Me.cboWeights.FormattingEnabled = True
        Me.cboWeights.Location = New System.Drawing.Point(205, 134)
        Me.cboWeights.Name = "cboWeights"
        Me.cboWeights.Size = New System.Drawing.Size(83, 21)
        Me.cboWeights.TabIndex = 9
        '
        'chkWeights
        '
        Me.chkWeights.AutoSize = True
        Me.chkWeights.Location = New System.Drawing.Point(118, 136)
        Me.chkWeights.Name = "chkWeights"
        Me.chkWeights.Size = New System.Drawing.Size(65, 17)
        Me.chkWeights.TabIndex = 8
        Me.chkWeights.Tag = "Weights"
        Me.chkWeights.Text = "Weights"
        Me.chkWeights.UseVisualStyleBackColor = True
        '
        'chkTobeImplementedLater
        '
        Me.chkTobeImplementedLater.AutoSize = True
        Me.chkTobeImplementedLater.Location = New System.Drawing.Point(12, 272)
        Me.chkTobeImplementedLater.Name = "chkTobeImplementedLater"
        Me.chkTobeImplementedLater.Size = New System.Drawing.Size(139, 17)
        Me.chkTobeImplementedLater.TabIndex = 10
        Me.chkTobeImplementedLater.Text = "To be implemented later"
        Me.chkTobeImplementedLater.UseVisualStyleBackColor = True
        '
        'dlgSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 350)
        Me.Controls.Add(Me.chkTobeImplementedLater)
        Me.Controls.Add(Me.cboWeights)
        Me.Controls.Add(Me.chkWeights)
        Me.Controls.Add(Me.grpSummaryStat)
        Me.Controls.Add(Me.grpTwoways)
        Me.Controls.Add(Me.lblVariates)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverVariate)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSummaryTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Summary_Tables"
        Me.Text = "Summary Tables"
        Me.grpTwoways.ResumeLayout(False)
        Me.grpTwoways.PerformLayout()
        CType(Me.nudDecimals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSummaryStat.ResumeLayout(False)
        Me.grpSummaryStat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverMultiple
    Friend WithEvents ucrReceiverVariate As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents lblVariates As Label
    Friend WithEvents grpTwoways As GroupBox
    Friend WithEvents grpSummaryStat As GroupBox
    Friend WithEvents cmdMore As Button
    Friend WithEvents chkMeans As CheckBox
    Friend WithEvents chkTotals As CheckBox
    Friend WithEvents cboWeights As ComboBox
    Friend WithEvents chkWeights As CheckBox
    Friend WithEvents chkTobeImplementedLater As CheckBox
    Friend WithEvents lblDecimals As Label
    Friend WithEvents nudDecimals As NumericUpDown
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents txtColumnFactors As TextBox
    Friend WithEvents chkDisplayMargins As CheckBox
End Class
