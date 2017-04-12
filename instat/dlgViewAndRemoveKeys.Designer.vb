<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgViewAndRemoveKeys
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
        Me.lblSelectedKey = New System.Windows.Forms.Label()
        Me.ucrChkRemoveKey = New instat.ucrCheck()
        Me.ucrReceiverSelectedKey = New instat.ucrReceiverSingle()
        Me.ucrSelectorKeys = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSelectedKey
        '
        Me.lblSelectedKey.AutoSize = True
        Me.lblSelectedKey.Location = New System.Drawing.Point(266, 45)
        Me.lblSelectedKey.Name = "lblSelectedKey"
        Me.lblSelectedKey.Size = New System.Drawing.Size(73, 13)
        Me.lblSelectedKey.TabIndex = 1
        Me.lblSelectedKey.Text = "Selected Key:"
        '
        'ucrChkRemoveKey
        '
        Me.ucrChkRemoveKey.Checked = False
        Me.ucrChkRemoveKey.Location = New System.Drawing.Point(266, 87)
        Me.ucrChkRemoveKey.Name = "ucrChkRemoveKey"
        Me.ucrChkRemoveKey.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkRemoveKey.TabIndex = 3
        '
        'ucrReceiverSelectedKey
        '
        Me.ucrReceiverSelectedKey.frmParent = Me
        Me.ucrReceiverSelectedKey.Location = New System.Drawing.Point(266, 60)
        Me.ucrReceiverSelectedKey.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedKey.Name = "ucrReceiverSelectedKey"
        Me.ucrReceiverSelectedKey.Selector = Nothing
        Me.ucrReceiverSelectedKey.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSelectedKey.TabIndex = 2
        '
        'ucrSelectorKeys
        '
        Me.ucrSelectorKeys.bShowHiddenColumns = False
        Me.ucrSelectorKeys.bUseCurrentFilter = True
        Me.ucrSelectorKeys.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorKeys.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorKeys.Name = "ucrSelectorKeys"
        Me.ucrSelectorKeys.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorKeys.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 203)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 4
        '
        'dlgViewAndRemoveKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 260)
        Me.Controls.Add(Me.ucrChkRemoveKey)
        Me.Controls.Add(Me.lblSelectedKey)
        Me.Controls.Add(Me.ucrReceiverSelectedKey)
        Me.Controls.Add(Me.ucrSelectorKeys)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewAndRemoveKeys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View and Remove Keys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorKeys As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSelectedKey As ucrReceiverSingle
    Friend WithEvents lblSelectedKey As Label
    Friend WithEvents ucrChkRemoveKey As ucrCheck
End Class
