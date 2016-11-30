<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReoderDescriptives
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
        Me.ucrDataFrameReoder = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 176)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'lblObjectsToReoder
        '
        Me.lblObjectsToReoder.AutoSize = True
        Me.lblObjectsToReoder.Location = New System.Drawing.Point(187, 15)
        Me.lblObjectsToReoder.Name = "lblObjectsToReoder"
        Me.lblObjectsToReoder.Size = New System.Drawing.Size(93, 13)
        Me.lblObjectsToReoder.TabIndex = 2
        Me.lblObjectsToReoder.Tag = "Objects_to_Reorder"
        Me.lblObjectsToReoder.Text = "Objects to Reoder"
        '
        'ucrReorderObjects
        '
        Me.ucrReorderObjects.Location = New System.Drawing.Point(190, 31)
        Me.ucrReorderObjects.Name = "ucrReorderObjects"
        Me.ucrReorderObjects.Size = New System.Drawing.Size(154, 139)
        Me.ucrReorderObjects.TabIndex = 3
        Me.ucrReorderObjects.ucrDataFrameList = Nothing
        Me.ucrReorderObjects.ucrReceiver = Nothing
        '
        'ucrDataFrameReoder
        '
        Me.ucrDataFrameReoder.bUseCurrentFilter = True
        Me.ucrDataFrameReoder.Location = New System.Drawing.Point(13, 13)
        Me.ucrDataFrameReoder.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameReoder.Name = "ucrDataFrameReoder"
        Me.ucrDataFrameReoder.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameReoder.TabIndex = 1
        '
        'dlgReoderDescriptives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 242)
        Me.Controls.Add(Me.ucrReorderObjects)
        Me.Controls.Add(Me.lblObjectsToReoder)
        Me.Controls.Add(Me.ucrDataFrameReoder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReoderDescriptives"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reoder_Objects"
        Me.Text = "Reoder Objects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblObjectsToReoder As Label
    Friend WithEvents ucrReorderObjects As ucrReorder
    Friend WithEvents ucrDataFrameReoder As ucrDataFrame
End Class
