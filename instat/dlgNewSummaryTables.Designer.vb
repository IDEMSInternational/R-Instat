<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNewSummaryTables
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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblSummaryColumns = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrNudDecimals = New instat.ucrNud()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.ucrchkCheckDisplayMargins = New instat.ucrCheck()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrchkCheckSummaries = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverNumeric = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFactor = New instat.ucrReceiverMultiple()
        Me.ucrSingleReceiver = New instat.ucrReceiverSingle()
        Me.ucrchkCheckWeight = New instat.ucrCheck()
        Me.ucrFactorsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(264, 45)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Tag = "Factors:"
        Me.lblFactors.Text = "Factors:"
        '
        'lblSummaryColumns
        '
        Me.lblSummaryColumns.AutoSize = True
        Me.lblSummaryColumns.Location = New System.Drawing.Point(264, 170)
        Me.lblSummaryColumns.Name = "lblSummaryColumns"
        Me.lblSummaryColumns.Size = New System.Drawing.Size(96, 13)
        Me.lblSummaryColumns.TabIndex = 3
        Me.lblSummaryColumns.Tag = "Summary_Columns"
        Me.lblSummaryColumns.Text = "Summary Columns:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrNudDecimals)
        Me.GroupBox1.Controls.Add(Me.lblDecimals)
        Me.GroupBox1.Controls.Add(Me.ucrNudColumnFactors)
        Me.GroupBox1.Controls.Add(Me.lblColumnFactors)
        Me.GroupBox1.Controls.Add(Me.ucrchkCheckDisplayMargins)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 101)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Layout:"
        '
        'ucrNudDecimals
        '
        Me.ucrNudDecimals.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimals.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimals.Location = New System.Drawing.Point(90, 65)
        Me.ucrNudDecimals.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimals.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimals.Name = "ucrNudDecimals"
        Me.ucrNudDecimals.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimals.TabIndex = 4
        Me.ucrNudDecimals.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDecimals
        '
        Me.lblDecimals.AutoSize = True
        Me.lblDecimals.Location = New System.Drawing.Point(5, 65)
        Me.lblDecimals.Name = "lblDecimals"
        Me.lblDecimals.Size = New System.Drawing.Size(53, 13)
        Me.lblDecimals.TabIndex = 3
        Me.lblDecimals.Tag = "Decimals"
        Me.lblDecimals.Text = "Decimals:"
        '
        'ucrNudColumnFactors
        '
        Me.ucrNudColumnFactors.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumnFactors.Location = New System.Drawing.Point(90, 40)
        Me.ucrNudColumnFactors.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumnFactors.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Name = "ucrNudColumnFactors"
        Me.ucrNudColumnFactors.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColumnFactors.TabIndex = 2
        Me.ucrNudColumnFactors.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblColumnFactors
        '
        Me.lblColumnFactors.AutoSize = True
        Me.lblColumnFactors.Location = New System.Drawing.Point(5, 42)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(83, 13)
        Me.lblColumnFactors.TabIndex = 1
        Me.lblColumnFactors.Tag = "Column_Factors"
        Me.lblColumnFactors.Text = "Column Factors:"
        '
        'ucrchkCheckDisplayMargins
        '
        Me.ucrchkCheckDisplayMargins.Checked = False
        Me.ucrchkCheckDisplayMargins.Location = New System.Drawing.Point(5, 19)
        Me.ucrchkCheckDisplayMargins.Name = "ucrchkCheckDisplayMargins"
        Me.ucrchkCheckDisplayMargins.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkCheckDisplayMargins.TabIndex = 0
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(309, 288)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(75, 23)
        Me.cmdSummaries.TabIndex = 9
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrchkCheckSummaries
        '
        Me.ucrchkCheckSummaries.Checked = False
        Me.ucrchkCheckSummaries.Location = New System.Drawing.Point(10, 229)
        Me.ucrchkCheckSummaries.Name = "ucrchkCheckSummaries"
        Me.ucrchkCheckSummaries.Size = New System.Drawing.Size(242, 20)
        Me.ucrchkCheckSummaries.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 364)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(435, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrReceiverNumeric
        '
        Me.ucrReceiverNumeric.frmParent = Me
        Me.ucrReceiverNumeric.Location = New System.Drawing.Point(264, 185)
        Me.ucrReceiverNumeric.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNumeric.Name = "ucrReceiverNumeric"
        Me.ucrReceiverNumeric.Selector = Nothing
        Me.ucrReceiverNumeric.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverNumeric.TabIndex = 4
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(264, 60)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactor.TabIndex = 2
        '
        'ucrSingleReceiver
        '
        Me.ucrSingleReceiver.frmParent = Me
        Me.ucrSingleReceiver.Location = New System.Drawing.Point(96, 204)
        Me.ucrSingleReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSingleReceiver.Name = "ucrSingleReceiver"
        Me.ucrSingleReceiver.Selector = Nothing
        Me.ucrSingleReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSingleReceiver.TabIndex = 6
        '
        'ucrchkCheckWeight
        '
        Me.ucrchkCheckWeight.Checked = False
        Me.ucrchkCheckWeight.Location = New System.Drawing.Point(10, 204)
        Me.ucrchkCheckWeight.Name = "ucrchkCheckWeight"
        Me.ucrchkCheckWeight.Size = New System.Drawing.Size(84, 20)
        Me.ucrchkCheckWeight.TabIndex = 5
        '
        'ucrFactorsSelector
        '
        Me.ucrFactorsSelector.bShowHiddenColumns = False
        Me.ucrFactorsSelector.bUseCurrentFilter = True
        Me.ucrFactorsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrFactorsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorsSelector.Name = "ucrFactorsSelector"
        Me.ucrFactorsSelector.Size = New System.Drawing.Size(210, 182)
        Me.ucrFactorsSelector.TabIndex = 0
        '
        'dlgNewSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 428)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrchkCheckSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverNumeric)
        Me.Controls.Add(Me.lblSummaryColumns)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSingleReceiver)
        Me.Controls.Add(Me.ucrchkCheckWeight)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrFactorsSelector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewSummaryTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Summary Tables"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrFactorsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrchkCheckWeight As ucrCheck
    Friend WithEvents ucrSingleReceiver As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactor As ucrReceiverMultiple
    Friend WithEvents ucrReceiverNumeric As ucrReceiverMultiple
    Friend WithEvents lblSummaryColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrchkCheckSummaries As ucrCheck
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrNudDecimals As ucrNud
    Friend WithEvents lblDecimals As Label
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrchkCheckDisplayMargins As ucrCheck
End Class
