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
        Me.lblFactorToUnstackBy.AutoSize = True
        Me.lblFactorToUnstackBy.Location = New System.Drawing.Point(255, 19)
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Size = New System.Drawing.Size(107, 13)
        Me.lblFactorToUnstackBy.TabIndex = 1
        Me.lblFactorToUnstackBy.Tag = "Factor_to_Unstack_By"
        Me.lblFactorToUnstackBy.Text = "Factor to Unstack By"
        '
        'lblColumnToUnstack
        '
        Me.lblColumnToUnstack.AutoSize = True
        Me.lblColumnToUnstack.Location = New System.Drawing.Point(255, 69)
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Size = New System.Drawing.Size(97, 13)
        Me.lblColumnToUnstack.TabIndex = 3
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack"
        Me.lblColumnToUnstack.Text = "Column to Unstack"
        '
        'chkDropMissingCombinations
        '
        Me.chkDropMissingCombinations.AutoSize = True
        Me.chkDropMissingCombinations.Location = New System.Drawing.Point(4, 219)
        Me.chkDropMissingCombinations.Name = "chkDropMissingCombinations"
        Me.chkDropMissingCombinations.Size = New System.Drawing.Size(153, 17)
        Me.chkDropMissingCombinations.TabIndex = 7
        Me.chkDropMissingCombinations.Tag = "Drop_Missing_Combinations"
        Me.chkDropMissingCombinations.Text = "Drop Missing Combinations"
        Me.chkDropMissingCombinations.UseVisualStyleBackColor = True
        '
        'lblDataFrameForUnstack
        '
        Me.lblDataFrameForUnstack.AutoSize = True
        Me.lblDataFrameForUnstack.Location = New System.Drawing.Point(1, 257)
        Me.lblDataFrameForUnstack.Name = "lblDataFrameForUnstack"
        Me.lblDataFrameForUnstack.Size = New System.Drawing.Size(118, 13)
        Me.lblDataFrameForUnstack.TabIndex = 10
        Me.lblDataFrameForUnstack.Tag = "New_Data_Frame_Name"
        Me.lblDataFrameForUnstack.Text = "New Data Frame Name"
        '
        'lblIDColumns
        '
        Me.lblIDColumns.AutoSize = True
        Me.lblIDColumns.Location = New System.Drawing.Point(255, 126)
        Me.lblIDColumns.Name = "lblIDColumns"
        Me.lblIDColumns.Size = New System.Drawing.Size(61, 13)
        Me.lblIDColumns.TabIndex = 13
        Me.lblIDColumns.Tag = "ID_Columns"
        Me.lblIDColumns.Text = "ID Columns"
        '
        'ucrNewDataName
        '
        Me.ucrNewDataName.Location = New System.Drawing.Point(131, 254)
        Me.ucrNewDataName.Name = "ucrNewDataName"
        Me.ucrNewDataName.Size = New System.Drawing.Size(142, 21)
        Me.ucrNewDataName.TabIndex = 14
        '
        'ucrIDColumns
        '
        Me.ucrIDColumns.Location = New System.Drawing.Point(256, 142)
        Me.ucrIDColumns.Name = "ucrIDColumns"
        Me.ucrIDColumns.Selector = Nothing
        Me.ucrIDColumns.Size = New System.Drawing.Size(121, 104)
        Me.ucrIDColumns.TabIndex = 12
        '
        'ucrColumnToUnstackReceiver
        '
        Me.ucrColumnToUnstackReceiver.Location = New System.Drawing.Point(256, 87)
        Me.ucrColumnToUnstackReceiver.Name = "ucrColumnToUnstackReceiver"
        Me.ucrColumnToUnstackReceiver.Selector = Nothing
        Me.ucrColumnToUnstackReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrColumnToUnstackReceiver.TabIndex = 4
        '
        'ucrFactorToUnstackReceiver
        '
        Me.ucrFactorToUnstackReceiver.Location = New System.Drawing.Point(256, 40)
        Me.ucrFactorToUnstackReceiver.Name = "ucrFactorToUnstackReceiver"
        Me.ucrFactorToUnstackReceiver.Selector = Nothing
        Me.ucrFactorToUnstackReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorToUnstackReceiver.TabIndex = 2
        '
        'ucrSelectorForunstack
        '
        Me.ucrSelectorForunstack.Location = New System.Drawing.Point(1, 12)
        Me.ucrSelectorForunstack.Name = "ucrSelectorForunstack"
        Me.ucrSelectorForunstack.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForunstack.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(1, 281)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 8
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 346)
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
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack_Columns"
        Me.Text = "Unstack Columns"
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
