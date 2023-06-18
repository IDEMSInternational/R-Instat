<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgGraphsGUI
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
        Me.ucrSelectorGraphGUI = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblGraphGUI = New System.Windows.Forms.Label()
        Me.ucrReceiverGraphs = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(0, 218)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 2
        '
        'ucrSelectorGraphGUI
        '
        Me.ucrSelectorGraphGUI.AutoSize = True
        Me.ucrSelectorGraphGUI.bDropUnusedFilterLevels = False
        Me.ucrSelectorGraphGUI.bShowHiddenColumns = False
        Me.ucrSelectorGraphGUI.bUseCurrentFilter = True
        Me.ucrSelectorGraphGUI.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorGraphGUI.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGraphGUI.Name = "ucrSelectorGraphGUI"
        Me.ucrSelectorGraphGUI.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorGraphGUI.TabIndex = 3
        '
        'lblGraphGUI
        '
        Me.lblGraphGUI.AutoSize = True
        Me.lblGraphGUI.Location = New System.Drawing.Point(249, 39)
        Me.lblGraphGUI.Name = "lblGraphGUI"
        Me.lblGraphGUI.Size = New System.Drawing.Size(107, 13)
        Me.lblGraphGUI.TabIndex = 5
        Me.lblGraphGUI.Text = "Selected Data Frame"
        '
        'ucrReceiverGraphs
        '
        Me.ucrReceiverGraphs.AutoSize = True
        Me.ucrReceiverGraphs.frmParent = Me
        Me.ucrReceiverGraphs.Location = New System.Drawing.Point(252, 67)
        Me.ucrReceiverGraphs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGraphs.Name = "ucrReceiverGraphs"
        Me.ucrReceiverGraphs.Selector = Nothing
        Me.ucrReceiverGraphs.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverGraphs.strNcFilePath = ""
        Me.ucrReceiverGraphs.TabIndex = 6
        Me.ucrReceiverGraphs.ucrSelector = Nothing
        '
        'dlgGraphsGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(410, 279)
        Me.Controls.Add(Me.ucrReceiverGraphs)
        Me.Controls.Add(Me.lblGraphGUI)
        Me.Controls.Add(Me.ucrSelectorGraphGUI)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGraphsGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graphs GUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorGraphGUI As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblGraphGUI As Label
    Friend WithEvents ucrReceiverGraphs As ucrReceiverSingle
End Class
