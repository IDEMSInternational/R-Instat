<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRestoreLevelHierachy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRestoreLevelHierachy))
        Me.ucrSelectorRestoreHierachy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverKeyVariable = New instat.ucrReceiverSingle()
        Me.lblKeyVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverOtherVariables = New instat.ucrReceiverMultiple()
        Me.lblOtherVariables = New System.Windows.Forms.Label()
        Me.ucrDelete = New instat.ucrCheck()
        Me.ucrChkWarn = New instat.ucrCheck()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.tipReceiverOtherVariables = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'ucrSelectorRestoreHierachy
        '
        Me.ucrSelectorRestoreHierachy.bShowHiddenColumns = False
        Me.ucrSelectorRestoreHierachy.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRestoreHierachy, "ucrSelectorRestoreHierachy")
        Me.ucrSelectorRestoreHierachy.Name = "ucrSelectorRestoreHierachy"
        '
        'ucrReceiverKeyVariable
        '
        Me.ucrReceiverKeyVariable.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverKeyVariable, "ucrReceiverKeyVariable")
        Me.ucrReceiverKeyVariable.Name = "ucrReceiverKeyVariable"
        Me.ucrReceiverKeyVariable.Selector = Nothing
        Me.ucrReceiverKeyVariable.strNcFilePath = ""
        Me.ucrReceiverKeyVariable.ucrSelector = Nothing
        '
        'lblKeyVariable
        '
        resources.ApplyResources(Me.lblKeyVariable, "lblKeyVariable")
        Me.lblKeyVariable.Name = "lblKeyVariable"
        '
        'ucrReceiverOtherVariables
        '
        Me.ucrReceiverOtherVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOtherVariables, "ucrReceiverOtherVariables")
        Me.ucrReceiverOtherVariables.Name = "ucrReceiverOtherVariables"
        Me.ucrReceiverOtherVariables.Selector = Nothing
        Me.ucrReceiverOtherVariables.strNcFilePath = ""
        Me.ucrReceiverOtherVariables.ucrSelector = Nothing
        '
        'lblOtherVariables
        '
        resources.ApplyResources(Me.lblOtherVariables, "lblOtherVariables")
        Me.lblOtherVariables.Name = "lblOtherVariables"
        '
        'ucrDelete
        '
        Me.ucrDelete.Checked = False
        resources.ApplyResources(Me.ucrDelete, "ucrDelete")
        Me.ucrDelete.Name = "ucrDelete"
        '
        'ucrChkWarn
        '
        Me.ucrChkWarn.Checked = False
        resources.ApplyResources(Me.ucrChkWarn, "ucrChkWarn")
        Me.ucrChkWarn.Name = "ucrChkWarn"
        '
        'ucrSaveColumn
        '
        resources.ApplyResources(Me.ucrSaveColumn, "ucrSaveColumn")
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgRestoreLevelHierachy
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrChkWarn)
        Me.Controls.Add(Me.ucrDelete)
        Me.Controls.Add(Me.ucrReceiverOtherVariables)
        Me.Controls.Add(Me.lblOtherVariables)
        Me.Controls.Add(Me.lblKeyVariable)
        Me.Controls.Add(Me.ucrReceiverKeyVariable)
        Me.Controls.Add(Me.ucrSelectorRestoreHierachy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRestoreLevelHierachy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorRestoreHierachy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverKeyVariable As ucrReceiverSingle
    Friend WithEvents lblKeyVariable As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents ucrChkWarn As ucrCheck
    Friend WithEvents ucrDelete As ucrCheck
    Friend WithEvents ucrReceiverOtherVariables As ucrReceiverMultiple
    Friend WithEvents lblOtherVariables As Label
    Friend WithEvents tipReceiverOtherVariables As ToolTip
End Class
