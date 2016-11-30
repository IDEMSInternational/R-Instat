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
        Me.rdoCombineGraph = New System.Windows.Forms.RadioButton()
        Me.rdoSingleGraphs = New System.Windows.Forms.RadioButton()
        Me.rdoFacets = New System.Windows.Forms.RadioButton()
        Me.chkFlipCoordinates = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrSelectorOneVarGraph
        '
        Me.ucrSelectorOneVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorOneVarGraph.bUseCurrentFilter = True
        Me.ucrSelectorOneVarGraph.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarGraph.Name = "ucrSelectorOneVarGraph"
        Me.ucrSelectorOneVarGraph.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneVarGraph.TabIndex = 0
        '
        'ucrReceiverOneVarGraph
        '
        Me.ucrReceiverOneVarGraph.Location = New System.Drawing.Point(237, 55)
        Me.ucrReceiverOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneVarGraph.Name = "ucrReceiverOneVarGraph"
        Me.ucrReceiverOneVarGraph.Selector = Nothing
        Me.ucrReceiverOneVarGraph.Size = New System.Drawing.Size(123, 110)
        Me.ucrReceiverOneVarGraph.TabIndex = 2
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(238, 40)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedVariables.TabIndex = 1
        Me.lblSelectedVariables.Text = "Selected Variables:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 270)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
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
        'ucrOneVarGraphSave
        '
        Me.ucrOneVarGraphSave.Location = New System.Drawing.Point(10, 244)
        Me.ucrOneVarGraphSave.Name = "ucrOneVarGraphSave"
        Me.ucrOneVarGraphSave.Size = New System.Drawing.Size(265, 20)
        Me.ucrOneVarGraphSave.TabIndex = 8
        '
        'rdoCombineGraph
        '
        Me.rdoCombineGraph.AutoSize = True
        Me.rdoCombineGraph.Location = New System.Drawing.Point(237, 194)
        Me.rdoCombineGraph.Name = "rdoCombineGraph"
        Me.rdoCombineGraph.Size = New System.Drawing.Size(98, 17)
        Me.rdoCombineGraph.TabIndex = 5
        Me.rdoCombineGraph.TabStop = True
        Me.rdoCombineGraph.Text = "Combine Graph"
        Me.rdoCombineGraph.UseVisualStyleBackColor = True
        '
        'rdoSingleGraphs
        '
        Me.rdoSingleGraphs.AutoSize = True
        Me.rdoSingleGraphs.Location = New System.Drawing.Point(237, 216)
        Me.rdoSingleGraphs.Name = "rdoSingleGraphs"
        Me.rdoSingleGraphs.Size = New System.Drawing.Size(91, 17)
        Me.rdoSingleGraphs.TabIndex = 6
        Me.rdoSingleGraphs.TabStop = True
        Me.rdoSingleGraphs.Text = "Single Graphs"
        Me.rdoSingleGraphs.UseVisualStyleBackColor = True
        '
        'rdoFacets
        '
        Me.rdoFacets.AutoSize = True
        Me.rdoFacets.Location = New System.Drawing.Point(237, 171)
        Me.rdoFacets.Name = "rdoFacets"
        Me.rdoFacets.Size = New System.Drawing.Size(57, 17)
        Me.rdoFacets.TabIndex = 4
        Me.rdoFacets.TabStop = True
        Me.rdoFacets.Text = "Facets"
        Me.rdoFacets.UseVisualStyleBackColor = True
        '
        'chkFlipCoordinates
        '
        Me.chkFlipCoordinates.AutoSize = True
        Me.chkFlipCoordinates.Enabled = False
        Me.chkFlipCoordinates.Location = New System.Drawing.Point(237, 240)
        Me.chkFlipCoordinates.Name = "chkFlipCoordinates"
        Me.chkFlipCoordinates.Size = New System.Drawing.Size(101, 17)
        Me.chkFlipCoordinates.TabIndex = 7
        Me.chkFlipCoordinates.Text = "Flip Coordinates"
        Me.chkFlipCoordinates.UseVisualStyleBackColor = True
        '
        'dlgOneVariableGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 333)
        Me.Controls.Add(Me.chkFlipCoordinates)
        Me.Controls.Add(Me.rdoFacets)
        Me.Controls.Add(Me.rdoSingleGraphs)
        Me.Controls.Add(Me.rdoCombineGraph)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneVarGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverOneVarGraph As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdGraphOptions As Button
    Friend WithEvents ucrOneVarGraphSave As ucrSaveGraph
    Friend WithEvents rdoCombineGraph As RadioButton
    Friend WithEvents rdoSingleGraphs As RadioButton
    Friend WithEvents rdoFacets As RadioButton
    Friend WithEvents chkFlipCoordinates As CheckBox
End Class
