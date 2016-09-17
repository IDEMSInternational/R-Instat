<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCombine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCombine))
        Me.ucrSelectorCombineFactors = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorsReceiver = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.chkDropUnusedLevels = New System.Windows.Forms.CheckBox()
        Me.ucrInputColName = New instat.ucrInputComboBox()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrSelectorCombineFactors
        '
        Me.ucrSelectorCombineFactors.bShowHiddenColumns = False
        Me.ucrSelectorCombineFactors.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorCombineFactors, "ucrSelectorCombineFactors")
        Me.ucrSelectorCombineFactors.Name = "ucrSelectorCombineFactors"
        '
        'ucrFactorsReceiver
        '
        resources.ApplyResources(Me.ucrFactorsReceiver, "ucrFactorsReceiver")
        Me.ucrFactorsReceiver.Name = "ucrFactorsReceiver"
        Me.ucrFactorsReceiver.Selector = Nothing
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Tag = "Factors"
        '
        'chkDropUnusedLevels
        '
        resources.ApplyResources(Me.chkDropUnusedLevels, "chkDropUnusedLevels")
        Me.chkDropUnusedLevels.Name = "chkDropUnusedLevels"
        Me.chkDropUnusedLevels.Tag = "Drop_Unused_Levels "
        Me.chkDropUnusedLevels.UseVisualStyleBackColor = True
        '
        'ucrInputColName
        '
        Me.ucrInputColName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColName, "ucrInputColName")
        Me.ucrInputColName.Name = "ucrInputColName"
        '
        'lblNewColumnName
        '
        resources.ApplyResources(Me.lblNewColumnName, "lblNewColumnName")
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Tag = "New_Column_Name"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgCombine
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputColName)
        Me.Controls.Add(Me.chkDropUnusedLevels)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrFactorsReceiver)
        Me.Controls.Add(Me.ucrSelectorCombineFactors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombine"
        Me.Tag = "Combine_Factors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorCombineFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorsReceiver As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents chkDropUnusedLevels As CheckBox
    Friend WithEvents ucrInputColName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
