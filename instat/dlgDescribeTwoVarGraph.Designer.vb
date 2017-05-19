<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescribeTwoVarGraph
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
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.lblFirstVariables = New System.Windows.Forms.Label()
        Me.ucrSecondVariableReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultipleTwoVar = New instat.ucrVariablesAsFactor()
        Me.ucrTwoVarGraphSave = New instat.ucrSaveGraph()
        Me.ucrSelectorTwoVarGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(320, 220)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(91, 23)
        Me.cmdOptions.TabIndex = 11
        Me.cmdOptions.Tag = "Options..."
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSecondVariable
        '
        Me.lblSecondVariable.AutoSize = True
        Me.lblSecondVariable.Location = New System.Drawing.Point(261, 176)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(88, 13)
        Me.lblSecondVariable.TabIndex = 14
        Me.lblSecondVariable.Text = "Second Variable:"
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.Location = New System.Drawing.Point(261, 50)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(81, 13)
        Me.lblFirstVariables.TabIndex = 16
        Me.lblFirstVariables.Tag = "First_Variable(s)"
        Me.lblFirstVariables.Text = "First Variable(s):"
        '
        'ucrSecondVariableReceiver
        '
        Me.ucrSecondVariableReceiver.frmParent = Me
        Me.ucrSecondVariableReceiver.Location = New System.Drawing.Point(261, 191)
        Me.ucrSecondVariableReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondVariableReceiver.Name = "ucrSecondVariableReceiver"
        Me.ucrSecondVariableReceiver.Selector = Nothing
        Me.ucrSecondVariableReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondVariableReceiver.strNcFilePath = ""
        Me.ucrSecondVariableReceiver.TabIndex = 13
        Me.ucrSecondVariableReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 247)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrReceiverMultipleTwoVar
        '
        Me.ucrReceiverMultipleTwoVar.frmParent = Me
        Me.ucrReceiverMultipleTwoVar.Location = New System.Drawing.Point(261, 35)
        Me.ucrReceiverMultipleTwoVar.Name = "ucrReceiverMultipleTwoVar"
        Me.ucrReceiverMultipleTwoVar.Selector = Nothing
        Me.ucrReceiverMultipleTwoVar.Size = New System.Drawing.Size(120, 138)
        Me.ucrReceiverMultipleTwoVar.strNcFilePath = ""
        Me.ucrReceiverMultipleTwoVar.TabIndex = 15
        Me.ucrReceiverMultipleTwoVar.ucrSelector = Nothing
        Me.ucrReceiverMultipleTwoVar.ucrVariableSelector = Nothing
        '
        'ucrTwoVarGraphSave
        '
        Me.ucrTwoVarGraphSave.Location = New System.Drawing.Point(12, 221)
        Me.ucrTwoVarGraphSave.Name = "ucrTwoVarGraphSave"
        Me.ucrTwoVarGraphSave.Size = New System.Drawing.Size(265, 20)
        Me.ucrTwoVarGraphSave.TabIndex = 12
        '
        'ucrSelectorTwoVarGraph
        '
        Me.ucrSelectorTwoVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorTwoVarGraph.bUseCurrentFilter = True
        Me.ucrSelectorTwoVarGraph.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorTwoVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoVarGraph.Name = "ucrSelectorTwoVarGraph"
        Me.ucrSelectorTwoVarGraph.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTwoVarGraph.TabIndex = 8
        '
        'dlgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 306)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.ucrReceiverMultipleTwoVar)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.ucrSecondVariableReceiver)
        Me.Controls.Add(Me.ucrTwoVarGraphSave)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSelectorTwoVarGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVarGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Two Variable Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrTwoVarGraphSave As ucrSaveGraph
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSelectorTwoVarGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSecondVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblSecondVariable As Label
    Friend WithEvents ucrReceiverMultipleTwoVar As ucrVariablesAsFactor
    Friend WithEvents lblFirstVariables As Label
End Class