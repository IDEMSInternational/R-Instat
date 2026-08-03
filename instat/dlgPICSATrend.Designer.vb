<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPICSATrendGraph
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorPICSATrend = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucrReceiverFacetBy = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverColourBy = New instat.ucrReceiverSingle()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PlotOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLineOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemPointOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPICSAOptions = New System.Windows.Forms.Button()
        Me.ucrReceiverPICSATrend = New instat.ucrVariablesAsFactor()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(20, 586)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorPICSATrend
        '
        Me.ucrSelectorPICSATrend.AutoSize = True
        Me.ucrSelectorPICSATrend.bDropUnusedFilterLevels = False
        Me.ucrSelectorPICSATrend.bShowHiddenColumns = False
        Me.ucrSelectorPICSATrend.bUseCurrentFilter = True
        Me.ucrSelectorPICSATrend.Location = New System.Drawing.Point(6, 39)
        Me.ucrSelectorPICSATrend.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPICSATrend.Name = "ucrSelectorPICSATrend"
        Me.ucrSelectorPICSATrend.Size = New System.Drawing.Size(332, 284)
        Me.ucrSelectorPICSATrend.TabIndex = 2
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(554, 430)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(123, 32)
        Me.ucrInputStation.TabIndex = 31
        '
        'ucrReceiverFacetBy
        '
        Me.ucrReceiverFacetBy.AutoSize = True
        Me.ucrReceiverFacetBy.frmParent = Me
        Me.ucrReceiverFacetBy.Location = New System.Drawing.Point(363, 430)
        Me.ucrReceiverFacetBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetBy.Name = "ucrReceiverFacetBy"
        Me.ucrReceiverFacetBy.Selector = Nothing
        Me.ucrReceiverFacetBy.Size = New System.Drawing.Size(188, 39)
        Me.ucrReceiverFacetBy.strNcFilePath = ""
        Me.ucrReceiverFacetBy.TabIndex = 30
        Me.ucrReceiverFacetBy.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(363, 410)
        Me.lblFacetBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(149, 20)
        Me.lblFacetBy.TabIndex = 29
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By (Optional):"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(363, 298)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(218, 39)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 26
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverColourBy
        '
        Me.ucrReceiverColourBy.AutoSize = True
        Me.ucrReceiverColourBy.frmParent = Me
        Me.ucrReceiverColourBy.Location = New System.Drawing.Point(363, 366)
        Me.ucrReceiverColourBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColourBy.Name = "ucrReceiverColourBy"
        Me.ucrReceiverColourBy.Selector = Nothing
        Me.ucrReceiverColourBy.Size = New System.Drawing.Size(218, 39)
        Me.ucrReceiverColourBy.strNcFilePath = ""
        Me.ucrReceiverColourBy.TabIndex = 28
        Me.ucrReceiverColourBy.ucrSelector = Nothing
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorOptional.Location = New System.Drawing.Point(363, 339)
        Me.lblFactorOptional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(154, 20)
        Me.lblFactorOptional.TabIndex = 27
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        Me.lblFactorOptional.Text = "Colour By (Optional):"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(363, 276)
        Me.lblXVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(86, 20)
        Me.lblXVariable.TabIndex = 25
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.AutoSize = True
        Me.ucrChkWithSE.Checked = False
        Me.ucrChkWithSE.Location = New System.Drawing.Point(6, 443)
        Me.ucrChkWithSE.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        Me.ucrChkWithSE.Size = New System.Drawing.Size(332, 34)
        Me.ucrChkWithSE.TabIndex = 33
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.AutoSize = True
        Me.ucrChkLineofBestFit.Checked = False
        Me.ucrChkLineofBestFit.Location = New System.Drawing.Point(6, 398)
        Me.ucrChkLineofBestFit.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        Me.ucrChkLineofBestFit.Size = New System.Drawing.Size(332, 34)
        Me.ucrChkLineofBestFit.TabIndex = 32
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.AutoSize = True
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Location = New System.Drawing.Point(6, 487)
        Me.ucrChkPoints.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkPoints.Name = "ucrChkPoints"
        Me.ucrChkPoints.Size = New System.Drawing.Size(332, 36)
        Me.ucrChkPoints.TabIndex = 34
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(6, 536)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(480, 36)
        Me.ucrSave.TabIndex = 35
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(6, 346)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(226, 34)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 37
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlotOptionsToolStripMenuItem, Me.toolStripMenuItemLineOptions, Me.toolStripMenuItemPointOption})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(194, 100)
        '
        'PlotOptionsToolStripMenuItem
        '
        Me.PlotOptionsToolStripMenuItem.Name = "PlotOptionsToolStripMenuItem"
        Me.PlotOptionsToolStripMenuItem.Size = New System.Drawing.Size(193, 32)
        Me.PlotOptionsToolStripMenuItem.Text = "Plot Options"
        '
        'toolStripMenuItemLineOptions
        '
        Me.toolStripMenuItemLineOptions.Name = "toolStripMenuItemLineOptions"
        Me.toolStripMenuItemLineOptions.Size = New System.Drawing.Size(193, 32)
        Me.toolStripMenuItemLineOptions.Text = "Line Options"
        '
        'toolStripMenuItemPointOption
        '
        Me.toolStripMenuItemPointOption.Name = "toolStripMenuItemPointOption"
        Me.toolStripMenuItemPointOption.Size = New System.Drawing.Size(193, 32)
        Me.toolStripMenuItemPointOption.Text = "Point Options"
        '
        'cmdPICSAOptions
        '
        Me.cmdPICSAOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPICSAOptions.Location = New System.Drawing.Point(6, 310)
        Me.cmdPICSAOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPICSAOptions.Name = "cmdPICSAOptions"
        Me.cmdPICSAOptions.Size = New System.Drawing.Size(226, 34)
        Me.cmdPICSAOptions.TabIndex = 36
        Me.cmdPICSAOptions.Tag = ""
        Me.cmdPICSAOptions.Text = "PICSA Options"
        Me.cmdPICSAOptions.UseVisualStyleBackColor = True
        '
        'ucrReceiverPICSATrend
        '
        Me.ucrReceiverPICSATrend.AutoSize = True
        Me.ucrReceiverPICSATrend.frmParent = Me
        Me.ucrReceiverPICSATrend.Location = New System.Drawing.Point(363, 56)
        Me.ucrReceiverPICSATrend.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrReceiverPICSATrend.Name = "ucrReceiverPICSATrend"
        Me.ucrReceiverPICSATrend.Selector = Nothing
        Me.ucrReceiverPICSATrend.Size = New System.Drawing.Size(234, 178)
        Me.ucrReceiverPICSATrend.strNcFilePath = ""
        Me.ucrReceiverPICSATrend.TabIndex = 38
        Me.ucrReceiverPICSATrend.ucrSelector = Nothing
        Me.ucrReceiverPICSATrend.ucrVariableSelector = Nothing
        '
        'dlgPICSATrendGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(693, 670)
        Me.Controls.Add(Me.ucrReceiverPICSATrend)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdPICSAOptions)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrChkPoints)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucrReceiverFacetBy)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrReceiverColourBy)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrSelectorPICSATrend)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSATrendGraph"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trend Graph"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPICSATrend As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucrReceiverFacetBy As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrReceiverColourBy As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents cmdPICSAOptions As Button
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents PlotOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemLineOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemPointOption As ToolStripMenuItem
    Friend WithEvents ucrReceiverPICSATrend As ucrVariablesAsFactor
End Class
