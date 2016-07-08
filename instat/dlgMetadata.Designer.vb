<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgMetadata
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
        Me.lblVIewDataBy = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectByMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputViewDataBy = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblVIewDataBy
        '
        Me.lblVIewDataBy.AutoSize = True
        Me.lblVIewDataBy.Location = New System.Drawing.Point(244, 32)
        Me.lblVIewDataBy.Name = "lblVIewDataBy"
        Me.lblVIewDataBy.Size = New System.Drawing.Size(79, 13)
        Me.lblVIewDataBy.TabIndex = 2
        Me.lblVIewDataBy.Tag = "View_Data_by"
        Me.lblVIewDataBy.Text = "View Data by..."
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 207)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectByMetadata
        '
        Me.ucrSelectByMetadata.bShowHiddenColumns = False
        Me.ucrSelectByMetadata.Location = New System.Drawing.Point(12, 13)
        Me.ucrSelectByMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectByMetadata.Name = "ucrSelectByMetadata"
        Me.ucrSelectByMetadata.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectByMetadata.TabIndex = 8
        '
        'ucrInputViewDataBy
        '
        Me.ucrInputViewDataBy.Location = New System.Drawing.Point(247, 62)
        Me.ucrInputViewDataBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputViewDataBy.Name = "ucrInputViewDataBy"
        Me.ucrInputViewDataBy.Selector = Nothing
        Me.ucrInputViewDataBy.Size = New System.Drawing.Size(120, 20)
        Me.ucrInputViewDataBy.TabIndex = 9
        '
        'dlgMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 265)
        Me.Controls.Add(Me.ucrInputViewDataBy)
        Me.Controls.Add(Me.ucrSelectByMetadata)
        Me.Controls.Add(Me.lblVIewDataBy)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Metadata"
        Me.Text = "Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblVIewDataBy As Label
    Friend WithEvents ucrSelectByMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputViewDataBy As ucrReceiverSingle
End Class
