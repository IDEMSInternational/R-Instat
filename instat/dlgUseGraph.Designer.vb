<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgUseGraph
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrGraphsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrGraphReceiver = New instat.ucrReceiverSingle()
        Me.lblGraphtoUse = New System.Windows.Forms.Label()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrSaveGraphForUseGraph = New instat.ucrSaveGraph()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 241)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrGraphsSelector
        '
        Me.ucrGraphsSelector.bShowHiddenColumns = False
        Me.ucrGraphsSelector.bUseCurrentFilter = False
        Me.ucrGraphsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrGraphsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphsSelector.Name = "ucrGraphsSelector"
        Me.ucrGraphsSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrGraphsSelector.TabIndex = 1
        '
        'ucrGraphReceiver
        '
        Me.ucrGraphReceiver.Location = New System.Drawing.Point(252, 44)
        Me.ucrGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphReceiver.Name = "ucrGraphReceiver"
        Me.ucrGraphReceiver.Selector = Nothing
        Me.ucrGraphReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrGraphReceiver.TabIndex = 2
        '
        'lblGraphtoUse
        '
        Me.lblGraphtoUse.AutoSize = True
        Me.lblGraphtoUse.Location = New System.Drawing.Point(249, 19)
        Me.lblGraphtoUse.Name = "lblGraphtoUse"
        Me.lblGraphtoUse.Size = New System.Drawing.Size(70, 13)
        Me.lblGraphtoUse.TabIndex = 3
        Me.lblGraphtoUse.Text = "Graph to Use"
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(252, 95)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlotOptions.TabIndex = 4
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveGraphForUseGraph
        '
        Me.ucrSaveGraphForUseGraph.Location = New System.Drawing.Point(13, 209)
        Me.ucrSaveGraphForUseGraph.Name = "ucrSaveGraphForUseGraph"
        Me.ucrSaveGraphForUseGraph.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveGraphForUseGraph.TabIndex = 5
        '
        'dlgUseGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 294)
        Me.Controls.Add(Me.ucrSaveGraphForUseGraph)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.lblGraphtoUse)
        Me.Controls.Add(Me.ucrGraphReceiver)
        Me.Controls.Add(Me.ucrGraphsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Use_Graph"
        Me.Text = "Use Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrGraphsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrGraphReceiver As ucrReceiverSingle
    Friend WithEvents lblGraphtoUse As Label
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrSaveGraphForUseGraph As ucrSaveGraph
End Class
