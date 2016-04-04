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
        Me.tabLegend = New System.Windows.Forms.TabPage()
        Me.tabFacet = New System.Windows.Forms.TabPage()
        Me.chkIncludeFacets = New System.Windows.Forms.CheckBox()
        Me.txtNoOfRows = New System.Windows.Forms.TextBox()
        Me.chkFreeScalesY = New System.Windows.Forms.CheckBox()
        Me.chkMargin = New System.Windows.Forms.CheckBox()
        Me.chkFreeScalesX = New System.Windows.Forms.CheckBox()
        Me.txtNoOfColumns = New System.Windows.Forms.TextBox()
        Me.lblNoofRows = New System.Windows.Forms.Label()
        Me.lblNoOfColumns = New System.Windows.Forms.Label()
        Me.chkWrapOptions = New System.Windows.Forms.CheckBox()
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
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.chkDisplayLegend = New System.Windows.Forms.CheckBox()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.grpLabels = New System.Windows.Forms.GroupBox()
        Me.chkDisplayTitle = New System.Windows.Forms.CheckBox()
        Me.chkChangeTitle = New System.Windows.Forms.CheckBox()
        Me.chkChangeLabels = New System.Windows.Forms.CheckBox()
        Me.chkReorderLabels = New System.Windows.Forms.CheckBox()
        Me.txtChangeTitle = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tabctrlBoxSubdialog.SuspendLayout()
        Me.tabLegend.SuspendLayout()
        Me.tabFacet.SuspendLayout()
        Me.tabLayers.SuspendLayout()
        Me.grpTitle.SuspendLayout()
        Me.grpLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabctrlBoxSubdialog
        '
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabTheme)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabLegend)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabFacet)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabLayers)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.TabPage1)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.TabPage2)
        Me.tabctrlBoxSubdialog.Location = New System.Drawing.Point(1, -1)
        Me.tabctrlBoxSubdialog.Name = "tabctrlBoxSubdialog"
        Me.tabctrlBoxSubdialog.SelectedIndex = 0
        Me.tabctrlBoxSubdialog.Size = New System.Drawing.Size(376, 283)
        Me.tabctrlBoxSubdialog.TabIndex = 0
        '
        'tabTheme
        '
        Me.tabTheme.Location = New System.Drawing.Point(4, 22)
        Me.tabTheme.Name = "tabTheme"
        Me.tabTheme.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTheme.Size = New System.Drawing.Size(368, 257)
        Me.tabTheme.TabIndex = 1
        Me.tabTheme.Tag = "Theme"
        Me.tabTheme.Text = "Theme"
        Me.tabTheme.UseVisualStyleBackColor = True
        '
        'tabLegend
        '
        Me.tabLegend.Controls.Add(Me.grpLabels)
        Me.tabLegend.Controls.Add(Me.grpTitle)
        Me.tabLegend.Controls.Add(Me.chkDisplayLegend)
        Me.tabLegend.Location = New System.Drawing.Point(4, 22)
        Me.tabLegend.Name = "tabLegend"
        Me.tabLegend.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLegend.Size = New System.Drawing.Size(368, 257)
        Me.tabLegend.TabIndex = 2
        Me.tabLegend.Tag = "Legend"
        Me.tabLegend.Text = "Legend"
        Me.tabLegend.UseVisualStyleBackColor = True
        '
        'tabFacet
        '
        Me.tabFacet.Controls.Add(Me.chkIncludeFacets)
        Me.tabFacet.Controls.Add(Me.txtNoOfRows)
        Me.tabFacet.Controls.Add(Me.chkFreeScalesY)
        Me.tabFacet.Controls.Add(Me.chkMargin)
        Me.tabFacet.Controls.Add(Me.chkFreeScalesX)
        Me.tabFacet.Controls.Add(Me.txtNoOfColumns)
        Me.tabFacet.Controls.Add(Me.lblNoofRows)
        Me.tabFacet.Controls.Add(Me.lblNoOfColumns)
        Me.tabFacet.Controls.Add(Me.chkWrapOptions)
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
        Me.tabFacet.Size = New System.Drawing.Size(368, 257)
        Me.tabFacet.TabIndex = 3
        Me.tabFacet.Tag = "Facet"
        Me.tabFacet.Text = "Facet"
        Me.tabFacet.UseVisualStyleBackColor = True
        '
        'chkIncludeFacets
        '
        Me.chkIncludeFacets.AutoSize = True
        Me.chkIncludeFacets.Location = New System.Drawing.Point(262, 119)
        Me.chkIncludeFacets.Name = "chkIncludeFacets"
        Me.chkIncludeFacets.Size = New System.Drawing.Size(96, 17)
        Me.chkIncludeFacets.TabIndex = 16
        Me.chkIncludeFacets.Tag = "Include_Facets"
        Me.chkIncludeFacets.Text = "Include Facets"
        Me.chkIncludeFacets.UseVisualStyleBackColor = True
        '
        'txtNoOfRows
        '
        Me.txtNoOfRows.Location = New System.Drawing.Point(240, 208)
        Me.txtNoOfRows.Name = "txtNoOfRows"
        Me.txtNoOfRows.Size = New System.Drawing.Size(62, 20)
        Me.txtNoOfRows.TabIndex = 15
        '
        'chkFreeScalesY
        '
        Me.chkFreeScalesY.AutoSize = True
        Me.chkFreeScalesY.Location = New System.Drawing.Point(151, 238)
        Me.chkFreeScalesY.Name = "chkFreeScalesY"
        Me.chkFreeScalesY.Size = New System.Drawing.Size(109, 17)
        Me.chkFreeScalesY.TabIndex = 14
        Me.chkFreeScalesY.Tag = "Free_scales"
        Me.chkFreeScalesY.Text = "Free scales y-axis"
        Me.chkFreeScalesY.UseVisualStyleBackColor = True
        '
        'chkMargin
        '
        Me.chkMargin.AutoSize = True
        Me.chkMargin.Location = New System.Drawing.Point(17, 182)
        Me.chkMargin.Name = "chkMargin"
        Me.chkMargin.Size = New System.Drawing.Size(63, 17)
        Me.chkMargin.TabIndex = 13
        Me.chkMargin.Text = "Margins"
        Me.chkMargin.UseVisualStyleBackColor = True
        '
        'chkFreeScalesX
        '
        Me.chkFreeScalesX.AutoSize = True
        Me.chkFreeScalesX.Location = New System.Drawing.Point(17, 238)
        Me.chkFreeScalesX.Name = "chkFreeScalesX"
        Me.chkFreeScalesX.Size = New System.Drawing.Size(109, 17)
        Me.chkFreeScalesX.TabIndex = 12
        Me.chkFreeScalesX.Tag = "Free_scales"
        Me.chkFreeScalesX.Text = "Free scales x-axis"
        Me.chkFreeScalesX.UseVisualStyleBackColor = True
        '
        'txtNoOfColumns
        '
        Me.txtNoOfColumns.Location = New System.Drawing.Point(240, 180)
        Me.txtNoOfColumns.Name = "txtNoOfColumns"
        Me.txtNoOfColumns.Size = New System.Drawing.Size(62, 20)
        Me.txtNoOfColumns.TabIndex = 11
        '
        'lblNoofRows
        '
        Me.lblNoofRows.AutoSize = True
        Me.lblNoofRows.Location = New System.Drawing.Point(136, 209)
        Me.lblNoofRows.Name = "lblNoofRows"
        Me.lblNoofRows.Size = New System.Drawing.Size(86, 13)
        Me.lblNoofRows.TabIndex = 10
        Me.lblNoofRows.Tag = "Number_of_Rows"
        Me.lblNoofRows.Text = "Number of Rows"
        '
        'lblNoOfColumns
        '
        Me.lblNoOfColumns.AutoSize = True
        Me.lblNoOfColumns.Location = New System.Drawing.Point(136, 183)
        Me.lblNoOfColumns.Name = "lblNoOfColumns"
        Me.lblNoOfColumns.Size = New System.Drawing.Size(98, 13)
        Me.lblNoOfColumns.TabIndex = 10
        Me.lblNoOfColumns.Tag = "Number_of_columns"
        Me.lblNoOfColumns.Text = "Number of columns"
        '
        'chkWrapOptions
        '
        Me.chkWrapOptions.AutoSize = True
        Me.chkWrapOptions.Location = New System.Drawing.Point(203, 143)
        Me.chkWrapOptions.Name = "chkWrapOptions"
        Me.chkWrapOptions.Size = New System.Drawing.Size(89, 17)
        Me.chkWrapOptions.TabIndex = 9
        Me.chkWrapOptions.Tag = "Wrap_options"
        Me.chkWrapOptions.Text = "Wrap options"
        Me.chkWrapOptions.UseVisualStyleBackColor = True
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.AutoSize = True
        Me.rdoHorizontal.Location = New System.Drawing.Point(83, 142)
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
        Me.rdoVertical.Location = New System.Drawing.Point(17, 143)
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
        Me.lblFactor2.Location = New System.Drawing.Point(265, 67)
        Me.lblFactor2.Name = "lblFactor2"
        Me.lblFactor2.Size = New System.Drawing.Size(101, 13)
        Me.lblFactor2.TabIndex = 4
        Me.lblFactor2.Text = "2nd factor (optional)"
        '
        'lblFactor1
        '
        Me.lblFactor1.AutoSize = True
        Me.lblFactor1.Location = New System.Drawing.Point(262, 15)
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Size = New System.Drawing.Size(51, 13)
        Me.lblFactor1.TabIndex = 3
        Me.lblFactor1.Tag = ""
        Me.lblFactor1.Text = "1st factor"
        '
        'ucr2ndFactorReceiver
        '
        Me.ucr2ndFactorReceiver.Location = New System.Drawing.Point(262, 87)
        Me.ucr2ndFactorReceiver.Name = "ucr2ndFactorReceiver"
        Me.ucr2ndFactorReceiver.Selector = Nothing
        Me.ucr2ndFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr2ndFactorReceiver.TabIndex = 2
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(262, 34)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr1stFactorReceiver.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(6, 6)
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
        Me.tabLayers.Size = New System.Drawing.Size(368, 257)
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
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(83, 288)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(160, 41)
        Me.ucrBaseSubdialog.TabIndex = 1
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
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.txtChangeTitle)
        Me.grpTitle.Controls.Add(Me.chkChangeTitle)
        Me.grpTitle.Controls.Add(Me.chkDisplayTitle)
        Me.grpTitle.Location = New System.Drawing.Point(7, 29)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(209, 100)
        Me.grpTitle.TabIndex = 1
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "Title"
        '
        'grpLabels
        '
        Me.grpLabels.Controls.Add(Me.chkReorderLabels)
        Me.grpLabels.Controls.Add(Me.chkChangeLabels)
        Me.grpLabels.Location = New System.Drawing.Point(7, 141)
        Me.grpLabels.Name = "grpLabels"
        Me.grpLabels.Size = New System.Drawing.Size(209, 100)
        Me.grpLabels.TabIndex = 2
        Me.grpLabels.TabStop = False
        Me.grpLabels.Text = "Labels"
        '
        'chkDisplayTitle
        '
        Me.chkDisplayTitle.AutoSize = True
        Me.chkDisplayTitle.Location = New System.Drawing.Point(7, 20)
        Me.chkDisplayTitle.Name = "chkDisplayTitle"
        Me.chkDisplayTitle.Size = New System.Drawing.Size(83, 17)
        Me.chkDisplayTitle.TabIndex = 0
        Me.chkDisplayTitle.Text = "Display Title"
        Me.chkDisplayTitle.UseVisualStyleBackColor = True
        '
        'chkChangeTitle
        '
        Me.chkChangeTitle.AutoSize = True
        Me.chkChangeTitle.Location = New System.Drawing.Point(7, 45)
        Me.chkChangeTitle.Name = "chkChangeTitle"
        Me.chkChangeTitle.Size = New System.Drawing.Size(86, 17)
        Me.chkChangeTitle.TabIndex = 0
        Me.chkChangeTitle.Text = "Change Title"
        Me.chkChangeTitle.UseVisualStyleBackColor = True
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
        'txtChangeTitle
        '
        Me.txtChangeTitle.Location = New System.Drawing.Point(99, 45)
        Me.txtChangeTitle.Name = "txtChangeTitle"
        Me.txtChangeTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtChangeTitle.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(368, 257)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "X-Axis"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(368, 257)
        Me.TabPage2.TabIndex = 6
        Me.TabPage2.Text = "Y-Axis"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'sdgPlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 320)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tabctrlBoxSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Plot_Options"
        Me.Text = "Plot Options"
        Me.TopMost = True
        Me.tabctrlBoxSubdialog.ResumeLayout(False)
        Me.tabLegend.ResumeLayout(False)
        Me.tabLegend.PerformLayout()
        Me.tabFacet.ResumeLayout(False)
        Me.tabFacet.PerformLayout()
        Me.tabLayers.ResumeLayout(False)
        Me.tabLayers.PerformLayout()
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        Me.grpLabels.ResumeLayout(False)
        Me.grpLabels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabctrlBoxSubdialog As TabControl
    Friend WithEvents tabTheme As TabPage
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tabLegend As TabPage
    Friend WithEvents tabFacet As TabPage
    Friend WithEvents tabLayers As TabPage
    Friend WithEvents chkFreeScalesX As CheckBox
    Friend WithEvents txtNoOfColumns As TextBox
    Friend WithEvents lblNoOfColumns As Label
    Friend WithEvents chkWrapOptions As CheckBox
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
    Friend WithEvents txtNoOfRows As TextBox
    Friend WithEvents chkIncludeFacets As CheckBox
    Friend WithEvents lblNoofRows As Label
    Friend WithEvents chkDisplayLegend As CheckBox
    Friend WithEvents grpLabels As GroupBox
    Friend WithEvents grpTitle As GroupBox
    Friend WithEvents chkChangeTitle As CheckBox
    Friend WithEvents chkDisplayTitle As CheckBox
    Friend WithEvents chkReorderLabels As CheckBox
    Friend WithEvents chkChangeLabels As CheckBox
    Friend WithEvents txtChangeTitle As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
