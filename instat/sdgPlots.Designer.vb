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
        Me.tabTheme = New System.Windows.Forms.TabPage()
        Me.ucrInputThemes = New instat.ucrInputComboBox()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.tabLegend = New System.Windows.Forms.TabPage()
        Me.grpLabels = New System.Windows.Forms.GroupBox()
        Me.chkReorderLabels = New System.Windows.Forms.CheckBox()
        Me.chkChangeLabels = New System.Windows.Forms.CheckBox()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.txtChangeTitle = New System.Windows.Forms.TextBox()
        Me.chkChangeTitle = New System.Windows.Forms.CheckBox()
        Me.chkDisplayLegend = New System.Windows.Forms.CheckBox()
        Me.tabFacet = New System.Windows.Forms.TabPage()
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.tabLayers = New System.Windows.Forms.TabPage()
        Me.chkConnect = New System.Windows.Forms.CheckBox()
        Me.chkDotPlot = New System.Windows.Forms.CheckBox()
        Me.tbpXAxis = New System.Windows.Forms.TabPage()
        Me.grpTich = New System.Windows.Forms.GroupBox()
        Me.chkSpecificPoints = New System.Windows.Forms.CheckBox()
        Me.txtSpecificPoints = New System.Windows.Forms.TextBox()
        Me.txtIntervals = New System.Windows.Forms.TextBox()
        Me.chkIntervals = New System.Windows.Forms.CheckBox()
        Me.chkXDisplayMarkers = New System.Windows.Forms.CheckBox()
        Me.grpScale = New System.Windows.Forms.GroupBox()
        Me.txtUpperLimit = New System.Windows.Forms.TextBox()
        Me.txtLowerLimit = New System.Windows.Forms.TextBox()
        Me.chkUpperLimit = New System.Windows.Forms.CheckBox()
        Me.chkLowerLimit = New System.Windows.Forms.CheckBox()
        Me.grpXLabel = New System.Windows.Forms.GroupBox()
        Me.cboChangeLabels = New System.Windows.Forms.ComboBox()
        Me.chkChangeXLabels = New System.Windows.Forms.CheckBox()
        Me.chkDisplayLabels = New System.Windows.Forms.CheckBox()
        Me.grpXAxisTitle = New System.Windows.Forms.GroupBox()
        Me.txtXTitle = New System.Windows.Forms.TextBox()
        Me.chkXDisplayTitle = New System.Windows.Forms.CheckBox()
        Me.tbpYAxis = New System.Windows.Forms.TabPage()
        Me.grpYlabels = New System.Windows.Forms.GroupBox()
        Me.cboYChangeLevel = New System.Windows.Forms.ComboBox()
        Me.chkChangeYLabelschkDisplayYLabels = New System.Windows.Forms.CheckBox()
        Me.chkDisplayYLabels = New System.Windows.Forms.CheckBox()
        Me.grpYTitle = New System.Windows.Forms.GroupBox()
        Me.txtYTitle = New System.Windows.Forms.TextBox()
        Me.chkDisplayYTitle = New System.Windows.Forms.CheckBox()
        Me.grpYTich = New System.Windows.Forms.GroupBox()
        Me.chkYSpecificPoints = New System.Windows.Forms.CheckBox()
        Me.txtYSpecificPoints = New System.Windows.Forms.TextBox()
        Me.txtYIntervals = New System.Windows.Forms.TextBox()
        Me.chkYIntervals = New System.Windows.Forms.CheckBox()
        Me.chkDisplayMarkers = New System.Windows.Forms.CheckBox()
        Me.grpYScale = New System.Windows.Forms.GroupBox()
        Me.txtYUpperLimit = New System.Windows.Forms.TextBox()
        Me.txtYLowerLimit = New System.Windows.Forms.TextBox()
        Me.chkYUpperLimit = New System.Windows.Forms.CheckBox()
        Me.chkYLowerLimit = New System.Windows.Forms.CheckBox()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.cmdCreateTheme = New System.Windows.Forms.Button()
        Me.chkOverideTheme = New System.Windows.Forms.CheckBox()
        Me.lbFont = New System.Windows.Forms.Label()
        Me.nudFont = New System.Windows.Forms.NumericUpDown()
        Me.tabctrlBoxSubdialog.SuspendLayout()
        Me.tabTheme.SuspendLayout()
        Me.tabLegend.SuspendLayout()
        Me.grpLabels.SuspendLayout()
        Me.grpTitle.SuspendLayout()
        Me.tabFacet.SuspendLayout()
        CType(Me.nudNoOfRowsOrColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLayers.SuspendLayout()
        Me.tbpXAxis.SuspendLayout()
        Me.grpTich.SuspendLayout()
        Me.grpScale.SuspendLayout()
        Me.grpXLabel.SuspendLayout()
        Me.grpXAxisTitle.SuspendLayout()
        Me.tbpYAxis.SuspendLayout()
        Me.grpYlabels.SuspendLayout()
        Me.grpYTitle.SuspendLayout()
        Me.grpYTich.SuspendLayout()
        Me.grpYScale.SuspendLayout()
        CType(Me.nudFont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabctrlBoxSubdialog
        '
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabTheme)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabLegend)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabFacet)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabLayers)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tbpXAxis)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tbpYAxis)
        Me.tabctrlBoxSubdialog.Location = New System.Drawing.Point(1, -1)
        Me.tabctrlBoxSubdialog.Name = "tabctrlBoxSubdialog"
        Me.tabctrlBoxSubdialog.SelectedIndex = 0
        Me.tabctrlBoxSubdialog.Size = New System.Drawing.Size(371, 283)
        Me.tabctrlBoxSubdialog.TabIndex = 0
        '
        'tabTheme
        '
        Me.tabTheme.Controls.Add(Me.nudFont)
        Me.tabTheme.Controls.Add(Me.lbFont)
        Me.tabTheme.Controls.Add(Me.chkOverideTheme)
        Me.tabTheme.Controls.Add(Me.cmdCreateTheme)
        Me.tabTheme.Controls.Add(Me.ucrInputThemes)
        Me.tabTheme.Controls.Add(Me.lblTheme)
        Me.tabTheme.Location = New System.Drawing.Point(4, 22)
        Me.tabTheme.Name = "tabTheme"
        Me.tabTheme.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTheme.Size = New System.Drawing.Size(363, 257)
        Me.tabTheme.TabIndex = 1
        Me.tabTheme.Tag = "Theme"
        Me.tabTheme.Text = "Theme"
        Me.tabTheme.UseVisualStyleBackColor = True
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.IsReadOnly = False
        Me.ucrInputThemes.Location = New System.Drawing.Point(75, 17)
        Me.ucrInputThemes.Name = "ucrInputThemes"
        Me.ucrInputThemes.Size = New System.Drawing.Size(171, 21)
        Me.ucrInputThemes.TabIndex = 1
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(-1, 17)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(73, 13)
        Me.lblTheme.TabIndex = 0
        Me.lblTheme.Text = "Select Theme"
        '
        'tabLegend
        '
        Me.tabLegend.Controls.Add(Me.grpLabels)
        Me.tabLegend.Controls.Add(Me.grpTitle)
        Me.tabLegend.Controls.Add(Me.chkDisplayLegend)
        Me.tabLegend.Location = New System.Drawing.Point(4, 22)
        Me.tabLegend.Name = "tabLegend"
        Me.tabLegend.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLegend.Size = New System.Drawing.Size(363, 257)
        Me.tabLegend.TabIndex = 2
        Me.tabLegend.Tag = "Legend"
        Me.tabLegend.Text = "Legend"
        Me.tabLegend.UseVisualStyleBackColor = True
        '
        'grpLabels
        '
        Me.grpLabels.Controls.Add(Me.chkReorderLabels)
        Me.grpLabels.Controls.Add(Me.chkChangeLabels)
        Me.grpLabels.Location = New System.Drawing.Point(7, 137)
        Me.grpLabels.Name = "grpLabels"
        Me.grpLabels.Size = New System.Drawing.Size(209, 100)
        Me.grpLabels.TabIndex = 2
        Me.grpLabels.TabStop = False
        Me.grpLabels.Text = "Labels"
        '
        'chkReorderLabels
        '
        Me.chkReorderLabels.AutoSize = True
        Me.chkReorderLabels.Location = New System.Drawing.Point(7, 43)
        Me.chkReorderLabels.Name = "chkReorderLabels"
        Me.chkReorderLabels.Size = New System.Drawing.Size(98, 17)
        Me.chkReorderLabels.TabIndex = 0
        Me.chkReorderLabels.Text = "Reorder Labels"
        Me.chkReorderLabels.UseVisualStyleBackColor = True
        '
        'chkChangeLabels
        '
        Me.chkChangeLabels.AutoSize = True
        Me.chkChangeLabels.Location = New System.Drawing.Point(7, 20)
        Me.chkChangeLabels.Name = "chkChangeLabels"
        Me.chkChangeLabels.Size = New System.Drawing.Size(97, 17)
        Me.chkChangeLabels.TabIndex = 0
        Me.chkChangeLabels.Text = "Change Labels"
        Me.chkChangeLabels.UseVisualStyleBackColor = True
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.txtChangeTitle)
        Me.grpTitle.Controls.Add(Me.chkChangeTitle)
        Me.grpTitle.Location = New System.Drawing.Point(7, 29)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(209, 100)
        Me.grpTitle.TabIndex = 1
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "Title"
        '
        'txtChangeTitle
        '
        Me.txtChangeTitle.Location = New System.Drawing.Point(5, 42)
        Me.txtChangeTitle.Name = "txtChangeTitle"
        Me.txtChangeTitle.Size = New System.Drawing.Size(180, 20)
        Me.txtChangeTitle.TabIndex = 1
        '
        'chkChangeTitle
        '
        Me.chkChangeTitle.AutoSize = True
        Me.chkChangeTitle.Location = New System.Drawing.Point(6, 19)
        Me.chkChangeTitle.Name = "chkChangeTitle"
        Me.chkChangeTitle.Size = New System.Drawing.Size(86, 17)
        Me.chkChangeTitle.TabIndex = 0
        Me.chkChangeTitle.Text = "Change Title"
        Me.chkChangeTitle.UseVisualStyleBackColor = True
        '
        'chkDisplayLegend
        '
        Me.chkDisplayLegend.AutoSize = True
        Me.chkDisplayLegend.Location = New System.Drawing.Point(7, 6)
        Me.chkDisplayLegend.Name = "chkDisplayLegend"
        Me.chkDisplayLegend.Size = New System.Drawing.Size(99, 17)
        Me.chkDisplayLegend.TabIndex = 0
        Me.chkDisplayLegend.Text = "Display Legend"
        Me.chkDisplayLegend.UseVisualStyleBackColor = True
        '
        'tabFacet
        '
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
        Me.tabFacet.Controls.Add(Me.ucrAddRemove)
        Me.tabFacet.Location = New System.Drawing.Point(4, 22)
        Me.tabFacet.Name = "tabFacet"
        Me.tabFacet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFacet.Size = New System.Drawing.Size(363, 257)
        Me.tabFacet.TabIndex = 3
        Me.tabFacet.Tag = "Facet"
        Me.tabFacet.Text = "Facet"
        Me.tabFacet.UseVisualStyleBackColor = True
        '
        'nudNoOfRowsOrColumns
        '
        Me.nudNoOfRowsOrColumns.Location = New System.Drawing.Point(159, 188)
        Me.nudNoOfRowsOrColumns.Name = "nudNoOfRowsOrColumns"
        Me.nudNoOfRowsOrColumns.Size = New System.Drawing.Size(39, 20)
        Me.nudNoOfRowsOrColumns.TabIndex = 19
        '
        'chkNoOfRowsOrColumns
        '
        Me.chkNoOfRowsOrColumns.AutoSize = True
        Me.chkNoOfRowsOrColumns.Location = New System.Drawing.Point(10, 191)
        Me.chkNoOfRowsOrColumns.Name = "chkNoOfRowsOrColumns"
        Me.chkNoOfRowsOrColumns.Size = New System.Drawing.Size(133, 17)
        Me.chkNoOfRowsOrColumns.TabIndex = 18
        Me.chkNoOfRowsOrColumns.Text = "Fixed Number of Rows"
        Me.chkNoOfRowsOrColumns.UseVisualStyleBackColor = True
        '
        'chkIncludeFacets
        '
        Me.chkIncludeFacets.AutoSize = True
        Me.chkIncludeFacets.Location = New System.Drawing.Point(10, 4)
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
        Me.chkFreeScalesY.Location = New System.Drawing.Point(249, 223)
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
        Me.chkMargin.Location = New System.Drawing.Point(10, 223)
        Me.chkMargin.Name = "chkMargin"
        Me.chkMargin.Size = New System.Drawing.Size(63, 17)
        Me.chkMargin.TabIndex = 13
        Me.chkMargin.Text = "Margins"
        Me.chkMargin.UseVisualStyleBackColor = True
        '
        'chkFreeScalesX
        '
        Me.chkFreeScalesX.AutoSize = True
        Me.chkFreeScalesX.Location = New System.Drawing.Point(108, 223)
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
        Me.rdoHorizontal.Location = New System.Drawing.Point(10, 159)
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
        Me.rdoVertical.Location = New System.Drawing.Point(99, 159)
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
        Me.lblFactor2.Location = New System.Drawing.Point(249, 98)
        Me.lblFactor2.Name = "lblFactor2"
        Me.lblFactor2.Size = New System.Drawing.Size(106, 13)
        Me.lblFactor2.TabIndex = 4
        Me.lblFactor2.Text = "2nd Factor (Optional)"
        '
        'lblFactor1
        '
        Me.lblFactor1.AutoSize = True
        Me.lblFactor1.Location = New System.Drawing.Point(249, 24)
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Size = New System.Drawing.Size(54, 13)
        Me.lblFactor1.TabIndex = 3
        Me.lblFactor1.Tag = ""
        Me.lblFactor1.Text = "1st Factor"
        '
        'ucr2ndFactorReceiver
        '
        Me.ucr2ndFactorReceiver.Location = New System.Drawing.Point(252, 114)
        Me.ucr2ndFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr2ndFactorReceiver.Name = "ucr2ndFactorReceiver"
        Me.ucr2ndFactorReceiver.Selector = Nothing
        Me.ucr2ndFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr2ndFactorReceiver.TabIndex = 2
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(252, 40)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr1stFactorReceiver.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(10, 24)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(228, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'tabLayers
        '
        Me.tabLayers.Controls.Add(Me.chkConnect)
        Me.tabLayers.Controls.Add(Me.chkDotPlot)
        Me.tabLayers.Location = New System.Drawing.Point(4, 22)
        Me.tabLayers.Name = "tabLayers"
        Me.tabLayers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLayers.Size = New System.Drawing.Size(363, 257)
        Me.tabLayers.TabIndex = 4
        Me.tabLayers.Tag = "Layers"
        Me.tabLayers.Text = "Layers"
        Me.tabLayers.UseVisualStyleBackColor = True
        '
        'chkConnect
        '
        Me.chkConnect.AutoSize = True
        Me.chkConnect.Location = New System.Drawing.Point(22, 84)
        Me.chkConnect.Name = "chkConnect"
        Me.chkConnect.Size = New System.Drawing.Size(66, 17)
        Me.chkConnect.TabIndex = 1
        Me.chkConnect.Tag = "Connect"
        Me.chkConnect.Text = "Connect"
        Me.chkConnect.UseVisualStyleBackColor = True
        '
        'chkDotPlot
        '
        Me.chkDotPlot.AutoSize = True
        Me.chkDotPlot.Location = New System.Drawing.Point(22, 35)
        Me.chkDotPlot.Name = "chkDotPlot"
        Me.chkDotPlot.Size = New System.Drawing.Size(63, 17)
        Me.chkDotPlot.TabIndex = 0
        Me.chkDotPlot.Tag = "Dot_plot"
        Me.chkDotPlot.Text = "Dot plot"
        Me.chkDotPlot.UseVisualStyleBackColor = True
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.grpTich)
        Me.tbpXAxis.Controls.Add(Me.grpScale)
        Me.tbpXAxis.Controls.Add(Me.grpXLabel)
        Me.tbpXAxis.Controls.Add(Me.grpXAxisTitle)
        Me.tbpXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpXAxis.Size = New System.Drawing.Size(363, 257)
        Me.tbpXAxis.TabIndex = 5
        Me.tbpXAxis.Text = "X-Axis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'grpTich
        '
        Me.grpTich.Controls.Add(Me.chkSpecificPoints)
        Me.grpTich.Controls.Add(Me.txtSpecificPoints)
        Me.grpTich.Controls.Add(Me.txtIntervals)
        Me.grpTich.Controls.Add(Me.chkIntervals)
        Me.grpTich.Controls.Add(Me.chkXDisplayMarkers)
        Me.grpTich.Location = New System.Drawing.Point(180, 115)
        Me.grpTich.Name = "grpTich"
        Me.grpTich.Size = New System.Drawing.Size(164, 84)
        Me.grpTich.TabIndex = 0
        Me.grpTich.TabStop = False
        Me.grpTich.Text = "Tick Markers "
        '
        'chkSpecificPoints
        '
        Me.chkSpecificPoints.AutoSize = True
        Me.chkSpecificPoints.Location = New System.Drawing.Point(6, 61)
        Me.chkSpecificPoints.Name = "chkSpecificPoints"
        Me.chkSpecificPoints.Size = New System.Drawing.Size(96, 17)
        Me.chkSpecificPoints.TabIndex = 0
        Me.chkSpecificPoints.Text = "Specific Points"
        Me.chkSpecificPoints.UseVisualStyleBackColor = True
        '
        'txtSpecificPoints
        '
        Me.txtSpecificPoints.Location = New System.Drawing.Point(112, 59)
        Me.txtSpecificPoints.Name = "txtSpecificPoints"
        Me.txtSpecificPoints.Size = New System.Drawing.Size(42, 20)
        Me.txtSpecificPoints.TabIndex = 1
        '
        'txtIntervals
        '
        Me.txtIntervals.Location = New System.Drawing.Point(112, 37)
        Me.txtIntervals.Name = "txtIntervals"
        Me.txtIntervals.Size = New System.Drawing.Size(42, 20)
        Me.txtIntervals.TabIndex = 1
        '
        'chkIntervals
        '
        Me.chkIntervals.AutoSize = True
        Me.chkIntervals.Location = New System.Drawing.Point(6, 40)
        Me.chkIntervals.Name = "chkIntervals"
        Me.chkIntervals.Size = New System.Drawing.Size(66, 17)
        Me.chkIntervals.TabIndex = 0
        Me.chkIntervals.Text = "Intervals"
        Me.chkIntervals.UseVisualStyleBackColor = True
        '
        'chkXDisplayMarkers
        '
        Me.chkXDisplayMarkers.AutoSize = True
        Me.chkXDisplayMarkers.Location = New System.Drawing.Point(6, 17)
        Me.chkXDisplayMarkers.Name = "chkXDisplayMarkers"
        Me.chkXDisplayMarkers.Size = New System.Drawing.Size(125, 17)
        Me.chkXDisplayMarkers.TabIndex = 0
        Me.chkXDisplayMarkers.Text = "Display Tich Markers"
        Me.chkXDisplayMarkers.UseVisualStyleBackColor = True
        '
        'grpScale
        '
        Me.grpScale.Controls.Add(Me.txtUpperLimit)
        Me.grpScale.Controls.Add(Me.txtLowerLimit)
        Me.grpScale.Controls.Add(Me.chkUpperLimit)
        Me.grpScale.Controls.Add(Me.chkLowerLimit)
        Me.grpScale.Location = New System.Drawing.Point(3, 115)
        Me.grpScale.Name = "grpScale"
        Me.grpScale.Size = New System.Drawing.Size(164, 84)
        Me.grpScale.TabIndex = 0
        Me.grpScale.TabStop = False
        Me.grpScale.Text = "Scale"
        '
        'txtUpperLimit
        '
        Me.txtUpperLimit.Location = New System.Drawing.Point(115, 51)
        Me.txtUpperLimit.Name = "txtUpperLimit"
        Me.txtUpperLimit.Size = New System.Drawing.Size(42, 20)
        Me.txtUpperLimit.TabIndex = 1
        '
        'txtLowerLimit
        '
        Me.txtLowerLimit.Location = New System.Drawing.Point(115, 17)
        Me.txtLowerLimit.Name = "txtLowerLimit"
        Me.txtLowerLimit.Size = New System.Drawing.Size(42, 20)
        Me.txtLowerLimit.TabIndex = 1
        '
        'chkUpperLimit
        '
        Me.chkUpperLimit.AutoSize = True
        Me.chkUpperLimit.Location = New System.Drawing.Point(7, 54)
        Me.chkUpperLimit.Name = "chkUpperLimit"
        Me.chkUpperLimit.Size = New System.Drawing.Size(79, 17)
        Me.chkUpperLimit.TabIndex = 0
        Me.chkUpperLimit.Text = "Upper Limit"
        Me.chkUpperLimit.UseVisualStyleBackColor = True
        '
        'chkLowerLimit
        '
        Me.chkLowerLimit.AutoSize = True
        Me.chkLowerLimit.Location = New System.Drawing.Point(7, 20)
        Me.chkLowerLimit.Name = "chkLowerLimit"
        Me.chkLowerLimit.Size = New System.Drawing.Size(79, 17)
        Me.chkLowerLimit.TabIndex = 0
        Me.chkLowerLimit.Text = "Lower Limit"
        Me.chkLowerLimit.UseVisualStyleBackColor = True
        '
        'grpXLabel
        '
        Me.grpXLabel.Controls.Add(Me.cboChangeLabels)
        Me.grpXLabel.Controls.Add(Me.chkChangeXLabels)
        Me.grpXLabel.Controls.Add(Me.chkDisplayLabels)
        Me.grpXLabel.Location = New System.Drawing.Point(173, 6)
        Me.grpXLabel.Name = "grpXLabel"
        Me.grpXLabel.Size = New System.Drawing.Size(171, 88)
        Me.grpXLabel.TabIndex = 0
        Me.grpXLabel.TabStop = False
        Me.grpXLabel.Text = "Labels"
        '
        'cboChangeLabels
        '
        Me.cboChangeLabels.FormattingEnabled = True
        Me.cboChangeLabels.Location = New System.Drawing.Point(24, 61)
        Me.cboChangeLabels.Name = "cboChangeLabels"
        Me.cboChangeLabels.Size = New System.Drawing.Size(121, 21)
        Me.cboChangeLabels.TabIndex = 1
        '
        'chkChangeXLabels
        '
        Me.chkChangeXLabels.AutoSize = True
        Me.chkChangeXLabels.Location = New System.Drawing.Point(7, 41)
        Me.chkChangeXLabels.Name = "chkChangeXLabels"
        Me.chkChangeXLabels.Size = New System.Drawing.Size(97, 17)
        Me.chkChangeXLabels.TabIndex = 0
        Me.chkChangeXLabels.Text = "Change Labels"
        Me.chkChangeXLabels.UseVisualStyleBackColor = True
        '
        'chkDisplayLabels
        '
        Me.chkDisplayLabels.AutoSize = True
        Me.chkDisplayLabels.Location = New System.Drawing.Point(7, 20)
        Me.chkDisplayLabels.Name = "chkDisplayLabels"
        Me.chkDisplayLabels.Size = New System.Drawing.Size(94, 17)
        Me.chkDisplayLabels.TabIndex = 0
        Me.chkDisplayLabels.Text = "Display Labels"
        Me.chkDisplayLabels.UseVisualStyleBackColor = True
        '
        'grpXAxisTitle
        '
        Me.grpXAxisTitle.Controls.Add(Me.txtXTitle)
        Me.grpXAxisTitle.Controls.Add(Me.chkXDisplayTitle)
        Me.grpXAxisTitle.Location = New System.Drawing.Point(6, 3)
        Me.grpXAxisTitle.Name = "grpXAxisTitle"
        Me.grpXAxisTitle.Size = New System.Drawing.Size(161, 91)
        Me.grpXAxisTitle.TabIndex = 0
        Me.grpXAxisTitle.TabStop = False
        Me.grpXAxisTitle.Text = "Title"
        '
        'txtXTitle
        '
        Me.txtXTitle.AcceptsReturn = True
        Me.txtXTitle.Location = New System.Drawing.Point(4, 44)
        Me.txtXTitle.Name = "txtXTitle"
        Me.txtXTitle.Size = New System.Drawing.Size(116, 20)
        Me.txtXTitle.TabIndex = 1
        '
        'chkXDisplayTitle
        '
        Me.chkXDisplayTitle.AutoSize = True
        Me.chkXDisplayTitle.Location = New System.Drawing.Point(4, 20)
        Me.chkXDisplayTitle.Name = "chkXDisplayTitle"
        Me.chkXDisplayTitle.Size = New System.Drawing.Size(83, 17)
        Me.chkXDisplayTitle.TabIndex = 0
        Me.chkXDisplayTitle.Text = "Display Title"
        Me.chkXDisplayTitle.UseVisualStyleBackColor = True
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.grpYlabels)
        Me.tbpYAxis.Controls.Add(Me.grpYTitle)
        Me.tbpYAxis.Controls.Add(Me.grpYTich)
        Me.tbpYAxis.Controls.Add(Me.grpYScale)
        Me.tbpYAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpYAxis.Size = New System.Drawing.Size(363, 257)
        Me.tbpYAxis.TabIndex = 6
        Me.tbpYAxis.Text = "Y-Axis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'grpYlabels
        '
        Me.grpYlabels.Controls.Add(Me.cboYChangeLevel)
        Me.grpYlabels.Controls.Add(Me.chkChangeYLabelschkDisplayYLabels)
        Me.grpYlabels.Controls.Add(Me.chkDisplayYLabels)
        Me.grpYlabels.Location = New System.Drawing.Point(175, 16)
        Me.grpYlabels.Name = "grpYlabels"
        Me.grpYlabels.Size = New System.Drawing.Size(171, 88)
        Me.grpYlabels.TabIndex = 1
        Me.grpYlabels.TabStop = False
        Me.grpYlabels.Text = "Labels"
        '
        'cboYChangeLevel
        '
        Me.cboYChangeLevel.FormattingEnabled = True
        Me.cboYChangeLevel.Location = New System.Drawing.Point(24, 61)
        Me.cboYChangeLevel.Name = "cboYChangeLevel"
        Me.cboYChangeLevel.Size = New System.Drawing.Size(121, 21)
        Me.cboYChangeLevel.TabIndex = 1
        '
        'chkChangeYLabelschkDisplayYLabels
        '
        Me.chkChangeYLabelschkDisplayYLabels.AutoSize = True
        Me.chkChangeYLabelschkDisplayYLabels.Location = New System.Drawing.Point(7, 41)
        Me.chkChangeYLabelschkDisplayYLabels.Name = "chkChangeYLabelschkDisplayYLabels"
        Me.chkChangeYLabelschkDisplayYLabels.Size = New System.Drawing.Size(97, 17)
        Me.chkChangeYLabelschkDisplayYLabels.TabIndex = 0
        Me.chkChangeYLabelschkDisplayYLabels.Text = "Change Labels"
        Me.chkChangeYLabelschkDisplayYLabels.UseVisualStyleBackColor = True
        '
        'chkDisplayYLabels
        '
        Me.chkDisplayYLabels.AutoSize = True
        Me.chkDisplayYLabels.Location = New System.Drawing.Point(7, 20)
        Me.chkDisplayYLabels.Name = "chkDisplayYLabels"
        Me.chkDisplayYLabels.Size = New System.Drawing.Size(94, 17)
        Me.chkDisplayYLabels.TabIndex = 0
        Me.chkDisplayYLabels.Text = "Display Labels"
        Me.chkDisplayYLabels.UseVisualStyleBackColor = True
        '
        'grpYTitle
        '
        Me.grpYTitle.Controls.Add(Me.txtYTitle)
        Me.grpYTitle.Controls.Add(Me.chkDisplayYTitle)
        Me.grpYTitle.Location = New System.Drawing.Point(8, 13)
        Me.grpYTitle.Name = "grpYTitle"
        Me.grpYTitle.Size = New System.Drawing.Size(161, 91)
        Me.grpYTitle.TabIndex = 2
        Me.grpYTitle.TabStop = False
        Me.grpYTitle.Text = "Title"
        '
        'txtYTitle
        '
        Me.txtYTitle.AcceptsReturn = True
        Me.txtYTitle.Location = New System.Drawing.Point(54, 40)
        Me.txtYTitle.Name = "txtYTitle"
        Me.txtYTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtYTitle.TabIndex = 1
        '
        'chkDisplayYTitle
        '
        Me.chkDisplayYTitle.AutoSize = True
        Me.chkDisplayYTitle.Location = New System.Drawing.Point(4, 20)
        Me.chkDisplayYTitle.Name = "chkDisplayYTitle"
        Me.chkDisplayYTitle.Size = New System.Drawing.Size(83, 17)
        Me.chkDisplayYTitle.TabIndex = 0
        Me.chkDisplayYTitle.Text = "Display Title"
        Me.chkDisplayYTitle.UseVisualStyleBackColor = True
        '
        'grpYTich
        '
        Me.grpYTich.Controls.Add(Me.chkYSpecificPoints)
        Me.grpYTich.Controls.Add(Me.txtYSpecificPoints)
        Me.grpYTich.Controls.Add(Me.txtYIntervals)
        Me.grpYTich.Controls.Add(Me.chkYIntervals)
        Me.grpYTich.Controls.Add(Me.chkDisplayMarkers)
        Me.grpYTich.Location = New System.Drawing.Point(182, 125)
        Me.grpYTich.Name = "grpYTich"
        Me.grpYTich.Size = New System.Drawing.Size(164, 84)
        Me.grpYTich.TabIndex = 3
        Me.grpYTich.TabStop = False
        Me.grpYTich.Text = "Tick Markers "
        '
        'chkYSpecificPoints
        '
        Me.chkYSpecificPoints.AutoSize = True
        Me.chkYSpecificPoints.Location = New System.Drawing.Point(6, 61)
        Me.chkYSpecificPoints.Name = "chkYSpecificPoints"
        Me.chkYSpecificPoints.Size = New System.Drawing.Size(96, 17)
        Me.chkYSpecificPoints.TabIndex = 0
        Me.chkYSpecificPoints.Text = "Specific Points"
        Me.chkYSpecificPoints.UseVisualStyleBackColor = True
        '
        'txtYSpecificPoints
        '
        Me.txtYSpecificPoints.Location = New System.Drawing.Point(112, 59)
        Me.txtYSpecificPoints.Name = "txtYSpecificPoints"
        Me.txtYSpecificPoints.Size = New System.Drawing.Size(42, 20)
        Me.txtYSpecificPoints.TabIndex = 1
        '
        'txtYIntervals
        '
        Me.txtYIntervals.Location = New System.Drawing.Point(112, 37)
        Me.txtYIntervals.Name = "txtYIntervals"
        Me.txtYIntervals.Size = New System.Drawing.Size(42, 20)
        Me.txtYIntervals.TabIndex = 1
        '
        'chkYIntervals
        '
        Me.chkYIntervals.AutoSize = True
        Me.chkYIntervals.Location = New System.Drawing.Point(6, 40)
        Me.chkYIntervals.Name = "chkYIntervals"
        Me.chkYIntervals.Size = New System.Drawing.Size(66, 17)
        Me.chkYIntervals.TabIndex = 0
        Me.chkYIntervals.Text = "Intervals"
        Me.chkYIntervals.UseVisualStyleBackColor = True
        '
        'chkDisplayMarkers
        '
        Me.chkDisplayMarkers.AutoSize = True
        Me.chkDisplayMarkers.Location = New System.Drawing.Point(6, 17)
        Me.chkDisplayMarkers.Name = "chkDisplayMarkers"
        Me.chkDisplayMarkers.Size = New System.Drawing.Size(125, 17)
        Me.chkDisplayMarkers.TabIndex = 0
        Me.chkDisplayMarkers.Text = "Display Tich Markers"
        Me.chkDisplayMarkers.UseVisualStyleBackColor = True
        '
        'grpYScale
        '
        Me.grpYScale.Controls.Add(Me.txtYUpperLimit)
        Me.grpYScale.Controls.Add(Me.txtYLowerLimit)
        Me.grpYScale.Controls.Add(Me.chkYUpperLimit)
        Me.grpYScale.Controls.Add(Me.chkYLowerLimit)
        Me.grpYScale.Location = New System.Drawing.Point(5, 125)
        Me.grpYScale.Name = "grpYScale"
        Me.grpYScale.Size = New System.Drawing.Size(164, 84)
        Me.grpYScale.TabIndex = 4
        Me.grpYScale.TabStop = False
        Me.grpYScale.Text = "Scale"
        '
        'txtYUpperLimit
        '
        Me.txtYUpperLimit.Location = New System.Drawing.Point(115, 51)
        Me.txtYUpperLimit.Name = "txtYUpperLimit"
        Me.txtYUpperLimit.Size = New System.Drawing.Size(42, 20)
        Me.txtYUpperLimit.TabIndex = 1
        '
        'txtYLowerLimit
        '
        Me.txtYLowerLimit.Location = New System.Drawing.Point(115, 17)
        Me.txtYLowerLimit.Name = "txtYLowerLimit"
        Me.txtYLowerLimit.Size = New System.Drawing.Size(42, 20)
        Me.txtYLowerLimit.TabIndex = 1
        '
        'chkYUpperLimit
        '
        Me.chkYUpperLimit.AutoSize = True
        Me.chkYUpperLimit.Location = New System.Drawing.Point(7, 54)
        Me.chkYUpperLimit.Name = "chkYUpperLimit"
        Me.chkYUpperLimit.Size = New System.Drawing.Size(79, 17)
        Me.chkYUpperLimit.TabIndex = 0
        Me.chkYUpperLimit.Text = "Upper Limit"
        Me.chkYUpperLimit.UseVisualStyleBackColor = True
        '
        'chkYLowerLimit
        '
        Me.chkYLowerLimit.AutoSize = True
        Me.chkYLowerLimit.Location = New System.Drawing.Point(7, 20)
        Me.chkYLowerLimit.Name = "chkYLowerLimit"
        Me.chkYLowerLimit.Size = New System.Drawing.Size(79, 17)
        Me.chkYLowerLimit.TabIndex = 0
        Me.chkYLowerLimit.Text = "Lower Limit"
        Me.chkYLowerLimit.UseVisualStyleBackColor = True
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(113, 284)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(160, 41)
        Me.ucrBaseSubdialog.TabIndex = 1
        '
        'cmdCreateTheme
        '
        Me.cmdCreateTheme.Location = New System.Drawing.Point(251, 16)
        Me.cmdCreateTheme.Name = "cmdCreateTheme"
        Me.cmdCreateTheme.Size = New System.Drawing.Size(110, 23)
        Me.cmdCreateTheme.TabIndex = 2
        Me.cmdCreateTheme.Text = "Create New Theme"
        Me.cmdCreateTheme.UseVisualStyleBackColor = True
        '
        'chkOverideTheme
        '
        Me.chkOverideTheme.AutoSize = True
        Me.chkOverideTheme.Location = New System.Drawing.Point(7, 48)
        Me.chkOverideTheme.Name = "chkOverideTheme"
        Me.chkOverideTheme.Size = New System.Drawing.Size(136, 17)
        Me.chkOverideTheme.TabIndex = 3
        Me.chkOverideTheme.Text = "Overide Theme Default"
        Me.chkOverideTheme.UseVisualStyleBackColor = True
        '
        'lbFont
        '
        Me.lbFont.AutoSize = True
        Me.lbFont.Location = New System.Drawing.Point(8, 76)
        Me.lbFont.Name = "lbFont"
        Me.lbFont.Size = New System.Drawing.Size(51, 13)
        Me.lbFont.TabIndex = 4
        Me.lbFont.Text = "Font Size"
        '
        'nudFont
        '
        Me.nudFont.Location = New System.Drawing.Point(75, 72)
        Me.nudFont.Maximum = New Decimal(New Integer() {45, 0, 0, 0})
        Me.nudFont.Minimum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudFont.Name = "nudFont"
        Me.nudFont.Size = New System.Drawing.Size(85, 20)
        Me.nudFont.TabIndex = 5
        Me.nudFont.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'sdgPlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 318)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tabctrlBoxSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Plot_Options"
        Me.Text = "Plot Options"
        Me.TopMost = True
        Me.tabctrlBoxSubdialog.ResumeLayout(False)
        Me.tabTheme.ResumeLayout(False)
        Me.tabTheme.PerformLayout()
        Me.tabLegend.ResumeLayout(False)
        Me.tabLegend.PerformLayout()
        Me.grpLabels.ResumeLayout(False)
        Me.grpLabels.PerformLayout()
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        Me.tabFacet.ResumeLayout(False)
        Me.tabFacet.PerformLayout()
        CType(Me.nudNoOfRowsOrColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLayers.ResumeLayout(False)
        Me.tabLayers.PerformLayout()
        Me.tbpXAxis.ResumeLayout(False)
        Me.grpTich.ResumeLayout(False)
        Me.grpTich.PerformLayout()
        Me.grpScale.ResumeLayout(False)
        Me.grpScale.PerformLayout()
        Me.grpXLabel.ResumeLayout(False)
        Me.grpXLabel.PerformLayout()
        Me.grpXAxisTitle.ResumeLayout(False)
        Me.grpXAxisTitle.PerformLayout()
        Me.tbpYAxis.ResumeLayout(False)
        Me.grpYlabels.ResumeLayout(False)
        Me.grpYlabels.PerformLayout()
        Me.grpYTitle.ResumeLayout(False)
        Me.grpYTitle.PerformLayout()
        Me.grpYTich.ResumeLayout(False)
        Me.grpYTich.PerformLayout()
        Me.grpYScale.ResumeLayout(False)
        Me.grpYScale.PerformLayout()
        CType(Me.nudFont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabctrlBoxSubdialog As TabControl
    Friend WithEvents tabTheme As TabPage
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tabLegend As TabPage
    Friend WithEvents tabFacet As TabPage
    Friend WithEvents tabLayers As TabPage
    Friend WithEvents chkFreeScalesX As CheckBox
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents lblFactor2 As Label
    Friend WithEvents lblFactor1 As Label
    Friend WithEvents ucr2ndFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents chkConnect As CheckBox
    Friend WithEvents chkDotPlot As CheckBox
    Friend WithEvents chkMargin As CheckBox
    Friend WithEvents chkFreeScalesY As CheckBox
    Friend WithEvents chkIncludeFacets As CheckBox
    Friend WithEvents chkDisplayLegend As CheckBox
    Friend WithEvents grpLabels As GroupBox
    Friend WithEvents grpTitle As GroupBox
    Friend WithEvents chkChangeTitle As CheckBox
    Friend WithEvents chkReorderLabels As CheckBox
    Friend WithEvents chkChangeLabels As CheckBox
    Friend WithEvents txtChangeTitle As TextBox
    Friend WithEvents tbpXAxis As TabPage
    Friend WithEvents tbpYAxis As TabPage
    Friend WithEvents grpScale As GroupBox
    Friend WithEvents txtUpperLimit As TextBox
    Friend WithEvents txtLowerLimit As TextBox
    Friend WithEvents chkUpperLimit As CheckBox
    Friend WithEvents chkLowerLimit As CheckBox
    Friend WithEvents grpXAxisTitle As GroupBox
    Friend WithEvents grpXLabel As GroupBox
    Friend WithEvents txtXTitle As TextBox
    Friend WithEvents chkXDisplayTitle As CheckBox
    Friend WithEvents grpTich As GroupBox
    Friend WithEvents cboChangeLabels As ComboBox
    Friend WithEvents chkChangeXLabels As CheckBox
    Friend WithEvents chkDisplayLabels As CheckBox
    Friend WithEvents chkSpecificPoints As CheckBox
    Friend WithEvents txtSpecificPoints As TextBox
    Friend WithEvents txtIntervals As TextBox
    Friend WithEvents chkIntervals As CheckBox
    Friend WithEvents chkXDisplayMarkers As CheckBox
    Friend WithEvents grpYlabels As GroupBox
    Friend WithEvents cboYChangeLevel As ComboBox
    Friend WithEvents chkChangeYLabelschkDisplayYLabels As CheckBox
    Friend WithEvents chkDisplayYLabels As CheckBox
    Friend WithEvents grpYTitle As GroupBox
    Friend WithEvents txtYTitle As TextBox
    Friend WithEvents chkDisplayYTitle As CheckBox
    Friend WithEvents grpYTich As GroupBox
    Friend WithEvents chkYSpecificPoints As CheckBox
    Friend WithEvents txtYSpecificPoints As TextBox
    Friend WithEvents txtYIntervals As TextBox
    Friend WithEvents chkYIntervals As CheckBox
    Friend WithEvents chkDisplayMarkers As CheckBox
    Friend WithEvents grpYScale As GroupBox
    Friend WithEvents txtYUpperLimit As TextBox
    Friend WithEvents txtYLowerLimit As TextBox
    Friend WithEvents chkYUpperLimit As CheckBox
    Friend WithEvents chkYLowerLimit As CheckBox
    Friend WithEvents nudNoOfRowsOrColumns As NumericUpDown
    Friend WithEvents chkNoOfRowsOrColumns As CheckBox
    Friend WithEvents ucrInputThemes As ucrInputComboBox
    Friend WithEvents lblTheme As Label
    Friend WithEvents cmdCreateTheme As Button
    Friend WithEvents chkOverideTheme As CheckBox
    Friend WithEvents nudFont As NumericUpDown
    Friend WithEvents lbFont As Label
End Class


