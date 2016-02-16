<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConvertTo
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
        Me.ucrSelectorByDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverConvertTo = New instat.ucrReceiverSingle()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(2, 237)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorByDataFrameAddRemove
        '
        Me.ucrSelectorByDataFrameAddRemove.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorByDataFrameAddRemove.Name = "ucrSelectorByDataFrameAddRemove"
        Me.ucrSelectorByDataFrameAddRemove.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorByDataFrameAddRemove.TabIndex = 1
        '
        'ucrReceiverConvertTo
        '
        Me.ucrReceiverConvertTo.Location = New System.Drawing.Point(283, 48)
        Me.ucrReceiverConvertTo.Name = "ucrReceiverConvertTo"
        Me.ucrReceiverConvertTo.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverConvertTo.TabIndex = 2
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(283, 29)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectedVariable.TabIndex = 3
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable"
        '
        'dlgConvertTo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 302)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrReceiverConvertTo)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgConvertTo"
        Me.Tag = "Convert_to"
        Me.Text = "Convert To"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorByDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverConvertTo As ucrReceiverSingle
    Friend WithEvents lblSelectedVariable As Label
End Class
