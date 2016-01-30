<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUnstack
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrame = New instat.ucrDataFrame()
        Me.ucrSelectorByDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblFactorToUnstackBy = New System.Windows.Forms.Label()
        Me.lblColumnToUnstack = New System.Windows.Forms.Label()
        Me.chkUseFactoLabels = New System.Windows.Forms.CheckBox()
        Me.ucrFactorToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrColumnToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.chkIDColumn = New System.Windows.Forms.CheckBox()
        Me.ucrIDColumnReceiver = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 275)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 2
        '
        'ucrDataFrame
        '
        Me.ucrDataFrame.Location = New System.Drawing.Point(7, 11)
        Me.ucrDataFrame.Name = "ucrDataFrame"
        Me.ucrDataFrame.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrame.TabIndex = 6
        '
        'ucrSelectorByDataFrameAddRemove
        '
        Me.ucrSelectorByDataFrameAddRemove.Location = New System.Drawing.Point(7, 49)
        Me.ucrSelectorByDataFrameAddRemove.Name = "ucrSelectorByDataFrameAddRemove"
        Me.ucrSelectorByDataFrameAddRemove.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorByDataFrameAddRemove.TabIndex = 7
        '
        'lblFactorToUnstackBy
        '
        Me.lblFactorToUnstackBy.AutoSize = True
        Me.lblFactorToUnstackBy.Location = New System.Drawing.Point(258, 16)
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Size = New System.Drawing.Size(118, 13)
        Me.lblFactorToUnstackBy.TabIndex = 9
        Me.lblFactorToUnstackBy.Tag = "Factors_to_Unstack_By"
        Me.lblFactorToUnstackBy.Text = "Factor(s) to Unstack By"
        '
        'lblColumnToUnstack
        '
        Me.lblColumnToUnstack.AutoSize = True
        Me.lblColumnToUnstack.Location = New System.Drawing.Point(255, 69)
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Size = New System.Drawing.Size(97, 13)
        Me.lblColumnToUnstack.TabIndex = 9
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack"
        Me.lblColumnToUnstack.Text = "Column to Unstack"
        '
        'chkUseFactoLabels
        '
        Me.chkUseFactoLabels.AutoSize = True
        Me.chkUseFactoLabels.Location = New System.Drawing.Point(13, 242)
        Me.chkUseFactoLabels.Name = "chkUseFactoLabels"
        Me.chkUseFactoLabels.Size = New System.Drawing.Size(193, 17)
        Me.chkUseFactoLabels.TabIndex = 10
        Me.chkUseFactoLabels.Tag = "Use_Factor_labels_in_Column_Names"
        Me.chkUseFactoLabels.Text = "Use Factor labels in Column Names"
        Me.chkUseFactoLabels.UseVisualStyleBackColor = True
        '
        'ucrFactorToUnstackReceiver
        '
        Me.ucrFactorToUnstackReceiver.Location = New System.Drawing.Point(256, 40)
        Me.ucrFactorToUnstackReceiver.Name = "ucrFactorToUnstackReceiver"
        Me.ucrFactorToUnstackReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorToUnstackReceiver.TabIndex = 12
        '
        'ucrColumnToUnstackReceiver
        '
        Me.ucrColumnToUnstackReceiver.Location = New System.Drawing.Point(258, 95)
        Me.ucrColumnToUnstackReceiver.Name = "ucrColumnToUnstackReceiver"
        Me.ucrColumnToUnstackReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrColumnToUnstackReceiver.TabIndex = 12
        '
        'chkIDColumn
        '
        Me.chkIDColumn.AutoSize = True
        Me.chkIDColumn.Location = New System.Drawing.Point(257, 126)
        Me.chkIDColumn.Name = "chkIDColumn"
        Me.chkIDColumn.Size = New System.Drawing.Size(75, 17)
        Me.chkIDColumn.TabIndex = 13
        Me.chkIDColumn.Tag = "ID_Column"
        Me.chkIDColumn.Text = "ID Column"
        Me.chkIDColumn.UseVisualStyleBackColor = True
        '
        'ucrIDColumnReceiver
        '
        Me.ucrIDColumnReceiver.Location = New System.Drawing.Point(249, 145)
        Me.ucrIDColumnReceiver.Name = "ucrIDColumnReceiver"
        Me.ucrIDColumnReceiver.Size = New System.Drawing.Size(121, 128)
        Me.ucrIDColumnReceiver.TabIndex = 14
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 331)
        Me.Controls.Add(Me.ucrIDColumnReceiver)
        Me.Controls.Add(Me.chkIDColumn)
        Me.Controls.Add(Me.ucrColumnToUnstackReceiver)
        Me.Controls.Add(Me.ucrFactorToUnstackReceiver)
        Me.Controls.Add(Me.chkUseFactoLabels)
        Me.Controls.Add(Me.lblColumnToUnstack)
        Me.Controls.Add(Me.lblFactorToUnstackBy)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemove)
        Me.Controls.Add(Me.ucrDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack_split_columns"
        Me.Text = "Unstack(Split) columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrame As ucrDataFrame
    Friend WithEvents ucrSelectorByDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorToUnstackBy As Label
    Friend WithEvents lblColumnToUnstack As Label
    Friend WithEvents chkUseFactoLabels As CheckBox
    Friend WithEvents ucrFactorToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrColumnToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents chkIDColumn As CheckBox
    Friend WithEvents ucrIDColumnReceiver As ucrReceiverMultiple
End Class
