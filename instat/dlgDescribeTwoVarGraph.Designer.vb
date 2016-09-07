<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDescribeTwoVarGraph
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
        Me.ucrTwoVarGraphSave = New instat.ucrSaveGraph()
        Me.cmdGraphOptions = New System.Windows.Forms.Button()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverTwoVarGraph = New instat.ucrReceiverMultiple()
        Me.ucrSelectorTwoVarGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSecondVariableReceiver = New instat.ucrReceiverSingle()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 255)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrTwoVarGraphSave
        '
        Me.ucrTwoVarGraphSave.Location = New System.Drawing.Point(7, 229)
        Me.ucrTwoVarGraphSave.Name = "ucrTwoVarGraphSave"
        Me.ucrTwoVarGraphSave.Size = New System.Drawing.Size(265, 20)
        Me.ucrTwoVarGraphSave.TabIndex = 12
        '
        'cmdGraphOptions
        '
        Me.cmdGraphOptions.Location = New System.Drawing.Point(7, 197)
        Me.cmdGraphOptions.Name = "cmdGraphOptions"
        Me.cmdGraphOptions.Size = New System.Drawing.Size(101, 23)
        Me.cmdGraphOptions.TabIndex = 11
        Me.cmdGraphOptions.Text = "Graph Options"
        Me.cmdGraphOptions.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(231, 16)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedVariables.TabIndex = 10
        Me.lblSelectedVariables.Text = "Selected Variables:"
        '
        'ucrReceiverTwoVarGraph
        '
        Me.ucrReceiverTwoVarGraph.Location = New System.Drawing.Point(231, 30)
        Me.ucrReceiverTwoVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTwoVarGraph.Name = "ucrReceiverTwoVarGraph"
        Me.ucrReceiverTwoVarGraph.Selector = Nothing
        Me.ucrReceiverTwoVarGraph.Size = New System.Drawing.Size(123, 131)
        Me.ucrReceiverTwoVarGraph.TabIndex = 9
        '
        'ucrSelectorTwoVarGraph
        '
        Me.ucrSelectorTwoVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorTwoVarGraph.bUseCurrentFilter = False
        Me.ucrSelectorTwoVarGraph.Location = New System.Drawing.Point(7, 6)
        Me.ucrSelectorTwoVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoVarGraph.Name = "ucrSelectorTwoVarGraph"
        Me.ucrSelectorTwoVarGraph.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTwoVarGraph.TabIndex = 8
        '
        'ucrSecondVariableReceiver
        '
        Me.ucrSecondVariableReceiver.Location = New System.Drawing.Point(232, 197)
        Me.ucrSecondVariableReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondVariableReceiver.Name = "ucrSecondVariableReceiver"
        Me.ucrSecondVariableReceiver.Selector = Nothing
        Me.ucrSecondVariableReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondVariableReceiver.TabIndex = 13
        '
        'lblSecondVariable
        '
        Me.lblSecondVariable.AutoSize = True
        Me.lblSecondVariable.Location = New System.Drawing.Point(231, 172)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(85, 13)
        Me.lblSecondVariable.TabIndex = 14
        Me.lblSecondVariable.Text = "Second Variable"
        '
        'dlgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 311)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.ucrSecondVariableReceiver)
        Me.Controls.Add(Me.ucrTwoVarGraphSave)
        Me.Controls.Add(Me.cmdGraphOptions)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverTwoVarGraph)
        Me.Controls.Add(Me.ucrSelectorTwoVarGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVarGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgDescribeTwoVarGraph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrTwoVarGraphSave As ucrSaveGraph
    Friend WithEvents cmdGraphOptions As Button
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrReceiverTwoVarGraph As ucrReceiverMultiple
    Friend WithEvents ucrSelectorTwoVarGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSecondVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblSecondVariable As Label
End Class
