<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescribeTwoVariable
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
        Me.lblFirstVariable = New System.Windows.Forms.Label()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblFirstVariables = New System.Windows.Forms.Label()
        Me.lbSecondVariable = New System.Windows.Forms.Label()
        Me.chkOmitMissing = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverSecondVar = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstVar = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseDescribeTwoVar = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFirstVariable
        '
        Me.lblFirstVariable.Location = New System.Drawing.Point(342, 0)
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Size = New System.Drawing.Size(100, 23)
        Me.lblFirstVariable.TabIndex = 0
        Me.lblFirstVariable.Tag = "First_Variable"
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(300, 198)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(105, 23)
        Me.cmdSummaries.TabIndex = 6
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'chkSaveResult
        '
        Me.chkSaveResult.Location = New System.Drawing.Point(10, 198)
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveResult.TabIndex = 6
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.Text = "Save Result"
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(300, 198)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdDisplayOptions.TabIndex = 0
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.Location = New System.Drawing.Point(275, 41)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(81, 13)
        Me.lblFirstVariables.TabIndex = 1
        Me.lblFirstVariables.Tag = "First_Variable(s):"
        Me.lblFirstVariables.Text = "First Variable(s):"
        '
        'lbSecondVariable
        '
        Me.lbSecondVariable.Location = New System.Drawing.Point(274, 152)
        Me.lbSecondVariable.Name = "lbSecondVariable"
        Me.lbSecondVariable.Size = New System.Drawing.Size(100, 15)
        Me.lbSecondVariable.TabIndex = 10
        Me.lbSecondVariable.Tag = "Second_Variable:"
        Me.lbSecondVariable.Text = "Second Variable:"
        '
        'chkOmitMissing
        '
        Me.chkOmitMissing.Location = New System.Drawing.Point(142, 198)
        Me.chkOmitMissing.Name = "chkOmitMissing"
        Me.chkOmitMissing.Size = New System.Drawing.Size(126, 25)
        Me.chkOmitMissing.TabIndex = 12
        Me.chkOmitMissing.Text = "Omit Missing Values"
        Me.chkOmitMissing.UseVisualStyleBackColor = True
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.Location = New System.Drawing.Point(274, 168)
        Me.ucrReceiverSecondVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondVar.Name = "ucrReceiverSecondVar"
        Me.ucrReceiverSecondVar.Selector = Nothing
        Me.ucrReceiverSecondVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondVar.TabIndex = 2
        '
        'ucrReceiverFirstVar
        '
        Me.ucrReceiverFirstVar.Location = New System.Drawing.Point(274, 56)
        Me.ucrReceiverFirstVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVar.Name = "ucrReceiverFirstVar"
        Me.ucrReceiverFirstVar.Selector = Nothing
        Me.ucrReceiverFirstVar.Size = New System.Drawing.Size(120, 87)
        Me.ucrReceiverFirstVar.TabIndex = 2
        '
        'ucrSelectorDescribeTwoVar
        '
        Me.ucrSelectorDescribeTwoVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeTwoVar.bUseCurrentFilter = True
        Me.ucrSelectorDescribeTwoVar.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDescribeTwoVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        Me.ucrSelectorDescribeTwoVar.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDescribeTwoVar.TabIndex = 5
        '
        'ucrBaseDescribeTwoVar
        '
        Me.ucrBaseDescribeTwoVar.Location = New System.Drawing.Point(10, 228)
        Me.ucrBaseDescribeTwoVar.Name = "ucrBaseDescribeTwoVar"
        Me.ucrBaseDescribeTwoVar.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseDescribeTwoVar.TabIndex = 8
        '
        'dlgDescribeTwoVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 292)
        Me.Controls.Add(Me.chkOmitMissing)
        Me.Controls.Add(Me.lbSecondVariable)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.ucrReceiverSecondVar)
        Me.Controls.Add(Me.ucrReceiverFirstVar)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.ucrBaseDescribeTwoVar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Describe_Two_Variable"
        Me.Text = "Describe Two Variables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseDescribeTwoVar As ucrButtons
    Friend WithEvents ucrSelectorDescribeTwoVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirstVar As ucrReceiverMultiple
    Friend WithEvents lblFirstVariable As Label
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents ucrReceiverSecondVar As ucrReceiverSingle
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents lblFirstVariables As Label
    Friend WithEvents lbSecondVariable As Label
    Friend WithEvents chkOmitMissing As CheckBox
End Class
