<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgExportToWWR
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
        Me.UcrSelectorByDataFrameAddRemove1 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'UcrSelectorByDataFrameAddRemove1
        '
        Me.UcrSelectorByDataFrameAddRemove1.bDropUnusedFilterLevels = False
        Me.UcrSelectorByDataFrameAddRemove1.bShowHiddenColumns = False
        Me.UcrSelectorByDataFrameAddRemove1.bUseCurrentFilter = True
        Me.UcrSelectorByDataFrameAddRemove1.Location = New System.Drawing.Point(9, 9)
        Me.UcrSelectorByDataFrameAddRemove1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelectorByDataFrameAddRemove1.Name = "UcrSelectorByDataFrameAddRemove1"
        Me.UcrSelectorByDataFrameAddRemove1.Size = New System.Drawing.Size(210, 180)
        Me.UcrSelectorByDataFrameAddRemove1.TabIndex = 0
        '
        'sdgExportToWWR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 287)
        Me.Controls.Add(Me.UcrSelectorByDataFrameAddRemove1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExportToWWR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station Metadata"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrSelectorByDataFrameAddRemove1 As ucrSelectorByDataFrameAddRemove
End Class
