<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMerge
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgMerge))
        Me.grpJoinType = New System.Windows.Forms.GroupBox()
        Me.rdoAntiJoin = New System.Windows.Forms.RadioButton()
        Me.rdoSemiJoin = New System.Windows.Forms.RadioButton()
        Me.rdoRightJoin = New System.Windows.Forms.RadioButton()
        Me.rdoLeftJoin = New System.Windows.Forms.RadioButton()
        Me.rdoFullJoin = New System.Windows.Forms.RadioButton()
        Me.rdoInnerJoin = New System.Windows.Forms.RadioButton()
        Me.ttJoinDetails = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrSubBase = New instat.ucrButtonsSubdialogue()
        Me.grpJoinType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpJoinType
        '
        Me.grpJoinType.Controls.Add(Me.rdoAntiJoin)
        Me.grpJoinType.Controls.Add(Me.rdoSemiJoin)
        Me.grpJoinType.Controls.Add(Me.rdoRightJoin)
        Me.grpJoinType.Controls.Add(Me.rdoLeftJoin)
        Me.grpJoinType.Controls.Add(Me.rdoFullJoin)
        Me.grpJoinType.Controls.Add(Me.rdoInnerJoin)
        Me.grpJoinType.Location = New System.Drawing.Point(12, 21)
        Me.grpJoinType.Name = "grpJoinType"
        Me.grpJoinType.Size = New System.Drawing.Size(106, 166)
        Me.grpJoinType.TabIndex = 26
        Me.grpJoinType.TabStop = False
        Me.grpJoinType.Text = "Join Type"
        '
        'rdoAntiJoin
        '
        Me.rdoAntiJoin.AutoSize = True
        Me.rdoAntiJoin.Location = New System.Drawing.Point(6, 140)
        Me.rdoAntiJoin.Name = "rdoAntiJoin"
        Me.rdoAntiJoin.Size = New System.Drawing.Size(65, 17)
        Me.rdoAntiJoin.TabIndex = 29
        Me.rdoAntiJoin.TabStop = True
        Me.rdoAntiJoin.Text = "Anti Join"
        Me.ttJoinDetails.SetToolTip(Me.rdoAntiJoin, "Include all rows from the 1st data frame where there are not matching values in t" &
        "he second data frame, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "keeping just columns from the first data frame.")
        Me.rdoAntiJoin.UseVisualStyleBackColor = True
        '
        'rdoSemiJoin
        '
        Me.rdoSemiJoin.AutoSize = True
        Me.rdoSemiJoin.Location = New System.Drawing.Point(6, 116)
        Me.rdoSemiJoin.Name = "rdoSemiJoin"
        Me.rdoSemiJoin.Size = New System.Drawing.Size(70, 17)
        Me.rdoSemiJoin.TabIndex = 28
        Me.rdoSemiJoin.TabStop = True
        Me.rdoSemiJoin.Text = "Semi Join"
        Me.ttJoinDetails.SetToolTip(Me.rdoSemiJoin, resources.GetString("rdoSemiJoin.ToolTip"))
        Me.rdoSemiJoin.UseVisualStyleBackColor = True
        '
        'rdoRightJoin
        '
        Me.rdoRightJoin.AutoSize = True
        Me.rdoRightJoin.Location = New System.Drawing.Point(6, 92)
        Me.rdoRightJoin.Name = "rdoRightJoin"
        Me.rdoRightJoin.Size = New System.Drawing.Size(72, 17)
        Me.rdoRightJoin.TabIndex = 27
        Me.rdoRightJoin.TabStop = True
        Me.rdoRightJoin.Text = "Right Join"
        Me.ttJoinDetails.SetToolTip(Me.rdoRightJoin, resources.GetString("rdoRightJoin.ToolTip"))
        Me.rdoRightJoin.UseVisualStyleBackColor = True
        '
        'rdoLeftJoin
        '
        Me.rdoLeftJoin.AutoSize = True
        Me.rdoLeftJoin.Location = New System.Drawing.Point(6, 20)
        Me.rdoLeftJoin.Name = "rdoLeftJoin"
        Me.rdoLeftJoin.Size = New System.Drawing.Size(65, 17)
        Me.rdoLeftJoin.TabIndex = 16
        Me.rdoLeftJoin.TabStop = True
        Me.rdoLeftJoin.Text = "Left Join"
        Me.ttJoinDetails.SetToolTip(Me.rdoLeftJoin, resources.GetString("rdoLeftJoin.ToolTip"))
        Me.rdoLeftJoin.UseVisualStyleBackColor = True
        '
        'rdoFullJoin
        '
        Me.rdoFullJoin.AutoSize = True
        Me.rdoFullJoin.Location = New System.Drawing.Point(6, 44)
        Me.rdoFullJoin.Name = "rdoFullJoin"
        Me.rdoFullJoin.Size = New System.Drawing.Size(63, 17)
        Me.rdoFullJoin.TabIndex = 14
        Me.rdoFullJoin.TabStop = True
        Me.rdoFullJoin.Text = "Full Join"
        Me.ttJoinDetails.SetToolTip(Me.rdoFullJoin, "Include all rows and all columns from both data frames." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Where there are not matc" &
        "hing values, NAs are used for the one missing.")
        Me.rdoFullJoin.UseVisualStyleBackColor = True
        '
        'rdoInnerJoin
        '
        Me.rdoInnerJoin.AutoSize = True
        Me.rdoInnerJoin.Location = New System.Drawing.Point(6, 68)
        Me.rdoInnerJoin.Name = "rdoInnerJoin"
        Me.rdoInnerJoin.Size = New System.Drawing.Size(71, 17)
        Me.rdoInnerJoin.TabIndex = 12
        Me.rdoInnerJoin.TabStop = True
        Me.rdoInnerJoin.Text = "Inner Join"
        Me.ttJoinDetails.SetToolTip(Me.rdoInnerJoin, resources.GetString("rdoInnerJoin.ToolTip"))
        Me.rdoInnerJoin.UseVisualStyleBackColor = True
        '
        'ttJoinDetails
        '
        Me.ttJoinDetails.AutoPopDelay = 10000
        Me.ttJoinDetails.InitialDelay = 500
        Me.ttJoinDetails.ReshowDelay = 100
        '
        'ucrSubBase
        '
        Me.ucrSubBase.Location = New System.Drawing.Point(12, 212)
        Me.ucrSubBase.Name = "ucrSubBase"
        Me.ucrSubBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubBase.TabIndex = 0
        '
        'sdgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(171, 244)
        Me.Controls.Add(Me.grpJoinType)
        Me.Controls.Add(Me.ucrSubBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "sdgMerge"
        Me.grpJoinType.ResumeLayout(False)
        Me.grpJoinType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
    Friend WithEvents grpJoinType As GroupBox
    Friend WithEvents rdoFullJoin As RadioButton
    Friend WithEvents rdoInnerJoin As RadioButton
    Friend WithEvents rdoAntiJoin As RadioButton
    Friend WithEvents ttJoinDetails As ToolTip
    Friend WithEvents rdoSemiJoin As RadioButton
    Friend WithEvents rdoRightJoin As RadioButton
    Friend WithEvents rdoLeftJoin As RadioButton
End Class
