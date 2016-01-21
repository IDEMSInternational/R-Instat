<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSubset
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSubset = New instat.ucrReceiverMultiple()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lblDrop = New System.Windows.Forms.Label()
        Me.cboDrop = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 263)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameAddRemove
        '
        Me.ucrDataFrameAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrDataFrameAddRemove.Name = "ucrDataFrameAddRemove"
        Me.ucrDataFrameAddRemove.Size = New System.Drawing.Size(242, 179)
        Me.ucrDataFrameAddRemove.TabIndex = 1
        '
        'ucrReceiverSubset
        '
        Me.ucrReceiverSubset.Location = New System.Drawing.Point(260, 43)
        Me.ucrReceiverSubset.Name = "ucrReceiverSubset"
        Me.ucrReceiverSubset.Size = New System.Drawing.Size(121, 128)
        Me.ucrReceiverSubset.TabIndex = 2
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(260, 27)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(100, 13)
        Me.lblSelectedVariables.TabIndex = 3
        Me.lblSelectedVariables.Tag = "Selected_variables"
        Me.lblSelectedVariables.Text = "Selected variable(s)"
        '
        'lblDrop
        '
        Me.lblDrop.AutoSize = True
        Me.lblDrop.Location = New System.Drawing.Point(257, 178)
        Me.lblDrop.Name = "lblDrop"
        Me.lblDrop.Size = New System.Drawing.Size(30, 13)
        Me.lblDrop.TabIndex = 3
        Me.lblDrop.Tag = "Drop"
        Me.lblDrop.Text = "Drop"
        '
        'cboDrop
        '
        Me.cboDrop.FormattingEnabled = True
        Me.cboDrop.Location = New System.Drawing.Point(260, 197)
        Me.cboDrop.Name = "cboDrop"
        Me.cboDrop.Size = New System.Drawing.Size(121, 21)
        Me.cboDrop.TabIndex = 4
        '
        'dlgSubset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 328)
        Me.Controls.Add(Me.cboDrop)
        Me.Controls.Add(Me.lblDrop)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverSubset)
        Me.Controls.Add(Me.ucrDataFrameAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgSubset"
        Me.Tag = "Subset"
        Me.Text = "Subset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSubset As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lblDrop As Label
    Friend WithEvents cboDrop As ComboBox
End Class
