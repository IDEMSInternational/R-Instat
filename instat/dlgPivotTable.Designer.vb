<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPivotTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgPivotTable))
        Me.lblInitialRowFactor = New System.Windows.Forms.Label()
        Me.lblInitialColumnFactor = New System.Windows.Forms.Label()
        Me.lblAdditionalRowFactor = New System.Windows.Forms.Label()
        Me.ttSelectedVariable = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrReceiverSelectedVariable = New instat.ucrReceiverMultiple()
        Me.ucrChkSelectedVariable = New instat.ucrCheck()
        Me.UcrInputComboBox2 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.ucrInputSummaries = New instat.ucrInputComboBox()
        Me.ucrReceiveradditionalRowFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverInitialColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverInitialRowFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorPivot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkIncludeSubTotals = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblInitialRowFactor
        '
        resources.ApplyResources(Me.lblInitialRowFactor, "lblInitialRowFactor")
        Me.lblInitialRowFactor.Name = "lblInitialRowFactor"
        Me.lblInitialRowFactor.Tag = "Initial Row Factor:"
        '
        'lblInitialColumnFactor
        '
        resources.ApplyResources(Me.lblInitialColumnFactor, "lblInitialColumnFactor")
        Me.lblInitialColumnFactor.Name = "lblInitialColumnFactor"
        Me.lblInitialColumnFactor.Tag = "Initial Column Factor:"
        '
        'lblAdditionalRowFactor
        '
        resources.ApplyResources(Me.lblAdditionalRowFactor, "lblAdditionalRowFactor")
        Me.lblAdditionalRowFactor.Name = "lblAdditionalRowFactor"
        Me.lblAdditionalRowFactor.Tag = "Additional Row Factor"
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
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.GetSetSelectedIndex = -1
        Me.UcrInputComboBox2.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox2, "UcrInputComboBox2")
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.GetSetSelectedIndex = -1
        Me.UcrInputComboBox1.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox1, "UcrInputComboBox1")
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        '
        'ucrInputSummaries
        '
        Me.ucrInputSummaries.AddQuotesIfUnrecognised = True
        Me.ucrInputSummaries.GetSetSelectedIndex = -1
        Me.ucrInputSummaries.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSummaries, "ucrInputSummaries")
        Me.ucrInputSummaries.Name = "ucrInputSummaries"
        '
        'ucrReceiveradditionalRowFactor
        '
        Me.ucrReceiveradditionalRowFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiveradditionalRowFactor, "ucrReceiveradditionalRowFactor")
        Me.ucrReceiveradditionalRowFactor.Name = "ucrReceiveradditionalRowFactor"
        Me.ucrReceiveradditionalRowFactor.Selector = Nothing
        Me.ucrReceiveradditionalRowFactor.strNcFilePath = ""
        Me.ucrReceiveradditionalRowFactor.ucrSelector = Nothing
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
        'ucrReceiverInitialRowFactor
        '
        Me.ucrReceiverInitialRowFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverInitialRowFactor, "ucrReceiverInitialRowFactor")
        Me.ucrReceiverInitialRowFactor.Name = "ucrReceiverInitialRowFactor"
        Me.ucrReceiverInitialRowFactor.Selector = Nothing
        Me.ucrReceiverInitialRowFactor.strNcFilePath = ""
        Me.ucrReceiverInitialRowFactor.ucrSelector = Nothing
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
        'ucrChkIncludeSubTotals
        '
        Me.ucrChkIncludeSubTotals.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeSubTotals, "ucrChkIncludeSubTotals")
        Me.ucrChkIncludeSubTotals.Name = "ucrChkIncludeSubTotals"
        '
        'dlgPivotTable
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkIncludeSubTotals)
        Me.Controls.Add(Me.ucrReceiverSelectedVariable)
        Me.Controls.Add(Me.ucrChkSelectedVariable)
        Me.Controls.Add(Me.UcrInputComboBox2)
        Me.Controls.Add(Me.UcrInputComboBox1)
        Me.Controls.Add(Me.ucrInputSummaries)
        Me.Controls.Add(Me.lblAdditionalRowFactor)
        Me.Controls.Add(Me.ucrReceiveradditionalRowFactor)
        Me.Controls.Add(Me.lblInitialColumnFactor)
        Me.Controls.Add(Me.ucrReceiverInitialColumnFactor)
        Me.Controls.Add(Me.lblInitialRowFactor)
        Me.Controls.Add(Me.ucrReceiverInitialRowFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorPivot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPivotTable"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorPivot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblInitialRowFactor As Label
    Friend WithEvents ucrReceiverInitialRowFactor As ucrReceiverSingle
    Friend WithEvents lblAdditionalRowFactor As Label
    Friend WithEvents ucrReceiveradditionalRowFactor As ucrReceiverSingle
    Friend WithEvents lblInitialColumnFactor As Label
    Friend WithEvents ucrReceiverInitialColumnFactor As ucrReceiverSingle
    Friend WithEvents UcrInputComboBox2 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents ucrInputSummaries As ucrInputComboBox
    Friend WithEvents ucrChkSelectedVariable As ucrCheck
    Friend WithEvents ttSelectedVariable As ToolTip
    Friend WithEvents ucrReceiverSelectedVariable As ucrReceiverMultiple
    Friend WithEvents ucrChkIncludeSubTotals As ucrCheck
End Class
