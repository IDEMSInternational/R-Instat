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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgDistributionOptions))
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
        Me.lblXAxisTitle = New System.Windows.Forms.Label()
        Me.rdoXAxisSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoXAxisNoTitle = New System.Windows.Forms.RadioButton()
        Me.rdoXAxisAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputXAxisLabel = New instat.ucrInputTextBox()
        Me.ucrPnlXAxis = New instat.UcrPanel()
        Me.tbpPlotsOptions.SuspendLayout()
        Me.tbpTitles.SuspendLayout()
        Me.tbpXAxis.SuspendLayout()
        Me.tbpYAxis.SuspendLayout()
        Me.tbpTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'tbpPlotsOptions
        '
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTitles)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpXAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpYAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTheme)
        resources.ApplyResources(Me.tbpPlotsOptions, "tbpPlotsOptions")
        Me.tbpPlotsOptions.Name = "tbpPlotsOptions"
        Me.tbpPlotsOptions.SelectedIndex = 0
        '
        'tbpTitles
        '
        Me.tbpTitles.Controls.Add(Me.Label1)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.tbpTitles.Controls.Add(Me.lblSubTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.tbpTitles.Controls.Add(Me.lblCaption)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphCaption)
        resources.ApplyResources(Me.tbpTitles, "tbpTitles")
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Tag = "Titles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphTitle, "ucrInputGraphTitle")
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        '
        'lblSubTitle
        '
        resources.ApplyResources(Me.lblSubTitle, "lblSubTitle")
        Me.lblSubTitle.Name = "lblSubTitle"
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphSubTitle, "ucrInputGraphSubTitle")
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        '
        'lblCaption
        '
        resources.ApplyResources(Me.lblCaption, "lblCaption")
        Me.lblCaption.Name = "lblCaption"
        '
        'ucrInputGraphCaption
        '
        Me.ucrInputGraphCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphCaption.IsMultiline = False
        Me.ucrInputGraphCaption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphCaption, "ucrInputGraphCaption")
        Me.ucrInputGraphCaption.Name = "ucrInputGraphCaption"
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.lblXAxisTitle)
        Me.tbpXAxis.Controls.Add(Me.rdoXAxisSpecifyTitle)
        Me.tbpXAxis.Controls.Add(Me.rdoXAxisNoTitle)
        Me.tbpXAxis.Controls.Add(Me.rdoXAxisAuto)
        Me.tbpXAxis.Controls.Add(Me.ucrInputXAxisLabel)
        Me.tbpXAxis.Controls.Add(Me.ucrPnlXAxis)
        resources.ApplyResources(Me.tbpXAxis, "tbpXAxis")
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.lblYAxisTitle)
        Me.tbpYAxis.Controls.Add(Me.rdoYAxisSpecifyTitle)
        Me.tbpYAxis.Controls.Add(Me.rdoYAxisNoTitle)
        Me.tbpYAxis.Controls.Add(Me.rdoYAxisAuto)
        Me.tbpYAxis.Controls.Add(Me.ucrInputYAxisLabel)
        Me.tbpYAxis.Controls.Add(Me.ucrPnlYAxis)
        resources.ApplyResources(Me.tbpYAxis, "tbpYAxis")
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'lblYAxisTitle
        '
        resources.ApplyResources(Me.lblYAxisTitle, "lblYAxisTitle")
        Me.lblYAxisTitle.Name = "lblYAxisTitle"
        '
        'rdoYAxisSpecifyTitle
        '
        resources.ApplyResources(Me.rdoYAxisSpecifyTitle, "rdoYAxisSpecifyTitle")
        Me.rdoYAxisSpecifyTitle.Name = "rdoYAxisSpecifyTitle"
        Me.rdoYAxisSpecifyTitle.TabStop = True
        Me.rdoYAxisSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoYAxisNoTitle
        '
        resources.ApplyResources(Me.rdoYAxisNoTitle, "rdoYAxisNoTitle")
        Me.rdoYAxisNoTitle.Name = "rdoYAxisNoTitle"
        Me.rdoYAxisNoTitle.TabStop = True
        Me.rdoYAxisNoTitle.UseVisualStyleBackColor = True
        '
        'rdoYAxisAuto
        '
        resources.ApplyResources(Me.rdoYAxisAuto, "rdoYAxisAuto")
        Me.rdoYAxisAuto.Name = "rdoYAxisAuto"
        Me.rdoYAxisAuto.TabStop = True
        Me.rdoYAxisAuto.UseVisualStyleBackColor = True
        '
        'ucrInputYAxisLabel
        '
        Me.ucrInputYAxisLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisLabel.IsMultiline = False
        Me.ucrInputYAxisLabel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYAxisLabel, "ucrInputYAxisLabel")
        Me.ucrInputYAxisLabel.Name = "ucrInputYAxisLabel"
        '
        'ucrPnlYAxis
        '
        resources.ApplyResources(Me.ucrPnlYAxis, "ucrPnlYAxis")
        Me.ucrPnlYAxis.Name = "ucrPnlYAxis"
        '
        'tbpTheme
        '
        Me.tbpTheme.Controls.Add(Me.lblSelectTheme)
        Me.tbpTheme.Controls.Add(Me.ucrInputThemes)
        Me.tbpTheme.Controls.Add(Me.lblFont)
        resources.ApplyResources(Me.tbpTheme, "tbpTheme")
        Me.tbpTheme.Name = "tbpTheme"
        Me.tbpTheme.Tag = "Theme"
        Me.tbpTheme.UseVisualStyleBackColor = True
        '
        'lblSelectTheme
        '
        resources.ApplyResources(Me.lblSelectTheme, "lblSelectTheme")
        Me.lblSelectTheme.Name = "lblSelectTheme"
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputThemes.GetSetSelectedIndex = -1
        Me.ucrInputThemes.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputThemes, "ucrInputThemes")
        Me.ucrInputThemes.Name = "ucrInputThemes"
        '
        'lblFont
        '
        resources.ApplyResources(Me.lblFont, "lblFont")
        Me.lblFont.Name = "lblFont"
        '
        'lblXAxisTitle
        '
        resources.ApplyResources(Me.lblXAxisTitle, "lblXAxisTitle")
        Me.lblXAxisTitle.Name = "lblXAxisTitle"
        '
        'rdoXAxisSpecifyTitle
        '
        resources.ApplyResources(Me.rdoXAxisSpecifyTitle, "rdoXAxisSpecifyTitle")
        Me.rdoXAxisSpecifyTitle.Name = "rdoXAxisSpecifyTitle"
        Me.rdoXAxisSpecifyTitle.TabStop = True
        Me.rdoXAxisSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoXAxisNoTitle
        '
        resources.ApplyResources(Me.rdoXAxisNoTitle, "rdoXAxisNoTitle")
        Me.rdoXAxisNoTitle.Name = "rdoXAxisNoTitle"
        Me.rdoXAxisNoTitle.TabStop = True
        Me.rdoXAxisNoTitle.UseVisualStyleBackColor = True
        '
        'rdoXAxisAuto
        '
        resources.ApplyResources(Me.rdoXAxisAuto, "rdoXAxisAuto")
        Me.rdoXAxisAuto.Name = "rdoXAxisAuto"
        Me.rdoXAxisAuto.TabStop = True
        Me.rdoXAxisAuto.UseVisualStyleBackColor = True
        '
        'ucrInputXAxisLabel
        '
        Me.ucrInputXAxisLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisLabel.IsMultiline = False
        Me.ucrInputXAxisLabel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXAxisLabel, "ucrInputXAxisLabel")
        Me.ucrInputXAxisLabel.Name = "ucrInputXAxisLabel"
        '
        'ucrPnlXAxis
        '
        resources.ApplyResources(Me.ucrPnlXAxis, "ucrPnlXAxis")
        Me.ucrPnlXAxis.Name = "ucrPnlXAxis"
        '
        'sdgDistributionOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbpPlotsOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDistributionOptions"
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
