<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFrequency
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
        Me.ucrFactorsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrSingleReceiver = New instat.ucrReceiverSingle()
        Me.ucrchkPercentagesOf = New instat.ucrCheck()
        Me.ucrchkOverallPercentages = New instat.ucrCheck()
        Me.ucrchkCounts = New instat.ucrCheck()
        Me.ucrchkWeights = New instat.ucrCheck()
        Me.ucrReceiverSingle = New instat.ucrReceiverSingle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ucrNudDecimals = New instat.ucrNud()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.ucrchkCheckDisplayMargins = New instat.ucrCheck()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrPnlDisplay = New instat.UcrPanel()
        Me.ucrPnlDisplayType = New instat.UcrPanel()
        Me.rdoHorizontally = New System.Windows.Forms.RadioButton()
        Me.rdoVertically = New System.Windows.Forms.RadioButton()
        Me.rdoSeparateTables = New System.Windows.Forms.RadioButton()
        Me.ucrchkDisplay = New instat.ucrCheck()
        Me.ucrchkMargins = New instat.ucrCheck()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 410)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(502, 55)
        Me.ucrBase.TabIndex = 1
        '
        'ucrFactorsSelector
        '
        Me.ucrFactorsSelector.bShowHiddenColumns = False
        Me.ucrFactorsSelector.bUseCurrentFilter = True
        Me.ucrFactorsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrFactorsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorsSelector.Name = "ucrFactorsSelector"
        Me.ucrFactorsSelector.Size = New System.Drawing.Size(210, 182)
        Me.ucrFactorsSelector.TabIndex = 2
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.frmParent = Me
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(240, 70)
        Me.ucrReceiverFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactors.TabIndex = 3
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(237, 55)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 4
        Me.lblFactors.Tag = "Factors:"
        Me.lblFactors.Text = "Factors:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrSingleReceiver)
        Me.GroupBox1.Controls.Add(Me.ucrchkPercentagesOf)
        Me.GroupBox1.Controls.Add(Me.ucrchkOverallPercentages)
        Me.GroupBox1.Controls.Add(Me.ucrchkCounts)
        Me.GroupBox1.Location = New System.Drawing.Point(240, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 101)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'ucrSingleReceiver
        '
        Me.ucrSingleReceiver.frmParent = Me
        Me.ucrSingleReceiver.Location = New System.Drawing.Point(149, 71)
        Me.ucrSingleReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSingleReceiver.Name = "ucrSingleReceiver"
        Me.ucrSingleReceiver.Selector = Nothing
        Me.ucrSingleReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSingleReceiver.TabIndex = 7
        '
        'ucrchkPercentagesOf
        '
        Me.ucrchkPercentagesOf.Checked = False
        Me.ucrchkPercentagesOf.Location = New System.Drawing.Point(5, 71)
        Me.ucrchkPercentagesOf.Name = "ucrchkPercentagesOf"
        Me.ucrchkPercentagesOf.Size = New System.Drawing.Size(141, 20)
        Me.ucrchkPercentagesOf.TabIndex = 2
        '
        'ucrchkOverallPercentages
        '
        Me.ucrchkOverallPercentages.Checked = False
        Me.ucrchkOverallPercentages.Location = New System.Drawing.Point(6, 45)
        Me.ucrchkOverallPercentages.Name = "ucrchkOverallPercentages"
        Me.ucrchkOverallPercentages.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkOverallPercentages.TabIndex = 1
        '
        'ucrchkCounts
        '
        Me.ucrchkCounts.Checked = False
        Me.ucrchkCounts.Location = New System.Drawing.Point(5, 19)
        Me.ucrchkCounts.Name = "ucrchkCounts"
        Me.ucrchkCounts.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkCounts.TabIndex = 0
        '
        'ucrchkWeights
        '
        Me.ucrchkWeights.Checked = False
        Me.ucrchkWeights.Location = New System.Drawing.Point(10, 195)
        Me.ucrchkWeights.Name = "ucrchkWeights"
        Me.ucrchkWeights.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkWeights.TabIndex = 10
        '
        'ucrReceiverSingle
        '
        Me.ucrReceiverSingle.frmParent = Me
        Me.ucrReceiverSingle.Location = New System.Drawing.Point(117, 195)
        Me.ucrReceiverSingle.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingle.Name = "ucrReceiverSingle"
        Me.ucrReceiverSingle.Selector = Nothing
        Me.ucrReceiverSingle.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSingle.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ucrNudDecimals)
        Me.GroupBox2.Controls.Add(Me.lblDecimals)
        Me.GroupBox2.Controls.Add(Me.ucrNudColumnFactors)
        Me.GroupBox2.Controls.Add(Me.lblColumnFactors)
        Me.GroupBox2.Controls.Add(Me.ucrchkCheckDisplayMargins)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 101)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Layout:"
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
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(240, 280)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 13
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrPnlDisplay
        '
        Me.ucrPnlDisplay.Location = New System.Drawing.Point(240, 314)
        Me.ucrPnlDisplay.Name = "ucrPnlDisplay"
        Me.ucrPnlDisplay.Size = New System.Drawing.Size(114, 90)
        Me.ucrPnlDisplay.TabIndex = 48
        '
        'ucrPnlDisplayType
        '
        Me.ucrPnlDisplayType.Location = New System.Drawing.Point(382, 314)
        Me.ucrPnlDisplayType.Name = "ucrPnlDisplayType"
        Me.ucrPnlDisplayType.Size = New System.Drawing.Size(114, 90)
        Me.ucrPnlDisplayType.TabIndex = 52
        '
        'rdoHorizontally
        '
        Me.rdoHorizontally.AutoSize = True
        Me.rdoHorizontally.Location = New System.Drawing.Point(391, 366)
        Me.rdoHorizontally.Name = "rdoHorizontally"
        Me.rdoHorizontally.Size = New System.Drawing.Size(79, 17)
        Me.rdoHorizontally.TabIndex = 55
        Me.rdoHorizontally.TabStop = True
        Me.rdoHorizontally.Text = "Horizontally"
        Me.rdoHorizontally.UseVisualStyleBackColor = True
        '
        'rdoVertically
        '
        Me.rdoVertically.AutoSize = True
        Me.rdoVertically.Location = New System.Drawing.Point(391, 342)
        Me.rdoVertically.Name = "rdoVertically"
        Me.rdoVertically.Size = New System.Drawing.Size(67, 17)
        Me.rdoVertically.TabIndex = 54
        Me.rdoVertically.TabStop = True
        Me.rdoVertically.Text = "Vertically"
        Me.rdoVertically.UseVisualStyleBackColor = True
        '
        'rdoSeparateTables
        '
        Me.rdoSeparateTables.AutoSize = True
        Me.rdoSeparateTables.Location = New System.Drawing.Point(391, 318)
        Me.rdoSeparateTables.Name = "rdoSeparateTables"
        Me.rdoSeparateTables.Size = New System.Drawing.Size(103, 17)
        Me.rdoSeparateTables.TabIndex = 53
        Me.rdoSeparateTables.TabStop = True
        Me.rdoSeparateTables.Text = "Separate Tables"
        Me.rdoSeparateTables.UseVisualStyleBackColor = True
        '
        'ucrchkDisplay
        '
        Me.ucrchkDisplay.Checked = False
        Me.ucrchkDisplay.Location = New System.Drawing.Point(245, 324)
        Me.ucrchkDisplay.Name = "ucrchkDisplay"
        Me.ucrchkDisplay.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkDisplay.TabIndex = 56
        '
        'ucrchkMargins
        '
        Me.ucrchkMargins.Checked = False
        Me.ucrchkMargins.Location = New System.Drawing.Point(245, 350)
        Me.ucrchkMargins.Name = "ucrchkMargins"
        Me.ucrchkMargins.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkMargins.TabIndex = 57
        '
        'dlgFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 478)
        Me.Controls.Add(Me.ucrchkMargins)
        Me.Controls.Add(Me.ucrchkDisplay)
        Me.Controls.Add(Me.rdoHorizontally)
        Me.Controls.Add(Me.rdoVertically)
        Me.Controls.Add(Me.rdoSeparateTables)
        Me.Controls.Add(Me.ucrPnlDisplayType)
        Me.Controls.Add(Me.ucrPnlDisplay)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ucrReceiverSingle)
        Me.Controls.Add(Me.ucrchkWeights)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrFactorsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFrequency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frequency"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrFactorsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrchkPercentagesOf As ucrCheck
    Friend WithEvents ucrchkOverallPercentages As ucrCheck
    Friend WithEvents ucrchkCounts As ucrCheck
    Friend WithEvents ucrSingleReceiver As ucrReceiverSingle
    Friend WithEvents ucrReceiverSingle As ucrReceiverSingle
    Friend WithEvents ucrchkWeights As ucrCheck
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ucrNudDecimals As ucrNud
    Friend WithEvents lblDecimals As Label
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrchkCheckDisplayMargins As ucrCheck
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrPnlDisplayType As UcrPanel
    Friend WithEvents ucrPnlDisplay As UcrPanel
    Friend WithEvents ucrchkMargins As ucrCheck
    Friend WithEvents ucrchkDisplay As ucrCheck
    Friend WithEvents rdoHorizontally As RadioButton
    Friend WithEvents rdoVertically As RadioButton
    Friend WithEvents rdoSeparateTables As RadioButton
End Class
