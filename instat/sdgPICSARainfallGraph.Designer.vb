<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPICSARainfallGraph
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgPICSARainfallGraph))
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.ucrChkPlotMean = New instat.ucrCheck()
        Me.ucrChkPlotMedian = New instat.ucrCheck()
        Me.ucrChkPlotTerciles = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrSdgPICSARainfalbuttons
        '
        resources.ApplyResources(Me.ucrSdgPICSARainfalbuttons, "ucrSdgPICSARainfalbuttons")
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        '
        'ucrChkPlotMean
        '
        Me.ucrChkPlotMean.Checked = False
        resources.ApplyResources(Me.ucrChkPlotMean, "ucrChkPlotMean")
        Me.ucrChkPlotMean.Name = "ucrChkPlotMean"
        '
        'ucrChkPlotMedian
        '
        Me.ucrChkPlotMedian.Checked = False
        resources.ApplyResources(Me.ucrChkPlotMedian, "ucrChkPlotMedian")
        Me.ucrChkPlotMedian.Name = "ucrChkPlotMedian"
        '
        'ucrChkPlotTerciles
        '
        Me.ucrChkPlotTerciles.Checked = False
        resources.ApplyResources(Me.ucrChkPlotTerciles, "ucrChkPlotTerciles")
        Me.ucrChkPlotTerciles.Name = "ucrChkPlotTerciles"
        '
        'sdgPICSARainfallGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkPlotTerciles)
        Me.Controls.Add(Me.ucrChkPlotMedian)
        Me.Controls.Add(Me.ucrChkPlotMean)
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPICSARainfallGraph"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents ucrChkPlotMean As ucrCheck
    Friend WithEvents ucrChkPlotMedian As ucrCheck
    Friend WithEvents ucrChkPlotTerciles As ucrCheck
End Class
