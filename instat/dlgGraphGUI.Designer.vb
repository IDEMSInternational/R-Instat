<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGraphGUI
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorGraphGUI = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverGraphGUI = New instat.ucrReceiverMultiple()
        Me.lblGraphGUI = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 218)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 2
        '
        'ucrSelectorGraphGUI
        '
        Me.ucrSelectorGraphGUI.bDropUnusedFilterLevels = False
        Me.ucrSelectorGraphGUI.bShowHiddenColumns = False
        Me.ucrSelectorGraphGUI.bUseCurrentFilter = True
        Me.ucrSelectorGraphGUI.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorGraphGUI.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGraphGUI.Name = "ucrSelectorGraphGUI"
        Me.ucrSelectorGraphGUI.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorGraphGUI.TabIndex = 3
        '
        'ucrReceiverGraphGUI
        '
        Me.ucrReceiverGraphGUI.frmParent = Me
        Me.ucrReceiverGraphGUI.Location = New System.Drawing.Point(252, 62)
        Me.ucrReceiverGraphGUI.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGraphGUI.Name = "ucrReceiverGraphGUI"
        Me.ucrReceiverGraphGUI.Selector = Nothing
        Me.ucrReceiverGraphGUI.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverGraphGUI.strNcFilePath = ""
        Me.ucrReceiverGraphGUI.TabIndex = 4
        Me.ucrReceiverGraphGUI.ucrSelector = Nothing
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
        'dlgGraphGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 279)
        Me.Controls.Add(Me.lblGraphGUI)
        Me.Controls.Add(Me.ucrReceiverGraphGUI)
        Me.Controls.Add(Me.ucrSelectorGraphGUI)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGraphGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graph GUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorGraphGUI As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverGraphGUI As ucrReceiverMultiple
    Friend WithEvents lblGraphGUI As Label
End Class
