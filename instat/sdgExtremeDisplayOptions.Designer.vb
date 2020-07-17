<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgExtremeDisplayOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgExtremeDisplayOptions))
        Me.ucrPnlExtreme = New instat.UcrPanel()
        Me.rdoZPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQ2 = New System.Windows.Forms.RadioButton()
        Me.rdoProbprob = New System.Windows.Forms.RadioButton()
        Me.rdoPrimary = New System.Windows.Forms.RadioButton()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoHist = New System.Windows.Forms.RadioButton()
        Me.rdoRlplot = New System.Windows.Forms.RadioButton()
        Me.rdoTrace = New System.Windows.Forms.RadioButton()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.grpPlots.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrPnlExtreme
        '
        resources.ApplyResources(Me.ucrPnlExtreme, "ucrPnlExtreme")
        Me.ucrPnlExtreme.Name = "ucrPnlExtreme"
        '
        'rdoZPlot
        '
        resources.ApplyResources(Me.rdoZPlot, "rdoZPlot")
        Me.rdoZPlot.Name = "rdoZPlot"
        Me.rdoZPlot.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        resources.ApplyResources(Me.rdoQQPlot, "rdoQQPlot")
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoQQ2
        '
        resources.ApplyResources(Me.rdoQQ2, "rdoQQ2")
        Me.rdoQQ2.Name = "rdoQQ2"
        Me.rdoQQ2.UseVisualStyleBackColor = True
        '
        'rdoProbprob
        '
        resources.ApplyResources(Me.rdoProbprob, "rdoProbprob")
        Me.rdoProbprob.Name = "rdoProbprob"
        Me.rdoProbprob.UseVisualStyleBackColor = True
        '
        'rdoPrimary
        '
        resources.ApplyResources(Me.rdoPrimary, "rdoPrimary")
        Me.rdoPrimary.Name = "rdoPrimary"
        Me.rdoPrimary.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        resources.ApplyResources(Me.rdoNoPlot, "rdoNoPlot")
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.ucrSavePlots)
        Me.grpPlots.Controls.Add(Me.rdoTrace)
        Me.grpPlots.Controls.Add(Me.rdoRlplot)
        Me.grpPlots.Controls.Add(Me.rdoHist)
        Me.grpPlots.Controls.Add(Me.rdoDensity)
        Me.grpPlots.Controls.Add(Me.rdoZPlot)
        Me.grpPlots.Controls.Add(Me.rdoProbprob)
        Me.grpPlots.Controls.Add(Me.rdoQQPlot)
        Me.grpPlots.Controls.Add(Me.rdoNoPlot)
        Me.grpPlots.Controls.Add(Me.rdoQQ2)
        Me.grpPlots.Controls.Add(Me.rdoPrimary)
        Me.grpPlots.Controls.Add(Me.ucrPnlExtreme)
        resources.ApplyResources(Me.grpPlots, "grpPlots")
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.TabStop = False
        '
        'rdoDensity
        '
        resources.ApplyResources(Me.rdoDensity, "rdoDensity")
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoHist
        '
        resources.ApplyResources(Me.rdoHist, "rdoHist")
        Me.rdoHist.Name = "rdoHist"
        Me.rdoHist.UseVisualStyleBackColor = True
        '
        'rdoRlplot
        '
        resources.ApplyResources(Me.rdoRlplot, "rdoRlplot")
        Me.rdoRlplot.Name = "rdoRlplot"
        Me.rdoRlplot.UseVisualStyleBackColor = True
        '
        'rdoTrace
        '
        resources.ApplyResources(Me.rdoTrace, "rdoTrace")
        Me.rdoTrace.Name = "rdoTrace"
        Me.rdoTrace.UseVisualStyleBackColor = True
        '
        'ucrSavePlots
        '
        resources.ApplyResources(Me.ucrSavePlots, "ucrSavePlots")
        Me.ucrSavePlots.Name = "ucrSavePlots"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'sdgExtremeDisplayOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpPlots)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExtremeDisplayOptions"
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrPnlExtreme As UcrPanel
    Friend WithEvents rdoZPlot As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoQQ2 As RadioButton
    Friend WithEvents rdoProbprob As RadioButton
    Friend WithEvents rdoPrimary As RadioButton
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents rdoTrace As RadioButton
    Friend WithEvents rdoRlplot As RadioButton
    Friend WithEvents rdoHist As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents ucrSavePlots As ucrSave
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
End Class
