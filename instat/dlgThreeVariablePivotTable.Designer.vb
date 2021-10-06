<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgThreeVariablePivotTable
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgThreeVariablePivotTable))
        Me.lblAdditionalRowFactor = New System.Windows.Forms.Label()
        Me.lblInitialColumnFactor = New System.Windows.Forms.Label()
        Me.lblInitialRowFactor = New System.Windows.Forms.Label()
        Me.ttSelectedVariable = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblRenderer = New System.Windows.Forms.Label()
        Me.ucrInputRenderer = New instat.ucrInputComboBox()
        Me.ucrReceiverInitialRowFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverAdditionalRowFactor = New instat.ucrReceiverSingle()
        Me.ucrSavePivot = New instat.ucrSave()
        Me.ucrChkIncludeSubTotals = New instat.ucrCheck()
        Me.ucrReceiverSelectedVariable = New instat.ucrReceiverMultiple()
        Me.ucrChkSelectedVariable = New instat.ucrCheck()
        Me.ucrReceiverInitialColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorPivot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputAggregator = New instat.ucrInputComboBox()
        Me.lblAggregator = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAdditionalRowFactor
        '
        resources.ApplyResources(Me.lblAdditionalRowFactor, "lblAdditionalRowFactor")
        Me.lblAdditionalRowFactor.Name = "lblAdditionalRowFactor"
        Me.lblAdditionalRowFactor.Tag = "Initial Column Factor:"
        '
        'lblInitialColumnFactor
        '
        resources.ApplyResources(Me.lblInitialColumnFactor, "lblInitialColumnFactor")
        Me.lblInitialColumnFactor.Name = "lblInitialColumnFactor"
        Me.lblInitialColumnFactor.Tag = "Initial Column Factor:"
        '
        'lblInitialRowFactor
        '
        resources.ApplyResources(Me.lblInitialRowFactor, "lblInitialRowFactor")
        Me.lblInitialRowFactor.Name = "lblInitialRowFactor"
        Me.lblInitialRowFactor.Tag = "Initial Row Factor:"
        '
        'lblRenderer
        '
        resources.ApplyResources(Me.lblRenderer, "lblRenderer")
        Me.lblRenderer.Name = "lblRenderer"
        '
        'ucrInputRenderer
        '
        Me.ucrInputRenderer.AddQuotesIfUnrecognised = True
        Me.ucrInputRenderer.GetSetSelectedIndex = -1
        Me.ucrInputRenderer.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRenderer, "ucrInputRenderer")
        Me.ucrInputRenderer.Name = "ucrInputRenderer"
        '
        'ucrReceiverInitialRowFactors
        '
        Me.ucrReceiverInitialRowFactors.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverInitialRowFactors, "ucrReceiverInitialRowFactors")
        Me.ucrReceiverInitialRowFactors.Name = "ucrReceiverInitialRowFactors"
        Me.ucrReceiverInitialRowFactors.Selector = Nothing
        Me.ucrReceiverInitialRowFactors.strNcFilePath = ""
        Me.ucrReceiverInitialRowFactors.ucrSelector = Nothing
        '
        'ucrReceiverAdditionalRowFactor
        '
        Me.ucrReceiverAdditionalRowFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverAdditionalRowFactor, "ucrReceiverAdditionalRowFactor")
        Me.ucrReceiverAdditionalRowFactor.Name = "ucrReceiverAdditionalRowFactor"
        Me.ucrReceiverAdditionalRowFactor.Selector = Nothing
        Me.ucrReceiverAdditionalRowFactor.strNcFilePath = ""
        Me.ucrReceiverAdditionalRowFactor.ucrSelector = Nothing
        '
        'ucrSavePivot
        '
        resources.ApplyResources(Me.ucrSavePivot, "ucrSavePivot")
        Me.ucrSavePivot.Name = "ucrSavePivot"
        '
        'ucrChkIncludeSubTotals
        '
        Me.ucrChkIncludeSubTotals.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeSubTotals, "ucrChkIncludeSubTotals")
        Me.ucrChkIncludeSubTotals.Name = "ucrChkIncludeSubTotals"
        '
        'ucrReceiverSelectedVariable
        '
        Me.ucrReceiverSelectedVariable.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSelectedVariable, "ucrReceiverSelectedVariable")
        Me.ucrReceiverSelectedVariable.Name = "ucrReceiverSelectedVariable"
        Me.ucrReceiverSelectedVariable.Selector = Nothing
        Me.ucrReceiverSelectedVariable.strNcFilePath = ""
        Me.ucrReceiverSelectedVariable.ucrSelector = Nothing
        '
        'ucrChkSelectedVariable
        '
        Me.ucrChkSelectedVariable.Checked = False
        resources.ApplyResources(Me.ucrChkSelectedVariable, "ucrChkSelectedVariable")
        Me.ucrChkSelectedVariable.Name = "ucrChkSelectedVariable"
        '
        'ucrReceiverInitialColumnFactor
        '
        Me.ucrReceiverInitialColumnFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverInitialColumnFactor, "ucrReceiverInitialColumnFactor")
        Me.ucrReceiverInitialColumnFactor.Name = "ucrReceiverInitialColumnFactor"
        Me.ucrReceiverInitialColumnFactor.Selector = Nothing
        Me.ucrReceiverInitialColumnFactor.strNcFilePath = ""
        Me.ucrReceiverInitialColumnFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorPivot
        '
        Me.ucrSelectorPivot.bDropUnusedFilterLevels = False
        Me.ucrSelectorPivot.bShowHiddenColumns = False
        Me.ucrSelectorPivot.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorPivot, "ucrSelectorPivot")
        Me.ucrSelectorPivot.Name = "ucrSelectorPivot"
        '
        'ucrInputAggregator
        '
        Me.ucrInputAggregator.AddQuotesIfUnrecognised = True
        Me.ucrInputAggregator.GetSetSelectedIndex = -1
        Me.ucrInputAggregator.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputAggregator, "ucrInputAggregator")
        Me.ucrInputAggregator.Name = "ucrInputAggregator"
        '
        'lblAggregator
        '
        resources.ApplyResources(Me.lblAggregator, "lblAggregator")
        Me.lblAggregator.Name = "lblAggregator"
        '
        'dlgThreeVariablePivotTable
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputAggregator)
        Me.Controls.Add(Me.lblAggregator)
        Me.Controls.Add(Me.ucrInputRenderer)
        Me.Controls.Add(Me.lblRenderer)
        Me.Controls.Add(Me.ucrReceiverInitialRowFactors)
        Me.Controls.Add(Me.lblAdditionalRowFactor)
        Me.Controls.Add(Me.lblInitialColumnFactor)
        Me.Controls.Add(Me.lblInitialRowFactor)
        Me.Controls.Add(Me.ucrReceiverAdditionalRowFactor)
        Me.Controls.Add(Me.ucrSavePivot)
        Me.Controls.Add(Me.ucrChkIncludeSubTotals)
        Me.Controls.Add(Me.ucrReceiverSelectedVariable)
        Me.Controls.Add(Me.ucrChkSelectedVariable)
        Me.Controls.Add(Me.ucrReceiverInitialColumnFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorPivot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariablePivotTable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdditionalRowFactor As Label
    Friend WithEvents lblInitialColumnFactor As Label
    Friend WithEvents lblInitialRowFactor As Label
    Friend WithEvents ttSelectedVariable As ToolTip
    Friend WithEvents ucrReceiverAdditionalRowFactor As ucrReceiverSingle
    Friend WithEvents ucrSavePivot As ucrSave
    Friend WithEvents ucrChkIncludeSubTotals As ucrCheck
    Friend WithEvents ucrReceiverSelectedVariable As ucrReceiverMultiple
    Friend WithEvents ucrChkSelectedVariable As ucrCheck
    Friend WithEvents ucrReceiverInitialColumnFactor As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPivot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverInitialRowFactors As ucrReceiverMultiple
    Friend WithEvents ucrInputRenderer As ucrInputComboBox
    Friend WithEvents lblRenderer As Label
    Friend WithEvents ucrInputAggregator As ucrInputComboBox
    Friend WithEvents lblAggregator As Label
End Class
