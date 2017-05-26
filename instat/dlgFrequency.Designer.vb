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
        Me.ucrFactorsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrchkWeights = New instat.ucrCheck()
        Me.ucrReceiverSingle = New instat.ucrReceiverSingle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ucrNudDecimals = New instat.ucrNud()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.ucrchkCheckDisplayMargins = New instat.ucrCheck()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrchkCounts = New instat.ucrCheck()
        Me.ucrchkOverallPercentages = New instat.ucrCheck()
        Me.ucrchkPercentagesOf = New instat.ucrCheck()
        Me.ucrSingleReceiver = New instat.ucrReceiverSingle()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 332)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(425, 55)
        Me.ucrBase.TabIndex = 8
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
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.frmParent = Me
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(222, 70)
        Me.ucrReceiverFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactors.TabIndex = 2
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(218, 55)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Tag = "Factors:"
        Me.lblFactors.Text = "Factors:"
        '
        'ucrchkWeights
        '
        Me.ucrchkWeights.Checked = False
        Me.ucrchkWeights.Location = New System.Drawing.Point(10, 195)
        Me.ucrchkWeights.Name = "ucrchkWeights"
        Me.ucrchkWeights.Size = New System.Drawing.Size(75, 20)
        Me.ucrchkWeights.TabIndex = 3
        '
        'ucrReceiverSingle
        '
        Me.ucrReceiverSingle.frmParent = Me
        Me.ucrReceiverSingle.Location = New System.Drawing.Point(88, 195)
        Me.ucrReceiverSingle.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingle.Name = "ucrReceiverSingle"
        Me.ucrReceiverSingle.Selector = Nothing
        Me.ucrReceiverSingle.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverSingle.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ucrNudDecimals)
        Me.GroupBox2.Controls.Add(Me.lblDecimals)
        Me.GroupBox2.Controls.Add(Me.ucrNudColumnFactors)
        Me.GroupBox2.Controls.Add(Me.lblColumnFactors)
        Me.GroupBox2.Controls.Add(Me.ucrchkCheckDisplayMargins)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 104)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Layout:"
        '
        'ucrNudDecimals
        '
        Me.ucrNudDecimals.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimals.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimals.Location = New System.Drawing.Point(90, 63)
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
        Me.cmdOptions.Location = New System.Drawing.Point(222, 280)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrchkCounts
        '
        Me.ucrchkCounts.Checked = False
        Me.ucrchkCounts.Location = New System.Drawing.Point(5, 19)
        Me.ucrchkCounts.Name = "ucrchkCounts"
        Me.ucrchkCounts.Size = New System.Drawing.Size(115, 20)
        Me.ucrchkCounts.TabIndex = 0
        '
        'ucrchkOverallPercentages
        '
        Me.ucrchkOverallPercentages.Checked = False
        Me.ucrchkOverallPercentages.Location = New System.Drawing.Point(5, 45)
        Me.ucrchkOverallPercentages.Name = "ucrchkOverallPercentages"
        Me.ucrchkOverallPercentages.Size = New System.Drawing.Size(140, 20)
        Me.ucrchkOverallPercentages.TabIndex = 1
        '
        'ucrchkPercentagesOf
        '
        Me.ucrchkPercentagesOf.Checked = False
        Me.ucrchkPercentagesOf.Location = New System.Drawing.Point(5, 71)
        Me.ucrchkPercentagesOf.Name = "ucrchkPercentagesOf"
        Me.ucrchkPercentagesOf.Size = New System.Drawing.Size(91, 20)
        Me.ucrchkPercentagesOf.TabIndex = 2
        '
        'ucrSingleReceiver
        '
        Me.ucrSingleReceiver.frmParent = Me
        Me.ucrSingleReceiver.Location = New System.Drawing.Point(99, 71)
        Me.ucrSingleReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSingleReceiver.Name = "ucrSingleReceiver"
        Me.ucrSingleReceiver.Selector = Nothing
        Me.ucrSingleReceiver.Size = New System.Drawing.Size(86, 20)
        Me.ucrSingleReceiver.TabIndex = 3
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrSingleReceiver)
        Me.grpDisplay.Controls.Add(Me.ucrchkPercentagesOf)
        Me.grpDisplay.Controls.Add(Me.ucrchkOverallPercentages)
        Me.grpDisplay.Controls.Add(Me.ucrchkCounts)
        Me.grpDisplay.Location = New System.Drawing.Point(222, 175)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(213, 101)
        Me.grpDisplay.TabIndex = 5
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display"
        '
        'dlgFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 403)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ucrReceiverSingle)
        Me.Controls.Add(Me.ucrchkWeights)
        Me.Controls.Add(Me.grpDisplay)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrFactorsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrReceiverSingle As ucrReceiverSingle
    Friend WithEvents ucrchkWeights As ucrCheck
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ucrNudDecimals As ucrNud
    Friend WithEvents lblDecimals As Label
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrchkCheckDisplayMargins As ucrCheck
    Friend WithEvents cmdOptions As Button
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrSingleReceiver As ucrReceiverSingle
    Friend WithEvents ucrchkPercentagesOf As ucrCheck
    Friend WithEvents ucrchkOverallPercentages As ucrCheck
    Friend WithEvents ucrchkCounts As ucrCheck
End Class
