<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRenameDescriptive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRenameDescriptive))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForRenameObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverCurrentName = New instat.ucrReceiverSingle()
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorForRenameObject
        '
        Me.ucrSelectorForRenameObject.bShowHiddenColumns = False
        Me.ucrSelectorForRenameObject.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorForRenameObject, "ucrSelectorForRenameObject")
        Me.ucrSelectorForRenameObject.Name = "ucrSelectorForRenameObject"
        '
        'ucrReceiverCurrentName
        '
        resources.ApplyResources(Me.ucrReceiverCurrentName, "ucrReceiverCurrentName")
        Me.ucrReceiverCurrentName.Name = "ucrReceiverCurrentName"
        Me.ucrReceiverCurrentName.Selector = Nothing
        '
        'lblCurrentName
        '
        resources.ApplyResources(Me.lblCurrentName, "lblCurrentName")
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Tag = "Current_Name"
        '
        'lblNewName
        '
        resources.ApplyResources(Me.lblNewName, "lblNewName")
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Tag = "New_Name"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewName, "ucrInputNewName")
        Me.ucrInputNewName.Name = "ucrInputNewName"
        '
        'dlgRenameDescriptive
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrReceiverCurrentName)
        Me.Controls.Add(Me.ucrSelectorForRenameObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRenameDescriptive"
        Me.Tag = "Rename_Object"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForRenameObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCurrentName As ucrReceiverSingle
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
End Class
