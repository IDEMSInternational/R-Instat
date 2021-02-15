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
        Me.grpGraph = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.urChkSelectTheme = New instat.ucrCheck()
        Me.ucrInputThemes = New instat.ucrInputComboBox()
        Me.lblYAxis = New System.Windows.Forms.Label()
        Me.UcrInputTextBox2 = New instat.ucrInputTextBox()
        Me.lblXAxis = New System.Windows.Forms.Label()
        Me.UcrInputTextBox1 = New instat.ucrInputTextBox()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.ucrInputGraphCaption = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.tbpXAxis = New System.Windows.Forms.TabPage()
        Me.tbpYAxis = New System.Windows.Forms.TabPage()
        Me.tbpTheme = New System.Windows.Forms.TabPage()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.tbpPlotsOptions.SuspendLayout()
        Me.tbpTitles.SuspendLayout()
        Me.grpGraph.SuspendLayout()
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
        Me.tbpTitles.Controls.Add(Me.grpGraph)
        Me.tbpTitles.Controls.Add(Me.urChkSelectTheme)
        Me.tbpTitles.Controls.Add(Me.ucrInputThemes)
        Me.tbpTitles.Controls.Add(Me.lblYAxis)
        Me.tbpTitles.Controls.Add(Me.UcrInputTextBox2)
        Me.tbpTitles.Controls.Add(Me.lblXAxis)
        Me.tbpTitles.Controls.Add(Me.UcrInputTextBox1)
        resources.ApplyResources(Me.tbpTitles, "tbpTitles")
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Tag = "Titles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'grpGraph
        '
        Me.grpGraph.Controls.Add(Me.Label1)
        Me.grpGraph.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraph.Controls.Add(Me.lblSubTitle)
        Me.grpGraph.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.grpGraph.Controls.Add(Me.lblCaption)
        Me.grpGraph.Controls.Add(Me.ucrInputGraphCaption)
        resources.ApplyResources(Me.grpGraph, "grpGraph")
        Me.grpGraph.Name = "grpGraph"
        Me.grpGraph.TabStop = False
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
        'urChkSelectTheme
        '
        Me.urChkSelectTheme.Checked = False
        resources.ApplyResources(Me.urChkSelectTheme, "urChkSelectTheme")
        Me.urChkSelectTheme.Name = "urChkSelectTheme"
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputThemes.GetSetSelectedIndex = -1
        Me.ucrInputThemes.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputThemes, "ucrInputThemes")
        Me.ucrInputThemes.Name = "ucrInputThemes"
        '
        'lblYAxis
        '
        resources.ApplyResources(Me.lblYAxis, "lblYAxis")
        Me.lblYAxis.Name = "lblYAxis"
        '
        'UcrInputTextBox2
        '
        Me.UcrInputTextBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputTextBox2.IsMultiline = False
        Me.UcrInputTextBox2.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputTextBox2, "UcrInputTextBox2")
        Me.UcrInputTextBox2.Name = "UcrInputTextBox2"
        '
        'lblXAxis
        '
        resources.ApplyResources(Me.lblXAxis, "lblXAxis")
        Me.lblXAxis.Name = "lblXAxis"
        '
        'UcrInputTextBox1
        '
        Me.UcrInputTextBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputTextBox1.IsMultiline = False
        Me.UcrInputTextBox1.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputTextBox1, "UcrInputTextBox1")
        Me.UcrInputTextBox1.Name = "UcrInputTextBox1"
        '
        'lblCaption
        '
        resources.ApplyResources(Me.lblCaption, "lblCaption")
        Me.lblCaption.Name = "lblCaption"
        '
        'lblSubTitle
        '
        resources.ApplyResources(Me.lblSubTitle, "lblSubTitle")
        Me.lblSubTitle.Name = "lblSubTitle"
        '
        'ucrInputGraphCaption
        '
        Me.ucrInputGraphCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphCaption.IsMultiline = False
        Me.ucrInputGraphCaption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphCaption, "ucrInputGraphCaption")
        Me.ucrInputGraphCaption.Name = "ucrInputGraphCaption"
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphSubTitle, "ucrInputGraphSubTitle")
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        '
        'tbpXAxis
        '
        resources.ApplyResources(Me.tbpXAxis, "tbpXAxis")
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'tbpYAxis
        '
        resources.ApplyResources(Me.tbpYAxis, "tbpYAxis")
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'tbpTheme
        '
        Me.tbpTheme.Controls.Add(Me.lblFont)
        resources.ApplyResources(Me.tbpTheme, "tbpTheme")
        Me.tbpTheme.Name = "tbpTheme"
        Me.tbpTheme.Tag = "Theme"
        Me.tbpTheme.UseVisualStyleBackColor = True
        '
        'lblFont
        '
        resources.ApplyResources(Me.lblFont, "lblFont")
        Me.lblFont.Name = "lblFont"
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
        Me.grpGraph.ResumeLayout(False)
        Me.grpGraph.PerformLayout()
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
    Friend WithEvents urChkSelectTheme As ucrCheck
    Friend WithEvents ucrInputThemes As ucrInputComboBox
    Friend WithEvents lblYAxis As Label
    Friend WithEvents UcrInputTextBox2 As ucrInputTextBox
    Friend WithEvents lblXAxis As Label
    Friend WithEvents UcrInputTextBox1 As ucrInputTextBox
    Friend WithEvents grpGraph As GroupBox
End Class
