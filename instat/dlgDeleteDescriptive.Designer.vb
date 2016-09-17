<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteDescriptive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDeleteDescriptive))
        Me.lblObjectsToDelete = New System.Windows.Forms.Label()
        Me.ucrReceiverObjectsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDeleteObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblObjectsToDelete
        '
        resources.ApplyResources(Me.lblObjectsToDelete, "lblObjectsToDelete")
        Me.lblObjectsToDelete.Name = "lblObjectsToDelete"
        Me.lblObjectsToDelete.Tag = "Objects_to_Delete"
        '
        'ucrReceiverObjectsToDelete
        '
        resources.ApplyResources(Me.ucrReceiverObjectsToDelete, "ucrReceiverObjectsToDelete")
        Me.ucrReceiverObjectsToDelete.Name = "ucrReceiverObjectsToDelete"
        Me.ucrReceiverObjectsToDelete.Selector = Nothing
        '
        'ucrSelectorDeleteObject
        '
        Me.ucrSelectorDeleteObject.bShowHiddenColumns = False
        Me.ucrSelectorDeleteObject.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorDeleteObject, "ucrSelectorDeleteObject")
        Me.ucrSelectorDeleteObject.Name = "ucrSelectorDeleteObject"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgDeleteDescriptive
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverObjectsToDelete)
        Me.Controls.Add(Me.lblObjectsToDelete)
        Me.Controls.Add(Me.ucrSelectorDeleteObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteDescriptive"
        Me.Tag = "Delete_Object"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDeleteObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblObjectsToDelete As Label
    Friend WithEvents ucrReceiverObjectsToDelete As ucrReceiverMultiple
End Class
