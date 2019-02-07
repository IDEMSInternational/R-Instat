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
        Me.lblGraphGUI = New System.Windows.Forms.Label()
        Me.ucrReceiverGraphs = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorGraphGUI = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'lblGraphGUI
        '
        Me.lblGraphGUI.AutoSize = True
        Me.lblGraphGUI.Location = New System.Drawing.Point(250, 46)
        Me.lblGraphGUI.Name = "lblGraphGUI"
        Me.lblGraphGUI.Size = New System.Drawing.Size(110, 13)
        Me.lblGraphGUI.TabIndex = 5
        Me.lblGraphGUI.Text = "Selected Data Frame:"
        '
        'ucrReceiverGraphs
        '
        Me.ucrReceiverGraphs.frmParent = Me
        Me.ucrReceiverGraphs.Location = New System.Drawing.Point(252, 62)
        Me.ucrReceiverGraphs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGraphs.Name = "ucrReceiverGraphs"
        Me.ucrReceiverGraphs.Selector = Nothing
        Me.ucrReceiverGraphs.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverGraphs.strNcFilePath = ""
        Me.ucrReceiverGraphs.TabIndex = 6
        Me.ucrReceiverGraphs.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 198)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 2
        '
        'ucrSelectorGraphGUI
        '
        Me.ucrSelectorGraphGUI.bShowHiddenColumns = False
        Me.ucrSelectorGraphGUI.Location = New System.Drawing.Point(10, 35)
        Me.ucrSelectorGraphGUI.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGraphGUI.Name = "ucrSelectorGraphGUI"
        Me.ucrSelectorGraphGUI.Size = New System.Drawing.Size(216, 141)
        Me.ucrSelectorGraphGUI.TabIndex = 7
        '
        'dlgGraphsGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 262)
        Me.Controls.Add(Me.ucrSelectorGraphGUI)
        Me.Controls.Add(Me.ucrReceiverGraphs)
        Me.Controls.Add(Me.lblGraphGUI)
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
    Friend WithEvents lblGraphGUI As Label
    Friend WithEvents ucrReceiverGraphs As ucrReceiverSingle
    Friend WithEvents ucrSelectorGraphGUI As ucrSelectorAddRemove
End Class
