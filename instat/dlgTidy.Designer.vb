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
        Me.lblModels = New System.Windows.Forms.Label()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrModelReceiver = New instat.ucrReceiverMultiple()
        Me.ucrModelSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.rdoDisplayInOutput = New System.Windows.Forms.RadioButton()
        Me.rdoNewDataFrame = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblModels
        '
        resources.ApplyResources(Me.lblModels, "lblModels")
        Me.lblModels.Name = "lblModels"
        '
        'ucrSaveNewDataFrame
        '
        resources.ApplyResources(Me.ucrSaveNewDataFrame, "ucrSaveNewDataFrame")
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        '
        'ucrModelReceiver
        '
        Me.ucrModelReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrModelReceiver, "ucrModelReceiver")
        Me.ucrModelReceiver.Name = "ucrModelReceiver"
        Me.ucrModelReceiver.Selector = Nothing
        Me.ucrModelReceiver.strNcFilePath = ""
        Me.ucrModelReceiver.ucrSelector = Nothing
        '
        'ucrModelSelector
        '
        Me.ucrModelSelector.bDropUnusedFilterLevels = False
        Me.ucrModelSelector.bShowHiddenColumns = False
        Me.ucrModelSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrModelSelector, "ucrModelSelector")
        Me.ucrModelSelector.Name = "ucrModelSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'rdoDisplayInOutput
        '
        resources.ApplyResources(Me.rdoDisplayInOutput, "rdoDisplayInOutput")
        Me.rdoDisplayInOutput.Name = "rdoDisplayInOutput"
        Me.rdoDisplayInOutput.TabStop = True
        Me.rdoDisplayInOutput.UseVisualStyleBackColor = True
        '
        'rdoNewDataFrame
        '
        resources.ApplyResources(Me.rdoNewDataFrame, "rdoNewDataFrame")
        Me.rdoNewDataFrame.Name = "rdoNewDataFrame"
        Me.rdoNewDataFrame.TabStop = True
        Me.rdoNewDataFrame.UseVisualStyleBackColor = True
        '
        'dlgTidy
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoNewDataFrame)
        Me.Controls.Add(Me.rdoDisplayInOutput)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrModelReceiver)
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
    Friend WithEvents ucrModelReceiver As ucrReceiverMultiple
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents rdoNewDataFrame As RadioButton
    Friend WithEvents rdoDisplayInOutput As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
