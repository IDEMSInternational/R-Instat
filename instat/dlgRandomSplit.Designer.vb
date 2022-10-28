<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRandomSplit
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
        Me.rdoSample = New System.Windows.Forms.RadioButton()
        Me.rdoTimeSeries = New System.Windows.Forms.RadioButton()
        Me.lblFraction = New System.Windows.Forms.Label()
        Me.lblPool = New System.Windows.Forms.Label()
        Me.lblBreaks = New System.Windows.Forms.Label()
        Me.ucrNudBreaks = New instat.ucrNud()
        Me.ucrNudPool = New instat.ucrNud()
        Me.ucrNudFraction = New instat.ucrNud()
        Me.ucrNudLag = New instat.ucrNud()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkLag = New instat.ucrCheck()
        Me.ucrChkStratifyingFactor = New instat.ucrCheck()
        Me.ucrPnlRandomSplit = New instat.UcrPanel()
        Me.ucrSelectorRandomSplit = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverRanSplit = New instat.ucrReceiverSingle()
        Me.ucrSaveTrainingData = New instat.ucrSave()
        Me.ucrSaveTestingData = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'rdoSample
        '
        Me.rdoSample.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSample.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSample.FlatAppearance.BorderSize = 2
        Me.rdoSample.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSample.Location = New System.Drawing.Point(110, 20)
        Me.rdoSample.Name = "rdoSample"
        Me.rdoSample.Size = New System.Drawing.Size(100, 28)
        Me.rdoSample.TabIndex = 21
        Me.rdoSample.Text = "Sample"
        Me.rdoSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSample.UseVisualStyleBackColor = True
        '
        'rdoTimeSeries
        '
        Me.rdoTimeSeries.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTimeSeries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTimeSeries.FlatAppearance.BorderSize = 2
        Me.rdoTimeSeries.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTimeSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTimeSeries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTimeSeries.Location = New System.Drawing.Point(208, 20)
        Me.rdoTimeSeries.Name = "rdoTimeSeries"
        Me.rdoTimeSeries.Size = New System.Drawing.Size(100, 28)
        Me.rdoTimeSeries.TabIndex = 20
        Me.rdoTimeSeries.Text = "Time Series"
        Me.rdoTimeSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTimeSeries.UseVisualStyleBackColor = True
        '
        'lblFraction
        '
        Me.lblFraction.AutoSize = True
        Me.lblFraction.Location = New System.Drawing.Point(281, 152)
        Me.lblFraction.Name = "lblFraction"
        Me.lblFraction.Size = New System.Drawing.Size(48, 13)
        Me.lblFraction.TabIndex = 32
        Me.lblFraction.Text = "Fraction:"
        '
        'lblPool
        '
        Me.lblPool.AutoSize = True
        Me.lblPool.Location = New System.Drawing.Point(281, 183)
        Me.lblPool.Name = "lblPool"
        Me.lblPool.Size = New System.Drawing.Size(31, 13)
        Me.lblPool.TabIndex = 33
        Me.lblPool.Text = "Pool:"
        '
        'lblBreaks
        '
        Me.lblBreaks.AutoSize = True
        Me.lblBreaks.Location = New System.Drawing.Point(281, 216)
        Me.lblBreaks.Name = "lblBreaks"
        Me.lblBreaks.Size = New System.Drawing.Size(46, 13)
        Me.lblBreaks.TabIndex = 37
        Me.lblBreaks.Text = "Breaks :"
        '
        'ucrNudBreaks
        '
        Me.ucrNudBreaks.AutoSize = True
        Me.ucrNudBreaks.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBreaks.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBreaks.Location = New System.Drawing.Point(351, 216)
        Me.ucrNudBreaks.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBreaks.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBreaks.Name = "ucrNudBreaks"
        Me.ucrNudBreaks.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBreaks.TabIndex = 36
        Me.ucrNudBreaks.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPool
        '
        Me.ucrNudPool.AutoSize = True
        Me.ucrNudPool.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPool.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPool.Location = New System.Drawing.Point(351, 183)
        Me.ucrNudPool.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPool.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPool.Name = "ucrNudPool"
        Me.ucrNudPool.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPool.TabIndex = 31
        Me.ucrNudPool.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFraction
        '
        Me.ucrNudFraction.AutoSize = True
        Me.ucrNudFraction.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFraction.Location = New System.Drawing.Point(351, 152)
        Me.ucrNudFraction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFraction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Name = "ucrNudFraction"
        Me.ucrNudFraction.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFraction.TabIndex = 30
        Me.ucrNudFraction.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLag
        '
        Me.ucrNudLag.AutoSize = True
        Me.ucrNudLag.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLag.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLag.Location = New System.Drawing.Point(92, 249)
        Me.ucrNudLag.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLag.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLag.Name = "ucrNudLag"
        Me.ucrNudLag.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLag.TabIndex = 29
        Me.ucrNudLag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 358)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 27
        '
        'ucrChkLag
        '
        Me.ucrChkLag.AutoSize = True
        Me.ucrChkLag.Checked = False
        Me.ucrChkLag.Location = New System.Drawing.Point(9, 249)
        Me.ucrChkLag.Name = "ucrChkLag"
        Me.ucrChkLag.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkLag.TabIndex = 25
        '
        'ucrChkStratifyingFactor
        '
        Me.ucrChkStratifyingFactor.AutoSize = True
        Me.ucrChkStratifyingFactor.Checked = False
        Me.ucrChkStratifyingFactor.Location = New System.Drawing.Point(281, 82)
        Me.ucrChkStratifyingFactor.Name = "ucrChkStratifyingFactor"
        Me.ucrChkStratifyingFactor.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkStratifyingFactor.TabIndex = 19
        '
        'ucrPnlRandomSplit
        '
        Me.ucrPnlRandomSplit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRandomSplit.Location = New System.Drawing.Point(104, 12)
        Me.ucrPnlRandomSplit.Name = "ucrPnlRandomSplit"
        Me.ucrPnlRandomSplit.Size = New System.Drawing.Size(212, 44)
        Me.ucrPnlRandomSplit.TabIndex = 26
        '
        'ucrSelectorRandomSplit
        '
        Me.ucrSelectorRandomSplit.AutoSize = True
        Me.ucrSelectorRandomSplit.bDropUnusedFilterLevels = False
        Me.ucrSelectorRandomSplit.bShowHiddenColumns = False
        Me.ucrSelectorRandomSplit.bUseCurrentFilter = True
        Me.ucrSelectorRandomSplit.Location = New System.Drawing.Point(9, 63)
        Me.ucrSelectorRandomSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRandomSplit.Name = "ucrSelectorRandomSplit"
        Me.ucrSelectorRandomSplit.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorRandomSplit.TabIndex = 38
        '
        'ucrReceiverRanSplit
        '
        Me.ucrReceiverRanSplit.AutoSize = True
        Me.ucrReceiverRanSplit.frmParent = Me
        Me.ucrReceiverRanSplit.Location = New System.Drawing.Point(281, 108)
        Me.ucrReceiverRanSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRanSplit.Name = "ucrReceiverRanSplit"
        Me.ucrReceiverRanSplit.Selector = Nothing
        Me.ucrReceiverRanSplit.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverRanSplit.strNcFilePath = ""
        Me.ucrReceiverRanSplit.TabIndex = 39
        Me.ucrReceiverRanSplit.ucrSelector = Nothing
        '
        'ucrSaveTrainingData
        '
        Me.ucrSaveTrainingData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTrainingData.Location = New System.Drawing.Point(9, 331)
        Me.ucrSaveTrainingData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTrainingData.Name = "ucrSaveTrainingData"
        Me.ucrSaveTrainingData.Size = New System.Drawing.Size(403, 23)
        Me.ucrSaveTrainingData.TabIndex = 28
        '
        'ucrSaveTestingData
        '
        Me.ucrSaveTestingData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTestingData.Location = New System.Drawing.Point(9, 300)
        Me.ucrSaveTestingData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTestingData.Name = "ucrSaveTestingData"
        Me.ucrSaveTestingData.Size = New System.Drawing.Size(403, 23)
        Me.ucrSaveTestingData.TabIndex = 40
        '
        'dlgRandomSplit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 418)
        Me.Controls.Add(Me.ucrSaveTestingData)
        Me.Controls.Add(Me.ucrReceiverRanSplit)
        Me.Controls.Add(Me.lblBreaks)
        Me.Controls.Add(Me.ucrNudBreaks)
        Me.Controls.Add(Me.lblPool)
        Me.Controls.Add(Me.lblFraction)
        Me.Controls.Add(Me.ucrNudPool)
        Me.Controls.Add(Me.ucrNudFraction)
        Me.Controls.Add(Me.ucrNudLag)
        Me.Controls.Add(Me.ucrSaveTrainingData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrChkLag)
        Me.Controls.Add(Me.rdoSample)
        Me.Controls.Add(Me.rdoTimeSeries)
        Me.Controls.Add(Me.ucrChkStratifyingFactor)
        Me.Controls.Add(Me.ucrPnlRandomSplit)
        Me.Controls.Add(Me.ucrSelectorRandomSplit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSplit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Split"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoSample As RadioButton
    Friend WithEvents rdoTimeSeries As RadioButton
    Friend WithEvents ucrChkStratifyingFactor As ucrCheck
    Friend WithEvents ucrChkLag As ucrCheck
    Friend WithEvents ucrNudPool As ucrNud
    Friend WithEvents ucrNudFraction As ucrNud
    Friend WithEvents ucrNudLag As ucrNud
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlRandomSplit As UcrPanel
    Friend WithEvents lblPool As Label
    Friend WithEvents lblFraction As Label
    Friend WithEvents lblBreaks As Label
    Friend WithEvents ucrNudBreaks As ucrNud
    Friend WithEvents ucrSelectorRandomSplit As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRanSplit As ucrReceiverSingle
    Friend WithEvents ucrSaveTrainingData As ucrSave
    Friend WithEvents ucrSaveTestingData As ucrSave
End Class
