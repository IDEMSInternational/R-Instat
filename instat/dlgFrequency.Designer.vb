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
        Me.ucrchkWeights = New instat.ucrCheck()
        Me.ucrReceiverSingle = New instat.ucrReceiverSingle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ucrNudDecimals = New instat.ucrNud()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrChkCounts = New instat.ucrCheck()
        Me.ucrChkOverallPercentages = New instat.ucrCheck()
        Me.ucrChkPercentagesOf = New instat.ucrCheck()
        Me.ucrSingleReceiver = New instat.ucrReceiverSingle()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.GroupBox2.SuspendLayout()
        Me.grpDisplay.SuspendLayout()
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
        'ucrchkWeights
        '
        Me.ucrchkWeights.Checked = False
        Me.ucrchkWeights.Location = New System.Drawing.Point(10, 204)
        Me.ucrchkWeights.Name = "ucrchkWeights"
        Me.ucrchkWeights.Size = New System.Drawing.Size(75, 20)
        Me.ucrchkWeights.TabIndex = 3
        '
        'ucrReceiverSingle
        '
        Me.ucrReceiverSingle.frmParent = Me
        Me.ucrReceiverSingle.Location = New System.Drawing.Point(103, 204)
        Me.ucrReceiverSingle.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingle.Name = "ucrReceiverSingle"
        Me.ucrReceiverSingle.Selector = Nothing
        Me.ucrReceiverSingle.Size = New System.Drawing.Size(117, 20)
        Me.ucrReceiverSingle.strNcFilePath = ""
        Me.ucrReceiverSingle.TabIndex = 4
        Me.ucrReceiverSingle.ucrSelector = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ucrNudDecimals)
        Me.GroupBox2.Controls.Add(Me.lblDecimals)
        Me.GroupBox2.Controls.Add(Me.ucrNudColumnFactors)
        Me.GroupBox2.Controls.Add(Me.lblColumnFactors)
        Me.GroupBox2.Controls.Add(Me.ucrChkDisplayMargins)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 282)
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
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(5, 19)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(104, 20)
        Me.ucrChkDisplayMargins.TabIndex = 0
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(321, 256)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(86, 23)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkCounts
        '
        Me.ucrChkCounts.Checked = False
        Me.ucrChkCounts.Location = New System.Drawing.Point(5, 19)
        Me.ucrChkCounts.Name = "ucrChkCounts"
        Me.ucrChkCounts.Size = New System.Drawing.Size(115, 20)
        Me.ucrChkCounts.TabIndex = 0
        '
        'ucrChkOverallPercentages
        '
        Me.ucrChkOverallPercentages.Checked = False
        Me.ucrChkOverallPercentages.Location = New System.Drawing.Point(5, 45)
        Me.ucrChkOverallPercentages.Name = "ucrChkOverallPercentages"
        Me.ucrChkOverallPercentages.Size = New System.Drawing.Size(140, 20)
        Me.ucrChkOverallPercentages.TabIndex = 1
        '
        'ucrChkPercentagesOf
        '
        Me.ucrChkPercentagesOf.Checked = False
        Me.ucrChkPercentagesOf.Location = New System.Drawing.Point(5, 71)
        Me.ucrChkPercentagesOf.Name = "ucrChkPercentagesOf"
        Me.ucrChkPercentagesOf.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkPercentagesOf.TabIndex = 2
        '
        'ucrSingleReceiver
        '
        Me.ucrSingleReceiver.frmParent = Me
        Me.ucrSingleReceiver.Location = New System.Drawing.Point(99, 71)
        Me.ucrSingleReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSingleReceiver.Name = "ucrSingleReceiver"
        Me.ucrSingleReceiver.Selector = Nothing
        Me.ucrSingleReceiver.Size = New System.Drawing.Size(86, 20)
        Me.ucrSingleReceiver.strNcFilePath = ""
        Me.ucrSingleReceiver.TabIndex = 3
        Me.ucrSingleReceiver.ucrSelector = Nothing
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrSingleReceiver)
        Me.grpDisplay.Controls.Add(Me.ucrChkPercentagesOf)
        Me.grpDisplay.Controls.Add(Me.ucrChkOverallPercentages)
        Me.grpDisplay.Controls.Add(Me.ucrChkCounts)
        Me.grpDisplay.Location = New System.Drawing.Point(175, 282)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(232, 104)
        Me.grpDisplay.TabIndex = 5
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display"
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 230)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkOmitMissing.TabIndex = 4
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.Checked = False
        Me.ucrChkPrintOutput.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        Me.ucrChkPrintOutput.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkPrintOutput.TabIndex = 9
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
        Me.ClientSize = New System.Drawing.Size(423, 456)
        Me.Controls.Add(Me.ucrChkPrintOutput)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ucrReceiverSingle)
        Me.Controls.Add(Me.ucrchkWeights)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFrequency As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrReceiverSingle As ucrReceiverSingle
    Friend WithEvents ucrchkWeights As ucrCheck
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ucrNudDecimals As ucrNud
    Friend WithEvents lblDecimals As Label
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents cmdOptions As Button
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrSingleReceiver As ucrReceiverSingle
    Friend WithEvents ucrChkPercentagesOf As ucrCheck
    Friend WithEvents ucrChkOverallPercentages As ucrCheck
    Friend WithEvents ucrChkCounts As ucrCheck
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkPrintOutput As ucrCheck
End Class
