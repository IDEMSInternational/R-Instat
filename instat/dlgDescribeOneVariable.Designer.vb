﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescribeOneVariable
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
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrBaseDescribeOneVar = New instat.ucrButtons()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverDescribeOneVar = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDescribeOneVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.chkCustomise = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(306, 191)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(75, 23)
        Me.cmdSummaries.TabIndex = 7
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.Location = New System.Drawing.Point(281, 14)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(124, 23)
        Me.lblSelectedVariable.TabIndex = 6
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable(s)"
        '
        'ucrBaseDescribeOneVar
        '
        Me.ucrBaseDescribeOneVar.Location = New System.Drawing.Point(10, 222)
        Me.ucrBaseDescribeOneVar.Name = "ucrBaseDescribeOneVar"
        Me.ucrBaseDescribeOneVar.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseDescribeOneVar.TabIndex = 5
        '
        'chkSaveResult
        '
        Me.chkSaveResult.Location = New System.Drawing.Point(10, 191)
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveResult.TabIndex = 0
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.Text = "Save Result"
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'ucrReceiverDescribeOneVar
        '
        Me.ucrReceiverDescribeOneVar.Location = New System.Drawing.Point(283, 36)
        Me.ucrReceiverDescribeOneVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDescribeOneVar.Name = "ucrReceiverDescribeOneVar"
        Me.ucrReceiverDescribeOneVar.Selector = Nothing
        Me.ucrReceiverDescribeOneVar.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverDescribeOneVar.TabIndex = 3
        '
        'ucrSelectorDescribeOneVar
        '
        Me.ucrSelectorDescribeOneVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeOneVar.bUseCurrentFilter = False
        Me.ucrSelectorDescribeOneVar.Location = New System.Drawing.Point(10, 5)
        Me.ucrSelectorDescribeOneVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeOneVar.Name = "ucrSelectorDescribeOneVar"
        Me.ucrSelectorDescribeOneVar.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDescribeOneVar.TabIndex = 2
        '
        'chkCustomise
        '
        Me.chkCustomise.Location = New System.Drawing.Point(291, 161)
        Me.chkCustomise.Name = "chkCustomise"
        Me.chkCustomise.Size = New System.Drawing.Size(104, 24)
        Me.chkCustomise.TabIndex = 1
        Me.chkCustomise.Tag = "Customise"
        Me.chkCustomise.Text = "Customise"
        Me.chkCustomise.UseVisualStyleBackColor = True
        '
        'dlgDescribeOneVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 281)
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.chkCustomise)
        Me.Controls.Add(Me.ucrSelectorDescribeOneVar)
        Me.Controls.Add(Me.ucrReceiverDescribeOneVar)
        Me.Controls.Add(Me.ucrBaseDescribeOneVar)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeOneVariable"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Describe_One_Variable"
        Me.Text = "Describe One Variable"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrBaseDescribeOneVar As ucrButtons
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents ucrReceiverDescribeOneVar As ucrReceiverMultiple
    Friend WithEvents ucrSelectorDescribeOneVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkCustomise As CheckBox
End Class