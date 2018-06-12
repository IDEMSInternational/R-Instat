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
        Me.lblStationThree = New System.Windows.Forms.Label()
        Me.lblYearThree = New System.Windows.Forms.Label()
        Me.lblMonthThree = New System.Windows.Forms.Label()
        Me.lblDayofMonthTwo = New System.Windows.Forms.Label()
        Me.grpMonth = New System.Windows.Forms.GroupBox()
        Me.grpYear = New System.Windows.Forms.GroupBox()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayofYear = New System.Windows.Forms.Label()
        Me.lblStationTwo = New System.Windows.Forms.Label()
        Me.lblYearTwo = New System.Windows.Forms.Label()
        Me.lblMonthTwo = New System.Windows.Forms.Label()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayofYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationTwo = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayofMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthTwo = New instat.ucrReceiverMultiple()
        Me.ucrReceiverYearTwo = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayofMonthTwo = New instat.ucrReceiverMultiple()
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
        Me.grpDay.Controls.Add(Me.ucrReceiverYearThree)
        Me.grpDay.Controls.Add(Me.grpMonth)
        Me.grpDay.Controls.Add(Me.ucrReceiverStationThree)
        Me.grpDay.Controls.Add(Me.ucrReceiverMonthThree)
        Me.grpDay.Controls.Add(Me.ucrReceiverDayofMonthTwo)
        Me.grpDay.Controls.Add(Me.lblStationThree)
        Me.grpDay.Controls.Add(Me.lblYearThree)
        Me.grpDay.Controls.Add(Me.lblMonthThree)
        Me.grpDay.Controls.Add(Me.lblDayofMonthTwo)
        resources.ApplyResources(Me.grpDay, "grpDay")
        Me.grpDay.Name = "grpDay"
        Me.grpDay.TabStop = False
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
        'lblDayofMonthTwo
        '
        resources.ApplyResources(Me.lblDayofMonthTwo, "lblDayofMonthTwo")
        Me.lblDayofMonthTwo.Name = "lblDayofMonthTwo"
        '
        'grpMonth
        '
        Me.grpMonth.Controls.Add(Me.ucrReceiverStationTwo)
        Me.grpMonth.Controls.Add(Me.ucrReceiverDayofMonth)
        Me.grpMonth.Controls.Add(Me.ucrReceiverMonthTwo)
        Me.grpMonth.Controls.Add(Me.lblStationTwo)
        Me.grpMonth.Controls.Add(Me.lblYearTwo)
        Me.grpMonth.Controls.Add(Me.lblMonthTwo)
        Me.grpMonth.Controls.Add(Me.lblDayofMonth)
        Me.grpMonth.Controls.Add(Me.ucrReceiverYearTwo)
        resources.ApplyResources(Me.grpMonth, "grpMonth")
        Me.grpMonth.Name = "grpMonth"
        Me.grpMonth.TabStop = False
        '
        'grpYear
        '
        Me.grpYear.Controls.Add(Me.ucrReceiverStation)
        Me.grpYear.Controls.Add(Me.ucrReceiverDayofYear)
        Me.grpYear.Controls.Add(Me.ucrReceiverYear)
        Me.grpYear.Controls.Add(Me.lblStation)
        Me.grpYear.Controls.Add(Me.lblMonth)
        Me.grpYear.Controls.Add(Me.lblYear)
        Me.grpYear.Controls.Add(Me.lblDayofYear)
        Me.grpYear.Controls.Add(Me.ucrReceiverMonth)
        resources.ApplyResources(Me.grpYear, "grpYear")
        Me.grpYear.Name = "grpYear"
        Me.grpYear.TabStop = False
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
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblDayofYear
        '
        resources.ApplyResources(Me.lblDayofYear, "lblDayofYear")
        Me.lblDayofYear.Name = "lblDayofYear"
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
        'lblMonthTwo
        '
        resources.ApplyResources(Me.lblMonthTwo, "lblMonthTwo")
        Me.lblMonthTwo.Name = "lblMonthTwo"
        '
        'lblDayofMonth
        '
        resources.ApplyResources(Me.lblDayofMonth, "lblDayofMonth")
        Me.lblDayofMonth.Name = "lblDayofMonth"
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
        'ucrReceiverDayofYear
        '
        Me.ucrReceiverDayofYear.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverDayofYear, "ucrReceiverDayofYear")
        Me.ucrReceiverDayofYear.Name = "ucrReceiverDayofYear"
        Me.ucrReceiverDayofYear.Selector = Nothing
        Me.ucrReceiverDayofYear.strNcFilePath = ""
        Me.ucrReceiverDayofYear.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
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
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverYearThree, "ucrReceiverYearThree")
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.strNcFilePath = ""
        Me.ucrReceiverYearThree.ucrSelector = Nothing
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
        'ucrReceiverDayofMonth
        '
        Me.ucrReceiverDayofMonth.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverDayofMonth, "ucrReceiverDayofMonth")
        Me.ucrReceiverDayofMonth.Name = "ucrReceiverDayofMonth"
        Me.ucrReceiverDayofMonth.Selector = Nothing
        Me.ucrReceiverDayofMonth.strNcFilePath = ""
        Me.ucrReceiverDayofMonth.ucrSelector = Nothing
        '
        'ucrReceiverMonthTwo
        '
        Me.ucrReceiverMonthTwo.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverMonthTwo, "ucrReceiverMonthTwo")
        Me.ucrReceiverMonthTwo.Name = "ucrReceiverMonthTwo"
        Me.ucrReceiverMonthTwo.Selector = Nothing
        Me.ucrReceiverMonthTwo.strNcFilePath = ""
        Me.ucrReceiverMonthTwo.ucrSelector = Nothing
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
        'ucrReceiverDayofMonthTwo
        '
        Me.ucrReceiverDayofMonthTwo.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverDayofMonthTwo, "ucrReceiverDayofMonthTwo")
        Me.ucrReceiverDayofMonthTwo.Name = "ucrReceiverDayofMonthTwo"
        Me.ucrReceiverDayofMonthTwo.Selector = Nothing
        Me.ucrReceiverDayofMonthTwo.strNcFilePath = ""
        Me.ucrReceiverDayofMonthTwo.ucrSelector = Nothing
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
        Me.Controls.Add(Me.grpYear)
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
    Friend WithEvents ucrReceiverDayofMonthTwo As ucrReceiverMultiple
    Friend WithEvents lblStationThree As Label
    Friend WithEvents lblYearThree As Label
    Friend WithEvents lblMonthThree As Label
    Friend WithEvents lblDayofMonthTwo As Label
    Friend WithEvents ucrReceiverYearThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonthThree As ucrReceiverSingle
    Friend WithEvents grpMonth As GroupBox
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationTwo As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonthTwo As ucrReceiverMultiple
    Friend WithEvents lblStationTwo As Label
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents lblMonthTwo As Label
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents grpYear As GroupBox
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverMultiple
    Friend WithEvents lblStation As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
End Class
