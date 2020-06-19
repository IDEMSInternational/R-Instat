<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMergeAdditionalData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMergeAdditionalData))
        Me.lblVariablesToIncludeSecond = New System.Windows.Forms.Label()
        Me.cmdModify = New System.Windows.Forms.Button()
        Me.ucrInputMergingBy = New instat.ucrInputTextBox()
        Me.ucrFirstDataFrame = New instat.ucrDataFrame()
        Me.ucrReceiverSecond = New instat.ucrReceiverMultiple()
        Me.ucrSecondSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblMergeBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVariablesToIncludeSecond
        '
        resources.ApplyResources(Me.lblVariablesToIncludeSecond, "lblVariablesToIncludeSecond")
        Me.lblVariablesToIncludeSecond.Name = "lblVariablesToIncludeSecond"
        '
        'cmdModify
        '
        resources.ApplyResources(Me.cmdModify, "cmdModify")
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.UseVisualStyleBackColor = True
        '
        'ucrInputMergingBy
        '
        Me.ucrInputMergingBy.AddQuotesIfUnrecognised = True
        Me.ucrInputMergingBy.IsMultiline = False
        Me.ucrInputMergingBy.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMergingBy, "ucrInputMergingBy")
        Me.ucrInputMergingBy.Name = "ucrInputMergingBy"
        '
        'ucrFirstDataFrame
        '
        Me.ucrFirstDataFrame.bDropUnusedFilterLevels = False
        Me.ucrFirstDataFrame.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrFirstDataFrame, "ucrFirstDataFrame")
        Me.ucrFirstDataFrame.Name = "ucrFirstDataFrame"
        '
        'ucrReceiverSecond
        '
        Me.ucrReceiverSecond.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSecond, "ucrReceiverSecond")
        Me.ucrReceiverSecond.Name = "ucrReceiverSecond"
        Me.ucrReceiverSecond.Selector = Nothing
        Me.ucrReceiverSecond.strNcFilePath = ""
        Me.ucrReceiverSecond.ucrSelector = Nothing
        '
        'ucrSecondSelector
        '
        Me.ucrSecondSelector.bDropUnusedFilterLevels = False
        Me.ucrSecondSelector.bShowHiddenColumns = False
        Me.ucrSecondSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSecondSelector, "ucrSecondSelector")
        Me.ucrSecondSelector.Name = "ucrSecondSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblMergeBy
        '
        resources.ApplyResources(Me.lblMergeBy, "lblMergeBy")
        Me.lblMergeBy.Name = "lblMergeBy"
        '
        'dlgMergeAdditionalData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblMergeBy)
        Me.Controls.Add(Me.cmdModify)
        Me.Controls.Add(Me.ucrInputMergingBy)
        Me.Controls.Add(Me.ucrFirstDataFrame)
        Me.Controls.Add(Me.lblVariablesToIncludeSecond)
        Me.Controls.Add(Me.ucrReceiverSecond)
        Me.Controls.Add(Me.ucrSecondSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMergeAdditionalData"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblVariablesToIncludeSecond As Label
    Friend WithEvents ucrReceiverSecond As ucrReceiverMultiple
    Friend WithEvents ucrSecondSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFirstDataFrame As ucrDataFrame
    Friend WithEvents ucrInputMergingBy As ucrInputTextBox
    Friend WithEvents cmdModify As Button
    Friend WithEvents lblMergeBy As Label
End Class
