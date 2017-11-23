<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticCheckDataRain
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
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblmm = New System.Windows.Forms.Label()
        Me.ucrNudWetDays = New instat.ucrNud()
        Me.ucrNudSame = New instat.ucrNud()
        Me.ucrNudLarge = New instat.ucrNud()
        Me.ucrChkOutlier = New instat.ucrCheck()
        Me.ucrChkDryMonth = New instat.ucrCheck()
        Me.ucrChkWetDays = New instat.ucrCheck()
        Me.ucrChkSame = New instat.ucrCheck()
        Me.ucrChkLarge = New instat.ucrCheck()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorRain = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblDaysWet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(259, 22)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(40, 13)
        Me.lblStation.TabIndex = 2
        Me.lblStation.Text = "Station"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(259, 69)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(259, 113)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "Year"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(259, 199)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(26, 13)
        Me.lblDay.TabIndex = 4
        Me.lblDay.Text = "Day"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(259, 155)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "Month"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(259, 245)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(45, 13)
        Me.lblElement.TabIndex = 4
        Me.lblElement.Text = "Element"
        '
        'lblmm
        '
        Me.lblmm.AutoSize = True
        Me.lblmm.Location = New System.Drawing.Point(157, 211)
        Me.lblmm.Name = "lblmm"
        Me.lblmm.Size = New System.Drawing.Size(23, 13)
        Me.lblmm.TabIndex = 19
        Me.lblmm.Text = "mm"
        '
        'ucrNudWetDays
        '
        Me.ucrNudWetDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWetDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWetDays.Location = New System.Drawing.Point(106, 255)
        Me.ucrNudWetDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWetDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWetDays.Name = "ucrNudWetDays"
        Me.ucrNudWetDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWetDays.TabIndex = 9
        Me.ucrNudWetDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSame
        '
        Me.ucrNudSame.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSame.Location = New System.Drawing.Point(106, 231)
        Me.ucrNudSame.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSame.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Name = "ucrNudSame"
        Me.ucrNudSame.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSame.TabIndex = 8
        Me.ucrNudSame.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLarge
        '
        Me.ucrNudLarge.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLarge.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLarge.Location = New System.Drawing.Point(106, 207)
        Me.ucrNudLarge.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.ucrNudLarge.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLarge.Name = "ucrNudLarge"
        Me.ucrNudLarge.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLarge.TabIndex = 7
        Me.ucrNudLarge.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOutlier
        '
        Me.ucrChkOutlier.Checked = False
        Me.ucrChkOutlier.Location = New System.Drawing.Point(10, 303)
        Me.ucrChkOutlier.Name = "ucrChkOutlier"
        Me.ucrChkOutlier.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOutlier.TabIndex = 6
        '
        'ucrChkDryMonth
        '
        Me.ucrChkDryMonth.Checked = False
        Me.ucrChkDryMonth.Location = New System.Drawing.Point(10, 279)
        Me.ucrChkDryMonth.Name = "ucrChkDryMonth"
        Me.ucrChkDryMonth.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDryMonth.TabIndex = 6
        '
        'ucrChkWetDays
        '
        Me.ucrChkWetDays.Checked = False
        Me.ucrChkWetDays.Location = New System.Drawing.Point(10, 255)
        Me.ucrChkWetDays.Name = "ucrChkWetDays"
        Me.ucrChkWetDays.Size = New System.Drawing.Size(92, 20)
        Me.ucrChkWetDays.TabIndex = 6
        '
        'ucrChkSame
        '
        Me.ucrChkSame.Checked = False
        Me.ucrChkSame.Location = New System.Drawing.Point(10, 231)
        Me.ucrChkSame.Name = "ucrChkSame"
        Me.ucrChkSame.Size = New System.Drawing.Size(92, 20)
        Me.ucrChkSame.TabIndex = 6
        '
        'ucrChkLarge
        '
        Me.ucrChkLarge.Checked = False
        Me.ucrChkLarge.Location = New System.Drawing.Point(10, 207)
        Me.ucrChkLarge.Name = "ucrChkLarge"
        Me.ucrChkLarge.Size = New System.Drawing.Size(92, 20)
        Me.ucrChkLarge.TabIndex = 6
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(259, 172)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 5
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(259, 258)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 5
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(259, 215)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 5
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(259, 129)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 5
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(259, 86)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 5
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(259, 38)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 3
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorRain
        '
        Me.ucrSelectorRain.bShowHiddenColumns = False
        Me.ucrSelectorRain.bUseCurrentFilter = True
        Me.ucrSelectorRain.Location = New System.Drawing.Point(10, 20)
        Me.ucrSelectorRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRain.Name = "ucrSelectorRain"
        Me.ucrSelectorRain.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorRain.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 329)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(157, 234)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(29, 13)
        Me.lblDays.TabIndex = 20
        Me.lblDays.Text = "days (ignoring zero)"
        '
        'lblDaysWet
        '
        Me.lblDaysWet.AutoSize = True
        Me.lblDaysWet.Location = New System.Drawing.Point(157, 259)
        Me.lblDaysWet.Name = "lblDaysWet"
        Me.lblDaysWet.Size = New System.Drawing.Size(98, 13)
        Me.lblDaysWet.TabIndex = 21
        Me.lblDaysWet.Text = "days"
        '
        'dlgClimaticCheckDataRain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 389)
        Me.Controls.Add(Me.lblDaysWet)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblmm)
        Me.Controls.Add(Me.ucrNudWetDays)
        Me.Controls.Add(Me.ucrNudSame)
        Me.Controls.Add(Me.ucrNudLarge)
        Me.Controls.Add(Me.ucrChkOutlier)
        Me.Controls.Add(Me.ucrChkDryMonth)
        Me.Controls.Add(Me.ucrChkWetDays)
        Me.Controls.Add(Me.ucrChkSame)
        Me.Controls.Add(Me.ucrChkLarge)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrSelectorRain)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticCheckDataRain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Check Data Rainfall"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRain As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrChkOutlier As ucrCheck
    Friend WithEvents ucrChkDryMonth As ucrCheck
    Friend WithEvents ucrChkWetDays As ucrCheck
    Friend WithEvents ucrChkSame As ucrCheck
    Friend WithEvents ucrChkLarge As ucrCheck
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrNudLarge As ucrNud
    Friend WithEvents ucrNudWetDays As ucrNud
    Friend WithEvents ucrNudSame As ucrNud
    Friend WithEvents lblmm As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents lblDaysWet As Label
End Class
