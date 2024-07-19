<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgFlowsToImport
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
        Me.ucrSelectorFlows = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.lblFlowName = New System.Windows.Forms.Label()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.ucrModifyEventFactor = New instat.ucrFactor()
        Me.SuspendLayout()
        '
        'ucrSelectorFlows
        '
        Me.ucrSelectorFlows.AutoSize = True
        Me.ucrSelectorFlows.bDropUnusedFilterLevels = False
        Me.ucrSelectorFlows.bShowHiddenColumns = False
        Me.ucrSelectorFlows.bUseCurrentFilter = True
        Me.ucrSelectorFlows.Location = New System.Drawing.Point(6, 14)
        Me.ucrSelectorFlows.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFlows.Name = "ucrSelectorFlows"
        Me.ucrSelectorFlows.Size = New System.Drawing.Size(318, 274)
        Me.ucrSelectorFlows.TabIndex = 20
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(265, 64)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(120, 24)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 21
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'lblFlowName
        '
        Me.lblFlowName.AutoSize = True
        Me.lblFlowName.Location = New System.Drawing.Point(267, 46)
        Me.lblFlowName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFlowName.Name = "lblFlowName"
        Me.lblFlowName.Size = New System.Drawing.Size(63, 13)
        Me.lblFlowName.TabIndex = 22
        Me.lblFlowName.Text = "Flow Name:"
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(110, 506)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(335, 42)
        Me.ucrSdgButtons.TabIndex = 23
        '
        'ucrModifyEventFactor
        '
        Me.ucrModifyEventFactor.AutoSize = True
        Me.ucrModifyEventFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrModifyEventFactor.Location = New System.Drawing.Point(10, 209)
        Me.ucrModifyEventFactor.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrModifyEventFactor.Name = "ucrModifyEventFactor"
        Me.ucrModifyEventFactor.Size = New System.Drawing.Size(433, 287)
        Me.ucrModifyEventFactor.TabIndex = 24
        '
        'sdgFlowsToImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 561)
        Me.Controls.Add(Me.ucrModifyEventFactor)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.lblFlowName)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrSelectorFlows)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFlowsToImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flows To Import"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorFlows As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
    Friend WithEvents lblFlowName As Label
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrModifyEventFactor As ucrFactor
End Class
