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
        Me.grpLayout = New System.Windows.Forms.GroupBox()
        Me.lblPageBy = New System.Windows.Forms.Label()
        Me.ucrInputPageBy = New instat.ucrInputComboBox()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.lblColFactors = New System.Windows.Forms.Label()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverMultiple()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkSummaries = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSummaryCols = New instat.ucrReceiverMultiple()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeight = New instat.ucrCheck()
        Me.ucrSelectorSummaryTables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkHTMLTable = New instat.ucrCheck()
        Me.grpLayout.SuspendLayout()
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
        Me.lblSummaryColumns.TabIndex = 5
        Me.lblSummaryColumns.Tag = "Summary_Columns"
        Me.lblSummaryColumns.Text = "Summary Columns:"
        '
        'grpLayout
        '
        Me.grpLayout.Controls.Add(Me.lblPageBy)
        Me.grpLayout.Controls.Add(Me.ucrInputPageBy)
        Me.grpLayout.Controls.Add(Me.ucrNudSigFigs)
        Me.grpLayout.Controls.Add(Me.lblSigFigs)
        Me.grpLayout.Controls.Add(Me.ucrChkDisplayMargins)
        Me.grpLayout.Location = New System.Drawing.Point(10, 331)
        Me.grpLayout.Name = "grpLayout"
        Me.grpLayout.Size = New System.Drawing.Size(248, 105)
        Me.grpLayout.TabIndex = 13
        Me.grpLayout.TabStop = False
        Me.grpLayout.Text = "Layout"
        '
        'lblPageBy
        '
        Me.lblPageBy.AutoSize = True
        Me.lblPageBy.Location = New System.Drawing.Point(5, 48)
        Me.lblPageBy.Name = "lblPageBy"
        Me.lblPageBy.Size = New System.Drawing.Size(49, 13)
        Me.lblPageBy.TabIndex = 15
        Me.lblPageBy.Tag = "Page by:"
        Me.lblPageBy.Text = "Page by:"
        '
        'ucrInputPageBy
        '
        Me.ucrInputPageBy.AddQuotesIfUnrecognised = True
        Me.ucrInputPageBy.IsReadOnly = False
        Me.ucrInputPageBy.Location = New System.Drawing.Point(99, 44)
        Me.ucrInputPageBy.Name = "ucrInputPageBy"
        Me.ucrInputPageBy.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputPageBy.TabIndex = 5
        '
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigFigs.Location = New System.Drawing.Point(99, 75)
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigFigs.TabIndex = 4
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSigFigs
        '
        Me.lblSigFigs.AutoSize = True
        Me.lblSigFigs.Location = New System.Drawing.Point(5, 77)
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Size = New System.Drawing.Size(96, 13)
        Me.lblSigFigs.TabIndex = 3
        Me.lblSigFigs.Tag = "Significant_Figures:"
        Me.lblSigFigs.Text = "Significant Figures:"
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(150, 20)
        Me.ucrChkDisplayMargins.TabIndex = 0
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(264, 413)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(120, 23)
        Me.cmdSummaries.TabIndex = 14
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblColFactors
        '
        Me.lblColFactors.AutoSize = True
        Me.lblColFactors.Location = New System.Drawing.Point(264, 171)
        Me.lblColFactors.Name = "lblColFactors"
        Me.lblColFactors.Size = New System.Drawing.Size(83, 13)
        Me.lblColFactors.TabIndex = 3
        Me.lblColFactors.Tag = "Column Factors:"
        Me.lblColFactors.Text = "Column Factors:"
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(264, 186)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnFactor.strNcFilePath = ""
        Me.ucrReceiverColumnFactor.TabIndex = 4
        Me.ucrReceiverColumnFactor.ucrSelector = Nothing
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 281)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkOmitMissing.TabIndex = 11
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(10, 255)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkStoreResults.TabIndex = 10
        '
        'ucrChkSummaries
        '
        Me.ucrChkSummaries.Checked = False
        Me.ucrChkSummaries.Location = New System.Drawing.Point(10, 229)
        Me.ucrChkSummaries.Name = "ucrChkSummaries"
        Me.ucrChkSummaries.Size = New System.Drawing.Size(242, 20)
        Me.ucrChkSummaries.TabIndex = 9
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 442)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(435, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrReceiverSummaryCols
        '
        Me.ucrReceiverSummaryCols.frmParent = Me
        Me.ucrReceiverSummaryCols.Location = New System.Drawing.Point(264, 310)
        Me.ucrReceiverSummaryCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSummaryCols.Name = "ucrReceiverSummaryCols"
        Me.ucrReceiverSummaryCols.Selector = Nothing
        Me.ucrReceiverSummaryCols.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSummaryCols.strNcFilePath = ""
        Me.ucrReceiverSummaryCols.TabIndex = 6
        Me.ucrReceiverSummaryCols.ucrSelector = Nothing
        '
        'ucrReceiverRowFactor
        '
        Me.ucrReceiverRowFactor.frmParent = Me
        Me.ucrReceiverRowFactor.Location = New System.Drawing.Point(264, 60)
        Me.ucrReceiverRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Selector = Nothing
        Me.ucrReceiverRowFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverRowFactor.strNcFilePath = ""
        Me.ucrReceiverRowFactor.TabIndex = 2
        Me.ucrReceiverRowFactor.ucrSelector = Nothing
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(109, 206)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 8
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeight
        '
        Me.ucrChkWeight.Checked = False
        Me.ucrChkWeight.Location = New System.Drawing.Point(10, 204)
        Me.ucrChkWeight.Name = "ucrChkWeight"
        Me.ucrChkWeight.Size = New System.Drawing.Size(84, 20)
        Me.ucrChkWeight.TabIndex = 7
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
        'ucrChkHTMLTable
        '
        Me.ucrChkHTMLTable.Checked = False
        Me.ucrChkHTMLTable.Location = New System.Drawing.Point(10, 307)
        Me.ucrChkHTMLTable.Name = "ucrChkHTMLTable"
        Me.ucrChkHTMLTable.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkHTMLTable.TabIndex = 15
        '
        'dlgNewSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 497)
        Me.Controls.Add(Me.ucrChkHTMLTable)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.lblColFactors)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrChkStoreResults)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.grpLayout)
        Me.Controls.Add(Me.ucrChkSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverSummaryCols)
        Me.Controls.Add(Me.lblSummaryColumns)
        Me.Controls.Add(Me.ucrReceiverRowFactor)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeight)
        Me.Controls.Add(Me.lblRowFactors)
        Me.Controls.Add(Me.ucrSelectorSummaryTables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewSummaryTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Summary Tables"
        Me.grpLayout.ResumeLayout(False)
        Me.grpLayout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorSummaryTables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblRowFactors As Label
    Friend WithEvents ucrChkWeight As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverMultiple
    Friend WithEvents ucrReceiverSummaryCols As ucrReceiverMultiple
    Friend WithEvents lblSummaryColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkSummaries As ucrCheck
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents grpLayout As GroupBox
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverMultiple
    Friend WithEvents lblColFactors As Label
    Friend WithEvents lblPageBy As Label
    Friend WithEvents ucrInputPageBy As ucrInputComboBox
    Friend WithEvents ucrChkHTMLTable As ucrCheck
End Class
