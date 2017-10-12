<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticCheckDataTemperature
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
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblRangeElement1 = New System.Windows.Forms.Label()
        Me.lblRangeElement2 = New System.Windows.Forms.Label()
        Me.lblRangeElement1to = New System.Windows.Forms.Label()
        Me.lblRangeElement2to = New System.Windows.Forms.Label()
        Me.ucrNudSame = New instat.ucrNud()
        Me.ucrNudDifference = New instat.ucrNud()
        Me.ucrNudOutlier = New instat.ucrNud()
        Me.ucrChkOutlier = New instat.ucrCheck()
        Me.ucrChkSame = New instat.ucrCheck()
        Me.ucrChkJump = New instat.ucrCheck()
        Me.ucrChkDifference = New instat.ucrCheck()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorTemperature = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudRangeElement2Max = New instat.ucrNud()
        Me.ucrNudRangeElement2Min = New instat.ucrNud()
        Me.ucrNudRangeElement1Max = New instat.ucrNud()
        Me.ucrNudRangeElement1Min = New instat.ucrNud()
        Me.ucrChkRange = New instat.ucrCheck()
        Me.lblJumpElement1to = New System.Windows.Forms.Label()
        Me.lblJumpElement2to = New System.Windows.Forms.Label()
        Me.lblJumpElement1 = New System.Windows.Forms.Label()
        Me.lblJumpElement2 = New System.Windows.Forms.Label()
        Me.ucrNudJumpElement2Max = New instat.ucrNud()
        Me.ucrNudJumpElement2Min = New instat.ucrNud()
        Me.ucrNudJumpElement1Max = New instat.ucrNud()
        Me.ucrNudJumpElement1Min = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(306, 9)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(40, 13)
        Me.lblStation.TabIndex = 8
        Me.lblStation.Text = "Station"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(306, 63)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(306, 115)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 10
        Me.lblYear.Text = "Year"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(306, 167)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblMonth.TabIndex = 11
        Me.lblMonth.Text = "Month"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(306, 219)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(26, 13)
        Me.lblDay.TabIndex = 12
        Me.lblDay.Text = "Day"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(306, 271)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(45, 13)
        Me.lblElement.TabIndex = 13
        Me.lblElement.Text = "Element"
        '
        'lblRangeElement1
        '
        Me.lblRangeElement1.AutoSize = True
        Me.lblRangeElement1.Location = New System.Drawing.Point(81, 218)
        Me.lblRangeElement1.Name = "lblRangeElement1"
        Me.lblRangeElement1.Size = New System.Drawing.Size(54, 13)
        Me.lblRangeElement1.TabIndex = 26
        Me.lblRangeElement1.Text = "Element 1"
        '
        'lblRangeElement2
        '
        Me.lblRangeElement2.AutoSize = True
        Me.lblRangeElement2.Location = New System.Drawing.Point(81, 260)
        Me.lblRangeElement2.Name = "lblRangeElement2"
        Me.lblRangeElement2.Size = New System.Drawing.Size(54, 13)
        Me.lblRangeElement2.TabIndex = 27
        Me.lblRangeElement2.Text = "Element 2"
        '
        'lblRangeElement1to
        '
        Me.lblRangeElement1to.AutoSize = True
        Me.lblRangeElement1to.Location = New System.Drawing.Point(185, 218)
        Me.lblRangeElement1to.Name = "lblRangeElement1to"
        Me.lblRangeElement1to.Size = New System.Drawing.Size(16, 13)
        Me.lblRangeElement1to.TabIndex = 26
        Me.lblRangeElement1to.Text = "to"
        '
        'lblRangeElement2to
        '
        Me.lblRangeElement2to.AutoSize = True
        Me.lblRangeElement2to.Location = New System.Drawing.Point(185, 260)
        Me.lblRangeElement2to.Name = "lblRangeElement2to"
        Me.lblRangeElement2to.Size = New System.Drawing.Size(16, 13)
        Me.lblRangeElement2to.TabIndex = 27
        Me.lblRangeElement2to.Text = "to"
        '
        'ucrNudSame
        '
        Me.ucrNudSame.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSame.Location = New System.Drawing.Point(81, 290)
        Me.ucrNudSame.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSame.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Name = "ucrNudSame"
        Me.ucrNudSame.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudSame.TabIndex = 23
        Me.ucrNudSame.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDifference
        '
        Me.ucrNudDifference.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDifference.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDifference.Location = New System.Drawing.Point(81, 406)
        Me.ucrNudDifference.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDifference.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDifference.Name = "ucrNudDifference"
        Me.ucrNudDifference.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudDifference.TabIndex = 21
        Me.ucrNudDifference.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudOutlier
        '
        Me.ucrNudOutlier.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOutlier.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOutlier.Location = New System.Drawing.Point(81, 432)
        Me.ucrNudOutlier.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOutlier.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOutlier.Name = "ucrNudOutlier"
        Me.ucrNudOutlier.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudOutlier.TabIndex = 20
        Me.ucrNudOutlier.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOutlier
        '
        Me.ucrChkOutlier.Checked = False
        Me.ucrChkOutlier.Location = New System.Drawing.Point(3, 432)
        Me.ucrChkOutlier.Name = "ucrChkOutlier"
        Me.ucrChkOutlier.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOutlier.TabIndex = 18
        '
        'ucrChkSame
        '
        Me.ucrChkSame.Checked = False
        Me.ucrChkSame.Location = New System.Drawing.Point(3, 290)
        Me.ucrChkSame.Name = "ucrChkSame"
        Me.ucrChkSame.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSame.TabIndex = 16
        '
        'ucrChkJump
        '
        Me.ucrChkJump.Checked = False
        Me.ucrChkJump.Location = New System.Drawing.Point(3, 327)
        Me.ucrChkJump.Name = "ucrChkJump"
        Me.ucrChkJump.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkJump.TabIndex = 15
        '
        'ucrChkDifference
        '
        Me.ucrChkDifference.Checked = False
        Me.ucrChkDifference.Location = New System.Drawing.Point(3, 406)
        Me.ucrChkDifference.Name = "ucrChkDifference"
        Me.ucrChkDifference.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDifference.TabIndex = 14
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(309, 284)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 7
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(309, 232)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 6
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(309, 180)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 5
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(309, 128)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 4
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(309, 76)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 3
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(309, 24)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorTemperature
        '
        Me.ucrSelectorTemperature.bShowHiddenColumns = False
        Me.ucrSelectorTemperature.bUseCurrentFilter = True
        Me.ucrSelectorTemperature.Location = New System.Drawing.Point(3, 9)
        Me.ucrSelectorTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTemperature.Name = "ucrSelectorTemperature"
        Me.ucrSelectorTemperature.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTemperature.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 462)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrNudRangeElement2Max
        '
        Me.ucrNudRangeElement2Max.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement2Max.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRangeElement2Max.Location = New System.Drawing.Point(209, 257)
        Me.ucrNudRangeElement2Max.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRangeElement2Max.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement2Max.Name = "ucrNudRangeElement2Max"
        Me.ucrNudRangeElement2Max.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudRangeElement2Max.TabIndex = 3
        Me.ucrNudRangeElement2Max.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRangeElement2Min
        '
        Me.ucrNudRangeElement2Min.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement2Min.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRangeElement2Min.Location = New System.Drawing.Point(141, 258)
        Me.ucrNudRangeElement2Min.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRangeElement2Min.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement2Min.Name = "ucrNudRangeElement2Min"
        Me.ucrNudRangeElement2Min.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudRangeElement2Min.TabIndex = 2
        Me.ucrNudRangeElement2Min.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRangeElement1Max
        '
        Me.ucrNudRangeElement1Max.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement1Max.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRangeElement1Max.Location = New System.Drawing.Point(210, 214)
        Me.ucrNudRangeElement1Max.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRangeElement1Max.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement1Max.Name = "ucrNudRangeElement1Max"
        Me.ucrNudRangeElement1Max.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudRangeElement1Max.TabIndex = 1
        Me.ucrNudRangeElement1Max.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRangeElement1Min
        '
        Me.ucrNudRangeElement1Min.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement1Min.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRangeElement1Min.Location = New System.Drawing.Point(141, 214)
        Me.ucrNudRangeElement1Min.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRangeElement1Min.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRangeElement1Min.Name = "ucrNudRangeElement1Min"
        Me.ucrNudRangeElement1Min.Size = New System.Drawing.Size(35, 20)
        Me.ucrNudRangeElement1Min.TabIndex = 0
        Me.ucrNudRangeElement1Min.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkRange
        '
        Me.ucrChkRange.Checked = False
        Me.ucrChkRange.Location = New System.Drawing.Point(3, 216)
        Me.ucrChkRange.Name = "ucrChkRange"
        Me.ucrChkRange.Size = New System.Drawing.Size(82, 20)
        Me.ucrChkRange.TabIndex = 28
        '
        'lblJumpElement1to
        '
        Me.lblJumpElement1to.AutoSize = True
        Me.lblJumpElement1to.Location = New System.Drawing.Point(190, 328)
        Me.lblJumpElement1to.Name = "lblJumpElement1to"
        Me.lblJumpElement1to.Size = New System.Drawing.Size(16, 13)
        Me.lblJumpElement1to.TabIndex = 33
        Me.lblJumpElement1to.Text = "to"
        '
        'lblJumpElement2to
        '
        Me.lblJumpElement2to.AutoSize = True
        Me.lblJumpElement2to.Location = New System.Drawing.Point(190, 370)
        Me.lblJumpElement2to.Name = "lblJumpElement2to"
        Me.lblJumpElement2to.Size = New System.Drawing.Size(16, 13)
        Me.lblJumpElement2to.TabIndex = 35
        Me.lblJumpElement2to.Text = "to"
        '
        'lblJumpElement1
        '
        Me.lblJumpElement1.AutoSize = True
        Me.lblJumpElement1.Location = New System.Drawing.Point(86, 328)
        Me.lblJumpElement1.Name = "lblJumpElement1"
        Me.lblJumpElement1.Size = New System.Drawing.Size(54, 13)
        Me.lblJumpElement1.TabIndex = 34
        Me.lblJumpElement1.Text = "Element 1"
        '
        'lblJumpElement2
        '
        Me.lblJumpElement2.AutoSize = True
        Me.lblJumpElement2.Location = New System.Drawing.Point(86, 370)
        Me.lblJumpElement2.Name = "lblJumpElement2"
        Me.lblJumpElement2.Size = New System.Drawing.Size(54, 13)
        Me.lblJumpElement2.TabIndex = 36
        Me.lblJumpElement2.Text = "Element 2"
        '
        'ucrNudJumpElement2Max
        '
        Me.ucrNudJumpElement2Max.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement2Max.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJumpElement2Max.Location = New System.Drawing.Point(214, 367)
        Me.ucrNudJumpElement2Max.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJumpElement2Max.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement2Max.Name = "ucrNudJumpElement2Max"
        Me.ucrNudJumpElement2Max.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudJumpElement2Max.TabIndex = 32
        Me.ucrNudJumpElement2Max.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJumpElement2Min
        '
        Me.ucrNudJumpElement2Min.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement2Min.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJumpElement2Min.Location = New System.Drawing.Point(146, 368)
        Me.ucrNudJumpElement2Min.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJumpElement2Min.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement2Min.Name = "ucrNudJumpElement2Min"
        Me.ucrNudJumpElement2Min.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudJumpElement2Min.TabIndex = 31
        Me.ucrNudJumpElement2Min.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJumpElement1Max
        '
        Me.ucrNudJumpElement1Max.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement1Max.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJumpElement1Max.Location = New System.Drawing.Point(215, 324)
        Me.ucrNudJumpElement1Max.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJumpElement1Max.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement1Max.Name = "ucrNudJumpElement1Max"
        Me.ucrNudJumpElement1Max.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudJumpElement1Max.TabIndex = 30
        Me.ucrNudJumpElement1Max.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJumpElement1Min
        '
        Me.ucrNudJumpElement1Min.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement1Min.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJumpElement1Min.Location = New System.Drawing.Point(146, 324)
        Me.ucrNudJumpElement1Min.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJumpElement1Min.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJumpElement1Min.Name = "ucrNudJumpElement1Min"
        Me.ucrNudJumpElement1Min.Size = New System.Drawing.Size(35, 20)
        Me.ucrNudJumpElement1Min.TabIndex = 29
        Me.ucrNudJumpElement1Min.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgClimaticCheckDataTemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 513)
        Me.Controls.Add(Me.lblJumpElement1to)
        Me.Controls.Add(Me.lblJumpElement2to)
        Me.Controls.Add(Me.lblJumpElement1)
        Me.Controls.Add(Me.lblJumpElement2)
        Me.Controls.Add(Me.ucrNudJumpElement2Max)
        Me.Controls.Add(Me.ucrNudJumpElement2Min)
        Me.Controls.Add(Me.ucrNudJumpElement1Max)
        Me.Controls.Add(Me.ucrNudJumpElement1Min)
        Me.Controls.Add(Me.ucrChkRange)
        Me.Controls.Add(Me.lblRangeElement1to)
        Me.Controls.Add(Me.ucrNudSame)
        Me.Controls.Add(Me.lblRangeElement2to)
        Me.Controls.Add(Me.lblRangeElement1)
        Me.Controls.Add(Me.ucrNudDifference)
        Me.Controls.Add(Me.lblRangeElement2)
        Me.Controls.Add(Me.ucrNudOutlier)
        Me.Controls.Add(Me.ucrNudRangeElement2Max)
        Me.Controls.Add(Me.ucrChkOutlier)
        Me.Controls.Add(Me.ucrNudRangeElement2Min)
        Me.Controls.Add(Me.ucrNudRangeElement1Max)
        Me.Controls.Add(Me.ucrChkSame)
        Me.Controls.Add(Me.ucrNudRangeElement1Min)
        Me.Controls.Add(Me.ucrChkJump)
        Me.Controls.Add(Me.ucrChkDifference)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorTemperature)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticCheckDataTemperature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Check Data Temperature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTemperature As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrChkOutlier As ucrCheck
    Friend WithEvents ucrChkSame As ucrCheck
    Friend WithEvents ucrChkJump As ucrCheck
    Friend WithEvents ucrChkDifference As ucrCheck
    Friend WithEvents ucrNudSame As ucrNud
    Friend WithEvents ucrNudDifference As ucrNud
    Friend WithEvents ucrNudOutlier As ucrNud
    Friend WithEvents ucrNudRangeElement1Max As ucrNud
    Friend WithEvents ucrNudRangeElement1Min As ucrNud
    Friend WithEvents lblRangeElement1 As Label
    Friend WithEvents lblRangeElement2 As Label
    Friend WithEvents ucrNudRangeElement2Max As ucrNud
    Friend WithEvents ucrNudRangeElement2Min As ucrNud
    Friend WithEvents lblRangeElement1to As Label
    Friend WithEvents lblRangeElement2to As Label
    Friend WithEvents ucrChkRange As ucrCheck
    Friend WithEvents lblJumpElement1to As Label
    Friend WithEvents lblJumpElement2to As Label
    Friend WithEvents lblJumpElement1 As Label
    Friend WithEvents lblJumpElement2 As Label
    Friend WithEvents ucrNudJumpElement2Max As ucrNud
    Friend WithEvents ucrNudJumpElement2Min As ucrNud
    Friend WithEvents ucrNudJumpElement1Max As ucrNud
    Friend WithEvents ucrNudJumpElement1Min As ucrNud
End Class
