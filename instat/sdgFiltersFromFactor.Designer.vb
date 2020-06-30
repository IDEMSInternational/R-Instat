<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgFiltersFromFactor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgFiltersFromFactor))
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmdToggleSelectAll = New System.Windows.Forms.Button()
        Me.lblExsistingFilter = New System.Windows.Forms.Label()
        Me.ucrReceiverExistingFilter = New instat.ucrReceiverSingle()
        Me.ucrChkAndExistingFilter = New instat.ucrCheck()
        Me.ucrFactorLevel = New instat.ucrFactor()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorSelctor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        '
        'cmdToggleSelectAll
        '
        resources.ApplyResources(Me.cmdToggleSelectAll, "cmdToggleSelectAll")
        Me.cmdToggleSelectAll.Name = "cmdToggleSelectAll"
        Me.cmdToggleSelectAll.UseVisualStyleBackColor = True
        '
        'lblExsistingFilter
        '
        resources.ApplyResources(Me.lblExsistingFilter, "lblExsistingFilter")
        Me.lblExsistingFilter.Name = "lblExsistingFilter"
        '
        'ucrReceiverExistingFilter
        '
        Me.ucrReceiverExistingFilter.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverExistingFilter, "ucrReceiverExistingFilter")
        Me.ucrReceiverExistingFilter.Name = "ucrReceiverExistingFilter"
        Me.ucrReceiverExistingFilter.Selector = Nothing
        Me.ucrReceiverExistingFilter.strNcFilePath = ""
        Me.ucrReceiverExistingFilter.ucrSelector = Nothing
        '
        'ucrChkAndExistingFilter
        '
        Me.ucrChkAndExistingFilter.Checked = False
        resources.ApplyResources(Me.ucrChkAndExistingFilter, "ucrChkAndExistingFilter")
        Me.ucrChkAndExistingFilter.Name = "ucrChkAndExistingFilter"
        '
        'ucrFactorLevel
        '
        resources.ApplyResources(Me.ucrFactorLevel, "ucrFactorLevel")
        Me.ucrFactorLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevel.clsReceiver = Nothing
        Me.ucrFactorLevel.Name = "ucrFactorLevel"
        Me.ucrFactorLevel.shtCurrSheet = Nothing
        Me.ucrFactorLevel.ucrChkLevels = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorReceiver, "ucrFactorReceiver")
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'ucrFactorSelctor
        '
        Me.ucrFactorSelctor.bDropUnusedFilterLevels = False
        Me.ucrFactorSelctor.bShowHiddenColumns = False
        Me.ucrFactorSelctor.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrFactorSelctor, "ucrFactorSelctor")
        Me.ucrFactorSelctor.Name = "ucrFactorSelctor"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'sdgFiltersFromFactor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblExsistingFilter)
        Me.Controls.Add(Me.ucrReceiverExistingFilter)
        Me.Controls.Add(Me.ucrChkAndExistingFilter)
        Me.Controls.Add(Me.cmdToggleSelectAll)
        Me.Controls.Add(Me.ucrFactorLevel)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrFactorSelctor)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFiltersFromFactor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrFactorSelctor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrFactorLevel As ucrFactor
    Friend WithEvents cmdToggleSelectAll As Button
    Friend WithEvents ucrChkAndExistingFilter As ucrCheck
    Friend WithEvents ucrReceiverExistingFilter As ucrReceiverSingle
    Friend WithEvents lblExsistingFilter As Label
End Class
