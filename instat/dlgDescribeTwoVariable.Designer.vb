<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDescribeTwoVariable
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
        Me.ucrBaseDescribeTwoVar = New instat.ucrButtons()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFirstVar = New instat.ucrReceiverMultiple()
        Me.lblFirstVariable = New System.Windows.Forms.Label()
        Me.cmdStatistics = New System.Windows.Forms.Button()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.chkDisplayResults = New System.Windows.Forms.CheckBox()
        Me.grpOutPut = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverSecondVar = New instat.ucrReceiverMultiple()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.grpOutPut.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseDescribeTwoVar
        '
        Me.ucrBaseDescribeTwoVar.Location = New System.Drawing.Point(10, 280)
        Me.ucrBaseDescribeTwoVar.Name = "ucrBaseDescribeTwoVar"
        Me.ucrBaseDescribeTwoVar.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseDescribeTwoVar.TabIndex = 0
        '
        'ucrSelectorDescribeTwoVar
        '
        Me.ucrSelectorDescribeTwoVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeTwoVar.Location = New System.Drawing.Point(8, -4)
        Me.ucrSelectorDescribeTwoVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        Me.ucrSelectorDescribeTwoVar.Size = New System.Drawing.Size(210, 189)
        Me.ucrSelectorDescribeTwoVar.TabIndex = 101
        '
        'ucrReceiverFirstVar
        '
        Me.ucrReceiverFirstVar.Location = New System.Drawing.Point(277, 27)
        Me.ucrReceiverFirstVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVar.Name = "ucrReceiverFirstVar"
        Me.ucrReceiverFirstVar.Selector = Nothing
        Me.ucrReceiverFirstVar.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFirstVar.TabIndex = 105
        '
        'lblFirstVariable
        '
        Me.lblFirstVariable.AutoSize = True
        Me.lblFirstVariable.Location = New System.Drawing.Point(292, 10)
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Size = New System.Drawing.Size(67, 13)
        Me.lblFirstVariable.TabIndex = 104
        Me.lblFirstVariable.Tag = "First_Variable"
        Me.lblFirstVariable.Text = "First Variable"
        '
        'cmdStatistics
        '
        Me.cmdStatistics.Location = New System.Drawing.Point(331, 253)
        Me.cmdStatistics.Name = "cmdStatistics"
        Me.cmdStatistics.Size = New System.Drawing.Size(71, 23)
        Me.cmdStatistics.TabIndex = 103
        Me.cmdStatistics.Tag = "Statistics"
        Me.cmdStatistics.Text = "Statistics "
        Me.cmdStatistics.UseVisualStyleBackColor = True
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
        Me.grpOutPut.Location = New System.Drawing.Point(16, 199)
        Me.grpOutPut.Name = "grpOutPut"
        Me.grpOutPut.Size = New System.Drawing.Size(209, 37)
        Me.grpOutPut.TabIndex = 106
        Me.grpOutPut.TabStop = False
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.Location = New System.Drawing.Point(280, 149)
        Me.ucrReceiverSecondVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondVar.Name = "ucrReceiverSecondVar"
        Me.ucrReceiverSecondVar.Selector = Nothing
        Me.ucrReceiverSecondVar.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSecondVar.TabIndex = 108
        '
        'lblSecondVariable
        '
        Me.lblSecondVariable.AutoSize = True
        Me.lblSecondVariable.Location = New System.Drawing.Point(277, 132)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(85, 13)
        Me.lblSecondVariable.TabIndex = 107
        Me.lblSecondVariable.Tag = "Second_Variable"
        Me.lblSecondVariable.Text = "Second Variable"
        '
        'dlgDescribeTwoVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 337)
        Me.Controls.Add(Me.ucrReceiverSecondVar)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.ucrReceiverFirstVar)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.cmdStatistics)
        Me.Controls.Add(Me.grpOutPut)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.ucrBaseDescribeTwoVar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Describe_Two_Variable"
        Me.Text = "Describe Two Variable"
        Me.grpOutPut.ResumeLayout(False)
        Me.grpOutPut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseDescribeTwoVar As ucrButtons
    Friend WithEvents ucrSelectorDescribeTwoVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirstVar As ucrReceiverMultiple
    Friend WithEvents lblFirstVariable As Label
    Friend WithEvents cmdStatistics As Button
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents chkDisplayResults As CheckBox
    Friend WithEvents grpOutPut As GroupBox
    Friend WithEvents ucrReceiverSecondVar As ucrReceiverMultiple
    Friend WithEvents lblSecondVariable As Label
End Class
