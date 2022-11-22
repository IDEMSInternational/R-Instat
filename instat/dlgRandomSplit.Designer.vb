<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRandomSplit
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
        Me.rdoSample = New System.Windows.Forms.RadioButton()
        Me.rdoTimeSeries = New System.Windows.Forms.RadioButton()
        Me.lblFraction = New System.Windows.Forms.Label()
        Me.ucrNudBreaks = New instat.ucrNud()
        Me.ucrNudPool = New instat.ucrNud()
        Me.ucrNudFraction = New instat.ucrNud()
        Me.ucrNudLag = New instat.ucrNud()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkLag = New instat.ucrCheck()
        Me.ucrPnlRandomSplit = New instat.UcrPanel()
        Me.ucrSelectorRandomSplit = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverRanSplit = New instat.ucrReceiverSingle()
        Me.ucrSaveTrainingData = New instat.ucrSave()
        Me.ucrSaveTestingData = New instat.ucrSave()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrChkbreaks = New instat.ucrCheck()
        Me.ucrChkPool = New instat.ucrCheck()
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
        Me.rdoSample.Location = New System.Drawing.Point(111, 15)
        Me.rdoSample.Name = "rdoSample"
        Me.rdoSample.Size = New System.Drawing.Size(100, 28)
        Me.rdoSample.TabIndex = 1
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
        Me.rdoTimeSeries.Location = New System.Drawing.Point(209, 15)
        Me.rdoTimeSeries.Name = "rdoTimeSeries"
        Me.rdoTimeSeries.Size = New System.Drawing.Size(100, 28)
        Me.rdoTimeSeries.TabIndex = 2
        Me.rdoTimeSeries.Text = "Time Series"
        Me.rdoTimeSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTimeSeries.UseVisualStyleBackColor = True
        '
        'lblFraction
        '
        Me.lblFraction.AutoSize = True
        Me.lblFraction.Location = New System.Drawing.Point(281, 135)
        Me.lblFraction.Name = "lblFraction"
        Me.lblFraction.Size = New System.Drawing.Size(48, 13)
        Me.lblFraction.TabIndex = 6
        Me.lblFraction.Text = "Fraction:"
        '
        'ucrNudBreaks
        '
        Me.ucrNudBreaks.AutoSize = True
        Me.ucrNudBreaks.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBreaks.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBreaks.Location = New System.Drawing.Point(351, 162)
        Me.ucrNudBreaks.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudBreaks.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBreaks.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBreaks.Name = "ucrNudBreaks"
        Me.ucrNudBreaks.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBreaks.TabIndex = 9
        Me.ucrNudBreaks.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPool
        '
        Me.ucrNudPool.AutoSize = True
        Me.ucrNudPool.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPool.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPool.Location = New System.Drawing.Point(351, 190)
        Me.ucrNudPool.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudPool.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPool.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPool.Name = "ucrNudPool"
        Me.ucrNudPool.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPool.TabIndex = 11
        Me.ucrNudPool.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFraction
        '
        Me.ucrNudFraction.AutoSize = True
        Me.ucrNudFraction.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFraction.Location = New System.Drawing.Point(351, 132)
        Me.ucrNudFraction.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudFraction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFraction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Name = "ucrNudFraction"
        Me.ucrNudFraction.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFraction.TabIndex = 7
        Me.ucrNudFraction.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLag
        '
        Me.ucrNudLag.AutoSize = True
        Me.ucrNudLag.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLag.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLag.Location = New System.Drawing.Point(105, 239)
        Me.ucrNudLag.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudLag.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLag.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLag.Name = "ucrNudLag"
        Me.ucrNudLag.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLag.TabIndex = 13
        Me.ucrNudLag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 332)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 16
        '
        'ucrChkLag
        '
        Me.ucrChkLag.AutoSize = True
        Me.ucrChkLag.Checked = False
        Me.ucrChkLag.Location = New System.Drawing.Point(9, 239)
        Me.ucrChkLag.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkLag.Name = "ucrChkLag"
        Me.ucrChkLag.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkLag.TabIndex = 12
        '
        'ucrPnlRandomSplit
        '
        Me.ucrPnlRandomSplit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRandomSplit.Location = New System.Drawing.Point(105, 7)
        Me.ucrPnlRandomSplit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlRandomSplit.Name = "ucrPnlRandomSplit"
        Me.ucrPnlRandomSplit.Size = New System.Drawing.Size(212, 44)
        Me.ucrPnlRandomSplit.TabIndex = 0
        '
        'ucrSelectorRandomSplit
        '
        Me.ucrSelectorRandomSplit.AutoSize = True
        Me.ucrSelectorRandomSplit.bDropUnusedFilterLevels = False
        Me.ucrSelectorRandomSplit.bShowHiddenColumns = False
        Me.ucrSelectorRandomSplit.bUseCurrentFilter = True
        Me.ucrSelectorRandomSplit.Location = New System.Drawing.Point(9, 53)
        Me.ucrSelectorRandomSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRandomSplit.Name = "ucrSelectorRandomSplit"
        Me.ucrSelectorRandomSplit.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorRandomSplit.TabIndex = 3
        '
        'ucrReceiverRanSplit
        '
        Me.ucrReceiverRanSplit.AutoSize = True
        Me.ucrReceiverRanSplit.frmParent = Me
        Me.ucrReceiverRanSplit.Location = New System.Drawing.Point(281, 102)
        Me.ucrReceiverRanSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRanSplit.Name = "ucrReceiverRanSplit"
        Me.ucrReceiverRanSplit.Selector = Nothing
        Me.ucrReceiverRanSplit.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverRanSplit.strNcFilePath = ""
        Me.ucrReceiverRanSplit.TabIndex = 5
        Me.ucrReceiverRanSplit.ucrSelector = Nothing
        '
        'ucrSaveTrainingData
        '
        Me.ucrSaveTrainingData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTrainingData.Location = New System.Drawing.Point(9, 300)
        Me.ucrSaveTrainingData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTrainingData.Name = "ucrSaveTrainingData"
        Me.ucrSaveTrainingData.Size = New System.Drawing.Size(300, 23)
        Me.ucrSaveTrainingData.TabIndex = 15
        '
        'ucrSaveTestingData
        '
        Me.ucrSaveTestingData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTestingData.Location = New System.Drawing.Point(9, 270)
        Me.ucrSaveTestingData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTestingData.Name = "ucrSaveTestingData"
        Me.ucrSaveTestingData.Size = New System.Drawing.Size(300, 23)
        Me.ucrSaveTestingData.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(279, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Stratifying Variable (optional):"
        '
        'ucrChkbreaks
        '
        Me.ucrChkbreaks.AutoSize = True
        Me.ucrChkbreaks.Checked = False
        Me.ucrChkbreaks.Location = New System.Drawing.Point(264, 159)
        Me.ucrChkbreaks.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ucrChkbreaks.Name = "ucrChkbreaks"
        Me.ucrChkbreaks.Size = New System.Drawing.Size(130, 23)
        Me.ucrChkbreaks.TabIndex = 18
        '
        'ucrChkPool
        '
        Me.ucrChkPool.AutoSize = True
        Me.ucrChkPool.Checked = False
        Me.ucrChkPool.Location = New System.Drawing.Point(264, 190)
        Me.ucrChkPool.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ucrChkPool.Name = "ucrChkPool"
        Me.ucrChkPool.Size = New System.Drawing.Size(130, 23)
        Me.ucrChkPool.TabIndex = 19
        '
        'dlgRandomSplit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 389)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrSaveTestingData)
        Me.Controls.Add(Me.ucrReceiverRanSplit)
        Me.Controls.Add(Me.ucrNudBreaks)
        Me.Controls.Add(Me.lblFraction)
        Me.Controls.Add(Me.ucrNudPool)
        Me.Controls.Add(Me.ucrNudFraction)
        Me.Controls.Add(Me.ucrNudLag)
        Me.Controls.Add(Me.ucrSaveTrainingData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrChkLag)
        Me.Controls.Add(Me.rdoSample)
        Me.Controls.Add(Me.rdoTimeSeries)
        Me.Controls.Add(Me.ucrPnlRandomSplit)
        Me.Controls.Add(Me.ucrSelectorRandomSplit)
        Me.Controls.Add(Me.ucrChkPool)
        Me.Controls.Add(Me.ucrChkbreaks)
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
    Friend WithEvents ucrChkLag As ucrCheck
    Friend WithEvents ucrNudPool As ucrNud
    Friend WithEvents ucrNudFraction As ucrNud
    Friend WithEvents ucrNudLag As ucrNud
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlRandomSplit As UcrPanel
    Friend WithEvents lblFraction As Label
    Friend WithEvents ucrNudBreaks As ucrNud
    Friend WithEvents ucrSelectorRandomSplit As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRanSplit As ucrReceiverSingle
    Friend WithEvents ucrSaveTrainingData As ucrSave
    Friend WithEvents ucrSaveTestingData As ucrSave
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrChkPool As ucrCheck
    Friend WithEvents ucrChkbreaks As ucrCheck
End Class
