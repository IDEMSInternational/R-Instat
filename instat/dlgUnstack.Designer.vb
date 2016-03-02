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
        Me.chkKeepUnusedFactorLevels = New System.Windows.Forms.CheckBox()
        Me.ucrColumnToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorForUnstack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameForUnstack = New instat.ucrVariableName()
        Me.lblDataFrameForUnstack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFactorToUnstackBy
        '
        Me.lblFactorToUnstackBy.AutoSize = True
        Me.lblFactorToUnstackBy.Location = New System.Drawing.Point(258, 16)
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
        'chkKeepUnusedFactorLevels
        '
        Me.chkKeepUnusedFactorLevels.AutoSize = True
        Me.chkKeepUnusedFactorLevels.Location = New System.Drawing.Point(250, 174)
        Me.chkKeepUnusedFactorLevels.Name = "chkKeepUnusedFactorLevels"
        Me.chkKeepUnusedFactorLevels.Size = New System.Drawing.Size(158, 17)
        Me.chkKeepUnusedFactorLevels.TabIndex = 7
        Me.chkKeepUnusedFactorLevels.Tag = "Keep_Unused_Factor_Levels"
        Me.chkKeepUnusedFactorLevels.Text = "Keep Unused Factor Levels"
        Me.chkKeepUnusedFactorLevels.UseVisualStyleBackColor = True
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
        'ucrSelectorForUnstack
        '
        Me.ucrSelectorForUnstack.Location = New System.Drawing.Point(1, 12)
        Me.ucrSelectorForUnstack.Name = "ucrSelectorForUnstack"
        Me.ucrSelectorForUnstack.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForUnstack.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(-2, 225)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 8
        '
        'ucrDataFrameForUnstack
        '
        Me.ucrDataFrameForUnstack.Location = New System.Drawing.Point(137, 196)
        Me.ucrDataFrameForUnstack.Name = "ucrDataFrameForUnstack"
        Me.ucrDataFrameForUnstack.Size = New System.Drawing.Size(149, 23)
        Me.ucrDataFrameForUnstack.TabIndex = 9
        '
        'lblDataFrameForUnstack
        '
        Me.lblDataFrameForUnstack.AutoSize = True
        Me.lblDataFrameForUnstack.Location = New System.Drawing.Point(13, 206)
        Me.lblDataFrameForUnstack.Name = "lblDataFrameForUnstack"
        Me.lblDataFrameForUnstack.Size = New System.Drawing.Size(118, 13)
        Me.lblDataFrameForUnstack.TabIndex = 10
        Me.lblDataFrameForUnstack.Tag = "New_Data_Frame_Name"
        Me.lblDataFrameForUnstack.Text = "New Data Frame Name"
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 283)
        Me.Controls.Add(Me.lblDataFrameForUnstack)
        Me.Controls.Add(Me.ucrDataFrameForUnstack)
        Me.Controls.Add(Me.ucrColumnToUnstackReceiver)
        Me.Controls.Add(Me.ucrFactorToUnstackReceiver)
        Me.Controls.Add(Me.chkKeepUnusedFactorLevels)
        Me.Controls.Add(Me.lblColumnToUnstack)
        Me.Controls.Add(Me.lblFactorToUnstackBy)
        Me.Controls.Add(Me.ucrSelectorForUnstack)
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
    Friend WithEvents ucrSelectorForUnstack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorToUnstackBy As Label
    Friend WithEvents lblColumnToUnstack As Label
    Friend WithEvents chkKeepUnusedFactorLevels As CheckBox
    Friend WithEvents ucrFactorToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrColumnToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrDataFrameForUnstack As ucrVariableName
    Friend WithEvents lblDataFrameForUnstack As Label
End Class
