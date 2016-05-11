<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCreateNewTheme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCreateNewTheme))
        Me.ucrBase = New instat.ucrButtons()
        Me.tbcCreateNewTheme = New System.Windows.Forms.TabControl()
        Me.tbpAxes = New System.Windows.Forms.TabPage()
        Me.tbpPanel = New System.Windows.Forms.TabPage()
        Me.tbpLegend = New System.Windows.Forms.TabPage()
        Me.tbpTitles = New System.Windows.Forms.TabPage()
        Me.tbcCreateNewTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'tbcCreateNewTheme
        '
        Me.tbcCreateNewTheme.Controls.Add(Me.tbpAxes)
        Me.tbcCreateNewTheme.Controls.Add(Me.tbpPanel)
        Me.tbcCreateNewTheme.Controls.Add(Me.tbpLegend)
        Me.tbcCreateNewTheme.Controls.Add(Me.tbpTitles)
        resources.ApplyResources(Me.tbcCreateNewTheme, "tbcCreateNewTheme")
        Me.tbcCreateNewTheme.Name = "tbcCreateNewTheme"
        Me.tbcCreateNewTheme.SelectedIndex = 0
        '
        'tbpAxes
        '
        resources.ApplyResources(Me.tbpAxes, "tbpAxes")
        Me.tbpAxes.Name = "tbpAxes"
        Me.tbpAxes.UseVisualStyleBackColor = True
        '
        'tbpPanel
        '
        resources.ApplyResources(Me.tbpPanel, "tbpPanel")
        Me.tbpPanel.Name = "tbpPanel"
        Me.tbpPanel.UseVisualStyleBackColor = True
        '
        'tbpLegend
        '
        resources.ApplyResources(Me.tbpLegend, "tbpLegend")
        Me.tbpLegend.Name = "tbpLegend"
        Me.tbpLegend.UseVisualStyleBackColor = True
        '
        'tbpTitles
        '
        resources.ApplyResources(Me.tbpTitles, "tbpTitles")
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'dlgCreateNewTheme
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcCreateNewTheme)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCreateNewTheme"
        Me.tbcCreateNewTheme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents tbcCreateNewTheme As TabControl
    Friend WithEvents tbpAxes As TabPage
    Friend WithEvents tbpPanel As TabPage
    Friend WithEvents tbpLegend As TabPage
    Friend WithEvents tbpTitles As TabPage
End Class
