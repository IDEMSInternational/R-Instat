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
        Me.rdoSample.Location = New System.Drawing.Point(166, 23)
        Me.rdoSample.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoSample.Name = "rdoSample"
        Me.rdoSample.Size = New System.Drawing.Size(150, 43)
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
        Me.rdoTimeSeries.Location = New System.Drawing.Point(314, 23)
        Me.rdoTimeSeries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoTimeSeries.Name = "rdoTimeSeries"
        Me.rdoTimeSeries.Size = New System.Drawing.Size(150, 43)
        Me.rdoTimeSeries.TabIndex = 2
        Me.rdoTimeSeries.Text = "Time Series"
        Me.rdoTimeSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTimeSeries.UseVisualStyleBackColor = True
        '
        'lblFraction
        '
        Me.lblFraction.AutoSize = True
        Me.lblFraction.Location = New System.Drawing.Point(422, 207)
        Me.lblFraction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraction.Name = "lblFraction"
        Me.lblFraction.Size = New System.Drawing.Size(71, 20)
        Me.lblFraction.TabIndex = 6
        Me.lblFraction.Text = "Fraction:"
        '
        'lblPool
        '
        Me.lblPool.AutoSize = True
        Me.lblPool.Location = New System.Drawing.Point(281, 197)
        Me.lblPool.Name = "lblPool"
        Me.lblPool.Size = New System.Drawing.Size(31, 13)
        Me.lblPool.TabIndex = 10
        Me.lblPool.Text = "Pool:"
        '
        'lblBreaks
        '
        Me.lblBreaks.AutoSize = True
        Me.lblBreaks.Location = New System.Drawing.Point(281, 169)
        Me.lblBreaks.Name = "lblBreaks"
        Me.lblBreaks.Size = New System.Drawing.Size(46, 13)
        Me.lblBreaks.TabIndex = 8
        Me.lblBreaks.Text = "Breaks :"
        '
        'ucrNudBreaks
        '
        Me.ucrNudBreaks.AutoSize = True
        Me.ucrNudBreaks.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBreaks.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBreaks.Location = New System.Drawing.Point(526, 249)
        Me.ucrNudBreaks.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudBreaks.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBreaks.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBreaks.Name = "ucrNudBreaks"
        Me.ucrNudBreaks.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudBreaks.TabIndex = 9
        Me.ucrNudBreaks.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPool
        '
        Me.ucrNudPool.AutoSize = True
        Me.ucrNudPool.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPool.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPool.Location = New System.Drawing.Point(526, 292)
        Me.ucrNudPool.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudPool.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPool.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPool.Name = "ucrNudPool"
        Me.ucrNudPool.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudPool.TabIndex = 11
        Me.ucrNudPool.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFraction
        '
        Me.ucrNudFraction.AutoSize = True
        Me.ucrNudFraction.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFraction.Location = New System.Drawing.Point(527, 203)
        Me.ucrNudFraction.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudFraction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFraction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Name = "ucrNudFraction"
        Me.ucrNudFraction.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudFraction.TabIndex = 7
        Me.ucrNudFraction.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLag
        '
        Me.ucrNudLag.AutoSize = True
        Me.ucrNudLag.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLag.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLag.Location = New System.Drawing.Point(157, 368)
        Me.ucrNudLag.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudLag.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLag.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLag.Name = "ucrNudLag"
        Me.ucrNudLag.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudLag.TabIndex = 13
        Me.ucrNudLag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 511)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 16
        '
        'ucrChkLag
        '
        Me.ucrChkLag.AutoSize = True
        Me.ucrChkLag.Checked = False
        Me.ucrChkLag.Location = New System.Drawing.Point(14, 368)
        Me.ucrChkLag.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkLag.Name = "ucrChkLag"
        Me.ucrChkLag.Size = New System.Drawing.Size(214, 35)
        Me.ucrChkLag.TabIndex = 12
        '
        'ucrPnlRandomSplit
        '
        Me.ucrPnlRandomSplit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRandomSplit.Location = New System.Drawing.Point(158, 11)
        Me.ucrPnlRandomSplit.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlRandomSplit.Name = "ucrPnlRandomSplit"
        Me.ucrPnlRandomSplit.Size = New System.Drawing.Size(318, 68)
        Me.ucrPnlRandomSplit.TabIndex = 0
        '
        'ucrSelectorRandomSplit
        '
        Me.ucrSelectorRandomSplit.AutoSize = True
        Me.ucrSelectorRandomSplit.bDropUnusedFilterLevels = False
        Me.ucrSelectorRandomSplit.bShowHiddenColumns = False
        Me.ucrSelectorRandomSplit.bUseCurrentFilter = True
        Me.ucrSelectorRandomSplit.Location = New System.Drawing.Point(14, 82)
        Me.ucrSelectorRandomSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRandomSplit.Name = "ucrSelectorRandomSplit"
        Me.ucrSelectorRandomSplit.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorRandomSplit.TabIndex = 3
        '
        'ucrReceiverRanSplit
        '
        Me.ucrReceiverRanSplit.AutoSize = True
        Me.ucrReceiverRanSplit.frmParent = Me
        Me.ucrReceiverRanSplit.Location = New System.Drawing.Point(422, 157)
        Me.ucrReceiverRanSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRanSplit.Name = "ucrReceiverRanSplit"
        Me.ucrReceiverRanSplit.Selector = Nothing
        Me.ucrReceiverRanSplit.Size = New System.Drawing.Size(180, 32)
        Me.ucrReceiverRanSplit.strNcFilePath = ""
        Me.ucrReceiverRanSplit.TabIndex = 5
        Me.ucrReceiverRanSplit.ucrSelector = Nothing
        '
        'ucrSaveTrainingData
        '
        Me.ucrSaveTrainingData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTrainingData.Location = New System.Drawing.Point(14, 462)
        Me.ucrSaveTrainingData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveTrainingData.Name = "ucrSaveTrainingData"
        Me.ucrSaveTrainingData.Size = New System.Drawing.Size(450, 35)
        Me.ucrSaveTrainingData.TabIndex = 15
        '
        'ucrSaveTestingData
        '
        Me.ucrSaveTestingData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTestingData.Location = New System.Drawing.Point(14, 416)
        Me.ucrSaveTestingData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveTestingData.Name = "ucrSaveTestingData"
        Me.ucrSaveTestingData.Size = New System.Drawing.Size(450, 35)
        Me.ucrSaveTestingData.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Stratifying Variable (optional):"
        '
        'ucrChkbreaks
        '
        Me.ucrChkbreaks.AutoSize = True
        Me.ucrChkbreaks.Checked = False
        Me.ucrChkbreaks.Location = New System.Drawing.Point(264, 165)
        Me.ucrChkbreaks.Name = "ucrChkbreaks"
        Me.ucrChkbreaks.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkbreaks.TabIndex = 18
        '
        'ucrChkPool
        '
        Me.ucrChkPool.AutoSize = True
        Me.ucrChkPool.Checked = False
        Me.ucrChkPool.Location = New System.Drawing.Point(265, 197)
        Me.ucrChkPool.Name = "ucrChkPool"
        Me.ucrChkPool.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkPool.TabIndex = 19
        '
        'dlgRandomSplit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 598)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
