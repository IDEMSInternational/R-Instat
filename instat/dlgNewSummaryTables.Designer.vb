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
        Me.ucrFactorsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrCheckWeight = New instat.ucrCheck()
        Me.ucrReceiverNumberColn = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverNumeric = New instat.ucrReceiverMultiple()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ucrCheckDisplayMargins = New instat.ucrCheck()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrNudSetSeed = New instat.ucrNud()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UcrNud1 = New instat.ucrNud()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrCheckSummaries = New instat.ucrCheck()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrFactorsSelector
        '
        Me.ucrFactorsSelector.bShowHiddenColumns = False
        Me.ucrFactorsSelector.bUseCurrentFilter = True
        Me.ucrFactorsSelector.Location = New System.Drawing.Point(10, 9)
        Me.ucrFactorsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorsSelector.Name = "ucrFactorsSelector"
        Me.ucrFactorsSelector.Size = New System.Drawing.Size(210, 182)
        Me.ucrFactorsSelector.TabIndex = 1
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(226, 7)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 5
        Me.lblFactors.Tag = "Factors"
        Me.lblFactors.Text = "Factors:"
        '
        'ucrCheckWeight
        '
        Me.ucrCheckWeight.Checked = False
        Me.ucrCheckWeight.Location = New System.Drawing.Point(10, 204)
        Me.ucrCheckWeight.Name = "ucrCheckWeight"
        Me.ucrCheckWeight.Size = New System.Drawing.Size(84, 20)
        Me.ucrCheckWeight.TabIndex = 6
        '
        'ucrReceiverNumberColn
        '
        Me.ucrReceiverNumberColn.frmParent = Me
        Me.ucrReceiverNumberColn.Location = New System.Drawing.Point(96, 204)
        Me.ucrReceiverNumberColn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNumberColn.Name = "ucrReceiverNumberColn"
        Me.ucrReceiverNumberColn.Selector = Nothing
        Me.ucrReceiverNumberColn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverNumberColn.TabIndex = 7
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(225, 24)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactor.TabIndex = 8
        '
        'ucrReceiverNumeric
        '
        Me.ucrReceiverNumeric.frmParent = Me
        Me.ucrReceiverNumeric.Location = New System.Drawing.Point(228, 146)
        Me.ucrReceiverNumeric.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNumeric.Name = "ucrReceiverNumeric"
        Me.ucrReceiverNumeric.Selector = Nothing
        Me.ucrReceiverNumeric.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverNumeric.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Tag = "Factors"
        Me.Label3.Text = "Summary Columns:"
        '
        'ucrCheckDisplayMargins
        '
        Me.ucrCheckDisplayMargins.Checked = False
        Me.ucrCheckDisplayMargins.Location = New System.Drawing.Point(8, 19)
        Me.ucrCheckDisplayMargins.Name = "ucrCheckDisplayMargins"
        Me.ucrCheckDisplayMargins.Size = New System.Drawing.Size(104, 20)
        Me.ucrCheckDisplayMargins.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Tag = "Factors"
        Me.Label1.Text = "Column Factors:"
        '
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSetSeed.Location = New System.Drawing.Point(89, 40)
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSetSeed.TabIndex = 9
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Tag = "Factors"
        Me.Label2.Text = "Decimals:"
        '
        'UcrNud1
        '
        Me.UcrNud1.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud1.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud1.Location = New System.Drawing.Point(90, 65)
        Me.UcrNud1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud1.Name = "UcrNud1"
        Me.UcrNud1.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud1.TabIndex = 11
        Me.UcrNud1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UcrNud1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ucrNudSetSeed)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ucrCheckDisplayMargins)
        Me.GroupBox1.Location = New System.Drawing.Point(215, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 101)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Layout:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 366)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(382, 50)
        Me.ucrBase.TabIndex = 12
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(10, 314)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(75, 23)
        Me.cmdSummaries.TabIndex = 13
        Me.cmdSummaries.Text = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrCheckSummaries
        '
        Me.ucrCheckSummaries.Checked = False
        Me.ucrCheckSummaries.Location = New System.Drawing.Point(10, 237)
        Me.ucrCheckSummaries.Name = "ucrCheckSummaries"
        Me.ucrCheckSummaries.Size = New System.Drawing.Size(84, 20)
        Me.ucrCheckSummaries.TabIndex = 14
        '
        'dlgNewSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 428)
        Me.Controls.Add(Me.ucrCheckSummaries)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverNumeric)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrReceiverNumberColn)
        Me.Controls.Add(Me.ucrCheckWeight)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrFactorsSelector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewSummaryTables"
        Me.Text = "New Summary Tables"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrFactorsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrCheckWeight As ucrCheck
    Friend WithEvents ucrReceiverNumberColn As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactor As ucrReceiverMultiple
    Friend WithEvents ucrReceiverNumeric As ucrReceiverMultiple
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UcrNud1 As ucrNud
    Friend WithEvents Label2 As Label
    Friend WithEvents ucrNudSetSeed As ucrNud
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrCheckDisplayMargins As ucrCheck
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrCheckSummaries As ucrCheck
End Class
