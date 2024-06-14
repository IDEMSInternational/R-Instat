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
        Me.ucrModifyEventFactor = New instat.ucrFactor()
        Me.ucrSelectorFlows = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.lblFlowName = New System.Windows.Forms.Label()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrModifyEventFactor
        '
        Me.ucrModifyEventFactor.AutoSize = True
        Me.ucrModifyEventFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrModifyEventFactor.Location = New System.Drawing.Point(12, 305)
        Me.ucrModifyEventFactor.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrModifyEventFactor.Name = "ucrModifyEventFactor"
        Me.ucrModifyEventFactor.Size = New System.Drawing.Size(389, 134)
        Me.ucrModifyEventFactor.TabIndex = 19
        '
        'ucrSelectorFlows
        '
        Me.ucrSelectorFlows.AutoSize = True
        Me.ucrSelectorFlows.bDropUnusedFilterLevels = False
        Me.ucrSelectorFlows.bShowHiddenColumns = False
        Me.ucrSelectorFlows.bUseCurrentFilter = True
        Me.ucrSelectorFlows.Location = New System.Drawing.Point(9, 22)
        Me.ucrSelectorFlows.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFlows.Name = "ucrSelectorFlows"
        Me.ucrSelectorFlows.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorFlows.TabIndex = 20
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(397, 98)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(180, 27)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 21
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'lblFlowName
        '
        Me.lblFlowName.AutoSize = True
        Me.lblFlowName.Location = New System.Drawing.Point(401, 71)
        Me.lblFlowName.Name = "lblFlowName"
        Me.lblFlowName.Size = New System.Drawing.Size(88, 20)
        Me.lblFlowName.TabIndex = 22
        Me.lblFlowName.Text = "FlowName:"
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(168, 551)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(336, 45)
        Me.ucrSdgButtons.TabIndex = 23
        '
        'sdgFlowsToImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 605)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.lblFlowName)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrSelectorFlows)
        Me.Controls.Add(Me.ucrModifyEventFactor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFlowsToImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flows To Import"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrModifyEventFactor As ucrFactor
    Friend WithEvents ucrSelectorFlows As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
    Friend WithEvents lblFlowName As Label
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
End Class
