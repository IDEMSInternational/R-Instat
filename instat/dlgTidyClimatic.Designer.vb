<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTidyClimaticData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTidyClimaticData))
        Me.lblColumnPer = New System.Windows.Forms.Label()
        Me.rdoDay = New System.Windows.Forms.RadioButton()
        Me.rdoMonth = New System.Windows.Forms.RadioButton()
        Me.rdoYear = New System.Windows.Forms.RadioButton()
        Me.lblYearTwo = New System.Windows.Forms.Label()
        Me.lblMonthTwo = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblDayofYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblElementName = New System.Windows.Forms.Label()
        Me.lblColumnstoStack = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverElementName = New instat.ucrReceiverSingle()
        Me.ucrReceiverMultipleStack = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDayofYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthTwo = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearTwo = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayofMonth = New instat.ucrReceiverSingle()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrPnlReshapeClimaticData = New instat.UcrPanel()
        Me.ucrSelectorTidyClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
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
        'lblDayofYear
        '
        resources.ApplyResources(Me.lblDayofYear, "lblDayofYear")
        Me.lblDayofYear.Name = "lblDayofYear"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblElementName
        '
        resources.ApplyResources(Me.lblElementName, "lblElementName")
        Me.lblElementName.Name = "lblElementName"
        '
        'lblColumnstoStack
        '
        resources.ApplyResources(Me.lblColumnstoStack, "lblColumnstoStack")
        Me.lblColumnstoStack.Name = "lblColumnstoStack"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
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
        'ucrReceiverElementName
        '
        Me.ucrReceiverElementName.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElementName, "ucrReceiverElementName")
        Me.ucrReceiverElementName.Name = "ucrReceiverElementName"
        Me.ucrReceiverElementName.Selector = Nothing
        Me.ucrReceiverElementName.strNcFilePath = ""
        Me.ucrReceiverElementName.ucrSelector = Nothing
        '
        'ucrReceiverMultipleStack
        '
        Me.ucrReceiverMultipleStack.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleStack, "ucrReceiverMultipleStack")
        Me.ucrReceiverMultipleStack.Name = "ucrReceiverMultipleStack"
        Me.ucrReceiverMultipleStack.Selector = Nothing
        Me.ucrReceiverMultipleStack.strNcFilePath = ""
        Me.ucrReceiverMultipleStack.ucrSelector = Nothing
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
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
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
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYearTwo, "ucrReceiverYearTwo")
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.strNcFilePath = ""
        Me.ucrReceiverYearTwo.ucrSelector = Nothing
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
        'ucrNewDFName
        '
        resources.ApplyResources(Me.ucrNewDFName, "ucrNewDFName")
        Me.ucrNewDFName.Name = "ucrNewDFName"
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
        'ucrPnlReshapeClimaticData
        '
        resources.ApplyResources(Me.ucrPnlReshapeClimaticData, "ucrPnlReshapeClimaticData")
        Me.ucrPnlReshapeClimaticData.Name = "ucrPnlReshapeClimaticData"
        '
        'ucrSelectorTidyClimaticData
        '
        Me.ucrSelectorTidyClimaticData.bDropUnusedFilterLevels = False
        Me.ucrSelectorTidyClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorTidyClimaticData.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTidyClimaticData, "ucrSelectorTidyClimaticData")
        Me.ucrSelectorTidyClimaticData.Name = "ucrSelectorTidyClimaticData"
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
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgTidyClimaticData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblColumnstoStack)
        Me.Controls.Add(Me.lblElementName)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverElementName)
        Me.Controls.Add(Me.ucrReceiverMultipleStack)
        Me.Controls.Add(Me.ucrReceiverDayofYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDayofYear)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverMonthTwo)
        Me.Controls.Add(Me.lblYearTwo)
        Me.Controls.Add(Me.lblMonthTwo)
        Me.Controls.Add(Me.ucrReceiverYearTwo)
        Me.Controls.Add(Me.ucrReceiverDayofMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrNewDFName)
        Me.Controls.Add(Me.lblDayofMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.rdoDay)
        Me.Controls.Add(Me.rdoMonth)
        Me.Controls.Add(Me.rdoYear)
        Me.Controls.Add(Me.ucrPnlReshapeClimaticData)
        Me.Controls.Add(Me.lblColumnPer)
        Me.Controls.Add(Me.ucrSelectorTidyClimaticData)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTidyClimaticData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTidyClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblColumnPer As Label
    Friend WithEvents rdoDay As RadioButton
    Friend WithEvents rdoMonth As RadioButton
    Friend WithEvents rdoYear As RadioButton
    Friend WithEvents ucrPnlReshapeClimaticData As UcrPanel
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents lblMonthTwo As Label
    Friend WithEvents ucrReceiverMonthTwo As ucrReceiverSingle
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents ucrNewDFName As ucrSave
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofMonth As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverDayofYear As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents lblColumnstoStack As Label
    Friend WithEvents lblElementName As Label
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverElementName As ucrReceiverSingle
    Friend WithEvents ucrReceiverMultipleStack As ucrReceiverMultiple
End Class
