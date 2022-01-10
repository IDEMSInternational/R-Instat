<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgDistributionOptions
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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbpPlotsOptions = New System.Windows.Forms.TabControl()
        Me.tbpTitles = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.ucrInputGraphCaption = New instat.ucrInputTextBox()
        Me.tbpXAxis = New System.Windows.Forms.TabPage()
        Me.lblXAxisTitle = New System.Windows.Forms.Label()
        Me.rdoXAxisSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoXAxisNoTitle = New System.Windows.Forms.RadioButton()
        Me.rdoXAxisAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputXAxisLabel = New instat.ucrInputTextBox()
        Me.ucrPnlXAxis = New instat.UcrPanel()
        Me.tbpYAxis = New System.Windows.Forms.TabPage()
        Me.lblYAxisTitle = New System.Windows.Forms.Label()
        Me.rdoYAxisSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoYAxisNoTitle = New System.Windows.Forms.RadioButton()
        Me.rdoYAxisAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputYAxisLabel = New instat.ucrInputTextBox()
        Me.ucrPnlYAxis = New instat.UcrPanel()
        Me.tbpTheme = New System.Windows.Forms.TabPage()
        Me.lblSelectTheme = New System.Windows.Forms.Label()
        Me.ucrInputThemes = New instat.ucrInputComboBox()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.tbpPlotsOptions.SuspendLayout()
        Me.tbpTitles.SuspendLayout()
        Me.tbpXAxis.SuspendLayout()
        Me.tbpYAxis.SuspendLayout()
        Me.tbpTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(60, 155)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 0
        '
        'tbpPlotsOptions
        '
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTitles)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpXAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpYAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTheme)
        Me.tbpPlotsOptions.Location = New System.Drawing.Point(1, 5)
        Me.tbpPlotsOptions.Name = "tbpPlotsOptions"
        Me.tbpPlotsOptions.SelectedIndex = 0
        Me.tbpPlotsOptions.Size = New System.Drawing.Size(270, 135)
        Me.tbpPlotsOptions.TabIndex = 1
        '
        'tbpTitles
        '
        Me.tbpTitles.Controls.Add(Me.Label1)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.tbpTitles.Controls.Add(Me.lblSubTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.tbpTitles.Controls.Add(Me.lblCaption)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphCaption)
        Me.tbpTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitles.Size = New System.Drawing.Size(262, 109)
        Me.tbpTitles.TabIndex = 2
        Me.tbpTitles.Tag = "Titles"
        Me.tbpTitles.Text = "Titles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Title:"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.AutoSize = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(66, 9)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphTitle.TabIndex = 9
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitle.Location = New System.Drawing.Point(7, 39)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(52, 13)
        Me.lblSubTitle.TabIndex = 10
        Me.lblSubTitle.Text = "Sub Title:"
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.AutoSize = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        Me.ucrInputGraphSubTitle.Location = New System.Drawing.Point(66, 35)
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        Me.ucrInputGraphSubTitle.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphSubTitle.TabIndex = 9
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaption.Location = New System.Drawing.Point(7, 68)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(46, 13)
        Me.lblCaption.TabIndex = 10
        Me.lblCaption.Text = "Caption:"
        '
        'ucrInputGraphCaption
        '
        Me.ucrInputGraphCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphCaption.AutoSize = True
        Me.ucrInputGraphCaption.IsMultiline = False
        Me.ucrInputGraphCaption.IsReadOnly = False
        Me.ucrInputGraphCaption.Location = New System.Drawing.Point(66, 64)
        Me.ucrInputGraphCaption.Name = "ucrInputGraphCaption"
        Me.ucrInputGraphCaption.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphCaption.TabIndex = 9
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.lblXAxisTitle)
        Me.tbpXAxis.Controls.Add(Me.rdoXAxisSpecifyTitle)
        Me.tbpXAxis.Controls.Add(Me.rdoXAxisNoTitle)
        Me.tbpXAxis.Controls.Add(Me.rdoXAxisAuto)
        Me.tbpXAxis.Controls.Add(Me.ucrInputXAxisLabel)
        Me.tbpXAxis.Controls.Add(Me.ucrPnlXAxis)
        Me.tbpXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpXAxis.Size = New System.Drawing.Size(262, 109)
        Me.tbpXAxis.TabIndex = 5
        Me.tbpXAxis.Text = "X-Axis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'lblXAxisTitle
        '
        Me.lblXAxisTitle.AutoSize = True
        Me.lblXAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXAxisTitle.Location = New System.Drawing.Point(5, 41)
        Me.lblXAxisTitle.Name = "lblXAxisTitle"
        Me.lblXAxisTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblXAxisTitle.TabIndex = 26
        Me.lblXAxisTitle.Text = "Title:"
        '
        'rdoXAxisSpecifyTitle
        '
        Me.rdoXAxisSpecifyTitle.AutoSize = True
        Me.rdoXAxisSpecifyTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoXAxisSpecifyTitle.Location = New System.Drawing.Point(58, 11)
        Me.rdoXAxisSpecifyTitle.Name = "rdoXAxisSpecifyTitle"
        Me.rdoXAxisSpecifyTitle.Size = New System.Drawing.Size(83, 17)
        Me.rdoXAxisSpecifyTitle.TabIndex = 23
        Me.rdoXAxisSpecifyTitle.TabStop = True
        Me.rdoXAxisSpecifyTitle.Text = "Specify Title"
        Me.rdoXAxisSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoXAxisNoTitle
        '
        Me.rdoXAxisNoTitle.AutoSize = True
        Me.rdoXAxisNoTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoXAxisNoTitle.Location = New System.Drawing.Point(152, 11)
        Me.rdoXAxisNoTitle.Name = "rdoXAxisNoTitle"
        Me.rdoXAxisNoTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoXAxisNoTitle.TabIndex = 24
        Me.rdoXAxisNoTitle.TabStop = True
        Me.rdoXAxisNoTitle.Text = "No Title"
        Me.rdoXAxisNoTitle.UseVisualStyleBackColor = True
        '
        'rdoXAxisAuto
        '
        Me.rdoXAxisAuto.AutoSize = True
        Me.rdoXAxisAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoXAxisAuto.Location = New System.Drawing.Point(5, 11)
        Me.rdoXAxisAuto.Name = "rdoXAxisAuto"
        Me.rdoXAxisAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoXAxisAuto.TabIndex = 22
        Me.rdoXAxisAuto.TabStop = True
        Me.rdoXAxisAuto.Text = "Auto"
        Me.rdoXAxisAuto.UseVisualStyleBackColor = True
        '
        'ucrInputXAxisLabel
        '
        Me.ucrInputXAxisLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisLabel.AutoSize = True
        Me.ucrInputXAxisLabel.IsMultiline = False
        Me.ucrInputXAxisLabel.IsReadOnly = False
        Me.ucrInputXAxisLabel.Location = New System.Drawing.Point(38, 37)
        Me.ucrInputXAxisLabel.Name = "ucrInputXAxisLabel"
        Me.ucrInputXAxisLabel.Size = New System.Drawing.Size(131, 21)
        Me.ucrInputXAxisLabel.TabIndex = 21
        '
        'ucrPnlXAxis
        '
        Me.ucrPnlXAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlXAxis.Location = New System.Drawing.Point(3, 8)
        Me.ucrPnlXAxis.Name = "ucrPnlXAxis"
        Me.ucrPnlXAxis.Size = New System.Drawing.Size(209, 23)
        Me.ucrPnlXAxis.TabIndex = 25
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.lblYAxisTitle)
        Me.tbpYAxis.Controls.Add(Me.rdoYAxisSpecifyTitle)
        Me.tbpYAxis.Controls.Add(Me.rdoYAxisNoTitle)
        Me.tbpYAxis.Controls.Add(Me.rdoYAxisAuto)
        Me.tbpYAxis.Controls.Add(Me.ucrInputYAxisLabel)
        Me.tbpYAxis.Controls.Add(Me.ucrPnlYAxis)
        Me.tbpYAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpYAxis.Size = New System.Drawing.Size(262, 109)
        Me.tbpYAxis.TabIndex = 6
        Me.tbpYAxis.Text = "Y-Axis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'lblYAxisTitle
        '
        Me.lblYAxisTitle.AutoSize = True
        Me.lblYAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYAxisTitle.Location = New System.Drawing.Point(6, 44)
        Me.lblYAxisTitle.Name = "lblYAxisTitle"
        Me.lblYAxisTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblYAxisTitle.TabIndex = 26
        Me.lblYAxisTitle.Text = "Title:"
        '
        'rdoYAxisSpecifyTitle
        '
        Me.rdoYAxisSpecifyTitle.AutoSize = True
        Me.rdoYAxisSpecifyTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYAxisSpecifyTitle.Location = New System.Drawing.Point(59, 14)
        Me.rdoYAxisSpecifyTitle.Name = "rdoYAxisSpecifyTitle"
        Me.rdoYAxisSpecifyTitle.Size = New System.Drawing.Size(83, 17)
        Me.rdoYAxisSpecifyTitle.TabIndex = 23
        Me.rdoYAxisSpecifyTitle.TabStop = True
        Me.rdoYAxisSpecifyTitle.Text = "Specify Title"
        Me.rdoYAxisSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoYAxisNoTitle
        '
        Me.rdoYAxisNoTitle.AutoSize = True
        Me.rdoYAxisNoTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYAxisNoTitle.Location = New System.Drawing.Point(153, 14)
        Me.rdoYAxisNoTitle.Name = "rdoYAxisNoTitle"
        Me.rdoYAxisNoTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoYAxisNoTitle.TabIndex = 24
        Me.rdoYAxisNoTitle.TabStop = True
        Me.rdoYAxisNoTitle.Text = "No Title"
        Me.rdoYAxisNoTitle.UseVisualStyleBackColor = True
        '
        'rdoYAxisAuto
        '
        Me.rdoYAxisAuto.AutoSize = True
        Me.rdoYAxisAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYAxisAuto.Location = New System.Drawing.Point(6, 14)
        Me.rdoYAxisAuto.Name = "rdoYAxisAuto"
        Me.rdoYAxisAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoYAxisAuto.TabIndex = 22
        Me.rdoYAxisAuto.TabStop = True
        Me.rdoYAxisAuto.Text = "Auto"
        Me.rdoYAxisAuto.UseVisualStyleBackColor = True
        '
        'ucrInputYAxisLabel
        '
        Me.ucrInputYAxisLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisLabel.AutoSize = True
        Me.ucrInputYAxisLabel.IsMultiline = False
        Me.ucrInputYAxisLabel.IsReadOnly = False
        Me.ucrInputYAxisLabel.Location = New System.Drawing.Point(40, 40)
        Me.ucrInputYAxisLabel.Name = "ucrInputYAxisLabel"
        Me.ucrInputYAxisLabel.Size = New System.Drawing.Size(134, 21)
        Me.ucrInputYAxisLabel.TabIndex = 21
        '
        'ucrPnlYAxis
        '
        Me.ucrPnlYAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlYAxis.Location = New System.Drawing.Point(4, 11)
        Me.ucrPnlYAxis.Name = "ucrPnlYAxis"
        Me.ucrPnlYAxis.Size = New System.Drawing.Size(209, 23)
        Me.ucrPnlYAxis.TabIndex = 25
        '
        'tbpTheme
        '
        Me.tbpTheme.Controls.Add(Me.lblSelectTheme)
        Me.tbpTheme.Controls.Add(Me.ucrInputThemes)
        Me.tbpTheme.Controls.Add(Me.lblFont)
        Me.tbpTheme.Location = New System.Drawing.Point(4, 22)
        Me.tbpTheme.Name = "tbpTheme"
        Me.tbpTheme.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTheme.Size = New System.Drawing.Size(262, 109)
        Me.tbpTheme.TabIndex = 1
        Me.tbpTheme.Tag = "Theme"
        Me.tbpTheme.Text = "Themes"
        Me.tbpTheme.UseVisualStyleBackColor = True
        '
        'lblSelectTheme
        '
        Me.lblSelectTheme.AutoSize = True
        Me.lblSelectTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectTheme.Location = New System.Drawing.Point(3, 19)
        Me.lblSelectTheme.Name = "lblSelectTheme"
        Me.lblSelectTheme.Size = New System.Drawing.Size(76, 13)
        Me.lblSelectTheme.TabIndex = 110
        Me.lblSelectTheme.Text = "Select Theme:"
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThemes.GetSetSelectedIndex = -1
        Me.ucrInputThemes.IsReadOnly = False
        Me.ucrInputThemes.Location = New System.Drawing.Point(83, 15)
        Me.ucrInputThemes.Name = "ucrInputThemes"
        Me.ucrInputThemes.Size = New System.Drawing.Size(128, 21)
        Me.ucrInputThemes.TabIndex = 109
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFont.Location = New System.Drawing.Point(233, 49)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(0, 13)
        Me.lblFont.TabIndex = 4
        '
        'sdgDistributionOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(283, 188)
        Me.Controls.Add(Me.tbpPlotsOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDistributionOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distribution Options"
        Me.tbpPlotsOptions.ResumeLayout(False)
        Me.tbpTitles.ResumeLayout(False)
        Me.tbpTitles.PerformLayout()
        Me.tbpXAxis.ResumeLayout(False)
        Me.tbpXAxis.PerformLayout()
        Me.tbpYAxis.ResumeLayout(False)
        Me.tbpYAxis.PerformLayout()
        Me.tbpTheme.ResumeLayout(False)
        Me.tbpTheme.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbpPlotsOptions As TabControl
    Friend WithEvents tbpTitles As TabPage
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputGraphCaption As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents tbpXAxis As TabPage
    Friend WithEvents tbpYAxis As TabPage
    Friend WithEvents tbpTheme As TabPage
    Friend WithEvents lblFont As Label
    Friend WithEvents ucrInputThemes As ucrInputComboBox
    Friend WithEvents lblSelectTheme As Label
    Friend WithEvents lblYAxisTitle As Label
    Friend WithEvents rdoYAxisSpecifyTitle As RadioButton
    Friend WithEvents rdoYAxisNoTitle As RadioButton
    Friend WithEvents rdoYAxisAuto As RadioButton
    Friend WithEvents ucrInputYAxisLabel As ucrInputTextBox
    Friend WithEvents ucrPnlYAxis As UcrPanel
    Friend WithEvents lblXAxisTitle As Label
    Friend WithEvents rdoXAxisSpecifyTitle As RadioButton
    Friend WithEvents rdoXAxisNoTitle As RadioButton
    Friend WithEvents rdoXAxisAuto As RadioButton
    Friend WithEvents ucrInputXAxisLabel As ucrInputTextBox
    Friend WithEvents ucrPnlXAxis As UcrPanel
End Class
