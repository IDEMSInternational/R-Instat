<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSeasonalGraph
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrSelectorForSeasonalGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrChkColour = New instat.ucrCheck()
        Me.lblXvariable = New System.Windows.Forms.Label()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverRibbons = New instat.ucrReceiverMultiple()
        Me.lblLines = New System.Windows.Forms.Label()
        Me.ucrReceiverLines = New instat.ucrReceiverMultiple()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrChkRibbons = New instat.ucrCheck()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucrReceiverFacetBy = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.UcrInputColour = New instat.ucrInputComboBox()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.SuspendLayout()
        '
        'ucrSelectorForSeasonalGraph
        '
        Me.ucrSelectorForSeasonalGraph.AutoSize = True
        Me.ucrSelectorForSeasonalGraph.bDropUnusedFilterLevels = False
        Me.ucrSelectorForSeasonalGraph.bShowHiddenColumns = False
        Me.ucrSelectorForSeasonalGraph.bUseCurrentFilter = True
        Me.ucrSelectorForSeasonalGraph.Location = New System.Drawing.Point(13, 68)
        Me.ucrSelectorForSeasonalGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForSeasonalGraph.Name = "ucrSelectorForSeasonalGraph"
        Me.ucrSelectorForSeasonalGraph.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForSeasonalGraph.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(22, 428)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 19
        '
        'rdoBar
        '
        Me.rdoBar.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBar.BackColor = System.Drawing.SystemColors.Control
        Me.rdoBar.Enabled = False
        Me.rdoBar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBar.FlatAppearance.BorderSize = 2
        Me.rdoBar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBar.Location = New System.Drawing.Point(204, 20)
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.Size = New System.Drawing.Size(80, 28)
        Me.rdoBar.TabIndex = 3
        Me.rdoBar.TabStop = True
        Me.rdoBar.Tag = ""
        Me.rdoBar.Text = "Bar"
        Me.rdoBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBar.UseVisualStyleBackColor = False
        '
        'rdoLine
        '
        Me.rdoLine.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLine.BackColor = System.Drawing.SystemColors.Control
        Me.rdoLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLine.FlatAppearance.BorderSize = 2
        Me.rdoLine.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLine.Location = New System.Drawing.Point(126, 20)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(80, 28)
        Me.rdoLine.TabIndex = 2
        Me.rdoLine.TabStop = True
        Me.rdoLine.Tag = "linepathstep"
        Me.rdoLine.Text = "Line"
        Me.rdoLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLine.UseVisualStyleBackColor = False
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(122, 12)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(220, 44)
        Me.ucrPnlOptions.TabIndex = 1
        '
        'ucrChkColour
        '
        Me.ucrChkColour.AutoSize = True
        Me.ucrChkColour.Checked = False
        Me.ucrChkColour.Enabled = False
        Me.ucrChkColour.Location = New System.Drawing.Point(13, 300)
        Me.ucrChkColour.Name = "ucrChkColour"
        Me.ucrChkColour.Size = New System.Drawing.Size(88, 23)
        Me.ucrChkColour.TabIndex = 15
        '
        'lblXvariable
        '
        Me.lblXvariable.AutoSize = True
        Me.lblXvariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXvariable.Location = New System.Drawing.Point(260, 285)
        Me.lblXvariable.Name = "lblXvariable"
        Me.lblXvariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXvariable.TabIndex = 6
        Me.lblXvariable.Text = "X Variable:"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(259, 301)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 7
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverRibbons
        '
        Me.ucrReceiverRibbons.AutoSize = True
        Me.ucrReceiverRibbons.frmParent = Me
        Me.ucrReceiverRibbons.Location = New System.Drawing.Point(259, 207)
        Me.ucrReceiverRibbons.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRibbons.Name = "ucrReceiverRibbons"
        Me.ucrReceiverRibbons.Selector = Nothing
        Me.ucrReceiverRibbons.Size = New System.Drawing.Size(120, 75)
        Me.ucrReceiverRibbons.strNcFilePath = ""
        Me.ucrReceiverRibbons.TabIndex = 12
        Me.ucrReceiverRibbons.ucrSelector = Nothing
        '
        'lblLines
        '
        Me.lblLines.AutoSize = True
        Me.lblLines.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLines.Location = New System.Drawing.Point(260, 68)
        Me.lblLines.Name = "lblLines"
        Me.lblLines.Size = New System.Drawing.Size(35, 13)
        Me.lblLines.TabIndex = 4
        Me.lblLines.Text = "Lines:"
        '
        'ucrReceiverLines
        '
        Me.ucrReceiverLines.AutoSize = True
        Me.ucrReceiverLines.frmParent = Me
        Me.ucrReceiverLines.Location = New System.Drawing.Point(259, 82)
        Me.ucrReceiverLines.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLines.Name = "ucrReceiverLines"
        Me.ucrReceiverLines.Selector = Nothing
        Me.ucrReceiverLines.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverLines.strNcFilePath = ""
        Me.ucrReceiverLines.TabIndex = 5
        Me.ucrReceiverLines.ucrSelector = Nothing
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(13, 383)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(451, 24)
        Me.ucrSave.TabIndex = 13
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(13, 343)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(88, 23)
        Me.ucrChkLegend.TabIndex = 17
        '
        'ucrChkRibbons
        '
        Me.ucrChkRibbons.AutoSize = True
        Me.ucrChkRibbons.Checked = False
        Me.ucrChkRibbons.Location = New System.Drawing.Point(259, 184)
        Me.ucrChkRibbons.Name = "ucrChkRibbons"
        Me.ucrChkRibbons.Size = New System.Drawing.Size(114, 23)
        Me.ucrChkRibbons.TabIndex = 11
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(386, 342)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(82, 21)
        Me.ucrInputStation.TabIndex = 10
        '
        'ucrReceiverFacetBy
        '
        Me.ucrReceiverFacetBy.AutoSize = True
        Me.ucrReceiverFacetBy.frmParent = Me
        Me.ucrReceiverFacetBy.Location = New System.Drawing.Point(259, 343)
        Me.ucrReceiverFacetBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetBy.Name = "ucrReceiverFacetBy"
        Me.ucrReceiverFacetBy.Selector = Nothing
        Me.ucrReceiverFacetBy.Size = New System.Drawing.Size(120, 26)
        Me.ucrReceiverFacetBy.strNcFilePath = ""
        Me.ucrReceiverFacetBy.TabIndex = 9
        Me.ucrReceiverFacetBy.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(260, 328)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(100, 13)
        Me.lblFacetBy.TabIndex = 8
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By (Optional):"
        '
        'UcrInputColour
        '
        Me.UcrInputColour.AddQuotesIfUnrecognised = True
        Me.UcrInputColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputColour.GetSetSelectedIndex = -1
        Me.UcrInputColour.IsReadOnly = False
        Me.UcrInputColour.Location = New System.Drawing.Point(119, 302)
        Me.UcrInputColour.Name = "UcrInputColour"
        Me.UcrInputColour.Size = New System.Drawing.Size(82, 21)
        Me.UcrInputColour.TabIndex = 16
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(119, 342)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(82, 21)
        Me.ucrInputLegendPosition.TabIndex = 18
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.Location = New System.Drawing.Point(13, 266)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(148, 23)
        Me.cmdOptions.TabIndex = 14
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'dlgSeasonalGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 493)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.UcrInputColour)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucrReceiverFacetBy)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrChkRibbons)
        Me.Controls.Add(Me.ucrChkColour)
        Me.Controls.Add(Me.lblXvariable)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrReceiverRibbons)
        Me.Controls.Add(Me.lblLines)
        Me.Controls.Add(Me.ucrReceiverLines)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.rdoBar)
        Me.Controls.Add(Me.rdoLine)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSelectorForSeasonalGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSeasonalGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seasonal Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorForSeasonalGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrChkColour As ucrCheck
    Friend WithEvents lblXvariable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrChkRibbons As ucrCheck
    Friend WithEvents ucrReceiverRibbons As ucrReceiverMultiple
    Friend WithEvents lblLines As Label
    Friend WithEvents ucrReceiverLines As ucrReceiverMultiple
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents UcrInputColour As ucrInputComboBox
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucrReceiverFacetBy As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents cmdOptions As ucrSplitButton
End Class
