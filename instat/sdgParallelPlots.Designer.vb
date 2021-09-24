<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgParallelPlots
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgParallelPlots))
        Me.ucrBaseSdgParallelPlot = New instat.ucrButtonsSubdialogue()
        Me.ucrInputMissing = New instat.ucrInputComboBox()
        Me.ucrInputOrder = New instat.ucrInputComboBox()
        Me.lblMissing = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBaseSdgParallelPlot
        '
        resources.ApplyResources(Me.ucrBaseSdgParallelPlot, "ucrBaseSdgParallelPlot")
        Me.ucrBaseSdgParallelPlot.Name = "ucrBaseSdgParallelPlot"
        '
        'ucrInputMissing
        '
        Me.ucrInputMissing.AddQuotesIfUnrecognised = True
        Me.ucrInputMissing.GetSetSelectedIndex = -1
        Me.ucrInputMissing.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMissing, "ucrInputMissing")
        Me.ucrInputMissing.Name = "ucrInputMissing"
        '
        'ucrInputOrder
        '
        Me.ucrInputOrder.AddQuotesIfUnrecognised = True
        Me.ucrInputOrder.GetSetSelectedIndex = -1
        Me.ucrInputOrder.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOrder, "ucrInputOrder")
        Me.ucrInputOrder.Name = "ucrInputOrder"
        '
        'lblMissing
        '
        resources.ApplyResources(Me.lblMissing, "lblMissing")
        Me.lblMissing.Name = "lblMissing"
        '
        'lblOrder
        '
        resources.ApplyResources(Me.lblOrder, "lblOrder")
        Me.lblOrder.Name = "lblOrder"
        '
        'sdgParallelPlots
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblMissing)
        Me.Controls.Add(Me.ucrInputOrder)
        Me.Controls.Add(Me.ucrInputMissing)
        Me.Controls.Add(Me.ucrBaseSdgParallelPlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgParallelPlots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdgParallelPlot As ucrButtonsSubdialogue
    Friend WithEvents ucrInputMissing As ucrInputComboBox
    Friend WithEvents ucrInputOrder As ucrInputComboBox
    Friend WithEvents lblMissing As Label
    Friend WithEvents lblOrder As Label
End Class
