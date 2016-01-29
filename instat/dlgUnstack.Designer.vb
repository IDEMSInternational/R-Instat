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
        Me.lblFactorstoUnstackBy = New System.Windows.Forms.Label()
        Me.lblColumnstoUnstack = New System.Windows.Forms.Label()
        Me.chkUseFactoLabels = New System.Windows.Forms.CheckBox()
        Me.ucrfactortoUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrColumntoUnstackReceiver = New instat.ucrReceiverSingle()
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
        'lblFactorstoUnstackBy
        '
        Me.lblFactorstoUnstackBy.AutoSize = True
        Me.lblFactorstoUnstackBy.Location = New System.Drawing.Point(258, 16)
        Me.lblFactorstoUnstackBy.Name = "lblFactorstoUnstackBy"
        Me.lblFactorstoUnstackBy.Size = New System.Drawing.Size(118, 13)
        Me.lblFactorstoUnstackBy.TabIndex = 9
        Me.lblFactorstoUnstackBy.Tag = "Factors_to_Unstack_By"
        Me.lblFactorstoUnstackBy.Text = "Factor(s) to Unstack By"
        '
        'lblColumnstoUnstack
        '
        Me.lblColumnstoUnstack.AutoSize = True
        Me.lblColumnstoUnstack.Location = New System.Drawing.Point(255, 69)
        Me.lblColumnstoUnstack.Name = "lblColumnstoUnstack"
        Me.lblColumnstoUnstack.Size = New System.Drawing.Size(97, 13)
        Me.lblColumnstoUnstack.TabIndex = 9
        Me.lblColumnstoUnstack.Tag = "Column_to_Unstack"
        Me.lblColumnstoUnstack.Text = "Column to Unstack"
        '
        'chkUseFactoLabels
        '
        Me.chkUseFactoLabels.AutoSize = True
        Me.chkUseFactoLabels.Location = New System.Drawing.Point(13, 225)
        Me.chkUseFactoLabels.Name = "chkUseFactoLabels"
        Me.chkUseFactoLabels.Size = New System.Drawing.Size(193, 17)
        Me.chkUseFactoLabels.TabIndex = 10
        Me.chkUseFactoLabels.Tag = "Use_Factor_labels_in_Column_Names"
        Me.chkUseFactoLabels.Text = "Use Factor labels in Column Names"
        Me.chkUseFactoLabels.UseVisualStyleBackColor = True
        '
        'ucrfactortoUnstackReceiver
        '
        Me.ucrfactortoUnstackReceiver.Location = New System.Drawing.Point(256, 40)
        Me.ucrfactortoUnstackReceiver.Name = "ucrfactortoUnstackReceiver"
        Me.ucrfactortoUnstackReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrfactortoUnstackReceiver.TabIndex = 12
        '
        'ucrColumntoUnstackReceiver
        '
        Me.ucrColumntoUnstackReceiver.Location = New System.Drawing.Point(258, 95)
        Me.ucrColumntoUnstackReceiver.Name = "ucrColumntoUnstackReceiver"
        Me.ucrColumntoUnstackReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrColumntoUnstackReceiver.TabIndex = 12
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
        Me.Controls.Add(Me.ucrColumntoUnstackReceiver)
        Me.Controls.Add(Me.ucrfactortoUnstackReceiver)
        Me.Controls.Add(Me.chkUseFactoLabels)
        Me.Controls.Add(Me.lblColumnstoUnstack)
        Me.Controls.Add(Me.lblFactorstoUnstackBy)
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
    Friend WithEvents lblFactorstoUnstackBy As Label
    Friend WithEvents lblColumnstoUnstack As Label
    Friend WithEvents chkUseFactoLabels As CheckBox
    Friend WithEvents ucrfactortoUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrColumntoUnstackReceiver As ucrReceiverSingle
    Friend WithEvents chkIDColumn As CheckBox
    Friend WithEvents ucrIDColumnReceiver As ucrReceiverMultiple
End Class
