﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgViewAndRemoveKeys
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
        Me.ucrSelectorKeys = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSelectedKey = New instat.ucrReceiverSingle()
        Me.lblSelectedKey = New System.Windows.Forms.Label()
        Me.chkRemoveKey = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 196)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorKeys
        '
        Me.ucrSelectorKeys.bShowHiddenColumns = False
        Me.ucrSelectorKeys.bUseCurrentFilter = True
        Me.ucrSelectorKeys.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorKeys.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorKeys.Name = "ucrSelectorKeys"
        Me.ucrSelectorKeys.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorKeys.TabIndex = 1
        '
        'ucrReceiverSelectedKey
        '
        Me.ucrReceiverSelectedKey.Location = New System.Drawing.Point(223, 26)
        Me.ucrReceiverSelectedKey.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedKey.Name = "ucrReceiverSelectedKey"
        Me.ucrReceiverSelectedKey.Selector = Nothing
        Me.ucrReceiverSelectedKey.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSelectedKey.TabIndex = 2
        '
        'lblSelectedKey
        '
        Me.lblSelectedKey.AutoSize = True
        Me.lblSelectedKey.Location = New System.Drawing.Point(220, 13)
        Me.lblSelectedKey.Name = "lblSelectedKey"
        Me.lblSelectedKey.Size = New System.Drawing.Size(73, 13)
        Me.lblSelectedKey.TabIndex = 3
        Me.lblSelectedKey.Text = "Selected Key:"
        '
        'chkRemoveKey
        '
        Me.chkRemoveKey.AutoSize = True
        Me.chkRemoveKey.Location = New System.Drawing.Point(227, 50)
        Me.chkRemoveKey.Name = "chkRemoveKey"
        Me.chkRemoveKey.Size = New System.Drawing.Size(87, 17)
        Me.chkRemoveKey.TabIndex = 4
        Me.chkRemoveKey.Text = "Remove Key"
        Me.chkRemoveKey.UseVisualStyleBackColor = True
        '
        'dlgViewAndRemoveKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 256)
        Me.Controls.Add(Me.chkRemoveKey)
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
    Friend WithEvents chkRemoveKey As CheckBox
End Class
