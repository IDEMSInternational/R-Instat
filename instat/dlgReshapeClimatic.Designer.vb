<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgReshapeClimaticData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReshapeClimaticData))
        Me.lblColumnPer = New System.Windows.Forms.Label()
        Me.rdoDay = New System.Windows.Forms.RadioButton()
        Me.rdoMonth = New System.Windows.Forms.RadioButton()
        Me.rdoYear = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverFirstDay = New instat.ucrReceiverSingle()
        Me.lblDayFirst = New System.Windows.Forms.Label()
        Me.ucrReceiverMonthTwo = New instat.ucrReceiverSingle()
        Me.lblYearTwo = New System.Windows.Forms.Label()
        Me.lblMonthTwo = New System.Windows.Forms.Label()
        Me.ucrReceiverYearTwo = New instat.ucrReceiverSingle()
        Me.ucrReceiverLastDay = New instat.ucrReceiverSingle()
        Me.lblDayLast = New System.Windows.Forms.Label()
        Me.ucrReceiverFirstMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverLastMonth = New instat.ucrReceiverSingle()
        Me.lblMonthFirst = New System.Windows.Forms.Label()
        Me.ucrReceiverDayofMonth = New instat.ucrReceiverSingle()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.lblMonthLast = New System.Windows.Forms.Label()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.ucrPnlReshapeClimaticData = New instat.UcrPanel()
        Me.ucrSelectorReshapeClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.lblDayofYear = New System.Windows.Forms.Label()
        Me.lblYearFirst = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ucrReceiverDayofYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverLastYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstYear = New instat.ucrReceiverSingle()
        Me.lblYearLast = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblColumnPer
        '
        resources.ApplyResources(Me.lblColumnPer, "lblColumnPer")
        Me.lblColumnPer.Name = "lblColumnPer"
        '
        'rdoDay
        '
        resources.ApplyResources(Me.rdoDay, "rdoDay")
        Me.rdoDay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDay.FlatAppearance.BorderSize = 2
        Me.rdoDay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDay.Name = "rdoDay"
        Me.rdoDay.TabStop = True
        Me.rdoDay.UseVisualStyleBackColor = True
        '
        'rdoMonth
        '
        resources.ApplyResources(Me.rdoMonth, "rdoMonth")
        Me.rdoMonth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonth.FlatAppearance.BorderSize = 2
        Me.rdoMonth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonth.Name = "rdoMonth"
        Me.rdoMonth.TabStop = True
        Me.rdoMonth.UseVisualStyleBackColor = True
        '
        'rdoYear
        '
        resources.ApplyResources(Me.rdoYear, "rdoYear")
        Me.rdoYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYear.FlatAppearance.BorderSize = 2
        Me.rdoYear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYear.Name = "rdoYear"
        Me.rdoYear.TabStop = True
        Me.rdoYear.UseVisualStyleBackColor = True
        '
        'ucrReceiverFirstDay
        '
        Me.ucrReceiverFirstDay.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirstDay, "ucrReceiverFirstDay")
        Me.ucrReceiverFirstDay.Name = "ucrReceiverFirstDay"
        Me.ucrReceiverFirstDay.Selector = Nothing
        Me.ucrReceiverFirstDay.strNcFilePath = ""
        Me.ucrReceiverFirstDay.ucrSelector = Nothing
        '
        'lblDayFirst
        '
        resources.ApplyResources(Me.lblDayFirst, "lblDayFirst")
        Me.lblDayFirst.Name = "lblDayFirst"
        '
        'ucrReceiverMonthTwo
        '
        Me.ucrReceiverMonthTwo.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonthTwo, "ucrReceiverMonthTwo")
        Me.ucrReceiverMonthTwo.Name = "ucrReceiverMonthTwo"
        Me.ucrReceiverMonthTwo.Selector = Nothing
        Me.ucrReceiverMonthTwo.strNcFilePath = ""
        Me.ucrReceiverMonthTwo.ucrSelector = Nothing
        '
        'lblYearTwo
        '
        resources.ApplyResources(Me.lblYearTwo, "lblYearTwo")
        Me.lblYearTwo.Name = "lblYearTwo"
        '
        'lblMonthTwo
        '
        resources.ApplyResources(Me.lblMonthTwo, "lblMonthTwo")
        Me.lblMonthTwo.Name = "lblMonthTwo"
        '
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYearTwo, "ucrReceiverYearTwo")
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.strNcFilePath = ""
        Me.ucrReceiverYearTwo.ucrSelector = Nothing
        '
        'ucrReceiverLastDay
        '
        Me.ucrReceiverLastDay.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLastDay, "ucrReceiverLastDay")
        Me.ucrReceiverLastDay.Name = "ucrReceiverLastDay"
        Me.ucrReceiverLastDay.Selector = Nothing
        Me.ucrReceiverLastDay.strNcFilePath = ""
        Me.ucrReceiverLastDay.ucrSelector = Nothing
        '
        'lblDayLast
        '
        resources.ApplyResources(Me.lblDayLast, "lblDayLast")
        Me.lblDayLast.Name = "lblDayLast"
        '
        'ucrReceiverFirstMonth
        '
        Me.ucrReceiverFirstMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirstMonth, "ucrReceiverFirstMonth")
        Me.ucrReceiverFirstMonth.Name = "ucrReceiverFirstMonth"
        Me.ucrReceiverFirstMonth.Selector = Nothing
        Me.ucrReceiverFirstMonth.strNcFilePath = ""
        Me.ucrReceiverFirstMonth.ucrSelector = Nothing
        '
        'ucrReceiverLastMonth
        '
        Me.ucrReceiverLastMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLastMonth, "ucrReceiverLastMonth")
        Me.ucrReceiverLastMonth.Name = "ucrReceiverLastMonth"
        Me.ucrReceiverLastMonth.Selector = Nothing
        Me.ucrReceiverLastMonth.strNcFilePath = ""
        Me.ucrReceiverLastMonth.ucrSelector = Nothing
        '
        'lblMonthFirst
        '
        resources.ApplyResources(Me.lblMonthFirst, "lblMonthFirst")
        Me.lblMonthFirst.Name = "lblMonthFirst"
        '
        'ucrReceiverDayofMonth
        '
        Me.ucrReceiverDayofMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDayofMonth, "ucrReceiverDayofMonth")
        Me.ucrReceiverDayofMonth.Name = "ucrReceiverDayofMonth"
        Me.ucrReceiverDayofMonth.Selector = Nothing
        Me.ucrReceiverDayofMonth.strNcFilePath = ""
        Me.ucrReceiverDayofMonth.ucrSelector = Nothing
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblDayofMonth
        '
        resources.ApplyResources(Me.lblDayofMonth, "lblDayofMonth")
        Me.lblDayofMonth.Name = "lblDayofMonth"
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
        'lblMonthLast
        '
        resources.ApplyResources(Me.lblMonthLast, "lblMonthLast")
        Me.lblMonthLast.Name = "lblMonthLast"
        '
        'ucrNewDFName
        '
        resources.ApplyResources(Me.ucrNewDFName, "ucrNewDFName")
        Me.ucrNewDFName.Name = "ucrNewDFName"
        '
        'ucrPnlReshapeClimaticData
        '
        resources.ApplyResources(Me.ucrPnlReshapeClimaticData, "ucrPnlReshapeClimaticData")
        Me.ucrPnlReshapeClimaticData.Name = "ucrPnlReshapeClimaticData"
        '
        'ucrSelectorReshapeClimaticData
        '
        Me.ucrSelectorReshapeClimaticData.bDropUnusedFilterLevels = False
        Me.ucrSelectorReshapeClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorReshapeClimaticData.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorReshapeClimaticData, "ucrSelectorReshapeClimaticData")
        Me.ucrSelectorReshapeClimaticData.Name = "ucrSelectorReshapeClimaticData"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
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
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'lblDayofYear
        '
        resources.ApplyResources(Me.lblDayofYear, "lblDayofYear")
        Me.lblDayofYear.Name = "lblDayofYear"
        '
        'lblYearFirst
        '
        resources.ApplyResources(Me.lblYearFirst, "lblYearFirst")
        Me.lblYearFirst.Name = "lblYearFirst"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'ucrReceiverDayofYear
        '
        Me.ucrReceiverDayofYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDayofYear, "ucrReceiverDayofYear")
        Me.ucrReceiverDayofYear.Name = "ucrReceiverDayofYear"
        Me.ucrReceiverDayofYear.Selector = Nothing
        Me.ucrReceiverDayofYear.strNcFilePath = ""
        Me.ucrReceiverDayofYear.ucrSelector = Nothing
        '
        'ucrReceiverLastYear
        '
        Me.ucrReceiverLastYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLastYear, "ucrReceiverLastYear")
        Me.ucrReceiverLastYear.Name = "ucrReceiverLastYear"
        Me.ucrReceiverLastYear.Selector = Nothing
        Me.ucrReceiverLastYear.strNcFilePath = ""
        Me.ucrReceiverLastYear.ucrSelector = Nothing
        '
        'ucrReceiverFirstYear
        '
        Me.ucrReceiverFirstYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirstYear, "ucrReceiverFirstYear")
        Me.ucrReceiverFirstYear.Name = "ucrReceiverFirstYear"
        Me.ucrReceiverFirstYear.Selector = Nothing
        Me.ucrReceiverFirstYear.strNcFilePath = ""
        Me.ucrReceiverFirstYear.ucrSelector = Nothing
        '
        'lblYearLast
        '
        resources.ApplyResources(Me.lblYearLast, "lblYearLast")
        Me.lblYearLast.Name = "lblYearLast"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'dlgReshapeClimaticData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblYearLast)
        Me.Controls.Add(Me.ucrReceiverFirstYear)
        Me.Controls.Add(Me.ucrReceiverLastYear)
        Me.Controls.Add(Me.ucrReceiverDayofYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYearFirst)
        Me.Controls.Add(Me.lblDayofYear)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverFirstDay)
        Me.Controls.Add(Me.ucrReceiverFirstMonth)
        Me.Controls.Add(Me.lblDayFirst)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverLastMonth)
        Me.Controls.Add(Me.ucrReceiverMonthTwo)
        Me.Controls.Add(Me.lblYearTwo)
        Me.Controls.Add(Me.lblMonthFirst)
        Me.Controls.Add(Me.lblMonthTwo)
        Me.Controls.Add(Me.ucrReceiverDayofMonth)
        Me.Controls.Add(Me.ucrReceiverYearTwo)
        Me.Controls.Add(Me.ucrReceiverLastDay)
        Me.Controls.Add(Me.lblDayLast)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrNewDFName)
        Me.Controls.Add(Me.lblDayofMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.rdoDay)
        Me.Controls.Add(Me.lblMonthLast)
        Me.Controls.Add(Me.rdoMonth)
        Me.Controls.Add(Me.rdoYear)
        Me.Controls.Add(Me.ucrPnlReshapeClimaticData)
        Me.Controls.Add(Me.lblColumnPer)
        Me.Controls.Add(Me.ucrSelectorReshapeClimaticData)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReshapeClimaticData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorReshapeClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblColumnPer As Label
    Friend WithEvents rdoDay As RadioButton
    Friend WithEvents rdoMonth As RadioButton
    Friend WithEvents rdoYear As RadioButton
    Friend WithEvents ucrPnlReshapeClimaticData As UcrPanel
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents lblMonthTwo As Label
    Friend WithEvents ucrReceiverMonthTwo As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofMonth As ucrReceiverSingle
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents ucrNewDFName As ucrSave
    Friend WithEvents lblMonthLast As Label
    Friend WithEvents ucrReceiverFirstMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverLastMonth As ucrReceiverSingle
    Friend WithEvents lblMonthFirst As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverLastDay As ucrReceiverSingle
    Friend WithEvents lblDayLast As Label
    Friend WithEvents ucrReceiverFirstDay As ucrReceiverSingle
    Friend WithEvents lblDayFirst As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblYearLast As Label
    Friend WithEvents ucrReceiverFirstYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverLastYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofYear As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYearFirst As Label
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
End Class
