<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTaylorDiagram
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
        Me.lblObserved = New System.Windows.Forms.Label()
        Me.lblEstimated = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.cmdTaylorDiagramOptions = New System.Windows.Forms.Button()
        Me.ucrReceiverEstimated = New instat.ucrReceiverMultiple()
        Me.ucrChkNormalise = New instat.ucrCheck()
        Me.ucrReceiverType = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrReceiverGroup = New instat.ucrReceiverMultiple()
        Me.ucrReceiverObserved = New instat.ucrReceiverSingle()
        Me.ucrSelectorTaylorDiagram = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblObserved
        '
        Me.lblObserved.AutoSize = True
        Me.lblObserved.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObserved.Location = New System.Drawing.Point(286, 24)
        Me.lblObserved.Name = "lblObserved"
        Me.lblObserved.Size = New System.Drawing.Size(56, 13)
        Me.lblObserved.TabIndex = 1
        Me.lblObserved.Text = "Observed:"
        '
        'lblEstimated
        '
        Me.lblEstimated.AutoSize = True
        Me.lblEstimated.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEstimated.Location = New System.Drawing.Point(286, 72)
        Me.lblEstimated.Name = "lblEstimated"
        Me.lblEstimated.Size = New System.Drawing.Size(56, 13)
        Me.lblEstimated.TabIndex = 3
        Me.lblEstimated.Text = "Estimated:"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup.Location = New System.Drawing.Point(286, 245)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(87, 13)
        Me.lblGroup.TabIndex = 7
        Me.lblGroup.Text = "Group (Optional):"
        '
        'lblFacet
        '
        Me.lblFacet.AutoSize = True
        Me.lblFacet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacet.Location = New System.Drawing.Point(283, 199)
        Me.lblFacet.Name = "lblFacet"
        Me.lblFacet.Size = New System.Drawing.Size(85, 13)
        Me.lblFacet.TabIndex = 5
        Me.lblFacet.Text = "Facet (Optional):"
        '
        'cmdTaylorDiagramOptions
        '
        Me.cmdTaylorDiagramOptions.Enabled = False
        Me.cmdTaylorDiagramOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTaylorDiagramOptions.Location = New System.Drawing.Point(6, 204)
        Me.cmdTaylorDiagramOptions.Name = "cmdTaylorDiagramOptions"
        Me.cmdTaylorDiagramOptions.Size = New System.Drawing.Size(148, 28)
        Me.cmdTaylorDiagramOptions.TabIndex = 9
        Me.cmdTaylorDiagramOptions.Text = "Taylor Diagram Options"
        Me.cmdTaylorDiagramOptions.UseVisualStyleBackColor = True
        Me.cmdTaylorDiagramOptions.Visible = False
        '
        'ucrReceiverEstimated
        '
        Me.ucrReceiverEstimated.AutoSize = True
        Me.ucrReceiverEstimated.frmParent = Me
        Me.ucrReceiverEstimated.Location = New System.Drawing.Point(286, 88)
        Me.ucrReceiverEstimated.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEstimated.Name = "ucrReceiverEstimated"
        Me.ucrReceiverEstimated.Selector = Nothing
        Me.ucrReceiverEstimated.Size = New System.Drawing.Size(120, 57)
        Me.ucrReceiverEstimated.strNcFilePath = ""
        Me.ucrReceiverEstimated.TabIndex = 4
        Me.ucrReceiverEstimated.ucrSelector = Nothing
        '
        'ucrChkNormalise
        '
        Me.ucrChkNormalise.AutoSize = True
        Me.ucrChkNormalise.Checked = False
        Me.ucrChkNormalise.Location = New System.Drawing.Point(6, 238)
        Me.ucrChkNormalise.Name = "ucrChkNormalise"
        Me.ucrChkNormalise.Size = New System.Drawing.Size(134, 23)
        Me.ucrChkNormalise.TabIndex = 10
        '
        'ucrReceiverType
        '
        Me.ucrReceiverType.AutoSize = True
        Me.ucrReceiverType.frmParent = Me
        Me.ucrReceiverType.Location = New System.Drawing.Point(286, 214)
        Me.ucrReceiverType.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverType.Name = "ucrReceiverType"
        Me.ucrReceiverType.Selector = Nothing
        Me.ucrReceiverType.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverType.strNcFilePath = ""
        Me.ucrReceiverType.TabIndex = 6
        Me.ucrReceiverType.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 395)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePlot.Location = New System.Drawing.Point(6, 367)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(320, 22)
        Me.ucrSavePlot.TabIndex = 11
        '
        'ucrReceiverGroup
        '
        Me.ucrReceiverGroup.AutoSize = True
        Me.ucrReceiverGroup.frmParent = Me
        Me.ucrReceiverGroup.Location = New System.Drawing.Point(286, 261)
        Me.ucrReceiverGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGroup.Name = "ucrReceiverGroup"
        Me.ucrReceiverGroup.Selector = Nothing
        Me.ucrReceiverGroup.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverGroup.strNcFilePath = ""
        Me.ucrReceiverGroup.TabIndex = 8
        Me.ucrReceiverGroup.ucrSelector = Nothing
        '
        'ucrReceiverObserved
        '
        Me.ucrReceiverObserved.AutoSize = True
        Me.ucrReceiverObserved.frmParent = Me
        Me.ucrReceiverObserved.Location = New System.Drawing.Point(286, 40)
        Me.ucrReceiverObserved.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObserved.Name = "ucrReceiverObserved"
        Me.ucrReceiverObserved.Selector = Nothing
        Me.ucrReceiverObserved.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverObserved.strNcFilePath = ""
        Me.ucrReceiverObserved.TabIndex = 2
        Me.ucrReceiverObserved.ucrSelector = Nothing
        '
        'ucrSelectorTaylorDiagram
        '
        Me.ucrSelectorTaylorDiagram.AutoSize = True
        Me.ucrSelectorTaylorDiagram.bDropUnusedFilterLevels = False
        Me.ucrSelectorTaylorDiagram.bShowHiddenColumns = False
        Me.ucrSelectorTaylorDiagram.bUseCurrentFilter = True
        Me.ucrSelectorTaylorDiagram.Location = New System.Drawing.Point(6, 18)
        Me.ucrSelectorTaylorDiagram.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTaylorDiagram.Name = "ucrSelectorTaylorDiagram"
        Me.ucrSelectorTaylorDiagram.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTaylorDiagram.TabIndex = 0
        '
        'dlgTaylorDiagram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 449)
        Me.Controls.Add(Me.ucrReceiverEstimated)
        Me.Controls.Add(Me.cmdTaylorDiagramOptions)
        Me.Controls.Add(Me.ucrChkNormalise)
        Me.Controls.Add(Me.lblFacet)
        Me.Controls.Add(Me.ucrReceiverType)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblEstimated)
        Me.Controls.Add(Me.lblObserved)
        Me.Controls.Add(Me.ucrReceiverGroup)
        Me.Controls.Add(Me.ucrReceiverObserved)
        Me.Controls.Add(Me.ucrSelectorTaylorDiagram)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTaylorDiagram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taylor Diagram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorTaylorDiagram As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents lblGroup As Label
    Friend WithEvents lblEstimated As Label
    Friend WithEvents lblObserved As Label
    Friend WithEvents ucrReceiverGroup As ucrReceiverMultiple
    Friend WithEvents ucrReceiverObserved As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFacet As Label
    Friend WithEvents ucrReceiverType As ucrReceiverSingle
    Friend WithEvents ucrChkNormalise As ucrCheck
    Friend WithEvents cmdTaylorDiagramOptions As Button
    Friend WithEvents ucrReceiverEstimated As ucrReceiverMultiple
End Class
