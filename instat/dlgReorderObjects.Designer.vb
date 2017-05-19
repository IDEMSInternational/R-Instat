<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReorderObjects
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
        Me.lblObjectsToReoder = New System.Windows.Forms.Label()
        Me.ucrReorderObjects = New instat.ucrReorder()
        Me.ucrDataFrameReorder = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 176)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 3
        '
        'lblObjectsToReoder
        '
        Me.lblObjectsToReoder.AutoSize = True
        Me.lblObjectsToReoder.Location = New System.Drawing.Point(213, 18)
        Me.lblObjectsToReoder.Name = "lblObjectsToReoder"
        Me.lblObjectsToReoder.Size = New System.Drawing.Size(99, 13)
        Me.lblObjectsToReoder.TabIndex = 1
        Me.lblObjectsToReoder.Tag = "Objects_to_Reorder"
        Me.lblObjectsToReoder.Text = "Objects to Reorder:"
        '
        'ucrReorderObjects
        '
        Me.ucrReorderObjects.Location = New System.Drawing.Point(208, 31)
        Me.ucrReorderObjects.Name = "ucrReorderObjects"
        Me.ucrReorderObjects.Size = New System.Drawing.Size(154, 139)
        Me.ucrReorderObjects.TabIndex = 2
        Me.ucrReorderObjects.ucrDataFrameList = Nothing
        Me.ucrReorderObjects.ucrReceiver = Nothing
        '
        'ucrDataFrameReorder
        '
        Me.ucrDataFrameReorder.bUseCurrentFilter = True
        Me.ucrDataFrameReorder.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameReorder.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameReorder.Name = "ucrDataFrameReorder"
        Me.ucrDataFrameReorder.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameReorder.TabIndex = 0
        '
        'dlgReoderDescriptives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 235)
        Me.Controls.Add(Me.ucrReorderObjects)
        Me.Controls.Add(Me.lblObjectsToReoder)
        Me.Controls.Add(Me.ucrDataFrameReorder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReoderDescriptives"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reorder_Objects"
        Me.Text = "Reorder Objects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblObjectsToReoder As Label
    Friend WithEvents ucrReorderObjects As ucrReorder
    Friend WithEvents ucrDataFrameReorder As ucrDataFrame
End Class
