<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescribeTwoVariable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDescribeTwoVariable))
        Me.lblFirstVariable = New System.Windows.Forms.Label()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrReceiverSecondVar = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstVar = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseDescribeTwoVar = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFirstVariable
        '
        resources.ApplyResources(Me.lblFirstVariable, "lblFirstVariable")
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Tag = "First_Variable"
        '
        'cmdSummaries
        '
        resources.ApplyResources(Me.cmdSummaries, "cmdSummaries")
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'chkSaveResult
        '
        resources.ApplyResources(Me.chkSaveResult, "chkSaveResult")
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'lblSecondVariable
        '
        resources.ApplyResources(Me.lblSecondVariable, "lblSecondVariable")
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Tag = "Second_Variable"
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrReceiverSecondVar
        '
        resources.ApplyResources(Me.ucrReceiverSecondVar, "ucrReceiverSecondVar")
        Me.ucrReceiverSecondVar.Name = "ucrReceiverSecondVar"
        Me.ucrReceiverSecondVar.Selector = Nothing
        '
        'ucrReceiverFirstVar
        '
        resources.ApplyResources(Me.ucrReceiverFirstVar, "ucrReceiverFirstVar")
        Me.ucrReceiverFirstVar.Name = "ucrReceiverFirstVar"
        Me.ucrReceiverFirstVar.Selector = Nothing
        '
        'ucrSelectorDescribeTwoVar
        '
        Me.ucrSelectorDescribeTwoVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeTwoVar.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorDescribeTwoVar, "ucrSelectorDescribeTwoVar")
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        '
        'ucrBaseDescribeTwoVar
        '
        resources.ApplyResources(Me.ucrBaseDescribeTwoVar, "ucrBaseDescribeTwoVar")
        Me.ucrBaseDescribeTwoVar.Name = "ucrBaseDescribeTwoVar"
        '
        'dlgDescribeTwoVariable
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.ucrReceiverSecondVar)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.ucrReceiverFirstVar)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.ucrBaseDescribeTwoVar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariable"
        Me.Tag = "Describe_Two_Variable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseDescribeTwoVar As ucrButtons
    Friend WithEvents ucrSelectorDescribeTwoVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirstVar As ucrReceiverMultiple
    Friend WithEvents lblFirstVariable As Label
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents lblSecondVariable As Label
    Friend WithEvents ucrReceiverSecondVar As ucrReceiverSingle
    Friend WithEvents cmdDisplayOptions As Button
End Class
