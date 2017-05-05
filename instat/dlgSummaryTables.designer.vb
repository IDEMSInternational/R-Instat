<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSummaryTables
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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblVariates = New System.Windows.Forms.Label()
        Me.grpTwoways = New System.Windows.Forms.GroupBox()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.grpSummaryStat = New System.Windows.Forms.GroupBox()
        Me.cmdMore = New System.Windows.Forms.Button()
        Me.cboWeights = New System.Windows.Forms.ComboBox()
        Me.ucrSelectorSummaryTables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverVariate = New instat.ucrReceiverMultiple()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrChkMeans = New instat.ucrCheck()
        Me.ucrChkTotals = New instat.ucrCheck()
        Me.ucrChkTrtSCFactor = New instat.ucrCheck()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrInputColumnFactors = New instat.ucrInputTextBox()
        Me.ucrNudDecimals = New instat.ucrNud()
        Me.grpTwoways.SuspendLayout()
        Me.grpSummaryStat.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 384)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 55)
        Me.ucrBase.TabIndex = 0
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(272, 45)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 4
        Me.lblFactors.Tag = "Factors:"
        Me.lblFactors.Text = "Factors:"
        '
        'lblVariates
        '
        Me.lblVariates.AutoSize = True
        Me.lblVariates.Location = New System.Drawing.Point(272, 163)
        Me.lblVariates.Name = "lblVariates"
        Me.lblVariates.Size = New System.Drawing.Size(48, 13)
        Me.lblVariates.TabIndex = 5
        Me.lblVariates.Tag = "Variates"
        Me.lblVariates.Text = "Variates:"
        '
        'grpTwoways
        '
        Me.grpTwoways.Controls.Add(Me.ucrNudDecimals)
        Me.grpTwoways.Controls.Add(Me.ucrInputColumnFactors)
        Me.grpTwoways.Controls.Add(Me.lblDecimals)
        Me.grpTwoways.Controls.Add(Me.lblColumnFactors)
        Me.grpTwoways.Controls.Add(Me.ucrChkDisplayMargins)
        Me.grpTwoways.Location = New System.Drawing.Point(10, 278)
        Me.grpTwoways.Name = "grpTwoways"
        Me.grpTwoways.Size = New System.Drawing.Size(207, 100)
        Me.grpTwoways.TabIndex = 6
        Me.grpTwoways.TabStop = False
        Me.grpTwoways.Tag = "Two_Way_Table(s)"
        Me.grpTwoways.Text = "Two Way Table(s)"
        '
        'lblDecimals
        '
        Me.lblDecimals.AutoSize = True
        Me.lblDecimals.Location = New System.Drawing.Point(6, 73)
        Me.lblDecimals.Name = "lblDecimals"
        Me.lblDecimals.Size = New System.Drawing.Size(53, 13)
        Me.lblDecimals.TabIndex = 4
        Me.lblDecimals.Tag = "Decimals:"
        Me.lblDecimals.Text = "Decimals:"
        '
        'lblColumnFactors
        '
        Me.lblColumnFactors.AutoSize = True
        Me.lblColumnFactors.Location = New System.Drawing.Point(6, 46)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(83, 13)
        Me.lblColumnFactors.TabIndex = 2
        Me.lblColumnFactors.Tag = "Column_Factors:"
        Me.lblColumnFactors.Text = "Column Factors:"
        '
        'grpSummaryStat
        '
        Me.grpSummaryStat.Controls.Add(Me.cmdMore)
        Me.grpSummaryStat.Controls.Add(Me.ucrChkMeans)
        Me.grpSummaryStat.Controls.Add(Me.ucrChkTotals)
        Me.grpSummaryStat.Location = New System.Drawing.Point(226, 278)
        Me.grpSummaryStat.Name = "grpSummaryStat"
        Me.grpSummaryStat.Size = New System.Drawing.Size(182, 100)
        Me.grpSummaryStat.TabIndex = 7
        Me.grpSummaryStat.TabStop = False
        Me.grpSummaryStat.Tag = "Summary_statistics"
        Me.grpSummaryStat.Text = "Summary Statistics"
        '
        'cmdMore
        '
        Me.cmdMore.Location = New System.Drawing.Point(77, 66)
        Me.cmdMore.Name = "cmdMore"
        Me.cmdMore.Size = New System.Drawing.Size(98, 23)
        Me.cmdMore.TabIndex = 2
        Me.cmdMore.Tag = "More"
        Me.cmdMore.Text = "More..."
        Me.cmdMore.UseVisualStyleBackColor = True
        '
        'cboWeights
        '
        Me.cboWeights.FormattingEnabled = True
        Me.cboWeights.Location = New System.Drawing.Point(116, 200)
        Me.cboWeights.Name = "cboWeights"
        Me.cboWeights.Size = New System.Drawing.Size(136, 21)
        Me.cboWeights.TabIndex = 9
        '
        'ucrSelectorSummaryTables
        '
        Me.ucrSelectorSummaryTables.bShowHiddenColumns = False
        Me.ucrSelectorSummaryTables.bUseCurrentFilter = True
        Me.ucrSelectorSummaryTables.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorSummaryTables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSummaryTables.Name = "ucrSelectorSummaryTables"
        Me.ucrSelectorSummaryTables.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorSummaryTables.TabIndex = 11
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(272, 60)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 93)
        Me.ucrReceiverFactor.TabIndex = 12
        '
        'ucrReceiverVariate
        '
        Me.ucrReceiverVariate.frmParent = Me
        Me.ucrReceiverVariate.Location = New System.Drawing.Point(272, 178)
        Me.ucrReceiverVariate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariate.Name = "ucrReceiverVariate"
        Me.ucrReceiverVariate.Selector = Nothing
        Me.ucrReceiverVariate.Size = New System.Drawing.Size(120, 93)
        Me.ucrReceiverVariate.TabIndex = 13
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDisplayMargins.TabIndex = 16
        '
        'ucrChkMeans
        '
        Me.ucrChkMeans.Checked = False
        Me.ucrChkMeans.Location = New System.Drawing.Point(11, 45)
        Me.ucrChkMeans.Name = "ucrChkMeans"
        Me.ucrChkMeans.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMeans.TabIndex = 17
        '
        'ucrChkTotals
        '
        Me.ucrChkTotals.Checked = False
        Me.ucrChkTotals.Location = New System.Drawing.Point(11, 19)
        Me.ucrChkTotals.Name = "ucrChkTotals"
        Me.ucrChkTotals.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkTotals.TabIndex = 18
        '
        'ucrChkTrtSCFactor
        '
        Me.ucrChkTrtSCFactor.Checked = False
        Me.ucrChkTrtSCFactor.Location = New System.Drawing.Point(10, 227)
        Me.ucrChkTrtSCFactor.Name = "ucrChkTrtSCFactor"
        Me.ucrChkTrtSCFactor.Size = New System.Drawing.Size(207, 20)
        Me.ucrChkTrtSCFactor.TabIndex = 19
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 201)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 20
        '
        'ucrInputColumnFactors
        '
        Me.ucrInputColumnFactors.AddQuotesIfUnrecognised = True
        Me.ucrInputColumnFactors.IsMultiline = False
        Me.ucrInputColumnFactors.IsReadOnly = False
        Me.ucrInputColumnFactors.Location = New System.Drawing.Point(89, 42)
        Me.ucrInputColumnFactors.Name = "ucrInputColumnFactors"
        Me.ucrInputColumnFactors.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputColumnFactors.TabIndex = 17
        '
        'ucrNudDecimals
        '
        Me.ucrNudDecimals.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimals.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimals.Location = New System.Drawing.Point(89, 69)
        Me.ucrNudDecimals.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimals.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimals.Name = "ucrNudDecimals"
        Me.ucrNudDecimals.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimals.TabIndex = 18
        Me.ucrNudDecimals.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 441)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrChkTrtSCFactor)
        Me.Controls.Add(Me.ucrReceiverVariate)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSelectorSummaryTables)
        Me.Controls.Add(Me.cboWeights)
        Me.Controls.Add(Me.grpSummaryStat)
        Me.Controls.Add(Me.grpTwoways)
        Me.Controls.Add(Me.lblVariates)
        Me.Controls.Add(Me.lblFactors)
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
        Me.grpSummaryStat.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFactors As Label
    Friend WithEvents lblVariates As Label
    Friend WithEvents grpTwoways As GroupBox
    Friend WithEvents grpSummaryStat As GroupBox
    Friend WithEvents cmdMore As Button
    Friend WithEvents cboWeights As ComboBox
    Friend WithEvents lblDecimals As Label
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrSelectorSummaryTables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverMultiple
    Friend WithEvents ucrReceiverVariate As ucrReceiverMultiple
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrChkTrtSCFactor As ucrCheck
    Friend WithEvents ucrChkTotals As ucrCheck
    Friend WithEvents ucrChkMeans As ucrCheck
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents ucrNudDecimals As ucrNud
    Friend WithEvents ucrInputColumnFactors As ucrInputTextBox
End Class
