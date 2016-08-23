<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgPlots
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
        Me.tabctrlBoxSubdialog = New System.Windows.Forms.TabControl()
        Me.tabFacet = New System.Windows.Forms.TabPage()
        Me.ucrFacetSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.nudNoOfRowsOrColumns = New System.Windows.Forms.NumericUpDown()
        Me.chkNoOfRowsOrColumns = New System.Windows.Forms.CheckBox()
        Me.chkIncludeFacets = New System.Windows.Forms.CheckBox()
        Me.chkFreeScalesY = New System.Windows.Forms.CheckBox()
        Me.chkMargin = New System.Windows.Forms.CheckBox()
        Me.chkFreeScalesX = New System.Windows.Forms.CheckBox()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.lblFactor2 = New System.Windows.Forms.Label()
        Me.lblFactor1 = New System.Windows.Forms.Label()
        Me.ucr2ndFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.tabLayers = New System.Windows.Forms.TabPage()
        Me.ucrPlotsAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.tabTitles = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.grpLegendTitle = New System.Windows.Forms.GroupBox()
        Me.rdoLegendTitleCustom = New System.Windows.Forms.RadioButton()
        Me.chkDisplayLegendTitle = New System.Windows.Forms.CheckBox()
        Me.chkOverwriteLegendTitle = New System.Windows.Forms.CheckBox()
        Me.txtOverwriteLegendTitle = New instat.ucrInputTextBox()
        Me.rdoLegendTitleAuto = New System.Windows.Forms.RadioButton()
        Me.tbpXAxis = New System.Windows.Forms.TabPage()
        Me.ucrXAxis = New instat.ucrAxes()
        Me.tbpYAxis = New System.Windows.Forms.TabPage()
        Me.ucrYAxis = New instat.ucrAxes()
        Me.tabTheme = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.cmdAllOptions = New System.Windows.Forms.Button()
        Me.ucrInputThemes = New instat.ucrInputComboBox()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tabctrlBoxSubdialog.SuspendLayout()
        Me.tabFacet.SuspendLayout()
        CType(Me.nudNoOfRowsOrColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLayers.SuspendLayout()
        Me.tabTitles.SuspendLayout()
        Me.grpLegendTitle.SuspendLayout()
        Me.tbpXAxis.SuspendLayout()
        Me.tbpYAxis.SuspendLayout()
        Me.tabTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabctrlBoxSubdialog
        '
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabFacet)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabLayers)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabTitles)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tbpXAxis)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tbpYAxis)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabTheme)
        Me.tabctrlBoxSubdialog.Location = New System.Drawing.Point(1, 3)
        Me.tabctrlBoxSubdialog.Name = "tabctrlBoxSubdialog"
        Me.tabctrlBoxSubdialog.SelectedIndex = 0
        Me.tabctrlBoxSubdialog.Size = New System.Drawing.Size(480, 330)
        Me.tabctrlBoxSubdialog.TabIndex = 0
        '
        'tabFacet
        '
        Me.tabFacet.Controls.Add(Me.ucrFacetSelector)
        Me.tabFacet.Controls.Add(Me.nudNoOfRowsOrColumns)
        Me.tabFacet.Controls.Add(Me.chkNoOfRowsOrColumns)
        Me.tabFacet.Controls.Add(Me.chkIncludeFacets)
        Me.tabFacet.Controls.Add(Me.chkFreeScalesY)
        Me.tabFacet.Controls.Add(Me.chkMargin)
        Me.tabFacet.Controls.Add(Me.chkFreeScalesX)
        Me.tabFacet.Controls.Add(Me.rdoHorizontal)
        Me.tabFacet.Controls.Add(Me.rdoVertical)
        Me.tabFacet.Controls.Add(Me.lblFactor2)
        Me.tabFacet.Controls.Add(Me.lblFactor1)
        Me.tabFacet.Controls.Add(Me.ucr2ndFactorReceiver)
        Me.tabFacet.Controls.Add(Me.ucr1stFactorReceiver)
        Me.tabFacet.Location = New System.Drawing.Point(4, 22)
        Me.tabFacet.Name = "tabFacet"
        Me.tabFacet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFacet.Size = New System.Drawing.Size(472, 304)
        Me.tabFacet.TabIndex = 3
        Me.tabFacet.Tag = "Facet"
        Me.tabFacet.Text = "Facet"
        Me.tabFacet.UseVisualStyleBackColor = True
        '
        'ucrFacetSelector
        '
        Me.ucrFacetSelector.bShowHiddenColumns = False
        Me.ucrFacetSelector.Location = New System.Drawing.Point(8, 36)
        Me.ucrFacetSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFacetSelector.Name = "ucrFacetSelector"
        Me.ucrFacetSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrFacetSelector.TabIndex = 20
        '
        'nudNoOfRowsOrColumns
        '
        Me.nudNoOfRowsOrColumns.Location = New System.Drawing.Point(172, 262)
        Me.nudNoOfRowsOrColumns.Name = "nudNoOfRowsOrColumns"
        Me.nudNoOfRowsOrColumns.Size = New System.Drawing.Size(39, 20)
        Me.nudNoOfRowsOrColumns.TabIndex = 19
        '
        'chkNoOfRowsOrColumns
        '
        Me.chkNoOfRowsOrColumns.AutoSize = True
        Me.chkNoOfRowsOrColumns.Location = New System.Drawing.Point(8, 264)
        Me.chkNoOfRowsOrColumns.Name = "chkNoOfRowsOrColumns"
        Me.chkNoOfRowsOrColumns.Size = New System.Drawing.Size(133, 17)
        Me.chkNoOfRowsOrColumns.TabIndex = 18
        Me.chkNoOfRowsOrColumns.Text = "Fixed Number of Rows"
        Me.chkNoOfRowsOrColumns.UseVisualStyleBackColor = True
        '
        'chkIncludeFacets
        '
        Me.chkIncludeFacets.AutoSize = True
        Me.chkIncludeFacets.Location = New System.Drawing.Point(8, 11)
        Me.chkIncludeFacets.Name = "chkIncludeFacets"
        Me.chkIncludeFacets.Size = New System.Drawing.Size(96, 17)
        Me.chkIncludeFacets.TabIndex = 16
        Me.chkIncludeFacets.Tag = "Include_Facets"
        Me.chkIncludeFacets.Text = "Include Facets"
        Me.chkIncludeFacets.UseVisualStyleBackColor = True
        '
        'chkFreeScalesY
        '
        Me.chkFreeScalesY.AutoSize = True
        Me.chkFreeScalesY.Location = New System.Drawing.Point(273, 264)
        Me.chkFreeScalesY.Name = "chkFreeScalesY"
        Me.chkFreeScalesY.Size = New System.Drawing.Size(114, 17)
        Me.chkFreeScalesY.TabIndex = 14
        Me.chkFreeScalesY.Tag = "Free_scales"
        Me.chkFreeScalesY.Text = "Free Scales Y-Axis"
        Me.chkFreeScalesY.UseVisualStyleBackColor = True
        '
        'chkMargin
        '
        Me.chkMargin.AutoSize = True
        Me.chkMargin.Location = New System.Drawing.Point(273, 199)
        Me.chkMargin.Name = "chkMargin"
        Me.chkMargin.Size = New System.Drawing.Size(63, 17)
        Me.chkMargin.TabIndex = 13
        Me.chkMargin.Text = "Margins"
        Me.chkMargin.UseVisualStyleBackColor = True
        '
        'chkFreeScalesX
        '
        Me.chkFreeScalesX.AutoSize = True
        Me.chkFreeScalesX.Location = New System.Drawing.Point(273, 231)
        Me.chkFreeScalesX.Name = "chkFreeScalesX"
        Me.chkFreeScalesX.Size = New System.Drawing.Size(114, 17)
        Me.chkFreeScalesX.TabIndex = 12
        Me.chkFreeScalesX.Tag = "Free_scales"
        Me.chkFreeScalesX.Text = "Free Scales X-Axis"
        Me.chkFreeScalesX.UseVisualStyleBackColor = True
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.AutoSize = True
        Me.rdoHorizontal.Location = New System.Drawing.Point(8, 231)
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.rdoHorizontal.TabIndex = 7
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.Text = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        Me.rdoVertical.AutoSize = True
        Me.rdoVertical.Location = New System.Drawing.Point(104, 231)
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.Size = New System.Drawing.Size(60, 17)
        Me.rdoVertical.TabIndex = 6
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.Text = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'lblFactor2
        '
        Me.lblFactor2.AutoSize = True
        Me.lblFactor2.Location = New System.Drawing.Point(270, 133)
        Me.lblFactor2.Name = "lblFactor2"
        Me.lblFactor2.Size = New System.Drawing.Size(106, 13)
        Me.lblFactor2.TabIndex = 4
        Me.lblFactor2.Text = "2nd Factor (Optional)"
        '
        'lblFactor1
        '
        Me.lblFactor1.AutoSize = True
        Me.lblFactor1.Location = New System.Drawing.Point(270, 80)
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Size = New System.Drawing.Size(54, 13)
        Me.lblFactor1.TabIndex = 3
        Me.lblFactor1.Tag = ""
        Me.lblFactor1.Text = "1st Factor"
        '
        'ucr2ndFactorReceiver
        '
        Me.ucr2ndFactorReceiver.Location = New System.Drawing.Point(273, 148)
        Me.ucr2ndFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr2ndFactorReceiver.Name = "ucr2ndFactorReceiver"
        Me.ucr2ndFactorReceiver.Selector = Nothing
        Me.ucr2ndFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr2ndFactorReceiver.TabIndex = 2
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(273, 93)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr1stFactorReceiver.TabIndex = 1
        '
        'tabLayers
        '
        Me.tabLayers.Controls.Add(Me.ucrPlotsAdditionalLayers)
        Me.tabLayers.Location = New System.Drawing.Point(4, 22)
        Me.tabLayers.Name = "tabLayers"
        Me.tabLayers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLayers.Size = New System.Drawing.Size(472, 304)
        Me.tabLayers.TabIndex = 4
        Me.tabLayers.Tag = "Layers"
        Me.tabLayers.Text = "Layers"
        Me.tabLayers.UseVisualStyleBackColor = True
        '
        'ucrPlotsAdditionalLayers
        '
        Me.ucrPlotsAdditionalLayers.Location = New System.Drawing.Point(6, 6)
        Me.ucrPlotsAdditionalLayers.Name = "ucrPlotsAdditionalLayers"
        Me.ucrPlotsAdditionalLayers.Size = New System.Drawing.Size(218, 191)
        Me.ucrPlotsAdditionalLayers.TabIndex = 0
        '
        'tabTitles
        '
        Me.tabTitles.Controls.Add(Me.Label1)
        Me.tabTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.tabTitles.Controls.Add(Me.grpLegendTitle)
        Me.tabTitles.Location = New System.Drawing.Point(4, 22)
        Me.tabTitles.Name = "tabTitles"
        Me.tabTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTitles.Size = New System.Drawing.Size(472, 304)
        Me.tabTitles.TabIndex = 2
        Me.tabTitles.Tag = "Titles"
        Me.tabTitles.Text = "Titles"
        Me.tabTitles.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Graph Title"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(72, 29)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(170, 21)
        Me.ucrInputGraphTitle.TabIndex = 9
        '
        'grpLegendTitle
        '
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleCustom)
        Me.grpLegendTitle.Controls.Add(Me.chkDisplayLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.chkOverwriteLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.txtOverwriteLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleAuto)
        Me.grpLegendTitle.Location = New System.Drawing.Point(7, 81)
        Me.grpLegendTitle.Name = "grpLegendTitle"
        Me.grpLegendTitle.Size = New System.Drawing.Size(278, 130)
        Me.grpLegendTitle.TabIndex = 8
        Me.grpLegendTitle.TabStop = False
        Me.grpLegendTitle.Text = "Legend Title"
        '
        'rdoLegendTitleCustom
        '
        Me.rdoLegendTitleCustom.AutoSize = True
        Me.rdoLegendTitleCustom.Location = New System.Drawing.Point(61, 23)
        Me.rdoLegendTitleCustom.Name = "rdoLegendTitleCustom"
        Me.rdoLegendTitleCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoLegendTitleCustom.TabIndex = 10
        Me.rdoLegendTitleCustom.TabStop = True
        Me.rdoLegendTitleCustom.Text = "Custom"
        Me.rdoLegendTitleCustom.UseVisualStyleBackColor = True
        '
        'chkDisplayLegendTitle
        '
        Me.chkDisplayLegendTitle.AutoSize = True
        Me.chkDisplayLegendTitle.Location = New System.Drawing.Point(6, 61)
        Me.chkDisplayLegendTitle.Name = "chkDisplayLegendTitle"
        Me.chkDisplayLegendTitle.Size = New System.Drawing.Size(60, 17)
        Me.chkDisplayLegendTitle.TabIndex = 7
        Me.chkDisplayLegendTitle.Text = "Display"
        Me.chkDisplayLegendTitle.UseVisualStyleBackColor = True
        '
        'chkOverwriteLegendTitle
        '
        Me.chkOverwriteLegendTitle.AutoSize = True
        Me.chkOverwriteLegendTitle.Location = New System.Drawing.Point(6, 94)
        Me.chkOverwriteLegendTitle.Name = "chkOverwriteLegendTitle"
        Me.chkOverwriteLegendTitle.Size = New System.Drawing.Size(94, 17)
        Me.chkOverwriteLegendTitle.TabIndex = 3
        Me.chkOverwriteLegendTitle.Text = "Overwrite Title"
        Me.chkOverwriteLegendTitle.UseVisualStyleBackColor = True
        '
        'txtOverwriteLegendTitle
        '
        Me.txtOverwriteLegendTitle.IsReadOnly = False
        Me.txtOverwriteLegendTitle.Location = New System.Drawing.Point(100, 92)
        Me.txtOverwriteLegendTitle.Name = "txtOverwriteLegendTitle"
        Me.txtOverwriteLegendTitle.Size = New System.Drawing.Size(170, 21)
        Me.txtOverwriteLegendTitle.TabIndex = 4
        '
        'rdoLegendTitleAuto
        '
        Me.rdoLegendTitleAuto.AutoSize = True
        Me.rdoLegendTitleAuto.Location = New System.Drawing.Point(6, 23)
        Me.rdoLegendTitleAuto.Name = "rdoLegendTitleAuto"
        Me.rdoLegendTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoLegendTitleAuto.TabIndex = 9
        Me.rdoLegendTitleAuto.TabStop = True
        Me.rdoLegendTitleAuto.Text = "Auto"
        Me.rdoLegendTitleAuto.UseVisualStyleBackColor = True
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.ucrXAxis)
        Me.tbpXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpXAxis.Size = New System.Drawing.Size(472, 304)
        Me.tbpXAxis.TabIndex = 5
        Me.tbpXAxis.Text = "X-Axis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'ucrXAxis
        '
        Me.ucrXAxis.Location = New System.Drawing.Point(0, 3)
        Me.ucrXAxis.Name = "ucrXAxis"
        Me.ucrXAxis.Size = New System.Drawing.Size(470, 300)
        Me.ucrXAxis.TabIndex = 0
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.ucrYAxis)
        Me.tbpYAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpYAxis.Size = New System.Drawing.Size(472, 304)
        Me.tbpYAxis.TabIndex = 6
        Me.tbpYAxis.Text = "Y-Axis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'ucrYAxis
        '
        Me.ucrYAxis.Location = New System.Drawing.Point(0, 1)
        Me.ucrYAxis.Name = "ucrYAxis"
        Me.ucrYAxis.Size = New System.Drawing.Size(470, 300)
        Me.ucrYAxis.TabIndex = 0
        '
        'tabTheme
        '
        Me.tabTheme.Controls.Add(Me.GroupBox1)
        Me.tabTheme.Controls.Add(Me.lblFont)
        Me.tabTheme.Controls.Add(Me.cmdAllOptions)
        Me.tabTheme.Controls.Add(Me.ucrInputThemes)
        Me.tabTheme.Controls.Add(Me.lblTheme)
        Me.tabTheme.Location = New System.Drawing.Point(4, 22)
        Me.tabTheme.Name = "tabTheme"
        Me.tabTheme.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTheme.Size = New System.Drawing.Size(472, 304)
        Me.tabTheme.TabIndex = 1
        Me.tabTheme.Tag = "Theme"
        Me.tabTheme.Text = "Theme"
        Me.tabTheme.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 223)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Common Options"
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(233, 49)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(0, 13)
        Me.lblFont.TabIndex = 4
        '
        'cmdAllOptions
        '
        Me.cmdAllOptions.Location = New System.Drawing.Point(275, 18)
        Me.cmdAllOptions.Name = "cmdAllOptions"
        Me.cmdAllOptions.Size = New System.Drawing.Size(78, 23)
        Me.cmdAllOptions.TabIndex = 2
        Me.cmdAllOptions.Text = "All Options"
        Me.cmdAllOptions.UseVisualStyleBackColor = True
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.IsReadOnly = False
        Me.ucrInputThemes.Location = New System.Drawing.Point(87, 19)
        Me.ucrInputThemes.Name = "ucrInputThemes"
        Me.ucrInputThemes.Size = New System.Drawing.Size(171, 21)
        Me.ucrInputThemes.TabIndex = 1
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(8, 22)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(73, 13)
        Me.lblTheme.TabIndex = 0
        Me.lblTheme.Text = "Select Theme"
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(157, 330)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(160, 41)
        Me.ucrBaseSubdialog.TabIndex = 1
        '
        'sdgPlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 361)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tabctrlBoxSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Plot_Options"
        Me.Text = "Plot Options"
        Me.TopMost = True
        Me.tabctrlBoxSubdialog.ResumeLayout(False)
        Me.tabFacet.ResumeLayout(False)
        Me.tabFacet.PerformLayout()
        CType(Me.nudNoOfRowsOrColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLayers.ResumeLayout(False)
        Me.tabTitles.ResumeLayout(False)
        Me.tabTitles.PerformLayout()
        Me.grpLegendTitle.ResumeLayout(False)
        Me.grpLegendTitle.PerformLayout()
        Me.tbpXAxis.ResumeLayout(False)
        Me.tbpYAxis.ResumeLayout(False)
        Me.tabTheme.ResumeLayout(False)
        Me.tabTheme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabctrlBoxSubdialog As TabControl
    Friend WithEvents tabTheme As TabPage
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tabTitles As TabPage
    Friend WithEvents tabFacet As TabPage
    Friend WithEvents tabLayers As TabPage
    Friend WithEvents chkFreeScalesX As CheckBox
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents lblFactor2 As Label
    Friend WithEvents lblFactor1 As Label
    Friend WithEvents ucr2ndFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents chkMargin As CheckBox
    Friend WithEvents chkFreeScalesY As CheckBox
    Friend WithEvents chkIncludeFacets As CheckBox
    Friend WithEvents tbpXAxis As TabPage
    Friend WithEvents tbpYAxis As TabPage
    Friend WithEvents nudNoOfRowsOrColumns As NumericUpDown
    Friend WithEvents chkNoOfRowsOrColumns As CheckBox
    Friend WithEvents ucrInputThemes As ucrInputComboBox
    Friend WithEvents lblTheme As Label
    Friend WithEvents cmdAllOptions As Button
    Friend WithEvents lblFont As Label
    Friend WithEvents ucrPlotsAdditionalLayers As ucrAdditionalLayers
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkDisplayLegendTitle As CheckBox
    Friend WithEvents txtOverwriteLegendTitle As ucrInputTextBox
    Friend WithEvents chkOverwriteLegendTitle As CheckBox
    Friend WithEvents ucrFacetSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpLegendTitle As GroupBox
    Friend WithEvents rdoLegendTitleCustom As RadioButton
    Friend WithEvents rdoLegendTitleAuto As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrXAxis As ucrAxes
    Friend WithEvents ucrYAxis As ucrAxes
End Class


