<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPolarFrequency
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
        Me.lblPollutant = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrChkTransform = New instat.ucrCheck()
        Me.ucrNudMinimumBins = New instat.ucrNud()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrInputStatistic = New instat.ucrInputComboBox()
        Me.ucrReceiverPollutant = New instat.ucrReceiverSingle()
        Me.ucrSelectorPolarFrequency = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblPollutant
        '
        Me.lblPollutant.AutoSize = True
        Me.lblPollutant.Location = New System.Drawing.Point(280, 45)
        Me.lblPollutant.Name = "lblPollutant"
        Me.lblPollutant.Size = New System.Drawing.Size(48, 13)
        Me.lblPollutant.TabIndex = 1
        Me.lblPollutant.Text = "Pollutant"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(13, 205)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 7
        Me.lblColor.Text = "Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Key Position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Minimum Bins:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Statistic:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(283, 135)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 5
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(284, 88)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 3
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(283, 103)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 4
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(283, 150)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 6
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrChkTransform
        '
        Me.ucrChkTransform.Checked = False
        Me.ucrChkTransform.Location = New System.Drawing.Point(14, 257)
        Me.ucrChkTransform.Name = "ucrChkTransform"
        Me.ucrChkTransform.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkTransform.TabIndex = 11
        '
        'ucrNudMinimumBins
        '
        Me.ucrNudMinimumBins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimumBins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinimumBins.Location = New System.Drawing.Point(348, 257)
        Me.ucrNudMinimumBins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinimumBins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimumBins.Name = "ucrNudMinimumBins"
        Me.ucrNudMinimumBins.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinimumBins.TabIndex = 17
        Me.ucrNudMinimumBins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(94, 201)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(68, 21)
        Me.ucrInputColor.TabIndex = 8
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(94, 228)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(68, 21)
        Me.ucrInputPosition.TabIndex = 10
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(324, 202)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputType.TabIndex = 13
        '
        'ucrInputStatistic
        '
        Me.ucrInputStatistic.AddQuotesIfUnrecognised = True
        Me.ucrInputStatistic.GetSetSelectedIndex = -1
        Me.ucrInputStatistic.IsReadOnly = False
        Me.ucrInputStatistic.Location = New System.Drawing.Point(324, 229)
        Me.ucrInputStatistic.Name = "ucrInputStatistic"
        Me.ucrInputStatistic.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputStatistic.TabIndex = 15
        '
        'ucrReceiverPollutant
        '
        Me.ucrReceiverPollutant.frmParent = Me
        Me.ucrReceiverPollutant.Location = New System.Drawing.Point(283, 60)
        Me.ucrReceiverPollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPollutant.Name = "ucrReceiverPollutant"
        Me.ucrReceiverPollutant.Selector = Nothing
        Me.ucrReceiverPollutant.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPollutant.strNcFilePath = ""
        Me.ucrReceiverPollutant.TabIndex = 2
        Me.ucrReceiverPollutant.ucrSelector = Nothing
        '
        'ucrSelectorPolarFrequency
        '
        Me.ucrSelectorPolarFrequency.bDropUnusedFilterLevels = False
        Me.ucrSelectorPolarFrequency.bShowHiddenColumns = False
        Me.ucrSelectorPolarFrequency.bUseCurrentFilter = True
        Me.ucrSelectorPolarFrequency.Location = New System.Drawing.Point(14, 1)
        Me.ucrSelectorPolarFrequency.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPolarFrequency.Name = "ucrSelectorPolarFrequency"
        Me.ucrSelectorPolarFrequency.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorPolarFrequency.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 329)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 18
        '
        'dlgPolarFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 396)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.lblWindSpeed)
        Me.Controls.Add(Me.ucrChkTransform)
        Me.Controls.Add(Me.ucrNudMinimumBins)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.ucrInputPosition)
        Me.Controls.Add(Me.ucrInputType)
        Me.Controls.Add(Me.ucrInputStatistic)
        Me.Controls.Add(Me.ucrReceiverPollutant)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblPollutant)
        Me.Controls.Add(Me.ucrSelectorPolarFrequency)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPolarFrequency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polar Frequency"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPolarFrequency As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblPollutant As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ucrReceiverPollutant As ucrReceiverSingle
    Friend WithEvents ucrChkTransform As ucrCheck
    Friend WithEvents ucrNudMinimumBins As ucrNud
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrInputStatistic As ucrInputComboBox
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblWindSpeed As Label
End Class
