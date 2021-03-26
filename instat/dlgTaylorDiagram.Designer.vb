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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTaylorDiagram))
        Me.lblObserved = New System.Windows.Forms.Label()
        Me.lblEstimated = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.ucrChkNormalise = New instat.ucrCheck()
        Me.ucrReceiverType = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrReceiverGroup = New instat.ucrReceiverMultiple()
        Me.ucrReceiverObserved = New instat.ucrReceiverSingle()
        Me.ucrReceiverEstimated = New instat.ucrReceiverSingle()
        Me.ucrSelectorTaylorDiagram = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdTaylorDiagramOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblObserved
        '
        resources.ApplyResources(Me.lblObserved, "lblObserved")
        Me.lblObserved.Name = "lblObserved"
        '
        'lblEstimated
        '
        resources.ApplyResources(Me.lblEstimated, "lblEstimated")
        Me.lblEstimated.Name = "lblEstimated"
        '
        'lblGroup
        '
        resources.ApplyResources(Me.lblGroup, "lblGroup")
        Me.lblGroup.Name = "lblGroup"
        '
        'lblFacet
        '
        resources.ApplyResources(Me.lblFacet, "lblFacet")
        Me.lblFacet.Name = "lblFacet"
        '
        'ucrChkNormalise
        '
        Me.ucrChkNormalise.Checked = False
        resources.ApplyResources(Me.ucrChkNormalise, "ucrChkNormalise")
        Me.ucrChkNormalise.Name = "ucrChkNormalise"
        '
        'ucrReceiverType
        '
        Me.ucrReceiverType.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverType, "ucrReceiverType")
        Me.ucrReceiverType.Name = "ucrReceiverType"
        Me.ucrReceiverType.Selector = Nothing
        Me.ucrReceiverType.strNcFilePath = ""
        Me.ucrReceiverType.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSavePlot
        '
        resources.ApplyResources(Me.ucrSavePlot, "ucrSavePlot")
        Me.ucrSavePlot.Name = "ucrSavePlot"
        '
        'ucrReceiverGroup
        '
        Me.ucrReceiverGroup.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverGroup, "ucrReceiverGroup")
        Me.ucrReceiverGroup.Name = "ucrReceiverGroup"
        Me.ucrReceiverGroup.Selector = Nothing
        Me.ucrReceiverGroup.strNcFilePath = ""
        Me.ucrReceiverGroup.ucrSelector = Nothing
        '
        'ucrReceiverObserved
        '
        Me.ucrReceiverObserved.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverObserved, "ucrReceiverObserved")
        Me.ucrReceiverObserved.Name = "ucrReceiverObserved"
        Me.ucrReceiverObserved.Selector = Nothing
        Me.ucrReceiverObserved.strNcFilePath = ""
        Me.ucrReceiverObserved.ucrSelector = Nothing
        '
        'ucrReceiverEstimated
        '
        Me.ucrReceiverEstimated.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverEstimated, "ucrReceiverEstimated")
        Me.ucrReceiverEstimated.Name = "ucrReceiverEstimated"
        Me.ucrReceiverEstimated.Selector = Nothing
        Me.ucrReceiverEstimated.strNcFilePath = ""
        Me.ucrReceiverEstimated.ucrSelector = Nothing
        '
        'ucrSelectorTaylorDiagram
        '
        Me.ucrSelectorTaylorDiagram.bDropUnusedFilterLevels = False
        Me.ucrSelectorTaylorDiagram.bShowHiddenColumns = False
        Me.ucrSelectorTaylorDiagram.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTaylorDiagram, "ucrSelectorTaylorDiagram")
        Me.ucrSelectorTaylorDiagram.Name = "ucrSelectorTaylorDiagram"
        '
        'cmdTaylorDiagramOptions
        '
        resources.ApplyResources(Me.cmdTaylorDiagramOptions, "cmdTaylorDiagramOptions")
        Me.cmdTaylorDiagramOptions.Name = "cmdTaylorDiagramOptions"
        Me.cmdTaylorDiagramOptions.UseVisualStyleBackColor = True
        '
        'dlgTaylorDiagram
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.ucrReceiverEstimated)
        Me.Controls.Add(Me.ucrSelectorTaylorDiagram)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTaylorDiagram"
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
    Friend WithEvents ucrReceiverEstimated As ucrReceiverSingle
    Friend WithEvents ucrChkNormalise As ucrCheck
    Friend WithEvents cmdTaylorDiagramOptions As Button
End Class
