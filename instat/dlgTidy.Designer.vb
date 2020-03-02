<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTidy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTidy))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrModelSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblModels = New System.Windows.Forms.Label()
        Me.UcrReceiverMultiple1 = New instat.ucrReceiverMultiple()
        Me.ucrChkDisplayInOutput = New instat.ucrCheck()
        Me.UcrSave1 = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrModelSelector
        '
        Me.ucrModelSelector.bDropUnusedFilterLevels = False
        Me.ucrModelSelector.bShowHiddenColumns = False
        Me.ucrModelSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrModelSelector, "ucrModelSelector")
        Me.ucrModelSelector.Name = "ucrModelSelector"
        '
        'lblModels
        '
        resources.ApplyResources(Me.lblModels, "lblModels")
        Me.lblModels.Name = "lblModels"
        '
        'UcrReceiverMultiple1
        '
        Me.UcrReceiverMultiple1.frmParent = Me
        resources.ApplyResources(Me.UcrReceiverMultiple1, "UcrReceiverMultiple1")
        Me.UcrReceiverMultiple1.Name = "UcrReceiverMultiple1"
        Me.UcrReceiverMultiple1.Selector = Nothing
        Me.UcrReceiverMultiple1.strNcFilePath = ""
        Me.UcrReceiverMultiple1.ucrSelector = Nothing
        '
        'ucrChkDisplayInOutput
        '
        Me.ucrChkDisplayInOutput.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayInOutput, "ucrChkDisplayInOutput")
        Me.ucrChkDisplayInOutput.Name = "ucrChkDisplayInOutput"
        '
        'UcrSave1
        '
        resources.ApplyResources(Me.UcrSave1, "UcrSave1")
        Me.UcrSave1.Name = "UcrSave1"
        '
        'dlgTidy
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcrSave1)
        Me.Controls.Add(Me.ucrChkDisplayInOutput)
        Me.Controls.Add(Me.UcrReceiverMultiple1)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.ucrModelSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTidy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrModelSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblModels As Label
    Friend WithEvents UcrReceiverMultiple1 As ucrReceiverMultiple
    Friend WithEvents UcrSave1 As ucrSave
    Friend WithEvents ucrChkDisplayInOutput As ucrCheck
End Class
