<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescriptiveStatistics
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
        Me.cmdStatistics = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrBaseDescribeOneVar = New instat.ucrButtons()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrame = New System.Windows.Forms.Label()
        Me.ucrReceiverDescribeOneVar = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDescribeOneVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.chkDisplayResults = New System.Windows.Forms.CheckBox()
        Me.grpOutPut = New System.Windows.Forms.GroupBox()
        Me.grpOutPut.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdStatistics
        '
        Me.cmdStatistics.Location = New System.Drawing.Point(325, 185)
        Me.cmdStatistics.Name = "cmdStatistics"
        Me.cmdStatistics.Size = New System.Drawing.Size(71, 23)
        Me.cmdStatistics.TabIndex = 90
        Me.cmdStatistics.Tag = "Statistics"
        Me.cmdStatistics.Text = "Statistics "
        Me.cmdStatistics.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(286, 5)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectedVariable.TabIndex = 94
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable"
        '
        'ucrBaseDescribeOneVar
        '
        Me.ucrBaseDescribeOneVar.Location = New System.Drawing.Point(10, 224)
        Me.ucrBaseDescribeOneVar.Name = "ucrBaseDescribeOneVar"
        Me.ucrBaseDescribeOneVar.Size = New System.Drawing.Size(399, 53)
        Me.ucrBaseDescribeOneVar.TabIndex = 95
        '
        'chkSaveResult
        '
        Me.chkSaveResult.AutoSize = True
        Me.chkSaveResult.Location = New System.Drawing.Point(9, 13)
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Size = New System.Drawing.Size(87, 17)
        Me.chkSaveResult.TabIndex = 96
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.Text = "Save Result "
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'lblNewDataFrame
        '
        Me.lblNewDataFrame.AutoSize = True
        Me.lblNewDataFrame.Location = New System.Drawing.Point(28, 189)
        Me.lblNewDataFrame.Name = "lblNewDataFrame"
        Me.lblNewDataFrame.Size = New System.Drawing.Size(0, 13)
        Me.lblNewDataFrame.TabIndex = 97
        Me.lblNewDataFrame.Tag = "Into_New_Data_Frame"
        '
        'ucrReceiverDescribeOneVar
        '
        Me.ucrReceiverDescribeOneVar.Location = New System.Drawing.Point(271, 23)
        Me.ucrReceiverDescribeOneVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDescribeOneVar.Name = "ucrReceiverDescribeOneVar"
        Me.ucrReceiverDescribeOneVar.Selector = Nothing
        Me.ucrReceiverDescribeOneVar.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverDescribeOneVar.TabIndex = 99
        '
        'ucrSelectorDescribeOneVar
        '
        Me.ucrSelectorDescribeOneVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeOneVar.Location = New System.Drawing.Point(9, 0)
        Me.ucrSelectorDescribeOneVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeOneVar.Name = "ucrSelectorDescribeOneVar"
        Me.ucrSelectorDescribeOneVar.Size = New System.Drawing.Size(210, 189)
        Me.ucrSelectorDescribeOneVar.TabIndex = 100
        '
        'chkDisplayResults
        '
        Me.chkDisplayResults.AutoSize = True
        Me.chkDisplayResults.Location = New System.Drawing.Point(101, 12)
        Me.chkDisplayResults.Name = "chkDisplayResults"
        Me.chkDisplayResults.Size = New System.Drawing.Size(96, 17)
        Me.chkDisplayResults.TabIndex = 101
        Me.chkDisplayResults.Tag = "Display_Result"
        Me.chkDisplayResults.Text = "Display Result "
        Me.chkDisplayResults.UseVisualStyleBackColor = True
        '
        'grpOutPut
        '
        Me.grpOutPut.Controls.Add(Me.chkSaveResult)
        Me.grpOutPut.Controls.Add(Me.chkDisplayResults)
        Me.grpOutPut.Location = New System.Drawing.Point(10, 185)
        Me.grpOutPut.Name = "grpOutPut"
        Me.grpOutPut.Size = New System.Drawing.Size(209, 37)
        Me.grpOutPut.TabIndex = 102
        Me.grpOutPut.TabStop = False
        '
        'dlgDescriptiveStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 284)
        Me.Controls.Add(Me.grpOutPut)
        Me.Controls.Add(Me.ucrSelectorDescribeOneVar)
        Me.Controls.Add(Me.ucrReceiverDescribeOneVar)
        Me.Controls.Add(Me.lblNewDataFrame)
        Me.Controls.Add(Me.ucrBaseDescribeOneVar)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdStatistics)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescriptiveStatistics"
        Me.ShowIcon = False
        Me.Tag = "Describe_One_Variable"
        Me.Text = "Describe One Variable"
        Me.grpOutPut.ResumeLayout(False)
        Me.grpOutPut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdStatistics As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrBaseDescribeOneVar As ucrButtons
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents lblNewDataFrame As Label
    Friend WithEvents ucrReceiverDescribeOneVar As ucrReceiverMultiple
    Friend WithEvents ucrSelectorDescribeOneVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkDisplayResults As CheckBox
    Friend WithEvents grpOutPut As GroupBox
End Class

