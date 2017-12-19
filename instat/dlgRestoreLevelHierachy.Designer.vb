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
        Me.lblCarryVariables = New System.Windows.Forms.Label()
        Me.tipRestoreHierachy = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrReceiverCarryVariables = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrChkWarn = New instat.ucrCheck()
        Me.ucrChkDelete = New instat.ucrCheck()
        Me.ucrSelectorRestoreHierachy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverKeyVariables = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblKeyVariable
        '
        resources.ApplyResources(Me.lblKeyVariable, "lblKeyVariable")
        Me.lblKeyVariable.Name = "lblKeyVariable"
        '
        'lblCarryVariables
        '
        resources.ApplyResources(Me.lblCarryVariables, "lblCarryVariables")
        Me.lblCarryVariables.Name = "lblCarryVariables"
        '
        'ucrReceiverCarryVariables
        '
        Me.ucrReceiverCarryVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCarryVariables, "ucrReceiverCarryVariables")
        Me.ucrReceiverCarryVariables.Name = "ucrReceiverCarryVariables"
        Me.ucrReceiverCarryVariables.Selector = Nothing
        Me.ucrReceiverCarryVariables.strNcFilePath = ""
        Me.tipRestoreHierachy.SetToolTip(Me.ucrReceiverCarryVariables, resources.GetString("ucrReceiverCarryVariables.ToolTip"))
        Me.ucrReceiverCarryVariables.ucrSelector = Nothing
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
        'ucrSelectorRestoreHierachy
        '
        Me.ucrSelectorRestoreHierachy.bShowHiddenColumns = False
        Me.ucrSelectorRestoreHierachy.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRestoreHierachy, "ucrSelectorRestoreHierachy")
        Me.ucrSelectorRestoreHierachy.Name = "ucrSelectorRestoreHierachy"
        '
        'ucrReceiverKeyVariables
        '
        Me.ucrReceiverKeyVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverKeyVariables, "ucrReceiverKeyVariables")
        Me.ucrReceiverKeyVariables.Name = "ucrReceiverKeyVariables"
        Me.ucrReceiverKeyVariables.Selector = Nothing
        Me.ucrReceiverKeyVariables.strNcFilePath = ""
        Me.tipRestoreHierachy.SetToolTip(Me.ucrReceiverKeyVariables, resources.GetString("ucrReceiverKeyVariables.ToolTip"))
        Me.ucrReceiverKeyVariables.ucrSelector = Nothing
        '
        'dlgRestoreLevelHierachy
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverKeyVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrChkWarn)
        Me.Controls.Add(Me.ucrChkDelete)
        Me.Controls.Add(Me.ucrReceiverCarryVariables)
        Me.Controls.Add(Me.lblCarryVariables)
        Me.Controls.Add(Me.lblKeyVariable)
        Me.Controls.Add(Me.ucrSelectorRestoreHierachy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRestoreLevelHierachy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorRestoreHierachy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblKeyVariable As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents ucrChkWarn As ucrCheck
    Friend WithEvents ucrChkDelete As ucrCheck
    Friend WithEvents ucrReceiverCarryVariables As ucrReceiverMultiple
    Friend WithEvents lblCarryVariables As Label
    Friend WithEvents tipRestoreHierachy As ToolTip
    Friend WithEvents ucrReceiverKeyVariables As ucrReceiverMultiple
End Class
