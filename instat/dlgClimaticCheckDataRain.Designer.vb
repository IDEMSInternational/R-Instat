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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgClimaticCheckDataRain))
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblmm = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblRainDays = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblDay
        '
        resources.ApplyResources(Me.lblDay, "lblDay")
        Me.lblDay.Name = "lblDay"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblmm
        '
        resources.ApplyResources(Me.lblmm, "lblmm")
        Me.lblmm.Name = "lblmm"
        '
        'lblDays
        '
        resources.ApplyResources(Me.lblDays, "lblDays")
        Me.lblDays.Name = "lblDays"
        '
        'lblRainDays
        '
        resources.ApplyResources(Me.lblRainDays, "lblRainDays")
        Me.lblRainDays.Name = "lblRainDays"
        '
        'ucrNudWetDays
        '
        Me.ucrNudWetDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWetDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudWetDays, "ucrNudWetDays")
        Me.ucrNudWetDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWetDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWetDays.Name = "ucrNudWetDays"
        Me.ucrNudWetDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSame
        '
        Me.ucrNudSame.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSame, "ucrNudSame")
        Me.ucrNudSame.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSame.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Name = "ucrNudSame"
        Me.ucrNudSame.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLarge
        '
        Me.ucrNudLarge.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLarge.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLarge, "ucrNudLarge")
        Me.ucrNudLarge.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLarge.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLarge.Name = "ucrNudLarge"
        Me.ucrNudLarge.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOutlier
        '
        Me.ucrChkOutlier.Checked = False
        resources.ApplyResources(Me.ucrChkOutlier, "ucrChkOutlier")
        Me.ucrChkOutlier.Name = "ucrChkOutlier"
        '
        'ucrChkDryMonth
        '
        Me.ucrChkDryMonth.Checked = False
        resources.ApplyResources(Me.ucrChkDryMonth, "ucrChkDryMonth")
        Me.ucrChkDryMonth.Name = "ucrChkDryMonth"
        '
        'ucrChkWetDays
        '
        Me.ucrChkWetDays.Checked = False
        resources.ApplyResources(Me.ucrChkWetDays, "ucrChkWetDays")
        Me.ucrChkWetDays.Name = "ucrChkWetDays"
        '
        'ucrChkSame
        '
        Me.ucrChkSame.Checked = False
        resources.ApplyResources(Me.ucrChkSame, "ucrChkSame")
        Me.ucrChkSame.Name = "ucrChkSame"
        '
        'ucrChkLarge
        '
        Me.ucrChkLarge.Checked = False
        resources.ApplyResources(Me.ucrChkLarge, "ucrChkLarge")
        Me.ucrChkLarge.Name = "ucrChkLarge"
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement, "ucrReceiverElement")
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDay, "ucrReceiverDay")
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorRain
        '
        Me.ucrSelectorRain.bShowHiddenColumns = False
        Me.ucrSelectorRain.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRain, "ucrSelectorRain")
        Me.ucrSelectorRain.Name = "ucrSelectorRain"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgClimaticCheckDataRain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblRainDays)
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
    Friend WithEvents lblRainDays As Label
End Class
