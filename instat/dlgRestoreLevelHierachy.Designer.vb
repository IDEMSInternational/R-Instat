<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRestoreLevelHierachy
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRestoreLevelHierachy))
        Me.lblKeyVariable = New System.Windows.Forms.Label()
        Me.lblOtherVariables = New System.Windows.Forms.Label()
        Me.tipRestoreHierachy = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrChkWarn = New instat.ucrCheck()
        Me.ucrChkDelete = New instat.ucrCheck()
        Me.ucrReceiverOtherVariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverKeyVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorRestoreHierachy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblKeyVariable
        '
        resources.ApplyResources(Me.lblKeyVariable, "lblKeyVariable")
        Me.lblKeyVariable.Name = "lblKeyVariable"
        '
        'lblOtherVariables
        '
        resources.ApplyResources(Me.lblOtherVariables, "lblOtherVariables")
        Me.lblOtherVariables.Name = "lblOtherVariables"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSaveColumn
        '
        resources.ApplyResources(Me.ucrSaveColumn, "ucrSaveColumn")
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        '
        'ucrChkWarn
        '
        Me.ucrChkWarn.Checked = False
        resources.ApplyResources(Me.ucrChkWarn, "ucrChkWarn")
        Me.ucrChkWarn.Name = "ucrChkWarn"
        '
        'ucrChkDelete
        '
        Me.ucrChkDelete.Checked = False
        resources.ApplyResources(Me.ucrChkDelete, "ucrChkDelete")
        Me.ucrChkDelete.Name = "ucrChkDelete"
        '
        'ucrReceiverOtherVariables
        '
        Me.ucrReceiverOtherVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOtherVariables, "ucrReceiverOtherVariables")
        Me.ucrReceiverOtherVariables.Name = "ucrReceiverOtherVariables"
        Me.ucrReceiverOtherVariables.Selector = Nothing
        Me.ucrReceiverOtherVariables.strNcFilePath = ""
        Me.tipRestoreHierachy.SetToolTip(Me.ucrReceiverOtherVariables, resources.GetString("ucrReceiverOtherVariables.ToolTip"))
        Me.ucrReceiverOtherVariables.ucrSelector = Nothing
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
        'ucrSelectorRestoreHierachy
        '
        Me.ucrSelectorRestoreHierachy.bShowHiddenColumns = False
        Me.ucrSelectorRestoreHierachy.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRestoreHierachy, "ucrSelectorRestoreHierachy")
        Me.ucrSelectorRestoreHierachy.Name = "ucrSelectorRestoreHierachy"
        '
        'dlgRestoreLevelHierachy
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrChkWarn)
        Me.Controls.Add(Me.ucrChkDelete)
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
    Friend WithEvents ucrChkDelete As ucrCheck
    Friend WithEvents ucrReceiverOtherVariables As ucrReceiverMultiple
    Friend WithEvents lblOtherVariables As Label
    Friend WithEvents tipRestoreHierachy As ToolTip
End Class
