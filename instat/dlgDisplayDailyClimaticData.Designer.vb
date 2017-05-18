<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplayDailyClimaticData
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
        Me.ucrSelectorDisplayDailyClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFrequencyDisplay = New instat.UcrPanel()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverXaxis = New instat.ucrReceiverSingle()
        Me.lblXaxis = New System.Windows.Forms.Label()
        Me.ucrReceiverYaxisLower = New instat.ucrReceiverSingle()
        Me.lblYaxisLower = New System.Windows.Forms.Label()
        Me.ucrReceiverYaxisUpper = New instat.ucrReceiverSingle()
        Me.lblYaxisUpper = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 409)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(428, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDisplayDailyClimaticData
        '
        Me.ucrSelectorDisplayDailyClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDisplayDailyClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDisplayDailyClimaticData.Location = New System.Drawing.Point(10, 43)
        Me.ucrSelectorDisplayDailyClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDisplayDailyClimaticData.Name = "ucrSelectorDisplayDailyClimaticData"
        Me.ucrSelectorDisplayDailyClimaticData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDisplayDailyClimaticData.TabIndex = 1
        '
        'rdoBoth
        '
        Me.rdoBoth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoBoth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoBoth.Location = New System.Drawing.Point(262, 11)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(100, 28)
        Me.rdoBoth.TabIndex = 7
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Location = New System.Drawing.Point(66, 11)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTable.TabIndex = 5
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGraph.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraph.Location = New System.Drawing.Point(164, 11)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(100, 28)
        Me.rdoGraph.TabIndex = 6
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'ucrPnlFrequencyDisplay
        '
        Me.ucrPnlFrequencyDisplay.Location = New System.Drawing.Point(10, 11)
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        Me.ucrPnlFrequencyDisplay.Size = New System.Drawing.Size(406, 29)
        Me.ucrPnlFrequencyDisplay.TabIndex = 4
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(274, 65)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 37
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(274, 80)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 38
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(274, 194)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 39
        Me.lblElement.Text = "Element:"
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.frmParent = Me
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(274, 209)
        Me.UcrReceiverSingle1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Selector = Nothing
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(143, 20)
        Me.UcrReceiverSingle1.strNcFilePath = ""
        Me.UcrReceiverSingle1.TabIndex = 40
        Me.UcrReceiverSingle1.ucrSelector = Nothing
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(274, 109)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 41
        Me.lblDate.Text = "Date:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(273, 124)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 42
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(273, 168)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 44
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(274, 153)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 43
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverXaxis
        '
        Me.ucrReceiverXaxis.frmParent = Me
        Me.ucrReceiverXaxis.Location = New System.Drawing.Point(274, 250)
        Me.ucrReceiverXaxis.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverXaxis.Name = "ucrReceiverXaxis"
        Me.ucrReceiverXaxis.Selector = Nothing
        Me.ucrReceiverXaxis.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverXaxis.strNcFilePath = ""
        Me.ucrReceiverXaxis.TabIndex = 46
        Me.ucrReceiverXaxis.ucrSelector = Nothing
        '
        'lblXaxis
        '
        Me.lblXaxis.AutoSize = True
        Me.lblXaxis.Location = New System.Drawing.Point(274, 235)
        Me.lblXaxis.Name = "lblXaxis"
        Me.lblXaxis.Size = New System.Drawing.Size(38, 13)
        Me.lblXaxis.TabIndex = 45
        Me.lblXaxis.Text = "X-axis:"
        '
        'ucrReceiverYaxisLower
        '
        Me.ucrReceiverYaxisLower.frmParent = Me
        Me.ucrReceiverYaxisLower.Location = New System.Drawing.Point(274, 292)
        Me.ucrReceiverYaxisLower.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYaxisLower.Name = "ucrReceiverYaxisLower"
        Me.ucrReceiverYaxisLower.Selector = Nothing
        Me.ucrReceiverYaxisLower.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYaxisLower.strNcFilePath = ""
        Me.ucrReceiverYaxisLower.TabIndex = 48
        Me.ucrReceiverYaxisLower.ucrSelector = Nothing
        '
        'lblYaxisLower
        '
        Me.lblYaxisLower.AutoSize = True
        Me.lblYaxisLower.Location = New System.Drawing.Point(274, 277)
        Me.lblYaxisLower.Name = "lblYaxisLower"
        Me.lblYaxisLower.Size = New System.Drawing.Size(70, 13)
        Me.lblYaxisLower.TabIndex = 47
        Me.lblYaxisLower.Text = "Y-axis Lower:"
        '
        'ucrReceiverYaxisUpper
        '
        Me.ucrReceiverYaxisUpper.frmParent = Me
        Me.ucrReceiverYaxisUpper.Location = New System.Drawing.Point(274, 338)
        Me.ucrReceiverYaxisUpper.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYaxisUpper.Name = "ucrReceiverYaxisUpper"
        Me.ucrReceiverYaxisUpper.Selector = Nothing
        Me.ucrReceiverYaxisUpper.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYaxisUpper.strNcFilePath = ""
        Me.ucrReceiverYaxisUpper.TabIndex = 50
        Me.ucrReceiverYaxisUpper.ucrSelector = Nothing
        '
        'lblYaxisUpper
        '
        Me.lblYaxisUpper.AutoSize = True
        Me.lblYaxisUpper.Location = New System.Drawing.Point(274, 323)
        Me.lblYaxisUpper.Name = "lblYaxisUpper"
        Me.lblYaxisUpper.Size = New System.Drawing.Size(70, 13)
        Me.lblYaxisUpper.TabIndex = 49
        Me.lblYaxisUpper.Text = "Y-axis Upper:"
        '
        'dlgDisplayDailyClimaticData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 473)
        Me.Controls.Add(Me.ucrReceiverYaxisUpper)
        Me.Controls.Add(Me.lblYaxisUpper)
        Me.Controls.Add(Me.ucrReceiverYaxisLower)
        Me.Controls.Add(Me.lblYaxisLower)
        Me.Controls.Add(Me.ucrReceiverXaxis)
        Me.Controls.Add(Me.lblXaxis)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrPnlFrequencyDisplay)
        Me.Controls.Add(Me.ucrSelectorDisplayDailyClimaticData)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDailyClimaticData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display Daily Climatic Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDisplayDailyClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents ucrPnlFrequencyDisplay As UcrPanel
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverYaxisUpper As ucrReceiverSingle
    Friend WithEvents lblYaxisUpper As Label
    Friend WithEvents ucrReceiverYaxisLower As ucrReceiverSingle
    Friend WithEvents lblYaxisLower As Label
    Friend WithEvents ucrReceiverXaxis As ucrReceiverSingle
    Friend WithEvents lblXaxis As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
End Class
