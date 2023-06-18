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
        Me.lblFacetTwo = New System.Windows.Forms.Label()
        Me.lblFacetOne = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblStatistic = New System.Windows.Forms.Label()
        Me.lblWindDirection2 = New System.Windows.Forms.Label()
        Me.lblWindSpeed2 = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblPollutant = New System.Windows.Forms.Label()
        Me.ucrChkCompareTwoSets = New instat.ucrCheck()
        Me.ucrReceiverFacetOne = New instat.ucrReceiverSingle()
        Me.ucrReceiverFacetTwo = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputStatistic = New instat.ucrInputComboBox()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrChkPaddle = New instat.ucrCheck()
        Me.ucrReceiverPollutant = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection2 = New instat.ucrReceiverSingle()
        Me.ucrSelectorWindPollutionRose = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFacetTwo
        '
        Me.lblFacetTwo.AutoSize = True
        Me.lblFacetTwo.Location = New System.Drawing.Point(398, 76)
        Me.lblFacetTwo.Name = "lblFacetTwo"
        Me.lblFacetTwo.Size = New System.Drawing.Size(94, 13)
        Me.lblFacetTwo.TabIndex = 16
        Me.lblFacetTwo.Text = "Facet 2 (Optional):"
        '
        'lblFacetOne
        '
        Me.lblFacetOne.AutoSize = True
        Me.lblFacetOne.Location = New System.Drawing.Point(398, 30)
        Me.lblFacetOne.Name = "lblFacetOne"
        Me.lblFacetOne.Size = New System.Drawing.Size(85, 13)
        Me.lblFacetOne.TabIndex = 14
        Me.lblFacetOne.Text = "Facet (Optional):"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(257, 14)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(10, 215)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 18
        Me.lblColor.Text = "Color:"
        '
        'lblStatistic
        '
        Me.lblStatistic.AutoSize = True
        Me.lblStatistic.Location = New System.Drawing.Point(10, 244)
        Me.lblStatistic.Name = "lblStatistic"
        Me.lblStatistic.Size = New System.Drawing.Size(47, 13)
        Me.lblStatistic.TabIndex = 20
        Me.lblStatistic.Text = "Statistic:"
        '
        'lblWindDirection2
        '
        Me.lblWindDirection2.AutoSize = True
        Me.lblWindDirection2.Location = New System.Drawing.Point(257, 275)
        Me.lblWindDirection2.Name = "lblWindDirection2"
        Me.lblWindDirection2.Size = New System.Drawing.Size(89, 13)
        Me.lblWindDirection2.TabIndex = 12
        Me.lblWindDirection2.Text = "Wind Direction 2:"
        '
        'lblWindSpeed2
        '
        Me.lblWindSpeed2.AutoSize = True
        Me.lblWindSpeed2.Location = New System.Drawing.Point(257, 232)
        Me.lblWindSpeed2.Name = "lblWindSpeed2"
        Me.lblWindSpeed2.Size = New System.Drawing.Size(78, 13)
        Me.lblWindSpeed2.TabIndex = 10
        Me.lblWindSpeed2.Text = "Wind Speed 2:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(257, 104)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 5
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(257, 58)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 3
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblPollutant
        '
        Me.lblPollutant.AutoSize = True
        Me.lblPollutant.Location = New System.Drawing.Point(257, 153)
        Me.lblPollutant.Name = "lblPollutant"
        Me.lblPollutant.Size = New System.Drawing.Size(99, 13)
        Me.lblPollutant.TabIndex = 7
        Me.lblPollutant.Text = "Pollutant (Optional):"
        '
        'ucrChkCompareTwoSets
        '
        Me.ucrChkCompareTwoSets.AutoSize = True
        Me.ucrChkCompareTwoSets.Checked = False
        Me.ucrChkCompareTwoSets.Location = New System.Drawing.Point(257, 207)
        Me.ucrChkCompareTwoSets.Name = "ucrChkCompareTwoSets"
        Me.ucrChkCompareTwoSets.Size = New System.Drawing.Size(155, 23)
        Me.ucrChkCompareTwoSets.TabIndex = 9
        '
        'ucrReceiverFacetOne
        '
        Me.ucrReceiverFacetOne.AutoSize = True
        Me.ucrReceiverFacetOne.frmParent = Me
        Me.ucrReceiverFacetOne.Location = New System.Drawing.Point(398, 47)
        Me.ucrReceiverFacetOne.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetOne.Name = "ucrReceiverFacetOne"
        Me.ucrReceiverFacetOne.Selector = Nothing
        Me.ucrReceiverFacetOne.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFacetOne.strNcFilePath = ""
        Me.ucrReceiverFacetOne.TabIndex = 15
        Me.ucrReceiverFacetOne.ucrSelector = Nothing
        '
        'ucrReceiverFacetTwo
        '
        Me.ucrReceiverFacetTwo.AutoSize = True
        Me.ucrReceiverFacetTwo.frmParent = Me
        Me.ucrReceiverFacetTwo.Location = New System.Drawing.Point(398, 92)
        Me.ucrReceiverFacetTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetTwo.Name = "ucrReceiverFacetTwo"
        Me.ucrReceiverFacetTwo.Selector = Nothing
        Me.ucrReceiverFacetTwo.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFacetTwo.strNcFilePath = ""
        Me.ucrReceiverFacetTwo.TabIndex = 17
        Me.ucrReceiverFacetTwo.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(257, 30)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 2
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 315)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(341, 34)
        Me.ucrSaveGraph.TabIndex = 23
        '
        'ucrInputStatistic
        '
        Me.ucrInputStatistic.AddQuotesIfUnrecognised = True
        Me.ucrInputStatistic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStatistic.GetSetSelectedIndex = -1
        Me.ucrInputStatistic.IsReadOnly = False
        Me.ucrInputStatistic.Location = New System.Drawing.Point(71, 240)
        Me.ucrInputStatistic.Name = "ucrInputStatistic"
        Me.ucrInputStatistic.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputStatistic.TabIndex = 21
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(70, 211)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputColor.TabIndex = 19
        '
        'ucrChkPaddle
        '
        Me.ucrChkPaddle.AutoSize = True
        Me.ucrChkPaddle.Checked = False
        Me.ucrChkPaddle.Location = New System.Drawing.Point(10, 282)
        Me.ucrChkPaddle.Name = "ucrChkPaddle"
        Me.ucrChkPaddle.Size = New System.Drawing.Size(155, 23)
        Me.ucrChkPaddle.TabIndex = 22
        '
        'ucrReceiverPollutant
        '
        Me.ucrReceiverPollutant.AutoSize = True
        Me.ucrReceiverPollutant.frmParent = Me
        Me.ucrReceiverPollutant.Location = New System.Drawing.Point(257, 170)
        Me.ucrReceiverPollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPollutant.Name = "ucrReceiverPollutant"
        Me.ucrReceiverPollutant.Selector = Nothing
        Me.ucrReceiverPollutant.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPollutant.strNcFilePath = ""
        Me.ucrReceiverPollutant.TabIndex = 8
        Me.ucrReceiverPollutant.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(257, 75)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 4
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.AutoSize = True
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(257, 120)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 6
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed2
        '
        Me.ucrReceiverWindSpeed2.AutoSize = True
        Me.ucrReceiverWindSpeed2.frmParent = Me
        Me.ucrReceiverWindSpeed2.Location = New System.Drawing.Point(257, 248)
        Me.ucrReceiverWindSpeed2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed2.Name = "ucrReceiverWindSpeed2"
        Me.ucrReceiverWindSpeed2.Selector = Nothing
        Me.ucrReceiverWindSpeed2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed2.strNcFilePath = ""
        Me.ucrReceiverWindSpeed2.TabIndex = 11
        Me.ucrReceiverWindSpeed2.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection2
        '
        Me.ucrReceiverWindDirection2.AutoSize = True
        Me.ucrReceiverWindDirection2.frmParent = Me
        Me.ucrReceiverWindDirection2.Location = New System.Drawing.Point(257, 291)
        Me.ucrReceiverWindDirection2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection2.Name = "ucrReceiverWindDirection2"
        Me.ucrReceiverWindDirection2.Selector = Nothing
        Me.ucrReceiverWindDirection2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection2.strNcFilePath = ""
        Me.ucrReceiverWindDirection2.TabIndex = 13
        Me.ucrReceiverWindDirection2.ucrSelector = Nothing
        '
        'ucrSelectorWindPollutionRose
        '
        Me.ucrSelectorWindPollutionRose.AutoSize = True
        Me.ucrSelectorWindPollutionRose.bDropUnusedFilterLevels = False
        Me.ucrSelectorWindPollutionRose.bShowHiddenColumns = False
        Me.ucrSelectorWindPollutionRose.bUseCurrentFilter = True
        Me.ucrSelectorWindPollutionRose.Location = New System.Drawing.Point(10, 5)
        Me.ucrSelectorWindPollutionRose.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorWindPollutionRose.Name = "ucrSelectorWindPollutionRose"
        Me.ucrSelectorWindPollutionRose.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorWindPollutionRose.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 351)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 24
        '
        'dlgWindPollutionRose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(526, 416)
        Me.Controls.Add(Me.ucrChkCompareTwoSets)
        Me.Controls.Add(Me.lblFacetTwo)
        Me.Controls.Add(Me.lblFacetOne)
        Me.Controls.Add(Me.ucrReceiverFacetOne)
        Me.Controls.Add(Me.ucrReceiverFacetTwo)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputStatistic)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.ucrChkPaddle)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblStatistic)
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
    Friend WithEvents lblFacetTwo As Label
    Friend WithEvents lblFacetOne As Label
    Friend WithEvents ucrReceiverFacetOne As ucrReceiverSingle
    Friend WithEvents ucrReceiverFacetTwo As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrInputStatistic As ucrInputComboBox
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrChkPaddle As ucrCheck
    Friend WithEvents lblColor As Label
    Friend WithEvents lblStatistic As Label
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
    Friend WithEvents ucrChkCompareTwoSets As ucrCheck
End Class
