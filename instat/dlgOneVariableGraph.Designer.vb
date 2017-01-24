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
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.cmdGraphOptions = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.ucrRdoFacets = New instat.ucrRadio()
        Me.ucrRdoSingleGraphs = New instat.ucrRadio()
        Me.ucrRdoCombine = New instat.ucrRadio()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrOneVarGraphSave = New instat.ucrSaveGraph()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverOneVarGraph = New instat.ucrReceiverMultiple()
        Me.ucrSelectorOneVarGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(238, 33)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedVariables.TabIndex = 1
        Me.lblSelectedVariables.Text = "Selected Variables:"
        '
        'cmdGraphOptions
        '
        Me.cmdGraphOptions.Location = New System.Drawing.Point(10, 201)
        Me.cmdGraphOptions.Name = "cmdGraphOptions"
        Me.cmdGraphOptions.Size = New System.Drawing.Size(101, 23)
        Me.cmdGraphOptions.TabIndex = 3
        Me.cmdGraphOptions.Text = "Graph Options"
        Me.cmdGraphOptions.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.ucrRdoFacets)
        Me.grpOutput.Controls.Add(Me.ucrRdoSingleGraphs)
        Me.grpOutput.Controls.Add(Me.ucrRdoCombine)
        Me.grpOutput.Location = New System.Drawing.Point(237, 160)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(123, 91)
        Me.grpOutput.TabIndex = 13
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'ucrRdoFacets
        '
        Me.ucrRdoFacets.Checked = False
        Me.ucrRdoFacets.Location = New System.Drawing.Point(6, 19)
        Me.ucrRdoFacets.Name = "ucrRdoFacets"
        Me.ucrRdoFacets.Size = New System.Drawing.Size(100, 20)
        Me.ucrRdoFacets.strParameterName = ""
        Me.ucrRdoFacets.TabIndex = 10
        '
        'ucrRdoSingleGraphs
        '
        Me.ucrRdoSingleGraphs.Checked = False
        Me.ucrRdoSingleGraphs.Location = New System.Drawing.Point(6, 67)
        Me.ucrRdoSingleGraphs.Name = "ucrRdoSingleGraphs"
        Me.ucrRdoSingleGraphs.Size = New System.Drawing.Size(100, 20)
        Me.ucrRdoSingleGraphs.strParameterName = ""
        Me.ucrRdoSingleGraphs.TabIndex = 12
        '
        'ucrRdoCombine
        '
        Me.ucrRdoCombine.Checked = False
        Me.ucrRdoCombine.Location = New System.Drawing.Point(6, 43)
        Me.ucrRdoCombine.Name = "ucrRdoCombine"
        Me.ucrRdoCombine.Size = New System.Drawing.Size(100, 20)
        Me.ucrRdoCombine.strParameterName = ""
        Me.ucrRdoCombine.TabIndex = 11
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(243, 257)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkFlip.strParameterName = ""
        Me.ucrChkFlip.TabIndex = 9
        '
        'ucrOneVarGraphSave
        '
        Me.ucrOneVarGraphSave.Location = New System.Drawing.Point(10, 257)
        Me.ucrOneVarGraphSave.Name = "ucrOneVarGraphSave"
        Me.ucrOneVarGraphSave.Size = New System.Drawing.Size(265, 20)
        Me.ucrOneVarGraphSave.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 283)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrReceiverOneVarGraph
        '
        Me.ucrReceiverOneVarGraph.frmParent = Me
        Me.ucrReceiverOneVarGraph.Location = New System.Drawing.Point(237, 48)
        Me.ucrReceiverOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneVarGraph.Name = "ucrReceiverOneVarGraph"
        Me.ucrReceiverOneVarGraph.Selector = Nothing
        Me.ucrReceiverOneVarGraph.Size = New System.Drawing.Size(123, 110)
        Me.ucrReceiverOneVarGraph.strParameterName = ""
        Me.ucrReceiverOneVarGraph.TabIndex = 2
        '
        'ucrSelectorOneVarGraph
        '
        Me.ucrSelectorOneVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorOneVarGraph.bUseCurrentFilter = True
        Me.ucrSelectorOneVarGraph.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarGraph.Name = "ucrSelectorOneVarGraph"
        Me.ucrSelectorOneVarGraph.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneVarGraph.strParameterName = ""
        Me.ucrSelectorOneVarGraph.TabIndex = 0
        '
        'dlgOneVariableGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 337)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.ucrOneVarGraphSave)
        Me.Controls.Add(Me.cmdGraphOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverOneVarGraph)
        Me.Controls.Add(Me.ucrSelectorOneVarGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVariableGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Variable Graph"
        Me.grpOutput.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneVarGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverOneVarGraph As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdGraphOptions As Button
    Friend WithEvents ucrOneVarGraphSave As ucrSaveGraph
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrRdoSingleGraphs As ucrRadio
    Friend WithEvents ucrRdoCombine As ucrRadio
    Friend WithEvents ucrRdoFacets As ucrRadio
    Friend WithEvents grpOutput As GroupBox
End Class
