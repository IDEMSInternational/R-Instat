<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescribeOneVariable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDescribeOneVariable))
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrBaseDescribeOneVar = New instat.ucrButtons()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrame = New System.Windows.Forms.Label()
        Me.ucrReceiverDescribeOneVar = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDescribeOneVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.chkCustomise = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdSummaries
        '
        resources.ApplyResources(Me.cmdSummaries, "cmdSummaries")
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        '
        'ucrBaseDescribeOneVar
        '
        resources.ApplyResources(Me.ucrBaseDescribeOneVar, "ucrBaseDescribeOneVar")
        Me.ucrBaseDescribeOneVar.Name = "ucrBaseDescribeOneVar"
        '
        'chkSaveResult
        '
        resources.ApplyResources(Me.chkSaveResult, "chkSaveResult")
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'lblNewDataFrame
        '
        resources.ApplyResources(Me.lblNewDataFrame, "lblNewDataFrame")
        Me.lblNewDataFrame.Name = "lblNewDataFrame"
        Me.lblNewDataFrame.Tag = "Into_New_Data_Frame"
        '
        'ucrReceiverDescribeOneVar
        '
        resources.ApplyResources(Me.ucrReceiverDescribeOneVar, "ucrReceiverDescribeOneVar")
        Me.ucrReceiverDescribeOneVar.Name = "ucrReceiverDescribeOneVar"
        Me.ucrReceiverDescribeOneVar.Selector = Nothing
        '
        'ucrSelectorDescribeOneVar
        '
        Me.ucrSelectorDescribeOneVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeOneVar.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorDescribeOneVar, "ucrSelectorDescribeOneVar")
        Me.ucrSelectorDescribeOneVar.Name = "ucrSelectorDescribeOneVar"
        '
        'chkCustomise
        '
        resources.ApplyResources(Me.chkCustomise, "chkCustomise")
        Me.chkCustomise.Name = "chkCustomise"
        Me.chkCustomise.Tag = "Customise"
        Me.chkCustomise.UseVisualStyleBackColor = True
        '
        'dlgDescribeOneVariable
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.chkCustomise)
        Me.Controls.Add(Me.ucrSelectorDescribeOneVar)
        Me.Controls.Add(Me.ucrReceiverDescribeOneVar)
        Me.Controls.Add(Me.lblNewDataFrame)
        Me.Controls.Add(Me.ucrBaseDescribeOneVar)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeOneVariable"
        Me.ShowIcon = False
        Me.Tag = "Describe_One_Variable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrBaseDescribeOneVar As ucrButtons
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents lblNewDataFrame As Label
    Friend WithEvents ucrReceiverDescribeOneVar As ucrReceiverMultiple
    Friend WithEvents ucrSelectorDescribeOneVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkCustomise As CheckBox
End Class