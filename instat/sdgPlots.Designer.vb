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
        Me.tabAxes = New System.Windows.Forms.TabPage()
        Me.chkDisplayMeans = New System.Windows.Forms.CheckBox()
        Me.chkDisplayError = New System.Windows.Forms.CheckBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtYlabel = New System.Windows.Forms.TextBox()
        Me.txtXlabel = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblYlabel = New System.Windows.Forms.Label()
        Me.lblXlabel = New System.Windows.Forms.Label()
        Me.tabTheme = New System.Windows.Forms.TabPage()
        Me.tabLegend = New System.Windows.Forms.TabPage()
        Me.tabFacet = New System.Windows.Forms.TabPage()
        Me.chkFreeScales = New System.Windows.Forms.CheckBox()
        Me.txtNoOfColumns = New System.Windows.Forms.TextBox()
        Me.lblNoOfColumns = New System.Windows.Forms.Label()
        Me.chkWrapOptions = New System.Windows.Forms.CheckBox()
        Me.rdoMargins = New System.Windows.Forms.RadioButton()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.chkGridOptions = New System.Windows.Forms.CheckBox()
        Me.lblFactor2 = New System.Windows.Forms.Label()
        Me.lblFactor1 = New System.Windows.Forms.Label()
        Me.ucrReceiveFactor2 = New instat.ucrReceiverSingle()
        Me.ucrReceiveFactor1 = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.tabLayers = New System.Windows.Forms.TabPage()
        Me.chkConnect = New System.Windows.Forms.CheckBox()
        Me.chkDotPlot = New System.Windows.Forms.CheckBox()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tabctrlBoxSubdialog.SuspendLayout()
        Me.tabAxes.SuspendLayout()
        Me.tabFacet.SuspendLayout()
        Me.tabLayers.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabctrlBoxSubdialog
        '
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabAxes)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabTheme)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabLegend)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabFacet)
        Me.tabctrlBoxSubdialog.Controls.Add(Me.tabLayers)
        Me.tabctrlBoxSubdialog.Location = New System.Drawing.Point(1, -1)
        Me.tabctrlBoxSubdialog.Name = "tabctrlBoxSubdialog"
        Me.tabctrlBoxSubdialog.SelectedIndex = 0
        Me.tabctrlBoxSubdialog.Size = New System.Drawing.Size(357, 276)
        Me.tabctrlBoxSubdialog.TabIndex = 0
        '
        'tabAxes
        '
        Me.tabAxes.Controls.Add(Me.chkDisplayMeans)
        Me.tabAxes.Controls.Add(Me.chkDisplayError)
        Me.tabAxes.Controls.Add(Me.txtTitle)
        Me.tabAxes.Controls.Add(Me.txtYlabel)
        Me.tabAxes.Controls.Add(Me.txtXlabel)
        Me.tabAxes.Controls.Add(Me.lblTitle)
        Me.tabAxes.Controls.Add(Me.lblYlabel)
        Me.tabAxes.Controls.Add(Me.lblXlabel)
        Me.tabAxes.Location = New System.Drawing.Point(4, 22)
        Me.tabAxes.Name = "tabAxes"
        Me.tabAxes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAxes.Size = New System.Drawing.Size(349, 250)
        Me.tabAxes.TabIndex = 0
        Me.tabAxes.Tag = "Axes"
        Me.tabAxes.Text = "Axes"
        Me.tabAxes.UseVisualStyleBackColor = True
        '
        'chkDisplayMeans
        '
        Me.chkDisplayMeans.AutoSize = True
        Me.chkDisplayMeans.Location = New System.Drawing.Point(23, 216)
        Me.chkDisplayMeans.Name = "chkDisplayMeans"
        Me.chkDisplayMeans.Size = New System.Drawing.Size(94, 17)
        Me.chkDisplayMeans.TabIndex = 7
        Me.chkDisplayMeans.Tag = "Display_means"
        Me.chkDisplayMeans.Text = "Display means"
        Me.chkDisplayMeans.UseVisualStyleBackColor = True
        '
        'chkDisplayError
        '
        Me.chkDisplayError.AutoSize = True
        Me.chkDisplayError.Location = New System.Drawing.Point(23, 176)
        Me.chkDisplayError.Name = "chkDisplayError"
        Me.chkDisplayError.Size = New System.Drawing.Size(107, 17)
        Me.chkDisplayError.TabIndex = 6
        Me.chkDisplayError.Tag = "Display_error_bars"
        Me.chkDisplayError.Text = "Display error bars"
        Me.chkDisplayError.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(92, 122)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(159, 20)
        Me.txtTitle.TabIndex = 5
        '
        'txtYlabel
        '
        Me.txtYlabel.Location = New System.Drawing.Point(92, 80)
        Me.txtYlabel.Name = "txtYlabel"
        Me.txtYlabel.Size = New System.Drawing.Size(159, 20)
        Me.txtYlabel.TabIndex = 4
        '
        'txtXlabel
        '
        Me.txtXlabel.Location = New System.Drawing.Point(92, 36)
        Me.txtXlabel.Name = "txtXlabel"
        Me.txtXlabel.Size = New System.Drawing.Size(159, 20)
        Me.txtXlabel.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(23, 129)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'lblYlabel
        '
        Me.lblYlabel.AutoSize = True
        Me.lblYlabel.Location = New System.Drawing.Point(23, 83)
        Me.lblYlabel.Name = "lblYlabel"
        Me.lblYlabel.Size = New System.Drawing.Size(43, 13)
        Me.lblYlabel.TabIndex = 1
        Me.lblYlabel.Tag = "Y_Label"
        Me.lblYlabel.Text = "Y Label"
        '
        'lblXlabel
        '
        Me.lblXlabel.AutoSize = True
        Me.lblXlabel.Location = New System.Drawing.Point(23, 39)
        Me.lblXlabel.Name = "lblXlabel"
        Me.lblXlabel.Size = New System.Drawing.Size(43, 13)
        Me.lblXlabel.TabIndex = 0
        Me.lblXlabel.Tag = "X_Label"
        Me.lblXlabel.Text = "X Label"
        '
        'tabTheme
        '
        Me.tabTheme.Location = New System.Drawing.Point(4, 22)
        Me.tabTheme.Name = "tabTheme"
        Me.tabTheme.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTheme.Size = New System.Drawing.Size(349, 250)
        Me.tabTheme.TabIndex = 1
        Me.tabTheme.Tag = "Theme"
        Me.tabTheme.Text = "Theme"
        Me.tabTheme.UseVisualStyleBackColor = True
        '
        'tabLegend
        '
        Me.tabLegend.Location = New System.Drawing.Point(4, 22)
        Me.tabLegend.Name = "tabLegend"
        Me.tabLegend.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLegend.Size = New System.Drawing.Size(349, 250)
        Me.tabLegend.TabIndex = 2
        Me.tabLegend.Tag = "Legend"
        Me.tabLegend.Text = "Legend"
        Me.tabLegend.UseVisualStyleBackColor = True
        '
        'tabFacet
        '
        Me.tabFacet.Controls.Add(Me.chkFreeScales)
        Me.tabFacet.Controls.Add(Me.txtNoOfColumns)
        Me.tabFacet.Controls.Add(Me.lblNoOfColumns)
        Me.tabFacet.Controls.Add(Me.chkWrapOptions)
        Me.tabFacet.Controls.Add(Me.rdoMargins)
        Me.tabFacet.Controls.Add(Me.rdoHorizontal)
        Me.tabFacet.Controls.Add(Me.rdoVertical)
        Me.tabFacet.Controls.Add(Me.chkGridOptions)
        Me.tabFacet.Controls.Add(Me.lblFactor2)
        Me.tabFacet.Controls.Add(Me.lblFactor1)
        Me.tabFacet.Controls.Add(Me.ucrReceiveFactor2)
        Me.tabFacet.Controls.Add(Me.ucrReceiveFactor1)
        Me.tabFacet.Controls.Add(Me.ucrAddRemove)
        Me.tabFacet.Location = New System.Drawing.Point(4, 22)
        Me.tabFacet.Name = "tabFacet"
        Me.tabFacet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFacet.Size = New System.Drawing.Size(349, 250)
        Me.tabFacet.TabIndex = 3
        Me.tabFacet.Tag = "Facet"
        Me.tabFacet.Text = "Facet"
        Me.tabFacet.UseVisualStyleBackColor = True
        '
        'chkFreeScales
        '
        Me.chkFreeScales.AutoSize = True
        Me.chkFreeScales.Location = New System.Drawing.Point(17, 227)
        Me.chkFreeScales.Name = "chkFreeScales"
        Me.chkFreeScales.Size = New System.Drawing.Size(80, 17)
        Me.chkFreeScales.TabIndex = 12
        Me.chkFreeScales.Tag = "Free_scales"
        Me.chkFreeScales.Text = "Free scales"
        Me.chkFreeScales.UseVisualStyleBackColor = True
        '
        'txtNoOfColumns
        '
        Me.txtNoOfColumns.Location = New System.Drawing.Point(241, 195)
        Me.txtNoOfColumns.Name = "txtNoOfColumns"
        Me.txtNoOfColumns.Size = New System.Drawing.Size(62, 20)
        Me.txtNoOfColumns.TabIndex = 11
        '
        'lblNoOfColumns
        '
        Me.lblNoOfColumns.AutoSize = True
        Me.lblNoOfColumns.Location = New System.Drawing.Point(133, 198)
        Me.lblNoOfColumns.Name = "lblNoOfColumns"
        Me.lblNoOfColumns.Size = New System.Drawing.Size(98, 13)
        Me.lblNoOfColumns.TabIndex = 10
        Me.lblNoOfColumns.Tag = "Number_of_columns"
        Me.lblNoOfColumns.Text = "Number of columns"
        '
        'chkWrapOptions
        '
        Me.chkWrapOptions.AutoSize = True
        Me.chkWrapOptions.Location = New System.Drawing.Point(17, 194)
        Me.chkWrapOptions.Name = "chkWrapOptions"
        Me.chkWrapOptions.Size = New System.Drawing.Size(89, 17)
        Me.chkWrapOptions.TabIndex = 9
        Me.chkWrapOptions.Tag = "Wrap_options"
        Me.chkWrapOptions.Text = "Wrap options"
        Me.chkWrapOptions.UseVisualStyleBackColor = True
        '
        'rdoMargins
        '
        Me.rdoMargins.AutoSize = True
        Me.rdoMargins.Location = New System.Drawing.Point(272, 163)
        Me.rdoMargins.Name = "rdoMargins"
        Me.rdoMargins.Size = New System.Drawing.Size(62, 17)
        Me.rdoMargins.TabIndex = 8
        Me.rdoMargins.TabStop = True
        Me.rdoMargins.Tag = "Margins"
        Me.rdoMargins.Text = "Margins"
        Me.rdoMargins.UseVisualStyleBackColor = True
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.AutoSize = True
        Me.rdoHorizontal.Location = New System.Drawing.Point(159, 163)
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
        Me.rdoVertical.Location = New System.Drawing.Point(50, 163)
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.Size = New System.Drawing.Size(60, 17)
        Me.rdoVertical.TabIndex = 6
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.Text = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'chkGridOptions
        '
        Me.chkGridOptions.AutoSize = True
        Me.chkGridOptions.Location = New System.Drawing.Point(17, 140)
        Me.chkGridOptions.Name = "chkGridOptions"
        Me.chkGridOptions.Size = New System.Drawing.Size(82, 17)
        Me.chkGridOptions.TabIndex = 5
        Me.chkGridOptions.Tag = "Grid_options"
        Me.chkGridOptions.Text = "Grid options"
        Me.chkGridOptions.UseVisualStyleBackColor = True
        '
        'lblFactor2
        '
        Me.lblFactor2.AutoSize = True
        Me.lblFactor2.Location = New System.Drawing.Point(227, 67)
        Me.lblFactor2.Name = "lblFactor2"
        Me.lblFactor2.Size = New System.Drawing.Size(101, 13)
        Me.lblFactor2.TabIndex = 4
        Me.lblFactor2.Text = "2nd factor (optional)"
        '
        'lblFactor1
        '
        Me.lblFactor1.AutoSize = True
        Me.lblFactor1.Location = New System.Drawing.Point(224, 15)
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Size = New System.Drawing.Size(51, 13)
        Me.lblFactor1.TabIndex = 3
        Me.lblFactor1.Tag = ""
        Me.lblFactor1.Text = "1st factor"
        '
        'ucrReceiveFactor2
        '
        Me.ucrReceiveFactor2.Location = New System.Drawing.Point(224, 87)
        Me.ucrReceiveFactor2.Name = "ucrReceiveFactor2"
        Me.ucrReceiveFactor2.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiveFactor2.TabIndex = 2
        '
        'ucrReceiveFactor1
        '
        Me.ucrReceiveFactor1.Location = New System.Drawing.Point(224, 34)
        Me.ucrReceiveFactor1.Name = "ucrReceiveFactor1"
        Me.ucrReceiveFactor1.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiveFactor1.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(6, 6)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'tabLayers
        '
        Me.tabLayers.Controls.Add(Me.chkConnect)
        Me.tabLayers.Controls.Add(Me.chkDotPlot)
        Me.tabLayers.Location = New System.Drawing.Point(4, 22)
        Me.tabLayers.Name = "tabLayers"
        Me.tabLayers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLayers.Size = New System.Drawing.Size(349, 250)
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
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(44, 277)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(253, 41)
        Me.ucrBaseSubdialog.TabIndex = 1
        '
        'sdgPlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 324)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tabctrlBoxSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Plot_Options"
        Me.Text = "Plot Options"
        Me.tabctrlBoxSubdialog.ResumeLayout(False)
        Me.tabAxes.ResumeLayout(False)
        Me.tabAxes.PerformLayout()
        Me.tabFacet.ResumeLayout(False)
        Me.tabFacet.PerformLayout()
        Me.tabLayers.ResumeLayout(False)
        Me.tabLayers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabctrlBoxSubdialog As TabControl
    Friend WithEvents tabAxes As TabPage
    Friend WithEvents tabTheme As TabPage
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tabLegend As TabPage
    Friend WithEvents tabFacet As TabPage
    Friend WithEvents tabLayers As TabPage
    Friend WithEvents chkDisplayMeans As CheckBox
    Friend WithEvents chkDisplayError As CheckBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtYlabel As TextBox
    Friend WithEvents txtXlabel As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblYlabel As Label
    Friend WithEvents lblXlabel As Label
    Friend WithEvents chkFreeScales As CheckBox
    Friend WithEvents txtNoOfColumns As TextBox
    Friend WithEvents lblNoOfColumns As Label
    Friend WithEvents chkWrapOptions As CheckBox
    Friend WithEvents rdoMargins As RadioButton
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents chkGridOptions As CheckBox
    Friend WithEvents lblFactor2 As Label
    Friend WithEvents lblFactor1 As Label
    Friend WithEvents ucrReceiveFactor2 As ucrReceiverSingle
    Friend WithEvents ucrReceiveFactor1 As ucrReceiverSingle
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents chkConnect As CheckBox
    Friend WithEvents chkDotPlot As CheckBox
End Class
