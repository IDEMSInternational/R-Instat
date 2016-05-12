<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCombineforGraphics
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
        Me.ucrCombineSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectedGraphsReceiver = New instat.ucrReceiverMultiple()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(6, 248)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrCombineSelector
        '
        Me.ucrCombineSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrCombineSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCombineSelector.Name = "ucrCombineSelector"
        Me.ucrCombineSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrCombineSelector.TabIndex = 1
        '
        'ucrSelectedGraphsReceiver
        '
        Me.ucrSelectedGraphsReceiver.Location = New System.Drawing.Point(253, 32)
        Me.ucrSelectedGraphsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectedGraphsReceiver.Name = "ucrSelectedGraphsReceiver"
        Me.ucrSelectedGraphsReceiver.Selector = Nothing
        Me.ucrSelectedGraphsReceiver.Size = New System.Drawing.Size(120, 158)
        Me.ucrSelectedGraphsReceiver.TabIndex = 2
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(253, 10)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(86, 13)
        Me.lblSelected.TabIndex = 3
        Me.lblSelected.Text = "Selected Graphs"
        '
        'dlgCombineforGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 306)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrSelectedGraphsReceiver)
        Me.Controls.Add(Me.ucrCombineSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCombineforGraphics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Combine"
        Me.Text = "Combine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCombineSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectedGraphsReceiver As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
End Class
