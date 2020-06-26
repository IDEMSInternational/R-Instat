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
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrChkNormalise = New instat.ucrCheck()
        Me.ucrReceiverSingleStation = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrReceiverMultipleGroup = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSingleObserved = New instat.ucrReceiverSingle()
        Me.ucrReceiverSingleEstimate = New instat.ucrReceiverSingle()
        Me.ucrSelectorTaylorDiagram = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblObserved
        '
        resources.ApplyResources(Me.lblObserved, "lblObserved")
        Me.lblObserved.Name = "lblObserved"
        '
        'lblEstimate
        '
        resources.ApplyResources(Me.lblEstimate, "lblEstimate")
        Me.lblEstimate.Name = "lblEstimate"
        '
        'lblGroup
        '
        resources.ApplyResources(Me.lblGroup, "lblGroup")
        Me.lblGroup.Name = "lblGroup"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'ucrChkNormalise
        '
        Me.ucrChkNormalise.Checked = False
        resources.ApplyResources(Me.ucrChkNormalise, "ucrChkNormalise")
        Me.ucrChkNormalise.Name = "ucrChkNormalise"
        '
        'ucrReceiverSingleStation
        '
        Me.ucrReceiverSingleStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSingleStation, "ucrReceiverSingleStation")
        Me.ucrReceiverSingleStation.Name = "ucrReceiverSingleStation"
        Me.ucrReceiverSingleStation.Selector = Nothing
        Me.ucrReceiverSingleStation.strNcFilePath = ""
        Me.ucrReceiverSingleStation.ucrSelector = Nothing
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
        'ucrReceiverMultipleGroup
        '
        Me.ucrReceiverMultipleGroup.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleGroup, "ucrReceiverMultipleGroup")
        Me.ucrReceiverMultipleGroup.Name = "ucrReceiverMultipleGroup"
        Me.ucrReceiverMultipleGroup.Selector = Nothing
        Me.ucrReceiverMultipleGroup.strNcFilePath = ""
        Me.ucrReceiverMultipleGroup.ucrSelector = Nothing
        '
        'ucrReceiverSingleObserved
        '
        Me.ucrReceiverSingleObserved.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSingleObserved, "ucrReceiverSingleObserved")
        Me.ucrReceiverSingleObserved.Name = "ucrReceiverSingleObserved"
        Me.ucrReceiverSingleObserved.Selector = Nothing
        Me.ucrReceiverSingleObserved.strNcFilePath = ""
        Me.ucrReceiverSingleObserved.ucrSelector = Nothing
        '
        'ucrReceiverSingleEstimate
        '
        Me.ucrReceiverSingleEstimate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSingleEstimate, "ucrReceiverSingleEstimate")
        Me.ucrReceiverSingleEstimate.Name = "ucrReceiverSingleEstimate"
        Me.ucrReceiverSingleEstimate.Selector = Nothing
        Me.ucrReceiverSingleEstimate.strNcFilePath = ""
        Me.ucrReceiverSingleEstimate.ucrSelector = Nothing
        '
        'ucrSelectorTaylorDiagram
        '
        Me.ucrSelectorTaylorDiagram.bDropUnusedFilterLevels = False
        Me.ucrSelectorTaylorDiagram.bShowHiddenColumns = False
        Me.ucrSelectorTaylorDiagram.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTaylorDiagram, "ucrSelectorTaylorDiagram")
        Me.ucrSelectorTaylorDiagram.Name = "ucrSelectorTaylorDiagram"
        '
        'dlgTaylorDiagram
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkNormalise)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverSingleStation)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.lblObserved)
        Me.Controls.Add(Me.ucrReceiverMultipleGroup)
        Me.Controls.Add(Me.ucrReceiverSingleObserved)
        Me.Controls.Add(Me.ucrReceiverSingleEstimate)
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
    Friend WithEvents lblEstimate As Label
    Friend WithEvents lblObserved As Label
    Friend WithEvents ucrReceiverMultipleGroup As ucrReceiverMultiple
    Friend WithEvents ucrReceiverSingleObserved As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverSingleStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverSingleEstimate As ucrReceiverSingle
    Friend WithEvents ucrChkNormalise As ucrCheck
End Class
