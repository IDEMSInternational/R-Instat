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
        Me.lblStatistic = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblMinimumBins = New System.Windows.Forms.Label()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrNudMinimumBins = New instat.ucrNud()
        Me.ucrInputStatistic = New instat.ucrInputComboBox()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrChkTransform = New instat.ucrCheck()
        Me.ucrChkKeyHeader = New instat.ucrCheck()
        Me.ucrReceiverPollutant = New instat.ucrReceiverSingle()
        Me.ucrSelectorPolarFrequency = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblPollutant
        '
        Me.lblPollutant.AutoSize = True
        Me.lblPollutant.Location = New System.Drawing.Point(281, 24)
        Me.lblPollutant.Name = "lblPollutant"
        Me.lblPollutant.Size = New System.Drawing.Size(51, 13)
        Me.lblPollutant.TabIndex = 2
        Me.lblPollutant.Text = "Pollutant:"
        '
        'lblStatistic
        '
        Me.lblStatistic.AutoSize = True
        Me.lblStatistic.Location = New System.Drawing.Point(12, 233)
        Me.lblStatistic.Name = "lblStatistic"
        Me.lblStatistic.Size = New System.Drawing.Size(47, 13)
        Me.lblStatistic.TabIndex = 3
        Me.lblStatistic.Text = "Statistic:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(307, 258)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 5
        Me.lblPosition.Text = "Position:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(12, 256)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 6
        Me.lblColor.Text = "Color:"
        '
        'lblMinimumBins
        '
        Me.lblMinimumBins.AutoSize = True
        Me.lblMinimumBins.Location = New System.Drawing.Point(234, 216)
        Me.lblMinimumBins.Name = "lblMinimumBins"
        Me.lblMinimumBins.Size = New System.Drawing.Size(74, 13)
        Me.lblMinimumBins.TabIndex = 14
        Me.lblMinimumBins.Text = "Minimum Bins:"
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(94, 208)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputType.TabIndex = 13
        '
        'ucrNudMinimumBins
        '
        Me.ucrNudMinimumBins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimumBins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinimumBins.Location = New System.Drawing.Point(354, 216)
        Me.ucrNudMinimumBins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinimumBins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimumBins.Name = "ucrNudMinimumBins"
        Me.ucrNudMinimumBins.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinimumBins.TabIndex = 12
        Me.ucrNudMinimumBins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputStatistic
        '
        Me.ucrInputStatistic.AddQuotesIfUnrecognised = True
        Me.ucrInputStatistic.GetSetSelectedIndex = -1
        Me.ucrInputStatistic.IsReadOnly = False
        Me.ucrInputStatistic.Location = New System.Drawing.Point(93, 232)
        Me.ucrInputStatistic.Name = "ucrInputStatistic"
        Me.ucrInputStatistic.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputStatistic.TabIndex = 11
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(93, 255)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputColor.TabIndex = 10
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(354, 255)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputPosition.TabIndex = 9
        '
        'ucrChkTransform
        '
        Me.ucrChkTransform.Checked = False
        Me.ucrChkTransform.Location = New System.Drawing.Point(236, 233)
        Me.ucrChkTransform.Name = "ucrChkTransform"
        Me.ucrChkTransform.Size = New System.Drawing.Size(80, 20)
        Me.ucrChkTransform.TabIndex = 8
        '
        'ucrChkKeyHeader
        '
        Me.ucrChkKeyHeader.Checked = False
        Me.ucrChkKeyHeader.Location = New System.Drawing.Point(236, 256)
        Me.ucrChkKeyHeader.Name = "ucrChkKeyHeader"
        Me.ucrChkKeyHeader.Size = New System.Drawing.Size(72, 20)
        Me.ucrChkKeyHeader.TabIndex = 7
        '
        'ucrReceiverPollutant
        '
        Me.ucrReceiverPollutant.frmParent = Me
        Me.ucrReceiverPollutant.Location = New System.Drawing.Point(284, 44)
        Me.ucrReceiverPollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPollutant.Name = "ucrReceiverPollutant"
        Me.ucrReceiverPollutant.Selector = Nothing
        Me.ucrReceiverPollutant.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPollutant.strNcFilePath = ""
        Me.ucrReceiverPollutant.TabIndex = 1
        Me.ucrReceiverPollutant.ucrSelector = Nothing
        '
        'ucrSelectorPolarFrequency
        '
        Me.ucrSelectorPolarFrequency.bDropUnusedFilterLevels = False
        Me.ucrSelectorPolarFrequency.bShowHiddenColumns = False
        Me.ucrSelectorPolarFrequency.bUseCurrentFilter = True
        Me.ucrSelectorPolarFrequency.Location = New System.Drawing.Point(6, 5)
        Me.ucrSelectorPolarFrequency.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPolarFrequency.Name = "ucrSelectorPolarFrequency"
        Me.ucrSelectorPolarFrequency.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorPolarFrequency.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 305)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgPolarFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 370)
        Me.Controls.Add(Me.lblMinimumBins)
        Me.Controls.Add(Me.ucrInputType)
        Me.Controls.Add(Me.ucrNudMinimumBins)
        Me.Controls.Add(Me.ucrInputStatistic)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.ucrInputPosition)
        Me.Controls.Add(Me.ucrChkTransform)
        Me.Controls.Add(Me.ucrChkKeyHeader)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStatistic)
        Me.Controls.Add(Me.lblPollutant)
        Me.Controls.Add(Me.ucrReceiverPollutant)
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
    Friend WithEvents ucrReceiverPollutant As ucrReceiverSingle
    Friend WithEvents lblMinimumBins As Label
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrNudMinimumBins As ucrNud
    Friend WithEvents ucrInputStatistic As ucrInputComboBox
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrChkTransform As ucrCheck
    Friend WithEvents ucrChkKeyHeader As ucrCheck
    Friend WithEvents lblColor As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatistic As Label
    Friend WithEvents lblPollutant As Label
End Class
