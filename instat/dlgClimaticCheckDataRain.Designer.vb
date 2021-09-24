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
        Me.lblSkewnessWeight = New System.Windows.Forms.Label()
        Me.grpLogicalCalculatedColumns = New System.Windows.Forms.GroupBox()
        Me.lblCoeff = New System.Windows.Forms.Label()
        Me.cmdOmitMonths = New System.Windows.Forms.Button()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblMissingThreshold = New System.Windows.Forms.Label()
        Me.lblThresholdmm = New System.Windows.Forms.Label()
        Me.lblGreater = New System.Windows.Forms.Label()
        Me.ucrInputSameValue = New instat.ucrInputTextBox()
        Me.ucrInputThreshold = New instat.ucrInputTextBox()
        Me.ucrInputThresholdValue = New instat.ucrInputTextBox()
        Me.ucrNudCoeff = New instat.ucrNud()
        Me.ucrChkOmitZero = New instat.ucrCheck()
        Me.ucrNudSkewnessWeight = New instat.ucrNud()
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
        Me.ucrChkLogicalColumns = New instat.ucrCheck()
        Me.ucrChkCalculatedColumns = New instat.ucrCheck()
        Me.grpLogicalCalculatedColumns.SuspendLayout()
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
        'lblSkewnessWeight
        '
        resources.ApplyResources(Me.lblSkewnessWeight, "lblSkewnessWeight")
        Me.lblSkewnessWeight.Name = "lblSkewnessWeight"
        '
        'grpLogicalCalculatedColumns
        '
        Me.grpLogicalCalculatedColumns.Controls.Add(Me.ucrChkLogicalColumns)
        Me.grpLogicalCalculatedColumns.Controls.Add(Me.ucrChkCalculatedColumns)
        resources.ApplyResources(Me.grpLogicalCalculatedColumns, "grpLogicalCalculatedColumns")
        Me.grpLogicalCalculatedColumns.Name = "grpLogicalCalculatedColumns"
        Me.grpLogicalCalculatedColumns.TabStop = False
        '
        'lblCoeff
        '
        resources.ApplyResources(Me.lblCoeff, "lblCoeff")
        Me.lblCoeff.Name = "lblCoeff"
        '
        'cmdOmitMonths
        '
        resources.ApplyResources(Me.cmdOmitMonths, "cmdOmitMonths")
        Me.cmdOmitMonths.Name = "cmdOmitMonths"
        Me.cmdOmitMonths.UseVisualStyleBackColor = True
        '
        'lblThreshold
        '
        resources.ApplyResources(Me.lblThreshold, "lblThreshold")
        Me.lblThreshold.Name = "lblThreshold"
        '
        'lblMissingThreshold
        '
        resources.ApplyResources(Me.lblMissingThreshold, "lblMissingThreshold")
        Me.lblMissingThreshold.Name = "lblMissingThreshold"
        '
        'lblThresholdmm
        '
        resources.ApplyResources(Me.lblThresholdmm, "lblThresholdmm")
        Me.lblThresholdmm.Name = "lblThresholdmm"
        '
        'lblGreater
        '
        resources.ApplyResources(Me.lblGreater, "lblGreater")
        Me.lblGreater.Name = "lblGreater"
        '
        'ucrInputSameValue
        '
        Me.ucrInputSameValue.AddQuotesIfUnrecognised = True
        Me.ucrInputSameValue.IsMultiline = False
        Me.ucrInputSameValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSameValue, "ucrInputSameValue")
        Me.ucrInputSameValue.Name = "ucrInputSameValue"
        '
        'ucrInputThreshold
        '
        Me.ucrInputThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputThreshold.IsMultiline = False
        Me.ucrInputThreshold.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputThreshold, "ucrInputThreshold")
        Me.ucrInputThreshold.Name = "ucrInputThreshold"
        '
        'ucrInputThresholdValue
        '
        Me.ucrInputThresholdValue.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdValue.IsMultiline = False
        Me.ucrInputThresholdValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputThresholdValue, "ucrInputThresholdValue")
        Me.ucrInputThresholdValue.Name = "ucrInputThresholdValue"
        '
        'ucrNudCoeff
        '
        Me.ucrNudCoeff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCoeff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCoeff, "ucrNudCoeff")
        Me.ucrNudCoeff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCoeff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCoeff.Name = "ucrNudCoeff"
        Me.ucrNudCoeff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOmitZero
        '
        Me.ucrChkOmitZero.Checked = False
        resources.ApplyResources(Me.ucrChkOmitZero, "ucrChkOmitZero")
        Me.ucrChkOmitZero.Name = "ucrChkOmitZero"
        '
        'ucrNudSkewnessWeight
        '
        Me.ucrNudSkewnessWeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSkewnessWeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSkewnessWeight, "ucrNudSkewnessWeight")
        Me.ucrNudSkewnessWeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSkewnessWeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSkewnessWeight.Name = "ucrNudSkewnessWeight"
        Me.ucrNudSkewnessWeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        Me.ucrSelectorRain.bDropUnusedFilterLevels = False
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
        'ucrChkLogicalColumns
        '
        Me.ucrChkLogicalColumns.Checked = False
        resources.ApplyResources(Me.ucrChkLogicalColumns, "ucrChkLogicalColumns")
        Me.ucrChkLogicalColumns.Name = "ucrChkLogicalColumns"
        '
        'ucrChkCalculatedColumns
        '
        Me.ucrChkCalculatedColumns.Checked = False
        resources.ApplyResources(Me.ucrChkCalculatedColumns, "ucrChkCalculatedColumns")
        Me.ucrChkCalculatedColumns.Name = "ucrChkCalculatedColumns"
        '
        'dlgClimaticCheckDataRain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputSameValue)
        Me.Controls.Add(Me.lblGreater)
        Me.Controls.Add(Me.lblThresholdmm)
        Me.Controls.Add(Me.ucrInputThreshold)
        Me.Controls.Add(Me.lblMissingThreshold)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.ucrInputThresholdValue)
        Me.Controls.Add(Me.cmdOmitMonths)
        Me.Controls.Add(Me.lblCoeff)
        Me.Controls.Add(Me.ucrNudCoeff)
        Me.Controls.Add(Me.ucrChkOmitZero)
        Me.Controls.Add(Me.lblSkewnessWeight)
        Me.Controls.Add(Me.ucrNudSkewnessWeight)
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
        Me.Controls.Add(Me.grpLogicalCalculatedColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticCheckDataRain"
        Me.grpLogicalCalculatedColumns.ResumeLayout(False)
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
    Friend WithEvents lblSkewnessWeight As Label
    Friend WithEvents ucrNudSkewnessWeight As ucrNud
    Friend WithEvents ucrChkCalculatedColumns As ucrCheck
    Friend WithEvents ucrChkLogicalColumns As ucrCheck
    Friend WithEvents grpLogicalCalculatedColumns As GroupBox
    Friend WithEvents ucrChkOmitZero As ucrCheck
    Friend WithEvents lblCoeff As Label
    Friend WithEvents ucrNudCoeff As ucrNud
    Friend WithEvents cmdOmitMonths As Button
    Friend WithEvents ucrInputThresholdValue As ucrInputTextBox
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblMissingThreshold As Label
    Friend WithEvents ucrInputThreshold As ucrInputTextBox
    Friend WithEvents lblThresholdmm As Label
    Friend WithEvents lblGreater As Label
    Friend WithEvents ucrInputSameValue As ucrInputTextBox
End Class
