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
        Me.ucrSelectorDescribeOneVar = New instat.ucrSelectorAddRemove()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrBaseDescribeOneVar = New instat.ucrButtons()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrame = New System.Windows.Forms.Label()
        Me.UcrInputTextBox1 = New instat.ucrInputTextBox()
        Me.ucrReceiverDescribeOneVar = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'cmdStatistics
        '
        Me.cmdStatistics.Location = New System.Drawing.Point(325, 179)
        Me.cmdStatistics.Name = "cmdStatistics"
        Me.cmdStatistics.Size = New System.Drawing.Size(71, 23)
        Me.cmdStatistics.TabIndex = 90
        Me.cmdStatistics.Tag = "Statistics"
        Me.cmdStatistics.Text = "Statistics "
        Me.cmdStatistics.UseVisualStyleBackColor = True
        '
        'ucrSelectorDescribeOneVar
        '
        Me.ucrSelectorDescribeOneVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeOneVar.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDescribeOneVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeOneVar.Name = "ucrSelectorDescribeOneVar"
        Me.ucrSelectorDescribeOneVar.Size = New System.Drawing.Size(213, 147)
        Me.ucrSelectorDescribeOneVar.TabIndex = 92
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(272, 10)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectedVariable.TabIndex = 94
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable"
        '
        'ucrBaseDescribeOneVar
        '
        Me.ucrBaseDescribeOneVar.Location = New System.Drawing.Point(10, 228)
        Me.ucrBaseDescribeOneVar.Name = "ucrBaseDescribeOneVar"
        Me.ucrBaseDescribeOneVar.Size = New System.Drawing.Size(399, 53)
        Me.ucrBaseDescribeOneVar.TabIndex = 95
        '
        'chkSaveResult
        '
        Me.chkSaveResult.AutoSize = True
        Me.chkSaveResult.Location = New System.Drawing.Point(10, 169)
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
        Me.lblNewDataFrame.Size = New System.Drawing.Size(108, 13)
        Me.lblNewDataFrame.TabIndex = 97
        Me.lblNewDataFrame.Tag = "Into_New_Data_Frame"
        Me.lblNewDataFrame.Text = "Into New Data Frame"
        '
        'UcrInputTextBox1
        '
        Me.UcrInputTextBox1.IsReadOnly = False
        Me.UcrInputTextBox1.Location = New System.Drawing.Point(143, 184)
        Me.UcrInputTextBox1.Name = "UcrInputTextBox1"
        Me.UcrInputTextBox1.Size = New System.Drawing.Size(95, 21)
        Me.UcrInputTextBox1.TabIndex = 98
        '
        'ucrReceiverDescribeOneVar
        '
        Me.ucrReceiverDescribeOneVar.Location = New System.Drawing.Point(260, 23)
        Me.ucrReceiverDescribeOneVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDescribeOneVar.Name = "ucrReceiverDescribeOneVar"
        Me.ucrReceiverDescribeOneVar.Selector = Nothing
        Me.ucrReceiverDescribeOneVar.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverDescribeOneVar.TabIndex = 99
        '
        'dlgDescriptiveStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 297)
        Me.Controls.Add(Me.ucrReceiverDescribeOneVar)
        Me.Controls.Add(Me.UcrInputTextBox1)
        Me.Controls.Add(Me.lblNewDataFrame)
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.ucrBaseDescribeOneVar)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrSelectorDescribeOneVar)
        Me.Controls.Add(Me.cmdStatistics)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescriptiveStatistics"
        Me.ShowIcon = False
        Me.Tag = "Describe_One_Variable"
        Me.Text = "Describe One Variable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdStatistics As Button
    Friend WithEvents ucrSelectorDescribeOneVar As ucrSelectorAddRemove
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrBaseDescribeOneVar As ucrButtons
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents lblNewDataFrame As Label
    Friend WithEvents UcrInputTextBox1 As ucrInputTextBox
    Friend WithEvents ucrReceiverDescribeOneVar As ucrReceiverMultiple
End Class

