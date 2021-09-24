<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTidyDailyData
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTidyDailyData))
        Me.lblColumnPer = New System.Windows.Forms.Label()
        Me.rdoDay = New System.Windows.Forms.RadioButton()
        Me.rdoMonth = New System.Windows.Forms.RadioButton()
        Me.rdoYear = New System.Windows.Forms.RadioButton()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblElementName = New System.Windows.Forms.Label()
        Me.lblColumnstoStack = New System.Windows.Forms.Label()
        Me.lblMultipleElement = New System.Windows.Forms.Label()
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.ucrChkUnstackElements = New instat.ucrCheck()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.ucrTextBoxElementName = New instat.ucrInputTextBox()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkIgnoreInvalid = New instat.ucrCheck()
        Me.ucrChkSilent = New instat.ucrCheck()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ttReshapeType = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblNColumns = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrame = New instat.ucrInputTextBox()
        Me.ucrReceiverMultipleStack = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayofMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrPnlReshapeClimaticData = New instat.UcrPanel()
        Me.ucrSelectorTidyDailyData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpElements.SuspendLayout()
        Me.grpOptions.SuspendLayout()
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
        'lblDayofMonth
        '
        resources.ApplyResources(Me.lblDayofMonth, "lblDayofMonth")
        Me.lblDayofMonth.Name = "lblDayofMonth"
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
        'lblMultipleElement
        '
        resources.ApplyResources(Me.lblMultipleElement, "lblMultipleElement")
        Me.lblMultipleElement.Name = "lblMultipleElement"
        '
        'grpElements
        '
        Me.grpElements.Controls.Add(Me.ucrChkUnstackElements)
        Me.grpElements.Controls.Add(Me.lblOr)
        Me.grpElements.Controls.Add(Me.lblElementName)
        Me.grpElements.Controls.Add(Me.ucrTextBoxElementName)
        Me.grpElements.Controls.Add(Me.lblMultipleElement)
        Me.grpElements.Controls.Add(Me.ucrReceiverElement)
        resources.ApplyResources(Me.grpElements, "grpElements")
        Me.grpElements.Name = "grpElements"
        Me.grpElements.TabStop = False
        '
        'ucrChkUnstackElements
        '
        Me.ucrChkUnstackElements.Checked = False
        resources.ApplyResources(Me.ucrChkUnstackElements, "ucrChkUnstackElements")
        Me.ucrChkUnstackElements.Name = "ucrChkUnstackElements"
        '
        'lblOr
        '
        resources.ApplyResources(Me.lblOr, "lblOr")
        Me.lblOr.Name = "lblOr"
        '
        'ucrTextBoxElementName
        '
        Me.ucrTextBoxElementName.AddQuotesIfUnrecognised = True
        Me.ucrTextBoxElementName.IsMultiline = False
        Me.ucrTextBoxElementName.IsReadOnly = False
        resources.ApplyResources(Me.ucrTextBoxElementName, "ucrTextBoxElementName")
        Me.ucrTextBoxElementName.Name = "ucrTextBoxElementName"
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
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkIgnoreInvalid)
        Me.grpOptions.Controls.Add(Me.ucrChkSilent)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrChkIgnoreInvalid
        '
        Me.ucrChkIgnoreInvalid.Checked = False
        resources.ApplyResources(Me.ucrChkIgnoreInvalid, "ucrChkIgnoreInvalid")
        Me.ucrChkIgnoreInvalid.Name = "ucrChkIgnoreInvalid"
        '
        'ucrChkSilent
        '
        Me.ucrChkSilent.Checked = False
        resources.ApplyResources(Me.ucrChkSilent, "ucrChkSilent")
        Me.ucrChkSilent.Name = "ucrChkSilent"
        '
        'lblNewDataFrameName
        '
        resources.ApplyResources(Me.lblNewDataFrameName, "lblNewDataFrameName")
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        '
        'lblNColumns
        '
        resources.ApplyResources(Me.lblNColumns, "lblNColumns")
        Me.lblNColumns.ForeColor = System.Drawing.Color.Red
        Me.lblNColumns.Name = "lblNColumns"
        '
        'ucrInputNewDataFrame
        '
        Me.ucrInputNewDataFrame.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrame.IsMultiline = False
        Me.ucrInputNewDataFrame.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewDataFrame, "ucrInputNewDataFrame")
        Me.ucrInputNewDataFrame.Name = "ucrInputNewDataFrame"
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
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
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
        'ucrSelectorTidyDailyData
        '
        Me.ucrSelectorTidyDailyData.bDropUnusedFilterLevels = False
        Me.ucrSelectorTidyDailyData.bShowHiddenColumns = False
        Me.ucrSelectorTidyDailyData.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTidyDailyData, "ucrSelectorTidyDailyData")
        Me.ucrSelectorTidyDailyData.Name = "ucrSelectorTidyDailyData"
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
        'dlgTidyDailyData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblNColumns)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrInputNewDataFrame)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.lblColumnstoStack)
        Me.Controls.Add(Me.ucrReceiverMultipleStack)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrReceiverDayofMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDayofMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.rdoDay)
        Me.Controls.Add(Me.rdoMonth)
        Me.Controls.Add(Me.rdoYear)
        Me.Controls.Add(Me.ucrPnlReshapeClimaticData)
        Me.Controls.Add(Me.lblColumnPer)
        Me.Controls.Add(Me.ucrSelectorTidyDailyData)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTidyDailyData"
        Me.grpElements.ResumeLayout(False)
        Me.grpElements.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTidyDailyData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblColumnPer As Label
    Friend WithEvents rdoDay As RadioButton
    Friend WithEvents rdoMonth As RadioButton
    Friend WithEvents rdoYear As RadioButton
    Friend WithEvents ucrPnlReshapeClimaticData As UcrPanel
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofMonth As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblMultipleElement As Label
    Friend WithEvents lblColumnstoStack As Label
    Friend WithEvents lblElementName As Label
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverMultipleStack As ucrReceiverMultiple
    Friend WithEvents ucrTextBoxElementName As ucrInputTextBox
    Friend WithEvents ucrChkIgnoreInvalid As ucrCheck
    Friend WithEvents ucrChkSilent As ucrCheck
    Friend WithEvents grpElements As GroupBox
    Friend WithEvents lblOr As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrInputNewDataFrame As ucrInputTextBox
    Friend WithEvents ttReshapeType As ToolTip
    Friend WithEvents ucrChkUnstackElements As ucrCheck
    Friend WithEvents lblNColumns As Label
End Class
