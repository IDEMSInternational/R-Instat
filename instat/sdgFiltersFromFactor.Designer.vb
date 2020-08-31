<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgFiltersFromFactor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgFiltersFromFactor))
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrSelectorFiltersFromFactors = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrFactorLevels = New instat.ucrFactor()
        Me.cmdSelectAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorFiltersFromFactors
        '
        Me.ucrSelectorFiltersFromFactors.bDropUnusedFilterLevels = False
        Me.ucrSelectorFiltersFromFactors.bShowHiddenColumns = False
        Me.ucrSelectorFiltersFromFactors.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFiltersFromFactors, "ucrSelectorFiltersFromFactors")
        Me.ucrSelectorFiltersFromFactors.Name = "ucrSelectorFiltersFromFactors"
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        '
        'ucrFactorLevels
        '
        resources.ApplyResources(Me.ucrFactorLevels, "ucrFactorLevels")
        Me.ucrFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.ucrChkLevels = Nothing
        '
        'cmdSelectAll
        '
        resources.ApplyResources(Me.cmdSelectAll, "cmdSelectAll")
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.UseVisualStyleBackColor = True
        '
        'sdgFiltersFromFactor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdSelectAll)
        Me.Controls.Add(Me.ucrFactorLevels)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSelectorFiltersFromFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFiltersFromFactor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrSelectorFiltersFromFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrFactorLevels As ucrFactor
    Friend WithEvents cmdSelectAll As Button
End Class
