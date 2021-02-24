<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWindPollutionRose
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
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblStatistic = New System.Windows.Forms.Label()
        Me.lblKeyPosition = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblWindDirection2 = New System.Windows.Forms.Label()
        Me.lblWindSpeed2 = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblPollutant = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkIncludePollutant = New instat.ucrCheck()
        Me.ucrInputStatistic = New instat.ucrInputComboBox()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrChkPaddle = New instat.ucrCheck()
        Me.ucrChkCompare = New instat.ucrCheck()
        Me.ucrReceiverPollutant = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection2 = New instat.ucrReceiverSingle()
        Me.ucrSelectorWindPollutionRose = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputKeyPosition = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.UcrReceiverStation = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(20, 211)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 17
        Me.lblColor.Text = "Color:"
        '
        'lblStatistic
        '
        Me.lblStatistic.AutoSize = True
        Me.lblStatistic.Location = New System.Drawing.Point(20, 242)
        Me.lblStatistic.Name = "lblStatistic"
        Me.lblStatistic.Size = New System.Drawing.Size(47, 13)
        Me.lblStatistic.TabIndex = 19
        Me.lblStatistic.Text = "Statistic:"
        '
        'lblKeyPosition
        '
        Me.lblKeyPosition.AutoSize = True
        Me.lblKeyPosition.Location = New System.Drawing.Point(14, 271)
        Me.lblKeyPosition.Name = "lblKeyPosition"
        Me.lblKeyPosition.Size = New System.Drawing.Size(64, 13)
        Me.lblKeyPosition.TabIndex = 21
        Me.lblKeyPosition.Text = "Keyposition:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(411, 84)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(85, 13)
        Me.lblType.TabIndex = 16
        Me.lblType.Text = "Facet (Optional):"
        '
        'lblWindDirection2
        '
        Me.lblWindDirection2.AutoSize = True
        Me.lblWindDirection2.Location = New System.Drawing.Point(260, 245)
        Me.lblWindDirection2.Name = "lblWindDirection2"
        Me.lblWindDirection2.Size = New System.Drawing.Size(89, 13)
        Me.lblWindDirection2.TabIndex = 10
        Me.lblWindDirection2.Text = "Wind Direction 2:"
        '
        'lblWindSpeed2
        '
        Me.lblWindSpeed2.AutoSize = True
        Me.lblWindSpeed2.Location = New System.Drawing.Point(260, 202)
        Me.lblWindSpeed2.Name = "lblWindSpeed2"
        Me.lblWindSpeed2.Size = New System.Drawing.Size(78, 13)
        Me.lblWindSpeed2.TabIndex = 8
        Me.lblWindSpeed2.Text = "Wind Speed 2:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(260, 85)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 3
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(260, 39)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 1
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblPollutant
        '
        Me.lblPollutant.AutoSize = True
        Me.lblPollutant.Location = New System.Drawing.Point(260, 313)
        Me.lblPollutant.Name = "lblPollutant"
        Me.lblPollutant.Size = New System.Drawing.Size(51, 13)
        Me.lblPollutant.TabIndex = 13
        Me.lblPollutant.Text = "Pollutant:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(260, 131)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(263, 147)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 6
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(7, 361)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(403, 34)
        Me.ucrSaveGraph.TabIndex = 24
        '
        'ucrChkIncludePollutant
        '
        Me.ucrChkIncludePollutant.Checked = False
        Me.ucrChkIncludePollutant.Location = New System.Drawing.Point(263, 285)
        Me.ucrChkIncludePollutant.Name = "ucrChkIncludePollutant"
        Me.ucrChkIncludePollutant.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkIncludePollutant.TabIndex = 12
        '
        'ucrInputStatistic
        '
        Me.ucrInputStatistic.AddQuotesIfUnrecognised = True
        Me.ucrInputStatistic.GetSetSelectedIndex = -1
        Me.ucrInputStatistic.IsReadOnly = False
        Me.ucrInputStatistic.Location = New System.Drawing.Point(73, 236)
        Me.ucrInputStatistic.Name = "ucrInputStatistic"
        Me.ucrInputStatistic.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputStatistic.TabIndex = 20
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(73, 206)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputColor.TabIndex = 18
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(416, 100)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(136, 21)
        Me.ucrInputType.TabIndex = 15
        '
        'ucrChkPaddle
        '
        Me.ucrChkPaddle.Checked = False
        Me.ucrChkPaddle.Location = New System.Drawing.Point(17, 297)
        Me.ucrChkPaddle.Name = "ucrChkPaddle"
        Me.ucrChkPaddle.Size = New System.Drawing.Size(155, 20)
        Me.ucrChkPaddle.TabIndex = 23
        '
        'ucrChkCompare
        '
        Me.ucrChkCompare.Checked = False
        Me.ucrChkCompare.Location = New System.Drawing.Point(263, 175)
        Me.ucrChkCompare.Name = "ucrChkCompare"
        Me.ucrChkCompare.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkCompare.TabIndex = 7
        '
        'ucrReceiverPollutant
        '
        Me.ucrReceiverPollutant.frmParent = Me
        Me.ucrReceiverPollutant.Location = New System.Drawing.Point(263, 330)
        Me.ucrReceiverPollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPollutant.Name = "ucrReceiverPollutant"
        Me.ucrReceiverPollutant.Selector = Nothing
        Me.ucrReceiverPollutant.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPollutant.strNcFilePath = ""
        Me.ucrReceiverPollutant.TabIndex = 14
        Me.ucrReceiverPollutant.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(263, 56)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 2
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(263, 101)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 4
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed2
        '
        Me.ucrReceiverWindSpeed2.frmParent = Me
        Me.ucrReceiverWindSpeed2.Location = New System.Drawing.Point(263, 218)
        Me.ucrReceiverWindSpeed2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed2.Name = "ucrReceiverWindSpeed2"
        Me.ucrReceiverWindSpeed2.Selector = Nothing
        Me.ucrReceiverWindSpeed2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed2.strNcFilePath = ""
        Me.ucrReceiverWindSpeed2.TabIndex = 9
        Me.ucrReceiverWindSpeed2.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection2
        '
        Me.ucrReceiverWindDirection2.frmParent = Me
        Me.ucrReceiverWindDirection2.Location = New System.Drawing.Point(263, 261)
        Me.ucrReceiverWindDirection2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection2.Name = "ucrReceiverWindDirection2"
        Me.ucrReceiverWindDirection2.Selector = Nothing
        Me.ucrReceiverWindDirection2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection2.strNcFilePath = ""
        Me.ucrReceiverWindDirection2.TabIndex = 11
        Me.ucrReceiverWindDirection2.ucrSelector = Nothing
        '
        'ucrSelectorWindPollutionRose
        '
        Me.ucrSelectorWindPollutionRose.bDropUnusedFilterLevels = False
        Me.ucrSelectorWindPollutionRose.bShowHiddenColumns = False
        Me.ucrSelectorWindPollutionRose.bUseCurrentFilter = True
        Me.ucrSelectorWindPollutionRose.Location = New System.Drawing.Point(18, 12)
        Me.ucrSelectorWindPollutionRose.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorWindPollutionRose.Name = "ucrSelectorWindPollutionRose"
        Me.ucrSelectorWindPollutionRose.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorWindPollutionRose.TabIndex = 0
        '
        'ucrInputKeyPosition
        '
        Me.ucrInputKeyPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputKeyPosition.GetSetSelectedIndex = -1
        Me.ucrInputKeyPosition.IsReadOnly = False
        Me.ucrInputKeyPosition.Location = New System.Drawing.Point(81, 267)
        Me.ucrInputKeyPosition.Name = "ucrInputKeyPosition"
        Me.ucrInputKeyPosition.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputKeyPosition.TabIndex = 22
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(73, 399)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 25
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(411, 38)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 26
        Me.lblStation.Text = "Station:"
        '
        'UcrReceiverStation
        '
        Me.UcrReceiverStation.frmParent = Me
        Me.UcrReceiverStation.Location = New System.Drawing.Point(414, 55)
        Me.UcrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverStation.Name = "UcrReceiverStation"
        Me.UcrReceiverStation.Selector = Nothing
        Me.UcrReceiverStation.Size = New System.Drawing.Size(138, 20)
        Me.UcrReceiverStation.strNcFilePath = ""
        Me.UcrReceiverStation.TabIndex = 27
        Me.UcrReceiverStation.ucrSelector = Nothing
        '
        'dlgWindPollutionRose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 462)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.UcrReceiverStation)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkIncludePollutant)
        Me.Controls.Add(Me.ucrInputStatistic)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.ucrInputType)
        Me.Controls.Add(Me.ucrChkPaddle)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblStatistic)
        Me.Controls.Add(Me.lblKeyPosition)
        Me.Controls.Add(Me.ucrChkCompare)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblWindDirection2)
        Me.Controls.Add(Me.lblWindSpeed2)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.lblWindSpeed)
        Me.Controls.Add(Me.lblPollutant)
        Me.Controls.Add(Me.ucrReceiverPollutant)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrReceiverWindSpeed2)
        Me.Controls.Add(Me.ucrReceiverWindDirection2)
        Me.Controls.Add(Me.ucrSelectorWindPollutionRose)
        Me.Controls.Add(Me.ucrInputKeyPosition)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWindPollutionRose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind/Pollution Rose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputStatistic As ucrInputComboBox
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrChkPaddle As ucrCheck
    Friend WithEvents lblColor As Label
    Friend WithEvents lblStatistic As Label
    Friend WithEvents lblKeyPosition As Label
    Friend WithEvents ucrChkCompare As ucrCheck
    Friend WithEvents lblType As Label
    Friend WithEvents lblWindDirection2 As Label
    Friend WithEvents lblWindSpeed2 As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents lblPollutant As Label
    Friend WithEvents ucrReceiverPollutant As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindSpeed2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection2 As ucrReceiverSingle
    Friend WithEvents ucrSelectorWindPollutionRose As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputKeyPosition As ucrInputComboBox
    Friend WithEvents ucrChkIncludePollutant As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents UcrReceiverStation As ucrReceiverSingle
End Class
