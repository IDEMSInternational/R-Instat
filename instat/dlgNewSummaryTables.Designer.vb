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
        Me.lblRowFactors = New System.Windows.Forms.Label()
        Me.lblSummaryColumns = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.ucrNudDecimals = New instat.ucrNud()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrChkSummaries = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverNumeric = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFactor = New instat.ucrReceiverMultiple()
        Me.ucrSingleReceiver = New instat.ucrReceiverSingle()
        Me.ucrChkWeight = New instat.ucrCheck()
        Me.ucrSelectorSummaryTables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverMultiple()
        Me.lblColFactors = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRowFactors
        '
        Me.lblRowFactors.AutoSize = True
        Me.lblRowFactors.Location = New System.Drawing.Point(264, 45)
        Me.lblRowFactors.Name = "lblRowFactors"
        Me.lblRowFactors.Size = New System.Drawing.Size(70, 13)
        Me.lblRowFactors.TabIndex = 1
        Me.lblRowFactors.Tag = "Row Factors:"
        Me.lblRowFactors.Text = "Row Factors:"
        '
        'lblSummaryColumns
        '
        Me.lblSummaryColumns.AutoSize = True
        Me.lblSummaryColumns.Location = New System.Drawing.Point(264, 295)
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
        Me.GroupBox1.Controls.Add(Me.ucrChkDisplayMargins)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 333)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 101)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Layout:"
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
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(177, 387)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(75, 23)
        Me.cmdSummaries.TabIndex = 9
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 307)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkOmitMissing.TabIndex = 3
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(10, 255)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkStoreResults.TabIndex = 0
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.Checked = False
        Me.ucrChkPrintOutput.Location = New System.Drawing.Point(10, 281)
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        Me.ucrChkPrintOutput.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkPrintOutput.TabIndex = 1
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
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(104, 20)
        Me.ucrChkDisplayMargins.TabIndex = 0
        '
        'ucrChkSummaries
        '
        Me.ucrChkSummaries.Checked = False
        Me.ucrChkSummaries.Location = New System.Drawing.Point(10, 229)
        Me.ucrChkSummaries.Name = "ucrChkSummaries"
        Me.ucrChkSummaries.Size = New System.Drawing.Size(242, 20)
        Me.ucrChkSummaries.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 440)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(435, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrReceiverNumeric
        '
        Me.ucrReceiverNumeric.frmParent = Me
        Me.ucrReceiverNumeric.Location = New System.Drawing.Point(264, 310)
        Me.ucrReceiverNumeric.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNumeric.Name = "ucrReceiverNumeric"
        Me.ucrReceiverNumeric.Selector = Nothing
        Me.ucrReceiverNumeric.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverNumeric.strNcFilePath = ""
        Me.ucrReceiverNumeric.TabIndex = 4
        Me.ucrReceiverNumeric.ucrSelector = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(264, 60)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 2
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrSingleReceiver
        '
        Me.ucrSingleReceiver.frmParent = Me
        Me.ucrSingleReceiver.Location = New System.Drawing.Point(96, 204)
        Me.ucrSingleReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSingleReceiver.Name = "ucrSingleReceiver"
        Me.ucrSingleReceiver.Selector = Nothing
        Me.ucrSingleReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSingleReceiver.strNcFilePath = ""
        Me.ucrSingleReceiver.TabIndex = 6
        Me.ucrSingleReceiver.ucrSelector = Nothing
        '
        'ucrChkWeight
        '
        Me.ucrChkWeight.Checked = False
        Me.ucrChkWeight.Location = New System.Drawing.Point(10, 204)
        Me.ucrChkWeight.Name = "ucrChkWeight"
        Me.ucrChkWeight.Size = New System.Drawing.Size(84, 20)
        Me.ucrChkWeight.TabIndex = 5
        '
        'ucrSelectorSummaryTables
        '
        Me.ucrSelectorSummaryTables.bShowHiddenColumns = False
        Me.ucrSelectorSummaryTables.bUseCurrentFilter = True
        Me.ucrSelectorSummaryTables.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorSummaryTables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSummaryTables.Name = "ucrSelectorSummaryTables"
        Me.ucrSelectorSummaryTables.Size = New System.Drawing.Size(210, 182)
        Me.ucrSelectorSummaryTables.TabIndex = 0
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(264, 184)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnFactor.strNcFilePath = ""
        Me.ucrReceiverColumnFactor.TabIndex = 12
        Me.ucrReceiverColumnFactor.ucrSelector = Nothing
        '
        'lblColFactors
        '
        Me.lblColFactors.AutoSize = True
        Me.lblColFactors.Location = New System.Drawing.Point(264, 169)
        Me.lblColFactors.Name = "lblColFactors"
        Me.lblColFactors.Size = New System.Drawing.Size(83, 13)
        Me.lblColFactors.TabIndex = 11
        Me.lblColFactors.Tag = "Column Factors:"
        Me.lblColFactors.Text = "Column Factors:"
        '
        'dlgNewSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 496)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.lblColFactors)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrChkStoreResults)
        Me.Controls.Add(Me.ucrChkPrintOutput)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrChkSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverNumeric)
        Me.Controls.Add(Me.lblSummaryColumns)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSingleReceiver)
        Me.Controls.Add(Me.ucrChkWeight)
        Me.Controls.Add(Me.lblRowFactors)
        Me.Controls.Add(Me.ucrSelectorSummaryTables)
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

    Friend WithEvents ucrSelectorSummaryTables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblRowFactors As Label
    Friend WithEvents ucrChkWeight As ucrCheck
    Friend WithEvents ucrSingleReceiver As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactor As ucrReceiverMultiple
    Friend WithEvents ucrReceiverNumeric As ucrReceiverMultiple
    Friend WithEvents lblSummaryColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkSummaries As ucrCheck
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrNudDecimals As ucrNud
    Friend WithEvents lblDecimals As Label
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrChkPrintOutput As ucrCheck
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverMultiple
    Friend WithEvents lblColFactors As Label
End Class
