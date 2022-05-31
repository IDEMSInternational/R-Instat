<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgThemesSub
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
        Me.TabThemes = New System.Windows.Forms.TabControl()
        Me.tbTitles = New System.Windows.Forms.TabPage()
        Me.ucrThemeTitleYAxis = New instat.ucrELementTextControl()
        Me.ucrThemeTitleXAxis = New instat.ucrELementTextControl()
        Me.ucrPlotTitle = New instat.ucrELementTextControl()
        Me.tbLabels = New System.Windows.Forms.TabPage()
        Me.ucrThemeLeftYAxis = New instat.ucrELementTextControl()
        Me.ucrThemeBottomXAxis = New instat.ucrELementTextControl()
        Me.ucrThemeAxesTickLabels = New instat.ucrELementTextControl()
        Me.tbAxes = New System.Windows.Forms.TabPage()
        Me.ucrYAxisLines = New instat.ucrElementLineControl()
        Me.ucrTickMarksYAxis = New instat.ucrElementLineControl()
        Me.ucrXAxisLines = New instat.ucrElementLineControl()
        Me.ucrTickMarksXAxis = New instat.ucrElementLineControl()
        Me.ucrThemeAxesLines = New instat.ucrElementLineControl()
        Me.ucrTickMarksAxes = New instat.ucrElementLineControl()
        Me.tbPanel = New System.Windows.Forms.TabPage()
        Me.ucrPanelGridMinor = New instat.ucrElementLineControl()
        Me.ucrPanelGridMajor = New instat.ucrElementLineControl()
        Me.ucrPanelGrid = New instat.ucrElementLineControl()
        Me.tbBackground = New System.Windows.Forms.TabPage()
        Me.ucrPanelBackground = New instat.ucrElementRectControl()
        Me.ucrPanelBorder = New instat.ucrElementRectControl()
        Me.tbLegend = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrChkLegTitleTextSize = New instat.ucrCheck()
        Me.grpLegendPosition = New System.Windows.Forms.GroupBox()
        Me.lblYCoord = New System.Windows.Forms.Label()
        Me.lblXCoord = New System.Windows.Forms.Label()
        Me.UcrNud2 = New instat.ucrNud()
        Me.UcrNud1 = New instat.ucrNud()
        Me.ucRdoCoordinated = New instat.ucrRadio()
        Me.ucrrdoSpecific = New instat.ucrRadio()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.lblLegendPosition = New System.Windows.Forms.Label()
        Me.ucrChkRemoveLegend = New instat.ucrCheck()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.TabThemes.SuspendLayout()
        Me.tbTitles.SuspendLayout()
        Me.tbLabels.SuspendLayout()
        Me.tbAxes.SuspendLayout()
        Me.tbPanel.SuspendLayout()
        Me.tbBackground.SuspendLayout()
        Me.tbLegend.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpLegendPosition.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabThemes
        '
        Me.TabThemes.Controls.Add(Me.tbTitles)
        Me.TabThemes.Controls.Add(Me.tbLabels)
        Me.TabThemes.Controls.Add(Me.tbAxes)
        Me.TabThemes.Controls.Add(Me.tbPanel)
        Me.TabThemes.Controls.Add(Me.tbBackground)
        Me.TabThemes.Controls.Add(Me.tbLegend)
        Me.TabThemes.Location = New System.Drawing.Point(2, 3)
        Me.TabThemes.Name = "TabThemes"
        Me.TabThemes.SelectedIndex = 0
        Me.TabThemes.Size = New System.Drawing.Size(527, 487)
        Me.TabThemes.TabIndex = 0
        '
        'tbTitles
        '
        Me.tbTitles.Controls.Add(Me.ucrThemeTitleYAxis)
        Me.tbTitles.Controls.Add(Me.ucrThemeTitleXAxis)
        Me.tbTitles.Controls.Add(Me.ucrPlotTitle)
        Me.tbTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbTitles.Name = "tbTitles"
        Me.tbTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTitles.Size = New System.Drawing.Size(519, 461)
        Me.tbTitles.TabIndex = 0
        Me.tbTitles.Text = "Titles"
        Me.tbTitles.UseVisualStyleBackColor = True
        '
        'ucrThemeTitleYAxis
        '
        Me.ucrThemeTitleYAxis.AutoSize = True
        Me.ucrThemeTitleYAxis.Location = New System.Drawing.Point(0, 228)
        Me.ucrThemeTitleYAxis.Name = "ucrThemeTitleYAxis"
        Me.ucrThemeTitleYAxis.Size = New System.Drawing.Size(259, 227)
        Me.ucrThemeTitleYAxis.TabIndex = 3
        '
        'ucrThemeTitleXAxis
        '
        Me.ucrThemeTitleXAxis.AutoSize = True
        Me.ucrThemeTitleXAxis.Location = New System.Drawing.Point(259, 3)
        Me.ucrThemeTitleXAxis.Name = "ucrThemeTitleXAxis"
        Me.ucrThemeTitleXAxis.Size = New System.Drawing.Size(260, 231)
        Me.ucrThemeTitleXAxis.TabIndex = 2
        '
        'ucrPlotTitle
        '
        Me.ucrPlotTitle.AutoSize = True
        Me.ucrPlotTitle.Location = New System.Drawing.Point(0, 3)
        Me.ucrPlotTitle.Name = "ucrPlotTitle"
        Me.ucrPlotTitle.Size = New System.Drawing.Size(255, 226)
        Me.ucrPlotTitle.TabIndex = 1
        '
        'tbLabels
        '
        Me.tbLabels.Controls.Add(Me.ucrThemeLeftYAxis)
        Me.tbLabels.Controls.Add(Me.ucrThemeBottomXAxis)
        Me.tbLabels.Controls.Add(Me.ucrThemeAxesTickLabels)
        Me.tbLabels.Location = New System.Drawing.Point(4, 22)
        Me.tbLabels.Name = "tbLabels"
        Me.tbLabels.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLabels.Size = New System.Drawing.Size(519, 461)
        Me.tbLabels.TabIndex = 1
        Me.tbLabels.Text = "Labels"
        Me.tbLabels.UseVisualStyleBackColor = True
        '
        'ucrThemeLeftYAxis
        '
        Me.ucrThemeLeftYAxis.AutoSize = True
        Me.ucrThemeLeftYAxis.Location = New System.Drawing.Point(254, 32)
        Me.ucrThemeLeftYAxis.Name = "ucrThemeLeftYAxis"
        Me.ucrThemeLeftYAxis.Size = New System.Drawing.Size(259, 226)
        Me.ucrThemeLeftYAxis.TabIndex = 4
        '
        'ucrThemeBottomXAxis
        '
        Me.ucrThemeBottomXAxis.AutoSize = True
        Me.ucrThemeBottomXAxis.Location = New System.Drawing.Point(0, 32)
        Me.ucrThemeBottomXAxis.Name = "ucrThemeBottomXAxis"
        Me.ucrThemeBottomXAxis.Size = New System.Drawing.Size(259, 226)
        Me.ucrThemeBottomXAxis.TabIndex = 3
        '
        'ucrThemeAxesTickLabels
        '
        Me.ucrThemeAxesTickLabels.AutoSize = True
        Me.ucrThemeAxesTickLabels.Location = New System.Drawing.Point(0, 32)
        Me.ucrThemeAxesTickLabels.Name = "ucrThemeAxesTickLabels"
        Me.ucrThemeAxesTickLabels.Size = New System.Drawing.Size(255, 228)
        Me.ucrThemeAxesTickLabels.TabIndex = 2
        '
        'tbAxes
        '
        Me.tbAxes.Controls.Add(Me.ucrYAxisLines)
        Me.tbAxes.Controls.Add(Me.ucrTickMarksYAxis)
        Me.tbAxes.Controls.Add(Me.ucrXAxisLines)
        Me.tbAxes.Controls.Add(Me.ucrTickMarksXAxis)
        Me.tbAxes.Controls.Add(Me.ucrThemeAxesLines)
        Me.tbAxes.Controls.Add(Me.ucrTickMarksAxes)
        Me.tbAxes.Location = New System.Drawing.Point(4, 22)
        Me.tbAxes.Name = "tbAxes"
        Me.tbAxes.Size = New System.Drawing.Size(519, 461)
        Me.tbAxes.TabIndex = 2
        Me.tbAxes.Text = "Axes"
        Me.tbAxes.UseVisualStyleBackColor = True
        '
        'ucrYAxisLines
        '
        Me.ucrYAxisLines.AutoSize = True
        Me.ucrYAxisLines.Location = New System.Drawing.Point(260, 197)
        Me.ucrYAxisLines.Name = "ucrYAxisLines"
        Me.ucrYAxisLines.Size = New System.Drawing.Size(254, 124)
        Me.ucrYAxisLines.TabIndex = 1
        '
        'ucrTickMarksYAxis
        '
        Me.ucrTickMarksYAxis.AutoSize = True
        Me.ucrTickMarksYAxis.Location = New System.Drawing.Point(258, 32)
        Me.ucrTickMarksYAxis.Name = "ucrTickMarksYAxis"
        Me.ucrTickMarksYAxis.Size = New System.Drawing.Size(255, 123)
        Me.ucrTickMarksYAxis.TabIndex = 0
        '
        'ucrXAxisLines
        '
        Me.ucrXAxisLines.AutoSize = True
        Me.ucrXAxisLines.Location = New System.Drawing.Point(0, 197)
        Me.ucrXAxisLines.Name = "ucrXAxisLines"
        Me.ucrXAxisLines.Size = New System.Drawing.Size(254, 124)
        Me.ucrXAxisLines.TabIndex = 1
        '
        'ucrTickMarksXAxis
        '
        Me.ucrTickMarksXAxis.AutoSize = True
        Me.ucrTickMarksXAxis.Location = New System.Drawing.Point(0, 32)
        Me.ucrTickMarksXAxis.Name = "ucrTickMarksXAxis"
        Me.ucrTickMarksXAxis.Size = New System.Drawing.Size(254, 124)
        Me.ucrTickMarksXAxis.TabIndex = 0
        '
        'ucrThemeAxesLines
        '
        Me.ucrThemeAxesLines.AutoSize = True
        Me.ucrThemeAxesLines.Location = New System.Drawing.Point(3, 197)
        Me.ucrThemeAxesLines.Name = "ucrThemeAxesLines"
        Me.ucrThemeAxesLines.Size = New System.Drawing.Size(253, 122)
        Me.ucrThemeAxesLines.TabIndex = 8
        '
        'ucrTickMarksAxes
        '
        Me.ucrTickMarksAxes.AutoSize = True
        Me.ucrTickMarksAxes.Location = New System.Drawing.Point(3, 32)
        Me.ucrTickMarksAxes.Name = "ucrTickMarksAxes"
        Me.ucrTickMarksAxes.Size = New System.Drawing.Size(257, 122)
        Me.ucrTickMarksAxes.TabIndex = 4
        '
        'tbPanel
        '
        Me.tbPanel.Controls.Add(Me.ucrPanelGridMinor)
        Me.tbPanel.Controls.Add(Me.ucrPanelGridMajor)
        Me.tbPanel.Controls.Add(Me.ucrPanelGrid)
        Me.tbPanel.Location = New System.Drawing.Point(4, 22)
        Me.tbPanel.Name = "tbPanel"
        Me.tbPanel.Size = New System.Drawing.Size(519, 461)
        Me.tbPanel.TabIndex = 3
        Me.tbPanel.Text = "Panel"
        Me.tbPanel.UseVisualStyleBackColor = True
        '
        'ucrPanelGridMinor
        '
        Me.ucrPanelGridMinor.AutoSize = True
        Me.ucrPanelGridMinor.Location = New System.Drawing.Point(261, 31)
        Me.ucrPanelGridMinor.Name = "ucrPanelGridMinor"
        Me.ucrPanelGridMinor.Size = New System.Drawing.Size(254, 124)
        Me.ucrPanelGridMinor.TabIndex = 4
        '
        'ucrPanelGridMajor
        '
        Me.ucrPanelGridMajor.AutoSize = True
        Me.ucrPanelGridMajor.Location = New System.Drawing.Point(6, 31)
        Me.ucrPanelGridMajor.Name = "ucrPanelGridMajor"
        Me.ucrPanelGridMajor.Size = New System.Drawing.Size(254, 124)
        Me.ucrPanelGridMajor.TabIndex = 3
        '
        'ucrPanelGrid
        '
        Me.ucrPanelGrid.AutoSize = True
        Me.ucrPanelGrid.Location = New System.Drawing.Point(3, 31)
        Me.ucrPanelGrid.Name = "ucrPanelGrid"
        Me.ucrPanelGrid.Size = New System.Drawing.Size(254, 124)
        Me.ucrPanelGrid.TabIndex = 2
        '
        'tbBackground
        '
        Me.tbBackground.Controls.Add(Me.ucrPanelBackground)
        Me.tbBackground.Controls.Add(Me.ucrPanelBorder)
        Me.tbBackground.Location = New System.Drawing.Point(4, 22)
        Me.tbBackground.Name = "tbBackground"
        Me.tbBackground.Size = New System.Drawing.Size(519, 461)
        Me.tbBackground.TabIndex = 4
        Me.tbBackground.Text = "Background"
        Me.tbBackground.UseVisualStyleBackColor = True
        '
        'ucrPanelBackground
        '
        Me.ucrPanelBackground.AutoSize = True
        Me.ucrPanelBackground.Location = New System.Drawing.Point(0, 144)
        Me.ucrPanelBackground.Name = "ucrPanelBackground"
        Me.ucrPanelBackground.Size = New System.Drawing.Size(253, 132)
        Me.ucrPanelBackground.TabIndex = 1
        '
        'ucrPanelBorder
        '
        Me.ucrPanelBorder.AutoSize = True
        Me.ucrPanelBorder.Location = New System.Drawing.Point(0, 6)
        Me.ucrPanelBorder.Name = "ucrPanelBorder"
        Me.ucrPanelBorder.Size = New System.Drawing.Size(253, 132)
        Me.ucrPanelBorder.TabIndex = 0
        '
        'tbLegend
        '
        Me.tbLegend.Controls.Add(Me.GroupBox1)
        Me.tbLegend.Controls.Add(Me.grpLegendPosition)
        Me.tbLegend.Controls.Add(Me.ucrChkRemoveLegend)
        Me.tbLegend.Location = New System.Drawing.Point(4, 22)
        Me.tbLegend.Name = "tbLegend"
        Me.tbLegend.Size = New System.Drawing.Size(519, 461)
        Me.tbLegend.TabIndex = 5
        Me.tbLegend.Text = "Legend"
        Me.tbLegend.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrChkLegTitleTextSize)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ucrChkLegTitleTextSize
        '
        Me.ucrChkLegTitleTextSize.AutoSize = True
        Me.ucrChkLegTitleTextSize.Checked = False
        Me.ucrChkLegTitleTextSize.Location = New System.Drawing.Point(3, 19)
        Me.ucrChkLegTitleTextSize.Name = "ucrChkLegTitleTextSize"
        Me.ucrChkLegTitleTextSize.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkLegTitleTextSize.TabIndex = 5
        '
        'grpLegendPosition
        '
        Me.grpLegendPosition.Controls.Add(Me.lblYCoord)
        Me.grpLegendPosition.Controls.Add(Me.lblXCoord)
        Me.grpLegendPosition.Controls.Add(Me.UcrNud2)
        Me.grpLegendPosition.Controls.Add(Me.UcrNud1)
        Me.grpLegendPosition.Controls.Add(Me.ucRdoCoordinated)
        Me.grpLegendPosition.Controls.Add(Me.ucrrdoSpecific)
        Me.grpLegendPosition.Controls.Add(Me.UcrInputComboBox1)
        Me.grpLegendPosition.Controls.Add(Me.lblLegendPosition)
        Me.grpLegendPosition.Location = New System.Drawing.Point(6, 36)
        Me.grpLegendPosition.Name = "grpLegendPosition"
        Me.grpLegendPosition.Size = New System.Drawing.Size(413, 84)
        Me.grpLegendPosition.TabIndex = 3
        Me.grpLegendPosition.TabStop = False
        Me.grpLegendPosition.Text = "Legend Position"
        '
        'lblYCoord
        '
        Me.lblYCoord.AutoSize = True
        Me.lblYCoord.Location = New System.Drawing.Point(329, 52)
        Me.lblYCoord.Name = "lblYCoord"
        Me.lblYCoord.Size = New System.Drawing.Size(15, 13)
        Me.lblYCoord.TabIndex = 8
        Me.lblYCoord.Text = "y:"
        '
        'lblXCoord
        '
        Me.lblXCoord.AutoSize = True
        Me.lblXCoord.Location = New System.Drawing.Point(239, 52)
        Me.lblXCoord.Name = "lblXCoord"
        Me.lblXCoord.Size = New System.Drawing.Size(15, 13)
        Me.lblXCoord.TabIndex = 7
        Me.lblXCoord.Text = "x:"
        '
        'UcrNud2
        '
        Me.UcrNud2.AutoSize = True
        Me.UcrNud2.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud2.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud2.Location = New System.Drawing.Point(348, 52)
        Me.UcrNud2.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud2.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud2.Name = "UcrNud2"
        Me.UcrNud2.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud2.TabIndex = 6
        Me.UcrNud2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNud1
        '
        Me.UcrNud1.AutoSize = True
        Me.UcrNud1.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud1.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud1.Location = New System.Drawing.Point(258, 51)
        Me.UcrNud1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud1.Name = "UcrNud1"
        Me.UcrNud1.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud1.TabIndex = 4
        Me.UcrNud1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucRdoCoordinated
        '
        Me.ucRdoCoordinated.AutoSize = True
        Me.ucRdoCoordinated.Location = New System.Drawing.Point(220, 19)
        Me.ucRdoCoordinated.Name = "ucRdoCoordinated"
        Me.ucRdoCoordinated.Size = New System.Drawing.Size(100, 20)
        Me.ucRdoCoordinated.TabIndex = 5
        '
        'ucrrdoSpecific
        '
        Me.ucrrdoSpecific.AutoSize = True
        Me.ucrrdoSpecific.Location = New System.Drawing.Point(9, 19)
        Me.ucrrdoSpecific.Name = "ucrrdoSpecific"
        Me.ucrrdoSpecific.Size = New System.Drawing.Size(100, 20)
        Me.ucrrdoSpecific.TabIndex = 4
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputComboBox1.GetSetSelectedIndex = -1
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(59, 51)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox1.TabIndex = 0
        '
        'lblLegendPosition
        '
        Me.lblLegendPosition.AutoSize = True
        Me.lblLegendPosition.Location = New System.Drawing.Point(6, 52)
        Me.lblLegendPosition.Name = "lblLegendPosition"
        Me.lblLegendPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblLegendPosition.TabIndex = 1
        Me.lblLegendPosition.Text = "Position:"
        '
        'ucrChkRemoveLegend
        '
        Me.ucrChkRemoveLegend.AutoSize = True
        Me.ucrChkRemoveLegend.Checked = False
        Me.ucrChkRemoveLegend.Location = New System.Drawing.Point(9, 10)
        Me.ucrChkRemoveLegend.Name = "ucrChkRemoveLegend"
        Me.ucrChkRemoveLegend.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkRemoveLegend.TabIndex = 2
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(182, 494)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSubdialog.TabIndex = 2
        '
        'sdgThemesSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(531, 529)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.TabThemes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgThemesSub"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Themes"
        Me.TabThemes.ResumeLayout(False)
        Me.tbTitles.ResumeLayout(False)
        Me.tbTitles.PerformLayout()
        Me.tbLabels.ResumeLayout(False)
        Me.tbLabels.PerformLayout()
        Me.tbAxes.ResumeLayout(False)
        Me.tbAxes.PerformLayout()
        Me.tbPanel.ResumeLayout(False)
        Me.tbPanel.PerformLayout()
        Me.tbBackground.ResumeLayout(False)
        Me.tbBackground.PerformLayout()
        Me.tbLegend.ResumeLayout(False)
        Me.tbLegend.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpLegendPosition.ResumeLayout(False)
        Me.grpLegendPosition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabThemes As TabControl
    Friend WithEvents tbTitles As TabPage
    Friend WithEvents tbLabels As TabPage
    Friend WithEvents tbAxes As TabPage
    Friend WithEvents tbPanel As TabPage
    Friend WithEvents tbBackground As TabPage
    Friend WithEvents tbLegend As TabPage
    Friend WithEvents ucrPlotTitle As ucrELementTextControl
    Friend WithEvents ucrThemeTitleXAxis As ucrELementTextControl
    Friend WithEvents ucrThemeTitleYAxis As ucrELementTextControl
    Friend WithEvents ucrThemeAxesTickLabels As ucrELementTextControl
    Friend WithEvents ucrThemeBottomXAxis As ucrELementTextControl
    Friend WithEvents ucrThemeLeftYAxis As ucrELementTextControl
    Friend WithEvents ucrTickMarksAxes As ucrElementLineControl
    Friend WithEvents ucrThemeAxesLines As ucrElementLineControl
    Friend WithEvents ucrXAxisLines As ucrElementLineControl
    Friend WithEvents ucrTickMarksXAxis As ucrElementLineControl
    Friend WithEvents ucrYAxisLines As ucrElementLineControl
    Friend WithEvents ucrTickMarksYAxis As ucrElementLineControl
    Friend WithEvents ucrPanelGrid As ucrElementLineControl
    Friend WithEvents ucrPanelGridMajor As ucrElementLineControl
    Friend WithEvents ucrPanelGridMinor As ucrElementLineControl
    Friend WithEvents ucrPanelBackground As ucrElementRectControl
    Friend WithEvents ucrPanelBorder As ucrElementRectControl
    Friend WithEvents grpLegendPosition As GroupBox
    Friend WithEvents lblYCoord As Label
    Friend WithEvents lblXCoord As Label
    Friend WithEvents UcrNud2 As ucrNud
    Friend WithEvents UcrNud1 As ucrNud
    Friend WithEvents ucRdoCoordinated As ucrRadio
    Friend WithEvents ucrrdoSpecific As ucrRadio
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents lblLegendPosition As Label
    Friend WithEvents ucrChkRemoveLegend As ucrCheck
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrChkLegTitleTextSize As ucrCheck
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
End Class
