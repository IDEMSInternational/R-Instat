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
        Me.lblReceiverRandomSplit = New System.Windows.Forms.Label()
        Me.ucrReceiverRandomSplit = New instat.ucrReceiverMultiple()
        Me.ucrNudPool = New instat.ucrNud()
        Me.ucrNudFraction = New instat.ucrNud()
        Me.ucrNudLag = New instat.ucrNud()
        Me.ucrSaveRandomSplit = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkLag = New instat.ucrCheck()
        Me.ucrChkTrainingData = New instat.ucrCheck()
        Me.ucrChkTestingData = New instat.ucrCheck()
        Me.ucrSelectorRandomSplit = New instat.ucrDataFrame()
        Me.ucrChkStratifyingFactor = New instat.ucrCheck()
        Me.ucrPnlRandomSplit = New instat.UcrPanel()
        Me.ucrNudBreaks = New instat.ucrNud()
        Me.lblBreaks = New System.Windows.Forms.Label()
        Me.ucrSelector = New instat.ucrSelectorByDataFrame()
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
        Me.rdoSample.Location = New System.Drawing.Point(98, 23)
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
        Me.rdoTimeSeries.Location = New System.Drawing.Point(196, 23)
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
        Me.lblFraction.Location = New System.Drawing.Point(278, 223)
        Me.lblFraction.Name = "lblFraction"
        Me.lblFraction.Size = New System.Drawing.Size(51, 13)
        Me.lblFraction.TabIndex = 32
        Me.lblFraction.Text = "Fraction :"
        '
        'lblPool
        '
        Me.lblPool.AutoSize = True
        Me.lblPool.Location = New System.Drawing.Point(278, 254)
        Me.lblPool.Name = "lblPool"
        Me.lblPool.Size = New System.Drawing.Size(34, 13)
        Me.lblPool.TabIndex = 33
        Me.lblPool.Text = "Pool :"
        '
        'lblReceiverRandomSplit
        '
        Me.lblReceiverRandomSplit.AutoSize = True
        Me.lblReceiverRandomSplit.Location = New System.Drawing.Point(279, 95)
        Me.lblReceiverRandomSplit.Name = "lblReceiverRandomSplit"
        Me.lblReceiverRandomSplit.Size = New System.Drawing.Size(56, 13)
        Me.lblReceiverRandomSplit.TabIndex = 35
        Me.lblReceiverRandomSplit.Text = "Variables :"
        '
        'ucrReceiverRandomSplit
        '
        Me.ucrReceiverRandomSplit.AutoSize = True
        Me.ucrReceiverRandomSplit.frmParent = Me
        Me.ucrReceiverRandomSplit.Location = New System.Drawing.Point(281, 112)
        Me.ucrReceiverRandomSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRandomSplit.Name = "ucrReceiverRandomSplit"
        Me.ucrReceiverRandomSplit.Selector = Nothing
        Me.ucrReceiverRandomSplit.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverRandomSplit.strNcFilePath = ""
        Me.ucrReceiverRandomSplit.TabIndex = 34
        Me.ucrReceiverRandomSplit.ucrSelector = Nothing
        '
        'ucrNudPool
        '
        Me.ucrNudPool.AutoSize = True
        Me.ucrNudPool.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPool.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPool.Location = New System.Drawing.Point(351, 254)
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
        Me.ucrNudFraction.Location = New System.Drawing.Point(351, 223)
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
        Me.ucrNudLag.Location = New System.Drawing.Point(92, 230)
        Me.ucrNudLag.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLag.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLag.Name = "ucrNudLag"
        Me.ucrNudLag.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLag.TabIndex = 29
        Me.ucrNudLag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveRandomSplit
        '
        Me.ucrSaveRandomSplit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveRandomSplit.Location = New System.Drawing.Point(9, 312)
        Me.ucrSaveRandomSplit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveRandomSplit.Name = "ucrSaveRandomSplit"
        Me.ucrSaveRandomSplit.Size = New System.Drawing.Size(403, 34)
        Me.ucrSaveRandomSplit.TabIndex = 28
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 354)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 27
        '
        'ucrChkLag
        '
        Me.ucrChkLag.AutoSize = True
        Me.ucrChkLag.Checked = False
        Me.ucrChkLag.Location = New System.Drawing.Point(9, 230)
        Me.ucrChkLag.Name = "ucrChkLag"
        Me.ucrChkLag.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkLag.TabIndex = 25
        '
        'ucrChkTrainingData
        '
        Me.ucrChkTrainingData.AutoSize = True
        Me.ucrChkTrainingData.Checked = False
        Me.ucrChkTrainingData.Location = New System.Drawing.Point(9, 259)
        Me.ucrChkTrainingData.Name = "ucrChkTrainingData"
        Me.ucrChkTrainingData.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkTrainingData.TabIndex = 24
        '
        'ucrChkTestingData
        '
        Me.ucrChkTestingData.AutoSize = True
        Me.ucrChkTestingData.Checked = False
        Me.ucrChkTestingData.Location = New System.Drawing.Point(9, 288)
        Me.ucrChkTestingData.Name = "ucrChkTestingData"
        Me.ucrChkTestingData.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkTestingData.TabIndex = 23
        '
        'ucrSelectorRandomSplit
        '
        Me.ucrSelectorRandomSplit.AutoSize = True
        Me.ucrSelectorRandomSplit.bDropUnusedFilterLevels = False
        Me.ucrSelectorRandomSplit.bUseCurrentFilter = True
        Me.ucrSelectorRandomSplit.Location = New System.Drawing.Point(9, 75)
        Me.ucrSelectorRandomSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRandomSplit.Name = "ucrSelectorRandomSplit"
        Me.ucrSelectorRandomSplit.Size = New System.Drawing.Size(153, 43)
        Me.ucrSelectorRandomSplit.TabIndex = 22
        '
        'ucrChkStratifyingFactor
        '
        Me.ucrChkStratifyingFactor.AutoSize = True
        Me.ucrChkStratifyingFactor.Checked = False
        Me.ucrChkStratifyingFactor.Location = New System.Drawing.Point(281, 69)
        Me.ucrChkStratifyingFactor.Name = "ucrChkStratifyingFactor"
        Me.ucrChkStratifyingFactor.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkStratifyingFactor.TabIndex = 19
        '
        'ucrPnlRandomSplit
        '
        Me.ucrPnlRandomSplit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRandomSplit.Location = New System.Drawing.Point(92, 12)
        Me.ucrPnlRandomSplit.Name = "ucrPnlRandomSplit"
        Me.ucrPnlRandomSplit.Size = New System.Drawing.Size(212, 44)
        Me.ucrPnlRandomSplit.TabIndex = 26
        '
        'ucrNudBreaks
        '
        Me.ucrNudBreaks.AutoSize = True
        Me.ucrNudBreaks.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBreaks.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBreaks.Location = New System.Drawing.Point(351, 287)
        Me.ucrNudBreaks.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBreaks.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBreaks.Name = "ucrNudBreaks"
        Me.ucrNudBreaks.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBreaks.TabIndex = 36
        Me.ucrNudBreaks.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBreaks
        '
        Me.lblBreaks.AutoSize = True
        Me.lblBreaks.Location = New System.Drawing.Point(279, 287)
        Me.lblBreaks.Name = "lblBreaks"
        Me.lblBreaks.Size = New System.Drawing.Size(46, 13)
        Me.lblBreaks.TabIndex = 37
        Me.lblBreaks.Text = "Breaks :"
        '
        'ucrSelector
        '
        Me.ucrSelector.AutoSize = True
        Me.ucrSelector.bDropUnusedFilterLevels = False
        Me.ucrSelector.bShowHiddenColumns = False
        Me.ucrSelector.bUseCurrentFilter = True
        Me.ucrSelector.Location = New System.Drawing.Point(9, 73)
        Me.ucrSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelector.Name = "ucrSelector"
        Me.ucrSelector.Size = New System.Drawing.Size(151, 180)
        Me.ucrSelector.TabIndex = 38
        '
        'dlgRandomSplit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 418)
        Me.Controls.Add(Me.ucrSelector)
        Me.Controls.Add(Me.lblBreaks)
        Me.Controls.Add(Me.ucrNudBreaks)
        Me.Controls.Add(Me.lblReceiverRandomSplit)
        Me.Controls.Add(Me.ucrReceiverRandomSplit)
        Me.Controls.Add(Me.lblPool)
        Me.Controls.Add(Me.lblFraction)
        Me.Controls.Add(Me.ucrNudPool)
        Me.Controls.Add(Me.ucrNudFraction)
        Me.Controls.Add(Me.ucrNudLag)
        Me.Controls.Add(Me.ucrSaveRandomSplit)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrChkLag)
        Me.Controls.Add(Me.ucrChkTrainingData)
        Me.Controls.Add(Me.ucrChkTestingData)
        Me.Controls.Add(Me.ucrSelectorRandomSplit)
        Me.Controls.Add(Me.rdoSample)
        Me.Controls.Add(Me.rdoTimeSeries)
        Me.Controls.Add(Me.ucrChkStratifyingFactor)
        Me.Controls.Add(Me.ucrPnlRandomSplit)
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
    Friend WithEvents ucrSelectorRandomSplit As ucrDataFrame
    Friend WithEvents ucrChkLag As ucrCheck
    Friend WithEvents ucrChkTrainingData As ucrCheck
    Friend WithEvents ucrChkTestingData As ucrCheck
    Friend WithEvents ucrNudPool As ucrNud
    Friend WithEvents ucrNudFraction As ucrNud
    Friend WithEvents ucrNudLag As ucrNud
    Friend WithEvents ucrSaveRandomSplit As ucrSave
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlRandomSplit As UcrPanel
    Friend WithEvents lblPool As Label
    Friend WithEvents lblFraction As Label
    Friend WithEvents ucrReceiverRandomSplit As ucrReceiverMultiple
    Friend WithEvents lblReceiverRandomSplit As Label
    Friend WithEvents lblBreaks As Label
    Friend WithEvents ucrNudBreaks As ucrNud
    Friend WithEvents ucrSelector As ucrSelectorByDataFrame
End Class
