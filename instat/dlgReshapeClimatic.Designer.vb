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
        Me.grpDay = New System.Windows.Forms.GroupBox()
        Me.lblDayFirst = New System.Windows.Forms.Label()
        Me.lblStationThree = New System.Windows.Forms.Label()
        Me.lblYearThree = New System.Windows.Forms.Label()
        Me.lblMonthThree = New System.Windows.Forms.Label()
        Me.lblDayLast = New System.Windows.Forms.Label()
        Me.grpMonth = New System.Windows.Forms.GroupBox()
        Me.grpYear = New System.Windows.Forms.GroupBox()
        Me.lblYearLast = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYearFirst = New System.Windows.Forms.Label()
        Me.lblDayofYear = New System.Windows.Forms.Label()
        Me.lblMonthFirst = New System.Windows.Forms.Label()
        Me.lblStationTwo = New System.Windows.Forms.Label()
        Me.lblYearTwo = New System.Windows.Forms.Label()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblMonthLast = New System.Windows.Forms.Label()
        Me.ucrReceiverStationTwo = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverLastYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayofYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverLastMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayofMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearTwo = New instat.ucrReceiverSingle()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.ucrReceiverFirstDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverLastDay = New instat.ucrReceiverSingle()
        Me.ucrPnlReshapeClimaticData = New instat.UcrPanel()
        Me.ucrSelectorReshapeClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDay.SuspendLayout()
        Me.grpMonth.SuspendLayout()
        Me.grpYear.SuspendLayout()
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
        'grpDay
        '
        Me.grpDay.Controls.Add(Me.ucrReceiverFirstDay)
        Me.grpDay.Controls.Add(Me.lblDayFirst)
        Me.grpDay.Controls.Add(Me.ucrReceiverStationThree)
        Me.grpDay.Controls.Add(Me.ucrReceiverMonthThree)
        Me.grpDay.Controls.Add(Me.lblStationThree)
        Me.grpDay.Controls.Add(Me.lblYearThree)
        Me.grpDay.Controls.Add(Me.lblMonthThree)
        Me.grpDay.Controls.Add(Me.ucrReceiverYearThree)
        Me.grpDay.Controls.Add(Me.ucrReceiverLastDay)
        Me.grpDay.Controls.Add(Me.lblDayLast)
        resources.ApplyResources(Me.grpDay, "grpDay")
        Me.grpDay.Name = "grpDay"
        Me.grpDay.TabStop = False
        '
        'lblDayFirst
        '
        resources.ApplyResources(Me.lblDayFirst, "lblDayFirst")
        Me.lblDayFirst.Name = "lblDayFirst"
        '
        'lblStationThree
        '
        resources.ApplyResources(Me.lblStationThree, "lblStationThree")
        Me.lblStationThree.Name = "lblStationThree"
        '
        'lblYearThree
        '
        resources.ApplyResources(Me.lblYearThree, "lblYearThree")
        Me.lblYearThree.Name = "lblYearThree"
        '
        'lblMonthThree
        '
        resources.ApplyResources(Me.lblMonthThree, "lblMonthThree")
        Me.lblMonthThree.Name = "lblMonthThree"
        '
        'lblDayLast
        '
        resources.ApplyResources(Me.lblDayLast, "lblDayLast")
        Me.lblDayLast.Name = "lblDayLast"
        '
        'grpMonth
        '
        Me.grpMonth.Controls.Add(Me.ucrReceiverStationTwo)
        Me.grpMonth.Controls.Add(Me.grpYear)
        Me.grpMonth.Controls.Add(Me.ucrReceiverFirstMonth)
        Me.grpMonth.Controls.Add(Me.ucrReceiverLastMonth)
        Me.grpMonth.Controls.Add(Me.lblMonthFirst)
        Me.grpMonth.Controls.Add(Me.ucrReceiverDayofMonth)
        Me.grpMonth.Controls.Add(Me.lblStationTwo)
        Me.grpMonth.Controls.Add(Me.lblYearTwo)
        Me.grpMonth.Controls.Add(Me.lblDayofMonth)
        Me.grpMonth.Controls.Add(Me.ucrReceiverYearTwo)
        Me.grpMonth.Controls.Add(Me.lblMonthLast)
        resources.ApplyResources(Me.grpMonth, "grpMonth")
        Me.grpMonth.Name = "grpMonth"
        Me.grpMonth.TabStop = False
        '
        'grpYear
        '
        Me.grpYear.Controls.Add(Me.ucrReceiverStation)
        Me.grpYear.Controls.Add(Me.lblYearLast)
        Me.grpYear.Controls.Add(Me.ucrReceiverFirstYear)
        Me.grpYear.Controls.Add(Me.ucrReceiverLastYear)
        Me.grpYear.Controls.Add(Me.ucrReceiverDayofYear)
        Me.grpYear.Controls.Add(Me.lblStation)
        Me.grpYear.Controls.Add(Me.lblMonth)
        Me.grpYear.Controls.Add(Me.lblYearFirst)
        Me.grpYear.Controls.Add(Me.lblDayofYear)
        Me.grpYear.Controls.Add(Me.ucrReceiverMonth)
        resources.ApplyResources(Me.grpYear, "grpYear")
        Me.grpYear.Name = "grpYear"
        Me.grpYear.TabStop = False
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
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'lblYearFirst
        '
        resources.ApplyResources(Me.lblYearFirst, "lblYearFirst")
        Me.lblYearFirst.Name = "lblYearFirst"
        '
        'lblDayofYear
        '
        resources.ApplyResources(Me.lblDayofYear, "lblDayofYear")
        Me.lblDayofYear.Name = "lblDayofYear"
        '
        'lblMonthFirst
        '
        resources.ApplyResources(Me.lblMonthFirst, "lblMonthFirst")
        Me.lblMonthFirst.Name = "lblMonthFirst"
        '
        'lblStationTwo
        '
        resources.ApplyResources(Me.lblStationTwo, "lblStationTwo")
        Me.lblStationTwo.Name = "lblStationTwo"
        '
        'lblYearTwo
        '
        resources.ApplyResources(Me.lblYearTwo, "lblYearTwo")
        Me.lblYearTwo.Name = "lblYearTwo"
        '
        'lblDayofMonth
        '
        resources.ApplyResources(Me.lblDayofMonth, "lblDayofMonth")
        Me.lblDayofMonth.Name = "lblDayofMonth"
        '
        'lblMonthLast
        '
        resources.ApplyResources(Me.lblMonthLast, "lblMonthLast")
        Me.lblMonthLast.Name = "lblMonthLast"
        '
        'ucrReceiverStationTwo
        '
        Me.ucrReceiverStationTwo.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverStationTwo, "ucrReceiverStationTwo")
        Me.ucrReceiverStationTwo.Name = "ucrReceiverStationTwo"
        Me.ucrReceiverStationTwo.Selector = Nothing
        Me.ucrReceiverStationTwo.strNcFilePath = ""
        Me.ucrReceiverStationTwo.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverFirstYear
        '
        Me.ucrReceiverFirstYear.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverFirstYear, "ucrReceiverFirstYear")
        Me.ucrReceiverFirstYear.Name = "ucrReceiverFirstYear"
        Me.ucrReceiverFirstYear.Selector = Nothing
        Me.ucrReceiverFirstYear.strNcFilePath = ""
        Me.ucrReceiverFirstYear.ucrSelector = Nothing
        '
        'ucrReceiverLastYear
        '
        Me.ucrReceiverLastYear.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverLastYear, "ucrReceiverLastYear")
        Me.ucrReceiverLastYear.Name = "ucrReceiverLastYear"
        Me.ucrReceiverLastYear.Selector = Nothing
        Me.ucrReceiverLastYear.strNcFilePath = ""
        Me.ucrReceiverLastYear.ucrSelector = Nothing
        '
        'ucrReceiverDayofYear
        '
        Me.ucrReceiverDayofYear.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverDayofYear, "ucrReceiverDayofYear")
        Me.ucrReceiverDayofYear.Name = "ucrReceiverDayofYear"
        Me.ucrReceiverDayofYear.Selector = Nothing
        Me.ucrReceiverDayofYear.strNcFilePath = ""
        Me.ucrReceiverDayofYear.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverFirstMonth
        '
        Me.ucrReceiverFirstMonth.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverFirstMonth, "ucrReceiverFirstMonth")
        Me.ucrReceiverFirstMonth.Name = "ucrReceiverFirstMonth"
        Me.ucrReceiverFirstMonth.Selector = Nothing
        Me.ucrReceiverFirstMonth.strNcFilePath = ""
        Me.ucrReceiverFirstMonth.ucrSelector = Nothing
        '
        'ucrReceiverLastMonth
        '
        Me.ucrReceiverLastMonth.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverLastMonth, "ucrReceiverLastMonth")
        Me.ucrReceiverLastMonth.Name = "ucrReceiverLastMonth"
        Me.ucrReceiverLastMonth.Selector = Nothing
        Me.ucrReceiverLastMonth.strNcFilePath = ""
        Me.ucrReceiverLastMonth.ucrSelector = Nothing
        '
        'ucrReceiverDayofMonth
        '
        Me.ucrReceiverDayofMonth.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverDayofMonth, "ucrReceiverDayofMonth")
        Me.ucrReceiverDayofMonth.Name = "ucrReceiverDayofMonth"
        Me.ucrReceiverDayofMonth.Selector = Nothing
        Me.ucrReceiverDayofMonth.strNcFilePath = ""
        Me.ucrReceiverDayofMonth.ucrSelector = Nothing
        '
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverYearTwo, "ucrReceiverYearTwo")
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.strNcFilePath = ""
        Me.ucrReceiverYearTwo.ucrSelector = Nothing
        '
        'ucrNewDFName
        '
        resources.ApplyResources(Me.ucrNewDFName, "ucrNewDFName")
        Me.ucrNewDFName.Name = "ucrNewDFName"
        '
        'ucrReceiverFirstDay
        '
        Me.ucrReceiverFirstDay.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverFirstDay, "ucrReceiverFirstDay")
        Me.ucrReceiverFirstDay.Name = "ucrReceiverFirstDay"
        Me.ucrReceiverFirstDay.Selector = Nothing
        Me.ucrReceiverFirstDay.strNcFilePath = ""
        Me.ucrReceiverFirstDay.ucrSelector = Nothing
        '
        'ucrReceiverStationThree
        '
        Me.ucrReceiverStationThree.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverStationThree, "ucrReceiverStationThree")
        Me.ucrReceiverStationThree.Name = "ucrReceiverStationThree"
        Me.ucrReceiverStationThree.Selector = Nothing
        Me.ucrReceiverStationThree.strNcFilePath = ""
        Me.ucrReceiverStationThree.ucrSelector = Nothing
        '
        'ucrReceiverMonthThree
        '
        Me.ucrReceiverMonthThree.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverMonthThree, "ucrReceiverMonthThree")
        Me.ucrReceiverMonthThree.Name = "ucrReceiverMonthThree"
        Me.ucrReceiverMonthThree.Selector = Nothing
        Me.ucrReceiverMonthThree.strNcFilePath = ""
        Me.ucrReceiverMonthThree.ucrSelector = Nothing
        '
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverYearThree, "ucrReceiverYearThree")
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.strNcFilePath = ""
        Me.ucrReceiverYearThree.ucrSelector = Nothing
        '
        'ucrReceiverLastDay
        '
        Me.ucrReceiverLastDay.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverLastDay, "ucrReceiverLastDay")
        Me.ucrReceiverLastDay.Name = "ucrReceiverLastDay"
        Me.ucrReceiverLastDay.Selector = Nothing
        Me.ucrReceiverLastDay.strNcFilePath = ""
        Me.ucrReceiverLastDay.ucrSelector = Nothing
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
        'dlgReshapeClimaticData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpMonth)
        Me.Controls.Add(Me.ucrNewDFName)
        Me.Controls.Add(Me.grpDay)
        Me.Controls.Add(Me.rdoDay)
        Me.Controls.Add(Me.rdoMonth)
        Me.Controls.Add(Me.rdoYear)
        Me.Controls.Add(Me.ucrPnlReshapeClimaticData)
        Me.Controls.Add(Me.lblColumnPer)
        Me.Controls.Add(Me.ucrSelectorReshapeClimaticData)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReshapeClimaticData"
        Me.grpDay.ResumeLayout(False)
        Me.grpDay.PerformLayout()
        Me.grpMonth.ResumeLayout(False)
        Me.grpMonth.PerformLayout()
        Me.grpYear.ResumeLayout(False)
        Me.grpYear.PerformLayout()
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
    Friend WithEvents grpDay As GroupBox
    Friend WithEvents lblStationThree As Label
    Friend WithEvents lblYearThree As Label
    Friend WithEvents lblMonthThree As Label
    Friend WithEvents ucrReceiverStationThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonthThree As ucrReceiverSingle
    Friend WithEvents grpMonth As GroupBox
    Friend WithEvents ucrReceiverStationTwo As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofMonth As ucrReceiverSingle
    Friend WithEvents lblStationTwo As Label
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents grpYear As GroupBox
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofYear As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYearFirst As Label
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYearThree As ucrReceiverSingle
    Friend WithEvents ucrNewDFName As ucrSave
    Friend WithEvents ucrReceiverFirstYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverLastYear As ucrReceiverSingle
    Friend WithEvents lblYearLast As Label
    Friend WithEvents lblMonthLast As Label
    Friend WithEvents ucrReceiverFirstMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverLastMonth As ucrReceiverSingle
    Friend WithEvents lblMonthFirst As Label
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents ucrReceiverLastDay As ucrReceiverSingle
    Friend WithEvents lblDayLast As Label
    Friend WithEvents ucrReceiverFirstDay As ucrReceiverSingle
    Friend WithEvents lblDayFirst As Label
End Class
