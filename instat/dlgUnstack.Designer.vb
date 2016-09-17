<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgUnstack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgUnstack))
        Me.lblFactorToUnstackBy = New System.Windows.Forms.Label()
        Me.lblColumnToUnstack = New System.Windows.Forms.Label()
        Me.chkDropMissingCombinations = New System.Windows.Forms.CheckBox()
        Me.lblDataFrameForUnstack = New System.Windows.Forms.Label()
        Me.lblIDColumns = New System.Windows.Forms.Label()
        Me.ucrNewDataName = New instat.ucrInputTextBox()
        Me.ucrIDColumns = New instat.ucrReceiverMultiple()
        Me.ucrColumnToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorForunstack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactorToUnstackBy
        '
        resources.ApplyResources(Me.lblFactorToUnstackBy, "lblFactorToUnstackBy")
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Tag = "Factor_to_Unstack_By"
        '
        'lblColumnToUnstack
        '
        resources.ApplyResources(Me.lblColumnToUnstack, "lblColumnToUnstack")
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack"
        '
        'chkDropMissingCombinations
        '
        resources.ApplyResources(Me.chkDropMissingCombinations, "chkDropMissingCombinations")
        Me.chkDropMissingCombinations.Name = "chkDropMissingCombinations"
        Me.chkDropMissingCombinations.Tag = "Drop_Missing_Combinations"
        Me.chkDropMissingCombinations.UseVisualStyleBackColor = True
        '
        'lblDataFrameForUnstack
        '
        resources.ApplyResources(Me.lblDataFrameForUnstack, "lblDataFrameForUnstack")
        Me.lblDataFrameForUnstack.Name = "lblDataFrameForUnstack"
        Me.lblDataFrameForUnstack.Tag = "New_Data_Frame_Name"
        '
        'lblIDColumns
        '
        resources.ApplyResources(Me.lblIDColumns, "lblIDColumns")
        Me.lblIDColumns.Name = "lblIDColumns"
        Me.lblIDColumns.Tag = "ID_Columns"
        '
        'ucrNewDataName
        '
        Me.ucrNewDataName.IsReadOnly = False
        resources.ApplyResources(Me.ucrNewDataName, "ucrNewDataName")
        Me.ucrNewDataName.Name = "ucrNewDataName"
        '
        'ucrIDColumns
        '
        resources.ApplyResources(Me.ucrIDColumns, "ucrIDColumns")
        Me.ucrIDColumns.Name = "ucrIDColumns"
        Me.ucrIDColumns.Selector = Nothing
        '
        'ucrColumnToUnstackReceiver
        '
        resources.ApplyResources(Me.ucrColumnToUnstackReceiver, "ucrColumnToUnstackReceiver")
        Me.ucrColumnToUnstackReceiver.Name = "ucrColumnToUnstackReceiver"
        Me.ucrColumnToUnstackReceiver.Selector = Nothing
        '
        'ucrFactorToUnstackReceiver
        '
        resources.ApplyResources(Me.ucrFactorToUnstackReceiver, "ucrFactorToUnstackReceiver")
        Me.ucrFactorToUnstackReceiver.Name = "ucrFactorToUnstackReceiver"
        Me.ucrFactorToUnstackReceiver.Selector = Nothing
        '
        'ucrSelectorForunstack
        '
        Me.ucrSelectorForunstack.bShowHiddenColumns = False
        Me.ucrSelectorForunstack.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorForunstack, "ucrSelectorForunstack")
        Me.ucrSelectorForunstack.Name = "ucrSelectorForunstack"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgUnstack
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNewDataName)
        Me.Controls.Add(Me.lblIDColumns)
        Me.Controls.Add(Me.ucrIDColumns)
        Me.Controls.Add(Me.lblDataFrameForUnstack)
        Me.Controls.Add(Me.ucrColumnToUnstackReceiver)
        Me.Controls.Add(Me.ucrFactorToUnstackReceiver)
        Me.Controls.Add(Me.chkDropMissingCombinations)
        Me.Controls.Add(Me.lblColumnToUnstack)
        Me.Controls.Add(Me.lblFactorToUnstackBy)
        Me.Controls.Add(Me.ucrSelectorForunstack)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUnstack"
        Me.Tag = "Unstack_Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForunstack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorToUnstackBy As Label
    Friend WithEvents lblColumnToUnstack As Label
    Friend WithEvents chkDropMissingCombinations As CheckBox
    Friend WithEvents ucrFactorToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrColumnToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents lblDataFrameForUnstack As Label
    Friend WithEvents ucrIDColumns As ucrReceiverMultiple
    Friend WithEvents lblIDColumns As Label
    Friend WithEvents ucrNewDataName As ucrInputTextBox
End Class
