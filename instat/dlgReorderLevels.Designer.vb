﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReorderLevels
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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrReorderFactor = New instat.ucrReorder()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorLevelsToReorder = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(249, 19)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 4
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'ucrReorderFactor
        '
        Me.ucrReorderFactor.Location = New System.Drawing.Point(249, 60)
        Me.ucrReorderFactor.Name = "ucrReorderFactor"
        Me.ucrReorderFactor.Size = New System.Drawing.Size(154, 139)
        Me.ucrReorderFactor.TabIndex = 3
        Me.ucrReorderFactor.ucrDataFrameList = Nothing
        Me.ucrReorderFactor.ucrReceiver = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(249, 32)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverFactor.TabIndex = 2
        '
        'ucrSelectorFactorLevelsToReorder
        '
        Me.ucrSelectorFactorLevelsToReorder.Location = New System.Drawing.Point(5, 6)
        Me.ucrSelectorFactorLevelsToReorder.Name = "ucrSelectorFactorLevelsToReorder"
        Me.ucrSelectorFactorLevelsToReorder.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorFactorLevelsToReorder.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 211)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'dlgReorderLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 265)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReorderFactor)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSelectorFactorLevelsToReorder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReorderLevels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reorder_Levels"
        Me.Text = "Reorder Levels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorLevelsToReorder As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents ucrReorderFactor As ucrReorder
    Friend WithEvents lblFactor As Label
End Class
