<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPolarAnnulus
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
        Me.lblMultiplePollutant = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblStatistic = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblPercentile = New System.Windows.Forms.Label()
        Me.lblSinglePollutant = New System.Windows.Forms.Label()
        Me.ucrReceiverSinglePollutant = New instat.ucrReceiverSingle()
        Me.ucrChkMultiplePollutants = New instat.ucrCheck()
        Me.ucrChkNormalize = New instat.ucrCheck()
        Me.ucrNudPercentile = New instat.ucrNud()
        Me.ucrReceiverMultiplePollutant = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrChckPadDate = New instat.ucrCheck()
        Me.ucrChckExcludeMissing = New instat.ucrCheck()
        Me.ucrInputStatistic = New instat.ucrInputComboBox()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrInputKeyPosition = New instat.ucrInputComboBox()
        Me.ucrSelectorPolarAnnulus = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblMultiplePollutant
        '
        Me.lblMultiplePollutant.AutoSize = True
        Me.lblMultiplePollutant.Location = New System.Drawing.Point(262, 112)
        Me.lblMultiplePollutant.Name = "lblMultiplePollutant"
        Me.lblMultiplePollutant.Size = New System.Drawing.Size(51, 13)
        Me.lblMultiplePollutant.TabIndex = 2
        Me.lblMultiplePollutant.Text = "Pollutant:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(12, 236)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(36, 13)
        Me.lblColor.TabIndex = 9
        Me.lblColor.Text = "Collor:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(12, 262)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 11
        Me.lblType.Text = "Type:"
        '
        'lblStatistic
        '
        Me.lblStatistic.AutoSize = True
        Me.lblStatistic.Location = New System.Drawing.Point(12, 287)
        Me.lblStatistic.Name = "lblStatistic"
        Me.lblStatistic.Size = New System.Drawing.Size(47, 13)
        Me.lblStatistic.TabIndex = 13
        Me.lblStatistic.Text = "Statistic:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Key Position:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(261, 36)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 6
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(262, 69)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(33, 13)
        Me.lbldate.TabIndex = 7
        Me.lbldate.Text = "Date:"
        '
        'lblPercentile
        '
        Me.lblPercentile.AutoSize = True
        Me.lblPercentile.Location = New System.Drawing.Point(11, 313)
        Me.lblPercentile.Name = "lblPercentile"
        Me.lblPercentile.Size = New System.Drawing.Size(57, 13)
        Me.lblPercentile.TabIndex = 15
        Me.lblPercentile.Text = "Percentile:"
        '
        'lblSinglePollutant
        '
        Me.lblSinglePollutant.AutoSize = True
        Me.lblSinglePollutant.Location = New System.Drawing.Point(262, 112)
        Me.lblSinglePollutant.Name = "lblSinglePollutant"
        Me.lblSinglePollutant.Size = New System.Drawing.Size(51, 13)
        Me.lblSinglePollutant.TabIndex = 5
        Me.lblSinglePollutant.Text = "Pollutant:"
        '
        'ucrReceiverSinglePollutant
        '
        Me.ucrReceiverSinglePollutant.frmParent = Me
        Me.ucrReceiverSinglePollutant.Location = New System.Drawing.Point(265, 125)
        Me.ucrReceiverSinglePollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSinglePollutant.Name = "ucrReceiverSinglePollutant"
        Me.ucrReceiverSinglePollutant.Selector = Nothing
        Me.ucrReceiverSinglePollutant.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSinglePollutant.strNcFilePath = ""
        Me.ucrReceiverSinglePollutant.TabIndex = 1
        Me.ucrReceiverSinglePollutant.ucrSelector = Nothing
        '
        'ucrChkMultiplePollutants
        '
        Me.ucrChkMultiplePollutants.Checked = False
        Me.ucrChkMultiplePollutants.Location = New System.Drawing.Point(15, 204)
        Me.ucrChkMultiplePollutants.Name = "ucrChkMultiplePollutants"
        Me.ucrChkMultiplePollutants.Size = New System.Drawing.Size(209, 20)
        Me.ucrChkMultiplePollutants.TabIndex = 8
        '
        'ucrChkNormalize
        '
        Me.ucrChkNormalize.Checked = False
        Me.ucrChkNormalize.Location = New System.Drawing.Point(230, 235)
        Me.ucrChkNormalize.Name = "ucrChkNormalize"
        Me.ucrChkNormalize.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkNormalize.TabIndex = 17
        '
        'ucrNudPercentile
        '
        Me.ucrNudPercentile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPercentile.Location = New System.Drawing.Point(100, 309)
        Me.ucrNudPercentile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPercentile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentile.Name = "ucrNudPercentile"
        Me.ucrNudPercentile.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPercentile.TabIndex = 16
        Me.ucrNudPercentile.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverMultiplePollutant
        '
        Me.ucrReceiverMultiplePollutant.frmParent = Me
        Me.ucrReceiverMultiplePollutant.Location = New System.Drawing.Point(265, 125)
        Me.ucrReceiverMultiplePollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePollutant.Name = "ucrReceiverMultiplePollutant"
        Me.ucrReceiverMultiplePollutant.Selector = Nothing
        Me.ucrReceiverMultiplePollutant.Size = New System.Drawing.Size(120, 95)
        Me.ucrReceiverMultiplePollutant.strNcFilePath = ""
        Me.ucrReceiverMultiplePollutant.TabIndex = 2
        Me.ucrReceiverMultiplePollutant.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(265, 82)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(264, 49)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 3
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrChckPadDate
        '
        Me.ucrChckPadDate.Checked = False
        Me.ucrChckPadDate.Location = New System.Drawing.Point(230, 314)
        Me.ucrChckPadDate.Name = "ucrChckPadDate"
        Me.ucrChckPadDate.Size = New System.Drawing.Size(154, 20)
        Me.ucrChckPadDate.TabIndex = 23
        '
        'ucrChckExcludeMissing
        '
        Me.ucrChckExcludeMissing.Checked = False
        Me.ucrChckExcludeMissing.Location = New System.Drawing.Point(230, 289)
        Me.ucrChckExcludeMissing.Name = "ucrChckExcludeMissing"
        Me.ucrChckExcludeMissing.Size = New System.Drawing.Size(155, 20)
        Me.ucrChckExcludeMissing.TabIndex = 22
        '
        'ucrInputStatistic
        '
        Me.ucrInputStatistic.AddQuotesIfUnrecognised = True
        Me.ucrInputStatistic.GetSetSelectedIndex = -1
        Me.ucrInputStatistic.IsReadOnly = False
        Me.ucrInputStatistic.Location = New System.Drawing.Point(67, 284)
        Me.ucrInputStatistic.Name = "ucrInputStatistic"
        Me.ucrInputStatistic.Size = New System.Drawing.Size(83, 21)
        Me.ucrInputStatistic.TabIndex = 14
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(67, 258)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(83, 21)
        Me.ucrInputType.TabIndex = 12
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(67, 232)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(83, 21)
        Me.ucrInputColor.TabIndex = 10
        '
        'ucrInputKeyPosition
        '
        Me.ucrInputKeyPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputKeyPosition.GetSetSelectedIndex = -1
        Me.ucrInputKeyPosition.IsReadOnly = False
        Me.ucrInputKeyPosition.Location = New System.Drawing.Point(301, 258)
        Me.ucrInputKeyPosition.Name = "ucrInputKeyPosition"
        Me.ucrInputKeyPosition.Size = New System.Drawing.Size(68, 21)
        Me.ucrInputKeyPosition.TabIndex = 19
        '
        'ucrSelectorPolarAnnulus
        '
        Me.ucrSelectorPolarAnnulus.bDropUnusedFilterLevels = False
        Me.ucrSelectorPolarAnnulus.bShowHiddenColumns = False
        Me.ucrSelectorPolarAnnulus.bUseCurrentFilter = True
        Me.ucrSelectorPolarAnnulus.Location = New System.Drawing.Point(15, 9)
        Me.ucrSelectorPolarAnnulus.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPolarAnnulus.Name = "ucrSelectorPolarAnnulus"
        Me.ucrSelectorPolarAnnulus.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorPolarAnnulus.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 361)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 24
        '
        'dlgPolarAnnulus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 418)
        Me.Controls.Add(Me.lblSinglePollutant)
        Me.Controls.Add(Me.ucrReceiverSinglePollutant)
        Me.Controls.Add(Me.ucrChkMultiplePollutants)
        Me.Controls.Add(Me.ucrChkNormalize)
        Me.Controls.Add(Me.ucrNudPercentile)
        Me.Controls.Add(Me.lblPercentile)
        Me.Controls.Add(Me.ucrReceiverMultiplePollutant)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.ucrChckPadDate)
        Me.Controls.Add(Me.ucrChckExcludeMissing)
        Me.Controls.Add(Me.ucrInputStatistic)
        Me.Controls.Add(Me.ucrInputType)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.ucrInputKeyPosition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblStatistic)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblMultiplePollutant)
        Me.Controls.Add(Me.ucrSelectorPolarAnnulus)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPolarAnnulus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polar Annulus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPolarAnnulus As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblMultiplePollutant As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblStatistic As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrInputStatistic As ucrInputComboBox
    Friend WithEvents ucrChckPadDate As ucrCheck
    Friend WithEvents ucrChckExcludeMissing As ucrCheck
    Friend WithEvents ucrInputKeyPosition As ucrInputComboBox
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lbldate As Label
    Friend WithEvents ucrReceiverMultiplePollutant As ucrReceiverMultiple
    Friend WithEvents lblPercentile As Label
    Friend WithEvents ucrNudPercentile As ucrNud
    Friend WithEvents ucrChkMultiplePollutants As ucrCheck
    Friend WithEvents ucrChkNormalize As ucrCheck
    Friend WithEvents lblSinglePollutant As Label
    Friend WithEvents ucrReceiverSinglePollutant As ucrReceiverSingle
End Class
