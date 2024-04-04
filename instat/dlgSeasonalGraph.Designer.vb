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
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.lblXvariable = New System.Windows.Forms.Label()
        Me.lblLines = New System.Windows.Forms.Label()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrReceiverAddPoint = New instat.ucrReceiverMultiple()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucrReceiverFacetBy = New instat.ucrReceiverSingle()
        Me.ucrChkRibbons = New instat.ucrCheck()
        Me.ucrChkAddPoint = New instat.ucrCheck()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverRibbons = New instat.ucrReceiverMultiple()
        Me.ucrReceiverLines = New instat.ucrReceiverMultiple()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSelectorForSeasonalGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkFill = New instat.ucrCheck()
        Me.ucrChkColour = New instat.ucrCheck()
        Me.ucrInputFill = New instat.ucrInputTextBox()
        Me.ucrInputColour = New instat.ucrInputTextBox()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        'lblXvariable
        '
        Me.lblXvariable.AutoSize = True
        Me.lblXvariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXvariable.Location = New System.Drawing.Point(320, 285)
        Me.lblXvariable.Name = "lblXvariable"
        Me.lblXvariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXvariable.TabIndex = 6
        Me.lblXvariable.Text = "X Variable:"
        '
        'lblLines
        '
        Me.lblLines.AutoSize = True
        Me.lblLines.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLines.Location = New System.Drawing.Point(320, 68)
        Me.lblLines.Name = "lblLines"
        Me.lblLines.Size = New System.Drawing.Size(35, 13)
        Me.lblLines.TabIndex = 4
        Me.lblLines.Text = "Lines:"
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(260, 444)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(100, 13)
        Me.lblFacetBy.TabIndex = 8
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By (Optional):"
        '
        'ucrReceiverAddPoint
        '
        Me.ucrReceiverAddPoint.AutoSize = True
        Me.ucrReceiverAddPoint.frmParent = Me
        Me.ucrReceiverAddPoint.Location = New System.Drawing.Point(319, 352)
        Me.ucrReceiverAddPoint.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAddPoint.Name = "ucrReceiverAddPoint"
        Me.ucrReceiverAddPoint.Selector = Nothing
        Me.ucrReceiverAddPoint.Size = New System.Drawing.Size(120, 75)
        Me.ucrReceiverAddPoint.strNcFilePath = ""
        Me.ucrReceiverAddPoint.TabIndex = 20
        Me.ucrReceiverAddPoint.ucrSelector = Nothing
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
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(119, 458)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(82, 21)
        Me.ucrInputLegendPosition.TabIndex = 18
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(386, 458)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(82, 21)
        Me.ucrInputStation.TabIndex = 10
        '
        'ucrReceiverFacetBy
        '
        Me.ucrReceiverFacetBy.AutoSize = True
        Me.ucrReceiverFacetBy.frmParent = Me
        Me.ucrReceiverFacetBy.Location = New System.Drawing.Point(259, 459)
        Me.ucrReceiverFacetBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetBy.Name = "ucrReceiverFacetBy"
        Me.ucrReceiverFacetBy.Selector = Nothing
        Me.ucrReceiverFacetBy.Size = New System.Drawing.Size(120, 26)
        Me.ucrReceiverFacetBy.strNcFilePath = ""
        Me.ucrReceiverFacetBy.TabIndex = 9
        Me.ucrReceiverFacetBy.ucrSelector = Nothing
        '
        'ucrChkRibbons
        '
        Me.ucrChkRibbons.AutoSize = True
        Me.ucrChkRibbons.Checked = False
        Me.ucrChkRibbons.Location = New System.Drawing.Point(319, 184)
        Me.ucrChkRibbons.Name = "ucrChkRibbons"
        Me.ucrChkRibbons.Size = New System.Drawing.Size(114, 23)
        Me.ucrChkRibbons.TabIndex = 11
        '
        'ucrChkAddPoint
        '
        Me.ucrChkAddPoint.AutoSize = True
        Me.ucrChkAddPoint.Checked = False
        Me.ucrChkAddPoint.Location = New System.Drawing.Point(319, 326)
        Me.ucrChkAddPoint.Name = "ucrChkAddPoint"
        Me.ucrChkAddPoint.Size = New System.Drawing.Size(88, 23)
        Me.ucrChkAddPoint.TabIndex = 15
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(319, 301)
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
        Me.ucrReceiverRibbons.Location = New System.Drawing.Point(319, 207)
        Me.ucrReceiverRibbons.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRibbons.Name = "ucrReceiverRibbons"
        Me.ucrReceiverRibbons.Selector = Nothing
        Me.ucrReceiverRibbons.Size = New System.Drawing.Size(120, 75)
        Me.ucrReceiverRibbons.strNcFilePath = ""
        Me.ucrReceiverRibbons.TabIndex = 12
        Me.ucrReceiverRibbons.ucrSelector = Nothing
        '
        'ucrReceiverLines
        '
        Me.ucrReceiverLines.AutoSize = True
        Me.ucrReceiverLines.frmParent = Me
        Me.ucrReceiverLines.Location = New System.Drawing.Point(319, 82)
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
        Me.ucrSave.Location = New System.Drawing.Point(13, 499)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(451, 24)
        Me.ucrSave.TabIndex = 13
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(13, 459)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(88, 23)
        Me.ucrChkLegend.TabIndex = 17
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(122, 12)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(220, 44)
        Me.ucrPnlOptions.TabIndex = 1
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
        Me.ucrBase.Location = New System.Drawing.Point(22, 544)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 19
        '
        'ucrChkFill
        '
        Me.ucrChkFill.AutoSize = True
        Me.ucrChkFill.Checked = False
        Me.ucrChkFill.Location = New System.Drawing.Point(14, 301)
        Me.ucrChkFill.Name = "ucrChkFill"
        Me.ucrChkFill.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkFill.TabIndex = 21
        '
        'ucrChkColour
        '
        Me.ucrChkColour.AutoSize = True
        Me.ucrChkColour.Checked = False
        Me.ucrChkColour.Location = New System.Drawing.Point(14, 370)
        Me.ucrChkColour.Name = "ucrChkColour"
        Me.ucrChkColour.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkColour.TabIndex = 22
        '
        'ucrInputFill
        '
        Me.ucrInputFill.AddQuotesIfUnrecognised = True
        Me.ucrInputFill.AutoSize = True
        Me.ucrInputFill.IsMultiline = False
        Me.ucrInputFill.IsReadOnly = False
        Me.ucrInputFill.Location = New System.Drawing.Point(64, 326)
        Me.ucrInputFill.Name = "ucrInputFill"
        Me.ucrInputFill.Size = New System.Drawing.Size(205, 23)
        Me.ucrInputFill.TabIndex = 184
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.AutoSize = True
        Me.ucrInputColour.IsMultiline = False
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(64, 395)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(205, 23)
        Me.ucrInputColour.TabIndex = 185
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFill.Location = New System.Drawing.Point(14, 332)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(41, 13)
        Me.lblFill.TabIndex = 186
        Me.lblFill.Text = "Labels:"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColour.Location = New System.Drawing.Point(14, 399)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(41, 13)
        Me.lblColour.TabIndex = 187
        Me.lblColour.Text = "Labels:"
        '
        'dlgSeasonalGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 604)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.ucrInputFill)
        Me.Controls.Add(Me.ucrChkColour)
        Me.Controls.Add(Me.ucrChkFill)
        Me.Controls.Add(Me.ucrReceiverAddPoint)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucrReceiverFacetBy)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrChkRibbons)
        Me.Controls.Add(Me.ucrChkAddPoint)
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
    Friend WithEvents ucrChkAddPoint As ucrCheck
    Friend WithEvents lblXvariable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrChkRibbons As ucrCheck
    Friend WithEvents ucrReceiverRibbons As ucrReceiverMultiple
    Friend WithEvents lblLines As Label
    Friend WithEvents ucrReceiverLines As ucrReceiverMultiple
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucrReceiverFacetBy As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents ucrReceiverAddPoint As ucrReceiverMultiple
    Friend WithEvents ucrChkColour As ucrCheck
    Friend WithEvents ucrChkFill As ucrCheck
    Friend WithEvents lblColour As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrInputColour As ucrInputTextBox
    Friend WithEvents ucrInputFill As ucrInputTextBox
End Class
