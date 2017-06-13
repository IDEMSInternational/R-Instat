<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgFrequency
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
        Me.ucrSelectorFrequency = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverSingle = New instat.ucrReceiverSingle()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrChkCounts = New instat.ucrCheck()
        Me.ucrChkPercentagesOf = New instat.ucrCheck()
        Me.ucrSingleReceiver = New instat.ucrReceiverSingle()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkHTMLTable = New instat.ucrCheck()
        Me.ucrInputNA = New instat.ucrInputTextBox()
        Me.lblDisplayNA = New System.Windows.Forms.Label()
        Me.ucrChkSummaries = New instat.ucrCheck()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrChkRowNumbers = New instat.ucrCheck()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPageBy = New System.Windows.Forms.Label()
        Me.ucrInputPageBy = New instat.ucrInputComboBox()
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.ucrChkPercentageDecimal = New instat.ucrCheck()
        Me.lblPercentageType = New System.Windows.Forms.Label()
        Me.ucrInputPercentageType = New instat.ucrInputComboBox()
        Me.grpDisplay.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 392)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(425, 55)
        Me.ucrBase.TabIndex = 8
        '
        'ucrSelectorFrequency
        '
        Me.ucrSelectorFrequency.bShowHiddenColumns = False
        Me.ucrSelectorFrequency.bUseCurrentFilter = True
        Me.ucrSelectorFrequency.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFrequency.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFrequency.Name = "ucrSelectorFrequency"
        Me.ucrSelectorFrequency.Size = New System.Drawing.Size(210, 182)
        Me.ucrSelectorFrequency.TabIndex = 0
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.frmParent = Me
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(253, 60)
        Me.ucrReceiverFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactors.strNcFilePath = ""
        Me.ucrReceiverFactors.TabIndex = 2
        Me.ucrReceiverFactors.ucrSelector = Nothing
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(253, 45)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Tag = "Factors:"
        Me.lblFactors.Text = "Factors:"
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 200)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkWeights.TabIndex = 3
        '
        'ucrReceiverSingle
        '
        Me.ucrReceiverSingle.frmParent = Me
        Me.ucrReceiverSingle.Location = New System.Drawing.Point(101, 200)
        Me.ucrReceiverSingle.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingle.Name = "ucrReceiverSingle"
        Me.ucrReceiverSingle.Selector = Nothing
        Me.ucrReceiverSingle.Size = New System.Drawing.Size(117, 20)
        Me.ucrReceiverSingle.strNcFilePath = ""
        Me.ucrReceiverSingle.TabIndex = 4
        Me.ucrReceiverSingle.ucrSelector = Nothing
        '
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigFigs.Location = New System.Drawing.Point(129, 90)
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigFigs.TabIndex = 4
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudColumnFactors
        '
        Me.ucrNudColumnFactors.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumnFactors.Location = New System.Drawing.Point(129, 114)
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
        Me.lblColumnFactors.Location = New System.Drawing.Point(8, 116)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(83, 13)
        Me.lblColumnFactors.TabIndex = 1
        Me.lblColumnFactors.Tag = "Column_Factors"
        Me.lblColumnFactors.Text = "Column Factors:"
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(10, 304)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(104, 20)
        Me.ucrChkDisplayMargins.TabIndex = 0
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(322, 366)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(86, 23)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkCounts
        '
        Me.ucrChkCounts.Checked = False
        Me.ucrChkCounts.Location = New System.Drawing.Point(500, 278)
        Me.ucrChkCounts.Name = "ucrChkCounts"
        Me.ucrChkCounts.Size = New System.Drawing.Size(115, 20)
        Me.ucrChkCounts.TabIndex = 0
        '
        'ucrChkPercentagesOf
        '
        Me.ucrChkPercentagesOf.Checked = False
        Me.ucrChkPercentagesOf.Location = New System.Drawing.Point(500, 330)
        Me.ucrChkPercentagesOf.Name = "ucrChkPercentagesOf"
        Me.ucrChkPercentagesOf.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkPercentagesOf.TabIndex = 2
        '
        'ucrSingleReceiver
        '
        Me.ucrSingleReceiver.frmParent = Me
        Me.ucrSingleReceiver.Location = New System.Drawing.Point(594, 330)
        Me.ucrSingleReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSingleReceiver.Name = "ucrSingleReceiver"
        Me.ucrSingleReceiver.Selector = Nothing
        Me.ucrSingleReceiver.Size = New System.Drawing.Size(129, 20)
        Me.ucrSingleReceiver.strNcFilePath = ""
        Me.ucrSingleReceiver.TabIndex = 3
        Me.ucrSingleReceiver.ucrSelector = Nothing
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.lblPercentageType)
        Me.grpDisplay.Controls.Add(Me.ucrChkPercentageDecimal)
        Me.grpDisplay.Controls.Add(Me.ucrInputPercentageType)
        Me.grpDisplay.Location = New System.Drawing.Point(459, 45)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(287, 192)
        Me.grpDisplay.TabIndex = 5
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Percentages"
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 278)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkOmitMissing.TabIndex = 4
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(227, 311)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(91, 20)
        Me.UcrCheck1.TabIndex = 9
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(10, 252)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkStoreResults.TabIndex = 10
        '
        'ucrChkHTMLTable
        '
        Me.ucrChkHTMLTable.Checked = False
        Me.ucrChkHTMLTable.Location = New System.Drawing.Point(11, 45)
        Me.ucrChkHTMLTable.Name = "ucrChkHTMLTable"
        Me.ucrChkHTMLTable.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkHTMLTable.TabIndex = 11
        '
        'ucrInputNA
        '
        Me.ucrInputNA.AddQuotesIfUnrecognised = True
        Me.ucrInputNA.IsMultiline = False
        Me.ucrInputNA.IsReadOnly = False
        Me.ucrInputNA.Location = New System.Drawing.Point(90, 139)
        Me.ucrInputNA.Name = "ucrInputNA"
        Me.ucrInputNA.Size = New System.Drawing.Size(89, 21)
        Me.ucrInputNA.TabIndex = 17
        '
        'lblDisplayNA
        '
        Me.lblDisplayNA.AutoSize = True
        Me.lblDisplayNA.Location = New System.Drawing.Point(8, 142)
        Me.lblDisplayNA.Name = "lblDisplayNA"
        Me.lblDisplayNA.Size = New System.Drawing.Size(76, 13)
        Me.lblDisplayNA.TabIndex = 16
        Me.lblDisplayNA.Tag = ""
        Me.lblDisplayNA.Text = "Display NA as:"
        '
        'ucrChkSummaries
        '
        Me.ucrChkSummaries.Checked = False
        Me.ucrChkSummaries.Location = New System.Drawing.Point(10, 226)
        Me.ucrChkSummaries.Name = "ucrChkSummaries"
        Me.ucrChkSummaries.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkSummaries.TabIndex = 18
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.Location = New System.Drawing.Point(10, 365)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(219, 24)
        Me.ucrSaveTable.TabIndex = 19
        '
        'ucrChkRowNumbers
        '
        Me.ucrChkRowNumbers.Checked = False
        Me.ucrChkRowNumbers.Location = New System.Drawing.Point(11, 19)
        Me.ucrChkRowNumbers.Name = "ucrChkRowNumbers"
        Me.ucrChkRowNumbers.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkRowNumbers.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrNudSigFigs)
        Me.GroupBox1.Controls.Add(Me.ucrNudColumnFactors)
        Me.GroupBox1.Controls.Add(Me.lblColumnFactors)
        Me.GroupBox1.Controls.Add(Me.ucrInputNA)
        Me.GroupBox1.Controls.Add(Me.ucrChkRowNumbers)
        Me.GroupBox1.Controls.Add(Me.lblPageBy)
        Me.GroupBox1.Controls.Add(Me.lblDisplayNA)
        Me.GroupBox1.Controls.Add(Me.ucrInputPageBy)
        Me.GroupBox1.Controls.Add(Me.ucrChkHTMLTable)
        Me.GroupBox1.Controls.Add(Me.lblSigFigs)
        Me.GroupBox1.Location = New System.Drawing.Point(221, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 169)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'lblPageBy
        '
        Me.lblPageBy.AutoSize = True
        Me.lblPageBy.Location = New System.Drawing.Point(8, 68)
        Me.lblPageBy.Name = "lblPageBy"
        Me.lblPageBy.Size = New System.Drawing.Size(49, 13)
        Me.lblPageBy.TabIndex = 2
        Me.lblPageBy.Tag = "Page by:"
        Me.lblPageBy.Text = "Page by:"
        '
        'ucrInputPageBy
        '
        Me.ucrInputPageBy.AddQuotesIfUnrecognised = True
        Me.ucrInputPageBy.IsReadOnly = False
        Me.ucrInputPageBy.Location = New System.Drawing.Point(60, 66)
        Me.ucrInputPageBy.Name = "ucrInputPageBy"
        Me.ucrInputPageBy.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputPageBy.TabIndex = 3
        '
        'lblSigFigs
        '
        Me.lblSigFigs.AutoSize = True
        Me.lblSigFigs.Location = New System.Drawing.Point(8, 92)
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Size = New System.Drawing.Size(96, 13)
        Me.lblSigFigs.TabIndex = 4
        Me.lblSigFigs.Tag = "Significant_Figures:"
        Me.lblSigFigs.Text = "Significant Figures:"
        '
        'ucrChkPercentageDecimal
        '
        Me.ucrChkPercentageDecimal.Checked = False
        Me.ucrChkPercentageDecimal.Location = New System.Drawing.Point(6, 109)
        Me.ucrChkPercentageDecimal.Name = "ucrChkPercentageDecimal"
        Me.ucrChkPercentageDecimal.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkPercentageDecimal.TabIndex = 4
        '
        'lblPercentageType
        '
        Me.lblPercentageType.AutoSize = True
        Me.lblPercentageType.Location = New System.Drawing.Point(6, 26)
        Me.lblPercentageType.Name = "lblPercentageType"
        Me.lblPercentageType.Size = New System.Drawing.Size(92, 13)
        Me.lblPercentageType.TabIndex = 21
        Me.lblPercentageType.Tag = "Percentage Type:"
        Me.lblPercentageType.Text = "Percentage Type:"
        '
        'ucrInputPercentageType
        '
        Me.ucrInputPercentageType.AddQuotesIfUnrecognised = True
        Me.ucrInputPercentageType.IsReadOnly = False
        Me.ucrInputPercentageType.Location = New System.Drawing.Point(104, 24)
        Me.ucrInputPercentageType.Name = "ucrInputPercentageType"
        Me.ucrInputPercentageType.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputPercentageType.TabIndex = 22
        '
        'dlgFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 456)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.ucrChkSummaries)
        Me.Controls.Add(Me.ucrSingleReceiver)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.ucrChkPercentagesOf)
        Me.Controls.Add(Me.ucrChkStoreResults)
        Me.Controls.Add(Me.ucrChkCounts)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrReceiverSingle)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrSelectorFrequency)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFrequency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frequency"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFrequency As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrReceiverSingle As ucrReceiverSingle
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents cmdOptions As Button
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrSingleReceiver As ucrReceiverSingle
    Friend WithEvents ucrChkPercentagesOf As ucrCheck
    Friend WithEvents ucrChkCounts As ucrCheck
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents ucrChkHTMLTable As ucrCheck
    Friend WithEvents ucrInputNA As ucrInputTextBox
    Friend WithEvents lblDisplayNA As Label
    Friend WithEvents ucrChkSummaries As ucrCheck
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents ucrChkRowNumbers As ucrCheck
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPageBy As Label
    Friend WithEvents ucrInputPageBy As ucrInputComboBox
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents ucrChkPercentageDecimal As ucrCheck
    Friend WithEvents lblPercentageType As Label
    Friend WithEvents ucrInputPercentageType As ucrInputComboBox
End Class
