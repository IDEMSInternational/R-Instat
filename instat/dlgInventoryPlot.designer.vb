<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInventoryPlot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.UcrInventoryPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveInventoryPlot = New instat.ucrSaveGraph()
        Me.ucrYearReceiver = New instat.ucrReceiverSingle()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrDayOfYearReceiver = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.lblDayOfyear = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.chkFlipCoordinates = New System.Windows.Forms.CheckBox()
        Me.lblDoY = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 285)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 12
        '
        'UcrInventoryPlotSelector
        '
        Me.UcrInventoryPlotSelector.bShowHiddenColumns = False
        Me.UcrInventoryPlotSelector.bUseCurrentFilter = True
        Me.UcrInventoryPlotSelector.Location = New System.Drawing.Point(9, 9)
        Me.UcrInventoryPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrInventoryPlotSelector.Name = "UcrInventoryPlotSelector"
        Me.UcrInventoryPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.UcrInventoryPlotSelector.TabIndex = 13
        '
        'ucrSaveInventoryPlot
        '
        Me.ucrSaveInventoryPlot.Location = New System.Drawing.Point(12, 238)
        Me.ucrSaveInventoryPlot.Name = "ucrSaveInventoryPlot"
        Me.ucrSaveInventoryPlot.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveInventoryPlot.TabIndex = 14
        '
        'ucrYearReceiver
        '
        Me.ucrYearReceiver.Location = New System.Drawing.Point(292, 53)
        Me.ucrYearReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrYearReceiver.Name = "ucrYearReceiver"
        Me.ucrYearReceiver.Selector = Nothing
        Me.ucrYearReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrYearReceiver.TabIndex = 15
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(289, 31)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 16
        Me.lblYear.Text = "Year"
        '
        'ucrDayOfYearReceiver
        '
        Me.ucrDayOfYearReceiver.Location = New System.Drawing.Point(292, 113)
        Me.ucrDayOfYearReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDayOfYearReceiver.Name = "ucrDayOfYearReceiver"
        Me.ucrDayOfYearReceiver.Selector = Nothing
        Me.ucrDayOfYearReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrDayOfYearReceiver.TabIndex = 17
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(292, 168)
        Me.UcrReceiverSingle2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Selector = Nothing
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle2.TabIndex = 18
        '
        'lblDayOfyear
        '
        Me.lblDayOfyear.AutoSize = True
        Me.lblDayOfyear.Location = New System.Drawing.Point(289, 90)
        Me.lblDayOfyear.Name = "lblDayOfyear"
        Me.lblDayOfyear.Size = New System.Drawing.Size(0, 13)
        Me.lblDayOfyear.TabIndex = 19
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(289, 146)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(19, 13)
        Me.lblFill.TabIndex = 20
        Me.lblFill.Text = "Fill"
        '
        'chkFlipCoordinates
        '
        Me.chkFlipCoordinates.AutoSize = True
        Me.chkFlipCoordinates.Location = New System.Drawing.Point(292, 204)
        Me.chkFlipCoordinates.Name = "chkFlipCoordinates"
        Me.chkFlipCoordinates.Size = New System.Drawing.Size(101, 17)
        Me.chkFlipCoordinates.TabIndex = 21
        Me.chkFlipCoordinates.Text = "Flip Coordinates"
        Me.chkFlipCoordinates.UseVisualStyleBackColor = True
        '
        'lblDoY
        '
        Me.lblDoY.AutoSize = True
        Me.lblDoY.Location = New System.Drawing.Point(289, 90)
        Me.lblDoY.Name = "lblDoY"
        Me.lblDoY.Size = New System.Drawing.Size(79, 13)
        Me.lblDoY.TabIndex = 22
        Me.lblDoY.Text = "Day of the year"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(12, 204)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 23
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'dlgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 348)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblDoY)
        Me.Controls.Add(Me.chkFlipCoordinates)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.lblDayOfyear)
        Me.Controls.Add(Me.UcrReceiverSingle2)
        Me.Controls.Add(Me.ucrDayOfYearReceiver)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrYearReceiver)
        Me.Controls.Add(Me.ucrSaveInventoryPlot)
        Me.Controls.Add(Me.UcrInventoryPlotSelector)
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
    Friend WithEvents UcrInventoryPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveInventoryPlot As ucrSaveGraph
    Friend WithEvents ucrYearReceiver As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrDayOfYearReceiver As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents lblDayOfyear As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents chkFlipCoordinates As CheckBox
    Friend WithEvents lblDoY As Label
    Friend WithEvents cmdOptions As Button
End Class
