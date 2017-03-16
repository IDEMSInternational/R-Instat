<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgInventoryPlot
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
        Me.lblDayOfyear = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.cmdInventoryPlotOptions = New System.Windows.Forms.Button()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrChkTitle = New instat.ucrCheck()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrChkShowNonMissing = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrInventoryPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblDayOfyear
        '
        Me.lblDayOfyear.AutoSize = True
        Me.lblDayOfyear.Location = New System.Drawing.Point(289, 88)
        Me.lblDayOfyear.Name = "lblDayOfyear"
        Me.lblDayOfyear.Size = New System.Drawing.Size(0, 13)
        Me.lblDayOfyear.TabIndex = 19
        '
        'cmdOptions
        '
        Me.cmdOptions.Enabled = False
        Me.cmdOptions.Location = New System.Drawing.Point(10, 205)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 23
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(260, 45)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 38
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(261, 204)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(88, 13)
        Me.lblStation.TabIndex = 16
        Me.lblStation.Text = "Station(Optional):"
        '
        'cmdInventoryPlotOptions
        '
        Me.cmdInventoryPlotOptions.Location = New System.Drawing.Point(10, 238)
        Me.cmdInventoryPlotOptions.Name = "cmdInventoryPlotOptions"
        Me.cmdInventoryPlotOptions.Size = New System.Drawing.Size(124, 23)
        Me.cmdInventoryPlotOptions.TabIndex = 40
        Me.cmdInventoryPlotOptions.Text = "Inventory Plot Options"
        Me.cmdInventoryPlotOptions.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(260, 86)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 13)
        Me.lblElement.TabIndex = 50
        Me.lblElement.Text = "Element(s):"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(263, 60)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 49
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(124, 295)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(259, 21)
        Me.ucrInputTitle.TabIndex = 48
        '
        'ucrChkTitle
        '
        Me.ucrChkTitle.Checked = False
        Me.ucrChkTitle.Location = New System.Drawing.Point(9, 297)
        Me.ucrChkTitle.Name = "ucrChkTitle"
        Me.ucrChkTitle.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkTitle.TabIndex = 47
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(263, 101)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.TabIndex = 36
        '
        'ucrChkShowNonMissing
        '
        Me.ucrChkShowNonMissing.Checked = False
        Me.ucrChkShowNonMissing.Location = New System.Drawing.Point(263, 270)
        Me.ucrChkShowNonMissing.Name = "ucrChkShowNonMissing"
        Me.ucrChkShowNonMissing.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkShowNonMissing.TabIndex = 34
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 322)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(283, 24)
        Me.ucrSaveGraph.TabIndex = 33
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(263, 244)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkFlipCoordinates.TabIndex = 32
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(263, 218)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.TabIndex = 15
        '
        'ucrInventoryPlotSelector
        '
        Me.ucrInventoryPlotSelector.bShowHiddenColumns = False
        Me.ucrInventoryPlotSelector.bUseCurrentFilter = True
        Me.ucrInventoryPlotSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrInventoryPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInventoryPlotSelector.Name = "ucrInventoryPlotSelector"
        Me.ucrInventoryPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrInventoryPlotSelector.TabIndex = 13
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 352)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 12
        '
        'dlgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 413)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.ucrChkTitle)
        Me.Controls.Add(Me.cmdInventoryPlotOptions)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrChkShowNonMissing)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblDayOfyear)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrInventoryPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInventoryPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Inventory_Plot"
        Me.Text = "Inventory Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInventoryPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblDayOfyear As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkShowNonMissing As ucrCheck
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents cmdInventoryPlotOptions As Button
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrChkTitle As ucrCheck
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblElement As Label
End Class
