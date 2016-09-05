<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOneVariableGraph
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
        Me.ucrSelectorOneVarGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverOneVarGraph = New instat.ucrReceiverMultiple()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdGraphOptions = New System.Windows.Forms.Button()
        Me.ucrOneVarGraphSave = New instat.ucrSaveGraph()
        Me.SuspendLayout()
        '
        'ucrSelectorOneVarGraph
        '
        Me.ucrSelectorOneVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorOneVarGraph.bUseCurrentFilter = False
        Me.ucrSelectorOneVarGraph.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarGraph.Name = "ucrSelectorOneVarGraph"
        Me.ucrSelectorOneVarGraph.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneVarGraph.TabIndex = 0
        '
        'ucrReceiverOneVarGraph
        '
        Me.ucrReceiverOneVarGraph.Location = New System.Drawing.Point(237, 34)
        Me.ucrReceiverOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneVarGraph.Name = "ucrReceiverOneVarGraph"
        Me.ucrReceiverOneVarGraph.Selector = Nothing
        Me.ucrReceiverOneVarGraph.Size = New System.Drawing.Size(123, 131)
        Me.ucrReceiverOneVarGraph.TabIndex = 1
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(234, 20)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedVariables.TabIndex = 2
        Me.lblSelectedVariables.Text = "Selected Variables:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 262)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'cmdGraphOptions
        '
        Me.cmdGraphOptions.Location = New System.Drawing.Point(10, 201)
        Me.cmdGraphOptions.Name = "cmdGraphOptions"
        Me.cmdGraphOptions.Size = New System.Drawing.Size(101, 23)
        Me.cmdGraphOptions.TabIndex = 6
        Me.cmdGraphOptions.Text = "Graph Options"
        Me.cmdGraphOptions.UseVisualStyleBackColor = True
        '
        'ucrOneVarGraphSave
        '
        Me.ucrOneVarGraphSave.Location = New System.Drawing.Point(10, 233)
        Me.ucrOneVarGraphSave.Name = "ucrOneVarGraphSave"
        Me.ucrOneVarGraphSave.Size = New System.Drawing.Size(265, 20)
        Me.ucrOneVarGraphSave.TabIndex = 7
        '
        'dlgOneVariableGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 316)
        Me.Controls.Add(Me.ucrOneVarGraphSave)
        Me.Controls.Add(Me.cmdGraphOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverOneVarGraph)
        Me.Controls.Add(Me.ucrSelectorOneVarGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgOneVariableGraph"
        Me.Text = "One Variable Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneVarGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverOneVarGraph As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdGraphOptions As Button
    Friend WithEvents ucrOneVarGraphSave As ucrSaveGraph
End Class
