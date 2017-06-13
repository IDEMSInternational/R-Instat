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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblDisplayNA = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPageBy = New System.Windows.Forms.Label()
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.lblFactorsAsPercentage = New System.Windows.Forms.Label()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.ucrInputNA = New instat.ucrInputTextBox()
        Me.ucrChkRowNumbers = New instat.ucrCheck()
        Me.ucrInputPageBy = New instat.ucrInputComboBox()
        Me.ucrChkHTMLTable = New instat.ucrCheck()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrReceiverSingle = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverMultiplePercentages = New instat.ucrReceiverMultiple()
        Me.ucrChkPercentageProportion = New instat.ucrCheck()
        Me.ucrChkDisplayAsPercentage = New instat.ucrCheck()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrSelectorFrequency = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.GroupBox1.SuspendLayout()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
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
        'lblColumnFactors
        '
        Me.lblColumnFactors.AutoSize = True
        Me.lblColumnFactors.Location = New System.Drawing.Point(8, 128)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(83, 13)
        Me.lblColumnFactors.TabIndex = 6
        Me.lblColumnFactors.Tag = "Column_Factors"
        Me.lblColumnFactors.Text = "Column Factors:"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(323, 392)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(86, 23)
        Me.cmdOptions.TabIndex = 11
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblDisplayNA
        '
        Me.lblDisplayNA.AutoSize = True
        Me.lblDisplayNA.Location = New System.Drawing.Point(8, 154)
        Me.lblDisplayNA.Name = "lblDisplayNA"
        Me.lblDisplayNA.Size = New System.Drawing.Size(76, 13)
        Me.lblDisplayNA.TabIndex = 8
        Me.lblDisplayNA.Tag = ""
        Me.lblDisplayNA.Text = "Display NA as:"
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
        Me.GroupBox1.Location = New System.Drawing.Point(223, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 192)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'lblPageBy
        '
        Me.lblPageBy.AutoSize = True
        Me.lblPageBy.Location = New System.Drawing.Point(8, 75)
        Me.lblPageBy.Name = "lblPageBy"
        Me.lblPageBy.Size = New System.Drawing.Size(49, 13)
        Me.lblPageBy.TabIndex = 2
        Me.lblPageBy.Tag = "Page by:"
        Me.lblPageBy.Text = "Page by:"
        '
        'lblSigFigs
        '
        Me.lblSigFigs.AutoSize = True
        Me.lblSigFigs.Location = New System.Drawing.Point(8, 101)
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Size = New System.Drawing.Size(96, 13)
        Me.lblSigFigs.TabIndex = 4
        Me.lblSigFigs.Tag = "Significant_Figures:"
        Me.lblSigFigs.Text = "Significant Figures:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.lblFactorsAsPercentage)
        Me.grpDisplay.Controls.Add(Me.ucrReceiverMultiplePercentages)
        Me.grpDisplay.Controls.Add(Me.ucrChkPercentageProportion)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplayAsPercentage)
        Me.grpDisplay.Location = New System.Drawing.Point(414, 194)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(155, 192)
        Me.grpDisplay.TabIndex = 9
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Percentages"
        '
        'lblFactorsAsPercentage
        '
        Me.lblFactorsAsPercentage.AutoSize = True
        Me.lblFactorsAsPercentage.Location = New System.Drawing.Point(18, 44)
        Me.lblFactorsAsPercentage.Name = "lblFactorsAsPercentage"
        Me.lblFactorsAsPercentage.Size = New System.Drawing.Size(117, 13)
        Me.lblFactorsAsPercentage.TabIndex = 1
        Me.lblFactorsAsPercentage.Tag = "Factors as Percentage:"
        Me.lblFactorsAsPercentage.Text = "Factors as Percentage:"
        '
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigFigs.Location = New System.Drawing.Point(129, 98)
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigFigs.TabIndex = 5
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudColumnFactors
        '
        Me.ucrNudColumnFactors.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumnFactors.Location = New System.Drawing.Point(130, 124)
        Me.ucrNudColumnFactors.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumnFactors.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Name = "ucrNudColumnFactors"
        Me.ucrNudColumnFactors.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColumnFactors.TabIndex = 7
        Me.ucrNudColumnFactors.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputNA
        '
        Me.ucrInputNA.AddQuotesIfUnrecognised = True
        Me.ucrInputNA.IsMultiline = False
        Me.ucrInputNA.IsReadOnly = False
        Me.ucrInputNA.Location = New System.Drawing.Point(90, 150)
        Me.ucrInputNA.Name = "ucrInputNA"
        Me.ucrInputNA.Size = New System.Drawing.Size(89, 21)
        Me.ucrInputNA.TabIndex = 9
        '
        'ucrChkRowNumbers
        '
        Me.ucrChkRowNumbers.Checked = False
        Me.ucrChkRowNumbers.Location = New System.Drawing.Point(11, 19)
        Me.ucrChkRowNumbers.Name = "ucrChkRowNumbers"
        Me.ucrChkRowNumbers.Size = New System.Drawing.Size(156, 20)
        Me.ucrChkRowNumbers.TabIndex = 0
        '
        'ucrInputPageBy
        '
        Me.ucrInputPageBy.AddQuotesIfUnrecognised = True
        Me.ucrInputPageBy.IsReadOnly = False
        Me.ucrInputPageBy.Location = New System.Drawing.Point(60, 71)
        Me.ucrInputPageBy.Name = "ucrInputPageBy"
        Me.ucrInputPageBy.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputPageBy.TabIndex = 3
        '
        'ucrChkHTMLTable
        '
        Me.ucrChkHTMLTable.Checked = False
        Me.ucrChkHTMLTable.Location = New System.Drawing.Point(11, 45)
        Me.ucrChkHTMLTable.Name = "ucrChkHTMLTable"
        Me.ucrChkHTMLTable.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkHTMLTable.TabIndex = 1
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.Location = New System.Drawing.Point(10, 391)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(270, 24)
        Me.ucrSaveTable.TabIndex = 10
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(10, 365)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(104, 20)
        Me.ucrChkDisplayMargins.TabIndex = 7
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(10, 339)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkStoreResults.TabIndex = 6
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
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 200)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkWeights.TabIndex = 3
        '
        'ucrReceiverMultiplePercentages
        '
        Me.ucrReceiverMultiplePercentages.frmParent = Nothing
        Me.ucrReceiverMultiplePercentages.Location = New System.Drawing.Point(18, 59)
        Me.ucrReceiverMultiplePercentages.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePercentages.Name = "ucrReceiverMultiplePercentages"
        Me.ucrReceiverMultiplePercentages.Selector = Nothing
        Me.ucrReceiverMultiplePercentages.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiplePercentages.strNcFilePath = ""
        Me.ucrReceiverMultiplePercentages.TabIndex = 2
        Me.ucrReceiverMultiplePercentages.ucrSelector = Nothing
        '
        'ucrChkPercentageProportion
        '
        Me.ucrChkPercentageProportion.Checked = False
        Me.ucrChkPercentageProportion.Location = New System.Drawing.Point(14, 166)
        Me.ucrChkPercentageProportion.Name = "ucrChkPercentageProportion"
        Me.ucrChkPercentageProportion.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkPercentageProportion.TabIndex = 3
        '
        'ucrChkDisplayAsPercentage
        '
        Me.ucrChkDisplayAsPercentage.Checked = False
        Me.ucrChkDisplayAsPercentage.Location = New System.Drawing.Point(14, 19)
        Me.ucrChkDisplayAsPercentage.Name = "ucrChkDisplayAsPercentage"
        Me.ucrChkDisplayAsPercentage.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkDisplayAsPercentage.TabIndex = 0
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
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 421)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(425, 55)
        Me.ucrBase.TabIndex = 12
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(227, 311)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(91, 20)
        Me.UcrCheck1.TabIndex = 9
        '
        'dlgFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 478)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.ucrChkStoreResults)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
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
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents ucrChkHTMLTable As ucrCheck
    Friend WithEvents ucrInputNA As ucrInputTextBox
    Friend WithEvents lblDisplayNA As Label
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents ucrChkRowNumbers As ucrCheck
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPageBy As Label
    Friend WithEvents ucrInputPageBy As ucrInputComboBox
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents ucrChkPercentageProportion As ucrCheck
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents lblFactorsAsPercentage As Label
    Friend WithEvents ucrReceiverMultiplePercentages As ucrReceiverMultiple
    Friend WithEvents ucrChkDisplayAsPercentage As ucrCheck
End Class
